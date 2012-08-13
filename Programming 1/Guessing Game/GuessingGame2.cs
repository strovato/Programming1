using System;
using System.Collections.Generic;

using System.Text;

namespace ConsoleApplication1
{
    class GuessingGame2
    {
        static int Tries = 0;
        static int Guess = 0;
        /*
        static string GuessNumber(int X)
        {
            do
            {
                Console.WriteLine("Guess the number: ");
                Guess = int.Parse(Console.ReadLine());
                if (X == Guess)
                {
                    Tries++;
                    return "You are correct!!!";
                }
                else if (X > Guess)
                {
                    Tries++;
                    Console.WriteLine("Your guess is too low.");
                }
                else
                {
                    Tries++;
                    Console.WriteLine("Your guess is too high.");
                }

            } while (X != Guess);
        }
         */



        static void SubMain()
        {
            Console.Write("What would you like the maximum limit to be? ");
            int Limit = int.Parse(Console.ReadLine());
            Random random = new Random();
            int RandomNumber = random.Next(0, Limit);
            
            //Console.WriteLine(GuessNumber(RandomNumber));
            
            //Want this to be a seperate Method
            do
            {
                Console.Write("Guess the number: ");
                Guess = int.Parse(Console.ReadLine());
                if (RandomNumber == Guess)
                {
                    Tries++;
                    Console.WriteLine("You are correct!!!");
                }
                else if (RandomNumber > Guess)
                {
                    Tries++;
                    Console.WriteLine("Your guess is too low.");
                }
                else
                {
                    Tries++;
                    Console.WriteLine("Your guess is too high.");
                }

            } while (RandomNumber != Guess);

            // Method ends here

            if (Tries == 1)
            {
                Console.WriteLine("You got it on your first try!!!");
            }
            else
            {
                Console.WriteLine("It took you " + Tries + " tries.");
            }
            Console.WriteLine("The number was: " + RandomNumber);
            Console.Write("Press enter to end.");
            Console.ReadLine();

        }
    }
}