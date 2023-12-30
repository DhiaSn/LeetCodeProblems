using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber997
{
    public static class Solution
    {
        public static int FindJudge(int n, int[][] trust)
        {
            if (trust.Length == 0 && n == 1)
                return n;

            List<int> potentialJudge = [];
            List<int> people = [];

            for (int i = 0; i < trust.Length; i++)
            {
                if (potentialJudge.Contains(trust[i][0]))
                    potentialJudge.Remove(trust[i][0]);
                else
                    potentialJudge.Add(trust[i][1]);
                people.Add(trust[i][0]);
            }

            potentialJudge = potentialJudge.Distinct().Except(people).ToList();

            return potentialJudge.Count != 1 ? -1 : potentialJudge.First();
        }
    }
}
