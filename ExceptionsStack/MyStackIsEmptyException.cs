using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsStack
{
    class MyStackIsEmptyException : Exception
    {
        public MyStackIsEmptyException(string message) : base(message)
        {

        }



    }
}
