/// <category>Module: Unit System</category>
/// <summary>
/// A <c>Molarity</c> value represents a concentration of substance in moles per
/// cubic meter, moles per liter, millimoles per liter etc. It is stored as a number
/// of moles per cubic meter.
/// </summary>
/// 
/// <note>
/// The <a href="https://www.nist.gov/pml/special-publication-811/nist-guide-si-chapter-8">NIST Guide to the SI</a>
/// states that the term "molarity" is considered obsolete, but it appears to still
/// be in common use and is far less verbose than the alternative NIST suggestion of
/// "amount-of-substance concentration".
/// Since the units of <c>Molarity</c> are defined to be <c>Rate Moles CubicMeters</c> (amount
/// of substance per unit volume), you can construct a <c>Molarity</c> value using
/// <c>Quantity.per</c>:
/// <code>
///     molarity =
///         substanceAmount |&gt; Quantity.per volume
/// </code>
/// </note>
///
/// <note>
/// You can also do rate-related calculations with <c>Molarity</c> values to compute
/// <c>SubstanceAmount</c> or <c>Volume</c>:
/// <code>
///     let substanceAmount =
///         volume |&gt; Quantity.at molarity
///     let volume =
///         substanceAmount |&gt; Quantity.at_ molarity
/// </code>
/// </note>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Molarity

open UralMathFsharpLibUnits


// ---- Constants --------------------------------------------------------------

/// <category>Constants</category>
/// One mole per liter, in moles per cubic meter
let oneMolePerLiter =
    MetricConstants.mole / MetricConstants.liter

/// <category>Constants</category>
/// One decimole per liter, in moles per cubic meter
let oneDecimolePerLiter =
    0.1 * MetricConstants.mole / MetricConstants.liter


// ---- Conversions ------------------------------------------------------------

/// <category>Conversions</category>
/// Construct a molarity from a number of moles per cubic meter.
let molesPerCubicMeter (numMolesPerCubicMeter: float) : Molarity = Quantity numMolesPerCubicMeter

/// <category>Conversions</category>
/// Convert a molarity to a number of moles per cubic meter.
let inMolesPerCubicMeter (numMolesPerCubicMeter: Molarity) : float = numMolesPerCubicMeter.Value

/// <category>Conversions</category>
/// Construct a molarity from a number of moles per liter.
let molesPerLiter (numMolesPerLiter: float) : Molarity =
    molesPerCubicMeter (numMolesPerLiter * oneMolePerLiter)

/// <category>Conversions</category>
/// Convert a molarity to a number of moles per liter.
let inMolesPerLiter (molarity: Molarity) : float =
    inMolesPerCubicMeter molarity / oneMolePerLiter


/// <category>Conversions</category>
/// Construct a molarity from a number of decimoles per liter.
let decimolesPerLiter (numDecimolesPerLiter: float) : Molarity =
    molesPerCubicMeter (numDecimolesPerLiter * oneDecimolePerLiter)

/// <category>Conversions</category>
/// Convert a molarity to a number of decimoles per liter.
let inDecimolesPerLiter (molarity: Molarity) : float =
    inMolesPerCubicMeter molarity
    / oneDecimolePerLiter

/// <category>Conversions</category>
/// Construct a molarity from a number of centimoles per liter.
let centimolesPerLiter (numCentimolesPerLiter: float) : Molarity =
    decimolesPerLiter (10. * numCentimolesPerLiter)

/// <category>Conversions</category>
/// Convert a molarity to a number of centimoles per liter.
let inCentimolesPerLiter (molar: Molarity) : float = inDecimolesPerLiter molar / 10.

/// <category>Conversions</category>
/// Construct a molarity from a number of millimoles per liter.
let millimolesPerLiter (numMillimolesPerLiter: float) : Molarity =
    decimolesPerLiter (100. * numMillimolesPerLiter)

/// <category>Conversions</category>
/// Convert a molarity to a number of millimoles per liter.
let inMillimolesPerLiter (molar: Molarity) : float = inDecimolesPerLiter molar / 100.

/// <category>Conversions</category>
/// Construct a molarity from a number of micromoles per liter.
let micromolesPerLiter (numMicromolesPerLiter: float) : Molarity =
    decimolesPerLiter (1000. * numMicromolesPerLiter)

/// <category>Conversions</category>
/// Convert a molarity to a number of micromoles per liter.
let inMicromolesPerLiter (molar: Molarity) : float = inDecimolesPerLiter molar / 1000.
