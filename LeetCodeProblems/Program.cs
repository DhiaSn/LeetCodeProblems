using _easyProblemsRef = LeetCodeProblems.Problems.Easy;

/*
 * • The Project is seperating the Problems by their difficulty on Leet code 
 * 
 * • You can track any problem by their own number
 * 
 * • Each Problem Has Solution Class & Test Cases Class
 * 
 * • If you want to excute and test any Algorithm Problem please Use The Method "ExcuteSolution" in TestCases Class 
 * 
 */

Console.WriteLine("Greetings!");

if(_easyProblemsRef.ProblemNumber119.TestCases.ExcuteSolution())
    Console.WriteLine("Congrats! Your algorithm works perfectly!");

static void PrintPascalTriangle(int rows)
{
    int i = rows; 

    int number = 1;
    for (int j = 0; j <= i; j++)
    {
        Console.Write("   "); // Adjust spacing for readability
        Console.Write("{0,3}", number);
        number = number * (i - j) / (j + 1);
    }
    Console.WriteLine();
}
