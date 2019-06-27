using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeExceptions
{
    public class BornException : Exception
    {
        public BornException()
            : base() { }
        public BornException(string message)
            : base(message) { }
    }
}
