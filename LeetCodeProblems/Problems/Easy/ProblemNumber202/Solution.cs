using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber202
{
    public static class Solution
    {
        public static bool IsHappy(int n)
        {
            Stack<int> seen = new();

            while (n != 1 && !seen.Contains(n))
            {
                seen.Push(n);
                int result = 0;

                while (n > 0)
                {
                    int digit = n % 10;
                    result += digit * digit;
                    n /= 10;
                }

                n = result;
            }

            return n == 1;
        }
    }
}
