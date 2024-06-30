using LeetCode.Challenges.Easy;
using LeetCode.Challenges.Shared;

var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));

new MergeSortedLists().Run(l1, l2);

Console.ReadLine();