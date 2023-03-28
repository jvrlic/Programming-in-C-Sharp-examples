namespace _7._04._InlineArray
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
            return numberedNames;
        }

        static void Main(string[] args)
        {
            var result = AddNumbers(new string[] { "The Jazz Devil", "Jitterbugs" });

            var inputString = "This is test, and everything  is  well . But, ... ";
            var items = inputString.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string i in items)
                Console.WriteLine(i);
            //public string[] Split(params char[] separator) ...
        }
    }
}