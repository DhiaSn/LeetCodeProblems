using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber202
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            bool outPut1 = Solution.IsHappy(19);
            if (outPut1 != true)
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }
            
            bool outPut2 = Solution.IsHappy(2);
            if (outPut2 != false)
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }
            
            bool outPut3 = Solution.IsHappy(7);
            if (outPut3 != true)
            {
                Console.WriteLine("[Problem N389] --> Test Case 3 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut3}");
                return false;
            }

            bool outPut4 = Solution.IsHappy(5);
            if (outPut4 != false)
            {
                Console.WriteLine("[Problem N389] --> Test Case 4 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut4}");
                return false;
            }

            bool outPut5 = Solution.IsHappy(59);
            if (outPut5 != false)
            {
                Console.WriteLine("[Problem N389] --> Test Case 5 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut5}");
                return false;
            }
            bool outPut6 = Solution.IsHappy(99);
            if (outPut6 != false)
            {
                Console.WriteLine("[Problem N389] --> Test Case 6 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut6}");
                return false;
            }

            return true;
        }
    }
}
