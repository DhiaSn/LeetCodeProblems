namespace LeetCodeProblems.Problems.Easy.ProblemNumber283
{
    public static class Solution
    {
        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length > 1)
            {
                int nonZeroIndex = 0;

                for (int i = 0; i < nums.Length; i++)
                    if (nums[i] != 0)
                    {
                        if (i != nonZeroIndex)
                            (nums[nonZeroIndex], nums[i]) = (nums[i], nums[nonZeroIndex]);
                        nonZeroIndex++;
                    }
            }
        }
    }
}
