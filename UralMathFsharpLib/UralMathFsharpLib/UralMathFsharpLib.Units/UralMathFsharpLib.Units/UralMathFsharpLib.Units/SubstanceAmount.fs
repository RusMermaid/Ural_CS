/// <category>Module: Unit System</category>
/// <summary>
/// A <c>SubstanceAmount</c> value represents a substance amount in
/// <a href="https://en.wikipedia.org/wiki/Mole_(unit)">moles</a>.
/// </summary>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.SubstanceAmount

/// <category>Conversions</category>
/// Construct a substance amount from a number of moles.
let moles (numMoles: float) : SubstanceAmount = Quantity numMoles

/// <category>Conversions</category>
/// Convert a substance amount to a number of moles.
let inMoles (numMoles: SubstanceAmount) : float = numMoles.Value

/// <category>Conversions</category>
/// Construct a substance amount from a number of picomoles.
let picomoles (numPicomoles: float) : SubstanceAmount = moles (numPicomoles * 1.0e-12)

/// <category>Conversions</category>
/// Convert a substance amount to a number of picomoles.
let inPicomoles (substanceAmount: SubstanceAmount) : float = inMoles substanceAmount / 1.0e-12

/// <category>Conversions</category>
/// Construct a substance amount from a number of nanomoles.
let nanomoles (numNanomoles: float) : SubstanceAmount = moles (numNanomoles * 1.0e-9)

/// <category>Conversions</category>
/// Convert a substance amount to a number of nanomoles.
let inNanomoles (substanceAmount: SubstanceAmount) : float = inMoles substanceAmount / 1.0e-9

/// <category>Conversions</category>
/// Construct a substance amount from a number of micromoles.
let micromoles (numMicromoles: float) : SubstanceAmount = moles (numMicromoles * 1.0e-6)

/// <category>Conversions</category>
/// Convert a substance amount to a number of micromoles.
let inMicromoles (substanceAmount: SubstanceAmount) : float = inMoles substanceAmount / 1.0e-6

/// <category>Conversions</category>
/// Construct a substance amount from a number of millimoles.
let millimoles (numMillimoles: float) : SubstanceAmount = moles (numMillimoles * 1.0e-3)

/// <category>Conversions</category>
/// Convert a substance amount to a number of millimoles.
let inMillimoles (substanceAmount: SubstanceAmount) : float = inMoles substanceAmount / 1.0e-3

/// <category>Conversions</category>
/// Construct a substance amount from a number of centimoles.
let centimoles (numCentimoles: float) : SubstanceAmount = moles (numCentimoles * 1.0e-2)

/// <category>Conversions</category>
/// Convert a substance amount to a number of centimoles.
let inCentimoles (substanceAmount: SubstanceAmount) : float = inMoles substanceAmount / 1.0e-2

/// <category>Conversions</category>
/// Construct a substance amount from a number of decimoles.
let decimoles (numDecimoles: float) : SubstanceAmount = moles (numDecimoles * 1.0e-1)

/// <category>Conversions</category>
/// Convert a substance amount to a number of decimoles.
let inDecimoles (substanceAmount: SubstanceAmount) : float = inMoles substanceAmount / 1.0e-1

/// <category>Conversions</category>
/// Construct a substance amount from a number of kilomoles.
let kilomoles (numKilomoles: float) : SubstanceAmount = moles (numKilomoles * 1.0e3)

/// <category>Conversions</category>
/// Convert a substance amount to a number of kilomoles.
let inKilomoles (substanceAmount: SubstanceAmount) : float = inMoles substanceAmount / 1.0e3

/// <category>Conversions</category>
/// Construct a substance amount from a number of megamoles.
let megamoles (numMegamoles: float) : SubstanceAmount = moles (numMegamoles * 1.0e6)

/// <category>Conversions</category>
/// Convert a substance amount to a number of megamoles.
let inMegamoles (substanceAmount: SubstanceAmount) : float = inMoles substanceAmount / 1.0e6

/// <category>Conversions</category>
/// Construct a substance amount from a number of gigamoles.
let gigamoles (numGigamoles: float) : SubstanceAmount = moles (numGigamoles * 1.0e9)

/// <category>Conversions</category>
/// Convert a substance amount to a number of gigamoles.
let inGigamoles (substanceAmount: SubstanceAmount) : float = inMoles substanceAmount / 1.0e9
