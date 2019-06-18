using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTravel
{
    public class MilesTraveled
    {
        

        //Calculate how many hours they have driven
        public static void milesTraveled(int speed, int miles)
        {
            float hours = miles / speed;
            Console.WriteLine(speed);
        }
        
    }
}
