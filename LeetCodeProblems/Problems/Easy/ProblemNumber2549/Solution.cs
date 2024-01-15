namespace LeetCodeProblems.Problems.Easy.ProblemNumber2549
{
    public static class Solution
    {
        public static int DistinctIntegers(int n)
        {
            if (n == 1)
                return n;
            else if (n == 2)
                return 1;

            int i = n - 1;
            while (i > 0)
            {
                if (n % i == 1)
                    break;
                i--;
            }

            return i;
        }
    }
}
