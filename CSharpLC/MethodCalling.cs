using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLC
{
    class MethodCalling
    {
        public int FindMax(int num1,int num2)
        {

            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }
        public int factorial(int num)
        {
            int result;
            if (num == 1)
                result= 1;
            else
                result=factorial(num - 1) * num;
            return result;
        }
    }
}
