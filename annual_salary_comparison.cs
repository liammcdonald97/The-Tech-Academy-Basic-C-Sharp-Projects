using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_income_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string input1 = Console.ReadLine();
            double hourlyRate1 = Convert.ToDouble(input1);
            Console.WriteLine("Hours worked per week?");
            string input2 = Console.ReadLine();
            double hoursWorked1 = Convert.ToDouble(input2);
            double weeklySalary1 = hourlyRate1 * hoursWorked1;
            double annualSalary1 = weeklySalary1 * 52;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string input3 = Console.ReadLine();
            double hourlyRate2 = Convert.ToDouble(input3);
            Console.WriteLine("Hours worked per week?");
            string input4 = Console.ReadLine();
            double hoursWorked2 = Convert.ToDouble(input4);
            double weeklySalary2 = hourlyRate2 * hoursWorked2;
            double annualSalary2 = weeklySalary2 * 52;


            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(annualSalary1);

            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(annualSalary2);

            bool doesPersonOneMakeMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(doesPersonOneMakeMore);
            Console.ReadLine();
        }
    }
}
