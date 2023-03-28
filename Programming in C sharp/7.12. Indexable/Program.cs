namespace _7._12._Indexable
{
    class Indexable
    {
        public string this[string index]
        {
            get
            {
                return "Item " + index;
            }
            set
            {
                Console.WriteLine("You set item " + index + " to " + value);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var ix = new Indexable();
            Console.WriteLine(ix["test"]);
            ix["opet"] = "Xyzzy";
        }
    }
}