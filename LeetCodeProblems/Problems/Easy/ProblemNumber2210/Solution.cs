namespace LeetCodeProblems.Problems.Easy.ProblemNumber2210
{
    public static class Solution
    {
        public static int CountHillValley(int[] nums)
        {
            int hill = 0;
            int valley = 0;

            nums = RemoveEqualsNeighbors(nums);

            for (int i = 1; i < nums.Length - 1; i++)
            {
                int current = nums[i];
                int leftNeighbor = nums[i - 1];
                int rightNeighbor = nums[i + 1];

                if (current > leftNeighbor && current > rightNeighbor)
                    hill++;
                else if (current < leftNeighbor && current < rightNeighbor)
                    valley++;
            }

            return hill + valley;
        }

        private static int[] RemoveEqualsNeighbors(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
                return nums;

            int j = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[j])
                {
                    j++;
                    nums[j] = nums[i];
                }
            }

            int[] result = new int[j + 1];
            Array.Copy(nums, result, j + 1);

            return result;
        }
    }
}
