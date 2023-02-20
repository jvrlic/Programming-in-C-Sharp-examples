using (var times = File.OpenText("LapTimes.txt"))
{
    while (!times.EndOfStream)
    {
        var line = times.ReadLine() ?? string.Empty;
        var lapEndTime = double.Parse(line);
        Console.WriteLine(lapEndTime);
    }
}