using System;
using System.Collections.Generic;
using System.Text;

namespace CompareObjects
{
    class Dog : IComparable<Dog>
    {
        public Dog(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public int CompareTo(Dog other)
        {
            if (Weight < other.Weight)
            {
                return -1;
            }

            if (Weight > other.Weight)
            {
                return 1;
            }

            return 0;
        }
    }
}
