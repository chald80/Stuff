using System;
using System.Collections.Generic;
using System.Text;

namespace InterPoly
{
    class Philosopher : ISpeak
    {
        public void Think()
        {
            Console.WriteLine("I think, there for I am");
        }
        public void Speak()
        {
            Console.WriteLine("Hallo world");
        }
    }
}
