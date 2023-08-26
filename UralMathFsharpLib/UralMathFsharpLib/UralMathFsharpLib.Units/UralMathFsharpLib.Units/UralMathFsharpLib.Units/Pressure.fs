/// <category>Module: Unit System</category>
/// <summary>
/// A <c>Pressure</c> value represents a pressure in kilopascals, pounds per square
/// inch, <a href="https://en.wikipedia.org/wiki/Atmosphere_(unit)">atmospheres</a>
/// etc. It is stored as a number of pascals.
/// </summary>
/// 
/// <note>
/// Since <c>Pascals</c> is defined as <c>Rate Newtons SquareMeters</c> (force per
/// unit area), you can construct a <c>Pressure</c> value using <c>Quantity.per</c>:
///     pressure =
///         force |&gt; Quantity.per area
/// You can also do rate-related calculations with <c>Pressure</c> values to compute
/// <c>Force</c> or <c>Area</c>:
/// <code>
///     let force =
///         area |&gt; Quantity.at pressure
///     let area =
///         force |&gt; Quantity.at_ pressure
/// </code>
/// </note>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Pressure

open UralMathFsharpLibUnits

/// <category>Metric</category>
/// Construct a pressure from a number of pascals.
let pascals (numPascals: float) : Pressure = Quantity numPascals

/// <category>Metric</category>
/// Convert a pressure to a number of pascals.
let inPascals (numPascals: Pressure) : float = numPascals.Value

/// <category>Metric</category>
/// Construct a pressure from a number of kilopascals.
let kilopascals (numKilopascals: float) : Pressure = pascals (1000. * numKilopascals)

/// <category>Metric</category>
/// Convert a pressure to a number of kilopascals.
let inKilopascals (pressure: Pressure) : float = inPascals pressure / 1000.

/// <category>Metric</category>
/// Construct a pressure from a number of megapascals.
let megapascals (numMegapascals: float) : Pressure = pascals (1.0e6 * numMegapascals)

/// Convert a pressure to a number of megapascals.
/// <category>Metric</category>
let inMegapascals (pressure: Pressure) : float = inPascals pressure / 1.0e6

/// <category>Imperial</category>
/// Construct a pressure from a number of pounds per square inch.
let poundsPerSquareInch (value: float) : Pressure =
    Force.pounds value
    |> Quantity.per (Area.squareInches 1.)

/// <category>Imperial</category>
/// Convert a pressure to a number of pounds per square inch.
let inPoundsPerSquareInch (pressure: Pressure) : float =
    Area.squareInches 1.
    |> Quantity.at pressure
    |> Force.inPounds

/// <category>Atmospheric</category>
/// <summary>
/// Construct a pressure from a number of <a href="https://en.wikipedia.org/wiki/Atmosphere_(unit)">atmospheres</a>.
/// </summary>
let atmospheres (numAtmospheres: float) : Pressure =
    pascals (MetricConstants.atmosphere * numAtmospheres)

/// <category>Atmospheric</category>
/// Convert a pressure to a number of atmospheres.
let inAtmospheres (pressure: Pressure) : float =
    inPascals pressure / MetricConstants.atmosphere
