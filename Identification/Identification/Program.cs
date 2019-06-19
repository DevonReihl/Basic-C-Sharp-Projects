using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identification
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";  
            employee.LastName = "Student"; 

            employee.SayName();
            IQuittable employee2 = new Employee();
            employee2 = employee;
            employee.Quit();
            Console.ReadLine();
        }
    }
}
