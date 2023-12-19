namespace LeetCodeProblems.Problems.Easy.ProblemNumber2525
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            if (Solution.CategorizeBox(1000, 35, 700, 300) != "Heavy")
            {
                Console.WriteLine("[Problem N2525] --> Test Case 1 didn't work correctly!");
                return false; 
            }
            if (Solution.CategorizeBox(200, 50, 800, 50) != "Neither")
            {
                Console.WriteLine("[Problem N2525] --> Test Case 2 didn't work correctly!");
                return false; 
            }
            if (Solution.CategorizeBox(2909, 3968, 3272, 727) != "Both")
            {
                Console.WriteLine("[Problem N2525] --> Test Case 3 didn't work correctly!");
                return false; 
            }

            if (Solution.CategorizeBox(2227, 937, 2241, 983) != "Both")
            {
                Console.WriteLine("[Problem N2525] --> Test Case 4 didn't work correctly!");
                return false;
            }

            return true; 
        }
    }
}
