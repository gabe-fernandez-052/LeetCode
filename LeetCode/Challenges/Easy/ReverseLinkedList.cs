using LeetCode.Challenges.Shared;

namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given the head of a singly linked list, reverse the list, and return the reversed list.
    /// </summary>
    public class ReverseLinkedList : ILeetCode
    {
        public ListNode? Run(ListNode? head)
        {
            ListNode? resultNode = null;

            while (head != null)
            {
                resultNode = new ListNode(head.val, resultNode);
                head = head.next;
            }

            return resultNode;
        }
    }
}