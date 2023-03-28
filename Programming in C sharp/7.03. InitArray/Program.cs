namespace _7._03._InitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] eventNames =
                {
                "Dean Collins Shim Sham Lesson",
                "Intermediate Lindy Hop Lesson",
                "Wild Times - Social Dancing at Wild Court"
                };

            /*
            // Won't compile!
            eventNames =
            {
            "Dean Collins Shim Sham Lesson",
            "Intermediate Lindy Hop Lesson",
            "Wild Times - Social Dancing at Wild Court"
            };
            */

            // Will compile!
            eventNames = new string[]
                {
                "Dean Collins Shim Sham Lesson",
                "Intermediate Lindy Hop Lesson",
                "Wild Times - Social Dancing at Wild Court"
                };

        }
    }
}