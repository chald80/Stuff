using System;
using System.Collections;

namespace ExceptionsStack
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            MyStack stk = new MyStack(5);


            try
            {
                stk.Push(1);
                stk.Push(2);
                stk.Push(3);
                stk.Push(4);
                stk.Push(5);
                stk.Push(6);

            }
            catch (MyStackIsFullException e)
            {
                Console.WriteLine(e.Message);
                
            }



            

            try
            {
                stk.Pop();
            }
            catch (MyStackIsEmptyException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
