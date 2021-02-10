using System;
using System.Text;

namespace Character
{
    class Entrypoint
    {

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //The character data-type can only have a value of a single character
            //This is used when we want to use special characters
            char theCharacterX = 'x';
            Console.WriteLine(theCharacterX);
            char specialCharacter = '\u0224';
            Console.WriteLine(specialCharacter);
        }
    }
}
