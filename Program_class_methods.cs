using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_method_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What number do you want to multiply by 2, divide by 2, and square?");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int output1 = Class1.TimesTwo(number1);
            Console.WriteLine(output1);
            int output2 = Class1.DivideByTwo(number1);
            Console.WriteLine(output2);
            int output3 = Class1.Squared(number1);
            Console.WriteLine(output3);
            Console.ReadLine();
            Console.ReadLine();
        }

    }
    
}
