/**
 * Given a string s, find the length of the longest substring without repeating characters.
 * 
 * Example:
 * 
 * Input: abcabcbb
 * Output: 3
 * Explanation: The answer is "abc", with the length of 3.
 * 
 * Input: s = "bbbbb"
 * Output: 1
 * Explanation: The answer is "b", with the length of 1.
 * 
 * Input: s = "pwwkew"
 * Output: 3
 * Explanation: The answer is "wke", with the length of 3.
 * Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.Solutions
{
    public interface LongestSubstringWithoutRepeatingCharacters
    {
        int LengthOfLongestSubstring(string s);
    }

    public class LongestSubstringWithoutRepeatingCharactersInitialSolution : LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            // Empty or null string given, so return 0.
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            // If length of string is 1, then just return 1.
            if (s.Length == 1)
            {
                return 1;
            }

            // This map will store the last index where the given character occurred.
            Dictionary<char, int> map = new Dictionary<char, int>();

            // Used to store final result, the longest string size.
            int result = 0;

            // Used to store the start index of the current substring.
            int startIndex = 0;

            // The basic premise is to use a window and to check if the map contains
            // the current character. If it does we reset the start of the current window.
            // As we go through, update the maximum length result if it is larger than the
            // current largest value.
            for (int endIndex = 0; endIndex < s.Length; endIndex++)
            {
                // We have hit a duplicate so restart the start of the substring
                // to one spot past the previous duplicate.
                if (map.ContainsKey(s[endIndex]))
                    startIndex = Math.Max(startIndex, map[s[endIndex]] + 1);

                // Set the index of when this character was last seen.
                map[s[endIndex]] = endIndex;

                // Update the result if we are in a string longer than the previous longest.
                result = Math.Max(result, endIndex - startIndex + 1);
            }

            return result;
        }
    }
}
