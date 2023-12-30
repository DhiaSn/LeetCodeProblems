namespace LeetCodeProblems.Problems.Easy.ProblemNumber997
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            /*
            int outPut1 = Solution.FindJudge(2, [[1, 2]]);
            if (outPut1 != 2)
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }

            int outPut2 = Solution.FindJudge(3, [[1, 3], [2, 3]]);
            if (outPut2 != 3)
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            int outPut3 = Solution.FindJudge(3, [[1, 3], [2, 3], [3, 1]]);
            if (outPut3 != -1)
            {
                Console.WriteLine("[Problem N389] --> Test Case 3 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut3}");
                return false;
            }

            int outPut4 = Solution.FindJudge(4, [[1, 3], [1, 4], [2, 3], [2, 4], [4, 3]]);
            if (outPut4 != 3)
            {
                Console.WriteLine("[Problem N389] --> Test Case 4 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut4}");
                return false;
            }

            int outPut5 = Solution.FindJudge(1, []);
            if (outPut5 != 1)
            {
                Console.WriteLine("[Problem N389] --> Test Case 5 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut5}");
                return false;
            }

            int outPut6 = Solution.FindJudge(2, []);
            if (outPut6 != -1)
            {
                Console.WriteLine("[Problem N389] --> Test Case 6 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut6}");
                return false;
            }

            int outPut7 = Solution.FindJudge(4, [[1, 3], [1, 4], [2, 3]]);
            if (outPut7 != -1)
            {
                Console.WriteLine("[Problem N389] --> Test Case 7 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut7}");
                return false;
            }
            */

            int outPut8 = Solution.FindJudge1(3, [[1, 2], [2, 3]]);
            if (outPut8 != -1)
            {
                Console.WriteLine("[Problem N389] --> Test Case 8 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut8}");
                return false;
            }

            return true;
        }
    }
}
