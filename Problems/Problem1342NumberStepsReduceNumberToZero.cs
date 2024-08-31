namespace LeetcodePlayground.Problems;

public class Problem1342NumberStepsReduceNumberToZero: ILeetCodeProblem
{
    
    /*
     * Given an integer num, return the number of steps to reduce it to zero.
       
       In one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.
       Example 1:
       
       Input: num = 14
       Output: 6
       Explanation: 
       Step 1) 14 is even; divide by 2 and obtain 7. 
       Step 2) 7 is odd; subtract 1 and obtain 6.
       Step 3) 6 is even; divide by 2 and obtain 3. 
       Step 4) 3 is odd; subtract 1 and obtain 2. 
       Step 5) 2 is even; divide by 2 and obtain 1. 
       Step 6) 1 is odd; subtract 1 and obtain 0.
       Example 2:
       
       Input: num = 8
       Output: 4
       Explanation: 
       Step 1) 8 is even; divide by 2 and obtain 4. 
       Step 2) 4 is even; divide by 2 and obtain 2. 
       Step 3) 2 is even; divide by 2 and obtain 1. 
       Step 4) 1 is odd; subtract 1 and obtain 0.
       Example 3:
       
       Input: num = 123
       Output: 12
     */
    
    private int NumberOfSteps(int num)
    {
        var steps = 0;
        while (num > 0)
        {
            if (num % 2 == 0)
            {
                num /= 2;
            }
            else
            {
                num -= 1;
            }

            steps++;
        }

        return steps;
    }

    public void Solution()
    {
        Console.WriteLine("--- 1342. Number of Steps to Reduce a Number to Zero ---");
        TestSolution();
    }

    private void TestSolution()
    {
        var testSets = new List<TestSet>
        {
            new(14, 6),
            new(8, 4),
            new(123, 12)
        };

        foreach (var testSet in testSets)
        {
            var result = NumberOfSteps(testSet.Input);
            Console.WriteLine(result.Equals(testSet.Output) ? "Test passed" : "Test failed");
        }
    }
    
    private class TestSet(int input, int output)
    {
        public int Input { get; } = input;
        public int Output { get; } = output;
    }
}