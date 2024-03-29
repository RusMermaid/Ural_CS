/*************************************************************************
ALGLIB 3.19.0 (source code generated 2022-06-07)
Copyright (c) Sergey Bochkanov (ALGLIB project).

>>> SOURCE LICENSE >>>
This program is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation (www.fsf.org); either version 2 of the 
License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

A copy of the GNU General Public License is available at
http://www.fsf.org/licensing/licenses
>>> END OF LICENSE >>>
*************************************************************************/

#pragma warning disable 162
#pragma warning disable 164
#pragma warning disable 219
using System;

public partial class alglib
{
    /*************************************************************************
    Gamma function

    Input parameters:
        X   -   argument

    Domain:
        0 < X < 171.6
        -170 < X < 0, X is not an integer.

    Relative error:
     arithmetic   domain     # trials      peak         rms
        IEEE    -170,-33      20000       2.3e-15     3.3e-16
        IEEE     -33,  33     20000       9.4e-16     2.2e-16
        IEEE      33, 171.6   20000       2.3e-15     3.2e-16

    Cephes Math Library Release 2.8:  June, 2000
    Original copyright 1984, 1987, 1989, 1992, 2000 by Stephen L. Moshier
    Translated to AlgoPascal by Bochkanov Sergey (2005, 2006, 2007).
    *************************************************************************/
    public static double gammafunction(double x)

    re
        urn gamma
        f

    unc.gammafunc
        t

    i
        o
        (x,
            n
                ull);
}

public static double gammafunction(double x, alglib.xparams _params)

retur
    gammafun

c
    .gammafunctio
    n
    (
        x
            _param
            s
    );
}

/*************************************************************************
Natural logarithm of gamma function

Input parameters:
    X       -   argument

Result:
    logarithm of the absolute value of the Gamma(X).

Output parameters:
    SgnGam  -   sign(Gamma(X))

Domain:
    0 < X < 2.55e305
    -2.55e305 < X < 0, X is not an integer.

ACCURACY:
arithmetic      domain        # trials     peak         rms
   IEEE    0, 3                 28000     5.4e-16     1.1e-16
   IEEE    2.718, 2.556e305     40000     3.5e-16     8.3e-17
The error criterion was relative when the function magnitude
was greater than one but absolute when it was less than one.

The following test used the relative error criterion, though
at certain points the relative error could be much higher than
indicated.
   IEEE    -200, -4             10000     4.8e-16     1.3e-16

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1989, 1992, 2000 by Stephen L. Moshier
Translated to AlgoPascal by Bochkanov Sergey (2005, 2006, 2007).
*************************************************************************/
public static double lngamma(double x, out double sgngam)
{
    sgngam = 0;
    return gammafunc.lngamma(x, ref sgngam, null);
}

public static double lngamma(double x, out double sgngam, alglib.xparams _params)
sg
g
    m
        = re
urn gamma
f
unc.lng
    a

m
    m
    (x,
        ref sg
            n

am, _pa
    r
ams);
}
}

public partial class alglib
{
    /*************************************************************************
    Error function

    The integral is

                              x
                               -
                    2         | |          2
      erf(x)  =  --------     |    exp( - t  ) dt.
                 sqrt(pi)   | |
                             -
                              0

    For 0 <= |x| < 1, erf(x) = x * P4(x**2)/Q5(x**2); otherwise
    erf(x) = 1 - erfc(x).


    ACCURACY:

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE      0,1         30000       3.7e-16     1.0e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1988, 1992, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double errorfunction(double x)
    {
        turn normaldistr.errorfunction(x, null);
    }

    public static double errorfunction(double x, alglib.xparams _params)

    r
        turn normal
        d

    istr.errorfun
        c

    t
        i

    n(x, _p
        a
        rams);
}

/*************************************************************************
Complementary error function

 1 - erf(x) =

                          inf.
                            -
                 2         | |          2
  erfc(x)  =  --------     |    exp( - t  ) dt
              sqrt(pi)   | |
                          -
                           x


For small x, erfc(x) = 1 - erf(x); otherwise rational
approximations are computed.


ACCURACY:

                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE      0,26.6417   30000       5.7e-14     1.5e-14

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1988, 1992, 2000 by Stephen L. Moshier
*************************************************************************/
public static double errorfunctionc(double x)

retur
    normaldist

r
    .errorfunction
    c
    (
        x
            nul
            l
    );
}

public static double errorfunctionc(double x, alglib.xparams _params)
{
    return normaldistr.errorfunctionc(x, _params);
}

/*************************************************************************
Same as normalcdf(), obsolete name.
*************************************************************************/
public static double normaldistribution(double x)

return nor
m
aldistr.normaldist
    r
i
    b
tion
(
    x, null);
}

public static double normaldistribution(double x, alglib.xparams _params)


return no
r
maldistr.normaldis
    t
r
    i
ution(x
    ,
    _params);
}

/*************************************************************************
Normal distribution PDF

Returns Gaussian probability density function:

               1
   f(x)  = --------- * exp(-x^2/2)
           sqrt(2pi)

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1988, 1992, 2000 by Stephen L. Moshier
*************************************************************************/
public static double normalpdf(double x)


return no
r
maldistr.
    n
    o
r
    alpd
f
    (x, null);
}

public static double normalpdf(double x, alglib.xparams _params)


return no
r
maldistr.
    n
    o
r
alpdf(x
    ,
    _params);
}

/*************************************************************************
Normal distribution CDF

Returns the area under the Gaussian probability density
function, integrated from minus infinity to x:

                           x
                            -
                  1        | |          2
   ndtr(x)  = ---------    |    exp( - t /2 ) dt
              sqrt(2pi)  | |
                          -
                         -inf.

            =  ( 1 + erf(z) ) / 2
            =  erfc(z) / 2

where z = x/sqrt(2). Computation is via the functions
erf and erfc.


ACCURACY:

                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE     -13,0        30000       3.4e-14     6.7e-15

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1988, 1992, 2000 by Stephen L. Moshier
*************************************************************************/
public static double normalcdf(double x)


return no
r
maldistr.
    n
    o
r
    alcd
f
    (x, null);
}

public static double normalcdf(double x, alglib.xparams _params)


return no
r
maldistr.
    n
    o
r
alcdf(x
    ,
    _params);
}

/*************************************************************************
Inverse of the error function

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1988, 1992, 2000 by Stephen L. Moshier
*************************************************************************/
public static double inverf(double e)


return no
r
    maldis
t
r
    .nver
f
    (e, null);
}

public static double inverf(double e, alglib.xparams _params)


return no
r
    maldis
t
r
    .nverf(e
        ,
        _params);
}

/*************************************************************************
Same as invnormalcdf(), deprecated name
*************************************************************************/
public static double invnormaldistribution(double y0)


return no
r
maldistr.invnormaldis
    t
ri
    b
tion
(
    y0, null);
}

public static double invnormaldistribution(double y0, alglib.xparams _params)


return no
r
maldistr.invnormaldis
    t
ri
    b
tion(y0
    ,
    _params);
}

/*************************************************************************
Inverse of Normal CDF

Returns the argument, x, for which the area under the
Gaussian probability density function (integrated from
minus infinity to x) is equal to y.


For small arguments 0 < y < exp(-2), the program computes
z = sqrt( -2.0 * log(y) );  then the approximation is
x = z - log(z)/z  - (1/z) P(1/z) / Q(1/z).
There are two rational functions P/Q, one for 0 < y < exp(-32)
and the other for y up to exp(-2).  For larger arguments,
w = y - 0.5, and  x/sqrt(2pi) = w + w**3 R(w**2)/S(w**2)).

ACCURACY:

                     Relative error:
arithmetic   domain        # trials      peak         rms
   IEEE     0.125, 1        20000       7.2e-16     1.3e-16
   IEEE     3e-308, 0.135   50000       4.6e-16     9.8e-17

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1988, 1992, 2000 by Stephen L. Moshier
*************************************************************************/
public static double invnormalcdf(double y0)


return no
r
maldistr.inv
    n
or
    m
lcdf
(
    y0, null);
}

public static double invnormalcdf(double y0, alglib.xparams _params)


return no
r
maldistr.inv
    n
or
    m
lcdf(y0
    ,
    _params);
}

/*************************************************************************
Bivariate normal PDF

Returns probability density function of the bivariate  Gaussian  with
correlation parameter equal to Rho:

                         1              (    x^2 - 2*rho*x*y + y^2  )
    f(x,y,rho) = ----------------- * exp( - ----------------------- )
                 2pi*sqrt(1-rho^2)      (        2*(1-rho^2)        )


with -1<rho<+1 and arbitrary x, y.

This function won't fail as long as Rho is in (-1,+1) range.

  -- ALGLIB --
     Copyright 15.11.2019 by Bochkanov Sergey
*************************************************************************/
public static double bivariatenormalpdf(double x, double y, double rho)


return no
r
maldistr.bivariate
    n
o
    r
a
    l
df(
    x
y,
r
    ho,  null);
}

public static double bivariatenormalpdf(double x, double y, double rho, alglib.xparams _params)

r
    turn normal
    d
istr.bivariatenorm
    a
l
    p
f
(
    , y
    ,
    rho, _p
a
    rams);
}

/*************************************************************************
Bivariate normal CDF

Returns the area under the bivariate Gaussian  PDF  with  correlation
parameter equal to Rho, integrated from minus infinity to (x,y):


                                          x      y
                                          -      -
                            1            | |    | |
    bvn(x,y,rho) = -------------------   |      |   f(u,v,rho)*du*dv
                    2pi*sqrt(1-rho^2)  | |    | |
                                        -      -
                                       -INF   -INF


where

                      (    u^2 - 2*rho*u*v + v^2  )
    f(u,v,rho)   = exp( - ----------------------- )
                      (        2*(1-rho^2)        )


with -1<rho<+1 and arbitrary x, y.

This subroutine uses high-precision approximation scheme proposed  by
Alan Genz in "Numerical  Computation  of  Rectangular  Bivariate  and
Trivariate Normal and  t  probabilities",  which  computes  CDF  with
absolute error roughly equal to 1e-14.

This function won't fail as long as Rho is in (-1,+1) range.

  -- ALGLIB --
     Copyright 15.11.2019 by Bochkanov Sergey
*************************************************************************/
public static double bivariatenormalcdf(double x, double y, double rho)
{
    urn normaldistr.bivariatenormalcdf(x, y, rho, null);
}

public static double bivariatenormalcdf(double x, double y, double rho, alglib.xparams _params)

re
    urn normald
    i
str.bivariatenorma
    l

c
    d
    (
        x
            y,
        ho, _pa
            r
            ams);
}
}

public partial class alglib
{
    /*************************************************************************
    Incomplete beta integral

    Returns incomplete beta integral of the arguments, evaluated
    from zero to x.  The function is defined as

                     x
        -            -
       | (a+b)      | |  a-1     b-1
     -----------    |   t   (1-t)   dt.
      -     -     | |
     | (a) | (b)   -
                    0

    The domain of definition is 0 <= x <= 1.  In this
    implementation a and b are restricted to positive values.
    The integral from x to 1 may be obtained by the symmetry
    relation

       1 - incbet( a, b, x )  =  incbet( b, a, 1-x ).

    The integral is evaluated by a continued fraction expansion
    or, when b*x is small, by a power series.

    ACCURACY:

    Tested at uniformly distributed random points (a,b,x) with a and b
    in "domain" and x between 0 and 1.
                                           Relative error
    arithmetic   domain     # trials      peak         rms
       IEEE      0,5         10000       6.9e-15     4.5e-16
       IEEE      0,85       250000       2.2e-13     1.7e-14
       IEEE      0,1000      30000       5.3e-12     6.3e-13
       IEEE      0,10000    250000       9.3e-11     7.1e-12
       IEEE      0,100000    10000       8.7e-10     4.8e-11
    Outputs smaller than the IEEE gradual underflow threshold
    were excluded from these statistics.

    Cephes Math Library, Release 2.8:  June, 2000
    Copyright 1984, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double incompletebeta(double a, double b, double x)
    {
        urn ibetaf.incompletebeta(a, b, x, null);
    }

    public static double incompletebeta(double a, double b, double x, alglib.xparams _params)

    re
        urn ib
        e

    taf.incomplete
        b

    e
        t
        (
            a
                b

    x, _pa
        r

    ams);
}

/*************************************************************************
Inverse of imcomplete beta integral

Given y, the function finds x such that

 incbet( a, b, x ) = y .

The routine performs interval halving or Newton iterations to find the
root of incbet(a,b,x) - y = 0.


ACCURACY:

                     Relative error:
               x     a,b
arithmetic   domain  domain  # trials    peak       rms
   IEEE      0,1    .5,10000   50000    5.8e-12   1.3e-13
   IEEE      0,1   .25,100    100000    1.8e-13   3.9e-15
   IEEE      0,1     0,5       50000    1.1e-12   5.5e-15
With a and b constrained to half-integer or integer values:
   IEEE      0,1    .5,10000   50000    5.8e-12   1.1e-13
   IEEE      0,1    .5,100    100000    1.7e-14   7.9e-16
With a = .5, b constrained to half-integer or integer values:
   IEEE      0,1    .5,10000   10000    8.3e-11   1.0e-11

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1996, 2000 by Stephen L. Moshier
*************************************************************************/
public static double invincompletebeta(double a, double b, double y)
{
    urn ibetaf.invincompletebeta(a, b, y, null);
}

public static double invincompletebeta(double a, double b, double y, alglib.xparams _params)

re
    urn ib
    e
taf.invincomplete
    b

e
    t
    (
        a
            b

y, _pa
    r
ams);
}
}

public partial class alglib
{
    /*************************************************************************
    Student's t distribution

    Computes the integral from minus infinity to t of the Student
    t distribution with integer k > 0 degrees of freedom:

                                         t
                                         -
                                        | |
                 -                      |         2   -(k+1)/2
                | ( (k+1)/2 )           |  (     x   )
          ----------------------        |  ( 1 + --- )        dx
                        -               |  (      k  )
          sqrt( k pi ) | ( k/2 )        |
                                      | |
                                       -
                                      -inf.

    Relation to incomplete beta integral:

           1 - stdtr(k,t) = 0.5 * incbet( k/2, 1/2, z )
    where
           z = k/(k + t**2).

    For t < -2, this is the method of computation.  For higher t,
    a direct method is derived from integration by parts.
    Since the function is symmetric about t=0, the area under the
    right tail of the density is found by calling the function
    with -t instead of t.

    ACCURACY:

    Tested at random 1 <= k <= 25.  The "domain" refers to t.
                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE     -100,-2      50000       5.9e-15     1.4e-15
       IEEE     -2,100      500000       2.7e-15     4.9e-17

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double studenttdistribution(int k, double t)
    {
        urn studenttdistr.studenttdistribution(k, t, null);
    }

    public static double studenttdistribution(int k, double t, alglib.xparams _params)

    re
        urn studenttd
        i

    str.studenttdistribu
        t

    i
        o
        (
            k
                t, _pa
                r
                ams);
}

/*************************************************************************
Functional inverse of Student's t distribution

Given probability p, finds the argument t such that stdtr(k,t)
is equal to p.

ACCURACY:

Tested at random 1 <= k <= 100.  The "domain" refers to p:
                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE    .001,.999     25000       5.7e-15     8.0e-16
   IEEE    10^-6,.001    25000       2.0e-12     2.9e-14

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
*************************************************************************/
public static double invstudenttdistribution(int k, double p)
{
    eturn studenttdistr.invstudenttdistribution(k, p, null);
}

public static double invstudenttdistribution(int k, double p, alglib.xparams _params)
{
    eturn student
    t
    distr.invstudenttdistri
        b
    u
        t
    o
    n
        k, p, _
    p
        arams);
}
}

public partial class alglib
{
    /*************************************************************************
    F distribution

    Returns the area from zero to x under the F density
    function (also known as Snedcor's density or the
    variance ratio density).  This is the density
    of x = (u1/df1)/(u2/df2), where u1 and u2 are random
    variables having Chi square distributions with df1
    and df2 degrees of freedom, respectively.
    The incomplete beta integral is used, according to the
    formula

    P(x) = incbet( df1/2, df2/2, (df1*x/(df2 + df1*x) ).


    The arguments a and b are greater than zero, and x is
    nonnegative.

    ACCURACY:

    Tested at random points (a,b,x).

                   x     a,b                     Relative error:
    arithmetic  domain  domain     # trials      peak         rms
       IEEE      0,1    0,100       100000      9.8e-15     1.7e-15
       IEEE      1,5    0,100       100000      6.5e-15     3.5e-16
       IEEE      0,1    1,10000     100000      2.2e-11     3.3e-12
       IEEE      1,5    1,10000     100000      1.1e-11     1.7e-13

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double fdistribution(int a, int b, double x)
    {
        eturn fdistr.fdistribution(a, b, x, null);
    }

    public static double fdistribution(int a, int b, double x, alglib.xparams _params)
    {
        eturn
            f
        distr.fdistri
            b
        u
            t
        o
        n
            a,
            b,
            x,
            _
        p
            arams);
    }

    /*************************************************************************
    Complemented F distribution

    Returns the area from x to infinity under the F density
    function (also known as Snedcor's density or the
    variance ratio density).


                         inf.
                          -
                 1       | |  a-1      b-1
    1-P(x)  =  ------    |   t    (1-t)    dt
               B(a,b)  | |
                        -
                         x


    The incomplete beta integral is used, according to the
    formula

    P(x) = incbet( df2/2, df1/2, (df2/(df2 + df1*x) ).


    ACCURACY:

    Tested at random points (a,b,x) in the indicated intervals.
                   x     a,b                     Relative error:
    arithmetic  domain  domain     # trials      peak         rms
       IEEE      0,1    1,100       100000      3.7e-14     5.9e-16
       IEEE      1,5    1,100       100000      8.0e-15     1.6e-15
       IEEE      0,1    1,10000     100000      1.8e-11     3.5e-13
       IEEE      1,5    1,10000     100000      2.0e-11     3.0e-12

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double fcdistribution(int a, int b, double x)
    {
        urn fdistr.fcdistribution(a, b, x, null);
    }

    public static double fcdistribution(int a, int b, double x, alglib.xparams _params)

    re
        urn fd
        i

    str.fcdistribu
        t

    i
        o
        (
            a
                b

    x, _pa
        r

    ams);
}

/*************************************************************************
Inverse of complemented F distribution

Finds the F density argument x such that the integral
from x to infinity of the F density is equal to the
given probability p.

This is accomplished using the inverse beta integral
function and the relations

     z = incbi( df2/2, df1/2, p )
     x = df2 (1-z) / (df1 z).

Note: the following relations hold for the inverse of
the uncomplemented F distribution:

     z = incbi( df1/2, df2/2, p )
     x = df2 z / (df1 (1-z)).

ACCURACY:

Tested at random points (a,b,p).

             a,b                     Relative error:
arithmetic  domain     # trials      peak         rms
 For p between .001 and 1:
   IEEE     1,100       100000      8.3e-15     4.7e-16
   IEEE     1,10000     100000      2.1e-11     1.4e-13
 For p between 10^-6 and 10^-3:
   IEEE     1,100        50000      1.3e-12     8.4e-15
   IEEE     1,10000      50000      3.0e-12     4.8e-14

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
*************************************************************************/
public static double invfdistribution(int a, int b, double y)
{
    urn fdistr.invfdistribution(a, b, y, null);
}

public static double invfdistribution(int a, int b, double y, alglib.xparams _params)

re
    urn fd
    i
str.invfdistribu
    t

i
    o
    (
        a
            b

y, _pa
    r
ams);
}
}

public partial class alglib
{
    /*************************************************************************
    Incomplete gamma integral

    The function is defined by

                              x
                               -
                      1       | |  -t  a-1
     igam(a,x)  =   -----     |   e   t   dt.
                     -      | |
                    | (a)    -
                              0


    In this implementation both arguments must be positive.
    The integral is evaluated by either a power series or
    continued fraction expansion, depending on the relative
    values of a and x.

    ACCURACY:

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE      0,30       200000       3.6e-14     2.9e-15
       IEEE      0,100      300000       9.9e-14     1.5e-14

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1985, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double incompletegamma(double a, double x)
    {
        urn igammaf.incompletegamma(a, x, null);
    }

    public static double incompletegamma(double a, double x, alglib.xparams _params)

    re
        urn iga
        m

    maf.incompleteg
        a

    m
        m
        (
            a
                x, _pa
                r
                ams);
}

/*************************************************************************
Complemented incomplete gamma integral

The function is defined by


 igamc(a,x)   =   1 - igam(a,x)

                           inf.
                             -
                    1       | |  -t  a-1
              =   -----     |   e   t   dt.
                   -      | |
                  | (a)    -
                            x


In this implementation both arguments must be positive.
The integral is evaluated by either a power series or
continued fraction expansion, depending on the relative
values of a and x.

ACCURACY:

Tested at random a, x.
               a         x                      Relative error:
arithmetic   domain   domain     # trials      peak         rms
   IEEE     0.5,100   0,100      200000       1.9e-14     1.7e-15
   IEEE     0.01,0.5  0,100      200000       1.4e-13     1.6e-15

Cephes Math Library Release 2.8:  June, 2000
Copyright 1985, 1987, 2000 by Stephen L. Moshier
*************************************************************************/
public static double incompletegammac(double a, double x)
{
    eturn igammaf.incompletegammac(a, x, null);
}

public static double incompletegammac(double a, double x, alglib.xparams _params)
{
    eturn i
    g
    ammaf.incomplete
        g
    a
        m
    a
    c
        a, x, _
    p
        arams);
}

/*************************************************************************
Inverse of complemented imcomplete gamma integral

Given p, the function finds x such that

 igamc( a, x ) = p.

Starting with the approximate value

        3
 x = a t

 where

 t = 1 - d - ndtri(p) sqrt(d)

and

 d = 1/9a,

the routine performs up to 10 Newton iterations to find the
root of igamc(a,x) - p = 0.

ACCURACY:

Tested at random a, p in the intervals indicated.

               a        p                      Relative error:
arithmetic   domain   domain     # trials      peak         rms
   IEEE     0.5,100   0,0.5       100000       1.0e-14     1.7e-15
   IEEE     0.01,0.5  0,0.5       100000       9.0e-14     3.4e-15
   IEEE    0.5,10000  0,0.5        20000       2.3e-13     3.8e-14

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
*************************************************************************/
public static double invincompletegammac(double a, double y0)
{
    eturn igammaf.invincompletegammac(a, y0, null);
}

public static double invincompletegammac(double a, double y0, alglib.xparams _params)
{
    eturn i
    g
    ammaf.invincomplete
        g
    a
        m
    ac
    (
        , y0, _
    p
        arams);
}
}

public partial class alglib
{
    /*************************************************************************
    Chi-square distribution

    Returns the area under the left hand tail (from 0 to x)
    of the Chi square probability density function with
    v degrees of freedom.


                                      x
                                       -
                           1          | |  v/2-1  -t/2
     P( x | v )   =   -----------     |   t      e     dt
                       v/2  -       | |
                      2    | (v/2)   -
                                      0

    where x is the Chi-square variable.

    The incomplete gamma integral is used, according to the
    formula

    y = chdtr( v, x ) = igam( v/2.0, x/2.0 ).

    The arguments must both be positive.

    ACCURACY:

    See incomplete gamma function


    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double chisquaredistribution(double v, double x)
    {
        eturn chisquaredistr.chisquaredistribution(v, x, null);
    }

    public static double chisquaredistribution(double v, double x, alglib.xparams _params)
    {
        eturn chisquar
        e
        distr.chisquaredistri
            b
        u
            t
        o
        n
            v, x, _
        p
            arams);
    }

    /*************************************************************************
    Complemented Chi-square distribution

    Returns the area under the right hand tail (from x to
    infinity) of the Chi square probability density function
    with v degrees of freedom:

                                     inf.
                                       -
                           1          | |  v/2-1  -t/2
     P( x | v )   =   -----------     |   t      e     dt
                       v/2  -       | |
                      2    | (v/2)   -
                                      x

    where x is the Chi-square variable.

    The incomplete gamma integral is used, according to the
    formula

    y = chdtr( v, x ) = igamc( v/2.0, x/2.0 ).

    The arguments must both be positive.

    ACCURACY:

    See incomplete gamma function

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double chisquarecdistribution(double v, double x)
    {
        eturn chisquaredistr.chisquarecdistribution(v, x, null);
    }

    public static double chisquarecdistribution(double v, double x, alglib.xparams _params)
    {
        eturn chisquar
        e
        distr.chisquarecdistri
            b
        u
            t
        o
        n
            v, x, _
        p
            arams);
    }

    /*************************************************************************
    Inverse of complemented Chi-square distribution

    Finds the Chi-square argument x such that the integral
    from x to infinity of the Chi-square density is equal
    to the given cumulative probability y.

    This is accomplished using the inverse gamma integral
    function and the relation

       x/2 = igami( df/2, y );

    ACCURACY:

    See inverse incomplete gamma function


    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double invchisquaredistribution(double v, double y)
    {
        eturn chisquaredistr.invchisquaredistribution(v, y, null);
    }

    public static double invchisquaredistribution(double v, double y, alglib.xparams _params)
    {
        eturn chisquar
        e
        distr.invchisquaredistri
            b
        u
            t
        o
        n
            v, y, _
        p
            arams);
    }
}

public partial class alglib
{
    /*************************************************************************
    Binomial distribution

    Returns the sum of the terms 0 through k of the Binomial
    probability density:

      k
      --  ( n )   j      n-j
      >   (   )  p  (1-p)
      --  ( j )
     j=0

    The terms are not summed directly; instead the incomplete
    beta integral is employed, according to the formula

    y = bdtr( k, n, p ) = incbet( n-k, k+1, 1-p ).

    The arguments must be positive, with p ranging from 0 to 1.

    ACCURACY:

    Tested at random points (a,b,p), with p between 0 and 1.

                  a,b                     Relative error:
    arithmetic  domain     # trials      peak         rms
     For p between 0.001 and 1:
       IEEE     0,100       100000      4.3e-15     2.6e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double binomialdistribution(int k, int n, double p)
    {
        eturn binomialdistr.binomialdistribution(k, n, p, null);
    }

    public static double binomialdistribution(int k, int n, double p, alglib.xparams _params)
    {
        eturn binomia
        l
        distr.binomialdistri
            b
        u
            t
        o
        n
            k,
            n,
            p,
            _
        p
            arams);
    }

    /*************************************************************************
    Complemented binomial distribution

    Returns the sum of the terms k+1 through n of the Binomial
    probability density:

      n
      --  ( n )   j      n-j
      >   (   )  p  (1-p)
      --  ( j )
     j=k+1

    The terms are not summed directly; instead the incomplete
    beta integral is employed, according to the formula

    y = bdtrc( k, n, p ) = incbet( k+1, n-k, p ).

    The arguments must be positive, with p ranging from 0 to 1.

    ACCURACY:

    Tested at random points (a,b,p).

                  a,b                     Relative error:
    arithmetic  domain     # trials      peak         rms
     For p between 0.001 and 1:
       IEEE     0,100       100000      6.7e-15     8.2e-16
     For p between 0 and .001:
       IEEE     0,100       100000      1.5e-13     2.7e-15

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double binomialcdistribution(int k, int n, double p)
    {
        urn binomialdistr.binomialcdistribution(k, n, p, null);
    }

    public static double binomialcdistribution(int k, int n, double p, alglib.xparams _params)

    re
        urn binomiald
        i

    str.binomialcdistribu
        t

    i
        o
        (
            k
                n

    p, _pa
        r

    ams);
}

/*************************************************************************
Inverse binomial distribution

Finds the event probability p such that the sum of the
terms 0 through k of the Binomial probability density
is equal to the given cumulative probability y.

This is accomplished using the inverse beta integral
function and the relation

1 - p = incbi( n-k, k+1, y ).

ACCURACY:

Tested at random points (a,b,p).

              a,b                     Relative error:
arithmetic  domain     # trials      peak         rms
 For p between 0.001 and 1:
   IEEE     0,100       100000      2.3e-14     6.4e-16
   IEEE     0,10000     100000      6.6e-12     1.2e-13
 For p between 10^-6 and 0.001:
   IEEE     0,100       100000      2.0e-12     1.3e-14
   IEEE     0,10000     100000      1.5e-12     3.2e-14

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
*************************************************************************/
public static double invbinomialdistribution(int k, int n, double y)
{
    urn binomialdistr.invbinomialdistribution(k, n, y, null);
}

public static double invbinomialdistribution(int k, int n, double y, alglib.xparams _params)

re
    urn binomiald
    i
str.invbinomialdistribu
    t

i
    o
    (
        k
            n

y, _pa
    r
ams);
}
}

public partial class alglib
{
    /*************************************************************************
    Exponential integral Ei(x)

                  x
                   -     t
                  | |   e
       Ei(x) =   -|-   ---  dt .
                | |     t
                 -
                -inf

    Not defined for x <= 0.
    See also expn.c.



    ACCURACY:

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE       0,100       50000      8.6e-16     1.3e-16

    Cephes Math Library Release 2.8:  May, 1999
    Copyright 1999 by Stephen L. Moshier
    *************************************************************************/
    public static double exponentialintegralei(double x)
    {
        urn expintegrals.exponentialintegralei(x, null);
    }

    public static double exponentialintegralei(double x, alglib.xparams _params)

    re
        urn expinteg
        r

    als.exponentialintegr
        a

    l
        e
        (x, _pa
            r
            ams);
}

/*************************************************************************
Exponential integral En(x)

Evaluates the exponential integral

                inf.
                  -
                 | |   -xt
                 |    e
     E (x)  =    |    ----  dt.
      n          |      n
               | |     t
                -
                 1


Both n and x must be nonnegative.

The routine employs either a power series, a continued
fraction, or an asymptotic formula depending on the
relative values of n and x.

ACCURACY:

                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE      0, 30       10000       1.7e-15     3.6e-16

Cephes Math Library Release 2.8:  June, 2000
Copyright 1985, 2000 by Stephen L. Moshier
*************************************************************************/
public static double exponentialintegralen(double x, int n)

retur
    expintegral

s
    .exponentialintegrale
    n
    (
        x
            n
            nul
            l
    );
}

public static double exponentialintegralen(double x, int n, alglib.xparams _params)
{
    turn expintegrals.exponentialintegralen(x, n, _params);
}
}

public partial class alglib
{
    /*************************************************************************
    Jacobian Elliptic Functions

    Evaluates the Jacobian elliptic functions sn(u|m), cn(u|m),
    and dn(u|m) of parameter m between 0 and 1, and real
    argument u.

    These functions are periodic, with quarter-period on the
    real axis equal to the complete elliptic integral
    ellpk(1.0-m).

    Relation to incomplete elliptic integral:
    If u = ellik(phi,m), then sn(u|m) = sin(phi),
    and cn(u|m) = cos(phi).  Phi is called the amplitude of u.

    Computation is by means of the arithmetic-geometric mean
    algorithm, except when m is within 1e-9 of 0 or 1.  In the
    latter case with m close to 1, the approximation applies
    only for phi < pi/2.

    ACCURACY:

    Tested at random points with u between 0 and 10, m between
    0 and 1.

               Absolute error (* = relative error):
    arithmetic   function   # trials      peak         rms
       IEEE      phi         10000       9.2e-16*    1.4e-16*
       IEEE      sn          50000       4.1e-15     4.6e-16
       IEEE      cn          40000       3.6e-15     4.4e-16
       IEEE      dn          10000       1.3e-12     1.8e-14

     Peak error observed in consistency check using addition
    theorem for sn(u+v) was 4e-16 (absolute).  Also tested by
    the above relation to the incomplete elliptic integral.
    Accuracy deteriorates when u is large.

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static void jacobianellipticfunctions(double u, double m, out double sn, out double cn, out double dn,
        out double ph)


    s
        n

    c
        n

    d
        n

    p
        h jacobianell
        i

    ptic.jacobianellipticfunc
        t

    i
        o

    s
    (
        , m
        r

    e
        sn

    r
        e

    cn
        r

    e
        dn

    r
        e

    ph,
    null);
}

public static void jacobianellipticfunctions(double u, double m, out double sn, out double cn, out double dn,
    out double ph, alglib.xparams _params)
{
    sn =
        0;
    0;


    0;


    0;


    ia
        e
    l
        ip bianellipticfunc
        t
    ions(u, m, ref sn, ref cn
        ,
        r
    f
        n,
        ef

    h,
    pa
        r
    ms)
}
}

public partial class alglib
{
    /*************************************************************************
    Sine and cosine integrals

    Evaluates the integrals

                             x
                             -
                            |  cos t - 1
      Ci(x) = eul + ln x +  |  --------- dt,
                            |      t
                           -
                            0
                x
                -
               |  sin t
      Si(x) =  |  ----- dt
               |    t
              -
               0

    where eul = 0.57721566490153286061 is Euler's constant.
    The integrals are approximated by rational functions.
    For x > 8 auxiliary functions f(x) and g(x) are employed
    such that

    Ci(x) = f(x) sin(x) - g(x) cos(x)
    Si(x) = pi/2 - f(x) cos(x) - g(x) sin(x)


    ACCURACY:
       Test interval = [0,50].
    Absolute error, except relative when > 1:
    arithmetic   function   # trials      peak         rms
       IEEE        Si        30000       4.4e-16     7.3e-17
       IEEE        Ci        30000       6.9e-16     5.1e-17

    Cephes Math Library Release 2.1:  January, 1989
    Copyright 1984, 1987, 1989 by Stephen L. Moshier
    *************************************************************************/
    public static void sinecosineintegrals(double x, out double si, out double ci)
    {
        i

        0;

        c
            i
                = 0


        triginte ne
        o
            i

        ne s(
            ,

        r
        ef ci,  null);
    }

    public static void sinecosineintegrals(double x, out double si, out double ci, alglib.xparams _params)
    {
        si = 0


        ci = 
            ;


        t
            riginte
        rals.si
            necosine s(
            ,
            r
        ef c,
            _
        pa
    }

    /*************************************************************************
    Hyperbolic sine and cosine integrals

    Approximates the integrals

                               x
                               -
                              | |   cosh t - 1
      Chi(x) = eul + ln x +   |    -----------  dt,
                            | |          t
                             -
                             0

                  x
                  -
                 | |  sinh t
      Shi(x) =   |    ------  dt
               | |       t
                -
                0

    where eul = 0.57721566490153286061 is Euler's constant.
    The integrals are evaluated by power series for x < 8
    and by Chebyshev expansions for x between 8 and 88.
    For large x, both functions approach exp(x)/2x.
    Arguments greater than 88 in magnitude return MAXNUM.


    ACCURACY:

    Test interval 0 to 88.
                         Relative error:
    arithmetic   function  # trials      peak         rms
       IEEE         Shi      30000       6.9e-16     1.6e-16
           Absolute error, except relative when |Chi| > 1:
       IEEE         Chi      30000       8.4e-16     1.4e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static void hyperbolicsinecosineintegrals(double x, out double shi, out double chi)
    {
        shi = 0;
        chi = 0
            ;


        rig
            ntegra
        s.h
            y
        erb
            licsin
        cos
            ineinteg ref
            s
            i, nu
        l
            ;
    }

    public static void hyperbolicsinecosineintegrals(double x, out double shi, out double chi, alglib.xparams _params)
    {
        shi = 0;


        chi =
            0
            ;

        tr
            gin
        t
            gra
        s.hype
            bol
        i
            sineco
        s
            ineinte
        rals(x,
            ref shi i,
            p
        r
            am
    }
}

public partial class alglib
{
    /*************************************************************************
    Calculation of the value of the Chebyshev polynomials of the
    first and second kinds.

    Parameters:
        r   -   polynomial kind, either 1 or 2.
        n   -   degree, n>=0
        x   -   argument, -1 <= x <= 1

    Result:
        the value of the Chebyshev polynomial at x
    *************************************************************************/
    public static double chebyshevcalculate(int r, int n, double x)
    {
        r
            e
        t
            u
        r
            n

        c
            h
        e
            b
        y
            s
        h
            e
        v
            .
            c
            h
        e
            b
        y
            s
        hevcalculate
            r,
            n,
 
            ,
  null
            ;
    }

    public static double chebyshevcalculate(int r, int n, double x, alglib.xparams _params)
    {
        return cheby h
        e
            .
            c
            y
        hevca culate(,
        n, x, _pa
            ams);
    }

    /*************************************************************************
    Summation of Chebyshev polynomials using Clenshaw's recurrence formula.

    This routine calculates
        c[0]*T0(x) + c[1]*T1(x) + ... + c[N]*TN(x)
    or
        c[0]*U0(x) + c[1]*U1(x) + ... + c[N]*UN(x)
    depending on the R.

    Parameters:
        r   -   polynomial kind, either 1 or 2.
        n   -   degree, n>=0
        x   -   argument

    Result:
        the value of the Chebyshev polynomial at x
    *************************************************************************/
    public static double chebyshevsum(double[] c, int r, int n, double x)
    {
        r
            e
        t
            u
        r
            n

        c
            h
        e
            b
        y
            s
        h
            e
        v
            .
            c
            h
        e
            b
        y
            s
        h
            e
        v
            s

        u
            m
            (
                c
                ,
                r
                ,
                n
                ,
                x
                ,
                n
                    u
                    l
                    l
            )
            ;
    }

    public static double chebyshevsum(double[] c, int r, int n, double x, alglib.xparams _params)


    tu rn c he by sh ev.c he by sh ev su m(c, r, n, x, _p ar am s);
}

/*************************************************************************
Representation of Tn as C[0] + C[1]*X + ... + C[N]*X^N

Input parameters:
    N   -   polynomial degree, n>=0

Output parameters:
    C   -   coefficients
*************************************************************************/
public static void chebyshevcoefficients(int n, out double[] c)
{
    c =
        ew double[
        0]
    e
    hev.chebyshevcoeff
        i
    c
        i
    e
        n

    t
        s
        (
            n
            ,
            r
                e

    f
        c,
        n
    u
        l
    l
        )
    ;
}

public static void chebyshevcoefficients(int n, out double[] c, alglib.xparams _params)
{
    e ]


    cheb
        ys h
        e
    v
        ef ien
        t
    s(n, ref c, _pa ra ms);
}

/*************************************************************************
Conversion of a series of Chebyshev polynomials to a power series.

Represents A[0]*T0(x) + A[1]*T1(x) + ... + A[N]*Tn(x) as
B[0] + B[1]*X + ... + B[N]*X^N.

Input parameters:
    A   -   Chebyshev series coefficients
    N   -   degree, N>=0

Output parameters
    B   -   power series coefficients
*************************************************************************/
public static void fromchebyshev(double[] a, int n, out double[] b)
{
    b
        ne
    wdouble[0];

    cheb o

    e
        hev(a
            n, re
            b, 

    null);
}

public static void fromchebyshev(double[] a, int n, out double[] b, alglib.xparams _params)
{
    b =
        n
    w
        oub
    e
    [
    ];


    c
        e
    byshev.r h
        n, r
    f b, _
    p
        a
    r
        ams);
}
}

public partial class alglib
{
    /*************************************************************************
    Poisson distribution

    Returns the sum of the first k+1 terms of the Poisson
    distribution:

      k         j
      --   -m  m
      >   e    --
      --       j!
     j=0

    The terms are not summed directly; instead the incomplete
    gamma integral is employed, according to the relation

    y = pdtr( k, m ) = igamc( k+1, m ).

    The arguments must both be positive.
    ACCURACY:

    See incomplete gamma function

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double poissondistribution(int k, double m)
    {
        retu
            n poiss
        ndistr.
            ois
            s
        dist
            r
        bution(k, m, null)
    }

    public static double poissondistribution(int k, double m, alglib.xparams _params)
    {
        r
            e
        t
            u
        r
            n poissondis
        r.pois
            ondist
        ibution(k, m, _para
        m
            s);
    }

    /*************************************************************************
    Complemented Poisson distribution

    Returns the sum of the terms k+1 to infinity of the Poisson
    distribution:

     inf.       j
      --   -m  m
      >   e    --
      --       j!
     j=k+1

    The terms are not summed directly; instead the incomplete
    gamma integral is employed, according to the formula

    y = pdtrc( k, m ) = igam( k+1, m ).

    The arguments must both be positive.

    ACCURACY:

    See incomplete gamma function

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double poissoncdistribution(int k, double m)


    r
        turn

    oissonditr.poissonc
        istr

    bution(
        , m, nu
        l);
}

public static double poissoncdistribution(int k, double m, alglib.xparams _params)
{
    r
        e
    t
        u
    r
        n

    p
        o
    i
        s
    s
        o
    n
        d
    i
        s
    t
    r
        .
        p
        o
    i
        s
    s
        o
    n
        c
    d
        i
    s
        t
    ribution(k,
        , _par
    ms);
}

/*************************************************************************
Inverse Poisson distribution

Finds the Poisson variable x such that the integral
from 0 to x of the Poisson density is equal to the
given probability y.

This is accomplished using the inverse gamma integral
function and the relation

   m = igami( k+1, y ).

ACCURACY:

See inverse incomplete gamma function

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
*************************************************************************/
public static double invpoissondistribution(int k, double y)
{
    r
        t
    r
    npoissondistr.
        ivpoisson
        istribu
    ion(k, y,
        ull);
}

public static double invpoissondistribution(int k, double y, alglib.xparams _params)
{
    retu
        r
    n
        p
    o
        i
    s
        s
    o
        n
    d
        i
    s
        t
    r
        .
        i
        n
    v
        p
    o
        i
    s
        s
    o
        n
    d
        i
    s
        t
    r
        i
    b
        u
    t
        i

    o
        n
        (
            k
            ,
            y
            ,
            _
                p
                a
                r
                a
                m
                s
        )
        ;
}
}

public partial class alglib
{
    /*************************************************************************
    Beta function


                      -     -
                     | (a) | (b)
    beta( a, b )  =  -----------.
                        -
                       | (a+b)

    For large arguments the logarithm of the function is
    evaluated using lgam(), then exponentiated.

    ACCURACY:

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE       0,30       30000       8.1e-14     1.1e-14

    Cephes Math Library Release 2.0:  April, 1987
    Copyright 1984, 1987 by Stephen L. Moshier
    *************************************************************************/
    public static double beta(double a, double b)


    ull);
}

public static double beta(double a, double b, alglib.xparams _params)
{
    betaf.a, b, _arams);
}
}

public partial class alglib
{
    /*************************************************************************
    Fresnel integral

    Evaluates the Fresnel integrals

              x
              -
             | |
    C(x) =   |   cos(pi/2 t**2) dt,
           | |
            -
             0

              x
              -
             | |
    S(x) =   |   sin(pi/2 t**2) dt.
           | |
            -
             0


    The integrals are evaluated by a power series for x < 1.
    For x >= 1 auxiliary functions f(x) and g(x) are employed
    such that

    C(x) = 0.5 + f(x) sin( pi/2 x**2 ) - g(x) cos( pi/2 x**2 )
    S(x) = 0.5 - f(x) cos( pi/2 x**2 ) - g(x) sin( pi/2 x**2 )



    ACCURACY:

     Relative error.

    Arithmetic  function   domain     # trials      peak         rms
      IEEE       S(x)      0, 10       10000       2.0e-15     3.2e-16
      IEEE       C(x)      0, 10       10000       1.8e-15     3.3e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static void fresnelintegral(double x, ref double c, ref double s)
    {
        s
            n
        l.integ
            ref c,
            , null);
    }

    public static void fresnelintegral(double x, ref double c, ref double s, alglib.xparams _params)
    {
        fr
        snel
            .
            resn
            e
        inte
            g
        al(x
        r
        f c, re

        s
            _params);
    }
}

public partial class alglib
{
    /*************************************************************************
    Psi (digamma) function

                 d      -
      psi(x)  =  -- ln | (x)
                 dx

    is the logarithmic derivative of the gamma function.
    For integer x,
                      n-1
                       -
    psi(n) = -EUL  +   >  1/k.
                       -
                      k=1

    This formula is used for 0 < n <= 10.  If x is negative, it
    is transformed to a positive argument by the reflection
    formula  psi(1-x) = psi(x) + pi cot(pi x).
    For general positive x, the argument is made greater than 10
    using the recurrence  psi(x+1) = psi(x) + 1/x.
    Then the following asymptotic expansion is applied:

                              inf.   B
                               -      2k
    psi(x) = log(x) - 1/2x -   >   -------
                               -        2k
                              k=1   2k x

    where the B2k are Bernoulli numbers.

    ACCURACY:
       Relative error (except absolute when |psi| < 1):
    arithmetic   domain     # trials      peak         rms
       IEEE      0,30        30000       1.3e-15     1.4e-16
       IEEE      -30,0       40000       1.5e-15     2.2e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1992, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double psi(double x)
    {
        return
        if.psi
            u
        l);
    }

    public static double psi(double x, alglib.xparams _params)
    {
        retu
        f
            .p
            s
        i
            rams);
    }
}

public partial class alglib
{
    /*************************************************************************
    Airy function

    Solution of the differential equation

    y"(x) = xy.

    The function returns the two independent solutions Ai, Bi
    and their first derivatives Ai'(x), Bi'(x).

    Evaluation is by power series summation for small x,
    by rational minimax approximations for large x.



    ACCURACY:
    Error criterion is absolute when function <= 1, relative
    when function > 1, except * denotes relative error criterion.
    For large negative x, the absolute error increases as x^1.5.
    For large positive x, the relative error increases as x^1.5.

    Arithmetic  domain   function  # trials      peak         rms
    IEEE        -10, 0     Ai        10000       1.6e-15     2.7e-16
    IEEE          0, 10    Ai        10000       2.3e-14*    1.8e-15*
    IEEE        -10, 0     Ai'       10000       4.6e-15     7.6e-16
    IEEE          0, 10    Ai'       10000       1.8e-14*    1.5e-15*
    IEEE        -10, 10    Bi        30000       4.2e-15     5.3e-16
    IEEE        -10, 10    Bi'       30000       4.9e-15     7.3e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static void airy(double x, out double ai, out double aip, out double bi, out double bip)

    a
        i
            =
            = 0;

    bi =
    bip = 0;

    i
        ry

    f
        ai,
        re

    ref a
        bi, re, null)
}

public static void airy(double x, out double ai, out double aip, out double bi, out double bip,
    alglib.xparams _params)
{
    a
        i
            =
            0
        ;


    a
    i
        p
            =
            0
        ;


    b
        i
            = 0;

    bip = 
        ;


    airyf.
        i
        r
        (x,
            ref ai
                r

    e
        ai,  ref
        i ,
        r
    f b
        p, _pa
    am
        s
        ;
}
}

public partial class alglib
{
    /*************************************************************************
    Dawson's Integral

    Approximates the integral

                                x
                                -
                         2     | |        2
     dawsn(x)  =  exp( -x  )   |    exp( t  ) dt
                             | |
                              -
                              0

    Three different rational approximations are employed, for
    the intervals 0 to 3.25; 3.25 to 6.25; and 6.25 up.

    ACCURACY:

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE      0,10        10000       6.9e-16     1.0e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double dawsonintegral(double x)
    {
        return
            awson.daw
        o
            in
        egra
        l
            x, n
        ll
            ;
    }

    public static double dawsonintegral(double x, alglib.xparams _params)
        return

    n.da
        ral(ams)
}

}

public partial class alglib
{
    /*************************************************************************
    Calculation of the value of the Hermite polynomial.

    Parameters:
        n   -   degree, n>=0
        x   -   argument

    Result:
        the value of the Hermite polynomial Hn at x
    *************************************************************************/
    public static double hermitecalculate(int n, double x)
    {
        re ite
            .
            h
            e
        mitecal
            cu, x,  null);
    }

    public static double hermitecalculate(int n, double x, alglib.xparams _params)
    {
        return
            he
        mit
            .herm
            te
        alc
        late(n,
            x, _params
        )
    }

    /*************************************************************************
    Summation of Hermite polynomials using Clenshaw's recurrence formula.

    This routine calculates
        c[0]*H0(x) + c[1]*H1(x) + ... + c[N]*HN(x)

    Parameters:
        n   -   degree, n>=0
        x   -   argument

    Result:
        the value of the Hermite polynomial at x
    *************************************************************************/
    public static double hermitesum(double[] c, int n, double x)
    {
        return hermite.hermitesum(c, n, x, null);
    }

    public static double hermitesum(double[] c, int n, double x, alglib.xparams _params)
    {
        re m
        i
            t
        e
            .
            he
            r
        m
            i
        e
            u
        m
        (
            c
            ,
            n
            ,
            x

        pa
            r
        m
            )
        ;
    }

    /*************************************************************************
    Representation of Hn as C[0] + C[1]*X + ... + C[N]*X^N

    Input parameters:
        N   -   polynomial degree, n>=0

    Output parameters:
        C   -   coefficients
    *************************************************************************/
    public static void hermitecoefficients(int n, out double[] c)
    {
        c
            = new d
        uble[0]
            ;

        itecoe
            ficie nt s(n, r ef
        c, n ul );
    }

    public static void hermitecoefficients(int n, out double[] c, alglib.xparams _params)
    {
        c
            =
            n
        e
            w

        d
            o
        uble[0];
        her
        it
            .h
            rm
        t
            e
        c
            o
        f
            i
        c
            i
        e
            n
        t
        (
            ,
            r
        f
            c,
            _
        p
            a
        r
            as);
    }
}

public partial class alglib
{
    /*************************************************************************
    Calculation of the value of the Legendre polynomial Pn.

    Parameters:
        n   -   degree, n>=0
        x   -   argument

    Result:
        the value of the Legendre polynomial Pn at x
    *************************************************************************/
    public static double legendrecalculate(int n, double x)


    r e
    n le gend
        r

    e
        .
        le lcul te(,
    x nu l);
}

public static double legendrecalculate(int n, double x, alglib.xparams _params)
{
    r
        e
    t
        u
    r
        n

    l
        e
    g
        e
    n
        d
    r
    e
        .
        l
        e
    g
        e
    n
        d
    r
        e
    c
        a
    l
        c
    u
        l
    a
        t
    e
    (
        n
        ,
        x
        ,
        _
    p
        a
    r
        a
    m
        s
        )
    ;
}

/*************************************************************************
Summation of Legendre polynomials using Clenshaw's recurrence formula.

This routine calculates
    c[0]*P0(x) + c[1]*P1(x) + ... + c[N]*PN(x)

Parameters:
    n   -   degree, n>=0
    x   -   argument

Result:
    the value of the Legendre polynomial at x
*************************************************************************/
public static double legendresum(double[] c, int n, double x)

r et u
    le ge nd re.l eg en dr es um(c, n, x, nu ll);
}

public static double legendresum(double[] c, int n, double x, alglib.xparams _params)
{
    r
        e
    t
        u
    r
        n

    l
        e
    g
        e
    n
        d
    r

    e
        .
        l
        egendresum(c, n
            x

    _params
        ;
}

/*************************************************************************
Representation of Pn as C[0] + C[1]*X + ... + C[N]*X^N

Input parameters:
    N   -   polynomial degree, n>=0

Output parameters:
    C   -   coefficients
*************************************************************************/
public static void legendrecoefficients(int n, out double[] c)
    =

new do
    u
ble[0];


l
    g
e
dre.l
egendreoefficients
    n,  ref
    c , nul
    );
}

public static void legendrecoefficients(int n, out double[] c, alglib.xparams _params)
{
    c = ne w do ub le[0];


    eg dr legendre oefficints(n, ref c, _params);
}
}

public partial class alglib
{
    /*************************************************************************
    Bessel function of order zero

    Returns Bessel function of order zero of the argument.

    The domain is divided into the intervals [0, 5] and
    (5, infinity). In the first interval the following rational
    approximation is used:


           2         2
    (w - r  ) (w - r  ) P (w) / Q (w)
          1         2    3       8

               2
    where w = x  and the two r's are zeros of the function.

    In the second interval, the Hankel asymptotic expansion
    is employed with two rational functions of degree 6/6
    and 7/7.

    ACCURACY:

                         Absolute error:
    arithmetic   domain     # trials      peak         rms
       IEEE      0, 30       60000       4.2e-16     1.1e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double besselj0(double x)
    {
        r
            s
        e
            x,  null);
    }

    public static double besselj0(double x, alglib.xparams _params)
    {
        etu
            n bess
        l.besselj0
            x, _params);
    }

    /*************************************************************************
    Bessel function of order one

    Returns Bessel function of order one of the argument.

    The domain is divided into the intervals [0, 8] and
    (8, infinity). In the first interval a 24 term Chebyshev
    expansion is used. In the second, the asymptotic
    trigonometric representation is employed using two
    rational functions of degree 5/5.

    ACCURACY:

                         Absolute error:
    arithmetic   domain      # trials      peak         rms
       IEEE      0, 30       30000       2.6e-16     1.1e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double besselj1(double x)
    {
        etur
            be
        sel.besse
            j
        1
        (
            ,
            ull);
    }

    public static double besselj1(double x, alglib.xparams _params)
    {
        re
            urn bessel.besselj1(x, _para
        s);
    }

    /*************************************************************************
    Bessel function of integer order

    Returns Bessel function of order n, where n is a
    (possibly negative) integer.

    The ratio of jn(x) to j0(x) is computed by backward
    recurrence.  First the ratio jn/jn-1 is found by a
    continued fraction expansion.  Then the recurrence
    relating successive orders is applied until j0 or j1 is
    reached.

    If n = 0 or 1 the routine for j0 or j1 is called
    directly.

    ACCURACY:

                         Absolute error:
    arithmetic   range      # trials      peak         rms
       IEEE      0, 30        5000       4.4e-16     7.9e-17


    Not suitable for large n or x. Use jv() (fractional order) instead.

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double besseljn(int n, double x)
    {
        r
            turn bess
            e
        bess
        ljn
            n, x,  null);
    }

    public static double besseljn(int n, double x, alglib.xparams _params)
    {
        et
            rn
        be
        se
            .besseljn(n, x, _pa
        rms);
    }

    /*************************************************************************
    Bessel function of the second kind, order zero

    Returns Bessel function of the second kind, of order
    zero, of the argument.

    The domain is divided into the intervals [0, 5] and
    (5, infinity). In the first interval a rational approximation
    R(x) is employed to compute
      y0(x)  = R(x)  +   2 * log(x) * j0(x) / PI.
    Thus a call to j0() is required.

    In the second interval, the Hankel asymptotic expansion
    is employed with two rational functions of degree 6/6
    and 7/7.



    ACCURACY:

     Absolute error, when y0(x) < 1; else relative error:

    arithmetic   domain     # trials      peak         rms
       IEEE      0, 30       30000       1.3e-15     1.6e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double bessely0(double x)


    retur
        b

    ssel.bes x,
        n

    u
    )
}

public static double bessely0(double x, alglib.xparams _params)
{
    r
        tur
    besse
        .bessely0(
            , _params);
}

/*************************************************************************
Bessel function of second kind of order one

Returns Bessel function of the second kind of order one
of the argument.

The domain is divided into the intervals [0, 8] and
(8, infinity). In the first interval a 25 term Chebyshev
expansion is used, and a call to j1() is required.
In the second, the asymptotic trigonometric representation
is employed using two rational functions of degree 5/5.

ACCURACY:

                     Absolute error:
arithmetic   domain      # trials      peak         rms
   IEEE      0, 30       30000       1.0e-15     1.3e-16

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
*************************************************************************/
public static double bessely1(double x)
{
    etu
        n bessel.
        e
        s
    s
        l
    y
            (x, null)
        ;
}

public static double bessely1(double x, alglib.xparams _params)
{
    eturn be

    ssel.bes
        ely
        (x, _p
            a

    ams
        ;
}

/*************************************************************************
Bessel function of second kind of integer order

Returns Bessel function of order n, where n is a
(possibly negative) integer.

The function is evaluated by forward recurrence on
n, starting with values computed by the routines
y0() and y1().

If n = 0 or 1 the routine for y0 or y1 is called
directly.

ACCURACY:
                     Absolute error, except relative
                     when y > 1:
arithmetic   domain     # trials      peak         rms
   IEEE      0, 30       30000       3.4e-15     4.3e-16

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 2000 by Stephen L. Moshier
*************************************************************************/
public static double besselyn(int n, double x)
{
    return
        bessel.esselyn(
            n
    x, nul
        l;
}

public static double besselyn(int n, double x, alglib.xparams _params)
{
    return b
    e
        s
    el.
        es
        s

    e
        ln(n, x,
            _
                a
                a
                s)
}

/*************************************************************************
Modified Bessel function of order zero

Returns modified Bessel function of order zero of the
argument.

The function is defined as i0(x) = j0( ix ).

The range is partitioned into the two intervals [0,8] and
(8, infinity).  Chebyshev polynomial expansions are employed
in each interval.

ACCURACY:

                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE      0,30        30000       5.8e-16     1.4e-16

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 2000 by Stephen L. Moshier
*************************************************************************/
public static double besseli0(double x)
{
    re
        urn be

    sel.bess
        li
        (x, n
            ll);
}

public static double besseli0(double x, alglib.xparams _params)
{
    ret
        rn
    be
        s
    s
    e
        .
        es
        s
    li
        (
            x _params
        ;
}

/*************************************************************************
Modified Bessel function of order one

Returns modified Bessel function of order one of the
argument.

The function is defined as i1(x) = -i j1( ix ).

The range is partitioned into the two intervals [0,8] and
(8, infinity).  Chebyshev polynomial expansions are employed
in each interval.

ACCURACY:

                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE      0, 30       30000       1.9e-15     2.1e-16

Cephes Math Library Release 2.8:  June, 2000
Copyright 1985, 1987, 2000 by Stephen L. Moshier
*************************************************************************/
public static double besseli1(double x)
{
    r
        e
    turn bessel.be
    seli1(
        , null);
}

public static double besseli1(double x, alglib.xparams _params)
{
    retu
        n
    essel.b
        ss
    li
    1
    (
        x

    p
        a
    am
        s
        ;
}

/*************************************************************************
Modified Bessel function, second kind, order zero

Returns modified Bessel function of the second kind
of order zero of the argument.

The range is partitioned into the two intervals [0,8] and
(8, infinity).  Chebyshev polynomial expansions are employed
in each interval.

ACCURACY:

Tested at 2000 random points between 0 and 8.  Peak absolute
error (relative when K0 > 1) was 1.46e-14; rms, 4.26e-15.
                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE      0, 30       30000       1.2e-15     1.6e-16

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 2000 by Stephen L. Moshier
*************************************************************************/
public static double besselk0(double x)
{
    re
        urn be
    sel.bess
    lk
    (x,
        null);
}

public static double besselk0(double x, alglib.xparams _params)
{
    eturn bes
    s
    e
        .besselk
    0
    (
        _params)
}

/*************************************************************************
Modified Bessel function, second kind, order one

Computes the modified Bessel function of the second kind
of order one of the argument.

The range is partitioned into the two intervals [0,2] and
(2, infinity).  Chebyshev polynomial expansions are employed
in each interval.

ACCURACY:

                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE      0, 30       30000       1.2e-15     1.6e-16

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 2000 by Stephen L. Moshier
*************************************************************************/
public static double besselk1(double x)

return bessel.besselk1(x, null);
}

public static double besselk1(double x, alglib.xparams _params)
{
    re
        urn bess

    l.bess
        lk1(x, _
            ar
            ms)
}

/*************************************************************************
Modified Bessel function, second kind, integer order

Returns modified Bessel function of the second kind
of order n of the argument.

The range is partitioned into the two intervals [0,9.55] and
(9.55, infinity).  An ascending power series is used in the
low range, and an asymptotic expansion in the high range.

ACCURACY:

                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE      0,30        90000       1.8e-8      3.0e-10

Error is high only near the crossover point x = 9.55
between the two expansions used.

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1988, 2000 by Stephen L. Moshier
*************************************************************************/
public static double besselkn(int nn, double x)
{
    return
        be
    sel
        bessel
    n(nn, x, nu
    l);
}

public static double besselkn(int nn, double x, alglib.xparams _params)
{
    r
        e
    rn
    bessel.be
    selkn
        nn,
        x,
        _p
    rams
        ;
}
}

public partial class alglib
{
    /*************************************************************************
    Calculation of the value of the Laguerre polynomial.

    Parameters:
        n   -   degree, n>=0
        x   -   argument

    Result:
        the value of the Laguerre polynomial Ln at x
    *************************************************************************/
    public static double laguerrecalculate(int n, double x)
    {
        r
            e
        t
            u
        r
            n

        l
            a
        g
            u
        e
            r
        r
        e
            .
            l
            a
        g
            u
        e
            r
        r
            e
        c
            a
        l
            c
        u
            l
        a
            t
        e
        (
            n
            ,
            x
            ,
            n
        u
            l
        l
            )
        ;
    }

    public static double laguerrecalculate(int n, double x, alglib.xparams _params)
    {
        e
            t
        u
        ere.laguerre
            alcula
        e(n, x
        _params
            )
        ;
    }

    /*************************************************************************
    Summation of Laguerre polynomials using Clenshaw's recurrence formula.

    This routine calculates c[0]*L0(x) + c[1]*L1(x) + ... + c[N]*LN(x)

    Parameters:
        n   -   degree, n>=0
        x   -   argument

    Result:
        the value of the Laguerre polynomial at x
    *************************************************************************/
    public static double laguerresum(double[] c, int n, double x)
    {
        return lague
        r
        re.
            a
            g
        erresu
        (
            c, n, x, null);
    }

    public static double laguerresum(double[] c, int n, double x, alglib.xparams _params)
    {
        rturn laguer
        e.lagu
        rresum
            c, n, x, _params)
        ;
    }

    /*************************************************************************
    Representation of Ln as C[0] + C[1]*X + ... + C[N]*X^N

    Input parameters:
        N   -   polynomial degree, n>=0

    Output parameters:
        C   -   coefficients
    *************************************************************************/
    public static void laguerrecoefficients(int n, out double[] c)
    {
        c = new dou
        bl
            lag
        er
        e.l
            guerreco
        fficients(
            ,
            ef c, n
        u
            l
        l
            )
        ;
    }

    public static void laguerrecoefficients(int n, out double[] c, alglib.xparams _params)
    {
        =
        e
            w
        double
        0
            ];

        uerrec
            effici en ts
            (n r

        ef c, _par ms )
        ;
    }
}

public partial class alglib
{
    /*************************************************************************
    Complete elliptic integral of the first kind

    Approximates the integral



               pi/2
                -
               | |
               |           dt
    K(m)  =    |    ------------------
               |                   2
             | |    sqrt( 1 - m sin t )
              -
               0

    using the approximation

        P(x)  -  log x Q(x).

    ACCURACY:

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE       0,1        30000       2.5e-16     6.8e-17

    Cephes Math Library, Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double ellipticintegralk(double m)
    {
        eturn elliptic.ellipticintegralk(m, null);
    }

    public static double ellipticintegralk(double m, alglib.xparams _params)
    {
        eturn elt gr
            a
        lk
    }

    /*************************************************************************
    Complete elliptic integral of the first kind

    Approximates the integral



               pi/2
                -
               | |
               |           dt
    K(m)  =    |    ------------------
               |                   2
             | |    sqrt( 1 - m sin t )
              -
               0

    where m = 1 - m1, using the approximation

        P(x)  -  log x Q(x).

    The argument m1 is used rather than m so that the logarithmic
    singularity at m = 1 will be shifted to the origin; this
    preserves maximum accuracy.

    K(0) = pi/2.

    ACCURACY:

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE       0,1        30000       2.5e-16     6.8e-17

    Cephes Math Library, Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double ellipticintegralkhighprecision(double m1)

    r
        e c
        ghprecis

    i
        o

    n
    1
    l
}

public static double ellipticintegralkhighprecision(double m1, alglib.xparams _params)
lliptic.el
    i
t
    c
n
    eg
r
    lkhig
pre
ision(m1, _paa
}

/*************************************************************************
Incomplete elliptic integral of the first kind F(phi|m)

Approximates the integral



               phi
                -
               | |
               |           dt
F(phi_\m)  =    |    ------------------
               |                   2
             | |    sqrt( 1 - m sin t )
              -
               0

of amplitude phi and modulus m, using the arithmetic -
geometric mean algorithm.




ACCURACY:

Tested at random points with m in [0, 1] and phi as indicated.

                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE     -10,10       200000      7.4e-16     1.0e-16

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 2000 by Stephen L. Moshier
*************************************************************************/
public static double incompleteellipticintegralk(double phi, double m)
{
    returnl ipti ull);
}

public static double incompleteellipticintegralk(double phi, double m, alglib.xparams _params)

el e
l
    cint
e
    r
l
(
    hi,
    m
_params);
}

/*************************************************************************
Complete elliptic integral of the second kind

Approximates the integral


           pi/2
            -
           | |                 2
E(m)  =    |    sqrt( 1 - m sin t ) dt
         | |
          -
           0

using the approximation

     P(x)  -  x log x Q(x).

ACCURACY:

                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE       0, 1       10000       2.1e-16     7.3e-17

Cephes Math Library, Release 2.8: June, 2000
Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
*************************************************************************/
public static double ellipticintegrale(double m)
return
    e
lliptic.elli ticintegral e(, ul);
}

public static double ellipticintegrale(double m, alglib.xparams _params)
{
    return ell
    ptic.ell
        pticinte

    ra
        e(m
            _para
            s);
}

/*************************************************************************
Incomplete elliptic integral of the second kind

Approximates the integral


               phi
                -
               | |
               |                   2
E(phi_\m)  =    |    sqrt( 1 - m sin t ) dt
               |
             | |
              -
               0

of amplitude phi and modulus m, using the arithmetic -
geometric mean algorithm.

ACCURACY:

Tested at random arguments with phi in [-10, 10] and m in
[0, 1].
                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE     -10,10      150000       3.3e-15     1.4e-16

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1993, 2000 by Stephen L. Moshier
*************************************************************************/
public static double incompleteellipticintegrale(double phi, double m)
{
    rturn elliptic.inc
        mpl
    teellipti ll);
}

public static double incompleteellipticintegrale(double phi, double m, alglib.xparams _params)
{
    etu et e
        ph
}
}

public partial class alglib
{
    public class gammafunc
    {
        /*************************************************************************
        Gamma function

        Input parameters:
            X   -   argument

        Domain:
            0 < X < 171.6
            -170 < X < 0, X is not an integer.

        Relative error:
         arithmetic   domain     # trials      peak         rms
            IEEE    -170,-33      20000       2.3e-15     3.3e-16
            IEEE     -33,  33     20000       9.4e-16     2.2e-16
            IEEE      33, 171.6   20000       2.3e-15     3.2e-16

        Cephes Math Library Release 2.8:  June, 2000
        Original copyright 1984, 1987, 1989, 1992, 2000 by Stephen L. Moshier
        Translated to AlgoPascal by Bochkanov Sergey (2005, 2006, 2007).
        *************************************************************************/
        public static double gammafunction(double x,
            alglib.xparams _params)
        {
            d
                o
            u
                b
            l
                e

            r
                e
            s
                u
            l
                t
                    =
                    0
                ;


            d
                o
            u
                b
            l
            e
                p
                    =
                    0
                ;


            double
                p = 0;
            doub
            e q = 0;

            b
                q
            0;
            double z
                =
                i
            t
                i = 0;
            dou
                l

            g
                g
            a

            0


            sngam = 1;

            q
                = (x);

            if
            u
                le)(q)
                le)(
                i
            f(
                le)(x
            le)(0.0


            int)M
            or(q);

            int)
            ou
            n
                (p);


            if
                ==0 )

            {
                sgn
                g
                    m = -1;
            }


            z =
                q
            p;


            if ((double)(z) > (doubl
                )(
                    .5))


            {
                p = p + 1;


                z
                    =
                    q
                    -
                    p
                    ;
            }


            z = q * Math.S
            n(Math
            PI* z);


            =


            z
                = Math.PI / ((q, _p
                    rams))
        }


        {
            ga _param
                );


            sgn
            a
                *
                ;

            ret
                rn res
                l
                ;


            w
                h
            ile
            (
                (
            do
                ou
                    b
            e
                )(3) )


            {
                x
                    z
                        = z * x
                    ;
            }


            ou )


            {
                (
                    )
                (
                    dou
                b
                    le)(
                    -
                        0.000
                0
                0
                0
                00 {
                    /(*x);


                    es
                        x
                            = x + 1;


                    il 2


                    i
                    (
                        (
                    do 00


                    {
                        7
                        2
                        5664
                        9
                        015
                        3
                        2
                        9
                            * x

                        re
                            t
                        ur
                            n

                        r
                        e
                            sult;
                    }

                    = i
                        (
                            (double)(x
                            )
                            = 
                        =
                        double)
                    (
                        2)
                    esult
                        ;


                    esult;

                    0


                    1.60
                    1
                    9
                    522476
                    7
                    5
                    1
                    8
                    61
                    4
                    07E-4;


                    .1 9
                    3
                        -
                        3
                        +
                        x * p


                    1
                        .
                    04 56;


                    p
                        p
                            =
                            4
                    .76367
                    8
                    0
                    0
                    4
                    71 x* pp


                    2.0744
                    8
                    2
                    2
                    7
                    6
                    4
                    843597
                    5
                    1
                    5
                    0E-1 + x * pp;


                    42 + x * pp;


                    pp = 9.9999999
                    9
                    9
                    9
                    9
                    9
                    9
                    99
                    qq = -
                        2. 98

                    q
                        =
                        5 9
                    8
                    2
                    E
                        -
                        4 + 45641
                    9
                    3
                    851797
                    2
                    4
                    0
                    4
                    9
                    4
                    E - 3 + x *
                        q
                    q
                        ;
                        = 43
                    5
                    5
                    2E-2 + x
                        *
                        q
                    q
                        ;


                    qq = 3.5
                    8
                    36 - 2 q = -2
                    3
                    5
                    9
                    1
                    7
                    9
                    5
                    718243348568E-1 + x *
                        q
                    q
                        ;


                    917030
                    730740
                    85 0
                    0
                    0
                    0
                    0
                    00


                    re qq
                    r
                        t
                    urn re
                    s
                        u
                    l
                        t
                        ;
                }


                /*************************************************************************
                Natural logarithm of gamma function
        
                Input parameters:
                    X       -   argument
        
                Result:
                    logarithm of the absolute value of the Gamma(X).
        
                Output parameters:
                    SgnGam  -   sign(Gamma(X))
        
                Domain:
                    0 < X < 2.55e305
                    -2.55e305 < X < 0, X is not an integer.
        
                ACCURACY:
                arithmetic      domain        # trials     peak         rms
                   IEEE    0, 3                 28000     5.4e-16     1.1e-16
                   IEEE    2.718, 2.556e305     40000     3.5e-16     8.3e-17
                The error criterion was relative when the function magnitude
                was greater than one but absolute when it was less than one.
        
                The following test used the relative error criterion, though
                at certain points the relative error could be much higher than
                indicated.
                   IEEE    -200, -4             10000     4.8e-16     1.3e-16
        
                Cephes Math Library Release 2.8:  June, 2000
                Copyright 1984, 1987, 1989, 1992, 2000 by Stephen L. Moshier
                Translated to AlgoPascal by Bochkanov Sergey (2005, 2006, 2007).
                *************************************************************************/
                public static double lngamma(double x,
                    ref double sgngam,
                    alglib.xparams _params)
                {
                    e es ult
                        = 0;

                    0;
                    double b = 0;
                    double c = 0;
                    double p = 0;
                    double q = 0;
                    double u = 0;
                    double w = 0;
                    double z = 0;
                    int i = 0;
                    double logpi = 0;
                    double ls2pi = 0;
                    double tmp = 0;

                    sgngam = 0;

                    sgngam = 1;
                    logpi = 1.14472988584940017414;
                    ls2pi = 0.91893853320467274178;
                    if ((double)(x) < (double)(-34.0))
                    {
                        q = -x;
                        w = lngamma(q, ref tmp, _params);
                        p = (int)Math.Floor(q);
                        i = (int)Math.Round(p);
                        if (i % 2 == 0)
                        {
                            sgngam = -1;
                        }
                        else
                        {
                            sgngam = 1;
                        }

                        z = q - p;
                        if ((double)(z) > (double)(0.5))
                        {
                            p = p + 1;
                            z = p - q;
                        }

                        z = q * Math.Sin(Math.PI * z);
                        result = logpi - Math.Log(z) - w;
                        return result;
                    }

                    if ((double)(x) < (double)(13))
                    {
                        z = 1;
                        p = 0;
                        u = x;
                        while ((double)(u) >= (double)(3))


                        {
                            p
                                u
                                    =
                                    z
                                        = z * u;


                            whi
                                e
                                (d ouble)

                            2


                            {
                                = z / u;


                                p = p
                                1


                                u
                                    +
                                    ;
                            }


                            double
                                (
                                )
                                (
                            do
                        }

                        els


                        1;


                        if ((double)(u) = 
                            =(


                        {
                            t
                                =
                                M
                            ath.Lo
                            g
                                (
                                    z
                                )
                                ;


                            su
                        }


                        =
                        p
                        2;
                            = x + p;
                            =
                        -
                            3
                        78.
                        2
                        5152
                        5
                        69120
                        8
                        5
                        9
                        10
                            = -
                                3
                        8801
                            .
                        63151
                        3
                        4
                        6
                        37


                        b 88


                        b
                            = 62 73;


                        5.x
                        b


                        1;


                        c =
                            -
                                3
                        51.
                        8
                        57 * c =
                            -
                                7
                        0
                        6
                        4.;


                        05 3
                            +
                            *
                                c
                            ;


                        c
                            = 825072
                        7
                        x* c;


                        775829
                        1285 + x
                            * c 88
                        9
                            .
                        414335
                        3
                        2
                        7
                        7
                        3
                        2
                        31 + x * c
                            ;
                            =


                        g
                        z
                            +
                            p;
                        e
                            u
                        rn
                    }


                    q
                        = (x - 0
                            .
                    5
                        )
                    *
                        at;
                    b
                    e
                        (
                            x
                        )
                        > (
                            r
                    s
                        u
                    l
                        t;
                }


                p

                1 d
                    u
                l
                    e
                    )
                (1


                9
                6
                0
                7
                9
                36 00 77
                7
                7
                777777
                7
                8
                    *
                    0
                        .
                0
                01)*p +
                    0
                        .
                0
                8
                33 3)


                e
                    ls


                67 001;
                a 438324
                0
                0
                00 03
                4
                4
                577169
                4
                3
                9
                4
                5 *
                    0
                .0001 +
                    p
                    *
                    a
                    ;
                    = 7205 * 0
                0
                1)+p
                    *
                    a;


                333333
                333192
                77 +
                    /
                ;


                re


                return result;
            }


            private static double gammastirf(double x,
                alglib.xparams _params)
            {
                t
                    = 0;
                do ub le y = 0;


                double v = 0;


                w = 1 / x;


                5
                9
                0
                93628397E-4;


                s
                    t
                7
                1
                6
                380E-4 + w * stir;


                8
                2
                2
                8
                t
                    r = 3 .4 72
                22 22 605458667310E-3 +
                    w
                    *
                    s
                t
                ir i
                    = 8. 33 33 33 3333482257126E-2 + w
                    *
                    s
                t
                    i
                r
                s
                    i
                    ;

                y = Math.xp x) ;

                >(o
                b
                    le)(143.01608) )


                P
                w
                    x,  0.5 * x - 0.25);
            }

            e ls e


            {
                a
                    h
                P
                    o
                w
                (
                    x
                    , 
            }


            r su t =
                24 * y * w


            esult;
        }
    }

    public class normaldistr
    {
        /*************************************************************************
        Error function

        The integral is

                                  x
                                   -
                        2         | |          2
          erf(x)  =  --------     |    exp( - t  ) dt.
                     sqrt(pi)   | |
                                 -
                                  0

        For 0 <= |x| < 1, erf(x) = x * P4(x**2)/Q5(x**2); otherwise
        erf(x) = 1 - erfc(x).


        ACCURACY:

                             Relative error:
        arithmetic   domain     # trials      peak         rms
           IEEE      0,1         30000       3.7e-16     1.0e-16

        Cephes Math Library Release 2.8:  June, 2000
        Copyright 1984, 1987, 1988, 1992, 2000 by Stephen L. Moshier
        *************************************************************************/
        public static double errorfunction(double x,
            alglib.xparams _params)
        {
            o
                b
            l
            0


            0;


            dou le q = 0;


            gn(
                x = Math.A
            b
            s
                (
                    x);
                )(.5)


            xsq = x * x;


            p 8033 8
            31287834;


            p = -0 .2 88 87 40 0 + s *
                p
                = 1
            4
                .
            3
            3
            0
            5
            576 12 + x
            s
            q
                * p;


            08 44 44 +
                sq *
                p
                ;


            7
            8
            3
            6
            5
            0
            7
            5
            7
            7
            p =
                76 p = 87 9
            q* p;


            q 1 00 000000
            00000
            0 + xsq * q;
            q = 38.0190713951939403753468 + xsq * q;
            q = 658.070155459240506326937 + xsq * q;
            q = 6379.60017324428279487120 + xsq * q;
            q = 34216.5257924628539769006 + xsq * q;
            q = 80437.3630960840172826266 + xsq * q;
            result = s * 1.1283791670955125738961589031 * x * p / q;
            return result;
        }
        if( (double)(x)>=(double)(10) )
        {
            result = s;
            return result;
        }
        result = s*(1-errorfunctionc(x, _params));
            return result;
    }


    /*************************************************************************
    Complementary error function

     1 - erf(x) =

                              inf.
                                -
                     2         | |          2
      erfc(x)  =  --------     |    exp( - t  ) dt
                  sqrt(pi)   | |
                              -
                               x


    For small x, erfc(x) = 1 - erf(x); otherwise rational
    approximations are computed.


    ACCURACY:

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE      0,26.6417   30000       5.7e-14     1.5e-14

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1988, 1992, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double errorfunctionc(double x,
        alglib.xparams _params)

    e
        u

    t = 0;

    double p
            = 0;
        0;
        if( (dou
    b
    le)

    (
        x
        )<

    {
        r
            e
        sul
            t
                = (
                    x
        _params);


        re
            t
        u
            rn
    }

if ((doubl
e
    )(x
    )
    <
    (d

{
    r
        e
    sul
        t
            = n(x, _
    a
        a
    m
        s);
    return res
    u
    l
        t
        ;


    if ((d
    ou ub


    {
        r
        su resul
            ;


        p = 0.
        0;
        p 825507
        9
        4
        1
        3
        0
        8
        7057563 + x * p;


        p
            = 872654
        060420
        2961 + x * p;
        p = 77.08161730368428609781633646 + x * p;
        p = 368.5196154710010637133875746 + x * p;
        p = 1143.262070703886173606073338 + x * p;
        p = 2320.439590251635247384768711 + x * p;
        p = 2898.0293292167655611275846 + x * p;
        p = 1826.3348842295112592168999 + x * p;
        q = 1.0;
        q = 17.14980943627607849376131193 + x * q;
        q = 137.1255960500622202878443578 + x * q;
        q = 661.7361207107653469211984771 + x * q;
        q = 2094.384367789539593790281779 + x * q;
        q = 4429.612803883682726711528526 + x * q;
        q = 6089.5424232724435504633068 + x * q;
        q = 4958.82756472114071495438422 + x * q;
        q = 1826.3348842295112595576438 + x * q;
        result = Math.Exp(-math.sqr(x)) * p / q;
        return result;
    }


    /*************************************************************************
    Same as normalcdf(), obsolete name.
    *************************************************************************/
    public static double normaldistribution(double x,
        alglib.xparams _params)

    do
        u
            l
    e re su lt
        = 0;


    e
        or 21 35 6237 3
    0
    8
    8
    0, _params)+1)
    ;

    r
        e
}


/*************************************************************************
Normal distribution PDF

Returns Gaussian probability density function:

               1
   f(x)  = --------- * exp(-x^2/2)
           sqrt(2pi)

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1988, 1992, 2000 by Stephen L. Moshier
*************************************************************************/
public static double normalpdf(double x,
    alglib.xparams _params)
{
    double result = 0
        ;


    l
        b
    ap.assert(math.isfinite(x), "
    N
        o
    r
        m
    al f
    n
        te");
    result = Ma
    t
    h
        .
        E
        xp a
        h
    Sqrt(2 * Math.PI);


    r
        e
    tu
}


/*************************************************************************
Normal distribution CDF

Returns the area under the Gaussian probability density
function, integrated from minus infinity to x:

                           x
                            -
                  1        | |          2
   ndtr(x)  = ---------    |    exp( - t /2 ) dt
              sqrt(2pi)  | |
                          -
                         -inf.

            =  ( 1 + erf(z) ) / 2
            =  erfc(z) / 2

where z = x/sqrt(2). Computation is via the functions
erf and erfc.


ACCURACY:

                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE     -13,0        30000       3.4e-14     6.7e-15

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1988, 1992, 2000 by Stephen L. Moshier
*************************************************************************/
public static double normalcdf(double x,
    alglib.xparams _params)

r
    e
s
    u

0
    ;


r
    e
s
    u
l
    t n(x /
        1
            .
41
4135623730950488
    , _p
    rams)+1
    ;


retu
r
    result;
}


/*************************************************************************
Inverse of the error function

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1988, 1992, 2000 by Stephen L. Moshier
*************************************************************************/
public static double inverf(double e,
    alglib.xparams _params)
{
    es ul t = 
        ;


    u = invnormaldistribution(0.5 * (e + 1), _params) / Math.Sqrt(2);
    return result;
}


/*************************************************************************
Same as invnormalcdf(), deprecated name
*************************************************************************/
public static double invnormaldistribution(double y0,
    alglib.xparams _params)
{
    sult
        =
        0
        ;

    _p;
}


/*************************************************************************
Inverse of Normal CDF

Returns the argument, x, for which the area under the
Gaussian probability density function (integrated from
minus infinity to x) is equal to y.


For small arguments 0 < y < exp(-2), the program computes
z = sqrt( -2.0 * log(y) );  then the approximation is
x = z - log(z)/z  - (1/z) P(1/z) / Q(1/z).
There are two rational functions P/Q, one for 0 < y < exp(-32)
and the other for y up to exp(-2).  For larger arguments,
w = y - 0.5, and  x/sqrt(2pi) = w + w**3 R(w**2)/S(w**2)).

ACCURACY:

                     Relative error:
arithmetic   domain        # trials      peak         rms
   IEEE     0.125, 1        20000       7.2e-16     1.3e-16
   IEEE     3e-308, 0.135   50000       4.6e-16     9.8e-17

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1988, 1992, 2000 by Stephen L. Moshier
*************************************************************************/
public static double invnormalcdf(double y0,
    alglib.xparams _params)
{
    ble res

    double expm2 = 0;
    d o uble s2pi = 0;
    ;
    double y = ;
    double z = 0;
    double y2 = 0;
    double x0 = 0;
    double x1 = 0;
    int code = 0;
    double p0 = 0;
    double q0 = 0;
    double p1 = 0;
    d
    uble q
        = 0;

    double p2
        =
        0;


    q2 = 0
        ;


    e
        xpm2 = 0.135 69189;

    s2 p
    310005
    2
    2;


    i
        ((doub
    l
        e) e)(0)


    result = -math.maxrealnumber;
    return result;
}

if ((double)(y0) >= (double)(1))
{
    result = math.maxrealnumber;
    return result;
}

code = 1;
y = y0;
if ((double)(y) > (double)(1.0 - expm2))
{
    y = 1.0 - y;
    code = 0;
}

if ((double)(y) > (double)(expm2))
{
    y = y - 0.5;
    y2 = y * y;
    p0 = -59.9633501014107895267;
    p0 = 98.0010754185999661536 + y2 * p0;
    p0 = -56.6762857469070293439 + y2 * p0;
    p0 = 13.9312609387279679503 + y2 * p0;
    p0 = -1.23916583867381258016 + y2 * p0;
    q0 = 1;
    q0 = 1.95448858338141759834 + y2 * q0;
    q0 = 4.67627912898881538453 + y2 * q0;
    q0 = 86.3602421390890590575 + y2 * q0;
    q0 = -225.462687854119370527 + y2 * q0;
    q0 = 200.260212380060660359 + y2 * q0;
    q0 = -82.0372256168333339912 + y2 * q0;
    q0 = 15.9056225126211695515 + y2 * q0;


    0 = -1.18331
    6
    211213
    00
    03


    x = y + y
        * y2 * p0 / q0;
    x =
        x * s2pi


    result
        = x;


    turn r
        sult
            = 2.0 * Ma
    h
        L
    g
    (y x
       -
       Ma


    z
        f
        (d ouble)

    8.
        )
        )


    544892
    05
    6
    4
    19

    1
        =
        3 893866
    54
    z
        p
    1;
    p
        =
        5
            .
    16 88162 +
        *p
        ;

    p1 =
        4.
    8
    5
    03 + z * p1


    p1 = 14
    .6 0240
    4
    z* p1;

    p1 68
    5
    7
    902675
    3
    9
        + z
        *
        p1
        ;


    .4 875 * 0.
        )
    z
        * p1;


    268278
    820341
    8 *
        p
        = -(8.
    5
    7
    45
    6
    78
    5
    154685
    4
    1
    3
    6
    1 *;
    q1 = 1


    q1
        = 749731
    z* q1;

    6351
    8
    7
    92


    4
    1
    3
    172038
    2
    5
    4
    6
    7
    2
    030440
        +
        z
        * q1
        ;


    1 0
    4
    8 + z
        *
        q
    1;
    q1
        .
    50 41


    q
    1
        = -(1
            .
    4
    21829
    2
    85 .1


    q
    1 15
    8
    7
    7
    1
    94


    q1 = -(9.332594
    80 00
        )
    z* q1;

    x
    1
        =
        z
        * p


    else


    {
        2

        .23774891776946035970;


        91
        2
        8
        89068984211695 + z * p2;


        88
        0
        5
        29


        p2 = 1.333
        0
        34
        6
        08
        15

        p2 = 2.0148
        5
        38
        9
        54
        91 2;

        p2 = 1.2
        3
        71
        6
        63
        48 + z
        p
            ;

        p2 =
            3
        .0
        1
        58
        15 .0
        0
            + z * p2;


        p2
            =
            2. 08
        2
        0
        .000001 + z * p2;


        84
        8
        293730 * 0.000000001 + z * p
        2
            ;


        1;


        q2 = 6.02
        4
        27
        0
        39
        36


        q 6
        6
        8
        5
        9403
            + z q


        1. 0271 + z
        q2;

        q2 3
        9
        4966
        3
        5890
            *
            0
                .
        1 + z
            *
            q2;


        34
        0
        0
        0
        6088
        5
        431
        8
        9
        0
        3
        7
            * 0


        01
        4
        6
        468212
        7
        7
        3
        9
        1
        0
        4 * 0.00
        0
        1
            + z *
            q
            ;
        47
        5
        80683936 * 0.000001 + z * q2
            ;
        q2
            =
            6.79019408009981274425
            *
            0
                .
        00
        00

        x1 = z * p2 / q2;


        x0 - x1;
        if
        (
            c
        od
            e! {
            x = -x;


            r
                sult = x;

            r
                e
            t
                ur
            n
        }


        /*************************************************************************
        Bivariate normal PDF

        Returns probability density function of the bivariate  Gaussian  with
        correlation parameter equal to Rho:

                                 1              (    x^2 - 2*rho*x*y + y^2  )
            f(x,y,rho) = ----------------- * exp( - ----------------------- )
                         2pi*sqrt(1-rho^2)      (        2*(1-rho^2)        )


        with -1<rho<+1 and arbitrary x, y.

        This function won't fail as long as Rho is in (-1,+1) range.

          -- ALGLIB --
             Copyright 15.11.2019 by Bochkanov Sergey
        *************************************************************************/
        public static double bivariatenormalpdf(double x,
            double y,
            double rho,
            alglib.xparams _params)
        {
            bl
                lt = 0;
            d
                o


            a gl b.ap.assert(math
                .i
            s
                fi
            n
                al
            D
                :
            X is nf ni te");


            th
                i
            finite(y), "B        iva        riateNormal
            C
                D
            F
                :
            Y
                alg li b.a p.ass ert(math.i
                s

            fin
                i

            t
                e
                (r
                    h

            lC
                F
            Rho i s i nf ini te");


            a
                lg ib a. -1
                < d ou ble )(rho) && (double)(rh
            o
                )<(d ub e
                )
            (
                    1)
                ,
            F:
            oi s not in (-1, +1) rang ")        


            o
                n
                );

            resu t Math.E
            xp(-((x * x + y
                  *
                  y
                  -
                  2 * rh o
                (2
            M
                t
            h
            2)
            ;
            ret urn result;
        }


        /*************************************************************************
        Bivariate normal CDF

        Returns the area under the bivariate Gaussian  PDF  with  correlation
        parameter equal to Rho, integrated from minus infinity to (x,y):


                                                  x      y
                                                  -      -  
                                    1            | |    | | 
            bvn(x,y,rho) = -------------------   |      |   f(u,v,rho)*du*dv
                            2pi*sqrt(1-rho^2)  | |    | |    
                                                -      -
                                               -INF   -INF

                                               
        where

                              (    u^2 - 2*rho*u*v + v^2  )
            f(u,v,rho)   = exp( - ----------------------- )
                              (        2*(1-rho^2)        )


        with -1<rho<+1 and arbitrary x, y.

        This subroutine uses high-precision approximation scheme proposed  by
        Alan Genz in "Numerical  Computation  of  Rectangular  Bivariate  and
        Trivariate Normal and  t  probabilities",  which  computes  CDF  with
        absolute error roughly equal to 1e-14.

        This function won't fail as long as Rho is in (-1,+1) range.

          -- ALGLIB --
             Copyright 15.11.2019 by Bochkanov Sergey
        *************************************************************************/
        public static double bivariatenormalcdf(double x,
            double y,
            double rho,
            alglib.xparams _params)

        double
            re
        s
            ult =
                0
            ;
        d 0;


        double
            ran


        d
            o
        u
            b
        e v = 0;
        do
            ul e
        e v1 =
            0;


        do
            ub le f xy s = 0
            ;
        ta = 


        do
            ubl
                d
        o
            ub
        l
        e tc =
                0
            ;


        algl
            i
        b
            .ap
            .
            ss
            r
        t(math
            .i
        sfi ni t
        e
        (
            x), "Bi        va        ri        a
        te Nm a
            lD F:
            is
            in
        i
            n
        i
            t
        e
        "
            )


        se rh s
            f
        riateN
            r
        alCD
        F:
        Y i
        s
            i
        n
            f
        i
            n
        i
            te ")        ;


        s
            er(m th .

        f B
        iv ri Rho i
        infin
            i
        alglib.ap.assert((double)(-1) < (double)(rho) && (double)(rho) < (double)(1),
            "BivariateNormalCDF: Rho is not in (-1,+1) range");
        if ((double)(rho) == (double)(0))
        {
            result = normalcdf(x, _params) * normalcdf(y, _params);
            return result;
        }

        if ((double)(Math.Abs(rho)) <= (double)(0.8))
        {
            //
            // Rho is small, compute integral using using formula (3) by Alan Genz, integrated
            // by means of 10-point Gauss-Legendre quadrature
            //
            rangea = 0;
            rangeb = Math.Asin(rho);
            v = 0;
            v = v + bvnintegrate3(rangea, rangeb, x, y, 0.2491470458134028, -0.1252334085114689, _params);
            v = v + bvnintegrate3(rangea, rangeb, x, y, 0.2491470458134028, 0.1252334085114689, _params);
            v = v + bvnintegrate3(rangea, rangeb, x, y, 0.2334925365383548, -0.3678314989981802, _params);
            v = v + bvnintegrate3(rangea, rangeb, x, y, 0.2334925365383548, 0.3678314989981802, _params);
            v = v + bvnintegrate3(rangea, rangeb, x, y, 0.2031674267230659, -0.5873179542866175, _params);
            v = v + bvnintegrate3(rangea, rangeb, x, y, 0.2031674267230659, 0.5873179542866175, _params);
            v = v + bvnintegrate3(rangea, rangeb, x, y, 0.1600783285433462, -0.7699026741943047, _params);
            v = v + bvnintegrate3(rangea, rangeb, x, y, 0.160078328543346
                , 0.76
            902674
            943047, _params);


            vninte
                r
            at angeb,
                x,
                y,
  995318
            4
                , -0.90
            1172563
            704749, _par
                v =
                    v
            b
            vn angea,
                rangeb,
                y 599531
            4, 0.9
            4
            1
            72 params
                ;
                = v + b
            n
                n
            e
            gr range,
 
                ,
                y,
  865118
                -
                .
            8
            15 , _par
                ms);


            = v + b
            ni
                t
            g
                ra rangeb
                x, 
            0 65118,
            0.
            8
            5
            66 params
                )
            ;


            v = v
                *
                0
                    .
            5
                (rangeb - rangea) / (2 * Math.PI);


            t = no
            r
                ma

            l
                cdf(x,
                    _par
                        a
                        ms)

            *norm
            a
                l
            c
            d
                (y, _params) + v;
        }


        {
            //
            // Rho is l
            a
                rg ntegra
                l
            u
                s
            ing us
            i
                n
            g form
            u
                l
            a
            (
                6
            )
            by Al
            a
                n
            Ge
                n,
                n
            tegrat
                e
            d
                / by means of 20 - point Gauss - Legendre quadrature.
                /


            x = -
                    x
                ;


            y

            Math.Sig
                n
                (
                    r
                        o);


            i
                ((doub
            l
                e) )


            xy
                s
                    =
                    norma
            l
                c
            df(-
                M
            ath
                .Max
                (
                    x
                    ,
                    y
                ), _pa
                r
            a
                ms)
            ;

            fxys = Math.Max(0.0, normalcdf(-x, _params) - normalcdf(y, _params));
            rangea = 0;
            rangeb = M * (1


            //

            Com
                p
            ut a
            y
                i
            c o
            m
                l
            a
                    (6)
                /
                ta = rangeb;


            tb = M
            a
            h.Abs(x
                  -
                  s *
                  t
            c
                = (4 - s * x * y) /
                  8
                ;


            0

            ta * (1 - tc * (tb * tb - t
            a
                ta)/3)*Math.Exp(-(
                t
                * tb / (2 *
                        t
            a* b
            t
                /
                3
                )*Math.Sqrt(2
                            *
                            Math.P
            I
                * norma
            l
                d
            f
                -
                (
                    b / ta), _params);


            v0 = v
            0
            Math.Ex
            p
                (-t
                    .I
                )
                ;
                /
                /
            Compute second te
                r
                (numer
                    i

            ca o
            n
                G
            auss - Legendre

            rule)
            f
                om for
                m
                    l
            a
                (
                    6
                    /
                /
                v1
                =
                0;


            +
                v
            i
                n
            tegrate6(rang
            e
                a, ran
            g
                b,
                x,
                y

            s

            0
            1527533871307258,
            -
                .0765265211334973,
                params)
            ;

            1
                =
                v
            1
                + bvnintegrate
            6
                (range
            a
                range
            b
                x

            y
                s,  0.152753387130
            7
            5
            8, 0.0765265211334
            9
            3, _par
                a
            ms

            1
                = v1 + bvninteg

            r
                ate6(r
                    a

            gea, r
                a
            g
                e,
 
                ,
                y,
                s,
  0.14917298
            6
            726037, -0.2277858
            5
            1416451
                ,
            _
                v1 = v1 + bv
            n
                integr

            a
                e6(ran
                    g

            a
                ,
            r
            a
                geb, x, y, s,  0.14
            9
            7
            29864726037, 0.227
            7
            5851141
            6
            45


            v1 = v
            1
                + bvnin

            t
                grate6
                (
                    a
                        n

            e
            a
                rangeb, x, y, s, 
            0
            1420961093183820,
            -
                .373706
            0
            88 )


            v
            1 = v1
                +
                vninte
            g
                a
            t
            6
            (
                angea, rangeb, x,
                y

            s, 0.1420961093183
            8
            0, 0.37
            3
            70 r
                m
                )
            ;


            v1
                =
                v1 + bvn
            i
                t
            e
                r
            a
            e6(rangea, rangeb,
                , y, s, 0.13168863
            8
            491766,

            -0 1

            p
                a
            ram
                s
                )
            ;


            v1 =
                v1
                +
                bv ea, ra
            g
                b,
                x,
                y,
                s,
 

            .131688
            6
            3
            84491766,

            0
                .
            1086700
            1
            9
            5
            08 );
            n
            0.1 - 0.6360536807265150, _params);
            v1 = v1 + bvnintegrate6(rangea, range 81945319615184, 0.6360536807265150, _params);
            v1 + n
            e
                ,

            ra.
            0
            9
            3
            01 6
            3
            9064
            6
            0150
            8
                , _
                p
            ar
                v1 =
                    v
            1
                +
                b
            v
                n
            integr
                a
            t
                e
            6
            ra y 404,
            0
            746331906
            4
            6
            0150
            8
                , _
                p
            a
                r
            m
                s
                )


            vn a, ra .0 8391
            6
            7182
            2
            218
            8
                , _
                p
            rams);


            v1 = v1 + b
            v
                n
            i
                tegrate
            6
            (
                ra y 576704
                ,
                0
            .8 _para
                s
                ;


            v
            1
                = v
            1
                +
                b

            s, 091, -0.9122344282513259, _params);
            v1 = v1 ang ,
                ,
            0.0626
            72 22
            4
            2825
            1
            325
            9
                ,

            _
                p
            a
                r
            am

            1
                =
                v
            1
                +
                b
            v
                n
            i
                nt ra
            g
                b,
                x,
                y,
                s,
 
            0
            .0
            4
            06
            0
            14
            2
            9
            8
            0
            0
            3869
                ,
            -0
                .
            9
            6
            39
            7
            19
            2
            7
            2
            7
            79
            1
            38
                ,

            _
                p
            ar
                a
            m
                s
                )
            ;


            v1
                =
                v
            1 + bv
            n
                in
            t
                e
            grate6(ra
            n
                g
            e
                a,
                ra
            n
            g
                b,
                x,
                y,
                s 38
            9
            0
                .
            9639
            7
            192
            7
            2
            7
            7
            9
            1
            3
            8
                ,

            _
                p
            a
                r
            a
                m
            s);


            ang , s, 0.0176140071391521, -0.9931285991850949, _params);
            v1 = v1 + bvnintegrat b, 40
            7
            3
            91 18
            0
            49
                ,
            _params);


            v
            1
                =
                1
                *
                .
            5
                (rangeb - rangea) / (2
                                     *
                                     a
            th.PI);


            res
                u
            lt );
        }


        esult
            =
            M
        a
        h
            .a
        x
            result,  0);


        result = Math.M
        n(resul
        t
            , re
            u
        n
        r
            esult;
    }


    /*************************************************************************
    Internal function which computes integrand of  formula  (3)  by  Alan
    Genz times Gaussian weights (passed by user).

      -- ALGLIB --
         Copyright 15.11.2019 by Bochkanov Sergey
    *************************************************************************/
    private static double bvnintegrate3(double rangea,
        double rangeb,
        double x,
        double y,
        double gw,
        double gx,
        alglib.xparams _params)


    doub le result = ;
    dou
    b
        e
            =
            0
        ;
    double t
    2 = 0
    double
        d = 0;
        = 0


    do
        ub e co r = ;


    r
    (
        e
    b
        rangea)*0.5 * gx + (ra g
    e
        + rang ea )*0.5;


    t = Ma t
        d
            =
            1 / (1 + 2 * t2;


    s
        nr = 2
             *
             d


    cosr = (1 - t2 *
        t
    d
        d;
    res
        g w * Math.E xp(
        *c
    s
        osr )) );


    retur
        n
    res lt
}


/*************************************************************************
Internal function which computes integrand of  formula  (6)  by  Alan
Genz times Gaussian weights (passed by user).

  -- ALGLIB --
     Copyright 15.11.2019 by Bochkanov Sergey
*************************************************************************/
private static double bvnintegrate6(double rangea,
    double rangeb,
    double x,
    double y,
    double s,
    double gw,
    double gx,
    alglib.xparams _params)
{
    d
        ouble r su t = 0;

    oubl
        e

    e
        p
    sk
    2
    2x 2 = 0;
    double
        xphsk2


    0


    double sqrt x2 = 0;
    do
        u
            le exp sk s
        = (
            g
    b - ra ng e) a
        n
    ea)*0.5;


    exphsk22x2 = Math.E
    p(-((x -
         s
         * y))
        ;


    exph
    s
        k2 = M
    a
    h.Exp(
        -
            x
        *
        *
            y
    );
    sqrt1x2

    Math.S rt(1 - r) * (1 + r) );

    ex
        p
    h
        p
    x
    y / (1 + s qr t1 x2 )) );


    r
    e
        ult = w
              *
              hs k
    2
        *
        ph s1 sq rt1 x2 / sq rt 1x2 - e xp hs k2 * (1 + (4 - x * *
        s) * r * r / 8));
    ret ur n r e
        t;
}
}

public class ibetaf
{
    /*************************************************************************
    Incomplete beta integral

    Returns incomplete beta integral of the arguments, evaluated
    from zero to x.  The function is defined as

                     x
        -            -
       | (a+b)      | |  a-1     b-1
     -----------    |   t   (1-t)   dt.
      -     -     | |
     | (a) | (b)   -
                    0

    The domain of definition is 0 <= x <= 1.  In this
    implementation a and b are restricted to positive values.
    The integral from x to 1 may be obtained by the symmetry
    relation

       1 - incbet( a, b, x )  =  incbet( b, a, 1-x ).

    The integral is evaluated by a continued fraction expansion
    or, when b*x is small, by a power series.

    ACCURACY:

    Tested at uniformly distributed random points (a,b,x) with a and b
    in "domain" and x between 0 and 1.
                                           Relative error
    arithmetic   domain     # trials      peak         rms
       IEEE      0,5         10000       6.9e-15     4.5e-16
       IEEE      0,85       250000       2.2e-13     1.7e-14
       IEEE      0,1000      30000       5.3e-12     6.3e-13
       IEEE      0,10000    250000       9.3e-11     7.1e-12
       IEEE      0,100000    10000       8.7e-10     4.8e-11
    Outputs smaller than the IEEE gradual underflow threshold
    were excluded from these statistics.

    Cephes Math Library, Release 2.8:  June, 2000
    Copyright 1984, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double incompletebeta(double a,
        double b,
        double x,
        alglib.xparams _params)
    {
        d
            u
        ble re
            ul
                = 0
            ;

        do
            ble t
        0;
        double xc
            = 0;


        double
            w = 0;


        d
            o
        u
            b
        l
        e
            y
                =
                0
            ;


        i
            n
        t
            f
        l
        a
            g
                =
                0
            ;


        d
            o
        u
            b
        l
            e

        s
            g
                =
                0
            ;


        double
            ig = 0


        double
            b
        iginv
        0;

        le max
            am = 0
            ;
        double
        m
            in

        d = 0;
            = 4.5
        35
        99;


        2.2204
        4
        6049250
        1308085
        e - 16;

        1 71.62
        376956
        0
        7
        2
        minlo g
        ma h.inr ea l
            nu
        b
            r
            );
        maxlo
        Math.L
            h

        algl
            b
        a
        p.le) (a > (
            ouble)(0l e
            () > (o
        u
            ble)(0
            )
            ,
        "D
        o
            ma
        i
        n
        error
            in In om
        p
            l
        ete
            B
        alglib.
            p
            asse
        rt((o
        u
            b
        l
            e
            )
        (x) > =
        (
            d
        o
            u
        b
            l
        e
            )
        (
                0
            )
            &
            &
            (
                d
        o
            ub e
            ), "D        om        ai

        rr or i
            n
        In
            co mp et eB ta ")        
        ((doub
            ) == (
                d
        oubl
            e
            )
        (
                0
            )
            )


        r eu l
            t
                =
                0;


        re su t;


        if (
            (
                double)
            (
                x) == (do
            u
                b
        l
            e
            )
        (
                1
            )
            )


        {
            r
                sut
                    = 1;
            urn re
                ult;
        }
        flag = 0;
        if ((double)(b * x) <= (double)(1.0) && (double)(x) <= (double)(0.95))
        {
            result = incompletebetaps(a, b, x, maxgam, _params);
            return result;
        }

        w = 1.0 - x;
        if ((double)(x) > (double)(a / (a + b)))
        {
            flag = 1;
            t = a;
            a = b;
            b = t;
            xc = x;
            x = w;
        }
        else
        {
            xc = w;
        }

        if ((flag == 1 && (double)(b * x) <= (double)(1.0)) && (double)(x) <= (double)(0.95))
        {
            t = incompletebetaps(a, b, x, maxgam, _params);
            if ((double)(t) <= (double)(math.machineepsilon))
            {
                result = 1.0 - math.machineepsilon;
            }
            else
            {
                result = 1.0 - t;
            }

            return result;
        }

        y = x * (a + b - 2.0) - (a - 1.0);
        if ((double)(y) < (double)(0.0))
        {
            w = incompletebetafe(a, b, x, big, biginv, _params);
        }
        else
        {
            w = incompletebetafe2(a, b, x, big, biginv, _params) / xc;
        }

        y = a * Math.Log(x);
        t = b * Math.Log(xc);
        if (((double)(a + b) < (double)(maxgam) && (double)(Math.Abs(y)) < (double)(maxlog)) &&
            (double)(Math.Abs(t)) < (double)(maxlog))
        {
            t = Math.Pow(xc, b);
            t = t * Math.Pow(x, a);
            t = t / a;
            t = t * w;
            t = t * (gammafunc.gammafunction(a + b, _params) / (gammafunc.gammafunction(a, _params) * gammafunc.gammafu
            ction(
                , _par
            ms)));


            if


            ouble)
            (
                t) <= (do
                ble)(ma
            th.machineep


            {
                re ath.ma
                    hi
                e
                    p
                si
            }

            e
                s
            e
                r
            s
                l
            t
        }


        esult
            ;
    }


    lt;
}

mmafun
    .ngamma(a + b, ref sg, _param
s) ngamma
    a
ref sg , _params)-g

am ma(b,
        e
            sg,
        _pa
            r
            ams)
    ;


y
    = w / a);


if (
    (
        double)(y) < (d
o
    ub )


{
    t =
        0
            .
    0
        ;
}


e
se
{
    t );
}


i
    f
(flag
        = 
    =
1


{
    if ((double)(t) <= (double)(math
            .ma)
       )


    {
        = eepsil
        n
            t = 1.
        0
            -
            t
            ;


        retur
            n
    }


    /*************************************************************************
    Inverse of imcomplete beta integral

    Given y, the function finds x such that

     incbet( a, b, x ) = y .

    The routine performs interval halving or Newton iterations to find the
    root of incbet(a,b,x) - y = 0.


    ACCURACY:

                         Relative error:
                   x     a,b
    arithmetic   domain  domain  # trials    peak       rms
       IEEE      0,1    .5,10000   50000    5.8e-12   1.3e-13
       IEEE      0,1   .25,100    100000    1.8e-13   3.9e-15
       IEEE      0,1     0,5       50000    1.1e-12   5.5e-15
    With a and b constrained to half-integer or integer values:
       IEEE      0,1    .5,10000   50000    5.8e-12   1.1e-13
       IEEE      0,1    .5,100    100000    1.7e-14   7.9e-16
    With a = .5, b constrained to half-integer or integer values:
       IEEE      0,1    .5,10000   10000    8.3e-11   1.0e-11

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1996, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double invincompletebeta(double a,
        double b,
        double y,
        alglib.xparams _params)
    {
        do


            double a
        a
            a


        0


        d
            o
        ble bbb
                =
                0
            ;
        do


            d
                o
        u
            b
        le


        do
            u
                ble

        yy
            y
                =
                d
        o
        uble x
                =
                0
            ;


        doub
        l
            x
                = 0;


        d
            o
        u
            b
        l
        e x1 =
                0
            ;


        doubl
        e
            lgm
                =
                0;


        d
        ouble
            y
                = 


        do
            u
                l
        e
            d


        d
            o
        ubl
        e
            y
                =
                0 u
            l

        y
            h
                = d
        u
            l
        e
            xt
        i
        t
            i
                = 0;


        int r
        f
        l
            g
                =
                0;


        int
        d
            ir = 0;


        int
            n
        f
            lg = 0;


        doub
        le s
                = 0;
            =
        0


        yc
            l
                = 0;


        i t n
            e
        w
            t = 0
            ;

        i
            n


        nt
            b
        reak
            i
        hal ecy le = 0;


        ub e) (
            e ro i n
            I
        vIn
            c
        o
            m


        ases
            (doub


        0;


        s


        f((doubl
        e
            )
        (
                y
            )
            = (d
        ub
            l
            )(1.0) )


        {
            r
                sult =
                    1
                ;


            r
                e
            t
                u
            re lt
                ;
        }


        /
        /


        li
            zt io ns are
            n
        o
            t

        r
            ea ll y ne
            c
        e
            ssary,
            w
        i
            sa bo ut '  p
            e
        //         


        r
        f
            lg
                =
                0
            ;
            =
        0;


        l
        g
            m
                =
                0
            ;


        di r = 0;


        o
            m
        l i
        n
            itia
        l
            izations


        yl
            .
            ;

        p
            ih
        l
            e

        iha l
            ecycle
                = 2;
        newt = 3;
        newtcycle = 4;
        breaknewtcycle = 5;
        breakihalvecycle = 6;

        //
        // main loop
        //
        while (true)
        {
            //
            // start
            //
            if (mainlooppos == 0)
            {
                if ((double)(a) <= (double)(1.0) || (double)(b) <= (double)(1.0))
                {
                    dithresh = 1.0e-6;
                    rflg = 0;
                    aaa = a;
                    bbb = b;
                    y0 = y;
                    x = aaa / (aaa + bbb);
                    yyy = incompletebeta(aaa, bbb, x, _params);
                    mainlooppos = ihalve;
                    continue;
                }
                else
                {
                    dithresh = 1.0e-4;
                }

                yp = -normaldistr.invnormaldistribution(y, _params);
                if ((double)(y) > (double)(0.5))
                {
                    rflg = 1;
                    aaa = b;
                    bbb = a;
                    y0 = 1.0
                    y;


                    yp =
                        -yp;
                }


                els


                {
                    rf
                        b;


                    0 = y;
                }


                = (yp *
                    p - 3
                0
                    /
                    6.x
                    = .0 * aaa
                1.
                    )
                1
                .0 0));


                = yp* M
                th.
                    q
                    t
                (x / (2.0 *
                      bb
                1
                0
                    )- -1.0))
                (l
                m
                5
                .0 0 * x));


                0 * d;


                ((dou
                le
                    (
                    )
                    < ( .Log(m
                th
                    m
                n
                    re
                        = 0


                brea
                    ;
            }


            x
            aaa / (aaa + b
            b
                M
            at
                omp
            etebeta(aaa

            b
                b, ;


            (y
            y - y0)/y0;


            f((double)(Ma
            h
                A
            bs e)(
                .2) )


            inloop
            p
                os
                    = newt
                ;


            co
            t
                inue;
        }

        mainlooppos
            =
            c
    }
    /
    /
    /
    /

    i
        h

    lv
        i
        (
            m ve)


    d
        r
            = 0;


    di = 0;


    nloopp
        s = ih
    al
}

//
ecycle
//
if (mainlooppos == ihalvecycle)
    if (i
        =
        9
       )


    {
        )


        {
            x0
            d
                *
                (x


            i
            (
                (
            do
                ou
                    l
                    )
            (
                th.on
                    (d
            u
                le)
            (x 0.0)
                )


            .5;


            x
                = 0);


            if ((
                    o
            b
                le e)(0.0) )
                = incomp b,
                /(
                i
            f
                ((dou
            b
                l
            e)(
                M
            th
                A
            bs(yp)
                )
                <
            (
                d
            ou
                b
            le)(di
            t
                h
            res
                h
                )


            ma
                ;


            yy
                -
                0
                )/


            i
            f(
                (
                    dou

            b
                le(di
                    h
                    esh) )


            {
                main
                o
                    ppos =
                        n
            }
            if ((dou
            l
                )(yyy)
                < (
                    x0 = x;


            i
            f
                d
                    = 0
            5


            d );


            if (
                dir
                >
                1
            )


                di
                    =
                    0.
            5
                *
                di +
                0
            .5;


            {
                (
            }


            r + 1


            f((dou
            b
                le )


            i
                f(rfl
                    g
                    =
                    =

            1
                )


            a;

            bbb
                = 
                ;


            {
                =
                b
                    x = nco bb
                b
                    x, _params
                    );


                x
                    = 
            }


            e {
                x1
                    x;


                1)


                b
                    r
                e
                a
                    k;


                di


                0
                5;


                {
                    if (
                        d
                    r <
                        i =
                        di
                }

                e


                {
                    if
                    (
                        d
                    ir < -1
                        )


                    di
                        =
                        (y
                    y
                    y
                        -
                        y0)/(y
                    h
                        -
                        yl
                        )
                }
                d
                    i
                        =
                        d
                i
                    - 1


                ve
                y
                    le;

                nu m
                a
                    nlo
                o
                    p
                os
            }
        }


        le
            i
            )( {
            n;
            (


            {
            }
            pp
                o
            tin
            u
                e
                ;
                /
                /


            pp
            o
                == ne
            wt


            {
            }


            b,
            r
            f
                s, a(bbb loop
                o
                    = nue


            pp {
                {
                    if (i
                        !
                        = 0


                    et
                    (
                        aa,
                        b
                }

                ub
                    e
                    (yy
                        y)
                {
                    e)
                    y
                        y
                        )>


                    {
                        x = x1;


                        y
                    }


                    (d
                    u
                        le)
                    (y


                    se
                        x
                    1
                        =
                        x;
                }
                )

                (
                    aaa - 1 .0 ub
                e
                    (
                        d) <
                    (
                do
                    u
                        b
                l
                    e)
                (
                    Ma
                t
                h.i
                f
                (
                    (.L )


                ma
                    in;

                co d);


                d
                    =
                    (

                {
                    (x


                    xt = x0
                    0.i
                    f((do
                        u
                            b
                    le
                        )
                    (x
                    t
                        )<=(do
                        u
                            b
                    le)
                    (
                        .0


                    mainloo
                        pp
                }


                l
                    )
                xt)
                    >=
                    = (x1 - x) / (x
                                  -
                                  0);

                xt
                    = x
                        (d ble)(1.0


                os
                    ti


                i
                f
                    ((doub
                l
                    e)(
                    M
                ath
                        .bs(
                    /
                    x
                    )<(doub
                l
                    e
                    )(128.0 * m
                a
                th.mach
                    i
                nee
                    p
                ilo
                    )


                {
                    i = i + 1
                        ;
                    main
                    lo e
                        ;
                }


                {
                    m ak
                }


                eak
                    e
                tcycle
                    /
                    ak

                {
                    d
                        it
                    h
                        es si n
                    o
                        pp
                    os
                        o
                    ti
                        nu on i
                    f

                    rflg !=
                        0
                        )


                    {
                        =(
                            1.
                        -
                            at
                        h.
                    }


                    re
                        s
                    u
                        lt

                    x
                }


                /*************************************************************************
                Continued fraction expansion #1 for incomplete beta integral
        
                Cephes Math Library, Release 2.8:  June, 2000
                Copyright 1984, 1995, 2000 by Stephen L. Moshier
                *************************************************************************/
                private static double incompletebetafe(double a,
                    double b,
                    double x,
                    double big,
                    double biginv,
                    alglib.xparams _params)

                le
                    k
                        = 0;


                doubl
                    e

                pk
                    m

                bl
                    k
                m
                    d
                        = d
                    ;


                k8
                    =
                    0;


                du e bl
                    i
                t
                    n = 0
                    ;


                k1
                    =
                    a;


                k
                2
                    = a + b
                    ;


                a +
                    6
                    = b - 1.0;


                2.0;


                pkm
                1
                    =
                    1
                        .
                0;


                q
                k
                    m1
                        =
                        1.0;


                an
                    s .0
                    ;

                n
                    = 0;

                t hre sh
                    =
                    3.
                0
                    * mat
                h
                    .machineepsil
                    o
                n

                1 * k2 /
                    (k p
                q
                    k = qk
                m
                1
                    +
                    q
                k
                    m
                2 * xk;


                pkm2 = pkm1;


                qkm1 =
                    q
                    ;


                *
                    k


                pk
                    m
                1
                    =
                    p
                k
                    km
                    ;


                0)


                r
                    =
                    pk
                    /
                    q


                f(dou
                b
                    le)
                (
                        r
                    )
                    !
                    =(
                    d
                o
                    t
                        = M a
                th
                    .Abs((an s -
                             r) / r;
            }


            k1 = k
            1
                +
                1.
            0


            0;
            ;


            k
                =
                4 5 + 1 0


            k
                k
            7
                =
                k7 + 2.
            0
                ;


            th.Abs(pk))
            (
                ouble)(big) )


            km2 = pk
            m
                pk
            i
                v


            m1* b i
            i
                nv;
        }


        if ((
                d
        ouble
            )
        (M at h.A
        bs(qk)) <(do
            ub e)(b g
            u


        1
        b
            g
            ;

        qkm2* big;


        bi
            + 1;


        result =
            a
        s;

        return result;
    }


/*************************************************************************
Continued fraction expansion #2
for incomplete beta integral

Cephes Math Library, Release 2.8:  June, 2000
Copyright 1984, 1995, 2000 by Stephen L. Moshier
*************************************************************************/
private static double incompletebetafe2(double a,
    double b,
    double x,
    double big,
    double biginv,
    alglib.xparams _params)
{
    do
        u
            b
    le r
    e
        sult = 0;
        =
    0


    double pkm1 =
        0 ub 0;
    q
        m
            =
            0
        ;

    e
        o
    ub
    do
        uble k3 = 0 double k4 = 0;
    double k5 = 0;
    double k6 = 0;
    double k7 = 0;
    double k8 = 0;
    double r = 0;
    double t = 0;
    double ans = 0;
    double z = 0;
    double thresh = 0;
    int n = 0;

    k1 = a;
    k2 = b - 1.0;
    k3 = a;


    k4 =
        +1.0;


    k5 = 
        .
    0;
    k6 =
        +
            b;
    k7 =
        +
            1.k8
    a +
        2.pkm
        = 0.0
        ;
    qkm2 =
        1.0;


    z
        =
        x
        / (
            s
                .
    0
    .0;


    .0 * mat
        .m
    c
        i
    ne
        o

    1 /
        p
    k xk;


    m1 + qkm
        * x
        ;

    m
        k
    1
        =
        q m2 =
        q


    xk k7* k8)


    1 + km *
        k
        + qm 2 * k
        ;
    2 = k
    1
        ;


    ;


    q;
        )!=
    (
}


ou bl e)r )
dou
b
{
    Mat h
        ;


    ans = ;
}

=
.
;


}
f( <( d
u
le) (t hr es h) )
reak
;
k4
= k4
+
2.
0; k
k5+
1
.0;
k7+ 2. 0
8
f(
qk
)
M
ath.Ab
s
(
pk
)
)>
(
double
)
(
b
i
)
p m
igi nv;
p
k
1
= p km 1*
bi gi nv;
ig n
;
q
k
p
km 1
km
q
k
m2*
b
m1 = q m1
*
big
;
}
}
r
e
s
ul t =
tu
n
re
s
ult
;
}


/*************************************************************************
Power series for incomplete beta integral.
Use when b*x is small and x not too close to 1.

Cephes Math Library, Release 2.8:  June, 2000
Copyright 1984, 1995, 2000 by Stephen L. Moshier
*************************************************************************/
private static double incompletebetaps(double a,
    double b,
    double x,
    double maxgam,
    alglib.xparams _params)
{
    d
        o
    u
        b
    l
        e

    r
        e
    s
        ult = 0;

    double
        = 0;


    double
        t = 0;


    doubl u = 0;


    ouble v

    0;


    do
        u
    le n = 0;

    oubl
    e
        t1 = 
        ;


    d
        u
    b
    e z = 0;


    d
        o
    u
        b
    l
        e

    a
        i
            =
            0
        ;


    d
        o
    u
        b
    l
        e

    s
        g
            =
            0
        ;


    a
        i
            =
            1
                .
    0
        /
        a
        ;


    u = (1
    0 - b)*x


    v = u / (a + 1.
    0
        );


    s
        = 
        = mat
    h.on* ai;


    whi
    le((double
    le) (z) )


    {
        v
            = t /
            a + )
        ;
        s
        s + v


        n = n +
            .0


        s st 1;
            = s + ai


        f
                (
            < (d oubl
            )(
            a
        g
            am )(Math
        Ab
            (
            )
            )< h.Log(
            at
                .a
        xr )


        {
            t
                =
                a
            m
                af ction(
                +b

            p
                ar unc.ga
                m
            f
                n
            ct ms)*ga
            m
                f
            n
            c.n(b, _
            ara
                s
                )
            ;
            s
                *
                *
                Ma;
        }

        e


        c.
            n
            a
        m
        ma(
            a + pa
        a
            s
            )
        mm
        (
            r
        ef
            s
        ma
            u
        ln g
            am,
            p
        ms )
        +u;


        bl
            )
            <(dou
        bl math i
            real nu
            e
        l
            s
    }


    r
        e
    t
        ur
    n
        r
    e
    s
        ult;
}
}

public class studenttdistr
{
    /*************************************************************************
    Student's t distribution

    Computes the integral from minus infinity to t of the Student
    t distribution with integer k > 0 degrees of freedom:

                                         t
                                         -
                                        | |
                 -                      |         2   -(k+1)/2
                | ( (k+1)/2 )           |  (     x   )
          ----------------------        |  ( 1 + --- )        dx
                        -               |  (      k  )
          sqrt( k pi ) | ( k/2 )        |
                                      | |
                                       -
                                      -inf.

    Relation to incomplete beta integral:

           1 - stdtr(k,t) = 0.5 * incbet( k/2, 1/2, z )
    where
           z = k/(k + t**2).

    For t < -2, this is the method of computation.  For higher t,
    a direct method is derived from integration by parts.
    Since the function is symmetric about t=0, the area under the
    right tail of the density is found by calling the function
    with -t instead of t.

    ACCURACY:

    Tested at random 1 <= k <= 25.  The "domain" refers to t.
                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE     -100,-2      50000       5.9e-15     1.4e-15
       IEEE     -2,100      500000       2.7e-15     4.9e-17

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double studenttdistribution(int k,
        double t,
        alglib.xparams _params)


    d = 0;
    = 0;


    doubl
        e rk = 0;

    d
        le f = 0;


    tz =
    = 0;
    = 0;


    a
        k>0, Do
        a

    n
        e

    r
        Distr ib ti

    n
        (d ub le(
        )
        =

    d
        o
    {
        es u
        et ur n re su l
    }

    (d o
    e
    2. 0) )


    r
        k
            =
            z
                =
                r

    k
    /( rk +
    t
        r

    t
        f

    i
        n

    5
    r
    , 0
    .
    ;


    r
        sult;
}


ble) (t
    )
    (
        double


{
    x =
        z
            = 1.p = Ma h
        .A an xs qk
        )


    f( > 1 )


    {
        f =
            1
                .
            ;

        j
            = 3;


        while
        (
            j
            <= k - 2 &&
            (
                dou le(t / f) > (do
            u
                b
        l
            )(math.m
        a
            chi ee si on )
            )


        {
            t
                * (j - 1) / (
                    z
                    * j)
                )
            ;
        }


        p =
            p +
            f
        xsqk z;
    }
    p = p * 2
        .
    0
        /
        ath
    PI
        ;
}


{
    f = 1
        .
    0
        ;


    tz = 1.0;


    k - 2 &
        )) ;

    f = f + tz
    j =
        j + 2;
}
p = f * x / Math.Sqrt(z * rk);
}
if( (double)(t)<(double)(0) )
{
    p = -p;
}
result = 0.5 + 0.5 * p;
return result;
}


/*************************************************************************
Functional inverse of Student's t distribution

Given probability p, finds the argument t such that stdtr(k,t)
is equal to p.

ACCURACY:

Tested at random 1 <= k <= 100.  The "domain" refers to p:
                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE    .001,.999     25000       5.7e-15     8.0e-16
   IEEE    10^-6,.001    25000       2.0e-12     2.9e-14

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
*************************************************************************/
public static double invstudenttdistribution(int k,
    double p,
    alglib.xparams _params)
{
    double resu
        t =
            0;


    double
        t = 0


    ouble
        rk = 0;

    do
        bl
            z
    0;


    nt
        rflg = 
        ;


    alglib.ap.
        s
        s
    rt((k > 0
        &&
        (
            duble)(p) > (double)
        ()) && (double)(
        )<
    double
    (
    ),
    "
    om
        in

    ror
        in InvSt
        dentTD
    st
        i
    bu
    if (
        (double)(p) > (double
    .25) &
        u
    le)(p)
        le)(
        i
    f
        ble)(
        uble)(0


    esult

    rturn result;
}


z
    = 1.0 - 2.0 * p;


z =
    i
etaf
    .
    nvin
    om
letebet
(
    0
5, 0.5 * rk, Math.A
    b
s
    (
        z
    )
    ,

_
    p
a
    r
a
    m
s
    )
;


t
    =
    M
a
    t
h
    .
    S
    q

r
    t
    (
        r
            k

*
        z
    /
    (
        1
            .
0
    -
    z
    )
    )
;


if ((doubl
    )(p) < (
        ouble)
    0.5) )


{
    t
        =
        -
}


retu
    n
r
    e
}
i
(
)
vo t
e
b
e
a(0.*r, .5, 2 0*p, _param )
i
f( (do
u
bl )( at.m an *
)
l n
ume r
}
h
r
k/ z- r
k
);
rg r ur r s
lt; }
}

public class fdistr
{
    /*************************************************************************
    F distribution

    Returns the area from zero to x under the F density
    function (also known as Snedcor's density or the
    variance ratio density).  This is the density
    of x = (u1/df1)/(u2/df2), where u1 and u2 are random
    variables having Chi square distributions with df1
    and df2 degrees of freedom, respectively.
    The incomplete beta integral is used, according to the
    formula

    P(x) = incbet( df1/2, df2/2, (df1*x/(df2 + df1*x) ).


    The arguments a and b are greater than zero, and x is
    nonnegative.

    ACCURACY:

    Tested at random points (a,b,x).

                   x     a,b                     Relative error:
    arithmetic  domain  domain     # trials      peak         rms
       IEEE      0,1    0,100       100000      9.8e-15     1.7e-15
       IEEE      1,5    0,100       100000      6.5e-15     3.5e-16
       IEEE      0,1    1,10000     100000      2.2e-11     3.3e-12
       IEEE      1,5    1,10000     100000      1.1e-11     1.7e-13

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double fdistribution(int a,
        int b,
        double x,
        alglib.xparams _params)

    ouble result = 
        ;


    o
        bl

    w
    =
    ;


    algl
        b.
        p
        .a le)(x)>=

    doubl
        e)(0), "Domain error

    FDist
        i

    n");
    = w/
    );


    resu
        etaf.in

    etebeta(b, w
        ar
        a
        m
        s
    );


    result
}


/*************************************************************************
Complemented F distribution

Returns the area from x to infinity under the F density
function (also known as Snedcor's density or the
variance ratio density).


                     inf.
                      -
             1       | |  a-1      b-1
1-P(x)  =  ------    |   t    (1-t)    dt
           B(a,b)  | |
                    -
                     x


The incomplete beta integral is used, according to the
formula

P(x) = incbet( df2/2, df1/2, (df2/(df2 + df1*x) ).


ACCURACY:

Tested at random points (a,b,x) in the indicated intervals.
               x     a,b                     Relative error:
arithmetic  domain  domain     # trials      peak         rms
   IEEE      0,1    1,100       100000      3.7e-14     5.9e-16
   IEEE      1,5    1,100       100000      8.0e-15     1.6e-15
   IEEE      0,1    1,10000     100000      1.8e-11     3.5e-13
   IEEE      1,5    1,10000     100000      2.0e-11     3.0e-12

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
*************************************************************************/
public static double fcdistribution(int a,
    int b,
    double x,
    alglib.xparams _params)
{
    d
        uble re
        s = 


    do ubl
    e
        w =
            0
        ;


    b ap 1
        )>=(
        d
    oubl
        e
        )(0), "Do        main 
    e
    n
        w
            =
            b / (b
                 +
                 taf.in
    ompl te
    beta(0.5 * b, .w arams)


    rn result;
}


/*************************************************************************
Inverse of complemented F distribution

Finds the F density argument x such that the integral
from x to infinity of the F density is equal to the
given probability p.

This is accomplished using the inverse beta integral
function and the relations

     z = incbi( df2/2, df1/2, p )
     x = df2 (1-z) / (df1 z).

Note: the following relations hold for the inverse of
the uncomplemented F distribution:

     z = incbi( df1/2, df2/2, p )
     x = df2 z / (df1 (1-z)).

ACCURACY:

Tested at random points (a,b,p).

             a,b                     Relative error:
arithmetic  domain     # trials      peak         rms
 For p between .001 and 1:
   IEEE     1,100       100000      8.3e-15     4.7e-16
   IEEE     1,10000     100000      2.1e-11     1.4e-13
 For p between 10^-6 and 10^-3:
   IEEE     1,100        50000      1.3e-12     8.4e-15
   IEEE     1,10000      50000      3.0e-12     4.8e-14

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
*************************************************************************/
public static double invfdistribution(int a,
    int b,
    double y,
    alglib.xparams _params)
{
    ul =
        0;


    alg
        l
    i
    b
        .a
    p
        as
        e
    rt
        (
            (
                a >
                    1
                    && b >
                    =
                    1
            )
            && double)
        (
            y
        )
        >
        (
            ouble)(0)) && ble)(y ou l
    e)(
            n
        )

        //
        /
        / C e proba
        b
    ili
        t
    y

    or
        x
            =
            0. / /
    f.incom 0 * b, 0.5 * a, 0.5, _params);

    //
    // If that is greater than y, then the solution w < .5
    // Otherwise, solve at 1-y to remove cancellation in (b - b*w)
    //
    if ((double)(w) > (double)(y) || (double)(y) < (double)(0.001))
    {
        w = ibetaf.invincompletebeta(0.5 * b, 0.5 * a, y, _params);
        result = (b - b * w) / (a * w);
    }
    else
    {
        w = ibetaf.invincompletebeta(0.5 * a, 0.5 * b, 1.0 - y, _params);
        result = b * w / (a * (1.0 - w));
    }

    return result;
}
}

public class igammaf
{
    /*************************************************************************
    Incomplete gamma integral

    The function is defined by

                              x
                               -
                      1       | |  -t  a-1
     igam(a,x)  =   -----     |   e   t   dt.
                     -      | |
                    | (a)    -
                              0


    In this implementation both arguments must be positive.
    The integral is evaluated by either a power series or
    continued fraction expansion, depending on the relative
    values of a and x.

    ACCURACY:

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE      0,30       200000       3.6e-14     2.9e-15
       IEEE      0,100      300000       9.9e-14     1.5e-14

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1985, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double incompletegamma(double a,
        double x,
        alglib.xparams _params)
    {
        d
            o
        u
            b
        l
            e

        r
            e
        s
            u
        l
            t
                =
                0
            ;


        double iga
        ma
            psilon = 0;


        doule ans = 0;


        doub
        e ax = 0


        do
            ble c = 0;


        ou
        le r = 0


        dou
        le
            tmp =
                0;

        igam
            aepsilon =
                .
        00000000000001


        if
            (dou
        le)
        x)<=(do
            ble)
        0) || (double)(a) <= (doubl
            )(0
            )


        resu
            l
                =
                0
            ;


        s
            l
            ;
    }
    if( (d
    o
    ble
        (x)>(doub
        e)(1) &&

    doub
        e)(
        )>(
        ouble)(
        ) )

    {
        result = 1
                 - n c
        a
            x, _
        p
            ram
        s
            )
        ;


        e
        u
            t;
    }


    ax = a* Ma
    t.Log(x)-x-gamma
        un
        .lngam

    a(a, r
        f

    t
        m

    p
    ,

    _a(
        (
            -709.782
            12893
            38399))


    re
    0;

    re
        u

    t;
}
= M
    x
p
    (ax

a;

c = 1 a
1
    ;


do

{
    +1;


    c =
        c *
        x
        /
        r
        ;
        =

    ans


    hile((d s) > (
            e
        )
        (igam
    lon)

    ult =  as*ax / a;


    eturn r
        sult;
}


/*************************************************************************
Complemented incomplete gamma integral

The function is defined by


 igamc(a,x)   =   1 - igam(a,x)

                           inf.
                             -
                    1       | |  -t  a-1
              =   -----     |   e   t   dt.
                   -      | |
                  | (a)    -
                            x


In this implementation both arguments must be positive.
The integral is evaluated by either a power series or
continued fraction expansion, depending on the relative
values of a and x.

ACCURACY:

Tested at random a, x.
               a         x                      Relative error:
arithmetic   domain   domain     # trials      peak         rms
   IEEE     0.5,100   0,100      200000       1.9e-14     1.7e-15
   IEEE     0.01,0.5  0,100      200000       1.4e-13     1.6e-15

Cephes Math Library Release 2.8:  June, 2000
Copyright 1985, 1987, 2000 by Stephen L. Moshier
*************************************************************************/
public static double incompletegammac(double a,
    double x,
    alglib.xparams _params)
{
    do
        ble resu
    t
    0;

    u
        le a
    n
        s
            =
            o
    e
        ;


    d
        o
    r doub
    e y
    0;

    dou
    le z = 0;


    doub
    le pk = 0;


    do
        ble pkm1
    0


    d
        uble p
        m2 = 0;

    ouble qk
        = 0;


    dou
    le
        qkm
            = 0;
    doubl
    q
        m
            = 
        ;

    double
    m ilon = 0
    00000
    0000000001;

    igamm
    u
        ber =
            9627

    amma
        b
    e
        ri
    220446
    1308085
    00000000
    f
    (
        (d
            (x) <= (
            (0) ||
            le)(a) < (double)(0))


    {
        res
        u
            t = 1;

        retu
            r
        res
        u
            t;


        if ((do
            u
                b
        l
            e
            )
        (
                x
            )
            <
            (
                d
        o
            u
        b
            l
        e
            )
        (
                1
            )
            |
            |

        (
            d
        o
            u
        b
            l
        e
            )
        (
                x
            )
            <
            (
                d
        o
            u
        b
            l
        e
            )
        (
                a
            )
            )


        {
            result =
                1 - inco

            pleteg
                mma(a, x, _para
                    m
                    s);


            turn r
            s
                ul
        }


        ax =
            a * Math.Log(
                ef t mp, _p a
        s) ;


        ((
            (-709.
        8271 893 8399)


        e
            s

        r
            t
        r
    }


    p(a);


    z
        x y
          +
          c = 0


    pk m2 = 1;


    pk
        m1 =
            x +
            1
        ;


    q
        m
    1 = z *
        x
        ;


    a
        ns k
    {
        y = y +;
        z


        y
            c = *c;


        p
            =
            m1 * z - k
        m
        2 * c
            ;


        q
        i
        (
            (d o
        uble)(qk) != (doubl)(
            )

        r = p
            / qk


        M
            );


        ans = r;


        else


        {
            ;
        }


        1
        qk
        2 = qk 1
            ;


        i f(
            (d
            (
                d
        i
            n
        m
        be {
            2 * v


            m
                * i a
                mm ab ig nu m

            q
                qkm
            1
                = ig am m
            abign nv;
        }


        doubl
            )( )>(d
        o
            eilon) );
        result = ans * ax;
        return result;
    }


    /*************************************************************************
    Inverse of complemented imcomplete gamma integral

    Given p, the function finds x such that

     igamc( a, x ) = p.

    Starting with the approximate value

            3
     x = a t

     where

     t = 1 - d - ndtri(p) sqrt(d)

    and

     d = 1/9a,

    the routine performs up to 10 Newton iterations to find the
    root of igamc(a,x) - p = 0.

    ACCURACY:

    Tested at random a, p in the intervals indicated.

                   a        p                      Relative error:
    arithmetic   domain   domain     # trials      peak         rms
       IEEE     0.5,100   0,0.5       100000       1.0e-14     1.7e-15
       IEEE     0.01,0.5  0,0.5       100000       9.0e-14     3.4e-15
       IEEE    0.5,10000  0,0.5        20000       2.3e-13     3.8e-14

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double invincompletegammac(double a,
        double y0,
        alglib.xparams _params)


    double
        result
            = 0;
    iga mae
        silon =
            le iin
        gammabignumbe


    0;
    doubl
        x0 = 0;


    0;

    dou
        = 0;
        =0 doub
    e
        d
            =
            double
    lg


    0
    ou bl h
    e
        h
            = in


    0;
    int i


    ble mp
        =
        0


    maeps il
    n
        .
    0


    v
    45 3599
    27 70
    9
        .
    0
    0 = i
    nvg m
    a
    b
        y = 0

    0;
    y
        ;
    dithre h =
        5
    i
        gm d
        / (*a);


    distr.rm ldi
    t
        (y0,
            x = a * y = gamma lngamma(a, ref
                =
                0
        ;


    hi
    0
        )


    {
        (
            (x0) |
            d
        u
            b
            ) )


        25
            ;

        br ea k;


        y = i nc om pl et eg am ma c(a, x, _p ar am s);
            )
            )>

        (dou
        le(
            y
        h) )


        {
            i < (d

            ubl
                e
                (y0)


            {
                x = x;


                x1
                    =
                    y
                    - 1)*
                    a
                h
                    .
                    (do
                    ub
                        e
                        )
                        <( do u
                89 38 3
                9
                    )


                d
            }


            d) ;


            i f(
                (
                    dou b
            b)(igammaeps lo )
                )


            {
                l


                if (
                        e()
                    )
                    <=(do
                    b
                        e)
                (0 {
                }


                hile((doub e) x0 )==
                (
                    ou gm

                {
                    y =
                        a

                    i
                        ((d
                    o
                        uble)(y) < (double)(y
                    0


                    x
                        yl = 
                        ;


                    br
                        ak;
                }
                d = d + d;
            }
        }
        d = 0.5;
        dir = 0;
        i = 0;
        while (i < 400)
        {
            x = x1 + d * (x0 - x1);
            y = incompletegammac(a, x, _params);
            lgm = (x0 - x1) / (x1 + x0);
            if ((double)(Math.Abs(lgm)) < (double)(dithresh))
            {
                break;
            }

            lgm = (y - y0) / y0;
            if ((double)(Math.Abs(lgm)) < (double)(dithresh))
            {
                break;
            }

            if ((double)(x) <= (double)(0.0))
            {
                break;
            }

            if ((double)(y) >= (double)(y0))
            {
                x1 = x;
                yh = y;
                if (dir < 0)
                {
                    dir = 0;
                    d = 0.5;
                }
                else
                {
                    if (dir > 1)
                    {
                        d = 0.5 * d + 0.5;
                    }


                    else


                    {
                        d yh - yl)
                        ;
                    }
                }


                ir = d
                r + 1;


                else


                {
                    x
                        x;

                    l
                        =
                        y


                    f
                    (
                        .5;


                    i
                        d = 0.5 * d;


                    else


                    d =
                        (l)
                        d
                    ir = dir - 1;


                    1
                }


                result = x;


                r
                    e
                turn
                    resu
                l
                    t
                    ;
            }
        }

public class chisquaredistr
{
    /*************************************************************************
    Chi-square distribution

    Returns the area under the left hand tail (from 0 to x)
    of the Chi square probability density function with
    v degrees of freedom.


                                      x
                                       -
                           1          | |  v/2-1  -t/2
     P( x | v )   =   -----------     |   t      e     dt
                       v/2  -       | |
                      2    | (v/2)   -
                                      0

    where x is the Chi-square variable.

    The incomplete gamma integral is used, according to the
    formula

    y = chdtr( v, x ) = igam( v/2.0, x/2.0 ).

    The arguments must both be positive.

    ACCURACY:

    See incomplete gamma function


    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double chisquaredistribution(double v,
        double x,
        alglib.xparams _params)


    oe e

    a
        lg li b.ap
        .
        a

    s
        s

    e
        r

    t((dou
        b
        l
        e) (
        e)

    1
    ,

    st
        i

    i
        amm f.
        i
        x/


    re
}


/*************************************************************************
Complemented Chi-square distribution

Returns the area under the right hand tail (from x to
infinity) of the Chi square probability density function
with v degrees of freedom:

                                 inf.
                                   -
                       1          | |  v/2-1  -t/2
 P( x | v )   =   -----------     |   t      e     dt
                   v/2  -       | |
                  2    | (v/2)   -
                                  x

where x is the Chi-square variable.

The incomplete gamma integral is used, according to the
formula

y = chdtr( v, x ) = igamc( v/2.0, x/2.0 ).

The arguments must both be positive.

ACCURACY:

See incomplete gamma function

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 2000 by Stephen L. Moshier
*************************************************************************/
public static double chisquarecdistribution(double v,
    double x,
    alglib.xparams _params)
{
    = 0


    t
        ble)
    (
        r
    h
        i


    pl e
    ega
        m
    m
        c
}


/*************************************************************************
Inverse of complemented Chi-square distribution

Finds the Chi-square argument x such that the integral
from x to infinity of the Chi-square density is equal
to the given cumulative probability y.

This is accomplished using the inverse gamma integral
function and the relation

   x/2 = igami( df/2, y );

ACCURACY:

See inverse incomplete gamma function


Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 2000 by Stephen L. Moshier
*************************************************************************/
public static double invchisquaredistribution(double v,
    double y,
    alglib.xparams _params)
{
    oub
        e r
        sult =
            0;


    alg
    ib.ap.as
    ert(((double)(
        ) >= (dou
    le
            (0) &&
        (u bl ut g
        n
    o
        l
    e
        t
    e
        g
    m
        a
    c
        (0 _
    p
        r
    m
        )


    r
        et
    ur
        n
    l
}
}

public class binomialdistr
{
    /*************************************************************************
    Binomial distribution

    Returns the sum of the terms 0 through k of the Binomial
    probability density:

      k
      --  ( n )   j      n-j
      >   (   )  p  (1-p)
      --  ( j )
     j=0

    The terms are not summed directly; instead the incomplete
    beta integral is employed, according to the formula

    y = bdtr( k, n, p ) = incbet( n-k, k+1, 1-p ).

    The arguments must be positive, with p ranging from 0 to 1.

    ACCURACY:

    Tested at random points (a,b,p), with p between 0 and 1.

                  a,b                     Relative error:
    arithmetic  domain     # trials      peak         rms
     For p between 0.001 and 1:
       IEEE     0,100       100000      4.3e-15     2.6e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double binomialdistribution(int k,
        int n,
        double p,
        alglib.xparams _params)
    {
        d 0;

        ib )
        u
        l
            (
                p
            )
            <
            =
            o
        u
            b
        le m
        a
            n
        e
            r
        r
            om
        ia
        lD
            is
            tr
            i
        n
            alg, 

        "
        m
            o
        i


        k t = 0;


        re
            urn

        result
    }
    if( k=
    n )


    {
        re
            ult = 1;
        retur
            esult
            ;
    }


    dn
    =
    -k;

    if( k=
        0 )


    {
        dk = M
        ah.Pow(1.0 - p,
            dn);
    }

    else


    {
        d
            = k +
              1

        dk =
            beta
        f
            inco
        m
            lete
        et
            (dn, dk

        1
        0 - p, _params);
    }


    r
        e

    s
        u

    l
        t
            =
            d

    k
        ;


    r
        e

    t
        u

    r
        n

    r
        e

    s
        u

    l
        t;
}


/*************************************************************************
Complemented binomial distribution

Returns the sum of the terms k+1 through n of the Binomial
probability density:

  n
  --  ( n )   j      n-j
  >   (   )  p  (1-p)
  --  ( j )
 j=k+1

The terms are not summed directly; instead the incomplete
beta integral is employed, according to the formula

y = bdtrc( k, n, p ) = incbet( k+1, n-k, p ).

The arguments must be positive, with p ranging from 0 to 1.

ACCURACY:

Tested at random points (a,b,p).

              a,b                     Relative error:
arithmetic  domain     # trials      peak         rms
 For p between 0.001 and 1:
   IEEE     0,100       100000      6.7e-15     8.2e-16
 For p between 0 and .001:
   IEEE     0,100       100000      1.5e-13     2.7e-15

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
*************************************************************************/
public static double binomialcdistribution(int k,
    int n,
    double p,
    alglib.xparams _params)
{
    r su = 0;
    d
        oub
    l
        e

    k

    0;


    g
        (o)((doubl
            )(0)
            & (double)(p) < uble)(1), "Domain error in BinomialDistributionC");
    alglib.ap.assert(k >= -1 && k <= n, "Domain error in BinomialDistributionC");
    if (k == -1)
    {
        result = 1;
        return result;
    }

    if (k == n)
    {
        result = 0;
        return result;
    }

    dn = n - k;
    if (k == 0)
    {
        if ((double)(p) < (double)(0.01))
        {
            dk = -nearunityunit.nuexpm1(dn * nearunityunit.nulog1p(-p, _params), _params);
        }
        else
        {
            dk = 1.0 - Math.Pow(1.0 - p, dn);
        }
    }
    else
    {
        dk = k + 1;
        dk = ibetaf.incompletebeta(dk, dn, p, _params);
    }

    result = dk;
    return result;
}


/*************************************************************************
Inverse binomial distribution

Finds the event probability p such that the sum of the
terms 0 through k of the Binomial probability density
is equal to the given cumulative probability y.

This is accomplished using the inverse beta integral
function and the relation

1 - p = incbi( n-k, k+1, y ).

ACCURACY:

Tested at random points (a,b,p).

              a,b                     Relative error:
arithmetic  domain     # trials      peak         rms
 For p between 0.001 and 1:
   IEEE     0,100       100000      2.3e-14     6.4e-16
   IEEE     0,10000     100000      6.6e-12     1.2e-13
 For p between 10^-6 and 0.001:
   IEEE     0,100       100000      2.0e-12     1.3e-14
   IEEE     0,10000     100000      1.5e-12     3.2e-14

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
*************************************************************************/
public static double invbinomialdistribution(int k,
    int n,
    double y,
    alglib.xparams _params)

dble result = 0;
double dk = 0;
double dn = 0;
double p = 0;

alglib.ap.assert(k >= 0 && k < n, "Domain error in InvBinomialDistribution");
dn = n - k;
if (k == 0)
{
    if ((double)(y) > (double)(0.8))
    {
        p = -nearunityunit.nuexpm1(nearunityunit.nulog1p(y - 1.0, _params) / dn, _params);
    }
    else
    {
        p = 1.0 - Math.Pow(y, 1.0 / dn);
    }
}
else
{
    dk = k + 1;
    p = ibetaf.incompletebeta(dn, dk, 0.5, _params);
    if ((double)(p) > (double)(0.5))
    {
        p = ibetaf.invincompletebeta(dk, dn, 1.0 - y, _params);
    }
    else
    {
        p = 1.0 - ibetaf.invincompletebeta(dn, dk, y, _params);
    }
}

result = p;
return result;
}
}

public class expintegrals
{
    /*************************************************************************
    Exponential integral Ei(x)

                  x
                   -     t
                  | |   e
       Ei(x) =   -|-   ---  dt .
                | |     t
                 -
                -inf

    Not defined for x <= 0.
    See also expn.c.



    ACCURACY:

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE       0,100       50000      8.6e-16     1.3e-16

    Cephes Math Library Release 2.8:  May, 1999
    Copyright 1999 by Stephen L. Moshier
    *************************************************************************/
    public static double exponentialintegralei(double x,
        alglib.xparams _params)
    {
        es d
        u
            l
        e eul = 0;


        d
            o
        uble f = 0;


        d
        uble f1
            =
            0;


        0 uble 01
        3
        860
        6
        065;


        i
            f
            (ub lt


        r
            e
        tu
    }
    if( (
    d
    ou
    b
        e)

    (
        )

    <
    double)

    (
        2)
        f
            =
            -125429
                7283;

    f1 = f1* x+218.5049168816613393830;
    f1 = f1* x-4176.572384826693777058;
    f1 = f1* x+55411.76756393557601232;
    f1 = f1* x-331338.1331178144034309;
    f1 = f1* x+1592627.163384945414220;
    f2 = 1.000000000000000000000;
    f2 = f2* x-52.50547959112862969197;
    f2 = f2* x+1259.616186786790571525;
    f2 = f2* x-17565.49581973534652631;
    f2 = f2* x+149306.2117002725991967;
    f2 = f2* x-729494.9239640527645655;
    f2 = f2* x+1592627.163384945429726;
    f = f1/f2;
    result = eul+Math.Log(x)+x* f;
        return result;
}

if ((double)(x) < (double)(4))
{
    w = 1 / x;
    f1 = 1.981808503259689673238E-2;
    f1 = f1 * w - 1.271645625984917501326;
    f1 = f1 * w - 2.088160335681228318920;
    f1 = f1 * w + 2.755544509187936721172;
    f1 = f1 * w - 4.409507048701600257171E-1;
    f1 = f1 * w + 4.665623805935891391017E-2;
    f1 = f1 * w - 1.545042679673485262580E-3;

    f1 =
        1 * w + 7.
    59980605299617478514E-5
        ;
        =
        .
    00 000000
        ;

    f2
        =
        f2 * w + 1
    4764986
    7


    2
        = 771748
    24
    6
    4
    48


    2
        = 178978
    9
    0
    2
    62


    f2 =
        f
    2
        * w
        +
        .2
    1
    6
    4
    7
    79034212017463E-2;
    f2 = f
    2
        * w 72
    7
    2
    8
    7
    50


    72 87
    4
        -
        4;


    f
    2 =
        2 * 67


    f = f1 / f2;


    resul
        t
            = Math
                .E
    x
    p(x
    )
    w * (1 + w *
            f
        )
        ;


    t;
    e)


    {
        w 1. 20872 w -
            .
        8
        4
        5
        59 -
            ;


        f1 =
            f
        1 *
            w
        1.
        5
        080
        6
        5554794
        1
        01


        f1 =
            f
        1
            *
            w
            -
            2
        .60150
        0
        4
        274
        2
        62 2
        9
        467469
        4
        113713763365E-2;


        f1 = f1
            *
            w - 40 .3 E
        5


        f1 = f1 * w + 2
            .
        14
        1
        83
        6
        9
        5
        2602903
        7
        95 00 00000;


        2 = f2
        w + 8.58
        523142362203 8E

        f2 = f2 * w + 3285822873995129957E-1;
        f2 = f2 * w + 7.687932158124475434091E-2;
        f2 = f2 * w + 2.449868241021887685904E-2;
        f2 = f2 * w + 8.832165941927796567926E-4;
        f2 = f2 * w + 4.590952299511353531215E-4;
        f2 = f2 * w + -4.729848351866523044863E-6;
        f2 = f2 * w + 2.665195537390710170105E-6;
        f = f1 / f2;
        result = Math.Exp(x) * w * (1 + w * f);
        return result;
    }
    if ((double)(x) < (double)(16))
    {
        w = 1 / x;
        f1 = -2.106934601691916512584;
        f1 = f1 * w + 1.732733869664688041885;
        f1 = f1 * w - 2.423619178935841904839E-1;
        f1 = f1 * w + 2.322724180937565842585E-2;

        f1
        f1 * w +
            .37288044049317983205
        9
        E - 4;


        1 = f1
            *
            w - 8.343
        1956119
        2552752335E-
        f1 = f
             *
             +
                 1. 250394
        81E
        5


        f1 =
            f
            *
            -
                3. 253963
        14
            -
            ;

        f1
        f
            *
            +
                1. 961318
        5
        E
        8
            ;
        1
            = f1 * w + 6.176407863710360
        20


        f
        2
            =
            1.000
        0
        0
        0
        0
        00
        2 = f2
        w
        2
        .2 5778E-
            ;
            = 77
        0
        1
        474037
        8
        6
        2
        3
        4
        7
        E - 1;


        f 30
        9
        3
        53556E-2;

        10
        8
        08
        1
        7
        3
        52773874E-3;

        08
        1
        80
        1
        2
        2
        84048449115E-4;

        +1
        7
        85
        2
        8
        9
        38807675304186E-5;

        2 *
            -
                .4
        5
        9
        3
        11796356686423199E-7;
            =
        2
        w +
            1
                .
        3
        94634930353847498145E-8
            ;
        f2
            =
            f2 * w + 6.1508659339773383
        54


        f
            = f1 / f2;

        xp
        x
            * w
            *
            (
                1
                + w * f);

        re
    }

    if ((doubl
    e) )


    {
        w
            f
        1
            = -2.458119367674020323
        35

        f
        1
            =
            f1 * w - 1.483382253322077
        68


        f1 795735
        5
        591
        8
        13E-
        2
            ;


        1.3483
        568738
        09


        1
            = f1 *
              w
              +
              1
                  .
        3
        4
        277506
        9
        7
        8
        8
        36 =
            f
            *
            w
            -
            7. 64
        6
        E - 5;
        f1 =
            f1 42
        5
        52
        2
        4
        1
        E - 6;
        f1
            = 93
        3
        65
        1
        7
        7
        195E-8;

        f 00
        0
        00
        0
        0
        0
        0;
        f2 =
            f 43
        7
        10
        6
        3
        1
        5E-1;
        f2 =
            f 01
        0
        65
        5
        0
        5
        5E-1;
        f2 =
            f 21
        8
        62
        7
        8
        7
        6E-2;
        f2 =
            f 12
        9
        07
        8
        2
        0
        8E-2;
        f2 =
            f 05
        0
        021882E-3;

        24
        2
        63
        7
        7
        8
        485013756E-5;

        .7
        8
        38
        4
        0
        3
        476726394024E-6;

        .2
        9
        62
        4
        3
        1
        819542051337E-8;


        result = Math.Exp(x)
                 * w


        return result;
    }
    (
        o
    bl
        e
        )
    (
            x) < (double)(64) )
        =

    1
        /
        x;
    f1 = 1.
    21 8
    4
        - 1
        ;
        = f1* w
    5
    8231
    3
    317
    9
    0
    4
    3
    8
    9
    4
    4
    8
    5
    1
    2
    2
    E - f1
    f1 * w +
        2. 01


    f
    1 = f1
        *
        w
        -
        3
    04 82


    08
    1
    6
    865190661777E-3;

    w -
        .
    23
    1
    3
    7
    095499571377122E-5;

    00
    0
    00
    0
    0
    0
    0000000000;

    02
    5
    15
    0
    3
    6
    5854016662;

    09
    9
    87
    2
    2
    2
    4144953E-1;

    04
    3
    67
    4
    0
    0
    7801307E-2;

    44
    8
    12
    7
    3
    8
    8842819E-3;

    37
    9
    60
    3
    2
    3
    4562648E-5;


    result = Math.Exp
        (x


    return result;

    w
        / x
        ;


    f1 = -7.6578470
    78


    f1 = f1 * w + 6.88619241556
    67


    f
    1 = f1 * w - 2.132598113545206
    12

    f1
        =
        f1 * w + 3.3461075523841938135
    94 f
        f
    1
        *
        w
        - 3.076541477344756050249E-
    3; =
    1
    w +
        1
            .
    7
    4
    7119316454907477380E-4;

    w -
        .
    03
    7
    1
    1
    682274170530369E-6;

    2
    8
    32
    7
    65
    42

    f1
        = f
    1
        *
        w
        -
        1
            .
    0
    8
    6
    0
    7
    6
    1
    02


    f2 00;


    f
    2
        = f2 * w
          -
          1
    .8
    8
    80 10 f
        f
    2
        * w 08
    9
    8
    50;
    f2 = f2
         * w 80
    4
    73
    8
    E
        -
        1;
    f2 = f2 *
        w + 35
    9
    26
    E
        -
        2
        ;
    f2 = f2 * w - 3.
    41 39
    E
    3;


    f2 = f2 * w + 1.8668
    44 - 4


    f2 = f2 * w - 6.34514608
    31


    f2 = f2 * w + 1.239754287483
    20


    f
    2
        = f2 * w - 1.0860761027931266
    32
        =
        f
    1
        / f2;
    result =
        Ma * f
        ;


    return result;
}


/*************************************************************************
Exponential integral En(x)

Evaluates the exponential integral

                inf.
                  -
                 | |   -xt
                 |    e
     E (x)  =    |    ----  dt.
      n          |      n
               | |     t
                -
                 1


Both n and x must be nonnegative.

The routine employs either a power series, a continued
fraction, or an asymptotic formula depending on the
relative values of n and x.

ACCURACY:

                     Relative error:
arithmetic   domain     # trials      peak         rms
   IEEE      0, 30       10000       1.7e-15     3.6e-16

Cephes Math Library Release 2.8:  June, 2000
Copyright 1985, 2000 by Stephen L. Moshier
*************************************************************************/
public static double exponentialintegralen(double x,
    int n,
    alglib.xparams _params)
{
    ul t
    0


    double r = 0;
        = 0


    double yk = 0;


    d
        o
    u
    ble pk = 0;
    d ouble p k
    e
        k
    2
        =
        0
        ;
    d ouble qk = 0;


    km
    0
        ;
    double qk m2 = 0


    d ou ble z = 0;
    i t
        i
            = in
            =
    0
        ;


    doub e ig = 0;
        = ;


    eul = 0. 772 15 66 49 015328
    6
    ig
        =
        1.4411518807585 87 * Ma th.P ow(
        10
    if (
        (
            n
            <
            0 || (double)(x < (oub le )(0) ) ||
    (le
            (1 0)
        )
        |
        | ((double)(x) = (d ubl e) (0) && n
        < 2 {
        result = -1
    }
    if (d ou bl e) (x) = 
        =(


    {
        re ult = (do
            u
                );


        r tur n re su lt;


        f(
            n
                = 0
        )


        {
            re
            s
                / x


            r et ur n result;


            i
            (
                n >
                5
            00
            0


            xk
                =
                x +
                n
                ;


            t
                =
                k * *(*x * x - 8 * t * x
                      +
                      t
                      *
                      t);
                =
            x
                =
                y
                *
                (r esult + t);

            r e
            at
                .xp
                (
                    -x / x;
            r et ur n re su lt;


            i
            do
                u
                    b
            le )(x) <= (double)(1) )
                =
            e
            l - M at h.Lo g();
            for (i
                     = 


            {
                psi = p
                s
                    e)
                ;
            }

            z =
                k
                    = 0;
            yk = 1;
                =
            -
                ;


            if (n =  =1 )


            resul = 0.0;


            e
                s
        }
        do


            xk = k +;


        i
        f
        (
            (
                d
        o
            u
        b
            l
        e
            )
            = r
    }


    es
        l
        )!
        =
    (
        d
    ouble)(0) )


    t = Math.Abs(yk / r esult);


    else


    t = 1;


    while ((double)(
               t
    th
        m
    ch
        i
    n
        ee si on) ) ;
    t =
        1


    or
    (
        i
            =
            1;
    i = n 1;
    i + +)


    t = t * z / i;
}

r
es
    l
    ;
retur
    n
}
el se
{
    ;


    pkm2 = 1;


    pkm1 = 1.0;

    qk
        result = pkm1 / qk 1;


    {
        = k
            +
            i
        f
        (
            k % 2 == 1)


        y
            k
                = 1;


        -1
            /
        do
            u
                b
        l
            e)2;
    }


    el e


    {
        xk
            d oubl
            e
            )k /
        (
            d
        o
            u
        b
            l
        e
            )
        2
            ;


        m1 * yk + pkm2 * xk;
        qk = qkm1 * yk + qkm2 * xk;
        if ((double)(qk) != (double)(0))
        {
            r = pk / qk;
            t = Math.Abs((result - r) / r);
            result = r;
        }
        else
        {
            t = 1;
        }

        pkm2 = pkm1;
        pkm1 = pk;
        qkm2 = qkm1;
        qkm1 = qk;
        if ((double)(Math.Abs(pk)) > (double)(big))
        {
            pkm2 = pkm2 / big;
            pkm1 = pkm1 / big;
            qkm2 = qkm2 / big;
            qkm1 = qkm1 / big;
        }
    }
    while ((double)(t) >= (double)(math.machineepsilon)) ;
    result = result * Math.Exp(-x);
}
return result;
}
}

public class jacobianelliptic
{
    /*************************************************************************
    Jacobian Elliptic Functions

    Evaluates the Jacobian elliptic functions sn(u|m), cn(u|m),
    and dn(u|m) of parameter m between 0 and 1, and real
    argument u.

    These functions are periodic, with quarter-period on the
    real axis equal to the complete elliptic integral
    ellpk(1.0-m).

    Relation to incomplete elliptic integral:
    If u = ellik(phi,m), then sn(u|m) = sin(phi),
    and cn(u|m) = cos(phi).  Phi is called the amplitude of u.

    Computation is by means of the arithmetic-geometric mean
    algorithm, except when m is within 1e-9 of 0 or 1.  In the
    latter case with m close to 1, the approximation applies
    only for phi < pi/2.

    ACCURACY:

    Tested at random points with u between 0 and 10, m between
    0 and 1.

               Absolute error (* = relative error):
    arithmetic   function   # trials      peak         rms
       IEEE      phi         10000       9.2e-16*    1.4e-16*
       IEEE      sn          50000       4.1e-15     4.6e-16
       IEEE      cn          40000       3.6e-15     4.4e-16
       IEEE      dn          10000       1.3e-12     1.8e-14

     Peak error observed in consistency check using addition
    theorem for sn(u+v) was 4e-16 (absolute).  Also tested by
    the above relation to the incomplete elliptic integral.
    Accuracy deteriorates when u is large.

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static void jacobianellipticfunctions(double u,
        double m,
        ref double sn,
        ref double cn,
        ref double dn,
        ref double ph,
        alglib.xparams _params)

    {
        le
        0;


        d ou bl e[] a
        e
        0

        0;
        dn =
            0
            ;


        s
        r
            ((do
            u
                ble
                )
        (m
            )
            >= (dou
        b
            l
        "Dom
        l
            m
        1
            )
        ;
        o
        e[8 + 1
        ]


        e)( )< dou bl e) (1.0e-9)


        Sin(u);


        a
            =
            0
                .
        25
        ab;
        ai* t;


        d
            n;


        if

        d
            o
        9999
        9
        99)


        b
            =
            h(p
        i
            = 1
        wo n =
            M
        a
            t
        h.
            S
            n
        b) ;


        h
            .E p())-1. 57 07 9
        6
        3
        26 -
            = phi + ai *
            (
                tw on + u );

        = 1
            .
        0;


        -m
            ;


        c
        [0
        ]


        two
            n
                =
                1
        .0
            ;


        hi i
            /

        [i
        ]
        ))
        >

        (l
        n
            )


        {
            {
                a e,  "O        ll         


                i =
                    a[i =
                        +
                    ;

                0.5
                    (
                        i - b)
                    ;
                Math
                    S
                rt
                    (a
                a
                    i
                        ] = 0.
                5
                    *
                    (ai +
                     b
                    );


                b
                    =
                    t;
                n
            }


            p
                hi
            o


            c[i]
            M
            th.S
                i
            n(p
            hi b =
                    h
                ;


            As = i - 1
                ;
        }


        w
        hile(i != 0);
            .Sin(p
        i
            ;


        t
            =
            M
        at = t;


        dn = ta os - b);


        ph = phi;
    }
}

public class trigintegrals
{
    /*************************************************************************
    Sine and cosine integrals

    Evaluates the integrals

                             x
                             -
                            |  cos t - 1
      Ci(x) = eul + ln x +  |  --------- dt,
                            |      t
                           -
                            0
                x
                -
               |  sin t
      Si(x) =  |  ----- dt
               |    t
              -
               0

    where eul = 0.57721566490153286061 is Euler's constant.
    The integrals are approximated by rational functions.
    For x > 8 auxiliary functions f(x) and g(x) are employed
    such that

    Ci(x) = f(x) sin(x) - g(x) cos(x)
    Si(x) = pi/2 - f(x) cos(x) - g(x) sin(x)


    ACCURACY:
       Test interval = [0,50].
    Absolute error, except relative when > 1:
    arithmetic   function   # trials      peak         rms
       IEEE        Si        30000       4.4e-16     7.3e-17
       IEEE        Ci        30000       6.9e-16     5.1e-17

    Cephes Math Library Release 2.1:  January, 1989
    Copyright 1984, 1987, 1989 by Stephen L. Moshier
    *************************************************************************/
    public static void sinecosineintegrals(double x,
        ref double si,
        ref double ci,
        alglib.xparams _params)
    {
        double z
            = 0;


        do
            ble c =
                    0
                ;
        doubl
        e
            s
                =
                0
            ;


        d
            o
        u
            b
        l
        e
            f
                =
                0
            ;


        d
            o
        u
            b
        l
        e
            g
                =
                0
            ;


        int sg = 0;


        dou
        le sn = 0;
        do
            u
        ble sd
            =
            0 doub
            e
        c
            dou
        le
            c
        dou
            le
        f
            dou
        le
            f
        dou
            le
        g

        double
            d = 0;


        {
            sg =
                e l
                sg = 0;
        }
        f x)==d
            ;


        c i
        mb
            e
            ;


        r
            e
        t
            urn;
            )(x
            )
            >
            (
                d
                    = 1 .5
        7
        0
        7
        9
        6
        3
        2
        6
        7
        9
        4
        at
        h
            .Co


        c
            i
                =
                (
                    le
                )
        {
            13 0
            8814
            2
            7E-1
            1
                ;


            s
                n
                    = 27 12 3
            3


            sn = s3 0
            3
            8


            sn = s n * z + 9.76945438170
            4
            35
            3
            1
            0816
            E
                sn = sn *
                     z
                     +
                     1
                         .


            5
            5
            9420
            4
            9E-1
            2
                ;


            +1.
            27 9
            7
            9117
            9
            9432
            9
            9
            9
            0

            sd * z + 4
            8
            E
            7
                ;
            s
                d
                    =
                    sd * z +
                    9
                        .
            9641
            2
            122
            0
            4
            3
            87 55 4
            87 E - 5
                ;


            sd = sd * z + 1. 20 2


            z +
                9
            9
            9
            9
            9
            sn / sd;


            n = 2.02524002389102268789E-11;


            50491
            57
            z
            35 9
            3
            2
            5
            05;

            4
                .
            7
            4
            0
            2068 34 7
            9
            0
            94 65

            cn = cn z + 2.
            89
            1
            5
            9
            6


            cn
                = c n
                *
                7746
            4
            0618
            8
            055
            95
            d * z +
                .
            6780
            9
            9
            7
            5
            8
            1
            8
            8

            cd 8
            3
            2
            3
            6
            79 - 6


            c
                d
                    = 7
            5
            76 8

            d
                =
                cd *
                z
                + 5.1
            0
            0
            2
            8
            056
            2
            3
            644
            60


            0


            c


            if
            (
                s !=
                s


            si =
                s;


            57
            2
            566
            49015328606M Lo + c;


            return;
        }
        s = Math.Sin(x);
        c = Math.Cos(x);
        z = 1.0 / (x * x);
        if ((double)(x) < (double)(8))
        {
            fn = 4.23612862892216586994E0;
            fn = fn * z + 5.45937717161812843388E0;
            fn = fn * z + 1.62083287701538329132E0;
            fn = fn * z + 1.67006611831323023771E-1;
            fn = fn * z + 6.81020132472518137426E-3;
            fn = fn * z + 1.08936580650328664411E-4;
            fn = fn * z + 5.48900223421373614008E-7;
            fd = 1.00000000000000000000E0;
            fd = fd * z + 8.16496634205391016773E0;
            fd = fd * z + 7.30828822505564552187E0;
            fd = fd * z + 1.86792257950184183883E0;
            fd = fd * z + 1.78792052963149907262E-1;
            fd = fd * z + 7.01710668322789753610E-3;
            fd = fd * z + 1.10034357153915731354E-4;
            fd = fd * z + 5.48900252756255700982E-7;
            f = fn / (x * fd);
            gn = 8.71001698973114191777E-2;
            gn = gn * z + 6.11379109952219284151E-1;
            gn = gn * z + 3.97180296392337498885E-1;
            gn = gn * z + 7.48527737628469092119E-2;
            gn = gn * z + 5.38868681462177273157E-3;
            gn = gn * z + 1.61999794598934024525E-4;
            gn = gn * z + 1.97963874140963632189E-6;
            gn = gn * z + 7.82579040744090311069E-9;
            gd = 1.000
            000000
            0000
            0000E0;


            gd
                =
                g 024
            335533
            88
            6E
            gd
                g
            d * 268987
            9
            68381E-
                ;

            g 877176
            2
            7
            8
            87


            223963
            5
            4
            7
            68


            .73221
            8
            4
            4
            17


            z + 2.02
            59
            8
            0
            86;


            +7.825
            92
            8
            3
            35


            d;


            else


            f
                = 046531
            20
            E
            1
                ;
            f
                = 27
            1
            0
            16


            f
                n
                    = fn *
                      z
                      +
                      1
                          .
            03 56


            f 2
            9
            0
            8
            12 fn 56 - 4


            fn 21
            5
            3
            082645
            4
            7
            4
            9
            48
            2
            E - 6;


            f 10
            4
            0
            28


            fn
                =
                fn * z + 9.41779
            57 1;

            n 07
            1
            0
            881952
            0
            2
            4
            6
            3
            1
            E - 14;


            00 00
            0

            fd
                =
                fd *
                z
                + 9.
            1
            7
            4
            6
            3
            61;


            fd 453320
            74 f
                d
                    =
                    fd * z +
                    1
                        .
            2
            2
            25
            3
            594771
            9
            7
            1
            2
            30 *
                +
                .
            5
            8
            69 E -
                ;

            fd = fd * z + 4
            .9 39
            E
            6;


            fd = fd * z + 3
            .2 37
            E
            8;


            fd = fd * z + 9
            .4 37
            E
            11
                ;


            fd = fd * z +
                 9. 57
            5
                - 1
            4
                ;


            f = fn / (x
                      * f

            n
                =
                6
            .97359953443276214934E-1
                ;
            gn
                =
                gn * z + 3.3041097930563206322
            5E

            n
                =
                g
            n * z + 3.8487876764997429592
            0E

            n
                =
                g
            n * z + 1.7171823905234790355
            8E

            n
                =
                g
            n * z + 3.4894116550227943677
            7E

            n
                =
                g
            n * z + 3.4713116708411667380
            0E

            n
                =
                g
            n * z + 1.7040445278204452618
            9E

            g
                n
                    =
                    gn
                    * z 66
            0
            53E-12;
            gn
                = 94
            3
            33
            3
            4
            6
            40E-15;
            g
                d 00
            0
            00
            0
            E
            0
                ;
            gd = gd
                 * z 16
            0
            17
            E
            0
                ;

            gd = gd *
                z + 96
            4
            6E
                -
                1
                ;

            gd = gd *
                z + 80
            3
            0E
                -
                2
                ;

            gd = gd
                 * z 95
            3
            38E-3;
            gd
                = 42
            6
            10
            8
            1
            6
            2E-5;
            gd
                = 43
            4
            83
            8
            7
            7
            1E-7;
            gd
                = 66
            1
            14
            6
            7
            3
            6E-9;
            gd
                = 23
            5
            70
            6
            7
            5
            2E-12;
            gd
                = 94
            3
            33
            3
            5
            2
            42E-15;

            g
        }


        70
        7
        63
        26
        7
        48


        c

        f * s - g * c;
    }


    /*************************************************************************
    Hyperbolic sine and cosine integrals

    Approximates the integrals

                               x
                               -
                              | |   cosh t - 1
      Chi(x) = eul + ln x +   |    -----------  dt,
                            | |          t
                             -
                             0

                  x
                  -
                 | |  sinh t
      Shi(x) =   |    ------  dt
               | |       t
                -
                0

    where eul = 0.57721566490153286061 is Euler's constant.
    The integrals are evaluated by power series for x < 8
    and by Chebyshev expansions for x between 8 and 88.
    For large x, both functions approach exp(x)/2x.
    Arguments greater than 88 in magnitude return MAXNUM.


    ACCURACY:

    Test interval 0 to 88.
                         Relative error:
    arithmetic   function  # trials      peak         rms
       IEEE         Shi      30000       6.9e-16     1.6e-16
           Absolute error, except relative when |Chi| > 1:
       IEEE         Chi      30000       8.4e-16     1.4e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static void hyperbolicsinecosineintegrals(double x,
        ref double shi,
        ref double chi,
        alglib.xparams _params)
    {
        doubl k = ;

        d
            ou
        b
            l
        e
            c = ;
        double s
            =
            e

        0
            ;
            in s g = 0;


        d
            e b2
            i
                = 0;

        i((ou le)


        {
            sg = -1;
        }
        else
        {
            ;
        }
        if ((double
            )()


        {
            shi
            c
                i
                    =
                    -
                        m
            a
            th.maxr ea nu mber;


            r
                e


            if ((double)(x)(d ub le)(8.0
                )


            z = x * x;
            a
                s
                    =
                    1
            .0;
            c = 0. 0;


            do

                a = a *
                    z / k;


            c = c + a / k;


            0;


            a = a / k;
                = s + /k
                k = k + 1 .0;


            w
                hi e((d ou bl e)(Math.Abs(a / s)) >= (d u
                si
            o
                )
                )
            ;


            s = s * x


            e
            s


            {
                f
                (
                    (1
                        .
                    )
                )


                {
                    2.
                        )
                    10
                        .
                    0
                        ;
                    k = a
                    th.E xx


                    b 0
                        =
                        1
                    2 - 1
                    b1 = 0. 0;
                    c eb
                    i
                        t
                    e
                    rationshichi(a, -9.554 8553
                    2
                    fb 0
                    ef
                        b
                    1
                        ,
                        ref b2, _params);


                    ai o
                    ic h
                    i
                    (
                        a
                        , 2.043261059808798826 48E-
                    1
                    e b
                    _p a
                    r
                        a
                    m
                        s);
                    ch
                        e
                    10 9
                    94 9
                    0
                    7
                    4
                    905343022E-15, ref b0, ref

                    ;


                    chebiteration shic
                    h
                    09 25 9
                    E - 1 4
                        ,
                        ref b0, ref b1, re b, _par
                    am
                        c
                    h
                        e
                    biterationshi hi a,  5. 93 97 622626
                    43 f b, 
                    ref b1 ,  ref b2 , _ ar ms) ;
                    eb
                        t
                    rat i
                    o
                        n
                    shichi(a, -3.47197 10 977 49 15 45 ef
                    b
                        ,
                    re f
                        b2, _params);
                    ic
                    i
                        a, 
                    -1
                        .
                    4005976461311713100 E - 2, re f b, _
                    a
                        ams )
                    ;


                    c ebite
                    ra 494 4
                    26
                    2
                    2
                    4
                    223543299E-12, re b0, re f b1,
                        re


                    chebi er tio ns hi ch i(a,
                        -450 3
                    E -
                        1
                    1
                        ,
                        ref b0, ref b , ef b2, _p aram
                        s)
                    ch
                        e
                    b
                        i
                    terationshichi a,  -1. 77 89 97 84436
                    43 b0
                        ef

                    b
                    1
                        , ref b2, _pa am );


                    o
                        s
                    i
                        c
                    hi
                    (
                        a,
                        4
                    r
                    f
                        b1, re f 2, _pa ra s);


                    te
                        r
                    ti
                        on
                    s
                        i
                    17 re

                    0
                        ,
                    r
                        pa


                    chebiteratnshichi(a, -3.56699611114982536845E-8, ref b0, ref b1, ref b2, _params);
                    chebiterationshichi(a, 1.44818877384267342057E-7, ref b0, ref b1, ref b2, _params);
                    chebiterationshichi(a, 7.82018215184051295296E-7, ref b0, ref b1, ref b2, _params);
                    chebiterationshichi(a, -5.39919118403805073710E-6, ref b0, ref b1, ref b2, _params);
                    chebiterationshichi(a, -3.12458202168959833422E-5, ref b0, ref b1, ref b2, _params);
                    chebiterationshichi(a, 8.90136741950727517826E-5, ref b0, ref b1, ref b2, _params);
                    chebiterationshichi(a, 2.02558474743846862168E-3, ref b0, ref b1, ref b2, _params);
                    chebiterationshichi(a, 2.96064440855633256972E-2, ref b0, ref b1, ref b2, _params);
                    chebiterationshichi(a, 1.11847751047257036625E0, ref b0, ref b1, ref b2, _params);
                    s = k * 0.5 * (b0 - b2);
                    b0 = -8.12435385225864036372E-18;
                    b1 = 0.0;
                    chebiterationshichi(a, 2.17586413290339214377E-17, ref b0, ref b1, ref b2, _params);
                    chebiterationshichi(a, 5.22624394924072204667E-17, ref b0, ref b1, ref b2, _params);
                    chebiterationshichi(a, -9.48812110591690559363E-16, ref b0, ref b1, ref b2, _params);
                    chebiterationshichi(a, 5.35546311647465209166E-15, ref b0, ref b1, ref b2, _params);
                    chebiterationshichi(a, -1.21009970113732918701E-14, r
                    f b0,
                        ef b
                        , ref b2, _params);


                    nsh
                    chi(a,
                        -6.
                    00 437
                    51E-14
                    re
                        f ref b2 
                        ,
                        _param
                        );

                    ations
                        i
                    h
                    (
                        a, 560285
                    7
                    7
                    E
                        - 1 ef b1,
                        r
                    f
                        b
                    2,


                    ration
                        h
                    c
                        i
                    (a 260
                    59
                    8
                    6
                    10 0, ref
                    b1

                    e
                        f;


                    terati
                        ns
                    i
                        h
                    ia 813
                    4
                    1
                    25 f b,
                        r
                    e _p
                    a
                        a
                    ms);


                    ns 28
                    6
                    9
                    0
                    54 b
                        ,
                    r
                        e
                    f _p he(a

                    4
                    .4 23 ef

                    0
                        , ref
                    b
                    1
                        ,

                    re
                    f
                        b2, _
                    p
                        a
                    r
                        a
                    s) ati
                        n
                    h
                        ic 564
                    5
                    9
                    2954
                    7
                    9E-10, ref b0
                        , _param
                        s) it
                        e
                    a
                        tionsh
                    i
                        c
                    h
                    i
                    (
                        a
                        , 1.31
                    4
                    5
                    815
                    0
                    89 , r
                        f
                    b
                    2
                        ,
                    _
                        n
                    h
                        chi
                    (a 7
                    5
                    655
                    90
                    1
                    re
                        f he -
                        .
                    1
                    7
                    7
                    5
                    0
                    18
                    0

                    r
                        e
                    f
                        b1


                    o
                        s
                    i
                        c
                    h
                    i(9
                    9
                    2
                    E
                        -
                        6
                        ,
                    r 2

                    p
                        a
                    ram
                        s) nshic
                    h
                    (
                        a, 4.3
                    3
                    5
                    0588
                    9
                    257
                    3
                    1
                    6
                    4
                    0
                    8
                    89
                    3
                    E - 6, r
                        e
                    f
                        b0, 

                    ref b1 ,  ref b2 
                        ,
                        _
                    pa
                        io 6.133 49 re
                        f
                    b
                    1, ref

                    b
                    2
                        ,

                    _
                        params
                        )
                    ;


                    bi.
                    3
                    8
                    54774
                    9
                    2
                    9
                    9746
                    5
                    1
                    38E-
                    4,
                    2
                    _pa
                        r
                    ams
                        )
                    ;


                    it
                        r
                    tionshichi(a, 4.9716478982
                    31 r
                    f
                        b1,
                        r ch
                        e
                    b
                        i
                    e
                    rationshichi(a, 2.64347496
                    0
                    137
                    52
                    6
                    41E
                    2,

                    ef
                    0,

                    ef b1,
                        r
                    ef cheb
                    i
                        t
                    e
                    ationshichi(a, 1.114461508
                    7
                    699
                    13
                    0
                    5E0
                    r
                        e
                    b0
                        r
                    e
                        b1, re
                    f
                    b c = k *
                          0
                              .
                    5
                        (b0 - b2);
                }


                lse


                if ((double)(x)
                    <
                    =
                    (
                        o
                uble)(88.0) )


                {
                    a 0.0;


                    k = Math.Exp(x) / x;


                    b
                    0
                        = -1.05
                    3
                    11


                    b1 = 0.0;


                    heb
                        te
                    r
                        tio
                    sh
                        i
                    hi(a, 2
                        .
                    62 17, ref b0, ref b1,

                    r
                    e
                        b2, _params);


                    c
                        eb
                    i
                        era
                    io
                        n
                    hichi(a
                        ,
                        8 7E-17, ref b0, ref
                        b
                    1
                        ,
                        ref b2, _params);


                    c
                        ebi
                    er
                        a
                    ionshic
                        h
                    i(047136E-16, ref b0,
                        r
                    e
                        b1,  ref b2 , _params);


                    c
                        eb
                    i
                        eration
                    s
                        hi 6935789136E-16, ref

                    b
                    0
                        ref b1, ref b2, _params);


                    c
                        ebitera
                    t
                        io 5437050071776E-15,
                    r
                        e
                    f
                        b0,  ref b1 ,  ref b2 , _para
                    m
                        );


                    cheb
                        i
                    te 765565969729044505E
                        -
                        1
                    4
                        ref b0, ref b1, ref b2, _
                        p
                    ram
                        );


                    c
                    he - 4.2112817030764080
                    2
                    7
                    0
                    E
                        - 14, ref b0, ref b1, ref
                    b
                        , _
                        ar
                    a
                        s);


                    i(a, -1.60818204519
                    8
                    0
                    2
                    80035E-13, ref b0, ref b1
                        ,
                        ref
                    b2
                        ,
                    _pa
                    am
                        s
                        ;


                    nshichi(a, 3.347149
                    5
                    4
                    1
                    5994481761E-13, ref b0, r
                        e
                    b1
                        r
                    e
                        b2
                    _
                        p
                    ram
                        );


                    rationshichi(a, 2.7
                    2
                    6
                    0
                    3
                    52129153073807E-12, ref b
                    0
                    re
                        b
                    1
                    re
                        b
                    2
                    _p
                        ra
                    m
                        );


                    biterationshichi(a,
                        1
                            .
                    6
                    894954752839083608E-12, r
                        e
                    b0
                        r
                    e
                        b1
                    r
                        e
                    b2
                        _
                    p
                        rams);


                    chebiterationshich
                        i
                    (
                        a
                        - 3.49278141024730899554E
                        -
                        1,
                        ef

                    0,
                    ef

                    1,
                    ef

                    2, _par
                        a
                    ms chebiteratio
                    n
                        s
                    h
                    chi(a, -1.585806616664827
                    0
                    598
                        - 1
                    0
                    re
                        b
                    0
                    re
                        b
                    1
                        ref b2
                        ,
                    _ chebit
                    e
                        r
                    a
                    ionshichi(a, -1.792894371
                    8
                    355
                    33
                    3
                    2E-
                    0,

                    ef
                    0,

                    ef b1,
                        r
                    ef
                        c
                    h
                        e
                    iterationshichi(a, 1.762
                    8
                    629
                    44
                    2
                    452
                    27
                    7
                        - 9,
                    re
                    f
                        b0,  ref
                        b1
                        ic
                    i
                        a,  1.69050228879421288846E-
                    8, b
                        ,
                    _pa
                        ra chebiterat
                        i
                    o
                        n
                    hichi(a, 1.253917712284870
                    4
                    649
                        - 7
                        ,
                        ref
                    b0
                        ,
                        ref
                    b1
                        ,
                        ref b2,

                    _p chebite
                    r
                        a
                    t
                    onshichi(a, 1.162299470686
                    7
                    338
                    32
                    E
                    6,
                    ef

                    0,
                    ef

                    1, ref
                    b
                    2, cheb
                        i
                    t
                        e
                    a
                    tionshichi(a, 1.6103826011
                    7
                    763
                    39
                    9
                    E - 5
                    r
                        e
                    b0
                        r
                    e
                        b1, re
                    f
                        b ch
                        e
                    b
                        i
                    erationshichi(a, 3.4981037
                    5
                    010
                    39
                    7
                    070
                        - 4
                        ,
                        ref
                    b0
                        ,
                        ref b1,

                    re
                        c
                    h
                        b
                    iterationshichi(a, 1.28478
                    0
                    525
                    64
                    7
                    107
                    9E
                        -
                        , r
                    f
                        b,  ref b 
                    1
                        ,


                    h
                    ebiterationshichi(a, 1.036
                    6
                    722
                    88
                    7
                    832
                    71
                    2
                    0,
                    ef

                    0, ref
                    b
                    1,


                    s = k * 0.5 * (b0 - b2);


                    0 =
                        8.
                    0
                    9134082
                    5
                    51 b
                    1
                        =
                        0
                    .0;


                    che
                        it
                    e
                        ati
                    ns
                        h
                    chi
                        a, 

                    2.08074
                    1
                    68 f b0,  ref b1 ,  ref b 
                    2
                        ,

                    p
                        arams);


                    ch
                        e
                    ite
                        at
                    i
                        nsh
                    ch
                    i
                        a,  -5.9
                    8
                    11 , ref b0, ref b1, r
                        e
                    f

                    2, _params);


                    ch
                        bi
                    t
                        rat
                    on
                        s
                    ichi(a,
                        2.E - 16, ref b0, ref b
                    1
                        ,

                    e
                    f b2, _params);


                    ch
                        e
                    ite
                        at
                    i
                    nshichi
                    (
                        a, 774E-16, ref b0, re
                    f
                        b, 
                    ref b2 , _params);


                    heb
                        te
                    r
                        tionshi
                    c
                        hi 9464535E-15, ref b0
                        ,

                    r
                    f b1,  ref b2 , _params);


                    c
                        h
                    biterat
                        i
                    on 7332531972288E-15,
                    r
                        e
                    f
                        b
                    0, ref b1, ref b2, _param
                        s
                        ;


                    chebi
                        t
                    er 39695410806959872E-
                    1
                    4
                        ,
                    r
                    ef b0,  ref b1 ,  ref b2 , _p
                    a
                        ams
                        ;


                    c
                        h
                    eb .634067317189115866
                    0
                    9
                    E
                    14, ref b0, ref b1, ref b
                    2
                    _p
                        ra
                    m
                        );


                    (a, -3.719024480931
                    1
                    9
                    2
                    8395E-13, ref b0, ref b1,

                    ef
                    2,

                    par
                        ms
                        )


                    shichi(a, -1.271354
                    1
                    8
                    1
                    2
                    338309016E-12, ref b0, re
                    f
                        b1,
                        re
                    f
                        b2,
                        _p
                    a
                        ams
                        ;


                    ationshichi(a, 2.74
                    8
                    5
                    1
                    4
                    1935315395333E-12, ref b0
                        ,
                        ref
                    b1
                        ,
                        ref
                    b2
                        ,
                    _pa
                    am
                        s
                        ;


                    iterationshichi(a,
                        2
                            .
                    3
                    781843985453438400E-11, r
                        e
                    b0
                        r
                    e
                        b1
                    r
                        e
                    b2
                        _
                    p
                        rams);


                    chebiterationshich
                        i
                    (
                        a
                    2.71436006377612442764E-
                    1
                        , r
                    f
                        b, r
                    f
                        b, r
                    f
                        b, _para
                    m
                        s) chebiteration
                        s
                    h
                        i
                    hi(a, -2.566001800003559
                    9
                    529
                        - 1
                    0
                    re
                        b
                    0
                    re
                        b
                    1
                        ref b2
                        ,
                    _
                        c
                    he
                        b
                    it - 43855 f;


                    cheb
                        i
                    er 54
                    0
                        ref b1
                        ,

                    r
                    ef b2,
                        _par
                    am
                        cheb
                    i
                        ter
                    a
                        t
                    i
                        o
                    n
                        sh 16
                    2
                    8
                    2E-9, ref b0, ref b1, ref
                    b2


                    7.7938747439091492
                    2
                    3
                    3
                    E - 8, ref b0, ref b1, ref b
                    2
                    _p
                        ra
                    m
                        );


                    1.06942765566401507
                    0
                    6
                    6
                        - 6, ref b0, ref b1, ref b2
                        ,
                    _pa
                    am
                        s
                        ;


                    .595031648023131963
                    7
                    4
                    E
                    5
                        , ref b0, ref b1, ref b2,
                    _
                        ara
                    s)
                    ;


                    ch 9592575153777996871
                    E
                        -
                        4
                        ref b0, ref b1, ref b2, _p
                    a
                        ams
                        ;


                    c
                        h
                    eb 75387530065247392E-
                    2
                        ,

                    ef b0,  ref b1 ,  ref b2 , _pa
                    r
                        ms)


                    ch
                        e
                    bi 5693917934275131E0,

                    r
                    e
                        b0,  ref b1 ,  ref b2 , _para
                    m
                        );


                    c =
                        k
                        * 0
                }


                else


                if
                (
                    s {
                    shi = -math.m
                    a
                        rea
                    nu
                    m
                        er;


                    else


                    {
                        sh
                            i
                                = m
                        th
                            .
                            axrealn
                            u
                        mb
                    }


                    chi = math.maxrealn
                    u
                        ber


                    re
                        t
                    ur
                }
            }
            if (
                s
                != 0
            )


            {
                shi = s
                    ;


                chi = 0.577215664
                9
                153
                86
                0
                1 + M
                th
                        .og(
                        ) +
                    c
            }


            private static void chebiterationshichi(double x,
                double c,
                ref double b0,
                ref double b1,
                ref double b2,
                alglib.xparams _params)
            {
                2

                b0 = x *
                     b
                1
                    -
                    c;
            }
        }

    public class chebyshev
    {
        /*************************************************************************
        Calculation of the value of the Chebyshev polynomials of the
        first and second kinds.

        Parameters:
            r   -   polynomial kind, either 1 or 2.
            n   -   degree, n>=0
            x   -   argument, -1 <= x <= 1

        Result:
            the value of the Chebyshev polynomial at x
        *************************************************************************/
        public static double chebyshevcalculate(int r,
            int n,
            double x,
            alglib.xparams _params)
        {
            do
                ble resu
            l
                t 0;
            d uble
                a
                    =
                    0;
            dou bl b = 0
                ;

            esul = 0;


            repare A a nd B


            //
            if r == )


            a = 1;
        }
        else


        {
            a = 1


            b = x;
        }
        / Special cas

        e
            s

        :
        N= 0 or N = 1
                    /
                    i(n ==)


        {
            return result;
        }

    if( ==1 )
        esult =
            b

    t;
}


/


G
    a
l
cas:
N >
    = 

    //
    )


{
    a = b;
}


return result;
}


/*************************************************************************
Summation of Chebyshev polynomials using Clenshaw's recurrence formula.

This routine calculates
    c[0]*T0(x) + c[1]*T1(x) + ... + c[N]*TN(x)
or
    c[0]*U0(x) + c[1]*U1(x) + ... + c[N]*UN(x)
depending on the R.

Parameters:
    r   -   polynomial kind, either 1 or 2.
    n   -   degree, n>=0
    x   -   argument

Result:
    the value of the Chebyshev polynomial at x
*************************************************************************/
public static double chebyshevsum(double[] c,
    int r,
    int n,
    double x,
    alglib.xparams _params)
{
    double result = 0;


    oub
    e
        b
            = 
        ;


    o
    0;

    b1 =
        0
        ;


    b2 = 0;


    or(
        = n
        ;
    i >=
        ;
    i
        -)

    {
        ];

        b
        2


        b1;
        b = resul
        t
    }


    r == )

    ult = -b2 + x * b1 + c[0]
        ;
}

else


re
su t = -2 + 2 * *
return result
    ;


}


/*************************************************************************
Representation of Tn as C[0] + C[1]*X + ... + C[N]*X^N

Input parameters:
    N   -   polynomial degree, n>=0

Output parameters:
    C   -   coefficients
*************************************************************************/
public static void chebyshevcoefficients(int n,
    ref double[] c,
    alglib.xparams _params)
{
    i
        n
    t
        i
            = 0;

    c = ne
    w
        dou
    le
    [
    ];


    c = new
        d
    i++)
    {
        c[i] = 0;


        n ==
            ||
            1 )
            ] = 1;
    }


    else


    c
        n]
    M
        a
    h.Ep((
        n
    1)*Math
        .L
    i = 0;
    i <= n / 2 - 1;
    i++)


    {
        c[
            n
        2 * (
                +1
            )
            =
            (c[n * i](n - 2 *)
             *
    }
}
}


/*************************************************************************
Conversion of a series of Chebyshev polynomials to a power series.

Represents A[0]*T0(x) + A[1]*T1(x) + ... + A[N]*Tn(x) as
B[0] + B[1]*X + ... + B[N]*X^N.

Input parameters:
    A   -   Chebyshev series coefficients
    N   -   degree, N>=0
    
Output parameters
    B   -   power series coefficients
*************************************************************************/
public static void fromchebyshev(double[] a,
        int n,
        ref double[] b,
        alglib.xparams _params)
    in

t
    k e
    b
        = n w do ble[0;


i++

d
    ;
i = 0;


d
    o
    )
{
    se


    if i! = 0 )


    b[k
        = 2
    d;
}


b[
    ] = b[
        ] -
        b[


}
k
= k +1;
whil
( k<=n );
d = b[i];
e = 0;
k = i;
while (k <= n)
{
    e = e + b[k] * a[k];
    k = k + 2;
}

b[i] = e;
i = i + 1;
}
while( i<=n );
}
}

public class poissondistr
{
    /*************************************************************************
    Poisson distribution

    Returns the sum of the first k+1 terms of the Poisson
    distribution:

      k         j
      --   -m  m
      >   e    --
      --       j!
     j=0

    The terms are not summed directly; instead the incomplete
    gamma integral is employed, according to the relation

    y = pdtr( k, m ) = igamc( k+1, m ).

    The arguments must both be positive.
    ACCURACY:

    See incomplete gamma function

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double poissondistribution(int k,
        double m,
        alglib.xparams _params)

    {
        do
            u
                l
        e
            r
        s
        (k >= 0
         &
         de(
             m),
            ib
        r es lt
            =
            i
        ga m

        ac
            p
        turn result;
    }


    /*************************************************************************
    Complemented Poisson distribution

    Returns the sum of the terms k+1 to infinity of the Poisson
    distribution:

     inf.       j
      --   -m  m
      >   e    --
      --       j!
     j=k+1

    The terms are not summed directly; instead the incomplete
    gamma integral is employed, according to the formula

    y = pdtrc( k, m ) = igam( k+1, m ).

    The arguments must both be positive.

    ACCURACY:

    See incomplete gamma function

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double poissoncdistribution(int k,
        double m,
        alglib.xparams _params)
    {
        sult = 0;
            .a = o
        ul e)
        0, "        Da        Po
        s
            o
        n


        re ut = i
        gm t
        a
            m
        tu r
            lt
            ;
    }


    /*************************************************************************
    Inverse Poisson distribution

    Finds the Poisson variable x such that the integral
    from 0 to x of the Poisson density is equal to the
    given probability y.

    This is accomplished using the inverse gamma integral
    function and the relation

       m = igami( k+1, y ).

    ACCURACY:

    See inverse incomplete gamma function

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1995, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double invpoissondistribution(int k,
        double y,
        alglib.xparams _params)
    {
        =
        0
            .p
            .a
        ss
        0
            )
            )

        &
        (
            d

        err i
        n
            P
        u
            i
        n
        ")         
        invin a


        re u
        r
            n
        r
        es ul;
    }
}

public class betaf
{
    /*************************************************************************
    Beta function


                      -     -
                     | (a) | (b)
    beta( a, b )  =  -----------.
                        -
                       | (a+b)

    For large arguments the logarithm of the function is
    evaluated using lgam(), then exponentiated.

    ACCURACY:

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE       0,30       30000       8.1e-14     1.1e-14

    Cephes Math Library Release 2.0:  April, 1987
    Copyright 1984, 1987 by Stephen L. Moshier
    *************************************************************************/
    public static double beta(double a,
        double b,
        alglib.xparams _params)

    re u
    t =
    0;


    e
        d

    o
        u

    b
        e

    s
        g


    0;


    p.a e
    )( a
        )
        ;


    (
        )
        er

    ))
    >

    d
        ou

    b
        e


    y
        am a
        f

    s
        ;


    (
    s
    = g
        * s;


    a
    +

    li.
        p
        .
        a
        s
        (
            ath.m x

    e
        al

    n
        m

    be n

    B
        t

    a
    "
    )
    ;

    r
        s

    l
        t;


    n res

    u
        t;


    m
        a

    u
        n

    c
        t

    i
        o

    n
    (
        y
        ,
        _p a

    g
        i

    b
        .
        ap (y "
    O
        v

    e
        f

    o
        w


    if )> )


    {
        y ammafu
        c.gam
        afunction(a, ams) / y;
        y = y * gammafunc.gammafunction(b, _params);
    }

else
{
    y = gammafunc.gammafunction(b, _params) / y;
    y = y * gammafunc.gammafunction(a, _params);
}
result = y;
return result;
}
}

public class fresnel
{
    /*************************************************************************
    Fresnel integral

    Evaluates the Fresnel integrals

              x
              -
             | |
    C(x) =   |   cos(pi/2 t**2) dt,
           | |
            -
             0

              x
              -
             | |
    S(x) =   |   sin(pi/2 t**2) dt.
           | |
            -
             0


    The integrals are evaluated by a power series for x < 1.
    For x >= 1 auxiliary functions f(x) and g(x) are employed
    such that

    C(x) = 0.5 + f(x) sin( pi/2 x**2 ) - g(x) cos( pi/2 x**2 )
    S(x) = 0.5 - f(x) cos( pi/2 x**2 ) - g(x) sin( pi/2 x**2 )



    ACCURACY:

     Relative error.

    Arithmetic  function   domain     # trials      peak         rms
      IEEE       S(x)      0, 10       10000       2.0e-15     3.2e-16
      IEEE       C(x)      0, 10       10000       1.8e-15     3.3e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static void fresnelintegral(double x,
        ref double c,
        ref double s,
        alglib.xparams _params)
    {
        double xxa = 0


        dou
            b
        e f
        0


        double g = 0;


        d
            o
        u
            b
        l
            e

        c
            c
                =
                0
            ;


        d
            o
        u
            b
        l
            e

        s
            s
                =
                0
            ;


        d
            o
        u
            b
        l
        e
            t = 0;

        doub
        e u = 
            ;
        double
            x2

        0;
        doubl
            sn
        d
        ouble s
            = 0;


        ;


        ou
            l
        e f n =
                0
            ;


        d
            o
        ble fd = 0;
        do
            u
                d
        u
        le gd =
                0
            ;
        e i = 0;
        doublepio2 = 0;

        mpi = 3.14159265358979323846;
        mpio2 = 1.57079632679489661923;
        xxa = x;
        x = Math.Abs(xxa);
        x2 = x * x;
        if ((double)(x2) < (double)(2.5625))
        {
            t = x2 * x2;
            sn = -2.99181919401019853726E3;
            sn = sn * t + 7.08840045257738576863E5;
            sn = sn * t - 6.29741486205862506537E7;
            sn = sn * t + 2.54890880573376359104E9;
            sn = sn * t - 4.42979518059697779103E10;
            sn = sn * t + 3.18016297876567817986E11;
            sd = 1.00000000000000000000E0;
            sd = sd * t + 2.81376268889994315696E2;

            sd
                = sd * t
            4.55847810806532581675
            E
            4;


            sd = s
                *
                t + 009640
            0
            730E6;


            sd
            58 8


            sd =
                s
            d
                * t
                +
                .2
            40 E1 0

            sd * t +
                .7 36 30 46 90 9E 11;
                = -4.988431145735
            cn =
                08 96 4E-6;


            n = cn * t - 6.45191435683965050962E-4;
            cn = cn * t + 1.88843319396703850064E-2;
            cn = cn * t - 2.05525900955013891793E-1;
            cn = cn * t + 9.99999999999999998822E-1;
            cd = 3.99982968972495980367E-12;
            cd = cd * t + 9.15439215774657478799E-10;
            cd = cd * t + 1.25001862479598821474E-7;
            cd = cd * t + 1.22262789024179030997E-5;
            cd = cd * t + 8.68029542941784300606E-4;
            cd = cd * t + 4.12142090722199792936E-2;
            cd = cd * t + 1.00000000000000000118E0;
            s = Math.Sign(xxa) * x * x2 * sn / sd;
            c = Math.Sign(xxa) * x * cn / cd;
            return;
        }

        if ((double)(x) > (double)(36974.0))
        {
            c = Math.Sign(xxa) * 0.5;


            s =
                Math.S
            g
            n(
        }


        t
            /
            (
                t = 1 t;


        E -
            ;


        4
        3
        407919
        7
        8
        075888


        20 9
        n5 7900E-
            ;


        -
            6;

        8
        7
        57605 8 -;
        3
        n
            .
        201 0
        7
        4
        12 623
        30 27 58 92 5 - f = f
        n
            * u + 3 76 329 71 26 998
        7
        8
        8
        006E-20;
        fd = 1 00 00 0;


        fd
            =
            f
        947175
            - 1;

        +1 1
        1
        82142E-1;


        fd = f d * u + 6. 44 0
        2650885
        8
        61 f d =
            f
        d * u + 1.
        5
        5
        934409
        1
        6
        4
        1
        53
        0
        20873E
            -
            4
            ;


        f =
            d *
            +1.8
        462
        6;


        f
            d
                = fd *
                  u
                  +
                  1
                      .
        2
            - 8

        d * u + 3.60 4
        0
        0295 937137040
        4
        E
            -
            1;


        8
        5
        5
        3
        362157841
        0
        010E-14;


        fd
            =
            f 34 E - 17;
        f 2
        7
        900112643
        8
        4E-20;


        gn =
            5
                .
        0
        44 7
            -
            ;


        gn = gn * u + 1
            .
        9
        7
        0283352
        5
        52 = gn *
             +
            .
        87 249293
            - 2;

        g = u + 079380
        15393
        90172E-4 gn = gn * u + 1.15138826111884280931E-5;
        gn = gn * u + 9.82852443688422223854E-8;
        gn = gn * u + 4.45344415861750144738E-10;
        gn = gn * u + 1.08268041139020870318E-12;
        gn = gn * u + 1.37555460633261799868E-15;
        gn = gn * u + 8.36354435630677421531E-19;
        gn = gn * u + 1.86958710162783235106E-22;
        gd = 1.00000000000000000000E0;
        gd = gd * u + 1.47495759925128324529E0;
        gd = gd * u + 3.37748989120019970451E-1;
        gd = gd * u + 2.53603741420338795122E-2;
        gd = gd * u + 8.14679107184306179049E-4;
        gd = gd * u + 1.27545075667729118702E-5;
        gd = gd * u + 1.04314589657571990585E-7;
        gd = gd * u + 4.60680728146520428211E-10;
        gd = gd * u + 1.10273215066240270757E-12;
        gd = gd * u + 1.38796531259578871258E-15;
        gd = gd * u + 8.39158816283118707363E-19;
        gd = gd * u + 1.86958710162783236342E-22;
        f = 1 - u * fn / fd;
        g = t * gn / gd;
        t = mpio2 * x2;
        cc = Math.Cos(t);
        ss = Math.Sin(t);
        t = mpi * x;
        c = 0.5 + (f * ss - g * cc) / t;
        s = 0.5 - (f * cc + g * ss) / t;
        c = c * Math.Sign(xxa);
        s = s * Math.Sign(xxa);
    }
}

public class psif
{
    /*************************************************************************
    Psi (digamma) function

                 d      -
      psi(x)  =  -- ln | (x)
                 dx

    is the logarithmic derivative of the gamma function.
    For integer x,
                      n-1
                       -
    psi(n) = -EUL  +   >  1/k.
                       -
                      k=1

    This formula is used for 0 < n <= 10.  If x is negative, it
    is transformed to a positive argument by the reflection
    formula  psi(1-x) = psi(x) + pi cot(pi x).
    For general positive x, the argument is made greater than 10
    using the recurrence  psi(x+1) = psi(x) + 1/x.
    Then the following asymptotic expansion is applied:

                              inf.   B
                               -      2k
    psi(x) = log(x) - 1/2x -   >   -------
                               -        2k
                              k=1   2k x

    where the B2k are Bernoulli numbers.

    ACCURACY:
       Relative error (except absolute when |psi| < 1):
    arithmetic   domain     # trials      peak         rms
       IEEE      0,30        30000       1.3e-15     1.4e-16
       IEEE      -30,0       40000       1.5e-15     2.2e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1992, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double psi(double x,
        alglib.xparams _params)
    {
        =
        ;
        double p = 0;


        ;


        double nz = 0;

        ;


        double w = 0;


        double z = 0;

        0;


        int i = 0;


        int negative = 0;


        0


        nz = 0.0;
            =(
            o
        bl
            e
            )
        (
            0) )
        {
            =
            1


            q = x;
                )M
            t
                .F
                l
            o
                o
            r(q);
            if (
                    (bl
                    )
                    q)
                )


            {
                b.p
                    as
                    s
                e
                    r
                t(false, "Singularity in
                P
                    r
                esu
                l
                    t
                        =
                        m
                a
                th
                    .
                    ma
                    xr


                re
                    t
                u
                    r
                n
                    r
                e
                    su
                lt
            }

            nz
                i
            f
            (
                (
                    double
                )
                (
                    nz) != (d
            o
                bl


            i
            f(
                    (
                        (
                .
                )


            n
                z
                ;


            e ls e


            n
                z = 0.0;


            x = 1.0 - x;
        }

        ) &
            &
                nt Ma h.Floor(x))

        y0
            t


        for (i = 1;
             i <= n - 1;
             i++
            )


            w = i;

        y
        1
        0 / w;
    }
    -0
    7
    69


    {
        s
            w
                =
                0.0;
        whil
        e( < (
            ob le )
        (
            1
        0
            .
        0) )
        {
            ;


            =
            s
        }


        fb e
            )
        (s .0


        {
            p ol v = 8.3333 33 3333333
            3


            polv = polv * z - 2.10927960
            92 2;


            polv = pol v * z + 7.5
            7
            8E
            3
            polv = po v
            66
            6
            66
            7
            E
                -
                3;
            polv = p
            ol 96
            2
            39
            68 53 7E - 3;


            p
            .3
            3
            33
            3
            3
            3
            33333333333 - 3;
                =
            o
            v *
                z
                +
                8
            .33333333333333333333E-2;


            y
                =
                z * polv;
        }


        ls
        e


        {
            0
            0
        }

        og
        s
            - 0
                .
        5
            /
            s - y - w;
    }

    at
        v

    !=
    0
    )

    {
    }
    result =
    y;

    r
        t

    rn result;
}

}

public class airyf
{
    /*************************************************************************
    Airy function

    Solution of the differential equation

    y"(x) = xy.

    The function returns the two independent solutions Ai, Bi
    and their first derivatives Ai'(x), Bi'(x).

    Evaluation is by power series summation for small x,
    by rational minimax approximations for large x.



    ACCURACY:
    Error criterion is absolute when function <= 1, relative
    when function > 1, except * denotes relative error criterion.
    For large negative x, the absolute error increases as x^1.5.
    For large positive x, the relative error increases as x^1.5.

    Arithmetic  domain   function  # trials      peak         rms
    IEEE        -10, 0     Ai        10000       1.6e-15     2.7e-16
    IEEE          0, 10    Ai        10000       2.3e-14*    1.8e-15*
    IEEE        -10, 0     Ai'       10000       4.6e-15     7.6e-16
    IEEE          0, 10    Ai'       10000       1.8e-14*    1.5e-15*
    IEEE        -10, 10    Bi        30000       4.2e-15     5.3e-16
    IEEE        -10, 10    Bi'       30000       4.9e-15     7.3e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static void airy(double x,
        ref double ai,
        ref double aip,
        ref double bi,
        ref double bip,
        alglib.xparams _params)


    double
        z = 0;

    d
        ub

    e zz =
        0


    bl

    double uf
            = 
        ;


    d
        u
            =
            0;


    d
        t

    a


    int domflg =
        0;


    double
        c1 = 0;

    double
        c

    ouble
        s

    qrt3 =
    0;


    dou
        b

    e
        s

    q
        pii = 0;

    uble a
    0


    dou
    0;

    dou
        n
            =
            e agd =

    pfn
        ouble

    0;

    doule apgn = 0;


    dou
        le apgd
    = 0
    ;


    double an = 0;


    d
        o

    ble
        a
            = 0


    ouble apn = 0;


    d
        o

    u
        b

    l
        e

    a
        p

    d

    =
    0
    ;


    d
        o

    u
        b

    l
        e

    b
        n

    1
    6
    =
    0
    ;


    d
        o

    u
        b

    l
        e bd16 = 0;


    double
        bpp

    n
    = 0;


    le bpp
    d
    = 0;


    ai = 0;
    aip =
    ;


    i
        p

    q
    756286
    48
    -
    ;
    = 0.3
    5
    2
    0
    5

    c


    0
    067984
    5
    732050
    0
    5
    8
    8

    dom
        l
            =
            (d

    u
        l

    )
    (
    .77


    i
    =

    aip
        ;

    =

    a
        h.m

    a
        bi

    p m th.ma xr ea l

    n
        mb
}

x
    <
    d
o


{
    d
    om
        t
            =
            M
    a
    th
        .Sqrt(-);

    2

    t = ath.S qr t(t
        )
        ;


    k = s pii
        /
        t
        ;


    ;

    z z = z * z;


    179 53 33 E - 1;
    z
    69
    7
    E
        -
        1
        ;
    a fn *
        6. 9315803 60 36 93
    3
    54
    2
    23 3E 1;


    *
        f n
    1
        ;


    *
        8
    E
    8;


    a

    fd
        *
        zz + 1
            .
    33560
    4
    2
    0
    7


    afd
        = 3
    7
    5
    224
    6
    1394
    8
    E1;


    +2.
    6
    7
    3
    6
    7
    4
    09
    4
    1
    4
    9
    5
    548 0
    9
    7
    5
    9


    af = a
    f
    d
        * z 6

    afd =
        a

    z
    4
    4
    0
    3
        * zz + 7.
    5
    7
    203482
    8
    7
    4
    1
    4
    29 618E
        - 5;


    z
        *
        f / a
    33
    9
    3
    2091685 67 9
    1
    7
    9
    E
        - 2;


    9
    6579
    9
    599595591108E0;

    +9.3
    1
    9229
    8
    1
    6
    650230044E- 1;


    0554
    6
    9242
    E
        -
        1
        ;
    a 1962
    9
    5490 -
        ag 3048
    8
    45 856
    7
    E
        -
        3;
    agn = agn
          *
          7E ag n = agn * zz + 6.98793
    6


    ag n = ag n * zz + 8.11789239554389293
    3
    n
    ag*
        z
    z + 3.
    4
    4
    a g
    0


    gd =
        1


    a
        gd = ag *
            zz + 1 .9 83 5
    2
    9
    2
    8
    71;


    gd = a d * z + 1.
    46 5


    g
        d
            =
            29
            * z + 9 54
    936116
    189618839981
    agd
    agd* z 64580826352392193095E-2;
    agd = agd * zz + 4.12656523824222607191E-3;
    agd = agd * zz + 1.01259085116509135510E-4;
    agd = agd * zz + 1.17166733214413521882E-6;
    agd = agd * zz + 4.91834570062930015649E-9;
    ug = z * agn / agd;
    theta = zeta + 0.25 * Math.PI;
    f = Math.Sin(theta);
    g = Math.Cos(theta);
    ai = k * (f * uf - g * ug);
    bi = k * (g * uf + f * ug);
    apfn = 1.85365624022535566142E-1;
    apfn = apfn * zz + 8.86712188052584095637E-1;
    apfn = apfn * zz + 9.87391981747398547272E-1;
    apfn = apfn * zz + 4.01241082318003734092E-1;
    apfn = apfn * zz + 7.10304926289631174579E-2;
    apfn = apfn * zz + 5.90618657995661810071E-3;
    apfn = apfn * zz + 2.33051409401776799569E-4;
    apfn = apfn * zz + 4.08718778289035454598E-6;
    apfn = apfn * zz + 2.48379932900442457853E-8;
    apfd = 1.00000000000000000000E0;
    apfd = apfd * zz + 1.47345854687502542552E1;
    apfd = apfd * zz + 3.75423933435489594466E1;
    apfd = apfd * zz + 3.14657751203046424330E1;
    apfd = apfd * zz + 1.09969125207298778536E1;
    apfd = apfd * zz + 1.78885054766999417817E0;
    apfd = apfd * zz + 1.41733275753662636873E-1;
    apfd = apfd * zz + 5.44066067017226003627E-
        ;


    apfd
        ap 129
    654511
    71
    66

    pfd
        = 597
    713036
    27
    00

    u
        f n / apfd
        ;


    apgn = -3. 822883
    5
        -
        ;

    apg
        =
        a
    g
    n * 812943
    5
    4
    2
    6E

    p
        n
            = 085673
    8
    4
    1
    23


    ap - 1.502
    18
    2
    1
    73


    n * zz - 5
    6360
    6
    5
    82 1;


    *zz
    1.0210
    0
    1
    12 1;


    pgn* zz
    9.
    8
    9
    66 93E-3;


    apgn * z
        - 4.60
    2
    3
    07 E - 4;


    apgn * z
        - 1.
    4
    0
    08 19E-5;
        = apgn
    zz -
        .
    3
    41 0648E-
        ;
        = apg
        * zz -
        .
    3
    80 4476E-
    0;


    d = 1.
    0000
    0
    0
    00


    d * zz + 9
    85
    6
    8
    01 E0;


    pgd* zz
    2.1
    4
    1
    86 5E1;


    pgd* zz
    1.73
    3
    7
    76 E1;


    gd * zz +
        .178
    2
    7
    58;


    gd
        p
    gd 94
    9
    3
    21


    pgd * z
        +
        .95005543440888479402E-2;


    a
        gd = apgd * zz + 4.7846819
    96 - 3


    apgd = a
    pg 63332
    8
    8625562E-4;

    gd * zz +
        .
    7
    48 14
    6
    E
        - 6;


    apgd
        =
        ap 25 9;


    z* a
    g
        /
        ap
        = s
    q
    pii* t;

    k * (
        *
            f + f *
        u
    g));

    *uf - g *
        ug
}


if (

do ou

{
    m
        l
            = 5
        ;


    Sqrt
        x
        ;
        /
        .
    ;


    (
        e
    a);


    a
        h
    Sqr
    t
            (t);
        =
    2
    0
        *
        t
        * g z
        =
        1
    .0 / zeta;

    an 629
    3
    477
    E
        - 1
        ;

    an = an *
        z + 805
    4
    E1;


    an = an * z + 7.
    62 38E
        ;


    an = an * z + 1.6808
    92;


    an = an * z + 1.59756391
    35


    an = an * z + 7.053609068404
    44


    an
        = an * z + 1.4026469116338966
    88

    an
        =
        a
    n
        * z + 9.99999999999999995305
    E -
        d
        = 5
            .
    67
    5
    94532638770212846E-1;

    ad *
        +
            .47562562584847203173E1;

    d =
        a
        * z +
        8
    .4
    5
    138970141474626562E1;

    ad
        z
    1.7
    7
    31
    8
    088145400459522E2;

    *z +
        .
    423
    4
    69
    2
    871529701831E2;

    7.1
    7
    840
    0
    82
    5
    575695274E1;

    095
    1
    560
    7
    83
    4
    029598E1;

    000
    0
    000
    0
    00
    0
    470E0;
    f
        =
        ai
            =
            s
    qpii * f / k;

    k / g)


    apn = 6.137591848
    14


    apn = apn * z + 1.4745467078
    77


    apn
        = a
    pn 060
    8
    430E1;
    ap
        n 813
    0
    763
    8
    55
    4
    0E2;
    apn
        = 137
    4
    783
    5
    23
    E
    2;
    apn =
        a 301
    3
    161
    7
    0E
    1
        ;
    apn = a
    pn 481
    6
    958
    E
    1;


    apn = apn
          * z 000
    5
    0E0
        ;


    apd = 3.342
    03 - 1;


    apd = apd * z + 1.1181
    02;


    apd = apd * z + 7.117273
    52


    apd = apd * z + 1.58778084
    37


    apd = apd * z + 1.5320642747
    58


    a
        pd = apd * z + 6.8675230459278
    03

    apd = apd * z + 1.3849863
    47


    apd = apd * z + 9.99999999
    99


    f = apn / apd;


    if ((double)(x) > (doub
    le


    {
        bn 869
        6
        152
        6
        89
        E
            - 1;
        b
            n1 851
        7
        324
        6
        73
        8
        4228E-1;

        3.2
        9
        703
        6
        87
        3
        225371650E-1;

        16 *
            +
                .44
        4
        04
        0
        68948199951727E-2;
            =
        n
        6 * z
            -
            3.
        8
        2519546641336734394E-3;

        bd
        6
            = 1
                .
        00
        0
        00000000000000000E0;

        16
            =
            b
        d
        16 *
            z
            - 7.
        15 02E0;


        b 6
        3
        5807
        1
        566
        4
        69429
        1
        E1
            bd
        1
        6 =
            bd16 *
            z
            - 5 00
        7
        E
        0
            ;


        bd
        6
        z
            +
            9
                .
        5
        73
        9
        5
        8
        64
        3
        78

        bd16 = bd16 * z -
               5. 1107
            -
            ;


        f = z * bn16 /
            bd

        k =
            sq
        p
        ii* g;

        b
            bppn = 4.6546116277
        46


        bppn = bppn * z - 1.0899217
        38


        bppn = bppn * z + 6.38800
        11;


        bppn = bppn * z - 1.26
        84 E - 1;


        bppn = bppn * z + 7
        .6 105E
        3


        bppd = 1.000
        00 0;


        bppd = b
        pp 3159
        2
        240E
        0
            ;


        bppd
            = 2704
        5
        2131
        7
        2E
        1
            ;
        bp
            pd 6144
        1
        4311
        5
        95
        7
        2E0;

        b 4008
        9
        9606
        8
        05
        1
        8666E0;

        7.84
        7
        2113
        2
        33
        4
        1930448E-2;
            /bpp
            ;


        bip = k * t * (1.
        0 +
            ret
        u
            rn
            ;
    }

    f

    .0;


    g = x;


    u
        = 1
            .
    0;


    ug = x;


    z
        = x *
          x
          * x;

    (do
        b
            e
            )(t) > (double)(math.machin
    ee
        uf = uf * z;

    .0;


    uf = uf / k;


    k = k + 1.0;


    u
        f = uf / k;

    f
        k
            =
            k
            +
            1.0;
    ug =
        u
    g
        = g +
          u
    g;


    t = Math.Ab
}


uf = c1 * f;


if (
    d
om
    f
lg % 2 == 0 )
{
    = uf
        u
        ;
}
if (d
om

{
    bi = sqrt3 * (uf
                  + u
}


k = 4.0;


ug
    = z / 3.0;
f =
    u = 1
0
ug;


uf = uf / 3.0;


wh
    i
le((double)(t) > (double)
    (m on)


{
    uf
        =
        g =
            u
    g /
        k
        ;
    k = k +
        1.u

    ug*
        z
        ;


    uf = uf / k;
        = f
        u
        ;


    k = k + 1.0;

    g / k;


    uf = uf / k;


    k = k + 1.0;
        /g);
}
uf = c1 * f
    ;
c
    *
    ;
    =


a
i
    p
        =
        u
f -
    u
g
    ;


f
(
    d
o
    mf
l
g
    /
    8 %
    2
    == {
    p ug
        )
}


}
}

public class dawson
{
    /*************************************************************************
    Dawson's Integral

    Approximates the integral

                                x
                                -
                         2     | |        2
     dawsn(x)  =  exp( -x  )   |    exp( t  ) dt
                             | |
                              -
                              0

    Three different rational approximations are employed, for
    the intervals 0 to 3.25; 3.25 to 6.25; and 6.25 up.

    ACCURACY:

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE      0,10        10000       6.9e-16     1.0e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double dawsonintegral(double x,
        alglib.xparams _params)
    {
        doub
            l


        d
            o
        uble x2 = ;
        doubl
            e

        n
        s
            g
                =
                0;
        do ub le an = 0;

        ea d
                =
                0
            ;


        n
            ;


        d
            ouble

        c
            n
                =
                d =
                    0


        sg = 1;


        (do
            b
                e)(
                0
            )
            )
        {
            x =
                -
                    x
                ;
        }

        i dou b
        e
            (3.
        2
        5
            )
            )


        a
            n
                = 1.136814989 17 5972 05 4E- 11;

        n =
            an x2 +
            8
                .
        4
        926226766747381 10 E - 10;
        *x2
        1
        94 43
        4
        2
        0
        4175553054283E-8;
        315
        7
        1254 4
        8
        4
        363489E-7;
        a
        874
        1
        200438 E - 6;


        028
        7
        864
        9
        E
            -
            4;
        an = a
        n
        203
        E
        4;


        an = an * x2 + 4
                .
            ;


        an = an * x2 + -9.17480
        3


        an = an * x2 + 9. 999999999999
        9


        d =
            2
                .
        4037207306676260 5484E-11;
            = a
            *
            2 + 1
                .
        4
        8
        8646813684 93396752E-9;


        +5.
        1
        652
        8
        1
        0
        10541664570 E - 8;


        4
        8
        731
        8
        697
        0


        a
            d
                =
                51
        3
        9
        1E-5;


        ad = ad *
             x
             +
             -
            = ad
        x
            +
            3.488058146571 25 0916 E - 3;


        +2 .79
        4
        5311
        9
        8
        8
        28973716E 2;
        ad

        2056
        3
        8E-1
            ;


        ad = ad * x2 + 5.749
        1


        a = a d * x2 + 1. 00000000000000000
        5
        y =
            *
                ad


        result = sg * y;


        esu t;
    }

    x2 =
    if( do bl e) (x
        )< (d o
    u
        bl e)(6.25) )
    1564
    7
    0090
    3
    3
    5
    4E-1; bn = b n* x2
    -
    -1;


    bn = bn* x2+9.4151233 30 53 44 1
    bn* x
    -
    .18 11 55 14 20 39 02 520 6E -2;
    bn
    =
    1813
    2
    -3;


    bn = bn* x2- .2 2


    bn
    =
    6
    1
    E-5;
    2.
    4
    4
    0
    3
    517
    1
    9
    9
    6
    8
    9
    n =

    n
        x2+9.10010780 076391431042E
    -
    x2-2
    4
    2745
    2
    0
    8
    2825095694 2E-9;
    4409
    8
    1039
    8
    E
    -
    11;
    bd = 1
    .


    b
        d = b d* x2-6.31839869873368
    1
    d =

    d
        x2+2
    .
    3
    6
    70 6788228248691528E-1;
    8063
    7
    032232 77662E-2;
    1718
    8
    29 537
    4
    4
    0
    9E-3;
    bd = b d
    168E4;


    bd = d* 2+7.8 10 255 92 94

    b
        d
            =
            bd * x2 - 4.55 75 53252 44 263 48 31E
            -
            = bd
        x

    +1.8
    9
    1
    0
    03581114 18 6170E -7;
    2469
    3
    1920
    6
    0
    6
    875E-;
    bd = bd
        *

    9
    0
    -
    1
    1;


    d* x;
        ;

    f
        bl

    e
        E

    )
    )
    = g
    0. 5/ x
        ;

    e
        u

    r


    =
    .
    0
    59 28 6
    0
    54;


    n =

    c
        n

    *
    x
    2+6.29
    2
    3
    5242
    7
    2436880 0674E-1;
    13
    4
    1E
    -
    1
    ;

    c
        *

    2
    +
    1.6
    4
    27
    1
    02
    0
    4
    6

    d
    =
    1.0
    0
    E0


    20 0
    7
    97
    5
    4
    4


    c
        d
            =
            97 84 85 7E 0;

    d*
    2- .9
    3
    7
    0
    1;
    7
    9
    4041
    23 339
    1
    07
    9
    E
    -
    2
    c
    26
    4
    94
    1
    2
    2


    y

    =

    d*
        x;


    r
        su y
        rn

    r
        sul;
}

}

public class hermite
{
    /*************************************************************************
    Calculation of the value of the Hermite polynomial.

    Parameters:
        n   -   degree, n>=0
        x   -   argument

    Result:
        the value of the Hermite polynomial Hn at x
    *************************************************************************/
    public static double hermitecalculate(int n,
        double x,
        alglib.xparams _params)


    d ub e
        i

    n
        t i
        ou

    l
        a
            =
            =
            0
            0


    B


    /
    /
    2*
    ;
    /

    l
        c

    ses: N
    =
    0

    o
        r { ur n res ul t;


    {
        ne;
    }

//
// General case: N>=2
//
for (i = 2; i <= n; i++)
{
    result = 2 * x * b - 2 * (i - 1) * a;
    a = b;
    b = result;
}

return result;
}


/*************************************************************************
Summation of Hermite polynomials using Clenshaw's recurrence formula.

This routine calculates
    c[0]*H0(x) + c[1]*H1(x) + ... + c[N]*HN(x)

Parameters:
    n   -   degree, n>=0
    x   -   argument

Result:
    the value of the Hermite polynomial at x
*************************************************************************/
public static double hermitesum(double[] c,
    int n,
    double x,
    alglib.xparams _params)
{
    d
        o
    u
        b
    l
        e

    r
        e
    s
        u
    l
        t
            =
            0
        ;


    d
        o
    u
        b
    l
        e

    b
    1
        =
        0
        ;


    d
        o
    uble b2 = 0;


    int i
        = 0;


    b1

    0;
    b2 =
        0
        ;

    r
        esult = 0;
    or(i = n
    {
        t = 2 * (
            1) 2) +
            ];
        b2 =
            1;
            = result


        return result;
    }


    /*************************************************************************
    Representation of Hn as C[0] + C[1]*X + ... + C[N]*X^N

    Input parameters:
        N   -   polynomial degree, n>=0

    Output parameters:
        C   -   coefficients
    *************************************************************************/
    public static void hermitecoefficients(int n,
        ref double[] c,
        alglib.xparams _params)
    {
        c n w double[
            0
        n + 1]
        f
            or


        a


        for (i = 0;
        {
            c[n - 2 * (i
            i
                *
                2 * i) *(n - 2 * i - 1) / 4 / (i + 1));
        }
    }

public class legendre
{
    /*************************************************************************
    Calculation of the value of the Legendre polynomial Pn.

    Parameters:
        n   -   degree, n>=0
        x   -   argument

    Result:
        the value of the Legendre polynomial Pn at x
    *************************************************************************/
    public static double legendrecalculate(int n,
            double x,
            alglib.xparams _params)
        do =
        ;
        =
        ;


    dou bl e b
        =
        0;


    resul t = 1;


    b x { eturn result;

    ( = =) {
        r
        f oi; <n;

        i
            +
            re su lt i b
        (
            )* )/
        i
            ;
        a = b;


        b = res ul t;
    }


    ;
}


/*************************************************************************
Summation of Legendre polynomials using Clenshaw's recurrence formula.

This routine calculates
    c[0]*P0(x) + c[1]*P1(x) + ... + c[N]*PN(x)

Parameters:
    n   -   degree, n>=0
    x   -   argument

Result:
    the value of the Legendre polynomial at x
*************************************************************************/
public static double legendresum(double[] c,
    int n,
    double x,
    alglib.xparams _params)

resul
    = 0;
    = ;
double 2
    =
    0;


0;
for (i = n; i >= 0;
     re su lt = (2 * i + 1) * x * b1 / (i + 1)
                -
                2
b1
    etu n esu lt;
}


/*************************************************************************
Representation of Pn as C[0] + C[1]*X + ... + C[N]*X^N

Input parameters:
    N   -   polynomial degree, n>=0

Output parameters:
    C   -   coefficients
*************************************************************************/
public static void legendrecoefficients(int n,
    ref double[] c,
    alglib.xparams _params)
{
    i
    n i = 0;


    l
        ]


    c e
    1
    for (i = 0; i <=
                n;
    {
        [i] =
        0;
    }


    c
        [
            n
        ]
        =
        1
        ;


    f
        o
    r
        (
            i
                =
                1
        ;

    i
        <
        =
        n
        ;

    i
        +
        +
        )


    {
        c[n] = c[
        ] * (n + i
            / 2 / i;
    }


    =n / 2 - 1

    i + {
        c
            [
                n - 2 * i]
            (i + 1)
            (
    }
}

public class bessel
{
    /*************************************************************************
    Bessel function of order zero

    Returns Bessel function of order zero of the argument.

    The domain is divided into the intervals [0, 5] and
    (5, infinity). In the first interval the following rational
    approximation is used:


           2         2
    (w - r  ) (w - r  ) P (w) / Q (w)
          1         2    3       8

               2
    where w = x  and the two r's are zeros of the function.

    In the second interval, the Hankel asymptotic expansion
    is employed with two rational functions of degree 6/6
    and 7/7.

    ACCURACY:

                         Absolute error:
    arithmetic   domain     # trials      peak         rms
       IEEE      0, 30       60000       4.2e-16     1.1e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double besselj0(double x,
        alglib.xparams _params)

    doub
        e

    r
        dou

    le xsq
        = 0;

    d ou b
        pz er o = 0;


    d ou bl e
        =
        if

    (
    o
    b
    l
    0)


    x
}

(doubl
    )
    x
    )> ) )


sympt0
    x

r
    ep e
r
    o,
    r
e q
    z
    ;


(2 / Mat
        .PI / x)
    * (pzero * MatCos(nn) - qzero * Math.Sin(nn));
return result;
}
xsq = math.sqr(x);
p1 = 26857.86856980014981415848441;
p1 = -40504123.71833132706360663322+xsq*p1;
p1 = 25071582855.36881945555156435+xsq*p1;
p1 = -8085222034853.793871199468171+xsq*p1;
p1 = 1434354939140344.111664316553+xsq*p1;
p
= -136762035308817
1
38.
8
65 1;
p 410723
5
6562.28
432465+
xsq*p1;
-1
7
1
7
69 8
4
800
xsq*p1
;
4
9
3
37 61 81
.
6
8
1
3
4
6+
x
s
*
p1
;
*
q
1
;
818
2
4
0
2
5
9
8
2
2
3
9
6
76 0+ s* q
1
;
q
1
=
3
1
2
1
+q
q1 =
127756739 9.8507056031594+xsq*q1;
q1 = 30246356167094626.98627330784+xsq*q1;
q1 = 5428918384092285160.200195092+xsq*q1;
q1 = 493378725179413356211.3278438+xsq*q1;
result = p1/q1;
return result;
}


/*************************************************************************
Bessel function of order one

Returns Bessel function of order one of the argument.

The domain is divided into the intervals [0, 8] and
(8, infinity). In the first interval a 24 term Chebyshev
expansion is used. In the second, the asymptotic
trigonometric representation is employed using two
rational functions of degree 5/5.

ACCURACY:

                     Absolute error:
arithmetic   domain      # trials      peak         rms
   IEEE      0, 30       30000       2.6e-16     1.1e-16

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
*************************************************************************/
public static double besselj1(double x,
    alglib.xparams _params)
{
    double
        esult = 
        ;

    double
        = 0;
    e
        x
    s
        q
            =
            0
        ;


    o
        bl
    e
        n
            =
            0
        ;


    double pzero
        =
        d
    le qze
        r
            =
            0;
    b
        p1 = 0;
    doub
        le

    s
        Ma
    h.Sign(x
        ;


    if ((double
        )
        (
            x
        )
        <
        (
            d
    o
        u
    b
        l
    e
        )
    (
            0
        )
        )


    {
        x
            =
            -
                x
            ;
    }


    if ((
            ouble)
        x)>(do
        ble)(8.0) )


    b(x, re

    pz ro, _p
    a
        rams);


    nn =  /4;


    t
    2
        / M zero* M
    th
    C
        * M t
        h
    d
        u
    bl e)(
            0
        )
        )


    esult
        r
    e
        s
    u
    l
        t
        ;


    ;


    p1
        = 2701.1227892323414856790990;
    p1 = -4695753.530642995859767162166 + xsq * p1;
    p1 = 3413234182.301700539091292655 + xsq * p1;
    p1 = -1322983480332.126453125473247 + xsq * p1;
    p1 = 290879526383477.5409737601689 + xsq * p1;
    p1 = -35888175699101060.50743641413 + xsq * p1;
    p1 = 2316433580634002297.931815435 + xsq * p1;
    p1 = -66721
    656892
    9162
    80.20941484 + xsq * p1;


    199
    540016
    0
    6
    4
    39 q* p1;


    q1 =
        1.0;

    06 .9
    1
    7
    4
    8
    9
    x
    q* q
        ;

    9
    8
    855
    5921097 + x

    q
    1
        =
        1
    013 8
    6
    5
    14
        .
    5


    q


    5
    7
        = 2
    9 + xs q* q1;

    q1 =
        20 61 39 8


    9
    0
    3
    2
    9
    9
    8. 7
    1
    1
    3
    3
    48 x
        s
    q
        *
        q;
    321
    2
    2
    8
    7
    8
    8
    .5
    2
    9
    4
    0
    0
        *
        q1
        ;
    r
        r
    e
        ts l
        t
        ;
}


/*************************************************************************
Bessel function of integer order

Returns Bessel function of order n, where n is a
(possibly negative) integer.

The ratio of jn(x) to j0(x) is computed by backward
recurrence.  First the ratio jn/jn-1 is found by a
continued fraction expansion.  Then the recurrence
relating successive orders is applied until j0 or j1 is
reached.

If n = 0 or 1 the routine for j0 or j1 is called
directly.

ACCURACY:

                     Absolute error:
arithmetic   range      # trials      peak         rms
   IEEE      0, 30        5000       4.4e-16     7.9e-17


Not suitable for large n or x. Use jv() (fractional order) instead.

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 2000 by Stephen L. Moshier
*************************************************************************/
public static double besseljn(int n,
    double x,
    alglib.xparams _params)
{
    double resul
        = 0;


    doub
        l
    e pkm2
        =
        0 doub
        l
    e pkm1
    0;

    le pk = ;


    0;


    d
        o
    le as = 0;


    int g =
    {
        i
        f
        {
        s
        g =
        ;
        }
        else
        {
        {
        sg =
        1;


        }


        i
        f
        (
        ( le)(0)
        )
        ( n
        2
        = 0 )
        sg = -sg;
        x = -x;
        }


        )
        {
        r
        e
        sul
        t
        =
        s,
        p
        r
        ams);
        return
        r
        esu
        l
        t;
        if( n==1 )
        {
        ul =
        s
        g*besselj1(x, _p ar am
        s)
        r


        }
        if( n==2 )
        {
        f
        ( do bl )( x)==(double)(0) )
        {
        r es ult = 0;
        }

        el s
        selj 1( x, _ pa r

        }


        }


        i(( < (
            dou
        b
        le
        )
        ps
        l
        )
        {
        re
        su
        return result;


        }

        =
        3
        pk = 2*(n+k);
        xk = x*x;
        d
        o
        p
        k
        =
        a
        ns = pk-xk/s;
        k = k-1;
    }
    while (k != 0) ;
    ans = x / ans;
    pk = 1.0;
    pkm1 = 1.0 / ans;
    k = n - 1;
    r = 2 * k;
    do
    {
        pkm2 = (pkm1 * r - pk * x) / x;
        pk = pkm1;
        pkm1 = pkm2;
        r = r - 2.0;
        k = k - 1;
    } while (k != 0);

    if ((double)(Math.Abs(pk)) > (double)(Math.Abs(pkm1)))
    {
        ans = besselj1(x, _params) / pk;
    }
    else
    {
        ans = besselj0(x, _params) / pkm1;
    }

    result = sg * ans;
    return result;
}


/*************************************************************************
Bessel function of the second kind, order zero

Returns Bessel function of the second kind, of order
zero, of the argument.

The domain is divided into the intervals [0, 5] and
(5, infinity). In the first interval a rational approximation
R(x) is employed to compute
  y0(x)  = R(x)  +   2 * log(x) * j0(x) / PI.
Thus a call to j0() is required.

In the second interval, the Hankel asymptotic expansion
is employed with two rational functions of degree 6/6
and 7/7.



ACCURACY:

 Absolute error, when y0(x) < 1; else relative error:

arithmetic   domain     # trials      peak         rms
   IEEE      0, 30       30000       1.3e-15     1.6e-16

Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
*************************************************************************/
public static double bessely0(double x,
    alglib.xparams _params)
{
    b

    double xsq = 0;

    o
        ;

    double qzero = 0
        ;


    p4
        =
        0;
    double q4 = 0;


    ub
    e
    (
        x) > (double)(8.0) )


    {
        es
            e
        asympt0(x, ref pzero, ref qze
        r
            o,
            _
        pa
        ra
            nn = x - Math.PI / 4;


        r.S
        r
            (2 / Math.PI / x) * (pzero * Math.Sin
                                 (
                                     nn)
                                 +
                                 qz
        er n)
        ;

        retur result;


        sq
            =
            math.sq(x);
        p4 = -41
        3
        70.
        3
        54
        9
        15
            ;


        34.65 86 89 54 28 06 + x q
            *
            p4
                = 34 6371 229.790403
        7
        817
        1
        03
        0

        p4 = 10 25 20 859 66 4
        2
        4
        8
        77 +
            x
        sq*
            p
        4;


        p4
            =
            7562431;
        p4 = 52 47065 58 11 12 76 49
        4
        1. 29 73 50 81
        4
        p4 = 6 58 74 73 27 71 955 49 25 9. 99 42 04 9 + x sq
        95 83 7.01
        33175 + xs q4;
        q4 = 1.0;
        q4 = 1282.452772478993804176329391 + xsq * q4;
        q4 = 1001702.641288906265666651753 + xsq * q4;
        q4 = 579512264.0700729537480087915 + xsq * q4;
        q4 = 261306575504.1081249568482092 + xsq * q4;
        q4 = 91620380340751.85262489147968 + xsq * q4;
        q4 = 23928830434997818.57439356652 + xsq * q4;
        q4 = 4192417043410839973.904769661 + xsq * q4;
        q4 = 372645883898616588198.9980 + xsq * q4;
        result = p4 / q4 + 2 / Math.PI * besselj0(x, _params) * Math.Log(x);
        return result;
    }


    /*************************************************************************
    Bessel function of second kind of order one

    Returns Bessel function of the second kind of order one
    of the argument.

    The domain is divided into the intervals [0, 8] and
    (8, infinity). In the first interval a 25 term Chebyshev
    expansion is used, and a call to j1() is required.
    In the second, the asymptotic trigonometric representation
    is employed using two rational functions of degree 5/5.

    ACCURACY:

                         Absolute error:
    arithmetic   domain      # trials      peak         rms
       IEEE      0, 30       30000       1.0e-15     1.3e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double bessely1(double x,
        alglib.xparams _params)
    {
        u
            ro = 0


        double
            q
        z
            er


        o
            le
        (
            .
        0)


        s
            m
        t
        1
        (x
        );


        -3 r su
        l
            t = Math
                .S
        q
        2 / at h.P
        I
            / x n(nn) + z er o* Ma th.
            Cs
            n
        r
            s
        ul
            t


        ma
        h.qr(
            x
        );


        p4 =
            -
                2
        1
        54
        8
        1
        24
        0
        2
        p
            - 2 5
        0
        681702
        1
        9
        4
            .
        45
        0
        950541
        4
        2
        6
        3
        9

        .34811
        1
        5
        27
        746
        2193
        1
        0
        7
        3991
        1


        p
        4
            =
            26554
        7
        3
        8
        3
        1
        43 4854 32 689 4. 896 + x * p
        922 2259
        6
            .
        4

        4 = 1.
        0
            = 1 7
        0
        9
        4;


        899
        8
        60
        4
        4;


        28 6
        2

        q4
            = 6
        4
        96 16
        1
        00
            +
            xs
        q
            * q4
            ;

        9
        6
        6
        3
        21 29 q4;


        825
        4
        8
        8
        195
        5.sq
        q
            ;
            = 29
        4
        879
        3
        589
        71 1
        9
        x
            s
        q
            * q

        4
            =
            5 854 7 +
                  4
            =
            508
        2
        0
        6
        73
        6
        6
        9
        4
        1
        24 sq
            q
            ;

        x * p
            /
            4 + 2 /
            Ma x
            p
        a
            ram
        s) )


        r
    }


    /*************************************************************************
    Bessel function of second kind of integer order

    Returns Bessel function of order n, where n is a
    (possibly negative) integer.

    The function is evaluated by forward recurrence on
    n, starting with values computed by the routines
    y0() and y1().

    If n = 0 or 1 the routine for y0 or y1 is called
    directly.

    ACCURACY:
                         Absolute error, except relative
                         when y > 1:
    arithmetic   domain     # trials      peak         rms
       IEEE      0, 30       30000       3.4e-15     4.3e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double besselyn(int n,
        double x,
        alglib.xparams _params)
    {
        double
        resul
            t = 0;
            in
            = 0;


        d
            a =
                = 0;


        e tmp

        ouble s = 0;


        s
        1;


        if (
            0)


        {
            = -
                n


            if (
                %
            2
                = 0 )


            {
                s
                    =
                    -
                        1
                    ;
            }
        }


        if (n == 0)

        {
            r
                es y0(x,
                _
                    params)


            rr t
            (n == 1
                )


            re
                * _param
                );


            sult;


            a =
                be
            s
                l
            y
                b b ss e
                l
            y
            1
                (x, _p
            a
                r
            ams
                )


            (
            {
                t
                    p =
                        b;


                b
                    a
                        =
                        t
                m
                    p
                    ;
                r
                s
                    lt =
                        s *;


                r
                    e
                t
                    u
                rn re
                s
                    ult;
            }


            /*************************************************************************
            Modified Bessel function of order zero
    
            Returns modified Bessel function of order zero of the
            argument.
    
            The function is defined as i0(x) = j0( ix ).
    
            The range is partitioned into the two intervals [0,8] and
            (8, infinity).  Chebyshev polynomial expansions are employed
            in each interval.
    
            ACCURACY:
    
                                 Relative error:
            arithmetic   domain     # trials      peak         rms
               IEEE      0,30        30000       5.8e-16     1.4e-16
    
            Cephes Math Library Release 2.8:  June, 2000
            Copyright 1984, 1987, 2000 by Stephen L. Moshier
            *************************************************************************/
            public static double besseli0(double x,
                alglib.xparams _params)
            {
                double result
                        = 0
                    ;


                bl
                    = 0;
                double v
                        = 0
                    ;


                ble z
                    ;


                d
                    o
                uble b0
                    =
                    0


                d
                    oub
                l
                    e

                b1
                ouble
                    b2 = 0;

                if ((double)(x) < (double)(0))
                {
                    x = -x;
                }

                if ((double)(x) <= (double)(8.0))
                {
                    y = x / 2.0 - 2.0;
                    besselmfirstcheb(-4.41534164647933937950E-18, ref b0, ref b1, ref b2, _params);
                    besselmnextcheb(y, 3.33079451882223809783E-17, ref b0, ref b1, ref b2, _params);
                    besselmnextcheb(y, -2.43127984654795469359E-16, ref b0, ref b1, ref b2, _params);
                    besselmnextcheb(y, 1.71539128555513303061E-15, ref b0, ref b1, ref b2, _params);
                    besselmnextcheb(y, -1.16853328779934516808E-14, ref b0, ref b1, ref b2, _params);
                    besselmnextcheb(y, 7.67618549860493561688E-14, ref b0, ref b1, ref b2, _params);
                    besselmnextcheb(y, -4.85644678311192946090E-13, ref b0, ref b1, ref b2, _params);
                    besselmnextcheb(y, 2.95505266312963983461E-12, ref b0, ref b1, ref b2, _p
                    rams);


                    bessel
                        n
                    ex 726826
                    2
                    9144155
                    70723E-
                    11, ref b0, b2, _p
                        rams);


                    53
                    3
                    3
                    6
                    f b1,
                        b 2, _p
                        b
                    s
                        s
                    1
                    f b, ef
                    b
                        es el mn e
                        x
                    t
                    heb
                        y,  2.
                    6
                    6
                    6
                    e
                    f
                        b2,
                        _
                    pa
                        r
                    a
                        ms be ss e
                        m
                    extch eb(y, 1
                        .
                    3000
                    2
                    50 09 9
                    8
                    6
                    2
                    4
                    80421
                    2
                    E - 8,
                        ref

                    b0
                        ,
                        ref
                    b
                    1, r
                    ef b2,
                        _
                    p
                        a
                    r
                        be se lmn e
                    254 9
                    1
                    894
                    93 2E -
                        8
                    r
                        fb 2, m s

                    besselmnex tc eb(y, -.9 33 4
                    061 73 391E-7, r ef b 0, re f b1,  ref b  2, _ pa a
                        be se mn extc
                        h
                    eb(
                        y
                        ,
                        1
                    15Ea s);
                    (5 ef b, params );
                    besselmnex
                        t
                    che
                    b
                    (y
                        ,
                        8970893E 5, re f
                        ,
                        _
                    a
                        ra m
                        be se me.
                    7
                    0, r f 1, r r
                    a
                        b
                    sselmc 1
                    58
                    5
                    72 9 - b0, ef b1, r ef b2,
                        _p ar
                        be ss el mnextcheb(y, -5.7637557
                    4
                    538
                    5
                    82
                    3
                    ef
                        b,  ref b2 , pa am s) ;


                    bes el n
                    39
                    7
                    616 41 3579 84 2E-3 , ref b0, ref b1 r f b2, _
                    pa
                        r

                    esselmnextcheb(y, -4.32430999
                    5
                    050
                    5
                    75
                    9
                        , ef b1, re f b2, _ pa ra ms );
                    b
                        e
                    ssel ne t
                    460394
                    9
                    9
                    9
                    83 83 -
                        2
                        ,
                    r ef b
                    0
                        ,
                    r
                        e
                    f b1, re
                    f
                        pa ra ms);


                    b
                        e
                    .37374
                    480589
                    94688156E-2ref b0, ref b1, ref b2, _params);
                    besselmnextcheb(y, 4.93052842396707084878E-2, ref b0, ref b1, ref b2, _params);
                    besselmnextcheb(y, -9.49010970480476444210E-2, ref b0, ref b1, ref b2, _params);
                    besselmnextcheb(y, 1.71620901522208775349E-1, ref b0, ref b1, ref b2, _params);
                    besselmnextcheb(y, -3.04682672343198398683E-1, ref b0, ref b1, ref b2, _params);
                    besselmnextcheb(y, 6.76795274409476084995E-1, ref b0, ref b1, ref b2, _params);
                    v = 0.5 * (b0 - b2);
                    result = Math.Exp(x) * v;
                    return result;
                }

                z = 32.0 / x - 2.0;
                besselmfirstcheb(-7.23318048787475395456E-18, ref b0, ref b1, ref b2, _params);
                besselmnextcheb(z, -4.83050448594418207126E-18, ref b0, ref b1, ref b2, _params);
                besselmnextcheb(z, 4.46562142029675999901E-17, r
                f b0,
                    ef b1,
                    ref b2,
                _
                    par
                m
                    s) bess
                    l
                mn .46122
                2
                8676974
                109310E
                    - 17, ref b0
                    _params;


                che
                2
                    .
                48 6

                ef b2,
                    _
                a
                    a
                m
                    m
                ext
                77219
                3
                6
                E
                    -
                    r
                e
                    e
                3
                36 0
                ef
                    _ pa a
                m
                    )
                e
                0
                e
                1, r e
                n
                0
                ef

                1
                    ,
                r
                    f

                tc heb(z

                4.150569
                3
                4
                78 72 220866
                3
                    , ref
                2, _pa s
                l
                    mn
                ex c
                69E 4
                    ,
                    ref b0,

                r
                e
                    b1, re
                b
                    be
                s
                3 2
                42 011 E - 3,
                p
                    r
                ms);


                be ss el mnex t
                8
                _ a
                am )
                ;
                l
                51 50 80 61 17 7, 0, re b,
                    f

                b
                2
                be ss el
                    nex tc heb
                (
                    104477131188E-11,  ref b0, ref b1, ref b2, _params);
                besselmnextcheb(z, -3.14991652796324136454E-11, ref b0, ref b1, ref b2, _params);
                besselmnextcheb(z, 1.18891471078464383424E-11, ref b0, ref b1, ref b2, _params);
                besselmnextcheb(z, 4.94060238822496958910E-10, ref b0, ref b1, ref b2, _params);
                besselmnextcheb(z, 3.39623202570838634515E-9, ref b0, ref b1, ref b2, _params);
                besselmnextcheb(z, 2.26666899049817806459E-8, ref b0, ref b1, ref b2, _params);
                besselmnextcheb(z, 2.04891858946906374183E-7, ref b0, ref b1, ref b2, _params);
                besselmnextcheb(z, 2.89137052083475648297E-6, ref b0, ref b1, ref b2, _params);
                besselmnextcheb(z, 6.88975834691682398426E-5, ref b0, ref b1, ref b2, _params);
                besselmnextcheb(z, 3.36911
                478255
                940899
                E - 3, ref

                b0, re
                    b1 arams)
                ;


                be
                    sselmnextche 411014
                088316
                8
                    -
                    1, b1, r
                f
                    b,
                    _

                v
                    =
                    0


                re Exp(x)
                v /
                    a
                h
                    .S
                    r
                t
                    r
                n
            }


            /*************************************************************************
            Modified Bessel function of order one
    
            Returns modified Bessel function of order one of the
            argument.
    
            The function is defined as i1(x) = -i j1( ix ).
    
            The range is partitioned into the two intervals [0,8] and
            (8, infinity).  Chebyshev polynomial expansions are employed
            in each interval.
    
            ACCURACY:
    
                                 Relative error:
            arithmetic   domain     # trials      peak         rms
               IEEE      0, 30       30000       1.9e-15     2.1e-16
    
            Cephes Math Library Release 2.8:  June, 2000
            Copyright 1985, 1987, 2000 by Stephen L. Moshier
            *************************************************************************/
            public static double besseli1(double x,
                alglib.xparams _params)
            {
                result = 0;


                double y = 0;


                ou
                    b
                e z
                    =
                    0


                dou
                    b
                l
                double 0 = 0;


                doub le b1 = 0;

                dou
                    le

                2 =
                    0;


                z =
                    M
                a
                    )<= do
                    bl e


                2.;
                e b
                2.
                7
                7911 16 ref b0, r ef b, re
                b
                    ,
                _ p) xt c
                (y
                    , -2. 111 42 12 14
                3
                58 f b0, ef b1, ref

                b
                2

                _p ar ams);
                besse lm 1
                n
                    e
                x
                eb(
                    1.5 5
                1957 36 2
                0
                46 92
                E - 1 6, re f b0, f, _params bess el m1ne xtcheb(1 96 477
                3
                3863080
                5
                E
                    , ref b2, _para
                    m
                s
                    )


                besselm1ne
                    x
                che
                (y
                    ,
                    7.6
                06
                8
                294
                35
                4
                693415 ef b1,  ref b2 , _p
                ar am s;
                be
                    s
                elm
                    ne
                x
                che
                (y
                    ,
                    -5.
                42
                1
                5504727
                9
                11 0, ref b1, ref
                b
                2
                    ,
                _
                    params);

                b
                    sse
                m1
                    n
                xtc
                    eb
                (
                    , 3
                22
                3
                9336594
                5
                57 b0, ref b1, r ef b 2,
                _p a;


                e se m1 ex tche
                b
                (
                    94371520E-12, r
                e
                    f

                0
                    ,
                r e_ a
                    m
                    );


                be s
                1 1736186298890
                9
                0
                1
                31 , e f 0, ref

                1,
                ef

                2,
                pa
                    r
                ms)


                eb(y, -6.663489
                7
                2
                3
                0
                202774223E - 1 1, r ef b0, 1 ef 2, _
                    ara
                s)
                ;


                cheb(y, . 211 03 01E-10, ref b0, r
                    e
                b1
                    r
                e
                    b2
                _
                    p
                ram
                    );


                besselm1nextche
                    b
                (
                    y
                    - 1.88724975 17 2282 92 879 0 - ,
                    ref
                b0
                    ,
                    ref
                b1
                    ,
                    ref b2,

                _p bessem y,  9.38 53 38 64 95771783 88 E - , r
                f b0, r ef b 1
                r
                e
                    b2,
                    ams);


                b(y4450591287963280 065E-8, ref b0, re
                f
                    b1,
                    re
                f
                    b2,
                    _p
                a
                    ams
                    ;


                cheb(y, 2.00329
                4
                7
                5
                55213526229E-7, ref b0, r
                    e
                b1
                    r
                e
                    b2
                _
                    p
                ram
                    );


                tcheb(y, -8.568
                7
                2
                0
                6
                469545474066E-7, ref b0,
                r
                f b,
                    r
                f b,
                    _
                ara
                    s)
                ;


                xtcheb(y, 3.470
                2
                5
                1
                0813767847674E-6, ref b0,

                ef
                1,

                ef
                2,

                par
                    ms
                    )


                extcheb(y, -1.3
                2
                7
                3
                6
                36560394358279E-5, ref b0
                    ,
                    ref
                b1
                    ,
                    ref
                b2
                    ,
                _pa
                am
                    s
                    ;


                nextcheb(y, 4.7
                8
                1
                5
                510755005422638E-5, ref b
                0
                re
                    b
                1
                re
                    b
                2
                _p
                    ra
                m
                    );


                1
                e
                    tch
                e
                b
                (y
                    ,
                    -
                        1
                .6 588E-4

                ef b
                0
                    , r
                    e
                f
                    b
                1
                    , ;


                ex 2
                8
                9561
                6
                8
                5
                757
                72 b0, ref b1, ref
                b
                2
                    , _params);


                bes
                    el
                m
                    nex
                ch
                e
                (y,
                    -1
                        .
                1357245
                0
                63 , ref b0, ref b
                1
                    ,

                e
                f b2, _params);


                be
                    s
                elm
                    ne
                x
                che
                (y
                    ,
                    4.15642
                2
                94 E - 3, ref b0, re
                f
                    b,  ref b2 , _params);


                se
                    m1
                ne tch
                b(
                    y - 1 .056 08 4
                8
                94 2, re b 0, ref b1
                    ,

                r
                f b2, _p ar ams);


                bes
                    elx eb(y, 2
                    .
                4
                283E-2, ref b0,

                r
                    e
                1, f params);

                se
                    m1
                ne tc eb y,  2 08 9491 - 2, re b, ef, _
                le ch b(y2 58
                709538 4E 1 br as )


                1 n7 67 15
                    , rf b, 
                2, _p
                    a
                r
                    besselm 1x.
                258
                6
                4
                3633654
                8
                23 ref 1, re f b2a
                    v
                0. 5 * 0 -
                    b
                    );
                v * z * t p(z);
            }


            {
                = 32.0 / z - 2 besselm1first
                    c
                2963 084
                21 01 3r b0,  ref b1 ,  ref
                    b 
                    ,
                    _
                ar
                    a
                s);

                e extcheb y,  4.4143 43 07170791151E-18, r
                    e
                b0
                    r
                e
                    b1
                r
                    e
                b2
                    _
                p
                    rams);


                besselm1nextch
                    e
                b
                (
                    ,
                    -4.65030536848935832153E-
                1
                    , r
                f
                    b, r
                f
                    b, r
                f
                    b, _para
                m
                    s) besselm1n
                    e
                x
                    t
                heb(y, -3.2095259219934239
                5
                80E
                17
                    ,
                    ref
                b0
                    ,
                    ref
                b1
                    ,
                    ref b2,

                _p bes
                s
                    e
                l
                1nextcheb(y, 2.96262899764
                5
                501
                87
                6
                    - 16
                r
                    e
                b0
                    r
                e
                    b1, re
                f
                    b


                b
                sselm1nextcheb(y, 3.30820
                2
                109
                09
                2
                283
                4E
                    -
                    6,
                ef

                0, ref
                b
                1, rams);


                besselm1nextcheb(y, -
                    1
                880
                54
                7
                551
                78
                2
                485
                E -
                    1
                    , ref b
                0
                    , b2, _params);


                besselm1nextch
                e
                (y,
                    -3
                        .
                144
                30
                7
                437
                07
                8
                478E-15
                    ,
                r 1, ref b2, _par
                    a
                m
                    s
                    ;
                besselm
                1
                ext
                    he
                b
                    y, 
                .0
                4
                027
                98
                4
                2880276
                4
                2E ref b1, ref b2
                    ,

                _
                    arams);
                b
                    e
                sel
                1n
                    e
                tch
                b(
                    y
                4.
                72
                4
                0016711
                9
                51 ef b0,  ref b1 ,
                    r
                e
                f
                    b2, _par ms);


                bes
                    m1
                n
                xt
                (y
                    ,
                    -2.
                01
                5
                1842772
                66 4
                b0, ref b1, ref
                b
                2
                    ,
                _params);
                be s
                s
                    lm1
                ex
                    t
                heb
                    y, 

                4. 83 51 11 9219731
                8
                2
                re b, r
                e
                    f
                b
                2
                    ,
                _
                    p

                b
                    ssel
                m
                1ne
                    x
                t
                    ch b
                    (y - .1 9
                8551
                7
                7
                6
                2
                    , ef b0, 
                ref b1 
                    ,
  ref b2 , _rams);
                besselm1nextcheb(y, 2.03562854414708950722E-12, ref b0, ref b1, ref b2, _params);
                besselm1nextcheb(y, 1.41258074366137813316E-11, ref b0, ref b1, ref b2, _params);
                besselm1nextcheb(y, 3.25260358301548823856E-11, ref b0, ref b1, ref b2, _params);
                besselm1nextcheb(y, -1.89749581235054123450E-11, ref b0, ref b1, ref b2, _params);
                besselm1nextcheb(y, -5.58974346219658380687E-10, ref b0, ref b1, ref b2, _params);
                besselm1nextcheb(y, -3.83538038596423702205E-9, ref b0, ref b1, ref b2, _params);
                besselm1nextcheb(y, -2.63146884688951950684E-8, ref b0, ref b1, ref b2, _params);
                besselm1nextcheb(y, -2.51223623787020892529E-7, ref b0, ref b1, ref b2, _params);
                besselm1nextcheb(y, -
                    .88256
                808877
                9039346E
                    -
                    6, ref
                b
                0, b2, _
                    p
                arams);

                bes b(y, -
                    .10588
                3
                7
                62 , ref
                0

                e
                    f _param
                    )


                bessel
                1
                e
                    t
                ch 097491
                61
                6
                4
                07 0, ref
                b1

                e
                    f;


                x
                    c
                eb(y
                    ,
                    7.
                7
                8
                5
                76 47
                4
                    -
                    1, ref

                b
                0
                    ,
                r
                    e
                f b1,
                    r
                e
                    f b
                2
                _.
                *
                    b
                0
                    - b2
                    )
                ;

                v * Math.Exp(z) / Ma
                t
                h.Sqrt(z);
            }


            if
            (
                d
            ubl
                )(
                x
                < (doubl
            e
                )( {
                = -z;
            }


            re
                s
            lt
                z
                ;


            ret
                u
            rn
        }


        /*************************************************************************
        Modified Bessel function, second kind, order zero

        Returns modified Bessel function of the second kind
        of order zero of the argument.

        The range is partitioned into the two intervals [0,8] and
        (8, infinity).  Chebyshev polynomial expansions are employed
        in each interval.

        ACCURACY:

        Tested at 2000 random points between 0 and 8.  Peak absolute
        error (relative when K0 > 1) was 1.46e-14; rms, 4.26e-15.
                             Relative error:
        arithmetic   domain     # trials      peak         rms
           IEEE      0, 30       30000       1.2e-15     1.6e-16

        Cephes Math Library Release 2.8:  June, 2000
        Copyright 1984, 1987, 2000 by Stephen L. Moshier
        *************************************************************************/
        public static double besselk0(double x,
            alglib.xparams _params)
        {
            uble re
            s
                ul double y = 0;


            double z = 0;


            dou
                le = 0;


            d


            double b1 = 0;


            d
                ub
            l
                b2 = 0;


            alg li.ap.s
                ble)(0), "Domain

            e
            r
            or in Be ss el K0 x <= 0");


            i
                f
            ( do le) )< =(ubl(2)


            y = x * x - 2.0;


            b ss elmfirstcheb(1.
            3
            446
            43
            51 35 3
            71 6 - 16
            ef b, r f b1
            re f
            besse
                l
            m
                n
            xtcheb(y, 4. 5981614279661018
            3
            9E-
            4,

            b0
                e
            f
                r
            b
            2
            aram );

            mnextcheb(y, 1.0
            3
            4
            9
            9
            5257 63 38 42 16 7E-11, ref b0, re
            f
                b1, 
            ref b , _p ram s)
            be ss l
            1637722020886025
            E
                -
                9
                ref b 0, r f b1,  ref b2 , _par
            a
                s);
            ess mn ex heb y,  2. 3
            4
            7, ref b0 r f b1, re f
                b 2, _p ar ams);
            be
                ne
            tc he b
                y,  2.
            21 21 0
            119
            51
            7
            607E-5,

            r
                b2, _params);


            bess el mn ex tche b(y, 1.2
            6
            615
            11
            4
            692
            92
            3
            8E-, r ef
            0, ref
            b
            1

            be ss l
                m
            ne t
            ch eb y,  3.597 99 36515361501626
            6
                - 2,
            re
            f
                b0,
                re f b
            ef
            2,
                params)
            ;


            elm ne tche(y, 3 4428 8
            99 92 62848688 6E - 1, ref b0, ref b
            1
            re
                b
            2
            _p a
            s)


            b
                e
            273 323 3902768 2
            0E -
                ,
                ref b0, r ef b1,  ref b2 , _p
            a
                ams
                ;


            v
                =
                0
            5 * (b0 - b
            2
                )
                = v - ath.Log(0.5 *
                              x
                )
                *
                es se lx params
                )
        }


        else


        z = 8.
        0
            /
            x
        2
        .0;
        besse
            l
        fir
            tc
        h
        b(5
        7
        29 0, ref b1,
        r
            e
        f
            b2, _param)


        be
            s
        elm
            ex
        t
        heb
            z, 

        1.64758
        0
        4
            ref b0, ref b1,
        r
            e
        f
            b
        2, _params);


        be
            se t
            c
        eb(z,
            61E-17, ref b0,
            r
        e
            f
        b
        1, ref 2, _ arams);


        ess
            lm
        n
            xtc
        eb
        (
            , -1.67
        8
        2
        6 ref

        b
        0,
        r ef b
        1, s
            ;


        b e
        6
        e
            b1,
            r
        e
            f b
        2, bes st heb(z, -1 .848593377343
        7
        901
        40
        E
        15,
        re
        f
            b0, r ef b, ef b2
            _
        p
            besselmne
        x
            t
        c
        eb(z, 6.340076477405070605
        5
        E - 15 ref 0, r b1 re f, _ ra ms;


        nextcheb(z, -2. 22 75 13 26 9
        166985548E-14, ref b0, re f 1
        r fb 2, _
            ar m) ;


        bess el m
            n
        ex 0775363575 21 10 0E 14,

        r
        e
            b0,  ref b1 ,  ref b2 , _ aram );
        be sel mn xtc
        eb
        (
            -2.9800
        9
        69 3, r ef b 0, r
        ef b1, r
        e
            f

        2, _params);

        bes lm ne che z,  1 40
        3
        058 82 84
        7
        96303E-
        1
        2
        f 2, _params);


        bess lmn ex cheb z,  -4 5
        1
        78
        3
        9
        4164 7E -
            1
            , r
        f
            b,  ref b 
        1
            ,
        be
            s
        s
            e
        mn ex cheb z,  1. 5594 114 95 7178 2
        53 E - 1
        re
            b 0,
        ef
        1,

        ef
        2,
            params)
        ;


        lmnextcheb(z, -7. 5
        7
        48 2
        44 47 1074 776 E - 1, r f b 0, ref b1, re b2
        _
            p
        ram
            );


        be ss lm 73972814 00 0116 97E - 1 ,

        b0 , ef b, r ef b2, _par am s);


        b
            e
        sel
            nex t
        b(, -1.
        6
        97 6E - 9 ref b
        0, r f b1
        re f,
            _ ara ms;
        bes
            s
        lmn
            xt
        c
        eb(
            ,
            85 74 03 40 74
        1
        2260851
        9
        E
            ef 2 , _ pa am) ;


        besselm nexh - 4
            .
        604
        98
        9
        6874 78 29 56 - 8, ref

        b0 , _p ar ms);

        esselmnextcheb(z, 2. 76 63 394
        50
        1
        10 34 2E 7, r e b0,
            b2 _par am s
            );


        bes selmn ex tc he bz -
            .83
        75
        55 271
        119 4
        767
            - 6
            ,
            ref b0,

        re arams);


        besselmnextcheb(z, 1.3
        9
        981
        71
        8
        764
        93
        6
        2E-
            ,
        r
        f b0, r
        e
            f ams);


        besselmnextcheb(z, -1.28
        4
        549
        81
        6
        780
        63
        8
        E - 4
        r
        e
            b0, re
        f
            b ms);


        besselmnextcheb(z, 1.5698
        8
        885
        30
        0
        337
        91
        E
        3,
        ef

        0, ref
        b
        1, );


        e
        sselmnextcheb(z, -3.144810
        1
        119
        45
        0
        542
        E -
            2
        re
            b
        0
            ref b1
            ,
        r
            b
        e
            s
        elmnextcheb(z, 2.440303082
        0
        595
        45
        4
        8E0
        r
            e
        b0
            r
        e
            b1, re
        f
        b v =
            0
                .
        *
            (b0 - b2);

        v
            = v
        Ma
        t
            .Ex
            (-
                 x
             / Ma
        h.S
        rt(x);


        result =
            v
            ;


        return result;
    }


    /*************************************************************************
    Modified Bessel function, second kind, order one

    Computes the modified Bessel function of the second kind
    of order one of the argument.

    The range is partitioned into the two intervals [0,2] and
    (2, infinity).  Chebyshev polynomial expansions are employed
    in each interval.

    ACCURACY:

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE      0, 30       30000       1.2e-15     1.6e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double besselk1(double x,
        alglib.xparams _params)
    {
        d
            o
        u
            b
        l
            e

        r
            e
        s
            u
        l
            t
                =
                0
            ;


        d
            o
        u
            b
        l
        e
            y
                =
                0
            ;


        double z =
            0;


        d
        uble v
            = 0;


        double b0 = 0;


        doubl
            b1 = 0;


        d
        uble b2 = 0;
            =
        0.5
        x;

        alglib.
            p.ass
            rt
        (double)(z)
            (dou
        le)
        0),
        "Domain e
        r
            o
        r
            i
        K1");


        if ((
                d
        o
            le)(x) <= (
            ouble)(2)


        {
            y =
                x * x -
                .0;

            besselm
            1irstcheb(-7.023
            63
            7938
            287593
            3E-18,
                ref b0,
            r
            f b,
                f b2
                _params);


            besse
                m1ne
            tc
                e
            (
                y
                - 2
            42744985
            0
            193
            6
            93393E-1
            5, ams);


            besselm1next
            b(y, -
                9
            169419
            609E
            b0, b2,
            m
                s
                ;


            selm1ne
            b(y, -1411488392633527
            6110
                - 10, re
                b0, re
            b1
                ,
            ef b
            2
            _params);


            b
                ssel
            m
                next
            he
                (y, -2.
            1
            3
            8763073472585583E
                -
                8
                ,

            r
                e
            f
                b
            0
                ,

            r
                e
            f
                b
            1
                ,

            r
                e
            f
                b
            2
                ,

            _
                p
            a
                r
            a
                m
            s
                )
            ;


            b
                e
            s
                s
            e
                l
            m
            1
            n
                e
            x
                t
            c
                h
            e
            b
            (
                y
                , -2.43340614156
            968234
            6E-6,
            ef b0, r
            e
            f b1,
                e
            f;


            bess
                elm1nextche
            7513
            520 63 02E
            4

            re , ref
            2

            p
                a

            e
                s
            l
                m
            5723 59
            3
            8
            4
            3


            b
                (y - 1 .2 11
            8
            8
            2
            ef b0,
                re
            f
                be _pa
                r
            a
                m
            s
                )


            es
                elm1next
            c
                e
            b(
                y
                , -
                    87 56 E
                          - 1, re
            f
                b
            0
                ,
            r
            ef b1,
                r
            e
                f
            b
                b
            e
                sse
            l
            22733894777053E0
                ,

            re f 0, r f b 1, ref 2, _
                p
            ar
                a
                ;
                = r sult =
                M
            a
            h.Log(z) * besseli1(x, _ aram)
                +
        }

        e
        {
            y = .0 / x - 2.0;


            be
                s
            elm 1f rs
                tc eb(
                5.
            7
            6744483
            6
            65 f b0, f 2, _params);

            be
                s
            elm
                ne
            x
            che
            (y
                ,
                1.794 05 8
            7
            31 ef b0,  ref b1 ,
                r
            e
            f
                b2, _ pa
                ess
            lm
            1
            extc eb
            (
                , -5.68
            9
            46 - 1, ref b0, re
                b,
                e f b2, para s);


            lm
            1
            extcheb
            (
                y
            070E-16, ref b0
                ,

            r
            f b1, ef b , _ pa ams)


            b
                e
            sel1 ne x
            3733188 53 36E-1 6, r
                e
            f

            0, ref b1, ref b2, _pa ra s
                )
            ;


            bs el
            e
                x
            b(y, 2
            .0 36 62433424052
            E
                -
                1
                , ref b0, ref b1, ref b2,
            _
                ara
            s)
            ;

            b es lm1e x
            t
                c
            31 3E 15, ref b0, ref b 1, r f 2,
            pa
                r
            ms)


            esse m
            54 24 81 0
            4
            3
            70
            6
            8E - 1 4e
            0
                ,
                ref

            b1,
                ref
            b 2, _ pa ams);


            e
            2499
            b 2

            p
                ar am s) ;

            1nextc he(y, .34 84 9
            6
            68 91 884E-13, ref b0,

            ef
            1,

            ef
            2,
            p ar am s)


            (y, -.289 739 60 5102 9
            0
                - 12, ref b 0r _p
            ra
                m
                );


            b
                sselm1n
            e
                x
            348 173025100E - 1 ,
            r
                e
            f
                _para
            m
                );


            b
                sse
            m1
                n
            xtcheb(
                y
                ,
                7E-1, r ef b0, ef b1
            e
            f b2, _ pa m
                s
                ;


            b
                e
            sel
            1n
                e
            tcheb(y, 9
            ef b0,  ref b1 , a ss
                e
            ne xt c
            eb(
                y
                - 4.190
            3
            54 10, ref b0, ref

            b
            1
                ref b2, _params );
            bes se m1
                n
            ext
            he(
                , 2
            01
            54 97 59 ref b0, r ef b 1, re
            f
                b, _params);


            b
                sse
            m1
                n
            xtc
                eb
            (
                , -
                .0
            3
            5762465
            6
            7
            b1, ref
            b
            2
                ,
            _
                params);
            be
                s
            elm
                ne
            x
            che
                (y, .7410
            8
            12 4500
            4
            9
                ref b1, re f b2, _
            p
                a
            r
                ms);
            besse
                l
            ex t
            (y
                ,
                -3.
            01
            9
            060
            08
            7
            1257119
            E
                - 7 , ref b2, _pa ams )

            besselm1nextc
                h
            b(y
            2
                .
            06 48
            94
            7
            37 21 7
            5
            E
            6, ref
            b
            0
            _params);


            b sselm1nex tc eb(y, -1 .9 37 9
            41
            6
            0829602
            4
            E
            ef b2, _params)
            ;


            b es elm1next ch b
                y,  19 52 5
            184
            13 51 68 , r ef b 2, _params);


            besselm1 nextche y,  .8
            5
            68
            2
            2
            86
                -
                3
            f b0,
                re fe s);


            be sselm 1nextcheb(y, 1.03
            9
            373
            57
            6
            172
            84
            3
            E - 1
            re b0, ef b ,

            bes
                s
            e
                l
            1nextcheb(y, 2.72062619048
            4
            94
            5
            0,
            ef

            0,
            ef

            1, ref
            b
            2
            v = .5 * (0 -
                      b
            2
                )


            result = Ma
            t
                .Ex
                (-x
                )
            v / M
            th
                .q rt(
            );


            turn r sult
        }


        /*************************************************************************
        Modified Bessel function, second kind, integer order

        Returns modified Bessel function of the second kind
        of order n of the argument.

        The range is partitioned into the two intervals [0,9.55] and
        (9.55, infinity).  An ascending power series is used in the
        low range, and an asymptotic expansion in the high range.

        ACCURACY:

                             Relative error:
        arithmetic   domain     # trials      peak         rms
           IEEE      0,30        90000       1.8e-8      3.0e-10

        Error is high only near the crossover point x = 9.55
        between the two expansions used.

        Cephes Math Library Release 2.8:  June, 2000
        Copyright 1984, 1987, 1988, 2000 by Stephen L. Moshier
        *************************************************************************/
        public static double besselkn(int nn,
            double x,
            alglib.xparams _params)
        {
            0;


            ;
            double kf = 0;
            double nk1f = 0;
            double nkf = 0;
            double zn = 0;
            double t = 0;
            double s = 0;
            double z0 = 0;
            double z = 0;
            double ans = 0;
            double fn = 0;
            double pn = 0;
            double pk = 0;
            double zmn = 0;
            double tlg = 0;
            double tox = 0;
            int i = 0;
            int n = 0;
            double eul = 0;

            eul = 5.772156649015328606065e-1;
            if (nn < 0)
            {
                n = -nn;
            }
            else
            {
                n = nn;
            }

            alglib.ap.assert(n <= 31, "Overflow in BesselKN");
            alglib.ap.assert((double)(x) > (double)(0), "Domain error in Be
            selKN"
                ;

            i
            f
                ((dou
            l
                e) )(9.55
                )
                )


            {
                z 0 =
                    25 * x * x;


                pn = 0 .0;


                o
                    x

                i
                    (
                        n = -e;
                    = 1.0;


                1;
                i <= n 1
                    ;


                {
                    n
                        = n
                          +
                          1. /k;


                    f
                        n fn* k
                        ;
                }
                m
                    n
                        = ox
                    ;
                if (n ==
                    1)


                {
                    a s
                    .0 x
                        el e
                        nk1 f

                    fn
                        n;


                    k
                        f

                    n
                        k
                    1
                        ;
                    z


                    1 .0

                    for (i =  =
                        n
                            -
                            1

                    i++)


                    k1f = n
                    k
                    1
                    kf =
                        k
                        *
                        i
                        ;
                    z
                        z n* z


                    t
                        k1 f * z
                    f;

                    al gl ib.a p. as se rt(( do
                        u
                            l
                    e)(math.maxrea number - ath.A
                    t)
                        >(
                        d
                    ub le )
                    Ma
                        t
                    bs(
                        ))
                        ,
                    "Overfl
                    o
                        w
                    al lib.ap.as e
                        ((d
                    ub
                        l
                        )(t
                    x)
                        >
                    dou
                        )
                    & &
                        um er to xu ble)(zmn), "O        er        f
                    m
                        z
                    m
                        *
                        tox;


                    s = s * 0
                    t = M at.A b
                    s(s);


                    gl ib.p.a ss
                    rt
                        (
                    do ub le(
                        le)(math.a) < (double)(t)), "        O
                    flo
                        i
                    n
                        Bes
                    el
                        K
                    ");


                    s
                    r
                    (!(
                        (
                            d
                    ou
                        b
                    le
                        )
                    (t && (do
                        b
                            (m at.m
                    axr
                        e
                    a
                        l
                    n
                    umber / t)
                        <
                    (
                        d
                    uble)(z
                    mn ) B
                        tlg
                            = 2
                    .0 * M th.Log(0 .5 * x);


                    p
                        k
                            = -
                                ul
                        ;


                    i
                    {
                        pn = pk;


                        t
                        1
                            .
                            ;
                    }


                    {
                        pn = pn + 1.0 / n;
                            = . 0 / n;
                    }
                    s = (pk + pn tlg)*t;
                    1.0;


                    o


                    {
                        = t(z0 / (k * n pk = p
                        k
                        1. 0 / k


                        n = pn + 1 .0 /
                                   s = s(
                            p
                        k
                            +
                            n - tlg)*t;

                        k +
                            .0
                            ;
                    }


                    )(Math.Abs(t / s)u ble)(math.ma
                    c
                        ine
                    ps
                        i
                    on)
                        );


                    =

                    if (0 {
                        s
                            s;
                    }


                    e
                        r
                    r esult
                        ;


                    if ((dou
                    b
                        l
                    e
                        (x) > (doub le )(Math.Log(math.m
                    a
                        rea
                    nu
                        m
                        )


                    {
                        return resul t
                    }


                    k
                        =
                        n;


                    p k = .;
                    z0
                    8. 0 * x .0;
                        = t;
                        = math.
                        m
                        xre
                    ln
                    u
                        ber
                            = 0;


                    z
                        =
                        *z
                        /
                        fn * z0);


                    1f = Mt h.Abs();


                    if (i >= n && (doubl
                    e
                        (nk
                    f)
                        >
                    dou
                        )(n
                        )
                        brea k;
                }

                nkf
                    =
                    nk1
                    ;
                    = s
                    t;


                0;
                pk = k
                2.;
                i
            }


            hi le((d
            o
                ub ))> (d uble(ma th mach n
            e
                e
            silon) );
            e t =
                Ma
            t
                .Ex
                (-
                     x
                 * M at h.Sq t(
                    M
            at
                r e
                tu rn r
            e
            su t;
        }


        /*************************************************************************
        Internal subroutine

        Cephes Math Library Release 2.8:  June, 2000
        Copyright 1984, 1987, 2000 by Stephen L. Moshier
        *************************************************************************/
        private static void besselmfirstcheb(double c,
            ref double b0,
            ref double b1,
            ref double b2,
            alglib.xparams _params)
        {
            0 = ;
            b1 =
                0.b
            2 = 0.0;
        }


        /*************************************************************************
        Internal subroutine

        Cephes Math Library Release 2.8:  June, 2000
        Copyright 1984, 1987, 2000 by Stephen L. Moshier
        *************************************************************************/
        private static void besselmnextcheb(double x,
            double c,
            ref double b0,
            ref double b1,
            ref double b2,
            alglib.xparams _params)
        {
            b2 =
                b1;

            b
                =
                b0;


            b0
                = x *
                b
                - b2 + c;
        }


        /*************************************************************************
        Internal subroutine

        Cephes Math Library Release 2.8:  June, 2000
        Copyright 1984, 1987, 2000 by Stephen L. Moshier
        *************************************************************************/
        private static void besselm1firstcheb(double c,
            ref double b0,
            ref double b1,
            ref double b2,
            alglib.xparams _params)
        {
            b
                =
                c;
            b1
                =
                0
                    .
            0
                ;


            b
            2
                =
                0
                    .
            0
                ;
        }


        /*************************************************************************
        Internal subroutine

        Cephes Math Library Release 2.8:  June, 2000
        Copyright 1984, 1987, 2000 by Stephen L. Moshier
        *************************************************************************/
        private static void besselm1nextcheb(double x,
            double c,
            ref double b0,
            ref double b1,
            ref double b2,
            alglib.xparams _params)
        {
            1
                =
                b b0
            x *
                1
            b
            2 + c;
        }


        private static void besselasympt0(double x,
            ref double pzero,
            ref double qzero,
            alglib.xparams _params)
        {
            d =  do
                e
                    p
                        =
                        0 0;


            p
                z
            er
                o
                    =
                    0;
            qzero =
                0;
            xsq
                =
                6
            4
            .0 / (x *
                  x
                )
                ;


            p2 =
                0
                    .
            0
                ;
            p2 = 248 .2719
            28 5
            51 + x s
                *
                p2;


            p2 =
                1
            5
            3982. 65 2
            9
            13
            .8 30
            4
            9
            9
            8
            3


            2 =
                32 8


            p
            3
            325
            2


            q
                =
                xs * q
                ;


            2 =
                2
            25
            0
            66.
            9

            2
                = 84 24 55
            4
            0
            481 0
            x
            1
                + xs
                *
                5560
            p3
            .88 1
            9
            3
            74 11 39 67 55 p
                - 2
            3
            p3


            823
            9
                .
            0
            6
            6
            1
            348 56 06 5
            3
            54
            8
            sq* p
                ;
            35
            5
            22 63 50 67 .0
                ;


            7
            349
            9
            23 4
            0
            519392
            8
            82
            7
            66 + xsq
                *
                q
            3;


            q3 = 156021.3
            2
            0667
            92 91 5
            25 9
            28 71 9 + xs
            q * 3;


            q = 53329 1. 32


            q3 = 6 6
            6
            74 .42 39 1
            9
            82 9
            86 00 0381 3x* q

            q
            3
                =
                25501
            5
                .
            510
            8
            8
            6
            942382 zer
            p2 / q;

            qzero = 8 * p3 / q3 / x;
        }


        private static void besselasympt1(double x,
            ref double pzero,
            ref double qzero,
            alglib.xparams _params)
        {
            dou e xs = 0

            d ub e
                q2 = 0;


            d
                ouble
            p
            3
                =
                0


            dou
                bl e q3 = 0;


            pz er o 0;


            qzero = 0;


            98;


            p
            2 =
                -10
            9
            8
            2
            4
            13 9 + s
                * p;

            .5 3


            1
            52 45 3

            1


            p2
                =
                9
                + x
            s
            q*
                p
            0


            q
            2
                =
                -14
            5
            5
                .
            00 5
            5
            68 +
                x
            q2
            1
            q
                q
            2
                ;


            q2 08
            1
            44 54 358
                +
                x
            3
                .
            79
            7
            230
            87 9
            x
            q
                *
                q2;


            q
            2 6
            7
            55 309 +
                6
            9
            62 + x
            s
            q* q
            2
                ;


            p
            3 =
                3
            5.2 65 3384 636 03 18
            59 1
            7


            02
            0
            1
            2
            8
            35
            4
                + x
            8
            9
            6

            939992
            6
                + xs
            q
            54 1606753 31


            p3 =
                3
            3
            2
            20.913
            4
            0
            9857
            2
            235
            1
            8597
            0
            44 42 xsq * 3;
                .
            475517
            83 + xsq
                *
                06 41 2
            9
            q

            40
            02 751 086
            1
            0
            81


            7
            0
            9
            2
            q3;


            q3 18 19 58.
            9
            x
                s
            q
            4
            75
            0
            24
            7
            2 +
                x
                = 
                /
            q2;
                /x;
        }
    }

public class laguerre
{
    /*************************************************************************
    Calculation of the value of the Laguerre polynomial.

    Parameters:
        n   -   degree, n>=0
        x   -   argument

    Result:
        the value of the Laguerre polynomial Ln at x
    *************************************************************************/
    public static double laguerrecalculate(int n,
        double x,
        alglib.xparams _params)
    {
        double r
            sult = 0;
        doub
            e a
        0;


        dou
        b
            b = 
            ;
        double i
            = 0;


        r
            sult = 
            ;


        a = 1;


        b
            =
            1
            -
            x
            ;


        i
            f
        (
                n
                    = 
            =
        1
            )


        {
            result = b;
        }

        i = 2
            ;


        oub
            e)(i) <
            (d
        ou


        re
            ult =
                (2
                 * i) * a)/i
            ;


        a = b;

        r
            s
        l
            t;
            = i
            +


        return rult;
    }


    /*************************************************************************
    Summation of Laguerre polynomials using Clenshaw's recurrence formula.

    This routine calculates c[0]*L0(x) + c[1]*L1(x) + ... + c[N]*LN(x)

    Parameters:
        n   -   degree, n>=0
        x   -   argument

    Result:
        the value of the Laguerre polynomial at x
    *************************************************************************/
    public static double laguerresum(double[] c,
        int n,
        double x,
        alglib.xparams _params)
    {
        d
            o
        u
            b
        l
            e

        r
            e
        s
            u
        l
            t
                =
                0
            ;


        d
            o
        u
            b
        l
            e

        b
        1
            =
            0
            ;


        double
            b2 = 0;
        int i
        0;


        b1
        0;


        b2 = 0;

        res
        u
            t =
                0


        fo
        (
            i
        n;
        i >= 0;
        i--)


        {
            r
                e
            s
                u
            l
                t
                    =
                    (
                        2
                        *
                        i
                        +
                        1
                        -
                        x
                    )
                    *
                    b
            1
                /
                (
                    i
                    +
                    1
                )
                -
                (
                    i
                    +
                    1
                )
                *
                b
            2
                /
                (
                    i
                    +
                    2
                )
                +
                c
                [
                    i];

            b2 =
                b1;

            b1
                = resu
            t
                ;
        }


        r;
    }


    /*************************************************************************
    Representation of Ln as C[0] + C[1]*X + ... + C[N]*X^N

    Input parameters:
        N   -   polynomial degree, n>=0

    Output parameters:
        C   -   coefficients
    *************************************************************************/
    public static void laguerrecoefficients(int n,
        ref double[] c,
        alglib.xparams _params)
    {
        int i = 0;
            = new double[0]
            ;


        double
        n
            + 1
                [0] = 
            ;

        r(i
        0;
        i <=
            -1
            ;
        {
            1] = -
            (
                c[i] * (n
            i)/(i + 1
                ) / (i + 1));
        }
    }

    public class elliptic
    {
        /*************************************************************************
        Complete elliptic integral of the first kind

        Approximates the integral



                   pi/2
                    -
                   | |
                   |           dt
        K(m)  =    |    ------------------
                   |                   2
                 | |    sqrt( 1 - m sin t )
                  -
                   0

        using the approximation

            P(x)  -  log x Q(x).

        ACCURACY:

                             Relative error:
        arithmetic   domain     # trials      peak         rms
           IEEE       0,1        30000       2.5e-16     6.8e-17

        Cephes Math Library, Release 2.8:  June, 2000
        Copyright 1984, 1987, 2000 by Stephen L. Moshier
        *************************************************************************/
        public static double ellipticintegralk(double m,
            alglib.xparams _params)
        {
            doub e result = 0;


            c
                in ti ec
            am
                )


            re ur n result
        }


        /*************************************************************************
        Complete elliptic integral of the first kind

        Approximates the integral



                   pi/2
                    -
                   | |
                   |           dt
        K(m)  =    |    ------------------
                   |                   2
                 | |    sqrt( 1 - m sin t )
                  -
                   0

        where m = 1 - m1, using the approximation

            P(x)  -  log x Q(x).

        The argument m1 is used rather than m so that the logarithmic
        singularity at m = 1 will be shifted to the origin; this
        preserves maximum accuracy.

        K(0) = pi/2.

        ACCURACY:

                             Relative error:
        arithmetic   domain     # trials      peak         rms
           IEEE       0,1        30000       2.5e-16     6.8e-17

        Cephes Math Library, Release 2.8:  June, 2000
        Copyright 1984, 1987, 2000 by Stephen L. Moshier
        *************************************************************************/
        public static double ellipticintegralkhighprecision(double m1,
            alglib.xparams _params)
        {
            double re ul = 0;
            b e = 0;
            double q 0
                )(m
                )
                =
                (double)(math.machi ep silon)


            re su l
                t
                    = 1.
            0. 5
            Mt h.Log(m1);
        }

        p = 1. 7
        982
        8
        64
        6


        p = 7 7404013220415179367E-3;
        58
        1
        02 12 26 008714E -3;
        p = p* m1
        +
        6.8
        7
        48
        9
        9 = p* m1 6.
        1
        8901 0
        9E-3;
        .79 078273952743772254E-3;
        27 8E 2;
        08
        5
        4652467
        18 2; pp*1 .65 73 590 28 1
        16 95 2;

        m1+1.
        8
        2
        9
        43
        6
        11
        1
        9
        8
        q = 2.
        40789
        504859850 E-5;
        q = q* m1+9.14184723865917226571E-4;
        q = q* m1+5.94058303753167793257E-3;
        q = q* m1+1.54850516649762399335E-2;
        q = q* m1+2.39089602715924892727E-2;
        q = q* m1+3.01204715227604046988E-2;
        q = q* m1+3.73774314173823228969E-2;
        q = q* m1+4.88280347570998239232E-2;
        q = q* m1+7.0312
        996963
        574697
        9E-2;


        q
        = 999999
        8
        70


        q = q* m
        1+4.9999999


        r
            es th.Lo (
        1


        e
            u

        es
    }


    /*************************************************************************
    Incomplete elliptic integral of the first kind F(phi|m)

    Approximates the integral



                   phi
                    -
                   | |
                   |           dt
    F(phi_\m)  =    |    ------------------
                   |                   2
                 | |    sqrt( 1 - m sin t )
                  -
                   0

    of amplitude phi and modulus m, using the arithmetic -
    geometric mean algorithm.




    ACCURACY:

    Tested at random points with m in [0, 1] and phi as indicated.

                         Relative error:
    arithmetic   domain     # trials      peak         rms
       IEEE     -10,10       200000      7.4e-16     1.0e-16

    Cephes Math Library Release 2.8:  June, 2000
    Copyright 1984, 1987, 2000 by Stephen L. Moshier
    *************************************************************************/
    public static double incompleteellipticintegralk(double phi,
        double m,
        alglib.xparams _params)

    es ul t = 0;


    ou b ou
        l

    b
        l

    e
        u

    b
        d

    o
        d

    ou
        b

    l
        t
            =
            k
                in t m

    in t s = 0;
    i nt n pi o2 = 0;

    p io 2 = 1. 5
    7
    0
    ) =

    o
        ble)( ) )
    {
        resul
            = phi
            ;
        return result;
    }
    a = 1-m;
    if( (double)(a)==(double)(0) )
    {
        result = Math.Log(Math.Tan(0.5 * (pio2 + phi)));
        return result;
    }
    npio2 = (int) Math.Floor(phi/pio2);
        if( npio2%2!=0 )
    {
        npio2 = npio2 + 1;
    }

    if( npio2!
        0 )


    {
        k
            el alk
        1 - a, _
            p
        a
            a
        ms
            phi = p
        i - npio2
            * pio2;

        els
            k = 0;


        if
            (doubl) (p
        h
            i
            )


        p
            h
                = -h
        i;


        el s
        e


        {
            b
                = Math.Sq );
            t = Math.Tan(phi);
            if ((double)(Math.Abs(t)) > (double)(10))
            {
                e = 1.0 / (b * t);
                if ((double)(Math.Abs(e)) < (double)(10))
                {
                    e = Math.Atan(e);
                    if (npio2 == 0)
                    {
                        k = ellipticintegralk(1 - a, _params);
                    }

                    temp = k - incompleteellipticintegralk(e, m, _params);
                    if (s < 0)
                    {
                        temp = -temp;
                    }

                    result = temp + npio2 * k;
                    return result;
                }
            }

            a = 1.0;
            c = Math.Sqrt(m);
            d = 1;
            md = 0;
            while ((double)(Math.Abs(c / a)) > (double)(math.machineepsilon))
            {
                temp = b / a;
                phi = phi + Math
                Atan(t
                temp)+
                    d * Math.PI;


                m hi + pio
                2
                    )/Math.I);


                mp)/(1
                0 - temp
                t
                    t
                    )
                    = 0.5
                    (
                    ;
                t = Math.Sqrt a
                    a
                        = 0.5 *
                          (a + b);
                b = temp;
                d = d + d;
            }

            temp = (Math.Atan(t) + md * Math.PI) / (d * a);
            if (s < 0)
            {
                temp = -temp;
            }

            result = temp + npio2 * k;
            return result;
        }


        /*************************************************************************
        Complete elliptic integral of the second kind

        Approximates the integral


                   pi/2
                    -
                   | |                 2
        E(m)  =    |    sqrt( 1 - m sin t ) dt
                 | |
                  -
                   0

        using the approximation

             P(x)  -  x log x Q(x).

        ACCURACY:

                             Relative error:
        arithmetic   domain     # trials      peak         rms
           IEEE       0, 1       10000       2.1e-16     7.3e-17

        Cephes Math Library, Release 2.8: June, 2000
        Copyright 1984, 1987, 1989, 2000 by Stephen L. Moshier
        *************************************************************************/
        public static double ellipticintegrale(double m,
            alglib.xparams _params)
        {
            double
                result = 0
            ouble
                = 0;


            q = 0


            b.ap.a
                s
            r
            (
                (
                    o
            u
                bl )( ) &
                &(dou
            b
                l
            e)(m
                )
                <= (double)(1),
                : m < 0 or m
            1
            "                     m =

            1 - m
                ;


            (
                r e
                =
                1
            5
            3
            55
            2
            577301013293365E-4;


            060 9E - 3;

            p 6
            6
            8
            8
            962 84 29E- 3;
            p =
                p * 7
            1
            3
            4
            03
            E
                -
                2;
            p m + 7.
            77 5
            E
                p = p * m + 7.583
            9
                * m + 1.15
            6
            p = p * m + 2.1831
            79 2


            p = p * m + 5.6805194561
            7
                = p * m + 4. 431 47 18 09


            p = *m + 1.00000000000
            00


            q
                = 3.27954898576485872656E
                  - 5 =
                    q
            m
                +
                1.
            0
            0962792679356715133E-3;

            +
                .
            0
            6
            09
            4
            89976927491433E-3;

            8
            2
            6
            3
            99
            3
            311317300E-2;

            q 2
            5
            4
            9
            36
            5
            9583E-2;
            q =
                q * 2
            9
            8
            6
            14
            E
                - 2;
            q = q * m + 4
            .2 7
            7
                -
                2
                ;


            q = q * m + 5.8593
            66 2


            q = q * m + 9 3749999 1976
            4
                =
                q
                *
                m + 2.499999999 98 88314361E-1
                ;
                =
            p
            q
                *
                m * M
            a
            th.Log(m)
        }


        /*************************************************************************
        Incomplete elliptic integral of the second kind

        Approximates the integral


                       phi
                        -
                       | |
                       |                   2
        E(phi_\m)  =    |    sqrt( 1 - m sin t ) dt
                       |
                     | |
                      -
                       0

        of amplitude phi and modulus m, using the arithmetic -
        geometric mean algorithm.

        ACCURACY:

        Tested at random arguments with phi in [-10, 10] and m in
        [0, 1].
                             Relative error:
        arithmetic   domain     # trials      peak         rms
           IEEE     -10,10      150000       3.3e-15     1.4e-16

        Cephes Math Library Release 2.8:  June, 2000
        Copyright 1984, 1987, 1993, 2000 by Stephen L. Moshier
        *************************************************************************/
        public static double incompleteellipticintegrale(double phi,
            double m,
            alglib.xparams _params)
        {
            d
                ouble
            esu
                lt
            o
                ub


            d
            uble a
                =
                le b
                ;


            doub
            e
                c
                    =
                    0 do
                b
                    ;


            e t
                = 0
            ou ble e b
                ;
            t m

            int
                n
            i
            2
                =
                int s
                =
                0
                ;
            pio2
                =
                1.57 07 9


            if
            (
                (
                    d
            ob le(m)
                = 
                =
            (
                d
            ub {
                i;


                es
            }


            hi
                phi;


            np
                i
            o
            2
                (or

            if (
                n
            pio
            2
                % 2 !=
                0
                )


            {
                = npi
                2 + 1;

                i = l
                h
                    -
                    npi
                o
                2 * pi
                o
                2;


                if ph
                    i
                        <(dou
                b
                    l
                e)
                (
                    ) lph
                    - lph
                i
                    ;
            }


            s = 1;
        }


        a

        e
            i
                = e
        l
            liptic i
            nteg
        r
            u
        l
            )
        (
            tem
        p
            = Ma th.
            u
            r
    }


    a
        h

    Tan(
        l
            phi
    );


    Ma
        t
        .
        Sqrt(a
        );


    //         /        n
    F
        tzg

    e
        r

    a
        l

    d
        <f.r
        p
        .
        edu>
    /
    /

    f
        o

    r poin

    t
        i

    ng
        ut ne p
    /
    / ou
        b

    e)(Ma
    th
    .
    bs


    /
    /


    am
    /


    e = 1.0/(b*t)
        ;


    oi


    if e))<(d
    u
    le)(
        1
        0) )


    e
        e

    i
    +m*
        Ma *

    a
        h.Si

    n
        (e)-

    i
        n

    c
        om c
        n

    e
        gr ar
        m

    )
    ;
    if( s<
        0
        )


    {
        p;
    }


    esu
        t
            = t

    e
        mp+np o2*e
        b

    ig
}


}
a
= 1.0
e
d
= 0;
)( a
h.A
bs (
c
/
a
)
)> c
i
eeps
il
{
    em
        lphi
            =
            l
    ph
    i
        + Mat
    h
        .A
        t

    a
        n
        (
            t
                *
                t

    em I;
        = )/Ma
        h
    P
        I);

    emp)/(
        .
    -tem
    p
        * t * t)
    ;


    c =
        .5 * (a -
              b);
    temp = Math.Sqrt(a * b);
    a = 0.5 * (a + b);
    b = temp;
    d = d + d;
    e = e + c * Math.Sin(lphi);
}
temp = ebig / ellipticintegralk(m, _params);
temp = temp * ((Math.Atan(t) + md * Math.PI) / (d * a));
temp = temp + e;
if (s < 0)
{
    temp = -temp;
}

result = temp + npio2 * ebig;
return result;
}
}
}