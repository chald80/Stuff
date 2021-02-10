using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAListDemo
{
    class Student
    {        
        public int Number { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Number} - {Name}";
        }

    }
}
