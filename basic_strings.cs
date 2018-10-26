using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your middle name:");
            string middleName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello, " + firstName + " " + middleName + " " + lastName);

            string firstNameUpper = firstName.ToUpper();

            Console.WriteLine(firstNameUpper);        

            StringBuilder sb = new StringBuilder();
            sb.Append("Thank you for using this program. ");
            sb.Append("This program was created as an introduction into how strings can be used. ");
            sb.Append("This paragraph was created using the Append method for the StringBuilder. ");
            sb.Append("This is now the end of the program. ");
            sb.Append("Have a nice day");

            Console.WriteLine(sb);

            Console.Read();

        }
    }
}
