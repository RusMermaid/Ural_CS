/// <category>Module: Unit System</category>
/// <summary>
/// A <c>Charge</c> value represents an electrical charge in coulombs or ampere
/// hours. It is stored as a number of coulombs.
/// </summary>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module Math.Units.Charge

open UralMathFsharpLib.Units
open UralMathFsharpLibUnits

/// <category>Conversions</category>
/// Construct a charge from a number of coulombs.
let coulombs (numCoulombs: float) : Charge = Quantity numCoulombs

/// <category>Conversions</category>
/// Convert a charge to a number of coulombs.
let inCoulombs (numCoulombs: Charge) : float = numCoulombs.Value

/// <category>Conversions</category>
/// Construct a charge from a number of ampere hours.
let ampereHours (numAmpereHours: float) : Charge =
    coulombs (MetricConstants.hour * numAmpereHours)

/// <category>Conversions</category>
/// Convert a charge to a number of ampere hours.
let inAmpereHours (charge: Charge) : float = inCoulombs charge / MetricConstants.hour

/// <category>Conversions</category>
/// Construct a charge from a number of milliampere hours.
let milliampereHours (numMilliampereHours: float) : Charge =
    coulombs (MetricConstants.hour * numMilliampereHours / 1000.)

/// <category>Conversions</category>
/// Convert a charge to a number of milliampere hours.
let inMilliampereHours (charge: Charge) : float =
    inCoulombs charge * 1000. / MetricConstants.hour
