using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber35
{
    public static class Solution
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int length = nums.Length;
            int left = 0;
            int right = length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (nums[middle] == target)
                    return middle;
                else if (nums[middle] > target)
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return left;
        }
    }
}
