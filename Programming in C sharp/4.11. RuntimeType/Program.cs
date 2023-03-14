namespace _4._11._RuntimeType
{
    interface INamedPerson
    {
        string Name
        {
            get;
        }
    }

    public class Person : INamedPerson
    {
        public Person(string name)
        {
            _name = name;
        }
        private string _name;
        public string Name  // read-write instance property
        {
            get
            {
                return _name;
            }
        }
    }

    class Program
    {
        public static void ClockIn(object item)
        {
            if (item is INamedPerson)
            {
                ClockIn(item as INamedPerson);
            }
            else
            {
                Console.WriteLine("We can't check in a '{0}'", item.GetType());
            }
        }
        public static void ClockIn(INamedPerson item)
        {
            Console.WriteLine(item.Name);
        }


        static void Main(string[] args)
        {
            object o = new object();
            object a = new Person("Pero");

            ClockIn(o);
            ClockIn(a);
        }
    }
}