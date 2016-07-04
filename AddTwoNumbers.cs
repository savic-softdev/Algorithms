//You are given two linked lists representing two non-negative numbers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

//Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
//Output: 7 -> 0 -> 8

public class Solution {
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			if (l1 == null || l2 == null)
				return null;

			string res = (GetNum(l1) + GetNum(l2)).ToString();

			return SetNum(res);
		}

		public ListNode SetNum(string str)
		{
			if (str.Count() == 0)
				return null;

			ListNode ret = new ListNode(int.Parse(str.Substring(str.Count() - 1)));
			ListNode tmp = ret;

			for (int i = str.Count() - 2; i >= 0; i--)
			{
				tmp.next = new ListNode(int.Parse(str.Substring(i, 1)));
				tmp = tmp.next;
			}

			return ret;
		}

		public long GetNum(ListNode node)
		{
			string num = string.Empty;
			do
			{
				num = node.val.ToString() + num;
				node = node.next;
			} while (node != null);

			return long.Parse(num);
		}
}