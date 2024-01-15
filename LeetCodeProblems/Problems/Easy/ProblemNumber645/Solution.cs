namespace LeetCodeProblems.Problems.Easy.ProblemNumber645
{
    public static class Solution
    {
        public static int[] FindErrorNums(int[] nums)
        {
            int n = nums.Length;

            int xorResult = 0;
            for (int i = 1; i <= n; i++)
                xorResult ^= i ^ nums[i - 1];

            int rightmostSetBit = xorResult & -xorResult;

            int num1 = 0, num2 = 0;

            foreach (int num in nums)
                if ((num & rightmostSetBit) != 0)
                    num1 ^= num;
                else
                    num2 ^= num;

            for (int i = 1; i <= n; i++)
                if ((i & rightmostSetBit) != 0)
                    num1 ^= i;
                else
                    num2 ^= i;

            foreach (int num in nums)
                if (num == num1)
                    return [num1, num2];

            return [num2, num1];
        }
    }
}
