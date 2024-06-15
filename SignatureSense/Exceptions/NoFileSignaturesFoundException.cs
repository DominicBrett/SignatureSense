using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureSense.Exceptions
{
    public class NoFileSignaturesFoundException : Exception
    {
        public NoFileSignaturesFoundException(string message)
              : base(message)
        {
        }

        public NoFileSignaturesFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
