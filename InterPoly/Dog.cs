using System;
using System.Collections.Generic;
using System.Text;

namespace InterPoly
{
    class Dog : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
