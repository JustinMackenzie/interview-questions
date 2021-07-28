using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.Solutions
{
    public class BinaryTreeNode
    {
        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
    }

    public class InvertBinaryTreeSolution
    {
        public BinaryTreeNode Inverse(BinaryTreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            BinaryTreeNode temp = this.Inverse(root.Left);
            root.Left = this.Inverse(root.Right);
            root.Right = temp;

            return root;
        }
    }
}
