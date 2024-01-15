namespace LeetCodeProblems.Problems.Easy.ProblemNumber645
{
    public static class TestCases
    {
        public static bool ExcuteSolution()
        {
            int[] outPut1 = Solution.FindErrorNums([1, 2, 2, 4]);
            int[] expectedResult1 = [2, 3];
            if (!Enumerable.SequenceEqual(outPut1, expectedResult1))
            {
                Console.WriteLine("[Problem N389] --> Test Case 1 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut1}");
                return false;
            }
            int[] outPut2 = Solution.FindErrorNums([1, 1]);
            int[] expectedResult2 = [1, 2];
            if (!Enumerable.SequenceEqual(outPut2, expectedResult2))
            {
                Console.WriteLine("[Problem N389] --> Test Case 2 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut2}");
                return false;
            }

            int[] outPut3 = Solution.FindErrorNums([2, 2]);
            int[] expectedResult3 = [2, 1];
            if (!Enumerable.SequenceEqual(outPut3, expectedResult3))
            {
                Console.WriteLine("[Problem N389] --> Test Case 3 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut3}");
                return false;
            }

            int[] outPut4 = Solution.FindErrorNums([3, 2, 2]);
            int[] expectedResult4 = [2, 1];
            if (!Enumerable.SequenceEqual(outPut4, expectedResult4))
            {
                Console.WriteLine("[Problem N389] --> Test Case 4 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut4}");
                return false;
            }

            int[] outPut5 = Solution.FindErrorNums([2, 3, 2]);
            int[] expectedResult5 = [2, 1];
            if (!Enumerable.SequenceEqual(outPut5, expectedResult5))
            {
                Console.WriteLine("[Problem N389] --> Test Case 5 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut5}");
                return false;
            }

            int[] outPut6 = Solution.FindErrorNums([1, 3, 3]);
            int[] expectedResult6 = [3, 2];
            if (!Enumerable.SequenceEqual(outPut6, expectedResult6))
            {
                Console.WriteLine("[Problem N389] --> Test Case 6 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut6}");
                return false;
            }


            int[] outPut7 = Solution.FindErrorNums([8, 7, 3, 5, 3, 6, 1, 4]);
            int[] expectedResult7 = [3, 2];
            if (!Enumerable.SequenceEqual(outPut7, expectedResult7))
            {
                Console.WriteLine("[Problem N389] --> Test Case 7 didn't work correctly!");
                Console.WriteLine($"[Problem N389] --> OutPut = {outPut7}");
                return false;
            }

            return true;
        }
    }
}
