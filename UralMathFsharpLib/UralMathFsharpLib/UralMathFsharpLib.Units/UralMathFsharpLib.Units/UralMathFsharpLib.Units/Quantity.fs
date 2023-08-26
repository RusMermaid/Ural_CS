/// <category>Module: Unit System</category>
[<AutoOpen>]
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Quantity

open System

/// <category>Module: Unit System</category>
/// <summary>
/// Quantity of any floating point value. This structure is represented as a
/// class so that all these functions can be inherited by the type alias.
/// This allows easy access to all of the base quantity functionality without
/// having to write any wrapper functions. This is achieved by creating a type alias,
/// in this example using a length or distance represented in meters <c>type
/// Length = Quantity<Meters></c>. If you would like to extend the <c>Length</c> type you can
/// just create a <c>Length</c> module and add any extension functions there.
/// </summary>
type Quantity<'Units> with

    /// <category>Unitless</category>
    /// <summary>
    /// Create a unitless quantity. Unitless quantities must use the unitless
    /// functions in this module to avoid accumulating unit ratios. Using
    /// the functions within this module maintains the <c>Unitless</c> type.
    /// </summary>
    static member unitless value : Quantity<Unitless> = Quantity value

    /// <category>Constants</category>
    /// <summary>
    /// A generic zero value. This can be treated as a quantity in any
    /// units type, similar to how <c>None</c> can be treated as any kind
    /// of <c>Option</c> type and <c>[]</c> can be treated as any kind of <c>List</c>.
    /// </summary>
    static member zero: Quantity<'Units> =
        Quantity LanguagePrimitives.GenericZero


    /// <category>Constants</category>
    /// A generic positive infinity value.
    static member positiveInfinity: Quantity<'Units> =
        Quantity Double.PositiveInfinity


    /// <category>Constants</category>
    /// <summary>
    /// Alias for <c>Quantity.positiveInfinity</c>.
    /// </summary>
    static member infinity: Quantity<'Units> =
        Quantity.positiveInfinity


    /// <category>Constants</category>
    /// <summary>
    /// A generic negative infinity value.
    /// </summary>
    static member negativeInfinity: Quantity<'Units> =
        Quantity Double.NegativeInfinity

    // ---- Unsafe Operations ------------------------------------------------------

    /// <category>Conversions</category>
    /// This function allows you to create a quantity of any value and type.
    /// This should only try to use in library functions. This does however
    /// let you create units of generic types and types that are compiler
    /// defined instead of user defined.
    static member create<'Units> value : Quantity<'Units> = Quantity value


    /// <category>Conversions</category>
    /// This function provides access to the floating point value represented by
    /// the quantity. This should only try to use in library functions.
    static member unwrap(quantity: Quantity<'Units>) : float = quantity.Value



    // --- Comparison --------------------------------------------------------------


    /// <category>Operators</category>
    /// <summary>
    /// Check if one quantity is less than another. Note the <b>argument order!</b>
    ///
    /// <example>
    /// <code lang="fsharp">
    ///     let oneMeter =
    ///         Length.meters 1
    ///
    ///     Length.feet 1 |&gt; Quantity.lessThan oneMeter
    ///     --&gt; True
    ///
    ///     // Is the same as:
    ///     Quantity.lessThan oneMeter (Length.feet 1)
    ///     --&gt; True
    ///
    /// </code>
    /// </example>
    ///
    /// <example>
    /// <code lang="fsharp">
    ///     List.filter (Quantity.lessThan oneMeter)
    ///         [ Length.feet 1
    ///           Length.parsecs 1
    ///           Length.yards 1
    ///           Length.lightYears 1
    ///         ]
    ///     --&gt; [ Length.feet 1; Length.yards 1 ]
    /// </code>
    /// </example>
    /// </summary>
    static member lessThan (y: Quantity<'Units>) (x: Quantity<'Units>) : bool = x < y


    /// <category>Operators</category>
    /// <summary>
    /// Check if one quantity is greater than another. Note the <b>argument order!</b>
    /// <example><code lang="fsharp">
    ///    oneMeter =
    ///        Length.meters 1
    ///    Length.feet 1 |&gt; Quantity.greaterThan oneMeter
    ///    // --&gt; False
    ///
    ///    // Same as:
    ///    Quantity.greaterThan oneMeter (Length.feet 1)
    ///    // --&gt; False
    ///    List.filter (Quantity.greaterThan oneMeter)
    ///        [ Length.feet 1
    ///        , Length.parsecs 1
    ///        , Length.yards 1
    ///        , Length.lightYears 1
    ///        ]
    ///    --&gt; [ Length.parsecs 1, Length.lightYears 1 ]
    /// </code></example>
    /// </summary>
    static member greaterThan (y: Quantity<'Units>) (x: Quantity<'Units>) : bool = x > y


    /// <category>Operators</category>
    /// <summary>
    /// Check if one quantity is less than or equal to another. Note the <b>argument
    /// order!</b>
    /// </summary>
    static member lessThanOrEqualTo (y: Quantity<'Units>) (x: Quantity<'Units>) : bool = x <= y


    /// <category>Operators</category>
    /// <summary>
    /// Check if one quantity is greater than or equal to another. Note the
    /// <b>argument order!</b>
    /// </summary>
    static member greaterThanOrEqualTo (y: Quantity<'Units>) (x: Quantity<'Units>) : bool = x >= y


    /// <category>Operators</category>
    /// <summary>
    /// Short form for <c>Quantity.lessThan Quantity.zero</c>.
    /// </summary>
    static member lessThanZero(x: Quantity<'Units>) : bool =
        x < Quantity LanguagePrimitives.GenericZero


    /// <category>Operators</category>
    /// <summary>
    /// Short form for <c>Quantity.greaterThan Quantity.zero</c>.
    /// </summary>
    static member greaterThanZero(x: Quantity<'Units>) : bool =
        x > Quantity LanguagePrimitives.GenericZero


    /// <category>Operators</category>
    /// <category>Operators</category>
    /// <summary>
    /// Short form for <c>Quantity.lessThanOrEqualTo Quantity.zero</c>.
    /// </summary>
    static member lessThanOrEqualToZero(x: Quantity<'Units>) : bool =
        x <= Quantity LanguagePrimitives.GenericZero


    /// <category>Operators</category>
    /// <summary>
    /// Short form for <c>Quantity.greaterThanOrEqualTo Quantity.zero</c>.
    /// </summary>
    static member greaterThanOrEqualToZero(x: Quantity<'Units>) : bool =
        x >= Quantity LanguagePrimitives.GenericZero


    /// <category>Operators</category>
    /// <summary>
    /// Compare two quantities, returning an int value indicating whether
    /// the first is less than, equal to or greater than the second.
    /// Greater than = 1, Less than = -1, Equal to = 0
    /// </summary>
    ///
    /// <example><code lang="fsharp">
    ///     Quantity.compare
    ///         (Duration.minutes 90)
    ///         (Duration.hours 1)
    ///     --&gt; 1
    ///     Quantity.compare
    ///         (Duration.minutes 60)
    ///         (Duration.hours 1)
    ///     --&gt; 0
    ///     Quantity.compare
    ///         (Duration.minutes 45)
    ///         (Duration.hours 1)
    ///     --&gt; -1
    /// </code></example>
    static member compare (x: Quantity<'Units>) (y: Quantity<'Units>) : int = x.Comparison(y)


    /// <category>Operators</category>
    /// <summary>
    /// Check if two quantities are equal within a given absolute tolerance. The
    /// given tolerance must be greater than or equal to zero - if it is negative, then
    /// the result will always be false.
    /// </summary>
    ///
    /// <example><code lang="fsharp">
    ///     // 3 feet is 91.44 centimeters or 0.9144 meters
    ///     Quantity.equalWithin (Length.centimeters 10)
    ///         (Length.meters 1)
    ///         (Length.feet 3)
    ///     --&gt; True
    ///     Quantity.equalWithin (Length.centimeters 5)
    ///         (Length.meters 1)
    ///         (Length.feet 3)
    ///     --&gt; False
    /// </code></example>
    static member equalWithin (tolerance: Quantity<'Units>) (x: Quantity<'Units>) (y: Quantity<'Units>) : bool =
        abs (x - y) <= abs tolerance
        
        
    /// <category>Math</category>
    /// <summary>
    ///     Get the absolute value of a quantity.
    /// </summary>
    ///
    /// <example>
    /// <para>
    /// This function can be called from the global function or the module
    /// function. They both return the same result
    /// </para>
    /// <code>
    ///     abs quantity = Units.abs quantity
    /// </code>
    /// 
    /// <code>
    ///     Quantity.abs (Duration.milliseconds -10)
    ///     --&gt; Duration.milliseconds 10
    /// </code>
    /// </example>
    static member abs(quantity: Quantity<'Units>) : Quantity<'Units> = Quantity.Abs quantity


    /// <category>Math</category>
    /// <summary>
    /// Find the maximum of two quantities.
    /// </summary>
    ///
    /// <example><code lang="fsharp">
    ///    Quantity.max (Duration.hours 2) (Duration.minutes 100)
    ///    --&gt; Duration.hours 2
    /// </code></example>
    static member max (x: Quantity<'Units>) (y: Quantity<'Units>) : Quantity<'Units> = max x y


    /// <category>Math</category>
    /// <summary>
    /// Find the minimum of two quantities.
    /// </summary>
    ///
    /// <example><code lang="fsharp">
    ///    Quantity.min (Duration.hours 2) (Duration.minutes 100)
    ///    --&gt; Duration.minutes 100
    /// </code></example>
    static member min (x: Quantity<'Units>) (y: Quantity<'Units>) : Quantity<'Units> = min x y


    /// <category>Accessors</category>
    /// <summary>
    /// Check if a quantity is positive or negative infinity.
    /// </summary>
    ///
    /// <example><code lang="fsharp">
    ///    Quantity.isInfinite
    ///        (Length.meters 1
    ///            |&gt; Quantity.per (Duration.seconds 0)
    ///        )
    ///    --&gt; True
    ///    Quantity.isInfinite Quantity.negativeInfinity
    ///    --&gt; True
    /// </code></example>
    static member isInfinite(quantity: Quantity<'Units>) : bool = Double.IsInfinity quantity.Value


    /// <category>Accessors</category>
    /// <summary>
    /// Check if a quantity's underlying value is NaN (not-a-number).
    /// </summary>
    ///
    /// <example><code lang="fsharp">
    ///    Quantity.isNan (Quantity.sqrt (Area.squareMeters -4))
    ///    --&gt; True
    ///    Quantity.isNan (Quantity.sqrt (Area.squareMeters 4))
    ///    --&gt; False
    /// </code></example>
    static member isNaN(quantity: Quantity<'Units>) : bool = Double.IsNaN quantity.Value



    // ---- Arithmetic -------------------------------------------------------------


    /// <category>Operators</category>
    /// <summary>
    /// Negate a quantity
    /// </summary>
    ///
    /// <example><code lang="fsharp">
    ///    Quantity.negate (Length.millimeters 10)
    ///    --&gt; Length.millimeters -10
    /// </code></example>
    static member negate(value: Quantity<'Units>) : Quantity<'Units> = -value


    /// <category>Operators</category>
    /// <summary>
    /// Add two quantities.
    /// </summary>
    ///
    /// <example><code lang="fsharp">
    ///    Length.meters 1 |&gt; Quantity.plus (Length.centimeters 5)
    ///    --&gt; Length.centimeters 105
    /// </code></example>
    static member plus (y: Quantity<'Units>) (x: Quantity<'Units>) : Quantity<'Units> = x + y


    /// <category>Operators</category>
    /// <summary>
    /// Subtract one quantity from another.
    /// </summary>
    ///
    /// <example><code lang="fsharp">
    ///    Quantity.difference
    ///        (Duration.hours 1)
    ///        (Duration.minutes 15)
    ///    --&gt; Duration.minutes 45
    /// </code></example>
    static member difference (x: Quantity<'Units>) (y: Quantity<'Units>) : Quantity<'Units> = x - y


    /// <category>Operators</category>
    /// <summary>
    /// An 'infix' version of <c>difference</c>, intended to be used in
    /// pipeline form;
    /// <code lang="fsharp">
    ///     Quantity.difference x y
    /// </code>
    /// can be written as
    /// <code lang="fsharp">
    ///     x |&gt; Quantity.minus y
    /// </code>
    /// </summary>
    /// 
    /// <note>
    /// Note that unlike <c>difference</c>, this also means that partial application will 'do
    /// the right thing':
    /// <code lang="fsharp">
    ///     List.map (Quantity.minus fifteenMinutes)
    ///         [ Duration.hours 1
    ///         , Duration.hours 2
    ///         , Duration.minutes 30
    ///         ]
    ///     --&gt; [ Duration.minutes 45
    ///     --&gt; , Duration.minutes 105
    ///     --&gt; , Duration.minutes 15
    ///     --&gt; ]
    /// </code>
    /// </note>
    static member minus (y: Quantity<'Units>) (x: Quantity<'Units>) : Quantity<'Units> = x - y


    /// <category>Operators</category>
    /// <summary>
    /// Multiply two quantities with units types <c>units1</c> and <c>units2</c> together,
    /// resulting in a quantity with units type <c>Product units1 units2</c>.
    /// This works for any two units types, but one special case is worth pointing out.
    /// The units type of an [<c>Area</c>](Area) is <c>SquareMeters</c>, which is a type alias for
    /// <c>Squared Meters</c>, which in turn expands to <c>Product Meters Meters</c>. This means
    /// that the product of two <c>Length</c>s does in fact give you an <c>Area</c>:
    /// <code lang="fsharp">
    ///     // This is the definition of an acre, I kid you not 😈
    ///     Quantity.product (Length.feet 66) (Length.feet 660)
    ///     --&gt; Area.acres 1
    /// </code>
    /// We can also multiply an <c>Area</c> by a <c>Length</c> to get a <c>Volume</c>:
    /// <code lang="fsharp">
    ///     Quantity.product
    ///         (Area.squareMeters 1)
    ///         (Length.centimeters 1)
    ///     --&gt; Volume.liters 10
    /// </code>
    /// </summary>
    ///
    /// <note>There are other forms of multiplication</note>

    static member product (x: Quantity<'Units>) (y: Quantity<'Units>) = x * y


    /// <category>Operators</category>
    /// <summary>
    /// An 'infix' version of <c>product</c>, intended to be used in pipeline
    /// form;
    /// <code lang="fsharp">
    ///     Quantity.product a b
    /// </code>
    /// can be written as
    /// <code lang="fsharp">
    ///     a |&gt; Quantity.times b
    /// </code>
    /// </summary>
    static member times (y: Quantity<'Units>) (x: Quantity<'Units>) = x * y


    /// <category>Unitless</category>
    /// <summary>
    /// If you use <c>times</c>) or product to multiply one
    /// quantity by another <c>Unitless</c> quantity, for example
    /// <code lang="fsharp">
    ///     quantity |&gt; Quantity.times unitlessQuantity
    /// </code>
    /// then the result you'll get will have units type <c>Product units Unitless</c>. But
    /// this is silly and not super useful, since the product of <c>units</c> and <c>Unitless</c>
    /// should really just be <c>units</c>. That's what <c>timesUnitless</c> does - it's a special
    /// case of <c>times</c> for when you're multiplying by another unitless quantity, that
    /// leaves the units alone.
    /// You can think of <c>timesUnitless</c> as shorthand for <c>toFloat</c> and <c>multiplyBy</c>;
    /// for <c>Float</c>-valued quantities,
    /// <code lang="fsharp">
    ///     quantity |&gt; Quantity.timesUnitless unitlessQuantity
    /// </code>
    /// is equivalent to
    /// <code lang="fsharp">
    ///     quantity
    ///         |&gt; Quantity.multiplyBy
    ///             (Quantity.toFloat unitlessQuantity)
    /// </code>
    /// </summary>
    static member timesUnitless (y: Quantity<Unitless>) (x: Quantity<Unitless>) : Quantity<Unitless> =
        Quantity(x.Value * y.Value)


    /// <category>Operators</category>
    /// <summary>
    /// Divide a quantity in <c>Product units1 units2</c> by a quantity in <c>units1</c>,
    /// resulting in another quantity in <c>units2</c>. For example, the units type of a
    /// <c>Force</c> is <c>Product Kilograms MetersPerSecondSquared</c> (mass times acceleration),
    /// so we could divide a force by a given mass to determine how fast that mass would
    /// be accelerated by the given force:
    /// <code lang="fsharp">
    ///     Force.newtons 100
    ///         |&gt; Quantity.over
    ///             (Mass.kilograms 50)
    ///     --&gt; Acceleration.metersPerSecondSquared 2
    /// </code>
    /// </summary>
    /// <note>There are other forms of division.</note>
    static member over (y: Quantity<'U1>) (x: Quantity<Product<'U1, 'U2>>) : Quantity<'U2> = Quantity(x.Value / y.Value)


    /// <category>Operators</category>
    /// <summary>
    /// Just like <c>over</c> but divide by a quantity in <c>units2</c>, resulting in another
    /// quantity in <c>units1</c>. For example, we could divide a force by a desired
    /// acceleration to determine how much mass could be accelerated at that rate:
    /// <code lang="fsharp">
    ///     Force.newtons 100
    ///         |&gt; Quantity.over_
    ///             (Acceleration.metersPerSecondSquared 5)
    ///     --&gt; Mass.kilograms 20
    /// </code>
    /// </summary>
    static member over_ (y: Quantity<'U2>) (x: Quantity<Product<'U1, 'U2>>) : Quantity<'U1> =
        Quantity(x.Value / y.Value)


    /// <category>Unitless</category>
    /// <summary>
    /// Similar to <c>timesUnitless</c>, <c>overUnitless</c> lets you
    /// divide one quantity by a second [unitless](#Unitless) quantity without affecting
    /// the units;
    /// <code lang="fsharp">
    ///     quantity |&gt; Quantity.overUnitless unitlessQuantity
    /// </code>
    /// is equivalent to
    /// <code lang="fsharp">
    ///     quantity
    ///         |&gt; Quantity.divideBy
    ///             (Quantity.toFloat unitlessQuantity)
    /// </code>
    /// </summary>
    static member overUnitless (y: Quantity<Unitless>) (x: Quantity<Unitless>) : Quantity<Unitless> = Quantity(x / y)


    /// <category>Operators</category>
    /// <summary>
    /// Find the ratio of two quantities with the same units.
    /// <code lang="fsharp">
    ///    Quantity.ratio (Length.miles 1) (Length.yards 1)
    ///    --&gt; 1760
    /// </code>
    /// </summary>
    static member ratio (x: Quantity<'Units>) (y: Quantity<'Units>) : float = x / y


    /// <category>Operators</category>
    /// <summary>
    /// Scale a <c>Quantity</c> by a <c>number</c>.
    /// <code lang="fsharp">
    ///     Quantity.multiplyBy 1.5 (Duration.hours 1)
    ///     --&gt; Duration.minutes 90
    /// </code>
    /// </summary>
    /// <note>There are other forms of multiplication</note>
    static member multiplyBy (scale: float) (quantity: Quantity<'Units>) : Quantity<'Units> =
        Quantity(scale * quantity.Value)


    /// <category>Operators</category>
    /// <summary>
    /// Divide a <c>Quantity</c> by a <c>Float</c>.
    /// </summary>
    /// <code lang="fsharp">
    ///     Quantity.divideBy 2 (Duration.hours 1)
    ///     --&gt; Duration.minutes 30
    /// </code>
    /// <note>There are other forms of division</note>
    static member divideBy (divisor: float) (quantity: Quantity<'Units>) : Quantity<'Units> =
        Quantity(quantity.Value / divisor)


    /// <category>Modifiers</category>
    /// <summary>
    /// Convenient shorthand for <c>Quantity.multiplyBy 2</c>.
    /// <code lang="fsharp">
    ///    Quantity.twice (Duration.minutes 30)
    ///    --&gt; Duration.hours 1
    /// </code>
    /// </summary>
    static member twice(quantity: Quantity<'Units>) : Quantity<'Units> = 2. * quantity


    /// <category>Modifiers</category>
    /// <summary>
    /// Convenient shorthand for <c>Quantity.multiplyBy 0.5</c>.
    /// <code lang="fsharp">
    ///    Quantity.half (Length.meters 1)
    ///    --&gt; Length.centimeters 50
    /// </code>
    /// </summary>
    static member half(quantity: Quantity<'Units>) : Quantity<'Units> = 0.5 * quantity

    /// <category>Modifiers</category>
    /// <summary>
    /// Given a lower and upper bound, clamp a given quantity to within those
    /// bounds. Say you wanted to clamp an angle to be between +/-30 degrees:
    /// <code lang="fsharp">
    ///     let lowerBound =
    ///         Angle.degrees -30
    ///     let upperBound =
    ///         Angle.degrees 30
    ///     Quantity.clamp lowerBound upperBound (Angle.degrees 5)
    ///     --&gt; Angle.degrees 5
    ///     -- One radian is approximately 57 degrees
    ///     Quantity.clamp lowerBound upperBound (Angle.radians 1)
    ///     --&gt; Angle.degrees 30
    ///     Quantity.clamp lowerBound upperBound (Angle.turns -0.5)
    ///     --&gt; Angle.degrees -30
    /// </code>
    /// </summary>
    static member clamp (lower: Quantity<'Units>) (upper: Quantity<'Units>) (quantity: Quantity<'Units>) =
        let clampHelper l u =
            if quantity.Value < lower.Value then
                l
            else if quantity.Value > upper.Value then
                u
            else
                quantity

        if lower <= upper then
            clampHelper lower upper
        else
            clampHelper upper lower

    /// <category>Modifiers</category>
    /// <summary>
    /// Square a quantity with some <c>units</c>, resulting in a new quantity in
    /// <c>Squared units</c>:
    /// <code lang="fsharp">
    ///     Quantity.squared (Length.meters 5)
    ///     --&gt; Area.squareMeters 25
    /// See also <c>Quantity.squaredUnitless</c>.
    /// </code>
    /// </summary>
    static member squared(quantity: Quantity<'Units>) : Quantity<'Units Squared> = quantity * quantity


    /// <category>Unitless</category>
    static member squaredUnitless(quantity: Quantity<Unitless>) : Quantity<Unitless> =
        Quantity(quantity.Value * quantity.Value)

    /// <category>Unitless</category>
    static member sqrtUnitless(quantity: Quantity<Unitless>) : Quantity<Unitless> = Quantity(sqrt quantity.Value)

    /// <category>Modifiers</category>
    /// <summary>
    /// Take a quantity in <c>Squared units</c> and return the square root of that
    /// quantity in plain <c>units</c>:
    /// <code lang="fsharp">
    ///     Quantity.sqrt (Area.hectares 1)
    ///     --&gt; Length.meters 100
    /// </code>
    /// Getting fancier, you could write a 2D hypotenuse (magnitude) function that
    /// worked on <b>any</b> quantity type (length, speed, force...) as
    /// <code lang="fsharp">
    ///     hypotenuse :
    ///         Quantity Float units
    ///         -> Quantity Float units
    ///         -> Quantity Float units
    ///     hypotenuse x y =
    ///         Quantity.sqrt
    ///             (Quantity.squared x
    ///                 |&gt; Quantity.plus
    ///                     (Quantity.squared y)
    ///             )
    /// </code>
    /// This works because:
    ///   - The <c>x</c> and <c>y</c> arguments are both in <c>units</c>
    ///   - So each squared item is in <c>Squared units</c>
    ///   - So the sum is also in <c>Squared units</c>
    ///   - And calling <c>sqrt</c> on something in <c>Squared units</c> returns a value back in
    ///     <c>units</c>
    /// See also <c>Quantity.sqrtUnitless</c>.
    /// </summary>
    static member sqrt(quantity: Quantity<'Units Squared>) = Quantity(sqrt quantity.Value)


    /// <category>Modifiers</category>
    /// <summary>
    /// Cube a quantity with some <c>units</c>, resulting in a new quantity in
    /// <c>Cubed units</c>.
    /// <code lang="fsharp">
    ///     Quantity.cubed (Length.meters 5)
    ///     --&gt; Volume.cubicMeters 125
    /// </code>
    /// See also <c>Quantity.cubedUnitless</c>.
    /// </summary>
    static member cubed(quantity: Quantity<'Units>) : Quantity<'Units Cubed> =
        Quantity(quantity.Value * quantity.Value * quantity.Value)


    /// <category>Unitless</category>
    static member cubedUnitless(quantity: Quantity<Unitless>) : Quantity<Unitless> =
        Quantity(quantity.Value * quantity.Value * quantity.Value)


    /// <category>Modifiers</category>
    static member unsafeCbrt(quantity: Quantity<'Units1>) : Quantity<'Units2> =
        if quantity.Value >= 0. then
            Quantity(Math.Pow(quantity.Value, (1. / 3.)))

        else
            Quantity(-(Math.Pow(-quantity.Value, (1. / 3.))))


    /// <category>Modifiers</category>
    /// <summary>
    /// Take a quantity in <c>Cubed units</c> and return the cube root of that
    /// quantity in plain <c>units</c>.
    /// <code lang="fsharp">
    ///     Quantity.cbrt (Volume.liters 1)
    ///     --&gt; Length.centimeters 10
    /// </code>
    /// See also <c>Quantity.cbrtUnitless</c>.
    /// </summary>
    static member cbrt(quantity: Quantity<'Units Cubed>) : Quantity<'Units> = Quantity.unsafeCbrt quantity


    /// <category>Unitless</category>
    static member cbrtUnitless(quantity: Quantity<Unitless>) : Quantity<Unitless> = Quantity.unsafeCbrt quantity


    /// <category>Modifiers</category>
    /// <summary>
    /// Find the inverse of a unitless quantity.
    /// <code lang="fsharp">
    ///    Quantity.reciprocal (Quantity.float 5)
    ///    --&gt; Quantity.float 0.2
    /// </code>
    /// </summary>
    static member reciprocal(quantity: Quantity<'Units>) : Quantity<'Units> = Quantity(1. / quantity.Value)


    
    /// <category>Modifiers</category>
    /// <summary>
    /// Returns the remainder of the modulus operation.
    /// </summary>
    /// <note>This returns negative results for remainders on negative numbers.</note>
    static member modBy (modulus: Quantity<'Units>) (quantity: Quantity<'Units>) : Quantity<'Units> = quantity % modulus


    /// <category>Modifiers</category>
    /// <summary>
    /// Returns the remainder of the modulus operation.
    /// </summary>
    /// <note>This returns positive results for remainders on negative numbers.</note>
    static member remainderBy (modulus: Quantity<'Units>) (quantity: Quantity<'Units>) : Quantity<'Units> =
        abs (quantity % modulus)


    /// <category>Queries</category>
    /// <summary>
    /// Interpolate from the first quantity to the second, based on a parameter that
    /// ranges from zero to one. Passing a parameter quantity of zero will return the start
    /// quantity and passing a parameter quantity of one will return the end quantity.
    /// <code lang="fsharp">
    ///     fiveMeters =
    ///         Length.meters 5
    ///     tenMeters =
    ///         Length.meters 10
    ///     Quantity.interpolateFrom fiveMeters tenMeters 0
    ///     --&gt; Length.meters 5
    ///     Quantity.interpolateFrom fiveMeters tenMeters 1
    ///     --&gt; Length.meters 10
    ///     Quantity.interpolateFrom fiveMeters tenMeters 0.6
    ///     --&gt; Length.meters 8
    /// </code>
    /// The end quantity can be less than the start quantity:
    /// <code lang="fsharp">
    ///     Quantity.interpolateFrom tenMeters fiveMeters 0.1
    ///     --&gt; Length.meters 9.5
    /// </code>
    /// Parameter quantitys less than zero or greater than one can be used to extrapolate:
    /// <code lang="fsharp">
    ///     Quantity.interpolateFrom fiveMeters tenMeters 1.5
    ///     --&gt; Length.meters 12.5
    ///     Quantity.interpolateFrom fiveMeters tenMeters -0.5
    ///     --&gt; Length.meters 2.5
    ///     Quantity.interpolateFrom tenMeters fiveMeters -0.2
    ///     --&gt; Length.meters 11
    /// </code>
    /// </summary>
    static member interpolateFrom
        (start: Quantity<'Units>)
        (finish: Quantity<'Units>)
        (parameter: float)
        : Quantity<'Units> =
        if parameter <= 0.5 then
            Quantity(
                start.Value
                + parameter * (finish.Value - start.Value)
            )

        else
            Quantity(
                finish.Value
                + (1. - parameter) * (start.Value - finish.Value)
            )


    /// <category>Queries</category>
    /// <summary>
    /// Find the midpoint between two quantities.
    /// <code lang="fsharp">
    ///    Quantity.midpoint (Length.meters 5) (Length.meters 10)
    ///    --&gt; Length.meters 7.5
    /// </code>
    /// </summary>
    static member midpoint (x: Quantity<'Units>) (y: Quantity<'Units>) : Quantity<'Units> = x + 0.5 * (y - x)


    /// <category>Queries</category>
    /// <summary>
    /// Construct a range of evenly-spaced quantitys given a <c>start</c> quantity, an <c>end</c>
    /// quantity and the number of <c>steps</c> to take from the start to the end. The first
    /// quantity in the returned list will be equal to <c>start</c> and the last quantity will be
    /// equal to <c>end</c>. Note that the number of returned quantitys will be one greater than
    /// the number of steps!
    /// </summary>
    ///
    /// <code lang="fsharp">
    ///     Quantity.range
    ///         { start = Length.meters 2
    ///         , end = Length.meters 3
    ///         , steps = 5
    ///         }
    ///     --&gt; [ Length.centimeters 200
    ///     --&gt;   Length.centimeters 220
    ///     --&gt;   Length.centimeters 240
    ///     --&gt;   Length.centimeters 260
    ///     --&gt;   Length.centimeters 280
    ///     --&gt;   Length.centimeters 300
    ///     --&gt; ]
    /// </code>
    ///
    /// The start and end quantitys can be in either order:
    /// 
    /// <code lang="fsharp">
    ///     Quantity.range
    ///         { start = Duration.hours 1
    ///         , end = Quantity.zero
    ///         , steps = 4
    ///         }
    ///     --&gt; [ Duration.minutes 60
    ///     --&gt;   Duration.minutes 45
    ///     --&gt;   Duration.minutes 30
    ///     --&gt;   Duration.minutes 15
    ///     --&gt;   Duration.minutes 0
    ///     --&gt; ]
    /// </code>
    /// 
    /// Passing a negative or zero <c>steps</c> quantity will result in an empty list being
    /// returned.
    /// If you need finer control over what quantitys get generated, try combining
    /// <c>interpolateFrom</c> with the various functions in the
    /// For example:
    /// 
    /// <code lang="fsharp">
    ///     // Same as using Quantity.range
    ///     Parameter1d.steps 4 
    ///         ( Quantity.interpolateFrom
    ///             (Length.meters 2)
    ///             (Length.meters 3) )
    ///     --&gt; [ Length.centimeters 200
    ///     --&gt;   Length.centimeters 225
    ///     --&gt;   Length.centimeters 250
    ///     --&gt;   Length.centimeters 275
    ///     --&gt;   Length.centimeters 300
    ///     --&gt; ]
    /// 
    ///     // Omit the last quantity
    ///     Parameter1d.leading 4
    ///         ( Quantity.interpolateFrom
    ///             (Length.meters 2)
    ///             (Length.meters 3) )
    ///     --&gt; [ Length.centimeters 200
    ///     --&gt;   Length.centimeters 225
    ///     --&gt;   Length.centimeters 250
    ///     --&gt;   Length.centimeters 275
    ///     --&gt; ]
    /// </code>
    static member range (start: Quantity<'Units>) (finish: Quantity<'Units>) (steps: int) : Quantity<'Units> list =
        let rec rangeHelp
            start
            finish
            (i: int)
            (steps: float)
            (accumulatedValues: Quantity<'Units> list)
            : Quantity<'Units> list =
            let quantity =
                Quantity.interpolateFrom start finish (float i / steps)

            let updatedValues =
                quantity :: accumulatedValues

            if i = 0 then
                updatedValues

            else
                rangeHelp start finish (i - 1) steps updatedValues

        if steps > 0 then
            rangeHelp start finish steps (float steps) []

        else
            []


    /// <category>Conversions</category>
    /// <summary>
    /// Generalized units conversion function that lets you convert to many kinds of
    /// units not directly supported by <c>elm-units</c>. The first argument is a function
    /// that constructs a quantity of the desired Unit System, and the second is the quantity
    /// to convert. For example,
    /// <code lang="fsharp">
    ///     Speed.metersPerSecond 5
    ///         |&gt; Speed.inFeetPerSecond
    ///     --&gt; 16.4042
    /// </code>
    /// is equivalent to
    /// <code lang="fsharp">
    ///     Speed.metersPerSecond 5
    ///         |&gt; Quantity.in_ Speed.feetPerSecond
    ///     --&gt; 16.4042
    /// </code>
    /// More interestingly, if you wanted to get speed in some weirder unit like
    /// millimeters per minute (not directly supported by <c>elm-units</c>), you could do
    /// <code lang="fsharp">
    ///     Speed.metersPerSecond 5
    ///         |&gt; Quantity.in_
    ///             (Length.millimeters
    ///                 >> Quantity.per (Duration.minutes 1)
    ///             )
    ///     --&gt; 300000
    /// </code>
    /// Internally,
    /// <code lang="fsharp">
    ///     Quantity.in_ someUnits someQuantity
    /// </code>
    /// is simply implemented as
    /// <code lang="fsharp">
    ///     Quantity.ratio some(someUnits 1)
    /// </code>
    /// </summary>
    static member in_ (units: float -> 'a) (quantity: Quantity<'Units>) : float = Quantity.ratio quantity (units 1.)


    // ---- Float Conversions ------------------------------------------------------------------------------------------

    /// <category>Modifiers</category>
    static member roundTo (digits: int) (quantity: Quantity<'Units>) : Quantity<'Units> =
        Quantity(Float.roundFloatTo digits quantity.Value)

    /// <category>Modifiers</category>
    /// <summary>
    /// Round a <c>Float</c>-valued quantity to the nearest <c>Int</c>. Note that [this may
    /// not do what you expect](#-int-float-conversion).
    /// <code lang="fsharp">
    ///     Quantity.round (Pixels.pixels 3.5)
    ///     --&gt; Pixels.pixels 4
    /// </code>
    /// </summary>
    static member round(quantity: Quantity<'Units>) : Quantity<'Units> = Quantity(round quantity.Value)


    /// <category>Modifiers</category>
    /// <summary>
    /// Round a <c>Float</c>-valued quantity down to the nearest <c>Int</c>. Note that [this
    /// may not do what you expect](#-int-float-conversion).
    /// <code lang="fsharp">
    ///     Quantity.floor (Pixels.pixels 2.9)
    ///     --&gt; Pixels.pixels 2
    ///     Quantity.floor (Pixels.pixels -2.1)
    ///     --&gt; Pixels.pixels -3
    /// </code>
    /// </summary>
    static member floor(quantity: Quantity<'Units>) : Quantity<'Units> = floor quantity


    /// <category>Modifiers</category>
    /// <summary>
    /// Round a <c>Float</c>-valued quantity up to the nearest <c>Int</c>.
    /// <code lang="fsharp">
    ///     Quantity.ceiling (Pixels.pixels 1.2)
    ///     --&gt; Pixels.pixels 2
    ///     Quantity.ceiling (Pixels.pixels -2.1)
    ///     --&gt; Pixels.pixels -2
    /// </code>
    /// </summary>
    /// <note>This may not do what you expect.</note>
    static member ceil(quantity: Quantity<'Units>) : Quantity<'Units> = ceil quantity

    /// <category>Modifiers</category>
    /// <summary>
    /// Round a <c>Float</c>-valued quantity towards zero.
    /// <code lang="fsharp">
    ///     Quantity.truncate (Pixels.pixels -2.8)
    ///     --&gt; Pixels.pixels -2
    /// </code>
    /// </summary>
    /// <note>This may not do what you expect.</note>
    static member truncate(quantity: Quantity<'Units>) : Quantity<'Units> = truncate quantity

    // ---- LIST FUNCTIONS ---------------------------------------------------------

    /// <category>List Functions</category>
    /// <summary>
    /// Find the sum of a list of quantities.
    /// <code lang="fsharp">
    ///    Quantity.sum
    ///        [ Length.meters 1
    ///        , Length.centimeters 2
    ///        , Length.millimeters 3
    ///        ]
    ///    --&gt; Length.meters 1.023
    ///    Quantity.sum []
    ///    --&gt; Quantity.zero
    /// </code>
    /// </summary>
    static member sum(quantities: Quantity<'Units> list) : Quantity<'Units> =
        List.fold Quantity.plus Quantity.zero quantities

    /// <category>List Functions</category>
    /// <summary>
    /// Find the minimum quantity in a list of quantities. Returns <c>None</c> if the
    /// list is empty.
    /// <code lang="fsharp">
    ///    Quantity.minimum
    ///        [ Mass.kilograms 1
    ///        , Mass.pounds 2
    ///        , Mass.tonnes 3
    ///        ]
    ///    --&gt; Some (Mass.pounds 2)
    /// </code>
    /// </summary>
    static member minimum(quantities: Quantity<'Units> list) : Quantity<'Units> option =
        match quantities with
        | [] -> None

        | first :: rest -> Some(List.fold min first rest)


    /// <category>List Functions</category>
    /// <summary>
    /// Find the maximum quantity in a list of quantities. Returns <c>None</c> if the
    /// list is empty.
    /// <code lang="fsharp">
    ///     Quantity.maximum
    ///         [ Mass.kilograms 1
    ///         , Mass.pounds 2
    ///         , Mass.tonnes 3
    ///         ]
    ///     --&gt; Some (Mass.tonnes 3)
    /// </code>
    /// </summary>
    static member maximum(quantities: Quantity<'Units> list) : Quantity<'Units> option =
        match quantities with
        | [] -> None

        | first :: rest -> Some(List.fold max first rest)


    /// <category>List Functions</category>
    /// <summary>
    /// Find the 'minimum' item in a list as measured by some derived <c>Quantity</c>:
    /// <code lang="fsharp">
    ///     let people =
    ///         [ { Name = "Bob", Height = Length.meters 1.6 }
    ///           { Name = "Charlie", Height = Length.meters 2.0 }
    ///           { Name = "Alice", Height = Length.meters 1.8 }
    ///         ]
    ///     Quantity.minimumBy (fun person -> person.Height) people
    ///     --&gt; Some { Name = "Bob"; Height = Length.meters 1.6 }
    /// </code>
    /// If the list is empty, returns <c>None</c>. If multiple items in the list are tied,
    /// then the first one is returned.
    /// </summary>
    static member minimumBy (toQuantity: 'a -> Quantity<'Units>) (quantities: 'a list) : 'a option =
        let rec minimumByHelp currentItem currentValue (currentQuantities: 'a list) =
            match currentQuantities with
            | [] -> currentItem

            | item :: rest ->
                let quantity = toQuantity item

                if quantity < currentValue then
                    minimumByHelp item quantity rest

                else
                    minimumByHelp currentItem currentValue rest

        match quantities with
        | [] -> None

        | firstItem :: rest ->
            let firstValue = toQuantity firstItem
            Some(minimumByHelp firstItem firstValue rest)




    /// <category>List Functions</category>
    /// <summary>
    /// Find the 'maximum' item in a list as measured by some derived <c>Quantity</c>:
    /// <code lang="fsharp">
    ///     let people =
    ///         [ { Name = "Bob", Height = Length.meters 1.6 }
    ///           { Name = "Charlie", Height = Length.meters 2.0 }
    ///           { Name = "Alice", Height = Length.meters 1.8 }
    ///         ]
    ///     Quantity.maximumBy (fun person -> person.Height) people
    ///     --&gt; Some { Name = "Charlie"; Height = Length.meters 2.0 }
    /// </code>
    /// If the list is empty, returns <c>None</c>. If multiple items in the list are tied,
    /// then the first one is returned.
    /// </summary>
    static member maximumBy (toQuantity: 'a -> Quantity<'Units>) (quantities: 'a list) : 'a option =
        let rec maximumByHelp currentItem currentValue (currentQuantities: 'a list) =
            match currentQuantities with
            | [] -> currentItem

            | item :: rest ->
                let quantity = toQuantity item

                if quantity < currentValue then
                    maximumByHelp item quantity rest

                else
                    maximumByHelp currentItem currentValue rest

        match quantities with
        | [] -> None

        | firstItem :: rest ->
            let firstValue = toQuantity firstItem
            Some(maximumByHelp firstItem firstValue rest)



    /// <category>List Functions</category>
    /// <summary>
    /// Sort a list of quantities.
    /// <code lang="fsharp">
    ///    Quantity.sort
    ///        [ Mass.kilograms 1
    ///          Mass.pounds 2
    ///          Mass.tonnes 3
    ///        ]
    ///    --&gt; [ Mass.pounds 2
    ///    --&gt;   Mass.kilograms 1
    ///    --&gt;   Mass.tonnes 3
    ///    --&gt; ]
    /// </code>
    /// </summary>
    static member sort(quantities: Quantity<'Units> list) : Quantity<'Units> list =
        List.sortBy Quantity.unwrap quantities


    /// <category>List Functions</category>
    /// <summary>
    /// Sort an arbitrary list of quantitys by a derived <c>Quantity</c>.
    /// </summary>
    ///
    /// <example>
    /// If you had
    /// <code lang="fsharp">
    ///     let people =
    ///         [ { Name = "Bob"; Height = Length.meters 1.6 }
    ///           { Name = "Charlie"; Height = Length.meters 2.0 }
    ///           { Name = "Alice"; Height = Length.meters 1.8 }
    ///         ]
    /// </code>
    /// then you could sort by Name with
    /// <code lang="fsharp">
    ///     List.sortBy (fun person -> person.Name) people
    ///     --&gt; [ { Name = "Alice"; Height = Length.meters 1.8 }
    ///     --&gt;   { Name = "Bob"; Height = Length.meters 1.6 }
    ///     --&gt;   { Name = "Charlie"; Height = Length.meters 2.0 }
    ///     --&gt; ]
    /// </code>
    /// (nothing new there!), and sort by Height with
    /// <code lang="fsharp">
    ///     Quantity.sortBy (fun person -> person.Height) people
    ///     --&gt; [ { Name = "Bob"; Height = Length.meters 1.6 }
    ///     --&gt;   { Name = "Alice"; Height = Length.meters 1.8 }
    ///     --&gt;   { Name = "Charlie"; Height = Length.meters 2.0 }
    ///     --&gt; ]
    /// </code>
    /// </example>
    static member sortBy (toQuantity: 'a -> Quantity<'Units>) (list: 'a list) : 'a list =
        let comparator first second =
            compare (toQuantity first) (toQuantity second)

        List.sortWith comparator list



    // ---- Working With Rates -----------------------------------------------------


    /// <category>Rates</category>
    /// <summary>
    /// Construct a rate of change by dividing a dependent quantity (numerator) by
    /// an independent quantity (denominator):
    /// <code lang="fsharp">
    ///     let speed =
    ///         Quantity.rate (Length.miles 1) Duration.minute
    /// 
    ///     speed |&gt; Speed.inMilesPerHour
    ///     --&gt; 60
    /// </code>
    /// 
    /// We could directly use our rate of change quantity as a <c>Speed</c>! That is
    /// because many built-in quantity types are defined as rates of change, for
    /// example:
    /// <list type="bullet">
    ///   <item><c>Speed</c> is <c>Length</c> per <c>Duration</c></item>
    ///   <item><c>Acceleration</c> is <c>Speed</c> per <c>Duration</c></item>
    ///   <item><c>Pressure</c> is <c>Force</c> per <c>Area</c></item>
    ///   <item><c>Power</c> is <c>Energy</c> per <c>Duration</c></item>
    ///   <item><c>Current</c> is <c>Charge</c> per <c>Duration</c></item>
    ///   <item><c>Resistance</c> is <c>Voltage</c> per <c>Current</c></item>
    ///   <item><c>Voltage</c> is <c>Power</c> per <c>Current</c></item>
    /// </list>
    /// </summary>
    /// <note> that there are other forms of division!</note>
    static member rate
        (dependentValue: Quantity<'Dependent>)
        (independentValue: Quantity<'Independent>)
        : Quantity<Rate<'Dependent, 'Independent>> =
        Quantity(dependentValue.Value / independentValue.Value)

    /// <category>Rates</category>
    /// <summary>
    /// 'Infix' version of [<c>rate</c>](#rate), meant to be used in pipeline form;
    /// <code lang="fsharp">
    ///     Quantity.rate distance time
    /// </code>
    /// can be written as
    /// <code lang="fsharp">
    ///     distance |&gt; Quantity.per time
    /// </code>
    /// </summary>
    static member per
        (independentValue: Quantity<'Independent>)
        (dependentValue: Quantity<'Dependent>)
        : Quantity<Rate<'Dependent, 'Independent>> =
        Quantity(dependentValue.Value / independentValue.Value)


    /// <category>Rates</category>
    /// <summary>
    /// Multiply a rate of change by an independent quantity (the denominator in
    /// the rate) to get a total quantity:
    ///
    /// <code lang="fsharp">
    ///       Duration.minutes 30
    ///           |&gt; Quantity.at
    ///               (Speed.kilometersPerHour 100)
    ///       --&gt; Length.kilometers 50
    /// </code>
    ///
    /// Can be useful to define conversion functions from one unit to another, since
    /// if you define a <c>rate</c> then <c>Quantity.at rate</c> will give you a conversion
    /// function:
    ///
    /// <code lang="fsharp">
    ///       let pixelDensity : Rate&lt;Pixels, Meters&gt; =
    ///           Pixels.pixels 96 |&gt; Quantity.per (Length.inches 1)
    ///       let lengthToPixels : Length -> Pixels =
    ///           Quantity.at pixelDensity length
    /// 
    ///       lengthToPixels (Length.inches 3)
    ///       --&gt; Pixels.pixels 288
    /// </code>
    ///
    /// Eagle-eyed readers will note that using partial application you could also
    /// simply write
    ///
    /// <code lang="fsharp">
    ///     let lengthToPixels =
    ///         Quantity.at pixelDensity
    /// </code>
    ///
    /// </summary>
    /// <note>There are other forms of multiplication!</note>
    static member at
        (rateOfChange: Quantity<Rate<'Dependent, 'Independent>>)
        (independentValue: Quantity<'Independent>)
        : Quantity<'Dependent> =
        Quantity(rateOfChange.Value * independentValue.Value)


    /// <category>Rates</category>
    /// <summary>
    /// Given a rate and a <b>Dependent</b> quantity (total quantity), determine the
    /// necessary amount of the <b>Independent</b> quantity:
    /// <code lang="fsharp">
    ///     Length.kilometers 75
    ///         |&gt; Quantity.at_
    ///             (Speed.kilometersPerHour 100)
    ///     --&gt; Duration.minutes 45
    /// </code>
    /// 
    /// Where <c>at</c> performs multiplication, <c>at_</c> performs division - you multiply a
    /// speed by a duration to get a distance, but you divide a distance by a speed to
    /// get a duration.
    /// Similar to <c>at</c>, <c>at_</c> can be used to define an _inverse_ conversion function:
    /// <code lang="fsharp">
    ///     let pixelDensity : Rate&lt;Pixels, Meters&gt;
    ///         Pixels.pixels 96 |&gt; Quantity.per (Length.inches 1)
    /// 
    ///     let pixelsToLength (pixels: Pixels): Length =
    ///         Quantity.at_ pixelDensity pixels
    /// 
    ///     pixelsToLength (Pixels.pixels 48)
    ///     --&gt; Length.inches 0.5
    /// 
    ///     Rate&lt;DependentUnits, IndependentUnits&gt;
    ///     --&gt; Quantity DependentUnits
    ///     --&gt; Quantity IndependentUnits
    /// </code>
    /// </summary>
    static member at_
        (rateOfChange: Quantity<Rate<'Dependent, 'Independent>>)
        (dependentValue: Quantity<'Depenent>)
        : Quantity<'Independent> =
        Quantity(dependentValue.Value / rateOfChange.Value)


    /// <category>Rates</category>
    /// <summary>
    /// Same as <c>at</c> but with the argument order flipped, which may read better
    /// in some cases:
    /// <code lang="fsharp">
    ///     Speed.kilometersPerHour 100
    ///         |&gt; Quantity.for
    ///             (Duration.minutes 30)
    ///     --&gt; Length.kilometers 50
    /// </code>
    /// </summary>
    static member for_
        (independentValue: Quantity<'Independent>)
        (rateOfChange: Quantity<Rate<'Dependent, 'Independent>>)
        : Quantity<'Dependent> =
        Quantity(rateOfChange.Value * independentValue.Value)


    /// <category>Rates</category>
    /// <summary>
    /// Find the inverse of a given rate. May be useful if you are using a rate to
    /// define a conversion, and want to convert the other way;
    /// <code lang="fsharp">
    ///     Quantity.at (Quantity.inverse rate)
    /// </code>
    /// is equivalent to
    /// <code lang="fsharp">
    ///     Quantity.at_ rate
    /// </code>
    /// </summary>
    static member inverse
        (rateOfChange: Quantity<Rate<'Dependent, 'Independent>>)
        : Quantity<Rate<'Independent, 'Dependent>> =
        Quantity(1. / rateOfChange.Value)


    /// <category>Rates</category>
    /// <summary>
    /// Multiply two rates of change that 'cancel out' together, resulting in a new
    /// rate. For example, if you know the real-world speed of an on-screen object and
    /// the display resolution, then you can get the speed in pixels per second:
    /// <code lang="fsharp">
    ///     let realWorldSpeed =
    ///         Speed.metersPerSecond 0.1
    ///     let resolution =
    ///         Pixels.float 96 |&gt; Quantity.per Length.inch
    /// 
    ///     Quantity.rateProduct realWorldSpeed resolution
    ///     --&gt; Pixels.pixelsPerSecond 377.95
    /// </code>
    /// 
    /// That is, "length per duration" multiplied by "pixels per length" gives you
    /// "pixels per duration".
    /// Sometimes you can't directly multiply two rates to get what you want, in which
    /// case you may need to use <c>inverse</c> in combination with
    /// <c>rateProduct</c>. For example, if you know the on-screen speed of some object and
    /// the display resolution, then you can use those to get the real-world speed:
    ///
    /// <code lang="fsharp">
    ///     let pixelSpeed =
    ///         Pixels.pixelsPerSecond 500
    ///     let resolution =
    ///         Pixels.float 96 |&gt; Quantity.per Length.inch
    ///     Quantity.rateProduct pixelSpeed
    ///         (Quantity.inverse resolution).Value
    ///     --&gt; Speed.metersPerSecond 0.1323
    /// </code>
    /// </summary>
    static member rateProduct
        (firstRate: Quantity<Rate<'U2, 'U1>>)
        (secondRate: Quantity<Rate<'U3, 'U2>>)
        : Quantity<Rate<'U3, 'U1>> =
        Quantity(firstRate.Value * secondRate.Value)
