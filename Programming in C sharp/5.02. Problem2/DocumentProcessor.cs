using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._02._Problem2
{
    class DocumentProcessor
    {
        private readonly List<DocumentProcess> processes = new List<DocumentProcess>();
        public List<DocumentProcess> Processes
        {
            get
            {
                return processes;
            }
        }
        public void Process(Document doc)
        {
            foreach (var process in Processes)
            {
                process.Process(doc);
            }
        }
    }
}
