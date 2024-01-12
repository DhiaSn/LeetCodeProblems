using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber283
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            Solution.MoveZeroes([3, 0, 2, 0, 12]);
            Solution.MoveZeroes([0, 1, 0, 3, 12]);
            Solution.MoveZeroes([0]);
            Solution.MoveZeroes([0, 0, 1]);
            Solution.MoveZeroes([0,0]);
            return true;
        }
    }
}
