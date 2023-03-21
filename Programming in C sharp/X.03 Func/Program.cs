namespace X._03_Func
{
    delegate string ConvertMethod(string inString);

    class Program
    {
        private static string UppercaseString(string inputString)
        {
            return inputString.ToUpper();
        }
        private static string UppercaseString1(string inputString, int x)
        {
            return inputString.ToUpper();
        }



        static void Main(string[] args)
        {
            // Instantiate delegate to reference UppercaseString method
            //ConvertMethod convertMethod = UppercaseString;
            Func<string, string> convertMethod = UppercaseString;
            //Func<string, string> convertMethod = delegate(string s)
            //{ return s.ToUpper(); };
            //Func<string, string> convertMethod = s => s.ToUpper();
            Func<string, int, string> test = UppercaseString1;

            var name = "Dakota";
            // Use delegate instance to call UppercaseString method
            Console.WriteLine(convertMethod(name));


            // Declare a Func variable and assign a lambda expression to the   
            // variable. The method takes a string and converts it to uppercase.
            Func<string, string> selector = str => str.ToUpper();

            // Create an array of strings. 
            string[] words = { "orange", "apple", "Article", "elephant" };
            // Query the array and select strings according to the selector method.
            IEnumerable<String> aWords = words.Select(selector);

            // Output the results to the console. 
            foreach (String word in aWords)
                Console.WriteLine(word);

        }
    }
}