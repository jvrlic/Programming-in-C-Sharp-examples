namespace _5._03._Problem3
{
    class Program
    {
        /*
        static DocumentProcessor Configure()
        {
            DocumentProcessor rc = new DocumentProcessor();
            rc.Processes.Add(new DocumentProcess(DocumentProcesses.TranslateIntoFrench));
            rc.Processes.Add(new DocumentProcess(DocumentProcesses.Spellcheck));
            rc.Processes.Add(new DocumentProcess(DocumentProcesses.Repaginate));
            return rc;
        }
        */

        static DocumentProcessor Configure()
        {
            DocumentProcessor rc = new DocumentProcessor();
            rc.Processes.Add(DocumentProcesses.TranslateIntoFrench);
            rc.Processes.Add(DocumentProcesses.Spellcheck);
            rc.Processes.Add(DocumentProcesses.Repaginate);
            return rc;
        }


        static void Main(string[] args)
        {
            Document doc1 = new Document
            {
                Author = "Matthew Adams",
                DocumentDate = new DateTime(2000, 01, 01),
                Text = "Am I a year early?"
            };
            Document doc2 = new Document
            {
                Author = "Ian Griffiths",
                DocumentDate = new DateTime(2001, 01, 01),
                Text = "This is the new millennium, I promise you."
            };

            DocumentProcessor processor = Configure();
            Console.WriteLine("Processing document 1");
            processor.Process(doc1);
            Console.WriteLine();
            Console.WriteLine("Processing document 2");
            processor.Process(doc2);
            Console.ReadKey();
        }
    }
}