namespace LeetCodeProblems.Problems.Easy.ProblemNumber1281
{
    public static class Solution
    {
        public static int SubtractProductAndSum(int n)
        {
            int productDigit = 1;
            int sumDigit = 0;

            int lenght = (int)Math.Floor(Math.Log10(n)) + 1;

            int i = 0;
            while (i < lenght)
            {
                int target = (int)((n % Math.Pow(10, i + 1)) / Math.Pow(10, i));

                productDigit *= target;
                sumDigit += target;

                i++;
            }

            return productDigit - sumDigit;
        }
    }
}
