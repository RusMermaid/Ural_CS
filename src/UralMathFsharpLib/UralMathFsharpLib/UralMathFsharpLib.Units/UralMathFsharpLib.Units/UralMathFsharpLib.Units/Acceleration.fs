/// <category>Module: Unit System</category>
/// <summary>
/// An <c>Acceleration</c> represents an acceleration in meters per second squared,
/// feet per second squared or
/// <a href="https://en.wikipedia.org/wiki/G-force#Unit_and_measurement">gees</a>.
/// It is stored as a number of meters per second squared.
/// </summary>
/// 
/// <example>
/// You can also do rate-related calculations with <c>Acceleration</c> values to compute
/// <c>Speed</c> or <c>Duration</c>:
/// <code lang="fsharp">
///     let changeInSpeed =
///         acceleration |&gt; Quantity.for duration
///     let alsoChangeInSpeed =
///         duration |&gt; Quantity.at acceleration
///     let duration =
///         changeInSpeed |&gt; Quantity.at_ acceleration
/// </code></example>
///
/// <note>
/// Since <c>MetersPerSecondSquared</c> is defined as <c>Rate MetersPerSecond Seconds</c>
/// (change in speed per unit time), you can construct an <c>Acceleration</c>
/// value using <c>Quantity.per</c>:
/// <code lang="fsharp">
///     let acceleration =
///         changeInSpeed |&gt; Quantity.per duration
/// </code>
/// </note>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Acceleration

open UralMathFsharpLibUnits

/// <category>Metric</category>
/// Construct an acceleration from a number of meters per second squared.
let metersPerSecondSquared (numMetersPerSecondSquared: float) : Acceleration = Quantity numMetersPerSecondSquared

/// <category>Metric</category>
/// Convert an acceleration to a number of meters per second squared.
let inMetersPerSecondSquared (numMetersPerSecondSquared: Acceleration) : float = numMetersPerSecondSquared.Value

/// <category>Imperial</category>
/// Construct an acceleration from a number of feet per second squared.
let feetPerSecondSquared (numFeetPerSecondSquared: float) : Acceleration =
    metersPerSecondSquared (MetricConstants.foot * numFeetPerSecondSquared)

/// <category>Imperial</category>
/// Convert an acceleration to a number of feet per second squared.
let inFeetPerSecondSquared (acceleration: Acceleration) : float =
    inMetersPerSecondSquared acceleration
    / MetricConstants.foot

/// <category>Imperial</category>
/// <summary>
/// Construct an acceleration from a number of
/// <a href="https://en.wikipedia.org/wiki/G-force#Unit_and_measurement">gees</a>.
/// One gee is equal to 9.80665 meters per second squared (the
/// standard acceleration due to gravity).
/// </summary>
/// 
/// <example>
/// <code lang="fsharp">
///     Acceleration.gees 1 = Acceleration.metersPerSecondSquared 9.80665
/// </code>
/// </example>
let gees (numGees: float) : Acceleration =
    metersPerSecondSquared (MetricConstants.gee * numGees)

/// <category>Imperial</category>
/// Convert an acceleration to a number of gees.
let inGees (acceleration: Acceleration) : float =
    inMetersPerSecondSquared acceleration
    / MetricConstants.gee
