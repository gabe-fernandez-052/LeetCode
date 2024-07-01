using LeetCode.Challenges.Shared;
using System.Numerics;
using System.Text;

namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// You are given two non-empty linked lists representing two non-negative integers.
    /// The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// l1 = [2,4,3], l2 = [5,6,4]
    /// </summary>
    public class TwoNumbers : ILeetCode
    {
        private StringBuilder _sb1 = new();
        private StringBuilder _sb2 = new();

        public ListNode? Run(ListNode? l1, ListNode? l2)
        {
            TraverseLinkedLists(l1, l2);

            BigInteger.TryParse(_sb1.ToString(), out BigInteger l1Value);
            BigInteger.TryParse(_sb2.ToString(), out BigInteger l2Value);

            var stringSum = (l1Value + l2Value).ToString();

            ListNode? result = null;

            foreach (var c in stringSum)
            {
                if (int.TryParse(c.ToString(), out int cValue))
                {
                    var node = new ListNode(cValue, result);
                    result = node;
                }
            }

            return result;
        }

        public void TraverseLinkedLists(ListNode? l1, ListNode? l2)
        {
            if (l1 != null)
            {
                if (l1.next != null)
                {
                    TraverseLinkedLists(l1.next, null);
                }

                _sb1.Append(l1.val);
            }

            if (l2 != null)
            {
                if (l2.next != null)
                {
                    TraverseLinkedLists(null, l2.next);
                }

                _sb2.Append(l2.val);
            }
        }
    }
}