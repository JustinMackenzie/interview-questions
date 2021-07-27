/**
 * Given a string s, return the longest palindromic substring in s.
 * 
 * Input: s = "babad"
 * Output: "bab"
 * Note: "aba" is also a valid answer.
 * 
 * Input: s = "cbbd"
 * Output: "bb"
 * 
 * Input: s = "a"
 * Output: "a"
 * 
 * Input: s = "ac"
 * Output: "a"
 */

using System;

namespace InterviewQuestions.Solutions
{
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            if (s.Length == 1)
            {
                return s;
            }

            // The theory behind this approach is to iterate through the string
            // one position at a time and expand out two pointers from that point.
            // If we are in the middle of a pallidrome, then the characters in both directions
            // will be the same.
            // One pointer will go to the left and one will go to the right. We will continuously
            // check if the characters at each pointer position are the same, if they are
            // then we keep expanding. If they are not the same, then we are not in the middle
            // of a pallidrome.
            int start = 0;
            int length = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // Checks for cases such as 'racecar', where there is an exact middle.
                int length1 = this.GetPalindromeLength(s, i, i);

                // Checks for cases such as 'abba', where there is no exact middle.
                int length2 = this.GetPalindromeLength(s, i, i + 1);

                int maxLength = Math.Max(length1, length2);

                // If this pallindrome is longer than the previous longest, update new length and start.
                if (maxLength > length)
                {
                    length = maxLength;
                    start = i - ((length - 1) / 2);
                }
            }

            return s.Substring(start, length);
        }

        private int GetPalindromeLength(string s, int left, int right)
        {
            
            // Check to see that we are not going out of bounds and that the character on left and right are the same.
            // If so, continue expanding.
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1;
        }
    }
}
