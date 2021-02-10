using System;
using System.Collections.Generic;

namespace SortingAListDemo
{
    class Program
    {
        public static int Compare(Student s1, Student s2)
        {
            return s1.Name.CompareTo(s2.Name);
        }

        static void Main(string[] args)
        {
            List<Student> sList = new List<Student>();

            Student s1 = new Student() { Number = 50, Name = "John" };
            Student s2 = new Student() { Number = 2, Name = "James" };
            Student s3 = new Student() { Number = 6, Name = "bo" };
            Student s4 = new Student() { Number = 4, Name = "Jane" };

            sList.Add(s1);
            sList.Add(s2);
            sList.Add(s3);
            sList.Add(s4);

            sList.Sort(Compare);

            foreach (var s in sList)
            {
                Console.WriteLine(s);
            }
        }
    }
}