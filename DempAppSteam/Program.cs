using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DempAppSteam
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Example.txt";
            using(StreamReader sr = File.OpenText(path))
            {
                string s = "";

                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
                Console.ReadKey();
            }
            using(StreamWriter sw= File.AppendText(path))
            {
                sw.WriteLine("Guru99- ASP.NET1");
                sw.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();

        }
    }
}
