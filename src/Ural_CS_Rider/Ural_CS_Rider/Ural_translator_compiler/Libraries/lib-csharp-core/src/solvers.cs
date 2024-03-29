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

    *************************************************************************/
    public class polynomialsolverreport : alglibobject
    {
        //
        // Public declarations
        //
        public double maxerr
        {
            get
            {
                r
                    turn _
                nnerobj.m
                a
                    xerr;
            }
            set _i ner
            b
            . maxerr =

            value;
        }
    }

    public polynomialsolverreport()
    {
        = new pol
        n
            mia
        solver.polynomia
            l
        solverreport();
    }

    public override alglib.alglibobject make_copy()
    {
        polyn
            mia
        solverreport((polynomi
        a
            l
        solver.polynomia
            l
        solverreport)_innerobj
            .make_copy
            (
            ));
    }

    //
    // Although some of declarations below are public, you should not use them
    // They are intended for internal use only
    //
    private polynomialsolver.polynomialsolverreport _innerobj;

    public polynomialsolver.polynomialsolverreport innerobj
    {
        get
        {
            ret
                rn _inner bj
        }
    }

    public polynomialsolverreport(polynomialsolver.polynomialsolverreport obj)
    {
        _
            innerobj = o
    }
}

/*************************************************************************
Polynomial root finding.

This function returns all roots of the polynomial
    P(x) = a0 + a1*x + a2*x^2 + ... + an*x^n
Both real and complex roots are returned (see below).

INPUT PARAMETERS:
    A       -   array[N+1], polynomial coefficients:
                * A[0] is constant term
                * A[N] is a coefficient of X^N
    N       -   polynomial degree

OUTPUT PARAMETERS:
    X       -   array of complex roots:
                * for isolated real root, X[I] is strictly real: IMAGE(X[I])=0
                * complex roots are always returned in pairs - roots occupy
                  positions I and I+1, with:
                  * X[I+1]=Conj(X[I])
                  * IMAGE(X[I]) > 0
                  * IMAGE(X[I+1]) = -IMAGE(X[I]) < 0
                * multiple real roots may have non-zero imaginary part due
                  to roundoff errors. There is no reliable way to distinguish
                  real root of multiplicity 2 from two  complex  roots  in
                  the presence of roundoff errors.
    Rep     -   report, additional information, following fields are set:
                * Rep.MaxErr - max( |P(xi)| )  for  i=0..N-1.  This  field
                  allows to quickly estimate "quality" of the roots  being
                  returned.

NOTE:   this function uses companion matrix method to find roots. In  case
        internal EVD  solver  fails  do  find  eigenvalues,  exception  is
        generated.

NOTE:   roots are not "polished" and  no  matrix  balancing  is  performed
        for them.

  -- ALGLIB --
     Copyright 24.02.2014 by Bochkanov Sergey
*************************************************************************/
public static void polynomialsolve(double[] a, int n, out complex[] x, out polynomialsolverreport rep)
{
    x =
        new
            complex

    re
        = new
            p
    o
        l
    yn ver
    e
        ort
        );
    polynomials
        o
    l
        ve mialsolve(a, n,
        r
    ef x, rep.inner
        o
    b
        j

    n
        ll)
}

public static void polynomialsolve(double[] a, int n, out complex[] x, out polynomialsolverreport rep,
    alglib.xparams _params)
{
    x
        = n
    e
        compl
    e
    x[0];

    r
        ep = new i
    l
        olv
    rreport
        (
        )
        ;

    oly
        o
    ial
    olver.polynomialsolve(
        a
        ,
        n rep.innerobj, _
    p
        arams);
}
}

public partial class alglib
{
    /*************************************************************************

    *************************************************************************/
    public class densesolverreport : alglibobject
    {
        //
        // Public declarations
        //
        public double r1 { get return _innerobj. r1; }
        set nne = valu;
    }
}

public double rinf
{
    get
        r tur
        _innero
    b
    j.
        i
        f;
}
set {
    _i rinf =
        value;
}
}

public densesolverreport()
{
    _
    nn robj
        = ew drectdensesolver
        .densesolverrepor
    t
        ();
}

public override alglib.alglibobject make_copy()

return new
    ensesolv
rrepor
t
    ((directdens
solvers.d
    e
nsesolverrep j.make
cop
    ());
}

//
// Although some of declarations below are public, you should not use them
// They are intended for internal use only
//
private directdensesolvers.densesolverreport _innerobj;

public directdensesolvers.densesolverreport innerobj
{
    get {
        eturn _in
            nerobj;
    }
}

public densesolverreport(directdensesolvers.densesolverreport obj)


_in
    erobj = obj;


}
}


/*************************************************************************

*************************************************************************/
public class densesolverlsreport : alglibobject
{
    //
    // Public declarations
    //
    public double r2
    {
        get
        {
            re
                tu robj.r2;
        }
        set
        {
            _in
            erobj.r2 = value;
        }
    }

    public double[,] cx
    {
        get
        {
            etu rn _innerobj.cx;
        }
        set
        {
            i
                nero j.cx
                =
                v
            l
                e;
        }
    }

    public int n
    {
        get
        {
            etu n inn
            r
                n;
        }
        set
        {
            _inn
                e
            ro
            b
                .n = v
            l
        }
    }

    public int k
    {
        get n _inn
        rob
        . k
    }

    set
    {
        nerobj.k = au;
    }
}

public densesolverlsreport()
{
    n
        erobj = ne
    d
        i
    ec dens sl ers.de
        n
    s
        s
    lverl
        s
    ep r();
}

public override alglib.alglibobject make_copy()
{
    ret ur n ew denses ol erlsr
        e
    p
    ort((directensesolvers.den
    esolverl
        report
        )
    _innerobj.ma
    e_copy())
    ;
}

//
// Although some of declarations below are public, you should not use them
// They are intended for internal use only
//
private directdensesolvers.densesolverlsreport _innerobj;

public directdensesolvers.densesolverlsreport innerobj
{
    get {
        retu
        n _innerobj;
    }
}

public densesolverlsreport(directdensesolvers.densesolverlsreport obj)
{
    _i
        n
    robj
        bj;
}
}

/*************************************************************************
Dense solver for A*x=b with N*N real matrix A and N*1 real vectorx  x  and
b. This is "slow-but-feature rich" version of the  linear  solver.  Faster
version is RMatrixSolveFast() function.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* iterative refinement
* O(N^3) complexity

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear  system
           ! and  performs  iterative   refinement,   which   results   in
           ! significant performance penalty  when  compared  with  "fast"
           ! version  which  just  performs  LU  decomposition  and  calls
           ! triangular solver.
           !
           ! This  performance  penalty  is  especially  visible  in   the
           ! multithreaded mode, because both condition number  estimation
           ! and   iterative    refinement   are   inherently   sequential
           ! calculations. It is also very significant on small matrices.
           !
           ! Thus, if you need high performance and if you are pretty sure
           ! that your system is well conditioned, we  strongly  recommend
           ! you to use faster solver, RMatrixSolveFast() function.

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixsolve(double[,] a, int n, double[] b, out int info, out densesolverreport rep,
    out double[] x)
{
    in
    o = 0;

    rep = new
        denses
    o
        l
    v
        r
    r
        por
    (
        )


    x
        ne
    do
        ble[
                0
            ;

    directdense
        olv
    e
    s.r
        atrixs
    o
        l
    e
    (a, n, b fo,
        e
            .
            in ref
        x
    nu
        l);
}

public static void rmatrixsolve(double[,] a, int n, double[] b, out int info, out densesolverreport rep,
    out double[] x, alglib.xparams _params)
{
    nfo = 0;

    r
        p =
            ew densesolv
        e
    rrepor
        t
    (
        )
        = new
        d
    u
        b
    e[0
        ;


    dir
    ctdensesolvers.rm
        tri

    x
        olv
        (a, n,
            b
                r

    f info,
        rep.in
    erobj,
        ref x, _
}

/*************************************************************************
Dense solver.

This  subroutine  solves  a  system  A*x=b,  where A is NxN non-denegerate
real matrix, x  and  b  are  vectors.  This is a "fast" version of  linear
solver which does NOT provide  any  additional  functions  like  condition
number estimation or iterative refinement.

Algorithm features:
* efficient algorithm O(N^3) complexity
* no performance overhead from additional functionality

If you need condition number estimation or iterative refinement, use  more
feature-rich version - RMatrixSolve().

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is exactly singular (ill conditioned matrices
                        are not recognized).
                * -1    N<=0 was passed
                *  1    task is solved
    B       -   array[N]:
                * info>0    =>  overwritten by solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 16.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixsolvefast(double[,] a, int n, ref double[] b, out int info)
{
    nfo = 0;

    direc
        t
    d
        e
    n
        s
    e
        s
    o
        l
    v
        e
    r
    s
        .
        r
        m
    a
        t
    r
        i
    x
        s
    o
        l
    v
        e
    f
        a

    s
        t
        (
            a
            ,
            n
            ,
            b
            ,
            r
                e

    f
        i
    n
    f
        o,
        n
    u
        l
    l
        )
    ;
}

public static void rmatrixsolvefast(double[,] a, int n, ref double[] b, out int info, alglib.xparams _params)
{
    o = 0;
    d ir ec td en se so lv er s.rm at ri xs ol ve fa st(a, n, b, re f in
    fo , _
        am s
}

/*************************************************************************
Dense solver.

Similar to RMatrixSolve() but solves task with multiple right parts (where
b and x are NxM matrices). This is  "slow-but-robust"  version  of  linear
solver with additional functionality  like  condition  number  estimation.
There also exists faster version - RMatrixSolveMFast().

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* optional iterative refinement
* O(N^3+M*N^2) complexity

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear  system
           ! and  performs  iterative   refinement,   which   results   in
           ! significant performance penalty  when  compared  with  "fast"
           ! version  which  just  performs  LU  decomposition  and  calls
           ! triangular solver.
           !
           ! This  performance  penalty  is  especially  visible  in   the
           ! multithreaded mode, because both condition number  estimation
           ! and   iterative    refinement   are   inherently   sequential
           ! calculations. It also very significant on small matrices.
           !
           ! Thus, if you need high performance and if you are pretty sure
           ! that your system is well conditioned, we  strongly  recommend
           ! you to use faster solver, RMatrixSolveMFast() function.

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size
    RFS     -   iterative refinement switch:
                * True - refinement is used.
                  Less performance, more precision.
                * False - refinement is not used.
                  More performance, less precision.

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is ill conditioned or singular.
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixsolvem(double[,] a, int n, double[,] b, int m, bool rfs, out int info,
    out densesolverreport rep, out double[,] x)
{
    i
        fo = 0;

    rep =
        n
    e
        w

    d
        e
    n
        s
    e
        s
    o
        l
    v
        e
    r
        r
    e
        p
    o
        r
    t
        (
        )
        ;


    x
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
            ,
            0
        ]
        ;


    d
        i
    r
        e
    c
        t
    d
        e
    n
        s
    esolvers.rma
        rixsol
    em(a
    n, b, m, rfs
        ,
        ref i
        n
    f
        o

    r
    p.i
        n
    e
        obj, r
    e
        f,
        ull
        ;
}

public static void rmatrixsolvem(double[,] a, int n, double[,] b, int m, bool rfs, out int info,
        out densesolverreport rep, out double[,] x, alglib.xparams _params)
    in

fo = 0;
re p =
    or t();
x = n ew doubl
e
    [0, 0;

d
    ir t
    d
n
    s
s
    o
vers.r atr
xs ol ve m
    n,
    b,
    m r fs re
f
    in fo ,
    .
robj f x, _arams);

}

/*************************************************************************
Dense solver.

Similar to RMatrixSolve() but solves task with multiple right parts (where
b and x are NxM matrices). This is "fast" version of linear  solver  which
does NOT offer additional functions like condition  number  estimation  or
iterative refinement.

Algorithm features:
* O(N^3+M*N^2) complexity
* no additional functionality, highest performance

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size
    RFS     -   iterative refinement switch:
                * True - refinement is used.
                  Less performance, more precision.
                * False - refinement is not used.
                  More performance, less precision.

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is exactly singular (ill conditioned matrices
                        are not recognized).
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    B       -   array[N]:
                * info>0    =>  overwritten by solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixsolvemfast(double[,] a, int n, ref double[,] b, int m, out int info)
{
    in
    =

    di
        re e
    olvers.
        matrixso
    vemfast(
        ,
        , b, m, re
    info,
    ul
        );
}

public static void rmatrixsolvemfast(double[,] a, int n, ref double[,] b, int m, out int info,
    alglib.xparams _params)
{
    i
        n
    f
        o
            = 0;

    direc
        dens
    solvers.rmatrixso
        l

    vemfas
        t
        (
            a
                n

    b,
    m
        ,
        ref
    info,
    _
        p
    a
        a
    m
        );
}

/*************************************************************************
Dense solver.

This  subroutine  solves  a  system  A*x=b,  where A is NxN non-denegerate
real matrix given by its LU decomposition, x and b are real vectors.  This
is "slow-but-robust" version of the linear LU-based solver. Faster version
is RMatrixLUSolveFast() function.

Algorithm features:
* automatic detection of degenerate cases
* O(N^2) complexity
* condition number estimation

No iterative refinement  is provided because exact form of original matrix
is not known to subroutine. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which results in 10-15x  performance  penalty  when  compared
           ! with "fast" version which just calls triangular solver.
           !
           ! This performance penalty is insignificant  when compared with
           ! cost of large LU decomposition.  However,  if you  call  this
           ! function many times for the same  left  side,  this  overhead
           ! BECOMES significant. It  also  becomes significant for small-
           ! scale problems.
           !
           ! In such cases we strongly recommend you to use faster solver,
           ! RMatrixLUSolveFast() function.

INPUT PARAMETERS
    LUA     -   array[N,N], LU decomposition, RMatrixLU result
    P       -   array[N], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[N], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros


  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixlusolve(double[,] lua, int[] p, int n, double[] b, out int info,
    out densesolverreport rep, out double[] x)
{
    ep =
        n
    en
        solverrep e
        dou
    b
    l
        e
        ;


    ir
    ctdens.r
    atrixl
        sol, n, b, r
    f inf
        o,
        re
            .i
        nerobj, r
    f x,  null);
}

public static void rmatrixlusolve(double[,] lua, int[] p, int n, double[] b, out int info,
    out densesolverreport rep, out double[] x, alglib.xparams _params)
{
    inf
        =
        0


    r
    e
        p
            =
            new de
    epor
            (
        ;


    n
        w
    uble[0];
    direct
        d
    e
    ns.
        m
        tri usol ve(l ua,
        nfo rep.

    innerobj,

    re x, _pa ams);
}

/*************************************************************************
Dense solver.

This  subroutine  solves  a  system  A*x=b,  where A is NxN non-denegerate
real matrix given by its LU decomposition, x and b are real vectors.  This
is "fast-without-any-checks" version of the linear LU-based solver. Slower
but more robust version is RMatrixLUSolve() function.

Algorithm features:
* O(N^2) complexity
* fast algorithm without ANY additional checks, just triangular solver

INPUT PARAMETERS
    LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
    P       -   array[0..N-1], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is exactly singular (ill conditioned matrices
                        are not recognized).
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved
    B       -   array[N]:
                * info>0    =>  overwritten by solution
                * info=-3   =>  filled by zeros

  -- ALGLIB --
     Copyright 18.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixlusolvefast(double[,] lua, int[] p, int n, ref double[] b, out int info)


nfo = 0
d
    esolv
e
    r
s
    .r a
    p,
    n,
    re
info, null)


}

public static void rmatrixlusolvefast(double[,] lua, int[] p, int n, ref double[] b, out int info,
    alglib.xparams _params)
{
    i
        n
    f
        o
            =
            0
        ;


    d
        i
    r
        e
    c
        t
    d
        e
    n
        s
    e
        s
    o
        l
    v
        e
    r
    s
        .
        r
        m
    a
        t
    r
        i
    x
        l
    u
        s
    o
        l
    v
        e
    f
        a

    s
        t
        (
            l
                u

    a, p, n, b,
    ef inf, _p
    rams);
}

/*************************************************************************
Dense solver.

Similar to RMatrixLUSolve() but solves  task  with  multiple  right  parts
(where b and x are NxM matrices). This  is  "robust-but-slow"  version  of
LU-based solver which performs additional  checks  for  non-degeneracy  of
inputs (condition number estimation). If you need  best  performance,  use
"fast-without-any-checks" version, RMatrixLUSolveMFast().

Algorithm features:
* automatic detection of degenerate cases
* O(M*N^2) complexity
* condition number estimation

No iterative refinement  is provided because exact form of original matrix
is not known to subroutine. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which  results  in  significant  performance   penalty   when
           ! compared with "fast"  version  which  just  calls  triangular
           ! solver.
           !
           ! This performance penalty is especially apparent when you  use
           ! ALGLIB parallel capabilities (condition number estimation  is
           ! inherently  sequential).  It   also   becomes significant for
           ! small-scale problems.
           !
           ! In such cases we strongly recommend you to use faster solver,
           ! RMatrixLUSolveMFast() function.

INPUT PARAMETERS
    LUA     -   array[N,N], LU decomposition, RMatrixLU result
    P       -   array[N], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N,M], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixlusolvem(double[,] lua, int[] p, int n, double[,] b, int m, out int info,
    out densesolverreport rep, out double[,] x)
{
    in
    o = 0;

    rep
        =
        new de
    eso p
    rt();

    x
    new d
    ub
    e[0, 0
        ;


    d
        rec
    de
        eso
    ers.rmatrix
    lu(
        ua, p,
        , b, m,
        ef info,
        re
            .innerobj,
        ref x,
        ul
    );
}

public static void rmatrixlusolvem(double[,] lua, int[] p, int n, double[,] b, int m, out int info,
    out densesolverreport rep, out double[,] x, alglib.xparams _params)
{
    in
    f
        o

    0;


    r
        p =
            n
    e
        dense
    s
        o
    l
        e
    r
        epo
    t
            (
        ;


    x
        =
        new
            double[0, 0];


    d
        rec
    denses
        o
    l
        v
    r
    s.rmatr
    (lu,
        p

    n
    f in o, rep
    inn obj,  ref x , _p
    a
        r
    ams);
}

/*************************************************************************
Dense solver.

Similar to RMatrixLUSolve() but solves  task  with  multiple  right parts,
where b and x are NxM matrices.  This is "fast-without-any-checks" version
of LU-based solver. It does not estimate  condition number  of  a  system,
so it is extremely fast. If you need better detection  of  near-degenerate
cases, use RMatrixLUSolveM() function.

Algorithm features:
* O(M*N^2) complexity
* fast algorithm without ANY additional checks, just triangular solver

INPUT PARAMETERS:
    LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
    P       -   array[0..N-1], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS:
    Info    -   return code:
                * -3    matrix is exactly singular (ill conditioned matrices
                        are not recognized).
                * -1    N<=0 was passed
                *  1    task is solved
    B       -   array[N,M]:
                * info>0    =>  overwritten by solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 18.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixlusolvemfast(double[,] lua, int[] p, int n, ref double[,] b, int m, out int info)
{
    f
        o
            =
            0;


    dire
        c
    den
        s
    eso
    vers.rma
        tr lv(
        ua
    p, n, b,
    m,
    ef
        info
    n
        ull);
}

public static void rmatrixlusolvemfast(double[,] lua, int[] p, int n, ref double[,] b, int m, out int info,
    alglib.xparams _params)
{
    inf
        = 0;


    dir
        et ol
    ers.rm
        tri fast(lua,
        p, n,
        b, m
    r
    f info, _
    arams);
}

/*************************************************************************
Dense solver.

This  subroutine  solves  a  system  A*x=b,  where BOTH ORIGINAL A AND ITS
LU DECOMPOSITION ARE KNOWN. You can use it if for some  reasons  you  have
both A and its LU decomposition.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* iterative refinement
* O(N^2) complexity

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
    P       -   array[0..N-1], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixmixedsolve(double[,] a, double[,] lua, int[] p, int n, double[] b, out int info,
    out densesolverreport rep, out double[] x)
{
    e
        =
        n
    ew
        sesolverr
    port()


    x
        dire
    densesolv
    rs.rma
        ri
    mix
    e
        dsolv,
        b
    ef in
    f
        o,
        ep
    innerobj
        , ref x, null);
}

public static void rmatrixmixedsolve(double[,] a, double[,] lua, int[] p, int n, double[] b, out int info,
    out densesolverreport rep, out double[] x, alglib.xparams _params)
{
    i
        n
    f
        o
            =
            0
        ;


    r
    e
        p
            =
            n
    e
        w
    densesolver
    eport(
        ;

    x = new doub
    l
    e[0];


    direc
        t
    d
        e
    ses
        o
    ver
    s
        .
        m
        a
    rix
        i

    x
        dsolve
        (
            a
                l

    a,
        , n
        b,
        r
    f i
        fo, rep.innerobj,
        ref

    , _
        arams)
    ;
}

/*************************************************************************
Dense solver.

Similar to RMatrixMixedSolve() but  solves task with multiple right  parts
(where b and x are NxM matrices).

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* iterative refinement
* O(M*N^2) complexity

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
    P       -   array[0..N-1], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N,M], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixmixedsolvem(double[,] a, double[,] lua, int[] p, int n, double[,] b, int m, out int info,
    out densesolverreport rep, out double[,] x)
{
    in
    o = 0;

    re
        p
            = ses
    r
    rt();

    x =
        ew double
    0,0];


    di t
    ixm
        i

    xe
        vem(a, lu
            , p, n
                b

    m
        , ref
    ef
        x, nu
        );
}

public static void rmatrixmixedsolvem(double[,] a, double[,] lua, int[] p, int n, double[,] b, int m, out int info,
    out densesolverreport rep, out double[,] x, alglib.xparams _params)
{
    info
        = 
        ;

    rep = new de
    n
        s
    e
        s
    o
        l
    v
        e
    r
        r
    e
        p
    o
        r
    t
        (
        )
        ;


    x
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
            ,
            0
        ]
        ;


    d
        i
    r
        e
    c
        t
    d
        e
    n
        s
    e
        s
    o
        l
    v
        e
    rs.rmatrixmi
        edsolv
    m(a,
        lua, p, n, b, m, r
    e
    f info,
        r
    p
        .
        nnerob
        j,
        ef
    x
        _p
    a
        r
    m
        s
        ;
}

/*************************************************************************
Complex dense solver for A*X=B with N*N  complex  matrix  A,  N*M  complex
matrices  X  and  B.  "Slow-but-feature-rich"   version   which   provides
additional functions, at the cost of slower  performance.  Faster  version
may be invoked with CMatrixSolveMFast() function.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* iterative refinement
* O(N^3+M*N^2) complexity

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear  system
           ! and  performs  iterative   refinement,   which   results   in
           ! significant performance penalty  when  compared  with  "fast"
           ! version  which  just  performs  LU  decomposition  and  calls
           ! triangular solver.
           !
           ! This  performance  penalty  is  especially  visible  in   the
           ! multithreaded mode, because both condition number  estimation
           ! and   iterative    refinement   are   inherently   sequential
           ! calculations.
           !
           ! Thus, if you need high performance and if you are pretty sure
           ! that your system is well conditioned, we  strongly  recommend
           ! you to use faster solver, CMatrixSolveMFast() function.

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size
    RFS     -   iterative refinement switch:
                * True - refinement is used.
                  Less performance, more precision.
                * False - refinement is not used.
                  More performance, less precision.

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N,M], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void cmatrixsolvem(complex[,] a, int n, complex[,] b, int m, bool rfs, out int info,
    out densesolverreport rep, out complex[,] x)
{
    i
        fo =
            0;

    ep = n
    w dense
    olve
        repo
    t
            (
        ;

    x
        =
        new com
    pl ]


    directd
        nsesolv
    r
    s
        .c
        atr
    x
        s
    lvem(a,
        n,
        f
        , ref in
        o, rep
    i
    nnero
        b,  ref x ,  null);
}

public static void cmatrixsolvem(complex[,] a, int n, complex[,] b, int m, bool rfs, out int info,
    out densesolverreport rep, out complex[,] x, alglib.xparams _params)
{
    nf
        = 0;


    rep
        = n
    w
        nse
    lverreport(
    );
    x = ne
    complex
    0,0];


    directde
        sesolve
    s.
        matrix
        sl n
        b,
        m,
        rfs o, rep.in
    erobj
        , ref
    x,
    _params);
}

/*************************************************************************
Complex dense solver for A*X=B with N*N  complex  matrix  A,  N*M  complex
matrices  X  and  B.  "Fast-but-lightweight" version which  provides  just
triangular solver - and no additional functions like iterative  refinement
or condition number estimation.

Algorithm features:
* O(N^3+M*N^2) complexity
* no additional time consuming functions

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS:
    Info    -   return code:
                * -3    matrix is exactly singular (ill conditioned matrices
                        are not recognized).
                * -1    N<=0 was passed
                *  1    task is solved
    B       -   array[N,M]:
                * info>0    =>  overwritten by solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 16.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void cmatrixsolvemfast(complex[,] a, int n, ref complex[,] b, int m, out int info)

info = 
    ;


irectd
    nsesolve
s.cmatrix
olvemfast
    a, n, b, m, r o
    n
ll);
}

public static void cmatrixsolvemfast(complex[,] a, int n, ref complex[,] b, int m, out int info,
    alglib.xparams _params)
{
    n
        o = 0;


    i
        rectd
    e
    sesolvers.cmatr
        xs

    lvemfa
        t(a, n,
            b, m, ref i p
                m
                s
        );
}

/*************************************************************************
Complex dense solver for A*x=B with N*N complex matrix A and  N*1  complex
vectors x and b. "Slow-but-feature-rich" version of the solver.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* iterative refinement
* O(N^3) complexity

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear  system
           ! and  performs  iterative   refinement,   which   results   in
           ! significant performance penalty  when  compared  with  "fast"
           ! version  which  just  performs  LU  decomposition  and  calls
           ! triangular solver.
           !
           ! This  performance  penalty  is  especially  visible  in   the
           ! multithreaded mode, because both condition number  estimation
           ! and   iterative    refinement   are   inherently   sequential
           ! calculations.
           !
           ! Thus, if you need high performance and if you are pretty sure
           ! that your system is well conditioned, we  strongly  recommend
           ! you to use faster solver, CMatrixSolveFast() function.

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void cmatrixsolve(complex[,] a, int n, complex[] b, out int info, out densesolverreport rep,
    out complex[] x)
{
    info
        = 
        ;

    rep =
        new dense
    olverrepo
    t();
    w
        co
    plex
    0];

    c
        d
    nses
        o
    lvers.cmatr
    xsolve
        a, n, b
    ref
        info
        r
    p.innerob
        ,

    r
    f x, nu
    ll
}

public static void cmatrixsolve(complex[,] a, int n, complex[] b, out int info, out densesolverreport rep,
    out complex[] x, alglib.xparams _params)
{
    in
    fo r
    p
    new dens
    sol
        er
    epor
        ();
    x = new complex[0];

    d
        ect o

    vers.c
        atrixsolv
        (a, n,
            b,
            ref i
                fo

    rep
    inn
        rob,
        f x
        _params);
}

/*************************************************************************
Complex dense solver for A*x=B with N*N complex matrix A and  N*1  complex
vectors x and b. "Fast-but-lightweight" version of the solver.

Algorithm features:
* O(N^3) complexity
* no additional time consuming features, just triangular solver

INPUT PARAMETERS:
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS:
    Info    -   return code:
                * -3    matrix is exactly singular (ill conditioned matrices
                        are not recognized).
                * -1    N<=0 was passed
                *  1    task is solved
    B       -   array[N]:
                * info>0    =>  overwritten by solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void cmatrixsolvefast(complex[,] a, int n, ref complex[] b, out int info)


nfo =
    0

directdens
    solvers
cm
    trixso
lv a,
    ef info, n
    ll);

}

public static void cmatrixsolvefast(complex[,] a, int n, ref complex[] b, out int info, alglib.xparams _params)
{
    info
        =
        0


    d
        n
    esolvers.cmatr
        xsolvef

    s
        t
        (a
                n,
            b
            ,
            ref info
            , s

    ;
}

/*************************************************************************
Dense solver for A*X=B with N*N complex A given by its  LU  decomposition,
and N*M matrices X and B (multiple right sides).   "Slow-but-feature-rich"
version of the solver.

Algorithm features:
* automatic detection of degenerate cases
* O(M*N^2) complexity
* condition number estimation

No iterative refinement  is provided because exact form of original matrix
is not known to subroutine. Use CMatrixSolve or CMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which  results  in  significant  performance   penalty   when
           ! compared with "fast"  version  which  just  calls  triangular
           ! solver.
           !
           ! This performance penalty is especially apparent when you  use
           ! ALGLIB parallel capabilities (condition number estimation  is
           ! inherently  sequential).  It   also   becomes significant for
           ! small-scale problems.
           !
           ! In such cases we strongly recommend you to use faster solver,
           ! CMatrixLUSolveMFast() function.

INPUT PARAMETERS
    LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
    P       -   array[0..N-1], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N,M], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void cmatrixlusolvem(complex[,] lua, int[] p, int n, complex[,] b, int m, out int info,
    out densesolverreport rep, out complex[,] x)
{
    info =
        0 =
            new denses
    lverrep
        rt
        );

    x =
        ew comple
        [0, 0];

    directde v
    rs
        cmat
    ixlusolv
    em p,
        b,
        m,
  ref info
        rep.i
        nerobj, 
    ref
        , nu
        l
        )
}

public static void cmatrixlusolvem(complex[,] lua, int[] p, int n, complex[,] b, int m, out int info,
    out densesolverreport rep, out complex[,] x, alglib.xparams _params)
{
    info
        = p
            =
            ew denses
        lve
    re
    ort(
        ;
    x = new complex[0, 0];

    d
        ect o
    vers.c
        atrixluso
    vem(lu
        ,
        , n,
        ,
        , re
            in
    o,
    ep
    nne
        bj,  ref x ,
        _p;
}

/*************************************************************************
Dense solver for A*X=B with N*N complex A given by its  LU  decomposition,
and N*M matrices X and B (multiple  right  sides).  "Fast-but-lightweight"
version of the solver.

Algorithm features:
* O(M*N^2) complexity
* no additional time-consuming features

INPUT PARAMETERS
    LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
    P       -   array[0..N-1], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is exactly singular (ill conditioned matrices
                        are not recognized).
                * -1    N<=0 was passed
                *  1    task is solved
    B       -   array[N,M]:
                * info>0    =>  overwritten by solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void cmatrixlusolvemfast(complex[,] lua, int[] p, int n, ref complex[,] b, int m, out int info)
{
    fo
    0


    dire
        tdenseso c
        at
    ixluso
        le l
        a, p, n, b
    m, ref
    in
    o, nul
        l)
}

public static void cmatrixlusolvemfast(complex[,] lua, int[] p, int n, ref complex[,] b, int m, out int info,
    alglib.xparams _params)
{
    i
    n
        o = 0;


    direct
        de v

    r
        .cmatrixlusolv
        mfast(l
                a
            ,
            p
                n,
            b
            ,
            m, ref i
                nf r
                m
        );
}

/*************************************************************************
Complex dense linear solver for A*x=b with complex N*N A  given  by its LU
decomposition and N*1 vectors x and b. This is  "slow-but-robust"  version
of  the  complex  linear  solver  with  additional  features   which   add
significant performance overhead. Faster version  is  CMatrixLUSolveFast()
function.

Algorithm features:
* automatic detection of degenerate cases
* O(N^2) complexity
* condition number estimation

No iterative refinement is provided because exact form of original matrix
is not known to subroutine. Use CMatrixSolve or CMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which results in 10-15x  performance  penalty  when  compared
           ! with "fast" version which just calls triangular solver.
           !
           ! This performance penalty is insignificant  when compared with
           ! cost of large LU decomposition.  However,  if you  call  this
           ! function many times for the same  left  side,  this  overhead
           ! BECOMES significant. It  also  becomes significant for small-
           ! scale problems.
           !
           ! In such cases we strongly recommend you to use faster solver,
           ! CMatrixLUSolveFast() function.

INPUT PARAMETERS
    LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
    P       -   array[0..N-1], pivots array, CMatrixLU result
    N       -   size of A
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void cmatrixlusolve(complex[,] lua, int[] p, int n, complex[] b, out int info,
    out densesolverreport rep, out complex[] x)

o
0;


r
e
    p
        = new
            denssolverrepor
            ();
com
[
    di
re i
l
    u
e(lua,
        p,
        n, b
    ref
nfo, rep.in
er
    bj,  ref
    x ,  null)
;
}

public static void cmatrixlusolve(complex[,] lua, int[] p, int n, complex[] b, out int info,
    out densesolverreport rep, out complex[] x, alglib.xparams _params)
{
    i
        fo = 0;


    p =
        d
    esolverrep
    rt();


    x =
        new co
    ple
            [0]
        ;
    o
        ver
    s
        .c
    ixlusolve
        lua, p
    n
        b,  ref
        ef
        x, _p
    ams);
}

/*************************************************************************
Complex dense linear solver for A*x=b with N*N complex A given by  its  LU
decomposition and N*1 vectors x and b. This is  fast  lightweight  version
of solver, which is significantly faster than CMatrixLUSolve(),  but  does
not provide additional information (like condition numbers).

Algorithm features:
* O(N^2) complexity
* no additional time-consuming features, just triangular solver

INPUT PARAMETERS
    LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
    P       -   array[0..N-1], pivots array, CMatrixLU result
    N       -   size of A
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is exactly singular (ill conditioned matrices
                        are not recognized).
                * -1    N<=0 was passed
                *  1    task is solved
    B       -   array[N]:
                * info>0    =>  overwritten by solution
                * info=-3   =>  filled by zeros

NOTE: unlike  CMatrixLUSolve(),  this   function   does   NOT   check  for
      near-degeneracy of input matrix. It  checks  for  EXACT  degeneracy,
      because this check is easy to do. However,  very  badly  conditioned
      matrices may went unnoticed.


  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void cmatrixlusolvefast(complex[,] lua, int[] p, int n, ref complex[] b, out int info)
{
    nfo = 0
    d
        esol
    er
        .c s
    t
        a,
        p,
        n,
        b,
        r
    e
        info
    nul);
}

public static void cmatrixlusolvefast(complex[,] lua, int[] p, int n, ref complex[] b, out int info,
        alglib.xparams _params)
    ;


directde
    n
se v
f
    a
u
    a,
 
    ,
    n
b, ref }

/*************************************************************************
Dense solver. Same as RMatrixMixedSolveM(), but for complex matrices.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* iterative refinement
* O(M*N^2) complexity

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
    P       -   array[0..N-1], pivots array, CMatrixLU result
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N,M], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void cmatrixmixedsolvem(complex[,] a, complex[,] lua, int[] p, int n, complex[,] b, int m,
    out int info, out densesolverreport rep, out complex[,] x)
{
    i
    n
        o = 0
            =
            n
    olver
    epor
        ();
    x =
        ew complex[
        r
    denses
        lver
    s. ,
    l
        u, n, b
    m
        ref
    info,
    rep.innerob
        ,
    ef x, n
    ll);
}

public static void cmatrixmixedsolvem(complex[,] a, complex[,] lua, int[] p, int n, complex[,] b, int m,
    out int info, out densesolverreport rep, out complex[,] x, alglib.xparams _params)

i
    re
        = new
            ensesolve
report
    );


0
    ;


directden
    esolve
s.m
a
    trixm,
    n,
    b,
    m,
    ef info,
ep.inn
ro
    j,
    r
ef x,  );
}

/*************************************************************************
Dense solver. Same as RMatrixMixedSolve(), but for complex matrices.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* iterative refinement
* O(N^2) complexity

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
    P       -   array[0..N-1], pivots array, CMatrixLU result
    N       -   size of A
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void cmatrixmixedsolve(complex[,] a, complex[,] lua, int[] p, int n, complex[] b, out int info,
    out densesolverreport rep, out complex[] x)
{
    info
    0;


    rep
    new de r
        )
        = p
        d
    i
        re
    c
        t
    d
        e
    n
        esolv
    rs.catrixmixeds
    lve(a, lua,, re
    f
    rep.in
    erob
        j,  ref x ,  null);
}

public static void cmatrixmixedsolve(complex[,] a, complex[,] lua, int[] p, int n, complex[] b, out int info,
    out densesolverreport rep, out complex[] x, alglib.xparams _params)

ep
    = ne
densesolv
    rre
ort();

x
    =
    n ex[
    directd
nsesol
    v
rs.cmatri
    mixeds
lve
    a,
    lu,
    rep
        .
        in
bj, ref x
    _para
s)


}

/*************************************************************************
Dense solver for A*X=B with N*N symmetric positive definite matrix A,  and
N*M vectors X and B. It is "slow-but-feature-rich" version of the solver.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* O(N^3+M*N^2) complexity
* matrix is represented by its upper or lower triangle

No iterative refinement is provided because such partial representation of
matrix does not allow efficient calculation of extra-precise  matrix-vector
products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which  results  in  significant   performance   penalty  when
           ! compared with "fast" version  which  just  performs  Cholesky
           ! decomposition and calls triangular solver.
           !
           ! This  performance  penalty  is  especially  visible  in   the
           ! multithreaded mode, because both condition number  estimation
           ! and   iterative    refinement   are   inherently   sequential
           ! calculations.
           !
           ! Thus, if you need high performance and if you are pretty sure
           ! that your system is well conditioned, we  strongly  recommend
           ! you to use faster solver, SPDMatrixSolveMFast() function.

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    IsUpper -   what half of A is provided
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or non-SPD.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N,M], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void spdmatrixsolvem(double[,] a, int n, bool isupper, double[,] b, int m, out int info,
    out densesolverreport rep, out double[,] x)
{
    info
    0;

    r
        = new densesolver
    eport()


    x = n b
    e[0, 0];


    ir
        ctden
    so
    ers.
        dma
        ixs

    lv
        m(a, n,
            supp
                r, b, m, n
                o,
            rep.in

    nr e
        x,  null);
}

public static void spdmatrixsolvem(double[,] a, int n, bool isupper, double[,] b, int m, out int info,
    out densesolverreport rep, out double[,] x, alglib.xparams _params)
{
    nfo = 0
        ;

    r
        p = new denses
    lverrep
        r
    t
        ()


    x = ne
    w[
        ,
    ];

    dire
        t
    dense
        s
    lvers.spdmatrix
        ol
    em(a,
        , isupp
    r, b, m, re ,
    p
        .
        in
    ero
        j, 
    ref x , _
    p
        ram
    s
        );
}

/*************************************************************************
Dense solver for A*X=B with N*N symmetric positive definite matrix A,  and
N*M vectors X and B. It is "fast-but-lightweight" version of the solver.

Algorithm features:
* O(N^3+M*N^2) complexity
* matrix is represented by its upper or lower triangle
* no additional time consuming features

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    IsUpper -   what half of A is provided
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is is exactly singular
                * -1    N<=0 was passed
                *  1    task was solved
    B       -   array[N,M], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 17.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void spdmatrixsolvemfast(double[,] a, int n, bool isupper, ref double[,] b, int m, out int info)


i
    o = 0;


di
    ectdens
solve
s.sp
    d
matrixs
lvemfast
    a, n, isupp m i
fo
null);

}

public static void spdmatrixsolvemfast(double[,] a, int n, bool isupper, ref double[,] b, int m, out int info,
    alglib.xparams _params)
{
    n
        o = 0;

    dir
        ct
    enseso
        lv dm o
    vemfast(a,
        n, isup
    er
        b, m, 
    ref info
        _params)
}

/*************************************************************************
Dense linear solver for A*x=b with N*N real  symmetric  positive  definite
matrix A,  N*1 vectors x and b.  "Slow-but-feature-rich"  version  of  the
solver.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* O(N^3) complexity
* matrix is represented by its upper or lower triangle

No iterative refinement is provided because such partial representation of
matrix does not allow efficient calculation of extra-precise  matrix-vector
products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which  results  in  significant   performance   penalty  when
           ! compared with "fast" version  which  just  performs  Cholesky
           ! decomposition and calls triangular solver.
           !
           ! This  performance  penalty  is  especially  visible  in   the
           ! multithreaded mode, because both condition number  estimation
           ! and   iterative    refinement   are   inherently   sequential
           ! calculations.
           !
           ! Thus, if you need high performance and if you are pretty sure
           ! that your system is well conditioned, we  strongly  recommend
           ! you to use faster solver, SPDMatrixSolveFast() function.

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    IsUpper -   what half of A is provided
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or non-SPD.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void spdmatrixsolve(double[,] a, int n, bool isupper, double[] b, out int info,
    out densesolverreport rep, out double[] x)
{
    in
    f
        = 
        ;

    re
        = ne
    den
        s
    esolver
    eport();
    x = ou;

    direc
        ens
    ol

    rs.s
        matrixsolve(a, n,
            supper,
            b,
            ref
                info, r e

    obj, ref
    , null
        ;
}

public static void spdmatrixsolve(double[,] a, int n, bool isupper, double[] b, out int info,
    out densesolverreport rep, out double[] x, alglib.xparams _params)
{
    info =
        rep
    new den
    se r
    p
    rt()
        ;

    x
    new d
    uble[0]


    i
        r
    ctdenseso
        v
    e
    r
        .spdmat
    ri(
        ,
        n, isupper, b,
        ref inf
        ,
        re
            .in
    e
    r
        bj,  ref
        x , m
        )
}

/*************************************************************************
Dense linear solver for A*x=b with N*N real  symmetric  positive  definite
matrix A,  N*1 vectors x and  b.  "Fast-but-lightweight"  version  of  the
solver.

Algorithm features:
* O(N^3) complexity
* matrix is represented by its upper or lower triangle
* no additional time consuming features like condition number estimation

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    IsUpper -   what half of A is provided
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is is exactly singular or non-SPD
                * -1    N<=0 was passed
                *  1    task was solved
    B       -   array[N], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 17.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void spdmatrixsolvefast(double[,] a, int n, bool isupper, ref double[] b, out int info)

info
    =
    di
ectdens
    e
olv
rs.s
    dmatrix
olvef
    s
t(
    , n, isuppe r
f
i
    n,  null)
;

}

public static void spdmatrixsolvefast(double[,] a, int n, bool isupper, ref double[] b, out int info,
    alglib.xparams _params)

info
0;


dir
    td
seso
    ers
pdm
    tr

xsolvefa
    t(a,
        n, isupp
            ef

info,
_a

}

/*************************************************************************
Dense solver for A*X=B with N*N symmetric positive definite matrix A given
by its Cholesky decomposition, and N*M vectors X and B. It  is  "slow-but-
feature-rich" version of the solver which estimates  condition  number  of
the system.

Algorithm features:
* automatic detection of degenerate cases
* O(M*N^2) complexity
* condition number estimation
* matrix is represented by its upper or lower triangle

No iterative refinement is provided because such partial representation of
matrix does not allow efficient calculation of extra-precise  matrix-vector
products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which  results  in  significant  performance   penalty   when
           ! compared with "fast"  version  which  just  calls  triangular
           ! solver. Amount of  overhead  introduced  depends  on  M  (the
           ! larger - the more efficient).
           !
           ! This performance penalty is insignificant  when compared with
           ! cost of large LU decomposition.  However,  if you  call  this
           ! function many times for the same  left  side,  this  overhead
           ! BECOMES significant. It  also  becomes significant for small-
           ! scale problems (N<50).
           !
           ! In such cases we strongly recommend you to use faster solver,
           ! SPDMatrixCholeskySolveMFast() function.

INPUT PARAMETERS
    CHA     -   array[0..N-1,0..N-1], Cholesky decomposition,
                SPDMatrixCholesky result
    N       -   size of CHA
    IsUpper -   what half of CHA is provided
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is is exactly singular or badly conditioned
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task was solved
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N]:
                * for info>0 contains solution
                * for info=-3 filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void spdmatrixcholeskysolvem(double[,] cha, int n, bool isupper, double[,] b, int m, out int info,
    out densesolverreport rep, out double[,] x)

o
    = 0;
rep = new dens
e
    s
lverrepo
r();

x = new do ];


irect
    d
e
    ns
e
    s
o
    l
v
    er
s
    .
    s
    p
d
    atrixcho
eskysolvem(ch
a, ef info, rep.inne
    obj, re l
}

public static void spdmatrixcholeskysolvem(double[,] cha, int n, bool isupper, double[,] b, int m, out int info,
    out densesolverreport rep, out double[,] x, alglib.xparams _params)
{
    in
    fo n
    w
        e
    ol
        er
    eport()


    x
    new
        ouble[0, 0];
    p
        ma
    rixcho
        es
    ysolv
    m(
        ha,
        , isu
    pp r
    p
        .
        r
        ob
    j
    re
        x, _params);
}

/*************************************************************************
Dense solver for A*X=B with N*N symmetric positive definite matrix A given
by its Cholesky decomposition, and N*M vectors X and B. It  is  "fast-but-
lightweight" version of  the  solver  which  just  solves  linear  system,
without any additional functions.

Algorithm features:
* O(M*N^2) complexity
* matrix is represented by its upper or lower triangle
* no additional functionality

INPUT PARAMETERS
    CHA     -   array[N,N], Cholesky decomposition,
                SPDMatrixCholesky result
    N       -   size of CHA
    IsUpper -   what half of CHA is provided
    B       -   array[N,M], right part
    M       -   right part size

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is is exactly singular or badly conditioned
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task was solved
    B       -   array[N]:
                * for info>0 overwritten by solution
                * for info=-3 filled by zeros

  -- ALGLIB --
     Copyright 18.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void spdmatrixcholeskysolvemfast(double[,] cha, int n, bool isupper, ref double[,] b, int m,
    out int info)
{
    info =
        0


    direct
        e
    ses
        l
    v
        rs
    pd
    trixcholeskysolvemfast(cha
        , n, isupper, b, m, ref info, null);
}

public static void spdmatrixcholeskysolvemfast(double[,] cha, int n, bool isupper, ref double[,] b, int m,
    out int info, alglib.xparams _params)
{
    info =
        0;
    di
    ectdensesolves.spdmatri
        choleskysol cha
    i
        per,
        b,
        m,
        ef info,
    _params);
}

/*************************************************************************
Dense solver for A*x=b with N*N symmetric positive definite matrix A given
by its Cholesky decomposition, and N*1 real vectors x and b. This is "slow-
but-feature-rich"  version  of  the  solver  which,  in  addition  to  the
solution, performs condition number estimation.

Algorithm features:
* automatic detection of degenerate cases
* O(N^2) complexity
* condition number estimation
* matrix is represented by its upper or lower triangle

No iterative refinement is provided because such partial representation of
matrix does not allow efficient calculation of extra-precise  matrix-vector
products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which results in 10-15x  performance  penalty  when  compared
           ! with "fast" version which just calls triangular solver.
           !
           ! This performance penalty is insignificant  when compared with
           ! cost of large LU decomposition.  However,  if you  call  this
           ! function many times for the same  left  side,  this  overhead
           ! BECOMES significant. It  also  becomes significant for small-
           ! scale problems (N<50).
           !
           ! In such cases we strongly recommend you to use faster solver,
           ! SPDMatrixCholeskySolveFast() function.

INPUT PARAMETERS
    CHA     -   array[N,N], Cholesky decomposition,
                SPDMatrixCholesky result
    N       -   size of A
    IsUpper -   what half of CHA is provided
    B       -   array[N], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is is exactly singular or ill conditioned
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N]:
                * for info>0  - solution
                * for info=-3 - filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void spdmatrixcholeskysolve(double[,] cha, int n, bool isupper, double[] b, out int info,
    out densesolverreport rep, out double[] x)

f
    = 0;

e
    p
        =
        n
ew or =
    ne
dou
le[0]


di
    ectdenses
lve
s.
    pdm
    trixch
leskys
    ol p
    r, b,  ref info , rep.innero
    b
j
    ref x,
nll);
}

public static void spdmatrixcholeskysolve(double[,] cha, int n, bool isupper, double[] b, out int info,
    out densesolverreport rep, out double[] x, alglib.xparams _params)
{
    =

    rep
        =
        n
    e
        dens
    solvrreport();

    x = le[0

    dir
        ctde
    ns o
    e
        s

    l
        e(
            ha
                n, isu
                per, b,
            ef
                inf
            , rep.innerobj, ref x, _params);
}

/*************************************************************************
Dense solver for A*x=b with N*N symmetric positive definite matrix A given
by its Cholesky decomposition, and N*1 real vectors x and b. This is "fast-
but-lightweight" version of the solver.

Algorithm features:
* O(N^2) complexity
* matrix is represented by its upper or lower triangle
* no additional features

INPUT PARAMETERS
    CHA     -   array[N,N], Cholesky decomposition,
                SPDMatrixCholesky result
    N       -   size of A
    IsUpper -   what half of CHA is provided
    B       -   array[N], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is is exactly singular or ill conditioned
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved
    B       -   array[N]:
                * for info>0  - overwritten by solution
                * for info=-3 - filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void spdmatrixcholeskysolvefast(double[,] cha, int n, bool isupper, ref double[] b, out int info)


info = 0;
directdensesolvers.spdmatrixcholeskysolvefast(cha, n, isupper, b, ref info, null);
}

public static void spdmatrixcholeskysolvefast(double[,] cha, int n, bool isupper, ref double[] b, out int info,
    alglib.xparams _params)
{
    i
        fo = 0
        ;
    direct
        ensesolv
    ers.spd
        a
    t
        r
    i
        x
    c
    oleskysolvefast(
            ha, n, 
        is
        pper, b, re
    i
        fo,
        _para
    s)
}

/*************************************************************************
Dense solver for A*X=B, with N*N Hermitian positive definite matrix A  and
N*M  complex  matrices  X  and  B.  "Slow-but-feature-rich" version of the
solver.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* O(N^3+M*N^2) complexity
* matrix is represented by its upper or lower triangle

No iterative refinement is provided because such partial representation of
matrix does not allow efficient calculation of extra-precise  matrix-vector
products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which  results  in  significant  performance   penalty   when
           ! compared with "fast"  version  which  just  calls  triangular
           ! solver.
           !
           ! This performance penalty is especially apparent when you  use
           ! ALGLIB parallel capabilities (condition number estimation  is
           ! inherently  sequential).  It   also   becomes significant for
           ! small-scale problems (N<100).
           !
           ! In such cases we strongly recommend you to use faster solver,
           ! HPDMatrixSolveMFast() function.

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    IsUpper -   what half of A is provided
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS
    Info    -   same as in RMatrixSolve.
                Returns -3 for non-HPD matrices.
    Rep     -   same as in RMatrixSolve
    X       -   same as in RMatrixSolve

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void hpdmatrixsolvem(complex[,] a, int n, bool isupper, complex[,] b, int m, out int info,
    out densesolverreport rep, out complex[,] x)
{
    info
        = 
        ;

    rep =
        new dense
    olverrepo
    t();
        = ne l
    x[0, 0];

    d
        r
    c
        td
    nsesolv
        e
    s.h
        dmat
    ixsolve
    (a, n
        is
        pper, b, m, n
    o

    r
        .innero
        b, r
    f x, 
    null);
}

public static void hpdmatrixsolvem(complex[,] a, int n, bool isupper, complex[,] b, int m, out int info,
    out densesolverreport rep, out complex[,] x, alglib.xparams _params)
{
    inf


    re
        p = e
    sesolverre
    ort();


    x
        = mp 0
        ;

    irectde
        se
    olvers
        hpdmatri
    solvem(a,
        n, isuppe
        , b, m, ref i e
            .i
    nero
        j,  ref x 
        ,
        s
        ;
}

/*************************************************************************
Dense solver for A*X=B, with N*N Hermitian positive definite matrix A  and
N*M complex matrices X and B. "Fast-but-lightweight" version of the solver.

Algorithm features:
* O(N^3+M*N^2) complexity
* matrix is represented by its upper or lower triangle
* no additional time consuming features like condition number estimation

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    IsUpper -   what half of A is provided
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is is exactly  singular or is not positive definite.
                        B is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved
    B       -   array[0..N-1]:
                * overwritten by solution
                * zeros, if problem was not solved

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 17.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void hpdmatrixsolvemfast(complex[,] a, int n, bool isupper, ref complex[,] b, int m, out int info)

i
    n
o
0;


dir
ctdenss.
    pdma
    rixsolv

mf
    st(a,
        n, er,
        ref
            nfo, nu
            l)

}

public static void hpdmatrixsolvemfast(complex[,] a, int n, bool isupper, ref complex[,] b, int m, out int info,
    alglib.xparams _params)
{
    info =
        0;


    directd
        nsesolve
    s.hpdmatrix fa n
    i
        pper,
        b,
        re
            in
        ,
        _p
    am
        s);
}

/*************************************************************************
Dense solver for A*x=b, with N*N Hermitian positive definite matrix A, and
N*1 complex vectors  x  and  b.  "Slow-but-feature-rich"  version  of  the
solver.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* O(N^3) complexity
* matrix is represented by its upper or lower triangle

No iterative refinement is provided because such partial representation of
matrix does not allow efficient calculation of extra-precise  matrix-vector
products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which  results  in  significant   performance   penalty  when
           ! compared with "fast" version  which  just  performs  Cholesky
           ! decomposition and calls triangular solver.
           !
           ! This  performance  penalty  is  especially  visible  in   the
           ! multithreaded mode, because both condition number  estimation
           ! and   iterative    refinement   are   inherently   sequential
           ! calculations.
           !
           ! Thus, if you need high performance and if you are pretty sure
           ! that your system is well conditioned, we  strongly  recommend
           ! you to use faster solver, HPDMatrixSolveFast() function.

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    IsUpper -   what half of A is provided
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   same as in RMatrixSolve
                Returns -3 for non-HPD matrices.
    Rep     -   same as in RMatrixSolve
    X       -   same as in RMatrixSolve

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void hpdmatrixsolve(complex[,] a, int n, bool isupper, complex[] b, out int info,
        out densesolverreport rep, out complex[] x)
    in

o
0

rep = e
seso
    verrepo
t(
    ;

ne l
x[0]


d
    rectde
sesolver
    .hpdmatri
solve(a,
        , isuppe
        , b
    ref i e
    .innerob
    j,
    ,
    n
l
    l)

}

public static void hpdmatrixsolve(complex[,] a, int n, bool isupper, complex[] b, out int info,
    out densesolverreport rep, out complex[] x, alglib.xparams _params)
{
    info
        = 
        ;

    r e
    densesol
        errepo
    t(
        ;
        = n
        co
    lex
    0]


    dire
        tdenseso h
        dm
    trixso
    le
        supper, b, 
    ref inf 
        ,
        ep.inn
        er ef a
    ams);
}

/*************************************************************************
Dense solver for A*x=b, with N*N Hermitian positive definite matrix A, and
N*1 complex vectors  x  and  b.  "Fast-but-lightweight"  version  of   the
solver without additional functions.

Algorithm features:
* O(N^3) complexity
* matrix is represented by its upper or lower triangle
* no additional time consuming functions

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    IsUpper -   what half of A is provided
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is is exactly singular or not positive definite
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task was solved
    B       -   array[0..N-1]:
                * overwritten by solution
                * zeros, if A is exactly singular (diagonal of its LU
                  decomposition has exact zeros).

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 17.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void hpdmatrixsolvefast(complex[,] a, int n, bool isupper, ref complex[] b, out int info)
{
    i
        f
            =
            0;

    direc
        d
    ensesolv
        rs
    hpd
    atr per, b,  ref i
        fo, 
    null)
}

public static void hpdmatrixsolvefast(complex[,] a, int n, bool isupper, ref complex[] b, out int info,
    alglib.xparams _params)


i
    fo = 0;


d
    rectden
esolv
    r
s.pdmatrixsol(
    ,
    n
    ,
    supper,
    , r
f in
o, _par
    ms);

}

/*************************************************************************
Dense solver for A*X=B with N*N Hermitian positive definite matrix A given
by its Cholesky decomposition and N*M complex matrices X  and  B.  This is
"slow-but-feature-rich" version of the solver which, in  addition  to  the
solution, estimates condition number of the system.

Algorithm features:
* automatic detection of degenerate cases
* O(M*N^2) complexity
* condition number estimation
* matrix is represented by its upper or lower triangle

No iterative refinement is provided because such partial representation of
matrix does not allow efficient calculation of extra-precise  matrix-vector
products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which  results  in  significant  performance   penalty   when
           ! compared with "fast"  version  which  just  calls  triangular
           ! solver. Amount of  overhead  introduced  depends  on  M  (the
           ! larger - the more efficient).
           !
           ! This performance penalty is insignificant  when compared with
           ! cost of large Cholesky decomposition.  However,  if  you call
           ! this  function  many  times  for  the same  left  side,  this
           ! overhead BECOMES significant. It  also   becomes  significant
           ! for small-scale problems (N<50).
           !
           ! In such cases we strongly recommend you to use faster solver,
           ! HPDMatrixCholeskySolveMFast() function.


INPUT PARAMETERS
    CHA     -   array[N,N], Cholesky decomposition,
                HPDMatrixCholesky result
    N       -   size of CHA
    IsUpper -   what half of CHA is provided
    B       -   array[N,M], right part
    M       -   right part size

OUTPUT PARAMETERS:
    Info    -   return code:
                * -3    A is singular, or VERY close to singular.
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task was solved
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N]:
                * for info>0 contains solution
                * for info=-3 filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void hpdmatrixcholeskysolvem(complex[,] cha, int n, bool isupper, complex[,] b, int m, out int info,
    out densesolverreport rep, out complex[,] x)
{
    info
    0;


    s
        lverrepo
    t();

    x = ne
    w
        co
    lex[
    ];

    directdens r
    xch
        lesky
    s
    olvem
        cha,
        n,
        s
    u
        p
    pe
        r, r f
        x, 
    null
        ;
}

public static void hpdmatrixcholeskysolvem(complex[,] cha, int n, bool isupper, complex[,] b, int m, out int info,
    out densesolverreport rep, out complex[,] x, alglib.xparams _params)

info = 0;

re d
v
    epor
()

new co
p
        [0, 0
    ;


d
    re
tdensesol m
o
    kysol
v
    e
m
(
    c
h
    , n,
suppe
    o
ep.in
erob
    , re x, _params
    ;
}

/*************************************************************************
Dense solver for A*X=B with N*N Hermitian positive definite matrix A given
by its Cholesky decomposition and N*M complex matrices X  and  B.  This is
"fast-but-lightweight" version of the solver.

Algorithm features:
* O(M*N^2) complexity
* matrix is represented by its upper or lower triangle
* no additional time-consuming features

INPUT PARAMETERS
    CHA     -   array[N,N], Cholesky decomposition,
                HPDMatrixCholesky result
    N       -   size of CHA
    IsUpper -   what half of CHA is provided
    B       -   array[N,M], right part
    M       -   right part size

OUTPUT PARAMETERS:
    Info    -   return code:
                * -3    A is singular, or VERY close to singular.
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task was solved
    B       -   array[N]:
                * for info>0 overwritten by solution
                * for info=-3 filled by zeros

  -- ALGLIB --
     Copyright 18.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void hpdmatrixcholeskysolvemfast(complex[,] cha, int n, bool isupper, ref complex[,] b, int m,
    out int info)
{
    info = 0
        ;

    ec nsesol ve rs.h pd ma tr x
        h
    o
        kysolv
    e
        f

    a
        t
        (
            su r,
            b, , ref i
                fo,
            n
                u
                l);
}

public static void hpdmatrixcholeskysolvemfast(complex[,] cha, int n, bool isupper, ref complex[,] b, int m,
    out int info, alglib.xparams _params)
{
    in
    o =
        0;

    directdense
        olv
    r
    s
        .
        pdmatri
        cholesky
    o
        emf
    t
    (
        a, n
    isupper, b, m, ref info, _pa
        ams);
}

/*************************************************************************
Dense solver for A*x=b with N*N Hermitian positive definite matrix A given
by its Cholesky decomposition, and N*1 complex vectors x and  b.  This  is
"slow-but-feature-rich" version of the solver  which  estimates  condition
number of the system.

Algorithm features:
* automatic detection of degenerate cases
* O(N^2) complexity
* condition number estimation
* matrix is represented by its upper or lower triangle

No iterative refinement is provided because such partial representation of
matrix does not allow efficient calculation of extra-precise  matrix-vector
products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which results in 10-15x  performance  penalty  when  compared
           ! with "fast" version which just calls triangular solver.
           !
           ! This performance penalty is insignificant  when compared with
           ! cost of large LU decomposition.  However,  if you  call  this
           ! function many times for the same  left  side,  this  overhead
           ! BECOMES significant. It  also  becomes significant for small-
           ! scale problems (N<50).
           !
           ! In such cases we strongly recommend you to use faster solver,
           ! HPDMatrixCholeskySolveFast() function.

INPUT PARAMETERS
    CHA     -   array[0..N-1,0..N-1], Cholesky decomposition,
                SPDMatrixCholesky result
    N       -   size of A
    IsUpper -   what half of CHA is provided
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is is exactly singular or ill conditioned
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N]:
                * for info>0  - solution
                * for info=-3 - filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void hpdmatrixcholeskysolve(complex[,] cha, int n, bool isupper, complex[] b, out int info,
    out densesolverreport rep, out complex[] x)
{
    nfo =
        0;
    rep =
        w dense
        s
    ve
        rep
    t();
    e
        [0];


    irect
        ens
    sol
    ers.
        dmat
        xcho
    l
        kyso
    e(cha, n, f
    info, r
    p.innerobj,

    ef
        , nu
        );
}

public static void hpdmatrixcholeskysolve(complex[,] cha, int n, bool isupper, complex[] b, out int info,
    out densesolverreport rep, out complex[] x, alglib.xparams _params)
{
    info
        =
        0;

    rep = new
            densesolver;
        = new
        c
    om
        p
    l
        e
    x
        [
            0]
        ;


    dire

    tdensesolvers
        .h e(cha, n, isupper
            b, ref e
            o

    ref
        x ,
        _p
}

/*************************************************************************
Dense solver for A*x=b with N*N Hermitian positive definite matrix A given
by its Cholesky decomposition, and N*1 complex vectors x and  b.  This  is
"fast-but-lightweight" version of the solver.

Algorithm features:
* O(N^2) complexity
* matrix is represented by its upper or lower triangle
* no additional time-consuming features

INPUT PARAMETERS
    CHA     -   array[0..N-1,0..N-1], Cholesky decomposition,
                SPDMatrixCholesky result
    N       -   size of A
    IsUpper -   what half of CHA is provided
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is is exactly singular or ill conditioned
                        B is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved
    B       -   array[N]:
                * for info>0  - overwritten by solution
                * for info=-3 - filled by zeros

  -- ALGLIB --
     Copyright 18.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void hpdmatrixcholeskysolvefast(complex[,] cha, int n, bool isupper, ref complex[] b, out int info)
    in
    =

;


rec
    d
nses lvers.hpdmatrixch
    o
l
    e
c
    a,
    is upp er, b, r ef
    in f
}

public static void hpdmatrixcholeskysolvefast(complex[,] cha, int n, bool isupper, ref complex[] b, out int info,
    alglib.xparams _params)
{
    i
        n
    f
        o
            =
            0
        ;


    d
        i
    r
        e
    c
        t
    d
        e
    n
        s
    e
        s
    o
    lvers.hpdma
        rixcho
    esk
        s
    o
        l
    v
        e
    ast(
        h
    a
        ,
    n, isuppe
        , b, ref
    info, _p
        rams);
}

/*************************************************************************
Dense solver.

This subroutine finds solution of the linear system A*X=B with non-square,
possibly degenerate A.  System  is  solved in the least squares sense, and
general least squares solution  X = X0 + CX*y  which  minimizes |A*X-B| is
returned. If A is non-degenerate, solution in the usual sense is returned.

Algorithm features:
* automatic detection (and correct handling!) of degenerate cases
* iterative refinement
* O(N^3) complexity

INPUT PARAMETERS
    A       -   array[0..NRows-1,0..NCols-1], system matrix
    NRows   -   vertical size of A
    NCols   -   horizontal size of A
    B       -   array[0..NCols-1], right part
    Threshold-  a number in [0,1]. Singular values  beyond  Threshold  are
                considered  zero.  Set  it to 0.0, if you don't understand
                what it means, so the solver will choose good value on its
                own.

OUTPUT PARAMETERS
    Info    -   return code:
                * -4    SVD subroutine failed
                * -1    if NRows<=0 or NCols<=0 or Threshold<0 was passed
                *  1    if task is solved
    Rep     -   solver report, see below for more info
    X       -   array[0..N-1,0..M-1], it contains:
                * solution of A*X=B (even for singular A)
                * zeros, if SVD subroutine failed

SOLVER REPORT

Subroutine sets following fields of the Rep structure:
* R2        reciprocal of condition number: 1/cond(A), 2-norm.
* N         = NCols
* K         dim(Null(A))
* CX        array[0..N-1,0..K-1], kernel of A.
            Columns of CX store such vectors that A*CX[i]=0.

  ! FREE EDITION OF ALGLIB:
  !
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 24.08.2009 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixsolvels(double[,] a, int nrows, int ncols, double[] b, double threshold, out int info,
    out densesolverlsreport rep, out double[] x)
{
    info = 0;


    rep =
        new de
    n
        e
    s
        olve
    r
        l
    s
        r
    p
        o
    rt()
        ;


    d
    uble[0];


    tde
        n
    seso
        l
    v
        e
    rs.rmat
    ix
        a, nr
    o
    w
        s,
        n
    c
        o
    l
        s,
        b,
        t
    reshol
        ,
    e
    f bj,  ref
        x ,
        nu
    l);
}

public static void rmatrixsolvels(double[,] a, int nrows, int ncols, double[] b, double threshold, out int info,
    out densesolverlsreport rep, out double[] x, alglib.xparams _params)
{
    inf
        = 
        ;
    r e

    e
        n
    solverl
        s
    epo
    t();

    x = n
    w do
        u
    ble[0];

    irectdenses.r s

    lv
        s(a, nrow
            nc

    s,
        , th
        shold,  ref info , r
    p.inner
        bj
    re
        x, _pa
}
}

public partial class alglib
{
    /*************************************************************************
    This structure is a sparse solver report (both direct and iterative solvers
    use this structure).

    Following fields can be accessed by users:
    * TerminationType (specific error codes depend on the solver  being  used,
      with positive values ALWAYS signaling  that something useful is returned
      in X, and negative values ALWAYS meaning critical failures.
    * NMV - number of matrix-vector products performed (0 for direct solvers)
    * IterationsCount - inner iterations count (0 for direct solvers)
    * R2 - squared residual
    *************************************************************************/
    public class sparsesolverreport : alglibobject
    {
        //
        // Public declarations
        //
        public int terminationtype
        {
            get
            {
                retu
                    n _innerobj.te
                    r
                minati
                    o
                n
                    t
                p
                    e
            }
            set
            {
                _
                    nne
                obj.t
                    e
                minati
                    o
                n
                y
                    p
                        = val
                e;
            }
        }

        public int nmv
        {
            get
            {
                return _in
                ero
                b
                    .nm
                    ;
            }
            set
            {
                _i oj alue
            }
        }

        public int iterationscount
        {
            get
            {
                r tu rn _
                i
                    nn e
                    t;
            }
            set
            {
                ions co unt = v al ue;
            }
        }

        public double r2
        {
            get
            {
                re tu r
                    n
                nn e
                j. 2;
            }
            set
            in n
            robj
            .
            2 =

            value;
        }
    }

    public sparsesolverreport()
    {
        _inne
            r
        o
            b
                =
                new
                    direc
        t
            par
        esolv
            e
        s.spar
            s
        e
            o
        l
            errepo
        t();
    }

    public override alglib.alglibobject make_copy()
    {
        new
            r
        olverreport((
            i
        ec
            se so ers.spar se olve r
        e
            p
        o
            j
        m
            ke c
        py()) ;
    }

    //
    // Although some of declarations below are public, you should not use them
    // They are intended for internal use only
    //
    private directsparsesolvers.sparsesolverreport _innerobj;

    public directsparsesolvers.sparsesolverreport innerobj
    {
        get
        {
            re
                urn
            _innerobj
        }
    }

    public sparsesolverreport(directsparsesolvers.sparsesolverreport obj)
    {
        _innero
            j = o
        j;
    }
}

/*************************************************************************
Sparse linear solver for A*x=b with N*N  sparse  real  symmetric  positive
definite matrix A, N*1 vectors x and b.

This solver  converts  input  matrix  to  SKS  format,  performs  Cholesky
factorization using  SKS  Cholesky  subroutine  (works  well  for  limited
bandwidth matrices) and uses sparse triangular solvers to get solution  of
the original system.

INPUT PARAMETERS
    A       -   sparse matrix, must be NxN exactly
    IsUpper -   which half of A is provided (another half is ignored)
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    X       -   array[N], it contains:
                * rep.terminationtype>0    =>  solution
                * rep.terminationtype=-3   =>  filled by zeros
    Rep     -   solver report, following fields are set:
                * rep.terminationtype - solver status; >0 for success,
                  set to -3 on failure (degenerate or non-SPD system).

  -- ALGLIB --
     Copyright 26.12.2017 by Bochkanov Sergey
*************************************************************************/
public static void sparsespdsolvesks(sparsematrix a, bool isupper, double[] b, out double[] x,
    out sparsesolverreport rep)
{
    = new doubl
        [0];


    rep
        ne
    spars
        sol
    err
    port(directsparsesolvers.sparsespdsolvesks(a., i b, ref
        , rep.innerobj, nul
    l
        );
}

public static void sparsespdsolvesks(sparsematrix a, bool isupper, double[] b, out double[] x,
    out sparsesolverreport rep, alglib.xparams _params)
{
    x =
        new double[0];


    r
    ort();


    i
        r
    olvers.parsespdsolvesks(a.innerobj, isupper, b, ref x, rep.innerobj, _params);
}

/*************************************************************************
Sparse linear solver for A*x=b with N*N  sparse  real  symmetric  positive
definite matrix A, N*1 vectors x and b.

This solver  converts  input  matrix  to  CRS  format,  performs  Cholesky
factorization using supernodal Cholesky  decomposition  with  permutation-
reducing ordering and uses sparse triangular solver to get solution of the
original system.

INPUT PARAMETERS
    A       -   sparse matrix, must be NxN exactly
    IsUpper -   which half of A is provided (another half is ignored)
    B       -   array[N], right part

OUTPUT PARAMETERS
    X       -   array[N], it contains:
                * rep.terminationtype>0    =>  solution
                * rep.terminationtype=-3   =>  filled by zeros
    Rep     -   solver report, following fields are set:
                * rep.terminationtype - solver status; >0 for success,
                  set to -3 on failure (degenerate or non-SPD system).

  -- ALGLIB --
     Copyright 26.12.2017 by Bochkanov Sergey
*************************************************************************/
public static void sparsespdsolve(sparsematrix a, bool isupper, double[] b, out double[] x,
    out sparsesolverreport rep)
{
    x ouble[0];
    r
    e
        p = new sparsesol
    v
        e
    r
    report()
        ;


    i
        r
    cts
        s
    sol
        v
    ers.spar
        s
    spds ol v
        e(a.innrobj, isupp
                r, b,
            ef x

    rep.innerobj, nu
        l
    l);
}

public static void sparsespdsolve(sparsematrix a, bool isupper, double[] b, out double[] x,
    out sparsesolverreport rep, alglib.xparams _params)
{
    oub l[
        r
    ep = new sparseso
    l
        v
    e
    rreport(
    )


    d
        i
    ect
        p
    a
        ses
    o
    lvers.sp
        a
    sespdso
        l
    ve(a.inerobj, isupper, b, ref x, rep.innerobj, _params);
}

/*************************************************************************
Sparse linear solver for A*x=b with N*N real  symmetric  positive definite
matrix A given by its Cholesky decomposition, and N*1 vectors x and b.

IMPORTANT: this solver requires input matrix to be in  the  SKS  (Skyline)
           or CRS (compressed row storage) format. An  exception  will  be
           generated if you pass matrix in some other format.

INPUT PARAMETERS
    A       -   sparse NxN matrix stored in CRs or SKS format, must be NxN
                exactly
    IsUpper -   which half of A is provided (another half is ignored)
    B       -   array[N], right part

OUTPUT PARAMETERS
    X       -   array[N], it contains:
                * rep.terminationtype>0    =>  solution
                * rep.terminationtype=-3   =>  filled by zeros
    Rep     -   solver report, following fields are set:
                * rep.terminationtype - solver status; >0 for success,
                  set to -3 on failure (degenerate or non-SPD system).

  -- ALGLIB --
     Copyright 26.12.2017 by Bochkanov Sergey
*************************************************************************/
public static void sparsespdcholeskysolve(sparsematrix a, bool isupper, double[] b, out double[] x,
    out sparsesolverreport rep)
{
    x =
        n
    e
        w
    double[
            0
        ;


    r
        e
    n
        w ars
        e
    solverre
        p
    rt();


    irectsparse
        olvers
    spar
        espdcholeskyso

    l
        ve(a.innerob
            ,
            supp
                r, b, r
                e

    x, re
    p
        .n
    n
        rob,  null
        )
    ;
}

public static void sparsespdcholeskysolve(sparsematrix a, bool isupper, double[] b, out double[] x,
    out sparsesolverreport rep, alglib.xparams _params)
{
    x = ne w
        d
    o
        u
    ble[0];


    r
        e
            =
            new
                s
    p
        rse
    s
        olverrep
    o
    t();


    diectsparsesolvers.sparsespdcholeskysolve(a.innerobj, isupper, b, ref x, rep.innerobj, _params);
}

/*************************************************************************
Sparse linear solver for A*x=b with general (nonsymmetric) N*N sparse real
matrix A, N*1 vectors x and b.

This solver converts input matrix to CRS format, performs LU factorization
and uses sparse triangular solvers to get solution of the original system.

INPUT PARAMETERS
    A       -   sparse matrix, must be NxN exactly, any storage format
    N       -   size of A, N>0
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    X       -   array[N], it contains:
                * rep.terminationtype>0    =>  solution
                * rep.terminationtype=-3   =>  filled by zeros
    Rep     -   solver report, following fields are set:
                * rep.terminationtype - solver status; >0 for success,
                  set to -3 on failure (degenerate system).

  -- ALGLIB --
     Copyright 26.12.2017 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolve(sparsematrix a, double[] b, out double[] x, out sparsesolverreport rep)
{
    x
        =
        new double[
        ]
        ;

    rep
        =
        new sp
    a
        r
    e
        s
    lve
        report
    (
        )


    directsparsesolv
    rs.
        sparseso n
    rb j, b, ef x,
    re p.n
        l) ;
}

public static void sparsesolve(sparsematrix a, double[] b, out double[] x, out sparsesolverreport rep,
    alglib.xparams _params)
{
    duble[0];

    r
        p =
            ew sparsesolverreport(
        )
        ;
    di
        e
    c
        spar
    esolver
        s
    sparse
        s
    o
        v
    e
    a.i
        nerobj,
 
        ,
        ef,
        rep.innerobj, _p
    ram
        s
        ;
}

/*************************************************************************
Sparse linear solver for A*x=b with general (nonsymmetric) N*N sparse real
matrix A given by its LU factorization, N*1 vectors x and b.

IMPORTANT: this solver requires input matrix  to  be  in  the  CRS  sparse
           storage format. An exception will  be  generated  if  you  pass
           matrix in some other format (HASH or SKS).

INPUT PARAMETERS
    A       -   LU factorization of the sparse matrix, must be NxN exactly
                in CRS storage format
    P, Q    -   pivot indexes from LU factorization
    N       -   size of A, N>0
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    X       -   array[N], it contains:
                * rep.terminationtype>0    =>  solution
                * rep.terminationtype=-3   =>  filled by zeros
    Rep     -   solver report, following fields are set:
                * rep.terminationtype - solver status; >0 for success,
                  set to -3 on failure (degenerate system).

  -- ALGLIB --
     Copyright 26.12.2017 by Bochkanov Sergey
*************************************************************************/
public static void sparselusolve(sparsematrix a, int[] p, int[] q, double[] b, out double[] x,
    out sparsesolverreport rep)
{
    wd ou le[
    ];

    r
        arss ol err
    por t();
    d rectspa rs e
    lusolve(a.innerob,
        p, q, b, ref
        x
        ,
        rep.nne
    r
        b
    j
        nu
    l
        )
}

public static void sparselusolve(sparsematrix a, int[] p, int[] q, double[] b, out double[] x,
    out sparsesolverreport rep, alglib.xparams _params)

x
    =
    n
e
    ];


ep = new sparsesol
ve rr ep d rects arsesolv er.sparse lu so ve(a i
n
ne obj,
    p,
 
    ,
    x
e
    .in
n
    erobj, _
p
    ram );
}
}

public partial class alglib
{
    /*************************************************************************
    This object stores state of the sparse linear solver object.

    You should use ALGLIB functions to work with this object.
    Never try to access its fields directly!
    *************************************************************************/
    public class sparsesolverstate : alglibobject
    {
        //
        // Public declarations
        //

        public sparsesolverstate()
        {
            _in
                erobj = sp
            rse
                olverst
            te();
        }

        public override alglib.alglibobject make_copy()
        {
            retu
                s
            sesol
                v
            e
                rs
            t
                a

            t
                e
                (
                    itera
                        ivesa sparse
                        olverstate)

            _innerobj
                o
                ));
        }

        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private iterativesparse.sparsesolverstate _innerobj;

        public iterativesparse.sparsesolverstate innerobj
        {
            get _i
            ne
            o
            b
            ;
        }
    }

    public sparsesolverstate(iterativesparse.sparsesolverstate obj)
    {
        _i o
        b
            j
                =
                o
        b
            j
            ;
    }
}

/*************************************************************************
Solving sparse symmetric linear system A*x=b using GMRES(k) method. Sparse
symmetric A is given by its lower or upper triangle.

NOTE: use SparseSolveGMRES() to solve system with nonsymmetric A.

This function provides convenience API for an 'expert' interface  provided
by SparseSolverState class. Use SparseSolver  API  if  you  need  advanced
functions like providing initial point, using out-of-core API and so on.

INPUT PARAMETERS:
    A       -   sparse symmetric NxN matrix in any sparse storage  format.
                Using CRS format is recommended because it avoids internal
                conversion.
                An exception will be generated if  A  is  not  NxN  matrix
                (where  N  is  a  size   specified  during  solver  object
                creation).
    IsUpper -   whether upper or lower triangle of A is used:
                * IsUpper=True  => only upper triangle is used and lower
                                   triangle is not referenced at all
                * IsUpper=False => only lower triangle is used and upper
                                   triangle is not referenced at all
    B       -   right part, array[N]
    K       -   k parameter for  GMRES(k), k>=0.  Zero  value  means  that
                algorithm will choose it automatically.
    EpsF    -   stopping condition, EpsF>=0. The algorithm will stop  when
                residual will decrease below EpsF*|B|. Having EpsF=0 means
                that this stopping condition is ignored.
    MaxIts  -   stopping condition, MaxIts>=0.  The  algorithm  will  stop
                after performing MaxIts iterations. Zero  value  means  no
                limit.

NOTE: having both EpsF=0 and MaxIts=0 means that stopping criteria will be
      chosen automatically.

OUTPUT PARAMETERS:
    X       -   array[N], the solution
    Rep     -   solution report:
                * Rep.TerminationType completion code:
                    * -5    CG method was used for a matrix which  is  not
                            positive definite
                    * -4    overflow/underflow during solution
                            (ill conditioned problem)
                    *  1    ||residual||<=EpsF*||b||
                    *  5    MaxIts steps was taken
                    *  7    rounding errors prevent further progress,
                            best point found is returned
                    *  8    the  algorithm  was  terminated   early  with
                            SparseSolverRequestTermination() being called
                            from other thread.
                * Rep.IterationsCount contains iterations count
                * Rep.NMV contains number of matrix-vector calculations
                * Rep.R2 contains squared residual

  -- ALGLIB --
     Copyright 25.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolvesymmetricgmres(sparsematrix a, bool isupper, double[] b, int k, double epsf,
    int maxits, out double[] x, out sparsesolverreport rep)
{
    x
    new double[0
    ];
    rep
        e
    parsesol
    erreport(
    )


    ite
        ativespar
    e.sp
        rses
    vesym bj, isup
    er,
        , k, eps
        , max
        ts,
        r
    e
        f

    x
    rep.i
        nero
    b
        j
    null);
}

public static void sparsesolvesymmetricgmres(sparsematrix a, bool isupper, double[] b, int k, double epsf,
    int maxits, out double[] x, out sparsesolverreport rep, alglib.xparams _params)
{
    x
        ep = new
            s
    arseso
        verr
    port
    (
    )


    i
        t
    e
        ative
    pars
        .sparses
        lvesymme
    ricg
    res j, isu
    per, b, k, ep
        s, maxits, r
    f x, rep.i
        nn p
}

/*************************************************************************
Solving sparse linear system A*x=b using GMRES(k) method.

This function provides convenience API for an 'expert' interface  provided
by SparseSolverState class. Use SparseSolver  API  if  you  need  advanced
functions like providing initial point, using out-of-core API and so on.

INPUT PARAMETERS:
    A       -   sparse NxN matrix in any sparse storage format. Using  CRS
                format   is   recommended   because   it  avoids  internal
                conversion.
                An exception will be generated if  A  is  not  NxN  matrix
                (where  N  is  a  size   specified  during  solver  object
                creation).
    B       -   right part, array[N]
    K       -   k parameter for  GMRES(k), k>=0.  Zero  value  means  that
                algorithm will choose it automatically.
    EpsF    -   stopping condition, EpsF>=0. The algorithm will stop  when
                residual will decrease below EpsF*|B|. Having EpsF=0 means
                that this stopping condition is ignored.
    MaxIts  -   stopping condition, MaxIts>=0.  The  algorithm  will  stop
                after performing MaxIts iterations. Zero  value  means  no
                limit.

NOTE: having both EpsF=0 and MaxIts=0 means that stopping criteria will be
      chosen automatically.

OUTPUT PARAMETERS:
    X       -   array[N], the solution
    Rep     -   solution report:
                * Rep.TerminationType completion code:
                    * -5    CG method was used for a matrix which  is  not
                            positive definite
                    * -4    overflow/underflow during solution
                            (ill conditioned problem)
                    *  1    ||residual||<=EpsF*||b||
                    *  5    MaxIts steps was taken
                    *  7    rounding errors prevent further progress,
                            best point found is returned
                    *  8    the  algorithm  was  terminated   early  with
                            SparseSolverRequestTermination() being called
                            from other thread.
                * Rep.IterationsCount contains iterations count
                * Rep.NMV contains number of matrix-vector calculations
                * Rep.R2 contains squared residual

  -- ALGLIB --
     Copyright 25.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolvegmres(sparsematrix a, double[] b, int k, double epsf, int maxits, out double[] x,
    out sparsesolverreport rep)
{
    x
    new
        ouble
        ];

    r rreport()


    it
        ra
    ivesparse.spa
        rs res(
        n
    bj, b, k
        epsf, ma
    x
        ts,
        re
    f
        , r
    p.innerob
        , nu
        l);
}

public static void sparsesolvegmres(sparsematrix a, double[] b, int k, double epsf, int maxits, out double[] x,
    out sparsesolverreport rep, alglib.xparams _params)
{
    x
        =
        w d
    ble[0];


    ep = rt();
    it
        rative
    parse.spar
        s

    solv
        mres(
            inner
                j, ref x
            , rep.inner
                o

    j, _pa
        ams)
}

/*************************************************************************
This function initializes sparse linear iterative solver object.

This solver can be used  to  solve  nonsymmetric  and  symmetric  positive
definite NxN (square) linear systems.

The solver provides  'expert'  API  which  allows  advanced  control  over
algorithms being used, including ability to get progress report, terminate
long-running solver from other thread, out-of-core solution and so on.

NOTE: there are also convenience  functions  that  allows  quick  one-line
      access to the solvers:
      * SparseSolveCG() to solve SPD linear systems
      * SparseSolveGMRES() to solve unsymmetric linear systems.

NOTE: if you want to solve MxN (rectangular) linear problem  you  may  use
      LinLSQR solver provided by ALGLIB.

USAGE (A is given by the SparseMatrix structure):

    1. User initializes algorithm state with SparseSolverCreate() call
    2. User  selects   algorithm  with one of the SparseSolverSetAlgo???()
       functions. By default, GMRES(k) is used with automatically chosen k
    3. Optionally, user tunes solver parameters, sets starting point, etc.
    4. Depending on whether system is symmetric or not, user calls:
       * SparseSolverSolveSymmetric() for a  symmetric system given by its
         lower or upper triangle
       * SparseSolverSolve() for a nonsymmetric system or a symmetric  one
         given by the full matrix
    5. User calls SparseSolverResults() to get the solution

    It is possible to call SparseSolverSolve???() again to  solve  another
    task with same dimensionality but different matrix and/or  right  part
    without reinitializing SparseSolverState structure.

USAGE (out-of-core mode):

    1. User initializes algorithm state with SparseSolverCreate() call
    2. User  selects   algorithm  with one of the SparseSolverSetAlgo???()
       functions. By default, GMRES(k) is used with automatically chosen k
    3. Optionally, user tunes solver parameters, sets starting point, etc.
    4. After that user should work with out-of-core interface  in  a  loop
       like one given below:

        > alglib.sparsesolveroocstart(state)
        > while alglib.sparsesolverooccontinue(state) do
        >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
        >     alglib.sparsesolveroocgetrequestdata(state, out X)
        >     if RequestType=0 then
        >         [calculate  Y=A*X, with X=R^N]
        >     alglib.sparsesolveroocsendresult(state, in Y)
        > alglib.sparsesolveroocstop(state, out X, out Report)

INPUT PARAMETERS:
    N       -   problem dimensionality (fixed at start-up)

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolvercreate(int n, out sparsesolverstate state)
{
    s
        ate =
            ew o
        l
    erstate();


    ite
        atives
    arse.spars
        e

    olve
        create(n
            stat
            e
            inn
            er l
        )
}

public static void sparsesolvercreate(int n, out sparsesolverstate state, alglib.xparams _params)
{
    stat
        =
        new tate(
        ;


    iterativ r
    esolvercreate(n,
        s
    t
    te.
        n
        erobj, _para
    s);
}

/*************************************************************************
This function sets the solver algorithm to GMRES(k).

NOTE: if you do not need advanced functionality of the  SparseSolver  API,
      you   may   use   convenience   functions   SparseSolveGMRES()   and
      SparseSolveSymmetricGMRES().

INPUT PARAMETERS:
    State   -   structure which stores algorithm state
    K       -   GMRES parameter, K>=0:
                * recommended values are in 10..100 range
                * larger values up to N are possible but have little sense
                  - the algorithm will be slower than any dense solver.
                * values above N are truncated down to N
                * zero value means that  default  value  is  chosen.  This
                  value is 50 in the current version, but  it  may  change
                  in future ALGLIB releases.

  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolversetalgogmres(sparsesolverstate state, int k)
{
    itera
        t
    ve
        p
    ar v
    rsetal
        g
    ogmres(state.innero
    b
        j,
        k,
        ull
        ;
}

public static void sparsesolversetalgogmres(sparsesolverstate state, int k, alglib.xparams _params)
{
    it
        t
    sparse.sp
        rseso
    verset
    lgogmres(
        tate.n,
        , _par
    ms);
}

/*************************************************************************
This function sets starting point.
By default, zero starting point is used.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state
    X       -   starting point, array[N]

OUTPUT PARAMETERS:
    State   -   new starting point was set

  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolversetstartingpoint(sparsesolverstate state, double[] x)
{
    i
        t
    e
        r
    a
        t
    i
        v
    e
        s
    p
        a
    r
        s
    e
        .
        s
        p
    a
        r
    s
        e
    s
        o
    l
        v
    e
        r
    s
        e
    t
        s
    t
        a
    r
        t

    i
        ngpoint(st
            te.

    inner
        bj,
 
        ,
        n
    ll);
}

public static void sparsesolversetstartingpoint(sparsesolverstate state, double[] x, alglib.xparams _params)
{
    i
        ativespar
    sparsesolversets
        t
    a
    ngpo innerobj, x, _params);
}

/*************************************************************************
This function sets stopping criteria.

INPUT PARAMETERS:
    EpsF    -   algorithm will be stopped if norm of residual is less than
                EpsF*||b||.
    MaxIts  -   algorithm will be stopped if number of iterations is  more
                than MaxIts.

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

NOTES:
If  both  EpsF  and  MaxIts  are  zero then small EpsF will be set to small
value.

  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolversetcond(sparsesolverstate state, double epsf, int maxits)
{
    itera
        ivesp
    a
    se.p
    arsesol
        .inner ob, e sf , ma
    x
        its,  null);
}

public static void sparsesolversetcond(sparsesolverstate state, double epsf, int maxits, alglib.xparams _params)
{
    ite
        ativesp

    arse.sp
        nd(te nerobj
            ,
            ep f, max ts, _pa ams);
}

/*************************************************************************
Procedure for  the  solution of A*x=b with sparse symmetric A given by its
lower or upper triangle.

This function will work with any solver algorithm  being   used,  SPD  one
(like CG) or not (like GMRES). Using unsymmetric solvers (like  GMRES)  on
SPD problems is suboptimal, but still possible.

NOTE: the  solver  behavior is ill-defined  for  a  situation  when a  SPD
      solver is used on indefinite matrix. It  may solve the problem up to
      desired precision (sometimes, rarely)  or  return  with  error  code
      signalling violation of underlying assumptions.

INPUT PARAMETERS:
    State   -   algorithm state
    A       -   sparse symmetric NxN matrix in any sparse storage  format.
                Using CRS format is recommended because it avoids internal
                conversion.
                An exception will be generated if  A  is  not  NxN  matrix
                (where  N  is  a  size   specified  during  solver  object
                creation).
    IsUpper -   whether upper or lower triangle of A is used:
                * IsUpper=True  => only upper triangle is used and lower
                                   triangle is not referenced at all
                * IsUpper=False => only lower triangle is used and upper
                                   triangle is not referenced at all
    B       -   right part, array[N]

RESULT:
    This function returns no result.
    You can get the solution by calling SparseSolverResults()

  -- ALGLIB --
     Copyright 25.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolversolvesymmetric(sparsesolverstate state, sparsematrix a, bool isupper, double[] b)
{
    iterativespar
    e.spa
        r
    esolve
        solv
    e
        ymm
    tric(s
    t
    te.inn
    e
        robj, a
    innerob
        j, isup
}

public static void sparsesolversolvesymmetric(sparsesolverstate state, sparsematrix a, bool isupper, double[] b,
    alglib.xparams _params)
{
    iterativ
        spa
    e.s
        rsesolve
    so
        v
    e
        s
    y
        m
    etri
        (state
    innerobj,
    a
        inner
    bj
        isupper,
        b,
        pa
    ams);
}

/*************************************************************************
Procedure for the solution of A*x=b with sparse nonsymmetric A

IMPORTANT: this function will work with any solver algorithm  being  used,
           symmetric solver like CG,  or  not.  However,  using  symmetric
           solvers on nonsymmetric problems is  dangerous.  It  may  solve
           the problem up  to  desired  precision  (sometimes,  rarely) or
           terminate with error code signalling  violation  of  underlying
           assumptions.

INPUT PARAMETERS:
    State   -   algorithm state
    A       -   sparse NxN matrix in any sparse storage  format.
                Using CRS format is recommended because it avoids internal
                conversion.
                An exception will be generated if  A  is  not  NxN  matrix
                (where  N  is  a  size   specified  during  solver  object
                creation).
    B       -   right part, array[N]

RESULT:
    This function returns no result.
    You can get the solution by calling SparseSolverResults()

  -- ALGLIB --
     Copyright 25.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolversolve(sparsesolverstate state, sparsematrix a, double[] b)


ite
    ati
esparse.
    pa
    sesolve
solve(state.innerob
j
    ,a ob, b, n
ll);
}

public static void sparsesolversolve(sparsesolverstate state, sparsematrix a, double[] b, alglib.xparams _params)
{
    i
    erativesparse.sparsesolver
        s
    olve(state.innero
    j, a.
        i
        nerobj, b, _
    a
        r
    ms);
}

/*************************************************************************
Sparse solver results.

This function must be called after calling one of the SparseSolverSolve()
functions.

INPUT PARAMETERS:
    State   -   algorithm state

OUTPUT PARAMETERS:
    X       -   array[N], solution
    Rep     -   solution report:
                * Rep.TerminationType completion code:
                    * -5    CG method was used for a matrix which  is  not
                            positive definite
                    * -4    overflow/underflow during solution
                            (ill conditioned problem)
                    *  1    ||residual||<=EpsF*||b||
                    *  5    MaxIts steps was taken
                    *  7    rounding errors prevent further progress,
                            best point found is returned
                    *  8    the  algorithm  was  terminated   early  with
                            SparseSolverRequestTermination() being called
                            from other thread.
                * Rep.IterationsCount contains iterations count
                * Rep.NMV contains number of matrix-vector calculations
                * Rep.R2 contains squared residual
s
  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolverresults(sparsesolverstate state, out double[] x, out sparsesolverreport rep)
{
    new doub
    e[0];


    rep = new
        sparsesolver
    r
        e
    p
        o
    r
    t
        (
        )
        ;


    i
        t
    e
        r
    a
        t
    i
        v
    e
        s
    p
        a
    r
        s
    e
        .
        s
        p
    a
        r
    s
        e
    s
        o
    l
        v
    e
        r
    r
        e
    s
        u
    l
        t
    s
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
        r
    e
    f x, rep.inn
        robj,
        ull)
}

public static void sparsesolverresults(sparsesolverstate state, out double[] x, out sparsesolverreport rep,
    alglib.xparams _params)
{
    x
        =
        new doble[0];

    re
        = n
    w sparsesolverrep
    o
    rt();
    ite
        ative
    s
    arse.sparses
        l
    v
        rresul
    t
        s
    s
        t
    te.inn
    e
        robj, r
    f x, re
    p.inner
}

/*************************************************************************
This function turns on/off reporting during out-of-core processing.

When the solver works in the out-of-core mode, it  can  be  configured  to
report its progress by returning current location. These location  reports
are implemented as a special kind of the out-of-core request:
* SparseSolverOOCGetRequestInfo() returns -1
* SparseSolverOOCGetRequestData() returns current location
* SparseSolverOOCGetRequestData1() returns squared norm of the residual
* SparseSolverOOCSendResult() shall NOT be called

This function has no effect when SparseSolverSolve() is used because  this
function has no method of reporting its progress.

NOTE: when used with GMRES(k), this function reports progress  every  k-th
      iteration.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state
    NeedXRep-   whether iteration reports are needed or not

  -- ALGLIB --
     Copyright 01.10.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolversetxrep(sparsesolverstate state, bool needxrep)
{
    iterativ
    sparse.spa
        sesolv r
        bj,
        nee
    xrep, nu
        l);
}

public static void sparsesolversetxrep(sparsesolverstate state, bool needxrep, alglib.xparams _params)
{
    itera
        iv
    sparse.sp
        rsesolverset
    x
        r

    e
        p
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
        n
    e
        e
    d
        x
    r
    e
        p,
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
This function initiates out-of-core mode of the sparse solver.  It  should
be used in conjunction with other out-of-core-related  functions  of  this
subspackage in a loop like one given below:

> alglib.sparsesolveroocstart(state)
> while alglib.sparsesolverooccontinue(state) do
>     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
>     alglib.sparsesolveroocgetrequestdata(state, out X)
>     if RequestType=0 then
>         [calculate  Y=A*X, with X=R^N]
>     alglib.sparsesolveroocsendresult(state, in Y)
> alglib.sparsesolveroocstop(state, out X, out Report)

INPUT PARAMETERS:
    State       -   solver object

  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolveroocstart(sparsesolverstate state, double[] b)
{
    iteratives
    arse.sparse
        ol

    e
        oocstar
        (sta
            e.

    nne
        obj,
        b,
        nul
        );
}

public static void sparsesolveroocstart(sparsesolverstate state, double[] b, alglib.xparams _params)


iterativesparse.spa
    r
s
    solvero
cstart(
    tate
        in
ero
    j, b, _params)

}

/*************************************************************************
This function performs iterative solution of  the  linear  system  in  the
out-of-core mode. It should be used in conjunction with other out-of-core-
related functions of this subspackage in a loop like one given below:

> alglib.sparsesolveroocstart(state)
> while alglib.sparsesolverooccontinue(state) do
>     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
>     alglib.sparsesolveroocgetrequestdata(state, out X)
>     if RequestType=0 then
>         [calculate  Y=A*X, with X=R^N]
>     alglib.sparsesolveroocsendresult(state, in Y)
> alglib.sparsesolveroocstop(state, out X, out Report)

  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static bool sparsesolverooccontinue(sparsesolverstate state)


re tu r
    te ra ti ve sp ar se.s p
ocontinue(state.innerobj, null);
}

public static bool sparsesolverooccontinue(sparsesolverstate state, alglib.xparams _params)
{
    return
        tera
    iv
    sparse.spar
        esol
    erooc
        ont
    i
        nu
    e
        (sta
    t
    e.inner
        j, _param
        ;
}

/*************************************************************************
This function is used to retrieve information  about  out-of-core  request
sent by the solver:
* RequestType=0  means that matrix-vector products A*x is requested
* RequestType=-1 means that solver reports its progress; this  request  is
  returned only when reports are activated wit SparseSolverSetXRep().

This function returns just request type; in order  to  get contents of the
trial vector, use sparsesolveroocgetrequestdata().

It should be used in conjunction with other out-of-core-related  functions
of this subspackage in a loop like one given below:

> alglib.sparsesolveroocstart(state)
> while alglib.sparsesolverooccontinue(state) do
>     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
>     alglib.sparsesolveroocgetrequestdata(state, out X)
>     if RequestType=0 then
>         [calculate  Y=A*X, with X=R^N]
>     alglib.sparsesolveroocsendresult(state, in Y)
> alglib.sparsesolveroocstop(state, out X, out Report)

INPUT PARAMETERS:
    State           -   solver running in out-of-core mode

OUTPUT PARAMETERS:
    RequestType     -   type of the request to process:
                        * 0   for matrix-vector product A*x, with A  being
                          NxN system matrix  and X being N-dimensional
                          vector
                        *-1   for location and residual report


  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolveroocgetrequestinfo(sparsesolverstate state, out int requesttype)
{
    requ
        et 0


    i parse.spa
        sesol
    veroo
        ge

    requestin
        o(state.inne
            r

    o
    b
        j,
        r
    e
        f

    r
        e
    q
        u
    e
        s
    t
        t
    y
    p
        e,
        n
    u
        l
    l
        )
    ;
}

public static void sparsesolveroocgetrequestinfo(sparsesolverstate state, out int requesttype,
    alglib.xparams _params)
{
    request
        t
    yp
        it
    e
        rativ
    e
    sparse.s
        p
    rses
        o

    lveroocetrequestin
        o(stat
                .inn
                robj, ref requesttype,
            _
                params);
}

/*************************************************************************
This function is used  to  retrieve  vector  associated  with  out-of-core
request sent by the solver to user code. Depending  on  the  request  type
(returned by the SparseSolverOOCGetRequestInfo()) this  vector  should  be
multiplied by A or subjected to another processing.

It should be used in conjunction with other out-of-core-related  functions
of this subspackage in a loop like one given below:

> alglib.sparsesolveroocstart(state)
> while alglib.sparsesolverooccontinue(state) do
>     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
>     alglib.sparsesolveroocgetrequestdata(state, out X)
>     if RequestType=0 then
>         [calculate  Y=A*X, with X=R^N]
>     alglib.sparsesolveroocsendresult(state, in Y)
> alglib.sparsesolveroocstop(state, out X, out Report)

INPUT PARAMETERS:
    State           -   solver running in out-of-core mode
    X               -   possibly  preallocated   storage;  reallocated  if
                        needed, left unchanged, if large enough  to  store
                        request data.

OUTPUT PARAMETERS:
    X               -   array[N] or larger, leading N elements are  filled
                        with vector X.


  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolveroocgetrequestdata(sparsesolverstate state, ref double[] x)
p
    a
r
    spa
sesolver
    ocg

trequest
    ata(ste ob
        , ref
        , n }

public static void sparsesolveroocgetrequestdata(sparsesolverstate state, ref double[] x, alglib.xparams _params)
{
    iterativesparse.sparsesolve
        r
    oocgetrequestdata
    state
        .
        nne
        obj
    ref x , _pa
    rams);
}

/*************************************************************************
This function is used to retrieve scalar value associated with out-of-core
request sent by the solver to user code. In  the  current  ALGLIB  version
this function is used to retrieve squared residual  norm  during  progress
reports.

INPUT PARAMETERS:
    State           -   solver running in out-of-core mode

OUTPUT PARAMETERS:
    V               -   scalar value associated with the current request


  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolveroocgetrequestdata1(sparsesolverstate state, out double v)
{
    = 0;


    iterat
    vesparse.s
        prsesolv
    roocge
        re
    uest
        at
    1(state.inn
    robj
        ref
    , n
        u
    ll
        )
    ;
}

public static void sparsesolveroocgetrequestdata1(sparsesolverstate state, out double v, alglib.xparams _params)
{
    v = 0;
    itera
        t
    ivesp
        a
    se.spars
        eroocg

    e
        trequestdata1(state.innerobj,
            ref v
            ,
            _pa
                ams);
}

/*************************************************************************
This function is used to send user reply to out-of-core  request  sent  by
the solver. Usually it is product A*x for vector X returned by the solver.

It should be used in conjunction with other out-of-core-related  functions
of this subspackage in a loop like one given below:

> alglib.sparsesolveroocstart(state)
> while alglib.sparsesolverooccontinue(state) do
>     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
>     alglib.sparsesolveroocgetrequestdata(state, out X)
>     if RequestType=0 then
>         [calculate  Y=A*X, with X=R^N]
>     alglib.sparsesolveroocsendresult(state, in Y)
> alglib.sparsesolveroocstop(state, out X, out Report)

INPUT PARAMETERS:
    State           -   solver running in out-of-core mode
    AX              -   array[N] or larger, leading N elements contain A*x


  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolveroocsendresult(sparsesolverstate state, double[] ax)
{
    tera ves
    a
        r
    e.sp arse
    s
    olveroosendresult(state.innerobj, ax, null);
}

public static void sparsesolveroocsendresult(sparsesolverstate state, double[] ax, alglib.xparams _params)
{
    ite
        atives
    ar
    e.sp
        rses
    o
        ve
    ocs
        dresult
    tate.i
        erobj, ax, _para
    s);
}

/*************************************************************************
This  function  finalizes out-of-core mode of the linear solver. It should
be used in conjunction with other out-of-core-related  functions  of  this
subspackage in a loop like one given below:

> alglib.sparsesolveroocstart(state)
> while alglib.sparsesolverooccontinue(state) do
>     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
>     alglib.sparsesolveroocgetrequestdata(state, out X)
>     if RequestType=0 then
>         [calculate  Y=A*X, with X=R^N]
>     alglib.sparsesolveroocsendresult(state, in Y)
> alglib.sparsesolveroocstop(state, out X, out Report)

INPUT PARAMETERS:
    State       -   solver state

OUTPUT PARAMETERS:
    X       -   array[N], the solution.
                Zero-filled on the failure (Rep.TerminationType<0).
    Rep     -   report with additional info:
                * Rep.TerminationType completion code:
                    * -5    CG method was used for a matrix which  is  not
                            positive definite
                    * -4    overflow/underflow during solution
                            (ill conditioned problem)
                    *  1    ||residual||<=EpsF*||b||
                    *  5    MaxIts steps was taken
                    *  7    rounding errors prevent further progress,
                            best point found is returned
                    *  8    the  algorithm  was  terminated   early  with
                            SparseSolverRequestTermination() being called
                            from other thread.
                * Rep.IterationsCount contains iterations count
                * Rep.NMV contains number of matrix-vector calculations
                * Rep.R2 contains squared residual

  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolveroocstop(sparsesolverstate state, out double[] x, out sparsesolverreport rep)
{
    x
    new double[0];
    r
    e
        p = new sparsesol
    errep
        o
    t();


    iterat
        i
    vespars
        .sparse
        solvero
    robj ref x, rep i
    n
    ner bj, n ul );
}

public static void sparsesolveroocstop(sparsesolverstate state, out double[] x, out sparsesolverreport rep,
    alglib.xparams _params)
{
    x =
        new

    do
        u
    ble[
    ];


    ep = n
    w spar
    s
        so
    verreport();


    terativespa
    se.s
        arses
    lve
        r
    oo
        c
    stop
    (
        state.i
    erobj, re
        x,
        ep.innerobj, _params
        ;
}

/*************************************************************************
This subroutine submits request for termination of the running solver.  It
can be called from some other thread which wants the   solver to terminate
or when processing an out-of-core request.

As result, solver  stops  at  point  which  was  "current  accepted"  when
the termination request was submitted and returns error code 8 (successful
termination).  Such   termination   is  a smooth  process  which  properly
deallocates all temporaries.

INPUT PARAMETERS:
    State   -   solver structure

NOTE: calling this function on solver which is NOT running  will  have  no
      effect.

NOTE: multiple calls to this function are possible. First call is counted,
      subsequent calls are silently ignored.

NOTE: solver clears termination flag on its start, it means that  if  some
      other thread will request termination too soon, its request will went
      unnoticed.

  -- ALGLIB --
     Copyright 01.10.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolverrequesttermination(sparsesolverstate state)
t
    a
spa
e.sparses
    ver

questtermi
    ion(s
        te.

innerobj, null);
}

public static void sparsesolverrequesttermination(sparsesolverstate state, alglib.xparams _params)
t
    rat
i
vesparse.sparse
    olverreq

esttermina
    ion(st s

;


}
}

public partial class alglib
{
    /*************************************************************************
    This object stores state of the linear CG method.

    You should use ALGLIB functions to work with this object.
    Never try to access its fields directly!
    *************************************************************************/
    public class lincgstate : alglibobject
    {
        //
        // Public declarations
        //

        public lincgstate()
        {
            _i nnerob
                j
                    = ne
            w
            l.i tate()
        }

        public override alglib.alglibobject make_copy()
        {
            r
                e
            urn ne
            w
                lincgs
            ate((li
            nc ngstate)_in
                er bj.
                e_c op y()
                );
        }

        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private lincg.lincgstate _innerobj;

        public lincg.lincgstate innerobj
        {
            get
            {
                eturn _
                nnerobj
            }
        }

        public lincgstate(lincg.lincgstate obj)
        {
            _
                nnerob
                    = ob
                ;
        }
    }


    /*************************************************************************

    *************************************************************************/
    public class lincgreport : alglibobject
    {
        //
        // Public declarations
        //
        public int iterationscount
        {
            get
            {
                return
                    inn
                robj.iterat
                    in nt;
            }
            set
            {
                _inn
                    er ation
                    u
                        = valu
                    ;
            }
        }

        public int nmv
        {
            get
            {
                retur
                    _
                nnerob
                    .nmv;
            }
            set
            {
                _inner
                j.nm
                    = va
                e;
            }
        }

        public int terminationtype
        {
            get
            {
                retu
                    n _inner
                bj.erminati
                o
                    type;
            }
            set
            {
                _innero
                bj ontype = v
                lue;
            }
        }

        public double r2
        {
            get
            {
                ret
                    rn _in
                erobj.r2;
            }
            set
            {
                _
                    nne
                obj.r
                2
                    =
                    alue;
            }
        }

        public lincgreport()
        {
            _i
            ner
                bj =
                    ew
            incg.li
                cgre
            ort()
        }

        public override alglib.alglibobject make_copy()
        {
            r
                e
            t
                u
            r
                n

            n
                e
            w
                l
            i
                n
            c
                g
            r
                e
            p
                o
            r
            t
            (
                (
                    l
            i
                n
            c
            g
                .
                l
                i
            n
                c
            g
                r
            e
                p
            o
                r
            t
                )
            _
                i
            n
                n
            e
                r
            o
                b
            j
                .
                m
                a
            k
                e
            _
                c
            o
                p
            y
                (
                )
                )
            ;
        }

        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private lincg.lincgreport _innerobj;

        public lincg.lincgreport innerobj
        {
            get
            {
                return
                    _i bj
            }
        }

        public lincgreport(lincg.lincgreport obj)
        {
            rb j = obj;
        }
    }

    /*************************************************************************
    This function initializes linear CG Solver. This solver is used  to  solve
    symmetric positive definite problems. If you want  to  solve  nonsymmetric
    (or non-positive definite) problem you may use LinLSQR solver provided  by
    ALGLIB.

    USAGE:
    1. User initializes algorithm state with LinCGCreate() call
    2. User tunes solver parameters with  LinCGSetCond() and other functions
    3. Optionally, user sets starting point with LinCGSetStartingPoint()
    4. User  calls LinCGSolveSparse() function which takes algorithm state and
       SparseMatrix object.
    5. User calls LinCGResults() to get solution
    6. Optionally, user may call LinCGSolveSparse()  again  to  solve  another
       problem  with different matrix and/or right part without reinitializing
       LinCGState structure.

    INPUT PARAMETERS:
        N       -   problem dimension, N>0

    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgcreate(int n, out lincgstate state)
    {
        s
            ate = new lincgstat lincgcreate(n, state.in nul
    }

    public static void lincgcreate(int n, out lincgstate state, alglib.xparams _params)
    {
        t
            = ne
            in gs
            li
        cg.l nc cre
            t
            (n, st e.nnerobj
                _pa
                ra s)
    }

    /*************************************************************************
    This function sets starting point.
    By default, zero starting point is used.

    INPUT PARAMETERS:
        X       -   starting point, array[N]

    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetstartingpoint(lincgstate state, double[] x)
    {
        li nc g.li nc gs et st ar ti ng po i
        obj l);
    }

    public static void lincgsetstartingpoint(lincgstate state, double[] x, alglib.xparams _params)
    {
        linc ets oint(st
        te.in
        n
            erobj, x, _
        arams);
    }

    /*************************************************************************
    This  function  changes  preconditioning  settings  of  LinCGSolveSparse()
    function. By default, SolveSparse() uses diagonal preconditioner,  but  if
    you want to use solver without preconditioning, you can call this function
    which forces solver to use unit matrix for preconditioning.

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state

      -- ALGLIB --
         Copyright 19.11.2012 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetprecunit(lincgstate state)
    {
        lincg.
            incgs
            tpre
        unit(state.innerobj,
            n
        ull);
    }

    public static void lincgsetprecunit(lincgstate state, alglib.xparams _params)
    {
        li
        cg.li
            cgsetprecuni
        t
        (
            ta
        e.i
            nerobj, _param
        s
            ;
    }

    /*************************************************************************
    This  function  changes  preconditioning  settings  of  LinCGSolveSparse()
    function.  LinCGSolveSparse() will use diagonal of the  system  matrix  as
    preconditioner. This preconditioning mode is active by default.

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state

      -- ALGLIB --
         Copyright 19.11.2012 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetprecdiag(lincgstate state)
    {
        l
            i
        cg.l
            i
        ncgsetpecdiag(stat
            .inner
        bj,
        ull);
    }

    public static void lincgsetprecdiag(lincgstate state, alglib.xparams _params)
    {
        l nc
        g
            .lincgset re d
            i
        a
            (stat
        e
            .innerob
            j _par ams)
        ;
    }

    /*************************************************************************
    This function sets stopping criteria.

    INPUT PARAMETERS:
        EpsF    -   algorithm will be stopped if norm of residual is less than
                    EpsF*||b||.
        MaxIts  -   algorithm will be stopped if number of iterations is  more
                    than MaxIts.

    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state

    NOTES:
    If  both  EpsF  and  MaxIts  are  zero then small EpsF will be set to small
    value.

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetcond(lincgstate state, double epsf, int maxits)
    {
        incg.lincgsetcond(state.innerobj, epsf, maxits, null);
    }

    public static void lincgsetcond(lincgstate state, double epsf, int maxits, alglib.xparams _params)
    {
        lincg.li
            n
        c
            setc
        nd(state
        innerobj, epsf
            ,
        axi
            , _params)
    }

    /*************************************************************************
    Procedure for solution of A*x=b with sparse A.

    INPUT PARAMETERS:
        State   -   algorithm state
        A       -   sparse matrix in the CRS format (you MUST contvert  it  to
                    CRS format by calling SparseConvertToCRS() function).
        IsUpper -   whether upper or lower triangle of A is used:
                    * IsUpper=True  => only upper triangle is used and lower
                                       triangle is not referenced at all
                    * IsUpper=False => only lower triangle is used and upper
                                       triangle is not referenced at all
        B       -   right part, array[N]

    RESULT:
        This function returns no result.
        You can get solution by calling LinCGResults()

    NOTE: this function uses lightweight preconditioning -  multiplication  by
          inverse of diag(A). If you want, you can turn preconditioning off by
          calling LinCGSetPrecUnit(). However, preconditioning cost is low and
          preconditioner  is  very  important  for  solution  of  badly scaled
          problems.

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsolvesparse(lincgstate state, sparsematrix a, bool isupper, double[] b)
    {
        i
        ncg.l in c
            gsolvesp a
            se(stat
                e.

        inerobj a.innerobj, isupper, b, null);
    }

    public static void lincgsolvesparse(lincgstate state, sparsematrix a, bool isupper, double[] b,
        alglib.xparams _params)
    {
        linc
            .l
            ncgs

        lv
            sparse(s
                at
                .

        inn
            robj,
            ,
            b,
            _p
        a
            ra
        ms);
    }

    /*************************************************************************
    CG-solver: results.

    This function must be called after LinCGSolve

    INPUT PARAMETERS:
        State   -   algorithm state

    OUTPUT PARAMETERS:
        X       -   array[N], solution
        Rep     -   optimization report:
                    * Rep.TerminationType completetion code:
                        * -5    input matrix is either not positive definite,
                                too large or too small
                        * -4    overflow/underflow during solution
                                (ill conditioned problem)
                        *  1    ||residual||<=EpsF*||b||
                        *  5    MaxIts steps was taken
                        *  7    rounding errors prevent further progress,
                                best point found is returned
                    * Rep.IterationsCount contains iterations count
                    * NMV countains number of matrix-vector calculations

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgresults(lincgstate state, out double[] x, out lincgreport rep)
    {
        x = report()


        lincg.li
            cg
        esul e
            x,
            rep
                .
        inner
            bj
        nul
            );
    }

    public static void lincgresults(lincgstate state, out double[] x, out lincgreport rep, alglib.xparams _params)
    {
        x
            = new double[
                0] re
            = new l
        ncgrepo
        t(
            ;

        lin
            gre
        ult
            (state.i
        ne
            obj, re
        x, rep.inne
        r
            oj, _param
        s
            ;
    }

    /*************************************************************************
    This function sets restart frequency. By default, algorithm  is  restarted
    after N subsequent iterations.

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetrestartfreq(lincgstate state, int srf)
    {
        l
            i
        n
            c
        g
            .
            l
            i
        n
            c
        g
            s
        e
            t
        r
            e
        s
            t
        a
            r
        t
            f
        r
            e
        q
        (
            s
        t
            a
        te.innerobj,
        srf, n
            ll);
    }

    public static void lincgsetrestartfreq(lincgstate state, int srf, alglib.xparams _params)
    {
        lin c
        g
            .lincgse
            t
        e
            s
        tartfreq
        (
            tate.in
        n
            r
        o
            j, s
        r
            f, _parms);
    }

    /*************************************************************************
    This function sets frequency of residual recalculations.

    Algorithm updates residual r_k using iterative formula,  but  recalculates
    it from scratch after each 10 iterations. It is done to avoid accumulation
    of numerical errors and to stop algorithm when r_k starts to grow.

    Such low update frequence (1/10) gives very  little  overhead,  but  makes
    algorithm a bit more robust against numerical errors. However, you may
    change it

    INPUT PARAMETERS:
        Freq    -   desired update frequency, Freq>=0.
                    Zero value means that no updates will be done.

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetrupdatefreq(lincgstate state, int freq)
    {
        d
            e
            (state
                inner

        bj,
        freq, null);
    }

    public static void lincgsetrupdatefreq(lincgstate state, int freq, alglib.xparams _params)
    {
        lin e
        (st
            a

        te.innerobj, fr
            q, _para
        s);
    }

    /*************************************************************************
    This function turns on/off reporting.

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state
        NeedXRep-   whether iteration reports are needed or not

    If NeedXRep is True, algorithm will call rep() callback function if  it is
    provided to MinCGOptimize().

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetxrep(lincgstate state, bool needxrep)


    linc
        g.l

    i
        nc(st e

    inn
        ro j, needx e
    p, n
}

public static void lincgsetxrep(lincgstate state, bool needxrep, alglib.xparams _params)
{
    l
        i
    n
        c
    g
        .
        l
        i
    n
        c
    g
        s
    e
        t
    x
        r

    e
        p
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
        n
    e
        e
    d
        x
    r
    e
        p, _params
        ;
}
}

public partial class alglib
{
    /*************************************************************************
    This object stores state of the LinLSQR method.

    You should use ALGLIB functions to work with this object.
    *************************************************************************/
    public class linlsqrstate : alglibobject
    {
        //
        // Public declarations
        //

        public linlsqrstate()
        {
            _innerobj = new
                l
            inlsqr.lin
                sqrst
            a
            e()
        }

        public override alglib.alglibobject make_copy()
        {
            re u
            r
                n ew
                l
            nlsqrst
                a
            te ns inlsqrstate)_innerobj.make_copy());
        }

        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private linlsqr.linlsqrstate _innerobj;

        public linlsqr.linlsqrstate innerobj
        {
            get
            {
                ret
                    rn _in
                ero
                    j;
            }
        }

        public linlsqrstate(linlsqr.linlsqrstate obj)
        {
            _in
                erob
                    = obj;
        }
    }


    /*************************************************************************

    *************************************************************************/
    public class linlsqrreport : alglibobject
    {
        //
        // Public declarations
        //
        public int iterationscount
        {
            get
            {
                re
                    _
                i
                    n
                n
                    e
                r
                    o
                b
                j
                    .
                    i
                    t
                e
                    r
                a
                    t
                i
                    o
                n
                    s
                c
                    o
                u
                n
                    t
                    ;
            }
            set
            {
                _
                    i
                n
                    n
                e
                    r
                o
                    b
                j
                    .
                    i
                    t
                e
                    r
                a
                    t
                i
                    o
                n
                    s
                c
                    o
                u
                n
                    t
                        =
                        v
                a
                    l
                u
                    e
                    ;
            }
        }

        public int nmv
        {
            get
            {
                return _inn
                e
                robj.nmv;
            }
            set
            {
                _in
                    erob
                j. = value;
            }
        }

        public int terminationtype
        {
            get
            {
                retu n
                _i nero
                b
                    .ter
                m
                    in ny
            }
            set
            {
                _inne
                obj.erminationtype = va
                l
                    ue;
            }
        }

        public linlsqrreport()
        {
            bj = new linlsqr.linlsqrr port();
        }

        public override alglib.alglibobject make_copy()
        {
            r
                e
            t
                u
            r
                n

            n
                e
            w
                l
            i
                n
            l
                s
            qr rt((
                inlsqr.l
            nlsqr
                ep
            o
                rt)
            innerobj.mk py())
        }

        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private linlsqr.linlsqrreport _innerobj;

        public linlsqr.linlsqrreport innerobj
        {
            get turn _inn
            robj;
        }
    }

    public linlsqrreport(linlsqr.linlsqrreport obj)
    {
        _
            i
        n
            n
        e
            r
        o
        b
            j
                =
                o
        b
            j
            ;
    }
}

/*************************************************************************
This function initializes linear LSQR Solver. This solver is used to solve
non-symmetric (and, possibly, non-square) problems. Least squares solution
is returned for non-compatible systems.

USAGE:
1. User initializes algorithm state with LinLSQRCreate() call
2. User tunes solver parameters with  LinLSQRSetCond() and other functions
3. User  calls  LinLSQRSolveSparse()  function which takes algorithm state
   and SparseMatrix object.
4. User calls LinLSQRResults() to get solution
5. Optionally, user may call LinLSQRSolveSparse() again to  solve  another
   problem  with different matrix and/or right part without reinitializing
   LinLSQRState structure.

INPUT PARAMETERS:
    M       -   number of rows in A
    N       -   number of variables, N>0

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

NOTE: see also linlsqrcreatebuf()  for  version  which  reuses  previously
      allocated place as much as possible.

  -- ALGLIB --
     Copyright 30.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrcreate(int m, int n, out linlsqrstate state)
{ = new
        linlsqrstate
        (
        );


    linlsqr.l
    nls
        qr,
        nul );
}

public static void linlsqrcreate(int m, int n, out linlsqrstate state, alglib.xparams _params)
{
    s
        t
    a
    t
        e
            =
            n
    e
        w

    l
        i
    n
        l
    s
        q
    r
        s
    t
        a
    t
    e
        (
        )
        ;


    l
        i
    n
        l
    s
        q
    r
        .
        l
        i
    n
        l
    s
        q
    r
        c
    r
        e
    a
        t
    e
    (
        m
        ,
        n
        ,
        state.inner
    bj, _
        arams);
}

/*************************************************************************
This function initializes linear LSQR Solver.  It  provides  exactly  same
functionality as linlsqrcreate(), but reuses  previously  allocated  space
as much as possible.

INPUT PARAMETERS:
    M       -   number of rows in A
    N       -   number of variables, N>0

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 14.11.2018 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrcreatebuf(int m, int n, linlsqrstate state)

l in ls q
    in ls q
ea te bu f(m, n, stat
    e
    .

i nerobj,
    n ll);
}

public static void linlsqrcreatebuf(int m, int n, linlsqrstate state, alglib.xparams _params)
{
    inl
    qr.inlsq uf(m, n, state.innerobj, _params);
}

/*************************************************************************
This  function  changes  preconditioning  settings of LinLSQQSolveSparse()
function. By default, SolveSparse() uses diagonal preconditioner,  but  if
you want to use solver without preconditioning, you can call this function
which forces solver to use unit matrix for preconditioning.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 19.11.2012 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrsetprecunit(linlsqrstate state)
{
    linl
        s
    q
        .li
        lsqrs
    tprecunit(state
        .nner
    j, nu
        );
}

public static void linlsqrsetprecunit(linlsqrstate state, alglib.xparams _params)
{
    linl
        s
    q
        .l
        nls
    rsetprecunit(s
    t
    te.innerob
        j
    _pa
        ams
        ;
}

/*************************************************************************
This  function  changes  preconditioning  settings  of  LinCGSolveSparse()
function.  LinCGSolveSparse() will use diagonal of the  system  matrix  as
preconditioner. This preconditioning mode is active by default.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 19.11.2012 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrsetprecdiag(linlsqrstate state)
{
    linlsqr.
        inlsqr
        etpr
    cdiag(state.i
    n
        ner
    b
        j
    nu
        l
        )
}

public static void linlsqrsetprecdiag(linlsqrstate state, alglib.xparams _params)
{
    lin
        l

    sqr.linsqrsetprecd
        ag(sta
            e.in

    erobj, _param
        s
        );
}

/*************************************************************************
This function sets optional Tikhonov regularization coefficient.
It is zero by default.

INPUT PARAMETERS:
    LambdaI -   regularization factor, LambdaI>=0

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 30.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrsetlambdai(linlsqrstate state, double lambdai)


linls
r.
    inlsqrset
    l
m
    b
di(state.inn
robj, lamb
    da;
}

public static void linlsqrsetlambdai(linlsqrstate state, double lambdai, alglib.xparams _params)
{
    l
        i
    n
        l
    s
        q
    r
        .
        l
        i
    n
        l
    s
        q
    r
        s
    e
        t
    l
        a
    m
        b
    d
        a
    i
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
        i,
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
Procedure for solution of A*x=b with sparse A.

INPUT PARAMETERS:
    State   -   algorithm state
    A       -   sparse M*N matrix in the CRS format (you MUST contvert  it
                to CRS format  by  calling  SparseConvertToCRS()  function
                BEFORE you pass it to this function).
    B       -   right part, array[M]

RESULT:
    This function returns no result.
    You can get solution by calling LinCGResults()

NOTE: this function uses lightweight preconditioning -  multiplication  by
      inverse of diag(A). If you want, you can turn preconditioning off by
      calling LinLSQRSetPrecUnit(). However, preconditioning cost is   low
      and preconditioner is very important for solution  of  badly  scaled
      problems.

  -- ALGLIB --
     Copyright 30.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrsolvesparse(linlsqrstate state, sparsematrix a, double[] b)
{
    li
        n
    sqr.li
        n

    lsqrsol
        esparse
        (state.
            erobj, b, n
            ul);
}

public static void linlsqrsolvesparse(linlsqrstate state, sparsematrix a, double[] b, alglib.xparams _params)
{
    linlsqr.
        nlsqrso
        esparse(state.i
            erobj, a
            nn

    obj, b, _params)
    ;
}

/*************************************************************************
This function sets stopping criteria.

INPUT PARAMETERS:
    EpsA    -   algorithm will be stopped if ||A^T*Rk||/(||A||*||Rk||)<=EpsA.
    EpsB    -   algorithm will be stopped if ||Rk||<=EpsB*||B||
    MaxIts  -   algorithm will be stopped if number of iterations
                more than MaxIts.

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

NOTE: if EpsA,EpsB,EpsC and MaxIts are zero then these variables will
be setted as default values.

  -- ALGLIB --
     Copyright 30.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrsetcond(linlsqrstate state, double epsa, double epsb, int maxits)
{
    lin
    sq
        .lin
        sq
    setcond
        (tate.inner
    bj, epsa,
    ep ts, nul
        )
}

public static void linlsqrsetcond(linlsqrstate state, double epsa, double epsb, int maxits, alglib.xparams _params)
{
    linlsq
        .linl
        sqrse

    co
        d(state.i
                nerobj, epsa
            ,
            e
                p

    s
        b,
        m
    a
        x
    i
    t
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
}

/*************************************************************************
LSQR solver: results.

This function must be called after LinLSQRSolve

INPUT PARAMETERS:
    State   -   algorithm state

OUTPUT PARAMETERS:
    X       -   array[N], solution
    Rep     -   optimization report:
                * Rep.TerminationType completetion code:
                    *  1    ||Rk||<=EpsB*||B||
                    *  4    ||A^T*Rk||/(||A||*||Rk||)<=EpsA
                    *  5    MaxIts steps was taken
                    *  7    rounding errors prevent further progress,
                            X contains best point found so far.
                            (sometimes returned on singular systems)
                    *  8    user requested termination via calling
                            linlsqrrequesttermination()
                * Rep.IterationsCount contains iterations count
                * NMV countains number of matrix-vector calculations

  -- ALGLIB --
     Copyright 30.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrresults(linlsqrstate state, out double[] x, out linlsqrreport rep)
{
    x = new
        oub
    e[0];


    rep =
        ew linl );

    r.inlsqr
    esu.innerobj
        ref
    x, re
        .i
        nerobj, n
    ll);
}

public static void linlsqrresults(linlsqrstate state, out double[] x, out linlsqrreport rep, alglib.xparams _params)
{
    x = new d
    u
        b
    e[0];


    rep
        epo rt );


    linlsq.linlsqr r
    esult
    st robj,
        e
    f
        x, re
    p
        .inneroj, _params)
}

/*************************************************************************
This function turns on/off reporting.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state
    NeedXRep-   whether iteration reports are needed or not

If NeedXRep is True, algorithm will call rep() callback function if  it is
provided to MinCGOptimize().

  -- ALGLIB --
     Copyright 30.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrsetxrep(linlsqrstate state, bool needxrep)
{
    l inlsq

    t
        p(state.i
                nerob
            , need
                rep, 

    null
        ;
}

public static void linlsqrsetxrep(linlsqrstate state, bool needxrep, alglib.xparams _params)
{
    l
        nls rsetxrep(
        tate.inner
    bj
        needxrep
    _params);
}

/*************************************************************************
This function is used to peek into LSQR solver and get  current  iteration
counter. You can safely "peek" into the solver from another thread.

INPUT PARAMETERS:
    S           -   solver object

RESULT:
    iteration counter, in [0,INF)

  -- ALGLIB --
     Copyright 21.05.2018 by Bochkanov Sergey
*************************************************************************/
public static int linlsqrpeekiterationscount(linlsqrstate s)
{
    r
        e
    t
        u
    r
        n

    l
        i
    n
        l
    s
        q
    r
        .
        linlsqrpee
        iterat
    i
        nscount
    (.innerobj
    null);
}

public static int linlsqrpeekiterationscount(linlsqrstate s, alglib.xparams _params)
{
    l
        l
    sqrpe
        e
    k
        i
    t
        rationsco ner
        _
    ams);
}

/*************************************************************************
This subroutine submits request for termination of the running solver.  It
can be called from some other thread which wants LSQR solver to  terminate
(obviously, the  thread  running  LSQR  solver can not request termination
because it is already busy working on LSQR).

As result, solver  stops  at  point  which  was  "current  accepted"  when
termination  request  was  submitted  and returns error code 8 (successful
termination).  Such   termination   is  a smooth  process  which  properly
deallocates all temporaries.

INPUT PARAMETERS:
    State   -   solver structure

NOTE: calling this function on solver which is NOT running  will  have  no
      effect.

NOTE: multiple calls to this function are possible. First call is counted,
      subsequent calls are silently ignored.

NOTE: solver clears termination flag on its start, it means that  if  some
      other thread will request termination too soon, its request will went
      unnoticed.

  -- ALGLIB --
     Copyright 08.10.2014 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrrequesttermination(linlsqrstate state)


linlsqr.l inlsqr r
    e
quest
    t
erminati
    o
at e.n
    n
rob j, 
null);


}

public static void linlsqrrequesttermination(linlsqrstate state, alglib.xparams _params)
{
    in
    l
        sqr
    linlsqrre
        qesttermina
    ion(state.
            in _para
        ;
}
}

public partial class alglib
{
    /*************************************************************************

    *************************************************************************/
    public class nleqstate : alglibobject
    {
        //
        // Public declarations
        //
        public bool needf
        {
            get
            {
                r
                    e
                t
                    u
                r
                    n

                _
                    i
                n
                    n
                e
                    r
                o
                    b
                j
                    .
                    n
                    e
                e
                d
                    f
                    ;
            }
            set
            {
                erobj.eedf =
                    valu
                    ;
            }
        }

        public bool needfij
        {
            get
            {
                return
                    _ robj.needfij;
            }
            set
            {
                _i
                    n
                nerobj.df =
                    value
                    ;
            }
        }

        public bool xupdated
        {
            get return
            _inner
            bj. x
            pdated;
        }

        set {
            _innerobj.x
            pdate
                d
                    = va
            ue;
        }
    }

    public double f
    {
        get
        {
            bj f;
        }
        set
        {
            _innerobj
                .f = va
            lu e;
        }
    }

    public double[] fi
    {
        get
        {
            e _innerobj.fi;
        }
    }

    public double[,] j
    {
        get
        {
            r
                e
            t
                u
            r
                n

            _
                i
            n
                n
            e
                r
            o
                b
            j
                .j
                ;
        }
    }

    public double[] x
    {
        get
        {
            r
                turn
            _inner
            bj.
                ;
        }
    }

    public nleqstate()
    {
        _in
        ero
            j = ne
        nle
            .nleqst
        te();
    }

    public override alglib.alglibobject make_copy()
    {
        retu
            r
        n
            w

        n
            leq
        sa eq
        nleqst
            te).make_cop
            ());
    }

    //
    // Although some of declarations below are public, you should not use them
    // They are intended for internal use only
    //
    private nleq.nleqstate _innerobj;

    public nleq.nleqstate innerobj
    {
        get
        {
            retu r
            n
                _innerobj
        }
    }

    public nleqstate(nleq.nleqstate obj)
    {
        _inne
        o
            b
                = obj
            ;
    }
}


/*************************************************************************

*************************************************************************/
public class nleqreport : alglibobject
{
    //
    // Public declarations
    //
    public int iterationscount
    {
        get
        {
            retur
                _in
            erobj.
                te
                tionscount;
        }
        set
        {
            _inn
                e
            obj
                terati
            scount
                valu
        }
    }

    public int nfunc
    {
        get eturn _
        nn
        ro
        j. nfunc
    }

    set {
        _in
            er
        bj.n
            f
        uc al
            e;
    }
}

public int njac
{
    get {
        tur
        _innerobj.njac;
    }
    set {
        _i obj.njac =
            lue;
    }
}

public int terminationtype
{
    get {
        return _in bj.terminat
            i
        o
            ype;
    }
    set {
        _inne
        j.r
        inatio
            ype = v
        ue;
    }
}

public nleqreport()
{
    _innero
        bj = new nleq.n
    r
    rt();
}

public override alglib.alglibobject make_copy()
{
    rn new
        l port
    (
        nleq.nle
    repor
        )_
        nner
    bj.make_
        opy
        ));
}

//
// Although some of declarations below are public, you should not use them
// They are intended for internal use only
//
private nleq.nleqreport _innerobj;

public nleq.nleqreport innerobj
{
    get rn
    _inner
        bj;
}
}

public nleqreport(nleq.nleqreport obj)
{
    _
        i
    n
        n
    e
        r
    o
    b
        j
            =
            o
    b
        j
        ;
}
}

/*************************************************************************
                LEVENBERG-MARQUARDT-LIKE NONLINEAR SOLVER

DESCRIPTION:
This algorithm solves system of nonlinear equations
    F[0](x[0], ..., x[n-1])   = 0
    F[1](x[0], ..., x[n-1])   = 0
    ...
    F[M-1](x[0], ..., x[n-1]) = 0
with M/N do not necessarily coincide.  Algorithm  converges  quadratically
under following conditions:
    * the solution set XS is nonempty
    * for some xs in XS there exist such neighbourhood N(xs) that:
      * vector function F(x) and its Jacobian J(x) are continuously
        differentiable on N
      * ||F(x)|| provides local error bound on N, i.e. there  exists  such
        c1, that ||F(x)||>c1*distance(x,XS)
Note that these conditions are much more weaker than usual non-singularity
conditions. For example, algorithm will converge for any  affine  function
F (whether its Jacobian singular or not).


REQUIREMENTS:
Algorithm will request following information during its operation:
* function vector F[] and Jacobian matrix at given point X
* value of merit function f(x)=F[0]^2(x)+...+F[M-1]^2(x) at given point X


USAGE:
1. User initializes algorithm state with NLEQCreateLM() call
2. User tunes solver parameters with  NLEQSetCond(),  NLEQSetStpMax()  and
   other functions
3. User  calls  NLEQSolve()  function  which  takes  algorithm  state  and
   pointers (delegates, etc.) to callback functions which calculate  merit
   function value and Jacobian.
4. User calls NLEQResults() to get solution
5. Optionally, user may call NLEQRestartFrom() to  solve  another  problem
   with same parameters (N/M) but another starting  point  and/or  another
   function vector. NLEQRestartFrom() allows to reuse already  initialized
   structure.


INPUT PARAMETERS:
    N       -   space dimension, N>1:
                * if provided, only leading N elements of X are used
                * if not provided, determined automatically from size of X
    M       -   system size
    X       -   starting point


OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state


NOTES:
1. you may tune stopping conditions with NLEQSetCond() function
2. if target function contains exp() or other fast growing functions,  and
   optimization algorithm makes too large steps which leads  to  overflow,
   use NLEQSetStpMax() function to bound algorithm's steps.
3. this  algorithm  is  a  slightly  modified implementation of the method
   described  in  'Levenberg-Marquardt  method  for constrained  nonlinear
   equations with strong local convergence properties' by Christian Kanzow
   Nobuo Yamashita and Masao Fukushima and further  developed  in  'On the
   convergence of a New Levenberg-Marquardt Method'  by  Jin-yan  Fan  and
   Ya-Xiang Yuan.


  -- ALGLIB --
     Copyright 20.08.2009 by Bochkanov Sergey
*************************************************************************/
public static void nleqcreatelm(int n, int m, double[] x, out nleqstate state)
st
    te = new n
l
    eqst
a
te();


nl r
ob j, n ul l) ;
}

public static void nleqcreatelm(int n, int m, double[] x, out nleqstate state, alglib.xparams _params)
{
    eqstate()
        ;


    n

    leq.
        leqcreate
        m(n, m x, state.innero
                bj, _param
        );
}

public static void nleqcreatelm(int m, double[] x, out nleqstate state)
{
    i
        n
    t
        s
    ta
        n
    l
        e
    q
        s
    t
        a
    t
        e
    (
        )


    n
        =
        a
            .len(x);


    leq
        nleqcreatel
        (n, m, x
            ,
            tate.inne
                bj, 

    null)

    return;
}

public static void nleqcreatelm(int m, double[] x, out nleqstate state, alglib.xparams _params)
{
    int
        n
    sta
        e = new
            l
    e
        q
    s
        ate
        );

    n
        =
        a
    p
        len
    x);

    n telm(n, m, x,
            ta
                e._
                ar
                a
                m
                s
        )
        ;


    re
        urn;
}

/*************************************************************************
This function sets stopping conditions for the nonlinear solver

INPUT PARAMETERS:
    State   -   structure which stores algorithm state
    EpsF    -   >=0
                The subroutine finishes  its work if on k+1-th iteration
                the condition ||F||<=EpsF is satisfied
    MaxIts  -   maximum number of iterations. If MaxIts=0, the  number  of
                iterations is unlimited.

Passing EpsF=0 and MaxIts=0 simultaneously will lead to  automatic
stopping criterion selection (small EpsF).

NOTES:

  -- ALGLIB --
     Copyright 20.08.2010 by Bochkanov Sergey
*************************************************************************/
public static void nleqsetcond(nleqstate state, double epsf, int maxits)
{
    n
        l
    q.nl
        qsetc
    nd(state.in
    n
    e
        ob, e
    sf, maxits, nu
        l
        );
}

public static void nleqsetcond(nleqstate state, double epsf, int maxits, alglib.xparams _params)
{
    leq
        .
        nl
        setcond(nnerobj,
            epsf,
            m
                xits, _params);
}

/*************************************************************************
This function turns on/off reporting.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state
    NeedXRep-   whether iteration reports are needed or not

If NeedXRep is True, algorithm will call rep() callback function if  it is
provided to NLEQSolve().

  -- ALGLIB --
     Copyright 20.08.2010 by Bochkanov Sergey
*************************************************************************/
public static void nleqsetxrep(nleqstate state, bool needxrep)
{
    nle
        .nleq
        etxre
        (stat
            .inne
            bj

    needxrep
        ,
}

public static void nleqsetxrep(nleqstate state, bool needxrep, alglib.xparams _params)
{
    le
        .nl
    qsetxre.innerobj
        ne
    xr
        ep, _par
    a
        ms);
}

/*************************************************************************
This function sets maximum step length

INPUT PARAMETERS:
    State   -   structure which stores algorithm state
    StpMax  -   maximum step length, >=0. Set StpMax to 0.0,  if you don't
                want to limit step length.

Use this subroutine when target function  contains  exp()  or  other  fast
growing functions, and algorithm makes  too  large  steps  which  lead  to
overflow. This function allows us to reject steps that are too large  (and
therefore expose us to the possible overflow) without actually calculating
function value at the x+stp*d.

  -- ALGLIB --
     Copyright 20.08.2010 by Bochkanov Sergey
*************************************************************************/
public static void nleqsetstpmax(nleqstate state, double stpmax)
{
    nl
        (s ta t
    nu ll);
}

public static void nleqsetstpmax(nleqstate state, double stpmax, alglib.xparams _params)


n
    l
q.nl
e
    .inner
o
    pax, _params
    ;
}

/*************************************************************************
This function provides reverse communication interface
Reverse communication interface is not documented or recommended to use.
See below for functions which provide better documented API
*************************************************************************/
public static bool nleqiteration(nleqstate state)
{
    return
        nleq.nleqi
    te tate.
        e
        j,  null);
}

public static bool nleqiteration(nleqstate state, alglib.xparams _params)
{
    r
        tu
    n
        n
    l
        eq
    nleqiterat _pa
    ams);
}

/*************************************************************************
This family of functions is used to launcn iterations of nonlinear solver

These functions accept following parameters:
    func    -   callback which calculates function (or merit function)
                value func at given point x
    jac     -   callback which calculates function vector fi[]
                and Jacobian jac at given point x
    rep     -   optional callback which is called after each iteration
                can be null
    obj     -   optional object which is passed to func/grad/hess/jac/rep
                can be null


  -- ALGLIB --
     Copyright 20.03.2009 by Bochkanov Sergey

*************************************************************************/
public static void nleqsolve(nleqstate state, ndimensional_func func, ndimensional_jac jac, ndimensional_rep rep,
    object obj)
{
    leqso
        ve(sta
                e, func,
            ac, re

    null);
}

public static void nleqsolve(nleqstate state, ndimensional_func func, ndimensional_jac jac, ndimensional_rep rep,
    object obj, alglib.xparams _params)
{
    c == null )


    t
        row new a
    glibexceptio
    n
    (
        "
    A
        L
    G
        L
    I
    B
        :

    e
        r
    r
        o
    r
        i
    n
        '
    n
        l
    e
        q
    s
        o
    l
        v
    e
        (
        )
        '
        (
            f
    u
        n
    c
        i
    s
        n
    u
        l
    l
        )
    "
        )
    ;


    i
        f
        (
            j
                a

    c
        = 
        =
    n
        u
    l
        l )

    thr
        w ne
        alglibexce
    p
    tion("ALG
    IB:
    e
        r
    or i
    'nleqso
    lve()' 


    wh le(al l
    ib.nl q

    itera on(ate, _par a
        s) )


    if (s
    ate.eedf )


    {
        func(
            s
        ate.x,
            ref sta
        e.inner
        obj.f,

        co tinue;
    }

    i f(
        tate.ne ed
            f
            ij)
    {
        jac(state.x, state.innerobj.fi, state.innerobj.j, obj);
        continue;
    }

    if (state.innerobj.xupdated)
    {
        if (rep != null)
            rep(state.innerobj.x, state.innerobj.f, obj);
        continue;
    }

    throw new alglibexception("ALGLIB: error in 'nleqsolve' (some derivatives were not provided?)");
}
}


/*************************************************************************
NLEQ solver results

INPUT PARAMETERS:
    State   -   algorithm state.

OUTPUT PARAMETERS:
    X       -   array[0..N-1], solution
    Rep     -   optimization report:
                * Rep.TerminationType completetion code:
                    * -4    ERROR:  algorithm   has   converged   to   the
                            stationary point Xf which is local minimum  of
                            f=F[0]^2+...+F[m-1]^2, but is not solution  of
                            nonlinear system.
                    *  1    sqrt(f)<=EpsF.
                    *  5    MaxIts steps was taken
                    *  7    stopping conditions are too stringent,
                            further improvement is impossible
                * Rep.IterationsCount contains iterations count
                * NFEV countains number of function calculations
                * ActiveConstraints contains number of active constraints

  -- ALGLIB --
     Copyright 20.08.2009 by Bochkanov Sergey
*************************************************************************/
public static void nleqresults(nleqstate state, out double[] x, out nleqreport rep)
{
    x
        = ne do
        u
    b
        rep = new nleqreport();
    nleq.nleqresults(state.innerobj, ref x, rep.innerobj, null);
}

public static void nleqresults(nleqstate state, out double[] x, out nleqreport rep, alglib.xparams _params)
{
    x =
        ew double[
    ];


    r
        p = n
    w nleqre
    po leqre
    ults
        st
    te.in
    erobj
        r p.i
        b
    _params)
}

/*************************************************************************
NLEQ solver results

Buffered implementation of NLEQResults(), which uses pre-allocated  buffer
to store X[]. If buffer size is  too  small,  it  resizes  buffer.  It  is
intended to be used in the inner cycles of performance critical algorithms
where array reallocation penalty is too large to be ignored.

  -- ALGLIB --
     Copyright 20.08.2009 by Bochkanov Sergey
*************************************************************************/
public static void nleqresultsbuf(nleqstate state, ref double[] x, nleqreport rep)

{
    nleq.
        leqr
        sultsbuf(
            s
                tate.

    inne
        obj,
        r
    f x, rep.innerobj
    nul
        l
        ;
}

public static void nleqresultsbuf(nleqstate state, ref double[] x, nleqreport rep, alglib.xparams _params)
{
    nleq.nleqre su lt sb uf(s ta te.i nn e
    j, r ef x,
        p. i
    ro bj, _p ar am s) ;
}

/*************************************************************************
This  subroutine  restarts  CG  algorithm from new point. All optimization
parameters are left unchanged.

This  function  allows  to  solve multiple  optimization  problems  (which
must have same number of dimensions) without object reallocation penalty.

INPUT PARAMETERS:
    State   -   structure used for reverse communication previously
                allocated with MinCGCreate call.
    X       -   new starting point.
    BndL    -   new lower bounds
    BndU    -   new upper bounds

  -- ALGLIB --
     Copyright 30.07.2010 by Bochkanov Sergey
*************************************************************************/
public static void nleqrestartfrom(nleqstate state, double[] x)
{
    qrestarom(state.innerobj, x, null);
}

public static void nleqrestartfrom(nleqstate state, double[] x, alglib.xparams _params)
{
    nleq.
        leqre
        sartfrom(sta
            e.

    innerobj
        , m
}
}

public partial class alglib
{
    public class polynomialsolver
    {
        public class polynomialsolverreport : apobject
        {
            public double maxerr;

            public polynomialsolverreport()
                in

            t();
        }

        public override void init()
        {
        }

        public override alglib.apobject make_copy()
        {
            r
                o
            resu
            l
                t
                    =
                    new
                        po


            _res
            lt.
                axerr
                e
            _result
        }
    };


    /*************************************************************************
    Polynomial root finding.

    This function returns all roots of the polynomial
        P(x) = a0 + a1*x + a2*x^2 + ... + an*x^n
    Both real and complex roots are returned (see below).

    INPUT PARAMETERS:
        A       -   array[N+1], polynomial coefficients:
                    * A[0] is constant term
                    * A[N] is a coefficient of X^N
        N       -   polynomial degree

    OUTPUT PARAMETERS:
        X       -   array of complex roots:
                    * for isolated real root, X[I] is strictly real: IMAGE(X[I])=0
                    * complex roots are always returned in pairs - roots occupy
                      positions I and I+1, with:
                      * X[I+1]=Conj(X[I])
                      * IMAGE(X[I]) > 0
                      * IMAGE(X[I+1]) = -IMAGE(X[I]) < 0
                    * multiple real roots may have non-zero imaginary part due
                      to roundoff errors. There is no reliable way to distinguish
                      real root of multiplicity 2 from two  complex  roots  in
                      the presence of roundoff errors.
        Rep     -   report, additional information, following fields are set:
                    * Rep.MaxErr - max( |P(xi)| )  for  i=0..N-1.  This  field
                      allows to quickly estimate "quality" of the roots  being
                      returned.

    NOTE:   this function uses companion matrix method to find roots. In  case
            internal EVD  solver  fails  do  find  eigenvalues,  exception  is
            generated.

    NOTE:   roots are not "polished" and  no  matrix  balancing  is  performed
            for them.

      -- ALGLIB --
         Copyright 24.02.2014 by Bochkanov Sergey
    *************************************************************************/
    public static void polynomialsolve(double[] a,
        int n,
        ref complex[] x,
        polynomialsolverreport rep,
        alglib.xparams _params)
    {
        uble[
        ] c = new
            double[0, 0];


        double
            , ] v
            =
            ew doub
        e[0, 0];

        doubl[0, 0];


        double[
            wr
                = new doubl


        doubl
            [] wi
                = new double[
                    i
        t i = 0;

        t
            = 0


        b at
            s = ne
        bo
        nt nz
            = 0;


        nt ne =
            c
        o
            m
        p
            l
        e
        x
            v
                =
                0
            ;


        c
            o
        m
            p
        l
            e
        x

        v
            v
                =
                0
            ;


        a
            =
            (
        do
            [])a.C
        one();

        x = new
            c
        omplex[0]


        a
            g
        li.
            nomi
            a
        lSolve:
        N <= 0");


        al
            g
        i
            b
        ap.a
            s
        se ll p.len(
        ) >= n + 1
        "Po
        ynomialSolve:
        L
            e
        ngth(A) < N
        1");


        a
        glib.a
        p
            .assert
        apserv.
            is t
            _par
        am ), "Po        lynomialS
        o
        lve:
        A
            contains i
            f
        i
            ite numbers");

        alglib.p.ass
        rt((dou bl[n]) !=
            doubl
            )(0), "Polynomial        e: A[N]=0");


        //


        // Prepare

        x
            = new
                co

        //


        ic ne NZ
            ero root


        e
            / ual NE
            th degre
            polyn
        o
            mial mon
        c

            //
            n =
                wi le(n z < n && (double)(a[nz])
                = 
            =
            (
                nz
    }
    for

    (; i<=n;
    i++)
    {
        a[i - nz] = a[i] / a[n];
    }

//
// For NZ<N, build companion matrix and find NE non-zero roots
//
if (ne > 0)
{
    c = new double[ne, ne];
    for (i = 0; i <= ne - 1; i++)
    {
        for (j = 0; j <= ne - 1; j++)
        {
            c[i, j] = 0;
        }
    }

    c[0, ne - 1] = -a[0];
    for (i = 1; i <= ne - 1; i++)
    {
        c[i, i - 1] = 1;
        c[i, ne - 1] = -a[i];
    }

    status = evd.rmatrixevd(c, ne, 0, ref wr, ref wi, ref vl, ref vr, _params);
    alglib.ap.assert(status, "PolynomialSolve: inernal error - EVD solver failed");
    for (i = 0; i <= ne - 1; i++)
    {
        x[i].x = wr[i];
        x[i].y = wi[i];
    }
}

//
// Remaining NZ zero roots
//
for (i = ne; i <= n - 1; i++)
{
    x[i] = 0;
}

//
// Rep
//
rep.maxerr = 0;
for (i = 0; i <= ne - 1; i++)
{
    v = 0;
    vv = 1;
    for (j = 0; j <= ne; j++)
    {
        v = v + a[j] * vv;
        vv = vv * x[i];
    }

    rep.maxerr = Math.Max(rep.maxerr, math.abscomplex(v));
}
}
}

public class directdensesolvers
{
    public class densesolverreport : apobject
    {
        public double r1;
        public double rinf;

        public densesolverreport()
        {
            init();
        }

        public override void init()
        {
        }

        public override alglib.apobject make_copy()
        {
            d
                e
            n
                s
            e
                s
            o
                l
            v
                e
            r
                r
            e
                p
            o
                r
            t
                _
            re ew den
                esolve
            repo
            t();


            _
                r
            e
                u
            lt.r1 = r1;


            _result.inf = r
            i
                n
                ;

            return _result;
        }
    };


    public class densesolverlsreport : apobject
    {
        public double r2;
        public double[,] cx;
        public int n;
        public int k;

        public densesolverlsreport()
        {
            i
            it();
        }

        public override void init()


        c
        = w do

        u
            b

        l
    }

    public override alglib.apobject make_copy()
    {
        ul t = ne w de n
            ol v
            s
        or t
        2
        r
            _re
        s
        u
            l, 
            )
        x.Co ne();
            = n;


        _res ul t.k =
            k


        _re su t;
    }
};


/*************************************************************************
Dense solver for A*x=b with N*N real matrix A and N*1 real vectorx  x  and
b. This is "slow-but-feature rich" version of the  linear  solver.  Faster
version is RMatrixSolveFast() function.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* iterative refinement
* O(N^3) complexity

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear  system
           ! and  performs  iterative   refinement,   which   results   in
           ! significant performance penalty  when  compared  with  "fast"
           ! version  which  just  performs  LU  decomposition  and  calls
           ! triangular solver.
           !
           ! This  performance  penalty  is  especially  visible  in   the
           ! multithreaded mode, because both condition number  estimation
           ! and   iterative    refinement   are   inherently   sequential
           ! calculations. It is also very significant on small matrices.
           !
           ! Thus, if you need high performance and if you are pretty sure
           ! that your system is well conditioned, we  strongly  recommend
           ! you to use faster solver, RMatrixSolveFast() function.

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  ! 
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixsolve(double[,] a,
    int n,
    double[] b,
    ref int info,
    densesolverreport rep,
    ref double[] x,
    alglib.xparams _params)
{
    double[,] b
        = new do
        ble[0, 0];

    d
    uble[,] xm = ne
    double[0
    0];

    int i_ = 0;


    info = 0;


    x

    new doubl[0];


    i
    (
        n <= 0
    )


    {
        in
        o = -1
    }


    bm = new
            ouble[n,
        ;


    for (
        = 0;
    i_ <
    {
        bm[i
        ] = b[i_];
    }

    n
        bm,  1, tru
        , ref info,
    rep, re
        xm,
        arams);


    x =
        r(i_ =
            i_ <
            -1;
    i_++)

    {
        x
    }
}


/*************************************************************************
Dense solver.

This  subroutine  solves  a  system  A*x=b,  where A is NxN non-denegerate
real matrix, x  and  b  are  vectors.  This is a "fast" version of  linear
solver which does NOT provide  any  additional  functions  like  condition
number estimation or iterative refinement.

Algorithm features:
* efficient algorithm O(N^3) complexity
* no performance overhead from additional functionality

If you need condition number estimation or iterative refinement, use  more
feature-rich version - RMatrixSolve().

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is exactly singular (ill conditioned matrices
                        are not recognized).
                * -1    N<=0 was passed
                *  1    task is solved 
    B       -   array[N]:
                * info>0    =>  overwritten by solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  ! 
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 16.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixsolvefast(double[,] a,
    int n,
    double[] b,
    ref int info,
    alglib.xparams _params)
{
    i
        n
    t
        i
            =
            0
        ;
        in
    j = 0


    int[
        ]
        p = n
    e
        w

    n
    t[
        a )a.Clo
        n
    e
        )
    ;
    inf
        = 
        ;


    n <= 0 )

    {
        nfo =
            -
                1


        retu
        r
            n;
    }

    xlu(re
    f
        a
    n n
    re
        p, _pa
    r
        a
    m
        s
        )
    ;
    r( = 0;
    i
        <
        =
        -1
            ++)


    {
        i
        (
            d
        u
            b
        uble
        (
        )

        {
            -1 j +
                )


            b
                j
                    ]
                ;


            e
        }
    }


    s
        b,
        _p m
        )
}


/*************************************************************************
Dense solver.

Similar to RMatrixSolve() but solves task with multiple right parts (where
b and x are NxM matrices). This is  "slow-but-robust"  version  of  linear
solver with additional functionality  like  condition  number  estimation.
There also exists faster version - RMatrixSolveMFast().

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* optional iterative refinement
* O(N^3+M*N^2) complexity

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear  system
           ! and  performs  iterative   refinement,   which   results   in
           ! significant performance penalty  when  compared  with  "fast"
           ! version  which  just  performs  LU  decomposition  and  calls
           ! triangular solver.
           !
           ! This  performance  penalty  is  especially  visible  in   the
           ! multithreaded mode, because both condition number  estimation
           ! and   iterative    refinement   are   inherently   sequential
           ! calculations. It also very significant on small matrices.
           !
           ! Thus, if you need high performance and if you are pretty sure
           ! that your system is well conditioned, we  strongly  recommend
           ! you to use faster solver, RMatrixSolveMFast() function.

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size
    RFS     -   iterative refinement switch:
                * True - refinement is used.
                  Less performance, more precision.
                * False - refinement is not used.
                  More performance, less precision.

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is ill conditioned or singular.
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  ! 
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixsolvem(double[,] a,
    int n,
    double[,] b,
    int m,
    bool rfs,
    ref int info,
    densesolverreport rep,
    ref double[,] x,
    alglib.xparams _params)
{
    doubl
    e
        da =
            w doubl
        ,0] e
        , ] emptya =
        new double[
            ,0];


    int[]
        = ne
    int[0]; =
    0;


    nt i
        = 0;


    info = 0;

    ;


    i
        puts
    allocate sp
    e...


    //


    (
        0 ||
        i
    n
        o = -1;


    retur
        =
        new
            uble[n, n

                //

                // 1         
                //
                .olve

    //


    for (i = 0;
    for
    (
        _ = ;
        i
        <= n -;
        i_ +
    )


        ;
}


trfac.atrixlu(re _
ara
    s)


if (
    r
s )
{
    rmatrixlus
        lveinternal,
        b,
  ref
        i
        nf
    o
        ,

    r
    e
        p,
        r
    e
        f, _par
    ms);


    else


    rmat
        r
    i
        xl
    u
        s
    o
        l
    v
        ei
    n
        t
    e
        r

    n
        l(da,
            p, n, s
            ,
            f inf
            , re
            , ref

    ;
}

}


/*************************************************************************
Dense solver.

Similar to RMatrixSolve() but solves task with multiple right parts (where
b and x are NxM matrices). This is "fast" version of linear  solver  which
does NOT offer additional functions like condition  number  estimation  or
iterative refinement.

Algorithm features:
* O(N^3+M*N^2) complexity
* no additional functionality, highest performance

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size
    RFS     -   iterative refinement switch:
                * True - refinement is used.
                  Less performance, more precision.
                * False - refinement is not used.
                  More performance, less precision.

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is exactly singular (ill conditioned matrices
                        are not recognized).
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    B       -   array[N]:
                * info>0    =>  overwritten by solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  ! 
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixsolvemfast(double[,] a,
    int n,
    double[,] b,
    int m,
    ref int info,
    alglib.xparams _params)


d o
b
le
    v
        =
        0
    ;

t
    in t
    = ;
    in


a
    =
    (
        d
ou
    b
l

    //
    /
    /
C
    h
ck
    o
r
    ex ct d g
e
    /
    0
{
    inf
        o
            =
            1
        ;


    t
        rn;


    t
        .
        matri lu
        (
            re e

    ;
    {
        if ((d ou bl )
        (
                a[
                    i,]
            )
            =
            (
                ouble)
            (
            ) )

        {
            for (
                j
                    = 


            {
                for (k = 0; k <= m - 1; k++)
                {
                    b[j, k] = 0.0;
                }
            }

            info = -3;
            return;
        }
    }

    //
    // Solve with TRSM()
    //
    for (i = 0; i <= n - 1; i++)
    {
        if (p[i] != i)
        {
            for (j = 0; j <= m - 1; j++)
            {
                v = b[i, j];
                b[i, j] = b[p[i], j];
                b[p[i], j] = v;
            }
        }
    }

    ablas.rmatrixlefttrsm(n, m, a, 0, 0, false, true, 0, b, 0, 0, _params);
    ablas.rmatrixlefttrsm(n, m, a, 0, 0, true, false, 0, b, 0, 0, _params);
    info = 1;
}


/*************************************************************************
Dense solver.

This  subroutine  solves  a  system  A*x=b,  where A is NxN non-denegerate
real matrix given by its LU decomposition, x and b are real vectors.  This
is "slow-but-robust" version of the linear LU-based solver. Faster version
is RMatrixLUSolveFast() function.

Algorithm features:
* automatic detection of degenerate cases
* O(N^2) complexity
* condition number estimation

No iterative refinement  is provided because exact form of original matrix
is not known to subroutine. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which results in 10-15x  performance  penalty  when  compared
           ! with "fast" version which just calls triangular solver.
           !
           ! This performance penalty is insignificant  when compared with
           ! cost of large LU decomposition.  However,  if you  call  this
           ! function many times for the same  left  side,  this  overhead
           ! BECOMES significant. It  also  becomes significant for small-
           ! scale problems.
           !
           ! In such cases we strongly recommend you to use faster solver,
           ! RMatrixLUSolveFast() function.

INPUT PARAMETERS
    LUA     -   array[N,N], LU decomposition, RMatrixLU result
    P       -   array[N], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[N], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

    
  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixlusolve(double[,] lua,
    int[] p,
    int n,
    double[] b,
    ref int info,
    densesolverreport rep,
    ref double[] x,
    alglib.xparams _params)
{
    d
        ou, 0 =
        n
    e
        w

    o
    ble
        [0 =  = new
        o
    b
        l
    e[n <= 0
        )
    i
        ret
}

bm e[n


f
    o
(
        i_
            =
            0
    ;

_
    <=
    n -
    bm
    [
        _, rma
t
    r
i
    x
l
    s
ol
    v

e
    m
    (
        u
            a,
        p,
        x
            o

(
    i
_
    =
    0
    ;

i
_
    <=


}


/*************************************************************************
Dense solver.

This  subroutine  solves  a  system  A*x=b,  where A is NxN non-denegerate
real matrix given by its LU decomposition, x and b are real vectors.  This
is "fast-without-any-checks" version of the linear LU-based solver. Slower
but more robust version is RMatrixLUSolve() function.

Algorithm features:
* O(N^2) complexity
* fast algorithm without ANY additional checks, just triangular solver

INPUT PARAMETERS
    LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
    P       -   array[0..N-1], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is exactly singular (ill conditioned matrices
                        are not recognized).
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved 
    B       -   array[N]:
                * info>0    =>  overwritten by solution
                * info=-3   =>  filled by zeros

  -- ALGLIB --
     Copyright 18.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixlusolvefast(double[,] lua,
        int[] p,
        int n,
        double[] b,
        ref int info,
        alglib.xparams _params)
    ;


i
    t
        = 0;


inf
    =
    0;


i
    f(
        i
            n

f
    = -1;

r
    turn;


(i = 0;

i
    <
    =
    n
    -
    ;
++)


{
    e
        ,
        ==(do
        u
            b
    l
    e
        (0) )


    {
        ;
        =n - 1
        j
            +)


        b[j] = 0.0;


        i
            fo =
                -e
        u
            r
    }
}


basiclus
    ol )


i
    fo = 1;
}


/*************************************************************************
Dense solver.

Similar to RMatrixLUSolve() but solves  task  with  multiple  right  parts
(where b and x are NxM matrices). This  is  "robust-but-slow"  version  of
LU-based solver which performs additional  checks  for  non-degeneracy  of
inputs (condition number estimation). If you need  best  performance,  use
"fast-without-any-checks" version, RMatrixLUSolveMFast().

Algorithm features:
* automatic detection of degenerate cases
* O(M*N^2) complexity
* condition number estimation

No iterative refinement  is provided because exact form of original matrix
is not known to subroutine. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which  results  in  significant  performance   penalty   when
           ! compared with "fast"  version  which  just  calls  triangular
           ! solver.
           !
           ! This performance penalty is especially apparent when you  use
           ! ALGLIB parallel capabilities (condition number estimation  is
           ! inherently  sequential).  It   also   becomes significant for
           ! small-scale problems.
           !
           ! In such cases we strongly recommend you to use faster solver,
           ! RMatrixLUSolveMFast() function.
  
INPUT PARAMETERS
    LUA     -   array[N,N], LU decomposition, RMatrixLU result
    P       -   array[N], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N,M], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  ! 
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixlusolvem(double[,] lua,
    int[] p,
    int n,
    double[,] b,
    int m,
    ref int info,
    densesolverreport rep,
    ref double[,] x,
    alglib.xparams _params)
{
    do
        u
    e[,] emptya = new double[0, 0];


    i
    n
        o = 0;

    x
        = new double[0, 0];

        //
        /
    repare:
    ch
    ck inputs, allo
    a
        t
    e
        s
    p
        a
    c
        ...
    //


    if (n <
        0 || m <= 0

    {
        i
        o
            - 1;


        r
            turn
    }


    //


    // 
    olve

        //
        r

    tr
        lusolveinternal(
            ua, p, n,
            emptya, fa
                le, b, m, ref info,
            e
            , re
                x, _par
                ms

    ;
}


/*************************************************************************
Dense solver.

Similar to RMatrixLUSolve() but solves  task  with  multiple  right parts,
where b and x are NxM matrices.  This is "fast-without-any-checks" version
of LU-based solver. It does not estimate  condition number  of  a  system,
so it is extremely fast. If you need better detection  of  near-degenerate
cases, use RMatrixLUSolveM() function.

Algorithm features:
* O(M*N^2) complexity
* fast algorithm without ANY additional checks, just triangular solver

INPUT PARAMETERS:
    LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
    P       -   array[0..N-1], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS:
    Info    -   return code:
                * -3    matrix is exactly singular (ill conditioned matrices
                        are not recognized).
                * -1    N<=0 was passed
                *  1    task is solved
    B       -   array[N,M]:
                * info>0    =>  overwritten by solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  ! 
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 18.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixlusolvemfast(double[,] lua,
    int[] p,
    int n,
    double[,] b,
    int m,
    ref int info,
    alglib.xparams _params)
{
    dou
    e v = 0;

    t
        i = 0;


    int j
    0


    int k
            = 
        ;
        =
    0;


    //


    //
    Check for
        exact
    degeneracy
        /
        /


    i
    f
        (
            n
                <
                =
                0
                |
        |
        m
        <
        =
        0
        )


    {
        info = -1;


        return;
    }


    0;
    i
        <
        n
        - 1


    i
    f
    (
        (
    do
        i])
            =
    (d


    for (j
        0;
    j <


    for (k =
             0; k <= m - 1;


    {
        = 0.;
    }


    fo


    etu n;
}
/

S
    l
ve

i
    f
        =
        0
    ;


{
    for (
        +)


        v
            = b[i, j]
            ;
            ,
    j
    b[i
    ]
    j];

    b[p[i], j] = v;
}
}
}
ablas.rmatrixlefttrsm(n, m, lua, 0, 0, false, true, 0, b, 0, 0, _params);
ablas.rmatrixlefttrsm(n, m, lua, 0, 0, true, false, 0, b, 0, 0, _params);
info = 1;
}


/*************************************************************************
Dense solver.

This  subroutine  solves  a  system  A*x=b,  where BOTH ORIGINAL A AND ITS
LU DECOMPOSITION ARE KNOWN. You can use it if for some  reasons  you  have
both A and its LU decomposition.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* iterative refinement
* O(N^2) complexity

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
    P       -   array[0..N-1], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixmixedsolve(double[,] a,
    double[,] lua,
    int[] p,
    int n,
    double[] b,
    ref int info,
    densesolverreport rep,
    ref double[] x,
    alglib.xparams _params)
{
    double
        , ] bm =
        new double[
            oub
    e
    [
    ] xm = n
    e
    do
        u
            ble
    0,0];

    t
        info
            = 0


    x = new double[0];


    if (
        =0
    {
        inf
            =
            -1;


        r
            tu
            ;
    }

    b
        = new
            ouble[n,
                1];


    for (i_
        0;
    i_ <=
        -1
    i_++)
        = b[i_];
}


rmatrixmixedsol
    v

e
    m
    (
        a
        ,
        l
            u

a
    ,

p
    ,

n
    ,

b
    m, 

1
    ,

r
    e
f
    i
n
f
    o,
    r
e
    p,
    r
e
    f

x
    m,
    _
p
    a
r
    a
m
    s
    )
;


x
    = new double[n];


for (i_ = 0; i_ <= n - 1; i
    _
        ++)


x[0];


}


/*************************************************************************
Dense solver.

Similar to RMatrixMixedSolve() but  solves task with multiple right  parts
(where b and x are NxM matrices).

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* iterative refinement
* O(M*N^2) complexity

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
    P       -   array[0..N-1], pivots array, RMatrixLU result
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N,M], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixmixedsolvem(double[,] a,
    double[,] lua,
    int[] p,
    int n,
    double[,] b,
    int m,
    ref int info,
    densesolverreport rep,
    ref double[,] x,
    alglib.xparams _params)
{
    i
        n
    f
        o
            = 0;
    x = new
            ouble[0, 0];

        //
        /
        /

    repare
        check cat
    c
        .


    //


    if (n <= 0
        |
        m <= 0)


        o = -
                1
            ;


    ret
    u
        n;
}


//


v

    //
    rm
trixusolveinternal(
    ua, p, n, a, re
f
    rep, r
f x,
    _params);
}


/*************************************************************************
Complex dense solver for A*X=B with N*N  complex  matrix  A,  N*M  complex
matrices  X  and  B.  "Slow-but-feature-rich"   version   which   provides
additional functions, at the cost of slower  performance.  Faster  version
may be invoked with CMatrixSolveMFast() function.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* iterative refinement
* O(N^3+M*N^2) complexity

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear  system
           ! and  performs  iterative   refinement,   which   results   in
           ! significant performance penalty  when  compared  with  "fast"
           ! version  which  just  performs  LU  decomposition  and  calls
           ! triangular solver.
           !
           ! This  performance  penalty  is  especially  visible  in   the
           ! multithreaded mode, because both condition number  estimation
           ! and   iterative    refinement   are   inherently   sequential
           ! calculations.
           !
           ! Thus, if you need high performance and if you are pretty sure
           ! that your system is well conditioned, we  strongly  recommend
           ! you to use faster solver, CMatrixSolveMFast() function.

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    B       -   array[0..N-1,0..M-1], right part
    M       -   right part size
    RFS     -   iterative refinement switch:
                * True - refinement is used.
                  Less performance, more precision.
                * False - refinement is not used.
                  More performance, less precision.

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    matrix is very badly conditioned or exactly singular.
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved (but matrix A may be ill-conditioned,
                        check R1/RInf parameters for condition numbers).
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N,M], it contains:
                * info>0    =>  solution
                * info=-3   =>  filled by zeros

  ! FREE EDITION OF ALGLIB:
  ! 
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void cmatrixsolvem(complex[,] a,
    int n,
    complex[,] b,
    int m,
    bool rfs,
    ref int info,
    densesolverreport rep,
    ref complex[,] x,
    alglib.xparams _params)
{
    c
        ompl
    ex[,] da = new complex[0, 0];
    complex[
    ] emptya
        =
        ne
    co
        plex
    0,
        ];

    int[
        ]
        = new
            nt[0];

    nt
        i = 0;


    int i_ = 0;


    info = 0;

    x =
        new complex
    0,0];


    /

    //
    prepare:
    heck i
        puts, allocate space
                           ..

                           //
                           f
                           (
                               n
                                   <
                                   =
                                   0
                                   |
                       |
                       m
        = 0 )
    {
        in
        o = -1;


        eturn;
    }


    ];


    //


    //
    actori
        , solve

    for (i =
             i <= n - 1;
         )


    {
        for )

        {
            a[i, i_]
            a[i,
            ];
        }


        t
        ac.cmatr
            lu
        ef da,
            n,
            n,
            f p
            _param
        fs )


        {
            tr a
                p,
                a,
  true, b
                m,  ref
                fo
                rep,  ref x
                _params


            l
            e

            {
                matrixlus
                    lveint
                nal(da, p,,
                    m,
                    info, re
                ef x, _par
                    );
            }
        }


        /*************************************************************************
        Complex dense solver for A*X=B with N*N  complex  matrix  A,  N*M  complex
        matrices  X  and  B.  "Fast-but-lightweight" version which  provides  just
        triangular solver - and no additional functions like iterative  refinement
        or condition number estimation.

        Algorithm features:
        * O(N^3+M*N^2) complexity
        * no additional time consuming functions

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size

        OUTPUT PARAMETERS:
            Info    -   return code:
                        * -3    matrix is exactly singular (ill conditioned matrices
                                are not recognized).
                        * -1    N<=0 was passed
                        *  1    task is solved 
            B       -   array[N,M]:
                        * info>0    =>  overwritten by solution
                        * info=-3   =>  filled by zeros

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

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

          -- ALGLIB --
             Copyright 16.03.2015 by Bochkanov Sergey
        *************************************************************************/
        public static void cmatrixsolvemfast(complex[,] a,
            int n,
            complex[,] b,
            int m,
            ref int info,
            alglib.xparams _params)
        {
            omplex
                = 0;
                in
            i = 0;


            i
            t j =
                0

            nt k =
                0;
            nt[] p =
                ew in
            t[0];


            a = (complex[,])
                a
                    .C
            l
                o
            n
            e
                (
                )
                ;


            i
                n
            f
                o
                    =
                    0
                ;
                /
                /


            // Check for e
            act de
            ener
            cy

                //
                | m
                =
                0 {
                -1


                re
                    urn
                    ;
            }


            xlu(ref a, n, n,
                ef
            p,

            f
                o
            r
                i
                    = 0 +)


            {
                {
                    n - 1;
                    j +
                        +)
                    {
                        r(k
                            = 0;
                        m
                        1;
                        k )


                        b
                    }


                    r turn;
                }
            }


            S ol ve
                h T
                    ()
                = n -;
            i
                +
                )


            {
                f
                    v =
                        b
                        [i
                            =
                            b
                            [
                                p
                                    [
                    ;
                    = v
                    ;


                a
                    bl
                a
                    a
                t
                    r
                ix f
                tt 0

                ra );


                bl
                s.
                    c
                    a
                t
                    i
                x
                t
                    sm, m, a, 

                0, ls
                    e,
 
                    ,
 
                    ;
                    = 1;
            }


            /*************************************************************************
            Complex dense solver for A*x=B with N*N complex matrix A and  N*1  complex
            vectors x and b. "Slow-but-feature-rich" version of the solver.
    
            Algorithm features:
            * automatic detection of degenerate cases
            * condition number estimation
            * iterative refinement
            * O(N^3) complexity
    
            IMPORTANT: ! this function is NOT the most efficient linear solver provided
                       ! by ALGLIB. It estimates condition  number  of  linear  system
                       ! and  performs  iterative   refinement,   which   results   in
                       ! significant performance penalty  when  compared  with  "fast"
                       ! version  which  just  performs  LU  decomposition  and  calls
                       ! triangular solver.
                       !
                       ! This  performance  penalty  is  especially  visible  in   the
                       ! multithreaded mode, because both condition number  estimation
                       ! and   iterative    refinement   are   inherently   sequential
                       ! calculations.
                       !
                       ! Thus, if you need high performance and if you are pretty sure
                       ! that your system is well conditioned, we  strongly  recommend
                       ! you to use faster solver, CMatrixSolveFast() function.
    
            INPUT PARAMETERS
                A       -   array[0..N-1,0..N-1], system matrix
                N       -   size of A
                B       -   array[0..N-1], right part
    
            OUTPUT PARAMETERS
                Info    -   return code:
                            * -3    matrix is very badly conditioned or exactly singular.
                            * -1    N<=0 was passed
                            *  1    task is solved (but matrix A may be ill-conditioned,
                                    check R1/RInf parameters for condition numbers).
                Rep     -   additional report, following fields are set:
                            * rep.r1    condition number in 1-norm
                            * rep.rinf  condition number in inf-norm
                X       -   array[N], it contains:
                            * info>0    =>  solution
                            * info=-3   =>  filled by zeros
    
              ! FREE EDITION OF ALGLIB:
              ! 
              ! Free Edition of ALGLIB supports following important features for  this
              ! function:
              ! * C++ version: x64 SIMD support using C++ intrinsics
              ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
              !
              ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
              ! Reference Manual in order  to  find  out  how to activate SIMD support
              ! in ALGLIB.
    
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
    
              -- ALGLIB --
                 Copyright 27.01.2010 by Bochkanov Sergey
            *************************************************************************/
            public static void cmatrixsolve(complex[,] a,
                int n,
                complex[] b,
                ref int info,
                densesolverreport rep,
                ref complex[] x,
                alglib.xparams _params)

            m
            0,0];


            m
                e
            x
            [
                0
                , 0;

            o
            o


            {
                =
                -
                    1
                    ;

                r


                or(i_ = 0 i_ <= n - 1;
                i_++ )


                _,0]
                    =[
            }

            c tr xs
                o
            l
                v
            m
            (
                ,
                b
            m

            1
            tru
                e
            ref in o
                e re s);


            x = ew complex[n];
            for (i_ = 0; i_ <= n - 1; i_++)
            {
                x[i_] = xm[i_, 0];
            }
        }


        /*************************************************************************
        Complex dense solver for A*x=B with N*N complex matrix A and  N*1  complex
        vectors x and b. "Fast-but-lightweight" version of the solver.

        Algorithm features:
        * O(N^3) complexity
        * no additional time consuming features, just triangular solver

        INPUT PARAMETERS:
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS:
            Info    -   return code:
                        * -3    matrix is exactly singular (ill conditioned matrices
                                are not recognized).
                        * -1    N<=0 was passed
                        *  1    task is solved 
            B       -   array[N]:
                        * info>0    =>  overwritten by solution
                        * info=-3   =>  filled by zeros

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

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

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void cmatrixsolvefast(complex[,] a,
            int n,
            complex[] b,
            ref int info,
            alglib.xparams _params)
        {
            t i
            0

            int j = 0;


            nt[
                p = ne


            a = (
                om
            lex[,
                    a.one(
                        info = 
                ;


            inf
                = -1;


            ;


            trfac
                cm
            trixlu
                ref a, n
                n,  ref p
                _params)
                <
            n -
                ;
            i +
                )


            if (a[i,
                ] == 0)


            {
                for (
                    j =
                        +
                    )


                    0
                0
            }


            info =
                -3;

            n
        }


        u
            n
        b
            _params)


        i
            nfo = 
            ;
    }


    /*************************************************************************
    Dense solver for A*X=B with N*N complex A given by its  LU  decomposition,
    and N*M matrices X and B (multiple right sides).   "Slow-but-feature-rich"
    version of the solver.

    Algorithm features:
    * automatic detection of degenerate cases
    * O(M*N^2) complexity
    * condition number estimation

    No iterative refinement  is provided because exact form of original matrix
    is not known to subroutine. Use CMatrixSolve or CMatrixMixedSolve  if  you
    need iterative refinement.

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear system,
               ! which  results  in  significant  performance   penalty   when
               ! compared with "fast"  version  which  just  calls  triangular
               ! solver.
               !
               ! This performance penalty is especially apparent when you  use
               ! ALGLIB parallel capabilities (condition number estimation  is
               ! inherently  sequential).  It   also   becomes significant for
               ! small-scale problems.
               !
               ! In such cases we strongly recommend you to use faster solver,
               ! CMatrixLUSolveMFast() function.

    INPUT PARAMETERS
        LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
        P       -   array[0..N-1], pivots array, RMatrixLU result
        N       -   size of A
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS
        Info    -   return code:
                    * -3    matrix is very badly conditioned or exactly singular.
                    * -1    N<=0 was passed
                    *  1    task is solved (but matrix A may be ill-conditioned,
                            check R1/RInf parameters for condition numbers).
        Rep     -   additional report, following fields are set:
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N,M], it contains:
                    * info>0    =>  solution
                    * info=-3   =>  filled by zeros

      ! FREE EDITION OF ALGLIB:
      ! 
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

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

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void cmatrixlusolvem(complex[,] lua,
        int[] p,
        int n,
        complex[,] b,
        int m,
        ref int info,
        densesolverreport rep,
        ref complex[,] x,
        alglib.xparams _params)
    {
        n
            o
        p


        are:
        c
            c
        f(n <= 0 | {
            = -1;


            turn;
        }

        //
        // solve
        //
        cmatrixlusolveinternal(lua, p, n, emptya, false, b, m, ref info, rep, ref x, _params);
    }


    /*************************************************************************
    Dense solver for A*X=B with N*N complex A given by its  LU  decomposition,
    and N*M matrices X and B (multiple  right  sides).  "Fast-but-lightweight"
    version of the solver.

    Algorithm features:
    * O(M*N^2) complexity
    * no additional time-consuming features

    INPUT PARAMETERS
        LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
        P       -   array[0..N-1], pivots array, RMatrixLU result
        N       -   size of A
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS
        Info    -   return code:
                    * -3    matrix is exactly singular (ill conditioned matrices
                            are not recognized).
                    * -1    N<=0 was passed
                    *  1    task is solved 
        B       -   array[N,M]:
                    * info>0    =>  overwritten by solution
                    * info=-3   =>  filled by zeros

      ! FREE EDITION OF ALGLIB:
      ! 
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

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

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void cmatrixlusolvemfast(complex[,] lua,
        int[] p,
        int n,
        complex[,] b,
        int m,
        ref int info,
        alglib.xparams _params)
    {
        com
        le
            v = 0;
            in


        it
            in
        k = 0;


        ;


        //


        / Check
            or exact
        egeneracy
            /
            f(n
                = 0 || m <
                    = 0

        {
            info
                = -1;


            return;
        }

        f
        r(i = 0;
        i <= n - 1;
        i++)


        {
            u
            [
                , i] == 0 )


            {
                fo
                    (j = 0;
                j
                    = n - 1;
                j++)


                {
                    for (k =
                             0; +


                    {
                        b[j, k] = 0.0;
                    }
                }


                in
                o =
                    -3
            }


            //

            //
            Solve
                ith //


            f
            r(i = 0;
            i <
                n - 1;
            i++)


            {
                i
                f
                (
                    p
                        [
                            i
                        ]
                        !
                        =
                        i
                )


                {
                    for (j = 0;
                         j <=
                         -1;
                         j +
                        )


                    {
                        =
                        b
                            [
                                ,
                                j]
                            ] = b[p
                        [
                            i
                        ]
                        j
                            ];

                        ,j]
                            = v
                    }
                }
            }


            b
                la ttrsm(
                n
                , m, lu
                , 0, 0,
                false, tru


            a
                se,
 
                ,
                p


            nf
                =
                1
        }


        /*************************************************************************
        Complex dense linear solver for A*x=b with complex N*N A  given  by its LU
        decomposition and N*1 vectors x and b. This is  "slow-but-robust"  version
        of  the  complex  linear  solver  with  additional  features   which   add
        significant performance overhead. Faster version  is  CMatrixLUSolveFast()
        function.

        Algorithm features:
        * automatic detection of degenerate cases
        * O(N^2) complexity
        * condition number estimation

        No iterative refinement is provided because exact form of original matrix
        is not known to subroutine. Use CMatrixSolve or CMatrixMixedSolve  if  you
        need iterative refinement.

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear system,
                   ! which results in 10-15x  performance  penalty  when  compared
                   ! with "fast" version which just calls triangular solver.
                   !
                   ! This performance penalty is insignificant  when compared with
                   ! cost of large LU decomposition.  However,  if you  call  this
                   ! function many times for the same  left  side,  this  overhead
                   ! BECOMES significant. It  also  becomes significant for small-
                   ! scale problems.
                   !
                   ! In such cases we strongly recommend you to use faster solver,
                   ! CMatrixLUSolveFast() function.

        INPUT PARAMETERS
            LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
            P       -   array[0..N-1], pivots array, CMatrixLU result
            N       -   size of A
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            Info    -   return code:
                        * -3    matrix is very badly conditioned or exactly singular.
                        * -1    N<=0 was passed
                        *  1    task is solved (but matrix A may be ill-conditioned,
                                check R1/RInf parameters for condition numbers).
            Rep     -   additional report, following fields are set:
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N], it contains:
                        * info>0    =>  solution
                        * info=-3   =>  filled by zeros

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void cmatrixlusolve(complex[,] lua,
            int[] p,
            int n,
            complex[] b,
            ref int info,
            densesolverreport rep,
            ref complex[] x,
            alglib.xparams _params)
        {
            co l
                x,
                ]
            [
            0,0
                ;


            w


            nt
                i_ =
                    w

            om l
            e
                    [0
                ;


            0


            b
                =
                n
            e
                w
            c
                om
            p
                l
            e
            x[,
                1
            ]
            i


            {
                [
                    c
                at i

                x
                    l
                u
                    s
                l
                    ve
                m
                f
                    x =
                        e
                w
                    c
                o
                    m
                p
                    e
                x
                    <
                    x[i
                _
            }


            /*************************************************************************
            Complex dense linear solver for A*x=b with N*N complex A given by  its  LU
            decomposition and N*1 vectors x and b. This is  fast  lightweight  version
            of solver, which is significantly faster than CMatrixLUSolve(),  but  does
            not provide additional information (like condition numbers).
    
            Algorithm features:
            * O(N^2) complexity
            * no additional time-consuming features, just triangular solver
    
            INPUT PARAMETERS
                LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
                P       -   array[0..N-1], pivots array, CMatrixLU result
                N       -   size of A
                B       -   array[0..N-1], right part
    
            OUTPUT PARAMETERS
                Info    -   return code:
                            * -3    matrix is exactly singular (ill conditioned matrices
                                    are not recognized).
                            * -1    N<=0 was passed
                            *  1    task is solved 
                B       -   array[N]:
                            * info>0    =>  overwritten by solution
                            * info=-3   =>  filled by zeros
                
            NOTE: unlike  CMatrixLUSolve(),  this   function   does   NOT   check  for
                  near-degeneracy of input matrix. It  checks  for  EXACT  degeneracy,
                  because this check is easy to do. However,  very  badly  conditioned
                  matrices may went unnoticed.
    
    
              -- ALGLIB --
                 Copyright 27.01.2010 by Bochkanov Sergey
            *************************************************************************/
            public static void cmatrixlusolvefast(complex[,] lua,
                int[] p,
                int n,
                complex[] b,
                ref int info,
                alglib.xparams _params)
            {
                int
                    = 0;

                int j
                    = fo i
                (n <
                 0)

                {
                    in
                    = -
                        ;
                }


                for (i = 0; i <= n
                     -
                     i++)


                {
                    =
                    0 )


                    {
                        fo
                            r
                                = 0;
                            =n - 1;
                        j++
                        {
                            b[
                                = 0.0;
                        }

                        i
                            fo =
                                3;

                        ;
                    }


                    cb
                        siclusolv
                    (lu
                        , 
                        , n
                            b, _p
                            rams);

                    ;
                }


                /*************************************************************************
                Dense solver. Same as RMatrixMixedSolveM(), but for complex matrices.
        
                Algorithm features:
                * automatic detection of degenerate cases
                * condition number estimation
                * iterative refinement
                * O(M*N^2) complexity
        
                INPUT PARAMETERS
                    A       -   array[0..N-1,0..N-1], system matrix
                    LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
                    P       -   array[0..N-1], pivots array, CMatrixLU result
                    N       -   size of A
                    B       -   array[0..N-1,0..M-1], right part
                    M       -   right part size
        
                OUTPUT PARAMETERS
                    Info    -   return code:
                                * -3    matrix is very badly conditioned or exactly singular.
                                * -1    N<=0 was passed
                                *  1    task is solved (but matrix A may be ill-conditioned,
                                        check R1/RInf parameters for condition numbers).
                    Rep     -   additional report, following fields are set:
                                * rep.r1    condition number in 1-norm
                                * rep.rinf  condition number in inf-norm
                    X       -   array[N,M], it contains:
                                * info>0    =>  solution
                                * info=-3   =>  filled by zeros
        
                  -- ALGLIB --
                     Copyright 27.01.2010 by Bochkanov Sergey
                *************************************************************************/
                public static void cmatrixmixedsolvem(complex[,] a,
                    complex[,] lua,
                    int[] p,
                    int n,
                    complex[,] b,
                    int m,
                    ref int info,
                    densesolverreport rep,
                    ref complex[,] x,
                    alglib.xparams _params)
                {
                    i
                        n
                    f
                        o
                            =
                            0
                        ;


                    x
                        =
                        n
                    e
                        w

                    c
                        o
                    m
                        p
                    l
                        e
                    x
                        [
                            0
                            ,
                            0
                        ]
                        ;

                        //
                        /
                        /

                    p
                        r
                    pare
                        c
                    h
                        ck inpu
                        s
                    allo
                        at
                    spa
                        ...
                    //


                    i
                    (n <= 0
                     |
                     m <=
                    )


                    {
                        info = -1;


                        ret
                        rn
                            /
                            /


                        // solve


                        //

                        cmatri
                            l
                        usol
                        einternal
                            lua,
                            p,
                            n a, true, b, m, re
                            info, r
                        ep, ref x,
                        p
                            a
                        r
                            a
                        m
                            s
                            ;
                    }


                    /*************************************************************************
                    Dense solver. Same as RMatrixMixedSolve(), but for complex matrices.
            
                    Algorithm features:
                    * automatic detection of degenerate cases
                    * condition number estimation
                    * iterative refinement
                    * O(N^2) complexity
            
                    INPUT PARAMETERS
                        A       -   array[0..N-1,0..N-1], system matrix
                        LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
                        P       -   array[0..N-1], pivots array, CMatrixLU result
                        N       -   size of A
                        B       -   array[0..N-1], right part
            
                    OUTPUT PARAMETERS
                        Info    -   return code:
                                    * -3    matrix is very badly conditioned or exactly singular.
                                    * -1    N<=0 was passed
                                    *  1    task is solved (but matrix A may be ill-conditioned,
                                            check R1/RInf parameters for condition numbers).
                        Rep     -   additional report, following fields are set:
                                    * rep.r1    condition number in 1-norm
                                    * rep.rinf  condition number in inf-norm
                        X       -   array[N], it contains:
                                    * info>0    =>  solution
                                    * info=-3   =>  filled by zeros
            
                      -- ALGLIB --
                         Copyright 27.01.2010 by Bochkanov Sergey
                    *************************************************************************/
                    public static void cmatrixmixedsolve(complex[,] a,
                        complex[,] lua,
                        int[] p,
                        int n,
                        complex[] b,
                        ref int info,
                        densesolverreport rep,
                        ref complex[] x,
                        alglib.xparams _params)
                    {
                        co ex[0, 0
                        ]x;


                        i
                            nf
                        x
                        f(n <= 0)


                        {
                            i
                                n
                        }
                        bm = new complex[n, 1];
                        for (i_ = 0; i_ <= n - 1; i_++)
                        {
                            bm[i_, 0] = b[i_];
                        }

                        cmatrixmixedsolvem(a, lua, p, n, bm, 1, ref info, rep, ref xm, _params);
                        x = new complex[n];
                        for (i_ = 0; i_ <= n - 1; i_++)
                        {
                            x[i_] = xm[i_, 0];
                        }
                    }


                    /*************************************************************************
                    Dense solver for A*X=B with N*N symmetric positive definite matrix A,  and
                    N*M vectors X and B. It is "slow-but-feature-rich" version of the solver.
            
                    Algorithm features:
                    * automatic detection of degenerate cases
                    * condition number estimation
                    * O(N^3+M*N^2) complexity
                    * matrix is represented by its upper or lower triangle
            
                    No iterative refinement is provided because such partial representation of
                    matrix does not allow efficient calculation of extra-precise  matrix-vector
                    products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
                    need iterative refinement.
            
                    IMPORTANT: ! this function is NOT the most efficient linear solver provided
                               ! by ALGLIB. It estimates condition  number  of  linear system,
                               ! which  results  in  significant   performance   penalty  when
                               ! compared with "fast" version  which  just  performs  Cholesky
                               ! decomposition and calls triangular solver.
                               !
                               ! This  performance  penalty  is  especially  visible  in   the
                               ! multithreaded mode, because both condition number  estimation
                               ! and   iterative    refinement   are   inherently   sequential
                               ! calculations.
                               !
                               ! Thus, if you need high performance and if you are pretty sure
                               ! that your system is well conditioned, we  strongly  recommend
                               ! you to use faster solver, SPDMatrixSolveMFast() function.
            
                    INPUT PARAMETERS
                        A       -   array[0..N-1,0..N-1], system matrix
                        N       -   size of A
                        IsUpper -   what half of A is provided
                        B       -   array[0..N-1,0..M-1], right part
                        M       -   right part size
            
                    OUTPUT PARAMETERS
                        Info    -   return code:
                                    * -3    matrix is very badly conditioned or non-SPD.
                                    * -1    N<=0 was passed
                                    *  1    task is solved (but matrix A may be ill-conditioned,
                                            check R1/RInf parameters for condition numbers).
                        Rep     -   additional report, following fields are set:
                                    * rep.r1    condition number in 1-norm
                                    * rep.rinf  condition number in inf-norm
                        X       -   array[N,M], it contains:
                                    * info>0    =>  solution
                                    * info=-3   =>  filled by zeros
            
                      ! FREE EDITION OF ALGLIB:
                      ! 
                      ! Free Edition of ALGLIB supports following important features for  this
                      ! function:
                      ! * C++ version: x64 SIMD support using C++ intrinsics
                      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
                      !
                      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
                      ! Reference Manual in order  to  find  out  how to activate SIMD support
                      ! in ALGLIB.
            
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
            
                      -- ALGLIB --
                         Copyright 27.01.2010 by Bochkanov Sergey
                    *************************************************************************/
                    public static void spdmatrixsolvem(double[,] a,
                        int n,
                        bool isupper,
                        double[,] b,
                        int m,
                        ref int info,
                        densesolverreport rep,
                        ref double[,] x,
                        alglib.xparams _params)
                    {
                        ,

                        a =
                            new dou
                        b
                            l
                        e
                            [0

                        i
                        n
                            t
                                =
                                0
                            ;


                        0;
                        j
                        1
                            =
                            0


                        0;
                        int i_ = 0;

                        info = 0;
                        x = new double[0, 0];


                        //
                        // prepare: check inputs, allocate space...
                        //
                        if (n <= 0 || m <= 0)
                        {
                            info = -1;
                            return;
                        }

                        da = new double[n, n];

                        //
                        // factorize
                        // solve
                        //
                        for (i = 0; i <= n - 1; i++)
                        {
                            if (isupper)
                            {
                                j1 = i;
                                j2 = n - 1;
                            }
                            else
                            {
                                j1 = 0;
                                j2 = i;
                            }

                            for (i_ = j1; i_ <= j2; i_++)
                            {
                                da[i, i_] = a[i, i_];
                            }
                        }

                        if (!trfac.spdmatrixcholesky(ref da, n, isupper, _params))
                        {
                            x = new double[n, m];
                            for (i = 0; i <= n - 1; i++)
                            {
                                for (j = 0; j <= m - 1; j++)
                                {
                                    x[i, j] = 0;
                                }
                            }

                            rep.r1 = 0;
                            rep.rinf = 0;
                            info = -3;
                            return;
                        }

                        info = 1;
                        spdmatrixcholeskysolveinternal(da, n, isupper, a, true, b, m, ref info, rep, ref x, _params);
                    }


                    /*************************************************************************
                    Dense solver for A*X=B with N*N symmetric positive definite matrix A,  and
                    N*M vectors X and B. It is "fast-but-lightweight" version of the solver.
            
                    Algorithm features:
                    * O(N^3+M*N^2) complexity
                    * matrix is represented by its upper or lower triangle
                    * no additional time consuming features
            
                    INPUT PARAMETERS
                        A       -   array[0..N-1,0..N-1], system matrix
                        N       -   size of A
                        IsUpper -   what half of A is provided
                        B       -   array[0..N-1,0..M-1], right part
                        M       -   right part size
            
                    OUTPUT PARAMETERS
                        Info    -   return code:
                                    * -3    A is is exactly singular
                                    * -1    N<=0 was passed
                                    *  1    task was solved
                        B       -   array[N,M], it contains:
                                    * info>0    =>  solution
                                    * info=-3   =>  filled by zeros
            
                      ! FREE EDITION OF ALGLIB:
                      ! 
                      ! Free Edition of ALGLIB supports following important features for  this
                      ! function:
                      ! * C++ version: x64 SIMD support using C++ intrinsics
                      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
                      !
                      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
                      ! Reference Manual in order  to  find  out  how to activate SIMD support
                      ! in ALGLIB.
            
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
            
                      -- ALGLIB --
                         Copyright 17.03.2015 by Bochkanov Sergey
                    *************************************************************************/
                    public static void spdmatrixsolvemfast(double[,] a,
                        int n,
                        bool isupper,
                        double[,] b,
                        int m,
                        ref int info,
                        alglib.xparams _params)
                    {
                        int i = 0;


                        i
                        t j = 0;


                        a
                            =
                            (
                        do
                            one
                                )
                        ;
                        info
                            = 0;


                        o = 1;
                            =0


                        etu
                            rn
                    }


                    i dmatri

                    x
                        cholesk
                        (ref a,
                            n, isupper
                                f

                    or(
                            i
                                =
                                0
                        ;


                    {
                        fo
                                (
                            = 
                            ;
                        j


                        b
                            info
                                =
                                -
                                    3
                            ;

                        if (isupper)
                        {
                            as. rs
                            m
                                n,
                                m
                            a

                            0,
                                , 1 ms);


                            rmatri
                                xl,
                                e,
                                f
                            lse
                            0, b,

                            0
                                ,
                            0
                                ,


                            {
                                abla ttr 0,
                                0
                                    ,

                                f
                                    a
                                s
                                    e,
                                    f
                                a
                                l
                                    e, 
                                0, ar
                                    ablas
                                rm m ls, 
                                1
                                    ,
                            }
                        }


                        /*************************************************************************
                        Dense linear solver for A*x=b with N*N real  symmetric  positive  definite
                        matrix A,  N*1 vectors x and b.  "Slow-but-feature-rich"  version  of  the
                        solver.
                
                        Algorithm features:
                        * automatic detection of degenerate cases
                        * condition number estimation
                        * O(N^3) complexity
                        * matrix is represented by its upper or lower triangle
                
                        No iterative refinement is provided because such partial representation of
                        matrix does not allow efficient calculation of extra-precise  matrix-vector
                        products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
                        need iterative refinement.
                
                        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                                   ! by ALGLIB. It estimates condition  number  of  linear system,
                                   ! which  results  in  significant   performance   penalty  when
                                   ! compared with "fast" version  which  just  performs  Cholesky
                                   ! decomposition and calls triangular solver.
                                   !
                                   ! This  performance  penalty  is  especially  visible  in   the
                                   ! multithreaded mode, because both condition number  estimation
                                   ! and   iterative    refinement   are   inherently   sequential
                                   ! calculations.
                                   !
                                   ! Thus, if you need high performance and if you are pretty sure
                                   ! that your system is well conditioned, we  strongly  recommend
                                   ! you to use faster solver, SPDMatrixSolveFast() function.
                
                        INPUT PARAMETERS
                            A       -   array[0..N-1,0..N-1], system matrix
                            N       -   size of A
                            IsUpper -   what half of A is provided
                            B       -   array[0..N-1], right part
                
                        OUTPUT PARAMETERS
                            Info    -   return code:
                                        * -3    matrix is very badly conditioned or non-SPD.
                                        * -1    N<=0 was passed
                                        *  1    task is solved (but matrix A may be ill-conditioned,
                                                check R1/RInf parameters for condition numbers).
                            Rep     -   additional report, following fields are set:
                                        * rep.r1    condition number in 1-norm
                                        * rep.rinf  condition number in inf-norm
                            X       -   array[N], it contains:
                                        * info>0    =>  solution
                                        * info=-3   =>  filled by zeros
                
                          ! FREE EDITION OF ALGLIB:
                          ! 
                          ! Free Edition of ALGLIB supports following important features for  this
                          ! function:
                          ! * C++ version: x64 SIMD support using C++ intrinsics
                          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
                          !
                          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
                          ! Reference Manual in order  to  find  out  how to activate SIMD support
                          ! in ALGLIB.
                
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
                
                          -- ALGLIB --
                             Copyright 27.01.2010 by Bochkanov Sergey
                        *************************************************************************/
                        public static void spdmatrixsolve(double[,] a,
                            int n,
                            bool isupper,
                            double[] b,
                            ref int info,
                            densesolverreport rep,
                            ref double[] x,
                            alglib.xparams _params)
                        {
                            do
                                ble[
                                    b
                                        =
                                        w do
                                bl e, ] xm e[int

                            i_ = 0;


                            n
                                f
                                    = 0;


                            x
                                ne w do
                                bl e0 ]
                                    ;


                            if (
                                n

                            info
                                =
                                -
                                ;


                            eturn
                        }


                        n, 1];
                        for (i_ = 0; i_ <= n - 1; i_++)
                        {
                            bm[i_, 0] = b[i_];
                        }

                        spdmatrixsolvem(a, n, isupper, bm, 1, ref info, rep, ref xm, _params);
                        x = new double[n];
                        for (i_ = 0; i_ <= n - 1; i_++)
                        {
                            x[i_] = xm[i_, 0];
                        }
                    }


                    /*************************************************************************
                    Dense linear solver for A*x=b with N*N real  symmetric  positive  definite
                    matrix A,  N*1 vectors x and  b.  "Fast-but-lightweight"  version  of  the
                    solver.
            
                    Algorithm features:
                    * O(N^3) complexity
                    * matrix is represented by its upper or lower triangle
                    * no additional time consuming features like condition number estimation
            
                    INPUT PARAMETERS
                        A       -   array[0..N-1,0..N-1], system matrix
                        N       -   size of A
                        IsUpper -   what half of A is provided
                        B       -   array[0..N-1], right part
            
                    OUTPUT PARAMETERS
                        Info    -   return code:
                                    * -3    A is is exactly singular or non-SPD
                                    * -1    N<=0 was passed
                                    *  1    task was solved
                        B       -   array[N], it contains:
                                    * info>0    =>  solution
                                    * info=-3   =>  filled by zeros
            
                      ! FREE EDITION OF ALGLIB:
                      ! 
                      ! Free Edition of ALGLIB supports following important features for  this
                      ! function:
                      ! * C++ version: x64 SIMD support using C++ intrinsics
                      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
                      !
                      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
                      ! Reference Manual in order  to  find  out  how to activate SIMD support
                      ! in ALGLIB.
            
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
            
                      -- ALGLIB --
                         Copyright 17.03.2015 by Bochkanov Sergey
                    *************************************************************************/
                    public static void spdmatrixsolvefast(double[,] a,
                        int n,
                        bool isupper,
                        double[] b,
                        ref int info,
                        alglib.xparams _params)
                    {
                        a
                        (double[,
                            a.C
                        ne
                            ;

                        info = 0;
                            in
                        o = 1;

                        if (n <= 0


                        {
                            nfo
                                =
                                1;


                            ret
                        }


                        trfac.spdm
                            trixcho
                        es
                        y(ref
                            a, r


                        {
                            for (i = 0;
                                 i <= n - 1;
                                 i
                                 +)

                            {
                                b
                                    i] = 0.0
                                    ;
                            }


                            inf
                                = -3;


                            return;
                        }

                        pdbasiccholesk
                            solve(a
                                    n
                                ,
                                sup
                                    e

                        r
                            b, _par
                        am
                    }


                    /*************************************************************************
                    Dense solver for A*X=B with N*N symmetric positive definite matrix A given
                    by its Cholesky decomposition, and N*M vectors X and B. It  is  "slow-but-
                    feature-rich" version of the solver which estimates  condition  number  of
                    the system.
            
                    Algorithm features:
                    * automatic detection of degenerate cases
                    * O(M*N^2) complexity
                    * condition number estimation
                    * matrix is represented by its upper or lower triangle
            
                    No iterative refinement is provided because such partial representation of
                    matrix does not allow efficient calculation of extra-precise  matrix-vector
                    products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
                    need iterative refinement.
            
                    IMPORTANT: ! this function is NOT the most efficient linear solver provided
                               ! by ALGLIB. It estimates condition  number  of  linear system,
                               ! which  results  in  significant  performance   penalty   when
                               ! compared with "fast"  version  which  just  calls  triangular
                               ! solver. Amount of  overhead  introduced  depends  on  M  (the
                               ! larger - the more efficient).
                               !
                               ! This performance penalty is insignificant  when compared with
                               ! cost of large LU decomposition.  However,  if you  call  this
                               ! function many times for the same  left  side,  this  overhead
                               ! BECOMES significant. It  also  becomes significant for small-
                               ! scale problems (N<50).
                               !
                               ! In such cases we strongly recommend you to use faster solver,
                               ! SPDMatrixCholeskySolveMFast() function.
            
                    INPUT PARAMETERS
                        CHA     -   array[0..N-1,0..N-1], Cholesky decomposition,
                                    SPDMatrixCholesky result
                        N       -   size of CHA
                        IsUpper -   what half of CHA is provided
                        B       -   array[0..N-1,0..M-1], right part
                        M       -   right part size
            
                    OUTPUT PARAMETERS
                        Info    -   return code:
                                    * -3    A is is exactly singular or badly conditioned
                                            X is filled by zeros in such cases.
                                    * -1    N<=0 was passed
                                    *  1    task was solved
                        Rep     -   additional report, following fields are set:
                                    * rep.r1    condition number in 1-norm
                                    * rep.rinf  condition number in inf-norm
                        X       -   array[N]:
                                    * for info>0 contains solution
                                    * for info=-3 filled by zeros
            
                      -- ALGLIB --
                         Copyright 27.01.2010 by Bochkanov Sergey
                    *************************************************************************/
                    public static void spdmatrixcholeskysolvem(double[,] cha,
                        int n,
                        bool isupper,
                        double[,] b,
                        int m,
                        ref int info,
                        densesolverreport rep,
                        ref double[,] x,
                        alglib.xparams _params)
                    {
                        d
                            ou t
                            a
                                = new do
                            ble[0,
                                ]
                                ;


                        info = 
                            ;


                        x =
                            new double[
                                //

                                // pr
                                ep
                        c
                            te
                        space...
                            /
                        if (n <= 0 || m <= 0)


                        {
                            i
                                fo = -1;


                            et
                                rn;


                            // so
                            ve

                                //
                                pd
                            atrixc
                                hl nt
                                rnal(c
                                        a, mptya, fa
                                        se, b
                                    , m,
                                    ef
                                        info, rep

                            ref x , _params)
                            ;
                        }


                        /*************************************************************************
                        Dense solver for A*X=B with N*N symmetric positive definite matrix A given
                        by its Cholesky decomposition, and N*M vectors X and B. It  is  "fast-but-
                        lightweight" version of  the  solver  which  just  solves  linear  system,
                        without any additional functions.
                
                        Algorithm features:
                        * O(M*N^2) complexity
                        * matrix is represented by its upper or lower triangle
                        * no additional functionality
                
                        INPUT PARAMETERS
                            CHA     -   array[N,N], Cholesky decomposition,
                                        SPDMatrixCholesky result
                            N       -   size of CHA
                            IsUpper -   what half of CHA is provided
                            B       -   array[N,M], right part
                            M       -   right part size
                
                        OUTPUT PARAMETERS
                            Info    -   return code:
                                        * -3    A is is exactly singular or badly conditioned
                                                X is filled by zeros in such cases.
                                        * -1    N<=0 was passed
                                        *  1    task was solved
                            B       -   array[N]:
                                        * for info>0 overwritten by solution
                                        * for info=-3 filled by zeros
                
                          -- ALGLIB --
                             Copyright 18.03.2015 by Bochkanov Sergey
                        *************************************************************************/
                        public static void spdmatrixcholeskysolvemfast(double[,] cha,
                            int n,
                            bool isupper,
                            double[,] b,
                            int m,
                            ref int info,
                            alglib.xparams _params)
                        {
                            i
                            t i = 0;

                            int j = 0
                                ;


                            int
                                k
                            0;


                            info
                            0;


                            info = 
                                <=
                                )


                            {
                                info
                                    - 1
                            }


                            r(
                                0;
                            k <= n - 1;
                            +)

                            {
                                a
                                    k, k])==(
                                    oubl
                                )(0.0)


                                {
                                    f )


                                    {
                                        fo
                                            j =
                                                =
                                        m - 1;


                                        {
                                            .0
                                        }


                                        info =
                                            3;
                                        e
                                            urn;
                                    }
                                }


                                ( is
                                per )

                                abl
                                s.rma
                                    rix
                                eft
                                rsm(
                                    m,
                                    a, 0
                                    ,
                                    , tr
                                    , false,)


                                ab
                                    l
                                s.atri
                                efttrsm
                                    n,
                                    m,
                                    cha,
 
                                    ,
  0
                                true
                                    , _
                                    arams
                                    ;
                            }


                            abl
                            s.rma
                                ri
                            lefttrsm
                                n, m, cha
                            0,
                            0,
                            fal
                                e, fal
                            e, 0,
                            b,
                            ablas.rmatrixle
                                f
                            t
                            rsm(n, m
                                , cha, 0, 0, fal
                            e, false, 1 par
                        }
                    }


                    /*************************************************************************
                    Dense solver for A*x=b with N*N symmetric positive definite matrix A given
                    by its Cholesky decomposition, and N*1 real vectors x and b. This is "slow-
                    but-feature-rich"  version  of  the  solver  which,  in  addition  to  the
                    solution, performs condition number estimation.
            
                    Algorithm features:
                    * automatic detection of degenerate cases
                    * O(N^2) complexity
                    * condition number estimation
                    * matrix is represented by its upper or lower triangle
            
                    No iterative refinement is provided because such partial representation of
                    matrix does not allow efficient calculation of extra-precise  matrix-vector
                    products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
                    need iterative refinement.
            
                    IMPORTANT: ! this function is NOT the most efficient linear solver provided
                               ! by ALGLIB. It estimates condition  number  of  linear system,
                               ! which results in 10-15x  performance  penalty  when  compared
                               ! with "fast" version which just calls triangular solver.
                               !
                               ! This performance penalty is insignificant  when compared with
                               ! cost of large LU decomposition.  However,  if you  call  this
                               ! function many times for the same  left  side,  this  overhead
                               ! BECOMES significant. It  also  becomes significant for small-
                               ! scale problems (N<50).
                               !
                               ! In such cases we strongly recommend you to use faster solver,
                               ! SPDMatrixCholeskySolveFast() function.
            
                    INPUT PARAMETERS
                        CHA     -   array[N,N], Cholesky decomposition,
                                    SPDMatrixCholesky result
                        N       -   size of A
                        IsUpper -   what half of CHA is provided
                        B       -   array[N], right part
            
                    OUTPUT PARAMETERS
                        Info    -   return code:
                                    * -3    A is is exactly singular or ill conditioned
                                            X is filled by zeros in such cases.
                                    * -1    N<=0 was passed
                                    *  1    task is solved
                        Rep     -   additional report, following fields are set:
                                    * rep.r1    condition number in 1-norm
                                    * rep.rinf  condition number in inf-norm
                        X       -   array[N]:
                                    * for info>0  - solution
                                    * for info=-3 - filled by zeros
            
                      -- ALGLIB --
                         Copyright 27.01.2010 by Bochkanov Sergey
                    *************************************************************************/
                    public static void spdmatrixcholeskysolve(double[,] cha,
                        int n,
                        bool isupper,
                        double[] b,
                        ref int info,
                        densesolverreport rep,
                        ref double[] x,
                        alglib.xparams _params)


                    b
                    e[0
                    0];


                    do
                        bl
                            [,] xm =
                                nt i
                        _
                            =
                            0;


                    i
                        x 0];


                    if (
                        n <
                        0)

                    {
                        i
                            n
                        f
                            o
                                =
                                -
                                    1
                            ;


                        r
                            e
                        t
                            u
                        r
                            n
                            ;
                    }


                    b
                        m
                            = new double[n,
                            ];


                    for (i_ = 0; i_ <= n - 1; i_++)


                    {
                        b
                        [
                            i_
                    }

                    spdma
                        t
                    r
                        i
                    c
                        ho cha
                        n, ,  1
                    re
                    inf
                        o, , _par
                    a
                        ms);


                    x = new d


                    o
                        r
                        ;
                    i_
                        +
                        x
                            [
                }
            }


            /*************************************************************************
            Dense solver for A*x=b with N*N symmetric positive definite matrix A given
            by its Cholesky decomposition, and N*1 real vectors x and b. This is "fast-
            but-lightweight" version of the solver.
    
            Algorithm features:
            * O(N^2) complexity
            * matrix is represented by its upper or lower triangle
            * no additional features
    
            INPUT PARAMETERS
                CHA     -   array[N,N], Cholesky decomposition,
                            SPDMatrixCholesky result
                N       -   size of A
                IsUpper -   what half of CHA is provided
                B       -   array[N], right part
    
            OUTPUT PARAMETERS
                Info    -   return code:
                            * -3    A is is exactly singular or ill conditioned
                                    X is filled by zeros in such cases.
                            * -1    N<=0 was passed
                            *  1    task is solved
                B       -   array[N]:
                            * for info>0  - overwritten by solution
                            * for info=-3 - filled by zeros
    
              -- ALGLIB --
                 Copyright 27.01.2010 by Bochkanov Sergey
            *************************************************************************/
            public static void spdmatrixcholeskysolvefast(double[,] cha,
                int n,
                bool isupper,
                double[] b,
                ref int info,
                alglib.xparams _params)

            nt i = 0
                ;

            int k =
                0;


            info = 
                ;


            n
            f
                o
                    = 
                ;
            if (n <
                0)


                inf
                    = -1;


            r
                tur
                ;


            for (k = 0
                k <= n - 1;
            ++)


            {
                i
                    ((doub
                e)(cha[k, k]) ==
                    double)(0.0) )


                {
                    f
                    r(
                        = 0;
                    i
                        <
                        = n - 1;
                    i
                        )


                    {
                        b
                            [
                            ] =
                            0.0;
                    }


                    info = -
                        ;


                    return;
                }


                spdbasicc
                    olesky
                olve(c
                a, n, isu
            }


            /*************************************************************************
            Dense solver for A*X=B, with N*N Hermitian positive definite matrix A  and
            N*M  complex  matrices  X  and  B.  "Slow-but-feature-rich" version of the
            solver.
    
            Algorithm features:
            * automatic detection of degenerate cases
            * condition number estimation
            * O(N^3+M*N^2) complexity
            * matrix is represented by its upper or lower triangle
    
            No iterative refinement is provided because such partial representation of
            matrix does not allow efficient calculation of extra-precise  matrix-vector
            products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
            need iterative refinement.
    
            IMPORTANT: ! this function is NOT the most efficient linear solver provided
                       ! by ALGLIB. It estimates condition  number  of  linear system,
                       ! which  results  in  significant  performance   penalty   when
                       ! compared with "fast"  version  which  just  calls  triangular
                       ! solver.
                       !
                       ! This performance penalty is especially apparent when you  use
                       ! ALGLIB parallel capabilities (condition number estimation  is
                       ! inherently  sequential).  It   also   becomes significant for
                       ! small-scale problems (N<100).
                       !
                       ! In such cases we strongly recommend you to use faster solver,
                       ! HPDMatrixSolveMFast() function.
    
            INPUT PARAMETERS
                A       -   array[0..N-1,0..N-1], system matrix
                N       -   size of A
                IsUpper -   what half of A is provided
                B       -   array[0..N-1,0..M-1], right part
                M       -   right part size
    
            OUTPUT PARAMETERS
                Info    -   same as in RMatrixSolve.
                            Returns -3 for non-HPD matrices.
                Rep     -   same as in RMatrixSolve
                X       -   same as in RMatrixSolve
    
              ! FREE EDITION OF ALGLIB:
              ! 
              ! Free Edition of ALGLIB supports following important features for  this
              ! function:
              ! * C++ version: x64 SIMD support using C++ intrinsics
              ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
              !
              ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
              ! Reference Manual in order  to  find  out  how to activate SIMD support
              ! in ALGLIB.
    
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
    
              -- ALGLIB --
                 Copyright 27.01.2010 by Bochkanov Sergey
            *************************************************************************/
            public static void hpdmatrixsolvem(complex[,] a,
                int n,
                bool isupper,
                complex[,] b,
                int m,
                ref int info,
                densesolverreport rep,
                ref complex[,] x,
                alglib.xparams _params)
            {
                c
                    mplex, ]
                da =
                    new c
                om n
                    i
                    ;
                    in
                    in

                t i_
                        =
                        0
                    ;


                x
                    ew complex[
                        , 0
                    ;
                    /
                    /

                r
                pare:
                he
                    k inpt e
                pace..


                if (
                    n <= 0
                    ||
                    m <= 0)

                {
                    i
                        n
                    f
                        o
                            =
                            -
                                1
                        ;


                    r
                        e
                    t
                        u
                    r
                        n
                        ;
                }


                da = new complex
                n, n];


                //


                /
                fa
                    ct, s
                l
                ve //
                    <= n - 1;

                i
                    +
                    )
                {
                    per )


                    {
                        j1
                            =
                            i


                        j
                            = n
                              -
                    }


                    i;


                    f r


                    {
                        =
                    }
                }


                i
                f(
                    !
                        r
                y
                    ar m
                    s) )


                {
                    m
                        fo r( = 
                        ; <=n
                        -
                        or(j
                    0
                    j = 
                }
            }


            r
            p
                .
            1 = 0;


            rep.rinf = 0;
            info = -3;
            return;
        }

        info = 1;
        hpdmatrixcholeskysolveinternal(da, n, isupper, a, true, b, m, ref info, rep, ref x, _params);
    }


    /*************************************************************************
    Dense solver for A*X=B, with N*N Hermitian positive definite matrix A  and
    N*M complex matrices X and B. "Fast-but-lightweight" version of the solver.

    Algorithm features:
    * O(N^3+M*N^2) complexity
    * matrix is represented by its upper or lower triangle
    * no additional time consuming features like condition number estimation

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        IsUpper -   what half of A is provided
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS
        Info    -   return code:
                    * -3    A is is exactly  singular or is not positive definite.
                            B is filled by zeros in such cases.
                    * -1    N<=0 was passed
                    *  1    task is solved
        B       -   array[0..N-1]:
                    * overwritten by solution
                    * zeros, if problem was not solved

      ! FREE EDITION OF ALGLIB:
      ! 
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

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

      -- ALGLIB --
         Copyright 17.03.2015 by Bochkanov Sergey
    *************************************************************************/
    public static void hpdmatrixsolvemfast(complex[,] a,
        int n,
        bool isupper,
        complex[,] b,
        int m,
        ref int info,
        alglib.xparams _params)
    {
        ;


        i
        t j = 0;


        a =
            (c a
            info
                = 0


        info = 1;
        if (n
            = 0)


            info
                - 1;


        re
            urn
    }

    c
        hpdmatr
    xcholesk
    (ref a,
        ,
        supper, _p
    rams) )


    f
    r(i++)


    for (j = 0;
         j
         <
         =
         m
         -
         1;
         j
         +
         +
        )


    {
        b
            [
                i
                ,
                j
            ]
            =
            0
                .
        0
            ;
    }
}


i
    n;


if (
    i
s
    u
p
    er


a
    las
cmat
ri m, a,  0, 0, true
fa
    ls 0,
    params)
;


blas.c
    m
atrixle
ttrsm(n
    , m, a, 0,
    0, b, 0,,
    _ ar
ms;


}
e
a
l
s
c
ma (n,
, 0
b
,
al fttr
m
n
,
e
e,
2, b, 0
,,
_ a
}


/*************************************************************************
Dense solver for A*x=b, with N*N Hermitian positive definite matrix A, and
N*1 complex vectors  x  and  b.  "Slow-but-feature-rich"  version  of  the
solver.

Algorithm features:
* automatic detection of degenerate cases
* condition number estimation
* O(N^3) complexity
* matrix is represented by its upper or lower triangle

No iterative refinement is provided because such partial representation of
matrix does not allow efficient calculation of extra-precise  matrix-vector
products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which  results  in  significant   performance   penalty  when
           ! compared with "fast" version  which  just  performs  Cholesky
           ! decomposition and calls triangular solver.
           !
           ! This  performance  penalty  is  especially  visible  in   the
           ! multithreaded mode, because both condition number  estimation
           ! and   iterative    refinement   are   inherently   sequential
           ! calculations.
           !
           ! Thus, if you need high performance and if you are pretty sure
           ! that your system is well conditioned, we  strongly  recommend
           ! you to use faster solver, HPDMatrixSolveFast() function.

INPUT PARAMETERS
    A       -   array[0..N-1,0..N-1], system matrix
    N       -   size of A
    IsUpper -   what half of A is provided
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   same as in RMatrixSolve
                Returns -3 for non-HPD matrices.
    Rep     -   same as in RMatrixSolve
    X       -   same as in RMatrixSolve

  ! FREE EDITION OF ALGLIB:
  ! 
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void hpdmatrixsolve(complex[,] a,
    int n,
    bool isupper,
    complex[] b,
    ref int info,
    densesolverreport rep,
    ref complex[] x,
    alglib.xparams _params)
{
    comp
    ex[,] bm = new comp
    l
    ex[0, 0]
        ;


    ex[
        ]
        x lex[
        , 0];

    i_ = 0;
        = 0
        = n
    w c
    mple
    x[i
    f
        (n <= 0


    {
        nfo
            =
            -
            ;


        ur;


        m =
            new com
        p
            l
        e
        x
        [
            i_ = 0;
        i
            <

        {
            b
                m
            i_ 0
                ]
                =

            hpdm
                x
            s
            o
                m, , r
            x
                = new c mplex[n];


            r(i_ = 0
                ;
            i_ < n - 1;
            i
                +
                i_
                =
                x
            m
                [
                    _
                    , 0
                ]
                ;
        }
    }


    /*************************************************************************
    Dense solver for A*x=b, with N*N Hermitian positive definite matrix A, and
    N*1 complex vectors  x  and  b.  "Fast-but-lightweight"  version  of   the
    solver without additional functions.

    Algorithm features:
    * O(N^3) complexity
    * matrix is represented by its upper or lower triangle
    * no additional time consuming functions

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        IsUpper -   what half of A is provided
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        Info    -   return code:
                    * -3    A is is exactly singular or not positive definite
                            X is filled by zeros in such cases.
                    * -1    N<=0 was passed
                    *  1    task was solved 
        B       -   array[0..N-1]:
                    * overwritten by solution
                    * zeros, if A is exactly singular (diagonal of its LU
                      decomposition has exact zeros).

      ! FREE EDITION OF ALGLIB:
      ! 
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

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

      -- ALGLIB --
         Copyright 17.03.2015 by Bochkanov Sergey
    *************************************************************************/
    public static void hpdmatrixsolvefast(complex[,] a,
        int n,
        bool isupper,
        complex[] b,
        ref int info,
        alglib.xparams _params)


    int
        i =
            0;


    ex[
        C
    e();


    info = 
        ;


    if (n <= 0

    {
        info
            =
            t
        rn;
    }

    i
        (!trfac.pdmatrixc
    olesky(r
    f a
        n, is r
        ms) )


    or(
        = 0;
        <=n - 1;
    ++)


    {
        b[i]

        0.
            ;


        info
            = -3;
        r
    }


    h
        basi
    holeskysolve(a, n,
        isupper
    b
        _p
    rams);
}


/*************************************************************************
Dense solver for A*X=B with N*N Hermitian positive definite matrix A given
by its Cholesky decomposition and N*M complex matrices X  and  B.  This is
"slow-but-feature-rich" version of the solver which, in  addition  to  the
solution, estimates condition number of the system.

Algorithm features:
* automatic detection of degenerate cases
* O(M*N^2) complexity
* condition number estimation
* matrix is represented by its upper or lower triangle

No iterative refinement is provided because such partial representation of
matrix does not allow efficient calculation of extra-precise  matrix-vector
products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which  results  in  significant  performance   penalty   when
           ! compared with "fast"  version  which  just  calls  triangular
           ! solver. Amount of  overhead  introduced  depends  on  M  (the
           ! larger - the more efficient).
           !
           ! This performance penalty is insignificant  when compared with
           ! cost of large Cholesky decomposition.  However,  if  you call
           ! this  function  many  times  for  the same  left  side,  this
           ! overhead BECOMES significant. It  also   becomes  significant
           ! for small-scale problems (N<50).
           !
           ! In such cases we strongly recommend you to use faster solver,
           ! HPDMatrixCholeskySolveMFast() function.


INPUT PARAMETERS
    CHA     -   array[N,N], Cholesky decomposition,
                HPDMatrixCholesky result
    N       -   size of CHA
    IsUpper -   what half of CHA is provided
    B       -   array[N,M], right part
    M       -   right part size

OUTPUT PARAMETERS:
    Info    -   return code:
                * -3    A is singular, or VERY close to singular.
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task was solved
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N]:
                * for info>0 contains solution
                * for info=-3 filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void hpdmatrixcholeskysolvem(complex[,] cha,
    int n,
    bool isupper,
    complex[,] b,
    int m,
    ref int info,
    densesolverreport rep,
    ref complex[,] x,
    alglib.xparams _params)
[
]
ptya = ne
com
    ex, 0];
info =
    0;


x = new ,
    ];


/
p
epare:
c
eck
    nputs, a a
e.
    .


if
n <= 0 |
    m
    = 0 )


info = -
    ;


return;


}

// 1. sc
al m
x
|U[i
   ,
   j]|)
/
2.fac
oriz
    sca
e
    d
matrix


//
3

//

h
    d
m
    at
ixc
    o
l
skysolve
    in ,
n
isupper
    empty,
    fals
e
    b, m,  ref info
    r
p, ref
x, _par
    ms);
}


/*************************************************************************
Dense solver for A*X=B with N*N Hermitian positive definite matrix A given
by its Cholesky decomposition and N*M complex matrices X  and  B.  This is
"fast-but-lightweight" version of the solver.

Algorithm features:
* O(M*N^2) complexity
* matrix is represented by its upper or lower triangle
* no additional time-consuming features

INPUT PARAMETERS
    CHA     -   array[N,N], Cholesky decomposition,
                HPDMatrixCholesky result
    N       -   size of CHA
    IsUpper -   what half of CHA is provided
    B       -   array[N,M], right part
    M       -   right part size

OUTPUT PARAMETERS:
    Info    -   return code:
                * -3    A is singular, or VERY close to singular.
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task was solved
    B       -   array[N]:
                * for info>0 overwritten by solution
                * for info=-3 filled by zeros

  -- ALGLIB --
     Copyright 18.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void hpdmatrixcholeskysolvemfast(complex[,] cha,
    int n,
    bool isupper,
    complex[,] b,
    int m,
    ref int info,
    alglib.xparams _params)
{
    int
        i
    0;

    int j = 0;


    int k = 0;


    info = 
        ;


    info = 1;


    i
        (n <= 0)

    {
        info = -1;


        re
            urn;
    }


    fo
        (k = 0;
    k < n - 1;
    k++)


    {
        if (
            double)
            cha[
                , k].x) =
        (double)(0.0)
            & (double)(cha[k,
            ].y)
            = (d
        uble)
        0.0) )


        {
            f
                o
            r(i = 0;
            i <= n - 1;
            i++)


            {
                for (j = 0; j <= m - 1
                    j +


                {
                    b[
                        i
                    j
                        = 0
                    0;
                }
            }

            3;


            eturn;
        }
    }
    u
        per )


    ablas.cm
        ixleftt
        (n, m f

    lse, 2,
        , 0,
    0, _pa
        ms);


    blas.
        atrixlefttr
        rue, f
    a
        se,  0,
    b,
        , 0, _pa
        ms);
}


el
    blas
cmatrixle
f
    tt,
 
    ,
0,
_params);


ablas.cmat
    xlef
trsm(n,
    , cha e
2,
    ,
    , 0,
    params);
}
}


/*************************************************************************
Dense solver for A*x=b with N*N Hermitian positive definite matrix A given
by its Cholesky decomposition, and N*1 complex vectors x and  b.  This  is
"slow-but-feature-rich" version of the solver  which  estimates  condition
number of the system.

Algorithm features:
* automatic detection of degenerate cases
* O(N^2) complexity
* condition number estimation
* matrix is represented by its upper or lower triangle

No iterative refinement is provided because such partial representation of
matrix does not allow efficient calculation of extra-precise  matrix-vector
products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
need iterative refinement.

IMPORTANT: ! this function is NOT the most efficient linear solver provided
           ! by ALGLIB. It estimates condition  number  of  linear system,
           ! which results in 10-15x  performance  penalty  when  compared
           ! with "fast" version which just calls triangular solver.
           !
           ! This performance penalty is insignificant  when compared with
           ! cost of large LU decomposition.  However,  if you  call  this
           ! function many times for the same  left  side,  this  overhead
           ! BECOMES significant. It  also  becomes significant for small-
           ! scale problems (N<50).
           !
           ! In such cases we strongly recommend you to use faster solver,
           ! HPDMatrixCholeskySolveFast() function.

INPUT PARAMETERS
    CHA     -   array[0..N-1,0..N-1], Cholesky decomposition,
                SPDMatrixCholesky result
    N       -   size of A
    IsUpper -   what half of CHA is provided
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is is exactly singular or ill conditioned
                        X is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved
    Rep     -   additional report, following fields are set:
                * rep.r1    condition number in 1-norm
                * rep.rinf  condition number in inf-norm
    X       -   array[N]:
                * for info>0  - solution
                * for info=-3 - filled by zeros

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
public static void hpdmatrixcholeskysolve(complex[,] cha,
    int n,
    bool isupper,
    complex[] b,
    ref int info,
    densesolverreport rep,
    ref complex[] x,
    alglib.xparams _params)


om
lex[complex
0
    ;


co
    pl
x[,] xm =  [
    i
n
    t

_ = 0


o
    x =
        new omplex[0];


if
(
    r
n


}
bm
= new co
    mp
_ <
    n - 1;
i_
    +)


{
    ]
}
l
    m,
    n,
    isu
per, bm o
r
    xm, _
p
    a
r
    am c
    mpl
x[n]
    ;


or
    i_ = 0;
i_ <
    x[i
    ]
xm[i, 
}
}


/*************************************************************************
Dense solver for A*x=b with N*N Hermitian positive definite matrix A given
by its Cholesky decomposition, and N*1 complex vectors x and  b.  This  is
"fast-but-lightweight" version of the solver.

Algorithm features:
* O(N^2) complexity
* matrix is represented by its upper or lower triangle
* no additional time-consuming features

INPUT PARAMETERS
    CHA     -   array[0..N-1,0..N-1], Cholesky decomposition,
                SPDMatrixCholesky result
    N       -   size of A
    IsUpper -   what half of CHA is provided
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    Info    -   return code:
                * -3    A is is exactly singular or ill conditioned
                        B is filled by zeros in such cases.
                * -1    N<=0 was passed
                *  1    task is solved
    B       -   array[N]:
                * for info>0  - overwritten by solution
                * for info=-3 - filled by zeros

  -- ALGLIB --
     Copyright 18.03.2015 by Bochkanov Sergey
*************************************************************************/
public static void hpdmatrixcholeskysolvefast(complex[,] cha,
    int n,
    bool isupper,
    complex[] b,
    ref int info,
    alglib.xparams _params)
{
    n
        t
    i

    0;


    i
        k
    0


    inf = 1;
    if (n <= 0)
    {
        info = -1;
        return;
    }

    for (k = 0; k <= n - 1; k++)
    {
        if ((double)(cha[k, k].x) == (double)(0.0) && (double)(cha[k, k].y) == (double)(0.0))
        {
            for (i = 0; i <= n - 1; i++)
            {
                b[i] = 0.0;
            }

            info = -3;
            return;
        }
    }

    hpdbasiccholeskysolve(cha, n, isupper, b, _params);
}


/*************************************************************************
Dense solver.

This subroutine finds solution of the linear system A*X=B with non-square,
possibly degenerate A.  System  is  solved in the least squares sense, and
general least squares solution  X = X0 + CX*y  which  minimizes |A*X-B| is
returned. If A is non-degenerate, solution in the usual sense is returned.

Algorithm features:
* automatic detection (and correct handling!) of degenerate cases
* iterative refinement
* O(N^3) complexity

INPUT PARAMETERS
    A       -   array[0..NRows-1,0..NCols-1], system matrix
    NRows   -   vertical size of A
    NCols   -   horizontal size of A
    B       -   array[0..NCols-1], right part
    Threshold-  a number in [0,1]. Singular values  beyond  Threshold  are
                considered  zero.  Set  it to 0.0, if you don't understand
                what it means, so the solver will choose good value on its
                own.
                
OUTPUT PARAMETERS
    Info    -   return code:
                * -4    SVD subroutine failed
                * -1    if NRows<=0 or NCols<=0 or Threshold<0 was passed
                *  1    if task is solved
    Rep     -   solver report, see below for more info
    X       -   array[0..N-1,0..M-1], it contains:
                * solution of A*X=B (even for singular A)
                * zeros, if SVD subroutine failed

SOLVER REPORT

Subroutine sets following fields of the Rep structure:
* R2        reciprocal of condition number: 1/cond(A), 2-norm.
* N         = NCols
* K         dim(Null(A))
* CX        array[0..N-1,0..K-1], kernel of A.
            Columns of CX store such vectors that A*CX[i]=0.

  ! FREE EDITION OF ALGLIB:
  ! 
  ! Free Edition of ALGLIB supports following important features for  this
  ! function:
  ! * C++ version: x64 SIMD support using C++ intrinsics
  ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
  !
  ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
  ! Reference Manual in order  to  find  out  how to activate SIMD support
  ! in ALGLIB.

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

  -- ALGLIB --
     Copyright 24.08.2009 by Bochkanov Sergey
*************************************************************************/
public static void rmatrixsolvels(double[,] a,
    int nrows,
    int ncols,
    double[] b,
    double threshold,
    ref int info,
    densesolverlsreport rep,
    ref double[] x,
    alglib.xparams _params)


ouble[] sv
n
    w d
uble[
];

double[,] u
n
    w double[0
0];


double[] vt = new dou
le[0, 0];
ubl
    p
new d
    o
u
    bl
e
    [
        0
    ]
    ;


dou
le[] utb = ne
w ouble[] sutb = ne
double
    b
        ] tm
    =
    ne


dou
le[]
    ta
        = n
w
ouble[0];
    ]
    = ne
    w

do
    u
        b
l
e
[
];

double[] bu
    = new doub
o
e[] w
new
d t
i
    in
j = 0;


int nsv
    ;


doub
    e
        = 0


b
    ol
vdfaile
    zer
a
new bo
t
    s = 0
    ;


b
    l
terminatene
tt
    me = new
        mal
err
    =
    n
w
bool ()
    = 
    ;


;

x
    = ne
d
uble[0];

if (
    (
        n
r
    o
w
    s
        <
        =
0
    |
    |

n
    c
o
    l
s
    <
    =
    0
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
    t
h
    r
e
    s
h
    o
l
    d
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
    info
        - 1;
    return;
}

dou
    l
e) =(do
    ble)(0)
    ) {
    old
        = 1
    00 * m
    at ilon;
}


F
    a

sv
    f
i
    ld rixs
d
    a, , 
1

2,
    , u, );


ble)(s
v[ )(
    i
f
(
    v
df
    a
i
    l
e
    ||
    z


if (
    s
v
    dfa
i
    l
e
    d
    )


i
n
    fo
        = -4;
    =
ne i <= n
o
s
    -
    1;
{
    x[rep.n
        = n
    c
        l
    s
        re
    p
        .k = ncols;
    rep.cx = new double[ncols, ncols];
    for (i = 0; i <= ncols - 1; i++)
    {
        for (j = 0; j <= ncols - 1; j++)
        {
            if (i == j)
            {
                rep.cx[i, j] = 1;
            }
            else
            {
                rep.cx[i, j] = 0;
            }
        }
    }

    rep.r2 = 0;
    return;
}
nsv = Math.Min(ncols, nrows);
if (nsv == ncols)
{
    rep.r2 = sv[nsv - 1] / sv[0];
}
else
{
    rep.r2 = 0;
}

rep.n = ncols;
info = 1;

//
// Iterative refinement of xc combined with solution:
// 1. xc = 0
// 2. calculate r = bc-A*xc using extra-precise dot product
// 3. solve A*y = r
// 4. update x:=x+r
// 5. goto 2
//
// This cycle is executed until one of two things happens:
// 1. maximum number of iterations reached
// 2. last iteration decreased error to the lower limit
//
utb = new double[nsv];
sutb = new double[nsv];
x = new double[ncols];
tmp = new double[ncols];
ta = new double[ncols + 1];
tx = new double[ncols + 1];
buf = new double[ncols + 1];
for (i = 0; i <= ncols - 1; i++)
{
    x[i] = 0;
}

kernelidx = nsv;
for (i = 0; i <= nsv - 1; i++)
{
    if ((double)(sv[i]) <= (double)(threshold * sv[0]))
    {
        kernelidx = i;
        break;
    }
}

rep.k = ncols - kernelidx;
nrfs = densesolverrfsmaxv2(ncols, rep.r2, _params);
terminatenexttime = false;
rp = new double[nrows];
for (rfs = 0; rfs <= nrfs; rfs++)
{
    if (terminatenexttime)
    {
        break;
    }

    //
    // calculate right part
    //
    if (rfs == 0)
    {
        for (i_ = 0; i_ <= nrows - 1; i_++)
        {
            rp[i_] = b[i_];
        }
    }
    else
    {
        smallerr = true;
        for (i = 0; i <= nrows - 1; i++)
        {
            for (i_ = 0; i_ <= ncols - 1; i_++)
            {
                ta[i_] = a[i, i_];
            }

            ta[ncols] = -1;
            for (i_ = 0; i_ <= ncols - 1; i_++)
            {
                tx[i_] = x[i_];
            }

            tx[ncols] = b[i];
            xblas.xdot(ta, tx, ncols + 1, ref buf, ref v, ref verr, _params);
            rp[i] = -v;
            smallerr = smallerr && (double)(Math.Abs(v)) < (double)(4 * verr);
        }

        if (smallerr)
        {
            te
                r
            minate
                n
            e
                x
            t
            im

                //
                * dx
                    = r
                      /
                      f
            r(i
                = 0;
            i
                +)


            tmp[i
            ] = 0;


            or(i = 0
                ;

            i
                <=


            {
                ] = 0;
            }


            (i = 0;
            i
                <
                nr
            w
                - 1;
            i++)


            v = r
            p
            [
                i
            ];


            for (
                _
                0;
            _ <= nsv
                -
                1
                ;
            i_
                i_] =
            u
            t
                [i
                ]
                + v
            u[i, i_
                ]
                ;
        }
    }


    for (i
             =
             0
        i <
            n
    v - 1
    i++)


    if
    (
        i
        < k


    utb
        i]

    t
    b[
}

e
    s
e

{
    sutb[i] =
        0
}


i = 0
i <
    n
v
    - 1


{
    v = sutb[i];


    i_ <
        ncols - 1;
    _
        +)


    tmp[
            _
                = v
                [
                    , i_
        ;


    //


    at
        fo nc


    {
        x +
    }
}


if (rep.k r
    p
c
    x =
        new double
        [
            n
c
    ls, r
e
    .k];


f
    o
(i = 
    ;
    <=r
p.k
1;
i++)


{
    f
        o
    r(i_ = 0
        ;

    i
    _
        <= )


    i_
        ,
        ] = vt[ke
    ne
}


/*************************************************************************
Internal LU solver

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
private static void rmatrixlusolveinternal(double[,] lua,
    int[] p,
    int n,
    double[,] a,
    bool havea,
    double[,] b,
    int m,
    ref int info,
    densesolverreport rep,
    ref double[,] x,
    alglib.xparams _params)
{
    i
    nt i
        =
        0;


    ;


    int
        k


    0;

    fs t n
        r
    f
        s
            =
            0
        ;


    do le ]
    y
        =
        n
    e
        d ub
        d
    o
        b
    e
        [] doub e[
        d
    o
        u
    b
        l
            = rr ub err
        =
        e

    bo bool
        t ti l()


    int
        _ = 0
        ;
        in
    f
        =
        0;


    d
        /
        /
        / ck in te
        /
        n )


    {
        i
            f
        o
            urn
    }
    for (i = 0; i <= n - 1; i++)
    {
        if (p[i] > n -)
        {
            info = -1;
            eturn;
        }

        x e[n, m];
        new xc = new double[n];
        bc = new double tx = new double[n + 1];
        xa = n + 1];
        xb = new double[n + 1];

        est
            m
        te
            onditi
        o
            n n
            u
        mb nea

        ing
            larity


        rep.r
        1
            = rc
        o
            nd ond
        (
            ua,
            n, _pa
        r
            ams);


        p.
            i
            f =
                rcond.r
        matri
            x
        l
            u
        rc n,
            _
        ara
            s);


        i rep
        r
            )<(
            ouble)
        (
            rcond
                .r
        c
            on par
            a
        m
            s
            )
            )
            |
            |
        (doub
        l
            e
            )
        r
        ep
            .r )(h
        o
            l
        d
            _
        a
            ra

        or(
            i = ++)


        {
            m -
                1

            j++)


            {
                0;
            }


            rep
                .r f
                info
                    = -3;

            etur
                ;
        }


        nfo
            =
            1

            //
            / Fir
        st lu
        i
        n:
        ough s
        o
            lutio
        n
            w


        //


        m
        xb <=
            n
        1;
        i++)
            )


        Math.Max(mxb, Math.Abs(;
            =0;

        i <
            =
            n
            -
            ;
        i +
            +)


        f(

        {
            =m v

            x
                [i


            x
            [p
                [i
        }
    }


    n, 0,

    x,
        ,
    0
        ,

    _
        pa
    r
    am at, 
    0
        , tru
        e

    a
        l
    se
        /
        /
    ag
        /
        or
        (
            k = 0;
    k
        =
        -
            1
        ;

    k +
        n
    fs =
        d
    e
        n
    eso
        ver

    r
        sma
        (
            n
                re
                .

    r1,

    ep.rinf
        ,
    _
        e
    m
        i
    na

    for
        rf
            =
            0;
    rfs
        <
        =
        nrfs
        -
        1;
    r
        f
    s
        +
        +
        )


    en
        e
    ttime )


    b re ak;


    ge
        r
    t
    ru e
        ;


    -


    {
        ;


        i_
            <
            =
            n
            -
            1i _ + +)


        i
            ]
            = a[i, i_]
            ;


        ;


        x
            b
        las.x d
        r
            )


        i
            ] -;


        m
            e)(M
            .A b
        s(v))<(do
            b
                al l
            e
        r
            r
            )


        t rm i
            d u
            p
        d
            a

        te
            v
            (
                ua,
                p
                ,
                n
                    fo

        (i_ = 0
            ;

        i_ = n 1
            ;


        [
        ]
        =

        x
            [
                i_
                ,
            ]
            +
            y[_]
    }
}
}
}


/*************************************************************************
Internal Cholesky solver

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
private static void spdmatrixcholeskysolveinternal(double[,] cha,
    int n,
    bool isupper,
    double[,] a,
    bool havea,
    double[,] b,
    int m,
    ref int info,
    densesolverreport rep,
    ref double[,] x,
    alglib.xparams _params)
{
    = 0;
    x = new double[0, 0];


    //
    // prepare: check inputs, allocate space...
    //
    if (n <= 0 || m <= 0)
    {
        info = -1;
        return;
    }

    x = new double[n, m];


    //

    // estimate 
    c
        onditi
    o
        n

    umb
        er ear
        s
    n
        gu

    rep
        .r
    1
        =
        r ixch
        lesky
    rc isuppe
        r,
        p
    ar
        r p.r
        ;


    ble)(rep.r1) < (dou
    le)
    (r res
        old(_p
            a
            r
            a
            s
        ))

    {
        f
        or(i = 0;
        i <=

        {
            o
                    (
                =
                0


            {
                x[
            }


            rep
                r1 = 0
                ;


            rep.r
            i
                n = ;
                in


            etu
                n;
                in fo = ;
                /
                /

            ol
                e
            wit
            TRSM(
            )


            f
            r(i
            0;
            i <=
                n
                -
                1
                ;
            {
                f - 1;
                j +
                    )


                [i, j
                 ;


                if (isupper)


                {
                    rma
                        l
                    f
                        tr sn 0, t e f
                        a,
                        _
                    ara
                        s);


                    0 , 0 e, 0, x, 0, 0, _params);
                }


                a
                l
                    as
                    .
                m
                    ,
                f ls e _pa
                ra.rm
                    a
                t
                    r
                i
                    x
                e
                    ft
                t
                    r
                s
                m
                    n,
                    m,
                    fa,
 
                0

                0
                    ,

                _
                    p
                a
                r
                    ms
                    ;
            }
        }


        /*************************************************************************
        Internal LU solver

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        private static void cmatrixlusolveinternal(complex[,] lua,
            int[] p,
            int n,
            complex[,] a,
            bool havea,
            complex[,] b,
            int m,
            ref int info,
            densesolverreport rep,
            ref complex[,] x,
            alglib.xparams _params)


        int i
                =
                0;
            in
        t j = 0;
        int k =
            0;
        nt f s
            = 0;

        int
            n
        r
        f
            s = 0;


        complex[] x c n w comp
        l
        e
            [0
        co
            mp l
            e
        x
            [
            ]
            ;


        0;

        []
        x
            a
            =

        e
            w
        c
            om p
        0
            ];


        p
            =
            n
        e
            w
        c
            m
        pl o
        do
            co
                p
        e
            x
        d
            oubl

        e
            r
        ol s
        l
            r
        r
            b n
            ();


        i
            x =
                new c
        mp
        ex[0,];
            /


        ch
            te s
            a
        e..
            .
        //


        f
        (
            n
            <=
            0


        i
        nf
            o
                =
                1
            ;


        u
            ;
        i
            =
            -1;
        i
            ++)


        {
            n
                -
                1
                |
                |
            p
                i
                    ]

            -1;


            r
                et u
                r
        }


        x
            =
            n];


        c
            =
            n;


        a
            =
            n
        e
            w

        c
            o
        le x
            [n +
             1
            ]
            ;


        ub
            mate
        c
        ondition number,
            t
        s
            t
        for

            e
                a

        s
            ngula
        r
            ty


        r ep.r1
            = xlurc

        o
            nd1(lua, n, _pa
                r
                a
                m
            )
            ;


        ep.r i
        rc on d.
            c
            a
        t
            i
        x
            u
        r
            o

        n
            inf(lua
                ,
                ep.r rcond.rcondthreshold(_params)) ||

        (do
            u
                hr

        e
            hold(
                pa
                    fr

        (i 0;
        i < = n -
              i
                  ++
            )
        {
            ; <=
            -;
            j++ )
            {
                [i, j] =

                0
            }


            re p
                    .inf = 0;
                in fo
                i
            n
                o = 1;


            lve w
            i

            {
                {
                    x i
                    j
                        ]
                        =
                    x
                    [p[
                        l ar i
                    e
                        ,
                    t r
                    e

                    0
                        ,
                    c x
                    l
                        e
                    ft r
                    sm(n
                        ,
                        m
                        ,
                        l
                    ua, 0


                    // so


                    {
                    }


                    {
                        x
                        c[
                            i
                        _
                            / Iterative refinement of xc:
                        // * calculate r = bc-A*xc using extra-precise dot product
                        // * solve A*y = r
                        // * update x:=x+r
                        //
                        // This cycle is executed until one of two things happens:
                        // 1. maxi
                        um num
                        er o
                        iterations reached
                            /
                            /

                        2
                        la
                            st ecr
                            a
                        se he l
                            wer lim
                        it /
                            /


                        f(h
                        vea )

                        {
                            nrf
                                = fsm
                            x(n
                            rep
                                .r _params);


                            ina
                                enextt
                            i
                            m
                                e
                                    =
                                    f


                            or(rfs =
                                0;
                            rfs <= nrf


                            i
                            (
                                t t
                            m
                                )


                            reak;
                        }


                        /


                        righ
                            a
                        r
                            t


                        m
                        lle
                            r = tr
                        u
                            e
                            ;


                        0;


                        b[i_] = xc
                    }


                    for (i = ;
                         i <= n - 1;
                         i
                         +
                         +)


                    {
                        for
                        (
                            i_ 0


                        {
                            a[i
                            _
                                = 
                        }


                        ]


                        x
                            b,
 
                            ,
                            _p ra
                            s
                            ;


                        y[
                            ]
                            =
                            (do
                            b
                                l
                        v))<
                        d
                            u
                        b
                    }

                    f(s ller
                    r )


                    t en e
                        ;
                        /
                        /


                    d
                        ca ic us lve(
                        l
                    u
                        a

                    p
                        n,
 
                        ,
                        p
                    a
                        ams)

                    f
                        o
                    r


                    {
                        c
                    }


                    /
                    /

                    //         S        to        re         x        .
                    / Pos
                        t
                    scale
                        e
                    s
                        l
                    t
                        / /

                    i_ <= n - 1;
                    i_)
                    {
                        x[i_, k] = xc[i_];
                    }
                }
            }


            /*************************************************************************
            Internal Cholesky solver
    
              -- ALGLIB --
                 Copyright 27.01.2010 by Bochkanov Sergey
            *************************************************************************/
            private static void hpdmatrixcholeskysolveinternal(complex[,] cha,
                    int n,
                    bool isupper,
                    complex[,] a,
                    bool havea,
                    complex[,] b,
                    int m,
                    ref int info,
                    densesolverreport rep,
                    ref complex[,] x,
                    alglib.xparams _params)
                in

            t
                =
                0


            o
                m
            p
                l
            omp lex[0];

            [
            0
                ];
            comple
            x
                [bc
            e
                mp lx[0];

            x
                c mp lex[
                ]
                x
            b x[
                c
            o
                m
            p
                co pl x[0
                ;
                = 0;

            ne
                o mp ex[

                //
                /
                /

            p
            ce ..
                /
                /
                )

            i fo =
                -1;
        }
        m
            y = n
        c
        ex[
            n =
                ne c m
        p
        lx[n];


        w


        x
            a
                =
                n ew
            pl ex n + ];


        / /a co e
            gu a
            tr xc ole
        kyrcond
        (
            c
        h
            a, _
        a
            ams
            ;


        u
            )
        p.r1 )
        ou bo dthr e
        s
            ho ld(_ p
        {
            f
                o
            r
            (
                i
            {
                (j 0;
                j = m -
                    ++ )

                x[i
                    ,
                    j]
                0
            }
        }

        =
        0
            ;

        r p.ri f = ;


        r
            e
        t
            urn;
    }


    in
    o
        = //

        //         
        f
    o
        r
    (
            i
                = 
        ;
    i
        <
        = -1;
    i + +)

    o
    r
        j
            = 0
        ;


    x
    [
        i
        ,
    ]
    b]
    isup pe )


    m, tr ue
    a
        s
    e
        ab l
        s

    t
        r
    ix ef t
    m(, m
        , 
}


/*************************************************************************
Internal subroutine.
Returns maximum count of RFS iterations as function of:
1. machine epsilon
2. task size.
3. condition number

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
private static int densesolverrfsmax(int n,
    double r1,
    double rinf,
    alglib.xparams _params)
{
    = 5;
    return result;
}


/*************************************************************************
Internal subroutine.
Returns maximum count of RFS iterations as function of:
1. machine epsilon
2. task size.
3. norm-2 condition number

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
private static int densesolverrfsmaxv2(int n,
    double r2,
    alglib.xparams _params)


}


/*************************************************************************
Basic LU solver for PLU*x = y.

This subroutine assumes that:
* A=PLU is well-conditioned, so no zero divisions or overflow may occur

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
private static void rbasiclusolve(double[,] lua,
    int[] p,
    int n,
    double[] xb,
    alglib.xparams _params)


d u
    = 0;

f
    o
r
    (i 0;
i < =
(
    p
i]!=i )


i
1;
i <=
    0.0;


(i 0
    ;
    =
i_++


}
1
v for(i

{
    ua
}


] ;


}
}


/*************************************************************************
Basic Cholesky solver for ScaleA*Cholesky(A)'*x = y.

This subroutine assumes that:
* A*ScaleA is well scaled
* A is well-conditioned, so no zero divisions or overflow may occur

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
private static void spdbasiccholeskysolve(double[,] cha,
    int n,
    bool isupper,
    double[] xb,
    alglib.xparams _params)
{
    int
    i
        i
            = 0
              /


    if (i
    up
        / S
    l
        e U
        * y = b fi
        r
    s
    t
        .
        / /
        <
    n
        -


    {
        ch
            r(i_
                i

        +;

        i
            bi _ x
        b] ;
    }


    //


    -1;
    i >= 0;
    i--)
    i
    {
        = 0.0;


        _ + )


        {
            =

            -
                v
                ;


            i
                ]
                = x b
                    [] /
                -1;
            i + )


            {
                v
                    =
                    (i_ = 0 i _
                    <= i
                1
                    ;
                i
                _
                    +
                    +
                    )


                v
                    ;
            }

            [i]
            x b

            {
                v = xb[i];
                for (i_ = 0; i_ <= i - 1; i_++)
                {
                    xb[i_] = xb[i_] - v * cha[i, i_];
                }
            }
        }
    }
}


/*************************************************************************
Basic LU solver for ScaleA*PLU*x = y.

This subroutine assumes that:
* L is well-scaled, and it is U which needs scaling by ScaleA.
* A=PLU is well-conditioned, so no zero divisions or overflow may occur

  -- ALGLIB --
     Copyright 27.01.2010 by Bochkanov Sergey
*************************************************************************/
private static void cbasiclusolve(complex[,] lua,
    int[] p,
    int n,
    complex[] xb,
    alglib.xparams _params)


i
    omple
x v =
    0;

int i_ = 0;


f
    o
r
    (
        i
            =
            0
    ;

i
    <
    =
    n
    -
    1
    ;

i
    +
    +
    )


{
    i
    f
    (
        p
            [
                i
            ]
            !
            = i)

    {
        v = x
        b
            [i]


        b[
            i]


        x
            b
    }


    {
        v = 0.0;
        for (i_ = 0; i_ <= i - 1; i_++)
        {
            v += lua[i, i_] * xb[i_];
        }

        xb[i] = xb[i] - v;
    }
    xb[n - 1] = xb[n - 1] / lua[n - 1, n - 1];
    for (i = n - 2; i >= 0; i--)
    {
        v = 0.0;
        for (i_ = i + 1; i_ <= n - 1; i_++)
        {
            v += lua[i, i_] * xb[i_];
        }


        x
            b
        i]
            = a[i
                ,
                i
            ;
    }


    /*************************************************************************
    Basic Cholesky solver for ScaleA*Cholesky(A)'*x = y.

    This subroutine assumes that:
    * A*ScaleA is well scaled
    * A is well-conditioned, so no zero divisions or overflow may occur

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    private static void hpdbasiccholeskysolve(complex[,] cha,
        int n,
        bool isupper,
        complex[] xb,
        alglib.xparams _params)


    i
    t
        i
            =
            0
        ;


    int i_ = ;


    //
    // A = L*L' or A=U'*U
    //
    if (isupper)
    {
        //
        // Solve U'*y=b first.
        //
        for (i = 0; i <= n - 1; i++)
        {
            xb[i] = xb[i] / math.conj(cha[i, i]);
            if (i < n - 1)
            {
                v = xb[i];
                for (i_ = i + 1; i_ <= n - 1; i_++)


                {
                    xb ] -
                            v
                        * m[i, i
                        ]);
                }
            }
        }

        Sl U
        xy //
            fo r(i + 1


        b
        [
            i]
        x
        b
        [
            v

        h
        a
        [i
            ,
        ]
    }
    /

    f
        o
    r
        i
            = 0
        ;
        <
        =n
        - 1


    v
    0
        ;
    i
        v i


    n
        .
        >


    x
    b[
            i
        ]
        /
        ath.c
    on(c h
    a[i, i] );


    {
        xb[i_] = xb[i_] - v * math.conj(cha[i, i_]);
    }
}
}
}
}
}

public class directsparsesolvers
{
    /*************************************************************************
    This structure is a sparse solver report (both direct and iterative solvers
    use this structure).

    Following fields can be accessed by users:
    * TerminationType (specific error codes depend on the solver  being  used,
      with positive values ALWAYS signaling  that something useful is returned
      in X, and negative values ALWAYS meaning critical failures.
    * NMV - number of matrix-vector products performed (0 for direct solvers)
    * IterationsCount - inner iterations count (0 for direct solvers)
    * R2 - squared residual
    *************************************************************************/
    public class sparsesolverreport : apobject
    {
        public int terminationtype;
        public int nmv;
        public int iterationscount;
        public double r2;

        public sparsesolverreport()
        {
        }

        public override void init()
        {
        }

        public override alglib.apobject make_copy()
        {
            report _ res
            rt();

            ty p
            t
                re o
                n
                    =
                    it


            _
                r
            e
                su
            lt
                .r;
        }
    };


    /*************************************************************************
    Sparse linear solver for A*x=b with N*N  sparse  real  symmetric  positive
    definite matrix A, N*1 vectors x and b.

    This solver  converts  input  matrix  to  SKS  format,  performs  Cholesky
    factorization using  SKS  Cholesky  subroutine  (works  well  for  limited
    bandwidth matrices) and uses sparse triangular solvers to get solution  of
    the original system.

    INPUT PARAMETERS
        A       -   sparse matrix, must be NxN exactly
        IsUpper -   which half of A is provided (another half is ignored)
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        X       -   array[N], it contains:
                    * rep.terminationtype>0    =>  solution
                    * rep.terminationtype=-3   =>  filled by zeros
        Rep     -   solver report, following fields are set:
                    * rep.terminationtype - solver status; >0 for success,
                      set to -3 on failure (degenerate or non-SPD system).

      -- ALGLIB --
         Copyright 26.12.2017 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsespdsolvesks(sparse.sparsematrix a,
        bool isupper,
        double[] b,
        ref double[] x,
        sparsesolverreport rep,
        alglib.xparams _params)


    nt
        i
            =
            0;


    nt
        n
            =
            0;


    x =

    n
        e

    w o

    u
        b

    s
        r

    l
        SPD;


    a
        glib
        .a sp v

    ara
        m

    s)
    =
    =
    n
    ,
    Sp ar s
        e

    PS ol ve SS :
    l l li b.a
    p. as e
    ,
    ii or t(re, _
        pa r
        ;


    ]

    ar
        s

    c
        o

    p
        t

    e ho ls k {
        for

    (
    i= 0;
    i
    <=n -
    1
    ;

    i
    +
    +
    )
    a2
    ,

    i
        s

    p
        er,
        f

    a
        s,
        1, x
    ,

    _pa
        r

    ams
    )
    ;


    rs , l {
        sparse.spa rsv(a2, isupper, false, 0, x, _params);
        sparse.sparsetrsv(a2, isupper, false, 1, x, _params);
    }

    rep.terminationtype = 1;
}


/*************************************************************************
Sparse linear solver for A*x=b with N*N  sparse  real  symmetric  positive
definite matrix A, N*1 vectors x and b.

This solver  converts  input  matrix  to  CRS  format,  performs  Cholesky
factorization using supernodal Cholesky  decomposition  with  permutation-
reducing ordering and uses sparse triangular solver to get solution of the
original system.

INPUT PARAMETERS
    A       -   sparse matrix, must be NxN exactly
    IsUpper -   which half of A is provided (another half is ignored)
    B       -   array[N], right part

OUTPUT PARAMETERS
    X       -   array[N], it contains:
                * rep.terminationtype>0    =>  solution
                * rep.terminationtype=-3   =>  filled by zeros
    Rep     -   solver report, following fields are set:
                * rep.terminationtype - solver status; >0 for success,
                  set to -3 on failure (degenerate or non-SPD system).

  -- ALGLIB --
     Copyright 26.12.2017 by Bochkanov Sergey
*************************************************************************/
public static void sparsespdsolve(sparse.sparsematrix a,
    bool isupper,
    double[] b,
    ref double[] x,
    sparsesolverreport rep,
    alglib.xparams _params)
{
    int
        = 0;


    t j
    0;


    s
    rse.sparsematrix a2 = new spar
    e.spa
        ema
    ix();
        in
    n
        = 0;


    double v = 0;

    int[] p
        =
        new
            int[
            ];


    x
        = new d
    ub
    e[0
        ;


    n = spars
        .sparseg
    tnrows
        (, _params);

    al r
    "
    rseSPD
    olve:
    N
        = 0")


    al rt(spar
        e

    arseg
        tnro
    s(
        ,
        _p
    rams)==n

    "Sparse
    PDSo
        ve
    rows(A
    )!
    g
        .ap.a
        s
    s
        er
    t
    (
        s
    p
        a

    se.sp
        rsegtncols(a, _para
            s)==

    n, "Spa         
        !
        );


    alglib
        .a )
        =n,

    "SparseSPDSolve
        :

    th
        )<N");
    r
        (ap
    s
    erv.isfinitevec
        t
    o
        r
    n
        _param
        ),
    "Spars         co
    s
        finiti
    s or N
        A
    s");


    ini
        spa
    rs m
        );


    spar
        e
    sparse
        opytoc
    r
    (
        a
    a2
        _param
    s) par
        ec
    o
        l

    sk
        p(a2, i
            u

    pper, ref
    ,
    par
        a
    ms)
        )


    r ntype = -
        ;


    ablas
        .rsetallocv(n, 0
            .
    0
        ,

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


    r
        e
    t
        u
    r
        n
        ;
}


a
blasf.rcopyalloc
(n, b,
    ref
    , _params);


f
or(i = 0;
i <= n
1
    ;
{
    p[i];
        =
    [i]
    ;


    ] = x[j];
}


1
    ,_ pa a
    m

p
e.sp a
set rs v, s, r a
}
e
l
se
spa
r
se.spa
r
setrsv(a2, isu
p
p
e
, false
,
0
,
, _params);
, isupper, fa ls e
, 1, x, _ {
    j =
        p
        [
            i
        ]
        ;

    v = x
    [
        i];


    xx v;


    rep.terminationtype
        = 1
        ;
}


/*************************************************************************
Sparse linear solver for A*x=b with N*N real  symmetric  positive definite
matrix A given by its Cholesky decomposition, and N*1 vectors x and b.

IMPORTANT: this solver requires input matrix to be in  the  SKS  (Skyline)
           or CRS (compressed row storage) format. An  exception  will  be
           generated if you pass matrix in some other format.

INPUT PARAMETERS
    A       -   sparse NxN matrix stored in CRs or SKS format, must be NxN
                exactly
    IsUpper -   which half of A is provided (another half is ignored)
    B       -   array[N], right part

OUTPUT PARAMETERS
    X       -   array[N], it contains:
                * rep.terminationtype>0    =>  solution
                * rep.terminationtype=-3   =>  filled by zeros
    Rep     -   solver report, following fields are set:
                * rep.terminationtype - solver status; >0 for success,
                  set to -3 on failure (degenerate or non-SPD system).

  -- ALGLIB --
     Copyright 26.12.2017 by Bochkanov Sergey
*************************************************************************/
public static void sparsespdcholeskysolve(sparse.sparsematrix a,
    bool isupper,
    double[] b,
    ref double[] x,
    sparsesolverreport rep,
    alglib.xparams _params)
{
    int n = 0;


    x = new d
    sp
        a
    rse.sparsegetnr
        o
    w
        s
    _
        rams);

    .as
    n
    "Spar
    eSPDCh
        o
    eskySolve
    N <= 0"
        ;


    a
    se.
        s
    parsegetnrows(a
            params
        == n, "
    S
        a
    r
        eSP
    Cholesk
        yS

    l
        g
    ib

    ap.asse
        t
        (sparse.sp
            rs

    get
        n
    col
        (a, _p
    a
        rm ar
        eSPDCh
    les(A) != N");


    a

    glib.ap.a
        sert(sparse.spar
            s

    e
        i
    s
        s

    k
        s
        (
            a
            ,
            _
                p
                a
                r
                a
                m
                s
        )
        |
        |

    s
        p
    a
        r
    s
    e
        .
        s
        p
    a
        r
    s
        e
    i
        s
    c
        r
    s
    (
        a
        ,
        _
    p
        a
    r
        a
    m
        s
        )
        ,

    "
    S
        p
    a
        r
    s
        e
    S
        P
    D
        C
    h
        o
    l
        e
    s
        k
    ySolve:
    A is not
        an SKS
    CRS
        atrix");


    a
    lglib.ap.ass
        r
    t(n(b)
        = n, "Sp
    ar ySolve
        :

    e
        ng


    a
        g
    li apserv.isfinitevec
    or(
        b,, "Spa
    r
        seSPDCh
    leskySo
    lve:
    B cont
    or
        s
        )
    ;
    p
        rs l
        v
    pa ms)
    ;


    x
        ew
    ouble n
            ]
        ;

    f
        o
    r
        i++
        i
        (
            (
                d
    spa
        r

    s
        gt(a i, , _
            pa

    a
        m
    .0


    rep t
    erminati ntype =
        -
            3


    r(i = 0;

    i <
        =
        n - 1;
    i
    {
        [i] =
        0
            ;
    }

    etur
        n
        ;
}


}
= n
i+
+
)
{
    x[i] =
        b
        [
        ];
}
if (r


sp
    a
rse.sp
    a
rsetrs
    v
(a
        , 
    is
u
p
    pe,
    f
e, 1, x, _params )


s trsv(a
    ,
    i
        s

upper, f
als e,  0,

x, _params);


else
{
    spa s
        .s
        ar se r
    sv(
        se,, x, _params);


    s a
        r, isu pe , false 1, x, _p ra ms
}

ep
    .
    e
    rmina
t
ionty e = 1;


}


/*************************************************************************
Sparse linear solver for A*x=b with general (nonsymmetric) N*N sparse real
matrix A, N*1 vectors x and b.

This solver converts input matrix to CRS format, performs LU factorization
and uses sparse triangular solvers to get solution of the original system.

INPUT PARAMETERS
    A       -   sparse matrix, must be NxN exactly, any storage format
    N       -   size of A, N>0
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    X       -   array[N], it contains:
                * rep.terminationtype>0    =>  solution
                * rep.terminationtype=-3   =>  filled by zeros
    Rep     -   solver report, following fields are set:
                * rep.terminationtype - solver status; >0 for success,
                  set to -3 on failure (degenerate system).

  -- ALGLIB --
     Copyright 26.12.2017 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolve(sparse.sparsematrix a,
    double[] b,
    ref double[] x,
    sparsesolverreport rep,
    alglib.xparams _params)


int
    = 0;


int
    j = 0;


i
    n
0
    ;


sparse
    spa
sematri
x
    a2 = n
e
    s
rse.spars
    atri
    );
ivp = new
    in
[0]


i
t[]
    ivq =
        new in
t0];


x = new d
    = spa
se.parseg
tnrows
    a,
    _pa
am
    );


a
    gl
b.ap e:
N <= 0"           algl

b
    .asse
    t(sp
        rs
        .

pa
    segetnro
s
    (a, _pa
ams)
    =n
"Spars
eS )


a
glib.p.asert(sparse.spar
egetncols(a n
s
lve:
c
    o
l
    s
A)
    =N");
(
    lgl
i
b.ap.len(b) >= n,

"
se
lve:
leng l
lib
    .ap.assert(apser
v
    .
    i
    ni
vector
    b,
    n,
    _pa seS
    ontain
infin
    i
ies or NA
    s");


r
    p,
    _
        params);


x =
    new do
    u
        l
e
    n];

a,
2,
_
    p
ra
    s);


if (
    !t
fac
    .
    spa
selu(a
2
    ,0 ,
ef piv, _


rep.te
    minationtype = -
        3
    ;


f
    o
r
    (
        i
            =
            0
    ;

i
    <
    =
    n
    -
    1
    ;

i
    +
    +
    )


{
    x[i] = 0;
}

r
    eturn;


r(i = 
    ;
i <= n -
    1;
{
    x[i
            = b[i
            ]
        ;

    for (i = 0
        i <
            = n

    {
        j = pi


        v
            x


        x[j]
            =
            v
    }


    sparse.spars et rs v(fa e, t
        r
        u
        s);


    ar parset sv(a2, tr e, false,
        x,
        _p r
    for
    (
        i =
            n
            - 1;
        i >
        =
        0;
        i -)

    {
        =

        p
        vq[i;
        v = x[
                i
            ;


        ;


        x[j
        ] = v;
    }


    re p.te
        r
    mi
        n
    a
        iontyp = 1;
}


/*************************************************************************
Sparse linear solver for A*x=b with general (nonsymmetric) N*N sparse real
matrix A given by its LU factorization, N*1 vectors x and b.

IMPORTANT: this solver requires input matrix  to  be  in  the  CRS  sparse
           storage format. An exception will  be  generated  if  you  pass
           matrix in some other format (HASH or SKS).

INPUT PARAMETERS
    A       -   LU factorization of the sparse matrix, must be NxN exactly
                in CRS storage format
    P, Q    -   pivot indexes from LU factorization
    N       -   size of A, N>0
    B       -   array[0..N-1], right part

OUTPUT PARAMETERS
    X       -   array[N], it contains:
                * rep.terminationtype>0    =>  solution
                * rep.terminationtype=-3   =>  filled by zeros
    Rep     -   solver report, following fields are set:
                * rep.terminationtype - solver status; >0 for success,
                  set to -3 on failure (degenerate system).

  -- ALGLIB --
     Copyright 26.12.2017 by Bochkanov Sergey
*************************************************************************/
public static void sparselusolve(sparse.sparsematrix a,
    int[] p,
    int[] q,
    double[] b,
    ref double[] x,
    sparsesolverreport rep,
    alglib.xparams _params)
{
    nt i = 
        ;


    n
        t
            = 0;

    double v
            = 
        ;


    int
        n
    0;


    x =
        new doub
    e[0];
        = spa
        r
    e.sparse
        et
    rows(a, _params);


    lglib.p.assert(n
    0, "Spa
    se
        USo
    ve:
    N <= 0
        );


    lglib.a.assert(sparse
    sparsegetnr m
    "
    rseLUS
    lve:
    r
        o
    s(A)
        = N
        );


    a
    glib.ap
    assert(e
    s
        _pa
    am
        )
        =
    n
        ,
    "        e
    A
        N");


    alg
    ib.a.assert(sparse.parseiscrs(
        L
    lve:
    A
        i
    s
        no
    an SKS
    ma i
        .ap
        .assert(alglib.a
    p
        .b)
    n, "Spars        


    alglib.a
    p
        .
        a
        rt
    pserv.
        sf
        niteve par
        arseLU
    olve:
    B
        contains
    nfinit
        es
    r N
    AN a
        .as

    s
        ert(alglib.ap.l
            n
            p)>=

    n,
    "Spars
    e
        U
    S
        lve
    length
        (P ap.ss
    r
        t
    al
    lib.ap.e
    n(q) >= n, "
    parseL
        U
    Sl(Q
       < N");
        = 0;
    i <= n -
        ;
    i++
        )


    {
        alg
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
            p
                [
                    i
                ]
                >
                =
                i
                &
                &
                    p
                    [
                        i
                    ]
                <
                n
            ,
            "
        S
            p
        a
            r
        s
            e
        L
            U
        S
            o
        l
            v
        e
            :

        P
            i
        s
            c
        o
            r
        r
            u
        p
            t
        e
            d
        "
            )
        ;


        algli
            .ap.as
        ert(
            [i] >= i && q
        [
            i] < n,
        "
        SparseLUSolv
            :
        Q d");


        ini
            t
        s
            a
        rs t(rep, _params);


        doubl
        e
            [n];


        f
                .d
            | .

        [a.
        )


        r p.termin at on
        y
            e = ;


        o
        r(i +
          +
        )


        x[
        ] 0;
    }
}

f r(i
0
    ;


{
    x[i] = b[i];


    r
        (i = 0;
    i
        <
        = n -;
    i +) {
        = i];


        v
        [i = x
            [j;


        x[j = v;
    }


    sp e.s
        pr se tr sv(a
    fa s
        e, t
    rams);


    spar se.
        s
        pa
    r
        set
    r
        s
    v
    (a
        ,
        e, se,, x
        ,
        _param
    s
        )
    ;


    =n -;
    i > = 0;
    i
        --)


    {
        = [
            i
            ;
        x[] =

        x[
            ];
            = v;
    }


    r ep.ter
        m
    i
}


/*************************************************************************
Reset report fields

  -- ALGLIB --
     Copyright 26.12.2017 by Bochkanov Sergey
*************************************************************************/
public static void initsparsesolverreport(sparsesolverreport rep,
    alglib.xparams _params)

{
    er minat
        i
            =
            0
        ;


    e
    p.i
        .r
    2 0
}
}

public class iterativesparse
{
    /*************************************************************************
    This object stores state of the sparse linear solver object.

    You should use ALGLIB functions to work with this object.
    Never try to access its fields directly!
    *************************************************************************/
    public class sparsesolverstate : apobject
    {
        public int n;
        public double[] x0;
        public double epsf;
        public int maxits;
        public int algotype;
        public int gmresk;
        public bool xrep;
        public bool running;
        public bool userterminationneeded;
        public double[] b;
        public double[] xf;
        public int repiterationscount;
        public int repnmv;
        public int repterminationtype;
        public double repr2;
        public int requesttype;
        public double[] x;
        public double[] ax;
        public double reply1;
        public double[] wrkb;
        public sparse.sparsematrix convbuf;
        public fbls.fblsgmresstate gmressolver;
        public rcommstate rstate;

        public sparsesolverstate()

        init();
    }

    public override void init()


    x0 = n
        e

    w
        bl

    0];
    e
    0];


    x
        f

    ne
    double
    0]

    x =

    o
        e[0];


    ax
    = new
        oub
        e[0
        ];

    n
        w d
        o

    uble[0];


    convbu
        f
            =
            ew

    parse.s
        pa

    mr
        s

    s
        lv

    r = new
        f
        bls.fblsgm

    esstat
        e
        (;

    rs
        ate tate();
}

public override alglib.apobject make_copy()
{
    s
        p
    a
        r
    s
        e
    s
        o
    l
        v
    e
        r
    s
        t
    at t = ne
    spars
        solv
    rstate();


    _result
        n
            = n;


    _result.x0 = (do
        u
            b
    e
        [])x0.Clone();


    _result.ep
        f = ep
    s
        f


    _result.maxits =
        max
    its;


    _result
        algotyp
    e p
    es
    l
        .e


    result.xrep = xrep;


    ning = u
    n
        i

    _re
    ult.u e
    r
        t
    e
        r
    r
        ermi na i
    o
        nneeded


    _r
        e
    s
        ])b.C
        lo e
    (
    );


    _re ult.f
        =
        (
    do
        ub e
    [
        _re
    s
    ult.rep terationscount
        =
        epitera un
        _ e
        s
    u
        lt r
        ep m
        v


    result
        .
        repter
        m
    ination re mina ion yp e;
    _res r2 r
        epr
    sult re
    q
        ue
    s
        ttype
            =
            reque
    st ype;


    _
    r
    (ble
        [) x
        on e(;

    _
    result.ax = (double[])x
        .Cl on e();


    s
        ul r
    e
        ly1 = reply1;


    double
    [
    ]) wr kb.C e()
    _resul
    t
        .
        c
        n
    v
        uf =
            arsemat ix)c
        ov bu.make_co
        );


    _
    result.gmressolver = (
        f
    bl.
        fbl sg mre
        s
    state)
    g
        mr
    e
        ss lv r
        .
        ma
        k
    e_ opy();
    _resu l
    t
        .r
    s
        tate = (rcommstate)rst
    a
    te
        .m ke_ op y(
    ;


    r
        et
    u
        r
    _ esult;
}
};


/*************************************************************************
Solving sparse symmetric linear system A*x=b using GMRES(k) method. Sparse
symmetric A is given by its lower or upper triangle.

NOTE: use SparseSolveGMRES() to solve system with nonsymmetric A.

This function provides convenience API for an 'expert' interface  provided
by SparseSolverState class. Use SparseSolver  API  if  you  need  advanced
functions like providing initial point, using out-of-core API and so on.

INPUT PARAMETERS:
    A       -   sparse symmetric NxN matrix in any sparse storage  format.
                Using CRS format is recommended because it avoids internal
                conversion.
                An exception will be generated if  A  is  not  NxN  matrix
                (where  N  is  a  size   specified  during  solver  object
                creation).
    IsUpper -   whether upper or lower triangle of A is used:
                * IsUpper=True  => only upper triangle is used and lower
                                   triangle is not referenced at all 
                * IsUpper=False => only lower triangle is used and upper
                                   triangle is not referenced at all
    B       -   right part, array[N]
    K       -   k parameter for  GMRES(k), k>=0.  Zero  value  means  that
                algorithm will choose it automatically.
    EpsF    -   stopping condition, EpsF>=0. The algorithm will stop  when
                residual will decrease below EpsF*|B|. Having EpsF=0 means
                that this stopping condition is ignored.
    MaxIts  -   stopping condition, MaxIts>=0.  The  algorithm  will  stop
                after performing MaxIts iterations. Zero  value  means  no
                limit.

NOTE: having both EpsF=0 and MaxIts=0 means that stopping criteria will be
      chosen automatically.
                
OUTPUT PARAMETERS:
    X       -   array[N], the solution
    Rep     -   solution report:
                * Rep.TerminationType completion code:
                    * -5    CG method was used for a matrix which  is  not
                            positive definite
                    * -4    overflow/underflow during solution
                            (ill conditioned problem)
                    *  1    ||residual||<=EpsF*||b||
                    *  5    MaxIts steps was taken
                    *  7    rounding errors prevent further progress,
                            best point found is returned
                    *  8    the  algorithm  was  terminated   early  with
                            SparseSolverRequestTermination() being called
                            from other thread.
                * Rep.IterationsCount contains iterations count
                * Rep.NMV contains number of matrix-vector calculations
                * Rep.R2 contains squared residual

  -- ALGLIB --
     Copyright 25.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolvesymmetricgmres(sparse.sparsematrix a,
    bool isupper,
    double[] b,
    int k,
    double epsf,
    int maxits,
    ref double[] x,
    directsparsesolvers.sparsesolverreport rep,
    alglib.xparams _params)
{
    0
    on vb uf = n ew s pa rs e.sp ar se ma tri
        ();


    spars solve state
        s
    o
        l
    rstate()
        [0];


    n = sp a
        r
    s
    e.
        s
        parse
    g
        e
    t
        est inp
        u
    ts

    //


    ap.asser(n >= 1, "        S
    a
        seSolvei GMR S:
    tr e
    detect
        N fr
        m
    size
        o
    tive
        s
    ze"        ;

    glib ap.
        a
        sser t(sp ar sa eg tnrows(a, _ params)
        =
        tri cG MS
    r
        o
    w
    s(A) != N ")        ;
        .assert
        (
            spr se sp ars egetn c
    "Spa        rs        eSo
    l
    veSymmetricGMRES:
    s
        = N");


    glib.a p.le
    n
        (b) >= n,
    cGMRES:
    le ngth(B) < N ");


    alglib.ap.assert
    (a ctor(b,
        n, _p
    r
        ms ), l ymme
    t
        ric GM RES :
    B cona in NAN / I NF");


    ss ert(math. is
            finite(e
            p
            s) &&
        (
            d
    ub le)(0)
        ,
    "
    p
        r
    seSolv
        e
    S
        y
    mme t
    ricGM
        R
    E
        S
        );


    al
        l
    b.ap.a
        s
    mmetric GM R
        E
    S:
    M
        a
    xIts <
        0
    "
        )
    (double)(ep sf == (d ub
    e( && maxits = 
        =
    0 )


    sf = 1.0
    E
        - 6;
}


//
//         If         A is 
n
    o
n - version
    /


if (!spa r
se.sparse
    i
s
c
{
    rsecopytocr
        sa, convbuf, _params);
    sparsesolvesymmetricgmres(convbuf, isupper, b, k, epsf, maxits, ref x, rep, _params);
    return;
}

//
// Solve using temporary solver object
//
sparsesolvercreate(n, solver, _params);
sparsesolversetalgogmres(solver, k, _params);
sparsesolversetcond(solver, epsf, maxits, _params);
sparsesolversolvesymmetric(solver, a, isupper, b, _params);
sparsesolverresults(solver, ref x, rep, _params);
}


/*************************************************************************
Solving sparse linear system A*x=b using GMRES(k) method.

This function provides convenience API for an 'expert' interface  provided
by SparseSolverState class. Use SparseSolver  API  if  you  need  advanced
functions like providing initial point, using out-of-core API and so on.

INPUT PARAMETERS:
    A       -   sparse NxN matrix in any sparse storage format. Using  CRS
                format   is   recommended   because   it  avoids  internal
                conversion.
                An exception will be generated if  A  is  not  NxN  matrix
                (where  N  is  a  size   specified  during  solver  object
                creation).
    B       -   right part, array[N]
    K       -   k parameter for  GMRES(k), k>=0.  Zero  value  means  that
                algorithm will choose it automatically.
    EpsF    -   stopping condition, EpsF>=0. The algorithm will stop  when
                residual will decrease below EpsF*|B|. Having EpsF=0 means
                that this stopping condition is ignored.
    MaxIts  -   stopping condition, MaxIts>=0.  The  algorithm  will  stop
                after performing MaxIts iterations. Zero  value  means  no
                limit.

NOTE: having both EpsF=0 and MaxIts=0 means that stopping criteria will be
      chosen automatically.
                
OUTPUT PARAMETERS:
    X       -   array[N], the solution
    Rep     -   solution report:
                * Rep.TerminationType completion code:
                    * -5    CG method was used for a matrix which  is  not
                            positive definite
                    * -4    overflow/underflow during solution
                            (ill conditioned problem)
                    *  1    ||residual||<=EpsF*||b||
                    *  5    MaxIts steps was taken
                    *  7    rounding errors prevent further progress,
                            best point found is returned
                    *  8    the  algorithm  was  terminated   early  with
                            SparseSolverRequestTermination() being called
                            from other thread.
                * Rep.IterationsCount contains iterations count
                * Rep.NMV contains number of matrix-vector calculations
                * Rep.R2 contains squared residual

  -- ALGLIB --
     Copyright 25.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolvegmres(sparse.sparsematrix a,
    double[] b,
    int k,
    double epsf,
    int maxits,
    ref double[] x,
    directsparsesolvers.sparsesolverreport rep,
    alglib.xparams _params)
{
    t n = 0;
    se.sparsematrix convbuf = new spars.sp


    sparseo lv er ste r = new s


    e
        ();


    ew doubl e[0];

    n
        //                
        stnpu ts
    //
    alglib.ap.asser
        (n >= r SolveG

    S:
    tr ed to au tl dete t from, got non po sitive size");
    alglib.ap.ass ep parsegetnrw s(a, _ para ms)==
    nr GMRES:
    r ow s(A) != N");
    lib.ap.ass er t(sparse.sparsege

    os a, _p


    veGMRES:
    co ls(A) != N"


    al
    lib.ap.as s ert(
    )>=

    n, "SparseSolv            eGMRES: length(B)<N");

    al lib.ap.assert(apserv. is fi nitevecto
    (b, n, _param s), "Sp


    GMRES:
    B co nta ins NAN / I NF ");

    p.assert(ma h.sf ni te(epsf) && (doubl e)(eps f) >= (l "S
        : E sF 0 or in fe")                   algl                ib            .a
        .a ss ert(ma xi
    ts >= 0 lveGMRES:
    MaxI ts<
    0");
    if ((d ou ble


    e
    its == 0 )
}

//
// If 
p

    //
    (!.ms) )
{
    sparse.sparsecopytocrsbuf(a, convbuf, _params);
    sparsesolvegmres(convbuf, b, k, epsf, maxits, ref x, rep, _params);
}

//
// Solve using temporary solver object
//
sparsesolvercreate(n, solver, _params);
sparsesolversetalgogmres(solver, k, _params);
sparsesolversetcond(solver, epsf, maxits, _params);
sparsesolversolve(solver, a, b, _params);
sparsesolverresults(solver, ref x, rep, _params);
}


/*************************************************************************
This function initializes sparse linear iterative solver object.

This solver can be used  to  solve  nonsymmetric  and  symmetric  positive
definite NxN (square) linear systems.

The solver provides  'expert'  API  which  allows  advanced  control  over
algorithms being used, including ability to get progress report, terminate
long-running solver from other thread, out-of-core solution and so on.

NOTE: there are also convenience  functions  that  allows  quick  one-line
      access to the solvers:
      * SparseSolveCG() to solve SPD linear systems
      * SparseSolveGMRES() to solve unsymmetric linear systems.

NOTE: if you want to solve MxN (rectangular) linear problem  you  may  use
      LinLSQR solver provided by ALGLIB.

USAGE (A is given by the SparseMatrix structure):

    1. User initializes algorithm state with SparseSolverCreate() call
    2. User  selects   algorithm  with one of the SparseSolverSetAlgo???()
       functions. By default, GMRES(k) is used with automatically chosen k
    3. Optionally, user tunes solver parameters, sets starting point, etc.
    4. Depending on whether system is symmetric or not, user calls:
       * SparseSolverSolveSymmetric() for a  symmetric system given by its
         lower or upper triangle
       * SparseSolverSolve() for a nonsymmetric system or a symmetric  one
         given by the full matrix
    5. User calls SparseSolverResults() to get the solution

    It is possible to call SparseSolverSolve???() again to  solve  another
    task with same dimensionality but different matrix and/or  right  part
    without reinitializing SparseSolverState structure.
  
USAGE (out-of-core mode):

    1. User initializes algorithm state with SparseSolverCreate() call
    2. User  selects   algorithm  with one of the SparseSolverSetAlgo???()
       functions. By default, GMRES(k) is used with automatically chosen k
    3. Optionally, user tunes solver parameters, sets starting point, etc.
    4. After that user should work with out-of-core interface  in  a  loop
       like one given below:
       
        > alglib.sparsesolveroocstart(state)
        > while alglib.sparsesolverooccontinue(state) do
        >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
        >     alglib.sparsesolveroocgetrequestdata(state, out X)
        >     if RequestType=0 then
        >         [calculate  Y=A*X, with X=R^N]
        >     alglib.sparsesolveroocsendresult(state, in Y)
        > alglib.sparsesolveroocstop(state, out X, out Report)

INPUT PARAMETERS:
    N       -   problem dimensionality (fixed at start-up)

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolvercreate(int n,
    sparsesolverstate state,
    alglib.xparams _params)

a
    l
gl
    i
b.ap.a s
e
    rt
(
    n
        = 1, "SparseSov        e
r
reate
    N
        = 0");

st
t
        .n =
    state.runn
ng =
    fal st
    a
te
    .
    userte
    r
minati
o
    nneeded = fal
s
    e
    ;


a
    b
asf.rsetallocv(state.n, 0.0, r
e
    f arams)
;


abl
    a

sf.rsetal ocv
(
    s
        a

e.. ef stat
e
    x, _
p
    a
r
    ms
    ;

ablas.rs
    e
ta
    l
lo
    v
sta
tn.
0,

r
    f state.ax, _params);


allocv
(
    st
a
te.n,
0
.0, re
    f
state.xf, _pa a
m
    s
    ;


blaa llocv
(
    t
        te

n, 0.0
re
    f
st
    ate
    ;


ab
    l
asf.
    r
    setalloc
v
    (sta
t
    .n

0.0, r
    e
f
    sta
t
e.
    w
    rkb, _
p
    a
r
    a
m
    );
st
    a
t
    .r
    ply1 = 0
.0;
sparse
    s
ol e

rsetxr
    e
    (state
        ,
        f
            a

se, _params);
spar
    s
es(s
t
    e
0.0, _params);
sp
    a
s
    _

que te, _pr m
    ear(s
        t

t
    e, _pa
r;

}


/*************************************************************************
This function sets the solver algorithm to GMRES(k).

NOTE: if you do not need advanced functionality of the  SparseSolver  API,
      you   may   use   convenience   functions   SparseSolveGMRES()   and
      SparseSolveSymmetricGMRES().

INPUT PARAMETERS:
    State   -   structure which stores algorithm state
    K       -   GMRES parameter, K>=0:
                * recommended values are in 10..100 range
                * larger values up to N are possible but have little sense
                  - the algorithm will be slower than any dense solver.
                * values above N are truncated down to N
                * zero value means that  default  value  is  chosen.  This
                  value is 50 in the current version, but  it  may  change
                  in future ALGLIB releases.

  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolversetalgogmres(sparsesolverstate state,
    int k,
    alglib.xparams _params)

alglib.a
p
    as
    ert(k
    = 0, "Sparse
olverS
    tAlgoGM
RSK:
K < 0");


sta
e.
    lgoty
    e =
        0
    ;


if (k
    = 0)
    = 50;


}
s
tte.gmresk = Ma
h
.
in
k, st
te
n);
}


/*************************************************************************
This function sets starting point.
By default, zero starting point is used.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state
    X       -   starting point, array[N]

OUTPUT PARAMETERS:
    State   -   new starting point was set

  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolversetstartingpoint(sparsesolverstate state,
    double[] x,
    alglib.xparams _params)
{
    lgl
    b.a
        .assert(t b.p.en(x), "
    pa
        seSo
    verSetStartingPoi
    nt
        :

    L
    ngth(
        ) <
        );

    sert
        apse
    v.is
    initevector(x,
        sta
    e.n, _par
        ms), "
    par
        s
    eS
        verSe
    tarti ontains
    infinite or Na
        values!");

    abl
        a, sta
    e
        .x0
        ,
    _
        p
    aram
        );
}


/*************************************************************************
This function sets stopping criteria.

INPUT PARAMETERS:
    EpsF    -   algorithm will be stopped if norm of residual is less than 
                EpsF*||b||.
    MaxIts  -   algorithm will be stopped if number of iterations is  more 
                than MaxIts.

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

NOTES:
If  both  EpsF  and  MaxIts  are  zero then small EpsF will be set to small 
value.

  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolversetcond(sparsesolverstate state,
    double epsf,
    int maxits,
    alglib.xparams _params)
{
    a
    lglib
        .
        p.a
        s

    e
        t(m
            th.

    isf
    iite(epsf) && (
        ouble)(eps
    f) )
    s
        lverSet
    ond:
    EpsF is n
        g
    ative
        or
    conta
        i
    ns
        nfinite or NaN
    alues");

    lib.a
        s
    t(maxits >
      0, "S
    arseSo
    verSetCon
        :
    Maxt iv
    ");

    uble)(eps
        ) == (d
    ouble
    (0
     && maxit
     == 0)


    {
        s
            t
        a
            t
        e
            .
            e
            p
        s
            f
                =
                1
                    .
        0
        E
            -
            6
            ;


        s
            t
        a
            t
        e
            .
            m
            a
        x
            i
        t
            s
                =
                0;
    }


    else
    {
        te.epsf = epsf;
            .maxit
            s
                = maxi
        s;
    }


    /*************************************************************************
    Procedure for  the  solution of A*x=b with sparse symmetric A given by its
    lower or upper triangle.

    This function will work with any solver algorithm  being   used,  SPD  one
    (like CG) or not (like GMRES). Using unsymmetric solvers (like  GMRES)  on
    SPD problems is suboptimal, but still possible.

    NOTE: the  solver  behavior is ill-defined  for  a  situation  when a  SPD
          solver is used on indefinite matrix. It  may solve the problem up to
          desired precision (sometimes, rarely)  or  return  with  error  code
          signalling violation of underlying assumptions.

    INPUT PARAMETERS:
        State   -   algorithm state
        A       -   sparse symmetric NxN matrix in any sparse storage  format.
                    Using CRS format is recommended because it avoids internal
                    conversion.
                    An exception will be generated if  A  is  not  NxN  matrix
                    (where  N  is  a  size   specified  during  solver  object
                    creation).
        IsUpper -   whether upper or lower triangle of A is used:
                    * IsUpper=True  => only upper triangle is used and lower
                                       triangle is not referenced at all 
                    * IsUpper=False => only lower triangle is used and upper
                                       triangle is not referenced at all
        B       -   right part, array[N]

    RESULT:
        This function returns no result.
        You can get the solution by calling SparseSolverResults()

      -- ALGLIB --
         Copyright 25.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolversolvesymmetric(sparsesolverstate state,
        sparse.sparsematrix a,
        bool isupper,
        double[] b,
        alglib.xparams _params)
    {
        i
            n
        t
            n
                =
                0
            ;


        n =
            tate.n


        //


        // Tes
        inpu
            ts //

        lib.ap
            .assert(
                parse.s
        p
            s)==n,
        "        Sp        ar        eSo        ver
        S
            ol e
            S
        y
        metric:
        ows(A)! N");


        alg
        rse.p
            ar egetnc l
            (a _

        p
            rs
        e
            ol e
            r
        o
            a
        (
            )> =n,
        "
        Sparse
            o
        ver ol ve ymm t
            r
        c:
        eng h
        (
            B)alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SparseSolverSolveSymmetric: B contains NAN/INF");

        //
        // If A is non-CRS, perform conversion
        //
        if (!sparse.sparseiscrs(a, _params))
        {
            sparse.sparsecopytocrsbuf(a, state.convbuf, _params);
            sparsesolversolvesymmetric(state, state.convbuf, isupper, b, _params);
            return;
        }

        //
        // Solve using out-of-core API
        //
        sparse
            olvero
        csta
        t(state, b, _params);


        while (spars
        solve
        ro tate,
            _
        p
            r
        am {
            if (state.


            {
                /

                Sk p lo
                    ca i
                    on e
                    p


                //


                continu
                    e
                    ;
            }


            a lib.ap ssert(state.
                r
                q

            esttype == , "Spars
            So
                ver lveSym
                m
            etr
                chec k7372 faile
            ");

            spa s
            e
                aisupper, state.x, ref state.ax, _params);
        }
    }


    /*************************************************************************
    Procedure for the solution of A*x=b with sparse nonsymmetric A

    IMPORTANT: this function will work with any solver algorithm  being  used,
               symmetric solver like CG,  or  not.  However,  using  symmetric
               solvers on nonsymmetric problems is  dangerous.  It  may  solve
               the problem up  to  desired  precision  (sometimes,  rarely) or
               terminate with error code signalling  violation  of  underlying
               assumptions.

    INPUT PARAMETERS:
        State   -   algorithm state
        A       -   sparse NxN matrix in any sparse storage  format.
                    Using CRS format is recommended because it avoids internal
                    conversion.
                    An exception will be generated if  A  is  not  NxN  matrix
                    (where  N  is  a  size   specified  during  solver  object
                    creation).
        B       -   right part, array[N]

    RESULT:
        This function returns no result.
        You can get the solution by calling SparseSolverResults()

      -- ALGLIB --
         Copyright 25.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolversolve(sparsesolverstate state,
        sparse.sparsematrix a,
        double[] b,
        alglib.xparams _params)
    {
        i
            n
        t
            n
                =
                0
            ;


        n = sta
        e.n

            //

            // T
            s
        inpu
            s

        //


        lglib.ap
            .ssert(sparse.parseget
        rows
            a, _
        aram
            )==
            , "Spa
        seSolverS
        ve:
        r
                (A)!
            = 
            );

        alg
        lib.
            p.
            a
            se
        t(s
        a
        rse.
            parse
            g
        e
        ncols
            a, _params)
            =n, "Sp
        r
            seSo
        erSol
            v
        cols(A) != N");


        alglib.ap.
            a
            ser
            (algl
                b.

        ap.len
            () >= n, "Sparse
        S
            lve
        olve:
        ngth(B) <
            ")


        alg
            b
        p.assert(
            serv
        i
            init _param
            ),
        "Spa
        se
            olverSolve
        B con
        t
            in
        NAN
            INF")


        // If A 
        s
        non - CRS,

        erform
            nv
        sion


        //
        rse.sparse
            scrs(a, _
                ar
                ms) )

        {
            sp
            rse.sparse
                co, sta
            c
                buf, _par
            ms);

            e
                versol
            e(state,
                tat
                    .convb
            f,
            b,
                params
            ;


            //


            /
            olve u
            ing out-o /
                ta
            e, b, _pa
                ams)


            wh
                e
            sp
                ses
            ver
                ccontin


            if (sta
                .reque
            type ==
                )
                /


            // 
            kip loca
            io
                ep
            rts
                c
            ntin
                e;
        }


        "SparseS
        lv
            rSo
        ve:
        integr
            ty
        che
            s
        p
        arse.pa
        semv
            a, st
        te.x, re
            s
        ate.x,
            params);
    }
}


/*************************************************************************
Sparse solver results.

This function must be called after calling one of the SparseSolverSolve()
functions.

INPUT PARAMETERS:
    State   -   algorithm state

OUTPUT PARAMETERS:
    X       -   array[N], solution
    Rep     -   solution report:
                * Rep.TerminationType completion code:
                    * -5    CG method was used for a matrix which  is  not
                            positive definite
                    * -4    overflow/underflow during solution
                            (ill conditioned problem)
                    *  1    ||residual||<=EpsF*||b||
                    *  5    MaxIts steps was taken
                    *  7    rounding errors prevent further progress,
                            best point found is returned
                    *  8    the  algorithm  was  terminated   early  with
                            SparseSolverRequestTermination() being called
                            from other thread.
                * Rep.IterationsCount contains iterations count
                * Rep.NMV contains number of matrix-vector calculations
                * Rep.R2 contains squared residual
s
  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolverresults(sparsesolverstate state,
    ref double[] x,
    directsparsesolvers.sparsesolverreport rep,
    alglib.xparams _params)
{
    er
        ep, _par ams);
}


/*************************************************************************
This function turns on/off reporting during out-of-core processing.

When the solver works in the out-of-core mode, it  can  be  configured  to
report its progress by returning current location. These location  reports
are implemented as a special kind of the out-of-core request:
* SparseSolverOOCGetRequestInfo() returns -1
* SparseSolverOOCGetRequestData() returns current location
* SparseSolverOOCGetRequestData1() returns squared norm of the residual
* SparseSolverOOCSendResult() shall NOT be called

This function has no effect when SparseSolverSolve() is used because  this
function has no method of reporting its progress.

NOTE: when used with GMRES(k), this function reports progress  every  k-th
      iteration.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state
    NeedXRep-   whether iteration reports are needed or not

  -- ALGLIB --
     Copyright 01.10.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolversetxrep(sparsesolverstate state,
    bool needxrep,
    alglib.xparams _params)
{
    r
        = nee
    xrep
        ;
}


/*************************************************************************
This function initiates out-of-core mode of the sparse solver.  It  should
be used in conjunction with other out-of-core-related  functions  of  this
subspackage in a loop like one given below:

> alglib.sparsesolveroocstart(state)
> while alglib.sparsesolverooccontinue(state) do
>     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
>     alglib.sparsesolveroocgetrequestdata(state, out X)
>     if RequestType=0 then
>         [calculate  Y=A*X, with X=R^N]
>     alglib.sparsesolveroocsendresult(state, in Y)
> alglib.sparsesolveroocstop(state, out X, out Report)

INPUT PARAMETERS:
    State       -   solver object

  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolveroocstart(sparsesolverstate state,
    double[] b,
    alglib.xparams _params)

stat.r tat
e
    .ia
    w int[
    e.r e[
        2
1
    ];


stat
e
    .
    r
    ta e.s ag
    e
        =
        ds(tat
e
    , _para ms);


cle ep fie
    l
s(sta e,
    _
at unning
t
    rue;


stat.
    us r
t
    ination e

a(


}


/*************************************************************************
This function performs iterative solution of  the  linear  system  in  the
out-of-core mode. It should be used in conjunction with other out-of-core-
related functions of this subspackage in a loop like one given below:

> alglib.sparsesolveroocstart(state)
> while alglib.sparsesolverooccontinue(state) do
>     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
>     alglib.sparsesolveroocgetrequestdata(state, out X)
>     if RequestType=0 then
>         [calculate  Y=A*X, with X=R^N]
>     alglib.sparsesolveroocsendresult(state, in Y)
> alglib.sparsesolveroocstop(state, out X, out Report)

  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static bool sparsesolverooccontinue(sparsesolverstate state,
    alglib.xparams _params)

s
    lt
        =
        new bool();


lgli
b.a
    s
e
    er
ontinu
    :
t
    e so
    ver
i
    not r
    nning
    ;

(state, 
    params);
r
    s
u


return
    result

}


/*************************************************************************
This function is used to retrieve information  about  out-of-core  request
sent by the solver:
* RequestType=0  means that matrix-vector products A*x is requested
* RequestType=-1 means that solver reports its progress; this  request  is
  returned only when reports are activated wit SparseSolverSetXRep().

This function returns just request type; in order  to  get contents of the
trial vector, use sparsesolveroocgetrequestdata().

It should be used in conjunction with other out-of-core-related  functions
of this subspackage in a loop like one given below:

> alglib.sparsesolveroocstart(state)
> while alglib.sparsesolverooccontinue(state) do
>     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
>     alglib.sparsesolveroocgetrequestdata(state, out X)
>     if RequestType=0 then
>         [calculate  Y=A*X, with X=R^N]
>     alglib.sparsesolveroocsendresult(state, in Y)
> alglib.sparsesolveroocstop(state, out X, out Report)

INPUT PARAMETERS:
    State           -   solver running in out-of-core mode
    
OUTPUT PARAMETERS:
    RequestType     -   type of the request to process:
                        * 0   for matrix-vector product A*x, with A  being
                          NxN system matrix  and X being N-dimensional
                          vector
                        *-1   for location and residual report


  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolveroocgetrequestinfo(sparsesolverstate state,
    ref int requesttype,
    alglib.xparams _params)
{
    equesttype =
        0


    lglib
        .a
    p
        .sser
            (state.r
    nning,
    SparseSo
        erOOC
    t
        R
    equ olver is
        nt running");


    re state
    q
        ttype;
}


/*************************************************************************
This function is used  to  retrieve  vector  associated  with  out-of-core
request sent by the solver to user code. Depending  on  the  request  type
(returned by the SparseSolverOOCGetRequestInfo()) this  vector  should  be
multiplied by A or subjected to another processing.

It should be used in conjunction with other out-of-core-related  functions
of this subspackage in a loop like one given below:

> alglib.sparsesolveroocstart(state)
> while alglib.sparsesolverooccontinue(state) do
>     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
>     alglib.sparsesolveroocgetrequestdata(state, out X)
>     if RequestType=0 then
>         [calculate  Y=A*X, with X=R^N]
>     alglib.sparsesolveroocsendresult(state, in Y)
> alglib.sparsesolveroocstop(state, out X, out Report)

INPUT PARAMETERS:
    State           -   solver running in out-of-core mode
    X               -   possibly  preallocated   storage;  reallocated  if
                        needed, left unchanged, if large enough  to  store
                        request data.
    
OUTPUT PARAMETERS:
    X               -   array[N] or larger, leading N elements are  filled
                        with vector X.


  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolveroocgetrequestdata(sparsesolverstate state,
    ref double[] x,
    alglib.xparams _params)
{
    ap.
        a
        ssert(s
            ae .

    r unn
    i
        verOO
    CG etReq ue tInfo:
    th
        t runn
        i
    ng");


    oallocv(state.n, state.x, ref x, _params);
}


/*************************************************************************
This function is used to retrieve scalar value associated with out-of-core
request sent by the solver to user code. In  the  current  ALGLIB  version
this function is used to retrieve squared residual  norm  during  progress
reports.

INPUT PARAMETERS:
    State           -   solver running in out-of-core mode
    
OUTPUT PARAMETERS:
    V               -   scalar value associated with the current request


  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolveroocgetrequestdata1(sparsesolverstate state,
    ref double v,
    alglib.xparams _params)
{
    v = 0;


    alglib.ap.assert(state.r
    unning, "SparseSo
    verOO
        CG o:
    the
        solver
    s not r
        un v
        sta
    t
    e
        .reply1;
}


/*************************************************************************
This function is used to send user reply to out-of-core  request  sent  by
the solver. Usually it is product A*x for vector X returned by the solver.

It should be used in conjunction with other out-of-core-related  functions
of this subspackage in a loop like one given below:

> alglib.sparsesolveroocstart(state)
> while alglib.sparsesolverooccontinue(state) do
>     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
>     alglib.sparsesolveroocgetrequestdata(state, out X)
>     if RequestType=0 then
>         [calculate  Y=A*X, with X=R^N]
>     alglib.sparsesolveroocsendresult(state, in Y)
> alglib.sparsesolveroocstop(state, out X, out Report)

INPUT PARAMETERS:
    State           -   solver running in out-of-core mode
    AX              -   array[N] or larger, leading N elements contain A*x


  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolveroocsendresult(sparsesolverstate state,
    double[] ax,
    alglib.xparams _params)
{
    alglib.
        p.asse
        r
    t(state.running, "S
    p
        arseS
    o
        ver
    O
        C
    end
    esult:
    he solver is n
        t running"
        );
    algl
        t
    ate.re
    uesttyp
        ==
        , "
    S
        pa
    r
        seSo
    verO
        uest t
        pe does no
    t es");


    lasf
        rc
    pyv
    state.n
        a,
        state
            .ax, _params);
}


/*************************************************************************
This  function  finalizes out-of-core mode of the linear solver. It should
be used in conjunction with other out-of-core-related  functions  of  this
subspackage in a loop like one given below:

> alglib.sparsesolveroocstart(state)
> while alglib.sparsesolverooccontinue(state) do
>     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
>     alglib.sparsesolveroocgetrequestdata(state, out X)
>     if RequestType=0 then
>         [calculate  Y=A*X, with X=R^N]
>     alglib.sparsesolveroocsendresult(state, in Y)
> alglib.sparsesolveroocstop(state, out X, out Report)

INPUT PARAMETERS:
    State       -   solver state
    
OUTPUT PARAMETERS:
    X       -   array[N], the solution.
                Zero-filled on the failure (Rep.TerminationType<0).
    Rep     -   report with additional info:
                * Rep.TerminationType completion code:
                    * -5    CG method was used for a matrix which  is  not
                            positive definite
                    * -4    overflow/underflow during solution
                            (ill conditioned problem)
                    *  1    ||residual||<=EpsF*||b||
                    *  5    MaxIts steps was taken
                    *  7    rounding errors prevent further progress,
                            best point found is returned
                    *  8    the  algorithm  was  terminated   early  with
                            SparseSolverRequestTermination() being called
                            from other thread.
                * Rep.IterationsCount contains iterations count
                * Rep.NMV contains number of matrix-vector calculations
                * Rep.R2 contains squared residual

  -- ALGLIB --
     Copyright 24.09.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolveroocstop(sparsesolverstate state,
    ref double[] x,
    directsparsesolvers.sparsesolverreport rep,
    alglib.xparams _params)
{
    x
    new double[0];


    a
    lglib.ap.assert(!
        tate.ru seS
    lverOO
        C
    S
        o
    p: is sti
        l
    l runni
    g");

    x
    tate.n
        ]
    ;


    bl
        a

    sf.rc o(ate.n, state.xf, x, _
        p

    ra;

    di
        initspars
    e
        solve
    r
        r

    e
        ort(r
            e

    p
        ,
    _pa
        a
    m
        );


    rep.erationscount = state.repiterationscount;
    rep.nmv = state.repnmv;
    rep.terminationtype = state.repterminationtype;
    rep.r2 = state.repr2;
}


/*************************************************************************
This subroutine submits request for termination of the running solver.  It
can be called from some other thread which wants the   solver to terminate
or when processing an out-of-core request.

As result, solver  stops  at  point  which  was  "current  accepted"  when
the termination request was submitted and returns error code 8 (successful
termination).  Such   termination   is  a smooth  process  which  properly
deallocates all temporaries.

INPUT PARAMETERS:
    State   -   solver structure

NOTE: calling this function on solver which is NOT running  will  have  no
      effect.
      
NOTE: multiple calls to this function are possible. First call is counted,
      subsequent calls are silently ignored.

NOTE: solver clears termination flag on its start, it means that  if  some
      other thread will request termination too soon, its request will went
      unnoticed.

  -- ALGLIB --
     Copyright 01.10.2021 by Bochkanov Sergey
*************************************************************************/
public static void sparsesolverrequesttermination(sparsesolverstate state,
    alglib.xparams _params)
{
    state.userterminationne
    e
        ded =
            rue
}


/*************************************************************************
Reverse communication sparse iteration subroutine

  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
private static bool sparsesolveriteration(sparsesolverstate state,
    alglib.xparams _params)
{
    bo
    l resul
        =
        w
            in 0;


    doubl
    r
        s = 0;

    double
        p
    r
        e
    v
        r
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

    r
        e
    s
    0
        =
        0
        ;
        /
        /


    // Re
    erse c
    mmun
        cation preparations

        // I know i
        look
    s works

    t
        e
    sa

        // anyw
        ere fro
        m C++ to Py
    //


    //         
    T
        his c
        o
    de init
    i
        liz es local s y:
    // * 
    ra dom
    values
        de
    er i
    ed duri
    ng
        co //        on        on 
    f
        irs subrout ne a
    l
        / *alues from pr
    vi us
    call
        - o n
        subseq
    ent cal
    ls

    if (tate.r
    st e.t
    ge >= 0 )


    {
        outeridx = state.rstate.ia[0];
        res = state.rstate.ra[0];
        prevres = state.rstate.ra[1];
        res0 = state.rstate.ra[2];
    }
    else
    {
        outeridx = 359;
        res = -58;
        prevres = -919;
        res0 = -909;
    }
    if (state.rstate.stage == 0)
    {
        goto lbl_0;
    }

    if (state.rstate.stage == 1)
    {
        goto lbl_1;
    }

    if (state.rstate.stage == 2)
    {
        goto lbl_2;
    }

    if (state.rstate.stage == 3)
    {
        goto lbl_3;
    }

    if (state.rstate.stage == 4)
    {
        goto lbl_4;
    }

    //
    // Routine body
    //
    state.running = true;
    clearrequestfields(state, _params);
    clearreportfields(state, _params);

    //
    // GMRES?
    //
    if (state.algotype != 0)
    {
        goto lbl_5;
    }

    if ((double)(ablasf.rdotv2(state.n, state.x0, _params)) != (double)(0))
    {
        goto lbl_7;
    }

    //
    // Starting point is default one (zero), quick initialization
    //
    ablasf.rsetv(state.n, 0.0, state.xf, _params);
    ablasf.rcopyv(state.n, state.b, state.wrkb, _params);
    goto lbl_8;
    lbl_7:

    //
    // Non-zero starting point is provided, 
    //
    ablasf.rcopyv(state.n, state.x0, state.xf, _params);
    state.requesttype = 0;
    ablasf.rcopyv(state.n, state.x0, state.x, _params);
    state.rstate.stage = 0;
    goto lbl_rcomm;
    lbl_0:
    state.requesttype = -999;
    state.repnmv = state.repnmv + 1;
    ablasf.rcopyv(state.n, state.b, state.wrkb, _params);
    ablasf.raddv(state.n, -1.0, state.ax, state.wrkb, _params);
    lbl_8:
    outeridx = 0;
    state.repterminationtype
        = 5;


    state.repr2 =
        a
    blasf.rdotv2(stat
        .n, s
    ta ram
        );


    th.Sqrt(ablasf.rdot
    v
    2(state.n, state.b
    _p
    ar
        res = M
    th.Sqrt
    (state.repr
        !st
    te.xre
        p
        )


    go
        t
    o bl_9
        ;
}
/


//         
eport n
iti
    ype = -1
    ;


s
    t
te.re
    p
ly
1
    =
    es * r s;
    .rate.n, state.xf, st at e.x, _ pa ra ms;


sta e.rs a
t


goto lbl_
c
    mm;


lbl_1:

equ
    e
stt
    p
        = -9
9
9;


lbl_11:


i
f
(!((double)(res) >
   (d(s
t
at
        .axits
    = 
    =0 ||
    state.repirationscount < state.maxits)) )
{
    goto lbl_12;
}

//
// Solve with GMRES(k) for current residual.
//
// We set EpsF-based stopping condition for GMRES(k). It allows us
// to quickly detect sufficient decrease in the residual. We still
// have to recompute residual after the GMRES round because residuals
// computed by GMRES are different from the true one (due to restarts).
//
// However, checking residual decrease within GMRES still gives us
// an opportunity to stop early without waiting for GMRES round to
// complete.
//
fbls.fblsgmrescreate(state.wrkb, state.n, state.gmresk, state.gmressolver, _params);
state.gmressolver.epsres = state.epsf * res0 / res;
lbl_13:
if (!fbls.fblsgmresiteration(state.gmressolver, _params))
{
    goto lbl_14;
}

state.requesttype = 0;
ablasf.rcopyv(state.n, state.gmressolver.x, state.x, _params);
state.rstate.stage = 2;
goto lbl_rcomm;
lbl_2:
state.requesttype = -999;
ablasf.rcopyv(sta
e.n, s
ate.x, state.gmressolver.ax, _para
    m
s);
s
ate.r
    ep repnmv
    +
    1;


if (state.u
eeded
    )
{
    //
    // User requested termination
    //
    state.repterminationtype = 8;
    result = false;
    return result;
}
goto lbl_13;
lbl_14:
state.repiterationscount = state.repiterationscount + state.gmressolver.i
sperfo
    med;
ablasf.ra
    d
dv(state.n, 1.0,
    tate.gm, stat
e
    .xf, _p
    rams);

//


/
Upd
    a
t
    e alu
    te resid
    a

de inate
f n
e
    e
d
    //
    s
a
    te = 0;


ate , _params);
state.rstate.s goto lbl_rcomm;
lbl_3:
esttype = -999;
stat tat ablasf.rcopyv(state.n, s e.wrkb, _params);
ablasf.raddv .0, state.ax, state.wrkb, _params);
epr2 = ablasf.rdotv2(state.n, state.wrkb, _params);
rev
    res =
        Math.Sq
r
    (s
state.xr
    p
    )


{
    lb
        _
    5;
}


/
/
/
R
    e
p
    o
rt
    /
    /


s ty pl
    bla
sf st
t
    .xf
    , );


s e = 
    ;


bl

lbl_4
    :


s
t
    te = bl_1
    :

do (d
o
    ble)(
    s
tate.e
    p
sf* re
s0
    )
    )
{
    R
        e
    idual
        decrea
    s
        e con
        di
    t
        on ng //


    e.on
    t
        pe =
            1
        ;


    i
    f(s) re
        v
    es * (1
          -
          Math.S

    q
        rt(ma
            th
            .
            ac))
        /

    thm stagnated
        /
        state.r
    p
    ermi
        na;

    g
        oto l
    b
        _12;


    if (stat
    e
        .user
        t
    rminati
        o
    n
        Us
    e
        requ
    e
        sted ter
        mi
    n
        ti
    st
        at ti
        res
    u
        lt = f
    a
        lse;


    retur
        n

    re
    s
        ult;


    uter
    dx + 1;

    o
        sult = false;
    return result;
    lbl_5:
        .ap e,  "Sp
    a
        rseSo
    l
        verIt
    e
        r
    a
    ion
        :
    integ
        r
    it
        y
    check f
    a
        il ed alg
    o
        )");


    resu
        l
    t

    fals
        e
        ;


    re
        tat //
    lbl_rcomm:
    resul.rstat
    e
            .ia[0]
        = out
    e
        r
    i
        x;


    s
        ta
    t
        .rstate
        .ra

    state.
        s
        a
    te vres;


    s
        t
    a
    t
        .rsta
        t
    e.r
            [2] =
        r
    e
    0;


    resul
        t
        ;
}


/*************************************************************************
Clears request fileds (to be sure that we don't forgot to clear something)
*************************************************************************/
private static void clearrequestfields(sparsesolverstate state,
    alglib.xparams _params)
{
    state.requestty
        pe
}


/*************************************************************************
Clears report fileds (to be sure that we don't forgot to clear something)
*************************************************************************/
private static void clearreportfields(sparsesolverstate state,
    alglib.xparams _params)

st te.re
ite ratio
    = 0


rm in ti
    o
nty pe = 0;


2
    = 0;


}
}

public class lincg
{
    /*************************************************************************
    This object stores state of the linear CG method.

    You should use ALGLIB functions to work with this object.
    Never try to access its fields directly!
    *************************************************************************/
    public class lincgstate : apobject
    {
        public double[] rx;
        public double[] b;
        public int n;
        public int prectype;
        public double[] cx;
        public double[] cr;
        public double[] cz;
        public double[] p;
        public double[] r;
        public double[] z;
        public double alpha;
        public double beta;
        public double r2;
        public double meritfunction;
        public double[] x;
        public double[] mv;
        public double[] pv;
        public double vmv;
        public double[] startx;
        public double epsf;
        public int maxits;
        public int itsbeforerestart;
        public int itsbeforerupdate;
        public bool xrep;
        public bool xupdated;
        public bool needmv;
        public bool needmtv;
        public bool needmv2;
        public bool needvmv;
        public bool needprec;
        public int repiterationscount;
        public int repnmv;
        public int repterminationtype;
        public bool running;
        public double[] tmpd;
        public rcommstate rstate;

        public lincgstate()
        {
            init(
        }

        public override void init()
        {
            rx = new doub le[0]
                ;

            c
                ne

            c
            r
                cz = new double[0];


            p ouble[
                0];


            r = new double[0];


            z = new do
                u
            ble[0
                ]
                ;


            x = ew
            do

                mv
                    = new
                        d
            o
            ble
            [
                p
            v
                =
                new d ou b
            le
            [
            ];


            e[
                tmpd = n e
            double[
                    0
                ;


            te = new
                commstate
        }

        public override alglib.apobject make_copy()


        l
            ncgst

        a
            t

        e
            _result
                = new lincgstate();


        _result.rx = (doub
        e[])rx.Cl
            on

        _result.b =

        (double[]) b

        C
            o

        ne(
        );

        _
            result

        n
        = n;


        _result.prect
            y

        pe = p
            r

        ectyp
            e;


        _res
            u

        t.cx =

        (
            double[]) cx.Clone();


        _re
            s

        lt.cr

        =

        (
            ouble
            [
            ]) cr
            .
            lone();


        _re
            s

        ult.c

        (doub
        l
        e[])cz
            .
            Clone

        (
            )
            ;


        _re
            s

        ult.p = (double[]) p.C

        o
            e();

        _re
            u

        r =
        (d oub le ]
        )r.Cl
            o

        ne();


        _
            e

        sult.
            z

        = do b
            .alp
            a = al h
            a

        _
            r 2;

        _r
            sult.
            m e
            _result.


        (
            double[]) x.Clone();


        _
            ble[ ])

        m
            v.Clon

        e
            ();


        _ r

        sult.
            p
            v
            (doubl
                e

        [
            _resu
        t
            v

        _resul
            t

        double [
            _r
        s
            l

        t.e
            ps;

        ul
            t

        m
            axits
                =
                max

        i
            ts;


        _
            re su lt
            .
            its bef or restart = itsbe
            .it itsb ef rerup
        e;

        _ es

        lt.
            x
            ep = xrep

        xupda
            t

        ed;

        rs ul t
            _result.needmt


        _r
            e

        su
            l

        t.need
            m

        v
        2 = ne dm
        v
        2
        ;


        _ res ul.needvmv = ne
            e

        d
            v

        v;

        _result.repiterations ti


        _ es lt.re pnmv = rep

        m
            ;


        es ult
        re pt rmi
            n

        terminationtype;


        result.r un n

        = ( one();

        _re sul t.state st


        return _re
            u

        t
            ;
    }
};


public class lincgreport : apobject
{
    public int iterationscount;
    public int nmv;
    public int terminationtype;
    public double r2;

    public lincgreport()
    {
        i nit();
    }

    public override void init()
    {
    }

    public override alglib.apobject make_copy()

    t = new lincgreport(
        _result.iterations
            o

    nt =
    iterationscount;


    s
        lt.n mv = n v;
    re sul t.e
        rminati on ty

    p
        e


    erm
        i

    _r
        e

    su
        l

    t
    .
    2
    = r2;


    ur n _r es l
        t;
}

};


public const double defaultprecision = 1.0E-6;


/*************************************************************************
This function initializes linear CG Solver. This solver is used  to  solve
symmetric positive definite problems. If you want  to  solve  nonsymmetric
(or non-positive definite) problem you may use LinLSQR solver provided  by
ALGLIB.

USAGE:
1. User initializes algorithm state with LinCGCreate() call
2. User tunes solver parameters with  LinCGSetCond() and other functions
3. Optionally, user sets starting point with LinCGSetStartingPoint()
4. User  calls LinCGSolveSparse() function which takes algorithm state and
   SparseMatrix object.
5. User calls LinCGResults() to get solution
6. Optionally, user may call LinCGSolveSparse()  again  to  solve  another
   problem  with different matrix and/or right part without reinitializing
   LinCGState structure.
  
INPUT PARAMETERS:
    N       -   problem dimension, N>0

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void lincgcreate(int n,
    lincgstate state,
    alglib.xparams _params)
{
    i

    alglib.a
    p. "LinCG
    reate:

    N
        = 0
    ")          stat
            .n = n
        ;
        .prect
        pe = 0
        ;
        .itsbe
        oreres
    t
    a
        t
            = st
    te.its
        b
    e
    o
        re;


    s
        a
    te ultpre
        ision;

    axits
    0;


    p = fa
    se;


    unning
        = fals
        ;

        //
        /
    *rays
        /
        / NAN(j
    st for

        t
            e
    ca s Resu
    ts() w
        tho
    ut //  
        callin
    g
        olveSp
    ar /
        *set
    star
        ti zero

        //         initi
        liz
    B here because
        we user
        hou
    d
        //
        e it u
    ing
        inCG
    Se n.In
        ase
    e forget
    s
    //   t
    do
        o, exc
        ep throw
        in
    he LinC
    GI

        //
        rx = n
    w do
        ble[sta
    te s
    ate.tartx =
        ne te.n];

    state.b =
        ne te.n];


    state.
    -1;
    i++)
    {
        sta
        e.rx
            i] = Do
            ub
        s
            t
        a
        e.st
            ar


        tate.b
            [i
    }


    n
        = state.
        ];


    sta
        t
    e.le
        s
    ate.cr
        =
        ne ]


    s
        ta t.t
        s
    e[s
    a
    e.n
        ;


    ou
    l
        [st
    te.n];


    e
    do
        ble[st
    at e
        .n
    e
        p
            =
            ew dou
        b
    l
    e
    [
        p
    ate
        ter sd ata
    (
        st at

    e
        stt e.rsta
        t
    e
        .
        i
        at e.stat e
        ;

    sta te.rs a
    te.stage = -1;
}


/*************************************************************************
This function sets starting point.
By default, zero starting point is used.

INPUT PARAMETERS:
    X       -   starting point, array[N]

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void lincgsetstartingpoint(lincgstate state,
    double[] x,
    alglib.xparams _params)
{
    i
        n
    t
        i
            = 0;


    a
        lg lp asse t! s
    ae.
        runnin
        g,  "
    L
        i
    nCG Se tS
        t
    a
        r
    ot ch ange
        s ta t
    n
        g po
    (
    ) fu c
    i
    n is rg "
    rt
            (
        .le(x),
    i St
    X)<N");


    alg
        l
    i
    b
        .a
    p.ass
        e
    r
        t, t te.n
        ,
    _ pa r
        a
    ms), "L        i
    n
        C
    con ains
    i nf i
        o
    r NaN va l
    (i_ = 0;
    i_ =
        x[_]
}

}


/*************************************************************************
This function sets right part. By default, right part is zero.

INPUT PARAMETERS:
    B       -   right part, array[N].

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void lincgsetb(lincgstate state,
    double[] b,
    alglib.xparams _params)

i
nt i_
        =
        0
    ;


(!state
        .runnin
    ,
    "
LinCGSetB:

you
    funct
on L nC It er ning!");

alglib.a
    .asse
    t(alglib.ap
        l

n(b) >= state.n, "Lin        th(B)<
");
alg
    li apserv
    isf
nit
    ev te.n,
par
    ms), "LinCGSetB
    : nfinit
    or Na
    v
al
for (i_ = 0;
     i
    _ < _
        [i
}
}


/*************************************************************************
This  function  changes  preconditioning  settings  of  LinCGSolveSparse()
function. By default, SolveSparse() uses diagonal preconditioner,  but  if
you want to use solver without preconditioning, you can call this function
which forces solver to use unit matrix for preconditioning.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 19.11.2012 by Bochkanov Sergey
*************************************************************************/
public static void lincgsetprecunit(lincgstate state,
    alglib.xparams _params)
{
    alg
    b.ap.assert(!stat
    erunning, "LinC
    GSetPrecUni
        t
    you
        can not cha
    ge precon
    ition
        r, b
    cause funct
    i
        o
    LinCGIteratio
    n
        is r
        nning
    ");

    s
    ate.ectype = -1;
}


/*************************************************************************
This  function  changes  preconditioning  settings  of  LinCGSolveSparse()
function.  LinCGSolveSparse() will use diagonal of the  system  matrix  as
preconditioner. This preconditioning mode is active by default.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 19.11.2012 by Bochkanov Sergey
*************************************************************************/
public static void lincgsetprecdiag(lincgstate state,
    alglib.xparams _params)
{
    alglib.p.assert(!state.r
    u
        n
    n
        i
    n
        g, 

    "
    L
        i
    n
        C
    G
        S
    e
        t
    P
        r
    e
        c
    D
        i
    a
    g
        :

    y
        o
    u
        c
    a
        n

    n
        o
    t
        c
    h
        a
    n
        g
    e
        p
    r
        e
    c
        o
    n
        d
    i
        t
    i
        o
    n
    e
        r,
        b
    e
        c
    a
        u
    s
        e

    f
        unction LinCGIte
        ation
    s ru
    ning!");


    type = 0;
}


/*************************************************************************
This function sets stopping criteria.

INPUT PARAMETERS:
    EpsF    -   algorithm will be stopped if norm of residual is less than 
                EpsF*||b||.
    MaxIts  -   algorithm will be stopped if number of iterations is  more 
                than MaxIts.

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

NOTES:
If  both  EpsF  and  MaxIts  are  zero then small EpsF will be set to small 
value.

  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void lincgsetcond(lincgstate state,
    double epsf,
    int maxits,
    alglib.xparams _params)
{
    a
        ib
    ap.as sert(!stat
    e
        .
        r
        et
    not c
    h
        an
    e
        st p
        ing cri
        t
    eria w
    h
        e
    n
        L n( is
        r nning
        )


    algl
        i
    b
        .
        a
        sfini
    t
        e
    es f)
    &(dou
    b
        le)(e
    p
        s
    f
        )
    Lin
        C
    G
        S
    e
        t
    o
    nd
        :
    Eps
        F s
        ne a
        ti
    ve n lues )
    ;


    alg
        l
    ib.a
        , "L        in        G
    S
        etC ond:

    M
        a
    I
        s i
        s


    if (
        (
            o
    b
        l
    b
    s == 0
        )


    tate.e
    p
        f
            = d
    faultp
        r
    ecisi
        on


    stat e.m
        a
    x
        t
            =
            axits;


    lse
        ;


    sta
        t
    e.
}


/*************************************************************************
Reverse communication version of linear CG.

  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static bool lincgiteration(lincgstate state,
    alglib.xparams _params)
{
    bool re
        ult =
            ne
    boo
        l);

    int i = 0;

    o
        a
    0;


    doubl
    e
        borm = 0;

    doubl
        e
    n
        _ = 0;


    //
    R
        verse
    omm parations
        /
        I know i
    looks ugly, but

    i
        t

    w
        o
    r
        k
    s
        t
    h
        e

    s
        a
    m
        e

    w
        a
    y
        /
        /

    a
        n
    y
        w
    h
        e
    r
        e

    f
        r
    o
        m

    C
        +
        +
            t
    o
        P
    y
        t
    h
        o
    n
        .

        //
        /
    Thi
        code initializes loc
    a
        ls by:


    value
        s

    e
        te g code


    // 
    generation su br ou i
        a
    l
        es from
        pr
    e
        vious
    c
        a
    ll -
        on subseq ue n
        c al ls

    if (st te.st >
           i =
        st ];


    uv r = state.r0


    norm = s ta te.r s
    t
    ate.ra[1]

    v = state.r st
        a
    t
        .ra[2]; else

    {
        i
            = ;


        b
            n
        o
            - 909;
    }
    if (state.rstate.stage == 0)
    {
        goto lbl_0;
    }

    if (state.rstate.stage == 1)
    {
        goto lbl_1;
    }

    if (state.rstate.stage == 2)
    {
        goto lbl_2;
    }

    if (state.rstate.stage == 3)
    {
        goto lbl_3;
    }

    if (state.rstate.stage == 4)
    {
        goto lbl_4;
    }


    if (
        s
    tate.rstat
        .stag
        e =
        {
            oto lb
            l
            _5;
            i f(
            stt e
            ta t
            {
            g oto lbl_6
            ;
            i
            ( state.rstate
            st
            ge==7 )
            got
            l
            bl_7;


            }


            //
            bod y

            //
            al glib.ap
            .
            a
            s
            ert(a
            l
            g
            l
            ap.l n(
            s
            t
            te.b)>0, "L        i
            C
            Iteratio
            : B is n i
            iti iz ed (y
            o
            u m
            B
            b
            y
            L
            i
            nG Se t
            B(
            ) cal
            l
            "
            )
            ;
            rue;
            s
            t
            a
            earrfields(state, _params);
            updateitersdata(state, _params);

            //
            // Start 0-th iteration
            //
            for(i_ = 0; i_<=state.n-1;i_++)
            {
            state.rx[i_] = state.startx[i_];
            }
            for(i_ = 0; i_<=state.n-1;i_++)
            {
            state.x[i_] = state.rx[i_];
            }
            state.repnmv = state.repnmv + 1;
            clearrfields(state, _params);
            state.needvmv = true;
            state.rstate.stage = 0;
            goto lbl_rcomm;
            lbl_0:
            state.needvmv = false;
            bnorm = 0;
            state.r2 = 0;
            state.meritfunct
            i
            on = 0;
            <=stat
            e
            .n-1; i
            +)
            {
            stat r
            [
            i]
            = stat
            e
            .
            b[i]- s
            t
            ate.mv[
            i
            ;
            st e.r2 = s
            ate
            r2+s at
            .r[i]*s ate.r[ ]
            ;
            s ta.meritfunction = st
            te meritf nct
            ]* tat
            e.[i]-2*
            t
            t
            e
            .
            [;
            bnorm = bnorm+state.b[i]*state.b[i];
            }
            bnorm = Math.Sqrt(bnorm);

            //
            // Output first report
            //
            if( !state.xrep )
            {
            goto lbl_8;
            }
            for(i_ = 0; i_<=state.n-1;i_++)
            {
            state.x[i_] = state.rx[i_];
            }
            clearrfields(state, _params);
            state.xupdated = true;
            state.rstate.stage = 1;
            goto lbl_rcomm;
            lbl_1:
            state.xupdated = false;
            lb
            _8:

            //
            /
            / tion?

            //
            te(sta
            te r
            2
            ) || (
            d
            o
            uble)
            (M at h.Sq rt (s ta te.
            )< = ( do ub le )( st at e.ep sf *b no rm ) )
            st at e.ru nn i
            = fa ls e;
            i f(
            h.is fi ni te (s t
            .r 2) )
            {
            natio
            n
            type = 1
            else
            {
            state.repterminationtype = -4;
            }
            result = false;
            return result;
            }

            //
            // Calculate Z and P
            //
            for(i_ = 0; i_<=state.n-1;i_++)
            {
            state.x[i_] = state.r[i_];
            }
            state.repnmv = state.repnmv + 1;
            clearrfields(state, _params);
            state.needprec = true;
            state.rstate.stage = 2;
            goto lbl_rcomm;
            lbl_2:
            state.needprec = false;
            for(i = 0; i<=state.n-1; i++)
            {
            state.z[i] = state.pv[i];
            state.p[i] = state.z[i];
            }


            /

            // O
            t
            her iterat
            ons(1
            .. //
            epi
            eratio
            ns
            lbl_10:
            if( fa
            {
            go to l b1;
            }
            stat.re
            iter at ions
            ou nt = s ate.repiterati
            o
            n
            cou t+1;
            / /
            alcula te A pha

            //
            f (i_ = 0; i _< = s ta e.n-1;
            _++)
            {
            state.x
            i_
            =
            tate.p
            [i_ ]
            t p
            mv = st at e.repn
            m
            ;
            ds
            (
            te _ ar as;
            t
            te rstate.st age = 3;
            g
            o
            to l bl rc m
            e.ne
            n
            ble) (s t
            a = (double)(
            {
            //
            // a) Overflow when calculating VMV
            // b) non-positive VMV (non-SPD matrix)
            //
            state.running = false;
            if( math.isfinite(state.vmv) )
            {
            state.reptermination
            ype =
            5;


            }


            e

            {
            stat tion
            ype =
            4
            se;
            sult;
            stat
            .
            l
            h
            a
            f
            r
            i
            =
            state.alpha = state.alpha+st te.z[i];
            }
            state.alpha = st ate.vmv;
            if( !math.i e.a {
            // Overflow when calculating                   //
            state.running state.repterminationtype = -4;
            lt
            ret
            u
            rn re
            su
            l
            ;
            }


            /
            /
            ard
            o
            ution

            //        (i=0;
            i
            = stat
            e
            .n-1;
            i
            ++
            )
            state
            .
            cx
            [
            i
            ]
            = +s tate.
            /
            Ca
            lc
            /
            *
            us
            e o
            o
            up
            da ve
            r
            ItsB
            e
            foreRU
            p
            date-
            th
            te cu atch
            usin
            g r
            /
            /
            in
            c
            ase R
            g
            r
            ws de thm
            s ter
            mi os ti
            o
            code

            //
            ! rupd
            te==0
            | te %s
            t
            te.it
            s
            before
            r
            updat
            e!
            =
            ) go
            o lbl
            _1
            /
            /
            at ent
            ormul
            a
            //         f
            o
            (i = 0;
            i<=sta
            t
            e.n-1
            ;
            i
            +) { sta
            e.cr[
            i] ]- st
            a
            e.mv[
            i
            ];
            =
            }

            ot

            lbl
            _
            12:
            /
            alcu
            ate R
            u v
            for(i_ = 0; -1;
            {
            st
            a
            te.
            x
            [i_]
            =
            s
            t
            a
            t
            .cx[i_];
            }
            state.repnmv = state.repnmv + 1;
            cle
            a
            rr, _pa
            r
            ams);
            mv =
            t
            rue;
            state.stage
            =
            4;
            g m;
            lbl_
            4
            :
            s
            t
            i<=state.n-1; i++)
            ate
            .
            cr
            [
            i
            ]
            =
            st
            ate.b
            [
            i
            ]
            -
            s
            ta
            te
            .m i] =
            s
            ta
            t
            e.
            c
            [
            ];


            }


            /
            / Cal
            c
            u
            l
            a
            t
            in
            g
            me
            eck e
            m
            e
            r
            ge
            n
            y
            stopp
            i
            ng
            cr
            i
            te
            v = 0;
            fo
            r
            (
            i = n-1; i++)
            {
            = v+s
            t
            ate.mv[
            ]
            stat
            e.e.b[i
            ]
            *state
            .
            cx[i]
            if(
            (double)(v)<(do
            ub ritfu
            n
            ction)
            g


            }
            for(i
            =
            0; i<=state.n
            1
            i+
            {
            i
            (
            !
            ma st
            {
            st lse;
            s
            t
            a
            t
            e
            .
            repte
            r
            m
            i
            n
            a
            ti
            re
            u
            t = f
            a
            lse;
            r
            eturn
            re
            s
            u
            l
            t
            ;


            }


            //


            /
            /
            o
            ut or //
            i
            f( !s
            t
            a
            oto lbl_16;
            <=
            s
            a
            te.n-
            1
            ;i_+
            )
            {
            stat
            .x[i_
            ] _] }


            cle
            a
            r
            r
            f
            i
            el
            ds
            (s s) ate.x
            u
            p
            d
            at
            e
            true
            ;
            st 5;
            got
            o
            lbl_rco
            m
            m; _5:
            tate
            .x lse;
            lbl_1
            :
            te.r
            nning = f
            alse;
            rmina
            t
            iontype
            ;
            result
            n r lbl_14:
            tfu
            l
            b
            l_13:
            or
            i
            _ = 0; i
            _
            <
            = sta
            t
            e.n-
            1
            ;i_++
            )
            {
            s
            at ta

            }


            // calc
            u
            latin
            g
            R
            N
            rm onoto
            n
            ic decrease of R2
            s
            n
            ot lg / at for
            (
            i = 0; i<=state.n-1;
            i
            +
            )
            .r2 =
            t
            te.r2
            +s.cr[i]
            t report
            rep
            )
            {
            bl }


            for(
            i
            _
            =
            0;
            i_ i_ {
            state
            .
            x
            [i x[i_];
            lds(s
            t
            ate, _pa
            a
            s);
            ate.x
            u
            pdated
            = tru
            ;
            te.r
            tate.stag
            e = 6;
            comm;
            b
            _6:
            te.
            x
            u
            p
            d
            a
            e
            d
            = fal
            s
            e
            ;
            /
            /

            //
            s
            t
            o
            pp
            /
            chiev
            e
            d
            t
            h
            e c
            h.isfinite(state.r2) || (d Sqr <=(do
            u
            ble)(state.epsf*bn
            r
            )
            )
            {
            tate.
            un;
            if(
            ath.is
            fi 2)
            {
            sta
            t
            e.repterminationty
            p
            e
            se
            .re
            p
            te
            r
            m
            i
            at
            io
            ntype
            =
            -
            4
            ;


            }
            resul
            t
            =
            f
            a
            s
            ;
            re

            }


            i
            f( sta
            t
            e
            .r count>=state
            .
            maxit
            s
            && stat
            e
            .m
            {
            0; i<
            =
            state.
            n
            -1; i
            +
            {
            if( !
            ma state
            .
            rx[i])
            {
            st
            a
            e.
            u
            nning
            =
            false
            ;
            e
            = false;
            re }
            }


            /
            if X
            is

            //
            = s
            t
            ate.reptermination
            y
            e
            =
            rn }


            for(i_ = 0;
            i
            <
            =
            st
            stat
            e.[i_];
            /
            /
            of
            p
            a
            r
            a
            m
            t
            er
            s for
            n
            e
            x
            t
            i
            te
            ra sta
            t
            e.rep
            m
            = st
            a
            te.re
            p
            nmv+1
            ;
            c
            l
            ea te
            s
            ate.n
            e
            edpre
            c
            = tr
            u
            e;
            at
            e
            r
            stat
            e
            .stage =
            7;
            m
            e.n
            for(i_ = 0; i_<=state.n- st
            a
            te.cz[i
            ]
            = sta
            te
            }

            if( s
            a
            e
            .
            re %state
            i
            sbefo
            re
            {
            s
            for(i = 0; i<=s +)
            {
            st ta [i]*s
            t
            at
            e
            .
            c
            [
            ];
            u
            var =
            u
            v
            a
            r
            +s a

            //check that UVar is't INF or                       //
            if( !math.isfinite(uvar) || (double)(uvar)==(double)(0) )
            state.running = false;
            state.repterminationtype = -4;
            res
            return
            re
            s
            lt


            }


            //                  BETA


            st r;

            //
            t.
            B
            E
            T
            A
            e
            it
            her I
            N
            F
            n
            o
            Na
            N
            i
            f(
            !
            m
            t
            .isfi
            n
            i
            t
            e
            (
            s
            tate.
            b
            eta)
            )
            t
            te.ru
            n
            ni
            n
            g
            = sta
            e.rept
            erminationtype =
            sul return result;
            i<=
            s
            ta
            t
            e
            .
            -1
            ;
            i++)
            te.p[
            i
            ]
            =
            s
            a
            e.cz[
            i
            ]+
            s
            ta
            t
            e.[i

            }


            }


            {
                f
                or tate.
                n
                -1;i_+
                )
                t
                at ate.
                z[i_];
            }


            /
            p
            re
            pere
            d
            a
            t
            a
            o
            r
            ne
            f
            r
            i = 0;
            i
            <
            =
            s
            t
            a
            te.n-
            1
            ;
            i
            +
            +
            )
            it k )th iteration
            state.r[i] = state.cr[i];
            st t
            t
            .
            cz


            }


            g
            o
            t
            lb
            l_ lb
            r
            s
            u
            lt =
            f
            al
            s
            e
            ;
            r
            e
            turn
            r
            e
            s
            u
            l
            t
            ;
            /
            Savin
            g
            s
            t
            a
            t
            e

            //
            lb
            l
            rc;
            e.
            s
            tate.
            r
            s
            t
            a
            t
            .
            ra
            [0 ta
            t
            .
            ra[1
            ]
            = bnorm
            ;
            st = rn re
            s
            ult;
        }


    /*************************************************************************
    Procedure for solution of A*x=b with sparse A.

    INPUT PARAMETERS:
        State   -   algorithm state
        A       -   sparse matrix in the CRS format (you MUST contvert  it  to 
                    CRS format by calling SparseConvertToCRS() function).
        IsUpper -   whether upper or lower triangle of A is used:
                    * IsUpper=True  => only upper triangle is used and lower
                                       triangle is not referenced at all 
                    * IsUpper=False => only lower triangle is used and upper
                                       triangle is not referenced at all
        B       -   right part, array[N]

    RESULT:
        This function returns no result.
        You can get solution by calling LinCGResults()
        
    NOTE: this function uses lightweight preconditioning -  multiplication  by
          inverse of diag(A). If you want, you can turn preconditioning off by
          calling LinCGSetPrecUnit(). However, preconditioning cost is low and
          preconditioner  is  very  important  for  solution  of  badly scaled
          problems.

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsolvesparse(lincgstate state,
        sparse.sparsematrix a,
        bool isupper,
        double[] b,
        alglib.xparams _params)
    {
        in n = 0;
        int double v = 0


        d
            le vm v
        0;


        int i_
            = ;


        sert(a l
        g
            l
        i
                .ap
                .len(
                    b
                )
            >
            =
            st te n, L ng
            a
        g
            .a.a
            s

        ser t
        (apse
            r

        v.
            i
            s
        f
            i
        nitev
            e
        ct
            o
        r
        (
            a

        nfinite or NaN v


        //


        p
            a
        ps e
        tat
        e.tm pd,
            n,
            ar
        am
            s);


        te dia go na l
            s
        c
            l
        ng ma
        t
            ri
        x
            D


        te.prectype = 
            =
        0 )


        ault
            p
        re ondi
        t
            ioner

        n
            v
        dia
            onal


        (i = 0;
        i <= n - 1;
        i++


        on a


        if ((do
            )

        {
            tm
            p
                [
                    i] =
                1 / Math.S
            q
            rt(v)
                ;
        }


        e lse


        {
            ] =
            1;
        }
    }

    //
    =

    n - 1;

    i++ )
    {
        =
    }


    /


    incg re st a
    rt(state, _params)
        ;

    li nc se
        b(sta te,
            b, _p
                a

    r
        m

    n(s
    t
        a
    t
        e,
        _
    pa ra ms) )


    // Proce
    s
        s diff er en
        t

    r
        e

    sta te n
        ee mv )


    esmv(
        a
        , s _para
    s
        ;

    i
        (stat
    e.er
        .m ,
    pr am
        );


    _ = 0;
    i
    _ <= stat
        .
    -1;
    i_
        ++ {
        m
            v tate.m
        [
            _];
    }


    e
        i
    f(r
    {
        fo
        r
        (
            +
                state.pv[i] = st at e.x[] * mat h
        sqr
            at e.tm pd i] );
    }
}


}


/*************************************************************************
CG-solver: results.

This function must be called after LinCGSolve

INPUT PARAMETERS:
    State   -   algorithm state

OUTPUT PARAMETERS:
    X       -   array[N], solution
    Rep     -   optimization report:
                * Rep.TerminationType completetion code:
                    * -5    input matrix is either not positive definite,
                            too large or too small                            
                    * -4    overflow/underflow during solution
                            (ill conditioned problem)
                    *  1    ||residual||<=EpsF*||b||
                    *  5    MaxIts steps was taken
                    *  7    rounding errors prevent further progress,
                            best point found is returned
                * Rep.IterationsCount contains iterations count
                * NMV countains number of matrix-vector calculations

  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void lincgresults(lincgstate state,
    ref double[] x,
    lincgreport rep,
    alglib.xparams _params)
{
    = new d oub le[
        t(!s ate.run ning, "LinCGResu
    get result, be Iteration has b
        lgl
    i
    b
        .
        a
        p
    l
    en(x) < st at e.n
        ne
}

f
    or
    (i _ = 0

;
i_ <= s ta t
e
        .n - 1
    ;
i_++)


e
    s ta
    t
e.
    r
    e
p
    te
ra
    tions
co un t
    ;


t
    rm ina
    t
i
    o
nt
y
    e
        = sta
te r
e
    pt
e
    r
        = state.r2;
}


/*************************************************************************
This function sets restart frequency. By default, algorithm  is  restarted
after N subsequent iterations.

  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void lincgsetrestartfreq(lincgstate state,
    int srf,
    alglib.xparams _params)
{
    al gl ib.a p

    tR
        ca not c h
        e re st ar t

    nCGIteration() i runn
        in a
        g
    ib.a
        p
    "LinC
    G
        SetRes
    t
        ar
    t
        F
    r
        q

    n
        s ta te.i sb efo r
    e
        r
    s
        art
            = 
}


/*************************************************************************
This function sets frequency of residual recalculations.

Algorithm updates residual r_k using iterative formula,  but  recalculates
it from scratch after each 10 iterations. It is done to avoid accumulation
of numerical errors and to stop algorithm when r_k starts to grow.

Such low update frequence (1/10) gives very  little  overhead,  but  makes
algorithm a bit more robust against numerical errors. However, you may
change it 

INPUT PARAMETERS:
    Freq    -   desired update frequency, Freq>=0.
                Zero value means that no updates will be done.

  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void lincgsetrupdatefreq(lincgstate state,
    int freq,
    alglib.xparams _params)
{
    e.ru
    n
        ing, 
    "LinCGSe
    RUpd
    teFreq:
    you
        can not change
    p
        te frequency w
    n L ) is ru
        ni
    g");


    alg
        l
    b.a
        .as
    ert(
        req >= 0, "LinCGS
    tRU
        dat itive F
    eq");


    s
    ate.its
    b
        forerupdate = f
    eq;
}


/*************************************************************************
This function turns on/off reporting.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state
    NeedXRep-   whether iteration reports are needed or not

If NeedXRep is True, algorithm will call rep() callback function if  it is
provided to MinCGOptimize().

  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void lincgsetxrep(lincgstate state,
    bool needxrep,
    alglib.xparams _params)
{
    sta
        re;
}


/*************************************************************************
Procedure for restart function LinCGIteration

  -- ALGLIB --
     Copyright 14.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void lincgrestart(lincgstate state,
    alglib.xparams _params)

rstae.i a = new in t[0 + 1
tate rsta


s a
te
    .
    r
    s
t
    t
e.
    s
    ams);
}


/*************************************************************************
Clears request fileds (to be sure that we don't forgot to clear something)
*************************************************************************/
private static void clearrfields(lincgstate state,
        alglib.xparams _params)
    =

f
    a
l
s
    e
    ;


s
    ta s
    f
l
    se a


}


/*************************************************************************
Clears request fileds (to be sure that we don't forgot to clear something)
*************************************************************************/
private static void updateitersdata(lincgstate state,
    alglib.xparams _params)

re i
erati o
n
    scount
0 a
    tep e
    rm
i
ionty e
    = 0;
}
}

public class linlsqr
{
    /*************************************************************************
    This object stores state of the LinLSQR method.

    You should use ALGLIB functions to work with this object.
    *************************************************************************/
    public class linlsqrstate : apobject
    {
        public normestimator.normestimatorstate nes;
        public double[] rx;
        public double[] b;
        public int n;
        public int m;
        public int prectype;
        public double[] ui;
        public double[] uip1;
        public double[] vi;
        public double[] vip1;
        public double[] omegai;
        public double[] omegaip1;
        public double alphai;
        public double alphaip1;
        public double betai;
        public double betaip1;
        public double phibari;
        public double phibarip1;
        public double phii;
        public double rhobari;
        public double rhobarip1;
        public double rhoi;
        public double ci;
        public double si;
        public double theta;
        public double lambdai;
        public double[] d;
        public double anorm;
        public double bnorm2;
        public double dnorm;
        public double r2;
        public double[] x;
        public double[] mv;
        public double[] mtv;
        public double epsa;
        public double epsb;
        public double epsc;
        public int maxits;
        public bool xrep;
        public bool xupdated;
        public bool needmv;
        public bool needmtv;
        public bool needmv2;
        public bool needvmv;
        public bool needprec;
        public int repiterationscount;
        public int repnmv;
        public int repterminationtype;
        public bool running;
        public bool userterminationneeded;
        public double[] tmpd;
        public double[] tmpx;
        public rcommstate rstate;

        public linlsqrstate()
        {
            init();
        }

        public override void init()
        {
            ni atorst at e();


            r
                x = new d ob b
                =
                n
            w
                doubl
            e
            [0
            ]; /*************************************************************************
            This function sets restart frequency. By default, algorithm  is  restarted
            after N subsequent iterations.
    
              -- ALGLIB --
                 Copyright 14.11.2011 by Bochkanov Sergey
            *************************************************************************/
            tm
                d = ne
            dou
            le[0];


            tmpx =
                ew do
                uble[0];


            rstate = new rco
            m
            mstate(
                ;
        }

        public override alglib.apobject make_copy()
        {
            li
                n
            l
                qr
            tate _re
                sult = new linlsqr ta e(
                )
                ;
            _resul t.nes = (no m
                m
            te)ne
            s
                .make_cop y();
                . /*************************************************************************
            This function sets frequency of residual recalculations.
    
            Algorithm updates residual r_k using iterative formula,  but  recalculates
            it from scratch after each 10 iterations. It is done to avoid accumulation
            of numerical errors and to stop algorithm when r_k starts to grow.
    
            Such low update frequence (1/10) gives very  little  overhead,  but  makes
            algorithm a bit more robust against numerical errors. However, you may
            change it 
    
            INPUT PARAMETERS:
                Freq    -   desired update frequency, Freq>=0.
                            Zero value means that no updates will be done.
    
              -- ALGLIB --
                 Copyright 14.11.2011 by Bochkanov Sergey
            *************************************************************************/
            h
                _
            esult.rhoi = rhoi;


            _
            result.ci = ci;


            _result.si
                = si;


            s
                _
            re ult.lambd i = l mbdai;


            _res
                .d(
                    ouble[])d
                Cl e
                );


            res lt.n
                orm
            r
                e
            su t
                .bn rm2
                    = bno
            rm
            2
                ;
            _resul
                t
            dno
            r
                m = dnor
                ;


            t. 2 =
                r2;


            re ul
            t
            [x /*************************************************************************
            This function turns on/off reporting.
    
            INPUT PARAMETERS:
                State   -   structure which stores algorithm state
                NeedXRep-   whether iteration reports are needed or not
    
            If NeedXRep is True, algorithm will call rep() callback function if  it is
            provided to MinCGOptimize().
    
              -- ALGLIB --
                 Copyright 14.11.2011 by Bochkanov Sergey
            *************************************************************************/ _res
            lt.rep
            tera
                ionscount =
                    r
            epiteratio
            scoun
                t;

            _result.repnmv = repnmv;


            _re
                su r
                mini nty
            p
                /*************************************************************************
  Procedure for restart function LinCGIteration

    -- ALGLIB --
       Copyright 14.11.2011 by Bochkanov Sergey
  *************************************************************************/
                n;
        }
    };


    public class linlsqrreport : apobject
    {
        public int iterationscount;
        public int nmv;
        public int terminationtype;

        public linlsqrreport()

        {
            init();
        }

        public override void init()
    }

    public override alglib.apobject make_copy()


    l
        i

    n
        l

    s
        q

    r
        r

    e
        p

    o
        r

    t
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

    l
        i

    n
        l

    s
        q

    r
        r

    e
        p

    o
        r

    t
    (
    );


    t.itera
        ionsco

    nt =

    iterationsco
        u

    nt;


    _result.nmv = nm
        v;


    r
        eturn

    r
        su lt;
}

};


public const double atol = 1.0E-6;
public const double btol = 1.0E-6;


/*************************************************************************
This function initializes linear LSQR Solver. This solver is used to solve
non-symmetric (and, possibly, non-square) problems. Least squares solution
is returned for non-compatible systems.

USAGE:
1. User initializes algorithm state with LinLSQRCreate() call
2. User tunes solver parameters with  LinLSQRSetCond() and other functions
3. User  calls  LinLSQRSolveSparse()  function which takes algorithm state 
   and SparseMatrix object.
4. User calls LinLSQRResults() to get solution
5. Optionally, user may call LinLSQRSolveSparse() again to  solve  another  
   problem  with different matrix and/or right part without reinitializing 
   LinLSQRState structure.
  
INPUT PARAMETERS:
    M       -   number of rows in A
    N       -   number of variables, N>0

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state
    
NOTE: see also linlsqrcreatebuf()  for  version  which  reuses  previously
      allocated place as much as possible.

  -- ALGLIB --
     Copyright 30.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrcreate(int m,
    int n,
    linlsqrstate state,
    alglib.xparams _params)
{
    al rt(m>
    0
    "LinL
    QRCreat
    e:
    algl
    b.ap.asse
        rt QRCrea
    e:
    N <=
        ");

    nlsqrc
    eatebu
    (m
        , arams)
}


/*************************************************************************
This function initializes linear LSQR Solver.  It  provides  exactly  same
functionality as linlsqrcreate(), but reuses  previously  allocated  space
as much as possible.
  
INPUT PARAMETERS:
    M       -   number of rows in A
    N       -   number of variables, N>0

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 14.11.2018 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrcreatebuf(int m,
    int n,
    linlsqrstate state,
    alglib.xparams _params)


int i =
    0 alg
ib.a
    .assert(m > 0, "LinLSQR
Cr 0");


alg
    li n > 0, "
inLSQR
    C
r
    ateB
uf
state.m
    = m;

te.n =
    n;


p
te.e
    p
s
a epsb =
    btol;


s
    ta M
state.maxi
    t
s
    at e
    l
mbd
    i = 0;


e = al e;

st ls
    ;


s
    ta coun

0;


//

*
        al
    / *se
t
    R
X the c
    s
us
    r call
    s

R
    es

//
call
    i
n
    g
S

    // * 
    s
e
    t
B

    //
    or
e
    tim
torcre
    a

t
    e
    (m.ne
        ,
        _pa
            ams);
    =

n w
d
    ubl stat.n
    ]
;


= n
    w
ub
e[s tate
        .m
    +
    s
stat
        .ip1
    = ne w double
    [s a

tate.v
    p1 = new
        double
        [
            state.n]


ne ];
s
ate.omeg
    i
        = n
w double[sta
te.n ];
te.omeg
a
    ip1
        =
        n
ew du b.state.d
    = 
    ];


state
        .x
    =
    n
ew do
    u
        b
le ];


stat
e
    .
    m
    v
        = new
            d
ou e.n];


ew doub
l
    e
s
    a
te state.b
    = new d
u
le[state
    .m or(i = 0;

i <
    n
1
    ;
i++)


{
    state.r
    x
        [i]

    o
    uble.N
    a
        N
        ;
}
(i = 0;
i
    <
    = m
1

i++)


{
    ate.b[i
        ]
        = 0
}


= new
i
nt[1 + 1
    ;


stat
e
    .rsta
    t
e
    .r + 1];


s
    a
te.rst
    a
t
e
        .stage =
    -1;


}


/*************************************************************************
This function sets right part. By default, right part is zero.

INPUT PARAMETERS:
    B       -   right part, array[N].

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 30.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrsetb(linlsqrstate state,
    double[] b,
    alglib.xparams _params)
{
    i
        algli
    b
        .ap.astate.running , "LinL        S
    QRSetB:
    y
        u ca n n ot c SQRIter at on i s r
        n
    ing")        

    a
        l
    gl
    b
        .a
    s
        .ap.le n,  "
    L
        i
    n
        L
    SQRSe
        t
    B
        :


    a
        g
    lib.ap
        .
        a
        s
    se
        r
    t(aps
    e
        r
    v. , state
        .m,
    p
        r
    ams),
    "
    L
        i
    nLS
        Q
    RSetB
        :

    B e or Na
    N
        val
    e
    ");

    bnorm2
        =
        0;


    tate.m -
        1
        ;
    i +
        )


    state.
    [
    ] = b[
        i] state
        .bnor
    2
        = st
    at i];
}


/*************************************************************************
This  function  changes  preconditioning  settings of LinLSQQSolveSparse()
function. By default, SolveSparse() uses diagonal preconditioner,  but  if
you want to use solver without preconditioning, you can call this function
which forces solver to use unit matrix for preconditioning.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 19.11.2012 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrsetprecunit(linlsqrstate state,
    alglib.xparams _params)
{
    alglib.ap.ass unning
    "L
    nLSQRSetPrecUni
    t:
    chang
        pr
    con
        di use fu
    cti
        n LinLSQRIterat
        io !");

    sta
    t
        e
        ;
}


/*************************************************************************
This  function  changes  preconditioning  settings  of  LinCGSolveSparse()
function.  LinCGSolveSparse() will use diagonal of the  system  matrix  as
preconditioner. This preconditioning mode is active by default.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state

  -- ALGLIB --
     Copyright 19.11.2012 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrsetprecdiag(linlsqrstate state,
    alglib.xparams _params)
{
    algl
    b.ap.ass
    rt(!state.r
    nning,
    "Lin
    SQRSet
        P
    ecDi
    g:
    you
        ca
    not
        ch
    nge preconditione
        r, because
    f
        unc
    t
        on LinCG
        I
    era
        t
    ion is
        unning!"
        )


    tate.prectype = 0;
}


/*************************************************************************
This function sets optional Tikhonov regularization coefficient.
It is zero by default.

INPUT PARAMETERS:
    LambdaI -   regularization factor, LambdaI>=0

OUTPUT PARAMETERS:
    State   -   structure which stores algorithm state
    
  -- ALGLIB --
     Copyright 30.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrsetlambdai(linlsqrstate state,
    double lambdai,
    alglib.xparams _params)


a
glib.ap.a
    s
e
    r
t!state.running,
"LinLSQRSe
tL can n
s
    LambdaI,
    ecaus
funct
    on LinLSQ
    Itera


lgli
    .ap.assert(math.i
s
    nit
lambdai
    && (d
ble)(l
bdai)>=(dou SQRSetLam
daI:
am
    daI
s
    nfinite
o

tat ambdai;


}


/*************************************************************************

  -- ALGLIB --
     Copyright 30.11.2011 by Bochkanov Sergey
*************************************************************************/
public static bool linlsqriteration(linlsqrstate state,
    alglib.xparams _params)
{
    o
        ol esut );
    in
    su m
    n

    0;


    0;
    int i = 0;
    int i_ = 0;


    //
    // Reverse communication preparations
    // I know it looks ugly, but it works the same way
    // anywhere from C++ to Python.
    //
    // This code initializes locals by:
    // * random values determined during code
    //   generation - on first subroutine call
    // * values from previous call - on subsequent calls
    //
    if (state.rstate.stage >= 0)
    {
        summn = state.rstate.ia[0];
        i = state.rstate.ia[1];
        bnorm = state.rstate.ra[0];


        else


        i
            =
            bnor
                = -919
            ;

        f
            s a
        t. ==0


        {
            goto l
            b
                _
            0;


            i
                f
                (
                    s
                        tate.

            r
                s
            t
                a
            t
                e
            st ge == 1 )


            lbl_
            1
                ;


            f(s
            t
            e == 2
                )


            g
                ot
        }


        ta te.s
        t
            age =
                3
            )


        got
            o
        lbl_ 3;


        e.sta
            g
        e ==
            got

        bl_4;


        if (state.rstate.
            =
        5


        if
        a
            e
                = 6 )


        go lb _
            ;
    }


    //         R        utine body


    a lg i
        .a
        .ass
        en
    SQRIteration:

    usin n n - al ocated ar ra y B
    "
        )


    s
    u
        mmn = tate m + s
    t
        a
    bnor
        m
            =
            M
    th.S rt stat
    e
        .bnor
        m
    2) ;

    s
    at.u ert r
        m
    inatio nn ee de d
        t
    te.unning =
        tr
    repnm
        v
            = 0;

    st at e.rep
        i
    t
        e


    s
    ate.r2
        = sta
    t
    e
        .
        bn
        c
    learr ie d
        (s a
    e, _pa
        r
    ams) ;


    //
    //
    stimat
        e
    for
        A
            N
    o
        r


    t
        i

    rresta rt(
        t.ne s,
        _pa ra ms);


    lbl_7
        :


    mesti ma to r.n
        e
    tim
        ri terat
        i
    on(st
    a
        t
    e
        .nes,

    _
        p
    a
    {
        g ot o bl 8;


        i(
            !st
        te ne.n
            e
        edmv )


        ot l b
            _
        9;


        state
            .n - 1;
        i
        _
            +


        {
            x[nes
                .x
                [
                    i
            _
                ;
        }


        n;


        l
            r
        state
                .needmv
            =
            r
        e;


        s
        0;

        g o
        to
            l
        l_r
            omm;


        s ta
        t
        e.ne ed mv =
            false
                = i_ <= state.m - 1;
        i_++)
        {
            state.nes.mv[i_] = state.mv[i_];
        }
        goto lbl_7;
        lbl_9:
        if (!state.nes.needmtv)
        {
            goto lbl_11;
        }

        for (i_ = 0; i_ <= state.m - 1; i_++)
        {
            state.x[i_] = state.nes.x[i_];
        }

        //
        //matrix-vector multiplication
        //
        state.repnmv = state.repnmv + 1;
        clear
        fields
            stat, _params);


        tate.ne;


        te.sta
        g
            e = 1;


        goto lb
        l:

        s
        tate.n
            e
        e
            dmtv
                =
                false;


        fo
            r
        i_ 0
        i_
            = st
        te.n - 1
        i
            ++)

        {
            sta.mt v[i_] = s t
                at et[
                    i_
                ]
                ;
        }
        g
            to lbl
            _
        7
            ;


        g
            oto l bl _7;


        l bl _8 :


        no
            r
        m
            e
        timato r.n
            o
        st ma tor
            r
        eu lt s(st ate.ne s, ref
            t
                .anorm, 
            params);


        //inita        li        e


        /
        /


        o
        r( = 
            ;


        s t
        a
            te
    }


    /
    /


    t //
    if (!state.xrep)
    {
        goto lbl_13;
    }

    for (i_ = 0; i_ <= state.n - 1; i_++)
    {
        state.x[i_] = state.rx[i_];
    }

    clearrfields(state, _params);
    state.xupdated = true;
    state.rstate.stage = 2;
    goto lbl_rcomm;
    lbl_2:
    state.xupdated = false;
    lbl_13:

        //
        // LSQR, Step 0.
        //
        // Algorithm outline corresponds to one which was described at p.50 of
        // "LSQR - an algorithm for sparse linear equations and sparse least 
        /
    squ
        res" by C.Paige an
    d
    M.Saunders
        ith o
        ne ion -
        w
    e
        /
        / explicitl
        matri
    x
        b
    y
        addit
    i
        o
    nal N

    lines in rde
        //         
        t
    ha
        dle
    non
        zero l bda i.e.origin
        a
    A is r
        pla ed b

        //            
        [A

            //         A_        md         = [        ]
            //         [ lambda*I ].
            //
            // Step 0:
            //     x[0]          = 0
            //     beta[1]*u[1]  = b
            //     alpha[1]*v[1] = A_mod'*u[1]
            //     w[1]          = v[1]
            //     phiBar[1]     = beta[1]
            //     rhoBar[1]     = alpha[1]
            //     d[0]          = 0
            //
            // NOTE:
            // There are three criteria for stopping:
            // (S0) maximum number of iterations
            // (S1) ||Rk||<=EpsB*||B||;
            // (S2) ||A^T*Rk||/(||A||*||Rk||)
            = EpsA.

                // It is ve
                r
    y important
    hat S
    2 ed AFT
    E
        R S1.I
        is nec
        essary

    id di i
        s
    io
        n
    by er
    o
        when
    R
        k = .

    //
    t
        a
    e.be ai bnor;

    if ((dou bl e
        (state.b ta i)==

    (d ub
        e)(0) )

    {
        //


        // Zero ght part
        //
        state.running = false;
        state.repterminationtype = 1;
        result = false;
        return result;
    }
    for (i = 0; i <= summn - 1; i++)
    {
        if (i < state.m)
        {
            state.ui[i] = state.b[i] / state.betai;
        }
        else
        {
            state.ui[i] = 0;
        }

        state.x[i] = state.ui[i];
    }

    state.repnmv = state.epnmv +
        ;

    clearrfi
        e
    lds(state, _
    arams
        );
    state
        needmtv
            =
            state.r
    tate.st
        a
    l l_rc
    o
        mm
        ;

    l
        b
    l
    _3:


    state.needm tv = fal
    s
        ;


    f i = 0;
    i <
        =
        te.n - 1 i++)
        ] = s a
    te
            .mtv[i]
        +
        stat
    e.la mb i* st e.ui[sta.m
    i
        ];
}


s
    t
a
e.alphai = 0;


or(
    ;
    =state.-1;
i++
    )


s
ate.alp
    h
ahai + state.mtv[i] * state.mtv[i];
}
state.alphai = Math.Sqrt(state.alphai);
if( (double)(state.alphai)==(double)(0) )
{
    //
    // Orthogonality stopping criterion is met


    //


    state.
        unnin
        g

    s
    ate.rep
        terminationt


    esu
        t =
            f
    a
        ls
    re
        u
    n
        r
}


i <=
    t
t
        .n -
    = s state.alphai;
state.om ate.vi[i];
}
state.phibari i;
state.rhobari = s
r(i = 0; i<=state.n-1; i++)
state.d[i] = 0;
}
e.dnorm = 0;

//
Steps I = 1, 2, ...
//
lbl_15:
fa

{
    g
        to


    //


    s
        e
    Stat
    e
        .RepIt
        e
    ra
        t
    i
        o
    ns
        /
        s
    ta
        t
    e
        .
        re ou epite + 1


    //        B
    d
        a
    go
    na
        /
        / ]*mo
    d
    v[i] -
        a
    lpha[i
        ]
        * u[i]
        ] =
    _mod'
    *u[i
       /
        /
        et a[i +
    ] = 0 w
        il cc na
    t
        on


    // 


    of rati
    n.In
        t a
        /
        / NOTE
    2
        : alg
        or
    i
        hm on eta
    there
        w

    div
        i
    sion b
    y
        zero
    b
        e
    au e ivis
        on

    H
    o
        ever,
        near-z
    e
        ro al
        ph
    a
        an s

        //         a        iv
        i
    ion b
    y
        zero
    w
        ill h
        ap
    p
        n,
        ty
            in
    U b
        = 0;
    i_ <= state.n -
        state
            .x[i_]
        =
        s
    t
    ate
        .vi[i_
        ]
        ;
}
state.repnmv = state.repn
m
v + cl
a
    rfiel

d
    s
    (
        state
        ,
        _p
            stat

e
    .nee
d
    mv =
        t
rue;


e.rst
    a
te.stage = 4;


got
    o

lbl_4:


edmv
    =
    false


i = 0;
i
    <= state.n - 1;
i++)


stat
e
    .mv[st
at te.lambdai* s
t
ate.v
    i
i];


.be for (i = 0; i++) {
    state.uip1[i] =
        state
            .mv[
                i
                - state.a
    lphai * state.ui[
        i]


    state.betaip
    1
        = state.betaip1 + state
            .uip1[
                i
            ] * s
    t
    te.uip1
    [
    ];
}

(do
    ble)(
    st !=)


{
    e.qrt(
        tate.be r(i
            =
            0;

    i
        <
        su
    mm
    n - 1;
    i
        +
        +
        )


    sta
        t
    e
        .ui
    p
    [
    ] = s
    t
    ate
        .
        u
        i
    p1
    [
        i] p1
}


}
i_<=state.m
-
1;i_+
+
sta
e
x[i_
]
[i_];


e.re
    nmv = sta
te.repnmv + 1;

rrfie
    l
ds(sta
e
    _par
am
    st
a
    t
e
    ne
ed
    mtv =
        t
r
u
    e
    ;


e.;


g
    o
o
    lbl_r
c
om
    m
    ;


ate.
    eedmt
    v = false;

0;
    <
    =stat
e
        .n -
    1
    ;
i++)

te.m
v[i] =
    s st sta
t
e.
    u
    i
p
    [s
ta
te.m +
    i
    ]
;


ip1 =
    0
    ;


fo
    r
(
        i
            = 0
    ;
i

vip1[i] = state.mtv[i] - state.be vi[
    stat
        .lphai
p
1 = st
a
    t
e.te.vip1[i] * s
t
ate.v
    i
1[i];


if (
    (
        oubl
e) ip1)!
    =
(doubl
e
    )(0)


state.alphaip1
    = ate.a
l
    phaip1)


i = 0
    ;
i
    <
    =
    s
at
e.n - 1;
i
    +
    +
    )


sta
    t
e.v
    i
p1[
        i
    ]
    =
    s
ate.v
    i
p1[
        i
    ] /
    s
ta
}
}
/

// Bui
ld onal transfor
m
ation
//
st
te.rh
o
i = a
p
erv.saf
e
p
e.b ams);
state.ci bar;
sta
t
e
.
s
i
=
s
ta ta
s
ta
t
e
.
h
t
a t
sta = -(state.ci*state.al ph
i
= sta
t
e.ci
st
.phi
arip1
= te
/
/
pd
/
/
/
/
T
hi rm essary beca
u
se s
i
ply wr
i
ti //
State.R2
=
tate
.P te.Ph
i
BarIP1
does
O
gu
// mo
notonic decreas
e off e
r
ror comb
n
d wit
h 80-bit
rna chips allows R2 slightly in some rare, but possible cases.This property is
ble, so we prefer to guard against R increase.
//
= Math.Min(state.r2, state.phibarip1*state.phibarip1);
//
// Update d and DNorm, check condition-related sto        ia
//
for(i = 0; i<=state.n-1; i++)
state.d[i
rhoi*(state.vi[i]-state.d[i]);

st sta te.d[i] * sta }
if ath.Sqrt(state.dnorm)*sta double)(state.epsc) )
{
    state.running = false;
    state.repterminationtype = result = false;
    n result;
}
x, output report
//
i <= state.n - 1;
i++)
{
    state.rx[i] = state.rx[i] + st te.rhoi * state.omegai[i];
}
(!state.xrep)
{
    goto lbl_17;
}
for (i_ = 0; i_ <= state.n - 1; i_++)

    [i_]
    =
stat
    .x[i_]
    ;
}
clea
r
rfiel
d
s(
s
tate,
_
p
a
r
ms
ge = 6;
stat
.
updat
ed lbl
_
17:

//
C
eck s
to
//
1 eq of
i
t
e
r
t
io
ns;
||
/
/
.|*
/
/
i
f
(
stat
e
.maxi
ts te ate.m
uired
n
u
m
b
r
of it
e
ra
t
i
o
ns
st
t
.runn
i
ng = f
a
l
se state.
r
epter
m
nationt
y
pe
res
l
= f
al
retu
r
n res
l
;
i
f( (double)(sta
te = (dou
b
le)(sta
e
epsb*
bn


{
    //

    ||R
    k
        |
        |
        =
    psB * |
        |
    B ||
        ,

    h
        e
    re ||
        R
    k || = Phi
    B
        ar

            //                  ning 
            =
            false


    sta
        t
    e
        .
        r
        e
    t
        er
    minat
        i
    o
        n
    t
    y
        e
            =
            1 se;


    r
        eturn
    r
        esult
        ;
}


ou lphai
p
1 * Math

A
    s(st
        a
        te.c
        i
    )/

sta
    t
e.anor
    m
    )< at
    e
e
    psa) )


{
    ||/ EpsA, here || A ^ T * Rk || = PhiBar * Alpha[i + 1] * |.C / sta
    t
    e.runni
        g
            = fal
    se sta
    t
    e.repterminationty
        e
            =
            4 resu
        t
            = fal
    se retu
    n resu
    lt i
    f
    (
        s
    t
        t
    e.
        usert
        e
    r
        m
    i
        n
    t
        io
    nn
        /
        /


    sted
        t
    ermina
        t
    i
    o
        .runn
    i
        ng = fa
    s
        ;


    epter
        m
    ination
    y
        e = 8
        ;


    ult
        =
        f
    a
    s
        e;


    lt
        Upda
    t
        e ome
        a


    or(e.n - 1;
    i++)
    state.om
        eg at
        e
    vip1[
    ] - st mega
        [i];


    Prepare for the next
    iteration - rename vari :=
    u
            [i + 1]
        /
        v[i]
        : = v[i + 1]
        .
        //
        i_ <= summn - 1;
    i_++)
    {
        stat tate.uip1[i_];
    }
    for (i_ = 0; i_ <= sta
        state.vi[i_] = state.vip1[i_];
}
for (i_ e.n - 1;
i_++)
{
    state.omegai[i_] = state.omegaip
}
state.alphai = state.alphaip1;
state.b.betaip1;
state.phibari = state.phibarip1;
sta state.rhobarip1;
goto lbl_15;
lbl_16:
res
return result;

//
// S                    //
lbl_rcomm:
esu
    s
ta
te.rs
    t
a
    t
e
    .ia
    [0
    ] ate.i
a
    [
        1
    ]
    =
    i


s ra


r
    turn
r
    esult;


}


/*************************************************************************
Procedure for solution of A*x=b with sparse A.

INPUT PARAMETERS:
    State   -   algorithm state
    A       -   sparse M*N matrix in the CRS format (you MUST contvert  it 
                to CRS format  by  calling  SparseConvertToCRS()  function
                BEFORE you pass it to this function).
    B       -   right part, array[M]

RESULT:
    This function returns no result.
    You can get solution by calling LinCGResults()
    
NOTE: this function uses lightweight preconditioning -  multiplication  by
      inverse of diag(A). If you want, you can turn preconditioning off by
      calling LinLSQRSetPrecUnit(). However, preconditioning cost is   low
      and preconditioner is very important for solution  of  badly  scaled
      problems.

  -- ALGLIB --
     Copyright 30.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrsolvesparse(linlsqrstate state,
    sparse.sparsematrix a,
    double[] b,
    alglib.xparams _params)
{
    int
        n
            =
            int i = 0;


    int j =
        0
    nt t0 = 0


    nt t 1 = 0
    ouble
        v = 0;


    algli b.ap. as s
        runni
    ng lveSp
    ar e:
    you
        a
    not
        c
    ion
        w
    h
        e
    n
        LS Q
        RIter at i
    o
    n is
        u
        nn

    ig rt(al
        g
        li.
        a
        p
        .
        en b)>=

    s
        t
    ate
        .m
        ,

    "LinL
    S
        QRSolve
    S
        pars e:
    Le ng th(B <
             M"        );


    ap evect

    o
        r(b, sta
            e

    _ p
    veS pa rs e:
    B co t
    ai
    ns in
    f
        i
    n
        i
    t
        /
        /


    // Allo
    c
        ate t
        e
    mp
        o
    r
        a
    r
        aps er v
    r
        ect or se t
        l
    engthatl
        e
    ast(r
    e
        f st
        a
    t
    e
        .
        tm pd,
        n,
        _ pa a
    m
        s
        )
    ;
    s
        en
    gt at east(r
    e
        f
    stat
    e
        .tmpx, n
        ,
    _ pa r
        ams);


    omput
        e
    diagona s
    alin
        g
    mat
        r
    ix D


    ate
        .
        p
        r
    ec ty e = =0 )


    //         D        e
    f
        au lt p
    re co ni ti ne -
        i
    nv er se
        o f c
    ol um n no
    r
        ms


    i
        sta
    e.tmpd[i]
    0;


    t

    0;


    r
        s
    e.spars
        e

    numerat
        e
        (a f

    t1,

    re
        , ref

    j, ref
    v
        , _pa
        r
    ams)

    s tate
            .tmpd[j]
        = sta
    t
    e.tm
        p
    v) ;


    i <= n
        -
        1;
    i++)


    {
        ouble
            )
        (st a
            m
        d[i] )> (
            d
        oub e)(0)
            )

        {
            s
                t
            ate.t
                m
            pd[i] =
                els


            tate.t
            d[i] = 
        }
    }

    e
        l
    se

    {
        /


        onal s caling
            /


        for (i 0;
        i
            = n - 1;
        i +
            +
            )


        st
        te.tm
        d[i] =
            1;
    }

    //
    // Solve.
    // Instead of solving A*x=b we solve preconditio        A*D        =b.


    // 
    T
        ransf
    o
        rm
    e
    A is
        not calcu
        l
    ated
    e
        xplicitly,
        ion // by A or A'. After solution we modify State.RX so it will stor        med         //

    v
        a
    r
        i
    b
        le
    s

        //         l        , b, 
        _
    p
        a
    r
    a
        s
        ;


    linls
        q
    rr
        e
    s
        t

    a
        rt(st
            a

    te, _
        p
    arams
        )
    ;


    nlsqr
        i

    terat
        o
        (stat
                e
            , _pa
                r
                ams)
        )


    {
        ed
            m
            )


        {
            fo
                r
            (i
                =
                0;
            i <=
                n
                -
                1;
            i +
                +
                )


            sta
                e
            tmpx[
                i] * stat
            e
                .x[i];


            spars
            e.e.tmpx
                ref s
                ta m

            state.needmtv )
            sp
                a
            r
                s
            e
                .
                p
                ar
            semtv
            (
                a
                ,
                s
            a
            te
                .x mt


            fo
                r
            (i
                    =
                    0
                ;

            i <= n -
                1
                ;
            i +
                +
                )


            {
                mt
                    v
                i
                    ] = s
                    t
                ate.
                    mp tv
            }
        }


        for
        (
            i
                =
                0;
            i
            <=
            n -
            st
            ae.r[i] = st
        t
        e
            .t
            mp d[i
    }


    /*************************************************************************
    This function sets stopping criteria.

    INPUT PARAMETERS:
        EpsA    -   algorithm will be stopped if ||A^T*Rk||/(||A||*||Rk||)<=EpsA.
        EpsB    -   algorithm will be stopped if ||Rk||<=EpsB*||B||
        MaxIts  -   algorithm will be stopped if number of iterations
                    more than MaxIts.

    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state

    NOTE: if EpsA,EpsB,EpsC and MaxIts are zero then these variables will
    be setted as default values.
        
      -- ALGLIB --
         Copyright 30.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void linlsqrsetcond(linlsqrstate state,
        double epsa,
        double epsb,
        int maxits,
        alglib.xparams _params)

    rt("L
    SQ
        RS et Co nd y u c
    a
        n no t
    ca l
    hi s fu
        cti on
        wh
    e
        n Li nL SQ
        .asse
        r
    t(math.s fi ite(e
    ) >= ( do
        ub le )(0) "        Lin        LSQRSe        tC        on        d:         E        ps         i         n        g
    at );


    is finit(ep sb) &&
        l
    tC
        o
    d
        :
    EpsB
        i
    s neg
    a
        tive, I NF
        o
    r NAN );


    al g
    l
    ib.a p.a
        s
    sert(ma x
    it
    s
        >= 0, "
    L
        i
    nLSQR Se Co nd:

    a
        ;
    (e
    p
        s
    b)
        =
        =(
        d
    ou
        bl
    e)
    (
            0)
        ) &&

    axit
        ==
        0
        )


    {
        tol st at e
            .epsb = bt l


        axit s =
            state.n;
    }

    {
        sa = p
        a;

        at b;


        state.m ax it s = ax its;
    }


    /*************************************************************************
    LSQR solver: results.

    This function must be called after LinLSQRSolve

    INPUT PARAMETERS:
        State   -   algorithm state

    OUTPUT PARAMETERS:
        X       -   array[N], solution
        Rep     -   optimization report:
                    * Rep.TerminationType completetion code:
                        *  1    ||Rk||<=EpsB*||B||
                        *  4    ||A^T*Rk||/(||A||*||Rk||)<=EpsA
                        *  5    MaxIts steps was taken
                        *  7    rounding errors prevent further progress,
                                X contains best point found so far.
                                (sometimes returned on singular systems)
                        *  8    user requested termination via calling
                                linlsqrrequesttermination()
                    * Rep.IterationsCount contains iterations count
                    * NMV countains number of matrix-vector calculations
                    
      -- ALGLIB --
         Copyright 30.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void linlsqrresults(linlsqrstate state,
            ref double[] x,
            linlsqrreport rep,
            alglib.xparams _params)
        in

    t
        x =
            n


    alg li b.ap.a ss ert(
        !s t
    t
        .runn
        in esult
        :
    you c
    a
        n no t ca l th s
    RIter
        a
    tion i
    s
        r
    u
        n
    n
        n
    ");


    gl b.apl en(x) < s
    t
    {
        x = new double[state.n];
    }
    for (i_ = 0; i_ <= state.n - 1; i_++)
    {
        x[i_] = state.rx[i_];
    }

    rep.iterationscount = state.repiterationscount;
    rep.nmv = state.repnmv;
    rep.terminationtype = state.repterminationtype;
}


/*************************************************************************
This function turns on/off reporting.

INPUT PARAMETERS:
    State   -   structure which stores algorithm state
    NeedXRep-   whether iteration reports are needed or not

If NeedXRep is True, algorithm will call rep() callback function if  it is
provided to MinCGOptimize().

  -- ALGLIB --
     Copyright 30.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrsetxrep(linlsqrstate state,
    bool needxrep,
    alglib.xparams _params)
{
    sta
        t
    e
        .
        x
        r
    e
        p
            =
            n
    e
        e
    d
        x
    r
    e
        p
        ;
}


/*************************************************************************
This function restarts LinLSQRIteration

  -- ALGLIB --
     Copyright 30.11.2011 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrrestart(linlsqrstate state,
    alglib.xparams _params)

st at
e
rstate.ia = new int[
    1
1];
tate.rstate.
    = ne w du le[0 + 1];


ta te.rst
ate.
    clea
    r
rfi el ds(
    st at e, _ ar
a
    m
s
    );


te.rep it erations co unt = 
    ;


}


/*************************************************************************
This function is used to peek into LSQR solver and get  current  iteration
counter. You can safely "peek" into the solver from another thread.

INPUT PARAMETERS:
    S           -   solver object

RESULT:
    iteration counter, in [0,INF)

  -- ALGLIB --
     Copyright 21.05.2018 by Bochkanov Sergey
*************************************************************************/
public static int linlsqrpeekiterationscount(linlsqrstate s,
    alglib.xparams _params)


resu t
    = s.r
e
    p
a
    ti return result;
}


/*************************************************************************
This subroutine submits request for termination of the running solver.  It
can be called from some other thread which wants LSQR solver to  terminate
(obviously, the  thread  running  LSQR  solver can not request termination
because it is already busy working on LSQR).

As result, solver  stops  at  point  which  was  "current  accepted"  when
termination  request  was  submitted  and returns error code 8 (successful
termination).  Such   termination   is  a smooth  process  which  properly
deallocates all temporaries.

INPUT PARAMETERS:
    State   -   solver structure

NOTE: calling this function on solver which is NOT running  will  have  no
      effect.
      
NOTE: multiple calls to this function are possible. First call is counted,
      subsequent calls are silently ignored.

NOTE: solver clears termination flag on its start, it means that  if  some
      other thread will request termination too soon, its request will went
      unnoticed.

  -- ALGLIB --
     Copyright 08.10.2014 by Bochkanov Sergey
*************************************************************************/
public static void linlsqrrequesttermination(linlsqrstate state,
    alglib.xparams _params)
{
    eeded = true;
}


/*************************************************************************
Clears request fileds (to be sure that we don't forgot to clear something)
*************************************************************************/
private static void clearrfields(linlsqrstate state,
    alglib.xparams _params)
{
    st
        a
    te.
        x
        pdated
            =
            dmv =
                fa ls e;


    t
        at e.n
        sta te ne e
    v
        v = fal
    se
        sta
    t
    e
        .n
}
}

public class nleq
{
    public class nleqstate : apobject
    {
        public int n;
        public int m;
        public double epsf;
        public int maxits;
        public bool xrep;
        public double stpmax;
        public double[] x;
        public double f;
        public double[] fi;
        public double[,] j;
        public bool needf;
        public bool needfij;
        public bool xupdated;
        public rcommstate rstate;
        public int repiterationscount;
        public int repnfunc;
        public int repnjac;
        public int repterminationtype;
        public double[] xbase;
        public double fbase;
        public double fprev;
        public double[] candstep;
        public double[] rightpart;
        public double[] cgbuf;

        public nleqstate()
        {
            i
                n
            i
            t
                (
                )
                ;
        }

        public override void init()
        {
            x = new double[0];


            fi = new
                oubl
            e[0];

            j
                = new double[0, 0];


            r
            s
                xbase =
                    ewd oub le[0];


            c ndse p =
                new doubl[0];

            h w doub
                l
            e[
                0
            ];


            cg
                b
            u
        }

        public override alglib.apobject make_copy()


        nl
            e eqs ta e()


        _res
            u

        t.n= n;


        .m = m;


        _ res ul t.
            e

        p
            f = ep sf;


        s as
        _ re su l
        t.xr e
        p = xre p;


        _resu t.s t
            x

        )x.Cl
            o

        ne()
            .f = f;


        ouble
        [
        ])fi.C
            o

        );


        _re
            le[,])j.Clone();

        ult.n
            e

        edf
            eed;


        esult
            .
            need
            i
                = n

        e
            _resul
            .
            update

        d

        /*************************************************************************
LSQR solver: results.

This function must be called after LinLSQRSolve

INPUT PARAMETERS:
State   -   algorithm state

OUTPUT PARAMETERS:
X       -   array[N], solution
Rep     -   optimization report:
* Rep.TerminationType completetion code:
*  1    ||Rk||<=EpsB*||B||
*  4    ||A^T*Rk||/(||A||*||Rk||)<=EpsA
*  5    MaxIts steps was taken
*  7 
};


public class nleqreport : apobject
{
public int iterationscount;
public int nfunc;
public int njac;
public int terminationtype;

public nleqreport()
{


init();
}

public override void init()
{
}

public override alglib.apobject make_copy()



leqrep
rt
_resul
t
= new
nleqreport()
co
nt = i
era                     

_resu
t.
func = nf
nc;





_
r
e
s
u
l
t
.
n
j
a
c

=

n
j
a
c
;


















_
r
e
s
u
l
t
.
t
e
r
m
i
n
a
t
i
o
n
t
y
p
e

=

t
e
r
m
i
na            ;



eturn _result;


}
};


/*************************************************************************
LEVENBERG-MARQUARDT-LIKE NONLINEAR SOLVER

DESCRIPTION:
This algorithm solves system of nonlinear equations
F[0](x[0], ..., x[n-1])   = 0
F[1](x[0], ..., x[n-1])   = 0
...
F[M-1](x[0], ..., x[n-1]) = 0
with M/N do not necessarily coincide.  Algorithm  converges  quadratically
under following conditions:
* the solution set XS is nonempty
* for some xs in XS there exist such neighbourhood N(xs) that:
* vector function F(x) and its Jacobian J(x) are continuously
differentiable on N
* ||F(x)|| provides local error bound on N, i.e. there  exists  such
c1, that ||F(x)||>c1*distance(x,XS)
Note that these conditions are much more weaker than usual non-singularity
conditions. For example, algorithm will converge for any  affine  function
F (whether its Jacobian singular or not).


REQUIREMENTS:
Algorithm will request following information during its operation:
* function vector F[] and Jacobian matrix at given point X
* value of merit function f(x)=F[0]^2(x)+...+F[M-1]^2(x) at given point X


USAGE:
1. User initializes algorithm state with NLEQCreateLM() call
2. User tunes solver parameters with  NLEQSetCond(),  NLEQSetStpMax()  and
other functions
3. User  calls  NLEQSolve()  function  which  takes  algorithm  state  and
pointers (delegates, etc.) to callback functions which calculate  merit
function value and Jacobian.
4. User calls NLEQResults() to get solution
5. Optionally, user may call NLEQRestartFrom() to  solve  another  problem
with same parameters (N/M) but another starting  point  and/or  another
function vector. NLEQRestartFrom() allows to reuse already  initialized
structure.


INPUT PARAMETERS:
N       -   space dimension, N>1:
* if provided, only leading N elements of X are used
* if not provided, determined automatically from size of X
M       -   system size
X       -   starting point


OUTPUT PARAMETERS:
State   -   structure which stores algorithm state


NOTES:
1. you may tune stopping conditions with NLEQSetCond() function
2. if target function contains exp() or other fast growing functions,  and
optimization algorithm makes too large steps which leads  to  overflow,
use NLEQSetStpMax() function to bound algorithm's steps.
3. this  algorithm  is  a  slightly  modified implementation of the method
described  in  'Levenberg-Marquardt  method  for constrained  nonlinear
equations with strong local convergence properties' by Christian Kanzow
Nobuo Yamashita and Masao Fukushima and further  developed  in  'On the
convergence of a New Levenberg-Marquardt Method'  by  Jin-yan  Fan  and
Ya-Xiang Yuan.


-- ALGLIB --
Copyright 20.08.2009 by Bochkanov Sergey
*************************************************************************/
        public static void nleqcreatelm(int n,
            int m,
            double[] x,
            nleqstate state,
            alglib.xparams _params)
        {
            alglib.ap.a
                s
            ert(n >=
                , "N
            EQCreate
            M:
            N < 1!")


            alglib.
                .ass
            t(m >
                    , "        M<1!")
                ;
            sser
                t
            alglib.a
                    .len(
                    ) >
                n, "
            LEQCreat
            LM:
            Length(X
            )
            N!");


            alg
                li serv.isfin
                tevec
            or(
                , n, _pa
            ams), "
            NEQCreateLM:
            X
                ontain
            infin
                te or NaN v
                lues
            ")


            //
            alize


            //

            stat
                .n
                n;


            s
            ate.
                = m;
            leqsetcon
                ds,
                params
                ;
            eqsetxrep
                state, fal
            e,
            _params);
            nleq
                s
            e
                t
            s
                t
            p
                m

            a
                x
                (
                    s
                        t

            a
            t
                e, 

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


            s
                t
            a
                t
            e
                    .x
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
                    n
                ]
                ;


            state.xba
                e = ne
            dou
            le[n];
            state.j
                = new doubl
                [m, n
                ];
            state
                .fi = ne
            double
                [m];

            art =
                n
            w do
                uble[n];
            state.candstep = new double[n];
            nleqrestartfrom(state, x, _params);
        }


        /*************************************************************************
        This function sets stopping conditions for the nonlinear solver

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state
            EpsF    -   >=0
                        The subroutine finishes  its work if on k+1-th iteration
                        the condition ||F||<=EpsF is satisfied
            MaxIts  -   maximum number of iterations. If MaxIts=0, the  number  of
                        iterations is unlimited.

        Passing EpsF=0 and MaxIts=0 simultaneously will lead to  automatic
        stopping criterion selection (small EpsF).

        NOTES:

          -- ALGLIB --
             Copyright 20.08.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void nleqsetcond(nleqstate state,
            double epsf,
            int maxits,
            alglib.xparams _params)
        {
            alglib.ap.ass
                er ite(ep
            f),
            "NLEQSet
            Co not fi
                ite
            number!
            ")          algl
            b.a
                .assert((double)(e
            ps(0), "
            LEQSet
                C
            o
            d:
            ne
                ga;


            algli
            b.xits >=
                , "NLE
            SetCo
                nd axIts!
                );


            if
                (f)==(d
            uble)(
                    0
                )
                && maxits
                == {
                e;
            }


            t
            xi ts = m ax it s;
        }


        /*************************************************************************
        This function turns on/off reporting.

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state
            NeedXRep-   whether iteration reports are needed or not

        If NeedXRep is True, algorithm will call rep() callback function if  it is
        provided to NLEQSolve().

          -- ALGLIB --
             Copyright 20.08.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void nleqsetxrep(nleqstate state,
            bool needxrep,
            alglib.xparams _params)
        {
            = need x
            r
                ep;
        }


        /*************************************************************************
        This function sets maximum step length

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state
            StpMax  -   maximum step length, >=0. Set StpMax to 0.0,  if you don't
                        want to limit step length.

        Use this subroutine when target function  contains  exp()  or  other  fast
        growing functions, and algorithm makes  too  large  steps  which  lead  to
        overflow. This function allows us to reject steps that are too large  (and
        therefore expose us to the possible overflow) without actually calculating
        function value at the x+stp*d.

          -- ALGLIB --
             Copyright 20.08.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void nleqsetstpmax(nleqstate state,
            double stpmax,
            alglib.xparams _params)
        {
            al rt(mat
                    . is
                inite(stpmax),
            "N        : StpM
            x i
            not
                fi
            a
            glib
                .a uble)(
                tpm
            x)>=(double)(0)
                , ax:
            St
            Max < 0!");


            t
        }


        /*************************************************************************

          -- ALGLIB --
             Copyright 20.03.2009 by Bochkanov Sergey
        *************************************************************************/
        public static bool nleqiteration(nleqstate state,
            alglib.xparams _params)
        {
            i nt n = 0;
                in t m = 0

            i nt i = 0;


            aup =
                0;

            ambdadown =
                double lambdav = 0;
            double rho = 0;
            double mu = 0;
            double stepnorm = 0;
            bool b = new bool();
            int i_ = 0;


            //
            // Reverse communication preparations
            // I know it looks ugly, but it works the same way
            // anywhere from C++ to Python.
            //
            // This code initializes locals by:
            // * random values determined during code
            //   generation - on first subroutine call
            // * values from previous call - on subsequent calls
            //
            if (state.rstate.stage >= 0)
            {
                n = state.rstate.ia[0];
                m = state.rstate.ia[1];
                i = state.rstate.ia[2];
                b = state.rstate.ba[0];
                lambdaup = state.rstate.ra[0];
                lambdadown = state.rstate.ra[1];
                lambdav = state.rstate.ra[2];
                rho = state.rstate.ra[3];
                mu = state.rstate.ra[4];
                stepnorm = state.rstate.ra[5];
            }
            else
            {
                n = 359;
                m = -58;
                i = -919;
                b = true;
                lambdaup = 81;
                lambdadown = 255;
                lambdav = 74;
                rho = -788;
                mu = 809;
                stepnorm = 205;
            }

            if (state.rstate.stage == 0)
            {
                goto lbl_0;
            }

            if (state.rstate.stage == 1)
            {
                goto lbl_1;
            }

            if (state.rstate.stage == 2)
            {
                goto lbl_2;
            }

            if (state.rstate.stage == 3)
            {
                goto lbl_3;
            }

            if (state.rstate.stage == 4)
            {
                goto lbl_4;
            }

            //
            // Routine body
            //

            //
            // Prepare
            //
            n = state.n;
            m = state.m;
            state.repterminationtype = 0;
            state.repiterationscount = 0;
            state.repnfunc = 0;
            state.repnjac = 0;

            //
            // Calculate F/G, initialize algorithm
            //
            clearrequestfields(state, _params);
            state.needf = true;
            state.rstate.stage = 0;
            goto lbl_rcomm;
            lbl_0:
            state.needf = false;
            state.repnfunc = state.repnfunc + 1;
            for (i_ = 0; i_ <= n - 1; i_++)
            {
                state.xbase[i_] = state.x[i_];
            }

            state.fbase = state.f;
            state.fprev = math.maxrealnumber;
            if (!state.xrep)
            {
                goto lbl_5;
            }

            //
            // progress report
            //
            clearrequestfields(state, _params);
            state.xupdated = true;
            state.rstate.stage = 1;
            goto lbl_rcomm;
            lbl_1:
            state.xupdated = false;
            lbl_5:
            if ((double)(state.f) <= (double)(math.sqr(state.epsf)))
            {
                state.repterminationtype = 1;
                result = false;
                return result;
            }

            //

            // M
            in cycle
                l
            am


            0.3;


            .001;


            rho
                = 1;


            if
            (
                f al e )


            {
                g
            }


            //

            / /Get Jacobian;
                /
            be
                fo e
                w
            g
                t o this po nt
            w alrea
            d
                y ha e

            Sta

                // wi
                t
            h curr
            e
                nt poi t and ta
            te F
            a
                s
            fil ed
            w
                i
            h function val
            u
                / at X as

                //          
                , _ state


            (i_ = 0
            i
                -
                1
            {
                x[i_] = sta t
                e
                    .xbas
                    e
                i
                    _
                    ;
            }
            state.rstat.stage
            2;


            g
                ot l bl _2 :
            st at e.ne e
                j =
                    ls e;

            fu nc + 1;


            st at e
                pn ja c = st at e.re pn j
            las.r
                m
            atri m
            (
                , m stat.j
                ,

            0
                , fi, 0
                , st t
                .ri
                htpart
            0
                ,
            _p a
            ra f or(i
                    = 
                ;
            i = n - 1;
            i_ +
                +
                )


            tat e.ri
                g
            h
                t
            pa state
                .rightpar
                [
                    _];


            //


            //

            Inner cyclefind good lambda
            //
            lbl_9:
            if (false)
            {
                goto lbl_10;
            }

            //
            // Solve (J^T*J + (Lambda+Mu)*I)*y = J^T*F
            // to get step d=-y where:
            // * Mu=||F|| - is damping parameter for nonlinear system
            // * Lambda   - is additional Levenberg-Marquardt parameter
            //              for better convergence when far away from minimum
            //
            for (i = 0; i <= n - 1; i++)
            {
                state.candstep[i] = 0;
            }

            fbls.fblssolvecgx(state.j, m, n, lambdav, state.rightpart, ref state.candstep, ref state.cgbuf, _params);

            //
            // Normalize step (it must be no more than StpMax)
            //
            stepnorm = 0;
            for (i = 0; i <= n - 1; i++


            {
                if
                    (dou
                bl dstep[
                ])!=
                (d


                tepnorm
                    = 1;

                break;
            }
        }

        lin
            m

        n.li
            mi

        nor
            ali ed(r f stat
            e.cand epnor ,

        n, _
        params
        )
        ;


        i
            f(
                (doubl
                    e
                    )

        (
        s
        t
        te stpmax) != (d u
        b
            e)( 0) )


        s t

        e
            pn

        o
            rm = M

        a
            th.Min
            (st p

        orm, tate.s tp

        m
            x);
    }


    //


    //        Test

    ne w st p
    is it go

    o
        e

    bda
        s

    increa
        s

    a
    /d , we
        d

    crease
        Lambda andove on.
    //
    // We can break this cycle on two occasions:
    // * step is so small that x+step==x (in floating point arithmetics)
    // * lambda is so large
    //
    for(i_= 0; i_<=n-1;i_++)
    {
        state.x[i_] = state.xbase[i_];
    }

for (i_ = 0; i_ <= n - 1; i_++)
{
    state.x[i_] = state.x[i_] + stepnorm * state.candstep[i_];
}

b = true;
for (i = 0; i <= n - 1; i++)
{
    if ((double)(state.x[i]) != (double)
        state.
    base
    i]) )


    {
        b
            = false;


        break;
    }


    {
        //
        // Step is too small, force zero step and break
        //
        stepnorm = 0;
        for (i_ = 0; i_ <= n - 1; i_++)
        {
            state.x[i_] = state.xbase[i_];
        }

        state.f = state.fbase;
        goto lbl_10;
    }
    clearrequestfields(state, _params);
    state.needf = true;
    state.rstate.stage = 3;
    goto lbl_rcomm;
    lbl_3:
    state.needf = false;
    state.repnfunc = state.repnfunc + 1;
    if ((double)(state.f) < (double)(state.fbase))
    {
        //
        // function value decreased, move on
        //
        decreaselambda(ref lambdav, ref rho, lambdadown, _params);
        goto lbl_10;


        if (!increas

        e
            lambda(re
                lamb

        da lambda
            p, _pa
        ra
        {
            //

            Lamb a
                is too l

            a
                rge(n
                    e
                    a overflow),

            force zero s
                ep nd r eak
                ste
            p
            n
                orm =
                    0
                ;


            f
                o
            r
                (
                    i_ = 
                ;
            i_ <= n - 1;
            i_++)


            a.xbase[i_];
        }
        state.f = state.fbase;
        goto lbl_10;
    }

    goto lbl_9;
    lbl_10:

    //
    // Accept step:
    // * new position
    // * new 
    unctio
        val
    e

        //
        st state.f
        ;

    f
    or(i_ = 0;
    i_ <
        se[
            _


    st ] +
        s
    e
        n
    or ste
        [
            _
        ;


    st
    t
        .
        re ount =
            state.repi
    e
        a
    ti

        //
        R
    p
        or ion


    if
    !state.r
    p
        ) {
        go
            iel arams);
        state.xupdated = t state.f = state.fbase;
        for (i_ = 0; i
        {
            s st ];
        }

        state.r = 4;
        goto lbl_rcomm;
        l state.xupdated = false;
        lbl_1
            //
            // Test stopping condi        ste        ze
            r
            ) and
            MaxIts
            ;


        of i
            et, R
        e
            pTermi
        n
            at
        i
            o
        n
            Ty


        //


        a
            h
        Sqrt(
            s
        tate.f
            )
            )<
            =
        (
            d
        ou


        {
            eptermin
                t
            ontyp
                e
                    = 1;


            if ((dou
            l
                )(ste
            p
                norm) =
                =
            (d
            o
                u
            b
                le ptermin
                t
            ontyp
            e
                == 0 )


            state
                .repter
            m
                in
            a
                t
            i
                on
        }


        i
            f
        (onscount
            =
            tate.m
        axits
            &
            &
                s
        t
            a
        te ta n
        y
            e =
                5


        t
            r
        i
            nat
        io

        {
            oto lbl_
                ;


            // Now,
            i
                er
            at ver


            g
                to
            lb _8:


            se
                r
            turn
            r
                esult;
                / Sa
                ing s
                ta lb
                l
            rcomm
                :


            r
                e
            ul tate
            ia[0]
                = te
                        .a[1]
                    =
                    m;


            st a[
                tate.rs b
            s
            ate.r
                s
            tate.r
            a
                    [0] =
                l
            a
                bd ra[1
                = la
            mb rs
            t
            te.ra
            [
                2] = l
            a
                mbdav
                ;


            e.ho;


            t
                s ra[5] = stepnorm return result;
        }


        /*************************************************************************
        NLEQ solver results

        INPUT PARAMETERS:
            State   -   algorithm state.

        OUTPUT PARAMETERS:
            X       -   array[0..N-1], solution
            Rep     -   optimization report:
                        * Rep.TerminationType completetion code:
                            * -4    ERROR:  algorithm   has   converged   to   the
                                    stationary point Xf which is local minimum  of
                                    f=F[0]^2+...+F[m-1]^2, but is not solution  of
                                    nonlinear system.
                            *  1    sqrt(f)<=EpsF.
                            *  5    MaxIts steps was taken
                            *  7    stopping conditions are too stringent,
                                    further improvement is impossible
                        * Rep.IterationsCount contains iterations count
                        * NFEV countains number of function calculations
                        * ActiveConstraints contains number of active constraints

          -- ALGLIB --
             Copyright 20.08.2009 by Bochkanov Sergey
        *************************************************************************/
        public static void nleqresults(nleqstate state,
            ref double[] x,
            nleqreport rep,
            alglib.xparams _params)
        {
            [
            0]


            nleqr
                e
            re f, rep
        }


        /*************************************************************************
        NLEQ solver results

        Buffered implementation of NLEQResults(), which uses pre-allocated  buffer
        to store X[]. If buffer size is  too  small,  it  resizes  buffer.  It  is
        intended to be used in the inner cycles of performance critical algorithms
        where array reallocation penalty is too large to be ignored.

          -- ALGLIB --
             Copyright 20.08.2009 by Bochkanov Sergey
        *************************************************************************/
        public static void nleqresultsbuf(nleqstate state,
            ref double[] x,
            nleqreport rep,
            alglib.xparams _params)
        { in
            t
                i

            i(
                al
            gl
                i
            b
                .a

            p.
                le n(x
                    x = n

            e
                w
            d
                u
            l
            e
            [
                state.n];
        }
        =


        x[i_
            = st
        a
        e.xb
        se[i
        ];
        rep.it
            er =
                s
        ate.r
            pi nt p.nf
            nc = s
        ta


        te.rep.terminationtype = state.repter;
    }


    /*************************************************************************
    This  subroutine  restarts  CG  algorithm from new point. All optimization
    parameters are left unchanged.

    This  function  allows  to  solve multiple  optimization  problems  (which
    must have same number of dimensions) without object reallocation penalty.

    INPUT PARAMETERS:
        State   -   structure used for reverse communication previously
                    allocated with MinCGCreate call.
        X       -   new starting point.
        BndL    -   new lower bounds
        BndU    -   new upper bounds

      -- ALGLIB --
         Copyright 30.07.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void nleqrestartfrom(nleqstate state,
        double[] x,
        alglib.xparams _params)


    i
    nt i_ = 0;


    al
        g
    li
    b
        .ap. as e
        r
    t
    (
        a
    g
    "N        LE        QRe        st        ar
    F
    om :
    Le
        n
    gth(X
    ) < N!"        ;


    a lg i
    b
        .
        v
        .n
        tartFro
    X c
    ntai
        nf
    ni
        e o r N valu
    e

    r(_ = 0;
    i_ < state.n - 1;
    _ + {
        state.[i] = x[i];


        te. new int[2 + 1];
        state.rstate.ba = n;
        state.rstate.ra = new double[5 + 1];
        state.rs - 1;
        clearre sta;
    }


    /*************************************************************************
    Clears request fileds (to be sure that we don't forgot to clear something)
    *************************************************************************/
    private static void clearrequestfields(nleqstate state,
        alglib.xparams _params)
    {
        =
        at.
            eedfi
            j
        ate.x
            u
    }


    /*************************************************************************
    Increases lambda, returns False when there is a danger of overflow
    *************************************************************************/
    private static bool increaselambda(ref double lambdav,
        ref double nu,
        double lambdaup,
        alglib.xparams _params)
    {
        b
            o
        ol re
        s
            lt = ne
        w
            b

        doub
            e
        lnla
            mb

        doub
            l
        e lnn


        0;
        dou
            le lnlamb
            daup = 0;

        lnmax
            = 0;


        false
            ;


        lnl
        a
            mbda = M
        a
            t
        h.;


        lnla
            m
        b
            d
        a
        u
            p = Ma
        t
        h
            .Log(
                l
        ambda
            u
            );
        nma(math.maxrealnumber);
        if (da + > (double)(lnma
        x
            ) )


        return
            r
        es
    }


    2)
        )
    (
        double)(ln max) )


    {
        r t
        u
            n re sult
            ;


        nu
            * 2

        res
            lt = tr
        e
            ;


        r
            e
        urn r
        sult
    }


    /*************************************************************************
    Decreases lambda, but leaves it unchanged when there is danger of underflow.
    *************************************************************************/
    private static void decreaselambda(ref double lambdav,
        ref double nu,
        double lambdadown,
        alglib.xparams _params)
    {
        doubl
            e
            )(Mat
            .og(la
        mb da v
            bd ad
            o
        wn
            )
            )
            <
        do
            ub
                l
        e
            )
        (
            Ma
        th
            .
        {
            bdav
                =
                math
                    .mi
            n
                ea nu be;
        }
        l
        am bdav = lambdav * lam
        da own;
    }
}
}
}