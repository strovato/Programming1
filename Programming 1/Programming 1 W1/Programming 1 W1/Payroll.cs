using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Payroll
{
    public static void SubMain()
    {
       
        Console.Write("Enter your Name: ");
        string Name = Console.ReadLine();
        int I = 0;
        string Social;
        do 
        {
            Console.Write("Enter your SSN: ");
            Social = Console.ReadLine();
            if (Social.Length == 9)
            {
                I++;
            }
                if (Social.Length < 9)
                {
                    Console.WriteLine("SSN is not long enough.");
                }
                    if (Social.Length > 9)
                    {
                        Console.WriteLine("SSN is too long (no dashes).");
                    }   
        } while (I < 1);
        Console.Write("Enter your Hourly pay Rate: ");
        decimal Rate = decimal.Parse(Console.ReadLine());
        Console.Write("Enter your Number of hours worked: ");
        decimal Hour = decimal.Parse(Console.ReadLine());
        Console.WriteLine();
        
        string DisplaySocial = Social.Insert(5, "-").Insert(3, "-");
        decimal FedRate = .15m;
        decimal StateRate = .05m;
        decimal Gross = Rate * Hour;
        decimal Fed = Gross * FedRate;
        decimal State = Gross * StateRate;
        decimal Net = Gross - (Fed + State);
        Math.Round(Gross, 2);
        Math.Round(Fed, 2);
        Math.Round(State, 2);
        Math.Round(Net, 2);
        Math.Round(Rate, 2);
        Math.Round(Hour, 2);
        Console.WriteLine("Payroll Summary for: " + Name);
        Console.WriteLine("SSN: " + DisplaySocial);
        Console.WriteLine("You earned $" + Gross + " at $" + Rate + " per hour");
        Console.WriteLine();
        Console.WriteLine("Gross pay:               $" + Gross);
        Console.WriteLine("Federal withholding:     $" + Fed);
        Console.WriteLine("State withholding:        $" + State);
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Net pay:                 $" + Net);
    }
}