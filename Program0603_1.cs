using System;
using System.Diagnostics;
using System.IO.Enumeration;

namespace Program0603
{
    class Program
    {
        internal void call(String filename)
            {
            //cal external .exe by using C#
            Process pro = new Process();
            pro.StartInfo.FileName = filename;
            pro.Start();
            }
        static void Main(string[] args)
        {
            string filename_1= "C:/Users/admin/source/repos/Helloworld/Helloworld/bin/Debug/netcoreapp3.1/Helloworld.exe";
            string filename_2 = "C:/Users/admin/source/repos/ConsoleApp2/ConsoleApp2/bin/Debug/netcoreapp3.1/ConsoleApp2.exe";
            string filename_3 = "C:/Users/admin/source/repos/Program0602_2/Program0602_2/bin/Debug/netcoreapp3.1/Program0602_2.exe";
            Program pg = new Program();
            //pg.call(filename_1);
            
            //pg.call(filename_2);
            
            pg.call(filename_3);
        }
    }
}
