namespace LeetCode.Challenges
{
    /// <summary>
    /// You are given the heads of two sorted linked lists list1 and list2.
    /// Merge the two lists into one sorted list.The list should be made by splicing together the nodes of the first two lists.
    /// Return the head of the merged linked list.
    ///var l1n3 = new ListNode(3);
    ///var l1n2 = new ListNode(2, l1n3);
    ///var head1 = new ListNode(1, l1n2);
    ///var l2n3 = new ListNode(4);
    ///var l2n2 = new ListNode(3, l2n3);
    ///var head2 = new ListNode(1, l2n2);
    /// </summary>
    public class MergeSortedLists
    {
        public ListNode? Run(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            if (list1.val <= list2.val)
            {
                list1.next = Run(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = Run(list1, list2.next);
                return list2;
            }
        }
    }

    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}