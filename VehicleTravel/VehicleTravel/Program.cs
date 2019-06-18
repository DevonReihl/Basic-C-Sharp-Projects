using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            MilesTraveled milesTraveled = new MilesTraveled(); // instantiates the class
            milesTraveled.computeMilesTraveled(speed: 30, hours: 4);

        }

    }
}


