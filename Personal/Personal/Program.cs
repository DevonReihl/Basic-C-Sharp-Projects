using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create List of 10 employees
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Smith", Id = 1 });
            employees.Add(new Employee() { FirstName = "Mary", LastName = "Gold", Id = 2 });
            employees.Add(new Employee() { FirstName = "Jesse", LastName = "Clark", Id = 3 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Jones", Id = 4 });
            employees.Add(new Employee() { FirstName = "Micheal", LastName = "Grant", Id = 5 });
            employees.Add(new Employee() { FirstName = "Samantha", LastName = "Garduno", Id = 666 });
            employees.Add(new Employee() { FirstName = "Miguel", LastName = "Ricardo", Id = 7 });
            employees.Add(new Employee() { FirstName = "Carissa", LastName = "Lange", Id = 8 });
            employees.Add(new Employee() { FirstName = "Fred", LastName = "Johnson", Id = 9 });
            employees.Add(new Employee() { FirstName = "Sarah", LastName = "Simpson", Id = 10 });
            


            // 2. Use foreach loop to create a list of employees name Joe
            //foreach (Employee employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        List<Employee> employeeNamedJoe = new List<Employee>();
            //        employeeNamedJoe.Add(employee);
            //        foreach (Employee namedJoe in employeeNamedJoe)
            //        {
            //            Console.WriteLine(namedJoe.FirstName + " " + namedJoe.LastName);
            //        }

            //    }

            //}

            //3 use lambda expression to create list of employees named Joe
            List<Employee> newList = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.FirstName + "\t " + employee.LastName);
            }

            //4. use lambda expression to create list of employees with Id higher than 5
            foreach (Employee employee in employees.FindAll(x => x.Id > 5).ToList())
            {
                Console.WriteLine(employee.FirstName + "\t " + employee.LastName);
            }

            Console.ReadLine();
        }
    }
}
