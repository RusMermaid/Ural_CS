/// <category>Module: Unit System</category>
/// <summary>
/// <a href="https://en.wikipedia.org/wiki/Luminance">Luminance</a>
/// is <a href="https://en.wikipedia.org/wiki/Candela_per_square_metre">luminous intensity</a> per
/// unit area or equivalently
/// <see cref="T:Math.Units.Illuminance"/> per
/// <see cref="T:Math.Units.SolidAngle"/>,
/// and is measured in <a href="https://en.wikipedia.org/wiki/Candela_per_square_metre">nits</a>
/// (or, to use standard SI terminology, candelas per square meter
/// - the two terms are equivalent).
/// </summary>
///
/// <note>
/// Luminance is often used to describe the brightness of a particular surface as
/// viewed from a particular direction; for example, a computer monitor might be
/// described as having a brightness of 300 nits (but that would likely only be true
/// when viewing straight on instead of at an angle).
/// See <a href="https://en.wikipedia.org/wiki/Orders_of_magnitude_(luminance)">here</a>
/// for some common approximate luminance values.
/// </note>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Luminance

open System

/// <category>Conversions</category>
/// <summary>
/// Construct a luminance value from a number of nits. One nit is equal to one
/// <b>candela</b> per square meter, or equivalently one <b>lux</b> per <b>steradian</b>.
/// </summary>
let nits (numNits: float) : Luminance = Quantity numNits

/// <category>Conversions</category>
/// Convert a luminance value to a number of nits.
let inNits (numNits: Luminance) : float = numNits.Value

/// <category>Conversions</category>
/// <summary>
/// Construct a luminance value from a number of
/// <a href="https://en.wikipedia.org/wiki/Foot-lambert">foot-lamberts</a>.
/// </summary>
let footLamberts (numFootLamberts: float) : Luminance =
    LuminousIntensity.candelas numFootLamberts
    |> Quantity.per (Area.squareFeet Math.PI)


/// <category>Conversions</category>
/// Convert a luminance value to a number of foot-lamberts.
let inFootLamberts (luminance: Luminance) : float =
    Area.squareFeet Math.PI
    |> Quantity.at luminance
    |> LuminousIntensity.inCandelas
