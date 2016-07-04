//You are given an n x n 2D matrix representing an image.

//Rotate the image by 90 degrees (clockwise).

//Follow up:
//Could you do this in-place?

public class Solution {
    public void Rotate(int[,] matrix)
    {
		int length = matrix.GetLength(0);

		if (length < 2)
			return;

		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < length; j++)
			{
				if (i != j && i > j)
				{
					int tmp = matrix[i, j];
					matrix[i, j] = matrix[j, i];
					matrix[j, i] = tmp;
				}
			}
		}

		int sl = length / 2;

		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < sl; j++)
			{
				int tmp = matrix[i, j];
				matrix[i, j] = matrix[i, length - j - 1];
				matrix[i, length - j - 1] = tmp;
			}
		}
	}
}