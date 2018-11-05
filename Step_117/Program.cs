using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to be divided by 2:");           
            int num1 = Convert.ToInt32(Console.ReadLine());         
            Class1.DivideBy2(ref num1);
            Console.WriteLine(num1);           
            Console.ReadLine();
        }
    }
}
