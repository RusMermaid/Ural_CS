namespace UralMathFsharpLib.Units

open System

/// <category>Other</category>
/// <summary>
/// A static class providing added features to the floating point number class.
/// </summary>
///
/// <remark>
/// <para>
/// A static class providing added features to the floating point number class.
/// The main features of this class allow for better floating point equality
/// testing. Generally, floating points always have small variations in their
/// values because the way that floating point numbers are encoded. It is often
/// useful to do equality comparison checks between floating point numbers in a
/// variety of contexts. There are two main ways of doing this type of
/// comparison. The first is to use a percentage tolerance between two numbers,
/// eg. Two floating point numbers are equal if they are within 0.01% of each
/// other. Another is to compare if the two numbers are within an absolute range
/// from each other, eg. Two floating point numbers are equal if they are within
/// 0.0001 units of each other.
/// </para>
///
/// <para>
/// This library does comparison by absolute value comparison through digit
/// precision. Numbers are considered equal if they are equal when rounded to
/// the number of digits as specified by <c>Float.DigitPrecision</c>.
/// The default is 10 digits, so by default <c>2.0 = 2.00000000003</c> (the 11th digit is a 3).
/// </para>
///
/// <para>
/// <c>Float.Epsilon</c> is a derived value from the number of digits and represents
/// the maximum difference between two numbers that is considered equal. This
/// number is <c>10^-(DigitPrecision)</c> which by default is <c>10^(-10)</c>, or
/// <c>0.000000001</c>.
/// </para>
///
/// <para>
/// In general the rules followed by this extension are from
/// <a href="https://floating-point-gui.de/errors/comparison/">The Floating Point Guide on Comparison</a>
/// </para>
/// </remark>
[<AbstractClass; Sealed>]
type Float private () =
    static let mutable digitPrecision = 10

    /// The smallest number that a 64-bit floating point number can accurately
    /// represent. Values lower than this may not have the expected results in
    /// some operations. This number is needed to handle the special case of
    /// trying to compare two numbers that are really close to zero.
    static member MinNormal = 10e-38

    /// The number of digits (in base 10) that are used for approximate equality tests.
    static member DigitPrecision
        with get () = digitPrecision
        and set v = digitPrecision <- v

    static member Epsilon =
        10. ** (float -Float.DigitPrecision)

/// <category>Other</category>
module Float =

    /// Compare two floating point values for equality. Equality testing is done
    /// based on a tolerance vale specified by <c>Float.Epsilon</c>.
    let almostEqual (a: float) (b: float) : bool =
        if a = b || Double.IsNaN a && Double.IsNaN b then
            true
        else
            let absA = abs a
            let absB = abs b
            let diff = abs (a - b)

            if (a = 0. || b = 0. || absA + absB < Float.MinNormal) then
                diff < Float.Epsilon
            else

                let divisor =
                    min (absA + absB) Microsoft.FSharp.Core.float.MaxValue

                diff / divisor <= (Float.Epsilon * 1.5)

    /// Round a floating point number to a specified number of digits.
    let roundFloatTo (digits: int) (x: float) = Math.Round(x, digits)


    /// Round a floating point number to the number of digits specified by
    /// <c>Float.DigitPrecision</c>. By default, this rounds a floating point value
    /// to 10 digits.
    let roundFloat (x: float) = roundFloatTo Float.DigitPrecision x


    /// <summary>
    /// Interpolate from the first value to the second, based on a parameter
    /// that ranges from zero to one. Passing a parameter value of zero will
    /// return the start value and passing a parameter value of one will return
    /// the end value.
    ///
    /// <example><code lang="fsharp">
    ///     Float.interpolateFrom 5 10 0
    ///     // 5
    ///     Float.interpolateFrom 5 10 1
    ///     // 10
    ///     Float.interpolateFrom 5 10 0.6
    ///     // 8
    /// </code></example>
    ///
    /// <example>
    /// The end value can be less than the start value:
    /// <code lang="fsharp">
    ///     Float.interpolateFrom 10 5 0.1
    ///     // 9.5
    /// </code>
    /// </example>
    ///
    /// <example>
    /// Parameter values less than zero or greater than one can be used to
    /// extrapolate:
    /// <code lang="fsharp">
    ///     Float.interpolateFrom 5 10 1.5
    ///     // 12.5
    ///     Float.interpolateFrom 5 10 -0.5
    ///     // 2.5
    ///     Float.interpolateFrom 10 5 -0.2
    ///     // 11
    /// </code>
    /// </example>
    /// </summary>
    let interpolateFrom (start: float) (finish: float) (parameter: float) : float =
        if parameter <= 0.5 then
            start + parameter * (finish - start)

        else
            finish + (1. - parameter) * (start - finish)
