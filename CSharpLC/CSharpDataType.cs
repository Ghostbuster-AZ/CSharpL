using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSharpLC
{
    class CSharpDataType
    {
        //value type- int,char,float- System.Valuetype
        //Referece type- object, dynamic, string, pointer
        //Pointer type

        //value-object type= boxing
        //object-value type= unboxing

        

        // Boxing
        readonly object obj=10;
  
        public void CheckSizeofInt()
        {
            String str;
            str= "This is Reference type";

            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.ReadLine();
        }
      
    }
}
