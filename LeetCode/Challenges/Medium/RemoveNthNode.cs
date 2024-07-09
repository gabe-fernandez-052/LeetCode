using LeetCode.Challenges.Shared;

namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// Given the head of a linked list, remove the nth node from the end of the list and return its head.
    /// </summary>
    public class RemoveNthNode : ILeetCode
    {
        private int _nodeCount = 0;

        public ListNode? Run(ListNode? head, int n)
        {
            CountLinkedList(head);

            if (n > _nodeCount)
            {
                return head;
            }

            if (_nodeCount - n == 0)
            {
                return null;
            }

            TraverseLinkedList(head, 1, _nodeCount - n);

            return head;
        }

        private void CountLinkedList(ListNode? head)
        {
            if (head == null)
            {
                return;
            }

            _nodeCount++;

            CountLinkedList(head.next);
        }

        private void TraverseLinkedList(ListNode? head, int index, int target)
        {
            if (head == null)
            {
                return;
            }

            if (index == target)
            {
                head.next = head.next?.next;
                return;
            }

            var increment = index + 1;
            TraverseLinkedList(head.next, increment, target);
        }
    }
}