using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4A3
{

    public class Fraction
    {
        
        public int Whole { get; set; }
        public int Numerator { get; set; }
        private int denominator;
        public int Denominator 
        { 
            get
            {
                 return denominator;
            }
            set
            {
                if (value == 0)
                    denominator = 1;
                else
                    denominator = value;
             }
            
        }
        
        
        public Fraction() : this(0, 0, 1)
        {  
        }
        
        public Fraction(int nu, int de) : this(0, nu, de)
        {
        }

        public Fraction(int wh, int nu, int de)
        {
            Whole = wh;
            Numerator = nu;
            Denominator = de;
            
            
        }

        public static Fraction operator+(Fraction first, Fraction second)
        {
            bool check = false;
            int J = 1;
            
            first.Numerator += first.Whole * first.Denominator;
            second.Numerator += second.Whole * second.Denominator;
            
            while (check != true)
                {
                    if (J % first.Denominator == 0 && J % second.Denominator == 0)
                    {
                        break;
                    }
                    J++;
                }

            first.Numerator *= (J / first.Denominator);
            second.Numerator *= (J / second.Denominator);
            int newDenominator = J;
            int newNumerator = first.Numerator + second.Numerator;

            return(new Fraction(newNumerator, newDenominator));
        }
        


    }

    class Run : Fraction
    {
        static void Main(string[] args)
        {
            
            string exit = "go";
            while (exit != "exit")
            {

                Console.WriteLine("\nEnter the first fraction: ");
                Fraction FirstFraction = Enter();
                Console.WriteLine("\nEnter the second fraction: ");
                Fraction SecondFraction = Enter();

                Console.Write("\n\nPress enter to find out what the answer to {0} + {1} is:", Display(FirstFraction), Display(SecondFraction), "is :");
                Fraction Result = FirstFraction + SecondFraction;
                Reduce(Result);
                Console.ReadLine();
                Console.WriteLine("{0}", Display(Result));


                Console.Write("\nType exit to quit: ");
                exit = Console.ReadLine();
            }
        }

        static Fraction Enter()
        {
            Console.Write("Whole number: ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numerator: ");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Denominator: ");
            int Z = Convert.ToInt32(Console.ReadLine());
            Fraction test = new Fraction { Whole = X, Numerator = Y, Denominator = Z };

            Console.Write("\nYou entered: {0}", Display(test));
            Reduce(test);
            Console.Write("\nYour simplified fraction is: {0}", Display(test));
            return test;
        }
        
        static string Display(Fraction frac)
        {
            if (frac.Whole == 0)
            {
                return String.Format("{0}/{1}", frac.Numerator, frac.Denominator);
            }
            else if (frac.Numerator == 0)
            {
                return String.Format("{0}", frac.Whole);
            }
            else
            {
                return String.Format("{0} {1}/{2}", frac.Whole, frac.Numerator, frac.Denominator);
            }
        }

        static void Reduce(Fraction F)
        {
            int A = F.Numerator;
            int B = F.Denominator;
            F.Numerator += F.Whole * F.Denominator;

            while (B != 0)
            {
                int Temp = A % B;
                A = B;
                B = Temp;
            }

            F.Numerator /= A;
            F.Denominator /= A;

            F.Whole = F.Numerator / F.Denominator;
            F.Numerator %= F.Denominator;
        }

        }

    }





