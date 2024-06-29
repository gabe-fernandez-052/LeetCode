namespace LeetCode.Challenges.Shared
{
    /// <summary>
    /// Definition for a binary tree node.
    /// </summary>
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;
    }
}