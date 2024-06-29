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
        public LinkedList<int> Run(LinkedList<int> l1, LinkedList<int> l2)
        {
            var l1Reversed = new StringBuilder();
            var l2Reversed = new StringBuilder();

            for (int i = l1.Count - 1; i >= 0; i--)
            {
                l1Reversed.Append(l1.ElementAt(i));
            }

            for (int i = l2.Count - 1; i >= 0; i--)
            {
                l2Reversed.Append(l2.ElementAt(i));
            }

            var result = new LinkedList<int>();

            if (int.TryParse(l1Reversed.ToString(), out int l1ReversedNumeric) &&
                int.TryParse(l2Reversed.ToString(), out int l2ReversedNumeric))
            {
                var combined = (l1ReversedNumeric + l2ReversedNumeric).ToString().ToArray();

                for (int i = combined.Length - 1; i >= 0; i--)
                {
                    if (int.TryParse(combined[i].ToString(), out int resultInt))
                    {
                        result.AddLast(resultInt);
                    }
                    else
                    {
                        //handle
                    }
                }
            }
            else
            {
                //handle
            }

            return result;
        }
    }
}