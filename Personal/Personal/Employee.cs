using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public List<Employee> Employees { get; set; }

        public void Quit()
        {
            Console.WriteLine("I QUIT!!!");
        }
    }
}
