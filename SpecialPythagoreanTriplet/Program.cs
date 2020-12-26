using System;
using _0_Base;

namespace SpecialPythagoreanTriplet
{
    class Program : SolverBase
    {
        /*
         A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

         a2 + b2 = c2
         For example, 3 2 + 4 2 = 9 + 16 = 25 = 5 2.
         
         There exists exactly one Pythagorean triplet for which a + b + c = 1000.
         Find the product abc.
         */
        static void Main(string[] args)
        {
            var sumOfabc = 1000;
            bool found = false;
            double a = 0;
            double b = 1;
            int c = 0;

            while(a+b+c <= sumOfabc)
            {
                c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) % 1 == 0 ? (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) : 0;

                while (a + b + c <= sumOfabc)
                {
                    c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) % 1 == 0 ? (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) : 0;

                    if (a + b + c == sumOfabc && a < b && b < c)
                    {
                        Console.WriteLine($"Found: {a}+{b}={c}");
                        found = true;
                        break;
                    }

                    b++;
                }

                if(found)
                {
                    break;
                }

                if (a+b+c == sumOfabc && a < b && b < c)
                {
                    Console.WriteLine($"Found: {a}+{b}={c}");
                    break;
                }

                a++;
                b = a + 1;
                c = 0;
            }

            ShowResults(9, a * b * c);            
        }
    }
}
