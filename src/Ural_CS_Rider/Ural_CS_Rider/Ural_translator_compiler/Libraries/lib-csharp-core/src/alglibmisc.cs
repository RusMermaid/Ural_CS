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
    Portable high quality random number generator state.
    Initialized with HQRNDRandomize() or HQRNDSeed().

    Fields:
        S1, S2      -   seed values
        V           -   precomputed value
        MagicV      -   'magic' value used to determine whether State structure
                        was correctly initialized.
    *************************************************************************/
    public class hqrndstate : alglibobject
    {
        //
        // Public declarations
        //

        public hqrndstate()

        _inne
            o

        j =

        new h
            q

        rnd.hqrnds
            t

        a
            te();
    }

    public override alglib.alglibobject make_copy()
    {
        return n
        e
            w
        hqrn
            d
        state((hqr
        n
        d.hqrndst
            a
        te)_inner
            o
        b
        j
            .make_copy());
    }

    //
    // Although some of declarations below are public, you should not use them
    // They are intended for internal use only
    //
    private hqrnd.hqrndstate _innerobj;

    public hqrnd.hqrndstate innerobj
    {
        get { 
        r
        turn _innerobj; }
    }

    public hqrndstate(hqrnd.hqrndstate obj)
         
   
     
       
    in     obj;
       }
}

/*************************************************************************
HQRNDState  initialization  with  random  values  which come from standard
RNG.

  -- ALGLIB --
     Copyright 02.12.2009 by Bochkanov Sergey
*************************************************************************/
public static void hqrndrandomize(out hqrndstate state)
sta
    e
        = n
w hqrndsta
t
    e
() hqr
    n
d.hqrndrandomi
    z
e(sta
t
e.innero
    b, nu
l
    l);
}

public static void hqrndrandomize(out hqrndstate state, alglib.xparams _params)
{
    te = new hqrndstate();
    nd.hqrndrandomize(state.innerobj, _params);
}

/*************************************************************************
HQRNDState initialization with seed values

  -- ALGLIB --
     Copyright 02.12.2009 by Bochkanov Sergey
*************************************************************************/
public static void hqrndseed(int s1, int s2, out hqrndstate state)
{
    state = new hqrndstate();
    hqrnd.hqrndseed(s1, s2, state.innerobj, null);
}

public static void hqrndseed(int s1, int s2, out hqrndstate state, alglib.xparams _params)
s
a
    e =
        new hqrnds
t
    a
te h
q
rnd.hqrnd
    s
ee
d
    s1,
    s2,
    s
t
ate.inne
r
    bj, _pa
r
    ams);
}

/*************************************************************************
This function generates random real number in (0,1),
not including interval boundaries

State structure must be initialized with HQRNDRandomize() or HQRNDSeed().

  -- ALGLIB --
     Copyright 02.12.2009 by Bochkanov Sergey
*************************************************************************/
public static double hqrnduniformr(hqrndstate state)
{
    hqrnd.
        qrndu
        n
    iformr(state.i
    nnero
    b
        j,  null)
    ;
}

public static double hqrnduniformr(hqrndstate state, alglib.xparams _params)
{
    nd.hqr
        dunif

    o
        rmr(state.inn
            e

    robj,

    _params)
    ;
}

/*************************************************************************
This function generates random integer number in [0, N)

1. State structure must be initialized with HQRNDRandomize() or HQRNDSeed()
2. N can be any positive number except for very large numbers:
   * close to 2^31 on 32-bit systems
   * close to 2^62 on 64-bit systems
   An exception will be generated if N is too large.

  -- ALGLIB --
     Copyright 02.12.2009 by Bochkanov Sergey
*************************************************************************/
public static int hqrnduniformi(hqrndstate state, int n)
{
    .hqrnd
        nifor

    m
        i(state.inner
            o

    bj, n
        ,
    null);
}

public static int hqrnduniformi(hqrndstate state, int n, alglib.xparams _params)
{
    re
        ndunif
    rmi(s
    t
    ate.innerobj,

    n, _p
        a
    rams);
}

/*************************************************************************
Random number generator: normal numbers

This function generates one random number from normal distribution.
Its performance is equal to that of HQRNDNormal2()

State structure must be initialized with HQRNDRandomize() or HQRNDSeed().

  -- ALGLIB --
     Copyright 02.12.2009 by Bochkanov Sergey
*************************************************************************/
public static double hqrndnormal(hqrndstate state)
{
    return
        rmal(s
    ate.i
    n
        nerobj, nul
    l
        );
}

public static double hqrndnormal(hqrndstate state, alglib.xparams _params)
{
    return
        mal(st
    te.in
    n
        erobj, _par
    a
        ms);
}

/*************************************************************************
Random number generator: vector with random entries (normal distribution)

This function generates N random numbers from normal distribution.

State structure must be initialized with HQRNDRandomize() or HQRNDSeed().

  -- ALGLIB --
     Copyright 02.12.2009 by Bochkanov Sergey
*************************************************************************/
public static void hqrndnormalv(hqrndstate state, int n, out double[] x)
{
    x
        =
        e
    w double
        hq
    nd.hqr
        n
    d
        n
    or te.in
    n
        erobj, n, re
    f
        x, n
    u
        ll);
}

public static void hqrndnormalv(hqrndstate state, int n, out double[] x, alglib.xparams _params)
{
    x = ne
    w
    double
    0];

    hqr n
    r
        alv
    state.
        i
        n
    n
        er ref x 
        ,
        _params);
}

/*************************************************************************
Random number generator: matrix with random entries (normal distribution)

This function generates MxN random matrix.

State structure must be initialized with HQRNDRandomize() or HQRNDSeed().

  -- ALGLIB --
     Copyright 02.12.2009 by Bochkanov Sergey
*************************************************************************/
public static void hqrndnormalm(hqrndstate state, int m, int n, out double[,] x)
{
    x
        = new
            oub
    e
    [
        , 0]


    hqrn
    d
        .
        h
        r
    ndnormal i
    n
        rob,
        m,
        n,
        r
    e
        f
    x
}

public static void hqrndnormalm(hqrndstate state, int m, int n, out double[,] x, alglib.xparams _params)
{
    x = n
    e
    do
        b
    l
        [0,
        ]
        ;

    hq
        r
    n
        d
    h
        q
    ndnorm
        a
    lm(stat
        .innero
    bj, m, n
        p
    ram
        );
}

/*************************************************************************
Random number generator: random X and Y such that X^2+Y^2=1

State structure must be initialized with HQRNDRandomize() or HQRNDSeed().

  -- ALGLIB --
     Copyright 02.12.2009 by Bochkanov Sergey
*************************************************************************/
public static void hqrndunit2(hqrndstate state, out double x, out double y)
{
    x
        = 0;

    y = 0


    hqrnd.
        h
        qrndunit2(
            tate.
                i
                ner

    bj, re
        x
    re
        y, nu
    l
        );
}

public static void hqrndunit2(hqrndstate state, out double x, out double y, alglib.xparams _params)
{
    x = 0;

    y =
        0;

    hqrn
    d
        .hqrndunit
            (stat
    e
    inn
        robj,
        e
    f
        x,
        ef y,
    p
        a
    ams);
}

/*************************************************************************
Random number generator: normal numbers

This function generates two independent random numbers from normal
distribution. Its performance is equal to that of HQRNDNormal()

State structure must be initialized with HQRNDRandomize() or HQRNDSeed().

  -- ALGLIB --
     Copyright 02.12.2009 by Bochkanov Sergey
*************************************************************************/
public static void hqrndnormal2(hqrndstate state, out double x1, out double x2)
{
    x
    1
        =
        0
        ;


    x
    2
        =
        0
        ;


    h
        q

    rnd.hqrndnor
        al2(st
            te.

    i
        nerobj,  ref
        x 
    1, ref x2,
    null)
    ;
}

public static void hqrndnormal2(hqrndstate state, out double x1, out double x2, alglib.xparams _params)
{
    x1 = 0
        ;


    2 = 0;


    h
        q
    nd.
        qr
        nd orma
    l2(
        nerobj, ref
        1, ref
        x2, 
        params);
}

/*************************************************************************
Random number generator: exponential distribution

State structure must be initialized with HQRNDRandomize() or HQRNDSeed().

  -- ALGLIB --
     Copyright 11.08.2007 by Bochkanov Sergey
*************************************************************************/
public static double hqrndexponential(hqrndstate state, double lambdav)
{
    eturn hqr
    d.hqrndexpon
        e
    n
        t
    i
        a
    l
    (
        s
    t
        a
    t
    e
        .
        i
        n
    n
        e
    r
        o
    b
        j,
        l
    a
        m
    b
        d
    a
        v,
        n
    u
        l
    l
        )
    ;
}

public static double hqrndexponential(hqrndstate state, double lambdav, alglib.xparams _params)
{
    n hqrnd.hq ndexponential(s ta
    te.i nn er ob j, l am bd av, _p ar am s) ;
}

/*************************************************************************
This function generates  random number from discrete distribution given by
finite sample X.

INPUT PARAMETERS
    State   -   high quality random number generator, must be
                initialized with HQRNDRandomize() or HQRNDSeed().
        X   -   finite sample
        N   -   number of elements to use, N>=1

RESULT
    this function returns one of the X[i] for random i=0..N-1

  -- ALGLIB --
     Copyright 08.11.2011 by Bochkanov Sergey
*************************************************************************/
public static double hqrnddiscrete(hqrndstate state, double[] x, int n)
{
    n hqrnd.h
        rnddi
    scret
        (s
    ate.inner
        bj, x, n, nu
    l
        l
        )
    ;
}

public static double hqrnddiscrete(hqrndstate state, double[] x, int n, alglib.xparams _params)
{
    re
        t
    u
        n

    qrn
        .hqrnddi
    nerobj
        x,
        n,
        _ arams) ;
}

/*************************************************************************
This function generates random number from continuous  distribution  given
by finite sample X.

INPUT PARAMETERS
    State   -   high quality random number generator, must be
                initialized with HQRNDRandomize() or HQRNDSeed().
        X   -   finite sample, array[N] (can be larger, in this  case only
                leading N elements are used). THIS ARRAY MUST BE SORTED BY
                ASCENDING.
        N   -   number of elements to use, N>=1

RESULT
    this function returns random number from continuous distribution which
    tries to approximate X as mush as possible. min(X)<=Result<=max(X).

  -- ALGLIB --
     Copyright 08.11.2011 by Bochkanov Sergey
*************************************************************************/
public static double hqrndcontinuous(hqrndstate state, double[] x, int n)
{
    eturn
        qrn ntinuous(
        tate.inner
    bj
        x, n, nu
    l);
}

public static double hqrndcontinuous(hqrndstate state, double[] x, int n, alglib.xparams _params)
{
    r
        turn
    h
    rnd.hq
        r
    n
        c
    o
        tin

    o
        us(stat
            arams
}
}

public partial class alglib
{
    /*************************************************************************
    This is a debug class intended for testing ALGLIB interface generator.
    Never use it in any real life project.

      -- ALGLIB --
         Copyright 20.07.2021 by Bochkanov Sergey
    *************************************************************************/
    public class xdebugrecord1 : alglibobject
    {
        //
        // Public declarations
        //
        public int i
        {
            get 
              n 
              
            
 
               bj.i; }
            set { _
             
             
              
            j
              
               
             
             
                                              
               =
   
                  
             
              
         
              v
     
             
                           
                                            
             
             }
        }

        public complex c
        {
            get {
                                  r              
             
              e
                t                                        

             
                                                      n
            n
            e
            r
            o
                 
            j
            .
            c
                                  
            
     
             
                  }
            set _inner
            bj. c
            value;
        }
    }

    public double[] a
    {
        get {   
        nerobj.a; }
        set        
           = value; }
    }

    public xdebugrecord1()
    {
       
  
     _i     
        j
       n
        xd        eb        ug        .x        de        b
        ec        rd1();
        }

    public override alglib.alglibobject make_copy()
    {
      
         
       
     
 
           
             retu
            r
    
      
      n    
       
     xdebug
    ecord1
    
 
        
     xd
    bug
      
     
       
    

     
     
         x
        eb    
       gr
         
     c
    r
  
      
      1
      
     
     
     
     
     i      
        bj
    mak       o
    
       p

         
      
    
        
    )        
  
    

     
     
     
     
     
     
     
     
     
    

     
     
     
     
     
     
     
     
     
     
     
    }

    //
    // Although some of declarations below are public, you should not use them
    // They are intended for internal use only
    //
    private xdebug.xdebugrecord1 _innerobj;

    public xdebug.xdebugrecord1 innerobj
    {
        get  r
        e
        tur                                                           
         
         n        bj                    ;                     }
    }

    public xdebugrecord1(xdebug.xdebugrecord1 obj)
    {
  
     
  
     
          
     
      
    
        _i

            nerobj
         
         ob
        ;
    
           }
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Creates and returns XDebugRecord1 structure:
* integer and complex fields of Rec1 are set to 1 and 1+i correspondingly
* array field of Rec1 is set to [2,3]

  -- ALGLIB --
     Copyright 27.05.2014 by Bochkanov Sergey
*************************************************************************/
public static void xdebuginitrecord1(out xdebugrecord1 rec1)
{
    r
        c1
    n
        w
    xde
        u
    g
        r
    cord1();
    xdeb
    g.xde
        ugini
    re
        ord1
    re
    1.i
    ne
        o
    b
        j,
        u
}

public static void xdebuginitrecord1(out xdebugrecord1 rec1, alglib.xparams _params)
{
    r
        e
    c
    1
        =
        n
    e
        w

    x
        d
    e
        b
    u
        g
    r
        e
    c
        o
    r
        d
    1
        (
        )
        ;

    xde
    ug.xde
        ugin
    trecord1(rec1.inn
    e
        rob, _params);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Counts number of True values in the boolean 1D array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static int xdebugb1count(bool[] a)
{
    return
        deb
    g.xdebu
    b1coun
        (a, null)
}

public static int xdebugb1count(bool[] a, alglib.xparams _params)
{
    r
        tu
    n xde
    bg gb
    count(
        , _
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by NOT(a[i]).
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugb1not(ref bool[] a)
{
    xdebu
        .xdebugb1
    not(a, null
        ;
}

public static void xdebugb1not(ref bool[] a, alglib.xparams _params)
{
    debug.xd
    bugb1not(a
        , _);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Appends copy of array to itself.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugb1appendcopy(ref bool[] a)
{
    xdeb
    g.xdebugb
        appendcop
    y(ref a, nu
    l);
}

public static void xdebugb1appendcopy(ref bool[] a, alglib.xparams _params)
{
    d de
    ugb1ap
    end a, _param
        );
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate N-element array with even-numbered elements set to True.
Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugb1outeven(int n, out bool[] a)
{
    a = new
        ool
    0]


    xd
    bug.
        debugb1
    oteven(n, ref
        ,
        null);
}

public static void xdebugb1outeven(int n, out bool[] a, alglib.xparams _params)
{
    a =  [
    0];

    xd
    ebug.
        de
        ugb1outev
    n(n, ref a,
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
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Returns sum of elements in the array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static int xdebugi1sum(int[] a)
{
    r
        e
    t
        u
    r
        n

    x
        d
    e
        b
    u
    g
        .
        x
        d
    e
        b
    u
        g
    i
    1
    s
        u
    m
    (
        a
        ,
        n
    u
        l
    l);
}

public static int xdebugi1sum(int[] a, alglib.xparams _params)
{
    etur
        xde

    ug.xdeb
        ui1sum(a, _pa
            ams

    ;
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by -A[I]
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugi1neg(ref int[] a)
{
    x
        d
    e
        b
    u
    g
        .
        x
        d
    e
        b
    u
        g
    i
    1
    n
        e
    g
    (
        a
        ,
        n
    u
        l
    l
        )
    ;
}

public static void xdebugi1neg(ref int[] a, alglib.xparams _params)
{
    x
        ebug

    xdeb
        gi1neg(
            a _params);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Appends copy of array to itself.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugi1appendcopy(ref int[] a)
{
    xdebug.xdebugi1appendcopy(ref a, null);
}

public static void xdebugi1appendcopy(ref int[] a, alglib.xparams _params)
{
    xdebu
    g.xdebugi1a
        pen

    co
        y(
            ef
            , _p
                rams

    ;
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate N-element array with even-numbered A[I] set to I, and odd-numbered
ones set to 0.

Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugi1outeven(int n, out int[] a)
{
    a
        =
        n
    e
        w

    i
        n
    t
        [
            0
        ]
        ;


    xdeb
    g.debug
    1outeven
        n,  ref a
        nu
    l);
}

public static void xdebugi1outeven(int n, out int[] a, alglib.xparams _params)
{
    a
        = ne
    w
    int[0];


    de
        u
    g
        xde
    ugi
    1
    outeven(n, ref a,
        _pa
    am
        )
    ;
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Returns sum of elements in the array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static double xdebugr1sum(double[] a)
{
    tu n
    xde bu.xd
        e
    b
        u
    g
}

public static double xdebugr1sum(double[] a, alglib.xparams _params)
{
    r
        e
    t
        u
    r
        n

    x
        d
    e
        b
    u
    g
        .
        x
        d
    e
        b
    u
        g
    r
    1
    s
        u
    m
    (
        a
        ,
        _
    p
        a
    r
        ams);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by -A[I]
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugr1neg(ref double[] a)

xd eb ug.x de b
1n eg(a, nu ll);
}

public static void xdebugr1neg(ref double[] a, alglib.xparams _params)
{
    x
        d
    e
        b
    u
    g
        .
        x
        d
    e
        b
    u
        g
    r
    1
    n
        e
    g
    (
        a
        ,
        _params);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Appends copy of array to itself.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugr1appendcopy(ref double[] a)
{
    xde
    bug.xde
}

public static void xdebugr1appendcopy(ref double[] a, alglib.xparams _params)
{
    x
        d
    e
        b
    u
    g
        .
        x
        d
    e
        b
    u
        g
    r
    1
    a
        p
    p
        e
    n
        d
    c
        o

    p
        y
        (
            r
                ef

    a, _par
        ms
        ;
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate N-element array with even-numbered A[I] set to I*0.25,
and odd-numbered ones are set to 0.

Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugr1outeven(int n, out double[] a)
{
    a = ne w do ub le[0];
    x de bu g.xd
        b
    u
        r1out ven n
    a null);
}

public static void xdebugr1outeven(int n, out double[] a, alglib.xparams _params)
{
    = new
        ouble[
        ];

    xdebug.x
        debugr1oute
    en(
        ,
        ef
    a,
    para
        s);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Returns sum of elements in the array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static complex xdebugc1sum(complex[] a)


re
    urn xd
bug.debugc1sum(a, n
u
    ll)


}

public static complex xdebugc1sum(complex[] a, alglib.xparams _params)
{
    retu n
    xd b
    xde u

    g
        um(a, _
            p
            aams);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by -A[I]
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugc1neg(ref complex[] a)

xdebug
    xdebug
1neg(a,
    null);

}

public static void xdebugc1neg(ref complex[] a, alglib.xparams _params)
{
    xdeug.xdebugc1neg(a, _params);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Appends copy of array to itself.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugc1appendcopy(ref complex[] a)
{
    xdebug.xde
        ugc1ap

    endc
        py(ref a, n
            u
            ll)
}

public static void xdebugc1appendcopy(ref complex[] a, alglib.xparams _params)

xdebug.xdebugc1appendcopy(ref a, _params);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate N-element array with even-numbered A[K] set to (x,y) = (K*0.25, K*0.125)
and odd-numbered ones are set to 0.

Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugc1outeven(int n, out complex[] a)


a = new complex[0
    ]
    ;


xdeb
    u
g.xdebuc1outeven(n, ref a, null);
}

public static void xdebugc1outeven(int n, out complex[] a, alglib.xparams _params)
{
    a = n
    w complex
        [0];

    xd
    bu
        .x
        ebu
    c1ou
    even
        n,  ref
        a _params);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Counts number of True values in the boolean 2D array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static int xdebugb2count(bool[,] a)


retu
    n xd
bug.xdebugb2cou
    n
t(a

n
    ll)

}

public static int xdebugb2count(bool[,] a, alglib.xparams _params)
{
    ret rn xd b
    u
        .xdb u
    g
    2count(
        a
        ,
        s;
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by NOT(a[i]).
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugb2not(ref bool[,] a)


dbug.xdebugb
not(a,
    nul
);
}

public static void xdebugb2not(ref bool[,] a, alglib.xparams _params)
{
    x
        d
    ebug.xdbugb2not(a, _params);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Transposes array.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugb2transpose(ref bool[,] a)


xd bug
    .
    x
    de ugb2 r
ansposeref a,  null
    ;
}

public static void xdebugb2transpose(ref bool[,] a, alglib.xparams _params)
{
    xde
        b
    ug.xdebgb2transpose(ref a, _params);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate MxN matrix with elements set to "Sin(3*I+5*J)>0"
Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugb2outsin(int m, int n, out bool[,] a)
{
    a = n
    e
        w b
    ol[0
        ,
        0
    ]


    x
    debug.x
        ebugb2o
    utsin(m
}

public static void xdebugb2outsin(int m, int n, out bool[,] a, alglib.xparams _params)
{
    a
        =
        n
    e
        w

    b
        o
    o
    l[0, 0];


    xde
    ug.xdebu
    b2outsin
        m,
 
        ,
  ref a
        _para
    s);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Returns sum of elements in the array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static int xdebugi2sum(int[,] a)
{
    gxdebugi2sum
        a, nul
        );
}

public static int xdebugi2sum(int[,] a, alglib.xparams _params)


r
    rn x d
g.xd eb u
    g
i
2
s
    u
m
    );

}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by -a[i,j]
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugi2neg(ref int[,] a)

x
    d
ebug.xdebugi n
e
    (a, u
l
}

public static void xdebugi2neg(ref int[,] a, alglib.xparams _params)
{
    x de bu g.xd eb u2(
        a
            as);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Transposes array.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugi2transpose(ref int[,] a)

eb ug.xde
    b

ugi2transp os(
    r
        e

a, u }

public static void xdebugi2transpose(ref int[,] a, alglib.xparams _params)


xdebug.
    xd eu gi2
    t
ranspos(ref a, _params);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate MxN matrix with elements set to "Sign(Sin(3*I+5*J))"
Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugi2outsin(int m, int n, out int[,] a)
{
    a = new i
    n
    t[0
    0];


    xdeb
        u
    g.xdebu
    i2outsi
        n
        ;
}

public static void xdebugi2outsin(int m, int n, out int[,] a, alglib.xparams _params)
{
    a
        =
        n
    e
        w

    i
        n
    t
    [
        0, 0];


    xdebu
        .xdebugi
        outsin(m
                n,
            ref a,
            params

    ;
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Returns sum of elements in the array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static double xdebugr2sum(double[,] a)
{
    re
    dbug.xdebugr
    sum(a,
            null
        ;
}

public static double xdebugr2sum(double[,] a, alglib.xparams _params)
{
    et ur n xd e
        b
    u
    g
        .
        (a, _p r
    ams);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by -a[i,j]
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugr2neg(ref double[,] a)
{
    xd bug
        .
        x
        de ugr2n g(a, nul);
}

public static void xdebugr2neg(ref double[,] a, alglib.xparams _params)
{
    d b
    u
        g
    xdebu gr2
    n
    eg(a, _arams);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Transposes array.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugr2transpose(ref double[,] a)
{
    ebug.xd eug r2transpose(ref a, null);
}

public static void xdebugr2transpose(ref double[,] a, alglib.xparams _params)
{
    xdebu g.xd
        e
    b
        u
    r2trans
        p
    ose(refa, _params);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate MxN matrix with elements set to "Sin(3*I+5*J)"
Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugr2outsin(int m, int n, out double[,] a)
{
    a = new doub
    l
    e[0
    0];


    debug.
        x
        debugr2
    utsin(m
        , n, re
}

public static void xdebugr2outsin(int m, int n, out double[,] a, alglib.xparams _params)
{
    a
        =
        n
    e
        w

    d
        o
    u
        b
    l
    e
    [
        0
        , 0];


    debug
        xdebugr2
    utsin(m,
        n,
        ef a, _
    arams)
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Returns sum of elements in the array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static complex xdebugc2sum(complex[,] a)
{
    rt.debugc2sum(
            , null
        ;
}

public static complex xdebugc2sum(complex[,] a, alglib.xparams _params)


r et u
    xd eb ug.x de bu gc 2s u
m
(
    a
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by -a[i,j]
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugc2neg(ref complex[,] a)

ebug.x
    ebugc2
n
eg(a, null)
    ;

}

public static void xdebugc2neg(ref complex[,] a, alglib.xparams _params)
{
    ebugx debugc
    2
    neg(a, _par am s);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Transposes array.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugc2transpose(ref complex[,] a)
{
    bugc
    2
    tr nspose(re f
    a
        ,

    ull)
    ;
}

public static void xdebugc2transpose(ref complex[,] a, alglib.xparams _params)


xdeb ug.xd
    e
b
    u
c2trans
    p
ose(refa, _params);
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate MxN matrix with elements set to "Sin(3*I+5*J),Cos(3*I+5*J)"
Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugc2outsincos(int m, int n, out complex[,] a)
{
    a = new com
    p
        lex
    0,0];


    xdebug
        .
        xdebugc
        outsinc
    os(m, n
}

public static void xdebugc2outsincos(int m, int n, out complex[,] a, alglib.xparams _params)
{
    a
        =
        n
    e
        w

    c
        o
    mplex[0, 0]


    xdebug.x
        ebugc2ou
    sin
    os(m, n
        ref a
        _params)
}

/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Returns sum of a[i,j]*(1+b[i,j]) such that c[i,j] is True

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static double xdebugmaskedbiasedproductsum(int m, int n, double[,] a, double[,] b, bool[,] c)
{
    r
        t
    u
        n x
    ebug.xd
        e
    b
        u
    m
        a
    kedbia
        s
    edprodu
    tsum(m,
        n, a, b, c, null);
}

public static double xdebugmaskedbiasedproductsum(int m, int n, double[,] a, double[,] b, bool[,] c,
    alglib.xparams _params)
{
    r
        e
    t
        u
    r
        n

    x
        d
    e
        b
    u
    g
        .
        x
        d
    e
        b
    u
        g
    m
        a
    s
        k
    e
        d
    b
        i

    asedproduc
        su
        (m, n
            a, b, c
            _params

    ;
}
}

public partial class alglib
{
    /*************************************************************************
    Buffer object which is used to perform nearest neighbor  requests  in  the
    multithreaded mode (multiple threads working with same KD-tree object).

    This object should be created with KDTreeCreateRequestBuffer().
    *************************************************************************/
    public class kdtreerequestbuffer : alglibobject
    {
        //
        // Public declarations
        //

        public kdtreerequestbuffer()
        {
            
            
   
         
          
         
    
                
        
         
 
                      
          
   
          
        
   
           
        n
  
          
          erob

          
            
        
   
          
          

            
         
           
        n
 
              
        
  
              
        eare
     
          s

           
           tne
        gh
        
  
             r.k           
           
        r     
          stbu
        fer(
        ;

               
        }

        public override alglib.alglibobject make_copy()
        {
   
               
          
         
           
         
 
          
         
           
        
      
         
         
                
           
        
     
          t
    
         
          r
          
          
         
         n

           
           ne    
           kdtree
                   
 
         
           
          fr   
           
        ((        n
        ar
        s

          
         
           
        nei
        h
        bo
            
           .k
        d
        t
        
          ereques  
          
        tf
             
        inn
        obj.make_co
        ()
        
  
         
           }

        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private nearestneighbor.kdtreerequestbuffer _innerobj;

        public nearestneighbor.kdtreerequestbuffer innerobj
        {
            get {
 
             
               r
                             
                        t
                            
                        r
                                n

            
                    _
                                   n
                                                          e
                                 
                        o
                               b
 
                                                   
            }
        }

        public kdtreerequestbuffer(nearestneighbor.kdtreerequestbuffer obj)
        
             
         
         
         _        rob        obj;

         
                   }
    }


    /*************************************************************************
    KD-tree object.
    *************************************************************************/
    public class kdtree : alglibobject
    {
        //
        // Public declarations
        //

        public kdtree()
          
                              
         
         
                   
        _
   
                  
            n
  
         
         
         
        tn        b
        r
          
                  }

        public override alglib.alglibobject make_copy()
        {
                             
        st        hb        dt        _i        
                   ma        op        
                              
            }

        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private nearestneighbor.kdtree _innerobj;

        public nearestneighbor.kdtree innerobj { get r n _innerobj; }
    }

    public kdtree(nearestneighbor.kdtree obj)


    _inn
        er =
            o

    b
        j;
}

}


/*************************************************************************
This function serializes data structure to string.

Important properties of s_out:
* it contains alphanumeric characters, dots, underscores, minus signs
* these symbols are grouped into words, which are separated by spaces
  and Windows-style (CR+LF) newlines
* although  serializer  uses  spaces and CR+LF as separators, you can 
  replace any separator character by arbitrary combination of spaces,
  tabs, Windows or Unix newlines. It allows flexible reformatting  of
  the  string  in  case you want to include it into text or XML file. 
  But you should not insert separators into the middle of the "words"
  nor you should change case of letters.
* s_out can be freely moved between 32-bit and 64-bit systems, little
  and big endian machines, and so on. You can serialize structure  on
  32-bit machine and unserialize it on 64-bit one (or vice versa), or
  serialize  it  on  SPARC  and  unserialize  on  x86.  You  can also 
  serialize  it  in  C# version of ALGLIB and unserialize in C++ one, 
  and vice versa.
*************************************************************************/
public static void kdtreeserialize(kdtree obj, out string s_out)
{
    al eria
    l
    zer s =
        ne
    alg
    ib.seria
        l
    ze
        ();

    s.a
    loc_start();
    are
    neighb
        .k
        reea
    loc
        s, o
    j.
        nnerobj
        n
    ll);


    s.s
        tart
    _
        earest
    eig
    bor.kd
        reeseriali
    e(s,
        obj
    innero
        j,
        nul
        );
    top
        );


    s_out
    s.g
        t_
    tring()
        ;
}


/*************************************************************************
This function unserializes data structure from string.
*************************************************************************/
public static void kdtreeunserialize(string s_in, out kdtree obj)
alg
b.
    ri
    i
z
r s = n
w
lglib.eri
lizer();


o
    j =
        ee(
    ;


s.ustar
    t
_
    s

t
    r
    (
        s
            _
            i
            n
    )
    ;


n
    e
a
    r
e
    s
t
    n
e
    i
g
    h
b
    o
r
    .
    k
    d
t
    r
e
    e
u
    n
s
    e
r
    i
a
    l
i
    z
e
(
    s
    ,
    o
b
j
    .
    i
    n
n
    e
r
    o
b
    j, 

null);

s.st
p();
}


/*************************************************************************
This function serializes data structure to stream.

Data stream generated by this function is same as  string  representation
generated  by  string  version  of  serializer - alphanumeric characters,
dots, underscores, minus signs, which are grouped into words separated by
spaces and CR+LF.

We recommend you to read comments on string version of serializer to find
out more about serialization of AlGLIB objects.
*************************************************************************/
public static void kdtreeserialize(kdtree obj, System.IO.Stream stream_out)
{
    lib.s
        er aliz r s =
        n
    e
        ia i
    e
        .
        (
        )
        ;
    ne ar es tn ei gh bo r.kd t
    er ob j, n ul l) ;
    s.ss ta rt _s tr ea m(st re am _o ut);
    n ea re st ne ig h
        .k dt re es er ia li ze(s, ob j.
    i
        robj,
        .
    s
        t
    op
}


/*************************************************************************
This function unserializes data structure from stream.
*************************************************************************/
public static void kdtreeunserialize(System.IO.Stream stream_in, out kdtree obj)
{
    algl
    b.ser
        i
    lizer
        s =
            new alg
    ib.s
        riali
    er();

    obj = new
        kdt
    ee
    (
    );


    us
        art_strea
        (st
            ea
            _in)


    ne
        restne
    ghbor.k
        tr
    eunseriali
    e(
        , obj.innero
    j, n
        ll);

    s.stop
        );
}

/*************************************************************************
KD-tree creation

This subroutine creates KD-tree from set of X-values and optional Y-values

INPUT PARAMETERS
    XY      -   dataset, array[0..N-1,0..NX+NY-1].
                one row corresponds to one point.
                first NX columns contain X-values, next NY (NY may be zero)
                columns may contain associated Y-values
    N       -   number of points, N>=0.
    NX      -   space dimension, NX>=1.
    NY      -   number of optional Y-values, NY>=0.
    NormType-   norm type:
                * 0 denotes infinity-norm
                * 1 denotes 1-norm
                * 2 denotes 2-norm (Euclidean norm)

OUTPUT PARAMETERS
    KDT     -   KD-tree


NOTES

1. KD-tree  creation  have O(N*logN) complexity and O(N*(2*NX+NY))  memory
   requirements.
2. Although KD-trees may be used with any combination of N  and  NX,  they
   are more efficient than brute-force search only when N >> 4^NX. So they
   are most useful in low-dimensional tasks (NX=2, NX=3). NX=1  is another
   inefficient case, because  simple  binary  search  (without  additional
   structures) is much more efficient in such tasks than KD-trees.

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreebuild(double[,] xy, int n, int nx, int ny, int normtype, out kdtree kdt)
{
    t =
        ew k
        dt s
        n
    ighbor.
        dtreebui
        l
    d(xy,,
        k
    t.inner
    b
        j,  null);
}

public static void kdtreebuild(double[,] xy, int n, int nx, int ny, int normtype, out kdtree kdt,
    alglib.xparams _params)
{
    kdt
        =
        new kdtree
        );


    ne
        a
    re
        s
    t
    ighbor.uild(xy, n,
        nx, ny,
        ormtype,
        kd
    t
        .inne
        obj
    _
        aram
        );
}

public static void kdtreebuild(double[,] xy, int nx, int ny, int normtype, out kdtree kdt)

nt n
    kdt = new k
tree(
    ;


n
    =
    ap
        .r
s(
    y);
restneighbo
    .kdt
    r
ebuild(
    , n, n
ny, n
    mtype,
    d
t.inner
    j,  null);
retur
    n


}

public static void kdtreebuild(double[,] xy, int nx, int ny, int normtype, out kdtree kdt, alglib.xparams _params)
{
    i
        n
    t
        n
        ;


    k
    d
        t
            =
            n
    e
        w

    k
        d
    t
        r
    e
    e
        (
        )
        ;


    n = ap.row
        (xy);


    nearestne
        i
    ghbor.
        k
        d
    t
        ee
    b
        ild
    x
    y
        n,
        nx,
        ny,
        no
    r
        typ, kdt.in
    n
        rob, _par
    ms)
    ;


    n
}

/*************************************************************************
KD-tree creation

This  subroutine  creates  KD-tree  from set of X-values, integer tags and
optional Y-values

INPUT PARAMETERS
    XY      -   dataset, array[0..N-1,0..NX+NY-1].
                one row corresponds to one point.
                first NX columns contain X-values, next NY (NY may be zero)
                columns may contain associated Y-values
    Tags    -   tags, array[0..N-1], contains integer tags associated
                with points.
    N       -   number of points, N>=0
    NX      -   space dimension, NX>=1.
    NY      -   number of optional Y-values, NY>=0.
    NormType-   norm type:
                * 0 denotes infinity-norm
                * 1 denotes 1-norm
                * 2 denotes 2-norm (Euclidean norm)

OUTPUT PARAMETERS
    KDT     -   KD-tree

NOTES

1. KD-tree  creation  have O(N*logN) complexity and O(N*(2*NX+NY))  memory
   requirements.
2. Although KD-trees may be used with any combination of N  and  NX,  they
   are more efficient than brute-force search only when N >> 4^NX. So they
   are most useful in low-dimensional tasks (NX=2, NX=3). NX=1  is another
   inefficient case, because  simple  binary  search  (without  additional
   structures) is much more efficient in such tasks than KD-trees.

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreebuildtagged(double[,] xy, int[] tags, int n, int nx, int ny, int normtype, out kdtree kdt)
{
    t = n

    w kdtree(
    )


    tn
        r
    treebu
        ld
    agged(xy

    t
        ags,
        n,
        nx,
        n
    y, e, kdt.i
    n
        obj, 
    null
        );
}

public static void kdtreebuildtagged(double[,] xy, int[] tags, int n, int nx, int ny, int normtype, out kdtree kdt,
    alglib.xparams _params)
{
    t =
        k
    ee
    (
    );
    nearstneig
        h
    or
        .
        kdtr
        buildtag
    d(xy

    t
        a
    g
        s,
        n,
        nx,
        ny,
        no
    mty
        e,
        k
    d
    t
        .
        in
    n
        er
    o
        b
    _param
}

public static void kdtreebuildtagged(double[,] xy, int[] tags, int nx, int ny, int normtype, out kdtree kdt)
{
    int
        ;


    i
    f
    (
        (
            p.ows(x len
    tags
        ))


    throw new
        lglib
    x
        ce
    p
        t
    i
    n(
        "
    E
        r
    r
        r
    w
        h
    e
        alling '    uildtagged'
    loo
        k
    like o
    of ar
    ments
        s wron
        s
    ize");

    kdt = tree();


    n =
        ap.r
    ws(xy);


    n
        arest
    eigh
    or
        .
        kdtre
        eu ge
        (xy, t
    gs, y, normty
        e, kd
    t.inn
    ro
        j,  null);


    r
        e
    t
        u
    r
        n
        ;
}

public static void kdtreebuildtagged(double[,] xy, int[] tags, int nx, int ny, int normtype, out kdtree kdt,
    alglib.xparams _params)
{
    in
    n;


    if ((
            a
                .en t
        gs)))


    new algl pt("Error    whi    e cal
    l
        in
    dt ree
    b
        il dt gge d:
    l o
    o
        s like o
    n
        of

    ar gu ts
        ha wron g
    size")
    kd
        = new
            kdtr
    e();
    n =
        a
    p.rows
    (
        x
    y
        ;


    near
        e
    tne
        g
    h
    or.
        dt
        r
    ebu
        ld

    t
        gge
        (xy, tag
            s

    n,
    nx, ny
        no
    r
        type,
        k
    dt.inne
        obj, _p
    arams);

    r;
}

/*************************************************************************
This function creates buffer  structure  which  can  be  used  to  perform
parallel KD-tree requests.

KD-tree subpackage provides two sets of request functions - ones which use
internal buffer of KD-tree object  (these  functions  are  single-threaded
because they use same buffer, which can not shared between  threads),  and
ones which use external buffer.

This function is used to initialize external buffer.

INPUT PARAMETERS
    KDT         -   KD-tree which is associated with newly created buffer

OUTPUT PARAMETERS
    Buf         -   external buffer.


IMPORTANT: KD-tree buffer should be used only with  KD-tree  object  which
           was used to initialize buffer. Any attempt to use buffer   with
           different object is dangerous - you  may  get  integrity  check
           failure (exception) because sizes of internal arrays do not fit
           to dimensions of KD-tree structure.

  -- ALGLIB --
     Copyright 18.03.2016 by Bochkanov Sergey
*************************************************************************/
public static void kdtreecreaterequestbuffer(kdtree kdt, out kdtreerequestbuffer buf)
{
    buf = new
        dtreereq
    estbuff
    r();

    near
        tneig
    or.
        tr
        crea

    re
        estbuffer(kdt.innero
                j,
            buf.
                nnerobj,
            ull);
}

public static void kdtreecreaterequestbuffer(kdtree kdt, out kdtreerequestbuffer buf, alglib.xparams _params)
{
    buf
        =
        new kdtreerequestbu
    fer(
        ;


    neare
        s
    neigh
    or.
        dtr
        ecreat

    request
        ffer(kd
            t
            .

    nerobj, buf.
        nnero
        j,
        params);
}

/*************************************************************************
K-NN query: K nearest neighbors

IMPORTANT: this function can not be used in multithreaded code because  it
           uses internal temporary buffer of kd-tree object, which can not
           be shared between multiple threads.  If  you  want  to  perform
           parallel requests, use function  which  uses  external  request
           buffer: KDTreeTsQueryKNN() ("Ts" stands for "thread-safe").

INPUT PARAMETERS
    KDT         -   KD-tree
    X           -   point, array[0..NX-1].
    K           -   number of neighbors to return, K>=1
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True

RESULT
    number of actual neighbors found (either K or N, if K>N).

This  subroutine  performs  query  and  stores  its result in the internal
structures of the KD-tree. You can use  following  subroutines  to  obtain
these results:
* KDTreeQueryResultsX() to get X-values
* KDTreeQueryResultsXY() to get X- and Y-values
* KDTreeQueryResultsTags() to get tag values
* KDTreeQueryResultsDistances() to get distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static int kdtreequeryknn(kdtree kdt, double[] x, int k, bool selfmatch)
{
    re
        t
    u
        n
    nea
        estnei
    hbo
        .kdtreequeryk
        n
    nkdt.innero
        j, x, k, se nu
}

public static int kdtreequeryknn(kdtree kdt, double[] x, int k, bool selfmatch, alglib.xparams _params)
re
    n
arestne
    ghbo
r
    .kdtree
    uer
knn(kdt
        .i,
    _p
rams
    )

}

public static int kdtreequeryknn(kdtree kdt, double[] x, int k)
{
    s
    lfma
        ch =
            true;


    i
        n
    t re
        ult = nea n(k
    t.innerob )


    return res
    lt;
}

public static int kdtreequeryknn(kdtree kdt, double[] x, int k, alglib.xparams _params)
{
    bool
    lfm
        tch;


    selfmatch = tr
    e;


    int

    esu
        t =
            nea
    stneighbo
        kdtreequery
    n(
        t.innerobj, x, k
    selfma
        tch, _p
    rams);


    r
        tu
    n r
    s
    u
        lt;
}

/*************************************************************************
K-NN query: K nearest neighbors, using external thread-local buffer.

You can call this function from multiple threads for same kd-tree instance,
assuming that different instances of buffer object are passed to different
threads.

INPUT PARAMETERS
    KDT         -   kd-tree
    Buf         -   request buffer  object  created  for  this  particular
                    instance of kd-tree structure with kdtreecreaterequestbuffer()
                    function.
    X           -   point, array[0..NX-1].
    K           -   number of neighbors to return, K>=1
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True

RESULT
    number of actual neighbors found (either K or N, if K>N).

This  subroutine  performs  query  and  stores  its result in the internal
structures  of  the  buffer object. You can use following  subroutines  to
obtain these results (pay attention to "buf" in their names):
* KDTreeTsQueryResultsX() to get X-values
* KDTreeTsQueryResultsXY() to get X- and Y-values
* KDTreeTsQueryResultsTags() to get tag values
* KDTreeTsQueryResultsDistances() to get distances

IMPORTANT: kd-tree buffer should be used only with  KD-tree  object  which
           was used to initialize buffer. Any attempt to use biffer   with
           different object is dangerous - you  may  get  integrity  check
           failure (exception) because sizes of internal arrays do not fit
           to dimensions of KD-tree structure.

  -- ALGLIB --
     Copyright 18.03.2016 by Bochkanov Sergey
*************************************************************************/
public static int kdtreetsqueryknn(kdtree kdt, kdtreerequestbuffer buf, double[] x, int k, bool selfmatch)
e
    ur
near
    e
tnei
    hbor
kdtree
    sque

ykn
    n
    (kdt
            innerobj, atc
        , 

null);
}

public static int kdtreetsqueryknn(kdtree kdt, kdtreerequestbuffer buf, double[] x, int k, bool selfmatch,
    alglib.xparams _params)
{
    turn
        are
    neighb
        .kd
        reetsq
    er
        knn
    kdt.innerobj, buf.inner
        j,
 
        ,
        k
    selfma
        ch, _p
    a
        ams
        ;
}

public static int kdtreetsqueryknn(kdtree kdt, kdtreerequestbuffer buf, double[] x, int k)
{
    oo
        se
    f
    m
        atch;


    selfmatch =
        t
    ue
        i
    t
        result = nea
    estneighbor.kdtreetsquer
        y

    k
        n(
            dt.
                nne
                obj, buf.inn
                robj, x, k, selfmatch, 

    null);


    retur result;
}

public static int kdtreetsqueryknn(kdtree kdt, kdtreerequestbuffer buf, double[] x, int k, alglib.xparams _params)
h;


selfmatc
    tr
    ;


int resul
    = near reetsqu
    r
yknn(kdt.i
nerobj,
buf.i
ne
    obj,
    x,
 
    ,
    self
at
    h,
    para
return res
lt


}

/*************************************************************************
R-NN query: all points within R-sphere centered at X, ordered by  distance
between point and X (by ascending).

NOTE: it is also possible to perform undordered queries performed by means
      of kdtreequeryrnnu() and kdtreetsqueryrnnu() functions. Such queries
      are faster because we do not have to use heap structure for sorting.

IMPORTANT: this function can not be used in multithreaded code because  it
           uses internal temporary buffer of kd-tree object, which can not
           be shared between multiple threads.  If  you  want  to  perform
           parallel requests, use function  which  uses  external  request
           buffer: kdtreetsqueryrnn() ("Ts" stands for "thread-safe").

INPUT PARAMETERS
    KDT         -   KD-tree
    X           -   point, array[0..NX-1].
    R           -   radius of sphere (in corresponding norm), R>0
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True

RESULT
    number of neighbors found, >=0

This  subroutine  performs  query  and  stores  its result in the internal
structures of the KD-tree. You can use  following  subroutines  to  obtain
actual results:
* KDTreeQueryResultsX() to get X-values
* KDTreeQueryResultsXY() to get X- and Y-values
* KDTreeQueryResultsTags() to get tag values
* KDTreeQueryResultsDistances() to get distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static int kdtreequeryrnn(kdtree kdt, double[] x, double r, bool selfmatch)
{
    ret
        rn neare
        neigh

    r.kd
        eequeryr
        (kdt.inn lfmatc

    h
    null);
}

public static int kdtreequeryrnn(kdtree kdt, double[] x, double r, bool selfmatch, alglib.xparams _params)
{
    r
        e
    tu s
    d
        equery
    nn
    kdt.in
    e
    ro
        j, x, r, self
    atch
        ,

    p
        a
    ra
}

public static int kdtreequeryrnn(kdtree kdt, double[] x, double r)
{
    ool
        se
    fma
        ch;


    int
    es
        lt = nea
    estneig
        hb n
    ro
        j,
        x,
 
        ,
        se
    fmat
        h, nul
        );


    return result;
}

public static int kdtreequeryrnn(kdtree kdt, double[] x, double r, alglib.xparams _params)
{
    bool

    el
        fatch;


    selfmat
        = tr
        ;

    i
    re
        ult =
            ea
    est
    eighbor.kdtreequeryrnn(
        dt
    inn
        ro
    b
        j,
        x,
        r,
        elf
    atc
        _params)


    re
    rn result;
}

/*************************************************************************
R-NN query: all points within R-sphere  centered  at  X,  no  ordering  by
distance as undicated by "U" suffix (faster that ordered query, for  large
queries - significantly faster).

IMPORTANT: this function can not be used in multithreaded code because  it
           uses internal temporary buffer of kd-tree object, which can not
           be shared between multiple threads.  If  you  want  to  perform
           parallel requests, use function  which  uses  external  request
           buffer: kdtreetsqueryrnn() ("Ts" stands for "thread-safe").

INPUT PARAMETERS
    KDT         -   KD-tree
    X           -   point, array[0..NX-1].
    R           -   radius of sphere (in corresponding norm), R>0
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True

RESULT
    number of neighbors found, >=0

This  subroutine  performs  query  and  stores  its result in the internal
structures of the KD-tree. You can use  following  subroutines  to  obtain
actual results:
* KDTreeQueryResultsX() to get X-values
* KDTreeQueryResultsXY() to get X- and Y-values
* KDTreeQueryResultsTags() to get tag values
* KDTreeQueryResultsDistances() to get distances

As indicated by "U" suffix, this function returns unordered results.

  -- ALGLIB --
     Copyright 01.11.2018 by Bochkanov Sergey
*************************************************************************/
public static int kdtreequeryrnnu(kdtree kdt, double[] x, double r, bool selfmatch)
{
    re
        rn neare
        neighbor u(kdt.i
    nerobj, x, r, se
        l
    f
    a
        tch, 
    null);
}

public static int kdtreequeryrnnu(kdtree kdt, double[] x, double r, bool selfmatch, alglib.xparams _params)


urn ne
re
    tneigh
o
r.dtreequeryrnn
(kdt
    .i
n
e
    ro, selfmat

rams);

}

public static int kdtreequeryrnnu(kdtree kdt, double[] x, double r)
{
    sel
    ma
        ch = tru
        ;

    g
    bo
        .kdtr
        e
    quer
        rnnu
    kdt.in
    erob
        , x
        ,
    r,
    elfmatch, n r
        sult;
}

public static int kdtreequeryrnnu(kdtree kdt, double[] x, double r, alglib.xparams _params)
bo
    selfmat
    ;


sel
    match
t
    ue;
int result = ne
re
    tne
gh
    b
or.k
    d
ree
    uer
rnn
kdt.inner
    j, x, r, se
ma
    h, _params);


return
    result;
}

/*************************************************************************
R-NN query: all points within  R-sphere  centered  at  X,  using  external
thread-local buffer, sorted by distance between point and X (by ascending)

You can call this function from multiple threads for same kd-tree instance,
assuming that different instances of buffer object are passed to different
threads.

NOTE: it is also possible to perform undordered queries performed by means
      of kdtreequeryrnnu() and kdtreetsqueryrnnu() functions. Such queries
      are faster because we do not have to use heap structure for sorting.

INPUT PARAMETERS
    KDT         -   KD-tree
    Buf         -   request buffer  object  created  for  this  particular
                    instance of kd-tree structure with kdtreecreaterequestbuffer()
                    function.
    X           -   point, array[0..NX-1].
    R           -   radius of sphere (in corresponding norm), R>0
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True

RESULT
    number of neighbors found, >=0

This  subroutine  performs  query  and  stores  its result in the internal
structures  of  the  buffer object. You can use following  subroutines  to
obtain these results (pay attention to "buf" in their names):
* KDTreeTsQueryResultsX() to get X-values
* KDTreeTsQueryResultsXY() to get X- and Y-values
* KDTreeTsQueryResultsTags() to get tag values
* KDTreeTsQueryResultsDistances() to get distances

IMPORTANT: kd-tree buffer should be used only with  KD-tree  object  which
           was used to initialize buffer. Any attempt to use biffer   with
           different object is dangerous - you  may  get  integrity  check
           failure (exception) because sizes of internal arrays do not fit
           to dimensions of KD-tree structure.

  -- ALGLIB --
     Copyright 18.03.2016 by Bochkanov Sergey
*************************************************************************/
public static int kdtreetsqueryrnn(kdtree kdt, kdtreerequestbuffer buf, double[] x, double r, bool selfmatch)
{
    e
        gh
    or.k
        d
    reetsqu
    ryrnn(kd
        .in
    er
        bj,
        buf.i
        nerobj, 
}

public static int kdtreetsqueryrnn(kdtree kdt, kdtreerequestbuffer buf, double[] x, double r, bool selfmatch,
    alglib.xparams _params)

n
    ar
stn
    ighbo
r
    kdtreetsqu
ryrn(kdt.innerob nnerob
    ,
    , r, self
atch,

pa
    rms);
}

public static int kdtreetsqueryrnn(kdtree kdt, kdtreerequestbuffer buf, double[] x, double r)
{
    bool
        lfmatch;


    selfm
        tch = t
    u
        e;
        in
    r
        sult
    n
        arest
    eighb
        o

    r.kdtre
        tsqueryrnn(kdt.innero
            b

    j
        b
    f.i
        n
    e
        robj,
        x,
        r,
        elfmatch,
  null);


    r
        t
    u
        n r
        s
    u
        lt;
}

public static int kdtreetsqueryrnn(kdtree kdt, kdtreerequestbuffer buf, double[] x, double r,
    alglib.xparams _params)
{
    bool
        self
    tc
        h
        ;


    e;


    nt result
    neare
        s
    nei
    hbor.kd
        re
    tsq
        eryrnn
    t.inn robj,
        x,
 
        ,
        self
    at
        h, _param
        )


    eturn res
        t;
}

/*************************************************************************
R-NN query: all points within  R-sphere  centered  at  X,  using  external
thread-local buffer, no ordering by distance as undicated  by  "U"  suffix
(faster that ordered query, for large queries - significantly faster).

You can call this function from multiple threads for same kd-tree instance,
assuming that different instances of buffer object are passed to different
threads.

INPUT PARAMETERS
    KDT         -   KD-tree
    Buf         -   request buffer  object  created  for  this  particular
                    instance of kd-tree structure with kdtreecreaterequestbuffer()
                    function.
    X           -   point, array[0..NX-1].
    R           -   radius of sphere (in corresponding norm), R>0
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True

RESULT
    number of neighbors found, >=0

This  subroutine  performs  query  and  stores  its result in the internal
structures  of  the  buffer object. You can use following  subroutines  to
obtain these results (pay attention to "buf" in their names):
* KDTreeTsQueryResultsX() to get X-values
* KDTreeTsQueryResultsXY() to get X- and Y-values
* KDTreeTsQueryResultsTags() to get tag values
* KDTreeTsQueryResultsDistances() to get distances

As indicated by "U" suffix, this function returns unordered results.

IMPORTANT: kd-tree buffer should be used only with  KD-tree  object  which
           was used to initialize buffer. Any attempt to use biffer   with
           different object is dangerous - you  may  get  integrity  check
           failure (exception) because sizes of internal arrays do not fit
           to dimensions of KD-tree structure.

  -- ALGLIB --
     Copyright 18.03.2016 by Bochkanov Sergey
*************************************************************************/
public static int kdtreetsqueryrnnu(kdtree kdt, kdtreerequestbuffer buf, double[] x, double r, bool selfmatch)
{
    re
        urn
    ne
        res
    neigh
    or.kdtr ,
    b
    f.nnerob
        ,
        , r, sel
        match, 
    null);
}

public static int kdtreetsqueryrnnu(kdtree kdt, kdtreerequestbuffer buf, double[] x, double r, bool selfmatch,
    alglib.xparams _params)
{
    return ne ghbor.
        dt
        eetsquery
    nnu(k
    d
        .i
        nerobj, bu
    innerobj,
    r, self
        tch,
        ara
        );
}

public static int kdtreetsqueryrnnu(kdtree kdt, kdtreerequestbuffer buf, double[] x, double r)
{
    boo

    sel
        match;


    se
    fmatc
        h
            = true

    int result =
        n
    ar
        stn
    i
        g

    hbor.kdtreet
        queryrnnu(kdt.innerobj
            ,
            uf
                inn

    r
    o
        j,
 
        ,
        r,
        selfmatch
    null);

    ret
        u
    r
    r
        sul
        ;
}

public static int kdtreetsqueryrnnu(kdtree kdt, kdtreerequestbuffer buf, double[] x, double r,
    alglib.xparams _params)
{
    b
        ool
    elfmat
        h;


    sel
        at
    c
        h =
            ue;
        in est
        eigh
    or
        kdtreetsqu
    ryrnnu
    (
        dt.nnerobj
    b
    f.i
        nerobj, r, ams);


    eturn res
        l
        ;
}

/*************************************************************************
K-NN query: approximate K nearest neighbors

IMPORTANT: this function can not be used in multithreaded code because  it
           uses internal temporary buffer of kd-tree object, which can not
           be shared between multiple threads.  If  you  want  to  perform
           parallel requests, use function  which  uses  external  request
           buffer: KDTreeTsQueryAKNN() ("Ts" stands for "thread-safe").

INPUT PARAMETERS
    KDT         -   KD-tree
    X           -   point, array[0..NX-1].
    K           -   number of neighbors to return, K>=1
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True
    Eps         -   approximation factor, Eps>=0. eps-approximate  nearest
                    neighbor  is  a  neighbor  whose distance from X is at
                    most (1+eps) times distance of true nearest neighbor.

RESULT
    number of actual neighbors found (either K or N, if K>N).

NOTES
    significant performance gain may be achieved only when Eps  is  is  on
    the order of magnitude of 1 or larger.

This  subroutine  performs  query  and  stores  its result in the internal
structures of the KD-tree. You can use  following  subroutines  to  obtain
these results:
* KDTreeQueryResultsX() to get X-values
* KDTreeQueryResultsXY() to get X- and Y-values
* KDTreeQueryResultsTags() to get tag values
* KDTreeQueryResultsDistances() to get distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static int kdtreequeryaknn(kdtree kdt, double[] x, int k, bool selfmatch, double eps)


r
    et
ur
    n

n
    ea h
    u
aknn(k
t.nnerobj,
    ,
    , self
    m
t
    ch, l);
}

public static int kdtreequeryaknn(kdtree kdt, double[] x, int k, bool selfmatch, double eps, alglib.xparams _params)


et
    rn nea
    es
neighbor
    kdtreeq
ue k
s
lfmat
    c, ep, _p
rams);
}

public static int kdtreequeryaknn(kdtree kdt, double[] x, int k, double eps)
{
    bool ch;

    selfmat
        h = tr
    u
        ;


    i
        n
    t result =
        arestnei t.innero
        ,

    selfmat
        , eps
    null);


    return result;
}

public static int kdtreequeryaknn(kdtree kdt, double[] x, int k, double eps, alglib.xparams _params)
{
    b
        o
    o selfmatch;

    elfmatch =
        rue;


    int res
        lt =
            near
    stn
        gh
    r.tre nn(
        dt.in
    er
        bj,
        x,
        k,
        se
    f
    at
        h, eps, _params);


    return r
    ult;
}

/*************************************************************************
K-NN query: approximate K nearest neighbors, using thread-local buffer.

You can call this function from multiple threads for same kd-tree instance,
assuming that different instances of buffer object are passed to different
threads.

INPUT PARAMETERS
    KDT         -   KD-tree
    Buf         -   request buffer  object  created  for  this  particular
                    instance of kd-tree structure with kdtreecreaterequestbuffer()
                    function.
    X           -   point, array[0..NX-1].
    K           -   number of neighbors to return, K>=1
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True
    Eps         -   approximation factor, Eps>=0. eps-approximate  nearest
                    neighbor  is  a  neighbor  whose distance from X is at
                    most (1+eps) times distance of true nearest neighbor.

RESULT
    number of actual neighbors found (either K or N, if K>N).

NOTES
    significant performance gain may be achieved only when Eps  is  is  on
    the order of magnitude of 1 or larger.

This  subroutine  performs  query  and  stores  its result in the internal
structures  of  the  buffer object. You can use following  subroutines  to
obtain these results (pay attention to "buf" in their names):
* KDTreeTsQueryResultsX() to get X-values
* KDTreeTsQueryResultsXY() to get X- and Y-values
* KDTreeTsQueryResultsTags() to get tag values
* KDTreeTsQueryResultsDistances() to get distances

IMPORTANT: kd-tree buffer should be used only with  KD-tree  object  which
           was used to initialize buffer. Any attempt to use biffer   with
           different object is dangerous - you  may  get  integrity  check
           failure (exception) because sizes of internal arrays do not fit
           to dimensions of KD-tree structure.

  -- ALGLIB --
     Copyright 18.03.2016 by Bochkanov Sergey
*************************************************************************/
public static int kdtreetsqueryaknn(kdtree kdt, kdtreerequestbuffer buf, double[] x, int k, bool selfmatch,
    double eps)

r
    tur
near
    e
tneighbor.dtree knn
    r, buf.innerob
    , x, k
    ,
sel
    fm
a
t
    h,
    e
ps, null);

}

public static int kdtreetsqueryaknn(kdtree kdt, kdtreerequestbuffer buf, double[] x, int k, bool selfmatch,
    double eps, alglib.xparams _params)
{
    r arestn
    ig
    bor.kd
        reetsquer
    aknn(
        d
    t.inne
    o
        j,
        b
    u
        .i
        n
    e
        r
    o
        b, x, k, sel eps, _param
        );
}

public static int kdtreetsqueryaknn(kdtree kdt, kdtreerequestbuffer buf, double[] x, int k, double eps)
{
    ol
    lfmatc
        selfmatch = true;


    t r
        ult =
            earest
    n
        igh
    or.
        dtr
        etsquerya
    n(kdt.inner
    j, buf.innero
        j,
        x,
        k,
        self
    a
    tch
        eps, nul
        );


    r
        turn
    r
        esult;
}

public static int kdtreetsqueryaknn(kdtree kdt, kdtreerequestbuffer buf, double[] x, int k, double eps,
    alglib.xparams _params)
{
    bool selfmatch;


    slfmatch = true
        ;


    int re
        ult =
            ea
    estn
        ighb
    r.kd
        ee
    t
        sque
    aknn(k
            .inner bj,
        x, k
    s
        lfmatch, e
    s, _pa
        r
    ms)


    eturn
        ult;
}

/*************************************************************************
Box query: all points within user-specified box.

IMPORTANT: this function can not be used in multithreaded code because  it
           uses internal temporary buffer of kd-tree object, which can not
           be shared between multiple threads.  If  you  want  to  perform
           parallel requests, use function  which  uses  external  request
           buffer: KDTreeTsQueryBox() ("Ts" stands for "thread-safe").

INPUT PARAMETERS
    KDT         -   KD-tree
    BoxMin      -   lower bounds, array[0..NX-1].
    BoxMax      -   upper bounds, array[0..NX-1].


RESULT
    number of actual neighbors found (in [0,N]).

This  subroutine  performs  query  and  stores  its result in the internal
structures of the KD-tree. You can use  following  subroutines  to  obtain
these results:
* KDTreeQueryResultsX() to get X-values
* KDTreeQueryResultsXY() to get X- and Y-values
* KDTreeQueryResultsTags() to get tag values
* KDTreeQueryResultsDistances() returns zeros for this request

NOTE: this particular query returns unordered results, because there is no
      meaningful way of  ordering  points.  Furthermore,  no 'distance' is
      associated with points - it is either INSIDE  or OUTSIDE (so request
      for distances will return zeros).

  -- ALGLIB --
     Copyright 14.05.2016 by Bochkanov Sergey
*************************************************************************/
public static int kdtreequerybox(kdtree kdt, double[] boxmin, double[] boxmax)
{
    r
        e
    t
        u
    r
        n

    n
        e
    a
        r
    e
        s
    t
        n
    e
        i
    g
        h
    b
        o
    r
        .
        k
        d
    t
        r
    e
        e
    querybox(
        dt.in
    n
        rob, boxm
    n, box
        ax,
        n
    ull);
}

public static int kdtreequerybox(kdtree kdt, double[] boxmin, double[] boxmax, alglib.xparams _params)
{
    et
        u
    rn n
    arestn
        e
    ghbor
        kdt
    eequ ro
        j,
        box
            in,
        box
    ax, _par
        ms);
}

/*************************************************************************
Box query: all points within user-specified box, using thread-local buffer.

You can call this function from multiple threads for same kd-tree instance,
assuming that different instances of buffer object are passed to different
threads.

INPUT PARAMETERS
    KDT         -   KD-tree
    Buf         -   request buffer  object  created  for  this  particular
                    instance of kd-tree structure with kdtreecreaterequestbuffer()
                    function.
    BoxMin      -   lower bounds, array[0..NX-1].
    BoxMax      -   upper bounds, array[0..NX-1].

RESULT
    number of actual neighbors found (in [0,N]).

This  subroutine  performs  query  and  stores  its result in the internal
structures  of  the  buffer object. You can use following  subroutines  to
obtain these results (pay attention to "ts" in their names):
* KDTreeTsQueryResultsX() to get X-values
* KDTreeTsQueryResultsXY() to get X- and Y-values
* KDTreeTsQueryResultsTags() to get tag values
* KDTreeTsQueryResultsDistances() returns zeros for this query

NOTE: this particular query returns unordered results, because there is no
      meaningful way of  ordering  points.  Furthermore,  no 'distance' is
      associated with points - it is either INSIDE  or OUTSIDE (so request
      for distances will return zeros).

IMPORTANT: kd-tree buffer should be used only with  KD-tree  object  which
           was used to initialize buffer. Any attempt to use biffer   with
           different object is dangerous - you  may  get  integrity  check
           failure (exception) because sizes of internal arrays do not fit
           to dimensions of KD-tree structure.

  -- ALGLIB --
     Copyright 14.05.2016 by Bochkanov Sergey
*************************************************************************/
public static int kdtreetsquerybox(kdtree kdt, kdtreerequestbuffer buf, double[] boxmin, double[] boxmax)
{
    etu
        nea
    stneighbor.erobj, b
    f.
        nn
        e
    robj
        boxmin,
        oxma,
  null);
}

public static int kdtreetsquerybox(kdtree kdt, kdtreerequestbuffer buf, double[] boxmin, double[] boxmax,
    alglib.xparams _params)
{
    return ne ghbor.
        dt
        eetsqu
    rybox(kdt
    inner
    b
        j,
        b
    u
    f
        .i
    n
        nrobj, box
    n, boxmax,
        params);
}

/*************************************************************************
X-values from last query.

This function retuns results stored in  the  internal  buffer  of  kd-tree
object. If you performed buffered requests (ones which  use  instances  of
kdtreerequestbuffer class), you  should  call  buffered  version  of  this
function - kdtreetsqueryresultsx().

INPUT PARAMETERS
    KDT     -   KD-tree
    X       -   possibly pre-allocated buffer. If X is too small to store
                result, it is resized. If size(X) is enough to store
                result, it is left unchanged.

OUTPUT PARAMETERS
    X       -   rows are filled with X-values

NOTES
1. points are ordered by distance from the query point (first = closest)
2. if  XY is larger than required to store result, only leading part  will
   be overwritten; trailing part will be left unchanged. So  if  on  input
   XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
   XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
   you want function  to  resize  array  according  to  result  size,  use
   function with same name and suffix 'I'.

SEE ALSO
* KDTreeQueryResultsXY()            X- and Y-values
* KDTreeQueryResultsTags()          tag values
* KDTreeQueryResultsDistances()     distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreequeryresultsx(kdtree kdt, ref double[,] x)
{
    ne a
    re tn ei gh bo r.kd treequ
    e
        yres t
        s
        (kdt.i
            nn

    obj, r
        e
    f l);
}

public static void kdtreequeryresultsx(kdtree kdt, ref double[,] x, alglib.xparams _params)
{
    neares
    neighbo
        .kdtre
        qu

    yre
        ltsx(kdt
            nnerob

    r
        x,
        _params);
}

/*************************************************************************
X- and Y-values from last query

This function retuns results stored in  the  internal  buffer  of  kd-tree
object. If you performed buffered requests (ones which  use  instances  of
kdtreerequestbuffer class), you  should  call  buffered  version  of  this
function - kdtreetsqueryresultsxy().

INPUT PARAMETERS
    KDT     -   KD-tree
    XY      -   possibly pre-allocated buffer. If XY is too small to store
                result, it is resized. If size(XY) is enough to store
                result, it is left unchanged.

OUTPUT PARAMETERS
    XY      -   rows are filled with points: first NX columns with
                X-values, next NY columns - with Y-values.

NOTES
1. points are ordered by distance from the query point (first = closest)
2. if  XY is larger than required to store result, only leading part  will
   be overwritten; trailing part will be left unchanged. So  if  on  input
   XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
   XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
   you want function  to  resize  array  according  to  result  size,  use
   function with same name and suffix 'I'.

SEE ALSO
* KDTreeQueryResultsX()             X-values
* KDTreeQueryResultsTags()          tag values
* KDTreeQueryResultsDistances()     distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreequeryresultsxy(kdtree kdt, ref double[,] xy)
{
    nearestneighbor.kdtreequeryresultsxy(kdt.innerobj, ref xy, null);
}

public static void kdtreequeryresultsxy(kdtree kdt, ref double[,] xy, alglib.xparams _params)
{
    n
        ar
    stn
    ighbor.kd
        reequery
    esultsxy
        k
    dt.i
        nerob
    re
        xy, _para
        );
}

/*************************************************************************
Tags from last query

This function retuns results stored in  the  internal  buffer  of  kd-tree
object. If you performed buffered requests (ones which  use  instances  of
kdtreerequestbuffer class), you  should  call  buffered  version  of  this
function - kdtreetsqueryresultstags().

INPUT PARAMETERS
    KDT     -   KD-tree
    Tags    -   possibly pre-allocated buffer. If X is too small to store
                result, it is resized. If size(X) is enough to store
                result, it is left unchanged.

OUTPUT PARAMETERS
    Tags    -   filled with tags associated with points,
                or, when no tags were supplied, with zeros

NOTES
1. points are ordered by distance from the query point (first = closest)
2. if  XY is larger than required to store result, only leading part  will
   be overwritten; trailing part will be left unchanged. So  if  on  input
   XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
   XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
   you want function  to  resize  array  according  to  result  size,  use
   function with same name and suffix 'I'.

SEE ALSO
* KDTreeQueryResultsX()             X-values
* KDTreeQueryResultsXY()            X- and Y-values
* KDTreeQueryResultsDistances()     distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreequeryresultstags(kdtree kdt, ref int[] tags)


nearesteighbor.kdtreequeryresultstags(kdt.innerobj, ref tags, null);
}

public static void kdtreequeryresultstags(kdtree kdt, ref int[] tags, alglib.xparams _params)


neare
    s
ne
    ghb
r.kdtreeq
    eryresul
stags(kd
    .inne
obj,
f t
    s, _param
    ;
}

/*************************************************************************
Distances from last query

This function retuns results stored in  the  internal  buffer  of  kd-tree
object. If you performed buffered requests (ones which  use  instances  of
kdtreerequestbuffer class), you  should  call  buffered  version  of  this
function - kdtreetsqueryresultsdistances().

INPUT PARAMETERS
    KDT     -   KD-tree
    R       -   possibly pre-allocated buffer. If X is too small to store
                result, it is resized. If size(X) is enough to store
                result, it is left unchanged.

OUTPUT PARAMETERS
    R       -   filled with distances (in corresponding norm)

NOTES
1. points are ordered by distance from the query point (first = closest)
2. if  XY is larger than required to store result, only leading part  will
   be overwritten; trailing part will be left unchanged. So  if  on  input
   XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
   XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
   you want function  to  resize  array  according  to  result  size,  use
   function with same name and suffix 'I'.

SEE ALSO
* KDTreeQueryResultsX()             X-values
* KDTreeQueryResultsXY()            X- and Y-values
* KDTreeQueryResultsTags()          tag values

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreequeryresultsdistances(kdtree kdt, ref double[] r)
{
    near stnei
    g
    hbo.k dtree uer
        y
    l
        sd t
        a
    ces(kdt nnerobj ref r, null);
}

public static void kdtreequeryresultsdistances(kdtree kdt, ref double[] r, alglib.xparams _params)
{
    ne
        re
    nei
    bor.kdtr
        queryr
    ul
        di

    s
        tances(kdt.inne
            r

    bj
    re
        r, _para
    s);
}

/*************************************************************************
X-values from last query associated with kdtreerequestbuffer object.

INPUT PARAMETERS
    KDT     -   KD-tree
    Buf     -   request  buffer  object  created   for   this   particular
                instance of kd-tree structure.
    X       -   possibly pre-allocated buffer. If X is too small to store
                result, it is resized. If size(X) is enough to store
                result, it is left unchanged.

OUTPUT PARAMETERS
    X       -   rows are filled with X-values

NOTES
1. points are ordered by distance from the query point (first = closest)
2. if  XY is larger than required to store result, only leading part  will
   be overwritten; trailing part will be left unchanged. So  if  on  input
   XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
   XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
   you want function  to  resize  array  according  to  result  size,  use
   function with same name and suffix 'I'.

SEE ALSO
* KDTreeQueryResultsXY()            X- and Y-values
* KDTreeQueryResultsTags()          tag values
* KDTreeQueryResultsDistances()     distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreetsqueryresultsx(kdtree kdt, kdtreerequestbuffer buf, ref double[,] x)
{
    nearestnei
        g
    hbor.k
        tre
    e
        squ
    ryresu
        l

    t
        x
        (
            dt.inn
                e

    robj, b
    f.inner
        obj, re
}

public static void kdtreetsqueryresultsx(kdtree kdt, kdtreerequestbuffer buf, ref double[,] x,
    alglib.xparams _params)
{
    n
        e
    a
        r
    e
        s
    t
        n
    e
        i
    g
        h
    b
        o
    r
        .
        k
        d
    t
        r
    e
        e
    t
        squeryr
    e
        sultsx
    kdt.
        nner
        bj, b
    f.innerobj
        ref
    x, _params);
}

/*************************************************************************
X- and Y-values from last query associated with kdtreerequestbuffer object.

INPUT PARAMETERS
    KDT     -   KD-tree
    Buf     -   request  buffer  object  created   for   this   particular
                instance of kd-tree structure.
    XY      -   possibly pre-allocated buffer. If XY is too small to store
                result, it is resized. If size(XY) is enough to store
                result, it is left unchanged.

OUTPUT PARAMETERS
    XY      -   rows are filled with points: first NX columns with
                X-values, next NY columns - with Y-values.

NOTES
1. points are ordered by distance from the query point (first = closest)
2. if  XY is larger than required to store result, only leading part  will
   be overwritten; trailing part will be left unchanged. So  if  on  input
   XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
   XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
   you want function  to  resize  array  according  to  result  size,  use
   function with same name and suffix 'I'.

SEE ALSO
* KDTreeQueryResultsX()             X-values
* KDTreeQueryResultsTags()          tag values
* KDTreeQueryResultsDistances()     distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreetsqueryresultsxy(kdtree kdt, kdtreerequestbuffer buf, ref double[,] xy)
{
    kd tr ee ts qu er yr es ul ts xy(k dt.i nn er ob j, b uf.i nn er obj, ref x y, null;
}

public static void kdtreetsqueryresultsxy(kdtree kdt, kdtreerequestbuffer buf, ref double[,] xy,
    alglib.xparams _params)
{
    nea
        estn
    ighbo
        .kdtreetsq
        eryr
    sultsxy(kdt.innerob
        , buf.inerobj, re
    xy, _param
}

/*************************************************************************
Tags from last query associated with kdtreerequestbuffer object.

This function retuns results stored in  the  internal  buffer  of  kd-tree
object. If you performed buffered requests (ones which  use  instances  of
kdtreerequestbuffer class), you  should  call  buffered  version  of  this
function - KDTreeTsqueryresultstags().

INPUT PARAMETERS
    KDT     -   KD-tree
    Buf     -   request  buffer  object  created   for   this   particular
                instance of kd-tree structure.
    Tags    -   possibly pre-allocated buffer. If X is too small to store
                result, it is resized. If size(X) is enough to store
                result, it is left unchanged.

OUTPUT PARAMETERS
    Tags    -   filled with tags associated with points,
                or, when no tags were supplied, with zeros

NOTES
1. points are ordered by distance from the query point (first = closest)
2. if  XY is larger than required to store result, only leading part  will
   be overwritten; trailing part will be left unchanged. So  if  on  input
   XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
   XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
   you want function  to  resize  array  according  to  result  size,  use
   function with same name and suffix 'I'.

SEE ALSO
* KDTreeQueryResultsX()             X-values
* KDTreeQueryResultsXY()            X- and Y-values
* KDTreeQueryResultsDistances()     distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreetsqueryresultstags(kdtree kdt, kdtreerequestbuffer buf, ref int[] tags)
{
    near
        stneig
    hor.kdtree
        squeryre

    ultsta
        s(kdt.i
            nerobj

    b
        .in
    robj, re
        tags,
        ll
}

public static void kdtreetsqueryresultstags(kdtree kdt, kdtreerequestbuffer buf, ref int[] tags,
    alglib.xparams _params)
{
    ea
    stneighbor.kdtree
        s
    ueryresultstags(kdt.inne
    r
    o
        b, buf.inne
        obj,  ref ta ams
}

/*************************************************************************
Distances from last query associated with kdtreerequestbuffer object.

This function retuns results stored in  the  internal  buffer  of  kd-tree
object. If you performed buffered requests (ones which  use  instances  of
kdtreerequestbuffer class), you  should  call  buffered  version  of  this
function - KDTreeTsqueryresultsdistances().

INPUT PARAMETERS
    KDT     -   KD-tree
    Buf     -   request  buffer  object  created   for   this   particular
                instance of kd-tree structure.
    R       -   possibly pre-allocated buffer. If X is too small to store
                result, it is resized. If size(X) is enough to store
                result, it is left unchanged.

OUTPUT PARAMETERS
    R       -   filled with distances (in corresponding norm)

NOTES
1. points are ordered by distance from the query point (first = closest)
2. if  XY is larger than required to store result, only leading part  will
   be overwritten; trailing part will be left unchanged. So  if  on  input
   XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
   XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
   you want function  to  resize  array  according  to  result  size,  use
   function with same name and suffix 'I'.

SEE ALSO
* KDTreeQueryResultsX()             X-values
* KDTreeQueryResultsXY()            X- and Y-values
* KDTreeQueryResultsTags()          tag values

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreetsqueryresultsdistances(kdtree kdt, kdtreerequestbuffer buf, ref double[] r)
{
    nearestneighbor
        kdtr
    etsq
        eryre

    ultsdistan
        es(k
            t.

    innerobj, buf.inn
        robj,
        rf r, null
        ;
}

public static void kdtreetsqueryresultsdistances(kdtree kdt, kdtreerequestbuffer buf, ref double[] r,
    alglib.xparams _params)
{
    nearestnei
    hbor.
        k
        d
    ree
        queryr

    ults
        stances(
            t.inner
                j,
            uf.innerobj, ref
            ,
            _params);
}

/*************************************************************************
X-values from last query; 'interactive' variant for languages like  Python
which   support    constructs   like  "X = KDTreeQueryResultsXI(KDT)"  and
interactive mode of interpreter.

This function allocates new array on each call,  so  it  is  significantly
slower than its 'non-interactive' counterpart, but it is  more  convenient
when you call it from command line.

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreequeryresultsxi(kdtree kdt, out double[,] x)
{
    =
    ew
        ou
    e[0, 0]
    n
        a
    r
        e
    s
        t
    n
        e
    i
        g
    h
        b
    o
    r
        .
        dtr
        equery
    es
        l
    t
        s
    x
    i
    (
        t.in
    ro
        , re
        x,
        ull)
}

public static void kdtreequeryresultsxi(kdtree kdt, out double[,] x, alglib.xparams _params)
{
    x =
        w double[
        0]

    near
        e
    neig treequer
    resu
        tsxi
    kdt.
        nne
        obj, r
    f x, _params)
}

/*************************************************************************
XY-values from last query; 'interactive' variant for languages like Python
which   support    constructs   like "XY = KDTreeQueryResultsXYI(KDT)" and
interactive mode of interpreter.

This function allocates new array on each call,  so  it  is  significantly
slower than its 'non-interactive' counterpart, but it is  more  convenient
when you call it from command line.

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreequeryresultsxyi(kdtree kdt, out double[,] xy)
{
    xy = ne double[0];
    ne
        ar t
        n
    eighbo k
    dt eq
    u
        eryresul
    t
        xyi
    t.nnerobj
        ,
        ref xy null);
}

public static void kdtreequeryresultsxyi(kdtree kdt, out double[,] xy, alglib.xparams _params)
{
    xy
    new doub
    e[0, 
        ;
    neares
    ighbor.
        eequeryres
        sxyi
    dt.innerobj, ref xy, _params);
}

/*************************************************************************
Tags  from  last  query;  'interactive' variant for languages like  Python
which  support  constructs  like "Tags = KDTreeQueryResultsTagsI(KDT)" and
interactive mode of interpreter.

This function allocates new array on each call,  so  it  is  significantly
slower than its 'non-interactive' counterpart, but it is  more  convenient
when you call it from command line.

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreequeryresultstagsi(kdtree kdt, out int[] tags)
{
    =
    int[0];

    ghbor.k reequeryresultstagsi kdt.i nerob,  ref tags  null);
}

public static void kdtreequeryresultstagsi(kdtree kdt, out int[] tags, alglib.xparams _params)
{
    ta
        s = n
    e
    int[0];

    near
        stn
    ighbor.kd
        reeq
    eryresultstagsi(
        .innero
        ref tags,
    rams
        ;
}

/*************************************************************************
Distances from last query; 'interactive' variant for languages like Python
which  support  constructs   like  "R = KDTreeQueryResultsDistancesI(KDT)"
and interactive mode of interpreter.

This function allocates new array on each call,  so  it  is  significantly
slower than its 'non-interactive' counterpart, but it is  more  convenient
when you call it from command line.

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreequeryresultsdistancesi(kdtree kdt, out double[] r)
{
    do
        [0]


    ne es r.kdtre eryres
    ultsdistancesi(kd nnero,
        r
    ef r, nu
    l
        );
}

public static void kdtreequeryresultsdistancesi(kdtree kdt, out double[] r, alglib.xparams _params)
{
    r
    new double[0
        ;

    n
        arestneig
    bor.
        treequeryresults
        stances
    kdt.innero
        , re
        r, _params);
}
}

public partial class alglib
{
    public class hqrnd
    {
        /*************************************************************************
        Portable high quality random number generator state.
        Initialized with HQRNDRandomize() or HQRNDSeed().

        Fields:
            S1, S2      -   seed values
            V           -   precomputed value
            MagicV      -   'magic' value used to determine whether State structure
                            was correctly initialized.
        *************************************************************************/
        public class hqrndstate : apobject
        {
            public int s1;
            public int s2;
            public int magicv;

            public hqrndstate()
            {
 
              
                              
                  i            );

            
             
             }

            public override void init()
            {
  
              
                  
            
      
              
               
    
                    
             
             
             
             
                               
             
             
             
                                         
             
             
             
              
   
              
             
                           }

            public override alglib.apobject make_copy()
                        
                  hqr
  
             

            
               
             
             
             
                           
               _r
             s               
             
             
                          lt  
                           s

             
                
            
 
                
                                         
            e
            u
            
                               
             

                     _

                   }
        };


        public const int hqrndmax = 2147483561;
        public const int hqrndm1 = 2147483563;
        public const int hqrndm2 = 2147483399;
        public const int hqrndmagic = 1634357784;


        /*************************************************************************
        HQRNDState  initialization  with  random  values  which come from standard
        RNG.

          -- ALGLIB --
             Copyright 02.12.2009 by Bochkanov Sergey
        *************************************************************************/
        public static void hqrndrandomize(hqrndstate state,
            alglib.xparams _params)
        {
            
          
         int s0 = 0;
          

          
         
        
        = ma
        h.
        r
        an        ne
        ge
                r(h
        qrn
        m1);
  
             
  
         
        hq
         
            hqrndsee         
        pa
             }


        /*************************************************************************
        HQRNDState initialization with seed values

          -- ALGLIB --
             Copyright 02.12.2009 by Bochkanov Sergey
        *************************************************************************/
        public static void hqrndseed(int s1,
            int s2,
            hqrndstate state,
            alglib.xparams _params)
        {
      
         

         
         
         
                      
         
         
         
         
         
         
         
         
         
                              
         
          
        

              
         
         
         
        
     
         
         
          
        
     
         
          
         
         
         
         
 
                

 
         
         
        n
        

              
         
        gainst 
        n
        e
        eds
         
               
         
                    
         
         
          
         
         
           
         
          e   
         
         
                       
         
        
     
         
         
        s
        t                                 
        ua
         to 
             
             
        
 
         
           
        ..        

             
        
  
             ces us t
         use  
        a
          bit  c
        mplicated
        

     
         
         
                   
         /
        /                          
          
            if
        
  
           {
        

        = -(
        s1
        +
        
        1
        );
    
             
     

         0
        )
         
           
         
              
         
            
      
          
        qrndm

                   
          
        hq                        
         }


 
               /***********************************************************************
        This function generates random real number in (0,1),
        not including interval boundaries

        State structure must be initialized with HQRNDRandomize() or HQRNDSeed().

          -- ALGLIB --
             Copyright 02.12.2009 by Bochkanov Sergey
        *************************************************************************/
        public static double hqrnduniformr(hqrndstate state,
            alglib.xparams _params)
        {
  

              
         
    
                  

         
                do
        ble
 
                   = 0
 
         
               
        e
     
           ul
     
            int
        ge
   
            b
        
        
        s

         
              
        qr
         
         
                   

         
         
              
          }


        /****        *
        **
        *
        is fun
        tion g
        enerates raom integer number in [0, N)

        1. State structure must be initialized with HQRNDRandomize() or HQRNDSeed()
        2. N can be any positive number except for very large numbers:
           * close to 2^31 on 32-bit systems
           * close to 2^62 on 64-bit systems
           An exception will be generated if N is too large.

          -- ALGLIB --
             Copyright 02.12.2009 by Bochkanov Sergey
        *************************************************************************/
    
           pub
        ic s
        atic int hqr
        n
        duniformi(
        qrnds
        ta           
         
                     
              
        a
        l
        l
        ib        rams)

         
               
        
   
  
                   
           
        

         
         
         
           nt max
    
         
                  
 
         
         
                  
     
          
        n
         
         
         
         
         
                 .        as
  
         
         
         
        ni    
         
          
          
         
         
         
         
         <=        "
                   
          
          
         xc
        nt = hqnd  
         
          
        
        nt
        

          
         
         
         
         
         
         
        /
        /
        

         
                    
         
                
             
         
    
         
               /
       
        a
        

         
         
         
         
          
        x
               .
        
         
         
                        
         
         
         
        /
         /         We
         
        have tw         
        ptions her
        e
             // a) N is exactly divisible by MaxCnt
                // b) N is not divisible by MaxCnt
                //
                // In both cases we reduce problem on interval spanning [0,N)
                // to several subproblems on intervals spanning [0,MaxCnt).
                //
   
              
            
        if( n%maxcnt
        =
        =0 )
     
             
                     
         
                     
         
                     
              
         
         
         
         
                  actly 
        d
        ivisibl
         by Max
        Cnt.
      
          
         
         
         
        ded
        
 
         
        N
        /
              them h
 
         
         
         
         
          
         
         
         
         
         
         
         
        /
        /
          
         
         
         
                   
         
           
              
         
         
         
         
         
         
           
         
         
         
         
        

         
          
         
         
         
         
        e
         g
        en        
          e

         
         
         
         
         
         
         :
        
 
         
         
         
         
          
         
        B
        // * random 
        o
        ffset
         
        ith
        n 
        b
        n A
          
         
               
         
                   
        n
        u
        m
        b
        e
        r
        s
         
        a
        e
        ge
        ne        

         
         
         
         
         
         
         
         
         
         
          
                  QR          
         
         
         
         
          
         
                            is equal to 
        A
        +MaxC
        n
        *B.
          
         
           
          
         
               
         
        //         
        a
        l
        g
        l
        i
        b
        .
        p
        as
        se        cn        formI: N isoo large");
                    a = hqrnduniformi(state, maxcnt, _params);
                    b = hqrnduniformi(state, n/maxcnt, _params);
                    result = a+maxcnt*b;
                }
                else
                {
                    
             
              
        /
 
                     
         
            // N i
         NOT 
        ex        ble
        b
        y    
              
           

                
 
         
                  
          
  
                     
              
         
                    )
        r
    
         
                     d
 
         
              v
               
         id        i        b
        in           

        
         

         
             l
        o 
        a
        C
        t
        .               
         
                       
         
         
         
                   
        

         
                    
                  e generate
 
         
             
         
        
  
         
         
          

         
         
               
         
                            do
  
         
         
         
         
         m
   
         
         
         
         
          
        

              
         
         
        b
        

          
         
            Ma
        x
         
         
         
          
         
              
         
         
         
         
         
         
                  om
        o
        fset
         
        wit
        h
        in b
        i
        n A
        

         
         
         
            
         
           
         
         
         
         
                  a

         
            
         
        t
 
         
            
         
         i

         
         
         
         
           s
        

           
         
         
         
         
                   
        i
          
         
            
         
         
  
         
         
         
           i
        s
           
         
          
         
          
         
        b
        in         
         
         
         
        2
        )          
         
         
         
         
                      th        eration of A/B.
                    //         essential in order to avoid bias in                    * otherwise, we return A*MaxCnt+N
                    //
            alglib.ap.assert(n/maxcnt+1<=maxcnt, "HQRNDUniformI: N is to                   lt
         
         
        -
        1;
   
          
         
                   
         a         e, maxcnt, _params);
                        for        , _params);
                        if( b==n/max        
                        {
                            
              
           

                    
         
                 m
        xcnt*
        b;           
              
          
                  esu
        t<0 );
          
                    }
  
         
               
         else
 
                   
        m
            urn "H

        n
         
         
        se
         
         
            

         
          
          
            
        =
        

         
                   
        c
        t
        -
        maxcnt%n
    
         
           ;

         
              

         
         
         
         
         
         
            
         
           
         
        

         
         
            
         
           
         
         
         
         
          
        d
        

            
 
         
         
         
         
         
         
          
   
         
         
         
         
          
         
              
         
         
         
         
         
         
        
     
         
         
         
         
                   
                                
                                   return result;
        }


          ***        *
        *
        ****
        *
        ****
        *
        *
        *
        *
        *
        ****
        *
        *************
        *
        

         
         
              Random
         
        number gener
        a
        t
        o
        r
        nd
         
        Q
        DSeed().

        -- ALGLIB --
             Copyright 02.12.2009 by Bochkanov Sergey
        *************************************************************************/
        public static double hqrndnormal(hqrndstate state,
            alglib.xparams _params)
        {
    
          
            d
        ub
        e res
        lt =
        0;
           
              
                         double 
        2 = 0;
        
     
              hq        
        f
         v        
             
        
               
        
      
                   res
 
         
              u
               
         l
        
        ***************************************************
        mber generator: vector with random entries (normal 
         
        nerates N r
                   Copyright 02.12.2009 by Bochkanov Sergey
        *************************************************************************/
        public static void hqrndnormalv(hqrndstate state,
            int n,
            ref double[] x,
            alglib.xparams 
        _
        p
        a
        rams)
        {

         
         
        

                 
         
           
        in
        t
              
         
         
         
           
         int
        n
         
         
         
               0;
   
                v1 =
         0;
                 
         
                     
         
                   doub
        l
        e         v2     
         
                          ;

        

         
       
         
           
           x         =         w do
        bl
        [0];


           

                   ablasf.ra        lo        v(n, re
        f 
        x
        , _p        ar        ams)
        ;
         

=n2          
                  
             
         
              
         
                  h
        1,
         
         v1;
 
                           x[2*i+1
        ]
         = v2
        ;
               
         
                  i
              
         
        qrndno
        r
        m
        al         v        params
        ;
    
                   [n-1] = v1;
            }
        }


        /*************************************************************************
     
          Rand
        m numb
        r generator: 
        m
        atrix with
        rando
        m         mal di
        s
        t
        i
        bu           
        h
        is        nerate
        s
         MxN ra
        dom mat
        rix.

     
        with HQRNDR
        a
         or         

    
         
          
         
          -- A
        

                    Copyright 02.12.
        2
        00        v S
              ****************
        *
        ***********
        m(hqrndstate s
        int m,
            int n,
            ref 
          
          
         
         
        in              
          
        n
         
        j=            int n2 =
         
        0;
  
         
           
          
         
        dou
        le
         
        1 = 0;

         
         
        v2 =         0        ;
        
          
          
         
        [0,0];
        
     
               n2 =/2;
            x = new double[m, n];
            for(i=0; i<=m-1; i++)
            {
                for(j=0; j<=n2-1; j++)
                {
                    hqrndnormal2(state, ref v1, ref v2, _params);
                    x[i,2*j+0] = v1;
                    x[i,2*j+1] = v2;
                }
                if( n%2!=0 )
                {
                    hqrndnormal2(state, ref v1, ref v2, _params);
                    x[i,n-1] = v1;
                }
            }
        }


        /*************************************************************************
        Random number ge
        erator
         rando
         X and Y such t
        h
        at X^2+Y^2
        1

  
                  ructur
        e
         
        u
        st        zed
        w
        it        mize()
         
        or HQRN
        Seed().
        

         
        pyright 02.12.
        009 by        v
        S
        e
        *****
        **
        *
        *
        *
        *****
        
 
         
         
         
        h
                ref do
        ub
        l
        e x,
         
         
         
         
        re        y,
            alglib.xparams _par         
           {
                                    d
  
              o
   
         
           
         
        u
        b
        l
         
        v
        = 0
        
 
         
     
         
            
          
         
      
        d
         
          
             o
    
        
                  =
    
         
         
         
         
              
              
         
        m
        );
            }
            while( !
        (
        (double)(x)!=(double)(0) || (double)(y)!=(double)(0
        )
        )               mx = Math.Max(Math.Abs(x), Ma
        Math.Abs(y)
        )
        ;
        h
        .
        S
        q
        r
            x = x/v;
          
          
        y
         = y/v;
       
         
        }


  
         
         
          
         
         /
        *************************************************************************
        Random number generator: normal numbers
        tion generates two independent random numbers from normal
        distribution. Its performance is equal to that of HQRNDNormal()

        St
        b
        HQRNDRandom
        ).

          -- ALGL
        Copyright 02.12.2009 by Bochkanov Sergey
        **
        ***********
        **********************/
        public static void hqrndnormal2(hqrndstate state,
            ref double x1,
  
         

         
         
              
         
         
                     
         
            v
        
         
        

                    
         
         
         
          
         
        
         
           x2
         
       
         
         
             
      
         
            
        

         
              
          
         
        r       rams)-1;
              v = 2*hqrnduniformr(state, _params)-1;
                s = math.sqr(u)+math.sqr(v);
                if( (double)(s)>(double)(0) && (double)(s)<(double)(1) )
                {
                    
                    //
                    // two Sqrt's instead of one to
                  
         // av
        id 
        verflow when S i
        s
         too small
             
                   //
  
         
               
               
         
         s)))/M
      
         
        h
        .
         
         
         
         
         
         
         
         
              
         

                 
                
         
           
              
         
                  ;
  
         
        
    
          
        
                         }
  
         
           
        *
        *
        *******************
  
              Rando
        m number gener
        a
        structure mus
        t
         b
        i
        z
        e
        d
         
        with HQRNDRandomize() 
         A
        L
          Copyright 1
        1.08.2007 b
        y
         
        o
        **        ****
        *
        **
        *
        ************
        p
        n
        ntial(hqrndst
        ate state,

         
                   double lambdav,
    
         
         _par
         
            {
       
         
        


         
         
         
              
      
         
         
         
        
         
  
         
               
   
             
        

                 
  
         
                   d
        o
 
                   
            b
        

                l
        e
         
        r
      
         
                       
         a
        l
        g
         
              l
        
        i
        
    
         
          
         
               (
        (
  
               u
        b
        l
        e
        )
        (
        lamb
         
        n
        ********************************************
      
        e
        r from discrete distribution given by
        finite sample X.

        INPUT PARAMETERS
         
         
        a
         must 
        e
                                
        i
        n
        i
        RND
        S
        
                       N 
         -   
        umber o        ements to use, N>=1

        RESULT
            this function returns one of the X[i] for random i=0..N-1

          -- ALGLIB --
             Copyright 08.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static double hqrnddiscrete(hqrndstate state,
            double[] x,
            int n,
            alg
        ib.xp
        rams _params)
         
              {
        

               
           
         
                  ,     
           ");

         
                  ib.ap.
        ssert 
         
         
         
                  rete: 
        ength(X)<N");
        

                  n
            
                   
        
               
                
        
   
            
        }
        

        *
         
        ra        u
        ti
        ib
        
 
        n
        i
        

        nm        r, mus
         be
    
              
         
                
           initia
        l
        iz        D
        ay        l
        rger,        se                             le        ed)         M        D
         
        >=1

         T
        h
        e
        t
        s
        ossi
        b
        l
           
            Cop
        yr        
        **
        *********************************************************************/
        public static double hqrndcontinuous(hqrndstate state,
            double[] x,
            int n,
            alglib.xparams _params)
        {
   
              
         dou
        le resul
         = 0;
      
             
        ouble mx = 0;
   
              
         
        duble mn = 0;
 
                  i             
         
        lgli
        .ap.ass
        rt(n>0
         "HQRN
        Continuou
        s
         N<=
        ");        ssert(n<=al
        lib.

              
        p.le
        (x), "HQR
       
         
        N
        D
 
            
                  nuous:
         
        L
     
          e
   
             n
    
               
         
         resul
         
        

               x[0]
         
        = hqrn
        uni
        or
          a
 
         
              t
        e
   
          
          
         
         
         
         
         
         
        ; 
                   i+1];
   
             
           al
        li
        .ap.asser
        ((double)(mx)>=(
        d
        o
        u
        b
        l
        e
        )
        (
        m
        n
        )
        ,
         
        "
        H
        Q
        R
        N
        D
        D
        i
        s
        c
        r
        e
        t
        e
        :
         
        X
         
        i
        s
      
          
   
           
        n
        o
 
         
            
         
         
        

                      s

         
               
        
      
         
          
              
                 
         
         
        e
 
        

         
                    i
        

         
         
         
         
         
          
        n
    
         
          
         
        g
 
         
         
         
         
         
         
        "
        
 
                              
         
         
         
        

         
                                  
        

              
         
         
        
                                 if
         (doub
        le)(mx
      !=(dou
        le)(mn
         )
          
         
         {
       
             
                  x-mn)*
        h
        q
        n
        du        e, 
        p
        ar              
         
          }
   
               
         else
     
              
          e         
         
        }
            return 
        r
        es         }


        /*************************************************************************
        This function returns random integer in [0,HQRNDMax]

        L'Ecuyer, Efficient and portable combined random number generators
        *************************************************************************/
        private static int hqrndintegerbase(hqrndstate state,
            alglib.xparams _params)


        res
            lt = 0;

        i
            t k = 0;


        e.magicv==h
            rndm

        gic, "HQRNDInt

        e
            g

        rB
            se: State
            i

        s i

        l
            d!");


        k
        =

        s
            a

        te.
        1/
        3668;


        sta
            e.s1 8)-k*12
        1
        ;
        if(
            s
            ate.
            1<0 )


        {
            tate.s1 + 2
            14


            k = sta
            e.
            2 / 5
            2
            7
            4;

            state(sta
            e.s2 - k * 5
            774)-k *
                791;


            i
                (state.s2
            0 )

            {
                stat
                        .s
                    = state.s2
                2
                47
                8339
                    ;
            }


            /
            Re //
                r
            su
                t = state
            s1 - state.s2;


            i
                f
                (
                    r
                        e

            s
                u
            l
                t
                    <
            1
                )


            {
                r
                    e
                s
                    u
                l
                    t
                        =
                        r
                e
                    s
                u
                    l
                t
                    +
                    2
                1
                47483562;
            }

            result = r
            e
            sult - 1;


            ult;
        }
    }

    public class xdebug
    {
        /*************************************************************************
        This is a debug class intended for testing ALGLIB interface generator.
        Never use it in any real life project.

          -- ALGLIB --
             Copyright 20.07.2021 by Bochkanov Sergey
        *************************************************************************/
        public class xdebugrecord1 : apobject
        {
            public int i;
            public complex c;
            public double[] a;

            public xdebugrecord1()
                   
             
                   
                   
                           
                            
 
                              i
             
             
             
                            
             
             
                              
             
             
               
            }

            public override void init()
            {
                          
                                                    
               d                     u                     
             ]                                
                                         }

            public override alglib.apobject make_copy()
            {
  
              
              
               
            
   
                
                
  
                                 
               
               
  
              
                 
            r

             
             
             
             
                          deb
 
              
                  
            g
   
                    
            
         
                            
              r
  
                                   (
                 
                 
             )
                     
              
                 
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
            

             
             
             
             
             
             
             
             
             
             
             
             
             
            

             
             
             
             
             
             
             
             
             
             
             
             
            _
            r
            e
            s
            u
            

             
             
                          l
    
                  
             =  
                      i
            ;
            
 
   
             
             
             
                  
             
            

                   
                  

                           
               
            e
                           
                               }
        };


        /*************************************************************************
        This is debug function intended for testing ALGLIB interface generator.
        Never use it in any real life project.

        Creates and returns XDebugRecord1 structure:
        * integer and complex fields of Rec1 are set to 1 and 1+i correspondingly
        * array field of Rec1 is set to [2,3]

          -- ALGLIB --
             Copyright 27.05.2014 by Bochkanov Sergey
        *************************************************************************/
        public static void xdebuginitrecord1(xdebugrecord1 rec1,
            alglib.xparams _params)
        {
    

         
           
            
 
         
         
         
                      
 
         
               
               
         
             ;
     
                                 
        
 
                     
    
             ]
        ;

         
             
         
          
         

                re  
         
             c1.a[0] =
        
         
         
         
           }


        /*************************************************************************
        This is debug function intended for testing ALGLIB interface generator.
        Never use it in any real life project.

        Counts number of True values in the boolean 1D array.

          -- ALGLIB --
             Copyright 11.10.2013 by Bochkanov Sergey
        *************************************************************************/
        public static int xdebugb1count(bool[] a,
            alglib.xparams _params)


        nt res

        u
            nt 0;


        res = 0;
        for(i= 0; i<=alglib.ap.len(a)-1; i++)
        {
            if (a[i])
            {
                result = result + 1;
            }
        }

    return result;
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by NOT(a[i]).
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugb1not(bool[] a,
    alglib.xparams _params)


int i = ;
    .ap.le n(-
    ;


a[i
]


}
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Appends copy of array to itself.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugb1appendcopy(ref bool[] a,
    alglib.xparams _params)
{
    int i =
        0;


    bool[] b = new
        bool[0];


    ol[alg
    l
    ib.ap.l
    n(a)];


    b.a p.le n(b
    -
        ;
    i
    b[i] = a i
}


a
    = ne w
en(b
    )
    ]
;


ialglib.ap.len(a) - 1;
i++)
{
    a[i] = b[i % alglib.ap.len(b)];
}
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate N-element array with even-numbered elements set to True.
Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugb1outeven(int n,
    ref bool[] a,
    alglib.xparams _params)


nt i =
        0
    ;
n
    = new
        bool[n
        ];
for (i = 0; i <= alglib.ap.len(a) - 1; i++)
{
    a[i] = i % 2 == 0;
}
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Returns sum of elements in the array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static int xdebugi1sum(int[] a,
    alglib.xparams _params)
{
    esult = 0;
    for (i = 0; i <= alglib.ap.len(a) - 1; i++)
    {
        result = result + a[i];
    }

    return result;
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by -A[I]
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugi1neg(int[] a,
    alglib.xparams _params)


i
    n
        =
        0
    ;
f
    .
    l
n(a + +)


a[i]
    =
    -
        a
            [i]
    ;


}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Appends copy of array to itself.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugi1appendcopy(ref int[] a,
    alglib.xparams _params)

nt i =
    0;

int[]
    b =
        n
ew
    = ib.ap.l
en(a)];


b.
    p
    l
b) -;

{
    [
    ]

    ;


    a
        =
        n
    e
        in
    t[2 * al
    g
        li
    b
        .ap
        .
        l
        e
    n
        (
            b
        ]
    ;

    r(p
        .l
    e
        (
        )
        -
        1
        ;
    i
        ++ {
        a[i] = b[i % alglib.ap.len(b)];
    }
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate N-element array with even-numbered A[I] set to I, and odd-numbered
ones set to 0.

Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugi1outeven(int n,
    ref int[] a,
    alglib.xparams _params)
{
    int i = ;

    a = new int[0];

    a = new int[n];
    for (i = 0; i <= alglib.ap.len(a) - 1; i++)
    {
        if (i % 2 == 0)
        {
            a[i] = i;
        }
        else
        {
            a[i] = 0;
        }
    }
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Returns sum of elements in the array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static double xdebugr1sum(double[] a,
    alglib.xparams _params)
{
    do
        ble resul
        t = 0;


    nt
        i
    0;


    resu
        l = 0;

    for
        i = 
            ;
    i <=
        lg
    ib.ap.len(a) - 1;
    i++)


    {
        res
            ut a[
        ];

        ret
            rn re
            sult;
    }


    /*************************************************************************
    This is debug function intended for testing ALGLIB interface generator.
    Never use it in any real life project.

    Replace all values in array by -A[I]
    Array is passed using "shared" convention.

      -- ALGLIB --
         Copyright 11.10.2013 by Bochkanov Sergey
    *************************************************************************/
    public static void xdebugr1neg(double[] a,
        alglib.xparams _params)
    {
        int
            i
                =
                0;


        i = 0;
        i <= algb.ap.len(a) - 1;
        i++)
        {
            a[i] = -a[i];
        }
    }


    /*************************************************************************
    This is debug function intended for testing ALGLIB interface generator.
    Never use it in any real life project.

    Appends copy of array to itself.
    Array is passed using "var" convention.

      -- ALGLIB --
         Copyright 11.10.2013 by Bochkanov Sergey
    *************************************************************************/
    public static void xdebugr1appendcopy(ref double[] a,
        alglib.xparams _params)


    n
        ti

    d
        ubl
    e
        [
        ]
        [
        ]
        ubl
    e
    [
        a
    l
        g
    i
    b.ap.len
        (
            a)
        ]
    ;


    f lg i
        +
        )
        = lib.a l
    i
    b
        .
        p
        l
    en[i] = b[i % alglib.ap.len(b)];
}
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate N-element array with even-numbered A[I] set to I*0.25,
and odd-numbered ones are set to 0.

Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugr1outeven(int n,
    ref double[] a,
    alglib.xparams _params)
{
    0 a =
        ew doub
    l
        a = new double[n];
    for (i = 0; i <= alglib.ap.len(a) - 1; i++)
    {
        if (i % 2 == 0)
        {
            a[i] = i * 0.25;
        }
        else
        {
            a[i] = 0;
        }
    }
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Returns sum of elements in the array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static complex xdebugc1sum(complex[] a,
    alglib.xparams _params)
{
    omplex r
        sult = 0


    int i
        = 0;


    r
        esult = 0;


    fo
            (i = 
        ;
    i <
        algl
    b.ap.le
        na)-1;
    i++)


    {
        result = resul
                 + a
        i];
    }


    e t;
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by -A[I]
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugc1neg(complex[] a,
    alglib.xparams _params)


i
nt
    i = 0;


f
    o
r
        (
    =
    0;
i le


{
    a
        [i
}
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Appends copy of array to itself.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugc1appendcopy(ref complex[] a,
    alglib.xparams _params)
{
    = 0
        = new
            complex
    0];


    b
        .a.


    for (i = ; l
        n
            b)
    -
        ;
    i++)


    b[i]
        =
        a
            [i]
        ;


    x[
        2
    a
        l
    g
        li
    b
        ap i
    b
        .a
        .e
    n
            (a) -
        1;
    a[i p.
}


}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate N-element array with even-numbered A[K] set to (x,y) = (K*0.25, K*0.125)
and odd-numbered ones are set to 0.

Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugc1outeven(int n,
    ref complex[] a,
    alglib.xparams _params)
{
    i
        n
    t
        i
            =
            0
        ;
        = new c
    om l
    e
        x

    glib.a
        .len(a
        )
    {
        if (i % 2 == 0)
        {
            a[i].x = i * 0.250;
            a[i].y = i * 0.125;
        }
        else
        {
            a[i] = 0;
        }
    }
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Counts number of True values in the boolean 2D array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static int xdebugb2count(bool[,] a,
    alglib.xparams _params)
{
    i
        n
    t
        r
    e
        s
    u
    l
        t
            =
            0
        ;
        in
    i
        = 0;


    int j
    0;


    r
        sult = 0;

    for (i = 0; i <=
                lgl
        b.
            p.
            ows
            a)
    -1
    i++


    {
        fo
            (j = 0;
        j <
            alglib
                .ap.cols(a) - 1;
        ++


        {
            a
                i, j] )
            {
                res
                    lt = result + 1;
            }
        }
    }


    r
        e
    t
        u
    r
    n
        result;
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by NOT(a[i]).
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugb2not(bool[,] a,
    alglib.xparams _params)
{
    i
        n
    t
        i
            =
            0
        ;


    i
        n
    t
        j
            =
            0
        ;


    f
        o
    r
    (
        i
            = 0;
    i <= alglib.p.ows(a
                      - 1;
    i++)


    for (j = 0
        j <= algli
    b.ap.cols(a) - 1;
    j++


    {
        a[i, j]
            !
        a[i, j];
    }
}


}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Transposes array.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugb2transpose(ref bool[,] a,
    alglib.xparams _params)
{
    i int j = 0;
    ew bool[0, 0];

    b ws(a)(a i
            =
            0
        ;
    i
        =
        al 1;
    {
        for (j = 0; j <= alglib.ap.cols(b) - 1; j++)
        {
            b[i, j] = a[i, j];
        }
    }
    a = new bool[alglib.ap.cols(b), alglib.ap.rows(b)];
    for (i = 0; i <= alglib.ap.rows(b) - 1; i++)
    {
        for (j = 0; j <= alglib.ap.cols(b) - 1; j++)
        {
            a[j, i] = b[i, j];
        }
    }
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate MxN matrix with elements set to "Sin(3*I+5*J)>0"
Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugb2outsin(int m,
    int n,
    ref bool[,] a,
    alglib.xparams _params)

0;

int j
    = 0;

a = new bool[0, 0];

a = new bool[m, n];
for (i = 0; i <= alglib.ap.rows(a) - 1; i++)
{
    for (j = 0; j <= alglib.ap.cols(a) - 1; j++)
    {
        a[i, j] = (double)(Math.Sin(3 * i + 5 * j)) > (double)(0);
    }
}
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Returns sum of elements in the array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static int xdebugi2sum(int[,] a,
    alglib.xparams _params)
{
    n
        i nt
    0;


    r = 0;
    i <= alglib.ap.rows(a) - 1;
    i++)
    {
        for (j = 0; j <= alglib.ap.cols(a) - 1; j++)
        {
            result = result + a[i, j];
        }
    }
    return result;
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by -a[i,j]
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugi2neg(int[,] a,
    alglib.xparams _params)
{
    i
        n
    t
        i
            = 0
        ;


    a
        l
    g
        l
    i
        b
    a
        .
        r
        o
    w
    s
        (
            a) = 
        ;
    j <=
        lgli
    b
        .ap.co
        l
    s(
        a
    ) - 1;

    j
        +
        +


    {
        a
            i,
            j
                ] = -a
        [
            i,
            j
        ];
    }
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Transposes array.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugi2transpose(ref int[,] a,
    alglib.xparams _params)
{
    i
        n
    t
        i
            =
            0
        ;


    i
        n
    t
        j
            =
            0
        ;


    i
        n
    t
        [
            ,
        ]
        b
            =
            new int[0, 0];


    b
        = new int[algl
    i
    b.a
        .ro b.a
        .
        co
        f
    o
    r
        i
            = 0 ap.row
    s
        (b) - 1;
    ++)


    j <
        al l
    b
        .p j
           +
           b
           [
               i
               ,
           ]
        = 
}


}
t[ ),
a
    l
g
    l
i
    .ap
    .rows(
        b
    )]
;


f
    or ap


{
    f
        o
    r
        (
            j
                =
                0
        ;

    j
        <
        = algli
    b
        .a
    p
        .c {
        a[j, i] = b[i, j];
    }
}
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate MxN matrix with elements set to "Sign(Sin(3*I+5*J))"
Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugi2outsin(int m,
    int n,
    ref int[,] a,
    alglib.xparams _params)

nt i =
    0
        in in
a =
    new int[m,;
for (i = 0; i <= alglib.ap.rows(a) - 1; i++)
{
    for (j = 0; j <= alglib.ap.cols(a) - 1; j++)
    {
        a[i, j] = Math.Sign(Math.Sin(3 * i + 5 * j));
    }
}
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Returns sum of elements in the array.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static double xdebugr2sum(double[,] a,
    alglib.xparams _params)
{
    d ou b
        i
            = 0;


    r es u
        l
        ; .rows(a) - 1;
    ++)
    {
        for (j = 0; j <= alglib.ap.cols(a) - 1; j++)
        {
            result = result + a[i, j];
        }
    }
    return result;
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Replace all values in array by -a[i,j]
Array is passed using "shared" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugr2neg(double[,] a,
    alglib.xparams _params)
{
    0;


    i
    nt j =
        0;


    r(
            i
        ;
    i +)


    {
        p
        {
            ;
        }


        /*************************************************************************
        This is debug function intended for testing ALGLIB interface generator.
        Never use it in any real life project.

        Transposes array.
        Array is passed using "var" convention.

          -- ALGLIB --
             Copyright 11.10.2013 by Bochkanov Sergey
        *************************************************************************/
        public static void xdebugr2transpose(ref double[,] a,
            alglib.xparams _params)
        {
            i
            t i
                    = 
                ;
            int j = 0;


            ouble[
            ] b =
                new d
            uble[0, 0];

            b
                = new
                    oub rows(a),
            lglib
                .ap.c
                ls
            a)];

            for (i = 0;
                 i
                 <
                 =
                 a
                l
                    g
            l
                i
            b
                .a
            p
                .
                r
                o
            w
            s
                (
                    b
                )
                -
                1
                ;

            i
                +
                +
                )


            {
                f
                    o
                r
                    (
                        j
                            =
                            0
                    ;

                j
                    <
                    =
                    a
                lglib.ap.cols(b)
                1;
                j++


                {
                    b[i
                    j
                        ]
                }


                a = ne
                w gl
                b
                    ap c
                    b)]


                ;
                i
                    = al
                lib
                    .a
                p
                    .r
                o


                {
                    (j =
                            0
                        ;

                    j
                        <
                        a
                    lg
                    lib.ap
                        .
                        co
                        l
                    s(b)
                        -
                        1
                        ;

                    j
                        +
                        )


                    {
                        a
                        [
                            j
                        i
                            ]
                            = b[i,
                            j
                        ];
                    }


                    /*************************************************************************
                    This is debug function intended for testing ALGLIB interface generator.
                    Never use it in any real life project.
            
                    Generate MxN matrix with elements set to "Sin(3*I+5*J)"
                    Array is passed using "out" convention.
            
                      -- ALGLIB --
                         Copyright 11.10.2013 by Bochkanov Sergey
                    *************************************************************************/
                    public static void xdebugr2outsin(int m,
                        int n,
                        ref double[,] a,
                        alglib.xparams _params)
                    {
                        i n0


                        o
                            ub
                        le[0, 0
                            ]
                            ;


                        a
                            =  , for
                        (
                            i
                                =
                                0;
                            i
                            <=
                            alglib
                                .ap
                                .rows
                                (
                                    a
                                )
                            -
                            1;
                            i
                                ++
                        )
                            j <= al
                        l
                        b.ap.c
                            o
                        l
                        s
                            (
                                a
                            )
                            -
                            1;
                        a[i, j]
                            = Math
                                .Sin(3 * i + 5 *;
                    }
                }
            }


            /*************************************************************************
            This is debug function intended for testing ALGLIB interface generator.
            Never use it in any real life project.
    
            Returns sum of elements in the array.
    
              -- ALGLIB --
                 Copyright 11.10.2013 by Bochkanov Sergey
            *************************************************************************/
            public static complex xdebugc2sum(complex[,] a,
                alglib.xparams _params)
            {
                le

                t
                    j = r ul = 0


                r
                    +)

                a) +
                {
                    result = result + a[i, j];
                }
            }

            return result;
        }


        /*************************************************************************
        This is debug function intended for testing ALGLIB interface generator.
        Never use it in any real life project.

        Replace all values in array by -a[i,j]
        Array is passed using "shared" convention.

          -- ALGLIB --
             Copyright 11.10.2013 by Bochkanov Sergey
        *************************************************************************/
        public static void xdebugc2neg(complex[,] a,
            alglib.xparams _params)
        {
            i
            nt i = 0
                ;


            j
                =
                0
                ;

            f or(i =
            0;
            i < = a lg li b.ap.r ow s(a) - 1;
            i
            (
                a[
                        i
                        ,
                        j] =
                    a
                        [i
        }
    }
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Transposes array.
Array is passed using "var" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugc2transpose(ref complex[,] a,
    alglib.xparams _params)
{
    in
    i
    0;


    i
    n j = 0;

    c
    mplex[
    ] b
    new com
    lex
    0,
        ];

    b = new comp
    ex
        alglib
    ap.ro
    s(a),

    alglib.ap.
        cl
        or(b.ap.rows
            b)

    -1;
    i++)


    f
        o
    r
        (
            j
                =
                0
        ;

    j
        <
        =
        a
    l
        g
    l
        i
    b
        .a
    p
        .
        c
        o
    l
    s
        (
            b
        )
        -
        1
        ;

    j
        +
        +
        )


    {
        b[i, j] = a[
            , j];
    }


    = alg
    ib.ap.
        c
        o
    l
    (
        b) rows(b
        )
        ];


    for (i = 0; i <= ws(
         )
        1

    i


    f
        j = 0;
    j <
        =
        a
    l
        gl ib.


    {
        j,i] = b[i, j];
    }
}
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Generate MxN matrix with elements set to "Sin(3*I+5*J),Cos(3*I+5*J)"
Array is passed using "out" convention.

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static void xdebugc2outsincos(int m,
    int n,
    ref complex[,] a,
    alglib.xparams _params)
{
    i
    n
        t
            = int

    j = 0;


    a = ne
        ];
    =
    m
        ]
    ;
    or(i = 0
           < g.+
        j <= alg
    l
    ib
        .
        ap.c
        o
    l
    s
    (
        a
    )
    1
        ;
    j + a[i
    j
        .x = M
    a
        t
    h
        .
        S
        i
    n
        (3[i.Cos(3
    i + 5 * j)
    ;
}
}
}


/*************************************************************************
This is debug function intended for testing ALGLIB interface generator.
Never use it in any real life project.

Returns sum of a[i,j]*(1+b[i,j]) such that c[i,j] is True

  -- ALGLIB --
     Copyright 11.10.2013 by Bochkanov Sergey
*************************************************************************/
public static double xdebugmaskedbiasedproductsum(int m,
    int n,
    double[,] a,
    double[,] b,
    bool[,] c,
    alglib.xparams _params)

r


ib.aa b.alglib.ap.assert(m >= alglib.ap.rows(b));
alglib.ap.assert(m >= alglib.ap.rows(c));
alglib.ap.assert(n >= alglib.ap.cols(a));
alglib.ap.assert(n >= alglib.ap.cols(b));
alglib.ap.assert(n >= alglib.ap.cols(c));
result = 0.0;
for (i = 0; i <= m - 1; i++)
{
    for (j = 0; j <= n - 1; j++)
    {
        if (c[i, j])
        {
            resu
                t = re
            ult +
            [i, j]
            *(1 + b[i, j]);
        }
    }

    ;
}
}

public class nearestneighbor
{
    /*************************************************************************
    Buffer object which is used to perform nearest neighbor  requests  in  the
    multithreaded mode (multiple threads working with same KD-tree object).

    This object should be created with KDTreeCreateRequestBuffer().
    *************************************************************************/
    public class kdtreerequestbuffer : apobject
    {
        public double[] x;
        public double[] boxmin;
        public double[] boxmax;
        public int kneeded;
        public double rneeded;
        public bool selfmatch;
        public double approxf;
        public int kcur;
        public int[] idx;
        public double[] r;
        public double[] buf;
        public double[] curboxmin;
        public double[] curboxmax;
        public double curdist;

        public kdtreerequestbuffer()
        {
        
     
         
                 
         
          
         
            
            ni
        ()
   
          
            
        
   
            
          
         
            
              }

        public override void init()
        {

   
          
           
           
  
                            x 
         n    
          
            e
   
         
           
         [

           
             0
  
                             
         
          

     
         
              

             
          
           
    
              
         

           
                      
                  
          
          
         
            
          
      
                    
             

                            
        
    
             
          
        
        
            
           
         
         
        

         
         
         
         
         
         
         
         
         
         
         
         
         
        

         
         
         
         
         
         
         
         
         
         
         
         
         
        

         
         
         
         
         
         
         
         
         
         
         
         
        b
        

         
         
         
         
         
         
         
         
         
         
         
         
        o
        

         
         
         
         
         
         
         
         
         
         
         
         
        x
        
            m
 
              
           i
                    n
           
         
         
    
           
                       
            n
           
                        
         
          w
   
               
          
        
                  l
        
          
         e
   
         
          
         0
          
         
         
                   

            
             
   
         
         

             
             
 
          
         
         
         
         
          
                
  
           
         
          
          
         
          
              
         
          
            
          
                     
         
          
        x

          
         
         
         
         
             
            =
             
            n
            e
            w             ];
   
                  
                
            idx = new int[0];
            

               
             
                       r = ne
             
            double[0];
      
                   
             
             
            b
            f
             = new double[0];
  
             
                   
                 cu
            rb            n
                                         
             
             
             curboxmax = new 
            b
            e
            0
            ];
            }

        public override alglib.apobject make_copy()


        kdt
            r

        e
            e

        r
            e

        q
            e

        st
            b
                =
                )
            ;


        _r es ul t.x = do ul e
        []
            )x i
        n
        = (d u
        b
            e

        ]) bo xm in.C lo ne();


        x

        =

        (
        d
        o
        u
            l
                [])b
            o

        xma
            x
            .C o
            n

        e
        (
        );

        esult.kneeded =

        /*************************************************************************
       This is debug function intended for testing ALGLIB interface generator.
       Never use it in any real life project.

       Returns sum of a[i,j]*(1+b[i,j]) such that c[i,j] is True

         -- ALGLIB --
            Copyright 11.10.2013 by Bochkanov Sergey
       *************************************************************************/
        a );


        _
            esult.curdist = curdist;


        return _re
            u

        lt;
    }
};


/*************************************************************************
KD-tree object.
*************************************************************************/
public class kdtree : apobject
{
    public int n;
    public int nx;
    public int ny;
    public int normtype;
    public double[,] xy;
    public int[] tags;
    public double[] boxmin;
    public double[] boxmax;
    public int[] nodes;
    public double[] splits;
    public kdtreerequestbuffer innerbuf;
    public int debugcounter;

    public kdtree()
    {
         
      
       
    
    
     
           
  
                             

      
          
      
      
         }

    public override void init()
        = new
        ouble

    0, 0];

    /*************************************************************************
Buffer object which is used to perform nearest neighbor  requests  in  the
multithreaded mode (multiple threads working with same KD-tree objec

public override alglib.apobject make_copy()
{





k
d
t
r
e
e

_
r
e
s
u
l
t

=

n
e
w

k
d
t
r
e
e
(
)
;


















_
r
e
s
u
l
t
.
n

=

n
;











sult.n
= nx

_r
s
lt.ny = n                       _result.n
rmtype

=
n
ormtype;

_r
e
s
lt.xy 
= (double[,])xy.Clon
();




_result.tags = 
int
])tags.
Clone();

_r
sult.bo
xmin = (double[])box
in.C
one();

_resul
.boxma
= (dou
ble[])boxmax.Clone()



_result.nod
s =

(
nt[
])nodes.Clone();





_result.splits = (
ouble[
]
)
pli
ts.Clone();



_
esult.inn
erbuf = (kdtreereque
tbuffe
r
)
nnerbuf.m
ake_copy();


_result
.debugcounter = debu
counter;


return _result;
}
};


public const int splitnodesize = 6;
public const int kdtreefirstversion = 0;


/*************************************************************************
KD-tree creation

This subroutine creates KD-tree from set of X-values and optional Y-values

INPUT PARAMETERS
XY      -   dataset, array[0..N-1,0..NX+NY-1].
one row corresponds to one point.
first NX columns contain X-values, next NY (NY may be zero)
columns may contain associated Y-values
N       -   number of points, N>=0.
NX      -   space dimension, NX>=1.
NY      -   number of optional Y-values, NY>=0.
NormType-   norm type:
* 0 denotes infinity-norm
* 1 denotes 1-norm
* 2 denotes 2-norm (Euclidean norm)

OUTPUT PARAMETERS
KDT     -   KD-tree


NOTES

1. KD-tree  creation  have O(N*logN) complexity and O(N*(2*NX+NY))  memory
requirements.
2. Although KD-trees may be used with any combination of N  and  NX,  they
are more efficient than brute-force search only when N >> 4^NX. So they
are most useful in low-dimensional tasks (NX=2, NX=3). NX=1  is another
inefficient case, because  simple  binary  search  (without  additional
structures) is much more efficient in such tasks than KD-trees.

-- ALGLIB --
Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
    public static void kdtreebuild(double[,] xy,
        int n,
        int nx,
        int ny,
        int normtype,
        kdtree kdt,
        alglib.xparams _params)


    i
        t[] t
        ag 0];


    int i
        = al

    lib.ap.assert(n>=0,
    "KDTreeB
    ui
        alglib.ap.as
    se DTreeB
    ild: N
        X
        <1

    DT<0");


    al
        lib.
        a

    p
        ty

    e
    = 2,
    DTreeB i

    l
        d

    :
    i e");


    al lglib.
        p

    row
        (xy)>=

    n
    ,
    "K        (X)<N"
    ;


    a
        lg glib.
        p
        col
        (xy
        )
        >
        =

    nx TreeBu
    l
    : c
        ls(X)<

    N
        X

    +

    NY alglib.a
        .
        sse

    t(apserv.apservisfi
        n

    i
        te, ms), "

    DTreeBui
        d: XY
        c

    ontains
        nfinite o
        r

    N
        t
            = n e
        nt[n];

    {
    }


    tre bu ld
        t

    ag
        e
        (x
            y, , normt
            y

    pe kdt,
        ra s);
}


/*************************************************************************
KD-tree creation

This  subroutine  creates  KD-tree  from set of X-values, integer tags and
optional Y-values

INPUT PARAMETERS
    XY      -   dataset, array[0..N-1,0..NX+NY-1].
                one row corresponds to one point.
                first NX columns contain X-values, next NY (NY may be zero)
                columns may contain associated Y-values
    Tags    -   tags, array[0..N-1], contains integer tags associated
                with points.
    N       -   number of points, N>=0
    NX      -   space dimension, NX>=1.
    NY      -   number of optional Y-values, NY>=0.
    NormType-   norm type:
                * 0 denotes infinity-norm
                * 1 denotes 1-norm
                * 2 denotes 2-norm (Euclidean norm)

OUTPUT PARAMETERS
    KDT     -   KD-tree

NOTES

1. KD-tree  creation  have O(N*logN) complexity and O(N*(2*NX+NY))  memory
   requirements.
2. Although KD-trees may be used with any combination of N  and  NX,  they
   are more efficient than brute-force search only when N >> 4^NX. So they
   are most useful in low-dimensional tasks (NX=2, NX=3). NX=1  is another
   inefficient case, because  simple  binary  search  (without  additional
   structures) is much more efficient in such tasks than KD-trees.

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreebuildtagged(double[,] xy,
    int[] tags,
    int n,
    int nx,
    int ny,
    int normtype,
    kdtree kdt,
    alglib.xparams _params)
{
    t
        = 0;
    nt j = 0;


    int
        odesof
            = 0;


    int sp
        tsoffs = 0;
    int i_ = 
        ;


    int i1_
    0


    a
        gl
    i
    b.ap.
        as "K
    TreeBu
        ldT

    al
    glib.p.ssert(nx >
                 1, "KDTreeBuildT
    a
        g
    g
        e
    d
        :

    N
        X
            <
    1
    "
        )
    ;


    a
        l
    g
        l
    i
    b
        .a
    p
        .
        a
        s
    s
        e

    r
        t
        (
            n
                y
                >
                =

    0
        ,

    "
    K
        D
    T
        r
    e
        e
    B
        u
    i
        l
    d
        T
    a
        g
    g
        e
    d
        :

    N
    Y < 0");

    algl

    b.ap
        assert(norm
            t

    ype >= 0
        &
        &
            no
    rm Tre
    B
        ui cor
        ec
    t

    p.a
        sert(alg
            li)>=

    n,
    KDT
    re :
    rows
    (
        X) < N");


    li.
        a
        p

    co ls(
        y
            >=

    n
        + ny
        |
        |

    dTa
    gd :
    c
        os


    algl
        i
    b
        .a

    p
        .a sert(apse rv.

    a
        p
    e
        r
    v
    isf
        n, nx
    +
        ny
        ,
    _p aram
    s
        ),
    "
    K
        D
    reeBuildT gge
    d
        X Y c
    o
    nta

        // 
        in it il /
              kdt.n = n

    kdt.n
        x =
            .ny =
        n
    y;


    k
        dt no mtyp
        =
        n
    orm ty p
    kdt.innerbuf.c

        //

        // N        0
        => q ui ck e
    x
        it


    //

    f(
            n
                = 
        = 0 )


    et rn;
}
/
/
/

ll cate


//        

kdtr
    ea ll cda
asetin
    dep

kt re
e
    a
l
    l
a
f

    //
    / Init ia l
f
    ll


for (i = 0; i <= n - 1; i++)
{
    for (i_ = 0; i_ <= nx - 1; i_++)
    {
        kdt.xy[i, i_] = xy[i, i_];
    }

    i1_ = (0) - (nx);
    for (i_ = nx; i_ <= 2 * nx + ny - 1; i_++)
    {
        kdt.xy[i, i_] = xy[i, i_ + i1_];
    }

    kdt.tags[i] = tags[i];
}

//
// Determine bounding box
//
for (i_ = 0; i_ <= nx - 1; i_++)
{
    kdt.boxmin[i_] = kdt.xy[0, i_];
}

for (i_ = 0; i_ <= nx - 1; i_++)
{
    kdt.boxmax[i_] = kdt.xy[0, i_];
}

for (i = 1; i <= n - 1; i++)
{
    for (j = 0; j <= nx - 1; j++)
    {
        kdt.boxmin[j] = Math.Min(kdt.boxmin[j], kdt.xy[i, j]);
        kdt.boxmax[j] = Math.Max(kdt.boxmax[j], kdt.xy[i, j]);
    }
}

//
// Generate tree
//
nodesoffs = 0;
splitsoffs = 0;
for (i_ = 0; i_ <= nx - 1; i_++)
{
    kdt.innerbuf.curboxmin[i_] = kdt.boxmin[i_];
}

for (i_ = 0; i_ <= nx - 1; i_++)
{
    kdt.innerbuf.curboxmax[i_] = kdt.boxmax[i_];
}

kdtreegeneratetreerec(kdt, ref nodesoffs, ref splitsoffs, 0, n, 8, _params);
apserv.ivectorresize(ref kdt.nodes, nodesoffs, _params);
apserv.rvectorresize(ref kdt.splits, splitsoffs, _params);
}


/*************************************************************************
This function creates buffer  structure  which  can  be  used  to  perform
parallel KD-tree requests.

KD-tree subpackage provides two sets of request functions - ones which use
internal buffer of KD-tree object  (these  functions  are  single-threaded
because they use same buffer, which can not shared between  threads),  and
ones which use external buffer.

This function is used to initialize external buffer.

INPUT PARAMETERS
    KDT         -   KD-tree which is associated with newly created buffer

OUTPUT PARAMETERS
    Buf         -   external buffer.
    
    
IMPORTANT: KD-tree buffer should be used only with  KD-tree  object  which
           was used to initialize buffer. Any attempt to use buffer   with
           different object is dangerous - you  may  get  integrity  check
           failure (exception) because sizes of internal arrays do not fit
           to dimensions of KD-tree structure.

  -- ALGLIB --
     Copyright 18.03.2016 by Bochkanov Sergey
*************************************************************************/
public static void kdtreecreaterequestbuffer(kdtree kdt,
    kdtreerequestbuffer buf,
    alglib.xparams _params)
{
    b
        ];

    .boxmin =
        ew do
        bl e[kd

    bu
        d
    o
    e[kd t
        .x

    dt.n];


    le[
        .Max(kd


    uf.cu boxmin = ew doub le[
        buf.cu rb ox m. = 
}


/*************************************************************************
K-NN query: K nearest neighbors

IMPORTANT: this function can not be used in multithreaded code because  it
           uses internal temporary buffer of kd-tree object, which can not
           be shared between multiple threads.  If  you  want  to  perform
           parallel requests, use function  which  uses  external  request
           buffer: KDTreeTsQueryKNN() ("Ts" stands for "thread-safe").

INPUT PARAMETERS
    KDT         -   KD-tree
    X           -   point, array[0..NX-1].
    K           -   number of neighbors to return, K>=1
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True

RESULT
    number of actual neighbors found (either K or N, if K>N).

This  subroutine  performs  query  and  stores  its result in the internal
structures of the KD-tree. You can use  following  subroutines  to  obtain
these results:
* KDTreeQueryResultsX() to get X-values
* KDTreeQueryResultsXY() to get X- and Y-values
* KDTreeQueryResultsTags() to get tag values
* KDTreeQueryResultsDistances() to get distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static int kdtreequeryknn(kdtree kdt,
    double[] x,
    int k,
    bool selfmatch,
    alglib.xparams _params)
{
    in
    re
        ult
    0


    alg
    i
        .ap.ssert
    k >= 1, "KDTreeQueryKN
        : K < 1!
        );


    al
        i
    b.ap.sert(algl
        .ap
    en(x) >
        =
        kdt.nx, "KDTreeQueryKNN:
    Leng
    h(X
      < NX!
    );


    al
        lib

    ap.ass
        rt(apse
            .isfini
            t

    e
    ctor(x, kdt.nx,
        param
    ),
    KDTreeQu
    ryKNN:
    contains inf
    nite or
    aN
        valu
    s!
        );

    resu
        t = kd
    teetsqueryaknn(
        dt, kdt.inn se
    0
    _
        p
    aram
        );


    retu
        n re
        ult;
}


/*************************************************************************
K-NN query: K nearest neighbors, using external thread-local buffer.

You can call this function from multiple threads for same kd-tree instance,
assuming that different instances of buffer object are passed to different
threads.

INPUT PARAMETERS
    KDT         -   kd-tree
    Buf         -   request buffer  object  created  for  this  particular
                    instance of kd-tree structure with kdtreecreaterequestbuffer()
                    function.
    X           -   point, array[0..NX-1].
    K           -   number of neighbors to return, K>=1
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True

RESULT
    number of actual neighbors found (either K or N, if K>N).

This  subroutine  performs  query  and  stores  its result in the internal
structures  of  the  buffer object. You can use following  subroutines  to
obtain these results (pay attention to "buf" in their names):
* KDTreeTsQueryResultsX() to get X-values
* KDTreeTsQueryResultsXY() to get X- and Y-values
* KDTreeTsQueryResultsTags() to get tag values
* KDTreeTsQueryResultsDistances() to get distances
    
IMPORTANT: kd-tree buffer should be used only with  KD-tree  object  which
           was used to initialize buffer. Any attempt to use biffer   with
           different object is dangerous - you  may  get  integrity  check
           failure (exception) because sizes of internal arrays do not fit
           to dimensions of KD-tree structure.

  -- ALGLIB --
     Copyright 18.03.2016 by Bochkanov Sergey
*************************************************************************/
public static int kdtreetsqueryknn(kdtree kdt,
    kdtreerequestbuffer buf,
    double[] x,
    int k,
    bool selfmatch,
    alglib.xparams _params)

int result =
    0;


al
lib.ap.assert(k >= 1,
    "
DT
    eeT
Q
    u
eryKNN:
K < 1!");

alglib.ap
    .
    a
    se
t(a
g
    l
b.a
    .l
en(x) >= kdt.nx, "
DTreeTsQueryKNN:
Lengt
    h
(
    )<
X!"
    ;

alglib
ap.assert(apserv.isfiniteve
c
    t
r(
    , k
t.nx, _paa ee
sQuery
NN:
nfinite o
NaN
    value
!"
    ;

result = kdt
r
    e
e
    t
s
    q
u
    e
r
    y
a
    k

n
    n
    (
        k
            d

t
    ,

b
u
    f,
    x,
    k,
    s
e
    l
f
    m
a
    t
c
    h, 

0
    .
0
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


r
    e
t
urn result;

}


/*************************************************************************
R-NN query: all points within R-sphere centered at X, ordered by  distance
between point and X (by ascending).

NOTE: it is also possible to perform undordered queries performed by means
      of kdtreequeryrnnu() and kdtreetsqueryrnnu() functions. Such queries
      are faster because we do not have to use heap structure for sorting.

IMPORTANT: this function can not be used in multithreaded code because  it
           uses internal temporary buffer of kd-tree object, which can not
           be shared between multiple threads.  If  you  want  to  perform
           parallel requests, use function  which  uses  external  request
           buffer: kdtreetsqueryrnn() ("Ts" stands for "thread-safe").

INPUT PARAMETERS
    KDT         -   KD-tree
    X           -   point, array[0..NX-1].
    R           -   radius of sphere (in corresponding norm), R>0
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True

RESULT
    number of neighbors found, >=0

This  subroutine  performs  query  and  stores  its result in the internal
structures of the KD-tree. You can use  following  subroutines  to  obtain
actual results:
* KDTreeQueryResultsX() to get X-values
* KDTreeQueryResultsXY() to get X- and Y-values
* KDTreeQueryResultsTags() to get tag values
* KDTreeQueryResultsDistances() to get distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static int kdtreequeryrnn(kdtree kdt,
    double[] x,
    double r,
    bool selfmatch,
    alglib.xparams _params)
{
    int
        result = 0;

    algl
        i
    b
        ap
    ass
    rt((doubl
    TreeQuery
        R
    N:

    inco
        rect R
    ");


    alg
    ib.a
        as
        s
    ert(
        glib.a
    len(x) ery
    NN:
    en
    th(X) < NX!"
        ;


    algli
        .a
        .as
    ert(ap
    v.isf nx, _para
    s), "K
    Tr
        eQueryRNN

    co
        ain
    inf
        ite or Na
    values sult =
        d
    treetsque
        r
    rnn(kdt
    kdt.
        nn
        rbuf,
        x,
        r,
        sel
    ma
        ch,
        _par et
    rn result;
}


/*************************************************************************
R-NN query: all points within R-sphere  centered  at  X,  no  ordering  by
distance as undicated by "U" suffix (faster that ordered query, for  large
queries - significantly faster).

IMPORTANT: this function can not be used in multithreaded code because  it
           uses internal temporary buffer of kd-tree object, which can not
           be shared between multiple threads.  If  you  want  to  perform
           parallel requests, use function  which  uses  external  request
           buffer: kdtreetsqueryrnn() ("Ts" stands for "thread-safe").

INPUT PARAMETERS
    KDT         -   KD-tree
    X           -   point, array[0..NX-1].
    R           -   radius of sphere (in corresponding norm), R>0
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True

RESULT
    number of neighbors found, >=0

This  subroutine  performs  query  and  stores  its result in the internal
structures of the KD-tree. You can use  following  subroutines  to  obtain
actual results:
* KDTreeQueryResultsX() to get X-values
* KDTreeQueryResultsXY() to get X- and Y-values
* KDTreeQueryResultsTags() to get tag values
* KDTreeQueryResultsDistances() to get distances

As indicated by "U" suffix, this function returns unordered results.

  -- ALGLIB --
     Copyright 01.11.2018 by Bochkanov Sergey
*************************************************************************/
public static int kdtreequeryrnnu(kdtree kdt,
        double[] x,
        double r,
        bool selfmatch,
        alglib.xparams _params)
    in

r
    sult = 0


e
(r
 > (dou
b
    e)(0
    , "K
TreeQu
    ryRN
U:
i
    ncor
ect R!");        alg
ib.ap.len U
L
ngt
    (X) < N
X
");

alglib.ap.assert niteve
to
(x, kdt.n
    , _pa
r
    ms
    ) "KDTreeQuery
NU:
X cont
ns infin
e or
N v
ues!")


r
    sul
        = kdtreetsqueryrnnu(kdt, k
t.nne
bu
    f,
    x,
 
    ,
    s
lfm
    tch
_params);

tu
    result;
}


/*************************************************************************
R-NN query: all points within  R-sphere  centered  at  X,  using  external
thread-local buffer, sorted by distance between point and X (by ascending)

You can call this function from multiple threads for same kd-tree instance,
assuming that different instances of buffer object are passed to different
threads.

NOTE: it is also possible to perform undordered queries performed by means
      of kdtreequeryrnnu() and kdtreetsqueryrnnu() functions. Such queries
      are faster because we do not have to use heap structure for sorting.

INPUT PARAMETERS
    KDT         -   KD-tree
    Buf         -   request buffer  object  created  for  this  particular
                    instance of kd-tree structure with kdtreecreaterequestbuffer()
                    function.
    X           -   point, array[0..NX-1].
    R           -   radius of sphere (in corresponding norm), R>0
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True

RESULT
    number of neighbors found, >=0

This  subroutine  performs  query  and  stores  its result in the internal
structures  of  the  buffer object. You can use following  subroutines  to
obtain these results (pay attention to "buf" in their names):
* KDTreeTsQueryResultsX() to get X-values
* KDTreeTsQueryResultsXY() to get X- and Y-values
* KDTreeTsQueryResultsTags() to get tag values
* KDTreeTsQueryResultsDistances() to get distances
    
IMPORTANT: kd-tree buffer should be used only with  KD-tree  object  which
           was used to initialize buffer. Any attempt to use biffer   with
           different object is dangerous - you  may  get  integrity  check
           failure (exception) because sizes of internal arrays do not fit
           to dimensions of KD-tree structure.

  -- ALGLIB --
     Copyright 18.03.2016 by Bochkanov Sergey
*************************************************************************/
public static int kdtreetsqueryrnn(kdtree kdt,
    kdtreerequestbuffer buf,
    double[] x,
    double r,
    bool selfmatch,
    alglib.xparams _params)
{
    int r
    e
    s
        lt
            = 0


    alglib.p.assert(
            at
                . is
        inite(
        r
        &&
        double)(
        )>(doub
    e)(0), "K
    TreeTsQ
        ur rr
        ct R!"
        ;
    glib.ap.a
    sert(
        algli
            .a
            .len(x) >=
        dt.nx, "KDTreeTs
    Q
        u
    e
        r
    y
        R
    N
    N
        :

    L
        e
    n
        g
    t
    h
        (
            X
        )
        <
        N
    X
        !
    "
        )
    ;


    a
        l
    g
        l
    i
    b
        .a
    p
        .
        a
        s
    s
        e

    r
        t
        (
            a
                p

    s
        e
    r
    v
        .
        i
        s
    f
        i
    n
        i
    t
        e
    v
    ector(x, kdt.nx,
        _param
    ),
    KDTreeTsQueryRN
    N
        :
    X co
    tai
        ns NaN v
    a
        l
    e
        s!re
    u
        lt n(kd
            , buf, x,
            r true,
            _params
        ;
}


/*************************************************************************
R-NN query: all points within  R-sphere  centered  at  X,  using  external
thread-local buffer, no ordering by distance as undicated  by  "U"  suffix
(faster that ordered query, for large queries - significantly faster).

You can call this function from multiple threads for same kd-tree instance,
assuming that different instances of buffer object are passed to different
threads.

INPUT PARAMETERS
    KDT         -   KD-tree
    Buf         -   request buffer  object  created  for  this  particular
                    instance of kd-tree structure with kdtreecreaterequestbuffer()
                    function.
    X           -   point, array[0..NX-1].
    R           -   radius of sphere (in corresponding norm), R>0
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True

RESULT
    number of neighbors found, >=0

This  subroutine  performs  query  and  stores  its result in the internal
structures  of  the  buffer object. You can use following  subroutines  to
obtain these results (pay attention to "buf" in their names):
* KDTreeTsQueryResultsX() to get X-values
* KDTreeTsQueryResultsXY() to get X- and Y-values
* KDTreeTsQueryResultsTags() to get tag values
* KDTreeTsQueryResultsDistances() to get distances

As indicated by "U" suffix, this function returns unordered results.
    
IMPORTANT: kd-tree buffer should be used only with  KD-tree  object  which
           was used to initialize buffer. Any attempt to use biffer   with
           different object is dangerous - you  may  get  integrity  check
           failure (exception) because sizes of internal arrays do not fit
           to dimensions of KD-tree structure.

  -- ALGLIB --
     Copyright 18.03.2016 by Bochkanov Sergey
*************************************************************************/
public static int kdtreetsqueryrnnu(kdtree kdt,
    kdtreerequestbuffer buf,
    double[] x,
    double r,
    bool selfmatch,
    alglib.xparams _params)

int
    result
        = 
    ;


gli
ap.sert(math
sfinit > (doubl
    )
    (0), "KDT
r
    eTsQuer
RNNU:
    in
orrect R
");


al ib
ap.len(x) >
    kd
        .n
x
    , "K
TreeTsQue
    rR h(
) < NX!"
    ;

glib.ap.a
    sert(
        apser
            .i
            finitevec

or(x, kdt.nx, _p
a
    r
a
    m
s
    )
    ,

"
K
    D
T
    r
e
    e
T
    s
Q
    u
e
    r
y
    R
N
    N
U
    :

X
    c
o
    n
t
    a
i
    n
s
    i
n
    f
i
    n
i
    t
e
    o
r
    N
a
    N

v
    a
l
    u
e
    s
!
    "
    )
;


result = t

queryr
    n(k
        t, buf, x, r, se
        l

fmatch
    fa
ls
return
    res
ult;
}


/*************************************************************************
K-NN query: approximate K nearest neighbors

IMPORTANT: this function can not be used in multithreaded code because  it
           uses internal temporary buffer of kd-tree object, which can not
           be shared between multiple threads.  If  you  want  to  perform
           parallel requests, use function  which  uses  external  request
           buffer: KDTreeTsQueryAKNN() ("Ts" stands for "thread-safe").

INPUT PARAMETERS
    KDT         -   KD-tree
    X           -   point, array[0..NX-1].
    K           -   number of neighbors to return, K>=1
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True
    Eps         -   approximation factor, Eps>=0. eps-approximate  nearest
                    neighbor  is  a  neighbor  whose distance from X is at
                    most (1+eps) times distance of true nearest neighbor.

RESULT
    number of actual neighbors found (either K or N, if K>N).
    
NOTES
    significant performance gain may be achieved only when Eps  is  is  on
    the order of magnitude of 1 or larger.

This  subroutine  performs  query  and  stores  its result in the internal
structures of the KD-tree. You can use  following  subroutines  to  obtain
these results:
* KDTreeQueryResultsX() to get X-values
* KDTreeQueryResultsXY() to get X- and Y-values
* KDTreeQueryResultsTags() to get tag values
* KDTreeQueryResultsDistances() to get distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static int kdtreequeryaknn(kdtree kdt,
    double[] x,
    int k,
    bool selfmatch,
    double eps,
    alglib.xparams _params)
{
    int result
        = 0;

    result
        =
        kd
    ree
        squ
    ryaknn(kdt, kdt.nnerbuf, x, k, selfmatch, eps
        ,
        pa
    ams
        ;
    return
        esult;
}


/*************************************************************************
K-NN query: approximate K nearest neighbors, using thread-local buffer.

You can call this function from multiple threads for same kd-tree instance,
assuming that different instances of buffer object are passed to different
threads.

INPUT PARAMETERS
    KDT         -   KD-tree
    Buf         -   request buffer  object  created  for  this  particular
                    instance of kd-tree structure with kdtreecreaterequestbuffer()
                    function.
    X           -   point, array[0..NX-1].
    K           -   number of neighbors to return, K>=1
    SelfMatch   -   whether self-matches are allowed:
                    * if True, nearest neighbor may be the point itself
                      (if it exists in original dataset)
                    * if False, then only points with non-zero distance
                      are returned
                    * if not given, considered True
    Eps         -   approximation factor, Eps>=0. eps-approximate  nearest
                    neighbor  is  a  neighbor  whose distance from X is at
                    most (1+eps) times distance of true nearest neighbor.

RESULT
    number of actual neighbors found (either K or N, if K>N).
    
NOTES
    significant performance gain may be achieved only when Eps  is  is  on
    the order of magnitude of 1 or larger.

This  subroutine  performs  query  and  stores  its result in the internal
structures  of  the  buffer object. You can use following  subroutines  to
obtain these results (pay attention to "buf" in their names):
* KDTreeTsQueryResultsX() to get X-values
* KDTreeTsQueryResultsXY() to get X- and Y-values
* KDTreeTsQueryResultsTags() to get tag values
* KDTreeTsQueryResultsDistances() to get distances
    
IMPORTANT: kd-tree buffer should be used only with  KD-tree  object  which
           was used to initialize buffer. Any attempt to use biffer   with
           different object is dangerous - you  may  get  integrity  check
           failure (exception) because sizes of internal arrays do not fit
           to dimensions of KD-tree structure.

  -- ALGLIB --
     Copyright 18.03.2016 by Bochkanov Sergey
*************************************************************************/
public static int kdtreetsqueryaknn(kdtree kdt,
    kdtreerequestbuffer buf,
    double[] x,
    int k,
    bool selfmatch,
    double eps,
    alglib.xparams _params)

sult = 0;

i
    t i
0;


int
    = 0


al rt(
    >

0, "
DT
    eeTsQuery
KN
    :
    in
orrect
    !");

alglib.a
assert((
        uble)
    ps)
(doubl
    (0)
"KDTr
eT
    Que
yAKNN:
incorrect Eps!");


a
    lgli
b

ap.
    sse
    t(a
        lib.ap.le
        x)>=

kdt.nx,
KD
eeTsQueryAKNN:
Lengt
    (X) < NX!
");

alglib.ap.asser
    t
    (
        ps
            rv.

s
    f
initevector(x, k
t.nx, _params), "KDT
r
    e
Ts
    uer
A
    K
N:

c
    ontains infinite
    or NaN values!");

    //

    // Handle special case
    :

DT
    N = 0

if (
    kdt {
    buf.kcur
        = 0;


    r
        e
    s
        u
    l
        t
            =
            0
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


/


// Check cons
i
    stency
of
    re


c
    he ferc
    nsistency
    (k rams);

    //

    // Prepare

    //
    .

Min(k
dt n);
buf.
    k
    nee
d
    d =
        k


b
f.rneeded

0;

b f.selfma
    ;


t.normtype == 2 )
{
    buf.approxf = 1 / math.sqr(1 + eps);
}
else
{
    buf.approxf = 1 / (1 + eps);
}
buf.kcur = 0;

//
// calculate distance from point to current bounding box
//
kdtreeinitbox(kdt, x, buf, _params);

//
// call recursive search
// results are returned as heap
//
kdtreequerynnrec(kdt, buf, 0, _params);

//
// pop from heap to generate ordered representation
//
// last element is non pop'ed because it is already in
// its place
//
result = buf.kcur;
j = buf.kcur;
for (i = buf.kcur; i >= 2; i--)
{
    tsort.tagheappopi(ref buf.r, ref buf.idx, ref j, _params);
}

return result;
}


/*************************************************************************
Box query: all points within user-specified box.

IMPORTANT: this function can not be used in multithreaded code because  it
           uses internal temporary buffer of kd-tree object, which can not
           be shared between multiple threads.  If  you  want  to  perform
           parallel requests, use function  which  uses  external  request
           buffer: KDTreeTsQueryBox() ("Ts" stands for "thread-safe").

INPUT PARAMETERS
    KDT         -   KD-tree
    BoxMin      -   lower bounds, array[0..NX-1].
    BoxMax      -   upper bounds, array[0..NX-1].


RESULT
    number of actual neighbors found (in [0,N]).

This  subroutine  performs  query  and  stores  its result in the internal
structures of the KD-tree. You can use  following  subroutines  to  obtain
these results:
* KDTreeQueryResultsX() to get X-values
* KDTreeQueryResultsXY() to get X- and Y-values
* KDTreeQueryResultsTags() to get tag values
* KDTreeQueryResultsDistances() returns zeros for this request
    
NOTE: this particular query returns unordered results, because there is no
      meaningful way of  ordering  points.  Furthermore,  no 'distance' is
      associated with points - it is either INSIDE  or OUTSIDE (so request
      for distances will return zeros).

  -- ALGLIB --
     Copyright 14.05.2016 by Bochkanov Sergey
*************************************************************************/
public static int kdtreequerybox(kdtree kdt,
    double[] boxmin,
    double[] boxmax,
    alglib.xparams _params)
{
    i
        t resul
    t ult
        = kdtr
    e
        s
    q
        dt i
    n
        f,
        _p
    s
        ;
    resul
        t
        ;
}


/*************************************************************************
Box query: all points within user-specified box, using thread-local buffer.

You can call this function from multiple threads for same kd-tree instance,
assuming that different instances of buffer object are passed to different
threads.

INPUT PARAMETERS
    KDT         -   KD-tree
    Buf         -   request buffer  object  created  for  this  particular
                    instance of kd-tree structure with kdtreecreaterequestbuffer()
                    function.
    BoxMin      -   lower bounds, array[0..NX-1].
    BoxMax      -   upper bounds, array[0..NX-1].

RESULT
    number of actual neighbors found (in [0,N]).

This  subroutine  performs  query  and  stores  its result in the internal
structures  of  the  buffer object. You can use following  subroutines  to
obtain these results (pay attention to "ts" in their names):
* KDTreeTsQueryResultsX() to get X-values
* KDTreeTsQueryResultsXY() to get X- and Y-values
* KDTreeTsQueryResultsTags() to get tag values
* KDTreeTsQueryResultsDistances() returns zeros for this query
    
NOTE: this particular query returns unordered results, because there is no
      meaningful way of  ordering  points.  Furthermore,  no 'distance' is
      associated with points - it is either INSIDE  or OUTSIDE (so request
      for distances will return zeros).
    
IMPORTANT: kd-tree buffer should be used only with  KD-tree  object  which
           was used to initialize buffer. Any attempt to use biffer   with
           different object is dangerous - you  may  get  integrity  check
           failure (exception) because sizes of internal arrays do not fit
           to dimensions of KD-tree structure.

  -- ALGLIB --
     Copyright 14.05.2016 by Bochkanov Sergey
*************************************************************************/
public static int kdtreetsquerybox(kdtree kdt,
        kdtreerequestbuffer buf,
        double[] boxmin,
        double[] boxmax,
        alglib.xparams _params)
    =

0


int j
    = 0;


alglib
    .
    p.ass
    rt(
        lgli dt

nx, "K
TreeTsQ
eryBox:
ength(B
o
    in
NX!
    ;


algl.ap.len(
        oxmax) >=
    k
t.n
    , "KDTre
sQuer
ox:
ngth(Box
x)<NX!")        b.ap.a

s
    ert(apserv.isfin
        i

t
    v
ecto
(boxmi
    , k
t.nx, _params
    )
    ,"KDTreeTsQuery
ox:
BoxMin ini

ue
    s
!");

alglib
    s
    (apse
        v.

isfi
    n
tevec
    t

o
    r(
        bo
            x

m
a
    x, rams),
e
    Query
ox:
Bo
    x
ax co
n
    t
ai
    ns

i
    n
fite or NaN value


//


//
C
    h
e
    c
k
    cnsistency of
    quest buff

    //
    eck
equest
    uf
erc
nsistency(kdt, buf, _params
    ;


// Quick 
it
    or degenerate boxes


//

for (j = 0; j <=
            k
    d
            .n
        - 1;
j
    +
    +)
{
    if (
        (
            d
    ub
        e)(
        o
    x
        in[
    ]
    )
    >

    (double)(boxmax
    j]) )

    {
        buf.kcur
            = 0;
        re
            s
        u
            t = 0;


        ret
    }
}


//


/ Pre
    ar
pa //


for (j; j <= k
    d
nx - 1;
j++)


{
    boxmin[j]
    box
        in[j]
    ;


    buf.b
    ma
        [j] = b
    x
    ma
        [j];
    uf.urboxmin[
        ] =
        oxmin[
        ];


    bu
        .curbo
        max j];
}


buf
    kcur = 0;
    /
    /
    /
    /

c
    a
l
    l

r
    e
c
    u
r
    s
i
    v
e
    s
e
    a
r
    c
h
    /
    /
kd
    reeque
ybo
rec(kdt, buf,
    0
    , _par
ms)
;
result
    =
    buf.kc
ur retu
r
n
    result
    ;
}


/*************************************************************************
X-values from last query.

This function retuns results stored in  the  internal  buffer  of  kd-tree
object. If you performed buffered requests (ones which  use  instances  of
kdtreerequestbuffer class), you  should  call  buffered  version  of  this
function - kdtreetsqueryresultsx().

INPUT PARAMETERS
    KDT     -   KD-tree
    X       -   possibly pre-allocated buffer. If X is too small to store
                result, it is resized. If size(X) is enough to store
                result, it is left unchanged.

OUTPUT PARAMETERS
    X       -   rows are filled with X-values

NOTES
1. points are ordered by distance from the query point (first = closest)
2. if  XY is larger than required to store result, only leading part  will
   be overwritten; trailing part will be left unchanged. So  if  on  input
   XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
   XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
   you want function  to  resize  array  according  to  result  size,  use
   function with same name and suffix 'I'.

SEE ALSO
* KDTreeQueryResultsXY()            X- and Y-values
* KDTreeQueryResultsTags()          tag values
* KDTreeQueryResultsDistances()     distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreequeryresultsx(kdtree kdt,
    ref double[,] x,
    alglib.xparams _params)
{
    kdtre
        ts
    uery
        esul
    sx(k
        ,
        k
    dt.i
        erbuf,
        ef x, _params);
}


/*************************************************************************
X- and Y-values from last query

This function retuns results stored in  the  internal  buffer  of  kd-tree
object. If you performed buffered requests (ones which  use  instances  of
kdtreerequestbuffer class), you  should  call  buffered  version  of  this
function - kdtreetsqueryresultsxy().

INPUT PARAMETERS
    KDT     -   KD-tree
    XY      -   possibly pre-allocated buffer. If XY is too small to store
                result, it is resized. If size(XY) is enough to store
                result, it is left unchanged.

OUTPUT PARAMETERS
    XY      -   rows are filled with points: first NX columns with
                X-values, next NY columns - with Y-values.

NOTES
1. points are ordered by distance from the query point (first = closest)
2. if  XY is larger than required to store result, only leading part  will
   be overwritten; trailing part will be left unchanged. So  if  on  input
   XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
   XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
   you want function  to  resize  array  according  to  result  size,  use
   function with same name and suffix 'I'.

SEE ALSO
* KDTreeQueryResultsX()             X-values
* KDTreeQueryResultsTags()          tag values
* KDTreeQueryResultsDistances()     distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreequeryresultsxy(kdtree kdt,
    ref double[,] xy,
    alglib.xparams _params)

squ
    e
ry s
l
    ts
xy(k,
    k
d
    t
i
    nn
e
    arams);
}


/*************************************************************************
Tags from last query

This function retuns results stored in  the  internal  buffer  of  kd-tree
object. If you performed buffered requests (ones which  use  instances  of
kdtreerequestbuffer class), you  should  call  buffered  version  of  this
function - kdtreetsqueryresultstags().

INPUT PARAMETERS
    KDT     -   KD-tree
    Tags    -   possibly pre-allocated buffer. If X is too small to store
                result, it is resized. If size(X) is enough to store
                result, it is left unchanged.

OUTPUT PARAMETERS
    Tags    -   filled with tags associated with points,
                or, when no tags were supplied, with zeros

NOTES
1. points are ordered by distance from the query point (first = closest)
2. if  XY is larger than required to store result, only leading part  will
   be overwritten; trailing part will be left unchanged. So  if  on  input
   XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
   XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
   you want function  to  resize  array  according  to  result  size,  use
   function with same name and suffix 'I'.

SEE ALSO
* KDTreeQueryResultsX()             X-values
* KDTreeQueryResultsXY()            X- and Y-values
* KDTreeQueryResultsDistances()     distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreequeryresultstags(kdtree kdt,
    ref int[] tags,
    alglib.xparams _params)
{
    u
        e
    yre
        u

    l
        tstags(kdt, kdt.
            nnerbuf, ref tags, _pa
            r

    a
}


/*************************************************************************
Distances from last query

This function retuns results stored in  the  internal  buffer  of  kd-tree
object. If you performed buffered requests (ones which  use  instances  of
kdtreerequestbuffer class), you  should  call  buffered  version  of  this
function - kdtreetsqueryresultsdistances().

INPUT PARAMETERS
    KDT     -   KD-tree
    R       -   possibly pre-allocated buffer. If X is too small to store
                result, it is resized. If size(X) is enough to store
                result, it is left unchanged.

OUTPUT PARAMETERS
    R       -   filled with distances (in corresponding norm)

NOTES
1. points are ordered by distance from the query point (first = closest)
2. if  XY is larger than required to store result, only leading part  will
   be overwritten; trailing part will be left unchanged. So  if  on  input
   XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
   XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
   you want function  to  resize  array  according  to  result  size,  use
   function with same name and suffix 'I'.

SEE ALSO
* KDTreeQueryResultsX()             X-values
* KDTreeQueryResultsXY()            X- and Y-values
* KDTreeQueryResultsTags()          tag values

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreequeryresultsdistances(kdtree kdt,
    ref double[] r,
    alglib.xparams _params)
{
    kdt
        eet
    queryr
        sul
    tdistances(kd
            , kdt.innerbuf
        ref r, _params);
}


/*************************************************************************
X-values from last query associated with kdtreerequestbuffer object.

INPUT PARAMETERS
    KDT     -   KD-tree
    Buf     -   request  buffer  object  created   for   this   particular
                instance of kd-tree structure.
    X       -   possibly pre-allocated buffer. If X is too small to store
                result, it is resized. If size(X) is enough to store
                result, it is left unchanged.

OUTPUT PARAMETERS
    X       -   rows are filled with X-values

NOTES
1. points are ordered by distance from the query point (first = closest)
2. if  XY is larger than required to store result, only leading part  will
   be overwritten; trailing part will be left unchanged. So  if  on  input
   XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
   XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
   you want function  to  resize  array  according  to  result  size,  use
   function with same name and suffix 'I'.

SEE ALSO
* KDTreeQueryResultsXY()            X- and Y-values
* KDTreeQueryResultsTags()          tag values
* KDTreeQueryResultsDistances()     distances

  -- ALGLIB --
     Copyright 28.02.2010 by Bochkanov Sergey
*************************************************************************/
public static void kdtreetsqueryresultsx(kdtree kdt,
    kdtreerequestbuffer buf,
    ref double[,] x,
    alglib.xparams _params)
{
    int
        = 0;


    int
        = 
        ;


    nt i1_ = 


    if
    (
        uf.k
    {
        return
    }

    if (a
    glib.ap.rows(x) < buf
        .k
        .a
    p.cols(x) < kdt.nx
        )
    {
        =

        ew
            o
        u
        ble[buf.kcur, kd
            .nx];
    }


    = buf.kcu;
    for (i = ; i
    {
        i1_
            (kdt.nx) - (0);


        f
            o
        r
        (
            i
        _
            =
            0
            ;

        i
            _
                <
                =
        k
            d
        t
            .n
        x
            -
            1
            ;
        i
        _
            +
            +
            )


        {
            x[i,
                _] = k
            t.xy
            buf.idx[i],i_ + i1_];
        }


        /*************************************************************************
        X- and Y-values from last query associated with kdtreerequestbuffer object.

        INPUT PARAMETERS
            KDT     -   KD-tree
            Buf     -   request  buffer  object  created   for   this   particular
                        instance of kd-tree structure.
            XY      -   possibly pre-allocated buffer. If XY is too small to store
                        result, it is resized. If size(XY) is enough to store
                        result, it is left unchanged.

        OUTPUT PARAMETERS
            XY      -   rows are filled with points: first NX columns with
                        X-values, next NY columns - with Y-values.

        NOTES
        1. points are ordered by distance from the query point (first = closest)
        2. if  XY is larger than required to store result, only leading part  will
           be overwritten; trailing part will be left unchanged. So  if  on  input
           XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
           XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
           you want function  to  resize  array  according  to  result  size,  use
           function with same name and suffix 'I'.

        SEE ALSO
        * KDTreeQueryResultsX()             X-values
        * KDTreeQueryResultsTags()          tag values
        * KDTreeQueryResultsDistances()     distances

          -- ALGLIB --
             Copyright 28.02.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void kdtreetsqueryresultsxy(kdtree kdt,
            kdtreerequestbuffer buf,
            ref double[,] xy,
            alglib.xparams _params)
        {
            i
                n
            t i = 0;
                in
            k =
                0;
            int i_ = 0;


            i
                i
            f()


            {
                if (alglib.ap.r
                o
                ws(y
                   < bu
                f
                    .kcur || gli
                    .a
                    .cols(x
                y
                    )
                    .)
                {
                    xy = new double[buf.kcur, kdt.nx + kdt.ny];
                }
                k = buf.kcur;
                for (i = 0; i <= k - 1; i++)
                {
                    i1_ = (kdt.nx) - (0);
                    for (i_ = 0; i_ <= kdt.nx + kdt.ny - 1; i_++)
                    {
                        xy[i, i_] = kdt.xy[buf.idx[i], i_ + i1_];
                    }
                }
            }


            /*************************************************************************
            Tags from last query associated with kdtreerequestbuffer object.
    
            This function retuns results stored in  the  internal  buffer  of  kd-tree
            object. If you performed buffered requests (ones which  use  instances  of
            kdtreerequestbuffer class), you  should  call  buffered  version  of  this
            function - KDTreeTsqueryresultstags().
    
            INPUT PARAMETERS
                KDT     -   KD-tree
                Buf     -   request  buffer  object  created   for   this   particular
                            instance of kd-tree structure.
                Tags    -   possibly pre-allocated buffer. If X is too small to store
                            result, it is resized. If size(X) is enough to store
                            result, it is left unchanged.
    
            OUTPUT PARAMETERS
                Tags    -   filled with tags associated with points,
                            or, when no tags were supplied, with zeros
    
            NOTES
            1. points are ordered by distance from the query point (first = closest)
            2. if  XY is larger than required to store result, only leading part  will
               be overwritten; trailing part will be left unchanged. So  if  on  input
               XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
               XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
               you want function  to  resize  array  according  to  result  size,  use
               function with same name and suffix 'I'.
    
            SEE ALSO
            * KDTreeQueryResultsX()             X-values
            * KDTreeQueryResultsXY()            X- and Y-values
            * KDTreeQueryResultsDistances()     distances
    
              -- ALGLIB --
                 Copyright 28.02.2010 by Bochkanov Sergey
            *************************************************************************/
            public static void kdtreetsqueryresultstags(kdtree kdt,
                kdtreerequestbuffer buf,
                ref int[] tags,
                alglib.xparams _params)

            int i = 0;
            int k = 0;

            if (buf.kcur == 0)
            {
                return;
            }

            if (alglib.ap.len(tags) < buf.kcur)
            {
                tags = new int[buf.kcur];
            }

            k = buf.kcur;
            for (i = 0; i <= k - 1; i++)
            {
                tags[i] = kdt.tags[buf.idx[i]];
            }
        }


        /*************************************************************************
        Distances from last query associated with kdtreerequestbuffer object.

        This function retuns results stored in  the  internal  buffer  of  kd-tree
        object. If you performed buffered requests (ones which  use  instances  of
        kdtreerequestbuffer class), you  should  call  buffered  version  of  this
        function - KDTreeTsqueryresultsdistances().

        INPUT PARAMETERS
            KDT     -   KD-tree
            Buf     -   request  buffer  object  created   for   this   particular
                        instance of kd-tree structure.
            R       -   possibly pre-allocated buffer. If X is too small to store
                        result, it is resized. If size(X) is enough to store
                        result, it is left unchanged.

        OUTPUT PARAMETERS
            R       -   filled with distances (in corresponding norm)

        NOTES
        1. points are ordered by distance from the query point (first = closest)
        2. if  XY is larger than required to store result, only leading part  will
           be overwritten; trailing part will be left unchanged. So  if  on  input
           XY = [[A,B],[C,D]], and result is [1,2],  then  on  exit  we  will  get
           XY = [[1,2],[C,D]]. This is done purposely to increase performance;  if
           you want function  to  resize  array  according  to  result  size,  use
           function with same name and suffix 'I'.

        SEE ALSO
        * KDTreeQueryResultsX()             X-values
        * KDTreeQueryResultsXY()            X- and Y-values
        * KDTreeQueryResultsTags()          tag values

          -- ALGLIB --
             Copyright 28.02.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void kdtreetsqueryresultsdistances(kdtree kdt,
            kdtreerequestbuffer buf,
            ref double[] r,
            alglib.xparams _params)

        i = 0;
        int k = 0;

        if (buf.kcur == 0)
        {
            return;
        }

        if (alglib.ap.len(r) < buf.kcur)
        {
            r = new double[buf.kcur];
        }

        k = buf.kcur;

        //
        // unload norms
        //
        // Abs() call is used to handle cases with negative norms
        // (generated during KFN requests)
        //
        if (kdt.normtype == 0)
        {
            for (i = 0; i <= k - 1; i++)
            {
                r[i] = Math.Abs(buf.r[i]);
            }
        }

        if (kdt.normtype == 1)
        {
            for (i = 0; i <= k - 1; i++)
            {
                r[i] = Math.Abs(buf.r[i]);
            }
        }

        if (kdt.normtype == 2)
        {
            for (i = 0; i <= k - 1; i++)
            {
                r[i] = Math.Sqrt(Math.Abs(buf.r[i]));
            }
        }
    }


    /*************************************************************************
    X-values from last query; 'interactive' variant for languages like  Python
    which   support    constructs   like  "X = KDTreeQueryResultsXI(KDT)"  and
    interactive mode of interpreter.

    This function allocates new array on each call,  so  it  is  significantly
    slower than its 'non-interactive' counterpart, but it is  more  convenient
    when you call it from command line.

      -- ALGLIB --
         Copyright 28.02.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void kdtreequeryresultsxi(kdtree kdt,
        ref double[,] x,
        alglib.xparams _params)
    {
        x
            =
            ew double
        0,0];


        k
            d
        t
            r
        e
            e
        q
            u
        e
            r
        y
            r
        e
            s
        u
            l
        t
            s
        x
        (
            k
        d
            t,
            r
        e
        f
            x,
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
    XY-values from last query; 'interactive' variant for languages like Python
    which   support    constructs   like "XY = KDTreeQueryResultsXYI(KDT)" and
    interactive mode of interpreter.

    This function allocates new array on each call,  so  it  is  significantly
    slower than its 'non-interactive' counterpart, but it is  more  convenient
    when you call it from command line.

      -- ALGLIB --
         Copyright 28.02.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void kdtreequeryresultsxyi(kdtree kdt,
        ref double[,] xy,
        alglib.xparams _params)
    {
        x
            =
            w
        d
        ouble[0, 0];


        kd
            reequeryr
        sultsxy(
            dt, ref
            y
            , _p
        rams)
    }


    /*************************************************************************
    Tags  from  last  query;  'interactive' variant for languages like  Python
    which  support  constructs  like "Tags = KDTreeQueryResultsTagsI(KDT)" and
    interactive mode of interpreter.

    This function allocates new array on each call,  so  it  is  significantly
    slower than its 'non-interactive' counterpart, but it is  more  convenient
    when you call it from command line.

      -- ALGLIB --
         Copyright 28.02.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void kdtreequeryresultstagsi(kdtree kdt,
        ref int[] tags,
        alglib.xparams _params)
    {
        tags
            = ne
        int[0
        kdtreeque
            r

        resultst
            gs(k
                t, r
                f

        ags,
        _params);
    }


    /*************************************************************************
    Distances from last query; 'interactive' variant for languages like Python
    which  support  constructs   like  "R = KDTreeQueryResultsDistancesI(KDT)"
    and interactive mode of interpreter.

    This function allocates new array on each call,  so  it  is  significantly
    slower than its 'non-interactive' counterpart, but it is  more  convenient
    when you call it from command line.

      -- ALGLIB --
         Copyright 28.02.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void kdtreequeryresultsdistancesi(kdtree kdt,
        ref double[] r,
        alglib.xparams _params)
    {
        r
            =
            d
        r
            ee dis
            a

        c
            s
            (d ar
                a
                s);
    }


    /*************************************************************************
    It is informational function which returns bounding box for entire dataset.
    This function is not visible to ALGLIB users, only ALGLIB itself  may  use
    it.

    This function assumes that output buffers are preallocated by caller.

      -- ALGLIB --
         Copyright 20.06.2016 by Bochkanov Sergey
    *************************************************************************/
    public static void kdtreeexplorebox(kdtree kdt,
        ref double[] boxmin,
        ref double[] boxmax,
        alglib.xparams _params)
    {
        apserv.rvectorsetleng xm _p


        apserv.r
            ve
        c
            or ea dt.
            n
            x,
            _
        a
            ra
        m
            s
            )
        ;


        i <


        {
            box
                m
            i
            n
                [
                    i
                ]
                = boxmax[i] kdt.boxmax[i];
        }
    }


    /*************************************************************************
    It is informational function which allows to get  information  about  node
    type. Node index is given by integer value, with 0  corresponding  to root
    node and other node indexes obtained via exploration.

    You should not expect that serialization/unserialization will retain  node
    indexes. You should keep in  mind  that  future  versions  of  ALGLIB  may
    introduce new node types.

    OUTPUT VALUES:
        NodeType    -   node type:
                        * 0 corresponds to leaf node, which can be explored by
                          kdtreeexploreleaf() function
                        * 1 corresponds to split node, which can  be  explored
                          by kdtreeexploresplit() function

      -- ALGLIB --
         Copyright 20.06.2016 by Bochkanov Sergey
    *************************************************************************/
    public static void kdtreeexplorenodetype(kdtree kdt,
        int node,
        ref int nodetype,
        alglib.xparams _params)
    {
        nodetype
            = 0;


        alglib
        ap.assert
        nod
            >= 0,
        KD
            reeE
        plor
            e
        de
        pe
            in
        rrect node");
        al
        lib.p.a
        sert(node < alglib.p.len(kdt.n
        o
            es)
        "
        DT
            eExp
        reNodeType:
        incorrect n
        de"
            ;


        if (kd
            .nod
        e[

        {
            //

            // Leaf no
            d
            e
                /
                /


            n
                o
            d
                e
            t
                y
            p
                e
                    =
                    0
                ;


            r
                e
            t
            u
                rn;


            if (kdt.nodes[node] = 
                =
            0 )


            // Spl
            it node
                /
                n
            o
                d
            e
                t
            y
                p
            return;
        }


        al lib.
            a
            s "KDTreeExploreNodeType: integrity check failure");
    }


    /*************************************************************************
    It is informational function which allows to get  information  about  leaf
    node. Node index is given by integer value, with 0  corresponding  to root
    node and other node indexes obtained via exploration.

    You should not expect that serialization/unserialization will retain  node
    indexes. You should keep in  mind  that  future  versions  of  ALGLIB  may
    introduce new node types.

    OUTPUT VALUES:
        XT      -   output buffer is reallocated (if too small) and filled by
                    XY values
        K       -   number of rows in XY

      -- ALGLIB --
         Copyright 20.06.2016 by Bochkanov Sergey
    *************************************************************************/
    public static void kdtreeexploreleaf(kdtree kdt,
        int node,
        ref double[,] xy,
        ref int k,
        alglib.xparams _params)
    {
        int offs
        0;

        int i = 0;
        int j = 0;


        k = 0;


        alglib.a.assert(node >
                        0, "KDTr
        eExploreL
        af:
        incor
            ec
        nod
            ind
        e
            );


        alglib.ap.assert(node + 1 < a
        glib
        ap.en(kdt.nodes), "K
        TreeExplore
            L
        af:
            in
        or
            ct n
            e index");

        lgl
        b.ap
            as
            ert(
            dt.node
                [nod
        e > Ex
        loreLe
        f:
        e index")
            = kdt.no
        es[node];


        o
            f
        f
            s
                =
                k
        d
        t
            .
            n
            o
        d
            e
        s
        [
            n
        o
            d
        e
            +
            1
            ]
        ;


        a
            l
        g
            l
        i
        b
            .a
        p
            .
            a
            s
        s
            e

        r
            t
            (
                o
                    f

        f
        s
            >
            =
            0
            ,

        "
        K
            DTreeExploreLeaf
        integ
            ity
        rror");
        alglib.a
        p
            .asser
                (of
        fs ap.ows(kd
        t
            .y
            ), oreLea
        f
            :
        integ
            ity err
            or");

        mt r
            y, k, kdt.nx + kdt.ny, _p ra s)


        f
        r(i = 0; <
            =
        k
        {
            for (j = 0; j <= kdt.nx + kdt.ny - 1; j++)
            {
                xy[i, j] = kdt.xy[offs + i, kdt.nx + j];
            }
        }
    }


    /*************************************************************************
    It is informational function which allows to get  information  about split
    node. Node index is given by integer value, with 0  corresponding  to root
    node and other node indexes obtained via exploration.

    You should not expect that serialization/unserialization will retain  node
    indexes. You should keep in  mind  that  future  versions  of  ALGLIB  may
    introduce new node types.

    OUTPUT VALUES:
        XT      -   output buffer is reallocated (if too small) and filled by
                    XY values
        K       -   number of rows in XY

        //      Nodes[idx+1]=dim    dimension to split
        //      Nodes[idx+2]=offs   offset of splitting point in Splits[]
        //      Nodes[idx+3]=left   position of left child in Nodes[]
        //      Nodes[idx+4]=right  position of right child in Nodes[]
        
      -- ALGLIB --
         Copyright 20.06.2016 by Bochkanov Sergey
    *************************************************************************/
    public static void kdtreeexploresplit(kdtree kdt,
        int node,
        ref int d,
        ref double s,
        ref int nodele,
        ref int nodege,
        alglib.xparams _params)
    {
        d =
            0;

        ;


        dele
            = 0;


        alglib.p.sser
            (nod
        e
            = 0, "
        DTr
            eE
        ploreSpl
        t:
        alglib.ap.a
            s
        s
        rt(node + 4 K
        T
            eeExploreSp
        it
            inco
        rect
            ode i
            dex
            ;

        de
            == 0, "KDTreeExplor
        e
            S
        lit:
        incr in
        ex");

        dt.nodes[
            ode + 1
        ];


        s =
            kdt.splits[kdt.n
        o
            d
        e
        s
        [
            n
        o
            d
        e
            +
            2
            ]
            ]
        ;


        n
            o
        d
            e
        l
            e
                =
                k
        d
        t
            .
            n
            o
        d
            e
        s
        [
            n
        o
            d
        e
            +
            3
            ]
        ;


        n
            o
        d
            e
        g
            e = kdt.nodes[no
        e + 4];


        alglib.ap.asser
            t
        (d >= 0,
            "KD
        Tr it:
        inte
            gr );


        a
            lg t(d < kd
        t
            .nx, "K
        TreeExp
        loreSplit:
        e");


        sert(ma h.i
        sfinite s), KD
            T
        r
            xpl reSpl t: in te ity ail e")             

        al rt(ode
                le =
                0
            , KDTr
                e

        eExp
            l
        oreSpl
            it
        i
            nte
        g
            rit
        y
            f ai ur
        e"        
        glib.ap.as

        s
            rt(nodele
                al

        li
        b.p
        "
        K
            Tre E
            xplo re
            S
        plit
            :

        i
            t
            )
            >=

        lit:
        integr it y
            ss e
        "        KD        Tr        ee        Ex        pl        or        e
        i
            in tegrity failure");
    }


    /*************************************************************************
    Serializer: allocation

      -- ALGLIB --
         Copyright 14.03.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void kdtreealloc(alglib.serializer s,
        kdtree tree,
        alglib.xparams _params)
    {
        /


        // 
        eader


        //


        s.alloc_
        try

        ()
        s.all
            o
        _ent
        y();
            /
            /

            // Data

            //
            .allo
            _ent
        y();


        s.a
        loc_entry()
            ;
            .alloc
            ent
        y();


        s.alloc_
            e
        ntry();


        pserv.locrealmatrix(s, tre
        e
            xy, 
        -1, -1
        _pa
            am
            ;


        apse
            .allocin
            ge
        rray(s
        tree.tags, -1, _param
            );


        pserv.allocreal
        rray(s
            , -
                r
        );


        a
        serv.allocr
            a
        la
        ray
            s, tr
        e
            .bo
            max,  -
            , _ er
            .alloci s
        n
            s,  -1,
        _p
            rams
            ;

        er
            .alloc
        eal.splits,
        1, _p
            arams
            ;
    }


    /*************************************************************************
    Serializer: serialization

      -- ALGLIB --
         Copyright 14.03.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void kdtreeserialize(alglib.serializer s,
        kdtree tree,
        alglib.xparams _params)
    {
        //
        //        e
        a
        //


        s
            .
            seri
            a
        l
            i
        ze int(s od
        es ge
        t
            kdt
        r
            eeser
        i
            a
        iza ioncode(_par am))
        ;

        .s i
        lize_
        int
            sion;


        //


        // D        ta


        //


        s
            .s
            ;


        s.s
            e
        r
            .s er ia li ze _i nt(t re e.ny);

        ty pe );
        a ps er v.se ri al iz er ea lm at ri x(s,
            e.xy, -1, -1, _params

        apse
        rv.s gerarr

        a
            y(s,
                tree.t g

        s, -1
            ,

        _
            p
        a
            rams);


        ap se v.s
            e
        ializerealarray(s, t r
        e.boxm n, 
        1, _ pa
        ram
            apv s
            e
        i
            a
        ize
            r
        ea
            l
        arr
            a
        y(
            s
        tree.b
            o
        x
            ap serializeint e.n
            o
        d
        e
            s, 
        -
            1,
        _p
            a
        ra
            m
        s);


        er it
            s, 

        -
            1

        par
            a
        ms
            )
        ;
    }


    /*************************************************************************
    Serializer: unserialization

      -- ALGLIB --
         Copyright 14.03.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void kdtreeunserialize(alglib.serializer s,
        kdtree tree,
        alglib.xparams _params)
    {
        nt i0
        0;
        int i
        1
            = 0
              /

              //
              he
        corre
            ness of header

            //
            i0 = s.unse
        ialize
            _i
        g
            .ap.as
        ert(i0
            = s
        odes.getkdt
            e
        es
            ria
        izati
            o
        cod
            (_para
        s), ea
            header;

        i1 =
            s.nser
        al
            ze_i alglib.ap.assert(i1 == kdtreefirstversion, ialize: stream header corrupted");

        //
        Unserialize data
        //
        tree.n = s.unseria tree.nx = s.unserialize_int();
        tree.ny
            t = s.unser
        alize
        _int(
            ;


        apserv.unserial
            i
        z
            e
        r
            e
        a
            l
        m
            a
        t
            r

        i
            x
            (
                s
                ,
                r
                    e

        f
            t
        r
            e
        e
            .
            x
            y,
            _
        p
            a
        r
            a
        m
            s
            )
        ;


        a
            p
        s
            e
        r
        v
            .
            u
            n
        s
            e
        r
            i
        a
            l
        i
            z
        e
            i

        n
            tegerarray(s, re
                tree.

        ags,
        _params);


        aps
        rv.
            un lar
        ay(s
            , min
        _p
            r
        am
            apserv
        u
            ns arr
        y(s
            ref t
            re ara
            s);

        nseria
            l

        izeinte
            erarray
            (s, ref tree a
                s)


        e
            v
        u
            n
        y(s, e

        te arams)


        reater
            eq e
            st uffer t
            ree, t e
        e
            .
            nn rbuf _p rams);
    }


    /*************************************************************************
    R-NN query: all points within  R-sphere  centered  at  X,  using  external
    thread-local buffer, sorted by distance between point and X (by ascending)

    You can call this function from multiple threads for same kd-tree instance,
    assuming that different instances of buffer object are passed to different
    threads.

    NOTE: it is also possible to perform undordered queries performed by means
          of kdtreequeryrnnu() and kdtreetsqueryrnnu() functions. Such queries
          are faster because we do not have to use heap structure for sorting.

    INPUT PARAMETERS
        KDT         -   KD-tree
        Buf         -   request buffer  object  created  for  this  particular
                        instance of kd-tree structure with kdtreecreaterequestbuffer()
                        function.
        X           -   point, array[0..NX-1].
        R           -   radius of sphere (in corresponding norm), R>0
        SelfMatch   -   whether self-matches are allowed:
                        * if True, nearest neighbor may be the point itself
                          (if it exists in original dataset)
                        * if False, then only points with non-zero distance
                          are returned
                        * if not given, considered True

    RESULT
        number of neighbors found, >=0

    This  subroutine  performs  query  and  stores  its result in the internal
    structures  of  the  buffer object. You can use following  subroutines  to
    obtain these results (pay attention to "buf" in their names):
    * KDTreeTsQueryResultsX() to get X-values
    * KDTreeTsQueryResultsXY() to get X- and Y-values
    * KDTreeTsQueryResultsTags() to get tag values
    * KDTreeTsQueryResultsDistances() to get distances
        
    IMPORTANT: kd-tree buffer should be used only with  KD-tree  object  which
               was used to initialize buffer. Any attempt to use biffer   with
               different object is dangerous - you  may  get  integrity  check
               failure (exception) because sizes of internal arrays do not fit
               to dimensions of KD-tree structure.

      -- ALGLIB --
         Copyright 18.03.2016 by Bochkanov Sergey
    *************************************************************************/
    private static int tsqueryrnn(kdtree kdt,
        kdtreerequestbuffer buf,
        double[] x,
        double r,
        bool selfmatch,
        bool orderedbydist,
        alglib.xparams _params)
    {
        int r
        e
            sult =
                0
            ;

        i
            = 0;
        int
        j
            /
            dle spe
            N =
                /


        buf.kcur = 0
            ;


        sult;
    }
    /


    k con si
        s
    tency of request buf fe r
        / /


    ch eckr
    e
        q
    ncy(kd
    t
        , bu , _params);


    /
    repare
        pa ra et er
        //        
        b
    uf.k n
    kdt.n
        o
    rmtype != 2 )


    uf.rn ede d = r;


    else


    {
        buf.r n
        ed
        h.sq r(r);

        buf.selfmatch = selfmatch;
        buf.approxf = 1;
        buf.kcur = 0;

        //
        // calculate distance from point to current bounding box
        //
        kdtreeinitbox(kdt, x, buf, _params);

        //
        // ca
        l recu
        sive
            search


        // re
        s
            ults are r
        t
        ur
            / kdtr
        e
            equeryn
        rec(kdt
            , buf, 0, _


        l
            t


        f
            ner e o red re esen
            at
        on
            el
        m
            n
        t
            is n t pop'e d be
        c
            a
        u
        i
            /
            / i s
        p ace


        //                                   i        ( or        e
        redbyd s
        t


        {
            j =
                buf.kcur;


            or
                i = u
            f.cur; >=2 i--)


            {
                tsort.tagheappopi
                (
                    ef buf.r, ref buf.idx, ref j, _params);


                urn result;
            }


            /*************************************************************************
            Rearranges nodes [I1,I2) using partition in D-th dimension with S as threshold.
            Returns split position I3: [I1,I3) and [I3,I2) are created as result.
    
            This subroutine doesn't create tree structures, just rearranges nodes.
            *************************************************************************/
            private static void kdtreesplit(kdtree kdt,
                int i1,
                int i2,
                int d,
                double s,
                ref int i3,
                alglib.xparams _params)
            {
                n
                t
                    nt =
                        in
                t
                    ileft

                0;


                t = 0;
                d
                    o
                ub le
                    v
                        = 0;


                i3 = 0;


                glib.ap.assert(kdt.n > 0, "KDTreeSplit: internal error");

                //
                // split XY/Tags in two parts:
                // * [ILeft,IRight] is non-processed part of XY/Tags
                //
                // After cycle is done, we have Ileft=IRight. We deal with
                // this element separately.
                //
                // After this, [I1,ILeft) contains left part, and [ILeft,I2)
                // contains right part.
                //
                ileft = i1;
                iright = i2 - 1;
                while (ileft < iright)
                {
                    if (kdt.xy[ileft, d] <= s)
                    {
                        //
                        // XY[ILeft] is on its place.
                        // Advance ILeft.
                        //
                        ileft = ileft + 1;
                    }
                    else
                    {
                        //
                        // XY[ILeft,..] must be at IRight.
                        // Swap and advance IRight.
                        //
                        for (i = 0; i <= 2 * kdt.nx + kdt.ny - 1; i++)
                        {
                            v = kdt.xy[ileft, i];
                            kdt.xy[ileft, i] = kdt.xy[iright, i];
                            kdt.xy[iright, i] = v;
                        }

                        j = kdt.tags[ileft];
                        kdt.tags[ileft] = kdt.tags[iright];
                        kdt.tags[iright] = j;
                        iright = iright - 1;
                    }
                }

                if (kdt.xy[ileft, d] <= s)
                {
                    ileft = ileft + 1;
                }
                else
                {
                    iright = iright - 1;
                }

                i3 = ileft;
            }


            /*************************************************************************
            Recursive kd-tree generation subroutine.
    
            PARAMETERS
                KDT         tree
                NodesOffs   unused part of Nodes[] which must be filled by tree
                SplitsOffs  unused part of Splits[]
                I1, I2      points from [I1,I2) are processed
                
            NodesOffs[] and SplitsOffs[] must be large enough.
    
              -- ALGLIB --
                 Copyright 28.02.2010 by Bochkanov Sergey
            *************************************************************************/
            private static void kdtreegeneratetreerec(kdtree kdt,
                ref int nodesoffs,
                ref int splitsoffs,
                int i1,
                int i2,
                int maxleafsize,
                alglib.xparams _params)
            {
                int n = 0;


                int nx = 0
                    ;


                int i
                0;

                nt j =
                    0


                t oldo
                f
                    s
                int i3 =
                    0;
                int
                    cntless = 0;

                t cntg
                r
                    eater =
                        0;

                doub
                    du bl e
                    = 0


                t mn i
                    xid
                        =
                        d
                oubl
                    =
                    ouble
                0 = 0;


                b
                    _
                        = 0;


                alglib
                ap.ass
                    re
                c:
                inte rn ao;


                a
                glib.ap
                    .a
                    : or");


                ra te

                le

                //


                {
                    offs]
                    nod
                        e
                    sof s +
                        i
                    1;


                    fs
                        =
                        nodesoff
                        +
                        ;

                    n;
                }


                ues access
                    //
                    nx = kdt.nx;
                y;
                    /
                    /


                // Sel
                e
                c
                    is a d m
                    nsion numbe
                    se bou nd ing
                ox
                    as ze ro si
                    e,
                    we e
                    of de.
                    //
                    d
                    d

                kd
                t
                    .inn
                    e
                ebuf.curboxmin[0
                    ;

                for i = 1
                i
                {
                    v
                        kd t. in nr bo
                    bu f
                    curb xmin[


                    {
                        d
                    }
                }


                b


                {
                    kdt
                        .
                        n
                        o
                    es[
                        ode
                    s
                        off
                    s
                    0]

                    i
                        - i1;
                        = i1;


                    nosoffs = nodesoffs + 2;
                    return;
                }

                //
                // Select split position S using sliding midpoint rule,
                // rearrange points into [I1,I3) and [I3,I2).
                //
                // In case all points has same value of D-th component
                // (MinV=MaxV) we enforce D-th dimension of bounding
                // box to become exactly zero and repeat tree constructi
                n.

                    //
                    =
                kd urb
                xm
                    in

                1)

                (0 for
                    i
                        _ = -1;
                _++


                kdt.inn
                erbuf.buf[i
                1_, d
                    n
                cntl

                0
                e
                t
                    r
                        = minv = k t
                    i
                n
                    x kdt.in
                n
                    er
                b
                uf.buf
                [
                    0];


                minidx = i1;


                for ;
                i++)
                {
                    t.innerbuf.buf[i];
                    if (v < minv)

                        minv = v;
                    minidx = i1 + i;
                    if (v > maxv)
                        maxv = v;
                    maxidx = i1 + i;
                    if (v < s


                    ntless
                    1


                    if
                    v
                        cnt
                    g
                        r
                    e
                    at
                        e
                            = 
                    if ( {
                        // In ca        me         ent


                        ) dimen
                            ero struction.
                            //
                            innerbuf.curboxmin[d];
                        inn
                            k
                        d
                        t.
                            i
                            nne
                        r
                            bu
                        f
                            .
                            c
                            r
                        bo
                            xm b
                            x
                        ax[
                                d
                            ]
                            =
                            maxv
                            ;


                        ate
                            t
                        re
                            e
                        rec(k
                        d
                            t,
                            r
                        f n
                        o
                            de
                        s
                            offs,
                            r
                        e
                            f
                        s afs
                        i
                            ze,
                            _para
                        m
                            s
                            )


                        rb;


                        k
                            dt d]
                            =
                        v1;


                        r
                        e
                            turn;


                        i
                            f(c
                                n

                        tless >
                            0
                            &
                            cn {
                            or
                                m
                            l m
                            i
                                dp
                            o
                            int s
                            p
                                l
                            i
                                t


                            //         kdtr
                            e
                                plit(
                                    k
                                        d

                            t, s, rams) se


                            {
                                //

                                // sliding midpoint
                                //
                                if (cntless == 0)
                                {
                                    //
                                    // 1. move split to MinV,
                                    // 2. place one point to the left bin (move to I1),
                                    //    others - to the right bin
                                    //
                                    s = minv;
                                    if (minidx != i1)
                                    {
                                        for (i = 0; i <= 2 * nx + ny - 1; i++)
                                        {
                                            v = kdt.xy[minidx, i];
                                            kdt.xy[minidx, i] = kdt.xy[i1, i];


                                            kdt.xy[i1, i]
                                                = v;
                                        }


                                        j =
                                            kdt
                                        tags[minid
                                        x]

                                        gs[
                                            in
                                            id s[i
                                            ];

                                        kdt.t
                                        ags[i1]
                                            = j;


                                        +1;

                                            //
                                            /
                                        1

                                        o
                                        ve xV,
                                            pl
                                        ce one poi
                                            t
                                        t
                                            o n(mov
                                        to
                                        2
                                        1
                                            ),
                                        //


                                        ot e l
                                            ft bin
                                               /
                                            = m
                                        x
                                            ;

                                        i
                                        (
                                            a
                                        i
                                            dx


                                        i <= 2 * n
                                            + n
                                            -
                                            ;
                                        i


                                        dt.y[m
                                        x
                                            d
                                        xi
                                            k
                                        d
                                        t
                                            .x
                                        y
                                            maxidx, i] = kdt.xy[i2 - 1, i];


                                        kdt.x
                                        y[
                                            i
                                        2 - 1,i]
                                            =
                                        v
                                            ;
                                    }
                                    ];
                                    kdt.tags[maxidx[i2


                                    kdt.t
                                        gs
                                }


                                3
                                    =
                                    i
                                2 -
                            }
                        }


                        /


                        // Gene
                        r
                        a
                            te
                                = kdt.nodes[nodesoffs + 1] = d;
                        t.n fs
                        2
                            =
                            s
                        pl
                            it

                        k
                            d
                        t.
                            s
                            ffs = nodesoffs;
                        n odesoffs + splitnodesize;
                        soffs = splitsoffs + 1;

                        //
                        // Recursive ge                   u
                        d
                            t
                        e
                            /
                            /
                        *call
                        s
                        ubroutine

                            // 
                            *
                            restore
                        C
                            u
                        r
                        Bo /
                            /


                        d
                        t.no 3]


                        v = kd
                        t
                            .innerbuf
                            .
                            c
                            u
                        r
                            box
                        m
                        ax[d];


                        k
                            d
                        t.ax
                            [
                            ]
                            = 
                            ;
                        ee r
                        f
                            n
                        od f,
                            i
                        1,, in
                        n
                            r
                        buf.cu
                            r
                        b
                            ox
                        m
                        ax
                            [
                                d] = v
                            ;


                        od nod
                        e
                            soffs
                            ;


                        v
                            =
                            k
                        dt
                            .i n[d
                            ]
                            ;


                        k
                            d
                        t
                            .
                            n
                            er
                        bu s;


                        kdtre
                            e
                        g
                            en,  ref
                            no
                            fsi;
                        kdt.innerbuf.curboxmin[d] = v;
                        //
                        // Zero-fill unused portions         (av        rnings by Valgrind
                        // about attempt to seri        ialized values)
                        //
                        alglib.ap.nodesize == 6, "KDTreeGenerateTreeRec: node size has unexpecte        );
                        k
                            t
                        nod
                            e
                        s[oldoff
                        s
                            + 5] = 0;
                    }


                    /*************************************************************************
                    Recursive subroutine for NN queries.
            
                      -- ALGLIB --
                         Copyright 28.02.2010 by Bochkanov Sergey
                    *************************************************************************/
                    private static void kdtreequerynnrec(kdtree kdt,
                        kdtreerequestbuffer buf,
                        int offs,
                        alglib.xparams _params)


                    d
                        ou =
                            0


                    i
                        t
                    i
                    2
                        = in


                    d
                        o
                    bl
                        d
                    u
                    le t1 = ;
                    b
                        n
                    t
                        hi

                    0;
                    o
                        ble prevdi
                        s
                    t

                    iv
                        e
                            = ne
                    w
                    bool
                        );
                    min = new bool();

                    alglib.ap.assert(kdt.n >

internal error");

//


// Pr
cess
points.of
s
    > 0
    )


{
    .n
        d
    s[o
    f
    fs + 1];


    for (i = i 1;
    i < = i2 - 1;
    i
        +
        +

        //
        / Calculate dis ta nce
        / /

    ptdist =
        0


    n x kdt.n x;

    kd
    t
        .normtyp
    e
        == 0 )


    for
    (
        j = 0; j <= n
        x
            -
            1
    j + )


    at h
        .ax(p tdist
            , Ma h
            (kdt.xy[i,
                j
            ]
    bu
    if
    dt.n orm ty pe =
        1 )


    fo(j 0;
    j
        <= nx - 1;

    ++
        )


    {
        ptdi
            .
    }
    if 2
        )


    th.sqr(kdt.xy[i, j] - buf.x[j]);
}

i
    oint
s f
s
lf - mat
ch
    es
ar


if
(
    pt
d
        is
        t
    = 
    =
    &&
!
    co
n
    tinue;
    /
T p
r
    oc
e
    ss

p
    o

f
    RN eded > 0)

A
    ND(Pt D

i
s
    /


if
(
    buf
    .rn e
    d
ed
    )
    /
    /

sati
    :
nt
    Cu K
    d)


worst po nt
    is
    ette )


*
    d oi n
t

th
    /
    i
    |
    uf kn e

{
    / d
        d
    c
    r
        /
        /


    bu f.r, r ef b f.idx,

    r
        e

    uf.k
    cu
        r,
        p
    t
        d
    i
        s
    t
}


//


ot,

de en
d
    in
g
    o

h
    ei
h ey re p
l
    a
c
    o


i f(p td
st < buf.
    [0]


if
(
    buf.knee
d
e
    d
        = 
    )


bu f
    .i d[
    tdist;


e
l
    .taghea re la c
topi(r
uf.i x
bufk ne eded, ptd


}
}
retu rn;

//
Si //
f( kd.n odes[off
s
    == 0
    )
{
    //         Lo
    a
    d:
        /
    *D
    lit
        /
        *S s plit p o
        / /


    d = kd
    t
        .n od e
        s = kd
    t
        .splits[k
    d
    t
        .
        o
        e
    s
        /
        /
        /
        / ffs
        chi
    l
        d box wit
    h
        b
    s

    c
        * C s child box with worst chances
    //
    if (b
    {
        childbestoffs[of


        c
        h
            ildworstoffs
                =
                k
        d
            .nodes[offs + 4];
        bestisleft = true;


        else


        childbestoffs = kdt.nodes[offs + 4];
        childworstoffs = kdt.nodes[offs + 3];
        bestisleft = false;
    }

    //
    // Navigate through childs
    //
    for (i = 0; i <= 1; i++)

    {
        // Se
        ect
            c ess

            // 
            *
            ChildO
        fs
            current chi Nodes
            ]


        *
            p
        a
            e
        Mi er
        i
            i
        u
            m alu

            //
            bou
        di
            g
        b
            ox on
            p
        a
        e
            /


        if
            =
        0
            )


        childoffs
            =
            c
        hi
            !be
            tisleft;
    }


    {
        pdatemin =
            b
        sti
            left
            ;


        chil
            o
        fs
            chi
        l
            d
        wr
    }


    /
    /


    ate x and current //                   da
    t
        min
        )


    r
        vdi
    s
        t = b
    u
    f.cu
        r
    d
        i
    st
        t
    1
        = bu
    f
        .x[d
        ]
        ;


    v
        =
        b
    uf
        .
        c
        u
    b
        ox
    mi
    if (kdt.b
    f
        cur
    d
        is
        t st
        ,
    s - t
    1
        );


    if
    (
        k
    d
        t
    n
        or
    mt
        y
    p
        e
            =
            1
        )


    uf.c
        u
    rdi
    s
        t = bu
    f
        curd
    i
    st -
        M
    ath
        .
        Ma
        x
    (
        v
        -
        t
    1
        , 0
        )
    +
            s
        -
        t
    1
        ;

    mt
        y
    e ==
        2
        )


    b
        u
    f
        c
    ur
        di
    s
        t


    bu
    f.x(
}


=

}
p
re
vd
i
s
t
=
b
uf
v
= b
u
f.c
u
rb
o
x
m
a
x
[
    d];


=s

t.n {
    buf.curdis dis
}


t.dis t1 - s;
}
pe==2 )
{
    t
        =
        buf
            .curdist
        - m
    a
    h.qr(Mat
    h.Max
        (
            t1 - v, 0
        ) +
        f.curboxmax[d] = s;
}
//
// Decide: to dive into                         //
if curdist > buf.rneeded )
{
    odi
}


e
    l
se
    ll po
    i
nts are foun
    d
    )
    /
    /


// KCur=KNeeded, decide to dive or not to di           // using point position relative to bounding box.
ve

buf.c
    u
rdi
    s
t
    <
    =
    b
f.
}
ery
n
nre
c
(
k
t
bu

//        bound                  datem
i
n )


{
    buf.
        c
        rboxmi
    n
        d
            ]
            = v;


    {
        bu
            bu p


        return;
    }


    /*************************************************************************
    Recursive subroutine for box queries.

      -- ALGLIB --
         Copyright 28.02.2010 by Bochkanov Sergey
    *************************************************************************/
    private static void kdtreequeryboxrec(kdtree kdt,
        kdtreerequestbuffer buf,
        int offs,
        alglib.xparams _params)
    {
        boo
            l
        inb
        o
            x
                = int nx = 0


        int
            i
        1
            = i2 = 0;
            = ouble s = 0;
        do
            ass
                e

        r
            t
            (
                k
                    t
                    .

        n
            >
            0

        "K
        D
        n
            / Chec
        t
            at inte
            th b ou ding bo i
        mpty.

            //
            Th
            s chec
            fs = 0(re r ot).
                /

        i
            (offs =
                0)
            +)


        f
            b


        if (buf.boxm
        a


        {
            / ea nod.


            if (kd
            t
                kdt
            nodes[of
            s];


            for (i
                 p int is
                n
                bo
            x o
            r
                no t


            inb ox
                =
                tr ue;
            j < nx 1;
            j + +)


            ox j]
                ;


            y
        }


        if (
                !inbox)

            //                                 
            bu
        f.r[bu f.kc ur]
            = 0. 0;
            = cu
            r
                = b
        u
        f.kcur + 1


        n
            /
            imp l
            e
        split

            //
            i
        f
            (kd
        t
            .no
            d
        e
        s
            [o
        f
            f

        ad d
        i
            mension t
            o

        s
            l
        t
            s = kd t.pl ts[k
        d
        t.nodes
            [o


        c
            o
        er s p
            l
        it(S i s up pe r bo un d

        o


        //


        {
            ox cur
            b
            oxmax[d

            s;


            k
                d
            t
                r
            f


            buf
                .curboxma
            x[
                d


            // 
            C
                he
            c
                k

            p
                p
            e
                r
            s
                p
            li ou /
                i
                    (uf.c
            urboxmi[d]


            bu.c
                u
            rbox m
                in [d] =
            s;


            k
                d
            t
                b
            f
                .c
        }
    }


    /*************************************************************************
    Copies X[] to Buf.X[]
    Loads distance from X[] to bounding box.
    Initializes Buf.CurBox[].

      -- ALGLIB --
         Copyright 28.02.2010 by Bochkanov Sergey
    *************************************************************************/
    private static void kdtreeinitbox(kdtree kdt,
        double[] x,
        kdtreerequestbuffer buf,
        alglib.xparams _params)

    i


    do
        ub d

    r")        /
    // calculate distance from point                 //
    buf.curdist = 0;
        =0;
    i <
        nx -
        1
        ;
    i + +)


    {
        .


        vmax =
            kd;
        bu.oxm
        i
            [i] = vmi
        n


        buf.curdist = M vm
    }


    if (x > vmax)


        uf.cu.c
}


for (0; i <= kdt.nx - 1; i++)
{
    vx = x[i];
    vmin = kdt.boxmin[i];
    vmax = kdt.boxmax[i];
    buf.x[i] = vx;
    buf.curboxmin[i] = vmin;
    buf.curboxmax[i] = vmax;
    if (vx <
        min)


    {
        f.curdist = buf.cur
        ist
            + v


        else


        i
        (v
         > vma
        x
            )


        u
        f.f.c
            rd
        s
            +
            v
    }
}


i
(
    k
t
    .o


{
    fo r
        ;
    i < k.vx = i]

    k
    t.boxmin
        i];


    x = kdt b
    xmax[
        buf
    x[i]
        = v
    cu b
    xmin
        [i

    x
            [
        )
    rd
        i
    t + m
    a
    th.sq r


    if
    (
        .s
        r
    vx
        -
        vmax;
}


}
}


/*************************************************************************
This function allocates all dataset-independend array  fields  of  KDTree,
i.e.  such  array  fields  that  their dimensions do not depend on dataset
size.

This function do not sets KDT.NX or KDT.NY - it just allocates arrays

  -- ALGLIB --
     Copyright 14.03.2011 by Bochkanov Sergey
*************************************************************************/
private static void kdtreeallocdatasetindependent(kdtree kdt,
    int nx,
    int ny,
    alglib.xparams _params)

ssert(k t.n > 0

et
    rr or "
    ;

k d
t.bo x
kd
t.ble[nx];
}


/*************************************************************************
This function allocates all dataset-dependent array fields of KDTree, i.e.
such array fields that their dimensions depend on dataset size.

This function do not sets KDT.N, KDT.NX or KDT.NY -
it just allocates arrays.

  -- ALGLIB --
     Copyright 14.03.2011 by Bochkanov Sergey
*************************************************************************/
private static void kdtreeallocdatasetdependent(kdtree kdt,
    int n,
    int nx,
    int ny,
    alglib.xparams _params)

i
    .
    p.a
    ss er t(n>
0,
"
K
    D
T
t:
i
    nt er nal er ro
r
"
    )


*n x + n
kd.n o
    des = new
        i
n
[
    p
l
    lits = new uble[2 * n];
}


/*************************************************************************
This  function   checks  consistency  of  request  buffer  structure  with
dimensions of kd-tree object.

  -- ALGLIB --
     Copyright 02.04.2016 by Bochkanov Sergey
*************************************************************************/
private static void checkrequestbufferconsistency(kdtree kdt,
    kdtreerequestbuffer buf,
    alglib.xparams _params)

alg lib.p.as
e
    t
(a(buf.x
   >= kd
       .x
    ,
    w
ith

p.assert(alglib.ap.len(buf.idx) >= kdt.n, "KDTree: dimensio        req        re 
i
    nconsis
e
    t
w tr
u
    tur
e
");
    as en(
    b
u
f
        .r
    >
    = d n,
"        KD        T
e
e:

e
    t
i
    h

k
    d
t
    r
lgli
    .a.as

s
    ert(al
        g

l
    i
b.h.M
    a
x
(
    k
d
    .
    ,
kd nsi
os of kd r
e
    e
e
    uest b
    li n(b
u
f.curbo
    m
n)>=
k
dt.
    n
    x, 
"
KDTree:

imen
    s
io
    n
s
    ur
e
    );


dt.
    n
    x,  "KDT
e
    :
di
    m
ens
    i
ons
    of kdtr
    e
re
    q
uest
    b
u
}
}
}