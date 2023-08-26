/// <category>Interval</category>
/// <summary>
/// These functions let you do math with <c>Interval</c> values, following the rules of
/// <a href="https://en.wikipedia.org/wiki/Interval_arithmetic">interval arithmetic</a>.
/// </summary>
///
/// <example>
/// Various functionality is included for constructing intervals (including as
/// the hull or intersection of other intervals), checking for
/// overlap/intersection/containment, and performing limited arithmetic on
/// intervals:
/// 
/// <code>
///     let unitInterval =
///         Interval.from 0 1
///     
///     Interval.endpoints unitInterval
///     --&gt; ( 0, 1 )
///     
///     Interval.hull 5 [ 3, 2, 4 ]
///     --&gt; Interval.from 2 5
///     
///     Interval.union
///         (Interval.from 1 2)
///         (Interval.from 3 5)
///     --&gt; Interval.from 1 5
///     
///     Interval.intersection
///         (Interval.from 1 3)
///         (Interval.from 2 5)
///     --&gt; Just (Interval.from 2 3)
///     
///     Interval.intersection
///         (Interval.from 1 2)
///         (Interval.from 3 5)
///     --&gt; Nothing
///     
///     Interval.contains 0 (Interval.from -1 3)
///     --&gt; True
///     
///     Interval.contains 5 (Interval.from -1 3)
///     --&gt; False
///     
///     Interval.sin (Interval.from 0 pi)
///     --&gt; Interval.from 0 1
/// </code>
/// </example>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Interval

open System

open UralMathFsharpLib.Units

/// <category>Builders</category>
let inline unit<'Units> : Interval<'Units> =
    Interval(Quantity LanguagePrimitives.GenericZero, Quantity LanguagePrimitives.GenericOne)

/// <category>Builders</category>
/// <summary>
/// Construct an interval from two given values.
///
/// The values should be given in order, but will be swapped if needed to
/// ensure a valid interval is created.
///
/// <code lang="fsharp">
///     Interval.from (3, 2)
///     --&gt; Interval (2, 3)
/// </code>
/// </summary>
let from (first: Quantity<'Units>) (second: Quantity<'Units>) : Interval<'Units> =
    if first <= second then
        Interval(first, second)
    else
        Interval(second, first)


/// <category>Builders</category>
/// <summary>
/// Construct an interval from it's endpoints.
///
/// The values should be given in order, but will be swapped if needed to
/// ensure a valid interval is created.
///
/// <code lang="fsharp">
///     Interval.fromEndpoints (3, 2)
///     --&gt; Interval (2, 3)
/// </code>
/// </summary>
let fromEndpoints (first, second) : Interval<'Units> = from first second

/// <category>Builders</category>
/// Construct a zero width interval containing a single value
let singleton n : Interval<'Units> = Interval(n, n)


// ---- Accessors ---

/// <category>Accessors</category>
/// <summary>
/// Get the endpoints of an interval (its minimum and maximum values) as a
/// tuple. The first value will always be less than or equal to the second.
/// <code lang="fsharp">
///     let ( minValue, maxValue ) =
///         Interval.endpoints someInterval
/// </code>
/// For any interval,
/// <code lang="fsharp">
///     Interval.endpoints interval
/// </code>
/// is equivalent to (but more efficient than)
/// <code lang="fsharp">
///     ( Interval.minValue interval
///     , Interval.maxValue interval
///     )
/// </code>
/// </summary>
let endpoints (Interval.Interval (a, b): Interval<'Units>) : Quantity<'Units> * Quantity<'Units> = (a, b)


/// <category>Accessors</category>
/// <summary>
/// <code lang="fsharp">
/// Get the minimum value of an interval.
///     Interval.minValue (Interval.from 1 3)
///     --&gt; 1
/// </code>
/// </summary>
let minValue (Interval (a, _): Interval<'Units>) : Quantity<'Units> = a


/// <category>Accessors</category>
/// <summary>
/// Get the maximum value of an interval.
/// <code lang="fsharp">
///     Interval.maxValue (Interval.from 1 3)
///     --&gt; 3
/// </code>
/// </summary>
let maxValue (Interval (_, b): Interval<'Units>) : Quantity<'Units> = b


/// <category>Accessors</category>
/// <summary>
/// Get the midpoint of an interval.
/// <code lang="fsharp">
///     Interval.midpoint (Interval.from 1 4)
///     --&gt; 2.5
/// </code>
/// </summary>
let inline midpoint (Interval (a, b): Interval<'Units>) : Quantity<'Units> = a + 0.5 * (b - a)

/// <category>Accessors</category>
/// <summary>
/// Get the width of an interval.
/// <code lang="fsharp">
///     Interval.width (Interval.from 1 5)
///     --&gt; 4
/// </code>
/// </summary>
let inline width (Interval (a, b)) : Quantity<'Units> = b - a

/// <category>Accessors</category>
/// <summary>
/// Check if the interval is a singleton (the minimum and maximum values are the
/// same).
/// <code lang="fsharp">
///     Interval.isSingleton (Interval.from 2 2)
///     --&gt; True
///     Interval.isSingleton (Interval.from 2 3)
///     --&gt; False
/// </code>
/// </summary>
let isSingleton (Interval (a, b): Interval<'Units>) : bool = a = b


// ---- Math Operations ----

/// <category>Math</category>
/// <summary>
/// Construct an interval containing both of the given intervals.
/// <code lang="fsharp">
///     let firstInterval =
///         Interval.from 1 2
///     let secondInterval =
///         Interval.from 3 6
///     let Interval.union firstInterval secondInterval
///     --&gt; Interval.from 1 6
/// </code>
/// </summary>
///
/// <note>
/// This is not strictly speaking a 'union' in the precise mathematical
/// sense, since the result will contain values that are _in between_ the two given
/// intervals and not actually _in_ either of them if those two intervals do not
/// overlap.
/// </note>
let union (Interval (a1, b1)) (Interval (a2, b2)) : Interval<'Units> = Interval(min a1 a2, max b1 b2)

/// <category>Math</category>
/// <summary>
/// Attempt to construct an interval containing all the values common to both
/// given intervals.
///
/// If the intervals do not intersect, returns <c>Nothing</c>.
/// <code lang="fsharp">
///     Interval.intersection
///         (Interval.from 1 3)
///         (Interval.from 2 5)
///     --&gt; Some (Interval.from 2 3)
///     Interval.intersection
///         (Interval.from 1 3)
///         (Interval.from 4 7)
///     --&gt; None
/// </code>
///
/// If the two intervals just touch, a singleton interval will be returned:
/// <code lang="fsharp">
///     Interval.intersection
///         (Interval.from 1 3)
///         (Interval.from 3 5)
///     --&gt; Some (Interval.singleton 3)
/// </code>
/// </summary>
let intersection (Interval (a1, b1)) (Interval (a2, b2)) : Interval<'Units> option =
    let maxA = max a1 a2
    let minB = min b1 b2

    if maxA <= minB then
        Some(Interval(maxA, minB))
    else
        None

/// <category>Math</category>
/// <summary>
/// Negate an interval. Note that this will flip the order of the endpoints.
/// <code lang="fsharp">
///    Interval.negate (Interval.from 2 3)
///    --&gt; Interval.from -3 -2
/// </code>
/// </summary>
let inline negate (Interval (a, b): Interval<'Units>) : Interval<'Units> = Interval(-b, -a)


/// <category>Math</category>
/// <summary>
/// Add the given amount to an interval.
/// <code lang="fsharp">
///    Interval.from -1 5 |&gt; Interval.add 3
///    --&gt; Interval.from 2 8
/// </code>
/// </summary>
let inline plus (delta: Quantity<'Units>) (Interval (a, b): Interval<'Units>) : Interval<'Units> =
    Interval(delta + a, delta + b)


/// <category>Math</category>
/// <summary>
/// Subtract the given amount from an interval.
/// <code lang="fsharp">
///    Interval.from -1 5 |&gt; Interval.subtract 3
///    --&gt; Interval.from -4 2
/// </code>
/// </summary>
let inline minus (delta: Quantity<'Units>) (Interval (a, b): Interval<'Units>) : Interval<'Units> =
    Interval(a - delta, b - delta)

/// <category>Math</category>
/// <summary>
/// Subtract an interval from the given amount. So if you wanted to compute
/// <c>interval - quantity</c> you would write
/// <code lang="fsharp">
///     interval |&gt; Interval.minus quantity
/// </code>
/// but if you wanted to compute <c>quantity - interval</c> then you would write
/// <code lang="fsharp">
///     Interval.difference quantity interval
/// </code>
/// </summary>
let difference (x: Quantity<'Units>) (interval: Interval<'Units>) =
    let (Interval (a, b)) = interval
    Interval(x - b, x - a)

/// <category>Math</category>
/// <summary>
/// Multiply an interval by a given value. Note that this will flip the order
/// of the interval's endpoints if the given value is negative.
/// <code lang="fsharp">
///     Interval.multiplyBy 5 (Interval.from 2 3)
///     --&gt; Interval.from 10 15
///     Interval.multiplyBy -2 (Interval.from 2 3)
///     --&gt; Interval.from -6 -4
/// </code>
/// </summary>
let multiplyBy (scale: float) (Interval (a, b): Interval<'Units>) : Interval<'Units> =
    if scale >= 0 then
        Interval(a * scale, b * scale)

    else
        Interval(b * scale, a * scale)

/// <category>Math</category>
/// <summary>
/// Multiply an <c>Interval</c> by a <c>Quantity</c>, for example
///     Interval.product quantity interval
/// </summary>
///
/// <note>
/// Unlike <c>Quantity.times</c>, the units of the result will be
/// <c>Product&lt;QuantityUnits, IntervalUnits&gt;</c>,
/// not <c>Product&lt;IntervalUnits, QuantityUnits&gt;</c>.
/// </note>
let product
    (x: Quantity<'QuantityUnits>)
    (Interval (a, b): Interval<'IntervalUnits>)
    : Interval<Product<'QuantityUnits, 'IntervalUnits>> =
    if x >= Quantity.zero then
        Interval(x * a, x * b)

    else
        Interval(x * b, x * a)


/// <category>Math</category>
/// <summary>
/// Divide an interval by a given value. Note that this will flip the order
/// of the interval's endpoints if the given value is negative.
/// <code lang="fsharp">
///     Interval.divideBy 2 (Interval.from 2 3)
///     --&gt; Interval.from 1 1.5
///     Interval.divideBy -2 (Interval.from 2 3)
///     --&gt; Interval.from -1.5 -1
/// </code>
/// </summary>
let divideBy (divisor: float) (Interval (a, b): Interval<'Units>) : Interval<'Units> =
    if divisor = 0. then
        Interval(Quantity(-1. / 0.), Quantity(1. / 0.))

    else if divisor > 0. then
        Interval(a / divisor, b / divisor)

    else
        Interval(b / divisor, a / divisor)


/// <category>Math</category>
/// <summary>
/// Shorthand for <c>multiplyBy 0.5</c>.
/// </summary>
let half (Interval (a, b): Interval<'Units>) : Interval<'Units> = Interval(0.5 * a, 0.5 * b)


/// <category>Math</category>
/// <summary>
/// Shorthand for <c>multiplyBy 2</c>.
/// </summary>
let twice (Interval (a, b): Interval<'Units>) : Interval<'Units> = Interval(2. * a, 2. * b)

/// <category>Math</category>
/// <summary>
/// Add two intervals together.
/// <code lang="fsharp">
///     Interval.from 5 10
///         |&gt; Interval.plus (Interval.from 2 3)
///     --&gt; Interval.from 7 13
/// </code>
/// </summary>
let plusInterval (Interval (a2, b2)) (Interval (a1, b1)) = Interval(a2 + a1, b2 + b1)


/// <category>Math</category>
/// <summary>
/// Subtract the first interval from the second. This means that <c>minus</c> makes
/// the most sense when using <c>|&gt;</c>:
/// <code lang="fsharp">
///     Interval.from 5 10
///         |&gt; Interval.minus (Interval.from 2 3)
///     --&gt; Interval.from 2 8
/// </code>
/// Without the pipe operator, the above would be written as:
/// <code lang="fsharp">
///     Interval.minus (Interval.from 2 3)
///         (Interval.from 5 10)
///     --&gt; Interval.from 2 8
/// </code>
/// </summary>
let minusInterval (Interval (a2, b2)) (Interval (a1, b1)) = Interval(a1 - b2, b1 - a2)

/// <category>Math</category>
/// <summary>
/// Multiply an <c>Interval</c> by a <c>Quantity</c>, for example
/// <code lang="fsharp">
///     interval |&gt; Interval.times quantity
/// </code>
/// </summary>
let times
    (x: Quantity<'QuantityUnits>)
    (interval: Interval<'IntervalUnits>)
    : Interval<Product<'IntervalUnits, 'QuantityUnits>> =
    let (Interval (a, b)) = interval

    if x >= Quantity.zero then
        Interval(a * x, b * x)

    else
        Interval(b * x, a * x)

/// <category>Unitless</category>
/// <summary>
/// Multiply an <c>Interval</c> by a unitless <c>Quantity</c>. See the documentation for
/// <c>Quantity.timesUnitless</c> for more details.
/// </summary>
let timesUnitless (x: Quantity<Unitless>) (interval: Interval<Unitless>) : Interval<Unitless> =
    let (Interval (a, b)) = interval

    if x >= Quantity.zero then
        Interval(a * x.Value, b * x.Value)

    else
        Interval(b * x.Value, a * x.Value)

/// <category>Math</category>
/// <summary>
/// Multiply the two given intervals.
/// <code lang="fsharp">
///     Interval.from 10 12
///         |&gt; Interval.times
///             (Interval.from 5 6)
///     --&gt; Interval.from 50 72
/// </code>
/// </summary>
let timesInterval
    (Interval (a2, b2): Interval<'UnitsA>)
    (Interval (a1, b1): Interval<'UnitsB>)
    : Interval<Product<'UnitsB, 'UnitsA>> =
    let aa = a1 * a2
    let ab = a1 * b2
    let ba = b1 * a2
    let bb = b1 * b2

    Interval(min (min (min aa ab) ba) bb, max (max (max aa ab) ba) bb)

/// <category>Unitless</category>
/// <summary>
/// Combination of <c>Quantity.timesInterval</c> and <c>Quantity.timesUnitless</c>
/// for when one of the intervals in a product is unitless.
/// </summary>
let timesUnitlessInterval (unitlessInterval: Interval<Unitless>) (interval: Interval<'Units>) : Interval<'Units> =
    let (Interval (a2, b2)) = unitlessInterval
    let (Interval (a1, b1)) = interval
    let aa = a1 * a2
    let ab = a1 * b2
    let ba = b1 * a2
    let bb = b1 * b2
    let start = min (min (min aa ab) ba) bb
    let finish = max (max (max aa ab) ba) bb

    Interval(Quantity start.Value, Quantity finish.Value)

/// <category>Math</category>
/// <summary>
/// Find the inverse of a unitless interval:
/// <code lang="fsharp">
///     Interval.reciprocal &lt;|
///         Interval.fromEndpoints
///             ( Quantity.float 2
///             , Quantity.float 3
///             )
///     --&gt; Interval.fromEndpoints
///     --&gt;     ( Quantity.float 0.333
///     --&gt;     , Quantity.float 0.500
///     --&gt;     )
/// </code>
///
/// Avoid using this function whenever possible, since it's very easy to get
/// infinite intervals as a result:
/// <code lang="fsharp">
///     Interval.reciprocal &lt;|
///         Interval.fromEndpoints
///             ( Quantity.float -1
///             , Quantity.float 2
///             )
///     --&gt; Interval.fromEndpoints
///     --&gt;     ( Quantity.negativeInfinity
///     --&gt;     , Quantity.negativeInfinity
///     --&gt;     )
/// </code>
///
/// Since zero is contained in the above interval, the range of possible reciprocals
/// ranges from negative to positive infinity!
/// </summary>
let reciprocal (Interval (a, b): Interval<Unitless>) : Interval<Unitless> =
    if a > Quantity.zero || b < Quantity.zero then
        Interval(Quantity(1. / b.Value), Quantity(1. / a.Value))

    else if a < Quantity.zero && b > Quantity.zero then
        Interval(Quantity.negativeInfinity, Quantity.positiveInfinity)

    else if a < Quantity.zero then
        Interval(Quantity.negativeInfinity, Quantity(1. / a.Value))

    else if b > Quantity.zero then
        Interval(Quantity(1. / b.Value), Quantity.positiveInfinity)

    else
        Interval(Quantity(Quantity.zero / Quantity.zero), Quantity(Quantity.zero / Quantity.zero))

/// <category>Math</category>
/// <summary>
/// Get the absolute value of an interval.
/// <code lang="fsharp">
///     Interval.abs &lt;|
///         Interval.fromEndpoints
///             ( Length.meters -3  Length.meters 2 )
///     --&gt; Interval.fromEndpoints
///     --&gt;     (Length.meters 0) (Length.meters 3)
/// </code>
/// </summary>
let abs (Interval (a, b) as interval: Interval<'Units>) : Interval<'Units> =
    if a >= Quantity.zero then
        interval

    else if b <= Quantity.zero then
        negate interval

    else
        Interval(Quantity.zero, max -a b)


/// <category>Math</category>
let unsafeSquared (Interval (a, b): Interval<'Units>) : Interval<'ResultUnits> =
    if a >= Quantity.zero then
        Interval(Quantity(a.Value * a.Value), Quantity(b.Value * b.Value))

    else if b <= Quantity.zero then
        Interval(Quantity(b.Value * b.Value), Quantity(a.Value * a.Value))

    else if -a < b then
        Interval(Quantity.zero, Quantity(b.Value * b.Value))

    else
        Interval(Quantity.zero, Quantity(a.Value * a.Value))


/// <category>Math</category>
/// Get the square of an interval.
let squared (interval: Interval<'Units>) : Interval<Squared<'Units>> = unsafeSquared interval


/// <category>Unitless</category>
/// <summary>
/// Specialized version of <c>squared</c> for unitless intervals.
/// </summary>
let squaredUnitless (interval: Interval<Unitless>) : Interval<Unitless> = unsafeSquared interval


/// <category>Math</category>
let unsafeCubed (Interval (a, b): Interval<'Units>) : Interval<'ResultUnits> =
    Interval(Quantity(a.Value * a.Value * a.Value), Quantity(b.Value * b.Value * b.Value))


/// <category>Math</category>
/// Get the cube of an interval.
let cubed (interval: Interval<'Units>) : Interval<Cubed<'Units>> = unsafeCubed interval


/// <category>Unitless</category>
/// <summary>
/// Specialized version of <c>cubed</c> for unitless intervals.
/// </summary>
let cubedUnitless (interval: Interval<Unitless>) : Interval<Unitless> = unsafeCubed interval

/// <category>Math</category>
/// <summary>
/// The maximum of <c>cos(x) is x = 2 pi \* k</c> for every integer k.
/// If <c>minValue</c> and <c>maxValue</c> are in different branches
/// (meaning different values of k), then the interval must pass through
/// <c>2 pi \* k</c>, which means the interval must include the maximum value.
/// </summary>
let cosIncludesMax (Interval (a, b)) : bool =
    let minBranch = floor (a / (2. * Math.PI))

    let maxBranch = floor (b / (2. * Math.PI))
    minBranch <> maxBranch

/// <category>Math</category>
/// <summary>
/// <c>cos(x + pi) = -cos(x)</c>, therefore if <c>cos(interval + pi)</c> includes the maximum,
/// that means <c>cos(interval)</c> includes the minimum.
/// </summary>
let cosIncludesMinMax (interval: Interval<'Units>) : bool * bool =
    (interval
     |> plus (Quantity Math.PI)
     |> cosIncludesMax,
     interval |> cosIncludesMax)

/// <category>Math</category>
/// <summary>
/// <c>cos(x - pi/2) = sin(x)</c>, therefore if <c>cos(interval - pi/2)</c> includes
/// the maximum/minimum, that means <c>sin(interval)</c> includes the maximum/minimum
/// accordingly.
/// </summary>
let sinIncludesMinMax (interval: Interval<'Units>) : bool * bool =
    let halfPi = Math.PI / 2.

    interval
    |> minus (Quantity halfPi)
    |> cosIncludesMinMax


/// <category>Math</category>
/// <summary>
/// Get the image of <c>sin(x)</c> applied on the interval.
/// <code lang="fsharp">
///     Interval.sin (Interval.from 0 (degrees 45))
///     --&gt; Interval.from 0 0.7071
///     Interval.sin (Interval.from 0 pi)
///     --&gt; Interval.from 0 1
/// </code>
/// </summary>
let sin (interval: Interval<Radians>) : Interval<Unitless> =
    if isSingleton interval then
        singleton (Angle.sin (minValue interval) |> Quantity)

    else
        let includesMin, includesMax =
            sinIncludesMinMax interval

        let a, b = endpoints interval

        let newMin =
            if includesMin then
                -1.

            else
                min (Angle.sin a) (Angle.sin b)

        let newMax =
            if includesMax then
                1.

            else
                max (Angle.sin a) (Angle.sin b)

        fromEndpoints (Quantity newMin, Quantity newMax)


/// <category>Math</category>
/// <summary>
///  Get the image of <c>cos(x)</c> applied on the interval.
/// <code lang="fsharp">
///     Interval.cos (Interval.from 0 (degrees 45))
///     --&gt; Interval.from 0.7071 1
///     Interval.cos (Interval.from 0 pi)
///     --&gt; Interval.from -1 1
/// </code>
/// </summary>
let cos (interval: Interval<Radians>) : Interval<Unitless> =
    if isSingleton interval then
        singleton (Angle.cos (minValue interval) |> Quantity)

    else
        let includesMin, includesMax =
            cosIncludesMinMax interval

        let a, b = endpoints interval

        let newMin =
            if includesMin then
                -1.

            else
                min (Angle.cos a) (Angle.cos b)

        let newMax =
            if includesMax then
                1.

            else
                max (Angle.cos a) (Angle.cos b)

        fromEndpoints (Quantity newMin, Quantity newMax)


// ---- Queries ----

/// <category>Queries</category>
/// <summary>
/// Interpolate between an interval's endpoints based on a parameter value that
/// will generally be between 0.0 and 1.0. A value of 0.0 corresponds to the minimum
/// value of the interval, a value of 0.5 corresponds to its midpoint and a value of
/// 1.0 corresponds to its maximum value:
/// <code lang="fsharp">
///     Interval.interpolate (Interval.from 1 5) 0
///     --&gt; 1
///     Interval.interpolate (Interval.from 1 5) 0.75
///     --&gt; 4
/// </code>
/// Values less than 0.0 or greater than 1.0 can be used to extrapolate:
/// <code lang="fsharp">
///     Interval.interpolate (Interval.from 1 5) 1.5
///     --&gt; 7
/// </code>
/// Note that because of how <c>Interval.from</c> works, the interpolation is in
/// fact from the minimum value to the maximum, _not_ "from the first
/// <c>Interval.from</c> argument to the second":
/// <code lang="fsharp">
///     Interval.interpolate (Interval.from 0 10) 0.2
///     --&gt; 2
///     Interval.interpolate (Interval.from 10 0) 0.2
///     --&gt; 2 // not 8!
/// </code>
/// </summary>
let interpolate (Interval (a, b): Interval<'Units>) (t: float) : Quantity<'Units> =
    Float.interpolateFrom a.Value b.Value t
    |> Quantity


/// <category>Queries</category>
/// <summary>
/// Given an interval and a given value, determine the corresponding
/// interpolation parameter (the parameter that you would pass to
/// <c>Interval.interpolate</c> to get the given value):
/// <code lang="fsharp">
///     Interval.interpolationParameter
///         (Interval.from 10 15)
///         12
///     --&gt; 0.4
/// </code>
///
/// The result will be between 0 and 1 if (and only if) the given value is within
/// the given interval:
/// <code lang="fsharp">
///     Interval.interpolationParameter
///         (Interval.from 10 15)
///         18
///     --&gt; 1.6
///     Interval.interpolationParameter
///         (Interval.from 10 15)
///         9
///     --&gt; -0.2
/// </code>
///
/// This is the inverse of <c>interpolate</c>; for any non-zero-width <c>interval</c>,
/// <code lang="fsharp">
///     Interval.interpolationParameter interval value
///         |&gt; Interval.interpolate interval
/// </code>
/// should be equal to the original <c>value</c> (within numerical round off).
/// </summary>
let interpolationParameter (Interval (a, b): Interval<'Units>) (value: Quantity<'Units>) : float =
    if a < b then
        (value - a) / (b - a)

    else

    if value < a then
        -1. / 0.

    else if value > b then
        1. / 0.

    else
        // value, a and intervalMaxValue are all equal
        0.

/// <category>Queries</category>
/// Test if a value is contained with a particular interval.
let contains (value: Quantity<'Units>) (Interval (a, b): Interval<'Units>) : bool = a <= value && value <= b


/// <category>Queries</category>
/// <summary>
/// Check if two intervals touch or overlap (have any values in common).
/// <code lang="fsharp">
///     Interval.from -5 5
///         |&gt; Interval.intersects (Interval.from 0 10)
///     --&gt; True
///     Interval.from -5 5
///         |&gt; Interval.intersects (Interval.from 10 20)
///     --&gt; False
/// </code>j
///
/// Intervals that just touch each other are considered to intersect (this is
/// consistent with <c>intersection</c> which will return a zero-width interval for the
/// intersection of two just-touching intervals):
/// <code lang="fsharp">
///     Interval.from -5 5
///         |&gt; Interval.intersects (Interval.from 5 10)
///     --&gt; True
/// </code>
/// </summary>
let intersects (Interval (a1, b1): Interval<'Units>) (Interval (a2, b2): Interval<'Units>) : bool = a1 <= b2 && b1 >= a2


/// <category>Queries</category>
/// <summary>
/// Check if the second interval is fully contained in the first.
/// <code lang="fsharp">
///     Interval.from -5 5
///         |&gt; Interval.isContainedIn (Interval.from 0 10)
///     --&gt; False
///     Interval.from -5 5
///         |&gt; Interval.isContainedIn (Interval.from -10 10)
///     --&gt; True
/// </code>
///
/// Be careful with the argument order! If not using the <c>|&gt;</c> operator, the second
/// example would be written as:
/// <code lang="fsharp">
///     Interval.isContainedIn (Interval.from -10 10)
///         (Interval.from -5 5)
///     --&gt; True
/// </code>
/// </summary>
let isContainedIn (Interval (a1, b1): Interval<'Units>) (Interval (a2, b2): Interval<'Units>) : bool =
    a1 <= a2 && b2 <= b1


/// <category>Queries</category>
/// <summary>
/// Find the interval containing one or more input values:
/// <code lang="fsharp">
///    Interval.hull 5 [ 3; 2; 4 ]
///    --&gt; Interval.from 2 5
/// </code>
/// See also <c>Interval.hullN</c>
/// </summary>
let hull (first: Quantity<'Units>) (rest: Quantity<'Units> list) : Interval<'Units> =
    let rec hullHelp a b values =
        match values with
        | value :: rest -> hullHelp (Quantity.min a value) (Quantity.max b value) rest

        | [] -> Interval(a, b)

    hullHelp first first rest

/// <category>Queries</category>
/// <summary>
/// Construct an interval containing the three given values;
/// <code lang="fsharp">
///     Interval.hull3 a b c
/// </code>
/// is equivalent to
/// <code lang="fsharp">
///     Interval.hull a [ b; c ]
/// </code>
/// but is more efficient. (If you're looking for a <c>Interval.hull2</c> function, <c>Interval.from</c>
/// should do what you want.)
/// </summary>
let hull3 (a: Quantity<'Units>) (b: Quantity<'Units>) (c: Quantity<'Units>) : Interval<'Units> =
    Interval(min a (min b c), max a (max b c))

/// <category>Queries</category>
/// <summary>
/// Attempt to construct an interval containing all _N_ values in the given
/// list. If the list is empty, returns <c>Nothing</c>. If you know you have at least one
/// value, you can use <c>Interval.hull</c> instead.
/// <code lang="fsharp">
///     Interval.hullN [ 2; 1; 3 ]
///     --&gt; Just (Interval.from 1 3)
///     Interval.hullN [ -3 ]
///     --&gt; Just (Interval.singleton -3)
///     Interval.hullN []
///     --&gt; Nothing
/// </code>
/// </summary>
let hullN (values: Quantity<'Units> list) : Interval<'Units> option =
    match values with
    | first :: rest -> Some(hull first rest)
    | [] -> None

/// <category>Queries</category>
/// <summary>
/// Like <c>Quantity.hull</c>, but lets you work on any kind of item as long as a
/// number can be extracted from it. For example, if you had
/// <code lang="fsharp">
///     type Person =
///         { Name : string
///           Age : float
///         }
/// </code>
///
/// then given some people you could find their range of ages as an <c>Interval</c>
/// using
/// <code lang="fsharp">
///     Interval.hullOf (fun person -> person.Age)
///         firstPerson
///         [ secondPerson
///           thirdPerson
///           fourthPerson
///         ]
/// </code>
///
/// See also <c>Interval.hullOfN</c>.
/// </summary>
let hullOf (getValue: 'a -> Quantity<'Units>) (first: 'a) (rest: 'a list) : Interval<'Units> =
    let rec hullOfHelp a b getValue list =
        match list with
        | first :: rest ->
            let value = getValue first
            hullOfHelp (min a value) (max b value) getValue rest

        | [] -> Interval(a, b)

    let firstValue = getValue first
    hullOfHelp firstValue firstValue getValue rest

/// <category>Queries</category>
/// <summary>
/// Combination of <c>Interval.hullOf</c> and <c>Interval.hullN</c>.
/// </summary>
let hullOfN (getValue: 'a -> Quantity<'Units>) (items: 'a list) : Interval<'Units> option =
    match items with
    | first :: rest -> Some(hullOf getValue first rest)
    | [] -> None

/// <category>Queries</category>
/// <summary>
/// Construct an interval containing one or more given intervals:
/// <code lang="fsharp">
///     Interval.aggregate
///         (Interval.singleton 2)
///         [ Interval.singleton 4
///           Interval.singleton 3
///         ]
///     --&gt; Interval.from 2 4
/// </code>
///
/// Works much like <c>Interval.hull</c>. See also <c>Interval.aggregateN</c>.
/// </summary>
let aggregate (Interval (a, b)) (rest: Interval<'Units> list) : Interval<'Units> =
    let rec aggregateHelp a b intervals =
        match intervals with
        | Interval (c, d) :: rest -> aggregateHelp (min a c) (max b d) rest

        | [] -> Interval(a, b)

    aggregateHelp a b rest

/// <category>Queries</category>
/// <summary>
/// Special case of <c>Interval.aggregate</c> for the case of three intervals;
/// <code lang="fsharp">
///     Interval.aggregate3 first second third
/// </code>
/// is equivalent to
/// <code lang="fsharp">
///     Interval.aggregate first [ second; third ]
/// </code>
/// but is more efficient. (If you're looking for an <c>Interval.aggregate2</c> function,
/// <c>Interval.union</c> should do what you want.)
/// </summary>
let aggregate3 (Interval (a1, b1)) (Interval (a2, b2)) (Interval (a3, b3)) : Interval<'Units> =
    Interval(min a1 (min a2 a3), max b1 (max b2 b3))

/// <category>Queries</category>
/// <summary>
///  Attempt to construct an interval containing all of the intervals in the given
/// list. If the list is empty, returns <c>None</c>. If you know you have at least one
/// interval, you can use <c>Interval.aggregate</c> instead.
/// </summary>
let aggregateN intervals : Interval<'Units> option =
    match intervals with
    | first :: rest -> Some(aggregate first rest)
    | [] -> None

/// <category>Queries</category>
/// <summary>
/// Like <c>Interval.aggregate</c>], but lets you work on any kind of item as
/// long as an interval can be generated from it similar to <c>Interval.hullOf</c>.
/// </summary>
let aggregateOf (getInterval: 'a -> Interval<'Units>) (first: 'a) (rest: 'a list) : Interval<'Units> =
    let rec aggregateOfHelp a b getInterval items =
        match items with
        | first :: rest ->
            let (Interval (c, d)) = getInterval first
            aggregateOfHelp (min a c) (max b d) getInterval rest

        | [] -> Interval(a, b)

    let (Interval (a, b)) = getInterval first
    aggregateOfHelp a b getInterval rest

/// <category>Queries</category>
/// <summary>
/// Combination of <c>Interval.aggregateOf</c> and <c>Interval.aggregateN</c>.
/// </summary>
let aggregateOfN (getInterval: 'a -> Interval<'Units>) (items: 'a list) : Interval<'Units> option =
    match items with
    | first :: rest -> Some(aggregateOf getInterval first rest)
    | [] -> None
