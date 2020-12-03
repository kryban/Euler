using System;
using _0_Base;

namespace _5_SmallestMultiple
{
    /*
    2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
     */

    class Program: SolverBase
    {
        static void Main(string[] args)
        {
            int maxDivider = 20;
            int calculationNumber = 1;
            int succeededDividers = 0;

            while (succeededDividers != maxDivider)
            {
                calculationNumber++;

                var i = 1;
                var dividerResult = 0;
                succeededDividers = 0;

                while (i <= maxDivider && dividerResult == 0)
                {
                    dividerResult = calculationNumber % i;

                    if (dividerResult > 0)
                        continue;
                    
                    succeededDividers++;
                    i++;

                    if(i > 15) 
                        Console.Write(i);
                }

                if(succeededDividers > 15) 
                    Console.WriteLine($"----- SUBRESULT: {calculationNumber}");
            }

            ShowResults(5, calculationNumber);
        }
    }
}
