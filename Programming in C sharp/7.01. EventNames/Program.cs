namespace _7._01._EventNames
{
    class Program
    {
        static string GenerateString()
        {
            return "Sting";
        }

        static string GenerateString1() => "String";



        static void Main(string[] args)
        {
            string[] testArray = null;
            var testArray1 = new string[10];
            string[] eventNames =
                {
                "Swing Dancing at the South Bank",
                "Saturday Night Swing",
                "Formula 1 German Grand Prix",
                "Swing Dance Picnic",
                "Stompin' at the 100 Club"
                };

            Console.WriteLine(testArray);
            Console.WriteLine(testArray.Length);
            foreach (var str in eventNames)
                Console.WriteLine(str);
        }
    }
}