/// <category>Other</category>
/// <summary>
/// All conversion factors sourced from 
/// <a href="https://www.nist.gov/pml/weights-and-measures/publications/nist-handbooks/handbook-44">National Institute of Standards and Technology</a>
/// unless otherwise specified.
/// </summary>
module UralMathFsharpLibUnits.MetricConstants

open System

open UralMathFsharpLib.Units

// ---- Units of length (in Meters) --------------------------------------------

// ---- Metric ----

[<Literal>]
let meter = 1.

let angstrom = 1.e-10 * meter
let nanometer = 1.e-9 * meter
let micron = 1.e-6 * meter
let millimeter = 1.e-3 * meter
let centimeter = 1.e-2 * meter
let kilometer = 1.e3 * meter


// ---- Imperial ----

let inch = 0.0254 * meter
let foot = 12. * inch
let yard = 3. * foot
let thou = 1.e-3 * inch
let mile = 5280. * foot


// ---- Astronomical ----

let astronomicalUnit = 149597870700. * meter
let lightYear = 9460730472580800. * meter

let parsec =
    (648000. / Math.PI) * astronomicalUnit


// ---- Digital Conversions ----

let cssPixel = inch / 96.
let point = inch / 72.
let pica = inch / 6.



// ---- Units of Area (in Square Meters) ---------------------------------------

let squareInch: float = inch * inch
let squareFoot: float = foot * foot
let squareYard: float = yard * yard
let squareMile: float = mile * mile
let acre: float = 43560. * squareFoot


// ---- Units of Volume (in Cubic Meters) --------------------------------------

let cubicMeter: float =
    meter * meter * meter

let liter: float = 0.001 * cubicMeter

/// <summary>
/// Sourced from <a href="https://www.nist.gov/pml/weights-and-measures/publications/nist-handbooks/handbook-44">UK Weights and Measures Act</a>. One imperial gallon is equal to
/// 4.54609 cubic decimeters (formerly defined as the volume of one kilogram
/// of pure water under standard conditions, now equal to 1 liter).
/// </summary>
let imperialGallon: float = 4.54609 * liter

let imperialQuart: float =
    imperialGallon / 4.

let imperialPint: float = imperialQuart / 2.

let imperialFluidOunce: float =
    imperialPint / 20.

let cubicInch: float = inch * inch * inch
let cubicFoot: float = foot * foot * foot
let cubicYard: float = yard * yard * yard
let usLiquidGallon: float = 231. * cubicInch

let usLiquidQuart: float =
    usLiquidGallon / 4.

let usLiquidPint: float = usLiquidQuart / 2.
let usFluidOunce: float = usLiquidPint / 16.
let bushel: float = 2150.42 * cubicInch
let peck: float = bushel / 4.
let usDryGallon: float = peck / 2.

let usDryQuart: float =
    67.200625 * cubicInch

let usDryPint: float = usDryQuart / 2.


// ---- Units of Mass (in Kilograms) -------------------------------------------

[<Literal>]
let kilogram: float = 1.

let pound: float = 0.45359237 * kilogram
let longTon: float = 2240. * pound
let shortTon: float = 2000. * pound
let ounce: float = pound / 16.


/// ---- Units of Duration (in Seconds) ----------------------------------------

[<Literal>]
let second: float = 1.

let minute: float = 60. * second
let hour: float = 60. * minute
let day: float = 24. * hour
let week: float = 7. * day
let julianYear: float = 365.25 * day


/// ---- Units of substance amount (in Moles) ----------------------------------

let mole: float = 1


// ---- Units of Acceleration (in Meters per Second Squared) -------------------

let gee: float =
    9.80665 * meter / (second * second)


// ---- Units of Force (in Newtons) --------------------------------------------

let newton: float =
    kilogram * meter / (second * second)

let poundForce: float =
    4.4482216152605 * newton


// ---- Units of Power (in Watts) ----------------------------------------------

let watt: float = newton * meter / second

let electricalHorsepower: float =
    746. * watt

let mechanicalHorsepower: float =
    33000. * foot * poundForce / minute

let metricHorsepower: float =
    75. * kilogram * gee * meter / second


// ---- Units of Pressure (in Pascals) -----------------------------------------

let pascal: float = newton / (meter * meter)
let atmosphere: float = 101325. * pascal


// ---- Angles -----------------------------------------------------------------
    
let radiansToDegrees: float =
    180. / Math.PI

let degreesToRadians: float =
    Math.PI / 180.
