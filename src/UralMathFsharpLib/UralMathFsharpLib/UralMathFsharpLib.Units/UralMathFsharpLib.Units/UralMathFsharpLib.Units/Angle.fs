/// <category>Module: Unit System</category>
/// <summary>
/// An <c>Angle</c> represents an angle in degrees, radians, or turns. It is stored
/// as a number of radians.
/// </summary>
///
/// <note>
/// Angles are sometimes measured in degrees, minutes, and seconds, where 1 minute =
/// 1/60th of a degree and 1 second = 1/60th of a minute.
/// </note>
///
/// <example>
/// You can construct an angle from your unit scheme. All of the following are equivalent.
/// <code>
///     Angle.radians Math.PI
///     Angle.degrees 180.
///     Angle.turns 0.5
/// </code>
/// </example>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Angle

open System
open UralMathFsharpLib.Units
open UralMathFsharpLibUnits


// ---- Builders / Accessors  --------------------------------------------------

// ---- Radians ----

/// <category>Radians</category>
/// Create an angle from a number of radians.
let radians (r: float) : Angle = Angle r

/// <category>Radians</category>
/// Get a <c>float</c> of the given angle in radians
let inRadians (r: Angle) : float = r.Value

// ---- Degrees ----

/// <category>Degrees</category>
/// Create an angle from a number of degrees.
let degrees (d: float) : Angle =
    d * MetricConstants.degreesToRadians |> radians

/// <category>Degrees</category>
/// Get a <c>float</c> of the given angle in degrees.
let inDegrees (angle: Angle) : float =
    angle.Value * MetricConstants.radiansToDegrees

// ---- Minutes ----

/// <category>Degrees</category>
/// Create an angle from a number of minutes.
let minutes (numMinutes: float) : Angle = degrees (numMinutes / 60.)

/// <category>Degrees</category>
/// Get a <c>float</c> of the given angle in minutes.
let inMinutes (angle: Angle) : float = 60. * inDegrees angle

// ---- Seconds ----

/// <category>Degrees</category>
/// Create an angle from a number of seconds.
let seconds (numSeconds: float) : Angle = degrees (numSeconds / 3600.)

/// <category>Degrees</category>
/// Get a <c>float</c> of the given angle in seconds.
let inSeconds (angle: Angle) : float = 3600. * inDegrees angle

// ---- Turns ----

/// <category>Turns</category>
/// Create an angle from a number of turns.
let turns (numTurns: float) : Angle = radians (2. * numTurns * Math.PI)

/// <category>Turns</category>
/// Get a <c>float</c> of the given angle in turns.
let inTurns (angle: Angle) : float = inRadians (angle / (2. * Math.PI))

// ---- Constants --------------------------------------------------------------

/// <category>Constants</category>
/// π
let pi: Angle = radians Math.PI

/// <category>Constants</category>
/// 2π
let twoPi: Angle = radians 2. * Math.PI

/// <category>Constants</category>
/// π/2
let piOverTwo: Angle = radians Math.PI / 2.

/// <summary>
/// π/2.
/// Alias for <see cref="M:Math.Units.Angle.piOverTwo"/>.
/// </summary>
/// <category>Constants</category>
let halfPi: Angle = piOverTwo


// ---- Modifiers --------------------------------------------------------------

/// <summary>
/// Convert an arbitrary angle to the equivalent angle in the range -180 to 180
/// degrees (-π to π radians), by adding or subtracting some multiple of 360
/// degrees (2π radians) if necessary.
/// </summary>
/// <category>Modifiers</category>
let normalize (r: Angle) : Angle =
    let turns = (r / twoPi.Value)
    let angleRadians = r - twoPi.Value * turns

    if (angleRadians.Value > Math.PI) then
        angleRadians - twoPi
    else if (angleRadians.Value < -Math.PI) then
        twoPi + angleRadians
    else
        angleRadians


// ---- Trig ----

/// <category>Trigonometry</category>
/// <summary>
/// Run the <c>sin</c> function on an angle.
/// </summary>
///
/// <example>
/// This can also be called using the builtin <c>sin</c> function.
/// <code>
/// sin Angle.pi = Angle.sin Angle.pi
/// </code>
/// </example>
let sin (r: Angle) : float = sin r.Value

/// <category>Trigonometry</category>
/// <summary>
/// Run the <c>cos</c> function on an angle.
/// </summary>
///
/// <example>
/// This can also be called using the builtin <c>cos</c> function.
/// <code>
/// cos Angle.pi = Angle.cos Angle.pi
/// </code>
/// </example>
let cos (r: Angle) : float = cos r.Value

/// <category>Trigonometry</category>
/// <summary>
/// Run the <c>tan</c> function on an angle.
/// </summary>
///
/// <example>
/// This can also be called using the builtin <c>tan</c> function.
/// <code>
/// tan Angle.pi = Angle.tan Angle.pi
/// </code>
/// </example>
let tan (r: Angle) : float = tan r.Value

/// <category>Trigonometry</category>
/// <summary>
/// Run the <c>asin</c> function on an angle.
/// </summary>
///
/// <example>
/// This can also be called using the builtin <c>asin</c> function.
/// <code>
/// asin Angle.pi = Angle.asin Angle.pi
/// </code>
/// </example>
let asin (x: float) : Angle = radians (asin x)

/// <category>Trigonometry</category>
/// <summary>
/// Run the <c>acos</c> function on an angle.
/// </summary>
///
/// <example>
/// This can also be called using the builtin <c>acos</c> function.
/// <code>
/// acos Angle.pi = Angle.acos Angle.pi
/// </code>
/// </example>
let acos (x: float) : Angle = radians (acos x)

/// <category>Trigonometry</category>
/// <summary>
/// Run the <c>atan</c> function on an angle.
/// </summary>
///
/// <example>
/// This can also be called using the builtin <c>atan</c> function.
/// <code>
/// atan Angle.pi = Angle.atan Angle.pi
/// </code>
/// </example>
let atan (x: float) : Angle = radians (atan x)


// ---- Constants ----

/// <category>Constants</category>
/// One radian.
let radian: Angle = radians 1.

/// <category>Constants</category>
/// One degree.
let degree: Angle = degrees 1.

/// <category>Constants</category>
/// One turn.
let turn: Angle = turns 1.

/// <category>Constants</category>
/// One minute.
let minute: Angle = minutes 1.

/// <category>Constants</category>
/// One second.
let second: Angle = seconds 1.
