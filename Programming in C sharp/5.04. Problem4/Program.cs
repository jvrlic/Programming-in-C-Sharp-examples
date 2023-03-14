namespace _5._04._Problem4
{
    class Program
    {

        static DocumentProcessor Configure()
        {
            DocumentProcessor rc = new DocumentProcessor();
            rc.AddProcess(DocumentProcesses.TranslateIntoFrench,
                delegate (Document doc)
                {
                    return !doc.Text.Contains("?");
                });
            rc.AddProcess(DocumentProcesses.Spellcheck);
            rc.AddProcess(DocumentProcesses.Repaginate);
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
            Document doc3 = new Document
            {
                Author = "Matthew Adams",
                DocumentDate = new DateTime(2002, 01, 01),
                Text = "Another year, another document."
            };

            string documentBeingProcessed = null;

            DocumentProcessor processor = Configure();
            processor.LogTextProvider = (Document => documentBeingProcessed);



            ProductionDeptTool1 tool1 = new ProductionDeptTool1();
            tool1.Subscribe(processor);
            ProductionDeptTool2 tool2 = new ProductionDeptTool2();
            tool2.Subscribe(processor);


            documentBeingProcessed = "(Document 1)";
            processor.Process(doc1);
            Console.WriteLine();
            documentBeingProcessed = "(Document 2)";
            processor.Process(doc2);
            Console.WriteLine();
            documentBeingProcessed = "(Document 3)";
            processor.Process(doc3);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}