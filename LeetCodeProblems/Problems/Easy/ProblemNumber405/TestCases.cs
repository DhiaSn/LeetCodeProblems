using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber405
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            string outPut1 = Solution.ToHex(26);
            if (outPut1 != "1a")
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }
            string outPut2 = Solution.ToHex(-1);
            if (outPut2 != "ffffffff")
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }
            
            string outPut3 = Solution.ToHex(231);
            if (outPut3 != "e7")
            {
                Console.WriteLine("[Problem N389] --> Test Case 3 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut3}");
                return false;
            }

            string outPut4 = Solution.ToHex(1);
            if (outPut4 != "1")
            {
                Console.WriteLine("[Problem N389] --> Test Case 4 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut4}");
                return false;
            }

            string outPut5 = Solution.ToHex(0);
            if (outPut5 != "0")
            {
                Console.WriteLine("[Problem N389] --> Test Case 5 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut5}");
                return false;
            }
            
            string outPut6 = Solution.ToHex(16);
            if (outPut6 != "10")
            {
                Console.WriteLine("[Problem N389] --> Test Case 6 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut6}");
                return false;
            }

            string outPut7 = Solution.ToHex(5386);
            if (outPut7 != "150a")
            {
                Console.WriteLine("[Problem N389] --> Test Case 7 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut7}");
                return false;
            }
            
            string outPut8 = Solution.ToHex(-2);
            if (outPut8 != "fffffffe")
            {
                Console.WriteLine("[Problem N389] --> Test Case 8 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut8}");
                return false;
            }

            string outPut9 = Solution.ToHex(-2147483648);
            if (outPut9 != "80000000")
            {
                Console.WriteLine("[Problem N389] --> Test Case 9 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut9}");
                return false;
            }

            return true;
        }
    }
}
