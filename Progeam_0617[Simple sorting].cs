using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Threading;

namespace Just_for_learning
{



        class Solution
        {

            static void Main(string[] args)
            {
            //假设我的文件中有18个数据5,4,8,48,54,41,44,44,56,47,14,84,1,47,96,85,21,41
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
           /* StreamReader read = new StreamReader("1.txt");
            string str;
            while ((str = read.ReadToEnd())!=null)
            {
                Console.WriteLine(str);//观察数据
            }*/
            //分成0-100,3组

            List<int> list_1= new List<int>();
            List<int> list_2 = new List<int>();
            List<int> list_3 = new List<int>();

            //分组：
            int a = 33;
            int b = 66;
            int c = 99;
            //String[] array_of_num = str.Split(",");
            int[] array_of_num = { 5, 4, 8, 48, 54, 41, 44, 44, 56, 47, 14, 84, 1, 47, 96, 85, 21, 41 };
            dic.Add(a,list_1);
            dic.Add(b, list_2);
            dic.Add(c, list_3);
            Console.WriteLine("__________________");
            foreach (int j in array_of_num) {
                //int j = int.Parse(i);
                if (j <= 33)
                {
                    list_1.Add(j);
                }
                if (j > 33 && j <= 66)
                {
                    list_2.Add(j);
                }
                if (j > 66)
                {
                    list_3.Add(j);
                }
            }
            }
            }
         }
    