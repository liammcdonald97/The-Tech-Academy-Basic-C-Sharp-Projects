using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_insurance_approval_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Program");
            Console.WriteLine("What is your age?");
            string input1 = Console.ReadLine();
            double age = Convert.ToDouble(input1);

            Console.WriteLine("Have you ever had a DUI? Please Write true or false:");
            string input2 = Console.ReadLine();
            bool hasDUI = Convert.ToBoolean(input2);

            Console.WriteLine("How many speeding tickets do you have?");
            string input3 = Console.ReadLine();
            double speedingTickets = Convert.ToDouble(input3);

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && hasDUI == false && speedingTickets <= 3);

            Console.ReadLine();

        }
    }
}
