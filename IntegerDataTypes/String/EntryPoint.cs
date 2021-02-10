using System;

namespace String
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string username = "admin";

            Console.WriteLine(username[0]);
            //Strings are immutable, it is impossible to change a single character in a string by for instance
            // username[4] = a;
        }
    }
}
