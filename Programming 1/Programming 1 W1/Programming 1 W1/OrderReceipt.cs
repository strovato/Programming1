using System;
using System.Collections.Generic;
using System.Text;

public class CommandLine

{
    public static void Main()
    {
       
        Console.Write("Enter your Name: ");
        string Name = Console.ReadLine();
        Console.Write("Street address: ");
        string Address = Console.ReadLine();
        Console.Write("City: ");
        string City = Console.ReadLine();
        Console.Write("State: ");
        string State = Console.ReadLine();
        Console.Write("Zip code: ");
        string Zip = Console.ReadLine();
        Console.Write("How many magic blenders do you want to order? ");
        decimal Quantity = decimal.Parse(Console.ReadLine());


        Math.Round(Quantity, 2);
        decimal Price = 39.95m;
        decimal TaxRate = .07m;
        decimal Gross = Quantity * Price;
        decimal Tax = Gross * TaxRate;
        decimal Net = Gross - Tax;
        Math.Round(Gross, 2);
        Math.Round(Tax, 2);
        Math.Round(Net, 2);
        Console.WriteLine();
        Console.WriteLine("Receipt for: ");
        Console.WriteLine(Name);
        Console.WriteLine(Address);
        Console.WriteLine(City + ", " + State + " " + Zip);
        Console.WriteLine();
        Console.WriteLine(Quantity + " blenders ordered @ $" + Price + " each");
        Console.WriteLine(); 
        Console.WriteLine("Total:                $" + Gross);
        Console.WriteLine("Tax:                    $" + Tax);
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Due:                   $" + Net);
        Console.Write("Press enter to end.");
        Console.ReadKey();
    }

}