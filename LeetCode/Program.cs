using LeetCode.Challenges;

var t3 = new TreeNode(3, null, null);
var t2 = new TreeNode(2, null, t3);
var t1 = new TreeNode(1, null, t2);

new BinaryTreeInOrderTraversal().Run(t1);

Console.ReadLine();