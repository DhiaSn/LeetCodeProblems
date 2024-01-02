using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber2937
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            int outPut1 = Solution.FindMinimumOperations("abc", "abb", "ab");
            if (outPut1 != 2)
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }
            int outPut2 = Solution.FindMinimumOperations("dac", "bac", "cac");
            if (outPut2 != -1)
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            int outPut3 = Solution.FindMinimumOperations("a", "aabc", "a");
            if (outPut3 != 3)
            {
                Console.WriteLine("[Problem N389] --> Test Case 3 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut3}");
                return false;
            }

            int outPut4 = Solution.FindMinimumOperations("cbba", "cbaa", "c");
            if (outPut4 != 6)
            {
                Console.WriteLine("[Problem N389] --> Test Case 4 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut4}");
                return false;
            }

            return true;
        }
    }
}
