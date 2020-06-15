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


    class Program
    {

        public void Merge(int[] A, int m, int[] B, int n)// two pointer to add B in A
        {
            var C = new int[m + n];
            var index = 0;
            var pa = 0;
            var pb = 0;
            while (pa < m || pb < n)
            {
                if (pa == m)
                {
                    C[index] = B[pb];
                    pb++;
                }
                else if (pb == n)
                {
                    C[index] = A[pa];
                    pa++;
                }
                else if (A[pa] > B[pb])
                {
                    C[index] = B[pb];
                    pb++;
                }
                else
                {
                    C[index] = A[pa];
                    pa++;
                }
                index++;
            }
            for (int i = 0; i < m + n; i++)
            {
                A[i] = C[i];
            }
        }
        

    }
        class Solution
        {

            static void Main(string[] args)
            {
            //假设我的文件中有18个数据5,4,8,48,54,41,44,44,56,47,14,84,1,47,96,85,21,41，但是只有9个内存
                Program pg = new Program();

                FileStream fs = new FileStream("res.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                

                string filepath = "1.txt";
                string filepath_1 = "res.txt";
                StreamReader read = new StreamReader(filepath);
                StreamReader read_1 = new StreamReader(filepath_1);
                
                List<int> list = new List<int>(6);
                int i = 0;
                while (i < 9)
                {
                    
                    list.Add(int.Parse(read.ReadLine()));
                    i++;
                }
                list.Sort();
                
                foreach(int a in list)
                {
                    sw.WriteLine(a);     
                }

                i = 0;

                list = null;//清空list
                while (i < 9)
                {

                    list.Add(int.Parse(read.ReadLine()));
                    i++;
                }
                list.Sort();

                pg.Merge(read_1.ReadLine().Split(" "), 18, list, 9);

            }
         }
    }