using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] { "PA", "NY", "AZ" };
            int[] intArray = new int[] { 38, 24, 992 };
            List<string> stringList = new List<string> { "This is located at Index 0", "This is located at index 1", "This is located at index 2"};

            Console.WriteLine("Please select an index from the array:");
            string userInput1 = Console.ReadLine();
            int arrayIndex1 = Convert.ToInt32(userInput1);
            
            try
            {
                Console.WriteLine(stringArray[arrayIndex1]);
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index. Please choose either 0, 1, or 2:");
                userInput1 = Console.ReadLine();
                arrayIndex1 = Convert.ToInt32(userInput1);
                Console.WriteLine(stringArray[arrayIndex1]);                   
            }
          
            Console.WriteLine("Please select an index from the array:");
            string userInput2 = Console.ReadLine();
            int arrayIndex2 = Convert.ToInt32(userInput2);

            try
            {
                Console.WriteLine(intArray[arrayIndex2]);
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index. Please choose either 0, 1, or 2:");
                userInput2 = Console.ReadLine();
                arrayIndex2 = Convert.ToInt32(userInput2);
                Console.WriteLine(intArray[arrayIndex2]);
            }

            Console.WriteLine("Please select an index from the list:");
            string userInput3 = Console.ReadLine();
            int listIndex3 = Convert.ToInt32(userInput3);

            try
            {
                Console.WriteLine(stringList[listIndex3]);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid index. Please choose either 0, 1, or 2:");
                userInput3 = Console.ReadLine();
                listIndex3 = Convert.ToInt32(userInput3);
                Console.WriteLine(stringList[listIndex3]);
            }
            Console.ReadLine();
        }
    }
}
