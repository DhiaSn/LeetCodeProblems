using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber2351
{
    public static class Solution
    {
        public static char RepeatedCharacter(string s)
        {
            Dictionary<char, int> keyValuePairs = [];
            foreach (char c in s)
                if (!keyValuePairs.TryAdd(c, 1))
                    return c;
            return ' ';
        }
    }
}
