using System;
using System.Collections.Generic;


namespace IterationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //===============================
            //STEP 1 and STEP 4
            //===============================
            string[] greetings = { "Hi", "Good Morning", "Salutaions", "Hello", "How's it going", "Hola", "Bonjour"};
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();

            for (int i = 0; i < greetings.Length; i++)
            {
                Console.WriteLine(greetings[i] + " " + name);
            }


            //===============================
            //STEP 5  and 2 / 3
            //===============================
            List<int> ages = new List<int>() { 4, 21, 40, 18, 13, 50, 35, 42, 10, 2, 85, 100 };

            foreach (int age in ages)
                if (age <= 18)
                {
                    Console.WriteLine("Your age is: " + age + " Congratulations, you are NOT an adult.");
                }
            int year = 0;
            foreach (int age in ages)//Infinite loop
                while (age > 0)
                {
                    //Console.WriteLine(year ++);
                    Console.WriteLine(year = age);// resolve infinite loop
                }

            //===============================
            //STEP 6, 7, and 8
            //===============================
            List<string> colors = new List<string>();
            colors.Add("blue");
            colors.Add("green");
            colors.Add("maganta");
            colors.Add("teal");
            colors.Add("pink");
            colors.Add("yellow");
            colors.Add("violet");
            colors.Add("black");
            colors.Add("maroon");

            Console.WriteLine("Please give me a color, and we will tell you where to find that color in our paints.");
            string paint = Console.ReadLine();

            foreach (string color in colors)
            {
                if (color == paint)
                    Console.WriteLine("Your color is: " + paint + "Index of: {0}",
                    colors.IndexOf(color));
                else
                {
                    Console.WriteLine("I am sorry we do not carry that color in our paints at this time.");
                    break;
                }
            }

            //===============================
            //STEP 9, 10, and 11
            //===============================

            List<string> songs = new List<string>() { "Hello", "One", "Bad", "Jump", "Creep", "One", "Money", "One" };

            Console.WriteLine("Please pick a song from the following list: \nHello \nOne \nBad \nJump \nCreep \nMoney");
            string userChoice = Console.ReadLine();

            var indices = new List<int>();
            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i] == userChoice)
                {
                    indices.Add(i);
                    Console.Write(userChoice + ":" + i + "\n");
                }
                else if (i == songs.Count)
                {
                    Console.WriteLine("I am sorry I can't find your choice please check that your entry is part of our list.");
                    break;
                }

            }


            songs.Add("Bad"); // Added second duplicate string for step 11
            List<string> songs2 = new List<string>();

            foreach (string song in songs)
            {
                
                if (songs2.Contains(song))
                {                    
                    Console.WriteLine(song + ", This is a duplicate song title.");
                }
                else
                {
                    songs2.Add(song);
                    Console.WriteLine(song);
                }
            }
            
            Console.ReadLine();
        }
    }
}
