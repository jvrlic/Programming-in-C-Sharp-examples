namespace _5._02._Problem2
{
    class Program
    {
        static DocumentProcessor Configure()
        {
            var rc = new DocumentProcessor();
            rc.Processes.Add(new TranslateIntoFrenchProcess());
            rc.Processes.Add(new SpellcheckProcess());
            rc.Processes.Add(new RepaginateProcess());
            return rc;
        }

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

            var processor = Configure();
            Console.WriteLine("Processing document 1");
            processor.Process(doc1);
            Console.WriteLine();
            Console.WriteLine("Processing document 2");
            processor.Process(doc2);
            Console.ReadKey();
        }
    }
}