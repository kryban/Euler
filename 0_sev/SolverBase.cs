using System;
using System.Collections.Generic;
using System.Text;

namespace _0_Base
{
    public class SolverBase
    {
        static void Main(string[] args)
        {

        }
        public static void ShowResults(object solution, object answer)
        {

            Console.WriteLine($"Solution Project 3: {solution}. ({answer})");

            Console.WriteLine();
            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }

    }
}
