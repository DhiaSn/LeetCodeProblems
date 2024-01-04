using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber2351
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            char outPut1 = Solution.RepeatedCharacter("abccbaacz");
            if (outPut1 != 'c')
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }

            char outPut2 = Solution.RepeatedCharacter("abcdd");
            if (outPut2 != 'd')
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            return true;
        }
    }
}
