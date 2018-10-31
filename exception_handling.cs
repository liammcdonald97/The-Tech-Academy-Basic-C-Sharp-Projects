using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int> { 10, 20, 30, 40, 50 };
            Console.WriteLine("Please enter a whole number to divide each number in the list by:");
            string userInput = Console.ReadLine();                 
           
            foreach (int number in numberList)
            {
                try
                {
                    int userInput1 = Convert.ToInt32(userInput);
                    Console.WriteLine(number / userInput1);                  
                }
                catch (System.DivideByZeroException)
                {
                    Console.WriteLine("You cannot divide by zero, please enter a whole number:");
                    int userInput1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(number / userInput1);
                    
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter a valid whole number:");
                    int userInput1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(number / userInput1);
                    

                }
                
            }
            Console.ReadLine();
        }

      
    }
}
