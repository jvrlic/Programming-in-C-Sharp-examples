namespace X._04_Kvadriranje
{
    delegate int del(int i);

    class Program
    {
        static void Main(string[] args)
        {
            del myDelegate = x => x * x;
            var j = myDelegate(5); //j = 25
        }
    }
}