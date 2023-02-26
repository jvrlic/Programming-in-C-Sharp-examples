namespace _3._2._Plane2
{
    class Plane
    {
        public string Identifier
        {
            get;
            private set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var someBoeing777 = new Plane();

            someBoeing777.Identifier = "BA0049";

            Console.WriteLine("Your plane has identifier {0}", someBoeing777.Identifier);

            Console.ReadKey();
        }
    }
}