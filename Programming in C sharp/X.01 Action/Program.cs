namespace X._01_Action
{
    internal class Program
    {
        delegate void DisplayMessage(string message);


        private static void ShowWindowsMessage(string message)
        {
            MessageBox.Show(message);
        }

        private static void Print(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            DisplayMessage messageTarget1;
            Action<string> messageTarget;

            if (Environment.GetCommandLineArgs().Length > 1)
            {
                messageTarget = ShowWindowsMessage;
                messageTarget = delegate(string s) { ShowWindowsMessage(s); };
                messageTarget = s => ShowWindowsMessage(s);
            }
            else
            {
                messageTarget = Print;
                // messageTarget = delegate(string s) { Console.WriteLine(s); };
                // messageTarget = s => Console.WriteLine(s);
            }

            messageTarget("Hello, World!");




            var names = new List<String>();
            names.Add("Bruce");
            names.Add("Alfred");
            names.Add("Tim");
            names.Add("Richard");

            // Display the contents of the list using the Print method.

            names.ForEach(Print);

            // The following demonstrates the anonymous method feature of C# 
            // to display the contents of the list to the console.
            names.ForEach(delegate (String name)
            {
                //Console.WriteLine(name);
                name = name.Substring(0, 1);
            });


            names.ForEach(Print);


        }

    }
}