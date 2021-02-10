using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsStack
{
    class MyStackIsFullException : Exception
    {
        public MyStackIsFullException(string message) : base(message)
        {
                
        }
    }
}
