c using System;

namespace Arrays
{
    class EntryPoint
    {
        static void Main()
            //Arrays are basically collections of data, collections of information
        {
            //When we use square brackets, [], in the data-types it allows us to target a specific index, within the data-type
            int[] numbers = { 1, 4, 5, 7, 6, 2, 3, 8 };
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[7]);
            //You can also do it this way
            int[] numbersAlt = new int[8]; //This way all the values are zero
            //You have to change them manually like this
            numbersAlt[0] = 0;
            numbersAlt[1] = 1;
            numbersAlt[2] = 2;
            numbersAlt[3] = 3;
            numbersAlt[4] = 100;
            numbersAlt[5] = 5;
            numbersAlt[6] = 6;
            numbersAlt[7] = 7;
            Console.WriteLine(numbersAlt[4]);
            string[] fruits = { "pear", "apple", "banana", "pineapple", "lemon" };
            string[] fruitsV2 = new string[5];
            fruitsV2[0] = "pear";
            fruitsV2[1] = "apple";
            fruitsV2[2] = "banana";
            fruitsV2[3] = "pineapple";
            fruitsV2[4] = "lemon";

            Console.WriteLine(fruits[3]);
            Console.WriteLine(fruits[4][0]);
        }
    }
}
