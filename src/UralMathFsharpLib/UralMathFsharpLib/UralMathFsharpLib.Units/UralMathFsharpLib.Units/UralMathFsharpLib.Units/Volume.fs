/// <category>Module: Unit System</category>
/// <summary>
/// A <c>Volume</c> represents a volume in cubic meters, cubic feet, liters, US
/// liquid gallons, imperial fluid ounces etc. It is stored as a number of cubic
/// meters.
/// </summary>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Volume

open UralMathFsharpLibUnits

// ---- Metric -----------------------------------------------------------------

/// <category index="1">Metric</category>
/// Construct a volume from a number of cubic meters.
let cubicMeters (numCubicMeters: float) : Volume = Quantity numCubicMeters

/// <category>Metric</category>
/// Convert a volume to a number of cubic meters.
let inCubicMeters (numCubicMeters: Volume) : float = numCubicMeters.Value

/// <category>Metric</category>
/// Construct a volume from a number of milliliters.
let milliliters (numMilliliters: float) : Volume = cubicMeters (1.0e-6 * numMilliliters)

/// <category>Metric</category>
/// Convert a volume to a number of milliliters.
let inMilliliters (volume: Volume) : float = 1.0e6 * inCubicMeters volume

/// <category>Metric</category>
/// Construct a volume from a number of cubic centimeters.
/// Alias for <c>milliliters</c>.
let cubicCentimeters (numCubicCentimeters: float) : Volume = milliliters numCubicCentimeters

/// <category>Metric</category>
/// Convert a volume to a number of cubic centimeters.
/// Alias for <c>inMilliliters</c>.
let inCubicCentimeters (volume: Volume) : float = inMilliliters volume

/// <category>Metric</category>
/// Construct a volume from a number of liters.
let liters (numLiters: float) : Volume = cubicMeters (0.001 * numLiters)

/// <category>Metric</category>
/// Convert a volume to a number of liters.
let inLiters (volume: Volume) : float = 1000. * inCubicMeters volume

// ---- Imperial ---------------------------------------------------------------

/// <category index="2">Imperial</category>
/// Construct a volume from a number of cubic inches.
let cubicInches (numCubicInches: float) : Volume =
    cubicMeters (MetricConstants.cubicInch * numCubicInches)

/// <category>Imperial</category>
/// Convert a volume to a number of cubic inches.
let inCubicInches (volume: Volume) : float =
    inCubicMeters volume / MetricConstants.cubicInch

/// <category>Imperial</category>
/// Construct a volume from a number of cubic feet.
let cubicFeet (numCubicFeet: float) : Volume =
    cubicMeters (MetricConstants.cubicFoot * numCubicFeet)

/// <category>Imperial</category>
/// Convert a volume to a number of cubic feet.
let inCubicFeet (volume: Volume) : float =
    inCubicMeters volume / MetricConstants.cubicFoot

/// <category>Imperial</category>
/// Construct a volume from a number of cubic yards.
let cubicYards (numCubicYards: float) : Volume =
    cubicMeters (MetricConstants.cubicYard * numCubicYards)

/// <category>Imperial</category>
/// Convert a volume to a number of cubic yards.
let inCubicYards (volume: Volume) : float =
    inCubicMeters volume / MetricConstants.cubicYard


/// <category>Imperial</category>
/// Construct a volume from a number of U.S. liquid gallon.
let usLiquidGallons (numUsLiquidGallons: float) : Volume =
    cubicMeters (numUsLiquidGallons * MetricConstants.usLiquidGallon)

/// <category>Imperial</category>
/// Convert a volume to a number of U.S. liquid gallons.
let inUsLiquidGallons (volume: Volume) : float =
    inCubicMeters volume / MetricConstants.usLiquidGallon

/// <category>Imperial</category>
/// Construct a volume from a number of U.S. dry gallons.
let usDryGallons (numUsDryGallons: float) : Volume =
    cubicMeters (numUsDryGallons * MetricConstants.usDryGallon)

/// <category>Imperial</category>
/// Convert a volume to a number of U.S. dry gallons.
let inUsDryGallons (volume: Volume) : float =
    inCubicMeters volume / MetricConstants.usDryGallon

/// <category>Imperial</category>
/// Construct a volume from a number of imperial gallons.
let imperialGallons (numImperialGallons: float) : Volume =
    cubicMeters (numImperialGallons * MetricConstants.imperialGallon)

/// <category>Imperial</category>
/// Convert a volume to a number of imperial gallons.
let inImperialGallons (volume: Volume) : float =
    inCubicMeters volume / MetricConstants.imperialGallon

/// <category>Imperial</category>
/// Construct a volume from a number of U.S. liquid quarts.
let usLiquidQuarts (numUsLiquidQuarts: float) : Volume =
    cubicMeters (numUsLiquidQuarts * MetricConstants.usLiquidQuart)

/// <category>Imperial</category>
/// Convert a volume to a number of U.S. liquid quarts.
let inUsLiquidQuarts (volume: Volume) : float =
    inCubicMeters volume / MetricConstants.usLiquidQuart

/// <category>Imperial</category>
/// Construct a volume from a number of U.S. dry quarts.
let usDryQuarts (numUsDryQuarts: float) : Volume =
    cubicMeters (numUsDryQuarts * MetricConstants.usDryQuart)

/// <category>Imperial</category>
/// Convert a volume to a number of U.S. dry quarts.
let inUsDryQuarts (volume: Volume) : float =
    inCubicMeters volume / MetricConstants.usDryQuart

/// <category>Imperial</category>
/// Construct a volume from a number of imperial quarts.
let imperialQuarts (numImperialQuarts: float) : Volume =
    cubicMeters (numImperialQuarts * MetricConstants.imperialQuart)

/// <category>Imperial</category>
/// Convert a volume to a number of imperial quarts.
let inImperialQuarts (volume: Volume) : float =
    inCubicMeters volume / MetricConstants.imperialQuart

/// <category>Imperial</category>
/// Construct a volume from a number of U.S. liquid pints.
let usLiquidPints (numUsLiquidPints: float) : Volume =
    cubicMeters (numUsLiquidPints * MetricConstants.usLiquidPint)

/// <category>Imperial</category>
/// Convert a volume to a number of U.S. liquid pints.
let inUsLiquidPints (volume: Volume) : float =
    inCubicMeters volume / MetricConstants.usLiquidPint

/// <category>Imperial</category>
/// Construct a volume from a number of U.S. dry pints.
let usDryPints (numUsDryPints: float) : Volume =
    cubicMeters (numUsDryPints * MetricConstants.usDryPint)

/// <category>Imperial</category>
/// Convert a volume to a number of U.S. dry pints.
let inUsDryPints (volume: Volume) : float =
    inCubicMeters volume / MetricConstants.usDryPint

/// <category>Imperial</category>
/// Construct a volume from a number of imperial pints.
let imperialPints (numImperialPints: float) : Volume =
    cubicMeters (numImperialPints * MetricConstants.imperialPint)

/// <category>Imperial</category>
/// Convert a volume to a number of imperial pints.
let inImperialPints (volume: Volume) : float =
    inCubicMeters volume / MetricConstants.imperialPint

/// <category>Imperial</category>
/// Construct a volume from a number of U.S. fluid ounces.
let usFluidOunces (numUsFluidOunces: float) : Volume =
    cubicMeters (numUsFluidOunces * MetricConstants.usFluidOunce)

/// <category>Imperial</category>
/// Convert a volume to a number of U.S. fluid ounces.
let inUsFluidOunces (volume: Volume) : float =
    inCubicMeters volume / MetricConstants.usFluidOunce

/// <category>Imperial</category>
/// Construct a volume from a number of imperial fluid ounces.
let imperialFluidOunces (numImperialFluidOunces: float) : Volume =
    cubicMeters (
        numImperialFluidOunces
        * MetricConstants.imperialFluidOunce
    )

/// <category>Imperial</category>
/// Convert a volume to a number of imperial fluid ounces.
let inImperialFluidOunces (volume: Volume) : float =
    inCubicMeters volume
    / MetricConstants.imperialFluidOunce

// ---- Constants --------------------------------------------------------------

/// <category index="3">Constants</category>
/// One cubic meter.
let cubicMeter: Volume = cubicMeters 1

/// <category>Constants</category>
/// One milliliter meter.
let milliliter: Volume = milliliters 1

/// <category>Constants</category>
/// One cubic centimeter.
let cubicCentimeter: Volume = milliliters 1

/// <category>Constants</category>
/// One liter.
let liter: Volume = liters 1

/// <category>Constants</category>
/// One cubic inch.
let cubicInch: Volume = cubicInches 1

/// <category>Constants</category>
/// One cubic foot.
let cubicFoot: Volume = cubicFeet 1

/// <category>Constants</category>
/// One cubic yard.
let cubicYard: Volume = cubicYards 1

/// <category>Constants</category>
/// One US liquid gallon.
let usLiquidGallon: Volume =
    usLiquidGallons 1

/// <category>Constants</category>
/// One US dry gallon.
let usDryGallon: Volume = usDryGallons 1

/// <category>Constants</category>
/// One imperial gallon.
let imperialGallon: Volume =
    imperialGallons 1

/// <category>Constants</category>
/// One liquid quart.
let usLiquidQuart: Volume = usLiquidQuarts 1

/// <category>Constants</category>
/// One US dry quart.
let usDryQuart: Volume = usDryQuarts 1

/// <category>Constants</category>
/// One imperial quart.
let imperialQuart: Volume = imperialQuarts 1

/// <category>Constants</category>
/// One US liquid pint.
let usLiquidPint: Volume = usLiquidPints 1

/// <category>Constants</category>
/// One US dry pint.
let usDryPint: Volume = usDryPints 1

/// <category>Constants</category>
/// One imperial pint.
let imperialPint: Volume = imperialPints 1

/// <category>Constants</category>
/// One US fluid ounce.
let usFluidOunce: Volume = usFluidOunces 1

/// <category>Constants</category>
/// One imperial fluid ounce.
let imperialFluidOunce: Volume =
    imperialFluidOunces 1
