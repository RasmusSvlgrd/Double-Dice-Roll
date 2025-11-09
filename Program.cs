using System;

namespace Diceroll_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Random rnd = new Random();
            int roll01 = 0, roll02 = 1;
            int attempts = 0;

            Console.WriteLine("Try to hit two same dice! \nClick enter to roll!");

            while (roll01 != roll02) 
            {
                attempts++;
                Console.ReadKey();
                roll01 = rnd.Next(1, 7);
                roll02 = rnd.Next(1, 7);
                Console.WriteLine("You rolled a " + roll01 + " and a " + roll02 + "!");
            }

            Console.WriteLine("It took you " + attempts + "attempt(s) to roll the same dice!");

            Console.ReadKey();
        }
    }
}
