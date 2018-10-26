using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipping_quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width:");
            double packageWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            double packageHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            double packageLength = Convert.ToDouble(Console.ReadLine());

            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            double quote = (((packageWidth + packageHeight + packageLength) * packageWeight) / 100);

            string formatQuote = String.Format("{0:C}", quote);

            Console.WriteLine("Your estimated total for shipping this package is: " + formatQuote);
            Console.WriteLine("Thank You");

            Console.ReadLine();
             
        }
    }
}
