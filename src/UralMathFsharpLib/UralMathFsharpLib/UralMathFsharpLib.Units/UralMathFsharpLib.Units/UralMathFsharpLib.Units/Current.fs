/// <category>Module: Unit System</category>
/// <summary>
/// A <c>Current</c> value represents an electrical current in amperes.
/// </summary>
/// 
/// <note>
/// Since <c>Amperes</c> is defined as <c>Rate Coulombs Seconds</c> (charge
/// per unit time), you can construct a <c>Current</c> value using <c>Quantity.per</c>:
/// <code>
///     let current =
///         charge |&gt; Quantity.per duration
/// </code>
/// </note>
///
/// <example>
/// You can also do rate-related calculations with <c>Current</c> values to compute
/// <c>Charge</c> or <c>Duration</c>:
/// <code>
///     let charge =
///         current |&gt; Quantity.for duration
///     let alsoCharge =
///         duration |&gt; Quantity.at current
///     let duration =
///         charge |&gt; Quantity.at_ current
/// </code>
/// </example>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Current

/// <category>Conversions</category>
/// Construct a current from a number of amperes.
let amperes (numAmperes: float) : Current = Quantity numAmperes


/// <category>Conversions</category>
/// <summary>
/// Convert a current to a number of amperes.
/// </summary>
/// 
/// <example><code>
///    Charge.coulombs 10
///        |&gt; Quantity.per (Duration.seconds 2)
///        |&gt; Current.inAmperes
///    --&gt; 5
/// </code></example>
let inAmperes (numAmperes: Current) : float = numAmperes.Value

/// <category>Conversions</category>
/// <summary>
/// Construct a current from a number of milliamperes.
/// </summary>
/// 
/// <example><code>
///    Current.milliamperes 500
///    --&gt; Current.amperes 0.5
/// </code></example>
let milliamperes (numMilliamperes: float) : Current = amperes (numMilliamperes * 1.0e-3)

/// <category>Conversions</category>
/// <summary>
/// Convert a current to number of milliamperes.
/// </summary>
/// 
/// <example><code>
///    Current.amperes 2 |&gt; Current.inMilliamperes
///    --&gt; 2000
/// </code></example>
let inMilliamperes (current: Current) : float = inAmperes current / 1.0e-3
