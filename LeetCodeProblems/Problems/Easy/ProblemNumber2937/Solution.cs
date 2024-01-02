using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber2937
{
    public static class Solution
    {
        public static int FindMinimumOperations(string s1, string s2, string s3)
        {
            if (s1[0] == s2[0] && s2[0] == s3[0])
            {
                int length = int.Min(int.Min(s1.Length, s2.Length), s3.Length);
                int index = 0;

                for (int i = 0; i < length; i++)
                {
                    if (s1[index] == s2[index] && s2[index] == s3[index])
                        index++;
                    else
                        break;
                }
                 
                return s1.Length + s2.Length + s3.Length - index * 3;
            }
            return -1;
        }
    }
}
