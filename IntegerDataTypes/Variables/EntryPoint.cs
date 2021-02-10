using System;

namespace Variables
{
    class EntryPoint
    {
        static void Main()
        {
            /*Imagine a box. This box can contain only eggs. In has 10 eggs inside it. It is the eggbox
            This perfectly illustrates what a variable is. It consists of three things
            It has a name, in this case egg box.
            It also has a value, in this case 10, 10 eggs.
            It also has a data-type, showing what kind of value that box have.
            Since this box can only contain eggs, it has the datatype 'Eggs*/
            /*In c-sharp we have several data-types, called primitive data-types.
             These are the main ingredients that make up everything else in our code.
             We can use them to create our own custom types named 'classes'*/
             //Concatenation - Stitching together

            int age = 24;
            string firstName = "Emil";
            string middleName = "Paarup";
            string lastName = "Tiedt";
            string space = " ";
            Console.WriteLine(age);
            Console.WriteLine(firstName+space+lastName);
            Console.WriteLine(firstName+space+middleName+space+lastName);
        }
    }
}
