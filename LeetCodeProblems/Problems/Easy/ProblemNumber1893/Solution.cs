namespace LeetCodeProblems.Problems.Easy.ProblemNumber1893
{
    public static class Solution
    {
        public static bool IsCovered(int[][] ranges, int left, int right)
        {
            for (int i = left; i <= right; i++)
            {
                bool isCovered = false;

                for (int j = 0; j < ranges.Length; j++)
                    if (ranges[j][0] <= i && ranges[j][1] >= i)
                    {
                        isCovered = true;
                        break;
                    }
                if (!isCovered)
                    return false;
            }
            return true;

        }
    }
}
