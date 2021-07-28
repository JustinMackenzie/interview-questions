using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.Solutions
{
    public class ReverseIntegerSolution
    {
        public int Reverse(int x)
        {
            int result = 0;
            Stack<int> stack = new Stack<int>();


            while (Math.Abs(x) > 0)
            {
                stack.Push(x % 10);
                x /= 10;
            }

            int totalDigits = stack.Count;

            while (stack.Count > 0)
            {
                result += (int)Math.Pow(10, totalDigits - stack.Count) * stack.Pop(); 
            }

            return result;
        }
    }
}
