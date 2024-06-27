namespace LeetCode.Challenges
{
    /// <summary>
    /// Given the root of a binary tree, return the inorder traversal of its nodes' values.
    /// </summary>
    public class BinaryTreeInOrderTraversal : ILeetCode
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

            Traverse(root);

            return _nodes;
        }

        private void Traverse(TreeNode? node)
        {
            if (node == null)
            {
                return;
            }

            Traverse(node.left);

            _nodes.Add(node.val);

            Traverse(node.right);
        }
    }

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