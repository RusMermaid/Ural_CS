/// <category>Module: Unit System</category>
/// <summary>
/// An <c>Inductance</c> value represents an electrical inductance in henries.
/// </summary>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Inductance

/// <category>Conversions</category>
/// Construct an inductance from a number of henries.
let henries (numHenries: float) : Inductance = Quantity numHenries

/// <category>Conversions</category>
/// Convert an inductance to a number of henries.
let inHenries (numHenries: Inductance) : float = numHenries.Value

/// <category>Conversions</category>
/// Construct an inductance from a number of millihenries.
let millihenries (numMilliHenries: float) : Inductance = henries (numMilliHenries * 1.0e-3)

/// <category>Conversions</category>
/// Convert an inductance to a number of millihenries.
let inMillihenries (inductance: Inductance) : float = inHenries inductance / 1.0e-3

/// <category>Conversions</category>
/// Construct an inductance from a number of microhenries.
let microhenries (numMicroHenries: float) : Inductance = henries (numMicroHenries * 1.0e-6)

/// <category>Conversions</category>
/// Convert an inductance to a number of microhenries.
let inMicrohenries (inductance: Inductance) : float = inHenries inductance / 1.0e-6

/// <category>Conversions</category>
/// Construct an inductance from a number of nanohenries.
let nanohenries (numNanoHenries: float) : Inductance = henries (numNanoHenries * 1.0e-9)

/// <category>Conversions</category>
/// Convert an inductance to a number of nanohenries.
let inNanohenries (inductance: Inductance) : float = inHenries inductance / 1.0e-9

/// <category>Conversions</category>
/// Construct an inductance from a number of kilohenries.
let kilohenries (numKiloHenries: float) : Inductance = henries (numKiloHenries * 1.0e3)

/// <category>Conversions</category>
/// Convert an inductance to a number of kilohenries.
let inKilohenries (inductance: Inductance) : float = inHenries inductance / 1.0e3
