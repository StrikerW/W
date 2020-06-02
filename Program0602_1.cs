using System;

namespace Program0602_1
{
    class Stack
    {
        static int num = 100; //set the size of stack
        int top = -1;//position
        int[] stack = new int[num];//creat a stack
        internal void Push(int data) //add one element into stack
        {
            if (top < num)
            {
                stack[++top] = data;// it equals to "++top; stack[top]=data;"
                
            }
        }


        internal int Pop()//remove the last added element and return it
        {
            int element = stack[top--];//it equals to "element=stack[top]; top--;"
            Console.WriteLine("the last element is :{0}, and remove it", element);
            return element;
        }

        internal int Peek()
        {
            Console.WriteLine("The last added is : {0}", stack[top]);
            return stack[top];
        }
        internal void Print()//print the stack
        {
            Console.WriteLine("the current stack is");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
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
