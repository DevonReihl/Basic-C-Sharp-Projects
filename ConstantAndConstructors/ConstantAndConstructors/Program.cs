using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantAndConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string companyName = "Reihl Roots Entreprises"; // constant variable

            Console.WriteLine("Welcome to {0}, How can our company help you today?", companyName);
            Console.WriteLine("Please tell us your name.");
            var name = Console.ReadLine();
            Console.ReadLine();
        }
    }
}
