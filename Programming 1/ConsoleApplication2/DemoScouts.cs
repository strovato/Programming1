using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4A2
{
    
    public class GirlScout
    {
        public const string motto = "To obey the Girl Scout law.";

        
        public string ScoutName { get; set; }
        public int TroopNumber { get; set; }
        public double DuesOwed { get; set; }

        
        public GirlScout()
        {
            ScoutName = "Demo";
            TroopNumber = 500;
            DuesOwed = 0.00;
        }
        
        

        

        

    }

    class DemoScouts : GirlScout
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the Scout's name: ");
            string X = Console.ReadLine();
            Console.Write("Enter the Scout's TroopNumber: ");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Scout's dues owed: ");
            double Z = Convert.ToDouble(Console.ReadLine());

            GirlScout scout1 = new GirlScout();
            GirlScout scout2 = new GirlScout {ScoutName = X, TroopNumber = Y, DuesOwed = Z };
            
            
            DisplayInfo(scout1);
            DisplayInfo(scout2);
            


            Console.Write("\nPress any key to quit.");
            Console.ReadKey();
        }
        
        
        
        
        
        static void DisplayInfo(GirlScout scout)
        {
            
            Console.WriteLine("\n\nGirl Scout {0} created.\nTroop Number: {1}\nDues Owed: {2}",
                scout.ScoutName, scout.TroopNumber, scout.DuesOwed.ToString("C"));
            Console.WriteLine(GirlScout.motto);

        }
    }
    
    
    
    
}
