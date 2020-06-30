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
    public void enqueue(int a)
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
    public void Dequeue()//from the front
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

            //queue[end - 1] = 0;

            if (end < number)
            {
                queue[end] = 0;
            }


            end--;
            return;
        }
        
    }
 
    public void show()
    {
        Console.WriteLine("now the queue is ");
        for(int i = end - 1; i > -1 ; i--)
        {
            Console.WriteLine(queue[i]);
            
        }
        Console.WriteLine("the number of elements is {0}", end);
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



        
        qu.Dequeue();
        qu.show();
        
        
        qu.enqueue(6);
        qu.enqueue(7);
        qu.enqueue(8);
        qu.enqueue(9);
        qu.enqueue(10);
        qu.enqueue(11);
        qu.show();

        qu.Dequeue();
        qu.show();




    }
 }