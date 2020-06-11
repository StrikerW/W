using System;
using System.Linq;

namespace Just_for_learning
{
    class Edit_dis
    {
        public int miniDis(string str1, string str2)
        {
            int str1_len = str1.Length;
            int str2_len = str2.Length;

            if (str1 == str2)
            {
                return 0;
            }
            if (str1_len == 0)
            {
                return str2_len;
            }
            if (str2_len == 0)
            {
                return str2_len;
            }
            int[,] matrix = new int[str1_len + 1, str2_len + 1];
            for (int i =0;i < str1_len+1; i++)
            {
                matrix[i,0] = i;
            }
            for (int j = 0; j < str2_len + 1; j++)
            {
                matrix[0,j] = j;
            }

            for (int j=1;j< str2_len+1;j++)
            {
                for (int i=1; i<str1_len+1; i++)
                {
                    int W;
                    if (str1[i-1] == str2[j-1])
                    {
                        W = 0;
                    }
                    else
                    {
                        W = 1;
                    }
                    //deletion: 
                    int deletation = matrix[i - 1, j] + 1;
                    int insertion = matrix[i ,j-1] + 1;
                    int substitution = matrix[i - 1, j - 1] + W;
                    int[] array = new int[] { deletation, insertion, substitution };

                    matrix[i, j] = array.Min();
                    Console.WriteLine("[{0},{1} = {2}]", i, j, matrix[i, j]);
                        
                }

            }
            
            return matrix[str1_len,str2_len];
        }
    }
    
 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("edit distance");
            Edit_dis ed = new Edit_dis();
            int Ed_ds = ed.miniDis("kitten", "sitting");
            Console.WriteLine("mini edit is {0}", Ed_ds);
        }
    }
}
