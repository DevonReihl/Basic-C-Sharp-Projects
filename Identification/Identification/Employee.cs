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

        public void Quit()
        {
            Console.WriteLine("I QUIT!!!");
        }

    }
}
