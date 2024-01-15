using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber2549
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            /*
            int outPut1 = Solution.DistinctIntegers(5);
            if (outPut1 != 4)
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }

            int outPut2 = Solution.DistinctIntegers(3);
            if (outPut2 != 2)
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            int outPut3 = Solution.DistinctIntegers(1);
            if (outPut3 != 1)
            {
                Console.WriteLine("[Problem N389] --> Test Case 3 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut3}");
                return false;
            }
            */

            int outPut4 = Solution.DistinctIntegers(2);
            if (outPut4 != 1)
            {
                Console.WriteLine("[Problem N389] --> Test Case 4 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut4}");
                return false;
            }

            return true;
        }
    }
}
