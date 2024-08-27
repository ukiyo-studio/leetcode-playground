namespace LeetcodePlayground.Problems;

public class Problem1672RichestCustomerWealth: ILeetCodeProblem
{
    /*
       You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the ith customer has in
       the jth bank. Return the wealth that the richest customer has.
       A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer 
       that has the maximum wealth.
       
        
       
       Example 1:
       
       Input: accounts = [[1,2,3],[3,2,1]]
       Output: 6
       Explanation:
       1st customer has wealth = 1 + 2 + 3 = 6
       2nd customer has wealth = 3 + 2 + 1 = 6
       Both customers are considered the richest with a wealth of 6 each, so return 6.
       Example 2:
       
       Input: accounts = [[1,5],[7,3],[3,5]]
       Output: 10
       Explanation: 
       1st customer has wealth = 6
       2nd customer has wealth = 10 
       3rd customer has wealth = 8
       The 2nd customer is the richest with a wealth of 10.
       Example 3:
       
       Input: accounts = [[2,8,7],[7,1,3],[1,9,5]]
       Output: 17
     */

    private int MaximumWealth(int[][] accounts) {
        // for each customer return the sum of their accounts
        // then compare maximum values to return the maximum of all accounts

        var accountTotals = new List<int>();

        for (int i = 0; i < accounts.Length; i++)
        {
            var banks = accounts[i];
            var sum = 0;
            for (int j = 0; j < banks.Length; j++)
            {
                sum += banks[j];
            }
            
            accountTotals.Add(sum);

        }

        return accountTotals.Max();
    }
    
    private int MaximumWealthLinq(int[][] accounts) {
        // for each customer return the sum of their accounts
        // then compare maximum values to return the maximum of all accounts

        return accounts.Select(banks => banks.Sum()).ToList().Max();
    }
    
    private int MaximumWealthFast(int[][] accounts) {
        // for each customer return the sum of their accounts
        // then compare maximum values to return the maximum of all accounts
        
        var maxWealth = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            var sum = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }

            if (sum > maxWealth)
            {
                maxWealth = sum;
            }
        }

        return maxWealth;

    }
    
    public void Solution()
    {
        Console.WriteLine("--- 1672. Richest Customer Wealth ---");
        TestSolution();
    }

    private void TestSolution()
    {
        var testSets = new List<TestSet>
        {
            new([[1,2,3],[3,2,1]], 6),
            new([[1,5],[7,3],[3,5]], 10),
            new([[2,8,7],[7,1,3],[1,9,5]], 17)
        };

        foreach (var testSet in testSets)
        {
            var result = MaximumWealthLinq(testSet.Input);
            Console.WriteLine(result.Equals(testSet.Output) ? "Test passed" : "Test failed");
        }
    }
    
    private class TestSet(int[][] input, int output)
    {
        public int[][] Input { get; } = input;
        public int Output { get; } = output;
    }
}