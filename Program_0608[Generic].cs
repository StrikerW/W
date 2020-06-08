using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Program0608
{
    class ProStack<T>//create a generic class
    {
        static int num = 100; 
        int top = -1; 
        List<T> list = new List<T>();//generic list 
        public void push(T a)
            {
                if (top < num)
                {
                    top++;
                list.Add(a);
                }
            }
            public T Pop()
        {
            if (top > 0) 
                {
                T element = list[top];
                list.RemoveAt(top);
                top--;
                
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
                if (top > 0)
                {
                    T element = list[top];
                    Console.WriteLine("the top one is {0}:",element);
                    return element;
                }
                else
                {
                    Console.WriteLine("Underflow");
                    return default(T);
                }
            }
            public void show()
        {
            for(int i=top; i>=0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }

    }
    class main
    {
        static void Main(string[] args)
        {
            //ProStack<int> st = new ProStack<int>();//set data type
            //int[] num = new int[] { 20,30,40,50,60};

            ProStack<string> st = new ProStack<string>();//set data type
            string[] num = new string[] {"a","b","c","d","e"};

            foreach (var i in num)
            {
                st.push(i);
            }
            st.show();
            Console.WriteLine("remove top one");
            st.Pop();//return the last element and remove it
            st.show();
            Console.WriteLine("return the top one");
            st.Peek();
            st.show();

        }
    }
}
