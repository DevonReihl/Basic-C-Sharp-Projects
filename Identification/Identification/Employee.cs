using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identification
{
    public class Employee : Person, IQuittable // inhertance from Person
    {
        public int Id { get; set; }
        //public List<Employee> Employees { get; set; }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            bool status = false;
            if (employee.Id == employee2.Id)
            {
                status = true;
                
            }
            return status;
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            bool status = false;
            if (employee.Id != employee2.Id)
            {
                status = true;
                
            }
            return status;
        }

        public void Quit()
        {
            Console.WriteLine("I QUIT!!!");
        }

    }
}
