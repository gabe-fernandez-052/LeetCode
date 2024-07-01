using LeetCode.Challenges.Shared;

namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given the root of a binary tree, return the preorder traversal of its nodes' values.
    /// new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(8, null, new TreeNode(9)));
    /// </summary>
    public class BinaryTreePreOrderTraversal : ILeetCode
    {
        private List<int> _nodes = [];

        public IList<int> Run(TreeNode root)
        {
            if (root == null)
            {
                return _nodes;
            }

            if (root.left == null && root.right == null)
            {
                _nodes.Add(root.val);
                return _nodes;
            }

            TraversePreOrder(root);

            return _nodes;
        }

        /// <summary>
        /// /// DFS - PreOrder (Node, Left, Right)
        /// </summary>
        /// <param name="node"></param>
        public void TraversePreOrder(TreeNode? root)
        {
            if (root == null)
            {
                return;
            }

            _nodes.Add(root.val);

            TraversePreOrder(root.left);

            TraversePreOrder(root.right);
        }
    }
}