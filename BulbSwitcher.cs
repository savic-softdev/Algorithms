//There are n bulbs that are initially off. You first turn on all the bulbs. Then, you turn off every second bulb. 
//On the third round, you toggle every third bulb (turning on if it's off or turning off if it's on). 
//For the ith round, you toggle every i bulb. For the nth round, you only toggle the last bulb. Find how many bulbs are on after n rounds.

public class Solution {
    public int BulbSwitch(int n) {
            if (n == 0)
                return 0;
                
			if (n <= 3)
				return 1;

			int retVal = 1;
			int sum = 3;
			int increment = 5;

			while (n > sum)
			{
				sum += increment;
				increment += 2;
				retVal++;
			}

			return retVal;
    }
}