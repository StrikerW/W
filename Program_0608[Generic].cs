using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Program0608
{
    class ProStack<T>//create a generic class
    {
        List<T> list = new List<T>();//generic list 
        public void push(T a)
            {
                list.Add(a);
            }
        public T Pop()
        {

            T element = list.Last();
            list.RemoveAt(list.Count-1);
            return element;
        }

            public T Peek()
            {
                    T element = list.Last();
                    Console.WriteLine("the top one is {0}:",element);
                    return element;
            }
            public void show()
        {
            for (int i = list.Count-1; i>= 0;i--)
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
