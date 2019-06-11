using System;
using System.Collections.Generic;


namespace ArrayListExercise
{
    class Program
    {
        static void Main()
        {
            //STRING ARRAY
            string[] placesArray = { "Paris", "Italy", "Dublin", "Hawaii", "Bahammas", "New York", "Autrailia", "North Pole" };
            int[] daysArray = { 3, 65, 20, 102, 43, 90, 180, 666, 365 };

            Console.WriteLine("Congradulations!! You won a trip to a surprise place. Please give us a number 0-7 to see where you are going");
            int vacationPlace = Convert.ToInt32(Console.ReadLine());

            if (vacationPlace < placesArray.Length)
            {
                while (true)
                {
                    Console.WriteLine("Your going to " + placesArray[vacationPlace]);
                    break;
                }
            }
            else
            {

                Console.WriteLine("You did not pick from our selected options");
            }

            //INT ARRAY
            Console.WriteLine("Now give me a number between 0-8 to see when you leave");
            int days = Convert.ToInt32(Console.ReadLine());



            if (days < daysArray.Length)
            {
                while (true)
                {
                    Console.WriteLine("You leave in " + daysArray[days] + " days");
                    break;
                }
            }
            else
            {

                Console.WriteLine("You did not pick from our selected options");
            }

            //STRING LIST
            List<string> songList = new List<string>();
            songList.Add("Can't Sleep Love");
            songList.Add("Standing By");
            songList.Add("Love Again");
            songList.Add("Rose Gold");
            songList.Add("Royals");
            songList.Add("Run To You");
            songList.Add("Cruisin' For a Bruisin'");
            songList.Add("Radioactive");
            songList.Add("See Through");
            songList.Add("I Need Your Love");
            songList.Add("Light in the Hallway");

            Console.WriteLine("Please help me pick with Pentatonix song to listen to? Give me a number between zero and ten?");
            int song = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thanks, I am going to listen to " + songList[song]);
            
            Console.ReadLine();
        }
    }
}
