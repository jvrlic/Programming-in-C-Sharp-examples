using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _6._07.Turtle6
{
    [Serializable]
    class TurtleException : Exception
    {
        public TurtleException()
        { }
        public TurtleException(string message)
            : base(message)
        { }
        public TurtleException(string message, Exception innerException)
            : base(message, innerException)
        { }
        // For serialization support
        protected TurtleException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}
