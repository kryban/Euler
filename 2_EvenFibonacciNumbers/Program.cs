﻿using System;

namespace _2_EvenFibonacciNumbers
{
    /*
     Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
     By starting with 1 and 2, the first 10 terms will be:
     1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
     By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
     find the sum of the even-valued terms.
     */

    class Program
    {
        static void Main(string[] args)
        {
            int solution = 0;

            int furtherPrevious = 0;
            int closestPrevious = 1;
            int maximumValue = 4000000;

            while (closestPrevious < maximumValue)
            {
                int nextFibonacci = closestPrevious + furtherPrevious;

                furtherPrevious = closestPrevious;
                closestPrevious = nextFibonacci;

                if(nextFibonacci % 2 == 0)
                {
                    solution += nextFibonacci;
                }
            }

            Console.WriteLine($"Solution Project 1: {solution}");

            Console.WriteLine();
            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }
    }
}