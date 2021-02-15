using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsStack
{
    class MyStack
    {
        private int[] stack;
        private int top = 0;
        private int size;
        public MyStack(int size)
        {
            stack = new int[size];
        }

        public void Push(int element)
        {
            if (top > size -1)
            {
                throw new MyStackIsFullException("this is Full");
            }
            top++;
            
        }

        public int Pop()
        {
            if (top == 0)
            {
                throw new MyStackIsEmptyException("this stack is emptyytyututyuy");
            }
            --top;
            return stack[top];
        }



    }
}
