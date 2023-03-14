using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._05.Problem5
{
    class DocumentProcessor
    {
        class ActionCheckPair
        {
            //public DocumentProcess Action { get; set; }
            public Action<Document> Action { get; set; }

            public Check QuickCheck { get; set;}
            //public Predicate<Document> QuickCheck { get; set; }
        }
        private readonly List<ActionCheckPair> processes = new List<ActionCheckPair>();

        public LogTextProvider LogTextProvider
        {
            get;
            set;
        }

        public void AddProcess (Action<Document> action)
        {
            AddProcess(action, null);
        }
        public void AddProcess(Action<Document> action, Check quickCheck)
        {
            processes.Add(new ActionCheckPair { Action = action, QuickCheck = quickCheck });
        }


        public event EventHandler<ProcessEventArgs> Processing;
        public event EventHandler<ProcessEventArgs> Processed;

        public void Process(Document doc)
        {
            ProcessEventArgs e = new ProcessEventArgs(doc);
            OnProcessing(e);

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
                    OnProcessed(e);
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
            OnProcessed(e);
        }
        private void OnProcessing(ProcessEventArgs e)
        {
            if (Processing != null)
            {
                Processing(this, e);
            }
        }
        private void OnProcessed(ProcessEventArgs e)
        {
            if (Processed != null)
            {
                Processed(this, e);
            }
        }
    }
}
