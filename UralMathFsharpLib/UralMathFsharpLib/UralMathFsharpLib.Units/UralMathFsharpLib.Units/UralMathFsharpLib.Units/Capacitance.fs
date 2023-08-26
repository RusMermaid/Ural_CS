/// <category>Module: Unit System</category>
/// <summary>
/// A <c>Capacitance</c> value represents an electrical capacitance in farads.
/// Note that since <c>Capacitance</c> is defined as <c>Rate&lt;Coulombs, Volts&gt;</c> (charge per
/// voltage) .
/// </summary>
/// 
/// <example>
/// <para>
/// You can construct a <c>Capacitance</c> value using <c>Quantity.per</c>:
/// </para>
/// <code>
///     let capacitance =
///         charge |&gt; Quantity.per voltage
/// </code>
/// <para>
/// You can also compute <c>Charge</c> and <c>Voltage</c> using <c>Capacitance</c>:
/// </para>
/// <code>
///     let charge =
///         voltage |&gt; Quantity.at capacitance
///     let voltage =
///         charge |&gt; Quantity.at_ capacitance
/// </code>
/// </example>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Capacitance

/// <category>Conversions</category>
/// Construct capacitance from a number of farads.
let farads (numFarads: float) : Capacitance = Quantity numFarads

/// <category>Conversions</category>
/// Convert capacitance to a number of farads.
let inFarads (numFarads: Capacitance) : float = numFarads.Value

/// <category>Conversions</category>
/// Construct a capacitance from a number of microfarads.
let microfarads (numMicrofarads: float) = farads (numMicrofarads * 1.0e-6)

/// <category>Conversions</category>
/// Convert a capacitance to a number of microfarads
let inMicrofarads (capacitance: Capacitance) : float = inFarads capacitance / 1.0e-6

/// <category>Conversions</category>
/// Construct a capacitance from a number of nanofarads
let nanofarads (numNanofarads: float) : Capacitance = farads (numNanofarads * 1.0e-9)

/// <category>Conversions</category>
/// Convert a capacitance to a number of nanofarads
let inNanofarads (capacitance: Capacitance) : float = inFarads capacitance / 1.0e-9

/// <category>Conversions</category>
/// Construct capacitance from a number of picofarads.
let picofarads (numPicofarads: float) : Capacitance = farads (numPicofarads * 1.0e-12)

/// <category>Conversions</category>
/// Convert a capacitance to a number of picofarads.
let inPicofarads (capacitance: Capacitance) : float = inFarads capacitance / 1.0e-12
