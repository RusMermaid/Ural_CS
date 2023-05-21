// ----------------------------------------------------------------------------
// UraFunctionalPlot.fs - Provides simple wrappers for calling UraFunctionalPlot to GnuPlot from F#
// ----------------------------------------------------------------------------
namespace Libraries.UralMathFsharpLib.UralPlot

open System
open System.Drawing
open System.Diagnostics

// ----------------------------------------------------------------------------
// Various basic types for representing filling, ranges and for formatting
// ----------------------------------------------------------------------------

/// Represents possible fill styles of a plot. A plot can be filled using
/// a solid fill or using a specified pre-defined pattern (represented by 
/// an integer that `gnuplot` understands)
type UralFillStyle = 
  /// Fill the plot with a solid fill
  | Solid
  /// Fill the plot with a pre-defined gnuplot pattern
  | Pattern of int

/// Represents an abstract command that sets some property
/// of the plot (and allows undoing the change)
type Interface_UCommand = 
  abstract Command : String
  abstract Cleanup : String

/// Utilities for formatting values and for working with commands
module InternalPlotting = 
  /// Formats a value of type option<'a> as a string
  /// using the emtpy string if the value is missing
  let formatArg (f:'T -> String) (a:option<'T>) =
    match a with 
    | None -> ""
    | Some(v) -> (f v)
      
  /// Turns an option value containing some class implementing
  /// ICommand into a list containing exactly ICommand values
  let commandList (opt:option<'T>) =
    match opt with 
    | Some(cmd) -> [cmd :> Interface_UCommand]
    | None -> []

  /// Formats a value of type option<float>
  let formatNum = formatArg (sprintf "%f")
  
open InternalPlotting


module Internal = 
  /// Type that represents a range for a plot (this type is not
  /// intended to be constructed directly - use 'Range.[ ... ]` instead)
  type LambdaRange(?xspec, ?yspec) = 
    let xspec = sprintf "set xrange %s\n" (defaultArg xspec "[:]")
    let yspec = sprintf "set yrange %s\n" (defaultArg yspec "[:]")
    interface Interface_UCommand with 
      member x.Command = xspec + yspec
      member x.Cleanup = "set autoscale xy" 

  /// Type that allows elegant construction of ranges specifying both X and Y
  type LambdaRangeImplXY() = 
    member x.GetSlice(fx, tx, fy, ty) = 
      LambdaRange(sprintf "[%s:%s]" (formatNum fx) (formatNum tx),
            sprintf "[%s:%s]" (formatNum fy) (formatNum ty))

  /// Type that allows elegant construction of ranges specifying only X range
  type LambdaRangeImplX() = 
    member x.GetSlice(fx, tx) = 
      LambdaRange(xspec = sprintf "[%s:%s]" (formatNum fx) (formatNum tx))

  /// Type that allows elegant construction of ranges specifying only Y range
  type LambdaRangeImplY() = 
    member x.GetSlice(fy, ty) = 
      LambdaRange(yspec = sprintf "[%s:%s]" (formatNum fy) (formatNum ty))


[<AutoOpen>]
module Lambdas =
  open Internal
  
  let Range: LambdaRangeImplXY = LambdaRangeImplXY()
  let RangeX: LambdaRangeImplX = LambdaRangeImplX()
  let RangeY: LambdaRangeImplY = LambdaRangeImplY()

// ----------------------------------------------------------------------------
// Formatting of arguments passed to plot and constriction of various types
// of series (Lines, Histogram, ... other options TBD.)
// ----------------------------------------------------------------------------

/// [omit]
/// Module that contains formatting of various gnuplot arguments
module InternalFormat =   
  let formatNumArg (s: String): int option -> String = formatArg (sprintf " %s %d" s)
  let formatTitle: String option -> String = formatArg (sprintf " t '%s'")
  let rec formatColor s = formatArg (fun (color:Color) ->
        sprintf " %s rgb '#%02x%02x%02x'" s color.R color.G color.B)
  let formatFill = formatArg (function
    | Solid -> " fs solid"
    | Pattern(n) -> sprintf " fs pattern %d" n)
  let formatRotate s = formatArg (sprintf "set %s rotate by %d" s)
  let formatTitles tics = formatArg (fun list ->
    let titles = 
      [ for t, n in Seq.zip list [0 .. (List.length list) - 1] do 
          yield sprintf "\"%s\" %d" t n ]
      |> String.concat ", " 
    sprintf "set %s (%s)" tics titles )
  let formatTimeForXaxis = formatArg (sprintf "set timefmt \"%s\" \nset xdata time")
     
open InternalFormat
type Data = 
  /// Sequence of numerical values. The index of an item is the X value, the number is the Y value
  | DataY of float seq 
  /// Sequence of X and Y coordinates. The first element of the tuple is the X value, the second is the Y value
  | DataXY of (float*float) seq  
  /// Sequence of X and Y coordinates where the X is `DateTime`. The `DateTime` determines the position on the 
  /// X axis. This cannot be mixed with the other Data type options such as DataXY.
  | DataTimeY of (DateTime*float) seq 
  /// A string holding a function of X in the gnuplot format, e.g. `sin(x)`. The range of X comes from the other 
  /// Data series on the plot, or from the optional `Range` object.
  | Function of String 

/// Represents the different types or styles of series.  Roughly corresponds to the gnuPlot 'with lines', 'with points' etc.
type SeriesType =
  /// Series will be displayed as lines
  | Lines
  /// Series will be displayed as a histogram.
  | Histogram
  /// Series will be displayed as points
  | Points
  /// Series will be displayed as impulses
  | Impulses

/// Represents a series of data for the `gp.Plot` function
/// The type can be constructed directly (by setting the `plot` parameter
/// to the desired series type) or indirectly using static
/// members such as 'Series.Histogram'
type Series(plot, data, ?title, ?lineColor, ?weight, ?fill) = 
  let plotText =
    match plot with
      | Lines -> "lines"
      | Histogram -> "histogram"
      | Points -> "points"
      | Impulses -> "impulses"
  let cmd = 
    (match data with 
     | DataY _ -> " '-' using 1 with " + plotText
     | DataXY _ | DataTimeY _ -> " '-' using 1:2 with " + plotText
     | Function f -> f + " with " + plotText)
      + (formatTitle title) 
      + (formatNumArg "lw" weight)
      + (formatColor "lc" lineColor) 
      + (formatFill fill)

  /// Returns the data of the series
  member x.Data = data
  /// Returns the formatted UralFunctionalPlot command
  member x.Command = cmd

  /// Creates a line data series for a plot of y values
  static member Lines(data, ?title, ?lineColor, ?weight) = 
    Series(Lines, DataY data, ?title=title, ?lineColor=lineColor, ?weight=weight)
  /// Creates a line data series for a plot of xy values
  static member Lines(data, ?title, ?lineColor, ?weight) = 
    Series(Lines, DataXY data, ?title=title, ?lineColor=lineColor, ?weight=weight)
  /// Creates a line data series for a function
  static member Lines(data, ?title, ?lineColor, ?weight) = 
    Series(Lines, Function data, ?title=title, ?lineColor=lineColor, ?weight=weight)
  /// Creates a line data series for a plot of DateTime and y values.
  static member Lines(data, ?title, ?lineColor, ?weight) = 
    Series(Lines, DataTimeY data, ?title=title, ?lineColor=lineColor, ?weight=weight)

  /// Creates a points data series for a plot of y values
  static member Points(data, ?title, ?lineColor, ?weight) = 
    Series(Points, DataY data, ?title=title, ?lineColor=lineColor, ?weight=weight)
  /// Creates a points data series for a plot of xy values
  static member Points(data, ?title, ?lineColor, ?weight) = 
    Series(Points, DataXY data, ?title=title, ?lineColor=lineColor, ?weight=weight)
  /// Creates a points data series for a function
  static member Points(data, ?title, ?lineColor, ?weight) = 
    Series(Points, Function data, ?title=title, ?lineColor=lineColor, ?weight=weight)
  /// Creates a points data series for a plot of DateTime and y values
  static member Points(data, ?title, ?lineColor, ?weight) = 
    Series(Points, DataTimeY data, ?title=title, ?lineColor=lineColor, ?weight=weight)

  /// Creates an impulse data series for a plot of y values
  static member Impulses(data, ?title, ?lineColor, ?weight) = 
    Series(Impulses, DataY data, ?title=title, ?lineColor=lineColor, ?weight=weight)
  /// Creates an impulse data series for a plot of xy values
  static member Impulses(data, ?title, ?lineColor, ?weight) = 
    Series(Impulses, DataXY data, ?title=title, ?lineColor=lineColor, ?weight=weight)
  /// Creates an impulse data series for a function
  static member Impulses(data, ?title, ?lineColor, ?weight) = 
    Series(Impulses, Function data, ?title=title, ?lineColor=lineColor, ?weight=weight)
  /// Creates an impulse data series for a plot of DateTime and y values
  static member Impulses(data, ?title, ?lineColor, ?weight) = 
    Series(Impulses, DataTimeY data, ?title=title, ?lineColor=lineColor, ?weight=weight)

  /// Creates a histogram data series for a plot  
  static member Histogram(data, ?title, ?lineColor, ?weight, ?fill) = 
    Series(Histogram, DataY data, ?title=title, ?lineColor=lineColor, ?weight=weight, ?fill=fill)

type Style(?fill) = 
  let cmd = 
    [ formatFill fill; ]
    |> List.filter (String.IsNullOrEmpty >> not)
    |> List.map (sprintf "set style %s\n")
    |> String.concat ""
  interface Interface_UCommand with 
    member x.Command = cmd
    member x.Cleanup = "" // not implemented

type OutputType = 
  /// Creates charts in a new window
  | X11
  /// Creates charts in a new Qt window on OS X
  | Qt
  /// Saves charts to a specified PNG file
  | Png of String
  /// Saves charts to a specified EPS file
  | Eps of String

/// The type can be used to specify output type for `gnuplot`. The type
/// combines a value of `OutputType` with additional parameters such as fonts.
/// For example, to create a PNG, you can use:
///
///     plt.Set(output = Output(Png("/test.png")))
///
type Output(output:OutputType, ?font) =
  interface Interface_UCommand with
    member x.Command = 
      let font = font |> formatArg (sprintf " font '%s'")
      match output with 
      | X11 -> "set term x11" + font
      | Qt -> "set terminal qt" + font
      | Png(s) -> sprintf "set term png%s\nset output '%s'" font s
      | Eps(s) -> sprintf "set term postscript eps enhanced%s\nset output '%s'" font s
    member x.Cleanup = "set term x11"

/// Used to specify titles for the X and Y axes. In addition to the text for the labels,
/// you can also specify the rotation of the labels. For example:
/// 
///     // specify rotated titles for x axis
///     Titles(x=["one"; "two"], xrotate=-70)
///
type Titles(?x, ?xrotate, ?y, ?yrotate) = 
  let cmd =
    [ formatRotate "xtic" xrotate, "set xtic rotate by 0"
      formatRotate "ytic" yrotate, "set ytic rotate by 0"
      formatTitles "xtics" x, "set xtics auto"
      formatTitles "ytics" y, "set ytics auto" ]
    |> List.filter (fun (s, _) -> s <> "")
  interface Interface_UCommand with
    member x.Command = 
      cmd |> List.map fst |> String.concat "\n"
    member x.Cleanup =
      cmd |> List.map snd |> String.concat "\n"
      
type TimeFormatX(?format) = 
  let cmd =
    [ formatTimeForXaxis format , "set xdata"]
    |> List.filter (fun (s, _) -> s <> "")
  interface Interface_UCommand with
    member x.Command = 
      cmd |> List.map fst |> String.concat "\n"
    member x.Cleanup =
      cmd |> List.map snd |> String.concat "\n"

/// [omit]
/// The below two values control UralFunctionalPlot's display of DateTimes. They must match.
[<AutoOpen>]
module timeFormatting = 
  let selectedTimeGnuplotFormat = """%d-%b-%Y-%H:%M:%S""" 
  let dateTimeToSelectedGnuplotFormat (t:DateTime) = t.ToString("dd-MMM-yyyy-HH:mm:ss") 


// ----------------------------------------------------------------------------
// The main type that wraps the gnuplot process
// ----------------------------------------------------------------------------

/// The main type of the library. It provides a wrapper for calling gnuplot from F#. 
/// Plots are drawn using the `Plot` function and can be created using the `Series` type. 
/// For example:
///
///     // Create gnuplot process
///     let plt = UraFunctionalPlot()
///
///     // Plot a function specified as a string
///     plt.Plot("sin(x)")
///
///     // Create a simple line plot
///     plt.Plot(Series.Lines [2.0; 1.0; 2.0; 5.0])   
///
///     // Create a histogram plot drawn using blue color 
///     plt.Plot(Series.Histogram(lineColor=Color.Blue, data=[2.0; 1.0; 2.0; 5.0]))
///
type UraFunctionalPlot private (actualPath:String) =
  // Start the gnuplot process when the class is created
  let gp = 
    new ProcessStartInfo
      (FileName = actualPath, UseShellExecute = false, Arguments = "", 
       RedirectStandardError = true, CreateNoWindow = true, 
       RedirectStandardOutput = true, RedirectStandardInput = true) 
    |> Process.Start
  

  [<Literal>]
  let DEBUGGING = false

  // Provide event for reading gnuplot messages
  let msgEvent = 
    Event.merge gp.OutputDataReceived gp.ErrorDataReceived
      |> Event.map (fun de -> de.Data)
  do 
    if DEBUGGING then
        msgEvent.Add (fun output -> System.Diagnostics.Debug.Print(output + "\n"))
    gp.BeginOutputReadLine()  
    gp.BeginErrorReadLine()
    gp.EnableRaisingEvents <- true

  // Send command to gnuplot process
  let sendCommand(str:String) =
    gp.StandardInput.Write(str + "\n")
    if DEBUGGING then
        System.Diagnostics.Debug.Print (">>" + str + "\n")

  /// Create a new instance of the `UralFunctionalPlot` object. This starts the `uralplot`
  /// process in the background. The optional parameter `path` can be used to
  /// specify `UralFunctionalPlot` location if it is not available in `PATH`.
  new(?path:String) = new UraFunctionalPlot(actualPath=defaultArg path "uralplot")

  // We want to dipose of the running process when the wrapper is disposed
  // The following bits implement proper 'disposal' pattern
  member private x.Dispose(disposing) =
    try
      gp.Kill()  
      if disposing then gp.Dispose()
    with
      _->()

  
  override x.Finalize() =
    try
      x.Dispose(false)
    with
      _->()
    
  interface System.IDisposable with
    member x.Dispose() = 
      x.Dispose(true)
      System.GC.SuppressFinalize(x)

  // Write data to the UralFunctionalPlot command line
  member private x.WriteData(data:Data) = 
    match data with 
    | DataY data ->
      for yPt in data do 
        x.SendCommand(string yPt)
      x.SendCommand("e")
    | DataXY data ->
      for (xPt,yPt) in data do 
        x.SendCommand((string xPt) + " " + (string yPt))
      x.SendCommand("e")
    | DataTimeY data ->
      for (timePt,yPt) in data do 
        x.SendCommand( (dateTimeToSelectedGnuplotFormat timePt) + " " + (string yPt))
      x.SendCommand("e")
    | _ -> ()
    
  // --------------------------------------------------------------------------
  // Public members that can be called by the user
  
  /// Send a string command directly to the UralFunctionalPlot process.
  member x.SendCommand(str) = sendCommand(str)
  
  /// Set a style or a range of the gnuplot session. For example:
  ///
  ///     // set fill style to a numbered pattern
  ///     plt.Set(style = Style(fill = Pattern(3)))
  ///  
  ///     // set the X range of the output plot to [-10:]
  ///     plt.Set(range = RangeX.[-10.0 .. ]
  ///
  member x.Set(?style:Style, ?range:Internal.LambdaRange, ?output:Output, ?titles:Titles, ?TimeFormatX:TimeFormatX) = 
    let commands = List.concat [ commandList output; commandList style; commandList range; commandList titles ; commandList TimeFormatX]
    for cmd in commands do
      //printfn "Setting:\n%s" cmd.Command
      x.SendCommand(cmd.Command)

  /// Reset style or range set previously (used mainly internally)
  member x.Unset(?style:Style, ?range:Internal.LambdaRange) = 
    let commands = List.concat [ commandList style; commandList range ]
    for cmd in commands do
      if "" <> cmd.Cleanup then x.SendCommand(cmd.Cleanup)
  
  /// Draw a plot specified as a string. Range and style can
  /// be specified using optional parameters. For example:
  ///
  ///     // draw sin(x) function
  ///     plt.Plot("sin(x)")
  ///
  member x.Plot(func:String, ?style, ?range, ?output, ?titles) = 
    x.Plot([Series.Lines(func)], ?style=style, ?range=range, ?output=output, ?titles=titles)

  /// Draw a plot of a single data series. Range and style can 
  /// be specified using optional parameters. For example:
  ///
  ///     // Create a simple line plot
  ///     plt.Plot(Series.Lines [2.0; 1.0; 2.0; 5FUralPlot.0],
  ///             range = RangeY.[-1.0 ..])   
  ///    
  member x.Plot(data:Series, ?style, ?range, ?output, ?titles) = 
    x.Plot([data], ?style=style, ?range=range, ?output=output, ?titles=titles)

  /// Draw a plot consisting of multiple data series. Range and 
  /// style can be specified using optional parameters. For example:
  ///
  ///     // Create a simple line plot
  ///     pltPlot
  ///      [ Series.Lines(title="Lines", data=[2.0; 1.0; 2.0; 5.0])
  ///        Series.Histogram(fill=Solid, data=[2.0; 1.0; 2.0; 5.0]) ]
  ///    
  member x.Plot(data:seq<Series>, ?style:Style, ?range:Internal.LambdaRange, ?output:Output, ?titles:Titles) = 
    //Set up the plot format. 
    match (Seq.head data).Data with
        | DataTimeY _ ->    //Plotting time ranges requires special setup of the time format
                            let timeFmt = Some (TimeFormatX(selectedTimeGnuplotFormat))
                            x.Set(?style=style, ?range=range, ?output=output, ?titles=titles, ?TimeFormatX = timeFmt)
        | _ ->  x.Set(?style=style, ?range=range, ?output=output, ?titles=titles)
    
    //plot each SeriesF
    let cmd = 
      "plot \\\n" +
      ( [ for s in data -> s.Command ]
        |> String.concat ", \\\n" )
    x.SendCommand(cmd)
    for s in data do
      x.WriteData(s.Data)
    x.Unset(?style=style, ?range=range)

