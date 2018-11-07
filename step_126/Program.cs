using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_124
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();

            IQuittable quittable = new Employee();
            quittable.Quit();
        }
    }
}
