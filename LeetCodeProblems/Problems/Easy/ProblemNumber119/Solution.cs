using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber119
{
    public static class Solution
    {
        public static IList<int> GetRow(int rowIndex)
        {
            IList<int> row = new List<int>();

            int i = rowIndex;

            long number = 1;
            for (int j = 0; j <= i; j++)
            {
                row.Add((int)number);
                number = number * (i - j) / (j + 1);
            }
            return row; 
        }
    }
}
