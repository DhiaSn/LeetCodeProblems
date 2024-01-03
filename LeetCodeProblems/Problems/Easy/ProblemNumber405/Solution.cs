using System.Text;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber405
{
    public static class Solution
    {
        public static string ToHex(int num)
        {
            if (num >= 0 && num <= 9)
                return $"{num}";

            long target = num;

            if (num < 0)
                target = (4294967296 - (target * -1));

            Dictionary<long, char> HexNumber = new() { { 10, 'a' }, { 11, 'b' }, { 12, 'c' }, { 13, 'd' }, { 14, 'e' }, { 15, 'f' } };

            var resultBuilder = new StringBuilder();

            while (true)
            {
                long quotient = target / 16;
                long remainder = target % 16;

                if (remainder > 9)
                    resultBuilder.Insert(0, HexNumber[remainder]);
                else
                    resultBuilder.Insert(0, remainder);

                target = quotient;
                if (quotient == 0)
                    break;
            }

            return resultBuilder.ToString();
        }
    }
}
