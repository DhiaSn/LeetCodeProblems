using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber2710
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            string outPut1 = Solution.RemoveTrailingZeros("51230100");
            if (outPut1 != "512301")
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }

            string outPut2 = Solution.RemoveTrailingZeros("123");
            if (outPut2 != "123")
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            return true;
        }
    }
}
