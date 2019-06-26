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
            Console.WriteLine("Please give me a number to file.");
            string fileNumber = Console.ReadLine();
            File.WriteAllText(@"C:\Users\user\Desktop\TechAcademy\C#-.net\The-Tech-Academy-Basic-C-Sharp-Projects\log.txt", fileNumber);
            Console.WriteLine(fileNumber);
            Console.ReadLine();
        }
    }
}
