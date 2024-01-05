using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber35
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            int outPut1 = Solution.SearchInsert([1, 3, 5, 6], 5);
            if (outPut1 != 2)
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }

            int outPut2 = Solution.SearchInsert([1, 3, 5, 6], 2);
            if (outPut2 != 1)
            {
                Console.WriteLine("[Problem N389] --> Test Case y didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            int outPut3 = Solution.SearchInsert([1, 3, 5, 6], 7);
            if (outPut3 != 4)
            {
                Console.WriteLine("[Problem N389] --> Test Case y didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut3}");
                return false;
            }

            return true;
        }
    }
}
