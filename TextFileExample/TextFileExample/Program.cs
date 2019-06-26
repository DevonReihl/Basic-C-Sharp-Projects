using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            var currentTime = DateTime.Now;
            Console.WriteLine("Please give me a number to file.");
            double fileNumber = Convert.ToDouble(Console.ReadLine());
            var futureTime = currentTime.AddHours(fileNumber);
            Console.WriteLine("The time will be " +futureTime+ " if we add your number as hours.");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
