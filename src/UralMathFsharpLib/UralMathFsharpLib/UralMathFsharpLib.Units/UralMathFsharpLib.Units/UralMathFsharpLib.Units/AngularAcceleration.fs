/// <category>Module: Unit System</category>
/// <summary>
/// An <c>AngularAcceleration</c> represents an angular acceleration in radians per
/// second squared, degrees per second squared, and turns per second squared. It is
/// stored as a number of radians per second squared.
/// </summary>
///
/// <note>
/// <para>
/// Since <c>RadiansPerSecondSquared</c> is defined as <c>Rate&lt;RadiansPerSecond,
/// Seconds&gt;</c> (change in angular speed per unit time), you can construct an
/// <c>AngularAcceleration</c> value using <c>Quantity.per</c>:
/// </para>
/// <code>
///     let angularAcceleration =
///         changeInAngularSpeed |&gt; Quantity.per duration
/// </code>
///
/// <para>
/// You can also do rate-related calculations with <c>AngularAcceleration</c> values to
/// compute <c>AngularSpeed</c> or <c>Duration</c>:
/// </para>
/// <code>
///     let changeInAngularSpeed =
///         angularAcceleration |&gt; Quantity.for duration
///     let alsoChangeInAngularSpeed =
///         duration |&gt; Quantity.at angularAcceleration
///     let duration =
///         changeInAngularSpeed |&gt; Quantity.at_ angularAcceleration
/// </code>
/// </note>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.AngularAcceleration

open System

/// <category>Conversions</category>
/// Construct an angular acceleration from a number of radians per second squared.
let radiansPerSecondSquared (numRadiansPerSecondSquared: float) : AngularAcceleration =
    Quantity numRadiansPerSecondSquared

/// <category>Conversions</category>
/// Convert an angular acceleration to a number of radians per second squared.
let inRadiansPerSecondSquared (numRadiansPerSecondSquared: AngularAcceleration) : float =
    numRadiansPerSecondSquared.Value

/// <category>Conversions</category>
/// Construct an angular acceleration from a number of degrees per second squared.
let degreesPerSecondSquared (numDegreesPerSecondSquared: float) : AngularAcceleration =
    radiansPerSecondSquared (Math.PI / 180. * numDegreesPerSecondSquared)

/// <category>Conversions</category>
/// Convert an angular acceleration to a number of degrees per second squared.
let inDegreesPerSecondSquared (angularAcceleration: AngularAcceleration) =
    inRadiansPerSecondSquared angularAcceleration
    / (Math.PI / 180.)

/// <category>Conversions</category>
/// Construct an angular acceleration from a number of turns per second squared.
let turnsPerSecondSquared (numTurnsPerSecondSquared: float) : AngularAcceleration =
    radiansPerSecondSquared (2. * Math.PI * numTurnsPerSecondSquared)

/// <category>Conversions</category>
/// Convert an angular acceleration to a number of turns per second squared.
let inTurnsPerSecondSquared (angularAcceleration: AngularAcceleration) : float =
    inRadiansPerSecondSquared angularAcceleration
    / (2. * Math.PI)
