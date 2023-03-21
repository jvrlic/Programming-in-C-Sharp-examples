namespace X._05_Izrazi
{
    delegate bool del1(int a, int b);
    delegate bool del2(int a, string b);
    delegate void del3();

    class Program
    {
        static void SomeMethod()
        {
            Console.WriteLine("Test");
        }

        static void Main(string[] args)
        {
            del1 myDelegate1 = (x, y) => x == y;
            del2 myDelegate2 = (int x, string s) => s.Length > x;
            del3 myDelegate3 = () => SomeMethod();

            Console.WriteLine(myDelegate1(3.4, 3.4));
        }
    }
}