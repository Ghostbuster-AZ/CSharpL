using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLC
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rt = new Rectangle();

            rt.GetMeasurement();
            rt.Display();
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
}
