using LeetCode.Challenges.Shared;

namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given the root of a binary tree, return its maximum depth.
    /// A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
    /// </summary>
    public class MaximumDepthBinaryTree : ILeetCode
    {
        public int Run(TreeNode? root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = Run(root.left);
            var right = Run(root.right);

            return Math.Max(left, right) + 1;
        }
    }
}