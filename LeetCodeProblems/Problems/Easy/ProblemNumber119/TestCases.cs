using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber119
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            /*
            IList<int> outPut1 = Solution.GetRow(3);
            int[] soughtResult1 = [1, 3, 3, 1];

            if (!Enumerable.SequenceEqual(outPut1, soughtResult1))
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }
            IList<int> outPut2 = Solution.GetRow(0);
            int[] soughtResult2 = [1];

            if (!Enumerable.SequenceEqual(outPut2, soughtResult2))
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            IList<int> outPut3 = Solution.GetRow(1);
            int[] soughtResult3 = [1, 1];

            if (!Enumerable.SequenceEqual(outPut3, soughtResult3))
            {
                Console.WriteLine("[Problem N389] --> Test Case 3 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut3}");
                return false;
            }
            */

            IList<int> outPut4 = Solution.GetRow(30);
            int[] soughtResult4 = [1, 30, 435, 4060, 27405, 142506, 593775, 2035800, 5852925, 14307150, 30045015, 54627300, 86493225, 119759850, 145422675, 155117520, 145422675, 119759850, 86493225, 54627300, 30045015, 14307150, 5852925, 2035800, 593775, 142506, 27405, 4060, 435, 30, 1];

            if (!Enumerable.SequenceEqual(outPut4, soughtResult4))
            {
                Console.WriteLine("[Problem N389] --> Test Case 4 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut4}");
                return false;
            }

            return true;
        }
    }
}
