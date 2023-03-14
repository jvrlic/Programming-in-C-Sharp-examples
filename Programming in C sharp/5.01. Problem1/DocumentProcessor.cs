using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._01.Problem1
{
    static class DocumentProcessor
    {
        public static void Process(Document doc)
        {
            DocumentProcesses.TranslateIntoFrench(doc);
            DocumentProcesses.Spellcheck(doc);
            DocumentProcesses.Repaginate(doc);
        }
    }
}
