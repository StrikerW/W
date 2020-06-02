using System;
using System.IO;

namespace Program0602_2
{
    class Program
    {
        public int[] CountLines(string FilePath)
        {
            using (StreamReader read = new StreamReader(FilePath))
            {
                var str="";
                int Count_rows=0;
                int Count_words = 0;
                int Count_chars = 0;
                while(( str=read.ReadLine()) !=null)
                {
                    Count_rows++;//count the rows
                    Count_words += str.Split(" ").Length;//count the words separated by space
                    Count_chars += str.Length-(str.Split(" ").Length - 1);//count the char
                    
                    Console.WriteLine(Count_words);
                    
                }
                int[] Count = new int[] {Count_rows, Count_words, Count_chars};
                return Count;
            }
        }
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch(); 
            


            Program pg = new Program();
            int SumRows = 0;
            int SumWords = 0;
            int SumChars = 0;
            Console.Write("Input the full directory path:");
            string path = Console.ReadLine();
            var files = Directory.GetFiles(path, "*.txt");//get all txt files in the directory
            stopwatch.Start();//timer
            foreach (var file in files)
            {
                int[] Sum = pg.CountLines(file);
                SumRows += Sum[0];
                SumWords += Sum[1];
                SumChars += Sum[2];
            }


            Console.WriteLine("the sum of rows is {0},the sum of words is {1}, the sum of chars is {2}", SumRows, SumWords, SumChars);
            stopwatch.Stop();
            Console.WriteLine("getTime:" + stopwatch.ElapsedMilliseconds.ToString());
        }
    }
}