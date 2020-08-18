using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class ResponseNotFoundException : Exception
    {
        public ResponseNotFoundException()
        {
        }

        public ResponseNotFoundException(string message)
            : base(message)
        {
        }

        public ResponseNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
    
