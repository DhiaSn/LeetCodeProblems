namespace LeetCodeProblems.Problems.Easy.ProblemNumber2525
{
    public static class Solution
    {
        public static string CategorizeBox(int length, int width, int height, int mass)
        {
            double minToGetBulky = 10000;

            bool isBulky = length >= minToGetBulky || width >= minToGetBulky || height >= minToGetBulky || mass >= minToGetBulky;

            if (!isBulky)
                isBulky = (ulong)(length * width) * (ulong)height >= 1000000000;

            bool isHeavy = mass >= 100;

            if (isBulky && isHeavy)
                return "Both";
            else if (!isHeavy && !isBulky)
                return "Neither";
            else if (isBulky && !isHeavy)
                return "Bulky";
            else
                return "Heavy";
        }
    }
}
