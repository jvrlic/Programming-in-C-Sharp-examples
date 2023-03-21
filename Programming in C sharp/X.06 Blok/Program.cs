namespace X._06_Blok
{
    delegate void TestDelegate(string s);

    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate myDel = n => { string s = n + " " + "World"; Console.WriteLine(s); };
            myDel("Hello");
        }
    }
}