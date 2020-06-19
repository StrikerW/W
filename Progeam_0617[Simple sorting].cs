using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
            

            StreamReader read = new StreamReader("1.txt");
            string str = read.ReadToEnd();//读取数据

            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();//创建字典   
            List<List<int>> list = new List<List<int>>();//c创建二维list
            
            String[] array_of_num = str.Split(",");//读取数据变成字符array
            int [] numbers = Array.ConvertAll(array_of_num, int.Parse);//转化成int类型
            //
            Console.Write("Input the group number:");//输入分组数
            int groups = int.Parse(Console.ReadLine());

            int max = numbers.Max();
            int min = numbers.Min();
            int interval = (max - min) / groups;//计算分组间隔


            int j = min;
            for (int i = 0 ; i < groups; i++)
            {
                dic.Add(  j , list[i]);//创建一对key&value
                var num =              //查找所有符合条件的数
                    from n in numbers
                    where n <= j
                    select n;
                List<int> temp = num.ToList();
                temp.Sort();//排序
                list[i] = temp;
                j += interval;//进入下一组
            }
            


        }
    }
            }
         
    