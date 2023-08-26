/// <category>Module: Unit System</category>
/// <summary>
/// A <c>Density</c> value represents a density in grams per cubic centimeter, pounds
/// per cubic inch, etc. It is stored as a number of kilograms per cubic meter.
/// </summary>
/// 
/// <note>
/// <para>
/// Since <c>KilogramsPerCubicMeter</c> is defined as <c>Rate Kilograms
/// CubicMeters</c> (mass per unit volume), you can construct a <c>Density</c> value using
/// <c>Quantity.per</c>:
/// </para>
/// <code>
///     let density =
///         mass |&gt; Quantity.per volume
/// </code>
/// </note>
///
/// <example>
/// <para>
/// You can also do rate-related calculations with <c>Density</c> values to compute
/// <c>Mass</c> or <c>Volume</c>:
/// </para>
/// <code>
///     let mass =
///         volume |&gt; Quantity.at density
///     let volume =
///         mass |&gt; Quantity.at_ density
/// </code>
/// </example>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Density

open UralMathFsharpLibUnits

/// <category>Metric</category>
/// Construct a density from a number of kilograms per cubic meter.
let kilogramsPerCubicMeter (numKilogramsPerCubicMeter: float) : Density = Quantity numKilogramsPerCubicMeter


/// <category>Metric</category>
/// Convert a density to a number of kilograms per cubic meter.
let inKilogramsPerCubicMeter (numKilogramsPerCubicMeter: Density) : float = numKilogramsPerCubicMeter.Value

/// <category>Metric</category>
/// Construct a density from a number of grams per cubic centimeter.
let gramsPerCubicCentimeter (numGramsPerCubicCentimeter: float) : Density =
    kilogramsPerCubicMeter (1000. * numGramsPerCubicCentimeter)


/// <category>Metric</category>
/// Convert a density to a number of grams per cubic centimeter.
let inGramsPerCubicCentimeter (density: Density) : float =
    inKilogramsPerCubicMeter density / 1000.

/// <category>Imperial</category>
/// Construct a density from a number of pounds per cubic inch.
let poundsPerCubicInch (numPoundsPerCubicInch: float) : Density =
    kilogramsPerCubicMeter (
        MetricConstants.pound / MetricConstants.cubicInch
        * numPoundsPerCubicInch
    )

/// <category>Imperial</category>
/// Convert a density to a number of pounds per cubic inch.
let inPoundsPerCubicInch (density: Density) : float =
    inKilogramsPerCubicMeter density
    / (MetricConstants.pound / MetricConstants.cubicInch)

/// <category>Imperial</category>
/// Construct a density from a number of pounds per cubic foot.
let poundsPerCubicFoot (numPoundsPerCubicFoot: float) : Density =
    kilogramsPerCubicMeter (
        MetricConstants.pound / MetricConstants.cubicFoot
        * numPoundsPerCubicFoot
    )

/// <category>Imperial</category>
/// Convert a density to a number of pounds per cubic foot.
let inPoundsPerCubicFoot (density: Density) : float =
    inKilogramsPerCubicMeter density
    / (MetricConstants.pound / MetricConstants.cubicFoot)
