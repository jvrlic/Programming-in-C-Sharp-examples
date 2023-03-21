using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._05._Problem5
{
    delegate void DocumentProcess(Document doc);

    delegate bool Check(Document doc);

    delegate string LogTextProvider(Document doc);


    /*
    abstract class DocumentProcess
    {
        public abstract void Process(Document doc);
    }

    class SpellcheckProcess : DocumentProcess
    {
        public override void Process(Document doc)
        {
            DocumentProcesses.Spellcheck(doc);
        }
    }

    class RepaginateProcess : DocumentProcess
    {
        public override void Process(Document doc)
        {
            DocumentProcesses.Repaginate(doc);
        }
    }
    class TranslateIntoFrenchProcess : DocumentProcess
    {
        public override void Process(Document doc)
        {
            DocumentProcesses.TranslateIntoFrench(doc);
        }
    }
     * */
}
