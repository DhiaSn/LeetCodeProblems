using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber804
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            /*
            int outPut1 = Solution.UniqueMorseRepresentations(["gin", "zen", "gig", "msg"]);
            if (outPut1 != 2)
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }
            */
            int outPut2 = Solution.UniqueMorseRepresentations(["a"]);
            if (outPut2 != 1)
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            return true;
        }
    }
}
