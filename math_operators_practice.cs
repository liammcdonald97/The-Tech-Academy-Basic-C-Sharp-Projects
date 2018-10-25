using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_operators_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number: ");
            string num1 = Console.ReadLine();
            double output1 = Convert.ToDouble(num1);
            Console.WriteLine("Your number multiplied by 5 is: " + (output1 * 5));
            

            Console.WriteLine("Please enter another number: ");
            string num2 = Console.ReadLine();
            double output2 = Convert.ToDouble(num2);
            Console.WriteLine("Your number plus 25 is: " + (output2 + 25));
           

            Console.WriteLine("Please enter another number: ");
            string num3 = Console.ReadLine();
            double output3 = Convert.ToDouble(num3);
            Console.WriteLine("Your number divided by 12.5 is: " + (output3 / 12.5));

            Console.WriteLine("Please enter another number: ");
            string num4 = Console.ReadLine();
            double output4 = Convert.ToDouble(num4);
            bool greaterThanFifty = output4 > 50;
            Console.WriteLine("Is your number greater than 50? " + greaterThanFifty);

            Console.WriteLine("Please enter another number: ");
            string num5 = Console.ReadLine();
            double output5 = Convert.ToDouble(num5);
            Console.WriteLine("The remainder of your number divided by 7 is: " + (output5 % 7));
            Console.ReadLine();


        }
    }
}
