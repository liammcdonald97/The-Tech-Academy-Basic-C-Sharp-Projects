using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_117
{
    //declare a class as static
    public static class Class1
    {
        //void method that outputs an integer
        //method divides data passed to it by 2
        //ref num 1 is output parameter
        public static void DivideBy2(ref int num1)
        {
             num1 = num1 / 2;           
        }

        //Overload a method
        public static int DivideBy2(int num1, out int num2)
        {
            num2 = num1 / 2;
            return num2;
        }

    }
}
