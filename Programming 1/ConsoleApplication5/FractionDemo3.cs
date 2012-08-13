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


        public Fraction()
            : this(0, 0, 1)
        {
        }

        public Fraction(int nu, int de)
            : this(0, nu, de)
        {
        }

        public Fraction(int wh, int nu, int de)
        {
            Whole = wh;
            Numerator = nu;
            Denominator = de;


        }

        static int FAN, SAN, FMN, SMN;

        public static Fraction operator +(Fraction first, Fraction second)
        {
            bool check = false;
            int J = 1;

            FAN = first.Numerator;
            SAN = second.Numerator;

            FAN += first.Whole * first.Denominator;
            SAN += second.Whole * second.Denominator;

            while (check != true)
            {
                if (J % first.Denominator == 0 && J % second.Denominator == 0)
                {
                    break;
                }
                J++;
            }

            FAN *= (J / first.Denominator);
            SAN *= (J / second.Denominator);
            int newDenominator = J;
            int newNumerator = FAN + SAN;

            return (new Fraction(newNumerator, newDenominator));
        }

        public static Fraction operator *(Fraction first, Fraction second)
        {

            FMN = first.Numerator;
            SMN = second.Numerator;

            FMN += first.Whole * first.Denominator;
            SMN += second.Whole * second.Denominator;

            int newNumerator = FMN * SMN;
            int newDenominator = first.Denominator * second.Denominator;

            return (new Fraction(newNumerator, newDenominator));
        }



    }

    class Run : Fraction
    {
        static void Main(string[] args)
        {
            
            string exit = "go";
            while (exit != "exit")
            {
                
                Fraction[] fracArray = new Fraction[4];
                Fraction[] addResults = new Fraction[16];
                Fraction[] multResults = new Fraction[16];
                
                int c = 0;
                Console.WriteLine("\nEnter the four fractions: ");

                
                for (int r = 0; r < fracArray.Length; r++)
                {
                    
                    fracArray[r] = Enter();
                }


                Console.WriteLine();
                
                
                for (int i = 0; i < fracArray.Length; i++)
                {
                    for (int k = 0; k < fracArray.Length; k++)
                    {
                        addResults[c] = fracArray[i] + fracArray[k];
                        Reduce(addResults[c]);
                        Console.WriteLine("{0,6} + {1,6} = {2,10}", Display(fracArray[i]), Display(fracArray[k]), Display(addResults[c]));
                        c++;
                    }
                }

                c = 0;

                for (int l = 0; l < fracArray.Length; l++)
                {
                    for (int p = 0; p < fracArray.Length; p++)
                    {
                        multResults[c] = fracArray[l] * fracArray[p];
                        Reduce(multResults[c]);
                        Console.WriteLine("{0,6} * {1,6} = {2,10}", Display(fracArray[l]), Display(fracArray[p]), Display(multResults[c]));
                        c++;
                    }
                }
                

                /*
                for (int tmp = 0; tmp < addResults.Length; tmp++)
                {
                    Reduce(addResults[tmp]);
                    Console.WriteLine(Display(addResults[tmp]));
                }
                 */
                                
                


                Console.Write("\nType exit to quit: ");
                exit = Console.ReadLine();
            }
        }

        static Fraction Enter()
        {
            Console.Write("\nWhole number: ");
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





