using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace Just_for_learning
{

    class Edit_dis_op
    {
        public int miniDis(string str1, string str2)
        {
            int str1_len = str1.Length;
            int str2_len = str2.Length;

            if (str1 == str2)
            {
                return 0;
            }
            int[] array = new int[str2_len+1];
            for (int i = 1; i <= str2_len; i++ )//initialized
            {
                array[i] = i;
            }

            int first;
            for (int i = 1; i <= str1_len; i++)
            {
                first = array[0];//record the top-left
                array[0] = i; //record the lower-left
                for (int j = 1; j <= str2_len; j++)
                {

                    int temp = array[j];//record the top-right
                    if (str1[i - 1 ] == str2[j - 1])
                    {
                        array[j] = first;
                    }
                    else
                    {
                        array[j] = Math.Min(Math.Min(array[j - 1], array[j]), first) + 1;
                    }

                    first = temp;//update top-left

                }
            }
            return array[str2_len];       
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("edit distance");
            Edit_dis_op ed = new Edit_dis_op();
            //Edit_dis_op ed = new Edit_dis_op();//optimatied
            int Ed_ds = ed.miniDis("sitting", "kitten");
            Console.WriteLine("mini edit is {0}", Ed_ds);
        }
    }
}
