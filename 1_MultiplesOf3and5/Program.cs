using _0_Base;
using System;

namespace _1_MultiplesOf3and5
{
    /*
     * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
     * The sum of these multiples is 23.
     * Find the sum of all the multiples of 3 or 5 below 1000.
     */
    class Program : SolverBase
    {
        static void Main(string[] args)
        {
            int solution = 0;
            for(int i = 0; i<1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    solution += i;
                }
            }

            ShowResults(1,solution);
        }
    }
}
