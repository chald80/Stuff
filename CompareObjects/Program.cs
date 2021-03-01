using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
//using Zoo;

namespace CompareObjects
{
    class Program
    {
        static void Main(string[] args)
        {

           

            List<int> numbers = new List<int>();

            numbers.Add(3);
            numbers.Add(1);
            numbers.Add(4);
            numbers.Add(2);

            Console.WriteLine(" -------------- Before Sorting ---------------");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(" -------------- After Sorting ---------------");
            //sort has no problems with sorting primitive data types
            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(" -------------- Sorting Animal/Objects ---------------");

            List<Dog> dogs = new List<Dog>();

            dogs.Add(new Dog("King", 40, 2));
            dogs.Add(new Dog("Spot", 30, 1));
            dogs.Add(new Dog("Rufus", 50, 4));

            Console.WriteLine(" -------------- Before Sorting ---------------");

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Weight);
            }

            //this sort will fail and will throw an exception if IComparble is not implemented by the Dog class
            dogs.Sort();

            Console.WriteLine(" -------------- After Sorting ---------------");

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Weight);
            }

            IComparer<Dog> dogCompare = new DogCompareByAge();
            //The following will also work because our DogCompareByAge implements IComparer
           // DogCompareByAge dogCompare = new DogCompareByAge();

           //This sort will only work if you implemet a new class e.g DogCompareByAge which must implemet IComparer
           //Sort method expects an object of IComparer type
            dogs.Sort(dogCompare);

            Console.WriteLine(" -------------- After using Comparer ---------------");

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Age);
            }

        }
    }

}
