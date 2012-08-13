using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SmallandLarge
{
    class SmallAndLarge
    {
        static int[] Nums = new int[10];
        
        static void Main(string[] args)
        {
            
            
            
            Console.WriteLine("Enter 10 numbers: ");
            
            for (int I = 0; I < Nums.Length; I++)
            
            {
              
                Nums[I] = Convert.ToInt32(Console.ReadLine());
                
            }
            
            

            Console.Write("\nYour numbers are: ");
            foreach (int X in Nums)
            {
                Console.Write("{0} ", X);
            }

            Limits(Nums);
            

            Console.Write("\nPress any key to quit.");
            Console.ReadKey();

        }

        static void Limits(int [] Z)
        {
            int Max = Z.Max();
            int Min = Z.Min();

            Console.WriteLine("\n\nThe smallest number is {0}, and the largest number is {1}.", Min, Max);
        }
    }
}
