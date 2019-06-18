using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTravel
{
    public class MilesTraveled
    {
        

        //Method to calculate how many hours they have driven

        
        public void computeMilesTraveled(int speed, int hours)
        {
            int miles = speed * hours;
            Console.WriteLine(miles);
            Console.ReadLine();
        }

        //public static void staticComputeMilesTraveled(int speed, int hours)
        //{
        //    int miles = speed * hours;
        //    Console.WriteLine(miles);
        //    Console.ReadLine();
        //}

    }
}
