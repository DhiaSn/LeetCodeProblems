namespace LeetCodeProblems.Problems.Easy.ProblemNumber2815
{
    public static class Solution
    {
        public static int MaxSum(int[] nums)
        {
            int i = 0;
            int j = 1;
            int maxSum = -1;
            int maxDigit = -1; 

            while (i < nums.Length)
            {
                while (j < nums.Length)
                {
                    int x = nums[i];
                    int y = nums[j];

                    if ((x + y) % 2 == 0)
                    {
                        string xS = x.ToString();
                        string yS = y.ToString();
                        int lastMaxDigit = 0; 
                        foreach (char xSC in xS)
                        {

                            bool isExist = yS.Contains(xSC);

                            if (isExist)
                            {
                                lastMaxDigit = xS.Intersect(yS).Select(c => int.Parse(c.ToString())).Max(); 

                                if (lastMaxDigit > maxDigit)
                                {
                                    maxSum = x + y;
                                    maxDigit = lastMaxDigit;
                                }

                            }
                        }
                    }
                    j++;

                }
                i++;
                j = i+1;
            }  

            return maxSum;
        }



    }
}
