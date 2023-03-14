namespace _3._1._Plane1
{
    class Plane
    {
        public string Identifier { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var someBoeing777 = new Plane
            {
                Identifier = "BA0049"
            };
            //someBoeing777.Identifier = "BA0049";
            //Console.WriteLine("Your plane has identifier {0}", someBoeing777.Identifier);
            Console.WriteLine($"Your plane has identifier {someBoeing777.Identifier}");
            // Wait for the user to press a key, so
            // that we can see what happened
            Console.ReadKey();
        }
    }
}