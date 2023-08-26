(**
---
title: Angle
category: Modules
categoryindex: 2
index: 1
---
*)
(*** hide ***)

#r "../Math.Units/bin/Release/net6.0/Math.Units.dll"

open Math.Units

open System

type Cartesian = Cartesian
(***)

(**
# Builders
*)

Angle.degrees 120.

Angle.radians (Math.PI / 3.)

(**
# Accessors
*)

Angle.inDegrees Angle.halfPi

Angle.inRadians Angle.halfPi

(**
# Trigonometry
*)

Angle.sin Angle.pi
Angle.cos Angle.pi
Angle.tan Angle.pi

Angle.asin (1. / 2.)
Angle.acos (1. / 2.)
Angle.atan (1. / 2.)

(**
# Constants

| Function                 | Value               |
|--------------------------|---------------------|
| `Angle.zero`             | 0                   |
| `Angle.pi`               | $ \pi $             |
| `Angle.twoPi`            | $ 2 \pi $           |
| `Angle.piOverTwo`        | $ \frac{\pi}{2} $   |
| `Angle.halfPi`           | $ \frac{\pi}{2} $   |
| `Angle.radiansToDegrees` | $ \frac{180}{\pi} $ |
| `Angle.degreesToRadians` | $ \frac{\pi}{180} $ |

*)

(**
# Operators

| Operator | Lhs    | Rhs    | Return Type | Example          | Function |
|----------|--------|--------|-------------|------------------|----------|
| -        | Angle  |        | Angle       | `-length`        | `Angle.neg` |
| +        | Angle  | Angle  | Angle       | `lhs + rhs`      | `Angle.plus` |
| -        | Angle  | Angle  | Angle       | `lhs - rhs`      | `Angle.minus` |
| *        | Angle  | float  | Angle       | `lhs * 0.5`      | `Angle.times` |
| *        | float  | Angle  | Angle       | `0.5 * rhs`      | None |
| *        | Angle  | Length | Length      | `angle / length` | None |
| *        | Length | Angle  | Length      | `length / angle` | None |
| /        | Angle  | float  | Angle       | `lhs / 4.`       | `Angle.dividedBy` |
| /        | Angle  | Angle  | float       | `lhs / rhs`      | None |
| /        | Angle  | Length | Length      | `angle / length` | None |
| /        | Length | Angle  | Length      | `length / angle` | None |
*)
