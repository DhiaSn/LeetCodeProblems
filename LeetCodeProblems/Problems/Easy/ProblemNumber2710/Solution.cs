using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber2710
{
    public static class Solution
    {
        public static string RemoveTrailingZeros(string num)
        {
            while(true)
            {
                if (num[^1] == '0')
                    num = num[..^1];
                else
                    break;
            }

            return num; 
        }
    }
}
