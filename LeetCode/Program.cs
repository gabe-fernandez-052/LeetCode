using LeetCode.Challenges;

var l1n3 = new ListNode(4);
var l1n2 = new ListNode(2, l1n3);
var head1 = new ListNode(1, l1n2);

var l2n3 = new ListNode(4);
var l2n2 = new ListNode(3, l2n3);
var head2 = new ListNode(1, l2n2);

var test = new MergeSortedLists().Run(head1, head2);

Console.ReadLine();