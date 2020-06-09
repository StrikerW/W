using System;
using System.Collections.Generic;

namespace Program_0609
{
    class Queue<T>
    {
        int top = -1;// record the initial position.
        List<T> queue = new List<T>();// use array to record the stack
        int begin = 0;

        public void Push(T a)
        {
                top = top + 1;
                queue.Add(a);
        }
        public T Pop()//remove and return
        {
            if (top > 0 && begin <= top)
            {
                T element = queue[begin];
                begin = begin + 1;
                return element;
            }
            else
            {
                Console.WriteLine("Underflow");
                return default(T);
            }
        }
        public T Peek()
        {
            return queue[begin];
        }
        public void print()
        {
            for (int i = top; i >= begin; i--)//************************************************************************
            {
                Console.WriteLine(queue[i]);
            }
        }

    }
    class program
    {
        public static void Main(string[] args)
        {
            Queue<int> qu = new Queue<int>();
            qu.Push(1);
            qu.Push(2);
            qu.Push(3);
            qu.print();
            Console.WriteLine("______________________");
            qu.Pop();
            qu.print();
            Console.WriteLine("______________________");
            qu.Peek();
            qu.print();
            Console.WriteLine("______________________");

        }
    }
}
