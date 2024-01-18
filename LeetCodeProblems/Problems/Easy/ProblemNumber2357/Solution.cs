namespace LeetCodeProblems.Problems.Easy.ProblemNumber2357
{
    public static class Solution
    {
        public static int MinimumOperations(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0] == 0 ? 0 : 1;

            int countOperation = 0;
            while (true)
            {
                int smallest = GetSmallestNumber(nums);

                if (smallest == 0)
                    return 0;

                int biggestNumber = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    int temp = nums[i] - smallest;
                    if (temp >= 0)
                    {
                        nums[i] = temp;
                        biggestNumber = Math.Max(biggestNumber, temp);
                    }
                }

                countOperation++;

                if (biggestNumber == 0)
                    break;
            }

            return countOperation;

        }

        private static int GetSmallestNumber(int[] nums)
        {
            int smallest = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] < smallest)
                {
                    smallest = nums[i];
                }
            }
            return smallest == int.MaxValue ? 0 : smallest;
        }
    }
}
