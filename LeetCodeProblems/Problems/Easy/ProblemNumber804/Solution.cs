namespace LeetCodeProblems.Problems.Easy.ProblemNumber804
{
    public static class Solution
    {
        public static int UniqueMorseRepresentations(string[] words)
        {
            Dictionary<char, string> keyValuePairs = new Dictionary<char, string>()
            {
                { 'a', ".-" }, { 'b', "-..." }, { 'c', "-.-." }, { 'd', "-.." }, { 'e', "." }, { 'f', "..-." }, { 'g', "--." }, { 'h', "...." }, { 'i', ".." }, { 'j', ".---" }, { 'k', "-.-" }, { 'l', ".-.." }, { 'm', "--" }, { 'n', "-." }, { 'o', "---" }, { 'p', ".--." }, { 'q', "--.-" }, { 'r', ".-." }, { 's', "..." }, { 't', "-" }, { 'u', "..-" }, { 'v', "...-" }, { 'w', ".--" }, { 'x', "-..-" }, { 'y', "-.--" }, { 'z', "--.." }
            };

            string[] resultList = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                string result = string.Empty;
                foreach (char letter in words[i])
                {
                    result += $"{keyValuePairs[letter]}";
                }
                resultList[i] = result;
            }   
 
            return resultList.Distinct().Count();
        }
    }
}
