using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DemoAppFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Example.txt";
            string copypath= @"D:\ExampleNew.txt";
            string line; 
            string[] lines;

            line=File.ReadAllText(path);
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

            Console.WriteLine(line);

            File.Copy(path,copypath);
            File.Delete(copypath);
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();


        }
    }
}
