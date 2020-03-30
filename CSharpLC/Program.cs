using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpLC
{
    class Program
    {
        static void Main(string[] args)
        {
            PathTest pt = new PathTest();
            pt.PathTested();

            Rectangle rt = new Rectangle();

            rt.GetMeasurement();
            rt.Display();

            MethodCalling mcall = new MethodCalling();
            int result = mcall.FindMax(4, 11);
            Console.WriteLine("Result: {0}", result);
            Console.ReadKey();

            int factt = mcall.factorial(2);
            Console.WriteLine("Factorial: {0}", factt);
            Console.ReadKey();
        }
    }
    public class Rectangle
    {
        double length;
        double width;

        public void GetMeasurement()
        {
            length = 2;
            width = 1.5;
        }
        public double getArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length:{0} ", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", getArea());
            Console.ReadKey();
        }
    }
    public class GetAread
    {
        public GetAread()
        {
            const double pi = 3.14;
            double r;

            Console.WriteLine("Enter radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double circle;
            circle = pi * r * r;
            Console.WriteLine("Radius {0}, Area{1}", r, circle);
        }

    }

    public class PathTest
     {
        public void PathTested()
        {
            string filename = "@C:\\Filename\\text.txt";
            string path = Path.GetFileName(filename);

            Console.WriteLine("Filename: {0}", filename);
            Console.WriteLine("Path: {0}", path);
        }

      }
   
}
