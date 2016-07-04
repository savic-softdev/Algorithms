//You are climbing a stair case. It takes n steps to reach to the top.

//Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

public class Solution {
    public int ClimbStairs(int n) {
		if (n == 0)
			return 0;

		int sum1 = 0, sum2 = 1, sum = 0;
		for (int i = 1; i <= n; i++)
		{
			sum = sum1 + sum2;
			sum1 = sum2;
			sum2 = sum;
		}

		return sum;
    }
}