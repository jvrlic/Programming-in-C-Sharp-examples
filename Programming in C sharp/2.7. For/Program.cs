var lines = File.ReadAllLines("LapTimes.txt");
var currentLapStartTime = 0d;
var fastestLapTime = 0d;
var fastestLapNumber = 0d;

for (var lapNumber = 1; lapNumber <= lines.Length; lapNumber++)
{
    var lapEndTime = double.Parse(lines[lapNumber - 1]);
    var lapTime = lapEndTime - currentLapStartTime;
    if (fastestLapTime == 0 || lapTime < fastestLapTime)
    {
        fastestLapTime = lapTime;
        fastestLapNumber = lapNumber;
    }
    currentLapStartTime = lapEndTime;
}

Console.WriteLine("Fastest lap: " + fastestLapNumber);
Console.WriteLine("Fastest lap time: " + fastestLapTime);