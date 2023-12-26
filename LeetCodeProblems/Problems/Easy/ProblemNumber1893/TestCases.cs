namespace LeetCodeProblems.Problems.Easy.ProblemNumber1893
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            bool outPut1 = Solution.IsCovered([[1, 2], [3, 4], [5, 6]], 2, 5);
            if (outPut1 != true)
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }

            bool outPut2 = Solution.IsCovered([[1, 10], [10, 20]], 21, 21);
            if (outPut2 != false)
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }
            
            bool outPut3 = Solution.IsCovered([[1, 50]], 1, 50);
            if (outPut3 != true)
            {
                Console.WriteLine("[Problem N389] --> Test Case 3 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut3}");
                return false;
            }
            bool outPut4 = Solution.IsCovered([[37, 49], [5, 17], [8, 32]], 29, 49);
            if (outPut4 != false)
            {
                Console.WriteLine("[Problem N389] --> Test Case 4 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut4}");
                return false;
            }
            bool outPut5 = Solution.IsCovered([[1, 1]], 1, 50);
            if (outPut5 != false)
            {
                Console.WriteLine("[Problem N389] --> Test Case 5 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut5}");
                return false;
            }

            return true;
        }
    }
}
