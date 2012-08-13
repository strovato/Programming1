using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;



public class EnsureValidPayrate
{
    public static void Main()
    {
        bool I = false;
        int Chances = 2;
        decimal PayRate = 0;
        //These lines will allow you to ask for the number of chances before the error message.
        //Console.WriteLine("How many chances would you like to enter a correct amount? ");
        //int Chances = int.Parse(Console.ReadLine());           
        
        for (int X = 0; X < Chances; X++)
        {
            Console.Write("Enter an hourly pay rate: ");
            PayRate = decimal.Parse(Console.ReadLine());
            if (PayRate > 5.65m && PayRate < 49.99m)
            {
                X = Chances;
                I = true;
            }
        }

        if (I)
        {
            Console.WriteLine("Pay rate is: $" + PayRate);
        }
        else
        {
            Console.WriteLine("You entered an invalid pay rate.");
        }
        Console.Write("Press enter to end.");
        Console.ReadKey();


    }
}

