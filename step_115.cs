using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_115
{
    class Program
    {
        static void Main(string[] args)
        {
            int num3 = 0;
            Console.WriteLine("Please enter one or two numbers to be added to 5");
            Console.WriteLine("Please enter the first value:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second value or press 0:");
            int num2 = Convert.ToInt32(Console.ReadLine());                   
            Console.WriteLine(Class1.Method1(num1, num2));
            Console.ReadLine();


        }
    }

    public class Class1
    {
        public static int Method1(int num1, int num2 = 0)
        {
            
            return num1 + num2 + 5;
        }
    }
}
