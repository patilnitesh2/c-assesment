using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiteshConsoleApp1
{

    internal class StackException : ApplicationException
    {
        public StackException() { }

        public StackException(string message)
            : base(message) { }

    }
}
