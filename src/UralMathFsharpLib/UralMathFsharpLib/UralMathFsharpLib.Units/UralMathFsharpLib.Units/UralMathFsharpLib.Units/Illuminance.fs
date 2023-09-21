/// <category>Module: Unit System</category>
/// <summary>
/// <a href="https://en.wikipedia.org/wiki/Illuminance">Illuminance</a> is a
/// measure of how much light is striking a surface:
/// luminous flux per unit area. It is measured in
/// <a href="https://en.wikipedia.org/wiki/Lux">lux</a>
/// </summary>
/// <note>
/// Illuminance is useful as a measure of how brightly a surface is lit. For
/// example, on an overcast day, outside surfaces have an illuminance of
/// approximately 1000 lux; inside an office might be more like 400 lux and under a
/// full moon might be only 0.2 lux.
/// </note>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Illuminance

/// <category>Conversions</category>
/// <summary>
/// Construct an illuminance value from a number of lux. One lux is equal to one
/// lumen per square meter. See
/// <a href="https://en.wikipedia.org/wiki/Lux#Illuminance">here</a>
/// for a table of illuminance values in lux for common environments.
/// </summary>
let lux (numLux: float) : Illuminance = Quantity numLux

/// <category>Conversions</category>
/// Convert an illuminance value to a number of lux.
let inLux (numLux: Illuminance) : float = numLux.Value

/// <category>Conversions</category>
/// <summary>
/// Construct an illuminance value from a number of
/// <a href="https://en.wikipedia.org/wiki/Foot-candle">foot-candles</a>.
/// One foot-candle is equal to one lumen per
/// square foot.
/// </summary>
let footCandles (numFootCandles: float) : Illuminance =
    LuminousFlux.lumens numFootCandles
    |> Quantity.per (Area.squareFeet 1)

/// <category>Conversions</category>
/// Convert an illuminance value to a number of foot-candles.
let inFootCandles (illuminance: Illuminance) : float =
    Area.squareFeet 1
    |> Quantity.at illuminance
    |> LuminousFlux.inLumens
