namespace _3._9._MyMethod
{
    class Program
    {
        public static void MyMethod( int firstOne, 
            double secondInLine = 3.1416, 
            string thirdHere = "The third parameter", 
            TimeSpan lastButNotLeast = default)
        {
            Console.WriteLine(firstOne);
            Console.WriteLine(secondInLine);
            Console.WriteLine(thirdHere);
            Console.WriteLine(lastButNotLeast);
        }

        static void Main(string[] args)
        {
            var doubleValue = 1.2d;

            MyMethod(127, thirdHere: "New third parameter");
            MyMethod(127, thirdHere: "New third parameter", secondInLine: doubleValue);
        }
    }
}