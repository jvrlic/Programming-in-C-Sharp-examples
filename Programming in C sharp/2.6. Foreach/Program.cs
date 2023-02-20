//var lines = File.ReadAllLines("LapTimes.txt");
var lines = new string[] { "10", "20", "30" };
var currentLapStartTime = 0d;
var fastestLapTime = 0d;

foreach (var line in lines)
{
    var lapEndTime = double.Parse(line);
    var lapTime = lapEndTime - currentLapStartTime;
    if (fastestLapTime == 0 || lapTime < fastestLapTime)
    {
        fastestLapTime = lapTime;
    }
    currentLapStartTime = lapEndTime;
}
Console.WriteLine($"Fastest lap time: {fastestLapTime}");