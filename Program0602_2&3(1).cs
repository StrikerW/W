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
                String str=read.ReadToEnd();//read all characters from the begin to end

                int Count_rows = str.Split('\n').Length;//use '\n' to split the string and get num of rows
                int Count_words = str.Split(' ').Length + Count_rows - 1;/* use ' ' to split string and add the num of rows, 
                                                                            becasue the last word of each row is not be computed, so plus it.
                                                                            But the last word of the whole file also has a '\n' after it , so minus 1*/
                int Count_chars = str.Length - (Count_words - Count_rows) - Count_rows; /*str.length not only includes '\n' but also includes ' ', so we
                                                                                         minus the num of ' ' and the num of '\n'*/
                    
                int[] Count = new int[] {Count_rows, Count_words, Count_chars};
                return Count;
            }
        }
        static void Main(string[] args)
        {
            Program pg = new Program();
            int SumRows = 0;
            int SumWords = 0;
            int SumChars = 0;
            Console.Write("Input the full directory path:");
            string path = Console.ReadLine();
            var files = Directory.GetFiles(path, "*.txt");//get all txt files in the directory
            foreach (var file in files)
            {
                int Sum_rows = pg.CountLines(file)[0];
                int Sum_words = pg.CountLines(file)[1];
                int Sum_chars = pg.CountLines(file)[2];
                SumRows += Sum_rows;
                SumWords += Sum_words;
                SumChars += Sum_chars;
            }
                

            Console.WriteLine("the sum of rows is {0},the sum of words is {1}, the sum of chars is {2}", SumRows,SumWords,SumChars);
        }
    }
}
