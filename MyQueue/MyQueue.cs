using System;
using System.Collections.Generic;
using System.Text;

namespace MyQueue
{
    class MyQueue<T>
    {
        private T[] queue;
        private int front = 0;
        private int rear = 0;

        public MyQueue(int size)
        {
            queue = new T[size];
            rear = size - 1;
        }
        public void Enqueue(T element)
        {
            
        }
        public Dequeue()
        {
            return;
        }



    }
}
