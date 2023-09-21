(**

---
title: Math.Units Package
---

This package is a port and extension of the framework [elm-units](https://package.elm-lang.org/packages/ianmackenzie/elm-units/latest/).
Huge thanks to [@ianmackenzie](https://github.com/ianmackenzie) for creating the original package and writing much of
the original documentation.

Note: This framework is currently in __alpha__ development.

*)
(*** hide ***)

#r "../Math.Units/bin/Release/net6.0/Math.Units.dll"

open System

(** *)

(**
To use this framework you include the package through the namespace
*)

open Math.Units

(**
# Math.Units

_Release notes for 2.0 are [here](https://github.com/ianmackenzie/elm-units/releases/tag/2.0.0)._

[Math.Units](./reference/math-units.html) is useful if you want to store, pass around, convert between,
compare, or do arithmetic on:

- Durations (seconds, milliseconds, hours...)
- Angles (degrees, radians, turns...)
- Lengths (meters, feet, inches, miles, light years...)
- Temperatures (Celsius, Fahrenheit, kelvins)
- Pixels (whole or partial)
- Speeds (pixels per second, miles per hour...) or any other rate of change
- Any of the other built-in quantity types: areas, accelerations, masses,
  forces, pressures, currents, voltages...
- Or even values in your own custom units, such as 'number of tiles' in a
  tile-based game

It is aimed especially at engineering/scientific/technical applications but is
designed to be generic enough to work well for other fields such as games and
finance. The core of the package consists of a generic `Quantity` type and
many concrete types such as `Length`, `Angle`, `Duration`, `Temperature`, and
`Speed`, which you can use to add some nice type safety to data types and
function signatures:
*)

type Camera =
    { fieldOfView: Angle
      shutterSpeed: Duration
      minimumOperatingTemperature: Temperature }

let canOperateAt (temperature: Temperature) (camera: Camera) : bool =
    temperature
    |> Temperature.greaterThan camera.minimumOperatingTemperature

(**
You can construct values of these types from any units you want, using provided
functions such as:

__Hint: hover over the function names to see the type values__
*)

Length.feet
Length.meters
Duration.seconds
Angle.degrees
Temperature.degreesFahrenheit


(**
You can later convert back to plain numeric values, also in any units you want
(which do not have to be the same units used when initially constructing the
value!):
*)

Length.inCentimeters
Length.inMiles
Duration.inHours
Angle.inRadians
Temperature.inDegreesCelsius

(**
This means that (among other things!) you can use these functions to do simple
unit conversions:
*)

Duration.hours 3. |> Duration.inSeconds
(*** include-it ***)

Length.feet 10. |> Length.inMeters
(*** include-it ***)

Speed.milesPerHour 60. |> Speed.inMetersPerSecond
(*** include-it ***)

Temperature.degreesCelsius 30.
|> Temperature.inDegreesFahrenheit
(*** include-it ***)

(**
Additionally, types like `Length` are actually type aliases of the form
`Quantity number units` (`Length` is `Quantity Float Meters`, for example,
meaning that it is internally stored as a number of meters), and there are
many generic functions which let you work directly with any kind of `Quantity`
values:
*)

Length.feet 3.
|> Quantity.lessThan (Length.meters 1.)
(*** include-it ***)

Duration.hours 2.
|> Quantity.plus (Duration.minutes 30.)
|> Duration.inSeconds
(*** include-it ***)

// Some functions can actually convert between units!
// Multiplying two Length values gives you an Area
Length.centimeters 60.
|> Quantity.times (Length.centimeters 80.)
(*** include-it ***)

Quantity.sort [ Angle.radians 1.
                Angle.degrees 10.
                Angle.turns 0.5 ]
(*** include-it ***)

(**
Ultimately, what this does is let you pass around and manipulate `Length`,
`Duration` or `Temperature` etc. values without having to worry about units.
When you initially construct a `Length`, you need to specify what units you're
using, but once that is done you can:

- Store the length inside a data structure
- Pass it around between different functions
- Compare it to other lengths
- Add and subtract it to other lengths
- Multiply it by another length to get an area, or divide by a duration to
  get a speed

...and much more, all without having to care about units at all. All
calculations will be done in an internally consistent way, and when you finally
need to actually display a value on screen or encode to JSON, you can extract
the final result in whatever units you want.

## Table of contents

- [Installation](#installation)
- [Usage](#usage)
  - [Fundamentals](#fundamentals)
  - [The `Quantity` type](#the-quantity-type)
  - [Basic arithmetic and comparison](#basic-arithmetic-and-comparison)
  - [Multiplication and division](#multiplication-and-division)
  - [Argument order](#argument-order)
  - [Custom functions](#custom-functions)
  - [Custom units](#custom-units)
  - [Understanding quantity types](#understanding-quantity-types)
- [Getting help](#getting-help)
- [API](#api)
- [Climate action](#climate-action)
- [Contributing](#contributing)
- [License](#license)

## Installation

Assuming you have [installed dotnet](https://dotnet.microsoft.com/en-us/download) and
started a new project, you can install `Math.Units` by running

    [Lang=sh]
    dotnet add package Math.Units

in a command prompt inside your project directory.

## Usage

### Fundamentals

To take code that currently uses raw `float` values and convert it to using
`Math.Units` types, there are three basic steps:

- Wherever you store a `float`, such as in your model or in a message, switch
  to storing a `Duration` or `Angle` or `Temperature` etc. value instead.
- Whenever you _have_ a `Float` (from an external package, JSON decoder etc.),
  use a function such as `Duration.seconds`, `Angle.degrees` or
  `Temperature.degreesFahrenheit` to turn it into a type-safe value.
- Whenever you _need_ a `float` (to pass to an external package, encode as
  JSON etc.), use a function such as `Duration.inMilliseconds`,
  `Angle.inRadians` or `Temperature.inDegreesCelsius` to extract the value in
  whatever units you want.
- Where you do math with `Float` values, switch to using `Quantity` functions
  like `Quantity.plus` or `Quantity.greaterThan`. If this becomes impractical,
  there are [other approaches](#custom-functions).

### The Quantity type

All values produced by this package (with the exception of `Temperature`, which
is a bit of a special case) are actually values of type `Quantity`, roughly
defined as...
*)

type Quantity<'Units>(quantity: float) =
    member this.Value = quantity


(** For example, `Length` is defined as *)
type Meters = Meters
type Length = Quantity<Meters>

(**
This means that a `Length` is internally stored as a `float` number of `Meters`,
but the choice of internal units can mostly be treated as an implementation
detail.

Having a common `Quantity` type means that it is possible to define generic
arithmetic and comparison operations that work on any kind of quantity; read on!

### Basic arithmetic and comparison

You can do basic math with `Quantity` values:
*)

// 6 feet 3 inches, converted to meters
Length.feet 6.
|> Quantity.plus (Length.inches 3.)
|> Length.inMeters
(*** include-it ***)

Duration.hours 1.
|> Quantity.minus (Duration.minutes 15.)
|> Duration.inMinutes
(*** include-it ***)

// pi radians plus 45 degrees is 5/8 of a full turn
Quantity.sum [ Angle.radians Math.PI
               Angle.degrees 45. ]
|> Angle.inTurns
(*** include-it ***)


(** `Quantity` values can be compared/sorted: *)

Length.meters 1.
|> Quantity.greaterThan (Length.feet 3.)
(*** include-it ***)

Quantity.compare (Length.meters 1.) (Length.feet 3.)
(*** include-it ***)

Quantity.max (Length.meters 1.) (Length.feet 3.)
(*** include-it ***)

Quantity.maximum [ Length.meters 1.
                   Length.feet 3. ]
(*** include-it ***)

Quantity.sort [ Length.meters 1.
                Length.feet 3. ]
(*** include-it ***)


(**
### Multiplication and division

There are actually three different 'families' of multiplication and division
functions in the `Quantity` module, used in different contexts:

- `multiplyBy` and `divideBy` are used to multiply (scale) or divide a
  `Quantity` by a plain `Int` or `Float`, with `twice` and `half` for the common
  cases of multiplying or dividing by 2
- `product`, `times`, `over` and `over_` are used to work with quantities that
  are products of other quantities:
  - multiply a `Length` by another `Length` to get an `Area`
  - multiply an `Area` by a `Length` to get a `Volume`
  - multiply a `Mass` by an `Acceleration` to get a `Force`
  - divide a `Volume` by an `Area` to get a `Length`
  - divide a `Force` by a `Mass` to get an `Acceleration`
- `rate`, `per`, `at`, `at_` and `for` are used to work with rates of change:
  - divide `Length` by `Duration` to get `Speed`
  - multiply `Speed` by `Duration` to get `Length`
  - divide `Length` by `Speed` to get `Duration`
- And one bonus fourth function: `ratio`, used to divide two quantities with
  the same units to get a plain `Float` value

For example, to calculate the area of a triangle:
*)

// Area of a triangle with base of 2 feet and
// height of 8 inches
let baseSize = Length.feet 2.
let height = Length.inches 8.

Quantity.half (Quantity.product baseSize height)
|> Area.inSquareInches
(*** include-it ***)

(** Comprehensive support is provided for working with rates of change: *)

// How fast are we going if we travel 30 meters in
// 2 seconds?
let speed =
    Length.meters 30.
    |> Quantity.per (Duration.seconds 2.)
// How far do we go if we travel for 2 minutes
// at that speed?
Duration.minutes 2. // duration
|> Quantity.at speed // length per duration
|> Length.inKilometers // gives us a length!
(*** include-it ***)

// How long will it take to travel 20 km
// if we're driving at 60 mph?
Length.kilometers 20.
|> Quantity.at_ (Speed.milesPerHour 60.)
|> Duration.inMinutes
(*** include-it ***)

// How fast is "a mile a minute", in kilometers per hour?
Length.miles 1.
|> Quantity.per (Duration.minutes 1.)
|> Speed.inKilometersPerHour
(*** include-it ***)

// Reverse engineer the speed of light from defined
// lengths/durations (the speed of light is 'one light
// year per year')
let speedOfLight =
    Length.lightYears 1.
    |> Quantity.per (Duration.julianYears 1.)

speedOfLight |> Speed.inMetersPerSecond
(*** include-it ***)

// One astronomical unit is the (average) distance from the
// Sun to the Earth. Roughly how long does it take light to
// reach the Earth from the Sun?
Length.astronomicalUnits 1.
|> Quantity.at_ speedOfLight
|> Duration.inMinutes
(*** include-it ***)

(**
Note that the various functions above are not restricted to speed (length per
unit time) - any units work:
*)

let pixelDensity =
    Pixels.float 96.
    |> Quantity.per (Length.inches 1.)

Length.centimeters 3. // length
|> Quantity.at pixelDensity // pixels per length
|> Pixels.toFloat // gives us pixels!
(*** include-it ***)

(**

### Argument order

Note that several functions like `Quantity.minus` and `Quantity.lessThan` (and
their `Temperature` equivalents) that mimic binary operators like `-` and `<`
"take the second argument first"; for example,

*)

(*** hide ***)

let x = Quantity.unitless 0.
let y = Quantity.unitless 1.

(** *)

Quantity.lessThan x y

(**
means `y < x`, _not_ `x < y`. This is done for a couple of reasons. First, so
that use with `|>` works naturally; for example,
*)

x |> Quantity.lessThan y

(*** hide ***)

let a, b, c =
    Quantity.unitless 0., Quantity.unitless 1., Quantity.unitless 2.

(**
_does_ mean `x < y`. The 'reversed' argument order also means that things like
*)

List.map (Quantity.minus x) [ a; b; c ]

(** will work as expected - it will result in *)

[ a - x, b - x, c - x ]

(** instead of *)

[ x - a, x - b, x - c ]

(**
which is what you would get if `Quantity.minus` took arguments in the 'normal'
order.

There are, however, several functions that take arguments in 'normal' order, for
example:

- `Quantity.difference` (compare to `minus`)
- `Quantity.product` (compare to `times`)
- `Quantity.rate` (compare to `per`)
- `Quantity.ratio`
- `Quantity.compare`

In general the function names try to match how you would use them in English;
you would say "the difference of `a` and `b`" (and so `Quantity.difference a b`)
but "`a` minus `b`" (and so `a |> Quantity.minus b`).

### Custom Functions

Some calculations cannot be expressed using the built-in `Quantity` functions.
Take kinetic energy `E_k = 1/2 * m * v^2`, for example - the `Math.Units` type
system is not sophisticated enough to work out the units properly. Instead,
you'd need to create a custom function like

*)

let kineticEnergy (m: Mass) (v: Speed) : Energy =
    Quantity.create (0.5 * m.Value * v.Value * v.Value)

(**
In the _implementation_ of `kineticEnergy`, you're working with raw `Float`
values so you need to be careful to make sure the units actually do work out.
(The values will be in [SI units][https://en.wikipedia.org/wiki/International_System_of_Units]
- meters, seconds etc.) Once the function has been implemented, though, it 
can be used in a completely type-safe way - callers can supply arguments 
using whatever units they have, and extract results in whatever units they want:
[6]: 
*)

kineticEnergy (Mass.shortTons 1.5) (Speed.milesPerHour 60.)
|> Energy.inKilowattHours
(*** include-it ***)

(**
### Custom Units

`Math.Units` defines many standard Unit Systems, but you can easily define your
own! See [CustomUnits][#CustomUnits] for an example.

### Understanding quantity types

The same quantity type can often be expressed in multiple different ways. Take
the `Volume` type as an example. It is an alias for
*)

Quantity<CubicMeters>

(** but expanding the `CubicMeters` type alias, this is equivalent to *)

Quantity<Meters Cubed>

(** which expands further to *)

Quantity<Product<Product<Meters, Meters>, Meters>>

(** which could also be written as *)

Quantity<Product<Meters Squared, Meters>>

(** or even *)

Quantity<Product<SquareMeters, Meters>>

(**
and you may see any one of these forms pop up in compiler error messages.

## API

[Full API documentation][reference/math-units.html] is available.

## Climate action

This is a message from Ian Mackenzie but as the maintainer of this package I
believe in this mantra and will follow through with his wishes on giving
priority to issues regarding climate action.

I would like for the projects I work on to be as helpful as possible in
addressing the climate crisis. If

- you are working on a project that helps address the climate crisis (clean
  energy, public transit, reforestation, sustainable agriculture etc.) either as
  an individual, as part of an non-profit organization or even as part of a
  for-profit company, and
- there is a new feature you would find helpful for that work (or a bug you need
  fixed) in any of my open-source projects, then

please [open a new issue](https://github.com/evelios/Math.Units/issues),
describe briefly what you're working on and I will treat that issue as high
priority.

## Contributing

Yes please! One of the best ways to contribute is to add a module for a new
quantity type; I'll add a proper CONTRIBUTING.md at some point, but some
brief guidelines in the meantime:

- Open a pull request by forking this repository, creating a new branch in
  your fork, making all changes in that branch, then opening a pull request
  from that branch.
- Git commit messages should follow [the seven rules of a great Git commit
  message][https://chris.beams.io/posts/git-commit/#seven-rules], although I'm not strict about the 50 or 72 character rules.

## License

[elm-units BSD-3-Clause © Ian Mackenzie][https://github.com/ianmackenzie/elm-units/blob/master/LICENSE]
[Math.Units BSD-3-Clause © Thomas Waters][https://github.com/evelios/Math.Unitsrblob/master/LICENSE]
*)
