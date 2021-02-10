using System;

namespace Boolean
{
    class Entrypoint
    {
        static void Main()
        {
            //With Boolean something either is, or isn't
            //Let's use a cookie jar as an example
            //The name of the variable is essentially a question that get's answered by the value of the variable
            //Boolean data-types are used to describe the state of an object or for comparison operations
            //Be mindful of what you name the boolean operations and make sure it properly describes the operation
            Console.WriteLine("Whether or not the cookie-jar is empty");
            bool isFull = false;
            bool isEmpty = true;
            Console.WriteLine(isEmpty);
            //Check if the first integer is lesser or bigger than the second
            Console.WriteLine("Bigger/Lesser");
            bool isItBigger = 4 < 6;
            bool isItLess = 4 > 6;
            Console.WriteLine(isItBigger);
            Console.WriteLine(isItLess);

        }
    }
}
