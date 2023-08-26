(**

---
title: Digit Precision
category: Tutorials
categoryindex: 1
index: 1
---

[floating point equality]: https://floating-point-gui.de/errors/comparison/
[f# float]: https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-6.0

*)
(*** hide ***)
#r "../Math.Units/bin/Release/net6.0/Math.Units.dll"

open Math.Units

type Cartesian = Cartesian

(**
# Digit Precision

This library provides equality operators `lhs = rhs` for many of the data
structures. The savvy among you may have noticed that all the data structures
are also storing float numbers. Comparing [floating point equality] is no easy
task. Due to floating point rounding errors when numbers are being stored, and
with many calculations (especially trig functions), the output numbers may be
slightly different than you would expect.

We can show this with an example. We would expect the following to be true
*)

1. = (0.3 * 3.) + 0.1
(*** include-it ***)

(**
Checking the returned value from the right hand side we see that we are getting
the value `1.0`. So what's going on?
*)

(0.3 * 3.) + 0.1
(*** include-it ***)

(**
Well, with a little investigation, we can see that we aren't getting exactly
`1.0`. We are getting ever so slightly less than `1.0`.
*)

((0.3 * 3.) + 0.1) - 1.
(*** include-it ***)

(**
Comparing datastructures that use floating point numbers can sometimes be a sign
of bad code code design, but this is not always the case. So when you are
looking to do equality comparison, this library provides the ability to do
approximate equality comparison on floating point numbers and data structures
like points and vectors.
*)

Float.almostEqual 1. ((0.3 * 3.) + 0.1)
(*** include-it ***)

(**
You can change the precision that floating point operations are performed at. The
default precision is a digit precision of 10. If we were looking a higher level
of precision, you can change the digit precision to be something more fitting of
your needs. In this example, we can make that equality check fail by increasing
the precision we are requiring for this operation.
*)

// Increasing the equality precision to make this check fail
Float.DigitPrecision <- 17

Float.almostEqual 1. ((0.3 * 3.) + 0.1)
(*** include-it ***)