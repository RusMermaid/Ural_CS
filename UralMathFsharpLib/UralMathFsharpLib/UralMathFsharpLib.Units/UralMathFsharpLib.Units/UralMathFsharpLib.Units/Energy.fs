/// <category>Module: Unit System</category>
/// <summary>
/// An <c>Energy</c> value represents an amount of energy (or work) in joules,
/// kilowatt hours etc. It is stored as a number of joules.
/// </summary>
/// 
/// <note>
/// <para>
/// Since <c>Joules</c> is defined as <c>Product&lt;Newtons, Meters&gt;</c>,
/// you can compute energy directly as a product of force and distance:
/// </para>
/// <code>
///     Force.newtons 5 |&gt; Quantity.times (Length.meters 4)
///     --&gt; Energy.joules 20
/// </code>
/// </note>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Energy

/// <category>Conversions</category>
/// Construct an energy value from a number of joules.
let joules (numJoules: float) : Energy = Quantity numJoules

/// <category>Conversions</category>
/// Convert an energy value to a number of joules.
let inJoules (numJoules: Energy) : float = numJoules.Value

/// <category>Conversions</category>
/// Construct an energy value from a number of kilojoules.
let kilojoules (numKilojoules: float) : Energy = joules (1000. * numKilojoules)

/// <category>Conversions</category>
/// Convert an energy value to a number of kilojoules.
let inKilojoules (energy: Energy) : float = inJoules energy / 1000.

/// <category>Conversions</category>
/// Construct an energy value from a number of megajoules.
let megajoules (numMegajoules: float) : Energy = joules (1.0e6 * numMegajoules)

/// <category>Conversions</category>
/// Convert an energy value to a number of megajoules.
let inMegajoules (energy: Energy) : float = inJoules energy / 1.0e6

/// <category>Conversions</category>
/// <summary>
/// <code>
/// Construct an energy value from a number of kilowatt hours.
///    Energy.kilowattHours 1
///    --&gt; Energy.megajoules 3.6
/// </code>
/// </summary>
let kilowattHours (numKilowattHours: float) : Energy = joules (3.6e6 * numKilowattHours)

/// <category>Conversions</category>
/// Convert an energy value to a number of kilowatt hours.
let inKilowattHours (energy: Energy) : float = inJoules energy / 3.6e6
