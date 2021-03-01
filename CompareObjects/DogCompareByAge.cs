using System;
using System.Collections.Generic;
using System.Text;

namespace CompareObjects
{
    class DogCompareByAge : IComparer<Dog>
    {
        public int Compare(Dog x, Dog y)
        {
            if (x.Age > y.Age)
            {
                return 1;
            }

            if (x.Age < y.Age)
            {
                return -1;
            }

            return 0;
        }
    }
}
