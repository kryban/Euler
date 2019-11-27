using System;
using System.Collections.Generic;

namespace _3_LargestPrimeFactor
{
    /*
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143 ?
     */

    class Program
    {
        static void Main(string[] args)
        {
            long solution = 0;
            long max = 600851475143;

            List<long> priemgetallen = new List<long>();

            for (long natuurlijkGetal = 1; natuurlijkGetal < max; natuurlijkGetal++)
            {
                BepaalPriemgetal(natuurlijkGetal, priemgetallen);

                long subtotaal = AllePriemGetallenVermenigvuldigd(priemgetallen);
                
                if (subtotaal > max)
                {
                    priemgetallen.RemoveAt(priemgetallen.Count - 1);
                    solution = priemgetallen[priemgetallen.Count-1];
                    max = natuurlijkGetal -1;
                }
                if(subtotaal == max)
                {
                    solution = priemgetallen[priemgetallen.Count-1]; ;
                    max = natuurlijkGetal - 1;
                }
            }



            Console.WriteLine($"Solution Project 3: {solution}");

            Console.WriteLine();
            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }

        private static long AllePriemGetallenVermenigvuldigd(List<long> priemgetallen)
        {
            long retval = 0;
            long vorigePriem = 0;
            foreach(long priemgetal in priemgetallen)
            {
                retval += vorigePriem * priemgetal;
                vorigePriem = priemgetal;
            }

            return retval;
        }

        private static void BepaalPriemgetal(long natuurlijkGetal, List<long> priemgetallen)
        {
            long deelTeller = 0;
            for (int i = 1; i <= natuurlijkGetal; i++)
            {                                
                if ( natuurlijkGetal % i == 0)
                {
                    deelTeller++;
                }

                if (i == natuurlijkGetal && deelTeller == 2)
                {
                    priemgetallen.Add(natuurlijkGetal);
                }
            }
        }
    }
}
