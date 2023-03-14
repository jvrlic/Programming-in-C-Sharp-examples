using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._05.Problem5
{
    class ProcessEventArgs : EventArgs
    {
        // Handy constructor
        public ProcessEventArgs(Document document)
        {
            Document = document;
        }
        // The extra property
        // We don't want subscribers to be able
        // to update this property, so we make
        // it private
        // (Of course, this doesn't prevent them
        // from changing the Document itself)

        public Document Document
        {
            get;
            private set;
        }
    }
}
