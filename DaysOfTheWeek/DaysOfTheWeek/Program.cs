using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class Program
    {
        public enum DayofWeek
        {
            Monday,
            Tuesday,
            Wendesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            string currentDay = Console.ReadLine();
            
            DayOfWeek day;
            try
            {
                day = (DayOfWeek)Enum.Parse(typeof(DayofWeek), currentDay);
                Console.WriteLine("The current day is: " + currentDay);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Please enter an actual day of the week.");



            }

           
            Console.ReadLine();
        }




        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Please enter the current day of the week.");
        //    string currentDay = Console.ReadLine();

        //        try
        //        {
        //            foreach (string str in Enum.GetNames(typeof(DayofWeek)))
        //                if (currentDay == str)
        //                {
        //                    Console.WriteLine("The current day is: " + str);
        //                }
        //        }

        //        catch
        //        {
        //            Console.WriteLine("Please enter an actual day of the week.");
        //        }

        //        Console.ReadLine();

        //    }
        //}

    }
}
