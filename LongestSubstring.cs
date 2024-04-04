// Q2: Given a string s, find the length of the longest substring without repeating characters.
// Example 1:
// Input: s = "abcabcbb"
// Output: 3
// Explanation: The answer is "abc", with the length of 3.
// Example 2:

// Input: s = "bbbbb"
// Output: 1
// Explanation: The answer is "b", with the length of 1.
// Example 3:

// Input: s = "pwwkew"
// Output: 3
// Explanation: The answer is "wke", with the length of 3.
// Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 
// Constraints:

// 0 <= s.length <= 5 * 104
// s consists of English letters, digits, symbols and spaces.

Solution;-

using System;
using System.Collections.Generic;

public class LongestSubstring {
    public static int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int maxLength = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++) {
            char currentChar = s[right];
            if (map.ContainsKey(currentChar)) {
                // If the character is already in the map, update the left pointer to the right of the previous occurrence
                left = Math.Max(left, map[currentChar] + 1);
            }
            // Update the maximum length
            maxLength = Math.Max(maxLength, right - left + 1);
            // Update the index of the current character
            map[currentChar] = right;
        }

        return maxLength;
    }

    public static void Main(string[] args) {
        string s1 = "abcabcbb";
        string s2 = "bbbbb";
        string s3 = "pwwkew";

        Console.WriteLine("Length of longest substring without repeating characters in " + s1 + ": " + LengthOfLongestSubstring(s1)); // Output: 3
        Console.WriteLine("Length of longest substring without repeating characters in " + s2 + ": " + LengthOfLongestSubstring(s2)); // Output: 1
        Console.WriteLine("Length of longest substring without repeating characters in " + s3 + ": " + LengthOfLongestSubstring(s3)); // Output: 3
    }
}
