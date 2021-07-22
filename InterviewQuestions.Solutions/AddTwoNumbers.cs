/**
 * You are given two non-empty linked lists representing two non-negative integers.
 * The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
 * You may assume the two numbers do not contain any leading zero, except the number 0 itself.
 * 
 * Example:
 * 
 * 2 -> 4 -> 3
 * 5 -> 6 -> 4
 * 
 * Should result in 7 -> 0 -> 8
 */

namespace InterviewQuestions.Solutions
{
    public interface AddTwoNumbers
    {
        ListNode AddTwoNumbers(ListNode l1, ListNode l2);
    }

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

    public class AddTwoNumbersInitialSolution : AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddTwoNodes(l1, l2, 0);
        }

        private ListNode AddTwoNodes(ListNode l1, ListNode l2, int carry)
        {
            var result = new ListNode();

            int resultValue = l1.val + l2.val + carry;
            bool nextCarry = resultValue > 9;
            result.val = resultValue % 10;

            if (l1.next == null && l2.next == null)
            {
                // We have no more nodes to search through.
                // If we have overflow, add that extra node.
                if (nextCarry)
                {
                    result.next = new ListNode(1);
                }

                return result;
            }

            result.next = AddTwoNodes(
                l1.next ?? new ListNode(0),
                l2.next ?? new ListNode(0),
                nextCarry ? 1 : 0);

            return result;
        }
    }

    public class AddTwoNumbersSolution2 : AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int sum = l1.val + l2.val;

            if (l1.next == null && l2.next == null)
            {
                if (sum < 10)
                {
                    return new ListNode(sum % 10);
                }
                else
                {
                    return new ListNode(sum % 10, new ListNode(sum / 10));
                }
            }
            else if (l1.next == null)
            {
                if (sum < 10)
                {
                    return new ListNode(sum % 10, l2.next);
                }
                else
                {
                    return new ListNode(sum % 10, AddTwoNumbers(new ListNode(sum / 10), l2.next));
                }
            }
            else if (l2.next == null)
            {
                if (sum < 10)
                {
                    return new ListNode(sum % 10, l1.next);
                }
                else
                {
                    return new ListNode(sum % 10, AddTwoNumbers(new ListNode(sum / 10), l1.next));
                }
            }

            if (sum < 10)
            {
                return new ListNode(sum % 10, AddTwoNumbers(l1.next, l2.next));
            }

            return new ListNode(sum % 10, AddTwoNumbers(new ListNode(sum / 10), AddTwoNumbers(l1.next, l2.next)));
        }
    }
}
