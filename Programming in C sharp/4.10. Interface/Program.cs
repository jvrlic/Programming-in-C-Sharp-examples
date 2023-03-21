namespace _4._10._Interface
{
    interface INamedPerson
    {
        string Name
        {
            get;
        }
    }

    class Person : INamedPerson
    {
        public string Name
        {
            get;
            set;
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            INamedPerson p = new Person() { Name = "Pero" };
        }
    }
}