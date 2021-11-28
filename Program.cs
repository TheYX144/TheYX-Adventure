using System;

namespace TheYX_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TheYX Adventure, a text based adventure.");
            Console.ForegroundColor = ConsoleColor.White;

Console.ReadKey();

            Console.WriteLine("Imagine you are a scientist in a spaceship and you are heading towards a planet to investigate and find out if it is safe to live on.");

            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Captian we are about to land!");

            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("OK! Scientist, do you have your supplies ready?");


            Console.ForegroundColor = ConsoleColor.Green;
            string ready = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;

            if (ready == "Yes") {
                Console.WriteLine("Great! Now that you are ready we should be good to land.");
            }
            else {
                Console.WriteLine("Hurry up!");
            }

            Console.ReadKey();
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("We have landed!");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Alright scientist, find signs that show it is safe to live here.");

            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You exit the spaceship and see water. You take note of this sight and move along. \n You see an alien, what do you do? \n Run / Flee \n Fight");

            string encounter = Console.ReadLine();

            if (encounter == "Fight") {
                Console.WriteLine("You punch the alien and it gets knocked out.");
            } else if (encounter == "Flee" || encounter == "Run") {
                Console.WriteLine("You run away,");
            }

            Console.ReadKey();

            Console.WriteLine("You see the temperature is 33 degrees celcius do you take note of it? \n Yes or No?");
            string yesNo = Console.ReadLine();
            bool tempNote;

            if (yesNo == "Yes") {
                Console.WriteLine("You decide to take note of the temerature. Good idea.");
                tempNote = true;
            } else {
                Console.WriteLine("You decide not to take note of the temperature.");
                tempNote = false;
            }

Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("It seems safe to live here!");
			
			Console.ReadKey();
        }
    }
}
