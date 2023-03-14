using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._04.Problem4
{
    class ProductionDeptTool1
    {
        public void Subscribe(DocumentProcessor processor)
        {
            processor.Processing += processor_Processing;
            processor.Processed += processor_Processed;
        }
        public void Unsubscribe(DocumentProcessor processor)
        {
            processor.Processing -= processor_Processing;
            processor.Processed -= processor_Processed;
        }
        void processor_Processing(object sender, EventArgs e)
        {
            Console.WriteLine("Tool1 has seen processing.");
        }
        void processor_Processed(object sender, EventArgs e)
        {
            Console.WriteLine("Tool1 has seen that processing is complete.");
        }
    }
    class ProductionDeptTool2
    {
        public void Subscribe(DocumentProcessor processor)
        {
            processor.Processing +=
            (sender, e) => Console.WriteLine("Tool2 has seen processing.");
            processor.Processed +=
            (sender, e) =>
            Console.WriteLine("Tool2 has seen that processing is complete.");
        }
    }
}
