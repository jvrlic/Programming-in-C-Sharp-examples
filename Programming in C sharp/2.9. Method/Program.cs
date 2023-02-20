namespace _2._9._Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentLapStartTime = 0d;
            var fastestLapTime = 0d;

            foreach (var lapEndTime in ReadNumbersFromFile("LapTimes.txt"))
            {
                var lapTime = lapEndTime - currentLapStartTime;
                if (fastestLapTime == 0 || lapTime < fastestLapTime)
                {
                    fastestLapTime = lapTime;
                }
                currentLapStartTime = lapEndTime;
            }
            Console.WriteLine("Fastest lap time: " + fastestLapTime);
        }

        static double[] ReadNumbersFromFile(string fileName)
        {
            var numbers = new List<double>();
            using (var file = File.OpenText(fileName))
            {
                while (!file.EndOfStream)
                {
                    var line = file.ReadLine();
                    // Skip blank lines
                    if (!string.IsNullOrEmpty(line))
                    {
                        numbers.Add(double.Parse(line));
                    }
                }
            }
            return numbers.ToArray();
        }
    }
}