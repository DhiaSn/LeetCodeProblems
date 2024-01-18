using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber2357
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            int outPut1 = Solution.MinimumOperations([1, 5, 0, 3, 5]);
            if (outPut1 != 3)
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }
            int outPut2 = Solution.MinimumOperations([0]);
            if (outPut2 != 0)
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            int outPut3 = Solution.MinimumOperations([0,0,0,0]);
            if (outPut3 != 0)
            {
                Console.WriteLine("[Problem N389] --> Test Case 3 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut3}");
                return false;
            }

            int outPut4 = Solution.MinimumOperations([5, 3, 2, 1]);
            if (outPut4 != 4)
            {
                Console.WriteLine("[Problem N389] --> Test Case 4 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut4}");
                return false;
            }

            return true;
        }
    }
}
