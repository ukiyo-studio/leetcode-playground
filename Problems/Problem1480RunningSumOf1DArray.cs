namespace LeetcodePlayground.Problems;

public class Problem1480RunningSumOf1DArray : ILeetCodeProblem
{
    /*
     * Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

       Return the running sum of nums.

       Example 1:

       Input: nums = [1,2,3,4]
       Output: [1,3,6,10]
       Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
       Example 2:

       Input: nums = [1,1,1,1,1]
       Output: [1,2,3,4,5]
       Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
       Example 3:

       Input: nums = [3,1,2,10,1]
       Output: [3,4,6,16,17]
     */

    private int[] RunningSum(int[] nums)
    {
        var runningSumResult = new int[nums.Length];

        Console.WriteLine($"Input: {string.Join(",", nums)}");
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                runningSumResult[i] = nums[i];
            }
            else
            {
                runningSumResult[i] = runningSumResult[i - 1] + nums[i];
            }
        }

        Console.WriteLine($"Output: {string.Join(",", runningSumResult)}");
        return runningSumResult;
    }

    public void Solution()
    {
        Console.WriteLine("--- 1480. Running Sum of 1D Array ---");
        TestSolution();
    }

    private void TestSolution()
    {
        var testSets = new List<TestSet>
        {
            new([1, 2, 3, 4], [1, 3, 6, 10]),
            new([1, 1, 1, 1, 1], [1, 2, 3, 4, 5]),
            new([3, 1, 2, 10, 1], [3, 4, 6, 16, 17])
        };

        foreach (var testSet in testSets)
        {
            var result = RunningSum(testSet.Input);
            Console.WriteLine(result.SequenceEqual(testSet.Output) ? "Test passed" : "Test failed");
        }
    }

    private class TestSet(int[] input, int[] output)
    {
        public int[] Input { get; } = input;
        public int[] Output { get; } = output;
    }
}