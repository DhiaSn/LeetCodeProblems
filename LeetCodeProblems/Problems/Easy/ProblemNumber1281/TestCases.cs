using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber1281
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            int outPut1 = Solution.SubtractProductAndSum(234);
            if (outPut1 != 15)
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }

            int outPut2 = Solution.SubtractProductAndSum(4421);
            if (outPut2 != 21)
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            return true;
        }
    }
}
