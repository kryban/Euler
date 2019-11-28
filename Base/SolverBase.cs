using System;

namespace Base
{
    public class SolverBase
    {
        public static void ShowResults(object solution, object answer)
        {
            Console.WriteLine($"Solution Project 3: {solution}. ({answer})");

            Console.WriteLine();
            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }
    }
}
