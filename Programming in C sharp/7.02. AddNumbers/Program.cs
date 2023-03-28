namespace _7._02._AddNumbers
{
    class Program
    {
        static string[] AddNumbers(string[] names)
        {
            var numberedNames = new string[names.Length];
            for (var i = 0; i < names.Length; ++i)
            {
                numberedNames[i] = string.Format("{0}: {1}", i, names[i]);
            }

            var listNumbered = new List<string>();
            var index = 0;
            foreach (var s in names)
            {
                listNumbered.Add(string.Format("{0}: {1}", index++, s));
            }


            return listNumbered.ToArray();
        }

        static void Main(string[] args)
        {
            string[] eventNames =
            {
                "Swing Dancing at the South Bank",
                "Saturday Night Swing",
                "Formula 1 German Grand Prix",
                "Swing Dance Picnic",
                "Stompin' at the 100 Club"
            };

            var numEvents = AddNumbers(eventNames);

            foreach (string str in numEvents)
                Console.WriteLine(str);
        }
    }
}