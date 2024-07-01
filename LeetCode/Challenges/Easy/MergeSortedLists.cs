using LeetCode.Challenges.Shared;

namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// You are given the heads of two sorted linked lists list1 and list2.
    /// Merge the two lists into one sorted list.The list should be made by splicing together the nodes of the first two lists.
    /// Return the head of the merged linked list.
    ///var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
    ///var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
    /// </summary>
    public class MergeSortedLists : ILeetCode
    {
        public ListNode? Run(ListNode? list1, ListNode? list2)
        {
            var dummyNode = new ListNode();
            var current = dummyNode;

            dummyNode.next = current;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    current = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    current = list2;
                    list2 = list2.next;
                }
            }

            current.next = list1 ?? list2;

            return dummyNode.next;
        }
    }
}