namespace X._08_Query
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> myFunc = x => x == 5;
            var result = myFunc(4); // returns false of course

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var oddNumbers = numbers.Count(n => n % 2 == 1);

            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

            var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);
        }
    }
}