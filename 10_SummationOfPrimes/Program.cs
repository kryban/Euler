using System;
using System.Threading;
using System.Threading.Tasks;
using _0_Base;

namespace _10_SummationOfPrimes
{
    class Program : SolverBase
    {
        /*
         The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
         Find the sum of all the primes below two million.
         */

        static void Main(string[] args)
        {
            long sum = 0;

            Parallel.For(2, 2000000, i =>
            {
                if (IsPrime(i))
                {
                    Interlocked.Add(ref sum, i);
                }
            });

            ShowResults(10, sum);
        }

        public static bool IsPrime(int number)
        {
            int counter = 0;
            
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;

                    if(counter > 2)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
