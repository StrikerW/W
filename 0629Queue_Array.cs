using System;
public class Queue
{
    public int[] queue;
    public int first, end;
    public int number;
    public Queue(int n)
    {
        first = 0;
        end = 0;
        number = n;
        queue = new int[number];
    }
    public void add(int a)
    {
        if (end >= number)
        {
            Console.WriteLine("Queue is full");
            return;
        }
        else
        {
            queue[end] = a;
            end++;
            return;
        }
    }
    public void Pop()//from the front
    {
        if(first >= end)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        else
        {
            for (int i = 0; i < end - 1; i++)
            {
                queue[i] = queue[i + 1];
            }
            queue[end] = 0;
            end--;
            return;
        }
        
    }
    public int Peek()
    {
        return queue[first];
    }
    public void show()
    {
        Console.WriteLine("now the queue is ");
        for(int i = end - 1; i > -1 ; i--)
        {
            Console.WriteLine(queue[i]);
        }
    }

}

public class solution {
    public static void Main(String[] args)
    {
        Queue qu = new Queue(10);
        qu.add(1);
        qu.add(2);
        qu.add(3);
        qu.add(4);
        qu.add(5);
        qu.show();

        qu.Pop();
        qu.Pop();
        qu.show();


        Console.WriteLine("peek and return {0}", qu.Peek());

        qu.show();

    }
 }