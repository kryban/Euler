using System;
using System.Threading.Tasks;

namespace _7_10001stPrime
{
    class Program : _0_Base.SolverBase
    {
        static void Main(string[] args)
        {
            int maxPrimeNumbers = 10001;
            int primeCounter = 1;
            int progress = 0;
            int number = 0;
            
            while(primeCounter <= maxPrimeNumbers)
            {
                number++;
                if (IsPrime(number))
                    primeCounter++;

                if(primeCounter % 1000 == 0)
                    Console.WriteLine($"Calculated {progress += 1}% (counter( {primeCounter} /{number} ))");
            }

            ShowResults(7, number);

        }

        private static bool IsPrime(long naturalNumber)
        {
            long divisibleCounter = 0;

            for (int i = 1; i <= naturalNumber; i++)
            {
                if (naturalNumber % i == 0)
                {
                    divisibleCounter++;
                }

                if (divisibleCounter > 2)
                {
                    return false;
                }

                if (i == naturalNumber && divisibleCounter == 2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
