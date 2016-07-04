//Given a roman numeral, convert it to an integer.

//Input is guaranteed to be within the range from 1 to 3999

public class Solution {
    
    public int RomanToInt(string num) {
        
		Dictionary<string, int> dict = new Dictionary<string, int> {
			{ "I",1 },
			{ "X",10 },
			{ "C",100 },
			{ "M",1000 },
			{ "V",5 },
			{ "L",50 },
			{ "D",500 }
		};
			
		int ret = 0;
		int prev = 0;
		
		for (int i = num.Length - 1; i >= 0; i--)
		{
			int temp = dict[num.Substring(i,1)];
			if (temp < prev)
				ret -= temp;
			else
				ret += temp;
			prev = temp;
		}
		
		return ret;
    }
}