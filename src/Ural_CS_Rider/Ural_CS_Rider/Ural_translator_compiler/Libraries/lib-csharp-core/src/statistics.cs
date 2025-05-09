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
    Calculation of the distribution moments: mean, variance, skewness, kurtosis.

    INPUT PARAMETERS:
        X       -   sample
        N       -   N>=0, sample size:
                    * if given, only leading N elements of X are processed
                    * if not given, automatically determined from size of X

    OUTPUT PARAMETERS
        Mean    -   mean.
        Variance-   variance.
        Skewness-   skewness (if variance<>0; zero otherwise).
        Kurtosis-   kurtosis (if variance<>0; zero otherwise).

    NOTE: variance is calculated by dividing sum of squares by N-1, not N.

      -- ALGLIB --
         Copyright 06.09.2006 by Bochkanov Sergey
    *************************************************************************/
    public static void samplemoments(double[] x, int n, out double mean, out double variance, out double skewness,
        out double kurtosis)

    e
        n
            = vari

    n
        e
            = skew

    e
        s
            = kurt

    s
        s
            = base

    s
        tat.samplemom

    e
        n

    t
    (
        x
            n,
        ref
            m
            an,
        ref vari
            a

    ce,

    ref skew
        n

    ss,

    ref kurt
        o

    is,

    n
        ull);
}

public static void samplemoments(double[] x, int n, out double mean, out double variance, out double skewness,
    out double kurtosis, alglib.xparams _params)
{
    mean
        = 0;
    ianc


    0;
    skewnes


    0;
    kurtosi


    0;
    basesta
        .
        a
        mp s(x, n,
        r
    ef mean,  ref
        v
        a
    r
        a
    n
        e,
        ef s
        k
    wne
        s,  ref k
        u
    tos
        s, _para
    m
        );
}

public static void samplemoments(double[] x, out double mean, out double variance, out double skewness,
    out double kurtosis)
{
    int
    n
        mean
            = 0;
    ian
        e

    kewn
        s
            = kurto
    i
        = n = a
            .e
    n(base
    t
    t
        .s e
    t
    (x
        ,
        n,
        r
    e
        f f varian
    c
        e,  ref skewne
        s
    s
        ,
    r
        e
    ku
        tosi
    s
        nu
    l);


    retur
        n
}

public static void samplemoments(double[] x, out double mean, out double variance, out double skewness,
    out double kurtosis, alglib.xparams _params)

i
t n;


me
    n = 0;


v
    a
riance
0;

ske 0;
    = 0;


p.len(x)


stat.sam
    l
m
om n,  ref m
    a,
    r n
    e
r
    e
f s
k
    e
w
ne kurtosis,
    _params);


retu
    r
    ;

}

/*************************************************************************
Calculation of the mean.

INPUT PARAMETERS:
    X       -   sample
    N       -   N>=0, sample size:
                * if given, only leading N elements of X are processed
                * if not given, automatically determined from size of X

NOTE:

This function return result  which calculated by 'SampleMoments' function
and stored at 'Mean' variable.


  -- ALGLIB --
     Copyright 06.09.2006 by Bochkanov Sergey
*************************************************************************/
public static double samplemean(double[] x, int n)
{
    r
        e
    t
        u
    r
        n

    b
        a
    s
        e
    s
        t
    a
    t
        .
        s
        a
    m
        p
    l
        e
    m
        e
    a
    n
    (
        x
        ,
        n
        ,
        null);
}

public static double samplemean(double[] x, int n, alglib.xparams _params)


re tu rn b as es ta t.sa mp le me an(x, n
pa ra s);


}

public static double samplemean(double[] x)
{
    int n;
        = ap.en(x);


    doub
        l
    e

    eu lt = b
    a
        s
    aplemean(x,
            , null
        ;

    re
        t
    urn re
    s
    u
        t
        ;
}

public static double samplemean(double[] x, alglib.xparams _params)
{
    t
        n;
        = ap.le
        (x);
    doube result =
        asesta
            .sampl
    mean(x, n,
        _param
    s
        )


    ret
        rn resu
        lt;
}

/*************************************************************************
Calculation of the variance.

INPUT PARAMETERS:
    X       -   sample
    N       -   N>=0, sample size:
                * if given, only leading N elements of X are processed
                * if not given, automatically determined from size of X

NOTE:

This function return result  which calculated by 'SampleMoments' function
and stored at 'Variance' variable.


  -- ALGLIB --
     Copyright 06.09.2006 by Bochkanov Sergey
*************************************************************************/
public static double samplevariance(double[] x, int n)
{
    r
        e
    t
        u
    r
        n

    b
        a
    s
        e
    s
        t
    a
    t
        .
        s
        a
    m
        p
    l
        e
    v
        a
    r
        i
    a
        n

    c
        e
        (
            x
            ,
            n
            ,
            n
                u
                l
                l
        )
        ;
}

public static double samplevariance(double[] x, int n, alglib.xparams _params)

re tu rn
    es ta t.sa mp le va ri an ce(x, n, _ pa ra ms);
}

public static double samplevariance(double[] x)
{
    in
    t
        n;


    n =
        ap.len(
        );


    sult =
        sesta

    t
        .samplevarianc
        e
        (
            x
                n

    null);


    return
        result
}

public static double samplevariance(double[] x, alglib.xparams _params)
    ;


n = ap.len(x);

oubl
    e

t.sampl varian, _params);


re
urn result;


}

/*************************************************************************
Calculation of the skewness.

INPUT PARAMETERS:
    X       -   sample
    N       -   N>=0, sample size:
                * if given, only leading N elements of X are processed
                * if not given, automatically determined from size of X

NOTE:

This function return result  which calculated by 'SampleMoments' function
and stored at 'Skewness' variable.


  -- ALGLIB --
     Copyright 06.09.2006 by Bochkanov Sergey
*************************************************************************/
public static double sampleskewness(double[] x, int n)
{
    et
        rn basest
    t.sampleskew
        n
    e
        s
    s
    (
        x
        ,
        n
        ,
        n
    u
        l
    l
        )
    ;
}

public static double sampleskewness(double[] x, int n, alglib.xparams _params)
{
    return
        wne s(
        , n, _p r
    a
        ms);
}

public static double sampleskewness(double[] x)
{
    int n;


    n
        = ap.l
    e
    n(x);

    d
        ouble r
    leskew
        n, n
    ul )


    returnresult;
}

public static double sampleskewness(double[] x, alglib.xparams _params)
{
    i
        n


    ap.len


    do
        u
    t.samp
        eskewn
    e
        n _params);


    r
    turn result;
}

/*************************************************************************
Calculation of the kurtosis.

INPUT PARAMETERS:
    X       -   sample
    N       -   N>=0, sample size:
                * if given, only leading N elements of X are processed
                * if not given, automatically determined from size of X

NOTE:

This function return result  which calculated by 'SampleMoments' function
and stored at 'Kurtosis' variable.


  -- ALGLIB --
     Copyright 06.09.2006 by Bochkanov Sergey
*************************************************************************/
public static double samplekurtosis(double[] x, int n)
{
    ret
        rn

    basestat.
        amplekurtosi
        s
        (
            x
            ,
            n
            ,
            n
                u
                l
                l
        )
        ;
}

public static double samplekurtosis(double[] x, int n, alglib.xparams _params)
{
    r
        t
    urn bas
    osis x, , _param
    s)
}

public static double samplekurtosis(double[] x)
{
    int n;


    n
        = ap.l
    e
    n(x);

    d
        ouble r
        pl ku rto
        is (n null
        )
        ;


    return esult;
}

public static double samplekurtosis(double[] x, alglib.xparams _params)
{
    i
        n
    t
        a en(x);


    o
        u
    le re su l
    urtosi
    (x, n,
        _param);


    re
        urn re
        ult;
}

/*************************************************************************
ADev

Input parameters:
    X   -   sample
    N   -   N>=0, sample size:
            * if given, only leading N elements of X are processed
            * if not given, automatically determined from size of X

Output parameters:
    ADev-   ADev

  -- ALGLIB --
     Copyright 06.09.2006 by Bochkanov Sergey
*************************************************************************/
public static void sampleadev(double[] x, int n, out double adev)
{
    adev
        = 0;

    base
    tat.samplead
        e
    v
    (
        x
        ,
        n
        ,
        r
    e
        f

    a
        d
    e
        v,
        n
    u
        l
    l
        )
    ;
}

public static void sampleadev(double[] x, int n, out double adev, alglib.xparams _params)
{
    adev
        b s
        s

    t
        ev(x, n,
            r
                ef

    adev, _p ar am s) ;
}

public static void sampleadev(double[] x, out double adev)
{
    i
    n
        n;


    dev
        =
        0;


    n =
        ap.len(
            x);

    at.sm v(x, n, e,
            n
                u
                l
        )
        ;


    return
        ;
}

public static void sampleadev(double[] x, out double adev, alglib.xparams _params)

i nt n
    ;

a ev
        = 0
    ;


p.l
en(x);


b
    ses
at.s
    ap le ad ev x,
    rams);

return;
}

/*************************************************************************
Median calculation.

Input parameters:
    X   -   sample (array indexes: [0..N-1])
    N   -   N>=0, sample size:
            * if given, only leading N elements of X are processed
            * if not given, automatically determined from size of X

Output parameters:
    Median

  -- ALGLIB --
     Copyright 06.09.2006 by Bochkanov Sergey
*************************************************************************/
public static void samplemedian(double[] x, int n, out double median)
{
    edian = 0


    b
        se

    tat.sampl
        median(x, n,
            r
                e

    f
        m
    e
        d
    i
    a
        n,
        n
    u
        l
    l
        )
    ;
}

public static void samplemedian(double[] x, int n, out double median, alglib.xparams _params)
{
    med
        ian = 0;
    bases
    a
        .
        (x n, ref
            median _para
    m
        s
        )
}

public static void samplemedian(double[] x, out double median)
{
    nt
        ;


    media
        n
            = 0;


    n
        = ap.le
    n(x);

    esta t.s
        m
    l
    em n, re m dn, nul
    l
        )


    r
    e
        urn;
}

public static void samplemedian(double[] x, out double median, alglib.xparams _params)

n;
    = ;


n
    =
    x);


ba sestat.
    s
    a
m
    l
e
    edi
n(x, n
    ,
    ref me d


retun;
}

/*************************************************************************
Percentile calculation.

Input parameters:
    X   -   sample (array indexes: [0..N-1])
    N   -   N>=0, sample size:
            * if given, only leading N elements of X are processed
            * if not given, automatically determined from size of X
    P   -   percentile (0<=P<=1)

Output parameters:
    V   -   percentile

  -- ALGLIB --
     Copyright 01.03.2008 by Bochkanov Sergey
*************************************************************************/
public static void samplepercentile(double[] x, int n, double p, out double v)
    =

0;

tat.sampl
    perce
ntile
    x,
    n,
    p,
ref
    v ,  null);


}

public static void samplepercentile(double[] x, int n, double p, out double v, alglib.xparams _params)
{
    v

    0;


    b
        sestat
    s
        amplepe
    n
        p params);
}

public static void samplepercentile(double[] x, double p, out double v)
{
    i
        t
        ;


    v = 0


    n
        = ap.l
    n(x);


    e
        n
    t
        r f v, nu l) ;


    e
    t
        rn;
}

public static void samplepercentile(double[] x, double p, out double v, alglib.xparams _params)
{
    n
        =
        a.l

    e
        n
        (
            tt am

    percentil
    (
        x
    n,
    p
        ,
    ms );

    return;
}

/*************************************************************************
2-sample covariance

Input parameters:
    X       -   sample 1 (array indexes: [0..N-1])
    Y       -   sample 2 (array indexes: [0..N-1])
    N       -   N>=0, sample size:
                * if given, only N leading elements of X/Y are processed
                * if not given, automatically determined from input sizes

Result:
    covariance (zero for N=0 or N=1)

  -- ALGLIB --
     Copyright 28.10.2010 by Bochkanov Sergey
*************************************************************************/
public static double cov2(double[] x, double[] y, int n)


r estat.cov
(x, y
    , n,
    ul
);
}

public static double cov2(double[] x, double[] y, int n, alglib.xparams _params)
{
    re
        urn
    b
        asesta

    t
        .
        o
        v
        (x, y,
            n
                _
                ara
                s
        );
}

public static double cov2(double[] x, double[] y)
{
    int
        n;


    i
        f

    (
        p.len(
                x
            )
            =
            a
                .le
                (
                    y
                ))


    throw n
    ew algl
    or hil ca lling '  co v2 :
    lo k
    s
        i
    k
        n
    a gume ts
        has wrog size");


    n
    ap.l
    en(x);


    dou
        b
    l
        result = t.c
    v
    2(n
    u
        l
        );


    r
        e
    t
        u
    r
        n
}

public static double cov2(double[] x, double[] y, alglib.xparams _params)
{
    nt n
        ;

    e
        !=
        ap.l en
        (
            y
        )
        )
    thro w n
        lglibe
    c
    ption("E
    r
        ro w h
    i
        l
    e
        c
    a
        l
    i
        g 'c    v2    '
        :
    me nt s ha s w
    ong si
    ze");
        = ap.en(x);


    dou
        b
    l

    r
        sult =
            b
    s
        e
    tat.co
        v
    2(x, y,
        n, _par
    ams);

    e
    tu t;
}

/*************************************************************************
Pearson product-moment correlation coefficient

Input parameters:
    X       -   sample 1 (array indexes: [0..N-1])
    Y       -   sample 2 (array indexes: [0..N-1])
    N       -   N>=0, sample size:
                * if given, only N leading elements of X/Y are processed
                * if not given, automatically determined from input sizes

Result:
    Pearson product-moment correlation coefficient
    (zero for N=0 or N=1)

  -- ALGLIB --
     Copyright 28.10.2010 by Bochkanov Sergey
*************************************************************************/
public static double pearsoncorr2(double[] x, double[] y, int n)
{
    retu t
    at.p
        ars
    n
        c
    o
    r2
        x,
        y l)
}

public static double pearsoncorr2(double[] x, double[] y, int n, alglib.xparams _params)
{
    r
        e
    t
        u
    r
        n

    b
        a
    s
        e
    s
        t
    at.pearsonco
    r2(x,
        , n, _
    arams);
}

public static double pearsoncorr2(double[] x, double[] y)
{
    n


    plen(x) != ap.en(y))


    throw
        n
    ew alg
    l
        i
    e
        x
    eption
    (
        "
    r
        r
    r w
    i
        l
    calli
        n
    g 'pear
        oncorr2
    ': look
        ro ng s iz e"    )

    n
        =
        ap.len(x)


    o
        u
    le resul
    t

    sat.pearsonc
    rr2(x,
        y, n,
        ull);


    r
        e
    u
        r
    resul
        t
        ;
}

public static double pearsoncorr2(double[] x, double[] y, alglib.xparams _params)
{
    i t
        n;
    if ((a p
        le
    n(x) = ap.len(y)
        )
    n ew a
        glib
    ex
        h il c
    a
        lli
    n
        g
            '
            : lo ks
    like o n
        arg
    u
        ments has wro
    n
        g
    s z
    e
        )
    ;


    x) ;
    doubl e r
    asestat.pea
        soncor
    2(x, y
    n, _params)
    ;


    retu
        r
    n
        r
    e
        ult;
}

/*************************************************************************
Spearman's rank correlation coefficient

Input parameters:
    X       -   sample 1 (array indexes: [0..N-1])
    Y       -   sample 2 (array indexes: [0..N-1])
    N       -   N>=0, sample size:
                * if given, only N leading elements of X/Y are processed
                * if not given, automatically determined from input sizes

Result:
    Spearman's rank correlation coefficient
    (zero for N=0 or N=1)

  -- ALGLIB --
     Copyright 09.04.2007 by Bochkanov Sergey
*************************************************************************/
public static double spearmancorr2(double[] x, double[] y, int n)
{
    return bas
    es rmancorr
    2(
        , y,
        n, null);
}

public static double spearmancorr2(double[] x, double[] y, int n, alglib.xparams _params)
{
    r
        e
    t
        u
    r
        n

    b
        a
    s
        e
    s
        t
    a
    t
        .
        s
        p
    e
        a
    r
        m
    a
        n
    c
        o
    r
        r
    2
    (
        x
        ,
        y
        ,
        n
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

public static double spearmancorr2(double[] x, double[] y)
{
    if ((a
             .len(x) !=
         a
    p.len(y)))


    t
        h
    ow n
    e
        w
    bxception("E
    ror wh
    le cal
    ing 'spearman
        c
    orr2':

    l
        o
    k
        like
    o
        n

    o
        ar
    u
        m
    nts ha
    s
        wrong
    ize");


    d o
    e re su lt = b as es ta t.sp ea rm an co rr 2(x, y, n, n ul l);


    et ur n re su lt;
}

public static double spearmancorr2(double[] x, double[] y, alglib.xparams _params)
{
    int n;


    ap.l n(
    )) )
    thro
        w
    ne al
    lib xc
    ptio("E
    ro
        r while ca llin
    g
        ea ma nc r2':l oo k
        ke ne f ar ume
    ts ha wron
        ize
    ");
        );
    d
        u
    le resul
        t
            = basestat.s
    p
        e
    a
        m
    a
        c
    o
    r2(x
        ,
        s);


    reurn result;
}

/*************************************************************************
Covariance matrix

  ! COMMERCIAL EDITION OF ALGLIB:
  !
  ! Commercial Edition of ALGLIB includes following important improvements
  ! of this function:
  ! * high-performance native backend with same C# interface (C# version)
  ! * multithreading support (C++ and C# versions)
  ! * hardware vendor (Intel) implementations of linear algebra primitives
  !   (C++ and C# versions, x86/x64 platform)
  !
  ! We recommend you to read 'Working with commercial version' section  of
  ! ALGLIB Reference Manual in order to find out how to  use  performance-
  ! related features provided by commercial edition of ALGLIB.

INPUT PARAMETERS:
    X   -   array[N,M], sample matrix:
            * J-th column corresponds to J-th variable
            * I-th row corresponds to I-th observation
    N   -   N>=0, number of observations:
            * if given, only leading N rows of X are used
            * if not given, automatically determined from input size
    M   -   M>0, number of variables:
            * if given, only leading M columns of X are used
            * if not given, automatically determined from input size

OUTPUT PARAMETERS:
    C   -   array[M,M], covariance matrix (zero if N=0 or N=1)

  -- ALGLIB --
     Copyright 28.10.2010 by Bochkanov Sergey
*************************************************************************/
public static void covm(double[,] x, int n, int m, out double[,] c)
e
    d
ubl
        [0, 0]
    ;
bases
at.covm(x,
        n, m
    ref
, nul);
}

public static void covm(double[,] x, int n, int m, out double[,] c, alglib.xparams _params)
c =
    ew do
    uble[
            , 0
        ;

basestat.cov
    m
    (
        x
        ,
        n
        ,
        m
        ,
        r
            e

f
    c,
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

public static void covm(double[,] x, out double[,] c)
{
    i
    n
        n;


    int m
        ;
        = new o
    u
        b
    l
    e[0, n = ap
        .rows
        (
            x
        );

    m
        p
    cols
    (
        x);
    basesta
        .covm(
            , n,
            m, r
    e
    f c, n
    u
    l
        l
        ;


    r
        tur
        ;
}

public static void covm(double[,] x, out double[,] c, alglib.xparams _params)


i nt
    in t m;


wdouble[0, 0]


n
ap.r
ows(x)
    ;
    = ap.
    c
    o
l
(
    x);

co vm,
    _pa
am s
t
    r
    ;

}

/*************************************************************************
Pearson product-moment correlation matrix

  ! COMMERCIAL EDITION OF ALGLIB:
  !
  ! Commercial Edition of ALGLIB includes following important improvements
  ! of this function:
  ! * high-performance native backend with same C# interface (C# version)
  ! * multithreading support (C++ and C# versions)
  ! * hardware vendor (Intel) implementations of linear algebra primitives
  !   (C++ and C# versions, x86/x64 platform)
  !
  ! We recommend you to read 'Working with commercial version' section  of
  ! ALGLIB Reference Manual in order to find out how to  use  performance-
  ! related features provided by commercial edition of ALGLIB.

INPUT PARAMETERS:
    X   -   array[N,M], sample matrix:
            * J-th column corresponds to J-th variable
            * I-th row corresponds to I-th observation
    N   -   N>=0, number of observations:
            * if given, only leading N rows of X are used
            * if not given, automatically determined from input size
    M   -   M>0, number of variables:
            * if given, only leading M columns of X are used
            * if not given, automatically determined from input size

OUTPUT PARAMETERS:
    C   -   array[M,M], correlation matrix (zero if N=0 or N=1)

  -- ALGLIB --
     Copyright 28.10.2010 by Bochkanov Sergey
*************************************************************************/
public static void pearsoncorrm(double[,] x, int n, int m, out double[,] c)
{
    c = ne
    d
        u
    le[
            , 0];
        .
    ea
        son
    orrm(
        x
    n, m, ref c,
    null);
}

public static void pearsoncorrm(double[,] x, int n, int m, out double[,] c, alglib.xparams _params)
{
    c = le[0, 0];


    bas
        st

    t.pearson
        orrm(x, n, m
            ,
            r
                e

    f
        c,
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

public static void pearsoncorrm(double[,] x, out double[,] c)
{
    i
        t
        ;


    n
    t
        m;


    c = ne
    0
        ;
    n a
    p.o
        w
    s
        (x m = a
    p.ols x);

    b e
    s
        a
    t
        pea
    s
        on orrm
        (
            x
            , ref c, null
        ;


    return;
}

public static void pearsoncorrm(double[,] x, out double[,] c, alglib.xparams _params)
    in

n
    ;
int
    m
    ;


c
    ne w
    ub le[0, 0];

w(x);

m = a
    .col
        (x);


basest
    a
t
    .
    e
    a

son
    orrm(x
        ,
        n
            m, ref


}

/*************************************************************************
Spearman's rank correlation matrix

  ! COMMERCIAL EDITION OF ALGLIB:
  !
  ! Commercial Edition of ALGLIB includes following important improvements
  ! of this function:
  ! * high-performance native backend with same C# interface (C# version)
  ! * multithreading support (C++ and C# versions)
  ! * hardware vendor (Intel) implementations of linear algebra primitives
  !   (C++ and C# versions, x86/x64 platform)
  !
  ! We recommend you to read 'Working with commercial version' section  of
  ! ALGLIB Reference Manual in order to find out how to  use  performance-
  ! related features provided by commercial edition of ALGLIB.

INPUT PARAMETERS:
    X   -   array[N,M], sample matrix:
            * J-th column corresponds to J-th variable
            * I-th row corresponds to I-th observation
    N   -   N>=0, number of observations:
            * if given, only leading N rows of X are used
            * if not given, automatically determined from input size
    M   -   M>0, number of variables:
            * if given, only leading M columns of X are used
            * if not given, automatically determined from input size

OUTPUT PARAMETERS:
    C   -   array[M,M], correlation matrix (zero if N=0 or N=1)

  -- ALGLIB --
     Copyright 28.10.2010 by Bochkanov Sergey
*************************************************************************/
public static void spearmancorrm(double[,] x, int n, int m, out double[,] c)
{
    0
    0]


    ba
    estat.s
        e
    rmancor
    m(
        ,
        n,
        , ref c, null);
}

public static void spearmancorrm(double[,] x, int n, int m, out double[,] c, alglib.xparams _params)
{
    c

    new
        ou
    l
    e
        [
            , 0
        ;


    se
    tat.sp
        arm, n, m, r
    f c,
        _para
    s)
}

public static void spearmancorrm(double[,] x, out double[,] c)
{
    int n
        in
    m;


    c =
        n
    e
        d
    ubl
    [
        0
    0];


    n = a
    p
        .
        r
        w
    s(x);


    p
    col
        (x);


    arm ncorr
    m
    (x n m, ref,
        n ll;


    ret
    u
        rn;
}

public static void spearmancorrm(double[,] x, out double[,] c, alglib.xparams _params)
{
    n
        i t m;


    w dou
    le[0, 0]
    n = ap.rows(x;

    m a
    x);
    b
        sestat

    spea
        mancorrm(x, n
            ,
            m, re
                f
                c
                _
                ara
                s);


    return;
}

/*************************************************************************
Cross-covariance matrix

  ! COMMERCIAL EDITION OF ALGLIB:
  !
  ! Commercial Edition of ALGLIB includes following important improvements
  ! of this function:
  ! * high-performance native backend with same C# interface (C# version)
  ! * multithreading support (C++ and C# versions)
  ! * hardware vendor (Intel) implementations of linear algebra primitives
  !   (C++ and C# versions, x86/x64 platform)
  !
  ! We recommend you to read 'Working with commercial version' section  of
  ! ALGLIB Reference Manual in order to find out how to  use  performance-
  ! related features provided by commercial edition of ALGLIB.

INPUT PARAMETERS:
    X   -   array[N,M1], sample matrix:
            * J-th column corresponds to J-th variable
            * I-th row corresponds to I-th observation
    Y   -   array[N,M2], sample matrix:
            * J-th column corresponds to J-th variable
            * I-th row corresponds to I-th observation
    N   -   N>=0, number of observations:
            * if given, only leading N rows of X/Y are used
            * if not given, automatically determined from input sizes
    M1  -   M1>0, number of variables in X:
            * if given, only leading M1 columns of X are used
            * if not given, automatically determined from input size
    M2  -   M2>0, number of variables in Y:
            * if given, only leading M1 columns of X are used
            * if not given, automatically determined from input size

OUTPUT PARAMETERS:
    C   -   array[M1,M2], cross-covariance matrix (zero if N=0 or N=1)

  -- ALGLIB --
     Copyright 28.10.2010 by Bochkanov Sergey
*************************************************************************/
public static void covm2(double[,] x, double[,] y, int n, int m1, int m2, out double[,] c)
{
    c = new
    do
        b
            le a
        es
    at.co
        v
    2(x,
        y, n, m
        ,
        2, ref
        ,
        u
    l);
}

public static void covm2(double[,] x, double[,] y, int n, int m1, int m2, out double[,] c, alglib.xparams _params)
{
    c =
        ew dou
        l
    e[0,
    ];


    b
        a

    ss vm
    (x, y,
        n, ef c, _pa
            ams);
}

public static void covm2(double[,] x, double[,] y, out double[,] c)
{
    int n;

    i
        t m1


    int
        m
    2


    i
    f
    (
        (
            a
                .ro
    s
        (
        ) !=
        p.r
    ws(
        ))
        )


    t
        r
    ow new
        t
    o
        ("Er    or     hi    le

    c
        a
    l
    l
        in ': ook l
    i
        ke on
        o
    f
        a g
        u
    e
        n
    s a
    r
        o
    g s
    "


    nw double[0,
        ];
        = ap
        .rows(x
        )
        ;


    m1
        =
        p
            .ols
    x
        )


    m2
        =
        a
            .co
    s(y);


    bases
        t
    at.covm
    (x, y,
        n, m1,
        n
    l
        r t
        urn;
}

public static void covm2(double[,] x, double[,] y, out double[,] c, alglib.xparams _params)
{
    in
    n;


    int m1
        ;


    p.o
    s(
    )))

    ew a lg ib ex e
    pti n("E    r
    or h
    il e al
        li g
    '  c
        on o f
    rgu
        as wr n
        g size");

    c = n ew
    ouble[0
        ,
    ];

    n
        = a.ro ws x);
    m
        = p.co s
        x)


    p
    col
        (y);


    2
    x, y, n,
    m
    1, m 2
    am


    et urn;
}

/*************************************************************************
Pearson product-moment cross-correlation matrix

  ! COMMERCIAL EDITION OF ALGLIB:
  !
  ! Commercial Edition of ALGLIB includes following important improvements
  ! of this function:
  ! * high-performance native backend with same C# interface (C# version)
  ! * multithreading support (C++ and C# versions)
  ! * hardware vendor (Intel) implementations of linear algebra primitives
  !   (C++ and C# versions, x86/x64 platform)
  !
  ! We recommend you to read 'Working with commercial version' section  of
  ! ALGLIB Reference Manual in order to find out how to  use  performance-
  ! related features provided by commercial edition of ALGLIB.

INPUT PARAMETERS:
    X   -   array[N,M1], sample matrix:
            * J-th column corresponds to J-th variable
            * I-th row corresponds to I-th observation
    Y   -   array[N,M2], sample matrix:
            * J-th column corresponds to J-th variable
            * I-th row corresponds to I-th observation
    N   -   N>=0, number of observations:
            * if given, only leading N rows of X/Y are used
            * if not given, automatically determined from input sizes
    M1  -   M1>0, number of variables in X:
            * if given, only leading M1 columns of X are used
            * if not given, automatically determined from input size
    M2  -   M2>0, number of variables in Y:
            * if given, only leading M1 columns of X are used
            * if not given, automatically determined from input size

OUTPUT PARAMETERS:
    C   -   array[M1,M2], cross-correlation matrix (zero if N=0 or N=1)

  -- ALGLIB --
     Copyright 28.10.2010 by Bochkanov Sergey
*************************************************************************/
public static void pearsoncorrm2(double[,] x, double[,] y, int n, int m1, int m2, out double[,] c)
{
    c =
        ew double[
        , 0];

    bas ar
    n
        rm
    2
    (
        x
    y, n,
    m1
        m2,  ref
        ,
    u
        ll);
}

public static void pearsoncorrm2(double[,] x, double[,] y, int n, int m1, int m2, out double[,] c,
    alglib.xparams _params)
{
    c = ne
    w ,


    b
        as
        e
    st
        a
    t
        pears
    o
    ncorrm2(x,
        , n, m
        ,
        m2,
        re

    c
        ,
    _p
        r
    a
        m
    s);
}

public static void pearsoncorrm2(double[,] x, double[,] y, out double[,] c)
{
    i
        n
    t
        n
        ;


    i
        n
    t
        m
    1
        ;


    i
    nt m2;

    if (
        ap.r
    ws(x) != ap.row
    s
        (y)))


    t
        h
    r
        o

    n
        w a
        g
    l
        bex
    ep
        t
    on(
        Er
    r
        r w
        ile ca
        l
    l
        i
    g
    'pearso :
    l
        s
    ike on
    e f

    a
        r
    wrong s
    i
        ze");            c     =     n    ew    o
    u
        l
    e[, 0]
        = 
        .r ow
    s
        (x);
    m1 = a
        .cols(
        );

    m2 = ap
            .cols(y
            )
        ;


    ba
        s
    e
        s
    a
        t
    pea
        s
    o
        cor
    m2
    (
        , y
    n
        ,
    m1,
    m2, re
        f

    c
        n
    ll);


    retu
        rn;
}

public static void pearsoncorrm2(double[,] x, double[,] y, out double[,] c, alglib.xparams _params)

{
    int
        n;


    nt m1;


    int m
    2
        ;


    if
    (
        (
            p
                .ows
    x)!=ap
        .
        r
        o
    s
        (y)))

    w al g
        ex c
        c al l
    '  pe a
    li ke
    on
        e
    nt
        s
    s
        w
    ro g
    s
        i
    z
        e"
        );


    c
        =
        ap r
        ws x) ;
    m 1 a
    p.ols(x;

    m2 = a p.ol(y);
    ba
        se ta.
        rso
        cor r
    2(
        y,, m1, m2,
        ef c,
        _par


    re ur n
        ;
}

/*************************************************************************
Spearman's rank cross-correlation matrix

  ! COMMERCIAL EDITION OF ALGLIB:
  !
  ! Commercial Edition of ALGLIB includes following important improvements
  ! of this function:
  ! * high-performance native backend with same C# interface (C# version)
  ! * multithreading support (C++ and C# versions)
  ! * hardware vendor (Intel) implementations of linear algebra primitives
  !   (C++ and C# versions, x86/x64 platform)
  !
  ! We recommend you to read 'Working with commercial version' section  of
  ! ALGLIB Reference Manual in order to find out how to  use  performance-
  ! related features provided by commercial edition of ALGLIB.

INPUT PARAMETERS:
    X   -   array[N,M1], sample matrix:
            * J-th column corresponds to J-th variable
            * I-th row corresponds to I-th observation
    Y   -   array[N,M2], sample matrix:
            * J-th column corresponds to J-th variable
            * I-th row corresponds to I-th observation
    N   -   N>=0, number of observations:
            * if given, only leading N rows of X/Y are used
            * if not given, automatically determined from input sizes
    M1  -   M1>0, number of variables in X:
            * if given, only leading M1 columns of X are used
            * if not given, automatically determined from input size
    M2  -   M2>0, number of variables in Y:
            * if given, only leading M1 columns of X are used
            * if not given, automatically determined from input size

OUTPUT PARAMETERS:
    C   -   array[M1,M2], cross-correlation matrix (zero if N=0 or N=1)

  -- ALGLIB --
     Copyright 28.10.2010 by Bochkanov Sergey
*************************************************************************/
public static void spearmancorrm2(double[,] x, double[,] y, int n, int m1, int m2, out double[,] c)
    =

n
    e
doubl
    [0
0];


a
    se r
2(
    , y,
    n
m1,
m2, ref
c,
null);


}

public static void spearmancorrm2(double[,] x, double[,] y, int n, int m1, int m2, out double[,] c,
        alglib.xparams _params)
    =
new d
    o
ble[
    , 0];


bases
    at
s
    ear
ancor
2,
    ref
c, _p
    a
ams);
}

public static void spearmancorrm2(double[,] x, double[,] y, out double[,] c)
{
    i
        nt n
        n
    t
        m;

    int m2
    (ap.rows
        x)!=

    a
    p.row
    (y
    ))

    throw n
    e
        w

    a
        l
    g
        l
    i
        b
    e
        x
    c
        e
    p
        t
    i
        o
    n
    (
        "
    E
        r
    r
        o
    r
        w
    h
        i
    l
        e

    c
        a
    l
        l
    i
        n
    g
        '
    s
        p
    e
        a
    r
        m
    a
        n
    c
        o
    r
        r
    m
    2
        '
        :

    l
        o
    o
        k
    s
        l
    i
        k
    e
        o
    n
        e
    of argument
    has w
    ong
        ize");


    c = ne
    w
        d
    u
        b
    e[0, 0]
        ;
        =
    ap.
        ow
        s
    x);


    m1 = a
    p
        .
        c
        l
    s
        co ls );

    b
        a
    s
        an corrm2
    (
        x, y, n, m1, 2
        , e

    c nu );


    r turn
        ;
}

public static void spearmancorrm2(double[,] x, double[,] y, out double[,] c, alglib.xparams _params)
{
    nt m;


    i((p.ows() != ap.ro
    w
    s
        (
        )
        )


    thro
        n
    w a lg ibe
    x
        ception"Error whil
    calli
        g 's
    earmancorrm2':

    looks
        l
    i
        k

    o
        e of a
    r
        g
    u
        e
    n
        s h
        s wron
        g

    s
        z
    e");

    ew d
    u
        n
    p.
        r


    s(
            x
        ;


    m
    2
        =
        a p
        .
        cols y
        );

    .spea
        ma nc o
    2(x, y, n, m 1, m 2, r ef c, _p ar am s);


    r et ur n
}

/*************************************************************************
This function replaces data in XY by their ranks:
* XY is processed row-by-row
* rows are processed separately
* tied data are correctly handled (tied ranks are calculated)
* ranking starts from 0, ends at NFeatures-1
* sum of within-row values is equal to (NFeatures-1)*NFeatures/2

  ! COMMERCIAL EDITION OF ALGLIB:
  !
  ! Commercial Edition of ALGLIB includes following important improvements
  ! of this function:
  ! * high-performance native backend with same C# interface (C# version)
  ! * multithreading support (C++ and C# versions)
  !
  ! We recommend you to read 'Working with commercial version' section  of
  ! ALGLIB Reference Manual in order to find out how to  use  performance-
  ! related features provided by commercial edition of ALGLIB.

INPUT PARAMETERS:
    XY      -   array[NPoints,NFeatures], dataset
    NPoints -   number of points
    NFeatures-  number of features

OUTPUT PARAMETERS:
    XY      -   data are replaced by their within-row ranks;
                ranking starts from 0, ends at NFeatures-1

  -- ALGLIB --
     Copyright 18.04.2013 by Bochkanov Sergey
*************************************************************************/
public static void rankdata(ref double[,] xy, int npoints, int nfeatures)
{
    b
        a
    estat.r
    an x,
        npoints,
        nfeat
    res, nu
        l
        )
    ;
}

public static void rankdata(ref double[,] xy, int npoints, int nfeatures, alglib.xparams _params)
{
    base

    ta
        .rank
        at
        (xy,
            npo
                nts

    n
    atu
        s, _params)
    ;
}

public static void rankdata(ref double[,] xy)
{
    int n
    po
        t
    eatur
    e
        s;


    npoints ws(xy);

    nf
    at
        res = a y);


    basest
    t.ankdata(y, npoints,
        nfeatures,
        n

    etur
        ;
}

public static void rankdata(ref double[,] xy, alglib.xparams _params)
{
    nt
        npoint
        ;
    t nfeatur
        s;


    np
        ints = ap.ro

    w
        s
        (
            x
                y
        )
        ;


    n
        f
    e
        a
    t
        u
    r
    e
        s
            =
            a
    p
        .
        c
        o

    l
        s
        (
            x
                y
        )
        ;


    b
        a
    s
        e
    s
        t
    a
    t
        .
        r
        a
    n
        k
    d
        a

    t
        a
        (
            x
                y
            ,
            n
                points, nfea
                ures,
            para
                s);


    re
        t
    u
        r
        ;
}

/*************************************************************************
This function replaces data in XY by their CENTERED ranks:
* XY is processed row-by-row
* rows are processed separately
* tied data are correctly handled (tied ranks are calculated)
* centered ranks are just usual ranks, but centered in such way  that  sum
  of within-row values is equal to 0.0.
* centering is performed by subtracting mean from each row, i.e it changes
  mean value, but does NOT change higher moments

  ! COMMERCIAL EDITION OF ALGLIB:
  !
  ! Commercial Edition of ALGLIB includes following important improvements
  ! of this function:
  ! * high-performance native backend with same C# interface (C# version)
  ! * multithreading support (C++ and C# versions)
  !
  ! We recommend you to read 'Working with commercial version' section  of
  ! ALGLIB Reference Manual in order to find out how to  use  performance-
  ! related features provided by commercial edition of ALGLIB.

INPUT PARAMETERS:
    XY      -   array[NPoints,NFeatures], dataset
    NPoints -   number of points
    NFeatures-  number of features

OUTPUT PARAMETERS:
    XY      -   data are replaced by their within-row ranks;
                ranking starts from 0, ends at NFeatures-1

  -- ALGLIB --
     Copyright 18.04.2013 by Bochkanov Sergey
*************************************************************************/
public static void rankdatacentered(ref double[,] xy, int npoints, int nfeatures)
{
    basestat.rank n

    er
        d(xy
                npoints
            , r
                s
                nul
                l
        );
}

public static void rankdatacentered(ref double[,] xy, int npoints, int nfeatures, alglib.xparams _params)


bas
sta
    .r
    nkda
acentered(xy, npoints, nfeatures,
    _params

}

public static void rankdatacentered(ref double[,] xy)

int n
    oints;
    in
n
    eatures;


n
    pints = ap.ows(xy);

at
    cols(
        x
            y);


bases
    t

a
    .rankdat d(xy, n
        o

s, nfe
tu
    es, nul

r
    urn;

}

public static void rankdatacentered(ref double[,] xy, alglib.xparams _params)
nts;

i
    t nf
    a
t
    res;


nt
    = ap.ows nfea
    ures
        = ap.ol
            (xy);

basestat
    .
    r
    a
n
    k
d
    a
t
    a
c
    e
n
    t
e
    r

e
    d
    (
        x
            y
        ,
        n
            p

o
    i
n
t
    s,
    n
f
    e
a
    t
u
    r
e
    s,
    _
p
    a
r
    a
m
    s
    )
;


r
    e
t
    u
r
    n
    ;

}

/*************************************************************************
Obsolete function, we recommend to use PearsonCorr2().

  -- ALGLIB --
     Copyright 09.04.2007 by Bochkanov Sergey
*************************************************************************/
public static double pearsoncorrelation(double[] x, double[] y, int n)


return
    base
tat.pearsoncorre
    l

ati
    n(x, y
        ,
        n
            n
            ull);
}

public static double pearsoncorrelation(double[] x, double[] y, int n, alglib.xparams _params)
{
    stat.p ea rs n
    correlation(x, y
        ,
        n
        ,
        _p ra;
}

/*************************************************************************
Obsolete function, we recommend to use SpearmanCorr2().

    -- ALGLIB --
    Copyright 09.04.2007 by Bochkanov Sergey
*************************************************************************/
public static double spearmanrankcorrelation(double[] x, double[] y, int n)

n ba se st at.s parmanrnkcorrelation(x, y, n, null);
}

public static double spearmanrankcorrelation(double[] x, double[] y, int n, alglib.xparams _params)
{
    rn basest
    t.spe
        arman
    an
        correlati
    n(x, y, n, _
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
    Pearson's correlation coefficient significance test

    This test checks hypotheses about whether X  and  Y  are  samples  of  two
    continuous  distributions  having  zero  correlation  or   whether   their
    correlation is non-zero.

    The following tests are performed:
        * two-tailed test (null hypothesis - X and Y have zero correlation)
        * left-tailed test (null hypothesis - the correlation  coefficient  is
          greater than or equal to 0)
        * right-tailed test (null hypothesis - the correlation coefficient  is
          less than or equal to 0).

    Requirements:
        * the number of elements in each sample is not less than 5
        * normality of distributions of X and Y.

    Input parameters:
        R   -   Pearson's correlation coefficient for X and Y
        N   -   number of elements in samples, N>=5.

    Output parameters:
        BothTails   -   p-value for two-tailed test.
                        If BothTails is less than the given significance level
                        the null hypothesis is rejected.
        LeftTail    -   p-value for left-tailed test.
                        If LeftTail is less than the given significance level,
                        the null hypothesis is rejected.
        RightTail   -   p-value for right-tailed test.
                        If RightTail is less than the given significance level
                        the null hypothesis is rejected.

      -- ALGLIB --
         Copyright 09.04.2007 by Bochkanov Sergey
    *************************************************************************/
    public static void pearsoncorrelationsignificance(double r, int n, out double bothtails, out double lefttail,
        out double righttail)
    {
        bothtails
        0


        lefttail =
            0;

        r
            ;
        c
            or
        elationtest
            .pearsoncor
            ela
        i
            nsi
        ni r,
            f both
        ai
            s,  ref l
            ft
        ail, re
            f
        r
            ig
        h
            tail,  null);
    }

    public static void pearsoncorrelationsignificance(double r, int n, out double bothtails, out double lefttail,
        out double righttail, alglib.xparams _params)
    {
        bo
        ht
            ils = 0;

        efttail
            ri
        htt
            il =
                0;


        co rr
        lationsi
            ni

        ican
            e(r,
                n,
                ef bo

        htails, ref
        eftta
            il );
    }

    /*************************************************************************
    Spearman's rank correlation coefficient significance test

    This test checks hypotheses about whether X  and  Y  are  samples  of  two
    continuous  distributions  having  zero  correlation  or   whether   their
    correlation is non-zero.

    The following tests are performed:
        * two-tailed test (null hypothesis - X and Y have zero correlation)
        * left-tailed test (null hypothesis - the correlation  coefficient  is
          greater than or equal to 0)
        * right-tailed test (null hypothesis - the correlation coefficient  is
          less than or equal to 0).

    Requirements:
        * the number of elements in each sample is not less than 5.

    The test is non-parametric and doesn't require distributions X and Y to be
    normal.

    Input parameters:
        R   -   Spearman's rank correlation coefficient for X and Y
        N   -   number of elements in samples, N>=5.

    Output parameters:
        BothTails   -   p-value for two-tailed test.
                        If BothTails is less than the given significance level
                        the null hypothesis is rejected.
        LeftTail    -   p-value for left-tailed test.
                        If LeftTail is less than the given significance level,
                        the null hypothesis is rejected.
        RightTail   -   p-value for right-tailed test.
                        If RightTail is less than the given significance level
                        the null hypothesis is rejected.

      -- ALGLIB --
         Copyright 09.04.2007 by Bochkanov Sergey
    *************************************************************************/
    public static void spearmanrankcorrelationsignificance(double r, int n, out double bothtails, out double lefttail,
        out double righttail)
    {
        b
        thtai
            ls
                = 0;

        lefttail
            =
            0;


        righttail = 
            ;

        orrelation
            te r
            r
        correlat
            io
        sign
        ficance(r,
            , ref botht
        ils
            ef
        ef e
        i
            tail,
            ul
            );
    }

    public static void spearmanrankcorrelationsignificance(double r, int n, out double bothtails, out double lefttail,
        out double righttail, alglib.xparams _params)


    lefttail =
    0;

    ri = 0;


    r
        e

    latio
        tes

    s.sp
        e

    armanr
        nkco

    rr ,
    ef botht
    il
    , re
        lef

    tai
    , ref
        righttail, _
        arams

    );
}

}

public partial class alglib
{
    /*************************************************************************
    Jarque-Bera test

    This test checks hypotheses about the fact that a  given  sample  X  is  a
    sample of normal random variable.

    Requirements:
        * the number of elements in the sample is not less than 5.

    Input parameters:
        X   -   sample. Array whose index goes from 0 to N-1.
        N   -   size of the sample. N>=5

    Output parameters:
        P           -   p-value for the test

    Accuracy of the approximation used (5<=N<=1951):

    p-value  	    relative error (5<=N<=1951)
    [1, 0.1]            < 1%
    [0.1, 0.01]         < 2%
    [0.01, 0.001]       < 6%
    [0.001, 0]          wasn't measured

    For N>1951 accuracy wasn't measured but it shouldn't be sharply  different
    from table values.

      -- ALGLIB --
         Copyright 09.04.2007 by Bochkanov Sergey
    *************************************************************************/
    public static void jarqueberatest(double[] x, int n, out double p)
    {
        p

        0

        jarqub er a.jarq
            eberate
        t(x,
            , ref p, ull);
    }

    public static void jarqueberatest(double[] x, int n, out double p, alglib.xparams _params)
    {
        p = 0;


        ja
            queb
        ra.j
            r

        ebera
            st(x,
                f
                    _params);
    }
}

public partial class alglib
{
    /*************************************************************************
    Two-sample F-test

    This test checks three hypotheses about dispersions of the given  samples.
    The following tests are performed:
        * two-tailed test (null hypothesis - the dispersions are equal)
        * left-tailed test (null hypothesis  -  the  dispersion  of  the first
          sample is greater than or equal to  the  dispersion  of  the  second
          sample).
        * right-tailed test (null hypothesis - the  dispersion  of  the  first
          sample is less than or equal to the dispersion of the second sample)

    The test is based on the following assumptions:
        * the given samples have normal distributions
        * the samples are independent.

    Input parameters:
        X   -   sample 1. Array whose index goes from 0 to N-1.
        N   -   sample size.
        Y   -   sample 2. Array whose index goes from 0 to M-1.
        M   -   sample size.

    Output parameters:
        BothTails   -   p-value for two-tailed test.
                        If BothTails is less than the given significance level
                        the null hypothesis is rejected.
        LeftTail    -   p-value for left-tailed test.
                        If LeftTail is less than the given significance level,
                        the null hypothesis is rejected.
        RightTail   -   p-value for right-tailed test.
                        If RightTail is less than the given significance level
                        the null hypothesis is rejected.

      -- ALGLIB --
         Copyright 19.09.2006 by Bochkanov Sergey
    *************************************************************************/
    public static void ftest(double[] x, int n, double[] y, int m, out double bothtails, out double lefttail,
        out double righttail)
    {
        o
        hta
            ls = 0;

        lefttai
            l = 0;

        righttai
            l

        iancet
            s
        t
            .ftes
                (x, n
        y, m
            ref
        both
            a
        ls
            r
        e
            f,
            f
        ghttai
            , nu
            ll);
    }

    public static void ftest(double[] x, int n, double[] y, int m, out double bothtails, out double lefttail,
            out double righttail, alglib.xparams _params)
        =
        ;

    le
        ttai
            = 0


    ighttail = 0
    , n
        y,
        , ref both
        ai

    s, ref l
        ef ef right,
        a

    r
        ams);
}

/*************************************************************************
One-sample chi-square test

This test checks three hypotheses about the dispersion of the given sample
The following tests are performed:
    * two-tailed test (null hypothesis - the dispersion equals  the  given
      number)
    * left-tailed test (null hypothesis - the dispersion is  greater  than
      or equal to the given number)
    * right-tailed test (null hypothesis  -  dispersion is  less  than  or
      equal to the given number).

Test is based on the following assumptions:
    * the given sample has a normal distribution.

Input parameters:
    X           -   sample 1. Array whose index goes from 0 to N-1.
    N           -   size of the sample.
    Variance    -   dispersion value to compare with.

Output parameters:
    BothTails   -   p-value for two-tailed test.
                    If BothTails is less than the given significance level
                    the null hypothesis is rejected.
    LeftTail    -   p-value for left-tailed test.
                    If LeftTail is less than the given significance level,
                    the null hypothesis is rejected.
    RightTail   -   p-value for right-tailed test.
                    If RightTail is less than the given significance level
                    the null hypothesis is rejected.

  -- ALGLIB --
     Copyright 19.09.2006 by Bochkanov Sergey
*************************************************************************/
public static void onesamplevariancetest(double[] x, int n, double variance, out double bothtails,
    out double lefttail, out double righttail)
{
    t
    tai
        s = 0


    l
    f
        tail =
            0;
    r
        ihttail = 0

    v
        ar t
        v
    ancete
        t
    (
        , n,
    arian
        e, re
    bot
        tail,
        re

    l
        e
    ft f

    l);
}

public static void onesamplevariancetest(double[] x, int n, double variance, out double bothtails,
    out double lefttail, out double righttail, alglib.xparams _params)
{
    otht
        ils
            = 0;

    leftt
        il = 0


    variancete
        ts
    onesampl
        ev est(x, n
    r
    c
        e,  ref
        bot
        tail
    s
        , ref
    eftt
        ai s)
}
}

public partial class alglib
{
    /*************************************************************************
    Wilcoxon signed-rank test

    This test checks three hypotheses about the median  of  the  given sample.
    The following tests are performed:
        * two-tailed test (null hypothesis - the median is equal to the  given
          value)
        * left-tailed test (null hypothesis - the median is  greater  than  or
          equal to the given value)
        * right-tailed test (null hypothesis  -  the  median  is  less than or
          equal to the given value)

    Requirements:
        * the scale of measurement should be ordinal, interval or  ratio (i.e.
          the test could not be applied to nominal variables).
        * the distribution should be continuous and symmetric relative to  its
          median.
        * number of distinct values in the X array should be greater than 4

    The test is non-parametric and doesn't require distribution X to be normal

    Input parameters:
        X       -   sample. Array whose index goes from 0 to N-1.
        N       -   size of the sample.
        Median  -   assumed median value.

    Output parameters:
        BothTails   -   p-value for two-tailed test.
                        If BothTails is less than the given significance level
                        the null hypothesis is rejected.
        LeftTail    -   p-value for left-tailed test.
                        If LeftTail is less than the given significance level,
                        the null hypothesis is rejected.
        RightTail   -   p-value for right-tailed test.
                        If RightTail is less than the given significance level
                        the null hypothesis is rejected.

    To calculate p-values, special approximation is used. This method lets  us
    calculate p-values with two decimal places in interval [0.0001, 1].

    "Two decimal places" does not sound very impressive, but in  practice  the
    relative error of less than 1% is enough to make a decision.

    There is no approximation outside the [0.0001, 1] interval. Therefore,  if
    the significance level outlies this interval, the test returns 0.0001.

      -- ALGLIB --
         Copyright 08.09.2006 by Bochkanov Sergey
    *************************************************************************/
    public static void wilcoxonsignedranktest(double[] x, int n, double e, out double bothtails, out double lefttail,
        out double righttail)
    {
        eft
            ail
        0;

        r
            ghttail
                = wsr.w
        x
            i
        g
            nedra

        kte
            t(x,
                n, e,
                ef b
                    ot f
                    ighttail
                    n
                    ll);
    }

    public static void wilcoxonsignedranktest(double[] x, int n, double e, out double bothtails, out double lefttail,
        out double righttail, alglib.xparams _params)
    {
        bo
        htai
            s =
                0;

        lefttai
            = 0;

        w
        r.wilcoxon
            ig
        edrankte
        s(x, n,
            , ref bot
        t
        a
            ils, r
        e
        leftta
            l,  ref rightt
            il
        _pa
            r
        ms);
    }
}

public partial class alglib
{
    /*************************************************************************
    Mann-Whitney U-test

    This test checks hypotheses about whether X  and  Y  are  samples  of  two
    continuous distributions of the same shape  and  same  median  or  whether
    their medians are different.

    The following tests are performed:
        * two-tailed test (null hypothesis - the medians are equal)
        * left-tailed test (null hypothesis - the median of the  first  sample
          is greater than or equal to the median of the second sample)
        * right-tailed test (null hypothesis - the median of the first  sample
          is less than or equal to the median of the second sample).

    Requirements:
        * the samples are independent
        * X and Y are continuous distributions (or discrete distributions well-
          approximating continuous distributions)
        * distributions of X and Y have the  same  shape.  The  only  possible
          difference is their position (i.e. the value of the median)
        * the number of elements in each sample is not less than 5
        * the scale of measurement should be ordinal, interval or ratio  (i.e.
          the test could not be applied to nominal variables).

    The test is non-parametric and doesn't require distributions to be normal.

    Input parameters:
        X   -   sample 1. Array whose index goes from 0 to N-1.
        N   -   size of the sample. N>=5
        Y   -   sample 2. Array whose index goes from 0 to M-1.
        M   -   size of the sample. M>=5

    Output parameters:
        BothTails   -   p-value for two-tailed test.
                        If BothTails is less than the given significance level
                        the null hypothesis is rejected.
        LeftTail    -   p-value for left-tailed test.
                        If LeftTail is less than the given significance level,
                        the null hypothesis is rejected.
        RightTail   -   p-value for right-tailed test.
                        If RightTail is less than the given significance level
                        the null hypothesis is rejected.

    To calculate p-values, special approximation is used. This method lets  us
    calculate p-values with satisfactory  accuracy  in  interval  [0.0001, 1].
    There is no approximation outside the [0.0001, 1] interval. Therefore,  if
    the significance level outlies this interval, the test returns 0.0001.

    Relative precision of approximation of p-value:

    N          M          Max.err.   Rms.err.
    5..10      N..10      1.4e-02    6.0e-04
    5..10      N..100     2.2e-02    5.3e-06
    10..15     N..15      1.0e-02    3.2e-04
    10..15     N..100     1.0e-02    2.2e-05
    15..100    N..100     6.1e-03    2.7e-06

    For N,M>100 accuracy checks weren't put into  practice,  but  taking  into
    account characteristics of asymptotic approximation used, precision should
    not be sharply different from the values for interval [5, 100].

    NOTE: P-value approximation was  optimized  for  0.0001<=p<=0.2500.  Thus,
          P's outside of this interval are enforced to these bounds. Say,  you
          may quite often get P equal to exactly 0.25 or 0.0001.

      -- ALGLIB --
         Copyright 09.04.2007 by Bochkanov Sergey
    *************************************************************************/
    public static void mannwhitneyutest(double[] x, int n, double[] y, int m, out double bothtails, out double lefttail,
        out double righttail)
    {
        bo
        ht
            il
                = 0;

        lefttai
            = 
            ;


        r
            ghttail
                =
                0;


        annwhitney
            .mannwhitney
        test(
            , n, y,
            m, r
        f bothta
        i
            s,
            ef l
            fttail, 
        ref ri
            gttail,  null);
    }

    public static void mannwhitneyutest(double[] x, int n, double[] y, int m, out double bothtails, out double lefttail,
        out double righttail, alglib.xparams _params)
    {
        bo
            th
                = 0;

        lefttail = 0
            ;


        ri
            ght
                = 0;

        mannwhitneyu
            .m
            ann
        n
            ey
        ute
            n,
            y,
            ef bothails, re
            l
        e
            f
        tta
            l,  ref r
            ghttai, _pa
        ra
            s);
    }
}

public partial class alglib
{
    /*************************************************************************
    Sign test

    This test checks three hypotheses about the median of  the  given  sample.
    The following tests are performed:
        * two-tailed test (null hypothesis - the median is equal to the  given
          value)
        * left-tailed test (null hypothesis - the median is  greater  than  or
          equal to the given value)
        * right-tailed test (null hypothesis - the  median  is  less  than  or
          equal to the given value)

    Requirements:
        * the scale of measurement should be ordinal, interval or ratio  (i.e.
          the test could not be applied to nominal variables).

    The test is non-parametric and doesn't require distribution X to be normal

    Input parameters:
        X       -   sample. Array whose index goes from 0 to N-1.
        N       -   size of the sample.
        Median  -   assumed median value.

    Output parameters:
        BothTails   -   p-value for two-tailed test.
                        If BothTails is less than the given significance level
                        the null hypothesis is rejected.
        LeftTail    -   p-value for left-tailed test.
                        If LeftTail is less than the given significance level,
                        the null hypothesis is rejected.
        RightTail   -   p-value for right-tailed test.
                        If RightTail is less than the given significance level
                        the null hypothesis is rejected.

    While   calculating   p-values   high-precision   binomial    distribution
    approximation is used, so significance levels have about 15 exact digits.

      -- ALGLIB --
         Copyright 08.09.2006 by Bochkanov Sergey
    *************************************************************************/
    public static void onesamplesigntest(double[] x, int n, double median, out double bothtails, out double lefttail,
        out double righttail)
    {
        botht
            ils
                = 0;


        le
            ttail = 0;


        r
            ghttai = 0;

        stest.o
        ne g,
            media
        n
            ref
        othta
            ls, r
        f le
            ttai,
            re

        r
            i
        gh u
    }

    public static void onesamplesigntest(double[] x, int n, double median, out double bothtails, out double lefttail,
        out double righttail, alglib.xparams _params)
    {
        otht
            ils
                = 0;

        leftt
            il = 0


        stest.ones
            mp

        esigntes
            t(dian, re
                t

        i
        l
            s, re
        le
        ttai
            l,  ref
            ight
            tail, _params);
    }
}

public partial class alglib
{
    /*************************************************************************
    One-sample t-test

    This test checks three hypotheses about the mean of the given sample.  The
    following tests are performed:
        * two-tailed test (null hypothesis - the mean is equal  to  the  given
          value)
        * left-tailed test (null hypothesis - the  mean  is  greater  than  or
          equal to the given value)
        * right-tailed test (null hypothesis - the mean is less than or  equal
          to the given value).

    The test is based on the assumption that  a  given  sample  has  a  normal
    distribution and  an  unknown  dispersion.  If  the  distribution  sharply
    differs from normal, the test will work incorrectly.

    INPUT PARAMETERS:
        X       -   sample. Array whose index goes from 0 to N-1.
        N       -   size of sample, N>=0
        Mean    -   assumed value of the mean.

    OUTPUT PARAMETERS:
        BothTails   -   p-value for two-tailed test.
                        If BothTails is less than the given significance level
                        the null hypothesis is rejected.
        LeftTail    -   p-value for left-tailed test.
                        If LeftTail is less than the given significance level,
                        the null hypothesis is rejected.
        RightTail   -   p-value for right-tailed test.
                        If RightTail is less than the given significance level
                        the null hypothesis is rejected.

    NOTE: this function correctly handles degenerate cases:
          * when N=0, all p-values are set to 1.0
          * when variance of X[] is exactly zero, p-values are set
            to 1.0 or 0.0, depending on difference between sample mean and
            value of mean being tested.


      -- ALGLIB --
         Copyright 08.09.2006 by Bochkanov Sergey
    *************************************************************************/
    public static void studentttest1(double[] x, int n, double mean, out double bothtails, out double lefttail,
        out double righttail)
    {
        htails

        0;


        leftt
            il =
                0;


        r
            i
        gh 0

        tude
            tt
        ests.s
            t
        d
            en
        tt n,
 
            ,
            f botht
            ils,
            ef
        lef
            tail, ref rightta
            l,  null);
    }

    public static void studentttest1(double[] x, int n, double mean, out double bothtails, out double lefttail,
        out double righttail, alglib.xparams _params)
    {
        bothta
            il l
            a
                =
                0;


        rig
            h
        ttail
        0;

        en
            ttest1(x
                n

        mea
            , re
        bo
            htail,  ref leftta
            l, re
        f
    }

    /*************************************************************************
    Two-sample pooled test

    This test checks three hypotheses about the mean of the given samples. The
    following tests are performed:
        * two-tailed test (null hypothesis - the means are equal)
        * left-tailed test (null hypothesis - the mean of the first sample  is
          greater than or equal to the mean of the second sample)
        * right-tailed test (null hypothesis - the mean of the first sample is
          less than or equal to the mean of the second sample).

    Test is based on the following assumptions:
        * given samples have normal distributions
        * dispersions are equal
        * samples are independent.

    Input parameters:
        X       -   sample 1. Array whose index goes from 0 to N-1.
        N       -   size of sample.
        Y       -   sample 2. Array whose index goes from 0 to M-1.
        M       -   size of sample.

    Output parameters:
        BothTails   -   p-value for two-tailed test.
                        If BothTails is less than the given significance level
                        the null hypothesis is rejected.
        LeftTail    -   p-value for left-tailed test.
                        If LeftTail is less than the given significance level,
                        the null hypothesis is rejected.
        RightTail   -   p-value for right-tailed test.
                        If RightTail is less than the given significance level
                        the null hypothesis is rejected.

    NOTE: this function correctly handles degenerate cases:
          * when N=0 or M=0, all p-values are set to 1.0
          * when both samples has exactly zero variance, p-values are set
            to 1.0 or 0.0, depending on difference between means.

      -- ALGLIB --
         Copyright 18.09.2006 by Bochkanov Sergey
    *************************************************************************/
    public static void studentttest2(double[] x, int n, double[] y, int m, out double bothtails, out double lefttail,
        out double righttail)
    {
        bo
            th 0

        efttai
            =
            0;


        ightt
            il =
                0;


        s
            t
        ud s
        t
        st2(
            ,
            , y, m
            , t
        e
            efttai,
            ef ri
            httai, nul
            );
    }

    public static void studentttest2(double[] x, int n, double[] y, int m, out double bothtails, out double lefttail,
        out double righttail, alglib.xparams _params)
    {
        othtails = 0

        ri
        htta
            l = 0;


        student
        tt dentttes,
            y,
            m,
            ef
        otht
        a
            ils, r
        f le
        ft ra
        s);
    }

    /*************************************************************************
    Two-sample unpooled test

    This test checks three hypotheses about the mean of the given samples. The
    following tests are performed:
        * two-tailed test (null hypothesis - the means are equal)
        * left-tailed test (null hypothesis - the mean of the first sample  is
          greater than or equal to the mean of the second sample)
        * right-tailed test (null hypothesis - the mean of the first sample is
          less than or equal to the mean of the second sample).

    Test is based on the following assumptions:
        * given samples have normal distributions
        * samples are independent.
    Equality of variances is NOT required.

    Input parameters:
        X - sample 1. Array whose index goes from 0 to N-1.
        N - size of the sample.
        Y - sample 2. Array whose index goes from 0 to M-1.
        M - size of the sample.

    Output parameters:
        BothTails   -   p-value for two-tailed test.
                        If BothTails is less than the given significance level
                        the null hypothesis is rejected.
        LeftTail    -   p-value for left-tailed test.
                        If LeftTail is less than the given significance level,
                        the null hypothesis is rejected.
        RightTail   -   p-value for right-tailed test.
                        If RightTail is less than the given significance level
                        the null hypothesis is rejected.

    NOTE: this function correctly handles degenerate cases:
          * when N=0 or M=0, all p-values are set to 1.0
          * when both samples has zero variance, p-values are set
            to 1.0 or 0.0, depending on difference between means.
          * when only one sample has zero variance, test reduces to 1-sample
            version.

      -- ALGLIB --
         Copyright 18.09.2006 by Bochkanov Sergey
    *************************************************************************/
    public static void unequalvariancettest(double[] x, int n, double[] y, int m, out double bothtails,
        out double lefttail, out double righttail)
    {
        othta
            ls = 
            ;


        l
            ft
        a
        i
            l
                =
                righ
        ta
            l =
                0;

        n
            t
        ests.u
            e
        q
            alvar

        ancet
            est(x
                    n, 
                , m,
                r
                    f

        o
            t
        h
            ta
        e
            ttai,
            ef
        ightta
            i,  null);
    }

    public static void unequalvariancettest(double[] x, int n, double[] y, int m, out double bothtails,
        out double lefttail, out double righttail, alglib.xparams _params)
    {
        bothta
            il l
            a
                =
                0;


        rig
            h
        ttail
        0;

        ua
            variance

        te
            t(x,
                n, y
                    m,
                ref b
                    thtails, ref
                    leftt
                    ai s);
    }
}

public partial class alglib
{
    public class basestat
    {
        /*************************************************************************
        Calculation of the distribution moments: mean, variance, skewness, kurtosis.

        INPUT PARAMETERS:
            X       -   sample
            N       -   N>=0, sample size:
                        * if given, only leading N elements of X are processed
                        * if not given, automatically determined from size of X
            
        OUTPUT PARAMETERS
            Mean    -   mean.
            Variance-   variance.
            Skewness-   skewness (if variance<>0; zero otherwise).
            Kurtosis-   kurtosis (if variance<>0; zero otherwise).

        NOTE: variance is calculated by dividing sum of squares by N-1, not N.

          -- ALGLIB --
             Copyright 06.09.2006 by Bochkanov Sergey
        *************************************************************************/
        public static void samplemoments(double[] x,
            int n,
            ref double mean,
            ref double variance,
            ref double skewness,
            ref double kurtosis,
            alglib.xparams _params)
        {
            in
            t
                i = 0;


            dou
                bl = 
            do ubl

            1
                = 0;
            b
                v
            2
            doub
            t
                dev = 0;

            m
            e
                an = 0;
            v r
            i
            a
                nc
                    =
                    0;

            skewnes
                s
                    = 0;

            ku
                tosis = 0
                ;


            gi b.ap.ass
            rt(n >= 0
            "Sam
            leMomen ts 0");


            algli.assert(alglib.ap.len(x) >= n, "SampleMoments: Length(X)<N!");
            alglib.ap.assert(apserv.isfinitevector(x, n, _params), "SampleMoments: X is not finite vector");

            //
            // Init, special case 'N=0'
            //
            mean = 0;
            variance = 0;
            skewness = 0;
            kurtosis = 0;
            stddev = 0;
            if (n <= 0)
            {
                return;
            }

            //
            // Mean
            //
            for (i = 0; i <= n - 1; i++)
            {
                mean = mean + x[i];
            }

            mean = mean / n;

            //
            // Variance (using corrected two-pass algorithm)
            //
            if (n != 1)
            {
                v1 = 0;
                for (i = 0; i <= n - 1; i++)
                {
                    v1 = v1 + math.sqr(x[i] - mean);
                }


                v2 = 0
                    ;


                ;
                i
                    =
                    n -

                {
                    v2 =
                        2 + (x[i] -
                             me
                }

                ath
                sqr(v2
                    / n;

                riance
                    = (v1 - v
                    ) / (n - 1)
                    ;

                oub
                    e
                    (
                        a
                            ri e)

                (0)


                e = 0;


                s
                    d
                dv(var
                a
                    c
                e)
            }


            //


            ess and
            u
                t
            oi //
                i
            f(
                (
                    ouble)(stddev) != (dou
            b
            le

            {
                f
                    o
                r(i
                        =
                        0
                    ;
                i
                    <
                    =
                    -1;
                i++)
                {
                    v =
                        (x
                        [
                            i] - mea
                    n
                        )/stdd
                    e
                        v;


                    v2 =
                        m
                    a
                    h.sqr(v);
                    skewness
                        = 
                        is = kurtosis + math.sqr(v2);


                    s
                        ke ness / n;


                    rtosis =
                        k
                    r
                        to
                }
            }


            /*************************************************************************
            Calculation of the mean.
    
            INPUT PARAMETERS:
                X       -   sample
                N       -   N>=0, sample size:
                            * if given, only leading N elements of X are processed
                            * if not given, automatically determined from size of X
    
            NOTE:
                            
            This function return result  which calculated by 'SampleMoments' function
            and stored at 'Mean' variable.
    
    
              -- ALGLIB --
                 Copyright 06.09.2006 by Bochkanov Sergey
            *************************************************************************/
            public static double samplemean(double[] x,
                int n,
                alglib.xparams _params)
            {
                d ou


                d ub e mean =
                        0
                    ;


                d

                s(, n,
                    e
                mea
                    n, re
                f
                    tmp, ef
                t
                    mp
                        = 

                return result;
            }


            /*************************************************************************
            Calculation of the variance.
    
            INPUT PARAMETERS:
                X       -   sample
                N       -   N>=0, sample size:
                            * if given, only leading N elements of X are processed
                            * if not given, automatically determined from size of X
    
            NOTE:
                            
            This function return result  which calculated by 'SampleMoments' function
            and stored at 'Variance' variable.
    
    
              -- ALGLIB --
                 Copyright 06.09.2006 by Bochkanov Sergey
            *************************************************************************/
            public static double samplevariance(double[] x,
                int n,
                alglib.xparams _params)
            {
                double r
                    sult
                        = 0;

                double
                    mp0
                0;


                double
                    mp1 =
                        0;


                double tmp2 = 
                    ;

                sampl
                    moment
                    (x
                        n, re
                        tmp0, r
                        ev

                ef
                    tmp1,
                    ef );


                resul
                    =
                    variance;
                retu
                    r
                n
                    r
                e
                    s
                u
                l
                    t
                    ;
            }


            /*************************************************************************
            Calculation of the skewness.
    
            INPUT PARAMETERS:
                X       -   sample
                N       -   N>=0, sample size:
                            * if given, only leading N elements of X are processed
                            * if not given, automatically determined from size of X
    
            NOTE:
                            
            This function return result  which calculated by 'SampleMoments' function
            and stored at 'Skewness' variable.
    
    
              -- ALGLIB --
                 Copyright 06.09.2006 by Bochkanov Sergey
            *************************************************************************/
            public static double sampleskewness(double[] x,
                int n,
                alglib.xparams _params)
            {
                double
                skewne
                    s = 0;

                doubl
                t
                    p0 = 0;

                double tmp1 = 0;


                double t
                    p2 = 0;


                am
                    lemome
                ts(0, ref tm
                1, re
                    f ske
                ne
                    s,  ref tm 
                2, _params);


                r
                    e
                s
                    u
                l
                    t
                        =
                        s
                k
                    e
                w
                    n
                e
                s
                    s
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
                    t
                    ;
            }


            /*************************************************************************
            Calculation of the kurtosis.
    
            INPUT PARAMETERS:
                X       -   sample
                N       -   N>=0, sample size:
                            * if given, only leading N elements of X are processed
                            * if not given, automatically determined from size of X
    
            NOTE:
                            
            This function return result  which calculated by 'SampleMoments' function
            and stored at 'Kurtosis' variable.
    
    
              -- ALGLIB --
                 Copyright 06.09.2006 by Bochkanov Sergey
            *************************************************************************/
            public static double samplekurtosis(double[] x,
                int n,
                alglib.xparams _params)
            {
                double resu
                    l
                        = 0


                do
                    ble tm
                        = 0;

                d
                uble tmp1 = 0;

                double tm
                2 = 0;


                amplemom
                    es t
                    p0, re
                tm ref kurt
                    sis,
                    _para
                s)


                result = kurt
                o
                    s
                i
                    s
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
                    t
                    ;
            }


            /*************************************************************************
            ADev
    
            Input parameters:
                X   -   sample
                N   -   N>=0, sample size:
                        * if given, only leading N elements of X are processed
                        * if not given, automatically determined from size of X
                
            Output parameters:
                ADev-   ADev
    
              -- ALGLIB --
                 Copyright 06.09.2006 by Bochkanov Sergey
            *************************************************************************/
            public static void sampleadev(double[] x,
                int n,
                ref double adev,
                alglib.xparams _params)
            {
                in
                t
                    = 0;


                dev
                0;


                a
                    gl
                b
                ap.ssert(n >= 0


                algl
                i
                    .ap.assert(al
                lib.ap.len
                    x)>=
                    , "S
                mp
                eDev:
                Length(X
                )
                t(ap
                erv.isfi
                    itevec
                or(x,
                    _par
                ms), "Samp
                eA
                ev:
                X is not fi
                    ite vector");


                //

                an
                le N = 0

                mean
                    = 0;


                dev = 0;


                i
                f
                (
                    n
                        <
                        =
                        0
                )


                {
                    r
                        e
                    t
                        u
                    r
                        n
                        ;
                }


                //

                // Mean


                //         fo
                (
                    i = ++)


                {
                    ];


                    // A
                    e
                        o
                    (
                        i
                    {
                        a
                            ev adev
                            +
                            ath
                        Abs(
                            x
                        i]-
                            ean);


                        = adev
                            n
                    }


                    /*************************************************************************
                    Median calculation.
            
                    Input parameters:
                        X   -   sample (array indexes: [0..N-1])
                        N   -   N>=0, sample size:
                                * if given, only leading N elements of X are processed
                                * if not given, automatically determined from size of X
            
                    Output parameters:
                        Median
            
                      -- ALGLIB --
                         Copyright 06.09.2006 by Bochkanov Sergey
                    *************************************************************************/
                    public static void samplemedian(double[] x,
                        int n,
                        ref double median,
                        alglib.xparams _params)
                    {
                        = 0;


                        int
                            ir = 0;

                        0;


                        n

                        m
                            i
                                = 
                        do
                            ble a 0
                            ;


                        ouble tval = 0;


                        ouble[] x
                            .C
                            l
                        one();


                        med a
                            n
                                = ;


                        a
                        glib.a

                        p
                            .a sert(n>=

                        0,
                        "
                        Sam leM
                        e
                        dian:
                        N < 0");


                        algl b.
                            a
                            p
                        assert alg ib
                            .p
                        le
                                (x)
                            = n, "Sa
                        pleMed
                            ian

                        a
                            (apserv.isfin te
                        e
                            c
                        to ms
                        an:
                        X i

                        n
                            );


                        / /


                        if (
                            =1 )
                            = [
                        0 ]
                        ;


                        =
                        2


                        r

                                //        Choo        e X
                                [(N -)
                                 /
                                 2]
                            =
                            0;
                            =-1;
                        k = (n - 1) / 2;
                        while (true)
                        {
                            if (ir <= l + 1)
                            {
                                //
                                // 1 or 2 elements in partition
                                //
                                if (ir == l + 1 && (double)(x[ir]) < (double)(x[l]))
                                {
                                    tval = x[l];
                                    x[l] = x[ir];
                                    x[ir] = tval;
                                }

                                break;
                            }
                            else
                            {
                                midp = (l + ir) / 2;
                                tv
                                    l = x[
                                        idp]
                                    [
                                        mi;


                                [l
                                +1]
                                tval;


                                if ((do
                                    ble)(x[
                                        l]) > (double)
                                    l =
                                    x
                                l
                                    ;


                                ;


                                x[i
                                    ]
                                    =
                                    t
                                va
                            }


                            if (
                                d
                            u
                                be o
                                b
                            e
                                )(x[ir
                                    ]
                                )
                                )


                            tval =
                                x[
                                    l
                                    + 1];


                            x[l
                              +
                              1]


                            x
                                [
                                    ir
                                ]
                                =
                                t
                            v
                            a
                                l;
                        }


                        (doub
                        l
                            e)
                        (
                                x[l]) >
                            (
                                double
                            )
                            (x[l + 1]) )


                        {
                            tval = x[l];
                                ] = x[l +
                        }


                        i
                            =
                            l
                            +
                            ;
                            =


                        tr

                        {
                            do
                        }


                        whi
                        le[

                        do


                            (
                                (
                                    o
                        u
                            b
                        l
                            e
                            )
                        (
                                x[(a))
                            ;


                        tval = x[i];
                            ] =


                        [j
                        =

                        tval
                            ;
                    }

                    l +
                        x
                        [
                            j
                        ]
                        = i
                    f
                            (
                        >
                        k
                        )
                        )
                }
            }
            /
            /


            //         
            r
                e
            s
                u
            l


            if
            (
                n
                % 2 == 1
            )


            {
            }


            fo


            {
                ou a)


                {
                    m
                        ed
                }


                /*************************************************************************
                Percentile calculation.
        
                Input parameters:
                    X   -   sample (array indexes: [0..N-1])
                    N   -   N>=0, sample size:
                            * if given, only leading N elements of X are processed
                            * if not given, automatically determined from size of X
                    P   -   percentile (0<=P<=1)
        
                Output parameters:
                    V   -   percentile
        
                  -- ALGLIB --
                     Copyright 01.03.2008 by Bochkanov Sergey
                *************************************************************************/
                public static void samplepercentile(double[] x,
                    int n,
                    double p,
                    ref double v,
                    alglib.xparams _params)


                d e
                [
                    0
                ]


                v =
                    0, <
                0
                "
                    )
                ;


                gl ib.a p.e
                (
                    x) le :
                L
                h()
                "
                p
                    ,
                    ,
                _
                    p
                a
                    ra l
                    to
                r
                    )
                ;


                se m
                l
                    P
                e
                a
                    >
                    (d o

                ntile:
                incorrect P!");


                st(buf,, _
                p
                ar
                    as )
                b


                {
                    x[0];


                    rn
                }


                (do
                    u
                        b
                l
                    e
                    )
                (
                    1
                )


                r
                    e
                t
                    u
                r
                    n
                    ;


                ;


                at
                    * (1 - t) +
                [
                1 + 1
                    ]
                *
                    t
                    ;
            }


            /*************************************************************************
            2-sample covariance
    
            Input parameters:
                X       -   sample 1 (array indexes: [0..N-1])
                Y       -   sample 2 (array indexes: [0..N-1])
                N       -   N>=0, sample size:
                            * if given, only N leading elements of X/Y are processed
                            * if not given, automatically determined from input sizes
    
            Result:
                covariance (zero for N=0 or N=1)
    
              -- ALGLIB --
                 Copyright 28.10.2010 by Bochkanov Sergey
            *************************************************************************/
            public static double cov2(double[] x,
                double[] y,
                int n,
                alglib.xparams _params)

            int i
                =
                0


            mean =
                0


            doubl e ym e

            x 0

            0;
            double y 0 = 0
            s =
                0;


            ool samex = new bool)


            ;
            al gl ib.ap.
                a
                s
            ert(n >= 0, "Cov2:N                                       a
                (algli
            b
                .a
            p
                    .len(x
                    )
                >= n,

            "Cov2: L
            e
                n
            g
            t
                (X) < N ")        
            alglib.ap.asse
                r
            t(
                a
            l.p(y
            ) >: Leng
            t
                (Y) < N!");


            t(
                a
            pse
            v
                .
                sfi
                itev
            e
                t
            o
                (x, n, _p
            ao
                t
            a
                s
            e
                r
            v
                .
                ct
                o
            s
                vec to r"        );        
                /
                p
            e
                c
            i
                a
            l

            if (
                r

            e
                s
            u
                lt;
        }
        / /

        le mean.
            //
            //
            // Additonally we calculate SameX and SameY -
            // flag variables which are set to True when
            // all X[] (or Y[]) contain exactly same value.
            //
            // If at least one of them is True, we return zero
            // (othwerwise we risk to get nonzero covariation
            // because of roundoff).
            //
            xmean = 0;
        ymean = 0;
        samex = true;
        samey = true;
        x0 = x[0];
        y0 = y[0];
        v = (double)1/(double) n;
            for(i= 0; i<=n-1; i++)
        {
            s = x[i];
            samex = samex && (double
                    (s) == (
                    ouble)
                x0);


            xmean +
                s
                *
                ;
                =

            same
                = same
            y && (double e)(y0)
                ym
            a
                +
                *
                    v;
        }


        i
            f(mey)


        e
            u

        t
        =

        r
            t

        r
            n
    }


    /

    cova
        iance

        //         v =
        (doub
            e
            1/(
        oubl
        e
        )

    (- re
        s

    ul
        t
            = 0;
        for(i=
    0
    ;


    {
        r
            e
        su
        l
            t
                = result + v * (x[i] - xme
        a
            n) );
    }


    r
        e

    t
        u

    rn
        r

    sult;
}


/*************************************************************************
Pearson product-moment correlation coefficient

Input parameters:
    X       -   sample 1 (array indexes: [0..N-1])
    Y       -   sample 2 (array indexes: [0..N-1])
    N       -   N>=0, sample size:
                * if given, only N leading elements of X/Y are processed
                * if not given, automatically determined from input sizes

Result:
    Pearson product-moment correlation coefficient
    (zero for N=0 or N=1)

  -- ALGLIB --
     Copyright 28.10.2010 by Bochkanov Sergey
*************************************************************************/
public static double pearsoncorr2(double[] x,
    double[] y,
    int n,
    alglib.xparams _params)
{
    do
        b
            e

    r
        e
    su
        i
    nt
        dou
    b
        l
    e
        xmean
            =
            0;
    do
        u
            b
    l
        e

    m
    ea
        n
            = 
        ;


    bl
        d
    o
        u
    bl
        d
    uble
    0

    0;


    ouble
        s =
            0
        ;
        = ne

    ool()
        ;


    o
        o
    l
    (
    )
    e xv 0


    doub
        l
    e

    y
        v
            =
            0;


    d ub e 2 =
        0
    rt(
        n
            = 0, "
    ea
        sonCo

    r
        t(lg ib

    a
        .
        l
        Co r2 L e
    gth(X)
        <
        n

    nCorr2:
    ength
        s
    rt a
    pserv is i
        n
    it vecto r(x,
        n
        ,
        _
    pa son Co rr2 :
    s
        ;


    a
        l
    g
        l
    b
        .a
        p
    f
        ), "        Pea        rs        on        o
    r2:
    Y
        i
    s
        n
    o
        t

    f
        i
    nite v e
        c
    t
        o
    r
    "
        )
    ;


    pe ci al c as

    //
    if (n <= 1)
    {
        result = 0;
        return result;
    }

    //
    // Calculate mean.
    //
    //
    // Additonally we calculate SameX and SameY -
    // flag variables which are set to True when
    // all X[] (or Y[]) contain exactly same value.
    //
    // If at least one of them is True, we return zero
    // (othwerwise we risk to get nonzero correlation
    // because of roundoff).
    //
    xmean = 0;
    ymean = 0;
    samex = true;
    samey = true;
    x0 = x[0];
    y0 = y[0];
    v = (double)1 / (double)n;
    for (i = 0; i <= n - 1; i++)


    {
        s =
            x
            [
            ]
            ;
        sa
        m
            e
                = ubl
            )
        (s x0);


        x
            mean = xmean
        s =
            y
        i
            ];

        a
            e
        y double
                (s) ==
            d
        u
            bl

        m
            a
        n
    }

    if (s
    me
        |
        s
    {
        sult =
            0


        retu
            n res
            l
            ;


        //


        merato
            a
        d
            d
        en
            /
            0;


        v
            = 
            ;
        for (i
                 =
                 0;
             i <= n - 1;
             i +
             +
            )
        {
            x[i] -
                x
            me
            a
                n;


            t
            2
                =
                y
                [
                    i
                    - ymean;
            xv =
                xv );


            yv =
                yv
                +
                mat
            h
                .s
            qr
            (
                t
            );
            s = s + t1 *
                t
            2;
        }


        i
        f
            ((dou
        b
            le)(xv) == (doub
        l
            e
            )
        0
            )
            || (dou
        b
            l
            )(yv) == (double)(0) )
        {
            sult =
                0;
        }


        el
            s
        e


        {
            result = s / (Math.Sqrt(
                x
            v

            return result;
        }


        /*************************************************************************
        Spearman's rank correlation coefficient

        Input parameters:
            X       -   sample 1 (array indexes: [0..N-1])
            Y       -   sample 2 (array indexes: [0..N-1])
            N       -   N>=0, sample size:
                        * if given, only N leading elements of X/Y are processed
                        * if not given, automatically determined from input sizes

        Result:
            Spearman's rank correlation coefficient
            (zero for N=0 or N=1)

          -- ALGLIB --
             Copyright 09.04.2007 by Bochkanov Sergey
        *************************************************************************/
        public static double spearmancorr2(double[] x,
            double[] y,
            int n,
            alglib.xparams _params)
        {
            a
                se
            v
                .apbuff r
            s
                buf = ew ap
                s
            e
            rv
                .
                a
                x
                    =
                    (doub
            l
            e
                [
                ]
                )
            bl
                e
                    ]).C
                );


            p
                manCor
            2: N
            lib.a.sser(a g
                ;


            ib.ap.assert lg ib ap.len(y) >= n
                :
            ;


            .a
                s
            r
                t

            ve to(
                x, , 

            "
            S
                pe ar m
            a
                r
            r2
                :

            X i
            o
                t fi ni
            p.
                s
                e

            r
                t
                (
                    ap se

            rv. is f
                i
            s),
            pe rm an Co r
            2: Y
                is or
                )


            //
            S
                ial c ase
                      /
                = 
                ;


            r
                e
            tu
                r
            n res ul t;
        }


        b
            a
        sicsta
            t
        o
            p
        s
            ra l
            b
            (f, _p a

        re r2(x, 
            ,
            n
            ,
            _par
                a
                ms);

        ult;
    }


    /*************************************************************************
    Covariance matrix

      ! COMMERCIAL EDITION OF ALGLIB:
      ! 
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      ! 
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

    INPUT PARAMETERS:
        X   -   array[N,M], sample matrix:
                * J-th column corresponds to J-th variable
                * I-th row corresponds to I-th observation
        N   -   N>=0, number of observations:
                * if given, only leading N rows of X are used
                * if not given, automatically determined from input size
        M   -   M>0, number of variables:
                * if given, only leading M columns of X are used
                * if not given, automatically determined from input size

    OUTPUT PARAMETERS:
        C   -   array[M,M], covariance matrix (zero if N=0 or N=1)

      -- ALGLIB --
         Copyright 28.10.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void covm(double[,] x,
        int n,
        int m,
        ref double[,] c,
        alglib.xparams _params)
    {
        int i = 0;
        int j = 0;
        double v = 0;
        double[] t = new double[0];
        double[] x0 = new double[0];
        bool[] same = new bool[0];
        int i_ = 0;

        x = (double[,])x.Clone();
        c = new double[0, 0];

        alglib.ap.assert(n >= 0, "CovM: N<0");
        alglib.ap.assert(m >= 1, "CovM: M<1");
        alglib.ap.assert(alglib.ap.rows(x) >= n, "CovM: Rows(X)<N!");
        alglib.ap.assert(alglib.ap.cols(x) >= m || n == 0, "CovM: Cols(X)<M!");
        alglib.ap.assert(apserv.apservisfinitematrix(x, n, m, _params), "CovM: X contains infinite/NAN elements");

        //
        // N<=1, return zero
        //
        if (n <= 1)
        {
            c = new double[m, m];
            for (i = 0; i <= m - 1; i++)
            {
                for (j = 0; j <= m - 1; j++)
                {
                    c[i, j] = 0;
                }
            }

            return;
        }

        //
        // Calculate means,
        // check for constant columns
        //
        t = new double[m];
        x0 = new double[m];
        same = new bool[m];
        c = new double[m, m];
        for (i = 0; i <= m - 1; i++)
        {
            t[i] = 0;
            same[i] = true;
        }

        for (i_ = 0; i_ <= m - 1; i_++)
        {
            x0[i_] = x[0, i_];
        }

        v = (double)1 / (double)n;
        for (i = 0; i <= n - 1; i++)
        {
            for (i_ = 0; i_ <= m - 1; i_++)
            {
                t
                    i_]
                t[i
                _
                    ] +v *
                    x
                    [
                        i
                i
                    _]
            }

            fo 1;
            ++)


            same[
                j] = same[j](x[
                        ,
                    ]
                    = 
                = ( ]);
        }
        /
        / ariabl
            e
        s

            //
            *

        if stan
            t

        olum
            s
        th
            se c
            o
        l
            u
        mn
            /
            r e
            o
        d
            (they

        m
            u
        s
            t

        be ze
        r
            o
        i h
        e
        ics
            / rtunat
        e
            ly

        floati
            n
        g
            p
        o
            i
        t ops are n
        o
        t
            /
            /
        *cal
        c
            u
        la
            t
        e
            upper half
            o
        f varian
        c
            e
        m
            atrix


        //


        for (i = 0; i <= n -
             1; {
            f
                or
            (
                    i_ = 0
                ;

            i
            _ <
                =
                -1
            i
            _ +
                +
                )
            {
                x
                [
                    i,
                    i
                _] = x
                    [
                        i, i_]
                    -
                    t[i_];
            }


            for (j = 0; j <= m - 1; j++)

            {
                me[ {
                    0;
                }
            }
        }


        rix
            s
        y
            r
        k
        (
            ,
            n
            ,
            (
                d
        u
            bl
        e) x , 0
            ,

        t
        r
            u,
            _
        p
            a
        r
            a
        s
            );

        tr
            m,
            t
        r
            e

        _params);
    }


    /*************************************************************************
    Pearson product-moment correlation matrix

      ! COMMERCIAL EDITION OF ALGLIB:
      ! 
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      ! 
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

    INPUT PARAMETERS:
        X   -   array[N,M], sample matrix:
                * J-th column corresponds to J-th variable
                * I-th row corresponds to I-th observation
        N   -   N>=0, number of observations:
                * if given, only leading N rows of X are used
                * if not given, automatically determined from input size
        M   -   M>0, number of variables:
                * if given, only leading M columns of X are used
                * if not given, automatically determined from input size

    OUTPUT PARAMETERS:
        C   -   array[M,M], correlation matrix (zero if N=0 or N=1)

      -- ALGLIB --
         Copyright 28.10.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void pearsoncorrm(double[,] x,
        int n,
        int m,
        ref double[,] c,
        alglib.xparams _params)
    {
        d ou le[] t
            =
            n
        ew dou
        b
            l
        e
            [
                0
            ]
            ;


        int
            =
            0
            ;

        nt j = 0;

        0;


        c = new double[
            0
            ,
            0;


        glib.ap
            .assert(n >= 0"PearsonCorrM: N<0");
        alglib.ap.assert(m >= 1, "PearsonCorrM: M<1");
        alglib.ap.assert(alglib.ap.rows(x) >= n, "PearsonCorrM: Rows(X)<N!");
        alglib.ap.assert(alglib.ap.cols(x) >= m || n == 0, "PearsonCorrM: Cols(X)<M!");
        alglib.ap.assert(apserv.apservisfinitematrix(x, n, m, _params),
            "PearsonCorrM: X contains infinite/NAN elements");
        t = new double[m];
        covm(x, n, m, ref c, _params);
        for (i = 0; i <= m - 1; i++)
        {
            if ((double)(c[i, i]) > (double)(0))
            {
                t[i] = 1 / Math.Sqrt(c[i, i]);
            }
            else
            {
                t[i] = 0.0;
            }
        }

        for (i = 0; i <= m - 1; i++)
        {
            v = t[i];
            for (j = 0; j <= m - 1; j++)
            {
                c[i, j] = c[i, j] * v * t[j];
            }
        }
    }


    /*************************************************************************
    Spearman's rank correlation matrix

      ! COMMERCIAL EDITION OF ALGLIB:
      ! 
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      ! 
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

    INPUT PARAMETERS:
        X   -   array[N,M], sample matrix:
                * J-th column corresponds to J-th variable
                * I-th row corresponds to I-th observation
        N   -   N>=0, number of observations:
                * if given, only leading N rows of X are used
                * if not given, automatically determined from input size
        M   -   M>0, number of variables:
                * if given, only leading M columns of X are used
                * if not given, automatically determined from input size

    OUTPUT PARAMETERS:
        C   -   array[M,M], correlation matrix (zero if N=0 or N=1)

      -- ALGLIB --
         Copyright 28.10.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void spearmancorrm(double[,] x,
        int n,
        int m,
        ref double[,] c,
        alglib.xparams _params)

    {
        int
            i
                = 
            ;
            .
        p
            u
        f
            f
        e
            rs v.a
            p
        b
            u
        f
            f
        r
        s(
            )
            ;


        c
            d
        o
            u
        b
            l
        e
            [
            ]
            t
                = ble v = 0;
        double vv = 0;
        double x0 = 0;
        bool b = new bool();

        c = new double[0, 0];

        alglib.ap.assert(n >= 0, "SpearmanCorrM: N<0");
        alglib.ap.assert(m >= 1, "SpearmanCorrM: M<1");
        alglib.ap.assert(alglib.ap.rows(x) >= n, "SpearmanCorrM: Rows(X)<N!");
        alglib.ap.assert(alglib.ap.cols(x) >= m || n == 0, "SpearmanCorrM: Cols(X)<M!");
        alglib.ap.assert(apserv.apservisfinitematrix(x, n, m, _params),
            "SpearmanCorrM: X contains infinite/NAN elements");

        //
        // N<=1, return zero
        //
        if (n <= 1)
        {
            c = new double[m, m];
            for (i = 0; i <= m - 1; i++)
            {
                for (j = 0; j <= m - 1; j++)
                {
                    c[i, j] = 0;
                }
            }

            return;
        }

        //
        // Allocate
        //
        t = new double[Math.Max(n, m)];
        c = new double[m, m];

        //
        // Replace data with ranks
        //
        xc = new double[m, n];
        ablas.rmatrixtranspose(n, m, x, 0, 0, xc, 0, 0, _params);
        rankdata(xc, m, n, _params);

        //
        // 1. Calculate means, check for constant columns
        // 2. Center variables, constant  columns are
        //   artificialy zeroed (they must be zero in exact arithmetics,
        //   but unfortunately floating point is not exact).
        //
        for (i = 0; i <= m - 1; i++)
        {
            //


            // Calculate:


            mea
                va var
                a
            bl
                // *
                B


            Tr ll var
                i
            able va
            ues are
            same
                ue;


            0
                = x
                    [i, 0];


            j <= n - 1
                ;

            j
                +)


            {
                v


                c[i
                j];


                v = v
                v
                    ;

                b
                    =
                    &
                        ( =(doub
                e)
                x
                    )
                ;


                /
                /

                Ce
                    n
                t
                r / zero I - th variable

                    //
                    i
                    (b)


                {
                    /
                    /


                    // Zero


                    //


                    f
                        or
                    (
                        j = 0;

                    j
                        <
                        = n
                          -
                        ;
                    +
                        +)


                    {
                        xc[i
                                ,
                                j]
                            = 0.0;
                    }
                }


                else
                {
                    // Center
                    //          


                    fo 1;


                    {
                        [i,
                         j
                        ]
                        =

                        c
                            [i
                                ,
                                j
                            ]
                            -
                            ;
                    }
                }


                p
                    e
                r
                    h
                a
                    f
                o
                    f m blas.r
                    ma n
                    xc .0, c, 0, 0, ms)


                //


                //        e
                r
                    on
                oeffic
                    i
                e
                    n
                s
                        (
                    / for (i = 0; i <= m - 1; i++)
                    if

                dou
                    le)(c[
                        i
                        ,
                        i
                    )
                    >
                    (d

                {
                    t[
                        i
                            =
                            1
                            /
                            ath.Sqr
                    t
                        (c


                    t[i] = 0.0;
                }
            }
            r(i = 0;
            i <= m - 1;
            i++)
            {
                ;
                for (j = i; j <= m - 1; j++)
                {
                    c[i, j] = c[i, j] * v * t[j];
                }
                /
                /
                /
                /

                fo c
                    as. mmetricity(c,);
            }


            /*************************************************************************
            Cross-covariance matrix
    
              ! COMMERCIAL EDITION OF ALGLIB:
              ! 
              ! Commercial Edition of ALGLIB includes following important improvements
              ! of this function:
              ! * high-performance native backend with same C# interface (C# version)
              ! * multithreading support (C++ and C# versions)
              ! * hardware vendor (Intel) implementations of linear algebra primitives
              !   (C++ and C# versions, x86/x64 platform)
              ! 
              ! We recommend you to read 'Working with commercial version' section  of
              ! ALGLIB Reference Manual in order to find out how to  use  performance-
              ! related features provided by commercial edition of ALGLIB.
    
            INPUT PARAMETERS:
                X   -   array[N,M1], sample matrix:
                        * J-th column corresponds to J-th variable
                        * I-th row corresponds to I-th observation
                Y   -   array[N,M2], sample matrix:
                        * J-th column corresponds to J-th variable
                        * I-th row corresponds to I-th observation
                N   -   N>=0, number of observations:
                        * if given, only leading N rows of X/Y are used
                        * if not given, automatically determined from input sizes
                M1  -   M1>0, number of variables in X:
                        * if given, only leading M1 columns of X are used
                        * if not given, automatically determined from input size
                M2  -   M2>0, number of variables in Y:
                        * if given, only leading M1 columns of X are used
                        * if not given, automatically determined from input size
    
            OUTPUT PARAMETERS:
                C   -   array[M1,M2], cross-covariance matrix (zero if N=0 or N=1)
    
              -- ALGLIB --
                 Copyright 28.10.2010 by Bochkanov Sergey
            *************************************************************************/
            public static void covm2(double[,] x,
                double[,] y,
                int n,
                int m1,
                int m2,
                ref double[,] c,
                alglib.xparams _params)
            {
                int i = 0 t
                    j
                        = 0;
                double v
                        = 
                    ;


                do
                    u
                ble[] t = n double[0];
                double[] x0 = new double[0];
                double[] y0 = new double[0];
                bool[] samex = new bool[0];
                bool[] samey = new bool[0];
                int i_ = 0;

                x = (double[,])x.Clone();
                y = (double[,])y.Clone();
                c = new double[0, 0];

                alglib.ap.assert(n >= 0, "CovM2: N<0");
                alglib.ap.assert(m1 >= 1, "CovM2: M1<1");
                alglib.ap.assert(m2 >= 1, "CovM2: M2<1");
                alglib.ap.assert(alglib.ap.rows(x) >= n, "CovM2: Rows(X)<N!");
                alglib.ap.assert(alglib.ap.cols(x) >= m1 || n == 0, "CovM2: Cols(X)<M1!");
                alglib.ap.assert(apserv.apservisfinitematrix(x, n, m1, _params),
                    "CovM2: X contains infinite/NAN elements");
                alglib.ap.assert(alglib.ap.rows(y) >= n, "CovM2: Rows(Y)<N!");
                alglib.ap.assert(alglib.ap.cols(y) >= m2 || n == 0, "CovM2: Cols(Y)<M2!");
                alglib.ap.assert(apserv.apservisfinitematrix(y, n, m2, _params),
                    "CovM2: X contains infinite/NAN elements");

                //
                // N<=1, return zero
                //
                if (n <= 1)
                {
                    c = new double[m1, m2];
                    for (i = 0; i <= m1 - 1; i++)
                    {
                        for (j = 0; j <= m2 - 1; j++)
                        {
                            c[i, j] = 0;
                        }
                    }

                    return;
                }

                //
                // Allocate
                //
                t = new double[Math.Max(m1, m2)];
                x0 = new double[m1];
                y0 = new double[m2];
                samex = new bool[m1];
                samey = new bool[m2];
                c = new double[m1, m2];

                //
                // * calculate means of X
                // * center X
                // * if we have constant columns, these columns are
                //   artificially zeroed (they must be zero in exact arithmetics,
                //   but unfortunately floating point ops are not exact).
                //
                for (i = 0; i <= m1 - 1; i++)
                {
                    t[i
                            = 0;
                        = true
                        ;


                    i_ <
                        m1
                        - 1

                    {
                        x0[i_
                            ]
                            =
                            x
                                [0
                    }


                    v
                        = (double)1 /
                          n - 1
                          +
                        )


                    i_ <= m
                    1
                        -
                        ;
                    _
                        +)


                    t[i
                    ] = t[
                        i
                    _
                        ]
                    +
                }


                ;
                j <
                    =
                    m
                    - 1;
                j
                    +
                    ame
                        [j]
                    =
                    s
                am ubl
                    )(

                [
                ,

                j) 0
                j
                    )
                ;
            }


            f
                o
            r
            (
                i = 0;
            i
                <
                = n


            {
                0;
                i_ <
                    =
                    m1
                    -
                    1;
                i_++
                    )


                {
                    x
                        [i
                            ,
                            i_] =
                        x
                        [i
                            , i
                    _
                        ]
                    -t[i_];


                    f
                        o
                    r(
                            j =
                                0
                        ;
                    j <= m1 - 1;
                    j++)


                    {
                        if
                        (
                            sam
                        e
                        x
                            [
                                j]
                            )


                        {
                            x[i,
                                j
                            ] = 0;
                        }
                    }


                    //


                    // Repeat

                    s
                        a
                    e
                        te
                    p
                    for Y


                    //
                    for (i = 0; i <= m2 - 1;
                         i + {
                        t[
                                i
                            ]
                            =
                            0;


                        samey[i] =
                            t
                        ru
                    }


                    for (i_
                             =
                             0;
                         i_ <=
                         m
                        2
                            -
                            1;
                    i_
                        +)


                    {
                        0,i_];
                    }


                    v = (double
                        )
                        1
                        /
                        d
                    o
                        bl
                    e
                        n;


                    for (i = 0; i <= n - 1; i++)
                    {
                        <=m {
                            ]
                            +
                                    v
                                * y
                                [
                                    , i


                            for (j =
                                     0;
                                 j
                                 = m
                                2
                                    - 1


                            {
                                s y[i
                                        ,
                                        j
                                    ]
                                    )
                                    =
                                (
                                do
                                    ub
                                        l
                                e
                                    )
                                y
                                0[
                                    j]

                                f
                                    o
                                r
                                (
                                    i
                                0

                                i < 2 - 1;
                                i_
                                    ++

                                y[i_] - t[i_];


                                for (j =
                                         0;
                                     j <
                                     =
                                     m2 -
                                     1;
                                     j
                                     +)


                                {
                                    j]
                                        )


                                    y
                                    [
                                        i, 
                                }
                            }
                        }


                        late cross - covariance matr //
                        atrixgemm(m1, m2, n, (double)1 / (double)(n - 1), x, 0, 0, 0, 0.0, c, 0, 0, _params);
                    }


                    /*************************************************************************
                    Pearson product-moment cross-correlation matrix
            
                      ! COMMERCIAL EDITION OF ALGLIB:
                      ! 
                      ! Commercial Edition of ALGLIB includes following important improvements
                      ! of this function:
                      ! * high-performance native backend with same C# interface (C# version)
                      ! * multithreading support (C++ and C# versions)
                      ! * hardware vendor (Intel) implementations of linear algebra primitives
                      !   (C++ and C# versions, x86/x64 platform)
                      ! 
                      ! We recommend you to read 'Working with commercial version' section  of
                      ! ALGLIB Reference Manual in order to find out how to  use  performance-
                      ! related features provided by commercial edition of ALGLIB.
            
                    INPUT PARAMETERS:
                        X   -   array[N,M1], sample matrix:
                                * J-th column corresponds to J-th variable
                                * I-th row corresponds to I-th observation
                        Y   -   array[N,M2], sample matrix:
                                * J-th column corresponds to J-th variable
                                * I-th row corresponds to I-th observation
                        N   -   N>=0, number of observations:
                                * if given, only leading N rows of X/Y are used
                                * if not given, automatically determined from input sizes
                        M1  -   M1>0, number of variables in X:
                                * if given, only leading M1 columns of X are used
                                * if not given, automatically determined from input size
                        M2  -   M2>0, number of variables in Y:
                                * if given, only leading M1 columns of X are used
                                * if not given, automatically determined from input size
            
                    OUTPUT PARAMETERS:
                        C   -   array[M1,M2], cross-correlation matrix (zero if N=0 or N=1)
            
                      -- ALGLIB --
                         Copyright 28.10.2010 by Bochkanov Sergey
                    *************************************************************************/
                    public static void pearsoncorrm2(double[,] x,
                        double[,] y,
                        int n,
                        int m1,
                        int m2,
                        ref double[,] c,
                        alglib.xparams _params)
                    {
                        in t
                            i = 0


                        do
                            u
                                b
                        le ]
                            ];


                        e
                            b
                        b
                            ew double[0];
                        bool[] same[0] boo
                        l
                            [] samey =
                                n
                        ew
                            oo
                        l
                        0
                            ]


                        int
                        i
                            _
                                =
                                0
                            ;


                        x
                            =
                            d
                        o
                            b
                        l
                                [,]
                            )
                            .
                        C
                            o
                        n
                        (
                        )


                        y = (dble[,])y.Clone();
                        c = new double[0, 0];

                        alglib.ap.assert(n >= 0, "PearsonCorrM2: N<0");
                        alglib.ap.assert(m1 >= 1, "PearsonCorrM2: M1<1");
                        alglib.ap.assert(m2 >= 1, "PearsonCorrM2: M2<1");
                        alglib.ap.assert(alglib.ap.rows(x) >= n, "PearsonCorrM2: Rows(X)<N!");
                        alglib.ap.assert(alglib.ap.cols(x) >= m1 || n == 0, "PearsonCorrM2: Cols(X)<M1!");
                        alglib.ap.assert(apserv.apservisfinitematrix(x, n, m1, _params),
                            "PearsonCorrM2: X contains infinite/NAN elements");
                        alglib.ap.assert(alglib.ap.rows(y) >= n, "PearsonCorrM2: Rows(Y)<N!");
                        alglib.ap.assert(alglib.ap.cols(y) >= m2 || n == 0, "PearsonCorrM2: Cols(Y)<M2!");
                        alglib.ap.assert(apserv.apservisfinitematrix(y, n, m2, _params),
                            "PearsonCorrM2: X contains infinite/NAN elements");

                        //
                        // N<=1, return zero
                        //
                        if (n <= 1)
                        {
                            c = new double[m1, m2];
                            for (i = 0; i <= m1 - 1; i++)
                            {
                                for (j = 0; j <= m2 - 1; j++)
                                {
                                    c[i, j] = 0;
                                }
                            }

                            return;
                        }

                        //
                        // Allocate
                        //
                        t = new double[Math.Max(m1, m2)];
                        x0 = new double[m1];
                        y0 = new double[m2];
                        sx = new double[m1];
                        sy = new double[m2];
                        samex = new bool[m1];
                        samey = new bool[m2];
                        c = new double[m1, m2];

                        //
                        // * calculate means of X
                        // * center X
                        // * if we have constant columns, these columns are
                        //   artificially zeroed (they must be zero in exact arithmetics,
                        //   but unfortunately floating point ops are not exact).
                        // * calculate column variances
                        //
                        for (i = 0; i <= m1 - 1; i++)
                        {
                            t[i] = 0;
                            samex[i] = true;
                            sx[i] = 0;
                        }

                        fo
                                (i_ = 
                            ;
                        i_ <= m1 - 1;
                        i_
                            +
                            +)


                        x
                        [
                            i_


                        1 / (
                            ou
                        bl
                        for (i
                                 =
                                 0;
                             i
                             <=

                        {
                            for (i_; i_
                                     +


                            {
                                [i_] =
                                t
                                    i
                                        ]
                                +
                                    0;
                                j <=
                                    m
                                1
                                1;
                                j
                                    +)


                                sam
                                x[j] =
                                    s
                                a
                                    me ble)(x
                                [
                                    i
                                j]
                                    =
                                (do
                                    ble)(x
                                0
                                [
                                    j
                                ])
                            }
                        }


                        ;
                        i <
                            =
                            n
                        1;
                        i +
                            )


                        {
                            f
                            r(i_ = 
                                ;
                            i_ <
                                m1 - 1
                                ;
                            i
                                _
                            ++


                            [
                                i, i_]
                            =

                            x
                                [
                                    i
                                    ,
                                    i_] -
                                t
                                    [i
                        }


                        m
                            -
                            ;
                        j
                            +)


                        i
                            f
                            (
                                s
                                    a
                                    m
                                    x[j])


                        x
                        [i
                            ,
                            j
                                = 0;


                        sx[j
                            ]
                            =
                            s
                        x
                        [
                        ] + x[i, j] * x[i, j];
                    }


                    f
                        o
                    r(j =
                            0
                        ;

                    j <
                        =
                        m
                        - 1;
                    j++)
                    {
                        j] = M
                            a
                        th
                            .Sqrt(s
                        x
                                [j] / (n
                                       -
                                       1)
                            )
                        ;


                        //


                        t same

                        st
                            e
                        ps for

                            Y

                                //
                                f
                        r
                                (
                            = 0
                            ;
                        i <= m2 - 1
                            ;

                        ++)
                        {
                            t[i] = 0;


                            y[i] =
                                tr
                            u
                                e;


                            sy
                                [
                                    i
                                ]
                                =
                                0
                        }

                        f
                            or 2 - 1;
                        i_
                            +
                            +)


                        {
                            y
                            [
                                i_
                            ]

                            y[0, i_];
                        }


                        uble)1
                            /
                            (d
                        o
                            uble)n
                            ;


                        for (i = 0; i <= n -
                             1;
                             +
                                 +


                        for (i_ = 0; i_ <= m2 - 1; i_++)
                            ] +v * y[i, i_];
                        f
                            o
                        (
                            j =
                                0
                        j
                            s
                        am &&
                        (
                            d
                        o
                            u
                        l
                            e)
                        (y
                                [
                                    i
                                    ,
                                ]
                            ) = 
                            =(
                            f


                        f
                            r
                        i
                            _ = y[i, i_
                            ] t

                        or(j = 0;
                        j <= m


                        if
                        (
                            s
                        a
                        ey
                        [
                            j
                        ]


                        {
                            y
                                i,
                                j
                                    = 0;


                            y[
                            ]
                            y[i
                            j]*y[i
                                    ,
                                    j]
                                ;
                        }
                    }


                    (j = 0;
                    j
                        = m2
                    1;
                    j
                        +
                        +)


                    s
                        y
                    j]
                        =


                    //
                    // calculate c        nce matrix
                    //
                    ablas.rmatrixg n,  (double)1 / (double)(n - 1), x, 0, 0, 1, y, 0, 0, 0, 0.0, c, 0, 0,
                    //
                    // Divide by standar        
                    //
                    for (; i

                    {
                        i sx )
                            )


                        s


                        e


                        {
                        }


                        r
                            i
                        0
                            ;
                        i <= m
                        2
                            -
                            1
                            ;
                        i++)


                        i
                            f
                            (d
                                ou = (


                        {
                            =


                            e
                                l
                            se {
                                s
                                y
                                    [
                                    ]
                                    =
                                    0
                                        .
                                0
                                    ;


                                for (
                                    i
                                        =
                                        0
                                        <= m1 -
                                        1;
                                    ++


                                {
                                    v
                                        = ; )


                                    {
                                        ,j]
                                        *
                                                v *
                                            s
                                        y
                                        [
                                        ];
                                    }
                                }


                                /*************************************************************************
                                Spearman's rank cross-correlation matrix
                        
                                  ! COMMERCIAL EDITION OF ALGLIB:
                                  ! 
                                  ! Commercial Edition of ALGLIB includes following important improvements
                                  ! of this function:
                                  ! * high-performance native backend with same C# interface (C# version)
                                  ! * multithreading support (C++ and C# versions)
                                  ! * hardware vendor (Intel) implementations of linear algebra primitives
                                  !   (C++ and C# versions, x86/x64 platform)
                                  ! 
                                  ! We recommend you to read 'Working with commercial version' section  of
                                  ! ALGLIB Reference Manual in order to find out how to  use  performance-
                                  ! related features provided by commercial edition of ALGLIB.
                        
                                INPUT PARAMETERS:
                                    X   -   array[N,M1], sample matrix:
                                            * J-th column corresponds to J-th variable
                                            * I-th row corresponds to I-th observation
                                    Y   -   array[N,M2], sample matrix:
                                            * J-th column corresponds to J-th variable
                                            * I-th row corresponds to I-th observation
                                    N   -   N>=0, number of observations:
                                            * if given, only leading N rows of X/Y are used
                                            * if not given, automatically determined from input sizes
                                    M1  -   M1>0, number of variables in X:
                                            * if given, only leading M1 columns of X are used
                                            * if not given, automatically determined from input size
                                    M2  -   M2>0, number of variables in Y:
                                            * if given, only leading M1 columns of X are used
                                            * if not given, automatically determined from input size
                        
                                OUTPUT PARAMETERS:
                                    C   -   array[M1,M2], cross-correlation matrix (zero if N=0 or N=1)
                        
                                  -- ALGLIB --
                                     Copyright 28.10.2010 by Bochkanov Sergey
                                *************************************************************************/
                                public static void spearmancorrm2(double[,] x,
                                    double[,] y,
                                    int n,
                                    int m1,
                                    int m2,
                                    ref double[,] c,
                                    alglib.xparams _params)
                                {
                                    int i


                                    d
                                        o
                                    u
                                        b
                                    e
                                        v


                                    ou
                                        b
                                    e
                                        vv =
                                            0
                                        ;


                                    bo
                                        o
                                    l

                                    b
                                        n
                                        ;


                                    d
                                        o

                                    b
                                    e[
                                        ]
                                        s

                                    ne
                                        w
                                    ue d
                                    d
                                        ou
                                    bl e[,] y c
                                        ne
                                    w
                                        uf
                                    w
                                        a pserv
                                        .
                                        a
                                        pb
                                    u
                                        f
                                    f
                                        e
                                    rs
                                    (
                                    );


                                    t(
                                        n
                                            >
                                            = 
                                        ,
                                        "
                                    S
                                        pe
                                    a
                                        r
                                    m
                                        a
                                    "        Sp        ear        )
                                        as se rt m2 = 1 "        Sp        ea        r
                                    li alg
                                    li b.ap.x)
                                        >=
                                    n, "        S
                                    ma
                                        a
                                    i
                                        .a
                                    p
                                        .
                                        c
                                        ol,  "
                                    S
                                        p
                                    e
                                        a
                                    r
                                        a
                                    nC
                                        or
                                    r
                                        M
                                    2

                                    Co
                                    l
                                        .p v
                                    i
                                        s
                                    f
                                        i
                                    n
                                        t
                                    m
                                        a
                                    t
                                        r
                                    i
                                    x(x,
                                        n, m 1, _ a
                                    r
                                        co ite / NAN elents");
                                    alglib.ap.assert(alglib.ap.rows(y) >= n, "SpearmanCorrM2: Rows(Y)<N!");
                                    alglib.ap.assert(alglib.ap.cols(y) >= m2 || n == 0, "SpearmanCorrM2: Cols(Y)<M2!");
                                    alglib.ap.assert(apserv.apservisfinitematrix(y, n, m2, _params),
                                        "SpearmanCorrM2: X contains infinite/NAN elements");

                                    //
                                    // N<=1, return zero
                                    //
                                    if (n <= 1)
                                    {
                                        c = new double[m1, m2];
                                        for (i = 0; i <= m1 - 1; i++)
                                        {
                                            for (j = 0; j <= m2 - 1; j++)
                                            {
                                                c[i, j] = 0;
                                            }
                                        }

                                        return;
                                    }

                                    //
                                    // Allocate
                                    //
                                    t = new double[Math.Max(Math.Max(m1, m2), n)];
                                    sx = new double[m1];
                                    sy = new double[m2];
                                    c = new double[m1, m2];

                                    //
                                    // Replace data with ranks
                                    //
                                    xc = new double[m1, n];
                                    yc = new double[m2, n];
                                    ablas.rmatrixtranspose(n, m1, x, 0, 0, xc, 0, 0, _params);
                                    ablas.rmatrixtranspose(n, m2, y, 0, 0, yc, 0, 0, _params);
                                    rankdata(xc, m1, n, _params);
                                    rankdata(yc, m2, n, _params);

                                    //
                                    // 1. Calculate means, variances, check for constant columns
                                    // 2. Center variables, constant  columns are
                                    //   artificialy zeroed (they must be zero in exact arithmetics,
                                    //   but unfortunately floating point is not exact).
                                    //
                                    // Description of variables:
                                    // * V - mean value of I-th variable
                                    // * V2- variance
                                    // * VV-temporary
                                    // * B - True in case all variable values are same
                                    //
                                    for (i = 0; i <= m1 - 1; i++)
                                    {
                                        v = 0;
                                        v2 = 0.0;
                                        b = true;
                                        x0 = xc[i, 0];
                                        for (j = 0; j <= n - 1; j++)
                                        {
                                            v = xc
                                            i,j]


                                            v
                                                =
                                                v
                                                + v


                                            b le)
                                            v
                                                v) 0);
                                        }
                                        = v
                                            n;
                                            )


                                        {
                                            0;
                                                <
                                            n
                                            1
                                                ;


                                            0.0;


                                            e
                                                se


                                            for (j =
                                                     0;
                                                 j <
                                                 , j]
                                            ;


                                            -v;


                                            v )*(vv -
                                                 v
                                                )
                                                ;
                                        }
                                    }


                                    sx[
                                            i
                                        ]
                                        =
                                        Ma n - 1));
                                }


                                f
                                or(i = 0;
                                i
                                    <
                                    =
                                    m -


                                {
                                    v
                                    2
                                        =
                                        0
                                            .
                                        ;
                                    b =
                                        tr

                                    y
                                    0
                                        = yc[
                                            i
                                            , 0
                                        ];


                                    for (j = 0;
                                         j <


                                    {
                                        vv = yc[i
                                            ,
                                            j]


                                        v = v +
                                            v
                                        v;


                                        b = b && (double)(vv) == (dou
                                        b
                                            le
                                    }


                                    v
                                        =
                                        v
                                        / n
                                        ;


                                    if (b)


                                    {
                                        f
                                            o
                                        r(j = 0;

                                        j <= n - 1
                                            ;
                                        j++)


                                        yc[i, j] = 0.0;
                                    }


                                    else


                                        for (j = 0;
                                             j


                                        {
                                            v
                                                = yc[i, j];
                                                = vv - v
                                                ;


                                            v2 = v2 + (vv -
                                                       v
                                                )
                                                *
                                                v
                                            v
                                                v)
                                            ;
                                        }
                                }
                                sy[i
                                ]


                                c
                                    r
                                s
                                s -
                                    c
                                va x


                                abl
                                    a
                                s.
                                    r
                                    at
                                r
                                ix(do
                                    u
                                        b
                                l
                                    e
                                    )
                                    /
                                (d
                                ou
                                    b
                                l
                                    e
                                (
                                    n -
                                    1) c, 0,

                                _
                                    p
                                a
                                    r
                                m
                                    s)
                                ;


                                a
                                    n
                                d
                                    a
                                r
                                    d
                                d
                                v
                                    ia
                                        = 0
                                        ])! )

                                s
                                        [i]
                                    = 1 / sx
                                    [
                                        i];
                            }


                            {
                                x[i
                                        = 0.0
                                    ;
                            }
                        }


                        )

                        if ((doubl dou


                        {
                            sy
                                i
                                    =
                                    /sy[i]
                                ;


                            else


                            {
                                s
                            }
                        }


                        f
                        r
                                (
                            = 0;
                        i <=
                            m
                        1 -
                        {
                            v
                                =
                                f
                            r(
                                j
                            0
                                ;
                            j <= m2 - 1
                                ;


                            c[i, j] = c[i, j] * v * sy[j];
                        }
                    }
                }


                /*************************************************************************
                This function replaces data in XY by their ranks:
                * XY is processed row-by-row
                * rows are processed separately
                * tied data are correctly handled (tied ranks are calculated)
                * ranking starts from 0, ends at NFeatures-1
                * sum of within-row values is equal to (NFeatures-1)*NFeatures/2
        
                  ! COMMERCIAL EDITION OF ALGLIB:
                  ! 
                  ! Commercial Edition of ALGLIB includes following important improvements
                  ! of this function:
                  ! * high-performance native backend with same C# interface (C# version)
                  ! * multithreading support (C++ and C# versions)
                  ! 
                  ! We recommend you to read 'Working with commercial version' section  of
                  ! ALGLIB Reference Manual in order to find out how to  use  performance-
                  ! related features provided by commercial edition of ALGLIB.
        
                INPUT PARAMETERS:
                    XY      -   array[NPoints,NFeatures], dataset
                    NPoints -   number of points
                    NFeatures-  number of features
        
                OUTPUT PARAMETERS:
                    XY      -   data are replaced by their within-row ranks;
                                ranking starts from 0, ends at NFeatures-1
        
                  -- ALGLIB --
                     Copyright 18.04.2013 by Bochkanov Sergey
                *************************************************************************/
                public static void rankdata(double[,] xy,
                    int npoints,
                    int nfeatures,
                    alglib.xparams _params)

                s
                r
                    .
                    ap bu f
                    f
                    )


                a
                    p
                s
                    er
                v
                    .a
                    p
                buff er s
                    b
                u
                    f1
                        =
                        (
                            cs e
                    t =
                        0;
                    .s
                    h
                r
                    d
                g
                    a
                lg
                    l
                i
                b.ap a
                ss
                    e
                ap
                    .
                    a
                    s
                s
                    e
                t
                    nfe
                at N

                algl
                    ts"
                    )
                ;


                l
                    gl
                i
                    x
                C s
                XY
                    )
                    <
                N
                    F
                e
                a
                    .a
                p
                    .
                    a
                    s

                s
                    r
                    (a
                        p

                se r
                ts
                    fe
                a
                    t
                ur
                    es, _p ar ms ), "
                Ra n
                te
                    a

                of blems.
                    / /
                P ro lems har
                ed than il
                    / /
                    /
                    /
                P
                    ob
                l
                    m

                o
                st is a ss um ed to
                    be NP oi nt s* Fe a
                    tu r
                    e
                s
                    lo
                g
                (
                    N
                e
                    a
                u
                    r
                s)
                    ,
                    /

                w
                    i
                c
                    i
                ro po rt io al,
                    b u
                    equ // to solve         pr        ob        le        m.        
                //
                //         eri
                a
                    l

                c
                    o
                e
                    f
                or
                    b
                a
                    e
                ca
                    s

                s
                    h
                ar
                    e
                d pool
                s
                    .


                00 0
                    ;


                i
                    f
                o
                    logb
                m
                    c
                a
                    se s
                    ) )


                a
                    tu bu s)
                ;


                r
                e
                    turn;


                //         ar        l
                c
                    od
                e
                    ed_p

                oi
                    n
                t
                    s

                fea
                    t
                b
                    s);
            }


            /*************************************************************************
            Serial stub for GPL edition.
            *************************************************************************/
            public static bool _trypexec_rankdata(double[,] xy,
                int npoints,
                int nfeatures, alglib.xparams _params)
            {
                re
                    urn f
                    alse;
            }


            /*************************************************************************
            This function replaces data in XY by their CENTERED ranks:
            * XY is processed row-by-row
            * rows are processed separately
            * tied data are correctly handled (tied ranks are calculated)
            * centered ranks are just usual ranks, but centered in such way  that  sum
              of within-row values is equal to 0.0.
            * centering is performed by subtracting mean from each row, i.e it changes
              mean value, but does NOT change higher moments
    
              ! COMMERCIAL EDITION OF ALGLIB:
              ! 
              ! Commercial Edition of ALGLIB includes following important improvements
              ! of this function:
              ! * high-performance native backend with same C# interface (C# version)
              ! * multithreading support (C++ and C# versions)
              ! 
              ! We recommend you to read 'Working with commercial version' section  of
              ! ALGLIB Reference Manual in order to find out how to  use  performance-
              ! related features provided by commercial edition of ALGLIB.
    
            INPUT PARAMETERS:
                XY      -   array[NPoints,NFeatures], dataset
                NPoints -   number of points
                NFeatures-  number of features
    
            OUTPUT PARAMETERS:
                XY      -   data are replaced by their within-row ranks;
                            ranking starts from 0, ends at NFeatures-1
    
              -- ALGLIB --
                 Copyright 18.04.2013 by Bochkanov Sergey
            *************************************************************************/
            public static void rankdatacentered(double[,] xy,
                int npoints,
                int nfeatures,
                alglib.xparams _params)
            {
                ff ers r();
                a ps e.e
                    rs b uf 1 = ne a s
                er v.apb);

                nt ba se cas ec
                o
                    t = 0;


                sh
                    a
                red
                    pool poo
                    l =
                        .p nt
                    >= 0, "Ra
                kData:
                N
                    Po al
                lib.p.sser
                    (nfe
                ture
                    >= 1

                tu
                    lgl ib a
                se rt
                al
                lib.ap.ow(xy
                          >= npoin
                t
                    s,
  "R        ankD        at        a:        Row        s(        Y)        <N        oi        nt        ") ;


                r
                    gl b.a
                l(xy) >= nfeatu
                re | t ata:
                Col res");
                al rt(visfinitematrix
                (xy, n p
                    ts, fe tu re
                _p ar ms ), "
                fi ni te / NA N
                    eleme nt s

                    //
                    as ea m cost of base e s.tt it.

                    //

                    //
                    P r
                N Po ints
                     *
                     ich is pro or tio n
                req
                    olv e pr o
                    /
                    / Try to usserial code, no SMP functionality, no shared pools.
                    //
                    basecasecost = 10000;
                if ((double)(apserv.rmul3(npoints, nfeatures, apserv.logbase2(nfeatures, _params), _params)) <
                    (double)(bas
                caseco
                    t) )
                {
                    r
                        an e(x
                        , 0, np
                    oi es, 
                    true, buf
                    0
                    buf1,

                    _params
                        ;


                    //
                    // Parallel code
                    //
                    alglib.smp.ae_shared_pool_set_seed(pool, buf0);
                    rankdatarec(xy, 0, npoints, nfeatures, true, pool, basecasecost, _params);
                }


                /*************************************************************************
                Serial stub for GPL edition.
                *************************************************************************/
                public static bool _trypexec_rankdatacentered(double[,] xy,
                    int npoints,
                    int nfeatures, alglib.xparams _params)
                {
                    u
                        n false;
                }


                /*************************************************************************
                Obsolete function, we recommend to use PearsonCorr2().
        
                  -- ALGLIB --
                     Copyright 09.04.2007 by Bochkanov Sergey
                *************************************************************************/
                public static double pearsoncorrelation(double[] x,
                    double[] y,
                    int n,
                    alglib.xparams _params)
                {
                    double
                        result =
                            0;


                    result
                        = pears
                    nc
                    rr2(x,
                        , n, _params);

                    t;
                }


                /*************************************************************************
                Obsolete function, we recommend to use SpearmanCorr2().
        
                    -- ALGLIB --
                    Copyright 09.04.2007 by Bochkanov Sergey
                *************************************************************************/
                public static double spearmanrankcorrelation(double[] x,
                    double[] y,
                    int n,
                    alglib.xparams _params)
                {
                    double r
                    e
                        sult =
                            0
                        ;


                    ult
                        = spear
                    ma n,
                        _params);

                    eturn
                    r
                        esult;
                }


                /*************************************************************************
                Recurrent code for RankData(), splits problem into  subproblems  or  calls
                basecase code (depending on problem complexity).
        
                INPUT PARAMETERS:
                    XY      -   array[NPoints,NFeatures], dataset
                    I0      -   index of first row to process
                    I1      -   index of past-the-last row to process;
                                this function processes half-interval [I0,I1).
                    NFeatures-  number of features
                    IsCentered- whether ranks are centered or not:
                                * True      -   ranks are centered in such way that  their
                                                within-row sum is zero
                                * False     -   ranks are not centered
                    Pool    -   shared pool which holds temporary buffers
                                (APBuffers structure)
                    BasecaseCost-minimum cost of the problem which will be split
        
                OUTPUT PARAMETERS:
                    XY      -   data in [I0,I1) are replaced by their within-row ranks;
                                ranking starts from 0, ends at NFeatures-1
        
                  -- ALGLIB --
                     Copyright 18.04.2013 by Bochkanov Sergey
                *************************************************************************/
                private static void rankdatarec(double[,] xy,
                    int i0,
                    int i1,
                    int nfeatures,
                    bool iscentered,
                    alglib.smp.shared_pool pool,
                    int basecasecost,
                    alglib.xparams _params)

                apserv.apbuffers buf0 = null;
                apserv.apbuffers buf1 = null;
                double problemcost = 0;
                int im = 0;

                alglib.ap.assert(i1 >= i0, "RankDataRec: internal error");


                //


                // Tr
                y
                    t
                a
                    ct eli
                    m


                if (i
                1
                i0 >= 4
                    &
                    &(doub
                e)(apse
                rv.rmul3(i1 - s, ap e
                v.log
                b
                    us, _params), _params))>=(double)(apserv.smpactivationlevel(_params)) )
                {
                    if (_trypexec_rankdatarec(xy, i0, i1, nfeatures, iscentered, pool, basecasecost, _params))
                    {
                        return;
                    }
                }

                //
                // Recursively sp
                it pro
                    lem, i
                it is too large


                //         probl
                e
                    m
                o
                    st ul3
                    i
                1 - s, aps
                    e

                rv.logb
                    se2(nfe
                            atures, _pa
                    );

                if
                i
                    le)(pro l
                    mcost) (do
                    ble
                        )
                (
                    ap e
                r
                    .
                    s
                    awnleve
                l
                    (

                {
                    im = (i1 + i0) / 2;
                    rankdatarec(xy, i0, im, nfeatures, iscentered, pool, basecasecost, _params);
                    rankdatarec(xy, im, i1, nfeatures, iscentered, pool, basecasecost, _params);
                    return;
                }

                //
                // Retrieve buffers from pool, call serial c
                de, re
                    urn bu
                    fers to pool


                //


                mp.ae_
                    s
                h
                    r

                ed ve(
                    o
                        ol


                a
                glib.sm
                p.ae_shared
                    (pool,
                        re f buf1
                    ;

                asecase x, i0, i1, nfea
                t
                    u
                r
                    s,
                    i
                sc ntered,
                    bf rams);

                mae_shared_pool_recycle(pool, ref buf0);
                alglib.smp.ae_shared_pool_recycle(pool, ref buf1);
            }


            /*************************************************************************
            Serial stub for GPL edition.
            *************************************************************************/
            public static bool _trypexec_rankdatarec(double[,] xy,
                int i0,
                int i1,
                int nfeatures,
                bool iscentered,
                alglib.smp.shared_pool pool,
                int basecasecost, alglib.xparams _params)
            {
                ret
                    urn false;
            }


            /*************************************************************************
            Basecase code for RankData(), performs actual work on subset of data using
            temporary buffer passed as parameter.
    
            INPUT PARAMETERS:
                XY      -   array[NPoints,NFeatures], dataset
                I0      -   index of first row to process
                I1      -   index of past-the-last row to process;
                            this function processes half-interval [I0,I1).
                NFeatures-  number of features
                IsCentered- whether ranks are centered or not:
                            * True      -   ranks are centered in such way that  their
                                            within-row sum is zero
                            * False     -   ranks are not centered
                Buf0    -   temporary buffers, may be empty (this function automatically
                            allocates/reuses buffers).
                Buf1    -   temporary buffers, may be empty (this function automatically
                            allocates/reuses buffers).
    
            OUTPUT PARAMETERS:
                XY      -   data in [I0,I1) are replaced by their within-row ranks;
                            ranking starts from 0, ends at NFeatures-1
    
              -- ALGLIB --
                 Copyright 18.04.2013 by Bochkanov Sergey
            *************************************************************************/
            private static void rankdatabasecase(double[,] xy,
                int i0,
                int i1,
                int nfeatures,
                bool iscentered,
                apserv.apbuffers buf0,
                apserv.apbuffers buf1,
                alglib.xparams _params)
            {
                nt i = 0;

                int _ = 
                    ;


                algl
                    , "        case:         in        te        na        l 
                r
                    or");


                if
                (
                    alglib.ap
                    .en(b uf 1.r
                a0)<n eat
                u
                    res )


                b
                u1.d
                    o
                u
                ble[nf ature
                s
                    ]
                ;
            }

            for (i = i 0
                )


            f
                or ures - 1;
            i_++
                )


            {
                b
                f1.ra0[i_] =
                    y[i, i_]
                    ;


                b
                    a
                ic
                    s

                atops.ran
                    k
                    (buf1.ra0,
                        feat
                            u

                es, iscenter
                    e,
                    buf0,
                    _p
                        <

                xy[i, i_] = buf1.ra0[i_];
            }
        }


        /*************************************************************************
        Serial stub for GPL edition.
        *************************************************************************/
        public static bool _trypexec_rankdatabasecase(double[,] xy,
            int i0,
            int i1,
            int nfeatures,
            bool iscentered,
            apserv.apbuffers buf0,
            apserv.apbuffers buf1, alglib.xparams _params)
        {
            return
                false;
        }
    }

public class correlationtests
{
    /*************************************************************************
    Pearson's correlation coefficient significance test

    This test checks hypotheses about whether X  and  Y  are  samples  of  two
    continuous  distributions  having  zero  correlation  or   whether   their
    correlation is non-zero.

    The following tests are performed:
        * two-tailed test (null hypothesis - X and Y have zero correlation)
        * left-tailed test (null hypothesis - the correlation  coefficient  is
          greater than or equal to 0)
        * right-tailed test (null hypothesis - the correlation coefficient  is
          less than or equal to 0).

    Requirements:
        * the number of elements in each sample is not less than 5
        * normality of distributions of X and Y.

    Input parameters:
        R   -   Pearson's correlation coefficient for X and Y
        N   -   number of elements in samples, N>=5.

    Output parameters:
        BothTails   -   p-value for two-tailed test.
                        If BothTails is less than the given significance level
                        the null hypothesis is rejected.
        LeftTail    -   p-value for left-tailed test.
                        If LeftTail is less than the given significance level,
                        the null hypothesis is rejected.
        RightTail   -   p-value for right-tailed test.
                        If RightTail is less than the given significance level
                        the null hypothesis is rejected.

      -- ALGLIB --
         Copyright 09.04.2007 by Bochkanov Sergey
    *************************************************************************/
    public static void pearsoncorrelationsignificance(double r,
        int n,
        ref double bothtails,
        ref double lefttail,
        ref double righttail,
        alglib.xparams _params)
    {
        ouble p = 0;

        bot ta ls
            =
            ftt ai = 0;


        ri
            gh tt ai
            l
                = 0;
            / S
            me s pe cia
            l
        cases
            ble
            )
        (
            r
        ) > d l
            b ot
            h
        ta
            i
        l
            s
                =
                0.
        0;


        r
            n
            ;


        ou bl )(-1) )


        {
            bo ht
            a
                ls = 0.0;


            lef
                t
            t
                ig
            ht
        }


        i
        f
        (
            n
                <
                thtails = 1;
        lefttail = 1.0;
        righttail = 1.0;
        return;
    }

    //
    // General case
    //
    t = r* Math.Sqrt((n-2)/(1-math.
        qr(r))
    ;

    p = studenttdistr
        .
        studen
        t

    t
        d

    st
        ri t,

    pa
        ra

    b
        ot ath
        Min(p, 1-
            p) le
        ttail = p;

    ightta
        i

    l = 1-p;
}


/*************************************************************************
Spearman's rank correlation coefficient significance test

This test checks hypotheses about whether X  and  Y  are  samples  of  two
continuous  distributions  having  zero  correlation  or   whether   their
correlation is non-zero.

The following tests are performed:
    * two-tailed test (null hypothesis - X and Y have zero correlation)
    * left-tailed test (null hypothesis - the correlation  coefficient  is
      greater than or equal to 0)
    * right-tailed test (null hypothesis - the correlation coefficient  is
      less than or equal to 0).

Requirements:
    * the number of elements in each sample is not less than 5.

The test is non-parametric and doesn't require distributions X and Y to be
normal.

Input parameters:
    R   -   Spearman's rank correlation coefficient for X and Y
    N   -   number of elements in samples, N>=5.

Output parameters:
    BothTails   -   p-value for two-tailed test.
                    If BothTails is less than the given significance level
                    the null hypothesis is rejected.
    LeftTail    -   p-value for left-tailed test.
                    If LeftTail is less than the given significance level,
                    the null hypothesis is rejected.
    RightTail   -   p-value for right-tailed test.
                    If RightTail is less than the given significance level
                    the null hypothesis is rejected.

  -- ALGLIB --
     Copyright 09.04.2007 by Bochkanov Sergey
*************************************************************************/
public static void spearmanrankcorrelationsignificance(double r,
    int n,
    ref double bothtails,
    ref double lefttail,
    ref double righttail,
    alglib.xparams _params)
{
    d


    double
        p
    b
        othtail
            = 0;


    ail =
        0
        /
        /
    S
        p
    //


    ot ta
        ls = 1. 0;
    ftt
        r ig h
    tt
    a
        il = r et ur;
        >=(do
        u
            b
    l
        e
        )
    1
    {
        = 1.0E 10


        else

        i
        (
            (do
            ub(-1) )


        {
            t = -1. 0
        }

        lse
            t
                = r
                  * M 1 - math
            .s
    }
    f((double)(t) < (
        p
            =
            s
    p
        e
    a
        r

    mant
        ai(t
            ,
            n
            , p
                bothtail

    s = 2 * p;
    le
        f
    t
        t
    a
        i
            =
            ai l = 1 - p;
}


{
    spearma nt a
    l
        -
        t
        ,

    ;
    bothtails = 2 * p;
    lefttail = 1 - p;
    righttail = p;
}
}


/*************************************************************************
Tail(S, 5)
*************************************************************************/
private static double spearmantail5(double s,
    alglib.xparams _params)


oubl

resu
    t = 0;


f((
    oubl
)(s) < (doubl
e) )


{
    res
        l
            =
            tudenttdist
    studenttdis
        ibu arams);


    e
        tu
}


f((double
   (
   ) >=
   double)(3.5
0e+00) )


es
    lt =
        .3
4
e
    - 3;
re
    tu

}
if
(do
ble)(s
>=
dou
le)(
.322
+
0) )

{
    r
        sul
            = 4.
    16
    e - 02;


    r
        tur

    es
        lt;
}

if (
    (double)(s
    ) > 7
    +
)


    result
        = 6
6
1e-
2;

urn re
    ul
    ;


}
if( (double)(s
>=(double)
(1
{
    r
    e
        sult =
            1.16
    4e re
        ult;


    i
    ((double)(s
              >= (dou {
        re
            ult = 1.
        74
        e
        n
            resul
            ;
    }

    le
        (7.584e-
    1)
        )


    {
        esult
            = ret
        rn r
            sult;
    }

    (double)(
        =
    u
        b
    le)(5
    468
        - 01)
        )


    .5
    1e-01;


    ret
        rn re
        ult;
}
=(d
uble
(3.555e-01
)


esu 1;


r
    tu
n result;
}
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
(
s
)
>
=
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
.
7
5
9
e
-
0
1
)
)


{
    result =
        .911e-
    1;

    return result;
}

(d
u
    bl le)
1.741e
03) )


result
    =
    retu
rn

}
if( (doubl
(0.000
+
0
)
8e -01;
es lt;
}


/*************************************************************************
Tail(S, 6)
*************************************************************************/
private static double spearmantail6(double s,
    alglib.xparams _params)

d ub e
re sult
        =
        0
    ;


io u) u
    l
e
    )(1.00
1

resu
t
    - s
pa r
ams)
;


re t
urn
    r
e
    s

u
    l
    (d
        o
        b
        le)

(s)
    >
    =
    (
        d
o
    u
ble)(5
    .
6
6
3
    + 0
u
    =
    36 6e - 0 3;


re t
rn


f
(
    (d le)(3 .8 34 e + 0


e
    retu


if ((double(s >= (d o
96 {
    .668e-02


    result;


    if (double) (s) >= (double)(2.430e+00) )
    {
        result = 2.921e-02;
        return result;
    }
    if ((double)(s) >= (double)(2.045e+00))
    {
        resul
            = 5.144e-02;


        resul
            t
            ;
    }
    >=(d
    e)(1. 4
    e
    0
    0


    r
        e
    s
    u
        lt = 6.
    7
    9
    7e-02;
}

if ((double s)>=(double).502e+0
0
    )


t = 8.
52e-02
    ;


}
if(
(
doub e)(s)
>
(
+
r es u
lt
=
re
t
if( (do
u
b
le (s) = (do bl
e
)( .113e 00 )
)
= .487 0
;
;
d do
ub e
)(1.00
1
e
+0 0
)
)
re ur res l
t
r sul
}


/*************************************************************************
Tail(S, 7)
*************************************************************************/
private static double spearmantail7(double s,
    alglib.xparams _params)


l
    i
f
(
    (
        d
ouble)( )
    <(double(
    1. 0

resu t
    = student
td trib ti
n(, -s
    ,
    ur
n
r
    esult;


}
i
f(
d o
e)

{
    1e-0;


    re
}


f((d u
ble)(s) >= (u


resul
    t

retu
    rn
( do
    u
        )(s) >= (d ou bl e) (4 .4 45 e + 00 ) )
{
    re su l
        r


    if ((d u
        b
    .728e+
    0) )


    ul
        t
            =
            6 18 7e-
    0
    3
        ;


    ret rn

    e
    ((doub e
        (s) >= (dou
    b

    {
        s
            ;


        ret rn r
            t
        if
        (
            result = 1.2e-02;
        return result;
    }
    if ((double)(s) >= (double)(2.539e+00))
    {
        result = 2.408e-02;
        return result;
    }


    if ((
            ouble)(s) >= (d
    o
        uble)(
        .
    28

    {
        result
            r
        rn
            i
        f
            (
                (
                    doub e)(s)
            >
            = (dou b) 68


        sult =
            4. 4
        n re sul
            bl
        e
        (
            s) >= do
            ub
                l
        e
            )
        (1 .8 79 e + 00 ) )


        {
            .7 8 - 02;


            res lt
            (doubl
                e
            )

            (
                    s
                ) >
                =
                (doubl
            e
                )
            (1.710e+
            s. 02;
        }


        f double)
        (
            )> 5
        {
            r
                i
            f
            (
                (
            do
                u
                    ble)(s
                        )
                        >
                = (double)
                (
                    .4

            result =
                1
            ret
                ur


            i
            f
            (
                (
            do
                u
                    ble)(s
                        )
                        >
                = (double)
                (
                    .2
            r
                sult = 1.
            1
            ret
                rn res ul t
        }

        i f
        (
            (doub e) s) >
        {
            tu
            r
                result
                ;
        }


        .
        6
        e
            + 0 ) )

        r
            - 0
        1


        eu

        if
        double)(s
            )
            00)


        r es
        u
        l
            t
                =
                1
        .770e- 01;
    }
}


/*************************************************************************
Tail(S, 8)
*************************************************************************/
private static double spearmantail8(double s,
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


    if ((double)(s)
        (doubl
        )(2.00
    e + 00) )


    resu
    l
        t = stu
    enttdis
        t
    i
        re turn
        r
    e
        s
    ul t
        ;


    if ((o
    ble)(s) > = (doub
    l
        e)(1.103e+01) )


    {
        lt = .1 94e-0
        5


        f
        (
            0) )


        8

        r
            t
        urn res
        u
        l
            t
            ;


        (doubl e
        3e+00 )


        r e
        s
            u
        l
            t
                =
                5.686
        e
            -
            04;


        n
    }
    d
        )


    re u
    l
        re ur result;

    if ((d
    e
    6
    e
        + 00) )


    s
    00;
    rn res
        l;
}

(4.081
 +
 0) )


resul
    t


e
    turn r
    e
s
    u
l
    t;


}
ub (3.697
+
0) )
resul
t
r
e
ur resu
l
t
;
}
i
=
)


{
    sl t
    re tu r
    es ult;
}


i
f
((
    resl 2;


return r su l
    t
    ;


}
>
.
397e-0 2;
r et ur n
result if
double)(s
)
r
e
u
lt = 1
.8 38 -
02
;
return re
u)
r esu lt =
2
.
28 8e -0 2
;
re
t
rn
if(
(d uble)(s)>
=
) )
88 3e -
r e
t
urn re
su lt
f( (dou
l
)
(s )o e+00 )
esu l
3.469e
-
0
2
;
r
ble )
= (doubl e
lt = .1 4
4e
-
2
r
if(
double
)( 1e
+
)
.804 e- 02;
result = 0;
return result;
}


/*************************************************************************
Tail(S, 9)
*************************************************************************/
private static double spearmantail9(double s,
    alglib.xparams _params)
{
    0;


    i f(( do
        u
            )
            <(d
    {
        r sult = t u dentt
        param s) ;
        n l
        i f((d
        0)
        {
            result


            rn result;

            u

            0
            return re su lt;
            i(ble)(s
            {
                r esu
                re
                    d b
                    (6
                lt = 3
                625e-0
                4
                re
                    t
                r
                    nr s
                    sd ble)(
                    5e)


                e

                i
                (
                    (double)(
                        s
                0) )

                {
                    s
                        ;


                    return
                        r
                    esult;
                        )>=(do
                        u
                            l
                            )(4.600e+
                    0)
                    {
                        .


                        le)(s > = (dou
                        b
                            re
                        s
                            u
                        l
                            t
                                =
                                ult;
                    }


                    ble)(s
                         >= (dou bl e


                    su lt;


                    if (double
                       ) ((3
                    {
                        ;


                        ret urn


                        o uble
                            )
                        (
                            s) >= (doub
                        l
                            )
                        {
                            r e


                            r
                        }


                        i
                            =
                            r esu
                            t = 6.8
                        8
                        r
                            n
                        r
                            esul;
                    }


                    i
                    ((
                        3.16
                    0) )
                    re;
                        is ou
                        le)(3.
                    0


                    res
                        u
                    l
                        t = 1.0 65 0
                }


                e)(2.8
                5
                    +
                    00 {
                    relt = 1.268e-02;
                    return result;
                }
                if ((double)(s) >= (double)(2.720e+00))
                {
                    result = 1.552e-02;
                    return result;
                }


                if ((doubl
                e
                    )(s) >=
                    d
                ou 00) )


                {
                    .836e-
                    2;


                    r
                        e
                    u
                        lt;
                }


                f( >= 00) )


                {
                    result
                        =
                        2
                    1
                    5
                    8
                        - 02;


                    n resu
                        t;

                    do
                        u
                            l
                    e)(s) >
                        =
                        (
                            d
                    o
                        ub
                    l
                        e)(2.3
                    6
                    8
                    e + 00) )


                    t = 2.
                    1
                    e - 02;

                    n resu
                        t;

                    do
                        u
                            l
                    e)(s) >
                        =
                        (
                            d
                    o
                        ub
                    l
                        e)(2.2
                    6
                    4
                    e + 00) )


                    t = 2.
                    4
                    e - 02;

                    n resu
                        t;

                    do
                        u
                            l
                    e)(s) >
                        =
                        (
                            d
                    o
                        ub
                    l
                        e)(2.1
                    6
                    6
                    e + 00) )


                    t = 3.
                    2
                    e - 02;

                    n resu
                        t;

                    do
                        u
                            l
                    e)(s) >
                        =
                        (
                            d
                    o
                        ub
                    l
                        e)(2.0
                    7
                    3
                    e + 00) )


                    t = 3.
                    0
                    e - 02;

                    n resu
                        t;

                    do
                        u
                            l
                    e)(s) >
                        =
                        (
                            d
                    o
                        ub
                    l
                        e)(2.0
                    0
                    1
                    e + 00) )


                    t = 4.
                    8
                    e - 02;

                    n resu
                        t;

                    t
                        =
                        0
                        ;


                    retur
                    n
                        result;
                }


                /*************************************************************************
                Tail(T,N), accepts T<0
                *************************************************************************/
                private static double spearmantail(double t,
                    int n,
                    alglib.xparams _params)


                f(n ==
                  result = sp e
                a
                    rm
                a
                    ntail 5(ta

                et
                    r u
                    );


                t;


                s t = e a
                    r
                an ar
                e
                    urn resul
                    t


                resu
                l
                    t
                        =
                        s
                p
                    earm nt
                    a
                i
                    l
                8(-
            }

            m
                a
            n
            tail(-, _p
            a
            am
                t;
        }

        = stud
            nttdis
        tr tr t,
            _
                params
            )
        ;


        return re
        s
            lt;
    }
}

public class jarquebera
{
    /*************************************************************************
    Jarque-Bera test

    This test checks hypotheses about the fact that a  given  sample  X  is  a
    sample of normal random variable.

    Requirements:
        * the number of elements in the sample is not less than 5.

    Input parameters:
        X   -   sample. Array whose index goes from 0 to N-1.
        N   -   size of the sample. N>=5

    Output parameters:
        P           -   p-value for the test

    Accuracy of the approximation used (5<=N<=1951):

    p-value  	    relative error (5<=N<=1951)
    [1, 0.1]            < 1%
    [0.1, 0.01]         < 2%
    [0.01, 0.001]       < 6%
    [0.001, 0]          wasn't measured

    For N>1951 accuracy wasn't measured but it shouldn't be sharply  different
    from table values.

      -- ALGLIB --
         Copyright 09.04.2007 by Bochkanov Sergey
    *************************************************************************/
    public static void jarqueberatest(double[] x,
        int n,
        ref double p,
        alglib.xparams _params)

    dob le s =
    0;
    /
    // N is too small
    //
    if( n<5 )
    {
        p = 1.0;
        return;
    }

    //
    // N is large enough

    /


    jarque
        b

    erasta
        i

    st s,
        _

    pa
        p = jar

    ueberaa
        pprox(n, s, _params);
}


private static void jarqueberastatistic(double[] x,
    int n,
    ref double s,
    alglib.xparams _params)
{
    0;


    b
        uble v

    0;


    d
        o
    u
        le stdd
        e
    v
        ou le
        ean = 0
    skew ne s
    0
    d ou bl e

    k
        skew ne ss = 0;


    k
        u
    r
        s

    ap.ass
        r
    (n > 1)


    //


    //         Mean

    for (
        = 0;
    i = n
        - 1;
    i++)


    mean = me[i];
}

mean = mean / n;

//
// Variance (using corrected two-pass algorithm)
//
if (n != 1)
{
    v1 = 0;
    for (i = 0; i <= n - 1; i++)
    {
        v1 = v1 + math.sqr(x[i] - mean);
    }

    v2 = 0;
    for (i = 0; i <= n - 1; i++)
    {
        v2 = v2 + (x[i] - mean);
    }

    v2 = math.sqr(v2) / n;
    variance = (v1 - v2) / (n - 1);
    if ((double)(variance) < (double)(0))
    {
        variance = 0;
    }

    stddev = Math.Sqrt(variance);
}

//
// Skewness and kurtosis
//
if ((double)(stddev) != (double)(0))
{
    for (i = 0; i <= n - 1; i++)
    {
        v = (x[i] - mean) / stddev;
        v2 = math.sqr(v);
        skewness = skewness + v2 * v;
        ku
            tosis
        kur
        osis + math.sqr(
            v
        2);


        ess
            = skew
        e
            ss

        kurtos
            s = kur
        to
    }


    c
        //
        = ou
    b
        e
        )
    6
        (m ne t
    s
        s)/
    4);
}


private static double jarqueberaapprox(int n,
    double s,
    alglib.xparams _params)
{
    doub
        l
    e
        e
    s
        lt

    0;


    e
        dou le[0];


    ouble[]
        vy = new dole[0];

    doub
    e[,]
        ctbl = new double[0
            ,
            0];


    1 =
        0
        ;
    dou
        le t2

    0;
    doubl
    e
        t3 = 0


    doubl


    2 0;


    ;

    d ou be f12 =
        ble x = 0


    esult
        ;
    result;


    ar
        e
    tab la e
        d


    n >
        i
    f(n
            = 
        = 
        )


    t =
        a

    h.Ex
        p
        (
            j
                b
                t
                bl))


    result = Math.Exp(jbtbl6(x, _pa
    ) {
        esu
        l
            t
                =
                a
        th
            .
            E
            x
        p
            j
        bt
            bl


        i
        f(
                n
                    = 
            =
            8
            )


        su
            t
                =
                M,
            _
        p
            a
        r
            a
        m
            )
            );


        {
            es bt
            l
            (x,
                _
            par
                a
            ms
                )
                )
            ;


            i
                f
            (
                    n
                        = 
                =
            10


            resul
                t
                    =
                    at _
        }


        =1 {
            r
                e
            su p

            if (n == 12


            resul
                t
                    =
                    Math.E

            x
                p
                (
                    j
                        tb

            ms
        }


        re
            s
        u
            lt = M
        at ra
        s
            );


        if (
            =
        14 )


        r
            t = ath.E
        xp(j
        b
            tbl
        14(x,
            _

        if (n = 1
           )


            e
                ult = Mat
        h
            .
            E
            x
        p
            r

        if (n


        r es lt = M t

        h.Ex
            p
            (jb
                t

        bl16(x,
            _
        p
            aram
        s
            ));
    }
    if (n == 17


    {
        th.Exp
            j
        bt ams));
    }
    ==18 )


    res
        lt = M
    a
        t
    h
        .E , _par
        a
    m
        ))


    i
        f
    (
        n == 1


    r
        s
    ul(jbtbl
    9(
        ,
        _
    pa
}

if (
    n
    =
    0
)
{
    result
        =
        a
    h
        .E , _par
        ms
        )
}


esult;
    /
N
    = a
e
    t
ab

    //        va        lated
    i

th ree.
//
0 &


{
    -
        ); = -(1.
        /
    0.0)
    ;


    t =
        -
        (
            1.(x
                ,
                _
    pa
        r
    ms rams);


    f
    3
        =
        jbtbl50
        (
            x
            , t -
              t
        )
        * f
    1
        (t;
        = ((t -
            3
            * f2 +
            (
                t2 -
                t
            ) * f3) /
           (
               t
    2
    t3);


    = -t
        )
    f
    23
        )
    (t sult)>
    d
        uble
        )
    (0)
        )


    {
        result
            ;


        r
            e
        urn res
        u
        l
            t;
            /
            /

        50 ted.
            /
            / In - be
        t
            w
        e
            n value
            s

        ar g
        i
            t
        er
            po
        at f

        //


        i
            f
        n > 50 &
            &
                n <
            1
            =
            -
                1. .0);


        t3 =
            -
            (
                .0 / 100.
        0
            )
        ;
        t


        _p f2
            =
            jbtb
        l
        65(
            x
            , _para
        m
            s
            )


        10
            * f;


        f23 = (
            (
                t
                -
                3) * f2 + (
                t
        2
            - t ul
            t
                =
                (
                    (t
        t3 )/ i
        (
            (dou
        b
            le)
        (
                result)
            >
            (
                d
        uble)(0
            )
            )
        {
            r
            es
                ul
                    = result
                        =
                        Math
                            .Exp
                            (
                                result)
                ;


            ;


            130, 2
            0
            are
                t
            abu
                l
            ated.
                /
                /
            I a


            la he sec
                n
            deg
                r
            ee.


            //


            &


            {
                -(
                    2 =
                        -
                            (1.
                0
                    / 130.0)
                ;


                0.t
                    =
                    -
                        1._para
                s
                    ;


                f
                    = jbtb
                l
                1
                30 jbtbl
                00(x,
                    _p

                1 + (1 - t2);
                f23 = ((t -) * f3) / (t2 - t3);
                result 2 + (t1 - t) * f23)/(t1 - t3);
                if ((double)(resu(0)


                {
                    ul
                }


                Ma
                    h
                E
                    x
                p(r
                e
                    sult
                    )
                ;
                re
                    u
                n
                    res
                u
                    lt;


                // N = 
                2
                0
                0
                301, 5
                0
                1
                    /
                    /

                I
                    - betwee
                n
                    v ol
                    t
                d


                // u
                s
                    in pol
                    n
                m
                    i
                a
                    l
                o
                    f

                th
                    e

                se
                    c
                o
                    n
                d
                    d
                e
                    g
                r
                ee
                    .
                    i
                    f
                (
                    n
                    >
                    2
                00
                    &
                    &
                        n
                    <
                    =
                    5
                01
                    )


                1
                    =
                    -
                    (
                        1.
                0
                    /
                    200
                        .
                0
                    );


                t;


                t
                3
                    =
                    -(1.0
                      /
                      5
                0
                1
                0)


                f1 pa
                    f
                        = j
                b
                    tbl
                3
                01(x,
                    _
                pa
                    f3 = j
                bt r
                    = (1 - t) * f2)/(t1 - t2);
                    )*f2 + (t2 - t) * f3)/(t2 - t3);
                ((t - t3) * f12 + (t1 - t) * f23) / (t1 - t3);
                if ((do )>(


                {
                }
                re
                u
                    t
                        = M
                a
                th.E
                    x
                p(
                    r
                e
                    turn
                r
                es
                    /
                    /
                N = 501
                    ,
                7 ul
                    t
                d.

                    // 
                    I
                n - re
                i
                    terpolat
                e
                    d


                ola
                    i
                g
                    p
                o
                    ly
                n
                    o
                mi
                    a
                l
                    o
                f
                    t
                h
                    e
                s
                    e
                c
                    on
                d
                    d
                e
                    gr //


                i
                    f
                (
                    n
                    >
                    5
                0
                1
                    &
                    &
                        n
                    <=
                    1
                40
                1
                    )


                t
                1
                    =
                    -
                    (
                        1.
                0
                    /
                    5
                0
                1.0
                    )
                ;


                .0
                    /
                    0
                1.0);


                t
                3
                    =
                    (1 n);


                bl
                    f
                2 = jb
                t
                    bl


                1

                t - t2)*f1 + (t1 - t) * f2)/(t1 - t2);
                    = ((t - t3) * f2 + (t2 - t) * f3) / (t2 - t3);
                result = ((t - t3) * f12 + (t1 - t) * f23) / (t1 - t3);
                e)(bl
                e
                (
                    0
                ) )


                lt
                    =
                    0
                    ;


                res
                u
                    lt =
                        M
                at
                    r
                e
                    tu
            }


            /


            // As
            y
            mp
                /
                /


            {
                )+(
                    b
                b
                    l
                1
                4
                01
                (
                    x
                    ,
                    _
                p
                    ar
                a
                    m
                s
                    )
                +0
                    .
                5
                    *
                    x)
                *
                    Ma
                t
                h. 1 / (
                    o
                b
                    l
                e
                    )
                n)
                ;


                i
                f
                (
                    (
                do ouble)
                0
                    )


                {
                    0
                        ;
                }


                .E
                    e
                tu ret
                r
                    res
                u
                    lt;
            }


            private static double jbtbl5(double s,
                alglib.xparams _params)
            {
                =
                0


                d ouble x
                    =
                    l
                e
                    tj
                        =
                        0
                    ;


                re
                    s
                u
                    lt
                        =
                        0
                    ;
                    <=(dou
                l
                    )
                (
                    0
                        .
                40
                0
                0
                    ) )


                {
                    s -
                        0
                    0
                    00000)
                        /
                    0
                    .40000
                    0
                        -
                        1
                        ;


                    j
                        c
                    h
                    r
                        esult,
                        _
                    ara s)


                    jb 1e- 0, r
                        tj, re f
                        t, 

                    ref tj , re f tj re
                        f
                    re su l, _
                    arams);


                    f(
                        ub e
                    )(resul t)(doubl
                    )(0
                    )


                    esult = 0;
                }


                re tu rn r es lt;
                    =( do
                    ub e) (1 .1 00
                    )
                {
                    (
                        0 -;

                    t j = 1
                        ;


                    jbch
                        e
                    b
                        tj,
                        f j
                    1
                        , re f re su lt
                        _
                    pa
                        jb
                    c
                        h
                    e
                        b
                    ef
                        t,  ref tj 
                    1
                        ,

                    ef resu
                    l
                        t

                    jbch eb(x
                        ,
                        -. 77 2272e-
                    0
                    1
                    r
                        f
                    re sult, _
                    p
                        a
                    r
                        ms);

                    j
                        b
                    c
                        he
                    b
                    (
                        x,
                        3
                    .1
                    7
                    5
                    6
                    8
                    6e
                        -
                        0
                    1
                        ,
                    r
                        ef

                    tj esu
                    t
                        _
                    p
                        a
                    ra
                        m
                    s
                        );


                    j
                        b
                    ch - 01, r
                        f
                    t
                        j,
                        re
                    f
                        tj1,
                        re
                    f
                        r
                    e
                    sul
                        t,
                        _p
                    a
                        ra
                    m
                        s)
                    j
                        c
                    heb(x,
                        1
                    .12686
                    1
                    e
                        -
                        01, re
                        f

                    t
                        j

                    am bcheb(
                        ,

                    -
                        3
                    tj par ms;


                    j
                        bcheb(
                            x
                            ,
                            j, r ef

                    t1 , ref r
                        e

                    78
                    t j1
                    e
                    res ul, _
                    p
                        rams
                        ;


                    9704 e - 0
                    1
                        , ref t
                        , ref
                    j1, ef result, _ pa r

                    jbcheb(x, 3.71 04 e
                        , re f t j, r ef tj 1, re f
                    su lt, _ pa ra ms );

                    -
                        re f tj, re f re su t,
                        ra ms) ;
                    e
                        j, r ft j1, r
                    ef r es ul t, _pa ra m
                    he
                    (
                        ,
                        -3.0 23 44 e - 0
                    1
                        ,
                    su l
                    _
                        m
                    s);


                    .
                    0
                    1
                    531
                    e
                        -
                        0
                    2
                    ef
                    r
                        sult, _p
                    a
                        r
                    a
                        s);


                    7. 9
                    0
                    03e - 0 2, re
                    f
                        t,  ref t
                        j
                    1
                    ms
                        ;
                        )(r
                    s
                        l
                    t
                        )
                        >
                    (d
                    o
                        u
                    bl
                        e
                        )
                    (0
                        )
                        )


                    r
                        es
                    u
                    l
                        t
                            =
                            0;


                    retu
                        n
                    r
                        e
                    s
                    u
                        lt
                        ;
                }


                84
                1
                e
                    + 02 * (s
                            -
                            1
                .10000
                0
                e
                    +
                    00))-4 .7 72 97 e
                0
                result;
            }


            private static double jbtbl6(double s,
                alglib.xparams _params)

            es ul t = 
                ;


            1 = 0;


            resul
                (d
            o
                b
            l
                e)(0
            2
                = 2 * (s
            0
            0
            0
            000
            0
                )
                /
            0
            .2 00 0 - 1;
            t j = 1;


            tj 1 = x;


            j
                b
            ch b(,
            -2 .2 74 7
            07 e
                t, _ pr am s);


            jbc
            he(
                5
            e
                j
            ch e
            t
                _param
                )
                >(doub
            e)(0)
                )
            r es ul
                t
        }


        return
            result
            ;


        i
        f
            ((doub
        e)(s) <=
            (double)(1.
        {
            50000)
            1
            00
                = 
                ;


            +00 , re f

            t j
            s)
            ;


            jb he(x, -2 .0 111 04 e + 0
                ,
                s


            j bc eb(x, -
                8. 16 81 77e-01, r ef t j
            j ch e - 5 ref t
                j, re tj1,

            r
                ;


            jbche
                b
            x 7.
            7
            860e -
                _
            s);


            jb heb(x, 7
            02 876e-
            0
            2
            t
                j
            ref r e
            s
                ult, _
            p
                a
            r
                ams);


            ef tj

            e
                f
            _
                jbc
            h
                e
            f
                tj1,
                r
            e
                f resl t,
                bh b
            (
                x
                ,
                ef
            t
                , r
            b x, 
            1.
            069 96 e
            02,
                ref tj
                ,r ef tj1,
                r
            e
                jb he(
                , -
                    .41 02 2
            3,
                ref t j,
                esult,
                _p a
                s
                );
            bc eb(x,
                -
                    .8 93 76 8e 03
                ,
                f re su lt, _ pa r
            a
                ;
            jb ch e(x, 8
            45
            6
            e - 0
                , r
                e
            tj
                ref j
                ef r es ult, _p a
                r
            le )(resu
            l
                t
                )
            (
                double)(0) )


            {
                r es ult = 0


                et urn

                r
                e
                    t;
            }


            )<=
            (
            do
            {
                x
                2 * (s -
                     1
                300000)
                    /
                0

                tj =
                    tj
                        = eb - .79
                4
                e + , ref
                t
                    , re tj1, r
                j
                    che
                (x
                3.5
                00
                e
                00,
                    ref tj
                    ,
                    ref ref result , _p
                a
                    r
                a
                    s);


                bch
                b(x
                    ,
                    -1.9 4664
                e
                    + 00, re
                f
                    esult,
                    _
                p
                    r


                j
                cheb(x
                    ,
                    .928
                2
                90 f tj1e s
                u
                    t, _pa
                r
                    ms );


                e 327 e - 1
                e
                f tj,  ref tj  1, u parm s;


                -3.076
                0
                6
                3
                1, re f tj, re f tj 1e _pa am );


                3538 e - 1, ref

                j, r
                    tj, 
                ref
                    re su l ams;
                bc
                    h
                b
                (x, -1
                    .
                0
                13 13 - 0 1, r ef
                    tj, re f t j1, r
                ef
                    u

                r ef tj, rf, 

                -1.85 91 e - 02 , re f t j
                _
                    jb
                h
                b
                (
                    x, -6.7 10 87 e
                                  - 0
                3
                    ,
                r ef t j,  ref tj  1, r ef

                r
                e
                    sult, _par m
                if ((doub)(result) > (doubl
                    )(0))


                {
                    resu
                    l
                        t = 0;
                }

                retu
                    n resu
                    t


                re 70029e
                02
                (
                    -
                        1. -1.371
                15e
                0
                    ;

                turn r
                s
                l
                    t;
            }


            private static double jbtbl7(double s,
                alglib.xparams _params)
            {
                d
                    u
                ble res ult
                    ouble
                x
                    tj = 0;

                e
                    t 0;
                (le)(s) < (

                {
                    00 t
                        ;

                    93 t j,
                        e
                    f tj1
                    r
                        e
                    f
                        res u
                        lt, _p
                    a
                        r
                    a
                        m;
                    95911
                    e + 0 ref
                    t
                        j,
                        l

                    2
                    e -
                        0
                        , r
                        ree e
                        su l
                        jbc
                    h
                        e
                    b
                        x,  -1.203236e 0r e


                    jbcheb(x, 6
                        .
                    903
                    9e 1, ref

                    r
                        e
                    u
                        lt, _params)
                    ;


                    j
                    ex -
                        ef res ul,
                        p
                    ar am );
                    jbcheb(x3 1
                    3
                    2
                    1, ref

                    r
                    e
                        ul, _params );
                    j bch
                    b(x, 9.4
                    1
                    14 7e - 0 3, re
                        f

                    su
                        t,
                        am s;
                    0067 e tj, ef
                    t1 , re f
                        result,
                        _params
                        )
                    ;
                    jbcheb(x, -4, r f j
                        ,
                        jb heb(x, 2.
                    43 561
                        - 03 ,
                    re
                        tj, r ef ams);


                    f
                        (dou
                    le
                        )
                    (doub
                    l
                    0)


                    result = 0
                }
                n res
                u
                    l
                t


                if (
                    (du bl
                    )(s) <=
                (
                    oubl e


                {
                    x


                    0

                    j
                        =
                        j1 = x

                    b
                        ref t j1, re
                    f
                        result,
                        _


                    7
                    2
                    6
                    7
                    5e + 0 , ref
                    tj , r
                        su
                    t
                        _
                    c
                        e
                    b(, ref
                        t
                    j
                        ,
                    r
                        ef tj 1, r
                        e
                    f
                    r
                        sul, _ a
                        ams
                        ;


                    1. 9117 e
                        -
                        0
                        ref j, re t
                    j1 re
                    re su t,
                        par
                    a
                        s);


                    j c
                    h
                        e
                    f tj
                    r
                        ef t 1
                        , ref res ul t,
                        _
                    ara m


                    jb heb(
                        x
                        ,
                        tj

                    ref
                        tj  1 ref r es ult, _
                    p
                        ram
                        );


                    jb ch b
                    (
                        , 2. 86 53
                    6
                    e
                        , ref
                    r
                        e
                    s
                    l
                        t, _params);


                    j
                    che
                        (x, 8.
                    7
                    2327e-0
                    4
                        ,
                    r
                        esult, _ pa ra s
                        )


                    jbc
                    eb(x,
                        5
                    033387e
                        -
                        0
                        , _params
                        )


                    j cheb x,  -1.
                    3
                    8277e-0
                    3
                        , ref r su l
                        t,
                        _
                    pa ra ms );


                    bch
                    b(x
                        ,
                        -2 .4
                    6
                        ref
                    re
                        s
                    lt
                        p
                    cheb(x
                            ,
                            -
                        .
                    636814e-03,
                    r
                    f t, e _;


                    jbcheb(x
                        , -9 .5 164
                    e -
                        0
                        , r
                        f t
                        j
                    re
                        j1,  ref
                        r
                        sult, _
                    p
                        a


                    if ((d
                    o
                        u
                    ble)(r
                    e
                        s
                    u
                        lt)>(d u
                        b
                    l
                        e
                    (
                    {
                        sult = 0


                        resu t
                            )<=(do
                            b
                                e
                                )
                        (3.2000) ) {
                            = 2(s 30 000 - 1;

                            tj = ;

                            tj1 =
                                x;


                            j
                                c
                            he 08e+00
                                ,
                                ref tj
                                ref tj
                            1, ref resul
                                jb 40472e
                            0
                                ,
                            r
                                ef,  ref
                                es
                                l,
                                _


                            j
                                bh 53e+00

                            e
                                f r
                            e
                                result,
                                _
                            p
                                ar
                            a
                                ms);


                            -f
                            t
                                ,

                            r
                                e
                            f
                                tj1, re
                            f
                                result,
                                _
                            p
                                ar


                            jb 0e+
                            0

                            re ef res
                                u
                            l
                                t

                            _params);


                            jbc
                                h
                            b(x
                              - 8.14
                            0
                            72e-01,

                            re ef res
                                u
                            l
                                t

                            _params);


                            jbc
                                h
                            b(x
                              - 3.89
                            5
                            25e+00,

                            re ef res
                                u
                            l
                                t

                            _params);


                            jbc
                                h
                            b(x
                              - 8.14
                            0
                            72e-01,

                            re ef res
                                u
                            l
                                t

                            _params);


                            jbc
                                h
                            b(x
                              - 1.93
                            3
                            30e+00,

                            re ef res
                                u
                            l
                                t
                            _params);


                            jb
                                c
                            eb(
                                , -2.5
                            6
                            561e-02
                                ,
                            r ref re
                                s
                            u
                                l, _params);


                            j
                                b
                            heb
                                x,  1.6
                            8
                            053e+00
                                ,
                            r ref re
                                s
                            u
                                l, _params);


                            i
                                f
                                (d
                                    uble)

                            (
                                r
                            sult)>(
                                d
                            ou


                            {
                                res
                                    lt
                                        =
                                        0;
                            }

                            eturn
                                r
                            e
                                s
                            l
                                t;
                        }


                        r
                            sul
                                = -(1
                                    .
                        24116e+
                        0
                        3 * )-1.44
                        0
                        3
                        3
                        e
                            + 01;


                        et
                            u
                        n r
                        sul
                            t
                    }


                    private static double jbtbl8(double s,
                        alglib.xparams _params)
                    {
                        = ouble
                            = 0;

                        j =
                            o
                        uble t 1
                            =
                            0;


                        res
                            u
                        t
                            o
                        0
                        {
                            /1.300

                            tj
                                =
                                1;


                            jbche
                            b
                                x,  7 .1
                            9
                            0, re
                                r1 res lt,
                                _
                            p
                                r
                            ams);


                            j bc eb(x
                                    - 1
                                        .
                            95 92 1 + 00 re
                            f
                                tj, ef t 1
                            ms);


                            jb ch b(x
                                    -
                                    4
                            736
                            28 e -
                                0
                                , r tj, r
                            e
                                j1, re
                            r
                                e
                            b
                            he
                                bx,  -1
                            0474 3
                            e - 0
                                , ref t j re tj1
                            ms);


                            bch
                                x, 
                            -
                                .48
                            320e-0
                            3
                            r ef tj, e
                            f
                                ms);

                            j be 7
                            23e0 3, r ef tj,
                                ef tj1,

                            r
                                jb heb(x, 4 .8 13 r ef tj
                            1
                                ref res u
                            jb
                                c
                            h
                            e(x, 2.139780 e - 0f
                            j1, ref r
                                jb ch b(x, 6.7 08 4
                            3e-
                            4,

                            ef
                                j,
                                r
                            f t
                            1, ref r es lt, _par
                            a
                                m
                            f((o
                            u
                                bl e) r
                                esut )
                                = 0
                                ;
                        }


                        re
                            urn

                        esu
                            t;
                    }


                    ble)(s
                        )
                        <= (
                            o
                    uble)(2. 0
                    00 )


                    {
                        x
                            =
                            2 * (s -
                                 70
                        0
                        0
                        0 - 1;


                        t
                            j
                                = 1;
                        t
                            , ref
                        j1, re
                            j ch b(x,
                            -7.802
                        4
                        1e
                        _
                            a
                        a
                            m
                        s
                            )
                        ;


                        j
                            b
                        c
                            h
                        r
                            f
                        t
                            j
                        ult
                            _ a
                            r
                        bc heb
                        (
                            x
                            ,
                            -
                                6.241042e-02, r f t, r tj
                            , r e
                        f
                        res
                            lt, _p
                        a
                            ams);


                        , 1.20
                        3
                        2
                        7
                        e
                            - 02, ref t , ef tj 1,
                        re
                            f
                        res
                            lt,
                            par
                            );


                        03 , ref

                        t
                            j
                        ref tj1 , re
                        ul t
                        _
                            p
                        ram
                            );


                        j
                        eb(x, -5. 12
                        5
                        5
                        1, ref

                        r
                            e
                        u
                            lt, _params)
                        ;

                        jb heb
                        (
                            , 1.
                        426e-0
                        3 re f tj, r
                        e
                            f
                        arams)
                        ;


                        eb(
                            ,
                            2
                        546
                        69e
                            -
                            4,
                        ef t j, r e
                        1, ref
                        r
                            e


                        if (
                            doubl e) result
                            )
                        oub
                            e)
                        (
                            ) )


                        {
                            tur
                                r
                            e
                                ult
                        }

                        if
                        (
                            .000 0) )
                            =
                        *(s
                          -
                          .00
                        000) /3 .0 0
                            - 1;


                        j
                        1 = x;


                        j
                            b
                        heb
                            x, 
                        -
                            .82
                        366e + 0 0, r tj, re
                        f
                            s);


                        bcheb(x, -.13
                        53
                        3
                            + 00
                        re
                        f
                            tj, 
                        ref t j1, e
                        result
                            ,

                        j cheb x, 
                        -5.0 16 71e-01, re tj
                        r
                        e
                            tj, r
                        e
                        re
                            ult, _p ar m
                            );


                        74 56 e
                            - 0 , re
                            f
                        t j,  ref
                            t
                            j
                        1, r ef re
                            s
                        u
                            l
                        t


                        2, r f j, e
                        f
                            rm jbh eb(x, 1. 6
                        2
                        j
                            ul, _p a
                            s
                            )
                        ;


                        j
                            b
                        cheb(x, -6.7
                        4
                        1
                        1
                        22e-0 3, r ef tj,
                            r
                        e
                            , _ pa a
                            s)

                        jheb(x, -4.516368
                                - 03, r
                        f tj,
                            ef tj1
                            ,
                            ref r
                            s
                        ul
                            jbche
                        b(x, 3.55208 j, ref
                            tj1, r
                        f
                            r
                        es );


                        x, 2.7
                        70
                        9
                            -
                            03 f tj1, 
                        ref
                            r
                            s
                        ut
                            ,
                        5
                        3
                        59774e
                            -
                            0
                        3
                            ,
                        r
                            e
                        f tj,
                            r
                        e
                        f tj1,
                            ef ra
                            i
                        f
                        (
                            (double)
                            (
                                r
                        esult)>(
                            d
                        o
                            ub


                        re
                    }


                    et
                        u
                    n r
                    sul
                        t
                }


                5.0870
                2
                8
                e
                0
                0 * (s - 5.00000
                0
                    + 00
                    )-
                    1
                071
                00e
                    +
                    1;


                retu
                    r
                n
            }


            private static double jbtbl9(double s,
                alglib.xparams _params)

            reu l
                t = 0
            d ble
                x
                    =
                    0;
            d
                o
            u
                d
            o
                u
            le tj1 = 0;


            re
                ult
                ;
            (s) <= (
                d
            o
                u
            le)(1.3000)
                )


            {
                2 000 00 0) /
                1
                    .
                3
                0000 - 1;


                t
                1
                    ;


                jbcheb(, -6 2
                7
                e -
                    rf t ,
                re
                    t
                1,
                ef res
                u
                    t, _p ar a


                j bcheb
                (
                    x
                    ,
                    -9.27
                7
                1
                5
                1
                    - 0 j1 s);


                tj, ref
                , re
                    r


                jb ch
                eb x,  -7.
                0
                8
                6149e - 0
                2
                    ,
                m) ;


                bc h

                e
                    b
                    (
                        t j
                            e
                            tj par
                            m
                    )
                    ;

                j
                re
                    j1,
                    re


                j bc eb(x,
                    .00
                04
                8
                    , ef tj 1, r ef
                jbcheb x,  7. 42 5e-0 ref , ref r es ul t, _p arams);


                jb
                    heb x
                2. 35 615e 04
                    ,
                    ref t , r
                    e
                f
                e
                    ult, _p ar am );


                if (
                    (oub le(res lt
                )
                uble(
                    0


                r
                sul
                    t
                        = ;
            }


            eu rn

            r
                e
            u
                lt;


            i f((d ou
            b
                e)(s) <=
                (d o
                x
                    =
                    2 * (s - 0 0000)
                /0.t 1;

            j1
                =
                x


            30
            e
            00 , ref
            t
                j,  ref t j,  ref r
                es ul ,
            _
                r
            _par s) ;

            (
                e - 0 1
                ref t
                j,
                r
            j
                e
            b
                (x, 3.80 530
            e
                -
                02, e f

            t
                s);


            x, -.888 0
            5 - 03 ref tj, ref

            j1,
            re
                f
            res u
                )
            ;


            eb(x,
                9
                    .
            0
            1
            302e- 3, re
                tj, ef tj ,
            re re
                ult,
                _pa ms);

            cheb(x
                ,
                -1. 7
            8767e-03, re
            f
                tj, 
            ref j1 , f r s
                lt, ara s);


            08510e-0 3
                ,
            r
                f t j, re
            f
                tj1 re f r
                e
            ult
                _p ar am s) ;
            j
                b
            heb
                x, 
            5.9 1e - 04,

            re ef re
                s
            u
                l,
                _pa rs


            i((d o
            e) (0) )


            {
                r s
                    lt = 0
            }


            re u
            rn

            es l
                ;
        }

        i
            ((doub
        l
            e
        0) )


        {
            x 2 *
            (
                -2 00 00 0)/5.
            0
            0000 - 1;


            ;


            j1 = x;


            jb heb(,
            6. 387
            4
            3e+00,
            r
            e
                esult,
                _
            pr am );
            j bc h
            b(
                x - 2 .8 4
            231
            e
                r
            f tj,
                r
            f tj1,
                r
            e
                j bc he b(x,
                -
                    1
            .8 09 95 6e-0
            1
                ,

            r
                f
            s
                j
            c
                h
            r
            sul t, _
            ar ms);

            c
            7e-03,
            r
            f
                tj,  ref t j1, ef
            r
                e
            s
            u
                lt, _par am )
            ;

            j bc e
                b
            2, re f t,  ref
                tj1 ,  ref relt , _params);


            bcheb(
                x
                , -7.3
            6
            52 j, ref

            tj1, re
                result, _params);
            jb
            heb(x,
                    -
                .
            39 f tj,
                e

            j
            1, _para
                s)


            jbcheb
                x,
                .
            1
            99 j, ref
            t
            1
                , _p
                a
            a
                ms);


            jbcheb
            (
                , 4,,
                r
            f
                r
            e
            s
                ult, _pa
            r
                a
            ms);


            x,
            4
            7
            90 re
                j
            1, rams);


            i
            ((
                ou
            b
                e)(
                esu
            l
                )>(
                    ouble)
                (
                ) )


            result
                =
                0;
        }


        re


        r
            sul
                =
                (2.
        209
        5
        e + 0
            * (s - 7.
        0
        0000e+0
        0
            ))


        return resul
        t
    }


    private static double jbtbl10(double s,
        alglib.xparams _params)

    es t = 0;

    uble t
        j
            =
            o j
        = 
        ;


    i
        f
    (
            double)(s) <=
        (
            oub
    e)
    (
        .20
    0)
        )


    {
        000 0)/
        1
        .2 000 - 1;


        j = 1

        tj1 =
            x
            (x
                , 4
        .59099
        3
        e
            - 01, re ft, re
        f
            t j
            j 3 ref
        , re r es
            ul


        j
            c
        heb(x, -
            2
                .
        3
        5
        393 4
        e -
            )


        jb c
        h
            e
        93
            -
            0
            , r fr e
            bc
        h
        b(x - 1 .8 4
        151
            - 03
            ,
            ref
        tj , ref
        t 1
        jbc
            h
        e
        0 j
            ,
        r ef
        es ul, a j b
        c
            h
        b
            (x, 3.636 29 5e - 0
        4
        re
            jr r
            e
        s
            j
        b
        heb
            x, 

        .17
        e -
            05 re f j, r f r, ms
            )
        ;

        jb
            c
        eb(, -
            8
        917
        49e
            - 5 , r
        f t, re f j1,  ref
            r
            i f((doub
        l
            )(r es lt
            )> dou
            le)
        (
            ) )


        {
            0;
        }


        re urn sult;


        if (double)
            (s) <=
            (
                ble
                (2
                    .
        000
            )


        {
            )/
            0
            8
            00 - 1
                ;


            3
            tj1, re
                sult, _

            b(,
                -
                    9.962 40 11 e
            f
                t
            e
                j
            bcheb(x,
                1
                    .
            83 87 5e-0
            1
                ,


            792e-0
            2
                ,

            e
            f tj, re tj1,
            e f rl rams)
            ;


            .5803 6
            e - 0
                ,
                ref j, r e 1, r
                f
            rs ul,
                _pa
            rm s) ;
            eb(x,
                1
                    .
            71 70 1e - 03, ref tj , r
                tj, f s
                );
            jbch
                e
            (x 3.77
            0
            33 r tj1,
                r f e
                t,
                par
            ms)
            ;


            bcheb(x
                , -
                    tj, re f1 f

            esu
                t, _
            aras );


            jbche
                b
                (
                    tj,
                    re f

            t
            1
                , re r esult,
                _
            ara
                s)
            ;


            if ((do
                u
                    le)(res
            u
            lt


            {
                e
                    = 0
                    ;
            }


            esult;
        }


        i
            f
        (do bl )(s
                 <= (
                     ouble)
                 (
                     .00 00 )


        x = 2 * (s - .
        0
        0000)/5.0000
        0
            - 1;


        j
        1;


        tj
        1

        jbche
        b
        (
            x, -5 33 7524e+00,
            ef
        j,

        ef
            r e
            f
        res
            lt, _p
        a
            ams);


        -1 8
        70 9e+ 00
        r
        ef tj, re
        t
            j1 ref
            re su t


        02, re tj
        r
            r
        jbcheb
            x,  -4.
        2
        es lt, a
            )
        ;


        j
            b
        c
            he b(, 3.3202 50 e
                             -
                             0
        3, ref tj, r
            e
        _para
            s);

        beb(x, -6.432266e
        03, re
            tj, r
        f tj1,
            r
        ef res
        l
            t, 


        if ((do
            uble)(result) )


        r
            es
    }
    re
        urn
    r
        s
    ut
}


-
    (
    .
711035
e
    -
    0
1
    * (
        s
        - 7.000
0
0
0e+00)
    )
7.e
u
l
    t
    ;


}


private static double jbtbl11(double s,
    alglib.xparams _params)
{
    do
        bl
            = 0;


    double
        j =
            0;


    oubl e t
        j
            = 0;


    re ul t =
            0
        ;
    if (
        (()
    x
        = 2 * (1 00 - 1;


    j
        = 1;

    t x,  -4. 3e re
    f
        tj, 
    ref t  1,
    ef
        r
    sul
        _para
    m
        );


    x, -6 .0 15 5
    8
    e
    01, ref tj, re tj,
        r
    f r
    sul
        t
    _p
        ra ms )
    00 09 2e-0 ,

    tj,r f
    t j1, 
    ref
        re
        s
    lt,
    _pa
        r
    ms)


    j bh e - 0 2, re
    f
        j, r f tj, re f
        r
    su t
    _
        p
    ram
        );


    ef
        j,  ref t  1
        ,
        ref re s
    u
    l
        t, _ ar
        am s)


    x t
    j
        u

    jbc
    h
        - 0 ef
        j
    1, ref

    r
        e
    s
        ult, _ para s
        );


    t
        j1, ef resu
    l
        t,
        fl ams
        )


    l
        e
        )
    (r su lt)>(double)
        (
        ) )

    re sult
        =
        0
}

i f(
    bl e

(s
    )
    = (d
ubl
    e) 2.
500) )


x = 2
    *
    (
        s
1
.200000)/ 1
    .
05 00 - 1;


t = 1;


x
    ;


j
che
(x
    ,
    -. 523
2
1e+
0, t ,
r lt, _ pa a
m
    s
    ;


j
    ch
e
(x,
    -1.
06 388
    + 0,
r
    j, r f
    tj 1
s);


(x
    ,
    2.1
966
1
    - 01
f tj
r
f j1,
    r
e
    bc
hb(x,
    -1 55 5
24e
03, re
ft j,  ref j 
1,
    );


j bc
h
    e
b
(x, -3
    .
2
3
8
6
j


4
1, re
    f
a
    b
cheb(x
    ,
    4. 95
77 e - 03,
r ef tj, r
e
    _
a
    a
m
    s
    )
;


jb ch b
(
    x
j,r e
f
    par a
    jbc he b(x
    ,
    -
        8.201340e-04
    ,
    t
r
    e
1,r re su t, _ ar
    a
s);


(
    doub e)(resul
t > (d ou
    le
    )
0)


{
    0;
}
r
    e
u
    r
n r

}
s) <= (d oub
l
e
)
8.0000) )


{
    x =
        2
    0)/5.
    7
    5
    0
    0
    0 - 1;


    t
        j
            = ;


    tj 1

    x;


    -
        5
    2
    121 79e+
    0
    0
        , ref
    t
        j, 
    ref t
        j
    1
        ,

    e
        - 1 .6845
    9
        +
        0
    ef );

    2
    j, ref
    t
    1, r f result, _ pa ra ms )
    ;

    jb
        ch eb x,  -3.606261
    e - ref tj
        re r es ul t
    jbc
    eb(x,
        .31086
    e - 03, r
        e
    f tj,
        e
    f ult, _
    p
        arams);

    jbc 0115e-
    3, ref
    t
        ,
    r result

    p
        r
    am
    i
    (
        (
    do )>(dou
    le)
    0
        ) {
        r
            e
        u
            lt = 0
            ;
    }


    et
}


resul
    t
        = s -
        .
0
00 4e+
0


resul
    t
    ;


}


private static double jbtbl12(double s,
    alglib.xparams _params)
{
    d ou l
    r sult = ;

    0;


    do
        u
    le t = 0;
    do
        ub e tj 1 0
        ;
        = 0;


    if ((d
    o
        ble )
        =
    (
        oub
    e)(
        1
    000
        )
        )/
    00 0
        - 1;

    t j = 
        ;


    t
        j
            = x;


    b c
        - 01, f j
    1,

    ef
        es
    u
        t,
        am s
        )


    jbcheb(x,
        f re
    s
        lt,
        _para ms )
    ;
    2
    9e-01,

    ef tj, r e
        am s) ;


    jb ch b
        x
    1, refr e
    t 6 ,
    r
        j, r f
        t j1
        r
    ef resu l
        t,
        _p ram
        s
        ;
        .
    80 44 5e - 0 , ref tj,

    r
        ef t j1, re
    f
        r


    79e
    0
        , r
        r sult
        _p ar m
    s);


    bc
    he(x,
        -2.
    2
    351
    e - 05,
    r
    f tj, re f j
    am );


    jbc e
    b(
        x 12 6
    8
    8e-5 , r j,
        _para
    m
        s) ;

    f
    do
        ul e) r
        sul
    t > (d o( {
        r
        sul t = 
            ;


        ult;
    }
    u
        )

    (./2. 0000
    0
    0 - 1

    j =
        1;


    x

    47e+00, r e, t
    j
        , r er aram jbcheb
    (
        x, -.5 15287e+00, re ft r f t1
        r
    f r
        sult,
        _
    arams );


    x, 3.611
    8
    8
    0e-01,
    r
        e
    f tj re f j
    1
    m

    11 f tj, re f
        result,
        j
    bc
        h
    eb(x, -6. 49 815e-0
    2

    f )


    jb ch eb(x 4.
    1
    4
    1
    f tj,
        r
    e
        x,  7 18 0886e-04 , re f
        tj, r ef t j1 re
    r es ul t
    a
        jb he b - 1.
    88211e
        -
        2, ref
    t
    j
        ult, _
    p
        a
    r
        ms)

    jb h
    e
    (x,
        4.8907
    6
    e - 03, r
        ef
    esu lt,
        _
    p
        a
    a
        ms);


    j
    che
        (x, 3.2
    3175e- ref re
        s
    u
    l
        _params;


    jb c
    eb(
        x
        - 2
    946156
    e
    03 , ref t
        j,
        t,
        _pa
    r
        a
    m
        )
    ;


    i( do
        ble
            (re
    s
        lt)
    (doubl
        )
        r
    e
    s
        ult =
            0
        ;
}
}
)
{
    .
    1;


    tj = 1;


    tj
    1
        =
        x;

    -5.94
    819e+0 0,
    t, ref result, _p
        rams);


    jbche
    (
        x, 00, re
    f
        tj, re
    tj1, r
    ef result, _

    b
        h
    eb e - 02,
    e
        j,
        resul,
        p
    r
        am
    jb
        h
    b
        (, 02, re

    j
        , r
        e
    u
        lt, _p
    a
        r
    a
        m
    s)
    ;


    j 90
    e
        t
    j
    1
        ,
        ref res
        u
    l
        t, _para
    m
        s
        );
    j
        c
    e
    b(, r
    f
    t
        j,
        sult,
        _
    p
        a
    a
        ms);


    bch
    b(x
        ,
        3.8
    7866e-
    0
        , ref t
        j, ult, _
    p
        a
    r
        m
    s);


    j
    che
    (x,
        .51
    252e-0
    3
        ref tj
        ,
    r lt, _p
    a
        r
    a
        s
        );


    j
        b
    heb
        x, 
    2
    073
    43e-03
        ,
        ref tj,

    re t, _pa
    r
        a
    m
        )
    ;


    jb
        c
    eb(
        , 3
            .
    226
    1e-03,

    ef tj,
        r
    ef , _par
        a
    m
        s
        ;


    bc
        h
    b(x
    1.
    5
    134
    e - 03,
    r
    f tj, r
    e
        f _para
        m
    s
        )


    f(
        dou
    le)
    (
        esu
    t)>(do
        u
            le)(0)
        )


    r
    e
        ult
            =
            0
}


t;


}
re
s
lt
-(
2
877
43e-01
*
s-1.200
0
00 +00;
retur
n
res
lt
;
}


private static double jbtbl13(double s,
        alglib.xparams _params)
    =

d
    oub
t
    r
s
    u
l
    t
        = 0;


if (
    (
        e)
    1. 0
0


0000)/
1
000
00
    -
    ;


tj
    =
    1;


;


jbcheb(
    x
    - 2
71
3
76e
01,
e f j
    r f tj
1 re resu
l
    t


jb ch eb(x,
    3 .5 57 5
1e
    -
    1,
ef t ef
    r
jb
    c
eb(
    ,
    -
        .45
092
e
02, ef tj, r, _pa ra ms
    )
;


-1
044145
e
02, ref

t, _pa
    r
a
    m
    )
;

bch
eb x,
    j
1
    ref result,

para s)
;


jbce(
    tj, r
e
    f

j
1
    , ef resu lt
    _
aras );


j ch
e
    b
ef tj, e
f
    t 1, ref re u
l
    t,
    pa ra
    jc he b(x, -7 .0
2
5
1, ref e
    s
u
    t, _ arams);


j
    b
heb
    x,  -1 .5 90 42e-05,

r
    sult _
    pa ra )
;


if
    ( do
    ul )
        >
doub le )(0) )


r su
    lt =
        0;

r et ur n r
sl t;
    )
0


he(
    x
e
    f tj1 ref re
    s
s);


bche
    b
    (
        tj, r f

t
    j, 
ref result ,
    par am );


jbcheb
(
    , 3.270
7
7
j1 r ef
    r
e
    ult, _params
    )


jb
    c
eb(
    , -8.0 5
e - 3, re
    f

esu t, _p a
    r
a
    s
    );


ch e
(x,
    -6.
6
164
e - 02 r ef
    j, re f tj 1,
re f


jbcheb(x,
    2
990
85
e
    ,
t j, r ef tj1
ref r es u
    l, _par am s) ;

bc eb x, 
8
    .
1
9
212e-03, ref

j, re t j
1
re
    re
s
    lt,
    _param
s;


e - 02
r
ef t, re tj1, r ef r
    sul, _p a
    ams
    ;


j bc he b(,
5
    .
9
f j1, e
f
    lt, params) ;


jbc
    h
b(x
3.522
3
0e- 03 , re t j,
 
    ,
    _p rams;

j bc eb(
    ,
    -
        447
1e-
0
    , r
f tj,
    r
f tj 1, r ef re s

i
    ((d uble(resu
l
do
    bl
e(0) )


}
e
ur
n
re su l
;
}
e
)
0000 )


{
    0
    tj;

    ;
    eb(x,
        5.7361
    2

    _p ar ms
        jbc he(
        x
        , -1.9 20 809e+0
    0
        ,
        ref tj, ref
    t
        params );
    b, 1.175858e-01,
    ef tj, 
    ref tj 
        ,
  ref r
        e
    sult,
    p
        ar

    jbch
    b(x, -4
    .002049e-02, tj1,
    ef res
        l,
        _


    j 58966e
    02

    e
        f ref r
        sul,
        _
    pr
        jb 57
    7
    1
    e - 03,
    r
        e
    f
        tj, 
    ref t
        j
    1
        , ref
    r
        su;
    j
        c
    e
    b
    (
        x
        ,
        2.76217
    2
    e
        - 03, ref

    t
        j, su
    t
        _p


    j 7e-04,

    r
    e
        tj,  ref tj1 ,
        ef
    es
    u
        t,
        par
    a
        s);


    jb 0e-03,

    r
    e
        tj,  ref tj1 ,
        ef
    es
    u
        t,
        par
    a
        s);


    jb 1e-05,

    r
    e
        tj,  ref tj1 ,
        ef
    es
    u
        t,
        par
    a
        s);


    jb e - 03,
    r
        e
    f
    t
        j,  ref tj1 ,
        r
    f r
    su
        l, _
    ara
        m
        );


    i
    f() > (dou
    b
        l
    e
    (
        0) )


    result
        =
        0
}


re
    t
rn
    es
u
    t;


}
re 4e-01*
(
s
-
.300000e+01)
)
7.5
62
6
e+0
;
r
e
urn res
u
lt;
}


private static double jbtbl14(double s,
    alglib.xparams _params)


doub
    le
d
ouble
    x
        = 0;


d
    o
u
b
    e
        = 0;


if (
do
    ble
        )
        =
2
(
    s
    -
    0
        .
000000)/

69 8
27e
    -
    1,
ef tr,
    r
jb
    c
eb(
    , -3 47 081
            - 01, r
e
    , ref
t
    j
    );

j be(x
    ,
    -8.
73 3e 02,

ef tj, r e
    , _ pa am
    s)


jb c
    - 8.4
6
899e - 0 3, re f

sult
    _
pa a
m
    s) ;


h
e
(x,
    -1.
49 485
f resu
l
    t, _ pa ams)


bche x, 
.1500 09 -
    5, ref
t
j ult, _
p
    a
rm s) ;


j
    b
(
    , 1
965 97 - 05 ref t ,
re tj1, r e
    f


j
    b
heb
    x, 
-
    .71
21 e - 05
ef t, re
ms);


bch
e
(x,
    78
0
e - 05, r
    e
f
esul t, _
p
    ar s);


if (u e
    (result
    )
    > d


r
eu lt =
    0;


retu
    r
n
resu l;


}
= *(s -1 000000 /
3
0
5
9
e
+
0
0, ref te _
a
    a he
    b
(
    x
1.42136 5
tj1, r
    ;


jbcheb(x,
    604
8e
    -
    1, e f ref tj1 ,  ref r
    e
s
    j
eb
    x, 
1 149
67e 0
    , r
f tj, re
f
1, ref
r
    e


j bcheb(x, -6
    .
611
9e
    -
    2,
ef
    t
re
    tj1 r f esult,
    _
p
    jbc
h
    e
b
    x,  1.97602 e -
    ef
j,

ef
    j1,
    ef
es lt, pa am s);


, 1.08
2
7
0
e
    - 02, r ef tj,
    re
ft j1, r
res ul, _
ar am s) ;


jbche
    b
    (x r

f j, r ef t j1 ref res ul t,
    _p
a
    ams


j
cheb(,
        453123e
        -
        0
    ref re
    s
u
    l, _params);


jb
heb
(
    .9
59e - 0 ,

tj, r f

t
    s);


jbc
h
    x, 
51
0
7e-
5,
r
    j,
    f t j1
r
    resu lt
    _
p
if (
    (
        d
o
    b
le)(result) >
(
    bl e
    )


r
}
e tu rn r su l
t
}
i ( (d ou l
e
0)
)


{
    x
        =
        2
        - 5. 74 89
    00, r f

    r


    jbcheb(
        x, -2. 01 441e+00, re
    f tj ref tj1 , e
    f
        r s
        jb
    cheb(x, 1.5146e-01, ref tj,
            ref tj
            , ref
            esult,
            _
                params
        ;

    jbc
        h
    eb(x, -
        .129690
    e - 02, ref tj ef res
        lt, _p
    r
        m
    s)
    b
        h
    b
        (x 02, re
    t
        ,
    r
    ef sult,
        par
    m
        )
    ;
    jbc
    e
    (
        x, 03
        ,
        r
    ef tj,
        r
    e
        f
    t
        j
    1, ref

    r
        esult,
        pa x
        .
    1
    9
    2
    9
    33e-03,
    r
        e
    f tj, re
    f
        tj pa
        a
    s
        );
    jb
        h
    b
        (x ref t
    j
        ,

    e
    f tj1,  ref r
        e
    ult
        _
    p
        ram
        );


    jbche
        b
    (x ref tj
        ,

    r
    f
        tj1,  ref re
        s
    lt,
    _p
    a
        ams
        ;


    jbcheb
    (
        x, ef tj,
        r
    e
        tj1,  ref res
        u
    t,
    pa
        r
    ms)


    jbcheb(
        x
        , ef tj,
        r
    e
        tj1,  ref res
        u
    t,
    pa
        r
    ms)


    if ((do
        u
            bl le)(0)
        )


    {
        resul
            t
                = 0;


        return re
        s
            lt;


        result
            = s - 1.50
        0
        0
        0
        e + 01))-7.632
        2
        8e+
        0;


        r
            turn r
        e
            ult;
    }


    private static double jbtbl15(double s,
        alglib.xparams _params)
    {
        do
            ub l
        e
        resul
            t
                = 
            ;
        l
            ub le t
                = 0
            ;
        resul
            t

        2
        0
        0
        0
        0
            )
            )


        ;


        j =
            1;


        tj1
            =
            x;

        -1.04 36 60 e + 0, ref t1 ef
        r
        sl
        (x, -1
            .
        3
        6
        3e+0 , r ef t
            j
        r
            f
        t
        1,
        ef
        r
            sul, _p a
        eb x,  3
        .0 9497e- 1, ref t
            , e
        t
            j, r ef r
        e
            ult _p a
        bcheb(
                x
                , 
            .
        95 17 4e-0 , r ef t
            j
        eft j1 re res
        u
            t,
            params
            )
        jb ch eb x, 
        4.377903e-2 r
            t
        j
            f,
            r
        es
            , _pa
            r
        ms);


        bcheb(x, 1. 03 2
        53
        e
        02,
        re
            f, r ef t
            j, r ef res
        u
            t, _para
        m
            s
        jbcheb(x,
                -
            .
        271309e-03,
        r
        f t,
            r
        f t
        1,
        r
            f r
            sult,
            _a ram s)

        le(res
        u
            l
        t > (double)(0)
        {
            = ;
        }


        u r
        n


        if ((oubl)
            () <(o
        ub e
        (5.
        00 0) )


        x =
            2
            * (s - 2.
        0
        00 00 )/30 0
        j;
        b(x,
            3.5827 7
        e
            lt,
            _
                params )

        -
            e f j


        0
        2, ref t ,
        r
            f t
            s

        jb c
        h
        b
            (x, -2.71738
        5
            - 02 ,
        re
        f
            tj, 
        ref
            j1 , r f r

        j
            b
        c
        eb(x, 1.2225
        9
        e - 0
            ,
        re tj
        re
            j1,
            f res
            ut, _params;
        bche b(x,
            -
                6
        63 124e-03,
        r
        ef
            j,
            ef

        j1,
            ref

        esu
            t, _ ar
            a
        s);


        .8 59 3e -
            0
        3
            ref tj, ref

        j1, ef re ul t,
            _pa
        r
            ms)


        f(((dou le(0)


        {
            r
                e
            ult
            0;
        }
        return
            r
            ;
    }


    f((
                ble
            )
            s) <
        (doubl
    e
        (17. 00) )


    x
        = 2 * (s - 5.00
    0
    00)
    12 .0 0
        - 1;


    tj 1;


    bcheb(x, -6.
    1
    547
    e + 0 0
    ef tj re
        f
    tj1
        re f es
        ul, _ pa ams)

    (x, -1. 65 5
    9
    6e+00, ref t
        j
    re
        t
    j
        re f
        ult,
        _pa
    ams) ;


    ref t
        j, r e
        tj1,  ref res
        u
    t,
    pa
        r
        );


    j bc e
    b
        - 2 .6 37
    9
    re
        f
    r
    esu lt, _
    p
        a
    rams);


    ,
    , _par am )


    e
    f tj,
        ef tj ,
    r
        jbche, 
    9
        .
    444801e-04,
    r
        e
    f
        tj, r ef t j1
        r
    ef
        r
    e
        sult, _p rams;


    ch b(x,
        -1 .5 150
    3
    jref tj1,  ref res
        lt, _p
    rams);


    jb 68696e
        -
        04, ref
    tj, ref
    tj1, ref re s);


    .72850
    e
    0
        ,
    r j1, re
    r
        s
    l
        t,
        b 6470e-
    3

    re 1,

    e
        f resu
    l
        t,
        _p
    a
        rams);


    ub b
    e
        (
            0
        )
        )


    {
        r
            s
        l
            t


        turn r
        e
            s
        u
            t
            ;
    }


    r
    e
        ult
            = -(1.
    9
    7937e-0
    1
        * (-7.700
    9
    8
    3
        +
        00;


    r
        tu
    r
    re
        ult
        ;
}


private static double jbtbl16(double s,
    alglib.xparams _params)
{
    = 0;


    double
        x
            = ;

    o ble t
            = 0;
        = 0;


    re ul
    t 0;


    f
        (d
    uble )( )
        <
    (doubl e) (0) )


    {
        = 2(s -.
        00 0
        0 / 2. 0
        00 - 1;


        tj1 =
            x
            ;


        b
        j
            r,
            ef

        j
            , ref
        tj 1
            ,
        r
            e
        f r esult
            _
        pa ram
            s
            ;

        3
        8
            - 0 1
            ,

        r
            e
        f tj,  ref
            t
            j1, r_ ms)


        bcheb(x. 6 -, r ef tj, ref
            t
        j
            a)

        ul t,
            _pa
        am
            s;


        03, re t j,
            e
        f tj1, r ef r
        es
            ul, _ pa am
        s)


        e - 04 , ef
            t
        j
            ref tj 1, r
            e
        f eu lt,
            _pa ms)


        if ((do
            u
                bl le)(0)
            )


        {
            su
                lt = 0
        }


        eturn resu lt;
    }


    if ((
    do ble) (s <=
             (


    {
        x
            =
            0
        j = ;


        bcheb(
            -. 86
        r
        e
            ut, _p ar m
        s
            );

        jb
            c
        e(e
            , e

        r
            e
        s
        u
            lt, _ pa am
        s)


        00
        e
        0
        1
        rams)
        ;


        jbh eb
            x, 

        3.1 30 31e- , r
        f tj, r
        e
            tj1, r
        e
            ft _
            p
        a
            a
        ms);


        j bc b(x 1. 52 373 - 02, re tj, ref
            t


        jb
            c
        eb(
            , -8 .0 4
        8
            - 03 ,r e
        f
            result, a
        rams);
        j bcheb
        (
            , 3. 55 6839
        e
            -
            ,s
            e) u
            le
            )
            )

        {
            result
            0;
        }

        r
            turn re
            s
        u
    }


    (b
    l
        )(s
          <= (
              d
    ubl
        )(20 00
    0
        ) )


    x =
        2
        *
        (
            -
                5.000000) / 15 .0
    0
    000 -;


    tj = 1
        ;


    jbcheb(, 6. 41 08e
    00
        ,
        ref
    tj,

    ef 1, re r e
    s
        lt, _pa
    r
        a
    jbcheb
    (
        x
        ,
        -1.832655e+ 0
    f t,
        r
    f t
    1,
    r
        es u
        t, _p ar am s


    5e
        -
        1
        , ref
    t
        j,  ref
        t
        j
    1
        , ref re ul t,
        r

    r f j,
        e

    t
        jb
    he b(x, 1 28 3
            ,
            ul t, _par m
        )
        ;


    j
        b
    c
    heb(x, 3.484
    5
    4
    9
    e - 03, re f tj r ef, par am;

    cb(x, 1.805968e-0
        , ref
        j, ref
        tj1, re
    f
        resul,
        _

    j
    cheb(x,
        -2.057243e- ref tj
        , ref
        e
    u
    lt
        - 1.454
    39
        -
        3
        , tj1, r
        f r
        s
    l
    t
        - 2
            .
    7
    7513e-
    0
    3
        ,

    re
    f
        tj, r
    e
    f
        tj1,
        r
    f am

    j
        b
    c
        h
    e
    b(x, -1.
    8
    1
    9209e-03
        ,

    re ef
    r
        s
    ul
        (resul
    t
        )
        >
    d
        ouble)(0) )


    {
        r
            es


        r
            tu
        r
        re
            ult
            ;
    }


    .39158
    0
    e
        -
        1
        * (s - 2.000000
    e
    01)
    -7
        .
    632
    5e+
    0
        ;


    retur
    n
        result;
}


private static double jbtbl17(double s,
    alglib.xparams _params)
{
    do
        u
            b
    do
        u
            le
                = 0


    do
        bl e t j = 
        ;


    ul t 0;


    if ((
    do ble)(s)
        <


    {
        x
            =
            2
            - 0 0
        j = 1


        jbche
            b
        0
        j1
            ,
        re f resu
        l
            t,
            _pa r
            b,
            f1 a)


        tj, re
            ft j
        1, ref resul
            t
        _p
            jb c
            h
        re f j,
            r
        e
            tj1,  ref u t
        _
            ms );


        j
        ef j, re fr sult, _
        jbcheb x, 
        556515e-02,
        r
            f j
            r
        e
            t j1 ref

        es ul t
            _para
        m
            );


        56965e
            -
            0
        3
            ref tj, ref

        j1,
        re
        f
            res,
            heb (x 1
        .4 4
        6
        9e-02, r f
        t
            j
        re f result,
            _par ams)
        ;

        bcheb(x, .
        47867e-03 , rr f
            result,
            _
        ouble
            )
        (
            r
        esul )>( do
            l
                r u
            l

        ret
            rn re sul
        t
        (
            d
        u
            ble)(s) =
            (
        do
            bl
                e) (6 0000
            )
            = 2 * (s 3. 000000)/
        3
            .
        00000 0 -;


        b(x, -
            3
                .
        9
        5
        684e+00, r f t j,  ref j1 
            ,
            r
        sul
            t
        _p
            ram s)


        jbcheb(x, -6. 2
        2920e-01, re t, e tj ,
        re
            rs ut _pa a
            m
            );

        7e- 02 r e
        tj re f t
        1, e f re su l, _
        arams)
        ;

        re
            t
        j
            e
        1f


        jh b1 702
        8
            - 03, re t j
            t, _ pa ram
        s
            )
        ;


        j
        che
        (x
            ,
            -1.
        0
            , ref t
            j,
            esul
        t
            ,
            params);


        jbc eb(
            x

        -4 .0 9683e- 4, ref tj,

        r
            _ aram
            s
            )
        ;


        jbc
            eb
        (
            , 1
        161 0
        e - 0
        re t j,
            ef tj1,

        r
            j che(x 2.
        254
        5e
            -
            4,
        ef
            t, e
        t 1, re f
            esult,
            _
        p
        if
        (
            (
                o
        ub le(r esult)>
        (d ou b
        (0) )


        {
            r
        }


        return
            ult
    }


    f((dou
    b
        l
    00
    0
        )


    {
        0
        1;


        -6 594 28 + 00 ref
        r
            ;


        j bc he b(,
        -
            1
                .
        9
        17838e+00 , ef
            t,
            r ef tj1,  ref re u
        j
        bcheb(x, 1.5980e-01, ref tj
            ref t
        1, ref
        result,

        _param
            )
        ;
        jb
            c
        heb(x,
            2.99958
        9e-02, ref t ref re
            ult, _
        a
            a
        ms
            j
        c
            e
        b(-03, r
        f
            j

        re esult,
            _pa
        a
            s
            )
        jb
            h
        b
            (x - 0
        3
            ref tj
            ,

        r
            e
        f
        t
            j1, re
        f
            result,
            _p (
            ,
        -
            1
                .
        8
        1
        9937e-03
            ,
            ref tj,
        r
            e
        f _
        a
            a
        ms
            b
        h
            eb 3, ref

        t
            j

        ref tj1 ,  ref
            esu
            t,
            par
        ms)
        ;


        jbc
        h
            eb,  ref
            t
            j,
            r
        ef tj1,  ref
            r
            sul,
            _
        ara
            s);


        jbch
            e
        b(, ref
            t
        j
            ,
        r
        ef tj1,  ref
            r
            sul,
            _
        ara
            s);


        jbch
            e
        b(, ref
            t
        j
            ,
            ref tj1, ref

        esu
            t,
            par
        ms)
        ;


        if (
            (d double
            )
        (
            0
        )


        {
            r
            e
                ult = 0
                ;


            return
                esu
            t;
        }


        res
            u
        lt 1 * (s - 2
            .
        4
        0
        0
        00e+01))-8.4
        0
        197
            + 0
        0


        return
            esult;
    }


    private static double jbtbl18(double s,
        alglib.xparams _params)
    {
        ul ouble
        ou
        le tj = ou bl t j1
                =
                0
            ;


        result
        0
            <
            (
                d
        o
            u
        b
            le)(3.00
        0
        0) )


        3
            .
        0
        0
        00 0 - 1;


        j
            =
            1;

        t j1 x;


        -1.52
        6
        8
        0
        e
            + 00, ref tj,
        r
            f t
        1, r
            f
        esu
            lt _pr ams);


        e + 00,

        ef ,
        ef
            j1
        r
        f
            esult, _
        ar ms);


        -02 re f j r
        e
            tj,  ref
            r
            sult, _
        p
            a
        jbch
            e
        b
        (
            , 2.1894 37 -
                     01
            ,
            ref
            tje f

        j1, ref r es u
            jb ch b
        (
            x. 72 e
        03,
        re f t j1, r ef
            lt, _p
        a
            r
        jbc
            he b(
            -4.823067e-0
        2
        re
            t
        j
        et result, _p a
            j che b(,
        -1 064501 -
            0
        2, ref
        tj
            ,
        t
        1,
        r
            r
        jbc
            h
        e
        b
            x,  .014 32e - 0 ,

        t, r f
        tj1 ref

        esu
            _para
        m) ;
        j
        eb x,  5.9
        5
        3
        513e-0
        3
            ,
            ref j ,

        r
            f
        p
            (d s


        l = (
            d

        {
            =*0


            t j = 1;


            t 1 =
                x;


            86 69e+0
            0
                ,

            ef tj,  ref t
                j, r
            f r ult
                _ a
                r
            ms);

            j ch eb 1, re f t
                j,
                tj1,
                re f res
            u
                t,
                pa
            r
                ms)


            bc eb x,  4
                .
            2
            r f j1,
                r
            e
                result, _pa
            r
                ms;


            jbc
            eb(x,
                -4 8798 7e 03,
                r ref re ul t
                ,
                p
            arams);


            j
            eb(x, 6 .8 87
            3
            7e- 0
                ref tj, r f tj1,
                r
            ef );

            j bc heb(x, 1. 6
            51e
            05
                ,r ef t j
            re
                f
            tj1
                ref r
            e
                ul, pa ra
                m
            s
                jb he b(
                x
                ,
                .

            502800e-04,
            r
                f t
            re f, r
            f r
            e
                ult
            aram )
            ;


            6e-0 5, r
                e
            f
                j,  ref tj1 ,
                r
            f rs ul t, _ ar am
                );


            b ch b(x, 5
                .
            0
            tj1, r e
            f
                r
            s
                ult, _params
                )


            if (
                doul e) resu t > (d uble(
                0
            )


            result

            0;


            etur r
            es u


            if (
                (
                    d
            ouble)
            (
                    s
                )
                <= (doub le )(2
            0

            00 00 / 14
            0
            00 0 -
                tj
            x;


            (
                , re f tj
                e
            f
                tj1,  ref re
                s
            u
            l
                t, _p ar am );


            jbc e
            b(x
            f tj,
                tj1,
                r
            _rams);


            bcheb(
                , 1.002
            2
            27e-01

            re 1, ref

            result,
            _params
                );
            b(x, -
                .33825
            e
            0
            2, tj1,
            e

            e
                su;


            4.137
            36e
            0
                ,
            e 1, ref
            r
                s
            ul
                j
            bcheb(
                x
                ,
                -2.58
            6
            02 , u
                t

            _
                p
            a
                r
            ams);


            38
            e
            0
            4,, r
                f
            r
                es


            jbcheb(x
                ,
                1.3
            22
            5
            e - 0
                , r
                e
            tj
                ref t
                j,  ref r
                e
            su


            jbcheb(x,
                .87
            98
            2
                - 03
            re
            f
                tj, 
            ref tj 
            1
                ref re
                s
            ul


            jbcheb(x,
                -
                    .16
            96
            3
                - 05
            re
            f
                tj, 
            ref tj 
            1
                ref re
                s
            ul


            jbcheb(x,
                2.5
            72
            4
            e - 0
                , r
                e
            tj
                ref t
                j,  ref r
                e
            su


            if ((dou
            b
                e)(
                es
            u
                t)>
            dou
                b
            e)(
                ) )


            r
            s
                ult = 0;


            return
                r
            es
        }


        result =
            (1.
        84
        6
        3e-
        1 * (
            s
        2.0
        0000e+
        0
            ))-7.42
        8
        88 ret
            u
        r
        n
            result;
    }


    private static double jbtbl19(double s,
        alglib.xparams _params)
    {
        d
            d
                <
        (
            d
        o
            u
        b
            le)(
                0) /
            .0 0
        0
        tj =
            1
            ;
            =
        ;


        j
        cheb(x, 1.49 02 3e
                        +
                        0
        1, ref

        r
            e
        u
            lt, _params)
        ;


        j
            b
        heb
            x,  -1. 1
        9
        e + 0 0, re
            f
        _par
            a
        m
            s
            ;


        ch eb,  -6.4
        5
        123e - 0 ,
        r
            e
        f re ul
            t,
            p a
            rams);


        jbc
        eb(
            x
        2.
        34878e- 0
        ef tj,
            r
        e
            t _p
            a
        r
            a
        ms);


        j
            che
        (x, 
            . 11 38
        8e-02,

        ef tj,
            r
        e
            _para
        m
            s
            )


        bch(x, -.030 2e-
        2, r f t
            j
        ref t j1, r f resu
            lt, _
        ms );


        b che(x
        - .
        54 02 e - 0, ref t
            j,
            arams
            )


        jb
            ce b(,
            7.525
        6
        3e-03, e
            f
        resul
            t,
            pa ra m


        he(x, 5
            .
        77360e-0 3
        re
        f
            ult,
            _
        p
            arams)
        ;


        0) )
            = 0;


        retur
            n re su lt;
    }

    oubl
        e
        )
    (s) = (oubl
    e
        )
    (
        00 0
    000
    1;


    t
        = 1;


    jb c
    h
    e - .
    44
    7
    00,
    e fj j1,  ref
        r
        jbc he b(x, -
        774
    e -
        0
        , r
        f t
        j
    re
        j1, re
    f esult, _ p
        ar
    j
        b
    c
    eb x,  4.22 71 e - 0
    2
    re
        t
    j
        re
    tj
    1
    e
    ul t, _
    p
        rams);


    x, -5.
    3
    6
    3
    89e-03 ref tj r f t
    1,

    ef
    esu
        l, _p ra s) ;


    , ref t
        j, r ef t
        j1, r ef result,
        _pa
    am
        s
        ;


    b
        (x, -5 .5 572
    5
    7
        ref re
        s
    u
        l,
        _params;


    j
        che
    b
        x,  4. 54 794e-
    0
        , ref t
        j,
        _param
    s
        );


    j c
    eb(x 9.0 207
             - 0 5, r
    f t, re f tj
    1
        ref re
        s
    u
        j
    b(x, 5.4 98 0
    7e- , r ef tj, ef
    j1, r re
        ult, _pa
    r
        ms);


    e)(res
    u
        l
    t > (d uble(0) )


    re
    s
        lt = 0;


    etur re su t
        ;
}

if (
    (d ou ble)
(
    )<=(dou
b
l


{
    x
        = *(s - 6. 0
    0
    00 )
    1

    tj


    x
        tj, rf t j1, r
    ef r
    jb
        h, 

    -1 430 68 e + 00
    r
    ef t, re tj1, r ef r
        e
    s
        ult, _p arams);

    j bc he b(,
    1.13
    6
    fj, ref tj1, ref
    esult,
    _param
        );


    1.7266
    2
    7e-02,
    ef tj, 
    ref tj1 ,  ref rams );


    , 3.42
    1
    0
        -
        03 f tj1,
        re

    e
        su;


    1.5815
    0
        -
        03 f
        t
    1
        , ref
    r
        e
    s
    u
        lt,
        _para
    m
        s
        );


    he 0
        ,
    r
        e
    f

    t
        j,  ref t
        j
    1
        , ref re
        s
    u
        lt


    .83
    2
    8
    e - tj1, r
        e
    f

    e
        sult, _param
    s
        ;


    jb
    heb(x,
        .428839
    e
        - 0 j1, re
        f

    r
    s
        ult, _params
        )


    jbc
    eb(x,
        -
            .170682
    e
        - 0 j1, re
        f

    r
    s
        ult, _params
        )


    jbc
    eb(x,
        -
            .006647
    e
        - 0 j1, re
        f

    r
        sult, _param
    s
        ;


    if
        (doub
    l
        )(resul
    t
        )>


    {
        res
        u
            t =
                0;


        ret
            u
        r
            n
        r
            esult;
    }


    r
        sult =
            (1.5393
    7
    3e + 01))-
        7
            .
    2
    6
    941e+00;


    etu
        n r
        e
    ult
}


private static double jbtbl20(double s,
    alglib.xparams _params)


b
    l

d
    u
b
    le tj1
0;


((do
    ub le )
(
        s
    ) <
    =
    (doubl e) (4.x
    =
    2 * (s - .000 0
0


jbc hb x, 
-.8
47
9
e + 0
    , r
    e
tj
    e
_param
    s
    )
;


jb h
b(x, 1.4 89
4
e + 0 0
    ref t
    j
re f tj1,
    s) ;


jbche b(1. 21 84 01, ef tj e tj
1
r ef resu
    l
t


bcheb(
    x
2.
39
3
7e-
1, r
    e,
    tj1,
    e
result
    ,

b
heb
    x, 
-
    .00
23 7e
    -
    1,
ef tj, re tj1 re f e


jbche b(x1
31e
02, r ef t, ef tj1,

r


jbcheb(x, 3 5
362
e - 02 ,t ef tj1, r e
    f


jbch b
(x
    ,
    9. 5
24 e
03,
    ref t re
tj 1,
;


jbch
e
(x,
    -1. 2
409
02
    ,
    ref
tj, ref

j1, re r
e
    s


jbch
    e
b
(
    x

t
    _p ar ms
    ;


2139e
03, ref
f
    s)
;


j
    bche b(x
f
    e
t
    _
p
    a
r
    ams);


.8
0e tj
1
r
    f r
    e
ul t,
    _param
s
    ;

jbc e(,
    .

061348e-04,
rf t j,
    re
f
    tj1
re
    f
res
    lt, _p ara
    m
    );


, 5.90
8
4
0
e - 04, f ,
re
    f
tj1
    re
f
    res, _pa
ra s);


.97835
3
e
    -
    4
    , ref t j,  ref
    t
    r
f
    rs ult
    _p
a
    ams
    ;
    >(doub
l
    e
    )
0) )


re sult

0;


r
    t
urn res lt


if (d ou bl e) (s) <= double )(15.
0
{
    x = 2(s 4. 00 0
    ) / 1
    1
    000
    00 - 1;


    j = 1;


    x;


    bc h
    e
    b(
        x
        - 5
    03
    0
    89e
    00,

    ef t j
    f tj1,
        ef resu lt
    bch
        e
    b
    (
        1.327151 e + 0
    0,

    ef
        j,
        ef
    j1,

    ef r
    lt _ par
        a
    s);

    6404 - 0
    1
        ,
    e f j,  ref t j1,
        r
    e
        re
    ul
        t
    _p
    ram
        s
        ;


    jbcheb(x
        ref j1
        ,

    rf r sult, _p ar a
    ms
        )


    jbc h
        x,  7.57
    8
    51e-03, r f
        t, a
    rams) ;


    jbch
        e
    b
    (
        x
        ,
        ms);


    59 ref tj 1, r f resul
    t
        x,  -5.3
    8
        -
        04, ref t j, re
    f
        t
    j
    1, ref resul
        t,
        _ pa ra ms;


    3.45 7
    5e - 0 , r
    1ref result, _par
        ms);


    j
    bcheb(
        ,
        -, ref
        t
    j, ref
    j1, ref
    result, _pa
        jb
    h
        b
    (x - 04, r
    f
        t,
        r result
        _
    a
        a
    ms
        jbc
    e
    (
        x 4, ref
        t
        ,
        r re
    s
    l
        t, _pa
    r
        a
    m
        s
        );


    jb 56 r
        f
    t
        j
    1
        ,
        ref resu
    l
        t, _param
    s
        )
    ;
    jb
        h
    b
    (x ref
        t
        ,
        r lt, _p
    a
        r
    a
        s
        );


    j
        b
    heb
        x, 
    9
    890
    59e-04
        ,
        ref tj,

    re t, _pa
    r
        a
    m
        )
    ;


    jb
        c
    eb(
        , 6
            .
    797
    2e-04,

    ef tj,
        r
    ef , _par
        a
    m
        s
        ;


    if
    (
        (do
        ble
            )
    res
        lt)>(d
    o
        ble)(0)
        )
    {
        r
            sul
                = 
            ;
    }


    lt;
}


i
    f
    (d
        ubl

e
        (s)
    = (doub
l
    )(25.00
0
0)


x = 2 *
    (
        -15
00
0
00)
10.
0
000
    - 1;


tj1 = x;


bch
e
(x,
    -7.015
8
4e+00,
r
    ef f resu
l
    t,
    _params);


jbc
    h
b(x
  - 7.48
7
37e-01,

re ef res
    u
l
    t

_params);


jbc
    h
b(x
2.244
2
4e-02,
r
    ef f resu
l
    t,
    _
        params);


f(
    (
        oub
e)(res
u
    t)>(dou
b
le

{
    r
    e
        ult
            = 0
        ;
}


rn res
u
    l
t
    re
s
lt
    - (1.3
1
007e-01
    *
    (s 7.7421
8
5
e
0
0;


re
    ur
n
res
    lt;


}


private static double jbtbl30(double s,
    alglib.xparams _params)
{
    d ou le
    esu
        t
            =
            0;
    double = 0;


    doub le t j1 = 
        ;
    ouble)
    (
        d
    {
        ;


        tj =
            1
            ;


        b
            h
        b
        (
            x
            ,
            -1.638 2
        2
        e + 00 ref tj
            ,

        r
            a
        a
            s
            )


        00, r ef
            tj, f
        t 1, re res lt,
            ra
        s)


        jbch
            e
        e - 02, r ef j ref tj1, re f

        lt
            p
        a
            );


        j
            b
        heb(x, .
        6
        5
        j, ref t j1, ef
        re
        s
            lt,
            _pa
        ra s) ;
        bche b(,
        f tj,
            r
        er f r
            sult,
            ar
        ms);


        2, rf
            t,  ref t  1, ref

        esua m
            s
            ;


        4825e - 0 3, r e, e ul
            t,
            j
        b
        heb
            x, 

        .39
        303
        e
        03,
            ref tj ,
        s
        u
            t, _p rm );


        ch eb(
            x

        -5
        785029 e - 04 ref tj
            ,

        lt, _pa ams);


        jbche
        b
            x,  -1 99
        0
        2
        tj 1, re
            f es l
            t, _params);


        bc
            h
        b(x, -1.037
        8
        8e-04,
        r
            e
        re ul, _
        p
            a
        a
            ms);


        j ch b(x
        6.
        7
        554
        e - 04, r t, ef t
            j
        1
        ams)


        jbch
        e
            (x, .7 44 3e-
        4,
        r
        f t, r ef tj 1
            ,
            ref re su lt, _
        p
        jbcheb
        (
            x
            ,
            -2.821395e-0
        4
        re
            t
        j
            r f j1, re f
            sul, _pa ra ms )

        .39 60 e - 0
        4
            ,
            ref tj, ref
        t
        1, r f es lt,
            _pa
        r
            ms)


        bc h
        e
        ef t, re
        t1 , ef r sult, _ pa ams
            ;


        f((do
            u
                le)(re su lt > (d

        {
            ul
                = 
                ;
        }
    }
    i(
        (
            d
    o
        ub le(s)
           <
        =
        (
            d
    le
        x 2 * (4
    0
        - 4 .5 3
    22 + 00, r f

    tj
        r
    ef tj 1, r
        e
    f resu lt,
        pa
            .
    9
    0
    18 e + 0
        , r f t j, re
    f j1, re res l
        t,
        j,
        r
    f
        t
    j
    para ms;


    jb
        ce b(x,
        -2
            .
    042
    3e-
    0
        , r
    f tj, r ef t 1, ref
    r
        e


    jb e
    b(x, 6. 67928e
            -
            re
    t
        j
    re
        tj
    1
    re
        res ul t,
        ams);


    -2.7 68 5
    8
    e - , ref tj ref
    t1 , re
        r
    e
        ult
    _p
    a
        ams
        ;
    jb
        c
    h
        t
    j re tj1
        r
    e
        f re su t,
        _
    para ms );


    ,
    t j1 ref r
        su l

    046235
        - 04, r ef


    jb ch b(x, -9. 53 6
    4
    6
    9e-05, ref t
        j, 

    ref tj1 , re f es u
        l
    bc
        h
    6e-04, ref tj, re
        tj1,
        ef res
        lt, _pa
    r
        ams);


    if ((d
    o
        uble)(r
    sult)>(
        double)(0) ) {
        lt = 0


        lt;
    }
    if ((
            o
    b
        le e)
    (
        5
    .0000)
        )


    {
        2 * .
        0
        0
        0
        0
            -
            1
            ;


        t
            j
                =
                j
        1

        b
        ch + 00, r
            e
        f
            j,  ref tj1 , r
        e
            re
        ul
            t
        _p
        ram
            s
            ;


        j
            b
        ch - 01, r
            e
        f
            j,  ref tj1 , r
        e
            re
        ul
            t
        _p
        ram
            s
            ;


        j
            b
        ch 02, re
        f
            t,  ref tj1 , r
        e
            re
        ul
            t
        _p
        ram
            s
            ;


        i
            f
        ( >(doub
        l
            e
            )
        0) )


        result
            =
            0
    }


    ret
        u
    n r
    su
        l
        ;
}


r
    es e - 01 * (
    s
    -
    2
5
00000e+01))-
    6
855
88
e
00;


ret
    u
n resul
    t
    ;
}


private static double jbtbl50(double s,
    alglib.xparams _params)
{
    bl
    e
        result
            =
            x = 0;


    d oe tj

    0;


    doubl
        e

    r es l
        t
            =
            0
        ;

    i((du) <= (do
        u
            le )(4. 00 0)
        )


    x = *(s - .
    0
    00
    0
    0)/
    .0
    0
    000
    1;


    t
    1 = x;


    b
    heb
        x,  -1. 362
    9e+00,

    ef j1,  ref r es ul ,
    _params);
    jbc
    eb(
        x
        - 15 1971 e
    00, ref

    sult,
    _
        p
    a
        a
    ms);

    jb
        c
    eb(, 1 1
    4
    699
        - 02, r
    ef tj, re t
        j
    s);


    jbh eb
    (
        , 1
    001204
    e
    01, ref j
        _
    a
        ram s)


    3
    tj1 re
        - 0 ef
        j 1, r ef res
        u
    l
        t, _p ar am s;
        ,
    -
        .
    2
    2
    0
    3
    2e 0
    j
    bcheb(x, 1.03
    3
    60e
        ,
    rf t j, 
    ref
        j1 , r
    f resu
    l
        params
        )
    ;
    ch b(,
    2.58828 0
        - 04
    r
    e
        tj, 
    ref t 
    1,
    ef res ul t

    j ch b(x5 653e-0
    4
        ,
    f r esu
    l
        t, p
    ar am );


    jb
        c
    eb(
        , -
            1
    2873 3e -
        , ref r
        e
    s
    u
        t, _params )
    f((d ble result
    )
    oub
        l
    e

    {
        r
            e
        ult 0;
    }
    tur n r
}

if (
    ou ble)(s
    )
    <
    0


{
    00)/11. 0
    00
    0
        - 1;


    tj1 = x;


    heb
        x, 
    -
        .23
    645e+ 0 ref u _params
        )


    he
        (x, 1.
    1
    9127 e + 00,

    r
        r
    e
    u
        lt, _par
    a
        m
    s)


    j
        ch 0
    esult,
    _
        a

    02, re
        tj, r
    e
        ,


    j
        b
    c
        h
    eb
    (
        x, 9.0
    86 77 e - 03, r
    e
        j,
        j
    bcheb(x,
        -
            1
    .4
    45 83 - 0 3, r ef t j, _p r
        m
    s
        bc h
    b
        x,
        j,
  ref
        t
        j, 
    ref result ,
        pa ra m


    j heb x,  -7 612 8e-0 4, r
        re su lt,
        _
    p
        a
    a
        ms);


    ch e
    (x,
        6.4
    9
    98 7e 4, ef tj ref tj1 , r f


    jbcheb(x,
        .60 5
    e - 4
    re
        tj,
        re f 1, ef re lt, _par am )

    ch eb(
        ,

    8.162
    2
    8
    2e-04,

    r
        e
    f tj, r ef t 1
        ,
    r
    result > (d u
        bl
    r
    su t = 0


    re turn
    e
        u
    l
        t;
}
if (
    (
        d
ou bl )(s) = (d ou le
    )
{
    x = *(s - 15.000000) / 1
    .00000
        - 1;


    t
        =
        tj1 = x


    jb 21095e
    00, re
        j,
        resul,
        _
    a
        ra

    b
        h
    eb 3e-01,
        ref
    t
        ,
    e esult,
        _
    a
        ra


    jb
        c
    h
        e
    b
    (x
        ,
        3.080
    1
    1
    3e-02,

    ef , a
        s
        ;


    if ((
            d
    o
        ub bl
        )
    0
        ) {
        esult
            =
            0
    }


    eturn
    r
        sult;


    r
        e
    s
    l
        t = -(9.3131
    1
    e - 0
        * (
            s
    2.5
    000
    0
        + 01
        )-6.47
    9
    54e+00;


    resul
        t
        ;
}


private static double jbtbl65(double s,
    alglib.xparams _params)
{
    d
        t 0;


    do
        u
            le

    do
        u
            le
    j1

    0;


    re su lt
    0;


    ou le(4 .0 00 0) )
    x = 2
        *
        (
            s
    0.000 00 )/40 00 00
    1;


    t
        = 1;


    jb h
    eb(-1. 00
    24 + 00
    r f

    r
    f tj1,
        s);


    jbc he b 0
        ref tj , r
        f t j1, r
    e
        f


    j cheb(x, 8 0
                - 03
    r ef t j, r
    e
        tj1, r
    e
        f;


    jb ce b(x, 7.e
        ;


    15 , ref
    j1, re
        f
        )

    jbche
    b
    (
        x, -5 - 03,
        e
    e
        jbc he(
        x
        ,
        , r
    f
        r
    e

    i((d uble)(r
    e
    ult
        > (
            d
    ubl
        )(0
        )
        )


    {
        = ;
    }


    r es lt;
}


(s <= (d
o
    u
b
    e)(15.0000) {
    11
        .
    000 - 1
        ;

    tj
        =
        j1 = x;


    jbche
    b
        x,  4 .0 0
    t, _par
        a
    m
        s;


    bch
    b(1.
    14233 + 0 0r f tj r f t, r
    e
    re
        t, _ ar ms)
        , ref
        t
        j,
        r
    ef tj1,  ref
        r
        s, s);


    j
        b
    2, r f

    tj ref t 1, ref
    r
        sul,
        _
    ara
        s);


    e - 02,
    r
        e
    f
        reft j
    1
        , r re lt, _ ara
        s);


    jbch
        e,  152e
        - 0 , ef tj, r ef tj1,
        r es u
        t,
        par
    ms);
    bcheb(
        x
        ,
        1.7 181
    4
    9
    e
        -
        3
    pa ams)


    jbcheb
        - .3 13 7
    0
    re es
        ut, _p arams
        )
    ;


    .0 ,
    r
        f

    t
        j
    1
        , ref res
        u
    l
        t, _params;


    b
    2
    1
    8
    ef
        j, 
        );


    jb he
    b
        x, 
    69 7
    e - 0
        , r
        e
    tj
        ref t 1, re r esul
        t,
        i
    f
    (
        (
            double)(resu
    lt > (do bl )( ) )


    {
    }


    tu
        n
    r
        sul
        ;
}


(2
5
00 00 ) )


{
    0
        =
        1
    heb(x - 5 8589
    5
    r
    su lt, pa r
        m
        )
    ;


    j bc eb(x - 5. 89 1
    79e 0
    1
        , ref t , ref
    t, _para
        s);
    jheb(x, 2.933237e
    02, re
        tj, r
    f tj1,
        r
    ef res
    l
        t, 


    if ((do
        uble)(result) )


    r
        es
}
re
    urn
r
    s
ut }
-
(
.
443768
e
-
0
2
*(
s
-2.500
0
0
0e+01)
)
6.
e
u
l
t
;
}


private static double jbtbl100(double s,
    alglib.xparams _params)
{
    do
        b
            e r
        e;


    double tj =
        dou
    b
        e tj 1
    ult =
        0
        ;


    i
        f(oub
            e)

    (
        )< =(ubl
    e
        (4 .0 0
    0) )


    *(s - 0.
    0
    0
    0
    0
    0 - 1;

    j1 = x
        ;


    jbc
        eb
    (
        , -
        57
    0
    1e+ 0r e,  ref re su l
        t

    _params);


    ref tj 
    1, r es;

    -
        1
    6
    28931e
        -
        0
    2, r f tj
        re f j1, e
    f
        r es l

    h
        b
        (
            je sult,
            params
        )
        ,

    1
        .
    51
    8
    48 7e - 0 3, r
        e
    f
        tj, re
    f
        tj t
        j cheb(
        x
        , -
            j, r e
    r
        f
    r
        e


    jbcheb(x, -4 - 0
    4
        ref tj , r
        e
    para s
        )
    ;


    f(
    do
        u
            le)
    res
        u
    t) >(ube)
        (
        ) )


    r es ul t 0;
}


;


}
i
f
(du bl )(s) = d ou le)( 5
.
0
{
    x
        = 2 * (s
    4.0
    0000)/
    1
    .00000 -
        1
        ;
    1;


    tj1
        =
        x


    eb(x, -
        4
    508e 00
        ,
    r ref re
    su lt, params) ;
    9690e+
    0
        ref re l
        t, _par a)


    j bc
    h
    b(x, 1.6 65 7
    1, ref

    r
    e
        ult, _params
        )


    j bc he b
        x, 
    4.29 00 12 e
        -
        2, ref
    t
        j
    fr es lt, p ar
        );

    , ref tj
        rf tj1, r
        e
    f e
    ul t, par s);


    j b
    04 46 5e 03 , ref
    t
        j,  ref t
        j
    1
        ,
        ref r
        e
    s
    u
        l,
        t
    ram )

    l
}


if ((do
    ue be )(25
    .
000)

x
    =
    2
    (
        s - 15.00 0000) / 10.
000
0 -
    1


tj
    =
    1;


jbc eb
(
    , -86
6
99 +
    0,
rf t j, 
ref j1 ,
    ef resu
    l
t
    jbch
e
b
(x, -6
    .
3
9
9767e-
0
1
    ,

e
    s

b
    h
e
    f re ult, _p ra ms)
;

result
    >
do
    ub e) (0) )


{
    result =
        0;
}

elt;


esult =
    -
        (1.080
9
7e 000e+0
1
    ))-6.48
094e+00
    ;
ult;

}


private static double jbtbl130(double s,
    alglib.xparams _params)
{
    =
    0


    d
        ou
    b
    le x = 0


    d
        o
    u
        b
    l
        e tj 1 = ;


    re
        le
    (
        )< =
    {
        x
            = *0
        000
        00)/4. 0
        0 - 1;


        tj1
            =
            x;


        j
            b
        r ef tj,  ref t j1, r
        e
            re
        ul
            t _pa
            ams
            )


        86 e + 0f ,

        ef
        esu
            l, _
        arams)
        ;
        jbcheb
        (
            x
            , -1. 61 803 2e - 02, re
        f
            tj, re t
            j, r ef res
        u
            t,
            params jbcheb
            (x, 3
        12 0
        2
            , t , ef tj 1


        jbcheb(x, 1 .2 546
                       - 0
        3
        r et,  ref t j1,
            bche b(,
            -
                4
        .73260
        2e - 0 ,
        r
        _para
            s
            ;


        h
            ,
        1
        pa ra )
        ;


        i
        f((d ol d


        {
            re
                su lt
                rt u


            i((doubl e) s)<
            (d
            o
            ble
            (15
                .
            000
                )


            {
                = 2 * (s
                       -
                       4
                           .
                0
                0000)/11.00 0
                tj = 
                    ;


                jbche - ,

                ef
                    r ef tj1, 
                ref resu l

                j
                eb(x, -1.3 31 9
                0
                    + 00 re fe, 
                ref re
                    s
                lt, _ a
                r
                1
                779
                29
                e0 1,
                ef
                    t, re f
                    tj1 re
                f
                    result,
                    _
                b cheb(x, -
                    4
                6744 9e - 0 2
                re
                t j, r ef tj1
                r ef r es ul,
                    jbch
                e
                e
                    .lt
                    ,
                _
                    params
                    )
                ;


                j che
                b
                    x
                rf
                    r f t
                j
                1, ref re
                    s
                u
                    lt, para s
                    );

                dob le(
                    r
                )


                e
                    sult = ;
            }


            re tu r
        }


        if ((doub le )(s
        de 5
            =
            *(s - 15
                .
        00000)/
        10.tj = ;


        93951e
        0,
        re e
        s);


        04e-0
            ,r ef
            tj, re t j1, r
        e
            f

        r
            esult, _para ms )
        ;


        116734
            - 02, r
        e
            t,  ref result , _p
        rams);


        if ((d
        u
            bl double
            )
        (0) )


        {
            r
                sult =
                    0
        }


        resul
            ;


        re
            u
        t
        01 * (s -
            .
        0
        00 10
        3
        4
        e + 00;


        r
            e
        t
            urn re
        s
            lt;
    }


    private static double jbtbl200(double s,
        alglib.xparams _params)

    do uu 0;


    d
    ub le = ;

    d
        ouble t
        j
            = 
        ;


    es
        = 0;


    i f(double)
    (4 .0 0
    0
    0) )


    {
        x =
            2 * (s - 0 0
        0
        0)/4.0
        0
        00 t j
            =
            1;
        t
        1
            =
            x;


        1.1461
        5
        5
        e
        00, ref t ,
        r ef j1,
            re
        f
        res
            lt,
            jbch
        e
        b
        (
            -1 .1 77398e+ 00, r
        ef te ult, _ ar m e b,  .7 02, re
            f t
            pa r
            a
        s
            );


        j
        _pa rams
            ;


        717
        r
        e
            result,
            _
        p
            ar m
            s) ;

        j h
        e4 1

        e
            f

        re su lt, pa rams
            )
        ;


        27
        3
        5
        ms);


        if
        (
            ub
        res
            lt)> (d ubl
            )(0)
        {
            r
                sul
                    = 
                ;
        }

        return resu t;
    }

    if (
        dou bl )(s) <=
    (
        b(


    {
        x 2
            *
            s - 4
        0000 )/1
        .00000
        0 1;
        b
            ref t 1, ref re su l
            jb ch b1 06
            , r
        f tj,
            ef
        j1, r ef re s
            lt, _par a
            m

        b 9
        lt , _p
            r
        m
            s
        j
            - 02,,
        ms
            )


        jb
            c
        h
            eb1 .418812e-
        r
        l
            t,
            _pa ra s);


        jbcheb
        x
            -
            result
        _a ram
            );


        j b
        c
            h
        6705e- 5
            , rf t
        j
            re
        tj
        1
        r ef
        ul t, _p
        a
            ams);

        uble)(
            r
        e
            s
        lt)>(doub e
            )(
            0
        )


        {
        }


        retu rn
        r
            e
        u
            )( )<=(
            ou l
            x =
                *(s - 15 0
                         -
                         t = 1


        tj = x;


        jb he b
        (
            x,
            j, r ef tj
            , r ef re
        sult, _para);

        jbch
        b(x, -
                 .152176e
             -
             01, re

        tj ef res
        u
            lt, _pa
        ams);

        3.725
        93e-02

        e
            f ref r
            s
        l
            ,
        _


        if esult)
        (do
            b
                e
                )0


        resul
            t
                =
                0;
    }
}


r
    e
su - 0
    *
    s
    - 2 764
3
e
    + 0 eturn
    r
e
    s
l
    t;
}


private static double jbtbl301(double s,
    alglib.xparams _params)
{
    d
        uble re
        s
    ul dou
    b
        l
    e
        x
            = 0;


    o = 0;


    e
        le)

    x = 2 * (
        s
        -
        -1;


    tj
    1
        ;


    1 = x;


    0e+ 0 ej r
    e
        f
    jbc eb
    (
        x
        ,
        -1.12 8
    0
    0
    e
        t
    ra s);


    .
    ref t 
    1, ref

    m


    jbcheb
    (
        x
        ,
        1.2 16 66e
               -
               0
    2, ref
    t
        ,
    ul


    bcheb(
        x
        ,
        1 502210e -
          0
    4
        , r
        f
    r
    es
        - 6.414
    5
    4
    3
        , r
        f t
        j, r
    f resrams);


    jbche(,
        6. 5
    11
    5
        ,
    t
        j
    re
        tj1 r
        e
    resul t,
        _

    i
    f
        (
            (dou t)
        >
        dou le(0)
    {
        ;


        r
            e
        t
        rn result;
    }


    i
        f
    le)(15. 0
        )
    x = *
    (
        1;
    tj = 
        ;

    t =
        5e
        +
        0
        , ref
    t
        j, r ef t 1,

    r
        e
    f resul t, _p a

    1
    j - 0
    1
        ref tj
        ,

    r
        e
    f
        tj, re

    b
    b
    (
        x
        ,
        -4.092e-02, rf f
    j
        ,


    779e-02 , r
        e
    r
        e
    re
        ult
    par
        ms) ;


    391e- 3
        ,

    r
    f j,  ref tj  1, r
        e
    r
        t,
        par
    ms)
    ;


    jb heb
    (
        x
            ef

    tj,

    r
    e
        tj1, ef res
        _p a
    am
        s
        ;


    f((d uble)(r
    e
    s


    {
        e
            eturn r
            l


        if double
            (25.00
        0

        2 * (s - 15
        0
        0
        0
        00)/10.00000 - 1


        t
            j = 1;

        x;

        jbcheb(x, .311384e+00, ref
            tj, re
        tj1,
        ef resul
            t, _par
        m
            s)
        j
        bcheb(x
              - 7.918
        763e-01, ref , ref
            esult ,
            _
        a
            ra

        j
            c
        he 4e-02,
        re
            j, resul, _
        a
            a
        m)
        f
                (d t)
            >
            d
        ouble)
        (
                0
            )
            )
    }


    t;


    e
    su - 01 * (s
               -
               2
                   .
    0
    0000e+01))-7
        .
    669
    5e
        +
        0;


    retu
    r
        result
        ;
}


private static double jbtbl501(double s,
    alglib.xparams _params)

double re su l
0;


oube x =
    dou
b
    l
doubl
    e tj 1 0;


res
    lt

0;


i f((d
o
    ble)(s)
        <
    = 


{
    2
        (s 0
    00 00 0
        / 4 0
    0000 - 1
        ;


    t 1 = x

    bch(x,
        1. 06 26e+00
        ,
        f
    re f re u
        lt, _p
    a
        r
    ams);


    j
        e
    r
    b(x, -.4
    3005e-
    03 f
        ul tp
        .
        j
        e
    f te t,
        ult
            >

    rs ul t

    0;
}


((dou
b
    l
e
        (s) <= (double)
    000
    ) )

{
    -4 00 00 00 )/ 1
    .000000 - 1;


    j
    (.1 27 4e+ 0,
        r
    tj, ef
        t
        );


    j
    che
    (x,
        1. 74 9e +
              0
    ef t,
        re f
        rams);
    eb
        x, 

    44 50 - 01
        ,
        ref
    tj,r f tj, r ef r


    j
        bc he b,
        s

    05
    9
    e
        - 04, r
        e
    f

    t
        j, 

    ref tj1 
    ref re s


    jb ch eb
    (
        x
        , 1.19711
    1
    e
        -
        re f
        r
    s
        u


    esult)
        >
    (
        d
    u
        ble)(0) )


    resul =
        0
        ;


    re turn re
    s
        lt;


    f((d oubl
    e
        )
    00 )


    {
        x
            = 2
            (s -
             1
        .00
        000)/1.
        00 00 1;


        ;


        tj
        1 = ;


        result
            p
        a
            c
        ref tj 
        ref t
            j
        p
            b
        c
        heb(x, 4.386
        4
        0
        5e - 0 2, r f tj,  ref
            t
            j
        1
            , re res lt, _ a
            r
        if (double) result)>
        (dble)(0) )


        {
            re


            re
                lt = -
                    1
            4
            8
            33 00000e
            01
                )
            7
            .4

            r
                t
            un
        }


        private static double jbtbl701(double s,
            alglib.xparams _params)
        {
            ubl
                =
                double

            t
                j
                ;
            o u tj1
                = 0;


            r
                e
            s
                ((dd()


            {
                x2 * (s
                      -
                      .000000
                    )
                    /
                    t
                    = 1


                j1
                    x;


                09
                9
                e
                    + 00, r
                    e
                f
                    tj, re

                h
                    e

                jb
                    c
                e
                b(x, -3. 92 6
                8
                0
                e -
                    0
                3, ref
                j , re
                    j ref resul
                    j bcheb(x
                    ,
                    4
                e

                if
                (
                    (
                        o
                uble)(result
                    )( do bl
                e
                    (0)


                e
                    s
                u
                0;
            }

            re
        }

        i f((dou le
        )
        s)<
        (do
            u
                le)
        1
            * s0 0
            )
            /
        j = 1


        t
        j
            x;


        tj, re f tj 1
            ref res ul t, a ms);
        0007e
            + 0 0, r ef tj, r
        e
            f

        t
        1
            )
        b(x, 1
        93 94 2
            ref r
        sul t, _p
        a
            - 2
                .
        3
        8711e- 02 ,e t
        j
            l


        j cheb x, 
        -
            2
        .8
        93 12e-0
        4
            ,

        e
            _pa r
            m
            )
        ;
        j, ref
        r e, m

        i f(e
        0) )


        {
            re su l
                    = 
                ;
        }


        r
            e
        t
            urn re
            s
        u
        l
            t;


        (
            0000)


        000000
            / 10.00
        0


        t 1 = x;


        bch b(,
        -6.917851e+
        0
        tj , ref
        result
            , _params);
        j
        cheb(x
             - 9.81
        020e-01,
            ref tj

        re esult,
            _params
            ;

        j 83727e
        02, re
            j,
            resul,
            _
        a
            ra

        f
            (d t) > (do
            ble
            (
            )

        {
            r
            s
                ult =
                    0
                ;
        }


        re
    }


    resu
    l
        t
            = (s
    2
    5
    00 15e
    0
        ;

    n resu
    l
        t
        ;
}


private static double jbtbl1401(double s,
    alglib.xparams _params)
{
    d
        o
    ble es
    u
        t =
            le tj
        =
        0;

    sul t
    0;


    if (
            (
                double)()
        <
        =
    {
        .
        ;


        t
            j
                = x;


        bc
        he(2 t
            ,
            r
        e
            f

        t
            j1,  ref r es u;


        -10 0
        0
        ms
            )


        jbc
            h
        b(x, -1
            .
        2
        j, ref
        tj
        1
        re
            r
        e
        ul t,
            ra s
            j
        ch b(x, 2 3,
            ef tj,
            r
        f t je l
            t, _ ar ams);


        e


        {
            t;
            s
            u
                t;
        }


        do
            u
                l
        e)(15.
        0
        0
        00


        00000 -
            = x;


        0f tj,

        ams);


        tj
            e
        f
            ams);


        jh b(x
            ,
            1.75 363e-01,
            ref tj,
            re t, _par
        a
            ms


        bch
        b(
            7.7
        135
        9
            - 03
            ref t
            j
        ef tj1, e
            ;


        jb he
        b
            x, 
        24 3
        8e-
        3,
        r
        f t,  ref j1 r f resu
        l
            t


        jbch
            e
        b
        (x, -1
            .
        7
        9
        311 e - 03 r f j, s
        if
        d ou b


        return resul
        t
            ;
    }


    if ((d ul le)(25
    0000) )


    x
    2 * (s -
         5.0000
    0)/10.000
    0
    00 - 1;


    tj = 1
        ;


    tj1 = x;
    jbc
    eb(x,
        7
    5
    44 tj, r
        f
    t
    1
        , _param
        );


    bcheb(
            , -
        .
    2
    58 j, ref
    t
    1
        , _p
        a
    a
        ms);


    jbcheb
    (
        ,,
        e

    r
        e
    s
    u
        lt, _par
    a
        m
    s);


    bl
        )
    r
        es )


    result
        =
        0;
}


re


r
    sul
        =
        (2.
193
7
e - 0
    * (s - 2.
5
0000e+0
1
    ))


return resul
t


}


private static void jbcheb(double x,
    double c,
    ref double tj,
    ref double tj1,
    ref double r,
    alglib.xparams _params)
{
    r + c * j;


    t
        =
        tj1 = t;
}
}

public class variancetests
{
    /*************************************************************************
    Two-sample F-test

    This test checks three hypotheses about dispersions of the given  samples.
    The following tests are performed:
        * two-tailed test (null hypothesis - the dispersions are equal)
        * left-tailed test (null hypothesis  -  the  dispersion  of  the first
          sample is greater than or equal to  the  dispersion  of  the  second
          sample).
        * right-tailed test (null hypothesis - the  dispersion  of  the  first
          sample is less than or equal to the dispersion of the second sample)

    The test is based on the following assumptions:
        * the given samples have normal distributions
        * the samples are independent.

    Input parameters:
        X   -   sample 1. Array whose index goes from 0 to N-1.
        N   -   sample size.
        Y   -   sample 2. Array whose index goes from 0 to M-1.
        M   -   sample size.

    Output parameters:
        BothTails   -   p-value for two-tailed test.
                        If BothTails is less than the given significance level
                        the null hypothesis is rejected.
        LeftTail    -   p-value for left-tailed test.
                        If LeftTail is less than the given significance level,
                        the null hypothesis is rejected.
        RightTail   -   p-value for right-tailed test.
                        If RightTail is less than the given significance level
                        the null hypothesis is rejected.

      -- ALGLIB --
         Copyright 19.09.2006 by Bochkanov Sergey
    *************************************************************************/
    public static void ftest(double[] x,
        int n,
        double[] y,
        int m,
        ref double bothtails,
        ref double lefttail,
        ref double righttail,
        alglib.xparams _params)
    {
        in
        i
        0;

        ou
            e x
            an = 0;
        ouble
            y
        me


        double
            xvar
                =
                0;


        d
        ubl
            yvar = 0;


        int d
        nt
            df2
        0;


        oub
        e stat = 0


        bothta
            is  = 0;


        l
            fttai
                =
                0;


        righttail
            =
            i
            (n <=
             || m <=
            )


        {
            a
                ls
            1.0;


            l
                ettail = 1.0;
                =
            0


            eturn
        }


        //
        M
            /
            xmea
            = 0;


        for
            i
        0;
        i
            <
            =
            n -

        {
            xmean = xm
            an + x[i];


            m
                =
                xmea
                / n;


            yme
            an <=
                -1;
            i++)


            {
                ymean
                    ymean
                yme
                    n = ymean /
                    ;

                    //
                    /
                    / Var
                    anc
                    (us
                        i

                ng cor
                ecte
                    d
                //


                var
                0;

                for (i = ; i <=
                           n -
                           xvar = xv
                    r +
                        ath.sqr(
                            x[
                                xv
                r = x
                v
                ar / (n -
                    );


                for (i = 0;
                     <=
                    -1;
                ++)


                {
                    ean
                        ;
                }


                v(m
                1);

                uble)(xva
                    ) == (d
                ouble
                (0
                 || (doub
                e)(yvar) == (doubl
                e
                    )
                (
                        0
                    )
                    )


                {
                    b
                        o
                    t
                        h
                    t
                        a
                    i
                    l
                        s
                            =
                            1
                                .
                    0
                        ;


                    l
                        efttail = 1.0;


                    rig
                    h
                        ttail
                            =
                            .
                    0;

                    re
                }


                // St
                tistic
                    df1 = n -
                          1;
                df
                    = m - 1


                h.Min(
                    x
                var / yva
                    , yvar /
                    xvar);
                ail
                    -
                    (f ibutio
                (df1,
                    d
                2
                    , ams)-f
                istr.
                    d
                    s
                tr df2,
                    tat,
                    _
                a
                    ra
                eftt
                    i
                        = rib
                tio
                (
                    f
                1, var
                    _p
                r
                    m
                s) righ
                    tail
                        =
                        1
                        - e
            }


            /*************************************************************************
            One-sample chi-square test
    
            This test checks three hypotheses about the dispersion of the given sample
            The following tests are performed:
                * two-tailed test (null hypothesis - the dispersion equals  the  given
                  number)
                * left-tailed test (null hypothesis - the dispersion is  greater  than
                  or equal to the given number)
                * right-tailed test (null hypothesis  -  dispersion is  less  than  or
                  equal to the given number).
    
            Test is based on the following assumptions:
                * the given sample has a normal distribution.
    
            Input parameters:
                X           -   sample 1. Array whose index goes from 0 to N-1.
                N           -   size of the sample.
                Variance    -   dispersion value to compare with.
    
            Output parameters:
                BothTails   -   p-value for two-tailed test.
                                If BothTails is less than the given significance level
                                the null hypothesis is rejected.
                LeftTail    -   p-value for left-tailed test.
                                If LeftTail is less than the given significance level,
                                the null hypothesis is rejected.
                RightTail   -   p-value for right-tailed test.
                                If RightTail is less than the given significance level
                                the null hypothesis is rejected.
    
              -- ALGLIB --
                 Copyright 19.09.2006 by Bochkanov Sergey
            *************************************************************************/
            public static void onesamplevariancetest(double[] x,
                int n,
                double variance,
                ref double bothtails,
                ref double lefttail,
                ref double righttail,
                alglib.xparams _params)

            int i = 0;
            double xmean = 0;
            double xvar = 0;
            double s = 0;
            double stat = 0;

            bothtails = 0;
            lefttail = 0;
            righttail = 0;

            if (n <= 1)
            {
                bothtails = 1.0;
                lefttail = 1.0;
                righttail = 1.0;
                return;
            }

            //
            // Mean
            //
            xmean = 0;
            for (i = 0; i <= n - 1; i++)
            {
                xmean = xmean + x[i];
            }

            xmean = xmean / n;

            //
            // Variance
            //
            xvar = 0;
            for (i = 0; i <= n - 1; i++)
            {
                xvar = xvar + math.sqr(x[i] - xmean);
            }

            xvar = xvar / (n - 1);
            if ((double)(xvar) == (double)(0))
            {
                bothtails = 1.0;
                lefttail = 1.0;
                righttail = 1.0;
                return;
            }

            //
            // Statistic
            //
            stat = (n - 1) * xvar / variance;
            s = chisquaredistr.chisquaredistribution(n - 1, stat, _params);
            bothtails = 2 * Math.Min(s, 1 - s);
            lefttail = s;
            righttail = 1 - lefttail;
        }
    }

    public class wsr
    {
        /*************************************************************************
        Wilcoxon signed-rank test

        This test checks three hypotheses about the median  of  the  given sample.
        The following tests are performed:
            * two-tailed test (null hypothesis - the median is equal to the  given
              value)
            * left-tailed test (null hypothesis - the median is  greater  than  or
              equal to the given value)
            * right-tailed test (null hypothesis  -  the  median  is  less than or
              equal to the given value)

        Requirements:
            * the scale of measurement should be ordinal, interval or  ratio (i.e.
              the test could not be applied to nominal variables).
            * the distribution should be continuous and symmetric relative to  its
              median.
            * number of distinct values in the X array should be greater than 4

        The test is non-parametric and doesn't require distribution X to be normal

        Input parameters:
            X       -   sample. Array whose index goes from 0 to N-1.
            N       -   size of the sample.
            Median  -   assumed median value.

        Output parameters:
            BothTails   -   p-value for two-tailed test.
                            If BothTails is less than the given significance level
                            the null hypothesis is rejected.
            LeftTail    -   p-value for left-tailed test.
                            If LeftTail is less than the given significance level,
                            the null hypothesis is rejected.
            RightTail   -   p-value for right-tailed test.
                            If RightTail is less than the given significance level
                            the null hypothesis is rejected.

        To calculate p-values, special approximation is used. This method lets  us
        calculate p-values with two decimal places in interval [0.0001, 1].

        "Two decimal places" does not sound very impressive, but in  practice  the
        relative error of less than 1% is enough to make a decision.

        There is no approximation outside the [0.0001, 1] interval. Therefore,  if
        the significance level outlies this interval, the test returns 0.0001.

          -- ALGLIB --
             Copyright 08.09.2006 by Bochkanov Sergey
        *************************************************************************/
        public static void wilcoxonsignedranktest(double[] x,
            int n,
            double e,
            ref double bothtails,
            ref double lefttail,
            ref double righttail,
            alglib.xparams _params)
        {
            int j
            0;


            int
                = 
                ;

            int
                = 
                ;
            le tmp
                =
                int
            mp
                = 0;


            nt
                s
                    = 0;


            double
                ] r
                ew double[0]


            int[] c =
                new
                    int[0
                    ];

            double w
                =
                0;

            double p = 0


            do
                u
                    le s
            0;


            oubl

            ig
                a
                    =
                    0
                        = 0;


            x x.Clon
                )

            bot
                tails
            0;

            lefttail =
                0 rightta
                = 


            //          
            //


            if
            n <
                )

            {
                leftta
                    l
                1.0;

                righttai
                1


                return
                    f
                r(i = 
                    ;
                i <
                    n - 1
                i++)
                    ==(
                    oubl
                )(e) )


                {
                    t
                        e
                        ;
                }


                ns =
                    ns
                1;
            }

            if (
                ns < 5)
                otht
                    ils = 1.0;


            lefttail
                = 1.0;


            righ
                tail = 1.0;


            return
        }

        r

        = new
            oubl

        [ns
        1+1];


        c = new
            n
            t[ns - 1
              +
            ];
            for(i= 0; i<=ns-1;
        ++)


        {
            r
                i]
            Math.Ab
            x[i] - e);

            c
                i]
                    = i;
        }

        //
        /

        s
            rt { R, C }


        //


        f(ns!=1


        {
            i = 2;


            do


            {
                =1 )


                {
                    k
                        =
                        t
                        /
                        2
                        ;


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
                    (
                            r
                            [
                                k
                                -
                                1
                            ]
                        )
                        >
                        =
                        (
                            d
                    o
                        u
                    b
                        l
                    e
                        )
                    (
                            r
                            [
                                t
                                -
                                1
                            ]
                        )
                        )


                    {
                        t
                            =
                            1
                            ;


                        e
                            ];


                        -1] =
                        r
                            [t - 1];


                        1]

                        m
                            ;


                        [k
                        -
                            ]


                        t - 1];


                        c[
                                -
                            ]
                            = 
                            = k;
                    }


                    i = i +
                        ;
                        =ns );


                    ns - 1;


                    {
                        tm
                            ri


                        r
                            [
                                i
                            ]
                            = r[0
                            ]
                            ;

                        r[
                            ]
                            =
                            t


                        tm
                            = tmpi;


                        e(

                        {
                            k =
                                2
                            t;

                            if (
                                k
                            i )


                            {
                                t
                                    =
                                    0
                            }


                            {
                                k
                                    i
                                f
                                    d
                                o
                                    u

                                b
                                    le(r
                                        k

                                1]
                                    )
                                    )


                                {
                                    k = k +
                                        ;
                                }


                                if [t
                                e
                                (
                                    [k

                                -
                                    ]) )


                                {
                                    t


                                    0;


                                    e
                                        l
                                    s
                                        e


                                    r[[k -
                                       t
                                    p
                                        = 
                                        = c[t
                                            -
                                        ]
                                        ;


                                    k;
                                }


                                i
                            }
                            >=1 ) /

                            o
                                m
                            p
                                u
                            t
                                e
                            t
                                i
                                    =
                                    0
                                ;


                            {
                                wh


                                {
                                    (
                                        d
                                    o
                                        u
                                    b
                                        l
                                        )
                                    r[i]
                                        )


                                    1


                                    i;
                                    k <
                                        =
                                        -
                                            1;
                                    k
                                        +
                                        )
                                    {
                                        = )/
                                    }
                                }


                                /

                                W +
                                    0
                                    ;


                                i
                                    +
                                    +
                                        f
                                        (ouble
                                        )
                                e
                                    )
                                    )
                                ;


                                /


                                (n * ((w
                                       -
                                       u
                                      )
                                      /
                                      ig(s


                                p
                                    =
                                    M

                                ath.Ex
                                    p
                                    (
                                        w
                                            s

                                i
                                    g
                                m
                                a
                                (
                                    (((
                                        -
                                            -
                                                m
                                u
                                    )/ h.
                                    E
                                    p
                                    (wsigm
                                        a

                                (
                                    (
                                        w
                                        -
                                        m
                                u
                                    )
                                    /
                                si
                                g
                                    ma,
                                    ns,
                                    _
                                p
                                    a
                                r
                                    a
                                m
                                    s
                                    );
                                Ex r
                                m
                                    )
                                    );
                                ef
                                (m s =
                                    2
                                M
                                    a
                                t
                                h
                                    .M
                                    in(lefttail, righttail);
                            }


                            /*************************************************************************
                            Sequential Chebyshev interpolation.
                            *************************************************************************/
                            private static void wcheb(double x,
                                double c,
                                ref double tj,
                                ref double tj1,
                                ref double r,
                                alglib.xparams _params)

                            do
                                ub le


                            t
                        }


                        /*************************************************************************
                        Tail(S, 5)
                        *************************************************************************/
                        private static double w5(double s,
                            alglib.xparams _params)

                        0


                        w
                            =
                            ((3 .5000
                        0
                        e
                            + 0
                        0
                            ;

                        f
                            =
                            31 e - 01;
                    }
                    (
                        08e-0
                    1


                    w
                    {
                        0;
                    }
                    4

                    r
                        =
                        -1.52
                    0
                    e
                        +
                        0
                    0
                        ;
                }


                i
                6e+00
                    ;


                2.
            }


            i( == 1
                +
                0
            0
                ;
        }


        i
            f
            (
                -
                .
                6
                6
    }


    /*************************************************************************
    Tail(S, 6)
    *************************************************************************/
    private static double w6(double s,
        alglib.xparams _params)

    lt = 0;

    t
        d

    uble r
        = 0;


    r = 0
    ;


    (int
    M
    th.R
        o

    und(
        -

    (4
    .
    7
    6
    9
    69
    6
    e
    +
    0
    0
    *
    s) 1
    ;

    f(w
        >=


    {
        r
            =
            -
                .9
        w


        {
            r
                =
                -
                    8
                        .
            630e-
            0
            1
        }
        w =
            8
            )


        {
            r
                = -1.
            0
            6
            e +
                0
                ;
                )
            -
                .
            69e+
            00;
        }
        if (w == 6
           )

        {
            +
                0
        }


        if (w
            =
            5
           )

        {
            e + 00;
        }


        r
            =
            -
    } i f(w
        =
        = 3)


    {
        r = -2.549e+00;
    }
    if( w==2 )
    {
        r = -3.060e+00;
    }

    if( w==1 )
    {
        r = -3.466e+00;
    }

    if( w<=0 )


    =


    result
    =
    r;

    re
        urn re
        ult;
}


/*************************************************************************
Tail(S, 7)
*************************************************************************/
private static double w7(double s,
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


    i
        n
    t
        w
            =
            0
        ;


    d
        o
    u
    ble r = 0;
        = 0;


    w Round(
        -
            (5.9160
    0e+00 * s
        )
    f


    1
}


if (w == 1
3
    )


{
    -.
    if
        (
}


0
    ;

{
    r =
        i
    f(
        =
        r =
            r


    if
    (
        w =
        r = -1

    6 )

    r - 2
    5
    {
        r = -2.549e+00;
    }
    if (w == 4)
    {
        r = -2.906e+00;
    }

    if (w == 3)
    {
        r =
            3.243e
        00;


        (w == 2
            )

        {
            r =
                3.753e
            0
                ;


            1
                -
                .
            59 e
                i
            f(w <= 0
            )

            {
                r = -4.852e+0;
            }


            /*************************************************************************
            Tail(S, 8)
            *************************************************************************/
            private static double w8(double s,
                alglib.xparams _params)
            {
                lt
                    i
                n w


                (
                    28
                e
                00 * s +. 8
            }


            r
                r = -8
            .6


            f(
                r = -
                    9.


            if


            r =
                -1


            r
                = -1.297
            e

            if (w = 1)


                r = -1.46800;
        }
        if (w == 11)
        {
            r = -1.653e+00;
        }

        if (w == 10)
        {
            r = -1.856e+00;
        }

        if (
            w == 9)


        {
            = -2.0
            7
            9e+00;
        }

        {
            r =
                3
                + 0 0
            i f(
                    7
                    - 2 .6 01 e + 0
                ;


            {
                r
                    = -2.9 6e+00
                    ;


                i
                f(
                    w
                        = 5
                2
                (
                    w
                        =
                        4
                )

                9
                    +
                    0
                    ;


                w
                    =
                    5
            }


            if

            sul t
                r;
        }


        /*************************************************************************
        Tail(S, 9)
        *************************************************************************/
        private static double w9(double s,
            alglib.xparams _params)
        {
            b
            e
                sult = ;


            d
                u
            bl
                e
                    =
                    (int)M th Ru 2
            2
            2
            w > 22 )

            6. 9
            3
            e
                - 0
            1;
                )


            {
                if (w == 20)
                {
                    r = -8.912e-01;
                }

                if (w == 19)
                {
                    r = -1.002e+00;
                }

                if (w == 18)
                {
                    r
                        =
                        -
                            1.120e
                    0
                    0;
                }


                if (w ==
                    17)


                    r
                        =
                        r = 1.
                3
                9
                4
                e
                    + 0;
            }


            4
        }


        0


        if (w = 
            =1
            =
            -2
        07
        i
                (w = 
            = 11 )
    }

    f(
        = 
        =1
    0
        )
        =
    -
        .
    501e+00;

    (
        w
            =
            9
    )


    2
    7
    42e+00;

    w
        =
        8
        )


    -
        .
    1
    9e+00;

    w = 
        =7 )


    +
        0


    f
        =
        -
            9e +
        00
}


{
    w = 4
        )


    e + 0
    0;
        =

    e +
}


f(
    +


{
}


/*************************************************************************
Tail(S, 10)
*************************************************************************/
private static double w10(double s,
    alglib.xparams _params)
{
    ouble r
        esult = 0;
    nt w 0


    r = 0;


    (
        9
    .81
    0
    708e
        +
        00 * s)
    +
        2
            .
    750000e+
    7


    r


    5e


    i


    7e


    i


    1

    if w = 
        =2


    r = -
        .

    -
        .
    6
    3
    e + 00;


    ;


    1
    4
    2
    e + 00;


    if (
        w
        =
        r =
            -
}
=

7
4
    ;

7


e +
    0;


{
    -1
}
w = 
{
    00
}


+
if = =13 )


7
e
    + 0 0
    ;


0


5
    = 3.713e+00;
}
if( w==7 )
{
    r = -3.987e+00;
}
if (w == 6)
{
    r = -4.292e+00;
}

if (w =
    5)


{
    r = -
        4
    .629e+0
        ;
}

w == 4
    = 


} f
=
= 3
r
= -5.322e+0
0
;
}
(
w
=
2
)
5
8
33e+00;
w
=
1
)
-
.
3
8e+00;
w<
=
)
6
9
1
e+00;
t
=
r
;
n }


/*************************************************************************
Tail(S, 11)
*************************************************************************/
private static double w11(double s,
    alglib.xparams _params)

do
    ub e e

it
d
    in tM t
47 30
0
0
0e
    + 0
    )
if


{
    -


    {
        7
    }
    f
            .r
        =
        -
            8.
    78
    e


    5
    e
    0
    0;


    if (w = 
        =2
        = 


    if (w
        ==
        r ;


    if (
        w = 


    if (w == 22)

        r
            =
            -
                1.
    7
        + 0


    {
        f(w

        r = -2.119
        e


        f(w = 1


        2. 73 + 0 0;
            ==
        1
            )


        7
            +
            0
            ;


        i {
            r = -2
            607e+0
            0;
        }
        if (w == 15)
        {
            r = -2.788e+00;
        }

        if (w == 14)
        {
            r = -2.980e+00;
        }

        if (w == 13)

        {
            r
                =
                -
        }


        if (w == 12 {
            e + 0
                ;


            i
                    (
                = 


            {
                r =
                    -3.6
                1
                7e+00
                    ;
            }


            if (
                w = 


            {
                r
            }

            w = 


            {
                =
            }

            ==

            {
                =
            }

            =7
                -
        }

        6
        {
            -4
        }

        ) {
            5.
        }

        )
        {
            .6
        }


        01


        26
    }


    1e


    i


    e +
}


re rn

e
    su
lt

}


/*************************************************************************
Tail(S, 12)
*************************************************************************/
private static double w12(double s,
    alglib.xparams _params)
{
    e


    int w
        = 0;


    t
        M
    t
    h.Round(-
        (1 s) 1)
    ;


    9


    01
}


r = -
    7


if
(
    ==


-7.878e-0;
    == 6


1


}
3
1
if( w
=
r
=
-
f
w==33 )
-
1
0
83
e
0
}
3
+0
0


{
    -
}
f


0
}
9
r =
i
(
= -1.552e
+
f(
=
= 2
7
)
{
    1
    6
    0
    e + 00;
        )


    0


    i


    {
    }


    .


    i
    f(
        r
            = 
}

fw == 22 )
{
    r = -2.285e+00;
}
if (w == 21)
{
    r = -2.429e+00;
}

if (w == 20)
{
    r =
        -2.581
        + 00
        ;


    i
        f
    (w == 19
        )

    {
        r = -
            .738e+
        0


        r
            = 
    }


    if (w ==
        1
    7
        )


    {
        r
            =
            -
                .0

        i
        f(w == 16
        )
        {
            r
                =
                -
                    .2

            i
            f(w == 15
            )
            {
                r
                    =
                    -
                        .4

                i
                f(w == 14
                )
                {
                    r
                        =
                        -
                            .6

                    i
                    f(w == 13
                    )
                    {
                        r
                            =
                            -
                                .8

                        i
                        f(w == 12
                        )
                        {
                            r
                                =
                                -
                                    .0

                            i
                            f(w == 11
                            )
                            {
                                r
                                    =
                                    -
                                        .3

                                i
                                f(w == 10
                                )
                                {
                                    r
                                        =
                                        -
                                            .5

                                    i
                                    f(w == 9)
                                        =
                                        -4
                                    82

                                    f
                                        (w == 8)


                                    r
                                        =
                                        -
                                            5.
                                    99
                                    i
                                    (
                                        w == 7)

                                    r
                                        - 5
                                    .3
                                    3e
                                    f

                                    w == 6 )

                                    r
                                        =
                                        -
                                            5.
                                    67
                                    e + i
                                        (
                                            w
                                            == 5)
                                        =
                                        6
                                    .0
                                    15
                                        + 0 f
                                        = 
                                        =4 )
                                        =
                                    -
                                        .
                                    37
                                    2e
                                    00(
                                            w
                                                =
                                                3)
                                        -
                                        6
                                    7
                                    08
                                    e +
                                        0;
                                }
                                =
                                2
                                    )

                                -7
                                    .
                                1
                                9e
                                    + 0
                                    ;
                            }
                            w
                                = 
                                )

                            7.
                            6
                            5
                            e +
                                00
                                <
                                0
                                )


                            .3
                            1
                            e
                                + 0
                            0;


                            ;


                            ult;
                        }


                        /*************************************************************************
                        Tail(S, 13)
                        *************************************************************************/
                        private static double w13(double s,
                            alglib.xparams _params)


                        lt
                            =
                            0
                            ;
                            =
                        bl r = ;


                        (i n
                            t
                        M
                            at
                        h.o un e
                            );
                        if
                        (
                            =
                        if w == 44 )


                        r
                            =
                            -
                                7.
                        48e - 0
                        w = 4 )

                        68 e
                            -
                            1
                            ;


                        {
                        }
                        f
                        {
                            e
                        }


                        r =
                            -1


                        i
                            (w
                        r =
                            -.072e+
                        00
                        i( = 
                            =3
                        8
                            )


                        4
                        6e + 00


                        7


                        4 + 00
                    }
                    if
                    {
                        r
                    }


                    5


                    39

                    if
                    (
                        r


                    if (w = 
                        =3
                        )
                    {
                        = 1. 7

                        f
                            w = =3 )

                        -1
                            .
                        72 +
                            3


                        {
                            00
                                ;


                            {
                                .8
                                    = 29 )


                                {
                                    r = -1.990e+00;
                                }
                                if (w == 28)
                                {
                                    r = -2.104e+00;
                                }

                                if (w == 27)
                                {
                                    r = -2.224e+00;
                                }


                                i
                                f(w ==
                                  6
                                ) {
                                    r =
                                        -2.349e+00;
                                }


                                f
                                    (


                                {
                                    r =
                                        -
                                        .
                                    7
                                    9 +
                                }

                                f
                                    = 
                                    =24
                                    )


                                {
                                    r = -2.61
                                    4
                                    e +
                                }


                                =2 {
                                    e +
                                }


                                =2 {
                                    e +
                                }


                                =2 {
                                    e +
                                }


                                =2 {
                                    e +
                                }


                                =1 {
                                    e +
                                }


                                =1 {
                                    e +
                                }


                                =1 {
                                    e +
                                }


                                =1 {
                                    e +
                                }


                                =1 {
                                    e +
                                }


                                =1 {
                                    e +
                                }


                                =1 {
                                    e +
                                }


                                =1 {
                                    e +
                                }


                                =1 {
                                    e +
                                }


                                =1 {
                                    e +
                                }


                                =9
                                    + 0


                                8


                                00
                            }


                            )


                            r 0;
                        }


                        )


                        r;
                    }


                    r
                        =
                        r
                            =
                            r =
                                -
                                    i


                    r =
                        -7


                    if


                    r = -
                        8.f(
                            r = -9
                    .0


                    r
                        su u
                        t
                }


                /*************************************************************************
                Tail(S, 14)
                *************************************************************************/
                private static double w14(double s,
                    alglib.xparams _params)
                {
                    int
                        .o
                    n
                    d(-(1.592
                    9
                    0


                    if
                    (
                        >=


                    -6.931e-0
                    1


                    w = 
                        =
                    1
                        )


                    2
                    e
                    0
                    1;


                    {
                    }


                    =

                    {
                        -
                    }


                    r 1


                    if (w ==
                        4


                    r
                        =
                        -
                            9
                    66
                    f
                        = 
                        =46 )


                    .0
                    2
                    e
                        + 0
                    0
                        ;


                    {
                    }


                    +
                        r = -
                        1.i
                    f(
                        ==
                        r
                        - 1.383e+0
                    0;
                    w = 
                        =
                    0
                        )
                        .
                    63 +
                        00;


                    ;
                }

                f


                {
                }


                2


                if (
                    w
                    - 1
            }

            (==35 )
            {
                r = -1.911e+00;
            }
            if (w == 34)
            {
                r = -2.011e+00;
            }

            if (w == 33)
            {
                r =
                    2.115e
                00;


                if
                (
                    w == 32


                {
                    r = -2
                    223e+0
                        ;


                    {
                        =
                    }


                    if (w == 3
                    0
                        )


                    {
                        =
                        -2
                        45

                        f
                                (w == 29)
                            =
                            -2
                        57

                        f
                                (w == 28)
                            =
                            -2
                        69

                        f
                                (w == 27)
                            =
                            -2
                        82

                        f
                                (w == 26)
                            =
                            -2
                        95

                        f
                                (w == 25)
                            =
                            -3
                        09

                        f
                                (w == 24)
                            =
                            -3
                        23

                        f
                                (w == 23)
                            =
                            -3
                        38

                        f
                                (w == 22)
                            =
                            -3
                        54

                        f
                                (w == 21)
                            =
                            -3
                        70

                        f
                                (w == 20)
                            =
                            -3
                        86

                        f
                                (w == 19)
                            =
                            -4
                        03

                        f
                                (w == 18)
                            =
                            -4
                        21

                        f
                                (w == 17)
                            =
                            -4
                        40

                        f
                                (w == 16)
                            =
                            -4
                        59

                        f
                                (w == 15)
                            =
                            -4
                        79

                        f
                                (w == 14)
                            =
                            -5
                        00

                        f
                                (w == 13)
                            =
                            -5
                        22

                        f
                                (w == 12)
                            =
                            -5
                        45

                        f
                                (w == 11)
                            =
                            -5
                        69

                        f
                                (w == 10)
                            =
                            -5
                        94

                        f
                            (w == 9)


                        r
                            =
                            -
                                6.
                        08
                        i
                        (
                            w == 8)

                        r
                            - 6
                        .4
                        5e
                        f

                        w == 7 )

                        r
                            =
                            -
                                6.
                        76
                        e + i
                            (
                                w
                                == 6)
                            =
                            7
                        .0
                        65
                            + 0 f
                            = 
                            =5 )
                            =
                        -
                            .
                        40
                        1e
                        00(
                                w
                                    =
                                    4)
                            -
                            7
                        7
                        58
                        e +
                            0;
                    }
                    =
                    3
                        )

                    -8
                        .
                    9
                    5e
                        + 0
                        ;
                }
                w
                    = 
                    )

                8.
                6
                5
                e +
                    00
                    =
                    1
                    )


                .0
                1
                e
                    + 0
                0;
                    =


                70
                4
                    +
                    00
                    ;
                    =
                r
                    lt;
            }


            /*************************************************************************
            Tail(S, 15)
            *************************************************************************/
            private static double w15(double s,
                alglib.xparams _params)
            {
                l


                it
                    r
                        =
                        Ro u
                d
                (-
                    (1
                70.i
                f(w >= 60)


                r =
                    -
                        6.
                71
                e0
                    = 9
                    )


                4e -
                    1
                    ;


                {
                }
                f
                {
                    e
                }


                )

                r = -
                    8.i
                f(
                        w =
                            r =
                                -9 114e-01
                    ;
            }

            w =
                5
            4
                )

            -9 65 e - 0
            1;
                )


            +
        }

        (


        {
            =
        }


        )
        {
            2e


            f
            (
                w =
                    r
                        =
                        f(w =  = 49)


            r - .2 7
            e
            f
                == 48 )


            .3
            3
            00


            {
                r;


                i


                {
                    82
                }
                45


                r
                    =
                    r = -1 .63 6 + if
                w = 
                {
                    r = -117e+00;
                }
                if (w == 42)
                {
                    r = -1.801e+00;
                }

                if (w == 41)
                {
                    r = -1.888e+00;
                }

                f(w ==
                  0)


                {
                    r = -
                        1
                    .977e+0
                        ;
                }
                w == 39
                    )


                r
                    =
                    i
                    (
                        w
                        ==


                {
                    r = -2.166e
                        +
                        0
                    0
                        ;
                }
                if
                (
                    w
                    ==
                    37
                )
                {
                    r
                        =
                        -
                            2.265e+00
                        ;
                }

                if
                (
                    w
                    ==
                    36
                )
                {
                    r
                        =
                        -
                            2.366e+00
                        ;
                }

                if
                (
                    w
                    ==
                    35
                )
                {
                    r
                        =
                        -
                            2.472e+00
                        ;
                }

                if
                (
                    w
                    ==
                    34
                )
                {
                    r
                        =
                        -
                            2.581e+00
                        ;
                }

                if
                (
                    w
                    ==
                    33
                )
                {
                    r
                        =
                        -
                            2.693e+00
                        ;
                }

                if
                (
                    w
                    ==
                    32
                )
                {
                    r
                        =
                        -
                            2.809e+00
                        ;
                }

                if
                (
                    w
                    ==
                    31
                )
                {
                    r
                        =
                        -
                            2.928e+00
                        ;
                }

                if
                (
                    w
                    ==
                    30
                )
                {
                    r
                        =
                        -
                            3.051e+00
                        ;
                }

                if
                (
                    w
                    ==
                    29
                )
                {
                    r
                        =
                        -
                            3.179e+00
                        ;
                }

                if
                (
                    w
                    ==
                    28
                )
                {
                    r
                        =
                        -
                            3.310e+00
                        ;
                }

                if
                (
                    w
                    ==
                    27
                )
                {
                    r
                        =
                        -
                            3.446e+00
                        ;
                }

                if
                (
                    w
                    ==
                    26
                )
                {
                    r
                        =
                        -
                            3.587e+00
                        ;
                }

                if
                (
                    w
                    ==
                    25
                )
                {
                    r
                        =
                        -
                            3.732e+00
                        ;
                }

                if
                (
                    w
                    ==
                    24
                )
                {
                    r
                        =
                        -
                            3.881e+00
                        ;
                }

                if
                (
                    w
                    ==
                    23
                )
                {
                    r
                        =
                        -
                            4.036e+00
                        ;
                }

                if
                (
                    w
                    ==
                    22
                )
                {
                    r
                        =
                        -
                            4.195e+00
                        ;
                }

                if
                (
                    w
                    ==
                    21
                )
                {
                    r
                        =
                        -
                            4.359e+00
                        ;
                }

                if
                (
                    w
                    ==
                    20
                )
                {
                    r
                        =
                        -
                            4.531e+00
                        ;
                }

                if
                (
                    w
                    ==
                    19
                )
                {
                    r
                        =
                        -
                            4.707e+00
                        ;
                }

                if
                (
                    w
                    ==
                    18
                )
                {
                    r
                        =
                        -
                            4.888e+00
                        ;
                }

                if
                (
                    w
                    ==
                    17
                )
                {
                    r
                        =
                        -
                            5.079e+00
                        ;
                }

                if
                (
                    w
                    ==
                    16
                )
                {
                    r
                        =
                        -
                            5.273e+00
                        ;
                }

                if
                (
                    w
                    ==
                    15
                )
                {
                    r
                        =
                        -
                            5.477e+00
                        ;
                }

                if
                (
                    w
                    ==
                    14
                )
                {
                    r
                        =
                        -
                            5.697e+00
                        ;
                }

                if
                (
                    w
                    ==
                    13
                )
                {
                    r
                        =
                        -
                            5.920e+00
                        ;
                }

                if
                (
                    w
                    ==
                    12
                )
                {
                    r
                        =
                        -
                            6.149e+00
                        ;
                }

                if
                (
                    w
                    ==
                    11
                )
                {
                    r
                        =
                        -
                            6.390e+00
                        ;
                }

                if
                (
                    w
                    ==
                    10
                )
                {
                    r
                        =
                        -
                            6.636e+00
                        ;
                }

                if
                (
                    w
                    ==
                    9


                6
                .901e+00;


                f(
                    = 
                    =8
                    )
                    =
                -
                    .
                178e+00;

                (
                    w
                        =
                        7
                )


                7
                4
                53e+00;

                w
                    =
                    6
                    )


                -
                    .
                5
                8e+00;

                w = 
                    =
                    )


                8
                0
                5
                e + 00;
                    ==
                4
                    )
                    .
                5
                e
                    + 00;
                    =3


                7
                8
                    +
                    00;

                2
                    )


                9
                e
                0
                0;
                    )


                4
                    +
                    0
                    ;
                    )


                e
                0
                    ;


                ;


                ult;
            }


            /*************************************************************************
            Tail(S, 16)
            *************************************************************************/
            private static double w16(double s,
                alglib.xparams _params)

            dou le
                = 0;
            do
                = 0;
            th 8e 01 s) +6.800000e + 0 )
        }
        ==
        .1
    }
    if =
    if (w == 65)
    { = -7 .98 e - if w = 6 4 )
        -8. 43 e - 01;
            ) {
            r 1;
        }
        if {
            91
        }
        ) r = -i

        r = -1.042
        e0
            w = =
        59 )


        -.0 6e + 00;
            ==
        5 )
        2
            +
            i


        r
    }


    56


    27


    i


    if w = 
        =5
    4
    {
        r
            =
            f

        w == 5 )

        -
            1
        4
        62
        e0 0
        5


        {
            +0
            0


            {
                1.
            }
            ==


            0;
        }


        {
            r = -1.748e+00;
        }
        if (w == 48)
        {
            r = -1.825e+00;
        }

        if (w == 47)
        {
            r = -1.904e+00;
        }


        if (
            ==4
        6
            )


        r =
            -1.986e
            + 00;

        if (w =
            4
           )
        {
            2.071e
            0
                ;


            {
                r
                    =
                    -
                        2.158e+00;


                if


                r =
                    -2


                if


                r =
                    -2


                if


                r =
                    -2


                if


                r =
                    -2


                if


                r =
                    -2


                if


                r =
                    -2


                if


                r =
                    -2


                if


                r =
                    -2


                if


                r =
                    -3


                if


                r =
                    -3


                if


                r =
                    -3


                if


                r =
                    -3


                if


                r =
                    -3


                if


                r =
                    -3


                if


                r =
                    -3


                if


                r =
                    -3


                if


                r =
                    -4


                if


                r =
                    -4


                if


                r =
                    -4


                if


                r =
                    -4


                if


                r =
                    -4


                if


                r =
                    -4


                if


                r =
                    -5


                if


                r =
                    -5


                if


                r =
                    -5


                if


                r =
                    -5


                if


                r =
                    -5


                if


                r =
                    -5


                if


                r =
                    -6


                if


                r =
                    -6


                if


                r =
                    -6


                if


                r =
                    -6


                if


                r =
                    -7


                if


                r =
                    -7


                if


                r = -
                    7.f(
                        r = -7
                .8


                i
                (
                    r = -8.
                14


                if
                w
                    r = -8.4
                51


                i
                f(
                    w =
                        r = -8.78
                8e


                if
                (
                    ==

                r
                    = -9.144
                e +
                    i
                f(
                    w
                        = 3
                            = -9.481e
                              + 0

                f
                (
                    w =
                        2
                r
                    =
                    -9.992e+
                00
                i
                (
                    w
                    ==
                ) {
                    -1.040e+0
                    1;
                }
                i
                    f

                w <
                    = 0
                    )
                {
                    r
                        =
                        -
                            1.109e+01
                        ;
                }
                re
                    s
                l
                    t
                        = 
                    ;
                re
            }


            /*************************************************************************
            Tail(S, 17)
            *************************************************************************/
            private static double w17(double s,
                alglib.xparams _params)


            ob l
            e result
                = 


            do
                bl
                    w = (in
            t) (
                65
            0
            0
            0e
                + 0
                );

            {
                9
            }


            5


            r
                = 


            if
            w
                r
                    = -7.695e
                      - 0
                      (
                          w
                              =
                              73
                      )

            8
            07 e
                - 01;


            ;
        }

        f


        {
            =
        }


        )


        -


        if (w
            ==
            r
            =
            -
                .8

        f w
            == 68 )


        1.
        0
        3
        e +
            00


        7
            )

        {
            ;


            {
                -
            }


            =


            r 0


            if


            r = -1.2
            40
            i
            f
                w =
                    =
            3


            1. 295e+00;


            2


            3
                +
                0
                ;


            {
            }

            w
            {
                -
                    0


                i f(w=
                    =

                5
                    =
                    -
                        .6
                f

                w == 57 )
                    = -
                    1. 66 +
                    0
                    ;
            }


            +0 0


            {
                =
                (
                    e +
                )
                r = -1 i f
                    == {
                    .028e+00;
                }
                if (w == 51)
                {
                    r = -2.106e+00;
                }

                if (w == 50)
                {
                    r = -2.186e+00;
                }

                if (w
                    = 49)


                {
                    r =
                        -2.269e
                    00;
                }

                f(w ==
                  8)


                r 0;


                i
                (
                    w


                {
                    r = -2.44
                    0
                    e
                        +
                        0
                    0;


                    i
                    (
                        w
                        ==
                        6
                    r
                        =
                        -2.530e+
                    00
                    i
                    (
                        w
                        ==
                        5
                    r
                        =
                        -2.621e+
                    00
                    i
                    (
                        w
                        ==
                        4
                    r
                        =
                        -2.715e+
                    00
                    i
                    (
                        w
                        ==
                        3
                    r
                        =
                        -2.812e+
                    00
                    i
                    (
                        w
                        ==
                        2
                    r
                        =
                        -2.911e+
                    00
                    i
                    (
                        w
                        ==
                        1
                    r
                        =
                        -3.012e+
                    00
                    i
                    (
                        w
                        ==
                        0
                    r
                        =
                        -3.116e+
                    00
                    i
                    (
                        w
                        ==
                        9
                    r
                        =
                        -3.223e+
                    00
                    i
                    (
                        w
                        ==
                        8
                    r
                        =
                        -3.332e+
                    00
                    i
                    (
                        w
                        ==
                        7
                    r
                        =
                        -3.445e+
                    00
                    i
                    (
                        w
                        ==
                        6
                    r
                        =
                        -3.560e+
                    00
                    i
                    (
                        w
                        ==
                        5
                    r
                        =
                        -3.678e+
                    00
                    i
                    (
                        w
                        ==
                        4
                    r
                        =
                        -3.799e+
                    00
                    i
                    (
                        w
                        ==
                        3
                    r
                        =
                        -3.924e+
                    00
                    i
                    (
                        w
                        ==
                        2
                    r
                        =
                        -4.052e+
                    00
                    i
                    (
                        w
                        ==
                        1
                    r
                        =
                        -4.183e+
                    00
                    i
                    (
                        w
                        ==
                        0
                    r
                        =
                        -4.317e+
                    00
                    i
                    (
                        w
                        ==
                        9
                    r
                        =
                        -4.456e+
                    00
                    i
                    (
                        w
                        ==
                        8
                    r
                        =
                        -4.597e+
                    00
                    i
                    (
                        w
                        ==
                        7
                    r
                        =
                        -4.743e+
                    00
                    i
                    (
                        w
                        ==
                        6
                    r
                        =
                        -4.893e+
                    00
                    i
                    (
                        w
                        ==
                        5
                    r
                        =
                        -5.047e+
                    00
                    i
                    (
                        w
                        ==
                        4
                    r
                        =
                        -5.204e+
                    00
                    i
                    (
                        w
                        ==
                        3
                    r
                        =
                        -5.367e+
                    00
                    i
                    (
                        w
                        ==
                        2
                    r
                        =
                        -5.534e+
                    00
                    i
                    (
                        w
                        ==
                        1
                    r
                        =
                        -5.706e+
                    00
                    i
                    (
                        w
                        ==
                        0
                    r
                        =
                        -5.884e+
                    00
                    i
                    (
                        w
                        ==
                        9
                    r
                        =
                        -6.066e+
                    00
                    i
                    (
                        w
                        ==
                        8
                    r
                        =
                        -6.254e+
                    00
                    i
                    (
                        w
                        ==
                        7
                    r
                        =
                        -6.451e+
                    00
                    i
                    (
                        w
                        ==
                        6
                    r
                        =
                        -6.654e+
                    00
                    i
                    (
                        w
                        ==
                        5
                    r
                        =
                        -6.864e+
                    00
                    i
                    (
                        w
                        ==
                        4
                    r
                        =
                        -7.083e+
                    00
                    i
                    (
                        w
                        ==
                        3
                    r
                        =
                        -7.306e+
                    00
                    i
                    (
                        w
                        ==
                        2
                    r
                        =
                        -7.535e+
                    00
                    i
                    (
                        w
                        ==
                        1
                    r
                        =
                        -7.776e+
                    00
                    i
                    (
                        w
                        ==
                        0
                    r
                        =
                        -8.022e+
                    00
                    i
                    (
                        w
                        ==
                    ) {
                        -8.287e+0
                        0;
                    }
                    i
                    f
                        w =
                            =8
                        )
                    {
                        r
                            =
                            -
                                8.565e+00
                            ;
                    }
                    if
                    (
                        w
                        ==
                        7


                    8
                    .839e+00;


                    f(
                        = 
                        =6
                        )
                        =
                    -
                        .
                    144e+00;

                    (
                        w
                            =
                            5
                    )


                    9
                    4
                    81e+00;

                    w
                        =
                        4
                        )


                    -
                        .
                    3
                    8e+00;

                    w = 
                        =
                        )


                    1
                    0
                    7
                    e + 01;
                        ==
                    2
                        )
                        .
                    6
                    e
                        + 01;
                        =1


                    1
                    9
                        +
                        01;

                    0
                        )


                    7
                    e
                    0
                    1;

                    r
                        ;


                    esult;
                }


                /*************************************************************************
                Tail(S, 18)
                *************************************************************************/
                private static double w18(double s,
                    alglib.xparams _params)


                doubl e
                    re
                        = 0;
                    = ;


                w R
                3e 01 s) +8. 5
                00


                {
                    r


                    f
                    {
                        6
                    }
                    )

                    r =
                        -7
                    if
                        ==
                    r =
                        -8.001e - 0
                    1;
                    if w = 8 1 )

                    8. 81 -
                        01;
                        )
                    {
                        ;
                    }


                    {
                        -
                            r 1

                        if (w ==
                            77
                        r = - .
                        03
                        i( = 
                            =76 )


                        -.0 7e + 00


                        5

                        {
                            00


                            {
                                .
                            }

                            7

                            r
                                =
                                i
                                (
                                    r = -1.2 38
                            e +
                            if w == 7 )
                            {
                                2
                                89e+00;

                                w =  =


                                42 + 0;
                            }

                            =6


                            .4


                            f
                                ;


                            i f(w==
                            6


                            r - .

                            i
                                    ( == 5 )
                                =
                            -
                                .
                            62 8
                                ;
                                =
                            4
                                )


                            e +
                                0
                                ;


                            {
                                -1


                                w = 
                                {
                                    00
                                }


                                r = -
                                    1


                                f(
                                {
                                    r = 1.953e+00;
                                }
                                if (w == 59)
                                {
                                    r = -2.023e+00;
                                }

                                if (w == 58)
                                {
                                    r = -2.095e+00;
                                }

                                if (
                                    ==57 )


                                {
                                    r
                                        =
                                        -2.168
                                        + 00;
                                }
                                if (w =
                                    56)


                                    00;


                                f
                                    (


                                {
                                    r = -2.3
                                    2
                                    1
                                    e
                                        +
                                        00;


                                    f
                                    (
                                        w =
                                            54
                                                = -2.400e
                                                  + 0

                                    f
                                    (
                                        w =
                                            53
                                                = -2.481e
                                                  + 0

                                    f
                                    (
                                        w =
                                            52
                                                = -2.564e
                                                  + 0

                                    f
                                    (
                                        w =
                                            51
                                                = -2.648e
                                                  + 0

                                    f
                                    (
                                        w =
                                            50
                                                = -2.735e
                                                  + 0

                                    f
                                    (
                                        w =
                                            49
                                                = -2.824e
                                                  + 0

                                    f
                                    (
                                        w =
                                            48
                                                = -2.915e
                                                  + 0

                                    f
                                    (
                                        w =
                                            47
                                                = -3.008e
                                                  + 0

                                    f
                                    (
                                        w =
                                            46
                                                = -3.104e
                                                  + 0

                                    f
                                    (
                                        w =
                                            45
                                                = -3.201e
                                                  + 0

                                    f
                                    (
                                        w =
                                            44
                                                = -3.301e
                                                  + 0

                                    f
                                    (
                                        w =
                                            43
                                                = -3.403e
                                                  + 0

                                    f
                                    (
                                        w =
                                            42
                                                = -3.508e
                                                  + 0

                                    f
                                    (
                                        w =
                                            41
                                                = -3.615e
                                                  + 0

                                    f
                                    (
                                        w =
                                            40
                                                = -3.724e
                                                  + 0

                                    f
                                    (
                                        w =
                                            39
                                                = -3.836e
                                                  + 0

                                    f
                                    (
                                        w =
                                            38
                                                = -3.950e
                                                  + 0

                                    f
                                    (
                                        w =
                                            37
                                                = -4.068e
                                                  + 0

                                    f
                                    (
                                        w =
                                            36
                                                = -4.188e
                                                  + 0

                                    f
                                    (
                                        w =
                                            35
                                                = -4.311e
                                                  + 0

                                    f
                                    (
                                        w =
                                            34
                                                = -4.437e
                                                  + 0

                                    f
                                    (
                                        w =
                                            33
                                                = -4.565e
                                                  + 0

                                    f
                                    (
                                        w =
                                            32
                                                = -4.698e
                                                  + 0

                                    f
                                    (
                                        w =
                                            31
                                                = -4.833e
                                                  + 0

                                    f
                                    (
                                        w =
                                            30
                                                = -4.971e
                                                  + 0

                                    f
                                    (
                                        w =
                                            29
                                                = -5.113e
                                                  + 0

                                    f
                                    (
                                        w =
                                            28
                                                = -5.258e
                                                  + 0

                                    f
                                    (
                                        w =
                                            27
                                                = -5.408e
                                                  + 0

                                    f
                                    (
                                        w =
                                            26
                                                = -5.561e
                                                  + 0

                                    f
                                    (
                                        w =
                                            25
                                                = -5.717e
                                                  + 0

                                    f
                                    (
                                        w =
                                            24
                                                = -5.878e
                                                  + 0

                                    f
                                    (
                                        w =
                                            23
                                                = -6.044e
                                                  + 0

                                    f
                                    (
                                        w =
                                            22
                                                = -6.213e
                                                  + 0

                                    f
                                    (
                                        w =
                                            21
                                                = -6.388e
                                                  + 0

                                    f
                                    (
                                        w =
                                            20
                                                = -6.569e
                                                  + 0

                                    f
                                    (
                                        w =
                                            19
                                                = -6.753e
                                                  + 0

                                    f
                                    (
                                        w =
                                            18
                                                = -6.943e
                                                  + 0

                                    f
                                    (
                                        w =
                                            17
                                                = -7.144e
                                                  + 0

                                    f
                                    (
                                        w =
                                            16
                                                = -7.347e
                                                  + 0

                                    f
                                    (
                                        w =
                                            15
                                                = -7.557e
                                                  + 0

                                    f
                                    (
                                        w =
                                            14
                                                = -7.776e
                                                  + 0

                                    f
                                    (
                                        w =
                                            13
                                                = -7.999e
                                                  + 0

                                    f
                                    (
                                        w =
                                            12
                                                = -8.228e
                                                  + 0

                                    f
                                    (
                                        w =
                                            11
                                                = -8.469e
                                                  + 0

                                    f
                                    (
                                        w =
                                            10
                                                = -8.715e
                                                  + 0

                                    f
                                    (
                                        w =
                                            9
                                    r
                                        =
                                        -8.980e+
                                    00
                                    i
                                    (
                                        w
                                        ==
                                    ) {
                                        -9.258e+0
                                        0;
                                    }
                                    i
                                    f
                                        w =
                                            =7
                                        )
                                    {
                                        r
                                            =
                                            -
                                                9.532e+00
                                            ;
                                    }
                                    if
                                    (
                                        w
                                        ==
                                        6


                                    9
                                    .838e+00;


                                    f(
                                        = 
                                        =5
                                        )
                                        =
                                    -
                                        .
                                    017e+01;

                                    (
                                        w
                                            =
                                            4
                                    )


                                    1
                                    0
                                    53e+01;

                                    w
                                        =
                                        3
                                        )


                                    -
                                        .
                                    8
                                    7e+01;

                                    w = 
                                        =
                                        )


                                    1
                                    1
                                    8
                                    e + 01;
                                        ==
                                    1
                                        )
                                        .
                                    7
                                    e
                                        + 01;
                                        =0


                                    2
                                    8
                                        +
                                        01;
                                        =
                                    r
                                        result;
                                }


                                /*************************************************************************
                                Tail(S, 19)
                                *************************************************************************/
                                private static double w19(double s,
                                    alglib.xparams _params)
                                {
                                    r

                                    i t
                                            =
                                            r =
                                                0
                                        ;
                                    w
                                    nd((2
                                    .4 49
                                    5e 0
                                    f

                                    w >= 95 )


                                    -67 7
                                    6e 01
                                        )


                                    {
                                        01;


                                        {
                                            -
                                        }
                                        =


                                        r 1


                                        if


                                        r = -8
                                        .0
                                        90
                                        f(
                                                w = 9
                                            )
                                            -
                                            .
                                        445e-01;
                                            =8 9)


                                        1


                                        {
                                        }


                                        8
                                        {
                                            7


                                            if
                                            (
                                                r
                                                -
                                                i
                                            f(w == 8 5
                                            )


                                            r = -1
                                            .0 8e
                                            00
                                            8
                                                )


                                            0e + 0;


                                            {
                                            }
                                            (
                                                e
                                        }


                                        r =
                                            -
                                                1.

                                        if w
                                            = 8
                                              - 1.259e +
                                              00
                                            ;
                                    }
                                    w = 7 9
                                        )

                                    1. 07 +
                                        00;
                                        )
                                }

                                (

                                {
                                    =
                                }
                                )
                                {
                                    e +
                                }
                                if (
                                    =


                                r -
                                    i(w == 74)


                                r = -.5 6e + 0(
                                    w
                                3


                                .6
                                2
                                e + 00
                                    )

                                {
                                    r;


                                    if


                                    {
                                        36
                                    }

                                    0


                                    r
                                        r = 1. 85
                                    7
                                    if
                                        = =


                                    r = -1.9e+00;
                                }
                                if (w == 67)
                                {
                                    r = -1.983e+00;
                                }

                                if (w == 66)
                                {
                                    r = -2.048e+00;
                                }

                                i
                                (w == 6
                                )


                                {
                                    r = -2
                                        .
                                    115e+00
                                }
                                w == 64
                                    = 
                            }
                            f
                                = 
                                =6

                            {
                                r = -2.253e+
                                0
                                0
                                    ;
                            }

                            f(
                                = 
                                =6
                            2


                            2
                            .325e+00;


                            f(
                                = 
                                =6
                            1


                            2
                            .398e+00;


                            f(
                                = 
                                =6
                            0


                            2
                            .472e+00;


                            f(
                                = 
                                =5
                            9


                            2
                            .548e+00;


                            f(
                                = 
                                =5
                            8


                            2
                            .626e+00;


                            f(
                                = 
                                =5
                            7


                            2
                            .706e+00;


                            f(
                                = 
                                =5
                            6


                            2
                            .787e+00;


                            f(
                                = 
                                =5
                            5


                            2
                            .870e+00;


                            f(
                                = 
                                =5
                            4


                            2
                            .955e+00;


                            f(
                                = 
                                =5
                            3


                            3
                            .042e+00;


                            f(
                                = 
                                =5
                            2


                            3
                            .130e+00;


                            f(
                                = 
                                =5
                            1


                            3
                            .220e+00;


                            f(
                                = 
                                =5
                            0


                            3
                            .313e+00;


                            f(
                                = 
                                =4
                            9


                            3
                            .407e+00;


                            f(
                                = 
                                =4
                            8


                            3
                            .503e+00;


                            f(
                                = 
                                =4
                            7


                            3
                            .601e+00;


                            f(
                                = 
                                =4
                            6


                            3
                            .702e+00;


                            f(
                                = 
                                =4
                            5


                            3
                            .804e+00;


                            f(
                                = 
                                =4
                            4


                            3
                            .909e+00;


                            f(
                                = 
                                =4
                            3


                            4
                            .015e+00;


                            f(
                                = 
                                =4
                            2


                            4
                            .125e+00;


                            f(
                                = 
                                =4
                            1


                            4
                            .236e+00;


                            f(
                                = 
                                =4
                            0


                            4
                            .350e+00;


                            f(
                                = 
                                =3
                            9


                            4
                            .466e+00;


                            f(
                                = 
                                =3
                            8


                            4
                            .585e+00;


                            f(
                                = 
                                =3
                            7


                            4
                            .706e+00;


                            f(
                                = 
                                =3
                            6


                            4
                            .830e+00;


                            f(
                                = 
                                =3
                            5


                            4
                            .957e+00;


                            f(
                                = 
                                =3
                            4


                            5
                            .086e+00;


                            f(
                                = 
                                =3
                            3


                            5
                            .219e+00;


                            f(
                                = 
                                =3
                            2


                            5
                            .355e+00;


                            f(
                                = 
                                =3
                            1


                            5
                            .493e+00;


                            f(
                                = 
                                =3
                            0


                            5
                            .634e+00;


                            f(
                                = 
                                =2
                            9


                            5
                            .780e+00;


                            f(
                                = 
                                =2
                            8


                            5
                            .928e+00;


                            f(
                                = 
                                =2
                            7


                            6
                            .080e+00;


                            f(
                                = 
                                =2
                            6


                            6
                            .235e+00;


                            f(
                                = 
                                =2
                            5


                            6
                            .394e+00;


                            f(
                                = 
                                =2
                            4


                            6
                            .558e+00;


                            f(
                                = 
                                =2
                            3


                            6
                            .726e+00;


                            f(
                                = 
                                =2
                            2


                            6
                            .897e+00;


                            f(
                                = 
                                =2
                            1


                            7
                            .074e+00;


                            f(
                                = 
                                =2
                            0


                            7
                            .256e+00;


                            f(
                                = 
                                =1
                            9


                            7
                            .443e+00;


                            f(
                                = 
                                =1
                            8


                            7
                            .636e+00;


                            f(
                                = 
                                =1
                            7


                            7
                            .837e+00;


                            f(
                                = 
                                =1
                            6


                            8
                            .040e+00;


                            f(
                                = 
                                =1
                            5


                            8
                            .250e+00;


                            f(
                                = 
                                =1
                            4


                            8
                            .469e+00;


                            f(
                                = 
                                =1
                            3


                            8
                            .692e+00;


                            f(
                                = 
                                =1
                            2


                            8
                            .921e+00;


                            f(
                                = 
                                =1
                            1


                            9
                            .162e+00;


                            f(
                                = 
                                =1
                            0


                            9
                            .409e+00;


                            f(
                                = 
                                =9
                                )
                                =
                            -
                                .
                            673e+00;

                            (
                                w
                                    =
                                    8
                            )


                            9
                            9
                            51e+00;

                            w
                                =
                                7
                                )


                            -
                                .
                            2
                            3e+01;

                            w = 
                                =
                                )


                            1
                            0
                            3
                            e + 01;
                                ==
                            5
                                )
                                .
                            8
                            e
                                + 01;
                                =4


                            1
                            2
                                +
                                01;

                            3
                                )


                            5
                            e
                            0
                            1;
                                )


                            7
                                +
                                1
                                ;
                                )


                            e
                            0
                                ;


                            +
                                1


                            lt;
                        }


                        /*************************************************************************
                        Tail(S, 20)
                        *************************************************************************/
                        private static double w20(double s,
                            alglib.xparams _params)


                        le
                            re s

                        double
                            r =
                                w =
                                    (-+
                                        00 e + 02);

                        w >

                        {
                            -6


                            01
                            if (w
                                = 1

                            r
                                =
                                w == 102 )

                            r

                            .6 8
                            6e -
                        }
                        w
                            )

                        00
                        4
                            ;


                        {
                            =


                            (
                                e -
                                    r =
                                    -.

                            i
                            f(
                                -9.363e-0
                            1
                        }
                        if
                        (
                            96
                        )

                            9
                        01;
                            )


                        ;
                    }

                    w =
                        1.i
                        ;

                    if (w ==
                        9
                        =
                        -1.
                        =9 1 )

                    -
                        1
                    e + 0
                    0;

                    0
                    {
                        00
                            ;


                        i
                        {
                            25
                        }


                        8
                        r


                        f(
                            r = -1.34
                        4 +
                            i f(w =  = 6
                        {
                            r
                                =
                                .3 0e + 00;


                            w = 
                                =
                            5 )

                            3
                            e
                            00


                            {
                            }


                            =8

                            {
                                .5
                            }


                            ;


                            if w ==
                                8


                            r
                                -
                                i
                                (
                                    w == 8)
                                =
                                -
                                .
                            69
                            2
                                +
                                =
                                9
                                )


                            e +
                                0
                                ;


                            {
                                -1


                                w = 
                                {
                                    00
                                }


                                {
                                    r = -1.916e+00;
                                }
                                if (w == 75)
                                {
                                    r = -1.976e+00;
                                }

                                if (w == 74)
                                {
                                    r = -2.036e+00;
                                }


                                if (
                                    w ==
                                    7
                                3 )


                                r
                                    - 2.098
                                e + 00;

                                if (w
                                    =
                                    2
                                   )
                                {
                                    -2.161
                                        +
                                        0


                                    1
                                        )


                                    {
                                        r
                                            =
                                            -2.225e+00;


                                        if


                                        r =
                                            -2


                                        f(
                                            r = -
                                                2.i
                                                (
                                                    r = -2
                                        .4


                                        if
                                        w
                                            r = -2.
                                        49


                                        if (
                                            w =
                                            r = -2.5
                                        66


                                        i
                                        f(
                                            ==
                                            r = -2.63
                                        9e


                                        if
                                        (
                                            ==


                                        r = -2.71
                                        3e


                                        if
                                        (
                                            ==


                                        r = -2.78
                                        8e


                                        if
                                        (
                                            ==


                                        r = -2.86
                                        5e


                                        if
                                        (
                                            ==


                                        r = -2.94
                                        3e


                                        if
                                        (
                                            ==


                                        r = -3.02
                                        3e


                                        if
                                        (
                                            ==


                                        r = -3.10
                                        4e


                                        if
                                        (
                                            ==


                                        r = -3.18
                                        7e


                                        if
                                        (
                                            ==


                                        r = -3.27
                                        2e


                                        if
                                        (
                                            ==


                                        r = -3.35
                                        8e


                                        if
                                        (
                                            ==


                                        r = -3.44
                                        6e


                                        if
                                        (
                                            ==


                                        r = -3.53
                                        6e


                                        if
                                        (
                                            ==


                                        r = -3.62
                                        7e


                                        if
                                        (
                                            ==


                                        r = -3.72
                                        1e


                                        if
                                        (
                                            ==


                                        r = -3.81
                                        5e


                                        if
                                        (
                                            ==


                                        r = -3.91
                                        2e


                                        if
                                        (
                                            ==


                                        r = -4.01
                                        1e


                                        if
                                        (
                                            ==


                                        r = -4.11
                                        1e


                                        if
                                        (
                                            ==


                                        r = -4.21
                                        4e


                                        if
                                        (
                                            ==


                                        r = -4.31
                                        8e


                                        if
                                        (
                                            ==


                                        r = -4.42
                                        5e


                                        if
                                        (
                                            ==


                                        r = -4.53
                                        4e


                                        if
                                        (
                                            ==


                                        r = -4.64
                                        4e


                                        if
                                        (
                                            ==


                                        r = -4.75
                                        7e


                                        if
                                        (
                                            ==


                                        r = -4.87
                                        2e


                                        if
                                        (
                                            ==


                                        r = -4.99
                                        0e


                                        if
                                        (
                                            ==


                                        r = -5.10
                                        9e


                                        if
                                        (
                                            ==


                                        r = -5.23
                                        2e


                                        if
                                        (
                                            ==


                                        r = -5.35
                                        6e


                                        if
                                        (
                                            ==


                                        r = -5.48
                                        4e


                                        if
                                        (
                                            ==


                                        r = -5.61
                                        4e


                                        if
                                        (
                                            ==


                                        r = -5.74
                                        6e


                                        if
                                        (
                                            ==


                                        r = -5.88
                                        2e


                                        if
                                        (
                                            ==


                                        r = -6.02
                                        0e


                                        if
                                        (
                                            ==


                                        r = -6.16
                                        1e


                                        if
                                        (
                                            ==


                                        r = -6.30
                                        5e


                                        if
                                        (
                                            ==


                                        r = -6.45
                                        3e


                                        if
                                        (
                                            ==


                                        r = -6.60
                                        3e


                                        if
                                        (
                                            ==


                                        r = -6.75
                                        7e


                                        if
                                        (
                                            ==


                                        r = -6.91
                                        5e


                                        if
                                        (
                                            ==


                                        r = -7.07
                                        6e


                                        if
                                        (
                                            ==


                                        r = -7.24
                                        2e


                                        if
                                        (
                                            ==


                                        r = -7.41
                                        1e


                                        if
                                        (
                                            ==


                                        r = -7.58
                                        4e


                                        if
                                        (
                                            ==


                                        r = -7.76
                                        3e


                                        if
                                        (
                                            ==


                                        r = -7.94
                                        7e


                                        if
                                        (
                                            ==


                                        r = -8.13
                                        6e


                                        if
                                        (
                                            ==


                                        r = -8.33
                                        0e


                                        if
                                        (
                                            ==


                                        r = -8.53
                                        0e


                                        if
                                        (
                                            ==


                                        r = -8.73
                                        3e


                                        if
                                        (
                                            ==


                                        r = -8.94
                                        3e


                                        if
                                        (
                                            ==


                                        r = -9.16
                                        2e


                                        if
                                        (
                                            ==


                                        r = -9.38
                                        6e


                                        if
                                        (
                                            ==


                                        r = -9.61
                                        4e


                                        if
                                        (
                                            ==


                                        r = -9.85
                                        6e


                                        if
                                        (
                                            ==


                                        r = -1.01
                                        0e


                                        if
                                        (
                                            ==

                                        r
                                            = -1.037
                                        e +
                                            i
                                        f(
                                            w
                                                = 8
                                                    = -1.064e
                                                      + 0

                                        f
                                        (
                                            w =
                                                7
                                        r
                                            =
                                            -1.092e+
                                        01
                                        i
                                        (
                                            w
                                            ==
                                        ) {
                                            -1.122e+0
                                            1;
                                        }
                                        i
                                        f
                                            w =
                                                =5
                                            )
                                        {
                                            r
                                                =
                                                -
                                                    1.156e+01
                                                ;
                                        }
                                        if
                                        (
                                            w
                                            ==
                                            4


                                        1
                                        .192e+01;


                                        f(
                                            = 
                                            =3
                                            )
                                            =
                                        -
                                            .
                                        225e+01;

                                        (
                                            w
                                                =
                                                2
                                        )


                                        1
                                        2
                                        76e+01;

                                        w
                                            =
                                            1
                                            )


                                        -
                                            .
                                        1
                                        7e+01;

                                        w <
                                            = 
                                            )


                                        1
                                        3
                                        6
                                        e + 01;

                                        t
                                            =
                                            r
                                            ;


                                        n
                                    }


                                    /*************************************************************************
                                    Tail(S, 21)
                                    *************************************************************************/
                                    private static double w21(double s,
                                        alglib.xparams _params)


                                    doubl e res
                                        ul


                                    d
                                        w =
                                            (n
                                             * s) +
                                            55
                                    00
                                    e +


                                    {
                                        =
                                    }


                                    e
                                }
                                )


                                r =
                                    -7

                                if
                                (
                                    ==
                                    = -7. 779e-
                                01
                                f(w
                                11
                                    )

                                8
                                0
                                7
                                e - 01;


                                0 )


                                1
                            }
                            i

                            {
                                r
                            }

                            0
                            {
                                1


                                if
                                (
                                    r
                                    = 


                                if (w == 106
                                   )
                                    r
                                9.
                                68
                                e -
                                    =
                                    1
                                05 )


                                .00 3
                                0;
                                    )


                                {
                                    ;


                                    {
                                        1
                                            =
                                            r 0


                                        if


                                        r = -1.
                                        15

                                        w
                                            ==
                                            00
                                        r
                                            =
                                            -
                                                1.189 e + 00;


                                        w == 9


                                        9
                                            +
                                            0
                                            ;
                                    }

                                    =
                                    {
                                        .


                                        if
                                            =


                                        if (w == 95
                                           )
                                            r
                                        1.
                                        39
                                        e +
                                            =
                                            9
                                        4 )


                                        441 e
                                            ;


                                        {
                                        }
                                        i


                                        3
                                    }


                                    r =
                                        -
                                            i
                                    f
                                    w
                                        r
                                            = -1. 6
                                    2
                                    8e
                                        + 0
                                    i f
                                    ( == 9
                                        .
                                    7
                                    7e+00;


                                    8 )


                                    e + 0;
                                }
                                {
                                }

                                86


                                83
                            }
                            i f(


                            if (w == 8
                            4) {
                                = -
                                    1. 39
                                f(w = 83)
                                    -
                                    19 94 + 0 0
                                8


                                {
                                    +0
                                    0


                                    2.
                                        ==


                                    0;
                                }


                                {
                                    r = -2.227e+00;
                                }
                                if (w == 78)
                                {
                                    r = -2.288e+00;
                                }

                                if (w == 77)
                                {
                                    r = -2.350e+00;
                                }


                                if (
                                    ==7
                                6
                                    )


                                r =
                                    -2.414e
                                    + 00;

                                if (w =
                                    7
                                   )
                                {
                                    2.478e
                                    0
                                        ;


                                    {
                                        r
                                            =
                                            -
                                                2.544e+00;


                                        f(
                                            r = -
                                                2.i
                                                (
                                                    r = -2
                                        .6


                                        if
                                        w
                                            r = -2.
                                        74


                                        if (
                                            w =
                                            r = -2.8
                                        19


                                        i
                                        f(
                                            ==
                                            r = -2.89
                                        1e


                                        if
                                            (w
                                             = 6

                                        r
                                            = -2.964
                                        e +
                                            i
                                        f(
                                            w =
                                                67
                                                    = -3.039e
                                                      + 0

                                        f
                                        (
                                            w ==
                                            6
                                        r
                                            =
                                            -3.115e+
                                        00
                                        i
                                        (
                                            w
                                            == 6
                                        ) {
                                            -3.192e+0
                                            0;
                                        }
                                        i
                                        f
                                            w =
                                                =64
                                            )
                                        {
                                            r
                                                =
                                                -
                                                    3.270e+00
                                                ;
                                        }
                                        if
                                        (
                                            w
                                            ==
                                            63


                                        3
                                        .350e+00;


                                        f(
                                            = 
                                            =6
                                        2 )
                                            =
                                        -
                                            .
                                        432e+00;

                                        (
                                            w
                                                =
                                                61
                                        )


                                        3
                                        5
                                        15e+00;

                                        w
                                            =
                                            6
                                        0
                                            )

                                        -
                                            .
                                        9
                                        9e+00;

                                        w = 
                                            =
                                        9
                                            )


                                        3
                                        6
                                        5
                                        e + 00;
                                            ==
                                        5
                                            )
                                            .
                                        7
                                        e
                                            + 00;
                                            =5
                                        7
                                            )
                                            .
                                        6
                                        e
                                            + 00;
                                            =5
                                        6
                                            )
                                            .
                                        5
                                        e
                                            + 00;
                                            =5
                                        5
                                            )
                                            .
                                        4
                                        e
                                            + 00;
                                            =5
                                        4
                                            )
                                            .
                                        3
                                        e
                                            + 00;
                                            =5
                                        3
                                            )
                                            .
                                        3
                                        e
                                            + 00;
                                            =5
                                        2
                                            )
                                            .
                                        3
                                        e
                                            + 00;
                                            =5
                                        1
                                            )
                                            .
                                        2
                                        e
                                            + 00;
                                            =5
                                        0
                                            )
                                            .
                                        3
                                        e
                                            + 00;
                                            =4
                                        9
                                            )
                                            .
                                        3
                                        e
                                            + 00;
                                            =4
                                        8
                                            )
                                            .
                                        3
                                        e
                                            + 00;
                                            =4
                                        7
                                            )
                                            .
                                        4
                                        e
                                            + 00;
                                            =4
                                        6
                                            )
                                            .
                                        5
                                        e
                                            + 00;
                                            =4
                                        5
                                            )
                                            .
                                        6
                                        e
                                            + 00;
                                            =4
                                        4
                                            )
                                            .
                                        7
                                        e
                                            + 00;
                                            =4
                                        3
                                            )
                                            .
                                        8
                                        e
                                            + 00;
                                            =4
                                        2
                                            )
                                            .
                                        0
                                        e
                                            + 00;
                                            =4
                                        1
                                            )
                                            .
                                        2
                                        e
                                            + 00;
                                            =4
                                        0
                                            )
                                            .
                                        4
                                        e
                                            + 00;
                                            =3
                                        9
                                            )
                                            .
                                        6
                                        e
                                            + 00;
                                            =3
                                        8
                                            )
                                            .
                                        8
                                        e
                                            + 00;
                                            =3
                                        7
                                            )
                                            .
                                        1
                                        e
                                            + 00;
                                            =3
                                        6
                                            )
                                            .
                                        4
                                        e
                                            + 00;
                                            =3
                                        5
                                            )
                                            .
                                        7
                                        e
                                            + 00;
                                            =3
                                        4
                                            )
                                            .
                                        1
                                        e
                                            + 00;
                                            =3
                                        3
                                            )
                                            .
                                        5
                                        e
                                            + 00;
                                            =3
                                        2
                                            )
                                            .
                                        9
                                        e
                                            + 00;
                                            =3
                                        1
                                            )
                                            .
                                        3
                                        e
                                            + 00;
                                            =3
                                        0
                                            )
                                            .
                                        8
                                        e
                                            + 00;
                                            =2
                                        9
                                            )
                                            .
                                        3
                                        e
                                            + 00;
                                            =2
                                        8
                                            )
                                            .
                                        8
                                        e
                                            + 00;
                                            =2
                                        7
                                            )
                                            .
                                        3
                                        e
                                            + 00;
                                            =2
                                        6
                                            )
                                            .
                                        9
                                        e
                                            + 00;
                                            =2
                                        5
                                            )
                                            .
                                        6
                                        e
                                            + 00;
                                            =2
                                        4
                                            )
                                            .
                                        2
                                        e
                                            + 00;
                                            =2
                                        3
                                            )
                                            .
                                        9
                                        e
                                            + 00;
                                            =2
                                        2
                                            )
                                            .
                                        7
                                        e
                                            + 00;
                                            =2
                                        1
                                            )
                                            .
                                        5
                                        e
                                            + 00;
                                            =2
                                        0
                                            )
                                            .
                                        4
                                        e
                                            + 00;
                                            =1
                                        9
                                            )
                                            .
                                        2
                                        e
                                            + 00;
                                            =1
                                        8
                                            )
                                            .
                                        2
                                        e
                                            + 00;
                                            =1
                                        7
                                            )
                                            .
                                        2
                                        e
                                            + 00;
                                            =1
                                        6
                                            )
                                            .
                                        2
                                        e
                                            + 00;
                                            =1
                                        5
                                            )
                                            .
                                        3
                                        e
                                            + 00;
                                            =1
                                        4
                                            )
                                            .
                                        5
                                        e
                                            + 00;
                                            =1
                                        3
                                            )
                                            .
                                        0
                                        e
                                            + 01;
                                            =1
                                        2
                                            )
                                            .
                                        3
                                        e
                                            + 01;
                                            =1
                                        1
                                            )
                                            .
                                        5
                                        e
                                            + 01;
                                            =1
                                        0
                                            )
                                            .
                                        7
                                        e
                                            + 01;
                                            =9


                                        1
                                        6
                                            +
                                            01;

                                        8
                                            )


                                        3
                                        e
                                        0
                                        1;
                                            )


                                        1
                                            +
                                            1
                                            ;
                                            )


                                        e
                                        0
                                            ;


                                        +
                                            1


                                        0
                                            ;


                                        {
                                            1
                                        }
                                        i


                                        {
                                            ;
                                        }
                                        if
                                    }

                                    f(


                                    {
                                    }

                                    su
                                        r
                                    tu
                                }


                                /*************************************************************************
                                Tail(S, 22)
                                *************************************************************************/
                                private static double w22(double s,
                                    alglib.xparams _params)

                                ul
                                    t
                                        =
                                        0
                                    ;

                                0;
                                b
                                e
                                    r
                                        = ;


                                (
                                    i
                                t
                                    )M
                                    at h.o
                                01 )


                                if
                                (
                                    r


                                i( == 1
                                25

                                {
                                    r
                                        =
                                        -7. 8
                                    f
                                        = 
                                        =
                                    12 )


                                    -7
                                        .
                                    5
                                    2e
                                        - 0 1;
                                    3
                                        )


                                    {
                                        01
                                            ;


                                        i


                                        .9
                                    }

                                    12 {
                                        ;
                                    }


                                    r = -
                                        8.
                                    5


                                    i
                                    f(w =
                                        r
                                            =
                                            -8 87 e - 0
                                    1;


                                    (
                                        w
                                            =
                                            11
                                    8 )
                                        .
                                    7
                                    e
                                        -
                                        01
                                        )


                                    ;
                                }


                                w = 


                                {
                                    -9
                                }


                                00


                                if (
                                    w
                                    =
                                    r


                                i
                                    f
                                ( == 13
                                    )


                                r
                                    - 1
                                .0 80 +
                            }
                            w
                                =
                                1
                            2
                                )


                            11
                            5
                                +
                                00
                                ;


                            {
                                =


                                (


                                {
                                    7e
                                }


                                )


                                r
                                    =
                                    f


                                r = 1. 2
                                62
                                e
                                    f
                                (
                                    w =  =1 7


                                1
                                    .
                                30 e + 0;
                                    ==
                                1
                                6
                                    )


                                0
                                    +
                                    0
                                    ;


                                i


                                {
                                    r


                                    10

                                    {
                                        42


                                        i


                                        if w = 
                                            =1
                                        0


                                        r
                                            = - .

                                        f

                                        w
                                            == 01 )
                                            =
                                        -
                                            .
                                        55
                                        0
                                            =
                                            0
                                            )


                                        4e
                                            +
                                            0
                                            ;


                                        {
                                            -
                                                    w
                                                + 0


                                            r


                                            i
                                                r = -1.7 1
                                        }
                                        i
                                        f
                                            w =
                                                =
                                        5

                                        1
                                        8
                                        30e+00;

                                        94
                                            +
                                            0


                                        f(


                                        {
                                            =
                                        }


                                        ) {
                                            if (w ==
                                                9
                                            {
                                                r =
                                                    -
                                                    .
                                                0
                                            }


                                            if (w == 8)
                                            {
                                                r = -2.142e+00;
                                            }

                                            if (w == 88)
                                            {
                                                r = -2.198e+00;
                                            }

                                            if (w == 87)
                                            {
                                                r
                                                    - 2.25
                                                e + 00;
                                            }

                                            f(w ==
                                              8
                                            6 )


                                            {
                                                2.312e
                                                00;


                                                i
                                                (
                                                    w
                                                {
                                                    =
                                                    -
                                                        .
                                                    37
                                                }


                                                i
                                                f(w == 84)


                                                {
                                                    =
                                                    -
                                                        .
                                                    42
                                                    9e+
                                                    0;
                                                }
                                                =
                                                8
                                                3 )

                                                -
                                                    2
                                                4
                                                90
                                                e + 0
                                                    ;
                                            }
                                            w
                                                =
                                                2
                                                )

                                            -2
                                                .
                                            5
                                            1e
                                                + 00
                                                =
                                                8
                                                )

                                            2.
                                            6
                                            4
                                            e +
                                                00;
                                                =
                                            0
                                                )


                                            .6
                                            7
                                            e
                                                + 0
                                            0;

                                            7


                                            74
                                            2
                                                +
                                                00
                                                ;

                                            8
                                                )


                                            08
                                            e
                                            0
                                            0;


                                            {
                                                5e
                                                    +
                                                    0
                                                    ;
                                                    )


                                                {
                                                    e +
                                                        0
                                                        ;


                                                    {
                                                        +0
                                                        0


                                                        {
                                                            00
                                                                ;


                                                            {
                                                                r 0;


                                                                {
                                                                    r;


                                                                    {
                                                                        =


                                                                        {
                                                                            =
                                                                        }
                                                                        i


                                                                        {
                                                                            -
                                                                        }
                                                                        if


                                                                        {
                                                                            -3


                                                                            f(


                                                                            {
                                                                                3.
                                                                            }
                                                                            (

                                                                            {
                                                                                .6
                                                                            }

                                                                            w


                                                                            76
                                                                        }

                                                                        w = 
                                                                        {
                                                                            51
                                                                        }


                                                                        ==


                                                                        5e
                                                                    }


                                                                    =6 {
                                                                        e +
                                                                    }


                                                                    61
                                                                        + 0


                                                                    0


                                                                    00
                                                                }


                                                                )


                                                                r 0;
                                                            }


                                                            )


                                                            r;
                                                        }


                                                        r
                                                            =
                                                            r
                                                                =
                                                                r
                                                                    =
                                                                    r
                                                                        =
                                                                        r
                                                                            =
                                                                            r
                                                                                =
                                                                                r
                                                                                    =
                                                                                    r
                                                                                        =
                                                                                        r
                                                                                            =
                                                                                            r
                                                                                                =
                                                                                                r
                                                                                                    =
                                                                                                    r
                                                                                                        =
                                                                                                        r
                                                                                                            =
                                                                                                            r
                                                                                                                =
                                                                                                                r
                                                                                                                    =
                                                                                                                    r
                                                                                                                        =
                                                                                                                        r
                                                                                                                            =
                                                                                                                            r
                                                                                                                                =
                                                                                                                                r
                                                                                                                                    =
                                                                                                                                    r
                                                                                                                                        =
                                                                                                                                        r
                                                                                                                                            =
                                                                                                                                            r
                                                                                                                                                =
                                                                                                                                                r
                                                                                                                                                    =
                                                                                                                                                    r
                                                                                                                                                        =
                                                                                                                                                        r
                                                                                                                                                            =
                                                                                                                                                            r
                                                                                                                                                                =
                                                                                                                                                                r
                                                                                                                                                                    =
                                                                                                                                                                    r
                                                                                                                                                                        =
                                                                                                                                                                        r
                                                                                                                                                                            =
                                                                                                                                                                            r
                                                                                                                                                                                =
                                                                                                                                                                                r
                                                                                                                                                                                    =
                                                                                                                                                                                    r
                                                                                                                                                                                        =
                                                                                                                                                                                        r
                                                                                                                                                                                            =
                                                                                                                                                                                            r
                                                                                                                                                                                                =
                                                                                                                                                                                                r
                                                                                                                                                                                                    =
                                                                                                                                                                                                    r
                                                                                                                                                                                                        =
                                                                                                                                                                                                        r
                                                                                                                                                                                                            =
                                                                                                                                                                                                            r
                                                                                                                                                                                                                =
                                                                                                                                                                                                                r
                                                                                                                                                                                                                    =
                                                                                                                                                                                                                    r
                                                                                                                                                                                                                        =
                                                                                                                                                                                                                        r
                                                                                                                                                                                                                            =
                                                                                                                                                                                                                            r
                                                                                                                                                                                                                                =
                                                                                                                                                                                                                                r
                                                                                                                                                                                                                                    =
                                                                                                                                                                                                                                    r
                                                                                                                                                                                                                                        =
                                                                                                                                                                                                                                        r
                                                                                                                                                                                                                                            =
                                                                                                                                                                                                                                            r
                                                                                                                                                                                                                                                =
                                                                                                                                                                                                                                                r
                                                                                                                                                                                                                                                    =
                                                                                                                                                                                                                                                    r
                                                                                                                                                                                                                                                        =
                                                                                                                                                                                                                                                        r
                                                                                                                                                                                                                                                            =
                                                                                                                                                                                                                                                            r =
                                                                                                                                                                                                                                                                -
                                                                                                                                                                                                                                                                    i


                                                        r =
                                                            -1


                                                        if


                                                        r = -
                                                            1.f(
                                                                r = -1
                                                        .2


                                                        i
                                                        (
                                                            r = -1.
                                                        33


                                                        if
                                                        w
                                                            r = -1.3
                                                        64


                                                        i
                                                        f(
                                                            w =
                                                                r = -1.41
                                                        5e


                                                        if
                                                        (
                                                            ==

                                                        r
                                                            = -1.456
                                                        e +
                                                            i
                                                        f(
                                                            w
                                                                = 0
                                                                    = -1.525e
                                                                      + 0

                                                        e
                                                        su
                                                            lt
                                                                = 
                                                    }


                                                    /*************************************************************************
                                                    Tail(S, 23)
                                                    *************************************************************************/
                                                    private static double w23(double s,
                                                        alglib.xparams _params)
                                                    {
                                                        ul = 0;
                                                        0
                                                        le
                                                            =
                                                            0;


                                                        (n
                                                            )
                                                            Math.Roun
                                                        d(0
                                                            ;


                                                        r =
                                                            -
                                                                i
                                                        f(
                                                                w = 
                                                            = -7.051e
                                                              - 0
                                                              (
                                                                  w
                                                                      =
                                                                      13
                                                        6
                                                            - 7 2
                                                        5
                                                        e - 01;
                                                            )


                                                        01
                                                    }


                                                    {
                                                    }

                                                    1


                                                    0
                                                }


                                                i
                                                f(
                                                    = 


                                                if (w == 13
                                                1
                                                r
                                                    - 8
                                                .6
                                                1e
                                                        ( =
                                                    1
                                                30 )


                                                88
                                                0
                                                    -
                                                    01
                                                    ;
                                                    )


                                                {
                                                    {
                                                        -
                                                    }


                                                    =


                                                    0


                                                    i
                                                        r = -1
                                                    .0


                                                    f
                                                    (
                                                        w =
                                                            12
                                                    r =
                                                        -
                                                            1.037e+00
                                                        ;
                                                }
                                                ==
                                                1
                                                4
                                                    )


                                                06 e
                                                0
                                                0;
                                            }

                                            (


                                            {
                                                =
                                            }


                                            e


                                            if (
                                                w =
                                                r
                                                    =
                                                    -1
                                            i
                                                (
                                                    w == 119)
                                                =
                                                -
                                                .
                                            23
                                            7e
                                            00
                                                == 1
                                                )


                                            e +
                                                0
                                                ;


                                            {
                                            }
                                            i


                                            3
                                        }


                                        1


                                        r
                                            =
                                            i
                                            (
                                                r = -1.42
                                        3e
                                        if
                                            (
                                                w
                                                ==
                                                11
                                            )
                                            = 1
                                        4
                                        62e+00;


                                        12


                                        e + 0
                                    }

                                    =
                                    {
                                        1


                                        i
                                            r 0


                                        if (w ==
                                            10
                                            =
                                            -1
                                        67
                                        if
                                            =
                                            =107 )


                                        1.
                                        7
                                        4
                                        e +
                                            00


                                        06 )


                                        0;


                                        {
                                            =
                                        }


                                        {
                                            e
                                                r =
                                                    -
                                                        i
                                            f
                                            w
                                                r
                                                    = -1.944
                                            e +
                                                f(
                                                = 
                                                =1
                                            0
                                                )
                                                =
                                            -. 9
                                            93e+00;


                                            00


                                            2
                                                +
                                                0;


                                            {
                                            }

                                            w
                                                -
                                                0


                                            if (w = 
                                                =9
                                                =
                                                -
                                                    .2

                                            f

                                            w == 95 )


                                            -2.e +
                                                0
                                                ;
                                        }
                                        =9


                                        e + 0
                                        0;


                                        {
                                            =
                                        }

                                        w == 92
                                            )


                                        r = -2.468e+00;
                                    }
                                    if (w == 91)
                                    {
                                        r = -2.525e+00;
                                    }

                                    if (w == 90)
                                    {
                                        r = -2.583e+00;
                                    }


                                    i
                                    f(w ==
                                      9
                                    ) {
                                        r =
                                            -2.642e+00;
                                    }


                                    f
                                        (


                                    {
                                        r =
                                            -
                                            .
                                        0
                                        2 +
                                    }

                                    f
                                        = 
                                        =87
                                        )


                                    {
                                        r = -2.76
                                        3
                                        e +
                                    }


                                    86
                                        + 0


                                    5


                                    00
                                }


                                )


                                r 0;
                            }


                            )


                            r;
                        }


                        r
                            =
                            r
                                =
                                i


                        r =
                            -


                        if


                        r =
                            -3


                        f(
                            r = -
                                3.i
                                (
                                    r = -3
                        .4


                        if
                        w
                            r = -3.
                        49


                        if (
                            w =
                            r = -3.5
                        71


                        i
                        f(
                            ==
                            r = -3.64
                        5e


                        if
                            (w
                             = 7

                        r
                            = -3.721
                        e +
                            i
                        f(
                            w =
                                72
                                    = -3.797e
                                      + 0

                        f
                        (
                            w ==
                            1
                        r
                            =
                            -3.875e+
                        00
                        i
                        (
                            w
                            == 7
                        ) {
                            -3.953e+0
                            0;
                        }
                        i
                        f
                            w =
                                =69
                            )
                        {
                            r
                                =
                                -
                                    4.033e+00
                                ;
                        }
                        if
                        (
                            w
                            ==
                            68


                        4
                        .114e+00;


                        f(
                            = 
                            =6
                        7 )
                            =
                        -
                            .
                        197e+00;

                        (
                            w
                                =
                                66
                        )


                        4
                        2
                        80e+00;

                        w
                            =
                            6
                        5
                            )

                        -
                            .
                        6
                        5e+00;

                        w = 
                            =
                        4
                            )


                        4
                        4
                        1
                        e + 00;
                            ==
                        6
                            )
                            .
                        3
                        e
                            + 00;
                            =6
                        2
                            )


                        6
                        8
                            +
                            00;

                        61


                        1
                        e
                        0
                        0;

                        0
                            )


                        9
                            +
                            0
                            ;
                            )


                        e
                        0
                            ;
                            )


                        +
                            0


                        0
                            ;


                        {
                            0
                        }
                        i


                        {
                            ;
                        }
                        if
                    }

                    f(


                    {
                    }

                    (


                    {
                        r
                    }

                    w


                    {
                        r
                    }

                    w = 


                    {
                        =
                    }

                    ==


                    {
                        =
                    }

                    =4

                    {
                        -
                    }

                    47
                        -
                }

                46
                    -
            }

            45
                -
        }

        44
            -
    }

    43
        -
}

42
    -


}
41
-
}
40
-
}
39
-
}
38
-
}
37
-
}
36
-
}
35
-
}
34
-
}
33
-
}
32
-
}
31
-
}
30
-
}
29
-
}
28
-
}
27
-
}
26
-
}
25
-
}
24
-
}
23
-
}
22
-
}
21
-
}
20
-
}
19
-
}
18
-
}
17
-
}
16
-
}
15
-
}
14
-
}
13
-
}
12
-
}
11
-
}
10
-
}
9
{
    -1
}

) {
    1.
}

)
{
    .3
}


33


64
}
0e
i
e+ }
if
+0
i
f(
01
if
(
r 1;
res
ul re
s
l
t;
}


/*************************************************************************
Tail(S, 24)
*************************************************************************/
private static double w24(double s,
    alglib.xparams _params)


int w


o
n
(
    -(3.50000
0
e
    i
f(
        w
            =
            r
                =
                -
                    6.820e-01
    ;

w = 
    =
4
9
    )


4
e
0
1;


}
=


{
}


if (
    w


r
    i
(
        w == 144)
    =
    8
.2
39
    -
    =
    4
    )


4e
    -
    1
    ;


{
    =


    e
        r


    f
        r = -9.56
    7

    i
    f
        w =
            =1
    8

    9
    8
    49e-01;


    13
    7
        )


    +
        0


    i


    {
    }


    3

    {
        if (w ==
            1


        r
            =
            -
            .
        f
            = 
            =132 )


        -1
            .
        6
        6e
            + 0
            ;
        1
            )


        00
            ;


        {
            1
        }

        {
            0
        }


        r =
            -
                i
        f(
            w

        r
            =
            -1.334e+
        0
        (
            w
                =
                12
        6
            .
        6
        e
            + 00;
            )


        ;
    }


    {
    }


    )


    if
    (
        i
    f(w == 121


    r
        - 1
    .5
    5
    w
        =
        2
    0 )


    59
    4
        +
        00
        ;


    {
        r


        {
            7
        }


        r = -1.
        7


        f
        (
            w =
                1


        1
        .800e+00;
            ==
        1
        4
            )


        4
            +
            0
            ;
    }


    =


    {
        e


        if (
            w


        r
            =
            f
            (w == 109
            )

        r
            =
            -
                2.
        0
        0e
        w
            =
            0
        8 )


        11
        8
            +
            00
            ;
            )


        {
            ;


            {
                -
            }
            (
            {
            }


            4


            r =
                -
                    i
                    (
                        r
                            = -2.367
            e +
                i f
            (
                w
                ==
                1
            2

            2
            4
            19e+00;
                =10 1
                )


            e
            0
                ;


            {
                r
                    = -2. 26 e
                    +
            }
            if (w == 99)
            {
                r = -2.580e+00;
            }

            if (w == 98)
            {
                r = -2.636e+00;
            }

            if (w == 97)

            {
                r
                    =
                    -
            }


            if (w == 96 {
                e + 0
                    ;


                i
                        (
                    = 


                {
                    r =
                        -2.8
                    0
                    6e+00
                        ;
                }


                if (
                    w = 


                {
                    =
                }

                ==


                {
                    =
                }

                =9

                {
                    -
                }

                91
                    - 3
            }

            0
            {
                3.
            }

            ) {
                .1
            }


            )
            {
                23


                00
            }


            5e


            i


            e +
        }


        if


        +0


        i
        f(
            00


        if
        (
            r 0;


        if (
            w


        r;


        if (
            w = 
            =


        if (w
            ==
            r
            = 


        if (w = 
            =7


        r
            -


        if (w ==
            77


        r =
            -4


        if (w == 7
        6


        r
            =
            4.


        if (w == 75
           )
        {
            r
                = -
                    .1

            i
            f(w == 74
            )
            {
                r
                    =
                    -4
                22

                f
                        (w == 73)
                    =
                    -4.
                08
                i
                (
                    w == 72)


                r
                    =
                    -
                        4.3
                7e
                f

                w == 71 )

                r
                    - 4
                .46
                e + i
                (
                    w
                    == 70)

                r
                    =
                    -
                        4.
                550
                    + 0 f
                    = 
                    =69 )
                    =

                4
                .6
                33e
                00(
                        w
                            =
                            68)
                    =
                    -
                    .
                71
                8e+
                0;
            }
            =
            6
            7 )

            -
                4
            8
            03
            e + 0
                ;
        }

        w
            =
            6
            )

        -4
            .
        9
        0e
            + 00
            =
            6
            )

        4.
        9
        8
        e +
            00;
            =
        4
            )


        .0
        6
        e
            + 0
        0;

        6


        15
        7
            +
            00
            ;

        2
            )


        49
        e
        0
        0;


        {
            2e
                +
                0
                ;
                )


            {
                e +
                    0
                    ;


                {
                    +0
                    0


                    {
                        00
                            ;


                        {
                            r 0;


                            {
                                r;


                                {
                                    =


                                    {
                                        =
                                    }
                                    i


                                    {
                                        -
                                    }
                                    if


                                    {
                                        -6


                                        f(


                                        {
                                            6.
                                        }
                                        (

                                        {
                                            .4
                                        }

                                        w


                                        56
                                    }

                                    w = 
                                    {
                                        78
                                    }


                                    ==


                                    2e
                                }


                                =4 {
                                    e +
                                }


                                45
                                    + 0


                                4


                                00
                            }


                            )


                            r 0;
                        }


                        )


                        r 0;
                    }


                    )


                    r 0;
                }


                )


                r 0;
            }


            )


            r 0;
        }


        )


        r 0;
    }


    )


    r 0;
}


)


r 0; }
)
r 0; }
)
r 0; }
)
r 0; }
)
r 0; }
)
r 0; }
)
r 0; }
)
r 0; }
)
r 0; }
)
r 0; }
)
r 0; }
)
r 0; }
)
r 1; }
)
r 1; }
)
r 1; }
)
r 1; }
)
r 1; }
)
r 1; }
)
r 1; }
)
r 1; }
)
r 1; }
)
r 1; }
)
r 1; }
)
r 1; }
)
r 1; }
)
r 1; }
)
r 1; }
)
r;
}
r
=
r
=
r =
-
i
r =
-1
if
r = -
1.
f(
r = -1
.5
i
(
r = -1.
55
if
w
r = -1.5
94
i
f(
w<
r = -1.66
4e
re
su
t;
}


/*************************************************************************
Tail(S, 25)
*************************************************************************/
private static double w25(double s,
    alglib.xparams _params)


0;
    =
e
    t
        = 0;


r
es
    ul
        =
        0
0
0
000e+00)/
4

t
    j
        =
        1
    ;


b
x
    - 5.150509
e + r
    ,
_
    a
ra
    ms
    ;
w
    ,
r
f
    tj,  ref
    tj t


w
    ch
b(e

e
    result, _
pa
61
1
0
6e
    - 0
    , t
    m
    )
    .
    ,
r
    f
t
    j1
r p
c
e
(
    x, -2.579
89 j
    ul
t
    _p
ar
ms
    -
    2
    ref tj, r
    ef s
    ch 5
j
    ,
r
ef result, 
-2
    .
5
48
81
    - 0 e
    a
a
    s
    );


tj
    ,
r
    ef
t
1,

c
    e
b(x, -8.4
37
es
u
    t,
    _p
ra


}


/*************************************************************************
Tail(S, 26)
*************************************************************************/
private static double w26(double s,
    alglib.xparams _params)
{
    s
        o
    ub
        le
    x
        doub
    le
    0
        ;
        .
        )
    4
    0
    00000e+00
        - 1


    j1
    2
    e
    0
    0, ref tj
        ,


    6
    f
        t
    1
        , ref res
    ul
        x, 

    1
    .3
    95
    67 ,

    p
        r
    ams);

    (
        re
    f
    t
        j,
        r
    f u


    wcheb(x,
        -6
    ef
        e
    su
        lt
    _
    6
    1
    2
    e - 02, ref
    t r
        );


    -
        e

    tj1, ref
    re s
    eb
    (
        ,
        -
            1.
    16
    l
        ,
    _
        params);

    h
    3,

    e
        f
    tj
        r r


    wcheb(
        x, 4
    r
        e

    re
    su
        t,
        .
    3
    3
    69e-04, r
        ef,
        ms
        )


    result;
}


/*************************************************************************
Tail(S, 27)
*************************************************************************/
private static double w27(double s,
    alglib.xparams _params)


double
    re
        =
        0


t
    u
l
    tj1 = 0;


e
    x
        =
        M
th 0
0
    -
    ,
1.0);


=

;


x
    t,
    r
ef tj1, r
ef r
wc
    h
b
(x
    ,
    5.r
e
u
    t, _params
    );
e +
    0
    ,
r
    ef
tj e


wch
    eb 6
tj
1

re
    f
es )
    ,
-
    .
753344e-0
2,
pa
    r
m
    s)
;
h
    r
f
t
    j,  ref tj 
1,


w
    ch
e
(x -
 r f
r
    esult, _p
ar
19
1
8
e -
    0
    , t
    as )
    .
    ,
r
    f
t
    j, _

ch b
(x, 3.033
76 j
    ul
t
    _p
a
    am
1
    - 4 ,
    ref tj,
re e
    r;
}


/*************************************************************************
Tail(S, 28)
*************************************************************************/
private static double w28(double s,
    alglib.xparams _params)


doub le res
    ul
0;


b
    e
t
    j1 = 0;


u
    x
a
h
    .M 0000e+
0)/4.0
0
1);
tj = 1;
tj1 = x;
wcheb(x, -5.065046e+00, ref tj, ref tj1, ref result, _params);
wcheb(x, -5.539163e+00, ref tj, ref tj1, ref result, _params);

wch
b(x, -
    .32
8
939e+0
    ,
r j1, re
f
    result
_param
    s
2
    .
    , ref
j
    , ul ,
r
    m
s
06 151 5e- ,
r
    e
f es lt, _para
m
    s) ;
ch eb x,  -1 .6 f t
    tj,
    result,
    _ p
    a
ra
    m
    );


x - 5 71 157 8e- 3, ef re ul,
    _
aras );


4, re
t
    j,
    r
ef tj1,
    r,
    rams);


e - 0 3, re f t j, e
tj
    ,
r
    f r
    s pa a
wcheb
(
    x
    ,
    4
        .
0e e tj r f tj1 ref
result
    ,
_ps;


wche b(x, -5
    .
285
5er re f, r ef es
u
    l

ret
    rn

es ul
    ;


}


/*************************************************************************
Tail(S, 29)
*************************************************************************/
private static double w29(double s,
    alglib.xparams _params)

l = 0;
double x = 0;
double tj = 0;
double tj1 = 0;

result = 0;
x = Math.Min(2 * (s - 0.000000e+00) / 4.000000e+00 - 1, 1.0);
tj = 1;


j1 = x


w 43413e
    +
    00, ref
tj, ref
tj1, ref r
    );


99 756 e + 0 ,
r
    f

rams) ;


21 3
f
    t
1, r
    es lt _ ar ams);


w
f
    j,
    ar ms;


wch
b(x
    ,
    -4.ef re
s
u
    l,
    _ps;


wche b(x
    ,
    -1.2600
6
4r
r
    j1, r ef esult,
    par
ms
    )
wch
    e
b
    - 03,
r, j1, r f r
    es lt
    par
a
    s);

x, -5
    .
4
71 3
0e-04, ref t
    j
f
    lt, _ par s);


b(, 1. 1
1
16
6
e - 03 r
    e
tj
    re
f
    te l
    t


w
    c
e
3
    - 04
    ,
reft j,  ref
    j1 , refl ram s)

wcheb
(
    , -
        0e 04 r ef tj,
    rf sula


r urn
res
u
    t;

}


/*************************************************************************
Tail(S, 30)
*************************************************************************/
private static double w30(double s,
    alglib.xparams _params)


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
    x
        =
        0
    ;


d
    o
u
    b
l
    e

t
    j
        = 0;

ouble
    j1 = 0


x
Math.M
    i
4.00000 e + 00 - 1
    .
0
j = 
    = x;


b(x

5
.4 t
su t, _p ra
    m
s);


w he(x
-.46
4
5
    ,
e
    u
_
    w
cx - .2 83 42
    + 00
    ,
re f
    j,  ref
    j1 , e _pa ra s) ;


wcheb
(
    , 8 00 0e 01,
    ref tj, r
e
    s
    );
w
    c
eb(
    , -
        4
04
f tj 1,

r
e
    result, m
w c
(x, -
    1
076162e
    - r f j, re f tj1,  ref
    r
    sul,
    _
ara
    w he b
(x, , rj, ef tj 1
    ,
    ref
res u
    l, _
arams)
;
(x, -1. 1
1
6
9
e - 04, ref ref es ult,
    _
ara ms);


-8 .6 91 8
5e - 0 ,
    ref
tj
    ,
    ref
t ul
t
    w
h
    e
b. 32 e - 4, re f j
re
    tj1,
    r
f
    ams);


wche
b
    x, 
3.0 04,
tj, r f t
    j
1
ms;


ret
    rn
r
    sul
    ;
}


/*************************************************************************
Tail(S, 40)
*************************************************************************/
private static double w40(double s,
    alglib.xparams _params)


doubl
    result

le x =
        0;
    =

uble t
1


r
    e
x a
h
n(*(s
    - 0.
0
0
0
0
0
0
e + 00)/4.000 0
0
e
    + 00 - 11
    ;


x;


x, -4
    .
9
0
8
09e+00, ref
t
    , r
    f
t
1,
ef
r
    sul, _par
a
    s);


x, -5
    .
2
4
3
27e+00, ref
t
    , r
    f
t
1,
ef
r
    sul, _par
a
    s);


, -1 1
3
6
6
8e 00, re f tj, r f j1,
    re
f
res
    lt,
    par am );
w c - 1.170982e - e r
    f t
    r f
res
    lt, _p
aa ms;
cheb(x, -1
.8 44 2, e
    tj, r
e
    tj1, re f
    r, s);


wcheb
(
    , -
        .4 e - 0
3
f tj,
    r
f t j1, r ef r
e


wcheb(x,
    -
        .34
92
9
    - 03
re
f
    tj, 
ref tj 
1 re res
u
    l
c
    h
b(x 2. 79 04 7e - 0
    , r
e
    e j 1, r
    e
f
    wc
h
b(x
  - 4.
198 e - 0 ,r ef t, ef t
    j, refs, _par am s) ;
wch
    e
(x
3
    .
591
1e-
0
    , re tj, re f j1,  ref
    r
    w heb(, -2.
8
302
e -
    0
    , rf
    j,
    ef t j1,
    _par ms
    elt;
}


/*************************************************************************
Tail(S, 60)
*************************************************************************/
private static double w60(double s,
    alglib.xparams _params)
{
    ouble
        e
    u
        t
            =  do
        bl
            = dou
    le
        j
            = 
        ;
    doubl
        j
    1

    re
    s
        ult
            =
            0
        ;


    x
        = Math.Min(2
                   *
                   (
                       s
    0.0
    0
    00 00
    0
        +
        0


    tj1
        = 
        ;

    w
        c
    eb(x -
       4
    8096 6e+
    0
        , r
        ft f
        params);


    .077
    1
    9
    esu );


    wcheb
    (
        , -1.02
    9
    4
    fe u
    _ a


    7931 -
        0
    2, r f
        t, f
    esu lt, _p ra s);


    -6.5
    0
    62 26 -
        03, ref t j, re
    f
        tj1
    r
        e rs lt,
        _pa
    ams);


    w c,  1278 e - 0, r
        ef
    j 1,
    ef

    esu
        t,
        _
    ara
        s) ;


    w h
    e
    b
        -
        0
        ,
    r ef t j, r ef tj
    1
    re
        r e s


    w
        c
    e
        -
        0
    4
        ref tj , r ef t
        j
    1,

    ef r ult _pa ra s);


    04 , e e t
        j1, r f res
    u
        t,
        am
    s
        ;


    wcheb
    (
        x
        , ref tj
    e1 ref
    r
        sul,
        _
    ams
        ;


    w
        c
    eb(x, -
            1
                .
        ref tj, ref tj ,
    ef result, params);
    return result;
}


/*************************************************************************
Tail(S, 120)
*************************************************************************/
private static double w120(double s,
    alglib.xparams _params)

t = 0;


bl e
    tj = 0;


d
    u
b
    e
u
    x = Ma
h
    M
i
e
    / 4.0
0
00 00 , 1.0);


t


4
    .
7
e + 00, ref tj,

ef
jr sult,
    _param s) ;


-4.93
4
4
2
e
    + 00, re ft,
    fl as;
x, -9.
4
3
3
3
1e-01, re
    tj, r f t

r
    f r
    t,
    par
ms);


92504e - 0 ,
r
ef tj,  ref t
    j1 re
    r
e
    ul ta
    x,  1 67
39 8
    - 0 5, ree
    ef
r
    lt,
    rams);


-6. 7
7
0
4e - 0 , ref tj ,
r
e
    tj,
    r
f r
sul
    t
_pr am );
b 768e-0 5
    ,

e
f tj,  ref tj 
1
re
    r
e
    ult
_pa ra s);

w heb(x
    , 9e 0
5
    ,
r
ef tj, re t j
1
    ,
r
    f r
su
    l, _
ara
    m
    );


cheb(
    x
    ,
    e
f tj, re f tj1, ef r sul t, _par ms)
;


8e 05 , r
    e
f
    j,  ref tj1 ,
    ef
esu , _ ram
    s;

w
    c
e - 05, r f

ref tj1 , re
f
su
    l, _
ar am s


}


/*************************************************************************
Tail(S, 200)
*************************************************************************/
private static double w200(double s,
    alglib.xparams _params)
{
    0;

    x
        ;


    do
        bl
    ru
        x
            = M th M
    i
    n
    (
        2
        * (s
           -
           0. 00 00 00 e + 00) / 4
        .
    00
    0
    0
    00e+00 - 1 , 1. 0
        );


    w
    0e+00
        ,

    r
        f
    t j, r ef tj 1, ref

    esut , p
    ra s;


    w heb(,
    -4.88 30 0
    e
        +
        tj1,

    r
        e

    re su lt, pa rams);


    w hb(x
    -
        326 8e 01, e
        tj, re
    t
        j

    p
        aram s) ;


    w
        he
    b
        x, 
    3.5
    12 84e - 0 , re t
    j
    f tj1,
        re arams
        )
    ;


    wc
        h
    b(x
    1
        .
    26 4
    e - , re tj, re
    f
        tj1,  ref
        re s);


    wcheb(x
        ,
        -5. 97
    9
    e - 04 ref

    j,
    tj1,
    r
        f resul
        t,
        w ch b
        x,  -1.628659e- 0 r
    f
        t, r f
        tj1, 
    ref
        re s
    cheb(
            x
            , 
        . 26 786e 05, r f
    tj ref t 1,
    r f r
        sul t
        _p
    rams );
    w he b(,
        -
            .002498e-05, r
    f tj re
        f
    tj1
        re
    f
        re su l
    wc e
    b
    (x 3
        .
    14 287e-05,
    r
    ef
        j, r
    f t
    1, r f
    res
        lt, _p
    a
        ams);


    b(x, -.
    72 76 e - 5, r f tj, e
    tj
        ,
    r
        f r
        sul
    t
        _p
    m
        esult
        ;
}


/*************************************************************************
Tail(S,N), S>=0
*************************************************************************/
private static double wsigma(double s,
    int n,
    alglib.xparams _params)
{
    resul
        t
            = 0;


    double f d
    le f1 = ;

    ble f2


    f3 0
        = 0;


    d
        o
    e x

    o
        ble
    x
    2 =
        0;
    double x
    3
        = 0;


    ul


    es ul = 0;


    f(
        == 5
    {
        s, _p ar a

        if (
            n
        {
            t
                w6
            (
                , _
                arams

            if (n =  =7
                )


            {
                r
                    sult =
                        w
                7
            }


            if ( ==8
            {
                = w8(
                    s
                    ,
                    p
                arams);
            }


            if
                =9 )
            {
                re su l, _ pa am );
            }
            i
                f
            n == 10
            re su l
            w10
                s,
                par
            ms );
        }


        {
            r
            e
                ult
                    = w1 1(,
                ams);
            f


            {
                rs ut = w 2


                n =
                    13


                r s, _pa
                ams);


                if (n == 14)
                {
                    result = w14(s, _params);
                }

                if (n == 15)
                {
                    result = w15(s, _params);
                }

                if
                n == 16
                    )


                {
                    sult =
                        w16(s, 
                            params)
                    ;


                    i
                        f


                    w1(s,
                        f( = 
                    {
                        8(
                            ,
                            _
                        p
                        if (n = 9
                           )


                            res ul = w19(
                                s
                                , 
                    }


                    i
                    (n
                        = 2
                    0
                        )


                    {
                        e s
                        u
                            t
                                = w2 0(s, _p arams
                        )
                    }

                    i
                        f
                            = 21


                    esult = w
                    21 s, _
                        ar
                    a
                        s);
                }


                if
                    (


                {
                    esu
                        t
                            =
                            w22
                    s,
                    _
                        am) ;


                    =
                    23 )


                    {
                        eu lt =
                            w2(s, _p ams);


                        if (n == 24)


                        {
                            re ult w24(s,
                                _
                            p
                        }

                        if (n = 25)


                        {
                            r
                            su t = w2(
                                s

                            f(
                                ==
                                2
                                )


                            {
                                ams);


                                i
                                n == 27


                                w
                                2
                                7(
                                    s
                                _p
                                    );
                            }

                            if
                            (
                                result = w28(s, _params);
                        }

                        if (n == 29)
                        {
                            result = w29(s, _params);
                        }

                        if (n == 30)
                        {
                            result =
                                30(s, 
                                    params
                                ;
                        }

                        if (n
                            >
                            30)


                        {
                            .
                            0
                                .s, par
                                f 1 = w
                            4
                            0(s, _params);


                            x2 =
                                1
                                    .
                                /60;


                            1120;

                            3 w
                            1
                            0(s
                            _p
                            a
                                ams
                                ;


                            f4 = 0 ams
                                )


                            f1 = ((
                                x
                                -
                                0) / (
                                x
                            1
                                - 0 );

                            f
                            2
                                = (x - x 0
                            f0 )/(x2
                                  -
                                  x
                            f 3
                                (
                                    x0) * f3 - (x - x3)
                                *
                                0)/
                            x3 - 0;


                            f
                            4
                                = ((x - x0) * f
                                   - x0);

                            2
                                =
                                (
                                    x - x
                                ) *
                                f
                                - (x - x) * f
                            1
                                / (x
                            1);


                            -(x - x
                            3
                                )*f1 /
                                (x3 - x1);


                            ((
                                xx 1) f
                                - (x - x4) * f4

                            f
                            3 = ((x - x2) *
                                 f
                                 - (-3)
                                 *
                                 2) / (3 - x2); = ((
                                        x - x2) * 4 - (x - x4) * f2
                                )
                                (x4 - 2)
                                ;


                            4 = (-x3 * f4 -
                                 (
                                     x - x3);


                            resu
                                l
                                    = f
                                ;


                            t
                        }
                    }

public class mannwhitneyu
{
    /*************************************************************************
    Mann-Whitney U-test

    This test checks hypotheses about whether X  and  Y  are  samples  of  two
    continuous distributions of the same shape  and  same  median  or  whether
    their medians are different.

    The following tests are performed:
        * two-tailed test (null hypothesis - the medians are equal)
        * left-tailed test (null hypothesis - the median of the  first  sample
          is greater than or equal to the median of the second sample)
        * right-tailed test (null hypothesis - the median of the first  sample
          is less than or equal to the median of the second sample).

    Requirements:
        * the samples are independent
        * X and Y are continuous distributions (or discrete distributions well-
          approximating continuous distributions)
        * distributions of X and Y have the  same  shape.  The  only  possible
          difference is their position (i.e. the value of the median)
        * the number of elements in each sample is not less than 5
        * the scale of measurement should be ordinal, interval or ratio  (i.e.
          the test could not be applied to nominal variables).

    The test is non-parametric and doesn't require distributions to be normal.

    Input parameters:
        X   -   sample 1. Array whose index goes from 0 to N-1.
        N   -   size of the sample. N>=5
        Y   -   sample 2. Array whose index goes from 0 to M-1.
        M   -   size of the sample. M>=5

    Output parameters:
        BothTails   -   p-value for two-tailed test.
                        If BothTails is less than the given significance level
                        the null hypothesis is rejected.
        LeftTail    -   p-value for left-tailed test.
                        If LeftTail is less than the given significance level,
                        the null hypothesis is rejected.
        RightTail   -   p-value for right-tailed test.
                        If RightTail is less than the given significance level
                        the null hypothesis is rejected.

    To calculate p-values, special approximation is used. This method lets  us
    calculate p-values with satisfactory  accuracy  in  interval  [0.0001, 1].
    There is no approximation outside the [0.0001, 1] interval. Therefore,  if
    the significance level outlies this interval, the test returns 0.0001.

    Relative precision of approximation of p-value:

    N          M          Max.err.   Rms.err.
    5..10      N..10      1.4e-02    6.0e-04
    5..10      N..100     2.2e-02    5.3e-06
    10..15     N..15      1.0e-02    3.2e-04
    10..15     N..100     1.0e-02    2.2e-05
    15..100    N..100     6.1e-03    2.7e-06

    For N,M>100 accuracy checks weren't put into  practice,  but  taking  into
    account characteristics of asymptotic approximation used, precision should
    not be sharply different from the values for interval [5, 100].

    NOTE: P-value approximation was  optimized  for  0.0001<=p<=0.2500.  Thus,
          P's outside of this interval are enforced to these bounds. Say,  you
          may quite often get P equal to exactly 0.25 or 0.0001.

      -- ALGLIB --
         Copyright 09.04.2007 by Bochkanov Sergey
    *************************************************************************/
    public static void mannwhitneyutest(double[] x,
        int n,
        double[] y,
        int m,
        ref double bothtails,
        ref double lefttail,
        ref double righttail,
        alglib.xparams _params)
    {
        i n
        t
            i
                =
                0


        i
            n
        t
            k
                =
                0
            ;


        d
            o
        ub
            l
        e tm
                =
                0
            ;


        i
        n
        t
            in t
            ns
                =
                0
            ;


        d
            ou
        b
        le
            []
            i
        n
        t
            []
            c =
                n
        ew
            i
        nt
            [
                0
            ]
            ;


        ;

        d
            le mp
        0;

        db =
            ouble sigma = double mu = 0;
        int tiecount = 0;
        int[] tiesize = new int[0];

        bothtails = 0;
        lefttail = 0;
        righttail = 0;


        //
        // Prepare
        //
        if (n <= 4 || m <= 4)
        {
            bothtails = 1.0;
            lefttail = 1.0;
            righttail = 1.0;
            return;
        }

        ns = n + m;
        r = new double[ns - 1 + 1];
        c = new int[ns - 1 + 1];
        for (i = 0; i <= n - 1; i++)
        {
            r[i] = x[i];
            c[i] = 0;
        }

        for (i = 0; i <= m - 1; i++)
        {
            r[n + i] = y[i];
            c[n + i] = 1;
        }

        //
        // sort {R, C}
        //
        if (ns != 1)
        {
            i = 2;
            do
            {
                t = i;
                while (t != 1)
                {
                    k = t / 2;
                    if ((double)(r[k - 1]) >= (double)(r[t - 1]))
                    {
                        t = 1;
                    }
                    else
                    {
                        tmp = r[k - 1];
                        r[k - 1] = r[t - 1];
                        r[t - 1] = tmp;
                        tmpi = c[k - 1];
                        c[k - 1] = c[t - 1];
                        c[t - 1] = tmpi;
                        t = k;
                    }
                }

                i = i + 1;
            } while (i <= ns);

            i = ns - 1;
            do
            {
                tmp = r[i];
                r[i] = r[0];
                r[0] = tmp;
                tmpi = c[i];
                c[i] = c[0];
                c[0] = tmpi;
                t = 1;
                while (t != 0)
                {
                    k = 2 * t;
                    if (k > i)
                    {
                        t = 0;
                    }
                    else
                    {
                        if (k < i)
                        {
                            if ((double)(r[k]) > (double)(r[k - 1]))
                            {
                                k = k + 1;
                            }
                        }

                        if ((double)(r[t - 1]) >= (double)(r[k - 1]))
                        {
                            t = 0;
                        }
                        else
                        {
                            tmp = r[k - 1];
                            r[k - 1] = r[t - 1];
                            r[t - 1] = tmp;
                            tmpi = c[k - 1];
                            c[k - 1] = c[t - 1];
                            c[t - 1] = tmpi;
                            t = k;
                        }
                    }
                }

                i = i - 1;
            } while (i >= 1);
        }

        //
        // compute tied ranks
        //
        i = 0;
        tiecount = 0;
        tiesize = new int[ns - 1 + 1];
        while (i <= ns - 1)
        {
            j = i + 1;
            while (j <= ns - 1)
            {
                if ((double)(r[j]) != (double)(r[i]))
                {
                    break;
                }


                j =
                    j
                    + 1;
                    =i;
                k <
                    =
                    j
                1
                    ;


                r[k] = 1
                       + (1) /
                       double
                2;


                tiesi
                    ze j - i;


                tiecount = t
                           /
                           C
                           /
                           0;
                    =ns
                1;
                i
                    +
                    )
                {
                    if (c
                        [
                            i
                        ]
                        ==


                    {
                        u + r[i]
                    }
                    u = ap
                    er
                        .
                        m
                        ul ams)+a
                    s
                    r
                        .
                        rm _param
                        )*0.5
                    u
                        /
                        / R
                    sult
                        mu = ap
                    e
                    v.r
                        ul2
                    (
                        n
                        , 
                        ,
                        tm.sqr(ns)
                    1
                        /
                        12 for (i = 0
                                    <
                                    = 

                    {
                        tmp = i]*es
                        i
                        e
                            [i
                            ]
                            - 1
                            /
                            12
                            ;
                            = Math.Sq
                            t
                        aps
                            er arams)/n
                            /
                            ns -
                            1) s = (u
                        m
                            )/s
                            ig if ((d
                        ou ub


                        {
                            p

                            Math.
                                E
                                xp
                                (
                                    u
                                        s

                            i
                                g
                            ma g
                                a, n
                            m,

                            _p
                                a
                            r
                                a
                            m
                                s
                                ))


                            m
                                p
                                    =
                                    1
                                    -
                                    M
                            a
                            t
                                .Ex
                            p(1 -,
                                _
                            p
                                r
                            m
                                s
                                )
                                )
                            ;


                            m
                                p
                                    =
                                    M
                            a
                            h
                                .E
                                xp u) a
                                r
                            a
                                m
                            s
                                )
                            ;


                            M
                                a
                            t
                            h
                                .
                                E
                                p
                            u
                            si /
                                leftta bou ax
                            (
                                p,
                                1
                                    .E - 0.ap th 0
                            1

                            0.bo
                            t
                                ta tt
                        }


                        /*************************************************************************
                        Sequential Chebyshev interpolation.
                        *************************************************************************/
                        private static void ucheb(double x,
                                double c,
                                ref double tj,
                                ref double tj1,
                                ref double r,
                                alglib.xparams _params)
                            =

                        0


                        t
                            =
                            2
                            *
                            *
                                j
                        1
                            -
                            t
                        j
                            ;


                        t
                        1
                            = t;
                    }


                    /*************************************************************************
                    Three-point polynomial interpolation.
                    *************************************************************************/
                    private static double uninterpolate(double p1,
                        double p2,
                        double p3,
                        int n,
                        alglib.xparams _params)
                    {
                        r
                            e
                        s
                        u
                            t
                                = 0;


                        ;

                        = 0;


                        d
                            ub t
                            .
                        0 / .0 1.0 / n t2
                            p t2 3)
                        *
                            1
                        2 + (t1 -
                             t
                            )
                            *
                            p
                        2
                        3
                            )
                            /
                        (
                                t1 - t3)
                            ;


                        return result;
                    }


                    /*************************************************************************
                    Tail(0, N1, N2)
                    *************************************************************************/
                    private static double usigma000(int n1,
                        int n2,
                        alglib.xparams _params)

                    ble
                        p
                            =
                            0
                        ;


                    1
                        =
                        u
                    n
                        i
                    n
                        te 0
                    1
                        ,

                    -
                        6
                    8
                    873
                    e - = u
                    i
                        t
                    e
                        r
                    p
                        o
                    l
                    at.
                    9
                    0
                    9
                    5
                    7
                        -
                        1
                        ,

                    n
                    2
                        ,
                    _ r
                    p
                        o
                    l
                        a
                    t
                    (
                        6.89
                    87 1

                    2
                        , = 3,
                }


                /*************************************************************************
                Tail(0.75, N1, N2)
                *************************************************************************/
                private static double usigma075(int n1,
                    int n2,
                    alglib.xparams _params)
                {
                    ou =
                        0


                    d
                        ou
                    b
                    le p2
                            =
                            0
                        ;


                    ;
                    rpola
                        t
                    0
                        ,
                    _a ra m
                        s
                        )
                    i
                    e + 0
                    0
                        ,

                    -
                        1
                    4
                    68 56 e + 0,
                    1
                    .4
                    7
                    s
                        n
                    t
                        e
                    r
                        o
                    at e
                    (
                        -1.470
                    6
                    3
                    e
                        +
                        0
                    0
                        ,

                    -1 47644e+ 0
                        ,

                    res ul
                        t
                            = unint
                    e
                        p
                    l
                        a
                    t
                        e
                    ams);


                    r
                        e
                    t
                    urn result;
                }


                /*************************************************************************
                Tail(1.5, N1, N2)
                *************************************************************************/
                private static double usigma150(int n1,
                    int n2,
                    alglib.xparams _params)

                d
                    ;
                do
                    u
                        b
                l
                    p
                        = 0;


                do
                    uble
                        p
                2


                0
                    ;


                dou l
                erp 80e+0 , -2

                90
                am
                    )


                p2 = un in e
                    r
                olate(-
                    2
                        .
                6
                7
                1e+
                0
                    -
                    2
                        .
                6965
                9
                e + 0
                0
                    ,
                n2 _ ar am
                s) p
                3
                    =
                    er pa 0, 2.7
                1
                2e+
                0
                0, n2,
                _
                    p
                a
                    r
                a
                    ms);


                re s
                ul t
                un nt erp ol 3, );


                r tu n re sul
                    t
                    ;
            }


            /*************************************************************************
            Tail(2.25, N1, N2)
            *************************************************************************/
            private static double usigma225(int n1,
                int n2,
                alglib.xparams _params)
            {
                e

                2 = 0;

                do
                    u
                ble p3
                        =
                        0
                    ;


                p
                    = u ni nt er po la e
                0
                    +
                    0
                    ,
                -4. 43 70 2e + 0 , 2, _par
                    a
                m
                    s
                    )
                ;


                te 0, -4.41
                3
                e + 00,
                -
                        4.41928e
                    +
                    00,
                n
                2, _ pa a
                    ms;


                p3
                    =
                    uninte
                r
                olate(-
                    4
                        .
                928e+00,
                4
                41030e
                    +
                    00, n2,
                _
                    para
                m
                    s);


                resul
                    interp

                o
                    ate(p1,
                        p
                            ms);


                ret
                    u
                rn
                r
                    esult;
            }


            /*************************************************************************
            Tail(3.0, N1, N2)
            *************************************************************************/
            private static double usigma300(int n1,
                int n2,
                alglib.xparams _params)
            {
                t =
                    0;
                    =
                ;


                2 = 0;


                dou
                    bl


                o
                    a
                e
                (
                    -
                        6
                .8
                98 3
                e
                    , -6 82 40 e + 00 , n2 ,_
                    (-.8 4
                7
                e00, -6.745e+00, -6.71117e+00, n2, _params);
                p3 = uninterpolate(-6.82340e+00, -6.71117e+00, -6.64929e+00, n2, _params);
                result = uninterpolate(p1, p2, p3, n1, _params);
                return result;
            }


            /*************************************************************************
            Tail(3.33, N1, N2)
            *************************************************************************/
            private static double usigma333(int n1,
                int n2,
                alglib.xparams _params)
            {
                esult
                0;
                    = 0;


                0;


                0;


                p1 la
                e
                    - 8.
                3
                1272e
                    + 0 +
                    0
                    - 8
                        .
                1
                31 _pa
                    a
                s
                    )
                ;


                p
                2
                    =
                    u
                n
                    in
                t
                    er
                p
                o
                    - 8
                0
                1
                5
                6
                e
                    + 0
                0
                    ,
                -
                    7
                        .
                93
                2
                4
                5
                e
                    + 0
                0
                    ,

                n2
                    ,
                _
                    p
                ar
                3
                    =
                    u
                n
                    in
                te rp la t
                e
                (
                    -8
                .1 31 25 e + 00 , -7 .9 32 45 e +
                    0
                0,
                -7
                s);


                result = ninterpolate(p1, p2, p3, n1, _params);
                return result;
            }


            /*************************************************************************
            Tail(3.66, N1, N2)
            *************************************************************************/
            private static double usigma367(int n1,
                int n2,
                alglib.xparams _params)

            resul
                =
                0
                    = ;
            double
                p
            2
                = 0;


            double p3
                ;


            p
            1
                =
                u
            interpo
                l
            at 00

            9. 08 4e + 0 0, -9. 62 087
            e
                +
                00, n2, _pa
                r
            m
                s);


            p 2 = un in te po at e
            .7 08 44 + 00, -9
                .
            41 28
            9
            e + 00, n2 , _p ar am s)
            p3
                uninterpola
            t
            (
                -9.62087e+0
            .2 8
            98e+00,

            -9 n2, _p
                r
            ms);


            es
            u
                t
                    =
                    un
            i
                terpola

            t
                e(n1, _p
                    rams);


            tn result;
        }


        /*************************************************************************
        Tail(4.0, N1, N2)
        *************************************************************************/
        private static double usigma400(int n1,
            int n2,
            alglib.xparams _params)
        {
            o
                b
            le
                d
            do ub le
                p2 =
                    3 = 0;


            nt
                r
            olate(-1.202 5e, 1 1. 3231e+ 01, 2
                = un i
            rp ol te(-1.1491
            1
            1, -1 .9 0 .0 79 37 e + 1, n2, _p a
            rams);

            =
            uninterpola t
                + 01, -1. 5
            85e+01 , 2, _p ar am s


            ni nt er pol
            te(p1,
                p2, p3, n1_params);
            return result;
        }


        /*************************************************************************
        Tail(S, 5, 5)
        *************************************************************************/
        private static double utbln5n5(double s,
            alglib.xparams _params)
        {
            do ub le
                lt
                ;


            le x = 0;


            ouble tj
            1
                = 0;


            r =
                n(
                    *
                        s - 0.000 00 e + 00)
                /
                2. 61 11 65 e - 1, 1 0) t j
                = 1;


            t j
            1
                =
                h
                - 2.5962
            6
            4
            e + 00, ref t
                j

            ref tj1 , re
            f
            r
                esul, para ms )
            ;

            u ch eb
                (
                    x
                ref tj,
            rf tj1,  ref res
                u
            lt
                ,
            _p
                a
            am
                s
                ;


            42e-01
                ref t j,
                elt,
                _params);
            ucheb(x, -5.614282e-02, ref tj, ref tj1, ref result, _params);
            ucheb(x, 3.372686e-03, ref tj, ref tj1, ref result, _params);
            ucheb(x, 8.524731e-03, ref tj, ref
                tj1, r
            f resu
                t, _param
            s
                );


            (x,
                4.
            43 f tj,
                r
            ef tj1, 
            ref res
                ult, _params uch1 .284665e-03, r
            f
                j,
                r
            e
                f
            ams );


            uc h
                f, 
            ref tj1 ,  ref l

            ucheb(x, 5
                .
            98
            3
            0e-03 , re f tj,
                ul,
                _params);


            uche
            b
                x,  7.4 72 2
            e
                - 0
            4 re f tj,  ref t j1, r ef
            r
                sult, _p
            a
                r
            uce b(,
            -3.93 87 9e-03
                ,
            r ef,  ref r
                e
            t, _params );


            uch eb(
                x
                ,
                tj, re
                    j1, ref r sul

            t
                ,
            _
                a;


            -1. 13 841 e - 03, r
                e
            j ref result, _params);
            ucheb(x, 8.684625e-04, ref tj, ref tj1, ref result, _params);
            ucheb(x, 1.558104e-03, ref tj, ref tj1, ref result, _params);
            return result;
        }


        /*************************************************************************
        Tail(S, 5, 6)
        *************************************************************************/
        private static double utbln5n6(double s,
            alglib.xparams _params)
        {
            d
                o
            ble res
            u
                l
            b
                l
            e x = ;


            double
                j
                    = 0;


            double

            tj
                result = 0
                ;
                = Math.Min(
                2
                (
                    s - 0.000000e
                    +
                    0)
                /
                .738613
            e
                + 0

            tj = 1;


            tj
            1
                =
                x
                - 2.810
            59e+00
                , ref tj, r tj1,  ref result , _params);
            ucheb(x, -2.684429e+00, ref tj, ref tj1, ref result, _params);
            ucheb(x, -5.712858e-01, ref tj, ref tj1, ref result, _params);
            ucheb(x, -8.009324e
            02, re
                tj, r
            f tj1, re
            f
                re
            ul
                t, 

            -6.644
            3
            91e-03,
                ref tj,
            r e
            ms);


            .
            0
                , ref
            j1
                e
            f
                u
            98
                -
                3, ref tj, r f j
            1
                , re f resu l
                t,
                p
            arams);

            uc heb(x, 3
                .
            79
            2
            3e-0 , ef t j
                pa ra s
            uc h 6
            34 5e 03 , re f t
                j, r ef tj 1, r ef re su lt, _
            pa ra m
                uc
            h
                e
            03
            t j, re f tj1, re f re s
            ul t, _params
                )


            u
                ch b
                (0,
                    r
                ref r
            s
                lt, _params);


            uc
                h
            b(x, -1
                .
            54 f tj,
                ef tj1
                , ref resul _params);
            ucheb(x, -3.283205e-03, ref tj, ref tj1, ref result, _params);
            ucheb(x, -3.016347e-03, ref tj, ref tj1, ref result, _params);
            ucheb(x, -1.221626e-03, ref tj, ref
                j1, re
            resul
                , _params
                )
            ;


            x,
            1.
            28 f tj,
                r
            ef tj1, 
            ref res
                u
            re
                urn re lt
        }


        /*************************************************************************
        Tail(S, 5, 7)
        *************************************************************************/
        private static double utbln5n7(double s,
            alglib.xparams _params)

        do bl e
            result = ;

        b
        le x = 0;


        d ub
        l
            e
        do
            be t 1 = 0


        r
        su
            l
                = 
            ;


        h Min(
            *(s - 0.
        000000e+00).841993e+00 - 1, 1.0);
        tj = 1;
        tj1 = x;
        ucheb(x, -2.994677e+00, ref tj, ref tj1, ref result, _params);
        ucheb(x, -2.923264e+00, ref tj, ref tj1, ref result, _param
        );


        ucheb(x,
            -6.
        06
        19 j,
        ef
        t lt, _p
        a
            rams);


        ucheb(x
        r f tj
            ref t
        1

        r
            r uc eb
        (
            j
                r
            ,
            p
                rams);


        ucheb(x,
            1
        7
        26290e-03,
        r
        f
            tj,  ref tj 
        1
        r
        e
            result,
            _

        uh eb(x, 4
            .
        5
        34180e- 03
        r
        f
            tj,  ref tj 
        1
            ref result,

        pa
            r
        ms);


        4 517845e-03, tj, ref tj
        1,

        e
            f res lt, _p
        a
        am
            s
            ;


        8e-03, ref tj
            ,
        r
            ef tj
        1
        r
            e
        r
        e
            ult, _p
        a
            ra u
        heb(x,
            3.882443e-, ref tj, ref tj1, ref result, _params);
        ucheb(x, 3.482988e-03, ref tj, ref tj1, ref result, _params);
        ucheb(x, 2.114875e-03, ref tj, ref tj1, ref result, _params);
        uch
        b(x, -
            .51508
        e - 04, re
        f
            tj, r
        f
        t lt, _p
        a
            rams);


        ucheb(x, 03, re
        j,
        r
            te _
            a
        a
            m
        s
        .29358
        e - 0 3
        e

        t
            esult,
            _
        a
            r

        ch b
        (
            x, -2.349444
        e - 03 , ref tj, re
            f

        t
        1,
        r
        ef ra
            ;


        rn re u
            t
            ;
    }


    /*************************************************************************
    Tail(S, 5, 8)
    *************************************************************************/
    private static double utbln5n8(double s,
        alglib.xparams _params)
    {
        resul
            t
                =
                0;


        do
            bl
        e
            x =
                0;


        d
        uble tj
            =  do
            u
                b
        l
            tj1 = 0;


        res lt
            =
            0;


        x = Ma th.M
        0e+00
            )
            /
        2. 2
        77 00e+00 - 1,
        1
        0);


        t
            j 1;


        tj1
            =
            x uch
            e
        b
        (
            , -3.155727e
              +
              0, r
        t j1 r ef s t,
            _
        p
        b(
            ,
            -3 135
        78e
            +
            0,
        ef tj,
            ef tj1,

        r
            rams)
        ;


        cheb(
            x
            - 7
        24
        7 - j, ef tj1, re
        f
            ;

        ucheb(x, -
            1. 3
        969
        e -
            0
            , r
        f tj,
            re tj , re
            f
        res ul tr;


        ucheb(x, -.99
        72
        5
            - 02
        re
        f
            tj,
            re f j
        1
            ref re
            s
        u

        x -
            3
        562 19
        e
        03,
            ref tj , rf j 1,
        r
            e
        r
            ams);


        u ,
        3
        383
        04e-03
            ,
            ref tj,

        re esult,
            _
        arams);


        u
        heb
            x, 
        5
        002
        88e-03
            ,
            ref tj,

        re esult,
            _
        arams);


        u
        heb
            x, 
        4
        487
        22e-03
            ,
            ref tj,

        re esult,
            _param
        s);
        ucheb(x, 3.443899e-03, ref tj, ref tj1, ref result, _params);
        ucheb(x, 2.688270e-03, ref tj, ref tj1, ref result, _params);
        ucheb(x, 2.600339e-03, ref tj, ref tj1, ref result, _
        arams)


        uc
            h
        eb(x, 
            .
        87 f tj,
            r
        ef tj1, 
        ref res
            ult, _param
        u ch b(x
        1.8 11 5e f tj,
            r
        f
            t
        j
            rams);


        353e-0
            ref
        t
            ,

        ult, _
            a
        am s
        (
            , -2
            .
        659
        45 7e 03 ,
            ref tj, re f j
        1, r f result, _
        pa
            r
        a
            m
            );


        n
            e
        u
            lt;
    }


    /*************************************************************************
    Tail(S, 5, 9)
    *************************************************************************/
    private static double utbln5n9(double s,
        alglib.xparams _params)
    {
        d
            ubl
        e
        res ul = ;


        d


        double t j = 0;


        do
            ble
                j1


        ath
        n(
            0. 0
        10 );


        t
            j
                = 1


        tj1 =
            29816
        2
        e
            +
            0, r f t j,  ref t
            j, r
        f r ams);
        heb(x
            ,
            -
                .3250 16e+00,
            r
        f t, r
        e
            tj, r
        e
        re
            ult, _
        p
            ra ms);
        eb(x, 7 93
        9
            - 0
        1
        re
            tj, 
        ref
            tj1 , re
        f
            result, _
        uc h
        e
        b
            x,  -1.563029
        e
            ,e , r
            f j1 r
        e
            result,
            uc he(
            x
            ,
            4
        .2 22 652e-02, r
            e
        tj
            r
        e
            j1
        ref
            esu
            t, _pa
        r
            ms);


        (x, -
            9
                .
        1
        5
        200e-03, ref

        j,
        ef
            j1, 
        ref
            esu
            t, _pa
        r
            ms);


        (x, 1
            .
        4
        4
        6
        65e-03, ref
        t
            , r
            f
        t
        1,
        ef
        r
            sul, _par
        a
            s);


        x, 5.
        2
        0
        4
        9
        2e-03, ref t
            j
        re
        t
            j, r
        re
        s
            lt, params;

        217e-
        0
        3
            ,
        f
        t j,  ref tj1 
            ,
 
        ref
            re
            sl t, _
        ara
            ms;

        778 e - 0
            , ref
        tj, ref tj1ref result, _params);
        ucheb(x, 2.221948e-03, ref tj, ref tj1, ref result, _params);
        ucheb(x, 2.242968e-03, ref tj, ref tj1, ref result, _params);
        ucheb(x, 2.607959e-03,
                ref tj
            ref t
        1, ref r
        e
            sult,
            p
        ar
            u
        cheb(x,
            1.77128
        5
            ref re ult, _
        a
            a
        m
            uc he
        (
            ,
            6
                .j, re f tr esult
        _p
            r
        m
            s
        he(x, -4
        0

        j
            , re
            f
        re
        su t,
            _
        p
            ar ams);


        return
            r
        e
            ult
            ;
    }


    /*************************************************************************
    Tail(S, 5, 10)
    *************************************************************************/
    private static double utbln5n10(double s,
        alglib.xparams _params)
    {
        do
            le
                es l
        0

        0;

        0
        b
            tj = 0
            ;


        ult =
            0
            ;
        x =
            a th Mi(2
            *
            s - 0
        000 00 + 0 0) .061862 e + 0 - 1, 1.
        0
            )
        tj =
            1
            ;
        tj1
            x;


        uc h,  -
            .42536
        0
            , r ef tj,
            result,
            _pa
        r
            ms)


        b(x
          - 3.49
        6
        10e + 0 , r ef t
            _para
        m
            );


        uch eb,  -8 87 65 e - 0
        1
        re f tj,
            r
        ef su t,
            _
        p
            ar ms);


        ch
        e
        (x,
            -1.
        8
        200
        e - 01,
        r
        f tj, r
        e
        f ult,
            _
        p
            a
        ams);


        uc
            h
        b(x
          - 5
              .
        276
        7e-02,

        ef tj,
            r
        ef sult,
            _
        p
            rams);


        u
            c
        eb(
            , -
                1
        515
        02e-02
            ,
            ref tj,

        re esul,
            _
        p
            ra s);


        u ch b(
            x
            - .4 686
        7
            - 04
            ref t
            j
        re f tj1,
            r
        ams);


        uche
        b
            x, 4.
        79 29 e - 0
        3
        re
            tj, r
        e
            t 1, re f rp c
        h
            ebx, 
        3e ref
        tj r f t
            t, _pa ra m
            s
            ;


        u
        heb
            x, 

        .65 4
        e - 3
            ,r ef t,  ref
            t 
        1, re r
            ;

        ucheb(x, .181165e-03, ref tj, ref tj1, ref result, _params);
        ucheb(x, 2.011665e-03, ref tj, ref tj1, ref result, _params);
        ucheb(x, 2.417927e-03, ref tj, ref tj1, ref result, _params);


        ucheb(
            , 2.5348
        8
        0e-03,
        r
            ef,  ref
            r
            esult,
            params)
        ;

        791255
            - 03, r e
            j, r
        e
            lt, _pa ra s
            ;


        1 8715
        2e
            ,
        r
            ef, r ef r es t,
            p
        r
            a
        turn rs ul;
    }


    /*************************************************************************
    Tail(S, 5, 11)
    *************************************************************************/
    private static double utbln5n11(double s,
        alglib.xparams _params)
    {
        double

        esu
            t
                =
                0;


        0
        doubl
        e
            t
                = 0;

        d
            ub e
            tj
        1 0


        res
        u
            t = 0;
            .Min(
                2
                *
                (
                    -
                        0.000 00e + 0)
            / 3. 542 7e 00
            - 1 1.
            );

        t j
            = x;


        uche b(,
        -3 539
        59
        e
        00
        re
        ft j, , ef re
            s
        u
            u heb(, -3.65 29 8e+
        0,

        tj
            re
        f
            tj1
        ref re s, param
        s
            )
        eb x,  - .
        16 50 e - 01 ref tj , ef
            j1,
            f r
            sul
        t
            _p
        rams);


        u
        c
            - 0 , re
            t, r f tj,  ref r es lt,
        _p
            a
        s);


        uch
        eb x,  -6.6 1
        8
        84 j, re
            f

        t
        1, ref resul
            t
        _p
            ra
        m
            );


        uche
        b
            x,  -2.1
        0
        94 tj, r
            e
        f
            j1,  ref resu
            l, _
        ar
            a
        s);


        uch
        e
            (x, -2.
        7
        86 tj,
        r
            e
        f
            tj1,  ref res
            u
        t,
        pa
            r
        ms)


        uc
            h
        b(, 4.2
        1
            , r ef t
            j
        1
            ,
        f result, _p
        a
            ams
            ;


        u heb
            x,  5 .48
        4
        20e-03r tj, r
        e
            f 1, ref resul
            t
        _p
        ra
            ms;
        u x,  3
            .
        9
            ref tj, ref re u
        s);


        e b(,
        2
        .3 96 191e - 03, re
            f, r
        f
            t
        1,
        ef r
        e
            ult
        _para
            m
            );


        .
        17 e - 03
            , ref tj, r tj1,  ref result , _params);
        ucheb(x, 2.206979e-03, ref tj, ref tj1, ref result, _params);
        ucheb(x, 2.519055e-03, ref tj, ref tj1, ref result, _params);
        ucheb(x, 2.21032
        e - 03,
        ef tj, 
        ref tj1 , 

        ref re
            u
        lt
            uc
        eb(x, 1
        .189679e-03
        1, ref re ult, _
        a
            a
        m
        eturn result;
    }


    /*************************************************************************
    Tail(S, 5, 12)
    *************************************************************************/
    private static double utbln5n12(double s,
        alglib.xparams _params)
    {
        d ble r
            su lt 0;

        do
            u
                bl


        d
        ouble j =
            0;
        oubl tj
        1
            = 0;


        x =
            a
        th.Min(2 * (-0
        000
        00
        e
        00 /
            .16
        2
        78 e + -1, 1.0 )
        tj =
            1;

        tj1 =
            x

        uc eb(-3
        4007 +
            0
            , re f j,
            r
        ult,
        _
            p
        a
            am s) ;

        u
        heb
            -
            3
        61
        00
            , ef
            ref j
        1
            ref r su
        l
            t


        uc he b(x, -9 .77117
        7
            - 01 re
            j, rf t 1
            ,
        f e su t, _ a
            ams);


        -2.2
        9
        0
        0
        3
        e - 01 , re t j, re
        f
            tj1
        r ef esu, _p r
            ms;


        uch
            e
        b
            j,  ref t j1, ef re
        s
            lt,
            _par am );


        cheb(x
            ,
            ref
            t
        j
            ,
            ref tj1, ref r
            sul, _
        p
            ram
            );


        u
        heb(x,
            -
                5. ref t
        j
            ,

        ef tj1,  ref
            r
            sul,
            _
        ara
            s);


        cheb(x,
            3. ref t
        j
            ,

        ef tj1,  ref
            r
            sul,
            _
        ara
            s);


        cheb(x,
            5. ref t
        j
            ,

        ef tj1,  ref
            re ult
        _p ams
            ;


        uche
            b
        4 .2015
        3
        0
        re f tj
        1
            ,
        r f result, _
        uc
            h
        b(, .7 55 e - 03, re t, rj
        r
            sul, _
        p
            ram
            );
        ch e 1.9
        7
        8
        9
        5
        e - 0, r
        f j, r ef res ult, _
        am s) ;


        2.0120
            - 0 3, ref t, ref tj1,ef result, _params);
        ucheb(x, 2.304579e-03, ref tj, ref tj1, ref result, _params);
        ucheb(x, 2.100378e-03, ref tj, ref tj1, ref result, _params);
        ucheb(x, 1.728269e-03, r
        f tj,
            ef tj1
            ref resu
        l
            t, _pa
        a
            ms ret
            u
        rn resu
            t;
    }


    /*************************************************************************
    Tail(S, 5, 13)
    *************************************************************************/
    private static double utbln5n13(double s,
        alglib.xparams _params)

    d
        uble r su

    l
        b

    l
        e =
            0;


    dou
        l;

    d ou l
        e


    e
        sult = 0;


    x= M at
        .Mi

    n
    2*(
    -0.000
    00 e+ 00 )/3.2
    0
    3


    t
        j = ;


    j
    =
    ;


    cheb(x
        , - 3. 73 91 0e+
        0
        0
        1, re
            r

    es t, _p rams;


    u
        ce b(x,
        -3.
        9
        811

    e+00,

    r
        tj, ef t
        j

    1
    ar am );


    u heb(x, -1 031
        05

    e
    , r
        f t
        j

    re
        tj1,
        r

    re su t, _
        p

    a
        uch

    eb(x -
        2.519403 e- 1
    , r tj
    r ef j1,

    ref
        u, ram
        s

    )

    b(x, -8 9
        6
        6
        48 e-02, ref tj ref j1
    ,
    re f sul
        t

    _p
        rams);
    .29 21 83
    e
    -
    0, ref tj,

    r
        f t1 ,

    r
        f r
        s_ r
        a

    s);
    80 293e 0
    3
    f tj r
        e

    f t j
    1,
    ef r
    sul, _ a

    r
        ms)

    uh 56e-0
    3
    ,

    ef tj, ref t
        j, r

    f
        r

    sul
    , _
        p

    ram
    );


    u
        ch 78e-0
    3
    ,

    ef tj, ref t
        j, r

    f
        r

    sul
    , _
        p

    ram
    );


    u
        ch 55e-0
    3
    ,

    ef tj, ref t
        j, r

    f
        r

    sul
    , _
        p

    ram
    );


    u
        c

    e-03,
    r f
    tj, ref t j1, r
    ef re su
        t,
        par

    ms)
    ;

    u
        b(x, 2
            .2 1

    ef tj1, r

    ef
        esl t
    ,

    _p am;
        941479e 03 re t j,

    re
        f

    tj1
        re

    f
        res

    lt, _p
        a

    s)

    uch
        b(x,
            2058603e-03ref tj, ref tj1, ref result, _params);
    ucheb(x, 1.824402e-03, ref tj, ref tj1, ref result, _params);

    ucheb(x, 1.830947e-03, ref tj, ref tj1, ref result, _params);
        return

    result
}


/*************************************************************************
Tail(S, 5, 14)
*************************************************************************/
private static double utbln5n14(double s,
    alglib.xparams _params)

d r
s
    u
do
    u
        b
l x
    = 0;
dou ble
    j =
        0;


r
s
    ult = 0;


x Ma th Min((s -
             .000 0
e + 00)/3 .2 4e + 0
0
    -
    1

1
.0 );


tj

1;

j1 = x


.8 2e +
    00
    ,
reft j, 
ref
    tj1 
    ,
 
ref
    result 
    ,
    par as )
;


(x, -4
    .
0
5
3
70e+0 0, ref tj
    ,
    ref
tj
1
re f
su t,
    _pa
ams);
u h
e
0, re f j,
    r
ef t j1,  ref re
    s
lt,
_p
    a
am s) ;


uche b(,
-2 743 16 e
    -
    0
1, r ef r
    e
s
l
    t, _p arams);


uc he b(, -
    1
012
30e- 01
r
    tj, r f
    t
ara ms;


x
    - 3
88 46 86 e - 2
    ref t
    j
re f j1, e
ms);


cheb(x
    ,
    -1.
59
6
6e - 0 2
re
f
    tj, 
ref tj  1, ef esu lt,
    _


uc he b7 1e-
3,
r
f t, re1 f
    ru;


ucheb(x,
    5
134 06 e
03 e f j,
    f
j1 , ef r ult, _ pa a
m
    x,  4.584201 e
03,
re
f
    tj, 
ref
    j1 , 
ref re
    s
lt, _pa
    r
am u
c
    h
e
    (x, 3.440618
e
03,
re
f
    tj, 
ref
    j1 , 
ref re
    s
lt, _pa
    r
am u
c
    h
e
    (x, 2.524133
e
03,
re
f
    tj, 
ref
    j1 , 
ref re
    s
lt, _pa
    r
am u
c
    h
e
    (x, 1.99 0
0
7e
    -
    r
f
    tj re
    tj
1
ef
esu t, _
p
    rams);


(x, 1.
8
8
7
34 e - 03, ref t t
    j, r
f resu
    l, pa am s
uc
heb(x, 1.5377e-03, ref tj, ref tj1, ref result, _params);
ucheb(x, 1.705395e-03, ref tj, ref tj1, ref result, _params);
return result;
}


/*************************************************************************
Tail(S, 5, 15)
*************************************************************************/
private static double utbln5n15(double s,
    alglib.xparams _params)


ub le

res
    u
l
    t
        =
        0;
d
    o
ub e x = ;


;


tj
0
resul
    t
        =
        0
    ;
    =
at
    h
n * 00e
    + 0 )/ 3. 25 000
e
    +
    t j 1


j1
    x;

uc h
    tj, r
e
    f

j
1, ref r es l
    t,
    _pa
s
    )


uche
b
    x,  -.08
2
0
t
    j1, re f re ul t,
    _
p
    ram
    );


che
(x, -1
    .
95983 + 0
0
    ,
1, r ef ult, _para
m
    );


u ch b(
    x, -2.8145
9
5
ef tj
1
    , r
    ms)

uc
    h
b(x
  - .07
3
48 e - 1, r f

re ult,
    _a ra ms);


ch eb(
    4.
202
1
e - 0, r f tj e f j1, e
f


ucheb(x, -1
    .
171
5e - 0 2
f
    j,
    r
f t1, ef r sl t, _par m
    s
    )
(x,
    -
        2
            .
180e-03, ref

j,
ef t j
    ef
res
u
    t, p arams);
93e-0 3, ef tj, re ft j1, 
ref r es lt,
_param
    s
    ;


2.7 11 4
3
e
    -
    3, ref tj, r
e
    tj,
    r
f r
sul
    t
_pr am );

u h
eb e - 03,

r
e
    tj, r ef t 1,
r
    ef

e p
ram )


c heb
(
    x
        f

tj, e f
t
    j, r
f
r
    sul, _
p
    ram
    );


u
    ch 12e-0
3
    ,

ef tj,  ref t
    j, r
f
r
    sul, _
p
    ram
    );


u
    ch 44e-0
3
    ,

ef tj,  ref t
    j, r
f
r
    sul, _
p
    ram
    );


u
    ch 16e-0
4
    ,

ef tj,  ref t
    j, e
r
e
    t,
    _par s);


uc eb(x
    ,
    1 ref t j,
    ref t 1
    ,
    t_params);
return result;
}


/*************************************************************************
Tail(S, 5, 16)
*************************************************************************/
private static double utbln5n16(double s,
    alglib.xparams _params)
{
    le r su
        t
        ;

    ouble x
    d oubl

    j


    oubl
        tj1 = 0
        ;


    re
        s
    u
        lt = 0;
    h.M
        n
    2
        *
        )/3 5
    e


    t
        j
            = 1;
    j
    1
        = x

    ucheb
    (
        x
    0, re
        f

    tj
        r
    ef t 1, r f

    re
        sl t _p
    a
        ams
        ;
    uc
        h
    e
        + 00,
    r
        e
    f
    t
        j,  ref tj1 , r e
        r s
        lt, ara );


    u
        he b(x. 6e+0 0,
        r
    e
    t j,  ref tj1 , r e
        re
    ult _pa
    ams
        );


    ucheb(x, -282e-01, r
    e
    f
        j, re f j1,  ref
        r
        sul,
        _
    ara
        s);

    u ch(x, -1.0
    8
    4
        ref t
        j
    1
        ,
    r
    ef result, _p ar
        a
    s);


    uh eb x
        - .667
    0
    4e-02 , e
        f

    ref result , _ a
    am
        s
        ;


    uc
    eb x, 
    -
        .843 90 e -
        0
    tj1,
    r
        e
    f
        result, _par am s


    uc he(
        ,

    54 56 32e- 3
    r ef tj, e
    f
        , _par
        a
    m
        s
        ;
    u
    (x
     -
     5
    039
    30 e - 4
    r ft j,  ref j 
        ,
        re res l
    t
        u
    heb(x, 4.723 50 8
        ,
        ef

    j,
    ef t 1
    r fr es lt, p
    ra ms;


    3. 96 8
    e
        - 0
    4, ref j,

    ef
        j1,
        ef r
        sult, _
    p
        s);


    1 4
    7
    8
    2
    5e - 04r re
    tj
    1
    r ef
        ult, _ pa ams);


    9144e-04,
    r
    f t,
        re tj 1, ref sul t, _par ms
        )


    -4.2 7
    7
    0
    3 - 04, ref tj,
    r
        f t
    1,

    ef
    esu
        l, _
    arams)
    ;


    4.707
    4
    1
    0
        - 04, ref tj,

    ef
        j1, 
    ref
        res
        u
    t,
        params
        )


    -1.87
    4
    2
    9
    e - 04, ref tj
        ,
        ref
    tj
    1
    re
        re
    s
        lt,
        _param
    s
        ;


    esult;
}


/*************************************************************************
Tail(S, 5, 17)
*************************************************************************/
private static double utbln5n17(double s,
    alglib.xparams _params)
{
    sult =
        0; = 0;


    0;


    d
        = ;


    M
        n
    2 * (s
         -
         0.0
    0
    0
    0
    0
    0
    e + 0)/3.25 0
    0
    0e
        +
        0
    0 - 1, 1.0);

    tj
        =
        tj
        ;


    che
    (
        ,
        f tj, ref tj1, ef res ul, _p rams);
    u
    heb(x,
        -4 .9,
        r
    f
    t j, r ef tj 1, ref

    esu
        t, _p rams;
    uch eb x,  -.08
    4
    70 j, r e1 e
        f
    res
        lt, _ ar am
        );


    uc
    he(x, -.75
    8
    8
        ref
    t
        j
    1, r
    ef result, _ pm
        u he b(x
    -1.073
    8
    4
    ef tj
    1
        ,

    ef r sult _para
    m) ;


    e - 4.68
    4
    8
    ef tj
    1
        , f
    r sult, _para );


    uc
        h
    b(-.9
    6
    4
        , ref

    tj 1, r
        e
    f esu lt _para );


    uch
    e
    (x,
        -6.7824 42 - 03, re
    f

    resul
        t,
        params);


    uc e
    (x,
        -1.
    9
    636
    03, re
    f
        tj,  ref
        t
        _para
    m
        s
        )
    uc
        h
    b(
        , -5. 8
    7e
        -
        4,
    ef tj,
        ef tj1 ,s ,
        params);

    ch
    eb x, 
    96
    93 e - 0
        , r ef tj, 
    ref tj  1,
    r
        ef ra ms );


    uch eb x, 
    -.55 82 2e
        - 0 , r
        j,
        r f t
    1, re r
    e
        ult, _ par
        a
    ms u ch eb x, 

    8.690746e - 0 ,
    re tj, ef
    t 1,
    re
    su t,
        par am );


    u 64 85 5e - 0 ,

    r
    f tj, r ef tj 1, ef rs ul
        t
    _p ams )


    uc he(x,
        -
            1
    r
        e
    f
    t
        j, r ef t 1, ref

    esu
        t,
        par
    ms );

    uc e
    (x, -1.
    5
    4
    tj, re
        f

    t
    1, ref resul
        t
    _p
        ra
    m
        );


    retu
    r
        result
        ;
}


/*************************************************************************
Tail(S, 5, 18)
*************************************************************************/
private static double utbln5n18(double s,
    alglib.xparams _params)
{
    double re
        ult = 
        ;

    do
        u
            ble x

    0;
    doubl
    e
        tj = 0


    0;


    s
        = x = M
    t
        .
        i
        n
        )/3.25
    00
    e
    0
    0
    tj 1
    tj1 = x
        .
    840 e0 0
        ,

    r
        e
    f
        tj,  ref tj  1
        ,

    r
    ef result, _a


    06
    e
        +
        f tf re
    s
        lt, _
    ms )
    ;


    u heb(,
    -
        tj, re
        t
    1
        , ref r e


    uche b(,
    -2 7126 9
    e1 f tj1
        r
    e
        re su t, _param s) ;

    u
    heb(x,
        1.0492 17 -
               0
    1, re
        f r
        e
    u
        lt, _pa ra m;

    ue 33
    e
    ef tj,
        re r
        esult, params
        )


    uche b
        - 1.92
    9
    8
    ef t
        j, r
    ef resu lt
        _
    p
    a
        ams
        ;


    u c
    ref t
        j,
        e
    f tj, re resut
    r
        as );


    uch
    e
    (x, -1. 94 90,
        rf t j, e f tj1,
        r
    f r
        t,
        ar
    ms;
    u
    heb(x,
            -
        ref t
        j, r
    f
    r
        sul, _
    pa ams
        ;

    uc he(
        ref tj, r ef

    t 1
        ,
        ref
    re
    s
        lt, ara s;

    u eb(x,
        1
            .f tj,
        r
    e
    f
        tj1,  ref res
        u
    _ pa ms
        )


    u
    (x, -
        6
    489 13e-
    0
        , ref re sp;


    u h
    b(, -6. 4572 e
    04 , ef t,
        ul t, _
        p
    a
        r
    ms);

    he
    (x
        ,
        -8.
    45 63 e
    04 e f j, r f
        tj 1, ref e
        s


    ucheb(x, -1 .4 2
    e -
        3,

    ef
        j, r f
        tj, r ef resu t
        _ pa ams)


    n resu
    l
        t
        ;
}


/*************************************************************************
Tail(S, 5, 19)
*************************************************************************/
private static double utbln5n19(double s,
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
        x
            =
            0
        ;


    double tj = 0;


    do
        ble tj1 =
                0;
            = 0;


    x =
        Math.Min(2 *
                 00
    0e+00 /
        0e

    j 1;


    x;


    27e + 0 0, r
        f
    t
        jt j
    1
        , ef re s, r
    a
        ms);
    x, - .
    5
    91 tj, r f
        t, _par am s


    he
        bx,  -1
    071
    1
    6e+
    re f t
        j
    re f j1, ef ram s) ;
    uc
    hb(x, -2 66 9
    9
    0e-
    1,
    r
        f t ref tj
    1
        ref re
        s
    u


    ucheb(x, -1
        .
    78 0e 1,

    ef
        j,
        r
    f t, r f r
    e
        ult, _par a
        m
    uch
        e
    b
    (
        ,
        -4.442555e-
    0
        , re f
    r e
        tj, r
    e
        reu lt _pa as );


    1.851
    3
    3
    5
        -
        02, re f tj, re f re ul t,
        _param
    s
        ;


    3386
    5
    e - ,
        ref t j,  ref t
        j, r e
        , _
        arams)
    ;

    446 e -
        0
    3
        ,r ef tj,  ref tj  1 _pa
        rm s) ;


    ucheb(
        ef tj
        , e

    tj1, ref res t,
        pa
    r
        ms) ;
    uc he(x
    0, r
    ef j, r f tj,  ref r ult,
        _
    ara
        s);

    u
    5e 03,

    r
    e
        tj, reft 1
    ef
        u
    l
        _p
    rams
        u heb(
        x
        ,
        03, ref t j,
        re f

    j1,
    re
        f
    ul
        _p
    a
        );


    c e
    b
    (
        e - 03, re f j, re
    f
        tj1
    r
        e
    re lt, _ ram)


    u
        - 04, ref
    j , e
        t 1 ref
    res
    u
        t,
        params
        )


    84427
    e
        -
        0
        ,
        ref t j, r e
        f
    t
        j, r
    f
    rs ul,
        _p r
        a


    et rn re
    su lt;
}


/*************************************************************************
Tail(S, 5, 20)
*************************************************************************/
private static double utbln5n20(double s,
    alglib.xparams _params)
{
    double res
    u
    l
        t
            = 
        ;


    d
        o
    u
        b
    l
    e
        x
            =
            0
        ;


    d
        o
    u
        b
    l
        e

    t
        j
            =
            0
        ;


    d
        o
    u
        b
    l
        e

    t
        j
    1
        =
        0
        ;


    result
        = 0;


    x = Ma
    t
    h.Min(
        *
            (s 0) / 3.2
    5
    0000e+0
        - 1, 1.0
        );


    tj
        u
    h
        b
    (
        , ref
    j,
    r
        f

    t


    54 29 +
        0
    0
        , re f tj, re f tj 1,
    r
        ef

    r
        esult, _p ara ms );


    -
        67 + 0, ej ef t 1, r
        ,
    _p
    a
        ams
        ;


    u
        c
    eb(x, -
        2
    .6 ef tj,
        r
    e t
        j1,  ref resu
        l
    _p ra s)
    ;


    b(x, -
        1
    003234e
        -
        01 f tj1,
        r
    f
    resu lt, _para
    m
        );


    u
    heb(x - 4. 72
    7
    9e-02, e
        f
    f r esu
    l
        t,
        _
    param s) ;
    uc he b
    (
        , -1
    831551
    e
    02, ref

    t
    resul
        t, a
    rams);

    uch eb(
        6.
    63090e
        -
        3, ref
    t
        j
    resu
    l
        t,
        _
    param s) ;
    he
        (x, -1
    8306 6e-03,

    ef tj,
        r
    e
        lt, _ a
        r
    a
        m
        )
    ;
    ucheb
        x, 
    122
    3
    4e - 0 4
        ref t
        j
    ref tj 
    1
        ,
    aram s)


    ucheb
    (
        , 8.
    04, re f t
    ef tj1,
        arams;


    uh eb
    (
        , 1 .5 79
    8
    e - 0
    rt tj1, r ef r es );


    uch b(x, .
    9
    66
        - 0
    3
    f
        j,
        r
    f t
    1, ref

    lt, _p
        a
    r
        uc
    h
        e
    b
    1.9 65696e- 3
    re
        tj, ef
    j1,
    e f re
        ult, _
    p
        rams);


    x, 1.
    4
    9
    32 6
    e - 03, ref t
        j,
        e j
    1, ref
    re u
        l, _
    ar am );


    uc 591e-
    0
    3,
    tj, ref tj1,
    e f r
    su
        l, _p ram
        s


    return
        result;
}


/*************************************************************************
Tail(S, 5, 21)
*************************************************************************/
private static double utbln5n21(double s,
    alglib.xparams _params)

double result = 0;
double x = 0;
double tj = 0;
double tj1 = 0;

result = 0;
x = Math.Min(2 * (s - 0.000000e+00) / 3.250000e+00 - 1, 1.
);


tj = 1;


uche
    (x, -3.
849649e+00,
ef res
    lt, _pa
a
    ;
che b(x,
    4
5
5e ref t j1 r
    f
r


b
    -
    .
06 f
    t, ef tj , rs l
    t, _pa ams;
-
    .
0
88 tj,
r
    f
su t, _para m
    uc
eb(x,
    .9 02
88e-02
    ,
    ref tj,

r
    _p am s;


uch
b(x, 4.
3
66 e -
    02 ,
    , ref

r
    e
u ra
m
    );


cheb(x
    ,
    -1.8747
0
9
f tj1,
    r
f
    result, _
p
    ar
a
    s);


c he b
    - 7.682
8
7e-03,
r
    e
re re
s
    u
l
    params);

u
heb(
    , -3 02 62
0
e - 03, r
    e
f
    ef re
    s
u
    l,
    _params) ;


che
    (x, -1.
5
4551e-03 ,
j1, rf r
    esult, _a s)


uche
    bx,  -4 .9 0575 -
    1,, _pa
    am s) ;


uch
b(x, 3
    .
33 4e
    -
    0
1, r ef r
    e
s
l
    t, _params);


u
    heb
(, 9 7
71 e - 04 re t
    j,
    re ult
    ,

_
    a

uc e
(x. 30 571e 0
    , ref tj, r
    sult,
    a


cheb(x 1.1 311 0e 03
    ,
    ref tj,
    esult
    ,
    _a ra m)

c he b(x, 1.1
2
457
    - 03, e tj,  ref
    p r
a
    m
    );
r r
    sul
    ;


}


/*************************************************************************
Tail(S, 5, 22)
*************************************************************************/
private static double utbln5n22(double s,
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
        x
            =
            0
        ;

    d
        o
    u
        l
    e
        tj
            = 0;


    d
        o
    u
        b
    l
        e

    t
        j
    1
        =
        0
        ;


    r
        e
    s
        u
    l
        t
            =
            0
        ;


    x
        =
        M
    a
        t
    h
        .
        M
        i
    n
    (2 * (s - 0.000000e+0
        ) / 3.25
    000e+0
        - 1, 1.0);


    tj1
        x;

    uc
        j, r ef t j1,
        f re su lt, _
    a
        ;

    05 e + 00 , re f,
        f
    1,


    c
        e
    b
    00, ref
    tj,
    r
        t
    j
        params
        ;


    x
    2 .579
    5
    13e
        -
        0
    1f tj, ref t
        j
    1 ef res
    u
        l
    t
        _p
    a
        r


    c
        h
    2
    e
        sult,
        _
    ar ms;


    u
    heb
        x,  -4.
    2
    5137e - 0 2,

    r
    1
        ,
    r
        e
    f es ult, _pa
    r
        ms)


    h
    b(x, -1
        .
    8
    j, re
        f
    t
        j1 ref r sul, _pa
    am s)


    cheb(x
        ,
        -8.1773
    7
    4
        ref t
        j
    1
        ,
    r
        ef res ul, _p r
        as );


    u ch(x,
        -3. 98 1
    tj1,

    r
        e

    re sl t, _par
    a
        che
    b
        x, 
    2. 69 290
    e
    03, re fr tj1, r ef r su t, _params);

    uc b(x
    1. 88 03e-0
    3
        ref t
        j,
        t,
        _pa ra ms );


    u
    heb
        x,  1
    085
    78e-03
        , ef tj, re
    _par am s
        )
    ;


    uc
    eb(x
    4.e -
        4, ref t
        j,
 
        ,
        _para ms );


    uch
    e
    (x,
        -5.426
    3
    7e-0 5,
    r
        e
    ref r
        e pa
        ams )


    u
    heb(x,
        396 13 - 0
    4
        ,
    j1, r
        e
    f
        esult, _para
    m
        );


    u
        c
    eb(
        , 2.66
    27 8e 04, e
    f
        ft, _pa
    r
        );


    ret rnr su lt
}


/*************************************************************************
Tail(S, 5, 23)
*************************************************************************/
private static double utbln5n23(double s,
    alglib.xparams _params)
{
    d
        ou le re s
        d
    ubl e x
        = 0;
    double tj = 0;
    double tj1 = 0;

    result = 0;
    x = Math.Min(2 * (s - 0.000000e+00) / 3.250000e+00 - 1, 1.0);
    tj = 1;
    tj1 = x;
    ucheb(x, -3.84
    269e+0
        , ref
    j, ref tj
    1
        , ref
    e
        su;


    cheb(x,
        -4.043761e
    ef res
        lt, _p ar am )
        , -1 .0 52 73 5
    0
    e
        j,
        s) ;

    u
    b
        - 2
    1, r ef r es u
        _ pa r
        )

    9.51750 e
    0
    2
    j
        ,
        ref r e
    s
        ult, pa r
        a
    m
        s);


    uc he b(x, -4. 1
    2
    0
    2e-0 2
        , tj
        ,
    r
        e
    ms)


    (x - .7 80 2
    re
        j, ef t

    r
        sult, _
    p
        a
    cheb(x, -7 .5 4
    483
        - 0
    3
    re
        tj, r ef t
    r ef re
    s
        lt, _pa
    r
        a
    (, -3.74732
    9
        - 03
    r
        e
    tj
        re
    f
        t re ult, para s
        ch eb x, 

    -
        2
    69 42 63e-03, ref

    j,
    ef
        , r
        f re
    s
        lt,
        _para m) ;


    4
    1
    e
        -
        3, r f tj, re f tj
    1
    re
        r
    e
        ult
    _pa r
        );

    ucheb(x
          -
          tj re
    f
        t
    1
        , ref re ult,
        _
    ara m

    uc he b(x, -1 .03917
    3
    e - ref t j1
    e
    f esult, _p ra
        m
        );

    heb(x, -7
    2356 15e-
    0
    4
    tj1,
    rf r
    es lt, _pa ra s
        )

    ucheb(x, -4 .6 56 54 e - 04, re
    f
        t ref r s
    u
        l,
        _ arams);


    uh eb(.0
    1
    423e - 0 4, r f tj ef res l
    t
    para ms;

    re rn
    esu lt;
}


/*************************************************************************
Tail(S, 5, 24)
*************************************************************************/
private static double utbln5n24(double s,
    alglib.xparams _params)
{
    d
        ub le resu
    l
        t


    o
        ub le x = 0;


    d
    e
        j =
            0

    d
        ub e tj1
        =
        resul
    t
        =
        0;


    Ma
    t
        .Mi
        (2 *
         (s 0.
    00 00e + 0 )
    3.25000 0

    tj
        = 1;
    tj1 = x;
    ucheb(x, -3.848925e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -4.040178e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.048355e+00, ref tj
        ref t
    1, ref
    result, _
        p
    arams)


    heb(x,
        -2.5101
    8e-01,
    re resul, _par
    m
        )
    ;
    ucheb(
            ,
            -
        .
    26 f tj,
        ef
    t
    1
        , _param
        );


    , -3.9
    5
    6
    4e
    e
        tj1,
        re
    f
        r
    e
        s
    u
        lt, _params)
    ;


    u
        c
    h
        b
    (x
     -
     ef
    t
        ,

    lt,
    _
        a
    r
        uc e
        b
    (
        ,

    -6 .307345e-0
    3tj, ref tj1
        ref re
    s
        lt, pa as);


    e(x, -2.7
    3
    992
        - 0
    3
    re
        tj,
        re t 1
    rs );
    u
    heb(, 1
    869
    52e
        -
        3,
    ef tj, r e
        tj1, r
    e
        f ams);


    ucheb(x
        ,
        -1.
    94
    17 e - 3e tj,
    r
    f tj1,
        ram );


    ucheb(x - 1
    04
    7
    ef j,  ref
        t
        j
    para s
        )
    ;


    uch eb
    (7
    178
    e - 04 re
    f
        tj, re f j
    1
    para
        m
    s) ;

    e
    5.42 4
    e - 4, ref tj
        ,
    re f tj1, e
    f
        u ch b(x,
        -. 82 95 4,
    ef tj, rf tj1, r
        e
    f
        ms;


    uc he(
        x
        ,
        -
            .8 40 8e 04
    re f tj, ef tj1, re
        f
        );


    eturn re
    s
}


/*************************************************************************
Tail(S, 5, 25)
*************************************************************************/
private static double utbln5n25(double s,
    alglib.xparams _params)


do
    ble res
u
    l
dou
    b
l
e
    x = 0;

ou
    b

double
    t


r
    sult = 0;


x

Ma
    - 0.00 00 00 +
    00 00 - 1,
.0;
    =;
tj1 = x;
ucheb(x, -3.848937e+00, ref tj, ref tj1, ref result, _params);
ucheb(x, -4.037512e+00, ref tj, ref tj1, ref result, _params);
ucheb(x, -1.044866e+
0, ref
tj, re
    tj1,  ref
    result
    _p

ucheb(
    , -2.48
3269e-01, r
    _ pa ra ms );

u c
(
    -9.
    , re f re su l
_
    a
    ;

eb(x, 3. 76 778 -
            2
    ,
    r es ul t, _ p
ms );


t j, r ef t j
    r
re s
u
b
    - 5. 33 27 56 e - 03 , r
    e
f

t
    j,  ref tj1 , r f
    resul, _para s
    )
;


1.
8
5
1
    ref
,

ar
    uch
b(x
    , -1
124041
e
0, e f
resul
    t
_pr as )


e - 4, f re
f
    tj1, re
f eu lt, arams);

.9 499e-0 4, ref t j,
    r
f t
1,

ef
    es ul t,
    _pa
ams) ;

30 e , r, t, _
    pr am );


-.029 2
8
    -
    0
4, r f tj, re
f
1e lt , pa ra m
    );


uc
    h
04, e
f
    t,
    r ef r
e
    re su t, _
p
    ram
    );


u
    c
h
4, r
    e
f tj
ref tj1 , rf re
ul t, _ pa am s)


re
    t
u
}


/*************************************************************************
Tail(S, 5, 26)
*************************************************************************/
private static double utbln5n26(double s,
    alglib.xparams _params)

ubl r
e
s
    u
        = 0;


d
    ub l
    e


o
    uble t j1 = 0;


r
su lt =
    0


n(*(s
    -
    0
        .
00e+00)/3 .2 5000e+00 - 1,
1
0) ;


tj = 1;


uche b(x, -3
    .
494 1
j
    ref t
    j, re fr e
s
    uc
h
55e+00, ref tj, ref tj1, ref result, _params);
ucheb(x, -1.042493e+00, ref tj, ref tj1, ref result, _params);
ucheb(x, -2.466021e-01, ref tj, ref tj1, ref result, _params);

uche
    (x, -8
956432e-0
2
    , ref
j
    , resul
    t, _para
s);

uc
91 4e-02
re, tj , re
    e s
l
    t,
    c
he 89e-02
re
    j, r result
    p
ar
    uc
h
eb(
    x
    ,
    -
        5
            .
035254e-03,
r
    e
f tj,  ref tj 
1
    ,

ef
    r
es );


(x,
        -
    .
67 f tj,
    r
e
    tj1, ef resu t
_p
m
    s
    ;


eb(x,
    -
        .492734
e
    -
    j1,
r
    e
f e
    sult, _pa

uch b(
    x

-7.014
0
r
f
    tj, reft j, e f
    ;


ce bx
    - r e
f
    tj, 
ref j , re r
    uch b(x - 57 0e 04,
    ref t j, r e
tj1, r ef
r
    e


uch eb(x
-2.07 5
41e
04
    ,
    ref
tj, re t j re
f
    a
r
    a
s
    );
uch b(x
-1
9
4, ref
t
    , re fe t, _
p
    a
r
    m
s);

heb , -2
.13
82 - 04
re f j,
    ef t j1, l _
    p
a
    a
ms);

re tu re lt;


}


/*************************************************************************
Tail(S, 5, 27)
*************************************************************************/
private static double utbln5n27(double s,
    alglib.xparams _params)
{
    bl e
    result

    0;

    x = 0
        ;


    dou bl et =
        0


    ouble tj 1

    r
        e
    s
    l
        t = 0;
        =

    ath
    Min
    (
        *(s
    0.00 00 00 + 0 )/3.250
    0
    0


    t j 1;


    j1
        x;


    c heb(x,
            -
        ref tj
        ef tj
    1
    l _params);
    ucheb(x, -4.034815e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.040650e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -2.453117e-01, ref tj,
            ef tj1
        ref r
        sult, _pa
    r
        ams);


    b(x, -
        8
    .886426
        - 02, re
    f tj,  ref t
        _p rams
        ;

    61 702e
    0
        ,
    r
        e
    rs l
    _
        aa m
        u heb(
        , -
            5e - 02, r e
    j, r
        e, _ pa a
    ms)


    ucheb(x
        , 5.002476
    f j 1

    re ara
        s
        ;

    cheb(
        x
        ,
        1
    .720126e-03,

    ef
        j,
        ef
    j1,

    ef
        esult,
        params)
    ;

    cheb(
        x
        ,
        1
    .001400e-03,

    ef
        j,
        ef
    j1,

    ef
        esult,
        params)
    ;

    cheb(
        x
        ,
        7
    .729826e-04,

    ef
        j, f t
    1, r
        e
    res lt, _p
    a
        am s) ;


    -4.7
    4
    0
    6
        -
        04, ref tj, r
        e tj1
        r
    e
    re
        ult,
        _pa
    ams);

    uc he 33e-0
    4, re t,  ref tj1 , r
    e
        re
    ul
        t
    par ms;


    u
    heb(x, 3
        .tj, r
    e
        f

    j
    1, r f es ult,
        _
    ara
        s)
    ;
    che b
        - 3. 19 34 71
    e
    04, ref
    t j
    es ul t, _p a
    r
        as )
    -3
    .8 40 1e -, j, re f tj,
        f
    result, _pa r
    a
        s);


    tur
        re su t;
}


/*************************************************************************
Tail(S, 5, 28)
*************************************************************************/
private static double utbln5n28(double s,
    alglib.xparams _params)
{
    d oe result = 0
    ble x =
        0


    d
        ubl e j
        =
        0;

    do
        ub l
    e
        ult = 0;


    x = M
    th.M
    n(2 *
      0000e
      +
      0
    01 ,
    1.0);


    t
        j
            = 1


    t
        j
    1
    uch
    eb(x, -3. 50668e+00, r tj
    r
    e
        tj, r
    e
        re s
        a
    r
    ucheb(
        , -4.03
    3
    etj, ref tj1, ref result, _params);
    ucheb(x, -1.038853e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -2.440281e-01, ref tj, ref tj1, ref result, _params);
    ucheb(x,
        -8.806
    20e-02
        ref tj,
    r
        ef tj1
        re arams)
    ;


    uc
    heb(x, -3.6
    tj, r
        f tj 1, r ult, _ pa ra s
        ;


    (x, 
        ,  ref
    ,
    _p rams
        ;
        ,
    87e e
    f tj,  ref t j1, 

    ref result ,
        _
    p
        a
    s)
    ;


    c
        he 30e
    0
        ,
    r j1, r
    e
        f

    e
        sult, _param
    s
        ;


    u
        c
    eb(
        , -8.2
    6
    121e-04
        ,
    r j1, r
    e
        f

    e
        sult, _param
    s
        ;


    u
        c
    eb(
        , -5.8
    4
    609e-04
        ,
    r j1, r
    e
        f

    e
        sult, _para s
        )


    che
    b
        x, 
    863967
        , ref t
        j,
        esult,
        p
    r
        ams);


    3 1610e-0
    4
        ,e t1, r e
        f
    s )


    u ce b
        - 1
            .
    7
    2
    2
    94e-04, ref tj ,, ref re
        s
    lt _p
    a
    r
        - 1
            .
    522
    3e0 4 refr e rs l
        t, _params);


    u c
    eb(
        , -
            2
    901
    e - 04,
    r
    f tj, re f t
    a
        ra s)
    t
}


/*************************************************************************
Tail(S, 5, 29)
*************************************************************************/
private static double utbln5n29(double s,
    alglib.xparams _params)
{
    t
        = 0;


    dou
        le
            = 0


    d
        o
    ble tj
    0
    oub lj


    es lt = 0


    x =
        M
    th.M n(2 * s
           -
           .2 50 00 -
                 1
    1 .0 )


    j =
        1;


    t
        j
    u ch e 17e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -4.032834e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.037113e+00, ref tj, ref tj1, ref result, _params);

    uche
        (x, -2
    427762e-0
    1
        , ref
    j
        , resul
        t, _para
    s);


    , -8
    71 91 46 e - 2

    r
        r f re s
    571 72e-
    2,
    e
        t f esul, _ p
        c
    h
        e
    b
    (
        x, -1. 35 98e-02
        ,
        ref tj, ref
        t
    j
    1 re
    r
        e
        ;


    3, re
    f
        t,
        r ef tj1, f, ara
    s) ;


    6e- 0 ref tj,
    r
        f t
    1,

    ef
    esu
        l, _
    arams)
    ;


    4.916
    9
    3
    6
        -
        04, ref tj,
    r
        f t
    1,

    ef
    esu
        l, _
    arams)
    ;


    2.065
    5
    3
    3
        -
        04, ref tj,
    r
        f t
    1,

    ef
    esu
        l, _
    arams)
    ;


    06730 e
        -
        0
        ,
    r f tj,  ref tj  1
    re
        es u
        t,
        par
    a
        s);

    uche(
        x
        ,
        rf j1, ref sul
        ,
        _
    ara
        s);


    u
        c
    eb(x, 2
        .
    4
        , ref

    t
        j, 
    ref result , ar


    uch
    b(x, 1
    95 e - 04,

    r
        re f re
    su lt,
        ar am s) ;

    u ch e
    (x
        ,
        4.7
    003 8e -
        re tj , ref

    j1, ref

    r
        re turn resul
    t
}


/*************************************************************************
Tail(S, 5, 30)
*************************************************************************/
private static double utbln5n30(double s,
    alglib.xparams _params)
{
    d
        o
    ble esu
        l
            = ;


    dou le t = 0;


    oub
        l
    tj 1


    x = M i
        n
    2 * (-0. 0
    000
        + 00
        )
    3.2
    0000e+
    0
        - 1 , 1. 0)


    ;


    tj = x;


    eb
        x, 
    -
        .85
    845e+0
    0
    r ef t, re
    f
        t, _pa
    ams);


    ueb(x, -4.032148e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.035679e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -2.417758e-01, ref tj, ref tj1, ref result, _para
    s);


    ucheb(x
        ,
        -8.65
    3
    30 , ref
    t
        j1,  ref
        result ,
        _params);

    -3. 22132e
    r
        e
    ref r
        s
    l
        , _
        uc
    eb
    x -
        tj,
    ef
        ar am s)


    4
    3
    1e-0 , re f j,
        r f tj1,  ref r
        e
    s
        ult, _ pa r
    (x

    1
        .r
    j
    1
    arams
        )
    ;


    che(x
        - 3 .1 33
    2
    e - 04, r
        e
    f ref
    r
        e
    s
    l
        t, _params);


    che
    b
        x, 
    5.6838
    8
    e - 05, r
        e
    f ref
    r
        e
    s
    l
        t, _params);


    che
    b
        x, 
    .81334
    6
        - 04, re
        f
    t ref r
        e
    s
    u
        t, _params);


    uc
    eb(x 4.6
    70 5e-0
    4
        ref t j,
        r
    e
        lt, _
    p
        a
    r
        ms );


    che b
        x, 

    .83
    1 - 04, ref j
        sult, _ ar ms;
    uc eb x, . ef tj, e
    j 1, ref re
        s
    lt _
    p
        ra m
        u
    4, re
        f
    t j

    ref tj1 , r l
        ,
    ams
        ;


    et r
}


/*************************************************************************
Tail(S, 5, 100)
*************************************************************************/
private static double utbln5n100(double s,
    alglib.xparams _params)


d
    ub l
res t = 
do
    ble
        x
d
    o
u
    b
e
    tj = 0;


d
    ubl
tj
1
    = 0;
resu
l
    t
        =
        M
a

t
    .
    Mi n(s

-0.000000
e
00 )/ 3
00 0
e
00 -
    , 1.0)
;
tj j
1 = x;


u he,  -3.8
7
940e + 0 0,

r
    e
su lt, _params
    )


uc
hb(x - 4.03
9
24e+0 0, r
    e
f
    resul _para
    m
ucheb(x, -1.022243e+00, ref tj, ref tj1, ref result, _params);
ucheb(x, -2.305825e-01, ref tj, ref tj1, ref result, _params);
ucheb(x, -7.960119e-02, ref tj, ref tj1, ref result, _
arams)


uch
    e
b(x, -
    .
11 f tj,
    r
ef tj1, 
ref res
    ult, _param
ucheb
    x,  -1.
3
80 , r
    f
t
    );
u
    ce 64e-03 ,
t,
p
    r
a
    c
e
(x -
 9. 17 5
2
0
ee ref t j1, re
f esu
l
    t


61 7e - ref t
    j
1
    ,
    ref result,
_
    ara
s);
ch eb,  -3 01 er j, re
f j, 
ref rs ul,
    _
ara
    s);


cheb(x,
    -1 ref
    t
j
    ,
r
ef tj1,  ref
    r
    sul,
    _
ara
    s);


cheb(x,
    1. ref t
j
    ,

e
f tj1,  ref r
    e
ult
    _
p
    ram
    );


u
heb(x,
    2
.4 ef tj,
    re
tj1, r f resul _p
ra
    m) ;


u
heb(x,
    4.18659
1e -
    tj 1,
r
    e
f
    r
esut _
p
ra s
    ;


u
    c
eb(x, -2 6
5
    ,
    ,
    ref
1 result, p
return
    esu l
    ;


}


/*************************************************************************
Tail(S, 6, 6)
*************************************************************************/
private static double utbln6n6(double s,
    alglib.xparams _params)
{
    0;


    doube
        = 
        ;
    d o
    ble tj =
            0
        ;
    uble
        t
    j
    1
        =
        0;


    re
    ul
        t
            = 0


    x =
        M
    th.Min(
        2
    ) / 2.83 0
    7e + 0 0 - 1, 1. 0);


    tj
    1;


    t
        j
            = x;
    - .
    05 40 5e+0 , ref

    j,
    ef
        j1, 
    ref
        esu
        t, _pa r
        a
    s);


    , -.9
    98 0
    e + 00 re t
        j,
        rf t 1
    r
        e
    re
        ur;
        , -
        f tj1, ref result, _params);
    ucheb(x, -1.067578e-01, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.709435e-02, ref tj, ref tj1, ref result, _params);
    ucheb(x, 9.952
    61e-04
        ref t
        , ref tj1
        ,
        ref r
        s
    ul
        u
    heb(x,
        3.641700e-0
    r s
    l
        t

    e
    (
        x
    re f j,
        ef
    t1 ,ef result, _pa
    ams
        ;


    x, 3.
    3
    2
    e
        j 1, re
        f
    re
        s
    u
    l
        t, _rams);
    u
    ch eb,  4
        .ef t
        j
    _p as);


    u
        h
    eb(x, 5.4018
    9
    e - 0
        ,
    r
    f t, r
    e
        tj,  ref
        r
        sult, _
    p
        ar

    u
        c
    e
    b(x, 2.24614
    8
        - 03
    r
        e
    tj
        re
    f
        tj1
    ref r
        e
    ult, _p
        a
    ra
        u
    c
        h
    b
        (x, -1.44266
    3
        - 03
    r
        e
    tj
        re
    f
        tj1
    ref r
        e
    ult, _p
        a
    r
        u h
        e
    b
        x,  2.502866e- 03 ,
        ref
    , r
        f t
    1,
    r
        f r
        sult, _p a
        ams);


    (
        ,
    -.105855e-0
    et ef
        j1, r s);


    eb
    (
        , -
            .73
    9
    71e
    04, re
        tj1 ef r es ul t,
        _
    a
        rams);

    r
        tu
    r
    reu lt;
}


/*************************************************************************
Tail(S, 6, 7)
*************************************************************************/
private static double utbln6n7(double s,
    alglib.xparams _params)
{
    d
        ob le r
    su t


    ou le x
        = 0
    le tj = 0;


    oub
    e tj = 0


    re u
    l
    t
        x
            = Ma t. .00
    00
    0
        + 00
        / 3.
    0
    000
    e + 00 - 1. 0)


    j1 =
        uc eb x, 
    3.2652
    8
    e + 00
    ef r s
        u
    l
        t
    p rams);


    uc
    eb(x, -
        32 74613
    e
        +
        ef tj ,
    r ef resu t, _paa s)


    u
    heb
        j1, re
    resul t
    ucheb(x, -1.334293e-01, ref tj, ref tj1, ref result, _params);
    ucheb(x, -2.915502e-02, ref tj, ref tj1, ref result, _params);
    ucheb(x, -4.108091e-03, ref tj, ref tj1, ref re
    ult, _
        arams)


    uch
        b
    (x 03, re
    f
        tj, re
    tj1, r
    ef result,
        u
    heb(x, 2
    8
    sult,
    pa
        a
    s
        )
    eb(x, 891
    0
    e
        -
        tj1,
    e
        r


    u h
    e
    b
    (
        x, 4. 1371 e
                   - 03, ef t, ref t j1
    r
        e
    re
        s
    u
        x,
        .
    8
    9
        ref t
        j, r f re ult, _p ar s);


    (
        x
    3.9 459
    4
    e
        tj,
        r
    e
        f
    t
        j1,  ref resu
        l, _
    ar
        a
    s);


    uch
    e
        (x, 1.0
    6
    23 tj, r
        e
    f
        j
    1, ref resul
        t
    _p
        ra
    m
        );


    uche
    b
        x,  -1.1
    5
    88 tj, r
        e
    f
        j
    1, ref resul
        t
    _p
        ra
    m
        );


    uche
    b
        x,  -1. 9
    6
    4
        ref
    t
        j1, e
    f res lt, _par
    a
        s);


    u
        c
    eb(x - 1.18
    56 2e-03,
    r
    er
        tj1,  ref e lt, _;


    e
}


/*************************************************************************
Tail(S, 6, 8)
*************************************************************************/
private static double utbln6n8(double s,
    alglib.xparams _params)
{
    do
        ub l
    r
    e
        ult
            = 0
        ;
    do
        u
            b
    e x = 0
        ;


    j = 0;

    do b
    le
        j1 = ;


    r
    su lt = 0


    s - 0 00
    0
    0
    0
    e + 00 / 3.09838 7e 0 - 1
    1
        .) ;
    =

    ;


    c
        h,  -3 450954e
        +
        0,
    eft 1, r
    e
        result,
        _


    ucheb(x, -3.
    5
    046
    e + 0 0
    re tj,
        ef
    j1, r f
    r
        su lt _pa
    r
        a
    x 4
    2
    299 e - 1,
    tj
        re
    f
        tj1
    ref r s, _p r
        uch
    b(x, -
        1.604853e-0 ref tj, ref tj1, ref result, _params);
    ucheb(x, -4.165840e-02, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.008756e-02, ref tj, ref tj1, ref result, _params);
    uche
        (x, -6
    723402
        - 04, ref t
        j,  ref
        j 
    1, _para
        m
    s);


    ucheb(x, 1
    tj ref j1, re

    e
        su;

    83 40 5e - 0 , ef
        t,
        lt _pa ms) ;


    , 3.7 20 9 - ,
    rf t j, r f tj1,
        r
    e
    f
        result, _ pa am
    s
        )
    ;
    u h
    b(x
        , 4
    re
        j, re s
        l,
        u
    h
    eb(x, .948034
    e
        ,j ef tj1, 
    ref resu l

    u
        c
    h
    b
        (x, 2 .7 6243e-
    0
        , re f, j1, re
    f
        result, a );


    ucheb(x
        ,
        8.6
    37
    3
    e - 0
        , r
        e
    tj
        ref t
        j,  ref r
        e
    su;


    ucheb(x,
        3.7
    20
    6
    e - 0
        , r
        e
    tj
        ref t
        j,  ref r
        e
    su;


    ucheb(x,
        9.7
    69
    2
    e - 0
        , r
        e
    tj
        ref t
        j, ef re
        s


    re ur n result;
}


/*************************************************************************
Tail(S, 6, 9)
*************************************************************************/
private static double utbln6n9(double s,
    alglib.xparams _params)
{
    dou l
    e


    double x = 0
        ;


    oub e j =
        0;
    do
        b
            l
    e
        r
    e
        s
            = 0;
        = Ma th Mi n(
        *(s
          -
          .000 00 + 00) 31 81 81e+ 0
        -
        1
    tj
        =
        1
    t
        j
            = 
        ;


    uc
        h
    b(x
      - 3. 1611 + 0 0, ref j
        ,
        ul, _
    p
        a
    rm s) ;


    uc
    eb(x
    3.71 650
    e
    00,
        ref tj
        ,
        ref tj1 ,

    r
        pa ams
        )
    ;


    uch(044
    8e - 0 1, r f tj, r
    e
        t j1 ref e


    uchx - 1
    e - 1, e f
        j,
        ef tj1
        ,
    rel );

    c
    64e-02, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.632286e-02, ref tj, ref tj1, ref result, _params);
    ucheb(x, -3.266481e-03, ref tj, ref tj1, ref result, _params);

    uch
    b(x, 1
    280067e-
    0
    3, ref
    t
        j, f resu
    l
        t, _par
    ms);

    u
        e
    f
        ref r
        t
    pa
    ch
        bx,  38 e - 03 re f tj r f, _ ara ms;

    x
        . 59 20
    0
    e - 0
    3, f j
    1
        , ref re sult,
        _
    p
        ram
    s
        )
    b(
        .
    5
    j, r
        j
    1, _par
        a
    m
        s
        ;


    u
        heb
    3
        .
    23
    3,
    r f t
        ef t 1
        ,
        ref r es l
        t,
        ucheb x
        ,
    2
        .
    471
    4e - 0 3 re
        tj, ef t , r f r
    e
        ult, _p
    a
        r
    uc
        h
    e
        b
    x1 535
        - 03
        ,
        ref
    tj, re
    f
        tj1, re
    f
        r ms);


    ucheb
    (
        , -
            .0
    9
    185
        - 04
        ,
        ref
    tj, re
    f
        tj1, re
    f
        r ms);


    retur
        n
    res
        lt
        ;
}


/*************************************************************************
Tail(S, 6, 10)
*************************************************************************/
private static double utbln6n10(double s,
    alglib.xparams _params)
{
    double
        re


    do u


    ble tj
        =
        ou le t
    j
    1

    0;


    r es l
        = 0


    x Ma h.Mi
        n
    2 * (s - 0.00
    0
    0
    7e + 0 - 1 ,

    1
        .
        );

    = 1 tj1 x;


    u ch eb(x
        ,
        r ef t, r
    e
        f
    t
        j1,  ref re u
    lt, pa ra );
    heb
        x,  -.94
    2
    66e + 0 0 ref t j1 r e
        result, _par
    am );


    u
        ce b(,
        -9 9398
    9
    e - 01 re
        f

    r su t, _params);


    he
    b
        x, 
    2.1378
    1
    e - 01, r
        e
    f
        ref r s
    lt _pa ra s);


    u
    heb
        x, 
    -
        .72
    270e-0
    2 re t j, r
    e
        f
    su t, _p ams);


    ucheb(x, -2.281070e-02, ref tj, ref tj1, ref result, _params);
    ucheb(x, -5.901060e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 3.824937e-04, ref tj, ref tj1, ref result, _p
    rams);

    uch
        e
    b(x, 2
    8
    02 tj, r
        e
    f tj1,
        ef resu
        lt, _params
    ch eb(x
    3 2581
    tj1,
    rf
        e, ar
    ms
        ;
        , 3. 3
    536
        -
        3
        ,
    j1, r ef e _a r
        ms);


    uc eb(x, 3
    .08 5
    3
    0e - 0 , re
    t
        j,
        r
    e
        t
    j
    1
    pa
        a
    s
        )
    b(
        ,
        3
            .ef tj
        ,
        r
    tj1, re f e
        s
    ulr ms
        ;
    ucheb
    (
        x. 3, ef

    t
        j
    r ef tj1, r ef e t,
        _pa
    ra s);


    uch
        e, ef
    r
        e
    ult _param
    heb(x
        ,
        1
    0
    35298e-03, r
        e
    tj
        r
    e
        tj, r
    e
    re
        ult, _
    p
        rams);


    urn r
    e
        s
    u
        t
        ;
}


/*************************************************************************
Tail(S, 6, 11)
*************************************************************************/
private static double utbln6n11(double s,
    alglib.xparams _params)
{
    d o
    u
    le x = 0;


    oub
        e t
        j = 0;


    s lt
    0;
        = Math
        .M
        )/ 3. 6625e+00 - 1 , )
    j =
        1


    j1 = x;


    -3.8 98 9
    7
    e
    00, re f tj, re
    f
        tj1
    r
        e
    r es u
        _p a
        r
    ms)

    che b(,

    f tj, r f
        j
    1, r ef result,
        par
    ms
        )


    che
        (x, -1 .0 297 + 00, e
    f
        resu lt
        _
    a
        rams) ;
    u ch eb
    (
        , -2
    396852
    e
    01, r ef t
        j,
        es ul ,
    _
        p
    a
        a
    ms);

    u ch
    b(
        x
        - 79 901
    2
    e - 0
        , ref
    t
        , ref t
        j
    1
    arams
        ;

    uch(x, -2.927977e-02, ref tj, ref tj1, ref result, _params);
    ucheb(x, -8.726500e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, -5.858745e-04, ref tj, ref tj1, ref result, _param
    );


    ucheb(x
        ,
        2.654
    9
    0e ref t
        j
    1, ref
    esult,
    _params);

    x, 3.2 73 6e 03, e
    t j, f re su t
        p
    ra m


    9770e - 0
    ef
        t,
 
        ,
        para
    s
        ;


    7
    6
    8493e - 0 3, r f
        tj, 

    ref tj1 ,  ref
        re lt,
        _p

    u
        f t j e
        tj1,  ref r es l
        t
    pa
    am
        s
        ;


    cheb(x, 3 140215e
              -
              0
    1, re
        f

    r
        s
    u
        lt, para s
        )
    ;


    he
        ,
    2
    6471 4e 03,
    r
    f tj, rt 1, re
        f

    r
    s
        ult, _ arams);

    u heb(1.
    2482 e
    03, f j1, e
    f
        r
    su lt, _params)
    ;


    ret
        u
    n r
        sult;
}


/*************************************************************************
Tail(S, 6, 12)
*************************************************************************/
private static double utbln6n12(double s,
    alglib.xparams _params)
{
    d
        o
    u
    0;


    doubl
    e
        x = ;


    ouble t
    j
        dou
    b
        l
    e
        tj1 = 0;


    res
        lt =
            x
                =
                Math.Mi n(2 * (
    ) / 3. 7
    1
    70 9
        + 0 1,
    ;


    tj
        = 1;


    cheb(x, -40 2
    941
        + 0
    0
    re
        tj, r f t
    1, re
        ms );


    ucheb(x, 4
    294
    50
    e
    00,
        ref

    j, re tj1,
        r
    f resul
        t,
        u
    ch eb x,  -.12 88 2
    e
        + 0 ,
    re f, r tj
        , re
    esu
        t, _ para
        m
        );


    65038
    9
    e
        -
        ref j, re
        t
    j1
        ef r ult _pa
        am s)


    u
        c
    eb(x, -
            9
                .
        , ref
        t
    j
        ef r sul t, _
    p
        ar m
        );

    uc he(
        ,

    -
        .57 8
        ref r
        sult,
        _
    ucheb(x, -1.162852e-02, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.746982e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 2.454209e-03, ref tj, ref tj1, ref resul
        , _par
    ms);


    ucheb
        x, ,  ref
        t
        j,  ref
        j1 ,  ref
        result , _p

    03, re
        j
    r e
    _para
        s)


    b(x, 2. 5
    ef t j
        f
    t
        j
    p
        rams
        )
    ;


    ucheb(x,
        2
            .
    665192e-03, re fr t1,
        fr am s)

    x, 2. 9
    4
    14 -
        03, ref tj,
    r
        f t
    1, re sul
    t
        _ pa ra ms)
    ;


    eb(,
        2
    .6 2249e-03 , ef
        t, r
    f t j1 re
    re
        s, a ms);
    x, 2.
    3
    6
    8
    4
    1e-03, ref t
        j
    re
    t
        j, re res
    u
        t,
        pa
    esult
        ;
}


/*************************************************************************
Tail(S, 6, 13)
*************************************************************************/
private static double utbln6n13(double s,
    alglib.xparams _params)
{
    doubl e r
        e
    ult 0;


    d
    uble x = 
        ;
        = u tj
        = ;


    x = Mat
        .Mi
        (2
            *
            s - 0
    e
    00)/3.4
    2
    0

    t
        j
            =
            1


    tj 1 =
        x;


    u ch b(x, -46 e
                  + 0 r ej, ref tj1
        ,
        ref
        su l
    t
        _p
    rams);


    c
    e + 0, e t j, re j
    1, ref
    rs lt
    _pa ra s);

    8e+00
        ,
    r ef tj, ef t 1, re
    re lt,
        _pa
    ams
        )


    che b(x
    -01, r ef t,
        ef tj1, r f
    re su t, _ ar
        a
    s);


    cheb(x
        ,
        -1.0502
    4
    9
    tj1, r ef r
    su t, _p rams;


    u
    heb(x - 4
        .
    269 01 - 02, r
    e
        tj, re
    f
        params );
    -471113e-02, ref tj, ref tj1, ref result, _params);
    ucheb(x, -3.007470e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 2.049420e-03, ref tj, ref tj1, ref result, _params);


    cheb(x
    3.059074
    e
        - 03, r
        f
    t ref re
    s
        ult, _p
    rams);


    1249e-
        ref t
        ,
    r
        e, _
    cheb(x
    24 5
    03, r
    f tj,
        t
    j
        _param;

    (
        2.4
    4
    180 5e 0
    3
        ,

    r
    ef tj, r tj1,
    r
        e
    f
        su lt
        _


    u 749
    e
    0
    3
    1, re
        f
    r e
    _p
        ra
    m
        );


    u
    heb(x,
        2
    483957e
        -
        03 f tj1, r
    e

    resul t, _param
    s
        ;


    u
        c
    eb
    2.4815
    9
    e - 03, re
        f

    f res
    u
    l
        t,
        _
            params) ;
}


/*************************************************************************
Tail(S, 6, 14)
*************************************************************************/
private static double utbln6n14(double s,
    alglib.xparams _params)
{
    d
        uble re
        s
    ul
        d
    uble x = 0;


    d
        ubl
    e
        tj
    0;


    d
        o


    r su lt = 0;


    x =
        ath
            .
            (2
                (s - 0. 00
    0
    00e+00)4 000e
        +
        00 , 1.0)
    tj
    1;


    t 1

    uche(x - 41 00
        ,
        ref
        tj, re
    f
        tj1, re
    f
        ch eb(x, -4 .5425
    6
    e + 0, r e
        f, re tj 1, f t, pa am s
        ub, 
    1.2 2
    5e 00,

    ef
        j, re f t
        j,  ref re ul


    ucheb(x, -
        3
    046
    e - 01 ref
    tj,

    ef
        j1, re
    f esul t, _
    p
        a
    u c -
        .13
    r ef tj1, 
    ref res
        u
    lt
        uc eb(x, -4.78
    6
    57 e - , r t j, ef j
        , re res lt,
        pa ra s);


    (x, -1
    84 37 48 e - 2, ref tj, retj1, ref result, _params);
    ucheb(x, -5.588022e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 2.253029e-04, ref tj, ref tj1, ref result, _params);
    ucheb(x, 1.667188
             - 03, r
    f tj,
        ef tj1, r
        e
    f resu
        t,
        uche
    (x, 1.7
    88330e-03,
    ams );


    e - 03
    ef
        t,
        u
    (
        x
            t
        ,  ref t jf l
        t, _params);


    .9
    18 8
    tj
        ,
    r
        e
    m
        s);


    che
    (x
        ,
        1.8 63 23e-, re tj, e tj1, ef
    );


    e
    (x
        ,
        2.2
    4e -
        0
        , r
    f tj,
        r
    j1, ef r


    return res
    u
        t;
}


/*************************************************************************
Tail(S, 6, 15)
*************************************************************************/
private static double utbln6n15(double s,
    alglib.xparams _params)
{
    oub
        l
    re
        ult =
            0
                = 0;


    doubl
        e
    tj
    0
        ;


    ouble
        t
    1 = 0;


    t = 0
        ;

    x = Ma
    t
        .Mi
        (2
            *
            s - 0
    00 00 0
    0
        + 00
    .4500
    0e + 00 - 1,
    1
        .tj = 1;


    t
    1 = 
        ;


    ch b(x,
        -
            j1, refr sul, p

    ch b6 e + 00 , ref tj
        ,
        ref
    1, r
    res
        lt,
        par
        );


    uc
        h
    e
    7r
        ef

    j1
        f r
        e
    ult
    _para ms;

    75035
    e
        -
        0
        , ref tj, re f, r
    e
    re s, pa ra ms
        )


    848 e0 1, ref tj, r
    e tj,
        re
    f
    res
        lt,
        par a
        ;


    uch
        e
    bx - 02,
    r
        e
    f
    t
        j,  ref tj1 r
    e
        re
    ul
        t
    _p
    ram
        s
        ;


    u
    heb(x,
        -2.
        , re f j
        , ef r
    e
        m;
    ucheb(x, -8.298720e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, -2.766708e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.026356e-03, ref tj, ref tj1,
        ef res
    lt, _p
        rams);


    u 93113e
        -
        04, ref
    tj, ref
    tj1, ref r
        ;
    u
    c
        - 03, r ef t,
        r
    e
        lt, _
    ar a
    uc he b(x, -1.
    3
    3
    7
    tj1 r
    f
        m) ;


    uh b
    (
        x, -8 .1 9087 e
        - 0
    4
        ,
    e
    res l, 

    (x,
        -
            4
                .
    3
    5972e 04, e
        f tj ref j1
        ,
        ref
    re u
        l, s );


    (x, 1
        .
    4
    1
    1
    29 - 04, ref t ,
    re tj
    e
        f
    res
        lt,
        p ar m
        );

    lt;
}


/*************************************************************************
Tail(S, 6, 30)
*************************************************************************/
private static double utbln6n30(double s,
    alglib.xparams _params)
{
    d
        o
    ble
        re
    s
        lt
    0;


    ouble x
        =  do
        u
            b
    l
        tj = 0;


    d
        ubl
    tj
    1
        = 0


    r
    e
        su
            = Math.Min(
                2
                (s -
                 .0
    0
    000
        + 00
        )
    3.4
    0000e+ 0
    1, 1. );


    1;

    tj1 = x;


    uc
    (x
        ,
        -4.1 6269e+
    0
        ,
    su
        l,
        ms
    u h
    e
    00, r
        e
    f
        j,  1 ,
    efe su t, a;

    18239
    e
        +
        0, r ef tj,  ref t
        j, r
    f
    r
        sul,
        _a r
        ms);


    .
    3
    0847e - 0 1, ref t
        j
    re
    t
        j, r f
        re u
        l, _
    arams) ;

    b ,
    -
        7
    .4 58 85e-02, ref

    j, r f
    t
    1, r
        f r
        e
    ult _pa rm s
        ;


    -3.0
    2
    5
    0
    1
    e - 02 , re t j, re
    f
        tj1
    r ef esu, _p r
        ms)


    u - 1.1871 7
        ,ef tj1,  ref result , _params);
    ucheb(x, -4.432089e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.408451e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, -4.3
    8774e-
    4, ref
    tj, ref t
        j
    1, ref
    r
        es );


    ucheb(x
        , -2.795560
    tj1,
    ef r sul,
        _
    p
        cheb
    x

    0
    j
        ,
    r params
        ;


    e
        j, r f
        tj,
        r ef r
    e
        s, pa am
        s
        )
    ;

    05 , e t
    ult
        _ a
        r
    u
        c
    h
    e
    (
        x, -4.3886 7
    9e
        -
        6,
    ef
        j,
        ef t j1 ref resu lt _pa ams)
    ;

    eb 4
        .
    83
    6
    27e
    06
        ,
        ref
    tj,
    r
    f tj,  ref r ult, _p
    a
    r
        result;
}


/*************************************************************************
Tail(S, 6, 100)
*************************************************************************/
private static double utbln6n100(double s,
    alglib.xparams _params)
{
    d
        ubl
    r
    e
        ult
            = 0
        ;


    double
        x
            = d
    o
        u
    b
    e
        tj = 0;


    oub
        e t
        j
            = 
        ;


    r
    es
        x = Math.Min
        (
            *(s
    0.
    0
    000
    e + 0
    0
        / 3.
    50000e
        +
        0 - 1, 1.
    0
        )
        = 1
        ;

    tj 1
        = 
        ;


    uch
    e
    (x,
        -4. 18 135
    0
        + 00 ref

    t
        esult, _ ara
        s)

    c4 , re
        f
    t re1,
        r
    f e
    ul
        t ar a;


    -9420 1e + 00, ref t j
    ef t
    1,

    ef
    esu
        l, _ pa rm s);


    , -2.
    1
    9
    5
    83e-01, ef tj, e j
    1
    re f est _pa ams );

    (x - 6
        .
    8
    19 37 - 02, ref t j,
        ef
    j1
        ,
        ref
    res
    u
        t,
        ams);


    u
    e - 02 rf tj, re f j
    1
        ,
    r
        f r e
    r
        ms);


    uc
        h
    e
        sult, _params);
    ucheb(x, -3.022148e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, -7.284181e-04, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.157766e-04, ref
        tj, re
    tj1,
    ef result,
        _para
    s
        );
    ucheb
    (
        x, -1.0
    3752e-0
    4, ref tj,
    lt _pa
    ams );


    .1 7985
        -
        4

    r
        f esul t, _p
    s
        )
    he b
        j,  ref
        t 
    1
        ,
    m
        )

    u
        c
    h
    eb(x, -.51617
    9
    e
        - 06, ref t j, r
    e
    f
        j1,
        r
    ram )
    ;
    heb
        , ref

    t
        j

    ref tj1 ,  ref re ult, _p
    a
        ams );


    f tj,
        r
    f
        tj1, r ef r
    e
        s
    u
        t, _a r
        ms)


    re
        t
    rn resu
    l
        t;
}


/*************************************************************************
Tail(S, 7, 7)
*************************************************************************/
private static double utbln7n7(double s,
    alglib.xparams _params)
{
    ouble
        r
    e
        o
    ub e x = 0;


    do
        ble
            j =
                0;


    d
    ou
        result = 
        ;


    x
        Ma
    h.Min(
        2
            (s - 0.00
    0
    00 495e+
    0
    0
        -
        , 1.0);


    t
        = 
        ;


    t
        j
            = x;


    b(x,
        -
            3
                .
    01264e+00
    re
        f
    tj
        ef,
        ef
    r
    su lt,
        _para s) ;


    58479 e
        +
        0
        , re f tj,  ref


    1
    1
    e -
        0
    re tj
    c b(,
    -1.
    170
    0
    e - 0
        , ref tj ,
        ref tj1
        ,

    h b(x
    -.1 40 ef
        t
    j
        esul,
        _ pa ams);


    uc
        h
    b(x
      - 1
          .
    234
    r
        e
    _ a
    ra ms;

    ch b
        x, 
    1 .0 25
    1
        - 03

    sult,
    para ms;

    ucheb(x, 8.626515e-04, ref tj, ref tj1, ref result, _params);
    ucheb(x, 2.072492e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 3.722926e-03, ref tj, ref tj1, ref result, _para
    s);


    ucheb(x
        ,
        5.095
    4
    5e ref t
        j
    1, ref
    esult,
    _params);

    4.84 26 e - 0 , r
        ft j
        sult,
        p
    r
        m
    s
    eb(x, 2. 51
             - 0 3
        ref rs ul,
        _
    a
        r


    u 8
    2
    e - 0 4, r
    ef j, re
    t
        j1 ref r es l
        t, params );


    43
    e
    0
    4
        , e

    l
        (x, -8.7723
    8
    e - 0
        , ref
    t
        ,
    _par
        a
    m
        s
        ;


    etu
        n r es lt;
}


/*************************************************************************
Tail(S, 7, 8)
*************************************************************************/
private static double utbln7n8(double s,
    alglib.xparams _params)
{
    do ub re ult = ;

    0;


    b e
    tj
    0;

    tj
    1
        =
        r
    e
        s
    l
        t = 0;


    x
        Ma
    h.M
    i
    (2 *
        s - 0.00
    0
    00e+00)
        /
    3. , 1.0
        )
    ;


    tj

    1;


    j1
        x;


    uc 9965e
        +
        0
    0
        ref tj, ref
    t
    1,
    ef

    esu
        t,
        _
    am
        );


    uc
        h
    e
    0, re
    f
        t, 
    ref tj1 , re f
        r
    sult _
    p
        rams;


    x, 01 , tj, ref t
        j1, 
    ref
        re ul, _


    h 195e-
    0
    1
        ,
    r
        e
    f j, re f f r
    e
        ul, a )
    ;


    , -5.4 39 9
    9
    e
        - 02, ref t j, re f j1,
        ult,
        _ a
        u ch eb(x
    -1.678028
    e
    02,
    ef
        j,
        ef t j1 ref resul t, _
    arams);


    h
        e
    b
        x,  -4. 48 54 0e-03,

    ef
        j,
        e f t
    1,r f re ult, _p
    ar ms);


    x,

    r tj,  ref tj1 ,  ref result , _params);
    ucheb(x, 1.440092e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 3.114227e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x,
        .51656
    e - 03,
    ef tj, re
    f
        tj1,
        e
    f ams);


    uche
    b(x, 4.8294
    r ef tj1,  ref r su
    _
        p
    uche
    (
        3
    7
    87 tj , re f,
        e

    r
        uc e
    (
        ef t j, r
    f
        t
    j
        a
    s);


    u heb(x
    1.9 1
    911 e - 4, r f tj,  ref t
        j, r
    e
        f
    _
        p


    u
        c
    e - 0 ,
    r ef t
        j,  ref tj1 , r f
    ara ms;


    esul t;
}


/*************************************************************************
Tail(S, 7, 9)
*************************************************************************/
private static double utbln7n9(double s,
    alglib.xparams _params)
{
    0;


    do ub e x
        =
        0


    oubl tj
    0;


    d
        resu
            =
            ath.Mi
    n
    2 * (s - 0.
    0
    00 34314
    e
        +
        0
        -
        1, 1.0);


    j =
        1;


    t
    1 = x;


    eb(x,
        -
            3
    8
    96550e+00, r
        e
    tj
        r
    e
        tj, r
    e
    re
        ult, _
    p
        rams);


    eb(x,
        -
            4
    1
    1267 e + 00, r f
        j, r f
        t
    1,
    ef r e
    s
        lt, pa rams)
    ;


    37277
    e
        + 0 0
        ref tj, t esu
    l
        _p
    rams);
    (x, -2 1
        - r t 1, ref
    result
        ,
    _params)

    6
        -
        0
        , re tj, ef
    j1 , ref
    r
        sult, _ pa ra m
        -
        2
    36
    12 ref , re f, re su lt, pa r
        a
    s
        );

    u
    b(
        7
            .
    96
    e - 0
    3
    re
        tj, r
    e
        tj1, r
    ef e s);


    uc eb(x
    -1 .7 0578 - 0
    3 re
        j,
        r
    f t
    1, ref

    esu lt, 


    .3843e-04, ref tj, ref tj1, ref result, _params);
    ucheb(x, 2.616148e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 3.852104e-03, ref tj, ref tj1, ref result, _params);

    uche
        (x, 4.
    90744e-03,
        ref tj

    re esult,
        _params
        ;

    uche
    03 ref j, r f tj,
        re f
        ;


    uc 10 1e - 0 3, re t,
        r
    e
        _par m
        );


    74 74e-0
        ,
    r
        e
    f
    r
        sult,
        _pa ra s
        )
    ;

    u
        c
    he b(,

    4. 04611e- 04
    r
        e
    f
    t
        j, r et ,
    re fr ms);

    ult;
}


/*************************************************************************
Tail(S, 7, 10)
*************************************************************************/
private static double utbln7n10(double s,
    alglib.xparams _params)
{
    double

    esu
        t
            =
            dou le x = 0
        ;
        =


    d
        ub
    l
        tj
            = 0;

    lt =
        0
        ;
        = M at h0 00)/3.
    4
    5650e+0
    0
        - 1


    j
        = 1;


    tj
    1
        = x


    uc
        h
    b(x, -4
        .
    06 f tj,
        r
    e
        tj1,  ref res
        u
    t,
    pa
        r
    ms)


    uc
        h
    b(x, -4
        .
    34 f tj,
        r
    e
        tj1,  ref res
        u
    t, _ ar
    a
        s);


    ucheb(x, -1.118 88 e
                       + 0 ef tj1, r
    e

    resu t, _para m
        s
        ;


    u
        c
    eb(x - 2
        .
    4
    tj, ref j1
        r, a
    ams);


    c heb8 9
    7
    81e- 2, re fr t 1
    _p ar am s)
    ;


    u ch e
    b(
        x
        - 3
    05
    7
    88 e - 0
    ef

    e j1,
        re fe ram
    uch
        x, 
    974
    6e-
    0
        , r
    f tj,
        r
    f t j1 re
    f


    uch e,  3. 092
    6
    e - 0
        , re f tj
        r
    f tj1 r
        e
        ;

    uc h
    eb(x, 4.0651e-04, ref tj, ref tj1, ref result, _params);
    ucheb(x, 2.196677e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 3.313994e-03, ref tj, ref tj1, ref result, _params);

    ucheb
        x,  3.8
    7157e-03
        ,
        ref t
        ,
    r result,
        _param
        );

    uch
        - 03, e f t
        _p aram
        )


    3.3 909
    3
    r f

    r esult
    _p
        r
    m
        s
    b(x, 2
    3
    0
        ref r
        e
    sul
        t, _ a
        r
    a
        ms);


    ucheb(x, 1 .3 95 17 e
    03,

    r
        ef e
        t

    r
        e
}


/*************************************************************************
Tail(S, 7, 11)
*************************************************************************/
private static double utbln7n11(double s,
    alglib.xparams _params)


d
    o
b
le result =
    0

doub
le x = 0;


tj = 0
    ;


u
    ult = 0;


Math.i
n(*(s - 0.00 00 0
e +
    0 - 1,
    );


tj1 = x;


che
b
    x, 
4.2177
9
e + 00, r
    e
f ref
r
    e
s
    lt, _params)
;


uch
e
(x,
    -4.549
7
3e+00,
r
    ef,  ref
    r
    e
ult, _params
    )


uc
    h
b(x
  - 1.19
5
05e+00
r
    e
ref r
    e
su lt _para s) ;


che
(x, -
    2
733
e - 01,
e f tj, r
e
f
    result, _par
a
    s)
uch
    e,  9. 28 42 j,

r
e
    tj1, f
rt _p
rams)
;

60093
e
    -
    0
    , ref j, r
    e
f
    t
1, r
    f r e
ult _p ar
    a
s);


uche
    b
    (
        ef j1

r es,
    _p
    ;
x, -4
    .
7
1
1
52e-03, r f

tj
    ef j 1, r
    );

199e 0
    , ref
t
f result, _params);
ucheb(x, 1.832423e-03, ref tj, ref tj1, ref result, _params);
ucheb(x, 2.905979e-03, ref tj, ref tj1, ref result, _params);
ucheb(x, 3.302799e-03, r
f tj,
    ef tj1
    ref res
u
    lt, _p
r
    am uc
    h
eb(x, 3
464371e
    - 03, ref tj
    ult, _
arams)


x
    ,
f tj, r f
    r
ams);


24 4e - 0 , r
    f
t
    j
e
    _p r
    a
ms );


uc eb(x,
    2. 14 0712e-03, re
f
    t, re f t
_p
    )
;
re
    ;

}


/*************************************************************************
Tail(S, 7, 12)
*************************************************************************/
private static double utbln7n12(double s,
    alglib.xparams _params)
{
    d
        o
    ble
        re su t = 
        ;

    l e
        x
            = 0;


    do
        ble
            j =
                0;


    oub
        r
    e
    u
        lt = 0;


    M
        a
    Mi
    (2 *
     (
         -0.
    00000e
        +
        0) 3.500
    0
    0


    tj = 1;


    1
        = x;


    uche
    b
        x,  -4.23
    5
    8
        ,
        ref
    re
    s
        lt,
        _pa
    r
        ms)


    uc
        h
    eb 0e+00
        ,

    r
    f tj,  ref tj 
    1
    re
        r
    e
        ult
    _p
    a
        ams
        ;


    u
        c
    he 13e+0
    0
        ,

    ef tj,  ref t
        j, r
    f
    r
        sul, _
    p
        ram
        );


    u
        ch 546e-
    0
    1
        ,
    f tj, r f
        tj
    1
    ef
        re
    s
        lt, _ ara
        m


    ucheb(
        x
        ,
        ref t j
        ,
        r
    f tj1, r par
        ms)
    ;

    u c,  3.967 5e - 0 , ref tj, r
    e
        tj,
        r
    f rs u
        a
    ucheb x. -0
        ,
    r
    f j, re f, ef r
    e
        s


    ucheb(x, -8.3
    0
    144
        - 0
    3
    re
    t j, r
    f tj 1r su l
        u
    c
        he
    b(, -
        .9 0
    3
    98e
    03,

    ef j 1, re
        f

    s);


    ucheb(x, 2.134906e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.175035e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, -7.266224e-04, ref tj, ref tj1, ref result, _params);


    uch
    b(x, -1.
    8
    92931e
    0
    4, tj1,
    r
        ef resu
        t, _par
    ams);

    -
        0
        , ref
    e
        t _
        uch
    b(
        .
    0
    j
        params
        ;


    1
    701
    0
    e - 0 3, r
        e
    f

    t
        j, re f tj1, re
    f
        result, _ pa ra ms;
}


/*************************************************************************
Tail(S, 7, 13)
*************************************************************************/
private static double utbln7n13(double s,
    alglib.xparams _params)


o
    ublr s
ul
    t
        = 0


doub e x = 0;
    =
oub
    e t j
    =
    res
u
    t = 0;
h.Mi(2 * s - 0.000
0
0e+
0)
    /
.50
000
e
00 -
    , 1.0)
;


t 1 = ;


u eb
(
    , -4 222
0
e + 00
    ref t
    j
ref tj 
1
    ,
ams);


uche b
    x, 
5
33 00 +
    0, r
    e
tj
f tj1, 
ref res
    u
l
    uch
e
(x,
    -1
        .
646
2e+
0
    , r
f tj,
    r
f tj1,
    r
ef rams)
;


uc
    h
b(x
  -
  2
523
68e
    -
    1,
ef tj,
    ef tj1,

re arams
    )
;


u
    c
eb(
    ,
    -
        .53
984
e
02,
    ref tj
    ,
    ref tj1
    ,

arams;


uch
    e,  -
    .4
7e-
2,
r
f t,  ref
    t 
ref res l


uch
b(
    x
    - 1
483
80 e - 0r f
ref r
    e
s
u
    t, _params);


u c,  -6.5241 6
e
    ref tj1, re r e, _p ra s);
uc h
0e - 0 3,
r
e
    f,  ref tj1 , r
e re su lt _ p
a
    ams
    ;


uc
    h
b(x, -1
    .
7
    ref

f result, _params);
ucheb(x, -1.602085e-03, ref tj, ref tj1, ref result, _params);
ucheb(x, -1.828831e-03, ref tj, ref tj1, ref result, _params);
ucheb(x, -1.994070e-03,
        ref tj
    ref t
1, ref re
s
    ult, _
a
    ra u
    c
heb(x,
    1.87387
9e-03, ref
result
    aram )

eb(x,
    1
3
19 3

e
    f
    ;
c
    e
b
    - 04, r
ft j, f e
    res
u
    lt,
    _
p
    a
r
    a
ms);


re urn resu lt;


}


/*************************************************************************
Tail(S, 7, 14)
*************************************************************************/
private static double utbln7n14(double s,
    alglib.xparams _params)
{
    dou
        b
    e resul t
        d ou le

    x


    0;

    d
    ubl
        tj
        ;


    do
        u
            b


    resul t 0;


    x =
        Mat.(2 * (s - 0
    .0 0
    0e+00 -
        1, 1 )
    ;
    j =
        tj1
            = x;


    176e +
        0
        ref j, r ef t
    1, r
        f
    rs ul,
        _pa
    r
        ms) ;
    .5074 2
        +
        00, ref t ,

    re
        j1,
        re
    fr es l, _
    p
        ra m
        - 1.1 43
    6
    4
    0
        + 00, ref tj,

    ef
        j1, 
    ref
        res
        u
    t,
        params
        )


    -2.39
    5
    7
    5
    e - 01, ref tj
        ,
        ref
    tj
    1
    re
        re
    s
        lt,
        _param
    s
        ;


    -7.8
    0
    8
    0
    0e-02, ref t
        j
    re
    t
        j, r
    f r
    e
        ult
    _para
        m
        );


    -3.04 2
    5
    e - 02 ref tj, re tj, ef res
        lt,
        par
    ms);
    c
        h
    8e-r f
    t
        j
    r
    ff result, _
    uce(x - 4.
        - 03, re tj, re t j l
        t,
        pa as;
    uch
    b(x, -5. 7
    2
    255e - 0 4, r
        e
    f
        f res
        u
    l
        t
    _params);

    uc
    eb(,
        tj,
        arams);
    ucheb(x, 1.113148e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 8.102514e-04, ref tj, ref tj1, ref result, _params);
    ucheb(x, 3.559442e-04, ref tj, ref tj
        , ref
        esult,
        _params);


    .63498
    6
    e - 05, r
    f tj, r
    e
        _ pa am s)


    77647 6e
    0
        ,
    r
        e
    j1
        ef
        );


    c 489e-0
        ,
    r
        e
    ef t
    j
    1, r
        e
    f
        r
    e
    s
        ult, _par a
        m


    r
        n
}


/*************************************************************************
Tail(S, 7, 15)
*************************************************************************/
private static double utbln7n15(double s,
    alglib.xparams _params)
{
    = 0;


    d u
    b
    le
        x = 
        ;


    u le tj
        =
        0;


    1 = 0;


    re
        s
    lt
    0
        ;
        = M th.Min
    (
        *(s 0.00
    00 0
        , 1.0) ;


    t
        j
            = 1;


    j1 x;


    898e+ 00 ,f re
    re
    s
        lt,
        _param
    s)
    h(
        x
        - 4 .4 89 96 e + 00, re
    f
        tj,
        f
    t
        r
    f
        r
    srams);


    -1.129 7
    e + 0, f ef
        j1, re
    f
        result,
        _p


    cheb(x, -2.3
    1
    741
        - 0
    1
    re
        tj, 
    ref
        tj1 , r
    e
        result,
        _


    ucheb(x, -7.
    5
    610
    e -
        0
        , r
        f t
        j
    re
        tj1,
        r
    f resul
        t,
        ucheb(x, -2
        .
    83 7
    e -
        0
    re
        tj, ef
    j1, re f
    r
        sul, _pa
    r
        am u ch
    e
        b
    (
        , 1.258013 e
        - 0
    2
    re
    tf tj1,
        re resu
        l

    ch
    e
    (x,
        25 ef
    t
    j
        ult, _p
    a
        am );
    eb(x, -1.
    9
    8
        ref
    t
        j
    1 ref result,
    _
        ara m
        u .92 8e - e tj rf tj1, refesult, _params);
    ucheb(x, 8.974023e-05, ref tj, ref tj1, ref result, _params);
    ucheb(x, 6.056195e-05, ref tj, ref tj1, ref result, _params);
    ucheb(x, -2.090842e-04, ref
        j, ref
        tj1, r
    f result,
        _param
        )
    ;
    ucheb(
        x
        , -5.23
    620e-04
        , ref tj, r
        t, _ aram );


    816339e 04
    e
        f
    f r sul
        _
    ar m
    s
    heb
        j, r f tj,
        r
    e
        s) ;


    r
        e
    tu n resul t;
}


/*************************************************************************
Tail(S, 7, 30)
*************************************************************************/
private static double utbln7n30(double s,
    alglib.xparams _params)
{
    d
        ub er es lt = 0


    double tj = 0;


    ble t 1 = 0;


    r
        x = M. 2 * (
        -0. 0
    00 +
        0)/
    3
    500
    00e+00
        -
        , 1.0;


    ;


    tj1 = x;


    u eb(,
    -4. 7
    536e
        ref

    tj ef re
        s
    u
        l,
        _params);


    u
    heb
        x, 
    -
        .39
    70 5e +
        ref
    r
        e
    s
    l
        t, _ pa ams)

    u
        c
    eb x
        - 1
            .
    454
    1e+00e j1,  ref
        r
        e
    s
        lt _pa ra s);


    u
        c
    eb(
        , -
            1
    821 9
    t
        j,
        esult,
        _
    a
        rams);


    u
        c
    eb(
        , -
            4
    962
    04e-02
        ,
        ref tj,

    re esult,
        _
    a
        rams);


    u
        c
    eb(
        , -
            1
    698
    32e-02
        ,
        ref tj,

    re esult,
        _
    a
        rams);


    u
        c
    eb(
        , -
            6
    062
    67e-03
        ,
        ref tj,

    r
        ult, _
    p
        a
    r
        m
    s
        );

    u
    heb
        x, 

    2.2
    235
    3 - 03 ,
    ef tj
    r
    f tj1, r
    e
        f
    e
    (x,
        .1 4
    34 ref t
        j1 re fs um
        - .035 68 3
    e
        - 0
    4
    r ef
    r ef
        j1, 
    ref
        esu l
    _param
        s
        ;


    etj, ref tj1, ref result, _params);
    ucheb(x, 3.801453e-06, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.920705e-05, ref tj, ref tj1, ref result, _params);
    ucheb(x,
        2.5187
    5e-05,
        ref tj, r
        e
    f tj1,
        r
    ef rams);


    uch
        e
    t j, r
    f tj 1, re
        e


    c
        e
    b
    05, re
        t,
        r
    e
        lt, p
    ram;
    rn r es l
        ;
}


/*************************************************************************
Tail(S, 7, 100)
*************************************************************************/
private static double utbln7n100(double s,
    alglib.xparams _params)
{
    ou l
    r
    eu lt =
        0;


    do
        u
    le x =
        0;

    le tj =
        0;
    dou bl
        t
            = 
        ;


    sul
        = 0;


    x s - 0. 00
    00 e0 0) 3.50 000e + 0 - 1
        , .0)


    t j


    ch b(,
    -4. 8
    83 7e 0
        , e
        tj rf tj1
    ref
        uc b
    (x - 4. 386949e
        +
        0, f tj
    r ef t j1
    r
        f resul
        t,
        u
    h
    eb(x, -1. 0 + 00,
        ref
        j,
        ef tj1
        ,
        ref res
    u
        lt eb(x,
        1 .6 86 57 e
    01,
        ref

    j,
    ef tj1, 
    ref r sult

    u
        c
    h
    b
        (x, -1 e - 0
    tj,
        ref tj
    1
        ref re
        s
    ul


    ucheb(x,
        -
            .39
    39
    2
        - 02
    re
    f
        tj, 
    ref tj 
    1
        ref re
        s
    ul


    ucheb(x,
        -
            .64
    33
    3
        - 03
    re
    f
        tj, 
    ref tj 
    1
        ref re
        s
    ul


    ucheb(x,
        -1 617
    44e 3,
    ef t
    j
        re
    tj 1, re
        f
    re ul t, _
    p
        ar u
        c
    h
        e,  -5.031 396e-
    0
        , r
        , ref e ult,
        _


    uc eb x,
 
        ,
        rj re ara s) ;


    ch b(x
        ,
        2.6
    545
    7
        - 05 ref tj ,
    r
        tj 1, r ef r es
    u
        l

    ucheb
    (
        5ref tj, ref tj1, ref result, _params);
    ucheb(x, -6.258552e-06, ref tj, ref tj1, ref result, _params);
    ucheb(x, -8.174214e-06, ref tj, ref tj1, ref result, _params);
    uche
        (x, -3
    073644
        - 06, ref
    t
        j,  ref
        t
        j1, _par
    a
        ms);


    ucheb(x,
            , re f j
        ref t
    1
    t, _pa
        s


    re ult;
}


/*************************************************************************
Tail(S, 8, 8)
*************************************************************************/
private static double utbln8n8(double s,
    alglib.xparams _params)
{
    ou
        bl re sult = ;


    do b
    le
        j =
            0;


    do
        ble j1 = 0
            = Mat h.Mi n(*
    (
        s -
        0
    000
    00e + 0 )/3. 606 72 00 - 1. 0)

    t
        tj1
            = 
        ;

    uch
    e
    (x,
        -3 .9 217 00, e
    t ,
    re f j1, f resu lt
    _
        u ch b
    (
        x,
        4.1
    89
    1
    e + 0
        , r f
        tj, 
    ref j1 
        ,
        res lt
        ,
    _ ucheb(x, -
        1
    0514 5e + 0 r f
        tj,
        ef
    j1, re
        f
    ra


    b x, 
    -
        .19
    32
    5
        - 01
    re
    f
        tj, 
    ref tj  1,
    result
        ,
    s
        uc he(x, -6.
    7
    51 96 e, r
    f tj, re f 1, ref
    r
        e
        );


    uc
        h,  -2.3855
    0
    6e ref
    t
        j
    1
        ref result,

    par
        ms
        )


    ucheb(
        x
        - 8.244
    9
    02 , ref

    t
        j,  ref result 
        ,
        _pa
    am
        s
        ;


    ucheb
    (
        , -2.52
    5
    63 j, re
        f

    t
    1, ref resul
        t
    _p
        ra
    m
        );


    cheb(
        x, 2.77127
    5
    e
        tj1,
        r
    e
    f
        result, _p a
        r
    am
        s
        ;


    u heb(x,
        2
    j1, ref es lt _ p;
        .
    0
        , ref

    t
        j,  ref result _ ar a


    u ch e,  4. 88 255
    1
        - 03, r ef

    t
        rs l
    ucheb(x, 4.407944e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 2.769844e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 1.062433e-03, ref tj, ref tj1, ref resul
        , _par
    ms);


    ucheb(
        ,
        5 ref t
    j
        , ref t
    1, ref
    result, _pa
        r
    e
}


/*************************************************************************
Tail(S, 8, 9)
*************************************************************************/
private static double utbln8n9(double s,
    alglib.xparams _params)
{
    uble
    re s
        =
        0;


    d ou le
        = 0;
    dou
        b
    e tj =
            0
        ;
    d
    ouble tj
        =
        0


    re
    s
        lt = ;


    x =
        M
    000e
        +
        0
    0
        /
        3.46 41 2e+0 -
        1, 1 );
    j = 
        ;
    t 1 = x;
        , -4.
    1
    4
    7
    0
    4
    e + 00 ref t
        j, r f
        tj,
        re f sul _p
    aa ms;

    ucheb
        (
            x
        ref t
        j,
        e
    f tj,  ref r
        es ul , _ ra
    m
        );


    uc eb(x
        ,
        -1.1 46 155
    e
        + 0 ef t j1, re
    e
        sult, _par a
        ms );

    u
    heb(x, -2.
    88561 e
        ef re u
    l
        t _params)
    ;

    h eb(
        x

    -8 .1 456
    1
    e - ref t
        j
    1
        ,
    r
        e
    f re s s);

    ucheb
            (, -.116
        ref t
        j
    1
        ,
    r
    ef result, _
    p
        ram
        );


    u
    heb(x,
        1.20566
    7
    e - ref t
        j
    1
        ,
        ref result,
    _
        ara
    s)
    ;


    cheb(x
        ,
        -4.5156
    6
    1e ref
    t
        j
    1
        ref result,

    par
        ms
        )


    ucheb(
        x
        - 7.618
    6
    16 , ref

    t
        j, 
    ref result ,
        par
        )
    ;


    c
    eb(x,
        1
    9011e-0 , re 1, re
        f re s
    l
        t, _p rams);


    b
    3
    457324e
        -
        0
        ref result
        ,
    ar a;
    cheb(x. 829r e
    f
        tj1
    re r su lp r
        a
    m
        u ch eb(x
    4.488
    2
    t ref tj1, ref result, _params);
    ucheb(x, 3.469823e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 1.957591e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 8.05
    326e-0
        , ref
    j, ref tj
    1
        , ref
    e
        su;


    eturn r
        esult;
}


/*************************************************************************
Tail(S, 8, 10)
*************************************************************************/
private static double utbln8n10(double s,
    alglib.xparams _params)
{
    d
        ubl e re su t 0;


    x 0;

    ouble do bl e
        j1 = 0;


    su lt =
            0
        ;
        = Ma
    t
        .Mi
        (2
            *
            s - 0
    000
    0
    0e+0 )/ 3. 55 09
    3
        + 00 - 1,
    1
            .tj =
        1;
    ucheb(x
    4. 34 282e
        +
        0
    j1 , ef
        r s
        lt, para s);


    u
    b(x
      - 4
          .
    008
    0e+00, r
        tj r ef t
        j
    1
    ar am );


    u heb(x, -1 235
    53
    e
        , r
        f t
        j
    re
        tj1, r e
    es lt, _p
    a
        r
    uc eb
    (x
    2. 77 489e 01, ref t , r
        f
    t
    f ult,
        _p ar am s)
        , 9.52 3
    2
    2, r f tj,
        re
    f
    1,
    re
        fr es l, _
    p
        ra ms ) 86288 e
        -
        02 ref j, ref

    j1,
    re
        f
    res
        lt,
        _
    ara
        s);


    u
    0
    2, ref tj , r
    ef t, r
    esu
        _
    pa ams

    uc he(
        r
            f

    t
    1,
    ef
    r
        sul, _par
    a
        s);


    x, -1
        .
    7
    1
    526e-03, ref

    j,
    ef
        j1, 
    ref
        esu
        t, _pa
    r
        ms);


    (x, 9
        .
    2
    1
    7
    26e-04, ref
    t
        , r
        f
    t
    1,
    ef
    r
        sul, _par
    a
        s);


    x, 2.
    8
    4
    8
    e - 03, r f tj,
        r f t
    1,

    ef r e
        ult, pa ra
        s);


    u
    e - 03 ,,
    r
    f j, r
    e
        re
    t
        ue, 
    4
    219 4e 03 r e j,
        ef j1,
    r
        ee ra
        s);

    ex, 3.753761e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 2.573688e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 1.602177e-03, ref tj, ref tj1, ref result, _params);


    retu
    n result;
}


/*************************************************************************
Tail(S, 8, 11)
*************************************************************************/
private static double utbln8n11(double s,
    alglib.xparams _params)


dou ble x = 0


dou e t
do
    u
        b
l
    tj1 = 0;


r ult
        = 0
    ;
x =
    0e 00 )/
3
    .
6
0
000e+00 - 1, 1
.0;


j = 1;

t
1 = x;


eb(x,
    -
        4. 21882e+00, re
f j,
    t
j
    re
res ul, _
arams)
;
b(x, -.8 1
2
4
7
e + 00, ref te t
j1 re
re su, _
ara ms );


3e+00
    ,

rf t, re tj 1, r
    ef sul t, _p
ar ms)


u ch eb(
    x
    - 2.849
3
4
tj1,

r
    e re ult, _pa ra s
    );

che
    (x, -971
27e - 0 2,
r
f tj, r
e
    f
_para
    m
s
    )

uc
h
    x, 
-4 .2 944 02,

ef tj ref t
    j, re f res
u
    lt

ucheb(x, -1 .9 4
22, ref tj,
    ref
tj1, r
    e r


u
    .
946
5e-
0
    , r
f tj,
    r
f tj1,
    r
e
    );


uche b(,
-
    5
031
36
e0 3 ref

j,
ef t j1,
    rams);


uc
    eb
(
    , -
    .51
4
30e
03, re
f
    tj,  ref
    tj t, _p
a
    r
a
    s
    );


uc
    eb
(
    , -
    .35
1
60e
04, re
f
    tj,  ref
    tj t, _p
a
    r
a
    s
    );


uc
    eb
(
    , 6
206
7
8e-
4, ref

j, ref
t
    j1, _pa a
m
    s
    ;


u
    c
eb(, 1.
4
2600 - 0 3,

ef
    j,  ref
    j1 , r ef r
e
    s


(
    , 2
005 8e-
3, rr
    t
1, e f
_para
    m
ucheb(x, 1.780099e-03, ref tj, ref tj1, ref result, _params);
ucheb(x, 1.673599e-03, ref tj, ref tj1, ref result, _params);
return result;
}


/*************************************************************************
Tail(S, 8, 12)
*************************************************************************/
private static double utbln8n12(double s,
    alglib.xparams _params)
{
    dou
        b
    l
        e
    res
    u
        l
            = 0
                = 0;


    double
        t
    1 = ;


    re
        ult =
            0

    ath.Mi n(2
             *
             .000 00e + 0)
        /
        3. 0
    000e 00
        - 1 1.
        );
    t j 1;


    x;


    ucheb(x,
        -
            .398 11
    e
    r
        tj, 
    ref t  1, ref

    esult,
    _
        p
    uche
    b
        (x, -4. 6221 e + 0 0, r
    ef , r ef tj
    1, ref
    res
        u
    _params );


    296e+
    0
    0
        ,
    r
        e
    f tj ref tj1 
        ,
        re
    es
    u
        t,
        par
    a
        s);
    h
        e
    01, re
    f
        t, 
    ref tj  1, ref
    r
        sul,
        _
    aras );

    uch
    e
        - 8. 432 2
    tj1,
    re f s
        ult, _ pa rams);


    eb(x
    3.5
    2438e-0 2, ref j, re
        _param s)


    uche
    b
        x, 
    1.
    5
    457 4
    2, r
        e
    tj
        ref t j1 ref res ul,
        u
    heb(x, -7. 64, r
    e tj, re tj1,
    r
        f re su lt, _ a
        uc
    h
    e
        bx, 4 re
    f
        tj, 
    ref tj 
    1
        ref re
        s
    u
        c e
    (x,
        .0 11 8
    e - 0
        , ref
    t
        , ref t
        j
    1
    aram) ;

    uc
        h
    b(x
    24 758e- resu
    l
        t,
        _params);


    uch
    b(x
        ,
        -1.
    98259e
        -
        3, ref
    t
        j, f res
        u
    l
        t
    _params);


    uc
    eb(
        x
        - 1
    659985
    e
    03, ref

    tj ef re
        s
    u
        l, _params);


    u
        heb
    (
        , -
        .33104 e
    03, r f
    t
    j
        esult, pa ams);


    uc he b
        x, 
    8. 3
    8
    78e0 4, ref

    j,
    re s, ucheb(x, -6.056785e-04,  ref tj, ref tj1, ref result, _params);
    return result;
}


/*************************************************************************
Tail(S, 8, 13)
*************************************************************************/
private static double utbln8n13(double s,
    alglib.xparams _params)
{
    = 0;
        =
    0
    d ou bl e j = 0;


    dou
        b
    le


    t
        .M
        in (2 * (s - .0 00 0
    0
    0e
        +
        0)/
    .6 0
    0
    00e+ 0 - 1
        , .0)


    tj
        =
        tj1 = x;
    uc h,  -
        .38
    0
    70e
    00 , ref

    j, ref t 1
        ,
    _para
        m
    s) ;

    u c
    he
    b
        x, 
    4.
    7
    451
    e + 0
    0
    re
        j,  ref
        j1 , re f
        r
    e
        u heb(x, 1 + 0
        , ref t j
        ,
        ref tj1
        , re arams
    );

    uc h
    e
    b(
        x
        - 2
    42
    0
    11e
    01 , re f j, r e
        tj1,
        r
    f resul
        t,
        u
    cheb(7 28e
    02 , re f j, r
    f tj1,
        ef r sult
    _
        uch
    e
    b
    (
        2.893999 e - 0
    2
        ,
    r
    f t,
        r
    f t
    1, r ef r sul,
        _par
            as );

    19e-
    0
    2, r f
        tj, re f tj1,
        r
    f r
    su
        l, _a ra ms );


    b(x, -4. 2
        ref t
        j1, f
    resul t, _para
    m
        );


    u ch b(, -
        .33966
    4
        , re t j
    esu t,
        _
    pr as );


    u
        c
    eb(
        , -
            1
    801 5
    8e-0 , r
    e
        tj, re
    f
        _para
    m
        s
        )
    u c,  10e
    04, ref t , ref

    t
        , _pa
        r
    a
        m
        );


    uc
        eb
    (
        , 2 .7 3250 04,
        ref tj
        ,
        ref t j1, e lt, _
        p
    ar s);
    uc
        h
    b(x
    1.
    8
    671
    e - 04,
    r
    f tj, r
    e
    f ult,
        _
    p
        a
    ams);


    uc
        h
    b(x
    1.
    3
    462
    e - 04,
    r
    f tj, r
    e
    f ult,
        _
    p
        a
    ams);


    uc
        h
    b(x
    1.
    1
    058
    e - 04,
    r
    f tj, r
    e
    f ult,
        _
    p
        a
    ams);
    u
        b
    (
        , 2
    936 45 3
        - 04
    ef tj,
        ef tj1,

    r
        s);


    return rult;
}


/*************************************************************************
Tail(S, 8, 14)
*************************************************************************/
private static double utbln8n14(double s,
    alglib.xparams _params)

dou
    l

r
    x = 0;


tj = 0


d 0;


x =
    M at.M
    in 2 * (s - 0 0000
0
0
e + 00)/3. 60 0
00
e
    +
    0 - 1, ;


tj
    c heb(x, -4. 36 8e 0,
    ef t, re t
j
    , ref r
    e
s
    uc eb(x - 4.6
9
11 e +
    0
    , r
f tj, f j1, r
    e
f
    s);


che bx, 
-1 1
44 40 00, ef
    t, e f tj1, 
ref r et arams) ;


uche
b
    x, 
2.
3
06 1 - 0, ref
tj, ref t 1, ref
r
    e
r
    m
s);


u
    he
b
    - 7 .0 7
39 e - 0 2, ref j
    r ef tj1,
    re arams
    )
;


uc he
b
    x, 
2.
6
582
2,
r f t j,  ref j1 
    ,
    r ef resu t,
    e,
-
    1
085
54
e
02 ,
ef
    t, r f tj r ef resl

52 68 e - 3
    ,
f j, ef t 1
    ref re u
l
    t


u
    ch eb(x, 1.96664
7
    - 03
f

r
    j1, ef
lt, p
    a
ams) ;


-7.4
5
3
3
8e - 0 4, r f tj, re
f
    tj1 re
es l, _ a
    r
    );
uche b(,

-
    ef tj
    ,

r
    f
t j1, re
r
    es
u
    t,
    pa
ra s);


uch b(x,
    3.5019 8
e
    -
    jr s
u
    lt,
    _pa
am
    s;


uc b(x
7 ref t
    j,
    e f j1,  ref re
    s
lt,
_p
    a
    );


ucheb
(
    , -8.2 1
9
7
r
    e
f
    j1,  ref resu
    l, _
ar
    a
s);


uch
e
    (x, -8.
1
18 tj,
r
    e
f
    tj1,  ref res
    u
t,
pa
    r
ms)


uc
    h
b(x, -9
    .
41 f tj,
    r
e
    tj1,  ref re
    s
lt,
_p
a
    ams
    ;


r
    e
urn res
u
    lt;
}


/*************************************************************************
Tail(S, 8, 15)
*************************************************************************/
private static double utbln8n15(double s,
    alglib.xparams _params)
{
    double
        r
    0;


    tj1 =
        x
        (
            -0 0e+00
        )
        / 3 .6 00 00 e + 00 - 1, 1
        .
    0
        )


    .3583
    9
    7
    e
        , ref tj, ref
    t
    1, r
        f
    r
        t, _ ara );


    u
    ch e, 
    -
        4
            .
    7
    4485e + 0 0, re f
        tj, 
    ref
        tj 
    1
    re
        r es
    u
        t, arams)
    ;


    ref t j
    ef
        tj
    1
    re
        re
    s
        lt,
        params
        )


    19578
    0e - 0
        ref tj , r1 f r
    e
        t,
        params
        )


    .5448 0
    e
        -
        2
        , ref j, ref
    j 1, r
        f
    r
    su lt, a;

    .42 61 3
    e - 2
        , ref tj, re
        f,
        ef

    esu
        t, _ a
        ams
        ;


    uch
        e
    b
    03, r
        e
    f
        j,  ref j1 , re
    f
    res
        lt, para s);


    53 r f tj ref t 1
    r f
    re
    sl t, _
    ara
        m) ;


    .0688
    7
    4
    e - 3, r f tj re f t
        j, r
    e
        s,
        par
    a


    385 4e- 04
    ef tj, re tj1 r
    e
        re su t,
        par
        );


    u
    heb(x, 8. 92 5
    2
        ref tj1 , e
    r sult, para s)
    ;


    u
    b(x
        ,
        1.0
    3905e-
    0
        , r ef t j, re f
        , _ ara ms;
    uc e
    b
        x, 
    9
    6
    3e-3 , re
    f
        tj, 
    ref tj 
    1
        ref r es ul,
        u
    h
    eb(x 9.42357
    2
        ,

    t
        , r
        j1, 
    ref
        re su l
        u h
    b(, 6.57964 e
                -
                4,
        ef

    j, e f j
    1
    reu t, _pa r)
    u
        c
    h
    b(x, 4.76590
    4
        - 04
    r
        e
    tj
        re
    f
        tj1
    ref r
        e
    ult, _p
        a
    ra
        r
    e
        t
    rn result;
}


/*************************************************************************
Tail(S, 8, 30)
*************************************************************************/
private static double utbln8n30(double s,
    alglib.xparams _params)
{
    d
        ouble
    e
        su

    double
        x = 0;


    doub le
    l
        x
            =
            a
    h
        .
    0e+00)3 .6 0
    0
    e
        +
        t
    1
    tj1
        = x
        ;

    uche
    b(x, -4.3 8823e+00,
        r
    f
        t,
        r re
    u
        t, 


    9e+00
        ,

    rf t,  ref tj  1 f esu lt _p
    ram
        s
        ;


    u ch e1 64864 e + 0
    0
        ,
        ref tj, ref
    t
    1, r
        f
    r
        sul, _ p
        a
    ams)
    uc
        h
    e
        ref tj , re f j1, r
    f
    r
        sul, _p ar ms)


    uche b(,

    -
        , re f,  1,

    ef r
    lt _ ara
        s);


    u hb(x
    -1.
    3
    0
    tj, rf j
    1, ref t _p
    aa ms)


    uch
        e
    b
        ef

    t
        j
    ef t 1, ref r
        e
    ult
        _
    p
        ram


    u
    15e-0 3, r
    e
        j, re tj1 r
    e
        r es t, ara
    s);


    87 - 04
        ,

    r
    f
        tj,  ref tj1 
        ,
        re f
        re
    s
        lt,
        _pa
    rm s)


    e 668 66 e - 04
        ,
    r
    ef tj,  ref t
        j, r ef re
    su t,
        par am;

    c 31e-0 ,

    rf tj, re
    t
        j1
    ef e su t
    _p
        ra ms )


    639 7e 0
    5
        ,r ef tj,  ref t
        j, r
    f
    r
        sul, _
    p
        ram
        );

    uche
        b
        (
            ref j
            ,
            r ef

    t
        j
    1, ref res ul,
        parm s) ;


    u
    heb(x, -1. 8185e-0
    5
        ,
        ref re
        su lt _
    pa ams);


    he
    b
        x, 
    9.2
    7
    903
        - 06 , re f j
        ref tj
    1
        ,
    ms;

    ucheb(x -
          7
    5345 1e - ref tj ,
        ref tj1
        ,

    ams);


    r turn
    r
        sul
}


/*************************************************************************
Tail(S, 8, 100)
*************************************************************************/
private static double utbln8n100(double s,
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


    double x
    0;


    double
    t
        j = 0;

    ble tj
    1
        = 0;


    result
        x

    00 0 + 0e+00 -
        ,
        .
        )
    ;
    = 1;


    u
        h
    e
        re t j, r
    e
        f

    t
        j
    1
        , ref r es ult, p
    a
        ra s);


    u
        heb
        (
            r
                t, tj
            ,
            r
                e

    ams;
    uche(x
        ,
        -1.
    2
    9
        + 00
        ref j1, re f r
        e
    s
        c
    he b(,
    -1 5
    4
    15 49 01, r
        e
    tj
        f
    t
    1, e f r
        u
    c
        h
    e
    (
        x, -3.525605 -
           2,
        ef tj re
    tj1 ,
        ref
    result
        ,
    _params) ;


    heb(x,
        -1 .0 9
    92 - 02 , ef t,
        r
    f t
    1,

    ef sul
    t _p r
        ms);

    , -3.0
    8
    5
    7
    3
    e - 03, ref j,

    ef
        j1,
        re
    esu
        l
    pa
        ams);

    b(x, -1. 07 71e-03, ref tj, r ef t
    1, rf r s
        lt
    _
        ara
    s);


    u
    c
        - 04, re f
        j, r f
        t
    1,
    ef
    rs ul,
        _p ram s)


    0
    6
    4
    e
    0
    4, j re
    t j1, 
    ref esult ,
        params );

    (x, -
        2
            .
    0
    43 9e-05, rf t, r
    f 1 ef re
        s, _para
    m
        s
    ch eb x, 
    7 3
    63 47 - 06, ef tj,
        re f 1,

    ef r
    arams) ;
    b(x,
        6
            .
    3
    5637e-06, ef
        j,
        ef

    j1,
    fr r
    ms);


    321 22e - 0 ,
        ref tj, ref
    tj , r
        f r es lt,
        _pa
    r
        ms)


    uche
        b
    (x - 06, e
    f
        t
    re f j1, e
    f
        r
    eu lt
    pa
        r
    ms );


    uche
        bx,  -3 .0 807
    9
    e
        tj 1, r
        e
    f s
    ul t, _par m
        s
        );


    r et u
        n r
        e
    ult
}


/*************************************************************************
Tail(S, 9, 9)
*************************************************************************/
private static double utbln9n9(double s,
    alglib.xparams _params)
{
    double res
    u
    l
        t
            = 
        ;


    d
        o
    u
        b
    l
    e
        x
            =
            0
        ;


    d
        o
    u
        b
    l
        e

    t
        j
            =
            0
        ;


    d
        o
    u
        b
    l
        e

    t
        j
    1
        =
        0
        ;


    result
        = 0;


    x = Ma
    t
    h.Min(
        *
            (s 0) / 3.5
    7
    6237e+0
        - 1, 1.0
        )


    b
    x
        -
        tj, r
    f
        j,
        rams);


    f
        tj, re
    f re su
    l
        t,
        _
    p
        arams);


    uche b(x, -1.
    2
    4
    8
    33e
        +
        0
    ams
        ;


    (x, -
        2
            .
    7
    2
    868e-01, ref

    re
    t
        j, r
    f re u
        t,
        pa ra m
    heb(x
            ,
            -
        .
    5593 72 - 02, r ef t, e
    t
        j, r
    f r
    e
    ul t, a


    .8949
    4
    1
    e - 2
        , re tj,  ref
        j1 , r ef r
        sul, _p ar ms)


    uc
        h
    e
    e - 02, r f


    re f j1,
        r
    ef
        esul,
        _
    ara
        s);


    u ch b(x
        ,
        re tj, r f
    tj1, ref res
    u
        t,
        par s);


    ucheb
    (
        , -2.285 03 4
    f tj1, e
    f
        s
    ul t, _paa s
        );


    uche b
    (x,
        6.11299 7
        , ref

    t
        j, re res lt, _ ar
        a
        ;


    uc
        h
    b(x
    2.806
    2
    9e-03,
    r
        e
    ref
        r
        e
    s
    l
        t, _params);


    uch(x,
        4.150 74 1
    ef res
    u
        l
    t
        _params) ;


    ce(x,
        .50
    e -
        0
        , r ef tj,
        r
    p
        aram s) ;


    u
        he
    b
        x,  3. 910
    1e-
        ref

    j, r ef t
        j, _pa
    r
        a
    m
        u
    heb(
        2. 85 13e
              -
              3, e f tj, r f
        , r ef r
    e
        s


    ucheb(x, 1 .5 3e
                  -
                  3,
        ef t j, re f j1, ef r
    e


    return re
    s
        lt;
}


/*************************************************************************
Tail(S, 9, 10)
*************************************************************************/
private static double utbln9n10(double s,
    alglib.xparams _params)
{
    d
        ;

    d ou
    ble x = 0;
    double tj = 0;
    double tj1 = 0;

    result = 0;
    x = Math.Min(2 * (s - 0.000000e+00) / 3.650000e+00 - 1, 1.0);
    tj = 1;
    tj1 = x;
    ucheb(x,
        -4.516
    26e+00
        ref tj,
    r
        ef tj1
        re arams)
    ;


    uc
    heb(x, -4.9
    j, reft j, p
    a
    5046e+
    0,
    e
        )

    ucheb(x, -2. 93 5
    326e-01, ref

    t
        j
    r ef t j
    e - 01, re f t,
        ef
    j1
        ,
    refr es l
        t
    _ aa m)


    05 92e-
    0
    2
        ,r ef t j, re f tj1, r
    e
    re
        t, _p rams;

    uc he(
        x

    -2.053
    14 0
    sul
        , p ara s);
    u he
    b
        - 1.065 9
    f tj1,  ref
        rs ult
    _
        p
    ram
        );


    u
    b(x, -5.j, ref t j1, ef
    esu
        t,
        para s)
    ;
    u
        c
    eb(x, -
        2
            .tj1, re f

    res u
        t,
        pa
    r
        ms) ;

    uche(
        x
        - 1. 1374 e
    f tj 1, f r
    e
    ul t,
        am s
        ;


    cheb x,  1
    510631e
        -
        0
    ef result,
        _pa
    am
        s
        ;

    che b(x
        ,
        2. 3605 7
    e
        -
        f resu lt, _
    p
        ar
    a
        s);


    c
    e(, 2. 3
    5e-0 3,
    r
        e
    f result,
        ra
    s)
    ;


    u eb(x,
        2
    692 - 0
    3
        , ef
        r
    e
    s
        lt, _pa rs


    cheb(x
        ,
        1.61505
    0e -
        t1 ,

    re f esul, _para ms;


    esult;
}


/*************************************************************************
Tail(S, 9, 11)
*************************************************************************/
private static double utbln9n11(double s,
    alglib.xparams _params)
{
    d oubl
    e


    double

    double tj = 0;
    double tj1 = 0;

    result = 0;
    x = Math.Min(2 * (s - 0.000000e+00) / 3.650000e+00 - 1, 1.0);
    tj = 1;
    tj1 = x;
    ucheb(x, -4.48
    308e+0
        , ref
    j, ref tj
    1
        , ref
    e
        su;


    cheb(x,
        -4.867483e
    f tj1,
        r esul
        ,
    _
        p
    uc e
    (
        ,

    sult,

    59 7
        - 0 , rt f tj1, 
    ref r su t, ms);
    b .40
    8
        - 0 2 tj1, r
        e
    f

    e
        sult, _param
    s
        uc
    eb(
        x
        - 3
    341 92 - 0 2
    rams);


    u
        heb
    (
        , -
        .46368
    0
        - 02 ref t ,
    f res
    u
        l
    t
        _params);


    uc
        h
    b(x - 7 4
    8
    21 e0 3, ref j
        re f j1,
        re ara ms )
    ch
    e
    (x,
        -4.
    6
    11 6 - 03 ref t
        , ref t
        j, _pa
    r
        a
    m
        c
    eb(
        ,
        -
            .34
    472
    e
        r
    ft j,
        ef tj1
        r
    er ams)
    ;


    eb
    (
        , -
            .54 4
    1
    6e-
    3, ref

    j, ref
    t
        para ms )
    u ch b(
        , -
            1
    802
    35 e - 3, r t j,  ref
        a
        u ch b(x
    -1
    117
    0
    4e - 0 ref t
        j
    ref t  1
        ,


    ch b(,
    -
        .21
    443e - 0 , re tj, ef
    t 1, r ef
    r
        e


    ucheb(x, -2 .8 87 66
                      - 0
    4
    re
    t j, r
    f t
    1, ref
    r
        lt, _p
    a
        r
    u
        c
    h
    e
    (
        x, -3.193687
    e
        , r
    f
        t, rf t j1,
        f
    esult, par ms);


    n result;
}


/*************************************************************************
Tail(S, 9, 12)
*************************************************************************/
private static double utbln9n12(double s,
    alglib.xparams _params)
{
    oub
        e
    re ult
        = 0;


    d
    0 double tj1 = 0;

    result = 0;
    x = Math.Min(2 * (s - 0.000000e+00) / 3.650000e+00 - 1, 1.0);
    tj = 1;
    tj1 = x;
    ucheb(x, -4.456776e+00, ref tj, re
    tj1,
    ef res
        lt, _param
    s
        );


    , -4.8
    1
    7037e+0
        , ref t
        j,  ref tj1 ,
        uc h
        x,  -1. 20 97 8
    0
    re f
        esult,
        _
    m
        s
    ucheb(, -2
    3
    2
    1
        ref t
    1, re
        e
    s

    7
    ef tj, r
    e
    f
        tj1,  ref re
        su t
        pa am s


    tj r er sul,
        _
    ar am s


    ucheb(
        x
        - 1 .0 2614
    1
    e
    f j1, rr _a ra
    m
        );

    u b(x
        ,
        ref
            t
            j, r f

    t1 r ef r
        esu, _
    ar
        a
    s);


    u c
        tj, r
    e
        f

    j
    1, r ef result,
        pa ra );

    u
        h2 e - 03 , re t j,
        r
    ef tj1,  ref r
        e
    t,
    _p
        a
    ams

    ucheb(x - 9.663
    6
    004, ref tj,
    r
        e
    ft j
    1, ref result
        ,
    _pa
    am
        s;


    ch
    b(x, -7
    76852 e -
        0
    4
    r
    f
        tj1, re f es u
    l
        t,
        par
    ms
        )

    che
        , -5 .7 015 - 04
        ,
    e j1, r
    e
        f

    e
        sult, _param
    s
        ;


    u
        c
    eb
        x,  -.8
    66 77 - 04, r
        e
    f
        ef, _
    pa
        r
    ms)


    c
    h
        x, -7.440
    65 e - 05, r
        e
    f
        es ul t, _ ar a
    m
        );


    uc he(x,
        1.5230
    3
    4, ref

    t
        r
    e
        r es ul t, _params)
    ;


    r
        tur
    n
    res
        lt;
}


/*************************************************************************
Tail(S, 9, 13)
*************************************************************************/
private static double utbln9n13(double s,
    alglib.xparams _params)
{
    dou
        b
    res ul =
        0
    ble x = 
        ;

    o le
        t
            = 0;


    doub le
    t
        e
    ul t 0;
        = Math.Min(2 * (s - 0.000000e+00) / 3.650000e+00 - 1, 1.0);
    tj = 1;
    tj1 = x;
    ucheb(x, -4.438840e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -4.779308e+00,
            ref tj
        ref t
    1, ref r
    e
        sult,
        p
    ar
        u
    cheb(x,
        -1.1806
    14e+00, ref
    t, _pa
        ams) ;


    48 9e - 0 1, r e
    j
    e
        j1,
        uc h
        x, 
    3
    21 e
        es ul t, _ pa r
        );


    e - 02, r f
    t
        j
    r
    s
        lt, _ p
        a
    ram
        s)


    uche
    b
    (
        x, -7. 796211e- 3
        ,
        ef t j

    h 2.
    5
    57 5
    3, rj f tj
    1
        ,


    u
    heb(x, -5.
    64 7e - 04,
    r
        e
    resu
    l
        t,
        _
    p
        ar am s) ;
    e b(x, 1
    0
    4
        ,
    re f tj, ef tj1, r
        e
    re
        _p am s)


    u
    c
    (x, 43 - 04
        ,
        r e
    j, re f tj1,  ref
        esu
        t, _
    ara );


    u heb
    (
        , 4.299
    1
    2
    j1, re f re s
    u
        lt,
        par
    ms
        )


    ch b(x, 3
    397416e
        -
        j1, r ee r
        a
    ms
        )


    uch
    e(x, 2
    781e-
    0, r f tj
        r
    et ult,
        _
    pa r


    uc eb(
        x

    1.
    3761 9e 0
    4
    ef tj,
        r
    ult, _ pa a
        s
        );
    ,
    7.2
    6
    692 e - 5, re
    f
        tj,  ref t
        j
    arams) ;


    r u
        t;
}


/*************************************************************************
Tail(S, 9, 14)
*************************************************************************/
private static double utbln9n14(double s,
    alglib.xparams _params)


d
    ub le e
    ult = 0;
bl x
    = 0;

d
    ub
e
    t
        =
        result = 0;
    =
ath
    .
    in(
    *(s
        + 00 - 1,
        1.0);
j 1;
tj1 = x;
ucheb(x, -4.425981e+00, ref tj, ref tj1, ref result, _params);
ucheb(x, -4.751545e+00, ref tj, ref tj1, ref result, _params);
ucheb(x, -1.159543
         + 00, r
f tj,
    ef tj1, r
    e
f resu
    t,
    uche
(x, -2.
086570e-01, t s


uc 7446e-
2,
r
    f
t ref re
    ult

p
    aa u
    h
b
    (x -
     2
    ref

tj,

r
    e
f

t
    j1,  ref resu
    l
t
    , _params);


8.
7
5
19 , r
    f
t
    j1, _pa
r
a
    ms;

u eb(
    ,

-. 51 54
3e-
    ref
tj, re
f
    tj1, re
f r
    ;


e(
    x
    - 1.72
7
72e
03, re
f
    tj, r lt, _pa a
m
    c
29e-0
4
    ,

e
f tj,  ref tj1 
    ,
 
ref
    su lt _pa
    am,  -
    0
4,

ef
    j,
    t
re f esult, _p ar s);


-04, re f tj,
    re
t
    j, r
f r
e
ul t, paa m
    s
    ;


-3.2
33 50 -
    04, re f te sult
    params)
;

cheb(x, 3
.50818, f
    tj,
    ef j 1, ref es ul, _p r
    a
uc e
b
(
    x
    -
    33 e
       -
       4,
    ef
t
    , r
    tj1, r
e
    sult,
    _p ar u
c
    h
e
    (x, -8 ef
t
    , r
    tj1, e
f
sul t, _p
a
    r

re r
n result; }


/*************************************************************************
Tail(S, 9, 15)
*************************************************************************/
private static double utbln9n15(double s,
    alglib.xparams _params)
{
    oube r es ul = 
        ;


    0;


    doub le;


    dou
        b
    e tj1 =
            0
        ;


    th.Min(2 * (s - 0.000000e+00) / 3.650000e+00 - 1, 1.0);
    tj = 1;
    tj1 = x;
    ucheb(x, -4.414952e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -4.727612e+00, ref t
        , ref
        j1, re
    result,
    _
        params
        ;

    cheb(x
        ,
        -1.140
    34e+00,
        ref tj, re
        lt, _p a
        uc
    1e-01,
    re
        j, resul, _
    a
        a
    m) uche
    (
        ,
        -,
        r
    f tj,
        re
    f
        t
    j
    1
        ,
        ref result,

    _
        params);


    u 53
    7
    e
        - 0 ef
        j,
        r param
        s
        )
    ;

    uc e
    (x, 
        .
    5
    105
    e - 0 3,
    ef
        r ef t
        j,  ref r
        e
    s


    ucheb(x, . 5
    762
    5
        , ref j, re fj resu t, _
    -9.
    2
    resul ,
    _
        p
    ram
        );


    uch
    b(x, -
        2
    448700e
        -
        04 f tj1,
        r
    f
    resl t, _
    pa
        r
    ms)


    uc he b
    1. 7126
    6
    e - 04, r e
    ref re
        su lt _
    pa ams);
    h .015
    0
    5
    re tj1, e
    r sult, _ pa a
    ms
        )


    cheb(x, 5
    610e-04
        ,

    j1, r f

    r
    s
        ult, _ arams)
    ;


    che
        b
    6.
    01363e
        -
        4, ref
    t
        j
    res ul,
        _p r
        a
    ms );


    ch b
        x, 
    .3 08 e
    04, re f t re ul
        t, _a ra s);
    c
    eb
    (
        .1
    477
    2 - 04 ,
    ef tj,
        ef tj1,
    r e
        ;

    retur n esul;
}


/*************************************************************************
Tail(S, 9, 30)
*************************************************************************/
private static double utbln9n30(double s,
    alglib.xparams _params)


d
    o
bler es lt

0;
x = 0;


doubl et j
    = ;

d ou l
    j1 =
        0


l
    = 0;


Math.Min(2 * (s - 0.000000e+00) / 3.650000e+00 - 1, 1.0);
tj = 1;
tj1 = x;
ucheb(x, -4.370720e+00, ref tj, ref tj1, ref result, _params);
ucheb(x, -4.615712e+00, ref
    tj, re
tj1,
ef result,
    _para
s
    );
ucheb
(
    x, -1.0
0023e+0
0, ref tj,
ult, _a rams);


jr ,
r params
    ;


-3.31
2
5
e - r
f
    tj1, 

ref
    r
    e
s
    u
l
    t, _params);


u
    c
h
e
(x,
    -9 r
f
t
    j, f r
    s
l
    t,
    ucheb(x, -2
    .
414
2e
    -
    3, f t
j
ef
    tj1, re
f
    result, _ p
    a
u
    c
h
e
(
    x, -8. 735360e- 4
re
t j, 
ref
    tj1 
    ,
    params);


uche(x - 2.e - 04, ref tj,
    re t, r ult,
    _
p
    r
am );
(x,
    -1 1
0
738
4,
ts
    uc eb(
    x
    - 4
348 991e- 5, ref

t
    t,
    par
ms)
;

c he(x, -
        f tj,
    r ef j
1, ref r es u, p
ram
    s
    ;


uche b(,
2 ref
t
    j,
    ult _p a
r
    ms)


ucheb
(
    , .39 74 6
e
    -
    j1f re
s
    lt, _
ms )
;


eb(x,
    -
        2
ef tj,
    r
e
    tj1,  ref res
    u
t,
par am );


u ch b
    (x - 9 .8 225
2
e
    ef tj
1
    ,

e
    f resu lt, _par
a
    s);

r e
t
rn
    esult;
}


/*************************************************************************
Tail(S, 9, 100)
*************************************************************************/
private static double utbln9n100(double s,
    alglib.xparams _params)


ouble re u
    l
do
    u
        b
le x = 0;


o
    ;


double
    tj 1
resu lt = 0;

Math.Min(2 * (s - 0.000000e+00) / 3.650000e+00 - 1, 1.0);
tj = 1;
tj1 = x;
ucheb(x, -4.372506e+00, ref tj, ref tj1, ref result, _params);
ucheb(x, -4.590966e+00, ref
    tj, re
tj1,
ef result,
    _para
s
    );
ucheb
(
    x, -1.0
1758e+0
0, ref tj,
sult , params
;
uc
e
(
    13 ef tj, r ef j
    ,
    ams);
eb(, -
    .
5
59 ,
r
f tj,
    re
f
    t
j
1
    ,
    ref result,

_
    params);


u 33
6
e
    - 0 ef
    j,
    r param
    s
    )
;

u
    c
eb(
    ,
    -
        .93
659
e
03,
    ref tj
    ,
    ref tj1
    ,
r param
s
    )
;

u
    ch b(x
         - 5 349
3e 0
4
re
t j,  ref
    , ref r
    e
s


ucheb(x, -1.
7
005 r
    e
tj1 re
f
    );


u ce b(
    x5, ref tj, rf
t
    e f r) ;


u
    j,
    r
e
    tj1 r er t, _p ra
    m
    );


28663 e - 06 ,

e
f tj,  ref tj1 ,
    r
su
    x,  8.
6
3
1
7
5
e - 07 ref j
    ,
    ref
tj
1
re
    re su l
eb x, 
1
    .
6
6
7
4e - 06, re
ft j, j ef re su lt, pa ra ms);


eb(x,
    4
        .
0e 07 , re tj
r
e
    tj, r
e
    r es t, p ams);


x, - .
7
8
872e-07, ref tj rf
t
1,
ef
    r
sul
    para s
    )


t;

}


/*************************************************************************
Tail(S, 10, 10)
*************************************************************************/
private static double utbln10n10(double s,
    alglib.xparams _params)


doub le result
    =
    0;


d o = 0;


le tj
0;

dble tj1 = 0;

result = 0;
x = Math.Min(2 * (s - 0.000000e+00) / 3.650000e+00 - 1, 1.0);
tj = 1;
tj1 = x;
ucheb(x, -4.468831e+00, ref tj, ref tj1, ref res
lt, _p
    rams);


uche
(
    x, 00, re
f
    tj, re
tj1, r
    e

uc eb(
    ,

-
    1. ref tj
    e f
    t
j
    _ ara s;

ef tj1

e
    f


uc e
b
(1 e
   - 0
2
    ,
r f t
    j,
    re
u
    t, 


.9714
2
5
e
0
2, ref tj, r
e
    tj,
    r
f r
sul
    t
_p
    rams);


.2153
7
1
e
0
2, ref tj, r
e
    tj,
    r
f r
sul
    t
_p
    rams);


.8284
5
1
e
0
3, ref tj
    re
f
    tj,
    re
f
su
    t,
    _
ar am s
    ;

uch
    e
b
03, r f
    t,
    re f tj1,  ref
    esu
    t,
    par
ms)
;


03, r
    e
f
    j,  ref tj1 , e
f es lt _
p
    ram
    );


u
    x,  -1.7
4
03 tj r f t
j
1
    ref result, _p ams


he b(
    x

-1
04921 1e - 0 3
    ref tj
    ,
    , _pa
    r
a
    m
    )
;

u
    c
eb(
    ,
    -
        .2 93 1e - 0
4
re
    tj, r
e
    tj1, re f
r
    eu;


uche(x, 2 .211 93
e
04, r f t
    j
re f
    t, e

c
heb(x, .232 14
e
04, r f
    t, r
f t
    j, r
f resu
    l, _par a
    c eb(x, 3. 0
1e -
    4,

ef
    j, r ef tj1 ref
    r
    sult _p
    a
ra
    r
e
    t
r
n result;

}


/*************************************************************************
Tail(S, 10, 11)
*************************************************************************/
private static double utbln10n11(double s,
    alglib.xparams _params)
{
    o
        u
    rs ul
    0


    do
        ul e x = 0
        ;

    ou bl e tj =
        0


    d
    ubl tj
        ;


    r
    e
        ult =
            x = M
    th.Min
        (2 * (s - 0.0000e+00) / 3.650000e+00 - 1, 1.0);
    tj = 1;
    tj1 = x;
    ucheb(x, -4.437998e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -4.782296e+00, ref tj, ref tj1, ref res
    lt, _p
        rams);


    uche
    (
        x, 00, re
    f
        tj, re
    tj1, r
    ef result,
        uche
    (
        2
        ,
        sult,
        pa
    a
        s
        )
    uche b(,
    -6.
    5
    2f t
    esul
        t, _
    p
        a
    r
        a
    m
        s
        );


    ucheb(x, -2
        .
    2
    9
    008
    e
        - 0 ef
        t
    1
        , _pa
        a
    s
        );
    uche
        b
    (
        x
        - 8.481501e-0
    3
    re
        t
    j
        re
    tj
    1
    re
        resul
    t
        _param
    s
        );
    uche
        b
    (
        x
        - 3.527940e-0
    3
    re
        t, 
    ref
    1,

    ef sult,
        _a ra ms);
    x, -1
        .
    95 34 6
    e - 03, ef tj,
        r f t
    1,

    efe _
    p
    ram
        - 1.56
    38 0e
    re f
        tj, 
    ref
        j1 , 
    ref re u
    t, _p ra ms
        )
    ;
    ucheb x,  -1 5
    74403e-03, r
        ef tj
    ef tj, r e
        es ul t, _ ara
        s);


    uc
        h
    e
        ref
    t
        j,
        r
    ef tj1 r f r
        es
    u
        t,
        pa
    r
        ms)

    ucheb
    (
        , -1.33 80 37 e
    f tj1
    r
        ef re su t, _ a
        r
    am
        s


    uc e
    (x,
        -1 .0 0
    ef tj
    1
        ,

    e
        f re ult, _ r
        ms)


    uch
    b(x, -
        5
    80 e
        f
    r er
    uc eb(x
    -3. 1
    8
        ref t
        j
    1
        ,
    re f esult, _ pa ra
    m
        );


    r e
    n es lt;
}


/*************************************************************************
Tail(S, 10, 12)
*************************************************************************/
private static double utbln10n12(double s,
    alglib.xparams _params)
{
    d
        o


    ouble x = 0;


    oub
    l
        tj
            = 0;


    d 0;
    res u
    l
        t
            =
            x =
                M th2 * (s - 0.000
    000e+0
        - 1, 1.
    0
    tj = 1;
    tj1 = x;
    ucheb(x, -4.416082e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -4.737458e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.
    50952e
    00, re
        tj,  ref
        t
        j1, re

    re s);


    ucheb(
        x
    re f j1,  ref r 
        ,
        _

    u
        h
    e
    02, re
        tj
    e
    f
        lt, _p ra
        s;

    -1 0
    6
    8
    e
        tj, 

    ref
        t
        j
    1
        ,
        ref result,
    _
        p
    arams);


    uc 96
    6
        -
        03 f t
    1

    re arams
        )
    ;


    uc
        h
    b(x
      -
      2
    162
    47e
        -
        3,
    ef tj,
        ef tj1,

    re arams
        )
    ;


    uc
        h
    b(x, -6
        .
    516 e - 0
    4
    ef
        tj,  ref t  1, ref re s
    ul
        uch b(x, -2. 1
    4
    757
        - 0
    4
    tj
        ,
        ref tj
    1
        ,


    uc
    eb(
        x, -1.
    03981e
        -
        4, ref t ,
    sult,

    _
        p
    r
        ams);


    uc
        eb
    (
        , 2. 316
    2
    04,
    f tj, re f t
        j,  ref r
        e
    s
        u
    b
        (x, -3.34690
    3
        - 0 , ef
        t, r
    f t
        j, r
    f es lt,
        params)
    ;


    x, -3
        .
    0
    1
    1
    51 e - 4, r f t j, r
    e
        tj, re re ult,
        _pa ra s);


    1. 95 61 48 - 0 4
        ,
    r
    ef tj,  ref tj re res ul, _p rams )


    ucheb(
        x
        ,
        ref t
    j
        ,

    e
    f tj1,  ref r
        e
    ult
        _
    pr ams
        ;


    r
        eu rn r su lt;
}


/*************************************************************************
Tail(S, 10, 13)
*************************************************************************/
private static double utbln10n13(double s,
    alglib.xparams _params)
{
    le res ul
    0;
    le
        = 
        ;


    do
        ub l


    du bl ej = 
        ;


    r
    e
        ult
            = 0;


    x
        =
        000000 e
        +
        0
        )
        /3.65000 0e + 0

    j =
        1;


    j
    1

    uc eb
        - 4.3
    99480e+00, f tj,  ref tj1 ,  ref result , _params);
    ucheb(x, -4.702863e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.124829e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x
          - 1.89
    428e-0
        , ref tj,
    r
        ef tj1
        re arams)
    ;


    uc
    heb(x, -4.9
    j, re
        tj1, ram s) ;


    62 ,
    1, refr esu, s);


    5.18
    0
    461
    e
        -
        0
    3
        ,
        ref tj, ref
    t
        j
    1, ref resul
        t,
        par
    a
        ms
    u
        h
    eb 6e-
    3

    re 1, re
        f

    r
    s
        ult, _params
        )


    uc
        h
    b(x
      - 7.86
    4
    76e-05,

    re 1, re
        f

    r
    s
        ult, _params
        )


    che
        b
    4
    186576e - 0 , ref j,
    re esult, _ p
        a
    a
        ms);

    uc
    eb
    (
        4, r
    e
        tj,  ref t1 lt, _p rm );


    uc
    eb
    (
        x,
        .83 8
    ef
    t
        j, ef re
        s
    u
        l, pa am s);


    uch eb x,  5
    47 56 e - 04 re
        tj, r
    e
        j1,  ref
        r
        e


    u
    cheb(x 4 20 9
    54
    7
        - 04
    r
        e
    tj
    ef tj, r
    f resu
        l, _para ms );

    eb(x 2
    .8 36 6e 04, ef t j, re
    f j1, 
    ref r sul, _p ar ms)


    uc he b(x
    r ef t
        j, f
    tj1, r f res ul _p am
        s
        ;


    r et u
}


/*************************************************************************
Tail(S, 10, 14)
*************************************************************************/
private static double utbln10n14(double s,
    alglib.xparams _params)


d ou bl e es ul t
    =
    0


d ubl e = 0 t 0;


d ou ble tj
1
    = 0;


re
    ult =
        0


n(2 * (
    s
    -
    0
00 00 + 00)/3.65
0
00e
00 - 1 .0

tj =
    1


uc eb(x, -
    4
386
24
e
00,r ef t
    j
eft j1 re esult, _
u
    c
6124e+00, ref tj, ref tj1, ref result, _params);
ucheb(x, -1.104740e+00, ref tj, ref tj1, ref result, _params);
ucheb(x, -1.793826e-01, ref tj, ref tj1, ref result, _params);

uch
b(x, -
    .558886e-0
2
    , ref
j
    , resul
    t, _para
s);


462e-0
    , ref j , e
    f, _par
m
    )


b(x, -
    .0
3
e
    ef tj1
    re

e
sl
    .
1
782e
    -
    03,

r
    e
f

t
    j,  ref tj1 ,
    r
e
f result, _p
a
    r
a
    s);


he
(
    ,
    -, r
f
t
    j, f res
    u
l
    t

_params);


uch
b(x
    ,
    -3.
7604 e -
    0
    , r f tj,
    ult,
    pa r
    a
s
    );


uc he(x
    ,
    -1. 455
1
    - 0 4
    ref
re ul, _params);


che(x, -.288778
e
    ef
res
    _p a
heb(x, -
    4
        .
5
7658e-05, r
    ef t j,  ref
    tj  1, e _pa am );


9101e
    -
    0
5
    ref tj, r ef t 1,
r
    f r
su
    l, _p ams;
u ch(x, -9.2
6
5
    ref t
    j
1
    ,
r
    ef resu lt, _p ra m
    s
    ;


uch bx,  2
38 503e - 0 re tj,
    r
t, _p
    a
r
    a
s
    );
r e
t
    rn
es
    ut;

}


/*************************************************************************
Tail(S, 10, 15)
*************************************************************************/
private static double utbln10n15(double s,
    alglib.xparams _params)
{
    d o
        ;
    o
        d ou le tj = 0;


    ou bl tj1

    0;


    resu
        l
    t
        x
            =
            ath.Min(2 * (-0
                .
    000
    0e + 0 / 3.6 000
    0
        + 00
    1,
    j = 1;


    tj = 
        ;


    ch eb x
        - .
    76846 e + 0
        ref j resu
    l
        t,
        _paa s);


    u
        c
    eb(
        , -
            4
    6544 7e 00,
    r
        f t j,  ref
        t 
        ,
        _p ar ms )


    b, -1.088083e+00, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.705945e-01, ref tj, ref tj1, ref result, _params);
    ucheb(x, -4.169677e-02, ref tj, ref tj1, ref result, _params);


    uc
    eb(x, -1.3
    1
    7213e-
    2
        , tj1, r
        e
    f resul, _para
    ms);
    , -4. 4836e

    r
        re f r
    s
        l, _a
    uc
        e,
        ef tj,
        ref
    ,

    am s)


    h
    b
        x,  -6
        .
    6339 1
    0
    e
        -
        0
    4
        , ref tj, re
    f
        tj1,  ref res
        u
    l
        t
    _p
        a
    ra
        u
    ch 621
        -
        4
        , tj1,
    r
        e
    f
    r
        esult, _para
    m
        );


    u
    heb
        x,  -2.
    6
    8588e-0
    4
        , tj1,
    r
        e
    f
    r
        esult, _para
    m
        );


    u
    heb
        x,  -.3
    2
    254 - 04,

    r
        ref r su l
        t

    _params);


    u
        heb,  -
        2
    17 52
    7e-04,

    tj1, e e_ s
    uch
        e,  -.1 23 14 f tj,
        r
    ef t
    j
    1, rf resu
        l, _
    a);
    u c
    eb(x, -1 .6 75 68 8
    e
        tj1,
        r
    e
        re su lt, para ms )
    ;


    uc eb x, 
    1.6
    1363e-
    0
        , re t, r
    ef sult, _ pa r
        ;

    r urn es ul
}


/*************************************************************************
Tail(S, 10, 30)
*************************************************************************/
private static double utbln10n30(double s,
    alglib.xparams _params)


doub le result

0;


d
    o
bl x = 0
    ;


0;
dob le t j1 = 0;


r es l
    t
0;
    .Min(2 * (-
    .
000000e+0) 0
    - 1,
    . 0) ;


t j = 1;
j1 = ;


e b(
    ,

-4. 3
7e +
    0, ref

j, re t
j
    ms);


ucheb(x,
    4.5
80
9
e + 0
    , r
e
    tj, ef tj1
    ,
    ref res
    u
l
    uche b e + 0
    , re f tj re
    tj1,
    r
f resu lt
    _
u
heb(x,
    0 ref tj, ref tj1, ref result, _params);
ucheb(x, -2.523674e-02, ref tj, ref tj1, ref result, _params);
ucheb(x, -6.828211e-03, ref tj, ref tj1, ref result, _params);
uche
    (x, -1
716917
    - 03, ref t
    j,  ref
    j 
1, _para
    m
s);


ucheb(x, -
    re f
resul
    ,
_
    a
r
heb(x, 1.4 3
7
1
tj1,
ef
    e
u
    l, 
5
    - 0 , re
f
    tj,
    r
e
f
    tj1, e sult, _ a
r
    a
s
    );
u
    h
b
    (x - 05

e
    f ref
    r
    e
s
l
    t, _params);


che
b
    x, 
9.1402
3
e - 06, r
    e
f ref
r
    e
s
l
    t, _params);


che
b
    x, 
5.6292
3
e - 06, r
    e
f ref
r
    e
s
l
    t, params)


uchb(x,
    -
        .5
5e-06,

ef tj,
    r
e
    t, _p
ar a;


uch
bx - 1 944946e
    -
    0
tj , rr t,
    par s)
;
u
    c
eb(x, 1
    .e f
tj, ef r f su
l
    _pa
s) ;


retu
    r re su lt;


}


/*************************************************************************
Tail(S, 10, 100)
*************************************************************************/
private static double utbln10n100(double s,
    alglib.xparams _params)
{
    d ble r sul
        = 0;


    do
        u
            b
    e
        tj = 0;


    do
        u;


    res
        u
    l
        x = M at.i
    n(2 * (s - 00 00
    00 e
    00
        )
    3.6
    00 00 +
        0 - 1
    1 .0 )

    t
        j
            = x;


    uce b(,
    -4 3
    40 08 +
        0, r
    f tj,
        r
    j1, re
        f r_ a
    r
        m
    s) ;
    u
        c
    eb(
        ,
        -
            .5 22 6e+ 0
    re
        tj, re f j1,  ref
        r 
        ;


    ucheb(x, -9 76 96
    7e
        -
        1,
    ef
        t, r
    f tj1,
        ef resu
        l

    uc hx 1.1
    81 10 e
        r e
        tj, 
    ref
        tj  1, ref su lt, _p r
    uche
        (x, -2
    .3650e-02, f tj,  ref tj1 ,  ref result , _params);
    ucheb(x, -5.242235e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.173571e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x
          - 3.03
    661e-0
        , ref tj,
    r
        ef tj1
        re arams)
    ;


    uc
    heb(x, -7.8 - r
    f tj,
        t
    j1 , _par
        , -2.0
    f tj, 
    ref
        t
        _p ar ms);


    (
        -0 6e-06, r ef t, r
    ef tj1,  ref
        r
        e
    s
        lt,
        _


    155 e
        tj1, f
    res ult, _par
    a
        s);


    che
    (x, -1
        .
    17130e-
    0
    6, tj1,

    r
    e
        result, _par
    a
        s);


    che
    (x, -2
        .
    40966e-
    0
    7, tj1,

    r
    e
        result, _par
    a
        s);


    che
        (x, 2.
    0
    1235e-0
    7
        , tj1,
    r
        ef e
        sult, _params;


    u
        heb
    1.6
    4052e-
    0
        , ref t
        j,
        sul t,
    _
        p
    a
        a
    ms)

    r
        e
    urn
        result
        ;
}


/*************************************************************************
Tail(S, 11, 11)
*************************************************************************/
private static double utbln11n11(double s,
    alglib.xparams _params)
{
    d
        ubl e
    su t = 0
        ;

    double tj
        =
        0;


    d
        o
    ble
        tj1 =
            0


    i
        n
    2 * (s .0
    0
    000
        + 00
        )
    3.7
    0000e+
    0
        - 1, 1.0
        )
    ;
    = ;


    t =
        che
    b
        x, 
    4.5 19 76 0e 0
        , ref t
        j,
        esult,
        _
    aa ms);


    u
    he bx, 
    -
        .886 94 e
        r ef r
    e
        s
    u
        t, _pa ram s)

    uc eb
        x, 
    -
        .2 0
    98e+0 0, r
    f tj, r
    e
    fj lt,
        _
    ar ams);


    u
    heb(
        , -
            2. 740
    2e-01, r
    f tj, r
    e
        , _pa
    r
        as
        ch eb(
        , -6 072
    3
    4e-
    2, ref

    j, ref tj ,
    para ucheb(x, -2.054773e-02, ref tj, ref tj1, ref result, _params);
    ucheb(x, -6.506613e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.813942e-03, ref tj, ref tj1, ref resul
        , _par
    ms);


    u
    cheb(x
         - 1 ref t
    j
        , ref t
    1, ref
    result, _pa
        uch
    b(x, 2
    71 6
    f tj1,
        r
    f
        r
    es );


    166e-0
        , r ef t,
 
        ,
        _ ara
        s;

    3
    2
    e
        -
        04 , re ft j,  ref t
        j
    1
        , ref r sult _
        p
    a
        r
    ms)
    ;


    he
    (,
        lt, _
    p
        a
    r
        ms );
    u
        c
    heb
        x,  1 96859
    0
        - 04
        ref t
        j
    1 f rs lt, _param
    s
        ;


    u
        c
    eb(
        , 2.63
    0
    32e-04,

    re 1, re
        f

    r
    s
        ult, _params
        )


    uc
        h
    b(x
    5.061
    0
    0e-04,
    r
        ef,  ref
        r
        e
    u
        lt, _params)
    ;


    ret
        u
    n r
        sult;
}


/*************************************************************************
Tail(S, 11, 12)
*************************************************************************/
private static double utbln11n12(double s,
    alglib.xparams _params)
{
    dou bl e re u
        l
    t do
        bl x =
            0;


    ou le
        t
            = 
        ;


    d ou b
        j1 = 0;
        = 0


    x = Mat h.i
        (2 *
            s - 0.
        + 00
        )
    3.700 00 e + 0
    0


    t j
    1;
        =


    ucheb(x
        ,
        ef tj
        ,
        r
    f
        tj1,  ref
        uc4  .83
    2
    6
    2
    e + 00 , ef tj,  ref
        j1 ,
        ef

    esul , _
        p
    ram
        );


    u
        c
    ref t j, r e
    1,
    ef

    esu
        t,
        _a ra s
        ;

    uche
    b
    (
        -01,
        r
    e
        f
    t
        j, r ef re
    ul t, _ pa am s)


    uc he(
        ,

    ref
        t 
        ,
        r f tj1,  ref
        esu
        t,
        r;

    uc eb(
        x, 02, r f
    re f
    t
        st, _params);
    ucheb(x, -5.347406e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.353464e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, 6.613369e-05, ref tj,
            ef tj1
        ref r
        sult, _par
    a
        ms);


    (x, 5.
    1
    02522e-
    4, ref
    tj, ref tj1
        _p
    5.2377
    9
        -
        4
        ,
    tj1, r
        f
    e
        u
    l
        (
            x
        ref tj ,e
        lt,
        _pa
    r
        a
    m
        s
        )
    ;

    uc
        h
    e
    b(x, 1.6 26 0
    3e- 4
        ,j
        j,
        ms)


    -1.
    1
    67 8
    e
        - 0 , ref tj, f t
    1,

    ef
    esu
        l, _
    arams );


    u
    64 45 e -
        05
    ef t,  ref tj1 
        ,
        r ef r
    su
        l,
        _
            as )
        .
    0
    4
    7
    2
    0e-04, ref t
        j
    re
    t
        j, r
    f r
    e
        ult
    _para
        m
        );


    resul
        t
        ;
}


/*************************************************************************
Tail(S, 11, 13)
*************************************************************************/
private static double utbln11n13(double s,
    alglib.xparams _params)

dl e
es
    ul = 0
e x
    =
    d ub e
    j
        = 0;
do
    u
        le
j1

0;


res ul t =
    2 * (s - 0
        .
0
0
0
00e+00)/3 70 00 0
    + 00
1,

.0)


tj = 1;


uche(
    x
    -
    4. 47 880e+00, r e
tj
    r
e
    tj, r
e re su lt _ param
    s
    ;


24 e + 00
r
f
    tj, r f tj1,
    r
ru , _
    arams) ;


69 + 00
    ,

r
    f tj ref j1, r
    e, _
p
    ram
    );


e 1739 e - 1
    ref tj, ref
t
1,
ef

ul t,
    _p ar a
m
    );


u heb(x
    ,
    -, r f
t
    j,
    r
ef tj1, r ee lt,
    ra m
    uch
eb(
    ref t
j
    ,

tj1 ref re su t
    _p
ra
    m
    );


ucheb
(
    , -51 76 tj, re
tj1,
    ref result, params);
ucheb(x, -1.817895e-03, ref tj, ref tj1, ref result, _params);
ucheb(x, -5.842451e-04, ref tj, ref tj1, ref result, _params);
ucheb(x, -8.935870e-05, ref tj, ref
    tj1, r
f resu
    t, _params
    )
;


8.421
7
77e-05,
    ref tj,

ams);


u
    c
e - 04 re
    j
r e
s
    );
uche
(x,
    8
8
6
    ref tj 1, r
    e
a
    ram
s
    )
;


uche
b
(
    x, 1.458255e 0
5
    , ef
    t
re
u
    t, p ms
    ;


x, -3
.3 6
5
9e-5 ref t
    j
re
1
    ,
    ref
re sp ra
    m
s
heb(x
    ,
    -
        1487 - 05, e
f
    t,
    re f 1,

ef
esul t, _pa
ams) ;

resul
    t
    ;


}


/*************************************************************************
Tail(S, 11, 14)
*************************************************************************/
private static double utbln11n14(double s,
    alglib.xparams _params)
{
    do
        u
            le
    es ul t
        = 0


    doub
    l
        x = 0;


    tj =
        0
        ;
    l tj1 = 0;
    esu
        l
    t


    0;
        = M
        a
    Mi
        * (-0 .0
    0
    000e+00
        )
        /
    ;


    tj =
        tj1
            = x;


    uc h
    eb 3e 00 r e
    f
        j,  ref tj1 , r
    su l,
        _
    ara
        s);


    ch e
    b
        x,  -4.7
    6
    6
    tj1 , e
    f
        sult, _ pa a
    m
        s)
    ;


    u
        heb
    (
        , -. 11 70 82 + 0 0
        ,
        ref tj,

    r
        _par am )
    ;
    u
        c
    he
    b
        x,  -1
    73
    9
    74e
    01,

    ef j, re f j1, r
    f resul
        t,
        uh eb x, -4.238
    8
    02
    r
    e tj, f j
    1
    re f res
        u
    l
        c
    heb(x, -1. 35 06 - 02
        ,
        ref
        tj, re
    f
        , ref
    re su );


    ucheb(x, -
        4
    4258 1e
        -
        3,
    ef
        t, r
    f tj1, r ef e s
        u
    l
        u
    c
    472e-03, ref tj, ref tj1, ref result, _params);
    ucheb(x, -6.660633e-04, ref tj, ref tj1, ref result, _params);
    ucheb(x, -2.879883e-04, ref tj, ref tj1, ref result, _params);

    ucheb
        x,  -1.
    49658e-04,
    r
    ef tj,
        r
    ef sult,
        _
            params)


    ucheb
        - 05, r
    f tj, f
    t
        j

    ch
    b
        x, 
    ref tj , 
    ref
        t 
    1
        ,
    para ms )

    uch
    eb x, 
    -
        3
            .
    0
    2
    4
    201e-0 5, re tj, ef t 1, ref e
        s
    ul _p
    a
        c
    e
        b
    5, r
        e
    f
        t, 
    ref tj1 , re
    r
        su t
        _
    pr as;


    u
        c
    eb(x, 4. 5
    9
    67 tj , ef
        t 1 re result, _pa ms)


    etu
        ru
}


/*************************************************************************
Tail(S, 11, 15)
*************************************************************************/
private static double utbln11n15(double s,
    alglib.xparams _params)
{
    d = 0;


    doub
        l
    x
    0
        ;


    ouble
        t
            = 0;


    le tj
    1
        = ;


    r
        sul
            = 
        ;


    x
    Math.M
    n(2 * (s -
           0. 0
    000 0e+
    0
    0
        -
        ,
    1.0);


    tj


    tj1
        x;

    b
        x,  -6 e
    00
        , ef t,
        f resul
        t,
        ucheb(x,
        -
            .74
    57
    0
        + 0 0,
        ref

    j, e f tj 1, re
        f
    s
        ucb e + 0
    0
        ref tj, re
    f
        tj1, re
    r
        e


    c
        he b(, -1.650 61 2
    e
    01,
    re
    f
        tj, 
    ref
        , r
        esult,
        param s)


    3.85 2
    8
    5
        -
        02 , ef tj, r ef
        t
    1,
    ef

    esu
        t,
        _
    am s


    uc he(
        x
        ,
        tj, e
            f

    j
    1, r f result, _
    ara
        s)
    ;


    uc
    eb(x, -
        3
    689241e
        -
        0
    tj , rf res lt, _pa ra s
        ;


    b(x,
        1 .2 94 36 e - 03
        ,
        , re res lt, _pa r
    ucheb(x, -5.072623e-04, ref tj, ref tj1, ref result, _params);
    ucheb(x, -2.278008e-04, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.322382e-04, ref tj, ref tj1, ref result, 
            params
        ;

    uch
        e
    b(x, -
        .
    13 f tj,
        r
    ef tj1, 
    ref res
        ult, _param
    he(x, 7 .305
    6
    e - 0
    _param
        );

    -6 .8 5627 - 05
    e f
        s
        ;


    u
        c
    h
        e
    b(x, -.332 8
    9e- 05 ref tj, ref t 1
        ,

    ef r es u, a
    a
        m

    c
        e
    b
    5, r ef t
        j
    ef tj1,  ref e
        ult
    _ pa rs;

    retu
        r
    n
}


/*************************************************************************
Tail(S, 11, 30)
*************************************************************************/
private static double utbln11n30(double s,
    alglib.xparams _params)
{
    ult =
        0
        ;

    d
        o
    ble
        x
            =
            0;


    doub
    l
        tj = 0
        ;

    ouble

    t
        j
            = 0;


    re
        s
    lt
    0;
        = Math
        .Mi 000e+
    0
    0
        )
    3
    .700000e+00 -
        1
    1.
        );


    t
        = 1;


    t
        u
    c
        h, 
    -4.402621e+
    0
        , r
    f tj, 
    ref
        tj ,
        ef e sult,
        _
    ara;


    ce b(x
    -0
        , r
        ef tj r f tj1,
        r
    f resul
        t,
 
        ,
  -1.01 3
    3e+
    0, r
        t
    1, ref r
        ep u
        c
    eb(
        ,
        -
            .22
    12 6e - 0 1
    re
        tj, r
    e
    t j1, re r
        es u _params);


    .2
    3
    85 6e - 0 2, re
        f
    t re f resu t,
        _params) ;


    u ch(x,
        -5.
    8
    934
    e - 03,
    r
    f tj, r ef t
    pa ra s)
    ;

    ucheb
    (
        -1.
    77
    3
    1e-
    3,
    r
        f t j
    ef tj 1,
    r
    f result,
        u h
        e
    b(-3.75 67 9e-04
        , r ef t
        ,
        r
    f t
    1,
    r
        f r
        lt, pa ra
        m
        );


    3323 0e 0
        , ef t
    j
    r result, _params);
    ucheb(x, -2.875472e-05, ref tj, ref tj1, ref result, _params);
    ucheb(x, -8.608399e-06, ref tj, ref tj1, ref result, _params);
    ucheb(x, -3.102943e-06, r
    f tj,
        ef tj1
        ref resul
        t, _par
    m
        s) uche
    b
        (x, -1.
    40693e-
    06, ref tj,
    sult,
    param s) ;


    (x, -1
    3
    31 9
    e
    f tj1, r ef e
    t
        c
    e
        b6 8
        -
        0
    1

    ef r
    e
        sul,
        _p r
        a
    m
        s
    ucheb(x, -6
    ef
        t,
        r
    sul
        ,
    _
        p


    re t
}


/*************************************************************************
Tail(S, 11, 100)
*************************************************************************/
private static double utbln11n100(double s,
    alglib.xparams _params)
{
    oube r su t =
        0;


    d u
        b
            = 0
        ;


    ble t
        j = 
        ;


    oub
        j1 0


    r
    e
        su
            = Math.Min(2
                *
                s - 0
    00
    0
    00e
    00)
        /
    .70
    000e+0
    0
    1, 1.0)
    ;

    j = 1
        ;


    tj1
        x;


    che
    (x, -4
        .
    98795e+
    0
    0, tj1,

    r
    e
        result, _pa
    r
        ms)


    heb
        x,  -4.5
    9
    486e+ 00 ,
    r
        e
    ref r
        e
    s
    u
        t, _p arams);


    che
    (x, -14, ref
        t
    j
        , ref r su t, _p aa
        u he b
    r et f t
    1,

    ef
        esu
    l
        am
    s
        uc hb 9e- 02 , r
        e
    f
        j,  ref t j1, re f
    res
        lt,
        _pa
    s)

    (x
        ,
        0
    3
        , re f tj, re f
    t
        j, r
    f
    r
        sul, p
    a
        );

    u heb(x
        ,
        rj

    ref tj1 ,
        r
    re
        ul
    t
        _p
    rams )
    ;


    ce b(x
        ,
        tj, re f

    j1 , ref

    esu
        t, _ ram;


    uc eb(x
    -5.360 07 e
        -
        tj1,
    ef res ul t
    ucheb(x, -1.260869e-05, ref tj, ref tj1, ref result, _params);
    ucheb(x, -3.033307e-06, ref tj, ref tj1, ref result, _params);
    ucheb(x, -7.727087e-07, ref tj, ref tj1, ref re
    ult, _
        arams)


    uche
    (
        x, 07, re
    f
        tj, re
    tj1, r
        e
        ;

    u
        h
    b
    (
        e
    jt ef res
        _ a
        a
    ms u he, 
    1
    9
        ref tj
        ,
    r
        e
        )
    ;


    u cheb(x
        ,
        3.898823e 0
    9, e
        f
    r
        e
    lt
        p
    a
    resu
        lt;
}


/*************************************************************************
Tail(S, 12, 12)
*************************************************************************/
private static double utbln12n12(double s,
    alglib.xparams _params)


d u
ble result = 
    ;
do
    ble
        = 
        ;


o e t
1 = 0


result 0;

2 * (s - 0 .0 0
0
0e+00)/3.700
0
0e+
0 -
    1
1.;


tj

1;


x;


ucheb(x
    ,
    -4.
72
6
6e+
0,
r
f t,  ref
    t 
1, ref
r
    es );


ucheb(x
    ,
    -4.
86
6
7e+
0,
r
f t,  ref
    t 
1, ref
r
    es );


ucheb(x
    ,
    -1.
32
0
9e+0 , r
e
    t, 
ref t  1
    ,
    ref resu lt,
    cheb(x, -1.817
52 e - 0
    ,
r
    ef
t
    j, _m


uc b(5 02,
    r j1, r f

re ul, _m


ub , -1.4 79 51 1
f tj1, re f
    esult, _para ms )


heb x,  -4.
99492e-0 ,

r
    f
r esult _ param
    s
    ;

ch eb x,  -.56535
0
    - 03, r ef ref tj1 ,  ref
    re s, _ arams);


che
(x,
    30
e - 04,

ef t, r
e
f
    result, _
ucheb(x, 1.380132e-04, ref tj, ref tj1, ref result, _params);
ucheb(x, 3.242761e-04, ref tj, ref tj1, ref result, _params);
ucheb(x, 3.576269e-04, ref tj, ref tj1, ref result, 
        params
    ;

uch
    e
b(x, 3
0
18 tj, r
    e
f tj1,
    ef resu
    lt, _params
uch eb x, 
933911 -
    4
1, re f s
    l, 


2799e-
5,
e
    t, f res ul t
    a
ms
    ch eb x,  2
    .
0
2
2048 e - 6, ref t j, , r
ms
    ;
urn e
u
    lt;
}


/*************************************************************************
Tail(S, 12, 13)
*************************************************************************/
private static double utbln12n13(double s,
    alglib.xparams _params)
{
    res
        u
    l
        t
            =
            0;
    d o
    bl
    e
        x =
            0;

    do
        u
            d
    o
        u
    l
    e tj1 = 0;


    esu l
        ;


    x = Ma
    t
        h
    e + 00)
        /
    3
        .
    00 00 e + 00 - 1, 1. )
    ;

    t
    1;


    u cb .454800e+
    0
        , r
    f
        t, r
    f t
        j, r
    f resu
        l, _para
    m
        s) uch
        e
    b
    (
        ,
        -4.750794e+
    0
        , r
    f
        t, r
    f t
        j, r
    f resu
        l, _para
    m
        s) uch
        e
    b
    (
        ,
        -1.105988e+
    0
        , r
    f
        t, r
    f t
        j, r
    f resu
        l, _para
    m
        s
    ucheb x, 
    -
        1
    .6 4754e-01,
    e f tj
        r
    ef tj 1,
        ref

    esu
        t, _pa
    rm s) ;


    -4.018 2
        ,
    r
        f j
        r
    e
        tj1 r e
    ch b(x1
    262
    79
    e - 2, r f j, t resul
        t,
        uh eb(x, -4 .0 44 492e-03
        ,
        ref
        tj
        ,
        ref
        tj1
        ,
        ref
        res ul t,
        _
    ara m
    u c(
        -
            .4 78 74 e -
                     03 re
    tj
        ,
    reft j1 ref su lt, _
    p
        a
    u he
    b
    (
        x
        - 5.3 22 165e-04,
        ef
    j,

    ef t 1,
    ef
        esult,
        params)
    ;


    , -. 621104
    e - 04, ref t ref tj1, ref result, _params);
    ucheb(x, 4.068753e-05, ref tj, ref tj1, ref result, _params);
    ucheb(x, 1.468396e-04, ref tj, ref tj1, ref result, _params);
    ucheb(x, 2.056
    35e-04
        ref t
        , ref tj1,
        ref re
        u
    lt
        uc
    eb(x, 2
    .327375e-04
        , ref
    esult,
    _
        a
    r
    ucheb(x 1
    87 7
    j1, rf r u
        t,
        uc he(
        ,
        7 ef tj, f j
    t
        aram
    s) ;


    t sult;
}


/*************************************************************************
Tail(S, 12, 14)
*************************************************************************/
private static double utbln12n14(double s,
    alglib.xparams _params)
{
    doub le re
    su t = 0


    ob le x
        =
        j = 0;


    do
        bl
    e
        tj1 = 0


    r s
    ut 0;

    Math
        .M in (0 00
    0
    00e +
        3. 7
    0
    000
        + 00 - 1,

    .0;


    tj 1 x;
    eb(
        x
        - 4
    440910
    e
    00, ref j
        u
    l
        t, params);

    x
        - 4
    722404
    e
    00, f ef tj
    1
        ,

    e
    f result, _p
    a
        ams
        ;


    uc
    eb(x,
        -
            .085254
    e
        + 0 ef tj
    1
        ,

    e
    f result, _p
    a
        ams
        ;


    uc
    eb(x,
        -
            .579439
    e
        - 0 ef tj
    1
        ,

    e
    f result, _p
    a
        ams
        ;


    uc
    eb(x,
        -
            63738e- 2
    tj1, r e
    f
        r
    su t, _params);


    uc
    eb(
        x, -1.
    6673 0e-
    0
        , ref e f t
        j
    1
        ,
    r
        ef res lt
    _
        ps heb(x, 3
        .f
    tj, ref tj1, ef,
    .0 14 53 1e -
        0
    3
        ,
    r
    ef tj, r ef tj
    1
    re
        r
    e
        ult
    _pa r
        ;


    u he b
    e - 4, j
        ,
        ref
    tj 1, re
        re
    s
        lt,
        _pa ams)


    -8.00 09 00 ,ef tj,  ref tj1 ,  ref result , _params);
    ucheb(x, 1.996174e-05, ref tj, ref tj1, ref result, _params);
    ucheb(x, 6.377924e-05, ref tj, ref tj1, ref result, _params);
    ucheb(x,
        8.9363
    4e-05,
        ref tj, re
    f
        tj1,
        e
    f ams);


    uche
    b(x, 1.0510
    j, ref
    tj1, r
        f
    su l
    uh eb x,
        f tj, r t
    1
    r e ams);


    u
        c
    05, r f
    r
        e
    p
        rams) ;


    return r es ul t;
}


/*************************************************************************
Tail(S, 12, 15)
*************************************************************************/
private static double utbln12n15(double s,
    alglib.xparams _params)
{
    ou bl r
    es l = ;
    oub x

    0;


    d ouble
        j = 0;


    ;


    res ul = 
        ;


    x = Ma th Min(2 * (
        s
        -
        .7000
    0
    0
    e + 0
        -
        1, 1 0);


    j
        =
        1;

    tj1
        = x
    ucheb(x -
          4
    .4 012 3e 00, e
    ft j, r
    f j 1,
        ref
    e su t
        _para
    m uc h
        e
    b
    (
        ,
        -4.700008e+0 0
        , r
    f j re
        j1
    rf r s
        l, _
    p
        rams);


    , -1.0689 1
        + 00
    r et tj1
        ref r
    e
        ult, _p
    a
        ra
    u
        c
    h
    b
        (x, -1.49972
    5
        - 01
    r
        e
    tj
        re
    f
        tj1
    ref r
        e
    ult, _p
        a
    ra
        u
    c
        h
    b
        (x, -3.25089
    7
        - 02
    r
        e
    tj
        re
    f
        tj1
    ref r
        e
    ult, _p
        a
    ra
        u
    c
        h
    b
        (x, -9.47314
    5
        - 0 ,
    re
        f,
        ef t , r
        f resu lt,
        _para s) ;


    heb(x, -
        2
            .
    8
    0
    00 e - 03, re f
        t, r
    f
        t ef r
    e
        t, _pa
    r
        a
    uche
        b
    (
        x
        - 8 48 350e- 0
    j,
    r
    ef
        j1, r


    ucheb(x - 29 0
    f
        j, r ef t
    j
        ref r es ul t,
        c
    h, -9. 9
    18 1 - ref tj r e
        esu
    ucheb(x, -4.015140e-05, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.977756e-05, ref tj, ref tj1, ref result, _params);
    ucheb(x, -8.707414e-06, ref tj, ref tj1, ref result, _
    arams)


    ucheb
    (
        x, 1.1
    4
    78 j, ref

    tj1, re
        result, _params);
    eb(x
    6.238
    65 -
        0
    tj1 ,e
        es u_params);


    u
        - 05, ef
        j,
        su lt , _p
        r
    m
        s
    n
        resu
    l
        t;
}


/*************************************************************************
Tail(S, 12, 30)
*************************************************************************/
private static double utbln12n30(double s,
    alglib.xparams _params)
{
    double

    esu
        t
            =
            0;


    d
        uble x

    0;


    tj =
        d
    ubl
        t 1


    esu l
        x
            =
            M
    ath.Min(2 * (s
                 -
                 .0 00 0
    0
    0
        / 3.
    000
    0
    e + 00 1, 1 0);


    cheb x,  - .
    80 2e + 0 , re
        j, rf t
        j, _pa
    r
        am s
        u
    heb
    (, -.58 782 e +, r f tj
        , r
    lt,
    _
        pa r
        u
    heb
    (
        , -
              8583 -
          0
        , ref t
    j
        ,
    esult
        ,

    _
        a
    rams);
    ucheb(
        x
    1.
    03394e, ref r
        e
    s
    u
        t, _params);


    u
        heb
    (
        , -
        .83401
    5
        - 02, re
        f
    t ref r
        e
    s
    u
        t, _params);


    u
        heb
    (
        , -
        .63521
    2
        - 03, re
        f
    t ref r
        e
    s
    u
        t, _params);


    u
        heb
    (
        , -
        .94 212
    e
    04 ref
    t
        esult _ p
    a
        a
    ms);


    uc eb
    (
        , -574
    1
    9e - 4, ref tj,
    f es lt,
        u
    heb
        x, 
    -
        .74
    980 - , re t j,
        re esult
        ms )
    u he(x, 3 67 2
    tj1,

    re f
        sult, _param s
        )

    u 5.
    3e - j f tj1,
        rf l _params);
    ucheb(x, -2.181038e-06, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.206473e-06, ref tj, ref tj1, ref result, _params);
    ucheb(x, -9.716003e-07, ref tj, r
    f tj1, 
    ref re
        ult, _para
    m
        s);


    x, -7.
    4
    76434e-
    7, ref
    t
        _pa ram
        );


    7.2 770
        ,
    f
        ;


    r
}


/*************************************************************************
Tail(S, 12, 100)
*************************************************************************/
private static double utbln12n100(double s,
    alglib.xparams _params)
{
    0;


    dou bl x =
        0


    d
    uble t = 
        ;


    r esult = 0
    x = t M
    n(2 * (s -
           0
               .
    00000
    e
        +
        0
        -
        1, 1.0);


    t
        = 
        ;


    tj1
        x;


    -4.37
    4
    5
    6
    e
        + 00, ref, e
        re
    s
        lt,
        rams)
    ;


    4.553
    4
    8
    1
        +
        0
    0, ref tj, r
    e
        t, _p rams);


    1334e
        -
        0
    1
        ref tj, re
        tj
    1
    re
        r
    e
        ult
    _p
        a
    ams
        uc
    h
        e
    02, r f

    t
        f t 1
        ,
    r
        e
    su
        t,
        pa ra m

    c(2, re
    f
        t,  ref tj1 , r
    e
        re
    ul
        t
    _p
    ram
        s
        ;


    ucheb
    (
        x, 03, r
    e
    f
        j,  ref tj1 ,
        r
    f r
    su
        l, _
    ara
        m
        );


    uche
        b
    (x - 04,
        r
    e
    f
        tj,  ref tj1 ,
        ef
    es
    u
        t,
        par
    a
        s);


    ucheb x
    4, r ef
    t
        j,
        re t j1,  ref r
        e
    ult
        _
    p
        ra ms )


    uc he
    b
        x,  -3.30 60e-0
    5
        ,
    r f tj,  ref t
        r
    sul
        , _p ra s
        x,  -7
        .
    3
    1
    501e-06, re
        t
    r
        j1, 
    ref
        res
        u
    t,
        params


    1.71
    3
    8
    8
    e
        - 0 6, r ef tj,  ref
        j1 ,
        re
    f
    res
        lt,
        pm h b(x
    -3 30 95
    83e-07, refj, ref tj1, ref result, _params);
    ucheb(x, -4.019804e-08, ref tj, ref tj1, ref result, _params);
    ucheb(x, 1.224829e-09, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1
    349019
        - 08, r
    f tj,  ref
        t
        j1, re

    re s);


    ucheb(
        x, -1.89330
        , re f tj 1, re
    re s);

    r
}


/*************************************************************************
Tail(S, 13, 13)
*************************************************************************/
private static double utbln13n13(double s,
    alglib.xparams _params)
{
    d
        ub le r
    su t
        = 0;

    d o
    u
        bl d ub e
        tj = 0;

    d ou l
        t 1
        = 0;


    r s
        lt = 0;


    x = at h.Min(2 * (s - 0.
    00 00
    e + 0 / 3 .7
    000
    0e 00 -
        .0);


    tj1 = x;

    he b(-4
        .
    41 , ref

    r
        e
    u
        lt, _p ram s
        )
    ;


    u
        heb
    (
        , -
        .85904 7e +
        tj1,

    r
    e
        result, _para ms;
    u heb(x, -1.1 0164e+
    0, r f tj1 f res
        u
    l
        t _p rams);


    uch eb x,  -1.
    6
    971
    e - 01,
    r
    f tj, f resu lt, _
    m
        s);


    ch
        x, 
    95
    693
    e
        ,
    tj,
    r
        j1, re
    f r_ a
        a
    ms);


    u
        he
    b
        x, 
    1.2
    3
    455
        - 02, r
    e
        tj, re
    f
    t lt, _
    p
        a
    r
        ms);


    ch
    e
    (x,
        -3.
    9
    655
    e - 03,
    r
    f tj, r
    e
    f ult,
        _
    p
        a
    ams);


    uc
        h
    b(x
      - 1
          .
    384
    5e-03,

    ef tj,
        r
    ef sult,
        _
    p
        rams);
    ch b
        x, 
    7.2
    4
    3e-
    4, ef t
    j
        ref tj
    1
        ,
    ara s)
    ;


    uch, -
        .14
    7e-04
        , ef tj, tj1,  ref resul
        t,
        pa ms)


    uche(x,
        , ref
        t 1, ref result,
        _
    ara
        s)
    ;

    u eb(x,
        -
            2
        , ref
        j1, re
    f result, _rams);
    ucheb(x, -1.488405e-04, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.156927e-04, ref tj, ref tj1, ref result, _params);
    ucheb(x, -7.949279e-05, ref tj, ref t
    1, ref
    result
        _params);


    7.5327
    0
    0e-05,
    ef tj, 
    ref tj1 , re
        ;


    e
        u
    r
}


/*************************************************************************
Tail(S, 13, 14)
*************************************************************************/
private static double utbln13n14(double s,
    alglib.xparams _params)

dou bl r
e
    ult
        =
        0


ou b
e x =
    0


d ou le tj1 = 0;


r
sul t =
    x = M th.M n
    )/3 75
0
0
0e + 0 - 1, 1.0) ;


j =
    1;


tj1 = 
    ;

55e 00
    ,

rf t,  ref tj1  ref result ,
    par a
    ;


uc
    h
e
00, re
    f t
    j

r
ef tj1,  ref r s
lt,
_p
a
    ams
    ;

ucheb(
    x - 1 .10811
0
e + ref t
    j
1
    ,
r
    ef l _p ra
    m
    );


uche
b
    x,  -1.5
7
9
f tj,  ref tj  1, r f re
    ul
t
    _p
ram s) uc b(x, -.tj, rt 1
    ,
r
    e
re
    ult, para s);


uc
he(x, -1.
0
3
e
f tj1,  ref r
    e
ult
    _
p
    ram
    );


u
heb(x,
    -
        2. ref t
j
    ,

ef tj1,  ref
    r
    sul,
    _
ara
    s);


cheb(x,
    -9 ref
    t
j
    ,
    ref tj1, ref

esu
    t,
    par
ms)
;


ucheb(x
    ,
    -, ref
    t
j, ref tj1 ref
re ult
_
    p
ram s)


uche
b
    x,  -1.3
3
8
    ref t
    j
1
    ,
    ref res
    _
aram );


u , re
    f
t jf 1
r
    e
re
    ul, ara
s);


u
02 3 - 5,

ef
    re f f esul
    t,
    uch
b(x, -
    1.110570e-0 ref tj, ref tj1, ref result, _params);
ucheb(x, 4.202332e-06, ref tj, ref tj1, ref result, _params);
ucheb(x, 1.056132e-05, ref tj, ref tj1, ref result, _params);
ucheb(
    , 1.53
323e-0
    , ref tj,
r
    ef tj1
    re arams)
;


re
turn result;
}


/*************************************************************************
Tail(S, 13, 15)
*************************************************************************/
private static double utbln13n15(double s,
    alglib.xparams _params)
{
    do
        ub e re ult =
        0;

    double tj = 0


    ou
        be t
    1 = ;


    x
        Mat Min
    2 *
    (
        -0.
    0000 + 00
        / 3 .7 000
    0
        + 00 - 1 , 1.
    0
        )
    tj = 1


    tj 1
    x;
    che b(,
    -4 135
    5e + 0 , r
    e
        tj,  ref
        t
        j
    _ pa ra s) ;


    u h
    eb(-4. 395 + 00, ef t re
    t j1 re
        f
    res ul t, _
    p
        a
    u he b
    (
        x
        - 1.09068 6e 0
    0,
    r f t j, r
    tj
        , r
        e
    r s
        lt, _p
    ar ms);


    , -1.
    4
    9
    5
    10 e - 01 r ef tj, re
    f
        tj1 re
    es l, _p
    a
        ams
        ;


    ue 0314e - 0 2,
    t
        j,  ref tj1 ,
        r
    f r
    l
        t _p ar
        );


    3124e
        -
        0
    3
        ref tj, reft 1
    e
        f
    res
        lt, _ par
        ms);

    13 e - 0
    3
        ,

    e
    f tj,  ref tj 
    1
    re
        r
    e
        ulp ara eb(x,
        -
            7
    4
    78239e-04, r
        e
    tj
        r
    e
        tj, r
    e
    re
        ult, _
    p
        rams);


    eb(x,
        -
            2
    1
    40914e-04, r
        e
    tj
        r
    e
        tj, r
    e
    re
        ult, _
    p
        rams);


    eb(x,
        -
            5
    3
    11541e-05, r
        e
    tj
        r
    e
        tj, r
    e
    re
        ult, _
    p
        ra s);


    x, -2. 67 7
    1
    5e-0 , ref tj,

    ef
        j1, 
    ref
        sul
        t
    _p ams);


    h b(
        x
        , 115464 - 05, rj tj
    1
    re
        esult,
        _params
        )
    ;
    c(,
        1
            .
    7856 - 0 5e ef t
        j, r f es up ar ms);


    (2.044604e-05,  ref tj, ref tj1, ref result, _params);
    ucheb(x, 1.888939e-05, ref tj, ref tj1, ref result, _params);
    ucheb(x, 2.395644e-05, ref tj, ref tj1, ref result, _params);


    return
        result;
}


/*************************************************************************
Tail(S, 13, 30)
*************************************************************************/
private static double utbln13n30(double s,
    alglib.xparams _params)
{
    re
        u
    t
        oubl
    e
        x
            =
            0;

    d
        l
    e
        tj
    0;
    do


        r
            esult = 0;


    x at
    hM in (2 * (s -
                0
                    .
    50 00e+ 00 1
        . );


    j = 1
    1 x;


    (x, -
        4. 45 9
    99 + 00, ref
    t
        , r
        f
    t
    1,
    ef
    r
        sul, _p ar am );


    34 + 00, r f
    tj ref tj 1, r
        ef

    esu lt _
        p
    ram
        );


    uc eb(
        ,

    -9.99
    5
    4
    f j1, re
    es lt, _pa ra s
        );


    uc
    eb(
        x
        - 1
    07 81 00 e - 1,
    ef tj,
        r
    e
        _ aram s)

    uc eb
    (
        , -. 72 - 02,
    r
        f t j, re f
        t
    j
        _param s)


    uche
    b
        x, 
    4.
    28 3
        ref t
        j
    f esul,
        p ar ms);


    ch
        e,  -
        .67
    1
    26e
    04, re
        f
    re
    f
        t, _p
    a
        r
    a
        s
        );
    -2.
    1
    58e0 4, r
    e
        tj,  ref
        , _pa
        r
    a
        m
        )
    ;


    u
        he
    b
        x, 
    5.5
    07 64e
    05, re
    f
        tj,  ref
        tj t, _p
    a
        r
    a
        s
        );


    uc
        eb
    (
        , -
        .41
    1
    46e
    05, re
    f
        tj,  ref
        tj t, _p
    a
        r
    a
        s
        );


    uc
        eb
    (
        , -
        .04
    4
    55e
    06, re
    f
        tj,  ref
        tj t, _p
    a
        r
    a
        s
        );


    uc
        eb
    (
        , 1
    285
    76 e - 0
        , r f t
        j
    ref t j1,
        r
    ams);


    ucheb x, 
    -5.4 5e ref tj
    r
        esult,
        _
    a
        rams);
    ( .
    te r result, _params);
    ucheb(x, -1.962037e-07, ref tj, ref tj1, ref result, _params);
    ucheb(x, -1.723644e-07, ref tj, ref tj1, ref result, _params);
    return result;
}


/*************************************************************************
Tail(S, 13, 100)
*************************************************************************/
private static double utbln13n100(double s,
    alglib.xparams _params)


b
    ;

d o
ub
l
    tj
        =
        0


oub le tj
1 = 0;


x = Ma t
    h
Min
2 *
(
    -0.e +
    0
) / 3.750
0
0
j = 1;


tj
1
    = x
uc he(x, .44 67 7e+
tj 1, su
    l, _
a)

u heb x, 
640804
e
    +
    tj1,

r
e
    result, _par
a
    s);


uch
e
    (x, .67 552 e -, r f tj, e
t, _pa ra m
    s
    ;


ch eb(
    9
        .
649
0e-
0, r f
tj re f j, ef r es l
    t

u
    c
e
b(x, -1.2744
4e - 0 2, r f
    t, r
f t
j
    ef
sul t, _
p
    ms);


, -3.
0
4440e-03, r
    e
tj re f tj, r
f r
e
    ult
_ pa ams)

1439e - 0 ,

e
f tj,  ref tj  1, r f r
su
    l, _
ara
    m
    );

ucheb(x2 4
    ,
    r
ef t j, r f tj1,
    r
f rs ul, _ par am );


heb(x,
        -
    ref tj , re t j
1,

ef
    es
u
    t,
    am
s)

u
(x, -5
    .
35 f tj,
    re t
    j1,  ref resul
    t
_p
    ra
m
    );


uche
b
    x,  -1.2
7
54 tj, r
    e
f
    j
1, ref resul
    t
_p
    ra
m
    );


uche
b
    x,  -2.7
4
76 tj, r
    e
f
    j1,  ref resu
    l, _
ar
    a
s);


uch
e
    (x, -5.
7
00 tj,
r
    e
f
    t
j1 ref re u
    lt,
    _p r
    ms
    )


b(x, -
    2
565559e
    -
    0
j1, r
    ef
r
s
    ult, _p


che(x, 5.0
0
396e-09
    ,
    ,r ams);
ucheb(x, 3.335794e-09, ref tj, ref tj1, ref result, _params);
return result;
}


/*************************************************************************
Tail(S, 14, 14)
*************************************************************************/
private static double utbln14n14(double s,
    alglib.xparams _params)
{
    resu t
        ;


    b
    e
        x =
            0
        ;


    doub e
        tj
            =
            0;

    d ub
    l
        e
        ;


    h.Min
        (
            2
            *
            s
            - 0 .0 0000e+00)
        /
        .75
    00
    0
        + 00
    1,
    1
    0);


    j = 1;


    ch b(x, -4.5e + 00
        ,
        f t
    ef tj1, 
    ref res
        u
    lt


    ucheb(x, -
        4
    798
    84
    e
    00,
        ref

    j,
    ef t j1, r
    f resul
        t,
        c
    h
    eb(x - 1. 8
    7
    10
    7 + 00
    ef
        j,
        ef
    t
    1,
    ef res
    u
        t _p a
    r
        a
    ch e(,
    -.478 53 e
        r
    e t, re
    f
        tj1, 
    ref re
        s
    lt, pa ra
    m
        s
    he(x, -.
    0
    50e- 02 ref t
        j,
        ef t ,
    r
        f r es lt,
        par
    ms);


    uc
        h
    e
    3, re
    t
        j, r
    e
    f tj, re
    r
    es
        ut, p
    ra
        m
        );


    ucheb(
        x - 2 .4 09 83e
                    -
                    0
    j1, r f

    re l
        t, _ aram );


    uh eb(x
    -7
        .
    995
    6e-04,

    t j,  ref
        t
        j
    _para s
        )
    c
        h
    b(x
      - 2. 617
    e - 0 4, f ref t
        j1,
        rams)
    ;


    uche b
        x, 
    6.
    4
    941
    e - 0
    5
    re
        tj, r ef
        ref r
        e
    s
        u e
        (x, 1.8
    1
    761
        - 05, r
        e tj ref t
        j1,
        arams
        )
    ;

    (
        , -
        25
    8
    2e- 0
        , ref
    t
        , ref t
        j
    1, _par
        a
    m
        s
        ;


    che
    (x
        ,
        4.5
    652
    1
        - 07
        ref t
        j
    ref tj 
    1
        , _para
        m
    s
        )


    u
    heb
        x, 

    .73
    551
    e
    06,
        ref tj
        ,
        ref tj1
        ,
    r param
    s
        )
    ;

    u
        c
    eb(
        ,
        9
    237
    63 -
        0
        , re tj, re tj1, re
        f


    uche b(x, 1.
    6
    20
        - 0
    5 ref
    tj,

    ef e
        rresult;
}


/*************************************************************************
Tail(S, 14, 15)
*************************************************************************/
private static double utbln14n15(double s,
    alglib.xparams _params)
{
    d o
        j = 0;


    x h i
    n
        (2 * (s - 0 .0 00000
    e
        +
        0
        )/3
        .
    7


    uche b
        -
        .4
    9
    681
        + 00
        ,
        ref
    tj, re
        f, re r
        ;
    ch
    e
    (x,
        4. 7
    8e + 0
        , r
        e
    tj
        ref tj
    1, ref r sult


    c
    heb(x, -1. 0
    7
    02
    6
    e + 0
        ,
    r
    f t, re f tj, re
    resul
        t
    _para ms;


    (x, -1. 9
    9
    4
    8e-0 1, t j
    r
    e
        tj, r
    e
        re
    ult _p ar s);

    , -2.
    8
    0
    7
    3
    9
    e, t
        j
    re
        tj1, ef r ult _p
        a
    ams);


    x, -7.
    8
    4
    5
    6
    3
    e - 03 ,t ef
        j1,
        ef
    es ul, _p am s)


    .0 177
    3
    e
        - 3 , ref tj, ref
    t
    1,
    ef r e,
        par
    a
        s);
    uc eb(x
    -
        6
        , re
        f

    t
        ref result,
    _
        aras );


    che
        - 2. 1
    1
        - 04, re
        f t
        esult,
        _ pa a
    ms);


    eb(
        x
        - 7
    305
    9
    6e-5 , ref t r ef tj1,
        r
    rams) ;


    e - 3.
    79 29 5e - 0 , r
    f tj,
        rf t 1, re
        f
        );


    ucheb(x
        ,
        -2. 99 43
    9
        - 05
        ref j, r tj, r
    e
        resul,
        _
    h b(x, -2.90
    4
        - 0
    ef
        j,
        r
    f t
    1, ref r ep;


    ucheb(x, -
        2
    944
    86
    e
    05,
        ref

    j,
    ef tj1, 
    ref res
        u
    lt


    ucheb(x,
        -
            .37
    90
    8
        - 05
    re
    f
        tj, 
    ref tj 
    1
        ref re
        s
    ul


    ucheb(x,
        2.1
    07
    9
    e - 0
        , r
        e
    tj
        ref t
        j,  ref r
        e
    su;


    r turn re u
        t;
}


/*************************************************************************
Tail(S, 14, 30)
*************************************************************************/
private static double utbln14n30(double s,
    alglib.xparams _params)
{
    do
        u
            ble re
        u
    lt
        d
    ouble x
        = 0;

    d
        doub
    e
        t
    j
        r
    s
        l
            =
            x =
                at
                    .i
    00) /3
    75 0
    0
        +
        0

    j 1 =
        x
        ;


    u heb(x, -4. 4
    0378e+00 , e
        f
    t
        j,
        r
    ef t j, r
    f
        r
    e


    .6495
    8
    7
    e
    0
    0, ref j, re
        f
    tj 1, ef
        esut, _a ams);


    -9. 80
    7
    8
    2
    e
        - 01, ref tj,

    ef
        j1, 
    ref esu
        l, _ pa ams);


    heb(x, -9
    7
    53e-02, ref t
        j,  ref
        tj 
    1
    r f r s
        lt, aram );


    3646e
        -
        0
    2

    r
        ef t j, r f tj1,
        ef
    es
    u
        t, _p ram
        );


    uc eb(x
    ref t
        j,
        e
    f tj1,  ref r
        e
    t,
    _
        ara
    s);


    u
    heb(x
        -
        tj, re f tj 1
    f r
    su
        l, _
    aram );


    uche(x
        ,
        4, ref t j
    f t
    1,

    ef
        esu lt _pa ms );


    u
        ch 172e-
    0
    5
        ,
    f tj r ef tj1, r
    e
        r es t, ar am;

    u heb
    (
        , -9 4466
    9
    9
    ef tj
    1
        ,

    r es lt, _params
        )

    uc b(x
    2. 61 92e 06,

    ef t, re
    f
        , _pa
        r
    a
        m

    uch
    e
        (x, .21 73 e -, r f
    tj , f t 1,
    r
        f re ult,
        _


    uch eb x,  -3
        .
    516
    3e
        -
        re
    j, re tj,  ref r ult, _p
    a
        r
    uch
    eb(x,
        -2.272777e-0
    7
    re
        t
    j
        re
    tj 1, ef esult, _ arams);
    u
        c
    h
    eb x,  -.464988e-
    0
        , r
    f
        t, r
    f tj, 
    ref
        result 
        ,
        _params
        )
    ;


    u
    heb(x, -1.10
    9
    03e
    07
        ,
        ref
    tj,

    ef
        j1, re
    f
        result,
        _p


    eturn result
        ;
}


/*************************************************************************
Tail(S, 14, 100)
*************************************************************************/
private static double utbln14n100(double s,
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
    ouble x = 0;


    double
        tj = 0;


    d 0;


    result
        = 0;
        .Mi(2(
        00e+0 0
    .7 0
    e
        +
        t
    1
        ;
    j1
    b(x, -4
    4
    9
    7
    e
        j1,  ref
        r
        e
    s
        u
    l
        t, _ pa;


    uch
        e
    b
    0

    e
        f
    r
        f
    r
        e


    ucheb(x, -9
        .
    8265 e - 1
    r ft j, r
    e
        j1 re res l, _para
    m
    s
        - 8.60
    5
    50e- 2,

    ef
        j,
        r
    f tj
    ef re
    s
        lt, para s
        )
    heb(x
        , 1
    0
    62151 e - 0f ,
        ref

    j1,
    f res
    u
        t, _para m
        s
    heb x, 
    -2. 5
    15 e - 03, ref
    t
        re
    t
        j, r eu _params
        )
    ;
    cheb(x, 3
    8
    35983e-04,
    rf t,
        re
    f
        tj1 re fe, _para
    m
        s
    ucheb(x
          -
          1
    14 40e-05, ref j,
    ef f
        esult,
        _ arams)
    ;


    (x, 1.
    44 01e- 05 ref tj
        ,
        ref j re f,
        par am s) ;

    x, -3
        .
    3
    1
    8
    5
    0e - 6 , ref
    t
        , re tj
    1
    re
        m
        );

    10 e - 0 7, r
    e
        j, r ef tj1 r
        e
    re su t,
        par
        );


    u
    heb(x, -1 53 6
    2
    re tj 1, r
        f esul t, _par ms
        )


    eb(
        x
        - 3
    705888
    e
    08, r ef t, r
    e
        lt, _pa ra s
        ;
    ch
    e
        (x, -.9
    9
    599
    9,
    r
    f t,  ref
        t 
    1, re f re ul t,
        u h
        b
    (x - 2. 908395e 0
        , r
        f tj ref
    tj1
        ,
    fesult, _para
        m
    s
    b(x,
        1
    .5 46 2
    3e-09, ref
    t
        , r
    f
        t1, f ult, _ p
        ms;


    resul
        t
        ;
}


/*************************************************************************
Tail(S, N1, N2)
*************************************************************************/
private static double usigma(double s,
    int n1,
    int n2,
    alglib.xparams _params)
{
    dou
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

    f
    0
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
    1
        =
        0
        ;


    double
    2 = 0;

    double
        f3 = 0


    uble f
    4
        = 0;


    s2 = 0;


    d
    u
        b
        ;

        //
        / /5 ,
    7
        .
        //         
        Math.M
    i
        n
    n
    1, n2)==5


    if (
        Mt)==5
        )


    r
    e
        ult = u b
        l
    n
        );
}


(t
h
Max(n1, n)


re ul
    t
        = u

bln n
(s,
    _param s
}
if( M
a
h.Mx (n,
n2 =
7 )
r
es ul t = utbln
5
7( s, pa
ams
;
}
, n2)==8


{
    res ul
        =
        _para
    m
        s
        )
}


i f(M
    th.

Ma
x
    n1, n2)
    =
    =


{
    re
        ult
            =
            ln
                (s, _ a
    r
        ;


    if (Mat
    h
    Max
        n1, 
        )==
    0 )


    {
        = utb ln n
        1
        (
            s, _ pa rams);


        i f(ath Max
        (n, 


        {
            es
            u
                t = u
            5n
            1
            (s,
                _para ms;


            i(
                M
            t
            h
                .M ax(n1, n2) = 
                =
            2 )


            {
                esu l
                p
                    a
                r
                    a
                s) ;


                if
                (
                    Math.Ma
                x
                    (


                {
                    result
                        utbln5
                    n
                    13;
                }


                if
                (
                    Mat
                    .Max(n
                1
                n2)==1
                4
                    ) {
                    result = utbln5n14(s, _params);
                }
                if (Math.Max(n1, n2) == 15)
                {
                    result = utbln5n15(s, _params);
                }

                if (Math
                Max(n1
                n2)==
                6 )


                {
                    resul
                        = utbl
                    n5n16(s, _p


                    f Ma t


                    {
                        r es u5(
                    }


                    i(Ma h.M ax n
                    1, 2
                        ) = 18 )


                    {
                        bln5
                            n
                        1
                        8
                        s
                            , _params);
                    }


                    if (Ma
                    t
                    h


                    {
                        ul
                            =
                            u
                        bl 5
                        19(s, _p a
                    }


                    if (
                        Ma
                    t
                    ax
                        n
                            = 2 )


                    {
                        r
                            e
                        s
                        u
                            t
                                = utbln5n s,
                        pa
                            r
                        ms) ;


                        i Mat
                        h
                            .M
                        x
                        (
                            n1, 2) == 21


                        {
                            re ul
                            t
                                _pa ra m
                        }


                        i f(
                            ath Max

                        (n, 


                        {
                            esu
                                = utbl n
                            5
                            22(s, _
                            p
                                a


                            at
                                h
                            Maxn 1, 2 == 23 )
                            {
                                r
                                    es
                                u
                                    t =
                                        ut
                                b
                                    n5n
                                3(s,
                                    r

                                f
                                (
                                    t
                                h.Ma(n1, n
                                2
                                    ) = =2 )


                                {
                                    = ut l
                                    n
                                    5
                                    2
                                    4(s, _ aram)
                                        ;
                                }

                                if (Mt 2)==2
                                5

                                {
                                    esu
                                        t = ut

                                    b
                                        n5n25(s, _p r
                                }

                                i
                                f(th.ax(n n2
                                          == 2 6)


                                {
                                    su t = t
                                    b
                                    26(s _pa ra s)
                                        ;
                                }


                                if (Mat h.Ma x

                                {
                                    esu
                                        t =
                                            tbl n
                                }


                                f(M th
                                    .n1
                                n2
                                    )
                                    =28
                                    )
                                {
                                    relt = utbln5n28(s, _params);
                                }
                                if (Math.Max(n1, n2) == 29)
                                {
                                    result = utbln5n29(s, _params);
                                }

                                if (Math.Max(
                                        1, n2)
                                29 )


                                {
                                    f0
                                        =
                                        utbln5
                                    15(s, _
                                        params);


                                    r
                                    esu lt
                                        =
                                        u
                                    n
                                        i
                                    nterpolat e(f0, 1
                                        ,
                                        f 2,
                                        retu n
                                    re su t;


                                    N16 , N2
                                        , 7,, .
                                        /
                                        .M in(
                                        n
                                    1
                                        ,
                                    n
                                    2)== 6 )


                                    {
                                        f(th.Max(n n2) == 6
                                        )


                                        {
                                            su lt ut l
                                            6n 6(_p ram
                                            s
                                                ;


                                            i f(M at .

                                            M ax(
                                                n

                                            1,

                                            2) =
                                            7 )


                                            {
                                                ln6n7
                                                (
                                                    s
                                                    ,
                                                    _
                                                p
                                                    ar am s) ;
                                            }


                                            Math
                                                .ax(n1,
                                                    n
                                            2
                                            {
                                                r
                                                    lt
                                                        = t l
                                                8(s, _ a
                                                r
                                                    a
                                            }


                                            f
                                            th.ax(n1,
                                                2) = 9 )


                                            r
                                                e
                                            ult
                                                l 6n9(s, _ arams);


                                            i f(Math
                                                .
                                                ax

                                            (
                                                    1,
                                                    2) =
                                                10
                                                )


                                            r
                                                e
                                            u
                                                l
                                            t utbln6n1
                                            0
                                            s, _
                                            ar
                                                as );


                                            x(n1,
                                                n2) = 1
                                            1 )


                                            resu
                                                l
                                            n(s, _
                                            p
                                                a
                                            r
                                                m
                                            s);
                                        }


                                        if (Ma
                                        t
                                            .Max(n1
                                                , 


                                        {
                                            re
                                                =
                                                bl
                                            6n12(s _p
                                            rams );


                                            i
                                                f
                                                (M at .

                                            Max n1, n )
                                                ==1 )


                                            {
                                                res
                                                    u
                                                l
                                                    _para
                                                m
                                                    s
                                                    )
                                            }

                                            f(M t
                                                    .Ma
                                                        (n 1, n2)
                                                =
                                                14)


                                            utbln6n14(s, _params);
                                        }
                                        if (Math.Max(n1, n2) == 15)
                                        {
                                            result = utbln6n15(s, _params);
                                        }

                                        if (Math.Max(n1, n
                                            ) > 15)

                                        {
                                            = utb
                                                l
                                            n6n15(s
                                            _param
                                                s);

                                            1 = u tbl
                                            6n3(s,
                                                p
                                            r
                                            a
                                                f
                                                    =
                                                    e in er o
                                            (0 1

                                            Ma h.a, n2
                                                )
                                                ,
                                            _ arams;


                                            eu rn
                                        }

                                        //        
                                        /

                                        N = 7 N 2
                                        //


                                        if (Ma h.M
                                            i
                                            (n1
                                                n

                                        2
                                            == 7 )


                                        {
                                            2
                                                )==7 )


                                            {
                                                resul t
                                                tbln7n7
                                                (
                                                    s
                                            }


                                            f(M th.Ma n1,
                                                    n2) = 8
                                                )


                                            resul t = u
                                            7n 8(
                                                ,
                                                _
                                            ara
                                                s);
                                        }


                                        .Max(
                                            n
                                        1
                                            ,


                                        {
                                            esul
                                                =
                                                ar ms)
                                            ;


                                            f(Mat h.a
                                                        (n, n2)
                                                    = 
                                                = 


                                            {
                                                rs l
                                                    = u
                                                t
                                                    n1, _pa
                                                r
                                                    ms);


                                                if (Math.M ax(1,
                                                        n2
                                                    )
                                                    = 11
                                                    )


                                                sult = u b
                                                    n
                                                7n11(s, _ pa


                                                if (
                                                    2)==1
                                                2
                                                    )


                                                tbln 7n 12(
                                            }


                                            i
                                                f
                                            Ma
                                            h.M
                                            a(n1
                                            2)==13


                                            esul = ub n7n 3
                                            (
                                                , _
                                            ara
                                                m
                                                );


                                            if (Math.Max(n n2 = 1 4


                                            {
                                                = u tb ln
                                                7
                                                n
                                                1
                                                (
                                                    s, _params);


                                                if (M th.Max(n 1, 


                                                {
                                                    r
                                                        t
                                                    tb
                                                        l
                                                    7n1 5(, _par
                                                    a
                                                        ;


                                                    if (M
                                                    215 )
                                                    {
                                                        f0 = utbln7n15(s, _params);
                                                        f1 = utbln7n30(s, _params);
                                                        f2 = utbln7n100(s, _params);
                                                        result = uninterpol
                                                        te(f0,
                                                            f1, f2
                                                        Math.Max(n
                                                        1
                                                            , n2),
                                                        _
                                                            pa
                                                    }


                                                    retu
                                                        / /


                                                    .. .


                                                    if (M th
                                                        M
                                                    n
                                                        (

                                                    {
                                                        th.Max(1

                                                        n
                                                            r el(s _p aams);
                                                    }


                                                    i(
                                                        .M
                                                    a
                                                        (n1 n2) =  =9 )


                                                    e
                                                        = ul n8 9(, _


                                                    f(Math.M(n1,
                                                        n
                                                    ) =  = 1 )


                                                    {
                                                        resu lt = utbl
                                                        n
                                                            (s
                                                        p
                                                        aa ms;
                                                    }
                                                    Mat

                                                    h
                                                        .M a
                                                        (
                                                            n1 n

                                                    2)==11 )


                                                    resu lu ln8
                                                        n
                                                    1
                                                    1(,
                                                        _para ms);


                                                    if (Math.M ax )


                                                    {
                                                        res
                                                            lt
                                                        utbln
                                                        8
                                                        12(s, _p am
                                                    }


                                                    f(
                                                        h.ax(
                                                            n
                                                            , n
                                                                = 13)


                                                    esu
                                                        t = u bln
                                                        n13
                                                    (
                                                        , _r )


                                                    if (Ma th Ma x(n1, n
                                                    2
                                                        == 1 )


                                                    14(s, _
                                                    p
                                                    ra ms;
                                                }


                                                n2 == 1
                                                5
                                                    )

                                                {
                                                    result
                                                        am
                                                    s) ;
                                                }


                                                (
                                                    M
                                                th.Max(n, 


                                                {
                                                    0
                                                        = ub ln n
                                                    1
                                                    (s,
                                                        _params)

                                                    f
                                                        = utbln8n30(,
                                                            _p r
                                                    ms
                                                        )


                                                    2 = ut bl ns m
                                                        s
                                                        )
                                                    ;

                                                    e su t
                                                        = nn te
                                                        r
                                                    ola
                                                    e(f0,
                                                        f
                                                        , 2,
                                                        M
                                                    a
                                                        _para
                                                    s);

                                                    return result;
                                                }

                                                //
                                                // N1=9, N2 = 9, 10, ...
                                                //
                                                if (Math.Min(n1, n2) == 9)
                                                {
                                                    if (Math.Max(n1,
                                                            n2) == 9
                                                       )


                                                    {
                                                        re
                                                            su 9(s
                                                        _
                                                            pa
                                                    }


                                                    if (M n2)==1
                                                        )


                                                    tbln9n
                                                    0(
                                                        ,
                                                        _
                                                    pa


                                                    if (
                                                        at
                                                        .a
                                                    x()


                                                    re 9n11(s
                                                    _
                                                        a
                                                    a
                                                        ms
                                                }


                                                (Math
                                                Ma
                                                (
                                                    1
                                                    ,
                                                    e
                                                s
                                                    );
                                            }
                                            if (M n2)


                                            {
                                                t pa
                                                r
                                                    ms);
                                            }
                                            i = 14 )


                                            {
                                                ul _
                                                p
                                                    rams
                                                    )
                                                ;


                                                )==15


                                                {
                                                    es s,
                                                        para
                                                    m
                                                        s);


                                                    n2)>15
                                                        )


                                                    {
                                                        f0 _p
                                                        a
                                                            ams)
                                                        ;


                                                        30

                                                        f2
                                                            =
                                                            u
                                                        bln9n10
                                                        0
                                                            (s su
                                                        l
                                                            = u
                                                        n
                                                        int
                                                            e
                                                        rp
                                                            o
                                                        at
                                                            e
                                                        (f
                                                        0
                                                        f n1
                                                    }


                                                    //


                                                    ,

                                                    //


                                                    if (M
                                                    a
                                                        th )


                                                    i
                                                    (
                                                        M
                                                    at
                                                    h.
                                                        ax
                                                        res
                                                    u
                                                    l
                                                        t
                                                            = utbln
                                                    1
                                                    0n
                                                        f(
                                                            Ma
                                                                th

                                                    Ma
                                                        re
                                                    s
                                                    u
                                                        l
                                                            = utbl
                                                    n
                                                    10


                                                    if
                                                    (
                                                        M
                                                    at
                                                        .M
                                                        r
                                                    e
                                                        s
                                                    u
                                                        t = utb
                                                    l
                                                        n1;
                                                }


                                                i
                                                    f
                                                    (
                                                        Ma
                                                            h.)


                                                r
                                                    e
                                                s
                                                    lt = ut
                                                b
                                                    ln );
                                            }


                                            i
                                                f(
                                                    M
                                                        th)


                                            r
                                            e
                                                ult = u
                                            t
                                                bl s)
                                        }


                                        if
                                        (
                                            at 5


                                        r
                                            sult =
                                                u
                                        tb ms


                                        i
                                        f(
                                            Ma 5


                                        f
                                            = utbl
                                        n
                                        10


                                        1 =
                                            u
                                        tbl
                                            n
                                        10
                                        n
                                        0(
                                            s
                                            ,
                                            _p
                                        ra 100(s,
                                            _
                                        arams);


                                        in,
                                        f
                                            , Ma
                                            t
                                        h.M
                                            a
                                        x(
                                            n
                                            ,
                                            n
                                        2)
                                            ,
                                        pa ret
                                        r
                                            result;
                                    }


                                    //

                                    N1 =
                                        1
                                    1,

                                    2
                                        =
                                        1
                                    1,
                                    12 ath.Mi
                                    (
                                        1, n2) == 1
                                    1
                                        )


                                    1,

                                    2)==
                                    1
                                    1 )


                                    11n11(
                                        ,
                                        _params);


                                    n1
                                        ,
                                    n2) =
                                        =
                                    12
                                        )


                                    n11n12
                                        s
                                    _params)
                                    ;


                                    (n
                                    1
                                    n2)
                                        =
                                        =13
                                        )


                                    ln11n1
                                        (
                                            , _params
                                        )
                                        ;


                                    x(
                                            n
                                            , n2
                                        )
                                        == 1
                                    4
                                        )


                                    bln11n
                                    4
                                    s, _param
                                        s
                                        )
                                    ;


                                    ax
                                    (
                                        1, n
                                    2
                                        )==
                                    1
                                    5
                                        )


                                    tbln11
                                    1
                                        (s, _para
                                    m
                                        s
                                        )


                                    Ma
                                    x
                                        n1,
                                        n
                                    2)>
                                    1
                                    5
                                        )


                                    11n15(
                                        ,
                                        _params);


                                    n1;


                                    f2
                                        = pa
                                    r
                                        sult = un
                                    i
                                        n

                                    t
                                        rpolate
                                        (
                                            f0 ax s)
                                        ;
                                }


                                n
                            }


                            //


                            12 ..
                                /
                                n1 {
                                if (Mat
                                h
                                    .M


                                re
                                    ul, 
                            }


                            i
                                f
                                ()


                            {
                                =

                                t
                                    ln12n13(s,
                                        _
                                            p
                                            rams);


                                if (Math.Ma
                                x
                                    (n
                                1
                                n
                                2
                                    ==
                                    1
                                    )


                                {
                                    ul , _par
                                        ms);


                                    .Ma 5 )
                                    {
                                        ln
                                        1
                                        n15(
                                            s
                                            , _
                                        p
                                            ar
                                        a
                                            s)
                                        ;


                                        f(
                                            ath.M
                                        ax(
                                            n
                                        1,

                                        2)
                                            >
                                        15


                                        0 = ut
                                        l
                                        12n15(s,
                                            _
                                        p
                                            rams);


                                        f ,
                                        _
                                            aram
                                        s
                                            );


                                        12


                                        r
                                        e
                                            ult = u
                                        n
                                            in , n
                                        2
                                            , _p
                                            a
                                        ram
                                            s
                                            );
                                    }


                                    N2

                                    13,

                                    14,

                                    ..
                                        .
                                        ==13 )


                                    {
                                        ax


                                        {
                                            = ms);


                                            Ma
                                                t ams);
                                        }


                                        .M


                                        {
                                            lt rams);
                                        }


                                        h.


                                        {
                                            u );


                                            f1 = u
                                            t
                                                bl s)

                                            f2
                                                = u
                                            t
                                                bl
                                            n
                                            3n
                                            1
                                            00
                                                (s
                                            _ uninte
                                            p
                                            late(f0,
                                                f
                                            1
                                                ,
                                            f2, Mat
                                            h
                                                .M am
                                        }


                                        re
                                            ur

                                        //


                                        // 
                                        N
                                        1 =  ./


                                        i
                                            f
                                        M
                                            a
                                        t
                                        h.
                                            in

                                        if (Mat
                                        h
                                            .
                                            M
                                        x(n1, n
                                        2
                                            ) =


                                        r
                                            e
                                        su pa
                                        a
                                            s);
                                    }


                                    th.Max
                                        n, n2)==15 )


                                    {
                                        r
                                            e
                                        su s, 
                                    }


                                    {
                                        n15;


                                        f
                                            = s,


                                        f
                                            =
                                            ut
                                        b
                                            n1 );
                                        resul
                                            uninter
                                        p
                                            o
                                        l
                                        te(f0,
                                            f
                                        1,,
                                    }


                                    su


                                    //


                                    15
                                        /
                                        /


                                    i
                                        (bl {
                                        s

                                        4;
                                            )<
                                        (
                                            oubl
                                        e
                                            )(3
                                            )
                                            )


                                        f0
                                            =
                                            sigma00
                                        0
                                            (n
                                        1
                                            =
                                            7.50
                                        0
                                        000
                                        e
                                            - 0
                                        1


                                        ma;


                                        s
                                        2

                                        1.5000
                                        0
                                        0e 0(
                                            n
                                            , n2
                                            ,
                                            _p
                                        a
                                            ra
                                        m
                                            );


                                        25
                                        3
                                            = usigma2
                                        2
                                        5
                                        (
                                            1, n2,
                                            _
                                        pa 00
                                        e
                                        00;


                                        4 n2

                                        1 = ((s - s
                                        0
                                            )
                                        *
                                                1 - (s - s1
                                            )
                                            * f(s
                                                -
                                                0) * f
                                        2
                                            - (s
                                               -
                                               s2
                                            )
                                        f0
                                            )
                                            /(
                                            s2
                                        s0 s3)*f0
                                            /
                                            s3 - s0);


                                        -( );


                                        f
                                        2
                                            =
                                            (s 1)
                                        3
                                            = ((s - s1)
                                               *
                                               f
                                        3
                                                (s - s3) *
                                            f
                                        1) -s
                                        1
                                            * f4 -
                                            (
                                                s - s
                                        4
                                            )*
                                            f
                                            )/
                                        (
                                            s
                                        4 -
                                            1) 3)
                                        f
                                            )/(s3 - s2)
                                            ;


                                        (s
                                        s
                                            )*f2)/(s4
                                                   -
                                                   s
                                        2
                                            ;


                                        *f
                                            -
                                            s - s4)*f3)/
                                        (
                                            s
                                        4
                                        s3);


                                        f4;
                                    }


                                    ls
                                    e
                                        + 0 f0
                                        usigm
                                    a3 p
                                        = ;
                                    f1 = usigm _p
                                        s
                                    2
                                        =
                                        3.
                                    6
                                    66
                                    6
                                    7e ma
                                    3
                                    7(n1
                                        ,
                                        n2
                                        ,
                                        _
                                    p
                                        ra
                                    m
                                        s)
                                    ;
                                    =

                                    f3 = u
                                    s
                                        i
                                    g
                                    a400(n1
                                        ,
                                        n((
                                            s
                                    s0)*
                                        f
                                    1 - (
                                        s
                                        - s
                                    1
                                        * f
                                    0
                                        )/
                                    (
                                            1 - s - s2) *
                                        0
                                        / (s2 - s0)
                                        ;


                                    *f - s
                                    0
                                        ;


                                    f2
                                        =  )*
                                        f3 = ((s -
                                               s
                                    1
                                        )
                                    f3 - (s - s
                                    3
                                        )*((
                                        s
                                    s2)*
                                        f
                                    3 - (
                                        s
                                        - s
                                    3
                                        * f
                                    2
                                        )/
                                    (s
                                     - s
                                }


                                eturn r
                                e
                                    sult;
                            }
                        }

public class stest
{
    /*************************************************************************
    Sign test

    This test checks three hypotheses about the median of  the  given  sample.
    The following tests are performed:
        * two-tailed test (null hypothesis - the median is equal to the  given
          value)
        * left-tailed test (null hypothesis - the median is  greater  than  or
          equal to the given value)
        * right-tailed test (null hypothesis - the  median  is  less  than  or
          equal to the given value)

    Requirements:
        * the scale of measurement should be ordinal, interval or ratio  (i.e.
          the test could not be applied to nominal variables).

    The test is non-parametric and doesn't require distribution X to be normal

    Input parameters:
        X       -   sample. Array whose index goes from 0 to N-1.
        N       -   size of the sample.
        Median  -   assumed median value.

    Output parameters:
        BothTails   -   p-value for two-tailed test.
                        If BothTails is less than the given significance level
                        the null hypothesis is rejected.
        LeftTail    -   p-value for left-tailed test.
                        If LeftTail is less than the given significance level,
                        the null hypothesis is rejected.
        RightTail   -   p-value for right-tailed test.
                        If RightTail is less than the given significance level
                        the null hypothesis is rejected.

    While   calculating   p-values   high-precision   binomial    distribution
    approximation is used, so significance levels have about 15 exact digits.

      -- ALGLIB --
         Copyright 08.09.2006 by Bochkanov Sergey
    *************************************************************************/
    public static void onesamplesigntest(double[] x,
            int n,
            double median,
            ref double bothtails,
            ref double lefttail,
            ref double righttail,
            alglib.xparams _params)
        in

    t
        i

    0
    ;
    0;


    b
        tht ai s =
        0;


    right
        t

    a
        i
            = 0;


    both
        t

    ai l t
        ai l = 1. 0;

    ig
        h

    ta
        i
            = 1
                .
                0;


    r
        e

    t

        //
        e

    i]

    // NECnt - count of x


    g tc nt

    = 0
    ;


    n
        ; +)


    {
        )
        )

        {
            1


            i((
                d
            ou
                b
            e)
            (
                x[
                    i]
                !=
                n ec nt
                =
                n
            e
                c
            t + 1;


            ne cn == 0 )


            {
                /
                l
                x[i] are eq
                u
                    a
                l
                    to Medi
                    a
                n.
                    t Me da n i
                    a
                tr
                    u
                e
                    m
                di
                    a
                n
                    :)


                s = 1.;


                l
                e
                    ttail =
                        1.re
                t
                    urn
                    ;
            }
            h
                al di tr.
                i
                om ia ldistrib
            u
                t

            i
                n(Math.
                    M
                    i

            n
            1.0 )


            ef
                t
            ta
                il
                    = n
            ec t,  0
            5 _p arams);


            r
                i
                (g t

            cn - 1,
            n
            ecn
                t, 
            0
            5,

            _
                pa
            ams);
        }
    }

    public class studentttests
    {
        /*************************************************************************
        One-sample t-test

        This test checks three hypotheses about the mean of the given sample.  The
        following tests are performed:
            * two-tailed test (null hypothesis - the mean is equal  to  the  given
              value)
            * left-tailed test (null hypothesis - the  mean  is  greater  than  or
              equal to the given value)
            * right-tailed test (null hypothesis - the mean is less than or  equal
              to the given value).

        The test is based on the assumption that  a  given  sample  has  a  normal
        distribution and  an  unknown  dispersion.  If  the  distribution  sharply
        differs from normal, the test will work incorrectly.

        INPUT PARAMETERS:
            X       -   sample. Array whose index goes from 0 to N-1.
            N       -   size of sample, N>=0
            Mean    -   assumed value of the mean.

        OUTPUT PARAMETERS:
            BothTails   -   p-value for two-tailed test.
                            If BothTails is less than the given significance level
                            the null hypothesis is rejected.
            LeftTail    -   p-value for left-tailed test.
                            If LeftTail is less than the given significance level,
                            the null hypothesis is rejected.
            RightTail   -   p-value for right-tailed test.
                            If RightTail is less than the given significance level
                            the null hypothesis is rejected.

        NOTE: this function correctly handles degenerate cases:
              * when N=0, all p-values are set to 1.0
              * when variance of X[] is exactly zero, p-values are set
                to 1.0 or 0.0, depending on difference between sample mean and
                value of mean being tested.


          -- ALGLIB --
             Copyright 08.09.2006 by Bochkanov Sergey
        *************************************************************************/
        public static void studentttest1(double[] x,
            int n,
            double mean,
            ref double bothtails,
            ref double lefttail,
            ref double righttail,
            alglib.xparams _params)
        {
            0 ub
            l
                ean
                    = 0;


            d ou bl
                d

            boo s me
                x =
                    n
            e
                oo l(;


            e
                ;


            d ou le xs td d
                e
                    = 
                ;


            d
                o
            ble v2
                =
                t = ;


            double
                s
                    = 
                ;


            b
                o
            th
                t
            il s
                ;


            ls l
            il

            .0
                ;


            l =
                re
            t
                ur
            n
                /
                /
            Me
                a
            n


            0


            samex =
                t
            r
                u
                ;


            v

            x
                [
                    i]
                ;


            x = sa
            e
                && (doubl
            e
                )
            (
                )==(dou
            b
                l
                )


            {
                {
                    x
                        m
                    e

                        //
                        t


                    //


                    x
                        v
                    a
                    dd
                        v
                            = 0;


                    if (n!
                        =
                        1


                    v1 = 0
                        ;


                    i++)


                    {
                        v 1 =
                            v1
                            +
                            ma
                        t
                            .s
                            q
                        r
                        x[i] - xm
                        e
                            a


                        n
                            v2 = v 2
                            +
                            (x
                             [
                             ] -
                             m
                        an
                            )


                        at h.r(v2) / n
                            ;


                        xv 1


                        i f((o
                        u
                            bl
                        e
                            (x va r
                        ia
                            nc
                            )

                        v
                            riance = 0
                            ;


                        xd xv
                        a
                            ianc
                        e
                            );
                    }


                    t
                    {
                        i
                        f
                        (
                            (double
                            )
                            (
                                e
                        ta
                    }


                    e
                        l
                    s

                    bothtail
                        s
                            =
                            0.0;


                    (
                        oub le(xmean)
                            >
                        =
                        (
                            ouble)(
                            m
                    ea {
                        le tt
                        a
                            il
                        1. 0
                            ;


                        {
                            efttai
                                = 0.0
                                ;
                                )(
                                )(mean) )


                            1.;
                        }


                        ai
                    }


                    re u

                        //
                        /
                        ta
                    t
                        = (xmea
                    n
                        - m thS qr(n));


                    en
                        t
                    istributi
                        o
                    n(
                        n
                    1,

                    tat, _p
                        a
                    r
                    th t
                        = 2 * Mat h.Min(s
                        ,
                        e
                    ttail = s
                        ;

                    ri gh tta il =
                        1 - s;
                }


                /*************************************************************************
                Two-sample pooled test
        
                This test checks three hypotheses about the mean of the given samples. The
                following tests are performed:
                    * two-tailed test (null hypothesis - the means are equal)
                    * left-tailed test (null hypothesis - the mean of the first sample  is
                      greater than or equal to the mean of the second sample)
                    * right-tailed test (null hypothesis - the mean of the first sample is
                      less than or equal to the mean of the second sample).
        
                Test is based on the following assumptions:
                    * given samples have normal distributions
                    * dispersions are equal
                    * samples are independent.
        
                Input parameters:
                    X       -   sample 1. Array whose index goes from 0 to N-1.
                    N       -   size of sample.
                    Y       -   sample 2. Array whose index goes from 0 to M-1.
                    M       -   size of sample.
        
                Output parameters:
                    BothTails   -   p-value for two-tailed test.
                                    If BothTails is less than the given significance level
                                    the null hypothesis is rejected.
                    LeftTail    -   p-value for left-tailed test.
                                    If LeftTail is less than the given significance level,
                                    the null hypothesis is rejected.
                    RightTail   -   p-value for right-tailed test.
                                    If RightTail is less than the given significance level
                                    the null hypothesis is rejected.
        
                NOTE: this function correctly handles degenerate cases:
                      * when N=0 or M=0, all p-values are set to 1.0
                      * when both samples has exactly zero variance, p-values are set
                        to 1.0 or 0.0, depending on difference between means.
        
                  -- ALGLIB --
                     Copyright 18.09.2006 by Bochkanov Sergey
                *************************************************************************/
                public static void studentttest2(double[] x,
                    int n,
                    double[] y,
                    int m,
                    ref double bothtails,
                    ref double lefttail,
                    ref double righttail,
                    alglib.xparams _params)
                {
                    in
                    i
                        = 0;
                        =
                    ew b
                    ol();


                    bo
                    l
                        amey =
                            ew bool()
                        ;

                    d
                    uble
                        x0
                            = 0
                        ;


                    d
                    uble
                        y0
                            = 0;

                    dou
                        l
                    x
                        ea
                            = 0;
                    dou
                    le ymean =
                        0

                    0;


                    dou
                        le st
                        t = 
                        ;


                    d
                        dou
                    le
                        p =
                            0;


                    tails
                    0

                    lef
                        tail
                            = 0;

                    ighttail =
                        0 if (n <
                              |
                              <
                              =
                    0 )


                    {
                        ef
                            tail
                                = 1.
                            ;


                        righ
                            tail = ;
                    }


                    /
                    a
                    n
                        /
                        /


                    x[
                    ];


                    s
                        mex
                    tr
                        e;

                    for
                        i = 0;
                    i <
                        v = x[
                        ];
                        = xmean + v


                    amex
                        =
                        samex
                        && (
                    do
                }


                if (
                    sam
                x )

                {
                }


                ls


                {
                    xmean =
                        e
                    a
                    n / n;
                }

                yme
                0;
                y0 = y[0];


                sam
                    e
                        =
                        true;

                f
                r(i = 
                    ;
                i <=
                    -1
                i++)


                v
                ymea
                    n = y
                ea
                    + v;

                samey
                    =
                    s
                a
                    m
                e
                y
                    &
                    &
                    (
                        d
                o
                    u
                b
                    l
                e
                    )
                (
                        v
                    )
                    = 
                    =
                (
                    d
                o
                    u
                b
                    l
                e
                    )
                (
                    y
                0
                    )
                ;
            }


            i
                f
                (
                    s
                        a
                        m
                        e
                        y)


            ymean = y0;
        }

        el
            e


        ean
            m;
    }


    //


    //


    if(
    n+m>2 )


    f
    0;
    .s r(x[i]-
    me n
    )
    fo r(0

    i
        s = s

    m
        th.
        sq
}
= M at.Sq rt *
    (d ou b
l
    (d ou b


if ((d(d
obl {
    =(dou
        )
        ym e
    {
        b
            o
        t
            els
        e
    }


    (d
    o
        bl e) (xm ea )
        >= (d o
        ub l
        e) ym
        e
    an) )


    efttai 1. 0;


    i
    f
    (
        (do
        ble )(xm ea )<
    (doub le )
    (
        r ih tt il = 10;


    {
    }


    //
    / / t
        a
    tist
    ic
        /
        an - ym ean )/s
        p
            =
            stt dist
        r
    st d
    nttdist
    r
        i, _


    b
        oh ta ils = 2M at.
        M
        p,  1 - );


    f l
        righttail = 1 -
}


/*************************************************************************
Two-sample unpooled test

This test checks three hypotheses about the mean of the given samples. The
following tests are performed:
    * two-tailed test (null hypothesis - the means are equal)
    * left-tailed test (null hypothesis - the mean of the first sample  is
      greater than or equal to the mean of the second sample)
    * right-tailed test (null hypothesis - the mean of the first sample is
      less than or equal to the mean of the second sample).

Test is based on the following assumptions:
    * given samples have normal distributions
    * samples are independent.
Equality of variances is NOT required.

Input parameters:
    X - sample 1. Array whose index goes from 0 to N-1.
    N - size of the sample.
    Y - sample 2. Array whose index goes from 0 to M-1.
    M - size of the sample.

Output parameters:
    BothTails   -   p-value for two-tailed test.
                    If BothTails is less than the given significance level
                    the null hypothesis is rejected.
    LeftTail    -   p-value for left-tailed test.
                    If LeftTail is less than the given significance level,
                    the null hypothesis is rejected.
    RightTail   -   p-value for right-tailed test.
                    If RightTail is less than the given significance level
                    the null hypothesis is rejected.

NOTE: this function correctly handles degenerate cases:
      * when N=0 or M=0, all p-values are set to 1.0
      * when both samples has zero variance, p-values are set
        to 1.0 or 0.0, depending on difference between means.
      * when only one sample has zero variance, test reduces to 1-sample
        version.

  -- ALGLIB --
     Copyright 18.09.2006 by Bochkanov Sergey
*************************************************************************/
public static void unequalvariancettest(double[] x,
    int n,
    double[] y,
    int m,
    ref double bothtails,
    ref double lefttail,
    ref double righttail,
    alglib.xparams _params)
{
    i nt
        i
            =
            n
    l
    bool
        amey = (
            d o
        ;


    ble xma n
        an = 0;


    ble yvar
        ;


    d

    0;

    ep 0
        ;


    0;


    l = ;


    {
        i
        .0;


        r
        t
            urn;
    }


    ue;
        ]

    v;
    sa me xe && do
        b
            e
            )
    ;


    )


    x
        m
    a
        n
            =
            x
    0


    x me n
        = x me n
        /
        n
        ;


    y0
        s
    m
        y = t r
        ue;


    ymean
        m
    ea
        s
    ame y = s am y
        && (dou ble(
}


ymea
    n
        = y0


e

    // V
    r
anc
    e
w
    ar = 0;


x
    )


{
    fo r(i
        =

    ;
    xv a
            = xvar / -
        );

    v
        a =
            f
    {
        m
        {
            =
            v
            r + m
            a
                di ff r
            n
                t spe ci a
                l ca
                s

            e
                s

                // 
                (
                    o
                        n

            e

                //
                (do
                u
                    le) (x v =  =(du e
                (
                    0
                ) &&
                (do
                u
                    bl e
            (
                y
            v
                a
            r
                )


            if ((
                    ou l
                e
                )
            (xmean) == (dble)(ymean) )
            {
                bothtails = 1.0;
            }
            else
            {
                bothtails = 0.0;
            }
            if ((double)(xmean) >= (double)(ymean))
            {
                lefttail = 1.0;
            }
            else
            {
                lefttail = 0.0;
            }

            if ((double)(xmean) <= (double)(ymean))
            {
                righttail = 1.0;
            }
            else
            {
                righttail = 0.0;
            }

            return;
        }
        if ((double)(xvar) == (double)(0))
        {
            //
            // X is constant, unpooled 2-sample test reduces to 1-sample test.
            //
            // NOTE: right-tail and left-tail must be passed to 1-sample
            //       t-test in reverse order because we reverse order of
            //       of samples.
            //
            studentttest1(y, m, xmean, ref bothtails, ref righttail, ref lefttail, _params);
            return;
        }

        if ((double)(yvar) == (double)(0))
        {
            //
            // Y is constant, unpooled 2-sample test reduces to 1-sample test.
            //
            studentttest1(x, n, ymean, ref bothtails, ref lefttail, ref righttail, _params);
            return;
        }

        //
        // Statistic
        //
        stat = (xmean - ymean) / Math.Sqrt(xvar / n + yvar / m);
        c = xvar / n / (xvar / n + yvar / m);
        df = apserv.rmul2(n - 1, m - 1, _params) / ((m - 1) * math.sqr(c) + (n - 1) * math.sqr(1 - c));
        if ((double)(stat) > (double)(0))
        {
            p = 1 - 0.5 * ibetaf.incompletebeta(df / 2, 0.5, df / (df + math.sqr(stat)), _params);
        }
        else
        {
            p = 0.5 * ibetaf.incompletebeta(df / 2, 0.5, df / (df + math.sqr(stat)), _params);
        }

        bothtails = 2 * Math.M
        n(p, 1
        p);

        le
        f
            ttail
                = 
            ;

        igh
            t
        ai
    }
}
}