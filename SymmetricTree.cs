//Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).

//For example, this binary tree [1,2,2,3,4,4,3] is symmetric

public class Solution {
    
	    public bool IsSymmetric(TreeNode root)
		{
			List<string> serialized = SerializeTree(root);

			if (serialized.Count == 0)
				return true;

			bool isSymm = true;
			int startIndex = 1;
			int levCount = 2;

			while(true)
			{
				if (serialized.Count() < startIndex + levCount) break;

				List<string> tmp = serialized.GetRange(startIndex, levCount);
				List<string> tmpReversed = new List<string>(tmp);
				tmpReversed.Reverse();
				if(!tmp.SequenceEqual(tmpReversed))
				{
					isSymm = false;
					break;
				}

				startIndex += levCount;
				levCount -= tmp.Where(x => x == "#").Count();
				levCount += levCount;
			}

			return isSymm;
		}
	
	public List<string> SerializeTree(TreeNode root)
	{
		List<string> nodes = new List<string>();

		if (root == null || (root.left == null && root.right == null))
			return nodes;

		nodes.Add(root.val.ToString());
		List<TreeNode> list = new List<TreeNode>() { root.left, root.right };
		List<TreeNode> outList = new List<TreeNode>();
		while (true)
		{
			foreach(TreeNode tn in list)
				nodes.Add(tn == null ? "#" : tn.val.ToString());

			outList.Clear();
			foreach (TreeNode tn in list)
			{
				if (tn == null) continue;

				outList.Add(tn.left);
				outList.Add(tn.right);
			}

			if (outList.Where(x => x != null).Count() == 0) break;
			list.Clear();
			list.AddRange(outList);
		}

		return nodes;
	}
}