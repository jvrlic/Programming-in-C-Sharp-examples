namespace X._02_Predicate
{
    public class HockeyTeam
    {
        private string _name;
        private int _founded;

        public HockeyTeam(string name, int year)
        {
            _name = name;
            _founded = year;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Founded
        {
            get { return _founded; }
        }
    }

    class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        private static bool FindPoints(Point obj)
        {
            return obj.X * obj.Y > 100000;
        }

        static void Main(string[] args)
        {
            var rnd = new Random();
            var teams = new List<HockeyTeam>();
            teams.AddRange(new HockeyTeam[] { new HockeyTeam("Detroit Red Wings", 1926),
                                         new HockeyTeam("Chicago Blackhawks", 1926),
                                         new HockeyTeam("San Jose Sharks", 1991),
                                         new HockeyTeam("Montreal Canadiens", 1909),
                                         new HockeyTeam("St. Louis Blues", 1967) });

            int[] years = { 1920, 1930, 1980, 2000 };

            var foundedBeforeYear = years[rnd.Next(0, years.Length)];

            Console.WriteLine("Teams founded before {0}:", foundedBeforeYear);

            foreach (var team in teams.FindAll(x => x.Founded <= foundedBeforeYear))
                Console.WriteLine("{0}: {1}", team.Name, team.Founded);

            teams.FindAll(x => x.Founded <= foundedBeforeYear)
                .ForEach(x => Console.WriteLine("{0}: {1}", x.Name, x.Founded));


            
            // Create an array of Point structures.
            Point[] points = { new Point(100, 200), 
                         new Point(150, 250), new Point(250, 375), 
                         new Point(275, 395), new Point(295, 450) };

            // Define the Predicate<T> delegate.
            Predicate<Point> predicate = FindPoints;

            // Find the first Point structure for which X times Y   
            // is greater than 100000. 
            var first = Array.Find(points, predicate);
            //Point first = Array.Find(points, x => x.X * x.Y > 100000);

            // Display the first structure found.
            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);          
            
        }
    }
}