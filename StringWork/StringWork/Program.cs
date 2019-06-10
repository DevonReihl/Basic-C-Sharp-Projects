using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Devon Reihl";
            string streetAddress = "2030 SW Merlo Ct";
            string city = "Beaverton";
            string state = "Oregon";
            string zipCode = "97003";

            Console.WriteLine("Hi, " + name.ToUpper() + "\nYou live at:\n " + "\t" +streetAddress + "\n\t" +city + " " + state + " " + zipCode);

            StringBuilder paragraph = new StringBuilder("Welcome to the neighborhood.");

            paragraph.Append(" At Merlo Station apartments you will find a family friendly community.");
            paragraph.Append(" We are also pet friendly.");
            paragraph.Append(" With great location close to transit and parks.");
            paragraph.Append(" We hope you love your new place!");
            Console.WriteLine(paragraph);
            Console.ReadLine();
        }
    }
}
