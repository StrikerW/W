using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number:");// get the number from the keyboard
            string num1 = Console.ReadLine();//read the number
            int number1 = Convert.ToInt32(num1);//convert string into int
            Console.Write("input the second number:");
            string num2 = Console.ReadLine();
            int number2 = Convert.ToInt32(num2);
            Console.Write(Environment.NewLine);
            int sum = number1 + number2;
            Console.WriteLine("sum is {0}",sum);
        }
    }
}
