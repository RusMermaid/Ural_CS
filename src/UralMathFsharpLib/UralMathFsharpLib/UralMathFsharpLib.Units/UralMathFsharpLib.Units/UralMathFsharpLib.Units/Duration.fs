/// <category>Module: Unit System</category>
///  A <c>Duration</c> refers to an elapsed time in seconds, milliseconds, hours etc.,
/// as opposed to a specific instant in time (which would generally be represented
/// by a <see cref="System.DateTime"/>. value). It is stored as a number of seconds.

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module UralMathFsharpLib.Units.Duration

open UralMathFsharpLibUnits

/// <category index="1">Conversions</category>
/// <summary>
/// Construct a <c>Duration</c> from a given number of seconds.
/// </summary>
let seconds (numSeconds: float) : Duration = Quantity numSeconds


/// <category>Conversions</category>
/// <summary>
/// Convert a <c>1</c> to a value in seconds.
/// </summary>
///
/// <example><code>
///    Duration.milliseconds 10 |&gt; Duration.inSeconds
///    --&gt; 0.01
/// </code></example>
let inSeconds (numSeconds: Duration) : float = numSeconds.Value

/// <category>Conversions</category>
/// <summary>
/// Construct a <c>Duration</c> from a given number of milliseconds.
/// </summary>
///
/// <example><code>
///    Duration.milliseconds 5000
///    --&gt; Duration.seconds 5
/// </code></example>
let milliseconds (numMilliseconds: float) : Duration = seconds (0.001 * numMilliseconds)


/// <category>Conversions</category>
/// <summary>
/// Convert a <c>Duration</c> to a value in milliseconds.
/// </summary>
///
/// <example><code>
///    Duration.seconds 0.5 |&gt; Duration.inMilliseconds
///    --&gt; 500
/// </code></example>
let inMilliseconds (duration: Duration) : float = inSeconds duration * 1000.


/// <category>Conversions</category>
/// <summary>
/// Construct a <c>Duration</c> from a given number of minutes.
/// </summary>
///
/// <example><code>
///    Duration.minutes 3
///    --&gt; Duration.seconds 180
/// </code></example>
let minutes (numMinutes: float) : Duration = seconds (60. * numMinutes)


/// <category>Conversions</category>
/// <summary>
/// Convert a <c>Duration</c> to a value in minutes.
/// </summary>
///
/// <example><code>
///    Duration.seconds 90 |&gt; Duration.inMinutes
///    --&gt; 1.5
/// </code></example>
let inMinutes (duration: Duration) : float = inSeconds duration / 60.

/// <category>Conversions</category>
/// <summary>
/// Construct a <c>Duration</c> from a given number of hours.
/// </summary>
///
/// <example><code>
///    Duration.hours 1
///    --&gt; Duration.seconds 3600
/// </code></example>
let hours (numHours: float) : Duration = seconds (MetricConstants.hour * numHours)


/// <category>Conversions</category>
/// <summary>
/// Convert a <c>Duration</c> to a value in hours.
/// </summary>
///
/// <example><code>
///    Duration.minutes 120 |&gt; Duration.inHours
///    --&gt; 2
/// </code></example>
let inHours (duration: Duration) : float = inSeconds duration / MetricConstants.hour

/// <category>Conversions</category>
/// <summary>
/// Construct a <c>Duration</c> from a given number of days. A day is defined as
/// exactly 24 hours or 86400 seconds. Therefore, it is only equal to the length of
/// a given calendar day if that calendar day does not include either a leap second
/// or any added/removed daylight savings hours.
/// </summary>
///
/// <example><code>
///     Duration.days 1
///     --&gt; Duration.hours 24
/// </code></example>
let days (numDays: float) : Duration = seconds (MetricConstants.day * numDays)

/// <category>Conversions</category>
/// <summary>
/// Convert a <c>Duration</c> to a value in days.
/// </summary>
///
/// <example><code>
///    Duration.hours 72 |&gt; Duration.inDays
///    --&gt; 3
/// </code></example>
let inDays (duration: Duration) : float = inSeconds duration / MetricConstants.day

/// <category>Conversions</category>
/// <summary>
/// Construct a <c>Duration</c> from a given number of weeks.
/// </summary>
///
/// <example><code>
///    Duration.weeks 1
///    --&gt; Duration.days 7
/// </code></example>
let weeks (numWeeks: float) : Duration = seconds (MetricConstants.week * numWeeks)

/// <category>Conversions</category>
/// <summary>
/// Convert a <c>Duration</c> to a value in weeks.
/// </summary>
///
/// <example><code>
///    Duration.days 28 |&gt; Duration.inWeeks
///    --&gt; 4
/// </code></example>
let inWeeks (duration: Duration) : float = inSeconds duration / MetricConstants.week

/// <category>Conversions</category>
/// <summary>
/// Construct a <c>Duration</c> from a given number of
/// <see href="https://en.wikipedia.org/wiki/Julian_year_(astronomy)">Julian years</see>
/// A Julian year is defined as exactly 365.25 days, the average length of a year in
/// the historical Julian calendar. This is 10 minutes and 48 seconds longer than
/// a Gregorian year (365.2425 days), which is the average length of a year in the
/// modern Gregorian calendar, but the Julian year is a bit easier to remember and
/// reason about and has the virtue of being the 'year' value used in the definition
/// of a <see href="https://en.wikipedia.org/wiki/Light-year">light year</see>].
/// </summary>
///
/// <example><code>
///     Duration.julianYears 1
///     --&gt; Duration.days 365.25
/// </code></example>
let julianYears (numJulianYears: float) : Duration =
    seconds (MetricConstants.julianYear * numJulianYears)

/// <category>Conversions</category>
/// <summary>
/// Convert a <c>Duration</c> to a value in Julian years.
/// </summary>
///
/// <example><code>
///    Duration.hours 10000 |&gt; Duration.inJulianYears
///    --&gt; 1.1407711613050422
/// </code></example>
let inJulianYears (duration: Duration) : float =
    inSeconds duration / MetricConstants.julianYear

/// <category>Constants</category>
/// One second
let second: Duration = seconds 1

/// <category>Constants</category>
/// One millisecond
let millisecond: Duration = milliseconds 1

/// <category>Constants</category>
/// One minute
let minute: Duration = minutes 1

/// <category>Constants</category>
/// One hour
let hour: Duration = hours 1

/// <category>Constants</category>
/// One day
let day: Duration = days 1

/// <category>Constants</category>
/// One week
let week: Duration = weeks 1

/// <category>Constants</category>
/// <summary>
/// One Julian Year
/// </summary>
///
/// <example><code>
///     Duration.julianYear
///     --&gt; Duration.days 365.25
/// </code></example>
let julianYear: Duration = julianYears 1
