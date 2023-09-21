(**

---
title: Quantity
category: Tutorials
categoryindex: 1
index: 4
---


*)
(*** hide ***)

#r "../Math.Units/bin/Release/net6.0/Math.Units.dll"

open Math.Units

type Cartesian = Cartesian
(***)

(**

@docs Quantity

# Unit Systems

The <c>Squared</c>, <c>Cubed</c>, `Product` and `Rate` units types allow you to build up
and work with composite units in a fairly flexible way.

@docs Squared, Cubed, Product, Rate

# Constants

@docs zero, infinity, positiveInfinity, negativeInfinity

# Comparison

@docs lessThan, greaterThan, lessThanOrEqualTo, greaterThanOrEqualTo
@docs lessThanZero, greaterThanZero, lessThanOrEqualToZero, greaterThanOrEqualToZero
@docs compare, equalWithin, max, min, isNaN, isInfinite

# Arithmetic

@docs negate, abs, plus, difference, minus, multiplyBy, divideBy, twice, half, ratio, squared, sqrt, cubed, cbrt

## Unitless quantities

Some specialized arithmetic functions for working with [unitless](#Unitless)
quantities. `squaredUnitless`, `sqrtUnitless`, `cubedUnitless` and
`cbrtUnitless` all behave just like their non-`Unitless` versions but return a
`Unitless` result (instead of for example something meaningless like `Squared
Unitless`).

@docs squaredUnitless, sqrtUnitless, cubedUnitless, cbrtUnitless, reciprocal

## Working with products

@docs product, times, timesUnitless, over, over_, overUnitless

## Working with rates

@docs rate, per, at, at_, for, inverse, rateProduct

## Modular arithmetic

`modBy` and `remainderBy` behave just like the [`modBy`](https://package.elm-lang.org/packages/elm/core/latest/Basics#modBy)
and [`remainderBy`](https://package.elm-lang.org/packages/elm/core/latest/Basics#remainderBy)
functions from Elm's built-in `Basics` module, but work on `Quantity` values
instead of raw `Int`s. `fractionalModBy` and `fractionalRemainderBy` have the
same behaviour but extended to `Float`-valued quantities.
    import Pixels exposing (pixels)
    import Length exposing (meters, centimeters)
    Quantity.modBy (pixels 4) (pixels 11)
    --> pixels 3
    Quantity.fractionalModBy (meters 0.5)
        (centimeters 162.3)
    --> centimeters 12.3
    
@docs modBy, fractionalModBy, remainderBy, fractionalRemainderBy

## Miscellaneous

@docs clamp, interpolateFrom, midpoint, range, in_

# `Int`/`Float` conversion

These functions only really make sense for quantities in units like pixels,
cents or game tiles where an `Int` number of units is meaningful. For quantities
like `Length` or `Duration`, it doesn't really make sense to round to an `Int`
value since the underyling base unit is pretty arbitrary - should `round`ing a
`Duration` give you an `Int` number of seconds, milliseconds, or something else?
(The actual behavior is that quantities will generally get rounded to the
nearest SI base unit, since that is how they are stored internally - for
example, `Length` values will get rounded to the nearest meter regardless of
whether they were constructed from a number of meters, centimeters, inches or
light years.)

@docs round, floor, ceiling, truncate, toFloatQuantity

# List functions

These functions act just like the corresponding functions in the built-in `List`
module (or, int the case of `minimumBy` and `maximumBy`, the `List.Extra` module
from `elm-community/list-extra`). They're necessary because the built-in
`List.sum` only supports `List Int` and `List Float`, and the remaining
functions only support built-in `comparable` types like `Int`, `Float`, `String`
and tuples.

@docs sum, minimum, maximum, minimumBy, maximumBy, sort, sortBy

# Unitless quantities

It is sometimes useful to be able to represent _unitless_ quantities, especially
when working with generic code (in most other cases, it is likely simpler and
easier to just use `Int` or `Float` values directly). All the conversions in
this section simply wrap or unwrap a `Float` or `Int` value into a `Quantity`
value, and so should get compiled away entirely when using `elm make
--optimize`.

@docs Unitless, int, toInt, float, toFloat

# Unsafe conversions

These functions are equivalent to directly constructing or unwrapping `Quantity`
values, and generally shouldn't be used outside of some specialized situations
that can come up when authoring packages that use `elm-units`.
@docs unsafe, unwrap



*)

(**
# Operators

| Operator | Lhs       | Rhs       | Return Type | Example          | Function |
|----------|-----------|-----------|-------------|------------------|----------|
| -        | Quantity  |           | Quantity    | `-quantity`      | [Quantity.negate](../reference/math-units-quantitymodule.html#negate) |
| +        | Quantity  | Quantity  | Quantity    | `lhs + rhs`      | `Quantity.plus` |
| -        | Quantity  | Quantity  | Quantity    | `lhs - rhs`      | `Quantity.difference` |
| *        | Quantity  | Quantity  | Quantity    | `lhs * rhs`      | `Quantity.product` & `Quantity.times` |
| *        | Quantity  | float     | Quantity    | `lhs * 0.5`      | `Quantity.multiplyBy` |
| *        | float     | Quantity  | Quantity    | `0.5 * rhs`      | `Quantity.multiplyBy` |
| /        | Quantity  | Quantity  | float       | `lhs / rhs`      | `Quantity.ratio` |
| /        | Quantity  | float     | Quantity    | `lhs / 4.`       | `Quantity.dividedBy` |

*)

(**

| Operator | Lhs       | Return Type | Example          | Function |
|----------|-----------|-------------|------------------|----------|
| abs      | Quantity  | Quantity    | `-length`        | `Quantity.abs` |
| min      | Quantity  | Quantity    | `lhs + rhs`      | `Quantity.min` |
| max      | Quantity  | Quantity    | `lhs - rhs`      | `Quantity.max` |
| sqrt     | Quantity<'Units>  | Quantity<'Units Squared>  | `lhs * 0.5`      | `Quantity.sqrt` |
| floor    | Quantity  | Quantity    | `0.5 * rhs`      | `Quantity.floor` |
| ceil     | Quantity  | Length      | `angle / length` | `Quantity.ceil` |
| round    | Quantity  | Quantity      | `length / angle` | `Quantity.round` |
| truncate | Quantity  | Quantity    | `lhs / 4.`       | `Quantity.truncate` |

*)
