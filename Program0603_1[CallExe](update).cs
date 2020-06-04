using System;
using System.Diagnostics;
using System.IO;
using System.IO.Enumeration;

namespace Program0603
{
    class Program
    {
        internal void call(String filename, string par)
            {

            Process pro = new Process();
            pro.StartInfo.FileName = filename;
            pro.StartInfo.Arguments = par;//call with parameter
            string path = Path.GetDirectoryName(filename);//get the directory name of file
            pro.StartInfo.WorkingDirectory = path;//change the working directory
            pro.Start();
        }


        static void Main(string[] args)
        {
            string filename_1= "C:/Users/admin/source/repos/Helloworld/Helloworld/bin/Debug/netcoreapp3.1/Helloworld.exe";
            string filename_2 = "C:/Users/admin/source/repos/Adding/Adding/bin/Debug/netcoreapp3.1/Adding.exe";
            string filename_3 = "C:/Users/admin/source/repos/Program0602/Program0602/bin/Debug/netcoreapp3.1/Program0602.exe";


            string parameter_1 = "";

            string parameter_2 = "1 2"; // parameter is a string spilted with " "

            string parameter_3 = "";

            Program pg = new Program();

            pg.call(filename_1,parameter_1);
            
            pg.call(filename_2,parameter_2);
            
            pg.call(filename_3,parameter_3);
        }
    }
}
