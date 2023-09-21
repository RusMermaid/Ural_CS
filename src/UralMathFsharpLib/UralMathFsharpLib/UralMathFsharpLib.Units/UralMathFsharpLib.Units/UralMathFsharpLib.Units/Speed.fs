/// <category>Module: Unit System</category>
/// <summary>
/// A <c>Speed</c> value represents a speed in meters per second, miles per hour etc.
/// It is stored as a number of meters per second.
/// </summary>
/// 
/// <note>
/// Since <c>MetersPerSecond</c> is defined as <c>Rate Meters Seconds</c> (length
/// per unit time), you can construct a <c>Speed</c> value using <c>Quantity.per</c>:
/// <code>
///     let speed =
///         length |&gt; Quantity.per duration
/// </code>
/// 
/// You can also do rate-related calculations with <c>Speed</c> values to compute
/// <c>Length</c> or <c>Duration</c>:
/// <code>
///     let length =
///         speed |&gt; Quantity.for duration
///     let alsoLength =
///         duration |&gt; Quantity.at speed
///     let duration =
///         length |&gt; Quantity.at_ speed
/// </code>
/// </note>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Speed

open UralMathFsharpLibUnits

/// <category>Conversions</category>
/// Construct a speed from a number of meters per second.
let metersPerSecond (numMetersPerSecond: float) : Speed = Quantity numMetersPerSecond

/// <category>Conversions</category>
/// Convert a speed to a number of meters per second.
let inMetersPerSecond (numMetersPerSecond: Speed) : float = numMetersPerSecond.Value

/// <category>Conversions</category>
/// Construct a speed from a number of feet per second.
let feetPerSecond (numFeetPerSecond: float) : Speed =
    metersPerSecond (MetricConstants.foot * numFeetPerSecond)

/// <category>Conversions</category>
/// Convert a speed to a number of feet per second.
let inFeetPerSecond (speed: Speed) : float =
    inMetersPerSecond speed / MetricConstants.foot

/// <category>Conversions</category>
/// Construct a speed from a number of kilometers per hour.
let kilometersPerHour (numKilometersPerHour: float) : Speed =
    metersPerSecond (numKilometersPerHour * 1000. / MetricConstants.hour)

/// <category>Conversions</category>
/// Convert a speed to a number of kilometers per hour.
let inKilometersPerHour (speed: Speed) : float =
    MetricConstants.hour * inMetersPerSecond speed * 0.001

/// <category>Conversions</category>
/// Construct a speed from a number of miles per hour.
let milesPerHour (numMilesPerHour: float) : Speed =
    metersPerSecond (numMilesPerHour * MetricConstants.mile / MetricConstants.hour)

/// <category>Conversions</category>
/// Convert a speed to a number of miles per hour.
let inMilesPerHour (speed: Speed) : float =
    (MetricConstants.hour / MetricConstants.mile)
    * inMetersPerSecond speed
