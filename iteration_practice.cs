using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration_basic_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a one-dimensional Array of strings. ask the user to input some text. Create a loop that goes through
            //each string in the Array, adding the user's text to the string. Then creat a loop that prints off each
            //string in the Array on a seperate line.
            //Console.WriteLine("Please enter four names:");
            //string[] userInput = new string[4];
            //for(int i = 0; i < userInput.Length; i++)
            //{
            //    userInput[i] = Console.ReadLine();
            //}

            //Console.WriteLine(userInput[0]);
            //Console.WriteLine(userInput[1]);
            //Console.WriteLine(userInput[2]);
            //Console.WriteLine(userInput[3]);

            //Console.ReadLine();


            //Create an infinite loop.
            //for (int number = 1; number >= 1; number++)
            //{
            //    Console.WriteLine("This is an infinite loop");               
            //}
            //Console.ReadLine();


            //Fix the infinite loop so it will execute.
            //for (int number = 1; number <= 10; number++)
            //{
            //    Console.WriteLine("This is a fixed loop that will execute up 10");
            //}
            //Console.ReadLine();

            //Create a loop where the comparison used to determine whether to continue iterating the loop is a < operator.
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //Create a loop where the comparison used to determine whether to continue iterating the loop is a <= operator.
            //for (int i = 0; i <= 25; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List.
            //Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            //List<string> states = new List<string>();
            //states.Add("Ohio");
            //states.Add("Arizona");
            //states.Add("Oregon");
            //states.Add("Kentucky");

            //Console.WriteLine("Please enter the name of a state:");
            //string name = Console.ReadLine();

            //foreach (string input in states)
            //{
            //    if (name == "Ohio")
            //    {
            //        int i = states.IndexOf("Ohio");
            //        Console.WriteLine(i);
            //        break;
            //    }
            //    if (name == "Arizona")
            //    {
            //        int i = states.IndexOf("Arizona");
            //        Console.WriteLine(i);
            //        break;
            //    }
            //    if (name == "Oregon")
            //    {
            //        int i = states.IndexOf("Oregon");
            //        Console.WriteLine(i);
            //        break;
            //    }
            //    if (name == "Kentucky")
            //    {
            //        int i = states.IndexOf("Kentucky");
            //        Console.WriteLine(i);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a different state:");
            //        name = Console.ReadLine();
            //    }
            //}

            //Console.ReadLine();


            //List<string> names = new List<string>();
            //names.Add("Sarah");
            //names.Add("John");
            //names.Add("Joe");
            //names.Add("John");

            //Console.WriteLine("Please enter a name:");
            //string name = Console.ReadLine();

            //foreach (string input in names)
            //{
            //    if (name == "Sarah")
            //    {
            //        int i = names.IndexOf("Sarah");
            //        Console.WriteLine(i);
            //        break;
            //    }
            //    if (name == "John")
            //    {
            //        int i = names.IndexOf("John");
            //        Console.WriteLine("1");
            //        Console.WriteLine("4");
            //        break;
            //    }
            //    if (name == "Joe")
            //    {
            //        int i = names.IndexOf("Joe");
            //        Console.WriteLine(i);
            //        break;
            //    }                   
            //    else
            //    {
            //        Console.WriteLine("Please enter a different name:");
            //        name = Console.ReadLine();
            //    }
            //}

            //Console.ReadLine();

            //Create a list of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays
            //a message showing the string and whether or not it has already appeared in the list.
            List<string> states = new List<string> { "PA", "CA", "PA", "OH" };
            bool containsDuplicates = (states.Count != states.Distinct().Count());
                foreach (string input in states)
                
                {                                            
                    Console.WriteLine(input, containsDuplicates);

                }
            Console.ReadLine();

        }
    }
}
