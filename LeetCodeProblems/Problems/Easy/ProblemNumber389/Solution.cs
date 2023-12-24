namespace LeetCodeProblems.Problems.Easy.ProblemNumber389
{
    public static class Solution
    {
        public static char FindTheDifference(string s, string t)
        {

            Dictionary<char, int> sDic = new Dictionary<char, int>();
            Dictionary<char, int> tDic = new Dictionary<char, int>();

            foreach (var item in s)
            {
                if (sDic.ContainsKey(item))
                    sDic[item] = sDic[item] + 1;
                else
                    sDic.Add(item, 1);

            }
            foreach (var item in t)
            {
                if (tDic.ContainsKey(item))
                    tDic[item] = tDic[item] + 1;
                else
                    tDic.Add(item, 1);

            }

            foreach (var tDicitem in tDic)
            {
                if (sDic.TryGetValue(tDicitem.Key, out int value))
                {
                    var sDicitem = value;

                    if (tDicitem.Value > sDicitem)
                        return tDicitem.Key; 
                }
                else
                    return tDicitem.Key; 
            }


            return default;
        }
    }
}
