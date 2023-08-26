/// <category>Module: Unit System</category>
/// <summary>
/// A <c>Voltage</c> value represents a voltage (electric potential difference, if
/// we're being picky) in volts.
/// </summary>
///
/// <note>
/// <para>
/// Since <c>Volts</c> is defined as <c>Rate Watts Amperes</c> (power per unit
/// current), you can do rate-related calculations with <c>Voltage</c> values to compute
/// <c>Power</c> or <c>Current</c>:
/// </para>
/// <code>
///     // elm-units version of 'P = V * I'
///     power =
///         current |&gt; Quantity.at voltage
///     // I = P / V
///     current =
///         power |&gt; Quantity.at_ voltage
/// </code>
/// <para>
/// Just for fun, note that since you can also express <c>Voltage</c> in terms of
/// <c>Current</c> and <c>Resistance</c>, you could rewrite the second example
/// above as
/// </para>
/// <code>
///     // P = I^2 * R
///     let power =
///         current
///             |&gt; Quantity.at
///                 (current
///                     |&gt; Quantity.at resistance
///                 )
/// </code>
/// </note>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Voltage


/// <category>Conversions</category>
/// Construct a voltage from a number of volts.
let volts (numVolts: float) : Voltage = Quantity numVolts


/// <category>Conversions</category>
/// Convert a voltage to a number of volts.
let inVolts (numVolts: Voltage) : float = numVolts.Value
