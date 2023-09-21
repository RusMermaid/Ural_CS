/// <category>Module: Unit System</category>
/// <summary>
/// A <c>Mass</c> represents a mass in kilograms, pounds, metric or imperial tons
/// etc. It is stored as a number of kilograms.
/// </summary>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Mass

open UralMathFsharpLibUnits

/// <category>Metric</category>
/// Construct a mass from a number of kilograms.
let kilograms (numKilograms: float) : Mass = Quantity numKilograms

/// <category>Metric</category>
/// Convert a mass to a number of kilograms.
let inKilograms (numKilograms: Mass) : float = numKilograms.Value

/// <category>Metric</category>
/// Construct a mass from a number of grams.
let grams (numGrams: float) : Mass = kilograms (0.001 * numGrams)

/// <category>Metric</category>
/// Convert a mass to a number of grams.
let inGrams (mass: Mass) : float = 1000. * inKilograms mass

/// <category>Imperial</category>
/// Construct a mass from a number of pounds.
let pounds (numPounds: float) : Mass = kilograms (MetricConstants.pound * numPounds)

/// <category>Imperial</category>
/// Convert a mass to a number of pounds.
let inPounds (mass: Mass) : float = inKilograms mass / MetricConstants.pound

/// <category>Imperial</category>
/// Construct a mass from a number of ounces.
let ounces (numOunces: float) : Mass = kilograms (MetricConstants.ounce * numOunces)

/// <category>Imperial</category>
/// <summary>
/// Convert a mass to a number of ounces.
/// <code>
///    Mass.pounds 1 |&gt; Mass.inOunces
///    --&gt; 16
/// </code>
/// </summary>
let inOunces (mass: Mass) : float = inKilograms mass / MetricConstants.ounce

/// <category>Imperial</category>
/// <summary>
/// Construct a mass from a number of <a href="https://en.wikipedia.org/wiki/Tonne">metric tons</a>.
/// <code>
///    Mass.metricTons 1
///    --&gt; Mass.kilograms 1000
/// </code>
/// </summary>
let metricTons (numTonnes: float) : Mass = kilograms (1000. * numTonnes)

/// <category>Imperial</category>
/// Convert a mass to a number of metric tons.
let inMetricTons (mass: Mass) : float = 0.001 * inKilograms mass

/// <category>Imperial</category>
/// <summary>
/// Construct a mass from a number of <a href="https://en.wikipedia.org/wiki/Short_ton">short tons</a>. This is the 'ton'
/// commonly used in the United States.
/// <code>
///     Mass.shortTons 1
///     --&gt; Mass.pounds 2000
/// </code>
/// </summary>
let shortTons (numShortTons: float) : Mass =
    kilograms (MetricConstants.shortTon * numShortTons)

/// <category>Imperial</category>
/// Convert a mass to a number of short tons.
let inShortTons (mass: Mass) : float = inKilograms mass / MetricConstants.shortTon

/// <category>Imperial</category>
/// <summary>
/// Construct a mass from a number of
/// <a href="https://en.wikipedia.org/wiki/Long_ton">long tons</a>.
/// This is the 'ton' commonly used in the United Kingdom and British Commonwealth.
/// <code>
///     Mass.longTons 1
///     --&gt; Mass.pounds 2240
/// </code>
/// </summary>
let longTons (numLongTons: float) : Mass =
    kilograms (MetricConstants.longTon * numLongTons)

/// <category>Imperial</category>
/// Convert a mass to a number of long tons.
let inLongTons (mass: Mass) : float = inKilograms mass / MetricConstants.longTon

/// <category>Constants</category>
/// One kilogram.
let kilogram = kilograms 1

/// <category>Constants</category>
/// One gram.
let gram = grams 1

/// <category>Constants</category>
/// One metric ton.
let metricTon = metricTons 1

/// <category>Constants</category>
/// One pound.
let pound = pounds 1

/// <category>Constants</category>
/// One ounce.
let ounce = ounces 1

/// <category>Constants</category>
/// One longTon.
let longTon = longTons 1

/// <category>Constants</category>
/// One shortTon.
let shortTon = shortTons 1
