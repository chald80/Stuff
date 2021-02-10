using System;

namespace IntegerDataTypes
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are some Datatypes");
            /*These can only hold whole numbers, meaning that if you tried applying decimal numbers
             they would get rounded to the nearest whole number, or integer
             3.14 would become three, etc.*/

            //The Int datatype can hold whole-numbers up to 32-Bits, meaning the biggest number is 2^32
            int intMax = int.MaxValue;
            int intMin = int.MinValue;
            Console.WriteLine("Integers");
            System.Console.WriteLine(intMax);
            Console.WriteLine("");
            System.Console.WriteLine(intMin);

            //The same as the Int datatype, except the Int datatype can hold both negative and positive number
            //uint stand for unsigned integer, meaning it can only hold positive numbers
            Console.WriteLine("Unsigned Integers");
            uint minUInt = uint.MinValue;
            uint maxUInt = uint.MaxValue;
            Console.WriteLine(minUInt);
            Console.WriteLine("");
            Console.WriteLine(maxUInt);

            //If we use the math class, along with the dot-operator and the pow method we can calculate 2^32, only off by one number because the UInt counts the zero as a positive number
            Console.WriteLine(Math.Pow(2, 32));

            //Next we have the byte datatype.
            Console.WriteLine("Byte");
            byte minByte = byte.MinValue;
            byte maxByte = byte.MaxValue;
            Console.WriteLine(minByte); //0
            Console.WriteLine("");
            Console.WriteLine(maxByte); //255

            //Next is the sbyte - shortbyte
            Console.WriteLine("Sbyte");
            sbyte minsByte = sbyte.MinValue;
            sbyte maxsByte = sbyte.MaxValue;
            Console.WriteLine(minsByte);
            Console.WriteLine("");
            Console.WriteLine(maxsByte);

            //Longdata types are used to display long, whole numbers - Up to 2^64
            long minLong = long.MinValue;
            long maxLong = long.MaxValue;
            Console.WriteLine(minLong);
            Console.WriteLine("");
            Console.WriteLine(maxLong);
            Console.WriteLine(Math.Pow(2, 64));

        }

    }
}
