using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_124
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);           
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public static bool operator== (Employee a, Employee b)
        {
            if(a.Id == b.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        
        public static bool operator!= (Employee a, Employee b)
        {
            if(a.Id != b.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
