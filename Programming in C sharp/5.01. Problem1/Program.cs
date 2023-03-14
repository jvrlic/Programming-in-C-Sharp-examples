using _5._01.Problem1;

namespace _5._01._Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doc1 = new Document
            {
                Author = "Matthew Adams",
                DocumentDate = new DateTime(2000, 01, 01),
                Text = "Am I a year early?"
            };
            var doc2 = new Document
            {
                Author = "Ian Griffiths",
                DocumentDate = new DateTime(2001, 01, 01),
                Text = "This is the new millennium, I promise you."
            };
            Console.WriteLine("Processing document 1");
            DocumentProcessor.Process(doc1);
            Console.WriteLine();
            Console.WriteLine("Processing document 2");
            DocumentProcessor.Process(doc2);
            Console.ReadKey();
        }
    }
}