using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber2553
{
    public static class Solution
    {
        public static int[] SeparateDigits(int[] nums)
        {
            List<int> result = [];
            foreach (int num in nums)
            {
                if (num < 9)
                    result.Add(num);
                else
                {
                    int temp = num;
                    List<int> digits = [];

                    while (temp != 0)
                    {
                        digits.Add(temp % 10);
                        temp /= 10;
                    }

                    for (int i = digits.Count - 1; i >= 0; i--)
                        result.Add(digits[i]);
                }
            }

            return [.. result];
        }
    }
}
