using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._04._Problem4
{
    class DocumentProcessor
    {
        class ActionCheckPair
        {
            public DocumentProcess Action { get; set; }
            //public Action<Document> Action { get; set; }

            public Check QuickCheck { get; set;}
            //public Predicate<Document> QuickCheck { get; set; }
        }
        private readonly List<ActionCheckPair> processes = new List<ActionCheckPair>();
        /*
        public List<ActionCheckPair> Processes
        {
            get
            {
                return processes;
            }
        }
        */

        public LogTextProvider LogTextProvider
        {
            get;
            set;
        }

        public void AddProcess (DocumentProcess action)
        {
            AddProcess(action, null);
        }
        public void AddProcess(DocumentProcess action, Check quickCheck)
        {
            processes.Add(new ActionCheckPair { Action = action, QuickCheck = quickCheck });
        }


        public event EventHandler Processing;
        public event EventHandler Processed;

        public void Process(Document doc)
        {
            OnProcessing(EventArgs.Empty);

            // First time, do the quick check
            foreach (ActionCheckPair process in processes)
            {
                if (process.QuickCheck != null && !process.QuickCheck(doc))
                {
                    Console.WriteLine("The process will not succeed.");
                    if (LogTextProvider != null)
                    {
                        Console.WriteLine(LogTextProvider(doc));
                    }
                    OnProcessed(EventArgs.Empty);
                    return;
                }
            }

            // Then perform the action
            foreach (ActionCheckPair process in processes)
            {
                process.Action(doc);
                if (LogTextProvider != null)
                {
                    Console.WriteLine(LogTextProvider(doc));
                }
            }
            OnProcessed(EventArgs.Empty);
        }
        private void OnProcessing(EventArgs e)
        {
            if (Processing != null)
            {
                Processing(this, e);
            }
        }
        private void OnProcessed(EventArgs e)
        {
            if (Processed != null)
            {
                Processed(this, e);
            }
        }
    }
}
