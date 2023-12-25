using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy.ProblemNumber917
{
    public static class Solution
    {
        public static string ReverseOnlyLetters(string s)
        {
            string englishLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder result = new(s.Length);

            Dictionary<int, char> specialCharacter = new Dictionary<int, char>();

            for (int i = s.Length - 1; i >= 0; i--) 
            {
                if (englishLetters.Contains($"{s[i]}", StringComparison.CurrentCultureIgnoreCase))
                    result.Append(s[i]);
                else
                    specialCharacter.Add(i, s[i]); 
            }
            specialCharacter = specialCharacter.OrderBy(x => x.Key).ToDictionary();
             
            foreach (var sC in specialCharacter)
            {
                result.Insert(sC.Key, sC.Value);
            }

            return result.ToString(); 
        }
    }
}
