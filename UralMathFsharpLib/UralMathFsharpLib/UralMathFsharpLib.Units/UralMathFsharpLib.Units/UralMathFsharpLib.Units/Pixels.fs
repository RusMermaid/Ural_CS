/// <category>Module: Unit System</category>
/// <summary>
/// Although most of the focus of <c>Math.Units</c> is on physical/scientific units,
/// it's often useful to be able to safely convert back and forth between (for
/// example) <c>Length</c> values in the real world and on-screen lengths in
/// pixels.
///
/// <para>
/// This module provides a standard <c>Pixels</c> units type and basic functions for
/// constructing/converting values of type <c>Quantity Int Pixels</c> or
/// <c>Quantity Float Pixels</c>, which allows you to do things like represent
/// conversions between real-world and on-screen lengths as rates of change.
/// This in turn means that all the normal <c>Quantity</c> functions can be
/// used to convert between pixels and other units, or even do type-safe math
/// directly on pixel values.
/// </para>
/// </summary>
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Pixels

/// <category>Distance</category>
/// <summary>
/// Construct a quantity representing a floating-point number of on-screen
/// pixels:
/// <code>
/// let lineWeight =
///     Pixels.float 1.5
/// </code>
/// </summary>
let float (numPixels: float) : Pixels = Quantity numPixels

/// <category>Distance</category>
/// <summary>
/// Convert a floating-point number of pixels back into a plain <c>Float</c>:
/// </summary>
/// <example><code>
/// let pixelDensity =
///     Pixels.float 96 |&gt; Quantity.per (Length.inches 1)
/// Length.centimeters 1
///     |&gt; Quantity.at pixelDensity
///     |&gt; Pixels.toFloat
/// --&gt; 37.795275590551185
/// </code></example>
let toFloat (numPixels: Pixels) : float = numPixels.Value

/// <category>Constants</category>
/// <summary>
/// Shorthand for <c>Pixels.float 1.</c>. Can be convenient to use with
/// <c>Quantity.per</c>].
/// </summary>
let pixel = float 1.

/// <category>Rate</category>
/// Construct an on-screen speed from a number of pixels per second.
let pixelsPerSecond (numPixelsPerSecond: float) : Quantity<PixelsPerSecond> = Quantity numPixelsPerSecond

/// <category>Rate</category>
/// <summary>
/// Convert an on-screen speed to a number of pixels per second.
/// </summary>
/// <example><code>
/// let elapsedTime =
///     Duration.milliseconds 16
/// let dragDistance =
///     Pixels.float 2
/// let dragSpeed =
///     dragDistance |&gt; Quantity.per elapsedTime
/// let dragSpeed |&gt; Pixels.inPixelsPerSecond
/// --&gt; 125
/// </code></example>
let inPixelsPerSecond (numPixelsPerSecond: Quantity<PixelsPerSecond>) : float = numPixelsPerSecond.Value

/// <category>Rate</category>
/// Construct an on-screen acceleration from a number of pixels per second
/// squared.
let pixelsPerSecondSquared (numPixelsPerSecondSquared: float) : Quantity<PixelsPerSecondSquared> =
    Quantity numPixelsPerSecondSquared

/// <category>Rate</category>
/// Convert an on-screen acceleration to a number of pixels per second squared.
let inPixelsPerSecondSquared (numPixelsPerSecondSquared: Quantity<PixelsPerSecondSquared>) : float =
    numPixelsPerSecondSquared.Value


/// <category>Area</category>
/// Construct an on-screen area from a number of square pixels.
let squarePixels (numSquarePixels: float) : Quantity<SquarePixels> = Quantity numSquarePixels

/// <category>Area</category>
/// Convert an on-screen area to a number of square pixels.
///    area =
///        Pixels.int 1928 |&gt; Quantity.times (Pixels.int 1080)
///    area |&gt; Pixels.inSquarePixels
///    --&gt; 2073600
let inSquarePixels (numSquarePixels: Quantity<SquarePixels>) : float = numSquarePixels.Value
