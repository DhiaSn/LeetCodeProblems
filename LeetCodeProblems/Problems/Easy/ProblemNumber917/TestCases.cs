using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber917
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            string outPut1 = Solution.ReverseOnlyLetters("ab-cd");
            if (outPut1 != "dc-ba")
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }

            string outPut2 = Solution.ReverseOnlyLetters("a-bC-dEf-ghIj");
            if (outPut2 != "j-Ih-gfE-dCba")
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            string outPut3 = Solution.ReverseOnlyLetters("Test1ng-Leet=code-Q!");
            if (outPut3 != "Qedo1ct-eeLg=ntse-T!")
            {
                Console.WriteLine("[Problem N389] --> Test Case 3 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut3}");
                return false;
            }

            return true;
        }
    }
}
