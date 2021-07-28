using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.Solutions
{
    public class Node
    {
        public Node(int value, Node next)
        {
            this.Value = value;
            this.Next = next;
        }

        public Node Next { get; set; }
        public int Value { get; set; }
    }

    public class ReverseLinkedListSolution
    {
        // a -> b -> c
        // c -> b -> a
        public Node Reverse(Node head)
        {
            if (head == null)
            {
                return null;
            }

            if (head.Next == null)
            {
                return head;
            }

            Stack<Node> stack = new Stack<Node>();
            Node current = head;

            while (current != null)
            {
                stack.Push(current);
                current = current.Next;
            }

            Node result = stack.Pop();
            current = result;

            while (stack.Count > 0)
            {
                current.Next = stack.Pop();
                current = current.Next;
            }

            return result;
        }
    }
}
