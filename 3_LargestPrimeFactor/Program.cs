using _0_Base;
using System.Collections.Generic;

namespace _3_LargestPrimeFactor
{
    /*
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143 ?
     */

    class Program : SolverBase
    {
        static void Main(string[] args)
        {
            int answer = 6857;
            long solution = 0;

            long max = 600851475143;

            long rest = max;

            for (long naturalNumber = 1; naturalNumber < max; naturalNumber++)
            {
                if(IsPrimeNumber(naturalNumber))
                {
                    System.Console.WriteLine($"Calculating next prime number: {naturalNumber}");

                    while (rest % naturalNumber == 0 && rest > 1)
                    {
                        rest /= naturalNumber;
                    }
                }

                if(rest == 1)
                {
                    solution = naturalNumber;
                    max = naturalNumber;
                }
            }

            ShowResults(3,solution);
        }

        private static bool IsPrimeNumber(long naturalNumber)
        {
            long divisibleCounter = 0;
            for (int i = 1; i <= naturalNumber; i++)
            {
                if (naturalNumber % i == 0)
                {
                    divisibleCounter++;
                }

                if (i == naturalNumber && divisibleCounter == 2)
                {
                    return true; ;
                }
            }
            return false;
        }
    }
}
