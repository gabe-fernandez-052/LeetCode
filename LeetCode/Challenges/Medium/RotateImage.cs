namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).
    /// You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.DO NOT allocate another 2D matrix and do the rotation.
    /// </summary>
    public class RotateImage : ILeetCode
    {
        public void Run(int[][] matrix)
        {
            //Swap i and j's
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    var tmp = matrix[i][j];

                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = tmp;
                }
            }

            //Swap over middle
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length / 2; j++)
                {
                    var tmp = matrix[i][j];

                    matrix[i][j] = matrix[i][matrix.Length - j - 1];
                    matrix[i][matrix.Length - j - 1] = tmp;
                }
            }
        }
    }
}