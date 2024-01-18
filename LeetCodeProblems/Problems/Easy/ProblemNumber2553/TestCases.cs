using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber2553
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            int[] outPut1 = Solution.SeparateDigits([13, 25, 83, 77]);

            if (Enumerable.SequenceEqual(outPut1, [1, 3, 2, 5, 8, 3, 7, 7]))
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }

            int[] outPut2 = Solution.SeparateDigits([7, 1, 3, 9]);
            if (Enumerable.SequenceEqual(outPut1, [7, 1, 3, 9]))
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            return true;
        }
    }
}
