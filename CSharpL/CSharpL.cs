using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpL
{
    public class CSharpL
    {
        static void Main(string[] args)
        {
            Rectangle rt = new Rectangle();
            rt.getArea();
            rt.Display();

            double d = 3.4;
            int i;
            i = (int)d;

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
            Console.WriteLine("Length: ", length);
            Console.WriteLine("Width: ", width);
            Console.WriteLine("Area: ", getArea());
        }
    }
}