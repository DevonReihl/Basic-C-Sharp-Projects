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

            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "A", "B", "C", "D", "E", "F"};

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
                Console.ReadLine();

            //Calling two employees and giving them Names and ID
            //Employee employee = new Employee();
            //employee.FirstName = "Sample";  
            //employee.LastName = "Student";
            //employee.Id = 1;

            //Employee employee2 = new Employee();
            //employee2.FirstName = "Next";
            //employee2.LastName = "Student";
            //employee2.Id = 2;

            ////writing employees name to console
            //employee.SayName();
            //employee2.SayName();

            // checking if employees have unique ID
            //if (employee.Id == employee2.Id)
            //    Console.WriteLine("Employee Ids are the same.");
            //else
            //    Console.WriteLine("Employee Ids are not the same.");




            //IQuittable employeeQuit = new Employee();
            //employeeQuit = employee;
            //employee.Quit();
            //Console.ReadLine();
        }
    }
}
