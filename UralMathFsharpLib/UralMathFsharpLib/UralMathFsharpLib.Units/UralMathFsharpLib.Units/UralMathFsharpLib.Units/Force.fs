/// <category>Module: Unit System</category>
/// <summary>
/// A <c>Force</c> value represents a force in newtons, pounds force etc. It is
/// stored as a number of newtons.
/// </summary>
/// 
/// <note>
/// <para>
/// Since <c>Newtons</c> is defined as <c>Product&lt;Kilograms,
/// MetersPerSecondSquared&gt;</c>, you can compute force directly as a
/// product of mass and acceleration:
/// </para>
/// <code>
///     let mass =
///         Mass.kilograms 10
///     let acceleration =
///         Acceleration.metersPerSecondSquared 2
///     mass |&gt; Quantity.times acceleration
///     --&gt; Force.newtons 20
/// </code>
/// </note>
    
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Force

open UralMathFsharpLibUnits

/// <category>Metric</category>
/// Construct a force value from a number of newtons.
let newtons (numNewtons: float) : Force = Quantity numNewtons

/// <category>Metric</category>
/// Convert a force value to a number of newtons.
let inNewtons (numNewtons: Force) : float = numNewtons.Value

/// <category>Metric</category>
/// Construct a force value from a number of kilonewtons.
let kilonewtons (numKilonewtons: float) : Force = newtons (1000. * numKilonewtons)

/// <category>Metric</category>
/// Convert a force value to a number of kilonewtons.
let inKilonewtons (force: Force) : float = inNewtons force / 1000.

/// <category>Metric</category>
/// Construct a force value from a number of meganewtons.
let meganewtons (numMeganewtons: float) : Force = newtons (1.0e6 * numMeganewtons)

/// <category>Metric</category>
/// Convert a force value to a number of meganewtons.
let inMeganewtons (force: Force) : float = inNewtons force / 1.0e6

/// <category>Imperial</category>
/// Construct a force value from a number of pounds force. One pound force is
/// the force required to accelerate one pound mass at a rate of one gee.
let pounds (numPounds: float) : Force =
    newtons (MetricConstants.poundForce * numPounds)

/// <category>Imperial</category>
/// Convert a force value to a number of pounds force.
let inPounds (force: Force) : float = inNewtons force / MetricConstants.poundForce

/// <category>Imperial</category>
/// <summary>
/// Construct a force value from a number of kips (kilopounds force).
/// <code>
///    Force.kips 2
///    --&gt; Force.pounds 2000
/// </code>
/// </summary>
let kips (numKips: float) : Force = pounds (1000. * numKips)

/// <category>Imperial</category>
/// Convert a force value to a number of kips.
let inKips (force: Force) : float = inPounds force / 1000.
