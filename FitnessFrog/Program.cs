﻿using System;

namespace FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {

            var runningTotal = 0.0;

            while (true)
            {
                //Prompt the user for minnuted exercised
                Console.Write("Enter how many minutes you exercised or type 'quit' to exit: ");

                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }



                try
                {
                    var minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {

                        Console.WriteLine(minutes + " is not an acceptable value");
                        continue;
                    }

                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }

                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!");
                    }

                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }

                    else
                    {
                        Console.WriteLine("Okay, now you're just showing off!");
                    }


                    //Add minutes exercised to total

                    runningTotal += minutes;
                }

                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid input");
                    continue;
                }

                //Display total minutes exercised to the screen

                Console.WriteLine("You've entered " + runningTotal + " minutes");

                //Repeat until the user quits


            }

            Console.WriteLine("Goodbye");
        }



    }
}
