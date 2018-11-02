using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine(Class1.Method1(12));
            Console.WriteLine(Class1.Method1(4.1));
            Console.WriteLine(Class1.Method1("5"));
            Console.ReadLine();
        }
    }
    public class Class1
    {
        public static int Method1(int number1)
        {
            return number1 * 2;
        }

        public static int Method1(double number1)
        {
            return Convert.ToInt32(number1) * 4;
        }

        public static int Method1(string number1)
        {
            return Convert.ToInt32(number1) * 5;
        }
    }
}
