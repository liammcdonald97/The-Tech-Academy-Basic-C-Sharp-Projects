using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Class1
    {
        public static int Method1(int num1, int num2)
        {
            return num1 + num2;
        }

    }


    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 7;
            int num4 = Class1.Method1(num1, num2);

            Console.WriteLine(Class1.Method1(2, 6));

        }
    }
}
