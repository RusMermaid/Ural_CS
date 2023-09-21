/// <category>Module: Unit System</category>
/// <summary>
/// An <c>Area</c> represents an area in square meters, square feet, acres, hectares
/// etc. It is stored as a number of square meters.
/// Note that you can construct an <c>Area</c> value directly using the functions in this
/// module, but it also works to call <c>Quantity.squared</c> on a
/// <c>Length</c> or <c>Quantity.times</c> on a pair of <c>Length</c>s.
/// </summary>
///
/// <example>
/// The following are all equivalent:
/// <code>
/// Area.squareFeet 100
/// Quantity.squared (Length.feet 10)
/// Length.feet 25 |&gt; Quantity.times (Length.feet 4)
/// </code>
/// </example>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Area

open UralMathFsharpLibUnits

/// <category>Conversions</category>
/// Construct an area from a number of square meters.
let squareMeters (numSquareMeters: float) : Area = Quantity numSquareMeters


/// <category>Conversions</category>
/// Convert an area to a number of square meters.
let inSquareMeters (numSquareMeters: Area) : float = numSquareMeters.Value


/// <category>Conversions</category>
/// Construct an area from a number of square millimeters.
let squareMillimeters (numSquareMillimeters: float) : Area =
    squareMeters (1.0e-6 * numSquareMillimeters)


/// <category>Conversions</category>
/// Convert an area to a number of square millimeters.
let inSquareMillimeters (area: Area) : float = 1.0e6 * inSquareMeters area


/// <category>Conversions</category>
/// Construct an area from a number of square inches.
let squareInches (numSquareInches: float) : Area =
    squareMeters (MetricConstants.squareInch * numSquareInches)


/// <category>Conversions</category>
/// Convert an area to a number of square inches.
let inSquareInches (area: Area) : float =
    inSquareMeters area / MetricConstants.squareInch


/// <category>Conversions</category>
/// Construct an area from a number of square centimeters.
let squareCentimeters (numSquareCentimeters: float) : Area =
    squareMeters (1.0e-4 * numSquareCentimeters)


/// <category>Conversions</category>
/// Convert an area to a number of square centimeters.
let inSquareCentimeters (area: Area) : float = 1.0e4 * inSquareMeters area


/// <category>Conversions</category>
/// Construct an area from a number of square feet.
let squareFeet (numSquareFeet: float) : Area =
    squareMeters (MetricConstants.squareFoot * numSquareFeet)


/// <category>Conversions</category>
/// Convert an area to a number of square feet.
let inSquareFeet (area: Area) : float =
    inSquareMeters area / MetricConstants.squareFoot


/// <category>Conversions</category>
/// Construct an area from a number of square yards.
let squareYards (numSquareYards: float) : Area =
    squareMeters (MetricConstants.squareYard * numSquareYards)


/// <category>Conversions</category>
/// Convert an area to a number of square yards.
let inSquareYards (area: Area) : float =
    inSquareMeters area / MetricConstants.squareYard


/// <category>Conversions</category>
/// Construct an area from a number of hectares.
let hectares (numHectares: float) : Area = squareMeters (1.0e4 * numHectares)


/// <category>Conversions</category>
/// Convert an area to a number of hectares.
let inHectares (area: Area) : float = 1.0e-4 * inSquareMeters area


/// <category>Conversions</category>
/// Construct an area from a number of square kilometers.
let squareKilometers (numSquareKilometers: float) : Area =
    squareMeters (1.0e6 * numSquareKilometers)


/// <category>Conversions</category>
/// Convert an area to a number of square kilometers.
let inSquareKilometers (area: Area) : float = 1.0e-6 * inSquareMeters area


/// <category>Conversions</category>
/// Construct an area from a number of acres.
let acres (numAcres: float) : Area =
    squareMeters (MetricConstants.acre * numAcres)


/// <category>Conversions</category>
/// Convert an area to a number of acres.
let inAcres (area: Area) : float = inSquareMeters area / MetricConstants.acre


/// <category>Conversions</category>
/// Construct an area from a number of square miles.
let squareMiles (numSquareMiles: float) : Area =
    squareMeters (MetricConstants.squareMile * numSquareMiles)


/// <category>Conversions</category>
/// Convert an area to a number of square miles.
let inSquareMiles (area: Area) : float =
    inSquareMeters area / MetricConstants.squareMile


// ---- Constants --------------------------------------------------------------

/// <category>Constants</category>
/// One square meter.
let squareMeter: Area = squareMeters 1.

/// <category>Constants</category>
/// One square millimeter.
let squareMillimeter: Area =
    squareMillimeters 1.

/// <category>Constants</category>
/// One square centimeter.
let squareCentimeter: Area =
    squareCentimeters 1.

/// <category>Constants</category>
/// One hectare.
let hectare: Area = hectares 1.

/// <category>Constants</category>
/// One square kilometer.
let squareKilometer: Area =
    squareKilometers 1.

/// <category>Constants</category>
/// One square inch.
let squareInch: Area = squareInches 1.

/// <category>Constants</category>
/// One square foot.
let squareFoot: Area = squareFeet 1.

/// <category>Constants</category>
/// One square yard.
let squareYard: Area = squareYards 1.

/// <category>Constants</category>
/// One acre.
let acre: Area = acres 1.

/// <category>Constants</category>
/// One square mile.
let squareMile: Area = squareMiles 1.
