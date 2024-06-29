using LeetCode.Challenges.Easy;
using LeetCode.Challenges.Shared;

var three = new TreeNode(3);
var four = new TreeNode(4);

var leftTwo = new TreeNode(2, three, four);
var rightTwo = new TreeNode(2, four, three);

var root = new TreeNode(1, leftTwo, rightTwo);

new SymmetricTree().Run(root);

Console.ReadLine();