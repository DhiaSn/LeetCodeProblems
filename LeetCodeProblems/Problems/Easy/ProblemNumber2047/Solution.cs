namespace LeetCodeProblems.Problems.Easy.ProblemNumber2047
{
    public static class Solution
    {
        public static int CountValidWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            int validCounter = 0;
            string patterns = "abcdefghijklmnopqrstuvwxyz?,.!";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 1 && patterns.Contains(words[i]) || System.Text.RegularExpressions.Regex.IsMatch(words[i], @"^(?:[a-z]+(?:-[a-z]+)?[.,!]?)$"))
                    validCounter++;
            }

            return validCounter;
        }
    }
}
