namespace Libraries.UralMathFsharpLib

type Cvet() =
    member val cos16 = 0.96126169593831886191649704855706 with get, set
    member val sin16 = 0.2756373558169991856499715746113 with get, set
    member val cos26 = 0.89879404629916699278229567669579 with get, set
    member val sin26 = 0.43837114678907741745273454065827 with get, set
    member val cos50 = 0.64278760968653932632264340990726 with get, set
    member val sin50 = 0.76604444311897803520239265055542 with get, set
    static member ryb2rgb(cveta : int[]) = 
        let mutable (w : float) = Unchecked.defaultof<float>
        let mutable (r : float) = Unchecked.defaultof<float>
        let mutable (y : float) = Unchecked.defaultof<float>
        let mutable (b : float) = Unchecked.defaultof<float>
        let mutable (g : float) = Unchecked.defaultof<float>
        let mutable (myc : float) = Unchecked.defaultof<float>
        let mutable (mgc : float) = Unchecked.defaultof<float>
        w <- Math.Min ((Math.Min (cveta.[0], cveta.[1])), cveta.[2])
        r <- cveta.[0] :> float - w
        y <- cveta.[1] :> float - w
        b <- cveta.[2] :> float - w
        myc <- Math.Max ((Math.Max (r, y)), b)
        g <- Math.Min (y, b)
        y <- y - g
        b <- b - g
        (* ERROR UnknownAssignmentOperator "*=" "AssignmentExpressionSyntax" b *= 2.0 *)
        (* ERROR UnknownAssignmentOperator "*=" "AssignmentExpressionSyntax" g *= 2.0 *)
        r <- r + y
        g <- g + y
        mgc <- Math.Max ((Math.Max (r, g)), b)
        if mgc <> 0
        then 
            (* ERROR UnknownAssignmentOperator "*=" "AssignmentExpressionSyntax" r *= (myc / mgc) *)
            (* ERROR UnknownAssignmentOperator "*=" "AssignmentExpressionSyntax" g *= (myc / mgc) *)
            (* ERROR UnknownAssignmentOperator "*=" "AssignmentExpressionSyntax" b *= (myc / mgc) *)
        r <- r + w
        g <- g + w
        b <- b + w
        [|(int r); (int g); (int b)|]
    static member rgb2ryb(cveta : int[]) = 
        let mutable (w : float) = Unchecked.defaultof<float>
        let mutable (r : float) = Unchecked.defaultof<float>
        let mutable (g : float) = Unchecked.defaultof<float>
        let mutable (b : float) = Unchecked.defaultof<float>
        let mutable (y : float) = Unchecked.defaultof<float>
        let mutable (mgc : float) = Unchecked.defaultof<float>
        let mutable (myc : float) = Unchecked.defaultof<float>
        w <- Math.Min ((Math.Min (cveta.[0], cveta.[1])), cveta.[2])
        r <- cveta.[0] :> float - w
        g <- cveta.[1] :> float - w
        b <- cveta.[2] :> float - w
        mgc <- Math.Max ((Math.Max (r, g)), b)
        y <- Math.Min (r, g)
        r <- r - y
        g <- g - y
        (* ERROR UnknownAssignmentOperator "/=" "AssignmentExpressionSyntax" b /= 2.0 *)
        (* ERROR UnknownAssignmentOperator "/=" "AssignmentExpressionSyntax" g /= 2.0 *)
        y <- y + g
        b <- b + g
        myc <- Math.Max ((Math.Max (r, g)), b)
        if myc <> 0
        then 
            (* ERROR UnknownAssignmentOperator "*=" "AssignmentExpressionSyntax" r *= (mgc / myc) *)
            (* ERROR UnknownAssignmentOperator "*=" "AssignmentExpressionSyntax" y *= (mgc / myc) *)
            (* ERROR UnknownAssignmentOperator "*=" "AssignmentExpressionSyntax" b *= (mgc / myc) *)
        r <- r + w
        y <- y + w
        b <- b + w
        [|(int r); (int y); (int b)|]

    static member ryb2rybk(ryb : int[]) = 
        let mutable (k : float) = Math.Min (ryb.[0], (Math.Min (ryb.[1], ryb.[2])))
        [|(int (ryb.[0] - k / 1 - k)); (int (ryb.[1] - k / 1 - k)); (int (ryb.[2] - k / 1 - k)); (int k)|]
    static member rybk2ryb(ryb : int[]) = 
        let mutable (r : int) = 1 - ryb.[0] * 1 - ryb.[3]
        let mutable (y : int) = 1 - ryb.[1] * 1 - ryb.[3]
        let mutable (b : int) = 1 - ryb.[2] * 1 - ryb.[3]
        [|r; y; b|]
    static member rgb2hsb(cveta : int[]) = 
        let mutable (r : float) = (cveta.[0] :> float / 255.0) :> float
        let mutable (g : float) = (cveta.[1] :> float / 255.0) :> float
        let mutable (b : float) = (cveta.[2] :> float / 255.0) :> float
        let mutable (max : float) = Math.Max (r, (Math.Max (g, b)))
        let mutable (min : float) = Math.Min (r, (Math.Min (g, b)))
        let mutable (h : float) = 0.0
        if max = r && g >= b
        then h <- 60 * g - b / max - min
        else 
            if max = r && g < b
            then h <- 60 * g - b / max - min + 360
            else 
                if max = g
                then h <- 60 * b - r / max - min + 120
                else 
                    if max = b
                    then h <- 60 * r - g / max - min + 240
        let mutable (s : float) = 
            if max = 0
            then 0.0
            else 1.0 - min / max
        [|(int h); (int s); (int max)|]
    static member hsb2rgb(cveta : int[]) = 
        let mutable (r : float) = 0
        let mutable (g : float) = 0
        let mutable (b : float) = 0
        if cveta.[1] = 0
        then r <- g <- b
        else 
            let mutable (sectorPos : float) = cveta.[0] / 60.0
            let mutable (sectorNumber : int) = Math.Floor (sectorPos)
            let mutable (fractionalSector : float) = sectorPos - sectorNumber
            let mutable (p : float) = b * 1.0 - cveta.[1]
            let mutable (q : float) = b * 1.0 - cveta.[1] * fractionalSector
            let mutable (t : float) = b * 1.0 - cveta.[1] * 1 - fractionalSector
            match sectorNumber with
            0 -> 
                r <- b
                g <- t
                b <- p
                (* ERROR BreakNotSupported "BreakStatementSyntax" break; *)
            | 1 -> 
                r <- q
                g <- b
                b <- p
                (* ERROR BreakNotSupported "BreakStatementSyntax" break; *)
            | 2 -> 
                r <- p
                g <- b
                b <- t
                (* ERROR BreakNotSupported "BreakStatementSyntax" break; *)
            | 3 -> 
                r <- p
                g <- q
                b <- b
                (* ERROR BreakNotSupported "BreakStatementSyntax" break; *)
            | 4 -> 
                r <- t
                g <- p
                b <- b
                (* ERROR BreakNotSupported "BreakStatementSyntax" break; *)
            | 5 -> 
                r <- b
                g <- p
                b <- q
                (* ERROR BreakNotSupported "BreakStatementSyntax" break; *)
        [|(int (r * 255)); (int (g * 255)); (int (b * 255))|]
    static member rgb2hsl(cveta : int[]) = 
        let mutable (h : float) = 0
        let mutable (s : float) = 0
        let mutable (l : float) = 0
        let mutable (r : float) = cveta.[0] :> float / 255.0
        let mutable (g : float) = cveta.[1] :> float / 255.0
        let mutable (b : float) = cveta.[2] :> float / 255.0
        let mutable (max : float) = Math.Max (r, (Math.Max (g, b)))
        let mutable (min : float) = Math.Min (r, (Math.Min (g, b)))
        if max = min
        then h <- 0
        else 
            if max = r && g >= b
            then h <- 60.0 * g - b / max - min
            else 
                if max = r && g < b
                then h <- 60.0 * g - b / max - min + 360.0
                else 
                    if max = g
                    then h <- 60.0 * b - r / max - min + 120.0
                    else 
                        if max = b
                        then h <- 60.0 * r - g / max - min + 240.0
        l <- max + min / 2.0
        if l = 0 || max = min
        then s <- 0
        else 
            if 0 < l && l <= 0.5
            then s <- max - min / max + min
            else 
                if l > 0.5
                then s <- max - min / 2 - max + min
        [|(int h); (int s); (int l)|]
    static member hsl2rgb(cveta : int[]) = 
        if cveta.[1] = 0
        then [|(int (int cveta.[2] * 255)); (int (int cveta.[2] * 255)); (int (int cveta.[2] * 255))|]
        else 
            let mutable (q : float) = 
                if cveta.[2] < 0.5
                then cveta.[2] * 1.0 + cveta.[1]
                else cveta.[2] + cveta.[1] - cveta.[2] * cveta.[1]
            let mutable (p : float) = 2.0 * cveta.[2] - q
            let mutable (Hk : float) = cveta.[0] / 360.0
            let mutable (T : double[]) = Array.zeroCreate 3
            T.[0] <- Hk + 1.0 / 3.0
            T.[1] <- Hk
            T.[2] <- Hk - 1.0 / 3.0
            do 
                let mutable (i : int) = 0
                while (i < 3) do
                    if T.[i] < 0
                    then T.[i] <- T.[i] + 1.0
                    if T.[i] > 1
                    then T.[i] <- T.[i] - 1.0
                    if T.[i] * 6 < 1
                    then T.[i] <- p + q - p * 6.0 * T.[i]
                    else 
                        if T.[i] * 2.0 < 1
                        then T.[i] <- q
                        else 
                            if T.[i] * 3.0 < 2
                            then T.[i] <- p + q - p * 2.0 / 3.0 - T.[i] * 6.0
                            else T.[i] <- p
                    i <- i + 1
                    i
            [|(int (int T.[2] * 255)); (int (int T.[2] * 255)); (int (int T.[2] * 255))|]
    static member rgb2cmyk(cveta : int[]) = 
        let mutable (c : float) = (255 - cveta.[0]) :> float / 255
        let mutable (m : float) = (255 - cveta.[1]) :> float / 255
        let mutable (y : float) = (255 - cveta.[2]) :> float / 255
        let mutable (k : float) = Math.Min (c, (Math.Min (m, y)))
        if k = 1.0
        then [|0; 0; 0; 1|]
        else [|(int (c - k / 1 - k)); (int (m - k / 1 - k)); (int (y - k / 1 - k)); (int k)|]
    static member cmyk2rgb(cveta : int[]) = 
        let mutable (r : int) = 1 - cveta.[0] * 1 - cveta.[3] * 255.0
        let mutable (g : int) = 1 - cveta.[1] * 1 - cveta.[3] * 255.0
        let mutable (b : int) = 1 - cveta.[2] * 1 - cveta.[3] * 255.0
        [|r; g; b|]
    static member rgb2xyz(cveta : int[]) = 
        let mutable (x : float) = Unchecked.defaultof<float>
        let mutable (y : float) = Unchecked.defaultof<float>
        let mutable (z : float) = Unchecked.defaultof<float>
        let mutable (r : float) = cveta.[0] :> float / 255.0
        let mutable (g : float) = cveta.[1] :> float / 255.0
        let mutable (b : float) = cveta.[2] :> float / 255.0
        r <- 
            if r > 0.04045
            then Math.Pow ((r + 0.055 / 1 + 0.055), 2.2)
            else r / 12.92
        g <- 
            if g > 0.04045
            then Math.Pow ((g + 0.055 / 1 + 0.055), 2.2)
            else g / 12.92
        b <- 
            if b > 0.04045
            then Math.Pow ((b + 0.055 / 1 + 0.055), 2.2)
            else b / 12.92
        x <- r * 0.4124 + g * 0.3576 + b * 0.1805
        y <- r * 0.2126 + g * 0.7152 + b * 0.0722
        z <- r * 0.0193 + g * 0.1192 + b * 0.9505
        [|x; y; z|]
    static member xyz2rgb(cveta : double[]) = 
        let mutable (rgb : double[]) = Array.zeroCreate 3
        rgb.[0] <- cveta.[0] * 3.2410 - cveta.[1] * 1.5374 - cveta.[2] * 0.4986
        rgb.[1] <- - cveta.[0] * 0.9692 + cveta.[1] * 1.8760 - cveta.[2] * 0.0416
        rgb.[2] <- cveta.[0] * 0.0556 - cveta.[1] * 0.2040 + cveta.[2] * 1.0570
        do 
            let mutable (i : int) = 0
            while (i < 3) do
                rgb.[i] <- 
                    if rgb.[i] <= 0.0031308
                    then 12.92 * rgb.[i]
                    else 1 + 0.055 * Math.Pow (rgb.[i], (1.0 / 2.4)) - 0.055
                i <- i + 1
                i
    [|(int (rgb.[0] * 255)); (int (rgb.[1] * 255)); (int (rgb.[2] * 255))|]