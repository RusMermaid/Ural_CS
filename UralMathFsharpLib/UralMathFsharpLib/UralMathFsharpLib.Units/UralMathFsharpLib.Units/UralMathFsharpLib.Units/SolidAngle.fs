/// <category>Module: Unit System</category>
/// <summary>
/// <a href="https://en.wikipedia.org/wiki/Solid_angle">Solid angle</a> is a tricky concept
/// to explain, but roughly speaking solid angle is for 3D what angle is for 2D. It
/// can be used to measure three-dimensional field of view and is stored in
/// <a href="https://en.wikipedia.org/wiki/Steradian">steradians</a>.
/// 2D angle can be thought of as how much circumference of the unit circle is
/// covered. The unit circle (circle of radius 1) has a circumference of 2π, and an
/// angle in radians corresponds to the corresponding amount of circumference
/// covered. So an angle of 2π radians covers the entire circumference of the
/// circle, π radians covers half the circle, π/2 radians covers a quarter, etc.
/// Similarly, 3D solid angle can be thought of as how much surface area of the unit
/// sphere is covered. The unit sphere has surface area of 4π, and a solid angle in
/// steradians corresponds to the corresponding amount of surface area covered. So a
/// solid angle of 4π steradians covers the entire sphere, 2π steradians covers half
/// the sphere (one hemisphere), etc.
/// </summary>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.SolidAngle

open System

/// <category>Conversions</category>
/// Construct a solid angle from a number of steradians.
let steradians (numSteradians: float) : SolidAngle = Quantity numSteradians

/// <category>Conversions</category>
/// Convert a solid angle to a number of steradians.
let inSteradians (numSteradians: SolidAngle) : float = numSteradians.Value

/// <category>Conversions</category>
/// <summary>
/// Construct a solid angle from a number of <a href="https://en.wikipedia.org/wiki/Spat_(unit)">spats</a>.
/// One spat is the 3D
/// equivalent of one full turn; in the same way that one turn is the angle that
/// covers an entire circle, one spat is the solid angle that covers an entire
/// sphere. It's rare to have solid angles more than one spat, since solid angles
/// are usually used to measure what angular fraction of a full sphere something
/// covers.
/// <code>
/// SolidAngle.spats 1
/// --&gt; SolidAngle.steradians (4 * pi)
/// </code>
/// </summary>
let spats (numSpats: float) : SolidAngle = steradians (4. * Math.PI * numSpats)


/// <category>Conversions</category>
/// <summary>
/// Convert a solid angle to a number of spats.
/// <code>
/// SolidAngle.steradians (2 * pi) |&gt; SolidAngle.inSpats
/// --&gt; 0.5
/// </code>
/// </summary>
let inSpats (solidAngle: SolidAngle) : float =
    inSteradians solidAngle / (4. * Math.PI)


/// <category>Conversions</category>
/// <summary>
/// Construct a solid angle from a number of
/// <a href="https://en.wikipedia.org/wiki/Square_degree">square degrees</a>
/// One square degree is,
/// roughly speaking, the solid angle of a square on the surface of a sphere where
/// the square is one degree wide and one degree tall as viewed from the center of
/// the sphere.
/// <code>
///     SolidAngle.squareDegrees 100
///     -> SolidAngle.steradians 0.03046
/// </code>
/// </summary>
let squareDegrees (numSquareDegrees: float) : SolidAngle =
    steradians (numSquareDegrees * (Math.PI / 180.) ** 2)


/// <category>Conversions</category>
/// <summary>
/// Convert a solid angle to a number of square degrees.
/// <code>
///    SolidAngle.spats 1 |&gt; SolidAngle.inSquareDegrees
///    --&gt; 41252.96125
/// </code>
/// </summary>
let inSquareDegrees (solidAngle: SolidAngle) : float =
    inSteradians solidAngle / ((Math.PI / 180.) ** 2)


/// <category>Queries</category>
/// <summary>
/// Find the solid angle of a cone with a given tip angle (the angle between two
/// opposite sides of the cone, <b>not</b> the half-angle from the axis of the cone to
/// its side). A 1 degree cone has a solid angle of approximately π/4 square
/// degrees, similar to how a circle of diameter 1 has an area of π/4:
/// <code>
///     SolidAngle.conical (Angle.degrees 1)
///         |&gt; SolidAngle.inSquareDegrees
///     --&gt; 0.78539318
///     pi / 4
///     --&gt; 0.78539816
/// </code>
/// A cone with a tip angle of 180 degrees is just a hemisphere:
/// <code>
///     SolidAngle.conical (Angle.degrees 180)
///     --&gt; SolidAngle.spats 0.5
/// </code>
/// "Inside out" cones are also supported, up to 360 degrees (a full sphere):
/// <code>
///     SolidAngle.conical (Angle.degrees 270)
///     --&gt; SolidAngle.spats 0.85355
///     SolidAngle.conical (Angle.degrees 360)
///     --&gt; SolidAngle.spats 1
/// </code>
/// </summary>
let conical (angle: Angle) : SolidAngle =
    let halfAngle = Quantity.half angle
    steradians (2. * Math.PI * (1. - Angle.cos halfAngle))


/// <category>Queries</category>
/// <summary>
/// Find the solid angle of a rectangular pyramid given the angles between the
/// two pairs of sides. A 1 degree by 1 degree pyramid has a solid angle of almost
/// exactly 1 square degree:
/// <code>
///     SolidAngle.pyramidal
///         (Angle.degrees 1)
///         (Angle.degrees 1)
///     --&gt; SolidAngle.squareDegrees 0.9999746
/// </code>
/// In general, the solid angle of a pyramid that is <b>n</b> degrees wide by <b>m</b> degrees
/// tall is (for relatively small values of <b>n</b> and <b>m</b>) approximately <b>nm</b> square
/// degrees:
/// <code>
///     SolidAngle.pyramidal
///         (Angle.degrees 10)
///         (Angle.degrees 10)
///     --&gt; SolidAngle.squareDegrees 99.7474
///     SolidAngle.pyramidal
///         (Angle.degrees 60)
///         (Angle.degrees 30)
///     --&gt; SolidAngle.squareDegrees 1704.08
/// </code>
/// A pyramid that is 180 degrees by 180 degrees covers an entire hemisphere:
/// <code>
///     SolidAngle.pyramidal
///         (Angle.degrees 180)
///         (Angle.degrees 180)
///     --&gt; SolidAngle.spats 0.5
/// </code>
/// "Inside out" pyramids greater than 180 degrees are not supported and will be
/// treated as the corresponding "normal" pyramid (an angle of 240 degrees will be
/// treated as 120 degrees, an angle of 330 degrees will be treated as 30 degrees,
/// etc.).
/// </summary>
let pyramidal (theta: Angle) (phi: Angle) : SolidAngle =
    let halfTheta = Quantity.half theta
    let halfPhi = Quantity.half phi

    steradians (
        4.
        * asin (Angle.sin halfTheta * Angle.sin halfPhi)
    )
