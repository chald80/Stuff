using System;
using System.Collections.Generic;
using System.Text;

namespace InterPoly
{
    class Cow : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("MoMo");
        }
    }
}
