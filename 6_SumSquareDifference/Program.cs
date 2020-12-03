using System;

namespace _6_SumSquareDifference
{
    /*
    The sum of the squares of the first ten natural numbers is: 1(2)+2(2)+...+10(2) = 385
    The square of the sum of the first ten natural numbers is: (1+2+...+10)(2) = 55(2) = 3025
    Hence the difference between the sum of the squares of the first ten natural numbers 
    and the square of the sum is 3025 - 385 = 3025.
    
    Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    */

    class Program : _0_Base.SolverBase
    {
        static void Main(string[] args)
        {
            int maxNumbers = 100;
            var sumOfSquares = 0;
            var squareOfSum = 0;

            for (int i = 0; i <= maxNumbers; i++)
            {
                sumOfSquares += i * i;
                squareOfSum += i;

                if(i % 5 == 0)
                    Console.WriteLine($"{i}%");
            }

            squareOfSum *= squareOfSum;
            var solution = squareOfSum - sumOfSquares;

            ShowResults(6, solution);
        }
    }
}
