using LeetCode.Challenges.Easy;
using LeetCode.Challenges.Shared;

var tree = new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(8, null, new TreeNode(9)));

var preOrder = new BinaryTreePreOrderTraversal().Run(tree);
var inOrder = new BinaryTreeInOrderTraversal().Run(tree);
var postOrder = new BinaryTreePostOrderTraversal().Run(tree);

Console.ReadLine();