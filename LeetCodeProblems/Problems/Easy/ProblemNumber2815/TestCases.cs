namespace LeetCodeProblems.Problems.Easy.ProblemNumber2815
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {

            int outPut1 = Solution.MaxSum([51, 71, 17, 24, 42]);
            if (outPut1 != 88)
            {
                Console.WriteLine("[Problem N2815] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N2815] --> OutPut = {outPut1}");
                return false;
            }

            int outPut2 = Solution.MaxSum([1, 2, 3, 4]);

            if (outPut2 != -1)
            {
                Console.WriteLine("[Problem N2815] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N2815] --> OutPut = {outPut2}");
                return false;
            }

            int outPut3 = Solution.MaxSum([31, 25, 72, 79, 74]);

            if (outPut3 != 146)
            {
                Console.WriteLine("[Problem N2815] --> Test Case 3 didn't work correctly!");
                Console.WriteLine($"[Problem N2815] --> OutPut = {outPut3}");
                return false;
            }

            int outPut4 = Solution.MaxSum([84, 91, 18, 59, 27, 9, 81, 33, 17, 58]);

            if (outPut4 != 165)
            {
                Console.WriteLine("[Problem N2815] --> Test Case 4 didn't work correctly!");
                Console.WriteLine($"[Problem N2815] --> OutPut = {outPut4}");
                return false;
            }

            return true;
        }
    }
}
