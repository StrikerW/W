using System;
using System.Collections.Generic;
using System.Linq;

namespace Program0602_1
{
    class Stack
    {
        static int num = 100; //set the size of stack
        int top = -1;//position
        List<int>stack = new List<int>();//creat a stack  by using list  
        internal void Push(int data) //add one element into stack
        {
            if (top < num)
            {
                top=top+1;
                //stack[++top] = data;// it equals to "++top; stack[top]=data;"
                stack.Insert(top,data);
            }
        }


        internal int Pop()//remove the last added element and return it
        {
            if (top > 0) 
            { 
            
                int element = stack.Last();//get the last element of the list
                top = top - 1;
                stack.Remove(element);
                Console.WriteLine("the last element is :{0}, and remove it", element);
                return element;
            }
            else
            {
                Console.WriteLine("StackUnderflow!!!!!!!!!");
                return 0;
            }

        }

        internal int Peek()
        {
            if(top > 0) { 
             
            Console.WriteLine("The last added is : {0}", stack[top]);
            return stack.Last();
            }
            else
            {
                Console.WriteLine("StackUnderflow!!!!!!!!!");
                return 0;
            }
        }
        internal void Print()//print the stack
        {
            if (top > 0) { 
            Console.WriteLine("the current stack is");
            foreach(int s in stack)
            {
                Console.WriteLine(s);
            }}
        }

    }
    class program0602
    {
        static void Main(string[] args)
        {

            Stack stack0602 = new Stack();
            stack0602.Push(20);//add element into stack
            stack0602.Push(30);
            stack0602.Push(40);
            stack0602.Push(50);
            stack0602.Push(60);
            stack0602.Print();

            stack0602.Pop();//return the last element and remove it

            stack0602.Print();

            stack0602.Peek();//return the last element

            stack0602.Print();



        }
    }

}

