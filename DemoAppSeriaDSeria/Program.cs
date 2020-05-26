using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppSeriaDSeria
{
   
    class Program
    {
        static void Main(string[] args)
        {
            ProPertyVSField tr = new ProPertyVSField();
            tr.MyProperty="Nameee";
            string NAme = tr.MyProperty;
            Console.WriteLine(NAme);

        }
    }
}
