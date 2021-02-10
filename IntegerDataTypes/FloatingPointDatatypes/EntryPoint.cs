using System;

namespace FloatingPointDatatypes
{
    internal class EntryPoint
    {
        private static void Main()
        {
            //The float data-type can hold numbers with up to 7 digits. It cuts out after that.
            //Even if there's  only one digit after the comma, it only shows 7
            float someFloat = 3222.1423f; //the f is needed for the float data-type
            Console.WriteLine(someFloat);
            //If you want the whole number displayed use this, only displays whole numbers and rounds up to nearest integer.
            Console.WriteLine(someFloat.ToString("f"));
            /*Calculate the area of a cirlce by defining several Variables
             The calculatio can easily be changed if we define both pi and radius, and put the
             calculation into a variable by itself, making it much easier to print
             */
            float pi = 3.14f;
            float radius = 5.4f;
            float areaOfCircle = pi * radius * radius;
            Console.WriteLine(areaOfCircle);
            //Let's see the max and min values of float. Float stores fractional numbers but only 6-7 digits
            float fMax = float.MaxValue;
            float fMin = float.MinValue;
            //If we want it printed with an 'E' notation;
            Console.WriteLine("Float");
            Console.WriteLine(fMax);
            Console.WriteLine(fMin);
            //If we want the whole number we use the .tostring method
            Console.WriteLine(fMax.ToString("f"));
            Console.WriteLine(fMin.ToString("f"));
            //Double. Stores fractional numbers. Sufficient for storing 15 decimal digits
            Console.WriteLine("Double");
            double doubleMax = double.MaxValue;
            double doubleMin = double.MinValue;
            //If we want it printed with an 'E' notation
            Console.WriteLine(doubleMax);
            Console.WriteLine(doubleMin);
            //If we want the number with more decimals we use the .tostring method
            //We lose precision due to the number of zeroes, i.e. we use precision if we have a lot of digits, more than 15.
            Console.WriteLine(doubleMax.ToString("f"));
            Console.WriteLine(doubleMin.ToString("f"));
            //Decimal, the most precise datatype.
            Console.WriteLine("Decimal");
            decimal decimalMax = decimal.MaxValue;
            decimal decimalMin = decimal.MinValue;
            //Print it
            Console.WriteLine(decimalMax);
            Console.WriteLine(decimalMin);
            //Print to string
            Console.WriteLine(decimalMax.ToString("f"));
            Console.WriteLine(decimalMin.ToString("f"));
        }
    }
}