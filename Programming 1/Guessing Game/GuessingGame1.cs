using System;
using System.Collections.Generic;

using System.Text;

namespace ConsoleApplication1
{
    class GuessingGame1
    {

        static string CheckNumber(int X, int Y)
        {
            if (X == Y)
            {
                return "You are correct!!!";
            }
            else if (X > Y)
            {
                return "Your guess is too low.";
            }
            else
            {
                return "Your guess is too high.";
            }
        }
            
        
            
        static void SMain()
        {
            Console.Write("What would you like the maximum limit to be? ");
            int Limit = int.Parse(Console.ReadLine());
            Random random = new Random();
            int RandomNumber = random.Next(0, Limit);
            Console.Write("Guess the number: ");
            int Guess = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckNumber(RandomNumber, Guess));

            Console.WriteLine("The number was: " + RandomNumber);
            Console.Write("Press enter to end.");
            Console.ReadLine();

        }

        
    }
        
  
}
    