using LeetCode.Challenges.Shared;

namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
    /// </summary>
    public class SymmetricTree : ILeetCode
    {
        public bool Run(TreeNode root)
        {
            return TraverseTree(root.left, root.right);
        }

        public bool TraverseTree(TreeNode node1, TreeNode node2)
        {
            if (node1 == null || node2 == null)
            {
                return node1?.val == node2?.val;
            }

            if (node1.val != node2.val)
            {
                return false;
            }

            return TraverseTree(node1.left, node2.right) && TraverseTree(node1.right, node2.left);
        }
    }
}