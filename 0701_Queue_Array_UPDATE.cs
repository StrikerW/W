using System;
using System.Threading;

public class Queue
{
    public int capacity;
    public int[] queue;
    public int first;
    public int count;
    public Queue(int n)
    {
        capacity = n;
        queue = new int[n];
        first = 0;
        count = 0;

    }
    public void enqueue(int a)
    {
       if (count != capacity)
        {
            queue[(first + count) % capacity] = a; // compute the tail index
            count++;
        }

    }
    public void Dequeue()
    {
        if(count != 0)
        {
            first = (first + 1) % capacity;
            count--;
        }

        
    }
 
    public void show()
    {
        Console.WriteLine("now the queue is ");
        for(int i = first; i < capacity; i++)
        {
            Console.WriteLine(queue[i]);    
        }
    }

}

public class solution {
    public static void Main(String[] args)
    {
        Queue qu = new Queue(10);
        
        
        qu.enqueue(1);
        qu.enqueue(2);
        qu.enqueue(3);
        qu.enqueue(4);
        qu.enqueue(5);
        qu.show();



        Console.WriteLine("get out of one");
        qu.Dequeue();
        qu.show();

        Console.WriteLine("get out of one");
        qu.Dequeue();
        qu.show();

        Console.WriteLine("add one");
        qu.enqueue(6);
        qu.show();


        /*
        qu.enqueue(6);
        qu.enqueue(7);
        qu.enqueue(8);
        qu.enqueue(9);
        qu.enqueue(10);
        qu.enqueue(11);
        qu.show();

        qu.Dequeue();
        qu.show();
        */



    }
 }