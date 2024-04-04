/*Q3:Find non-repeating characters in a string */
using System;
using System.Collections.Generic;

public class NonRepeatingCharacters {
    public static void FindNonRepeatingCharacters(string s) {
        // Create a dictionary to store the count of each character
        Dictionary<char, int> charCountMap = new Dictionary<char, int>();
        
        // Populate the dictionary with character counts
        foreach (char c in s) {
            if (charCountMap.ContainsKey(c)) {
                charCountMap[c]++;
            } else {
                charCountMap[c] = 1;
            }
        }
        
        // Print non-repeating characters
        Console.Write("Non-repeating characters: ");
        foreach (char c in s) {
            if (charCountMap[c] == 1) {
                Console.Write(c + " ");
            }
        }
    }

    public static void Main(string[] args) {
        string s = "leetcode";
        FindNonRepeatingCharacters(s);
    }
}
