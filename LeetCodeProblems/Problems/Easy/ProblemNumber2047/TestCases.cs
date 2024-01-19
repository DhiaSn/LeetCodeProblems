using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber2047
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            int outPut1 = Solution.CountValidWords("cat and  dog");
            if (outPut1 != 3)
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }

            int outPut2 = Solution.CountValidWords("!this  1-s b8d!");
            if (outPut2 != 0)
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            int outPut3 = Solution.CountValidWords("alice and  bob are playing stone-game10");
            if (outPut3 != 5)
            {
                Console.WriteLine("[Problem N389] --> Test Case 3 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut3}");
                return false;
            }

            int outPut4 = Solution.CountValidWords("he bought 2 pencils, 3 erasers, and 1  pencil-sharpener.");
            if (outPut4 != 6)
            {
                Console.WriteLine("[Problem N389] --> Test Case 4 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut4}");
                return false;
            }

            int outPut5 = Solution.CountValidWords("!");
            if (outPut5 != 1)
            {
                Console.WriteLine("[Problem N389] --> Test Case 5 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut5}");
                return false;
            }

            int outPut6 = Solution.CountValidWords("0");
            if (outPut6 != 0)
            {
                Console.WriteLine("[Problem N389] --> Test Case 6 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut6}");
                return false;
            }

            int outPut7 = Solution.CountValidWords(" , wn xhx5e2  9k !  fs uc5jc  u3  f5 lj x mkkouek, .g");
            if (outPut7 != 7)
            {
                Console.WriteLine("[Problem N389] --> Test Case 7 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut7}");
                return false;
            }

            return true;
        }
    }
}
