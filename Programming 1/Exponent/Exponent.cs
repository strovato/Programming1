using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Exponent
    {
        static int X;

        static void Main(string[] args)
        {
            
            
            Console.Write("Enter a number: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYour number squared is: {0}\n\nYour number cubed is: {1}", Squared(X),Cubed(X));
            Console.ReadLine(); 
                    
        }

        static int Squared(int Z)
        {
            return Z * Z;
        }

        static int Cubed(int Y)
        {
            return Squared(Y) * Y;
        }
        
    }
}
