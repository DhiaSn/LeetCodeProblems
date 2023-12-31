using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber2210
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            /*
            int outPut1 = Solution.CountHillValley([2, 4, 1, 1, 6, 5]);
            if (outPut1 != 3)
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }
            
            int outPut2 = Solution.CountHillValley([6, 6, 5, 5, 4, 1]);
            if (outPut2 != 0)
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }
            */
           
            int outPut3 = Solution.CountHillValley([5, 7, 7, 1, 7]);
            if (outPut3 != 2)
            {
                Console.WriteLine("[Problem N389] --> Test Case 3 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut3}");
                return false;
            }
            return true;
        }
    }
}
