using System;
using System.Collections.Generic;

/*Q4:You are given an array of integers. 
Write a C# program to find the frequency of each unique element in the array and 
store the results in a dictionary where the key is the element and the value is its frequency.
Then, print the elements and their frequencies.

Example:
Input:
int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

Output:
Element: 1, Frequency: 1
Element: 2, Frequency: 2
Element: 3, Frequency: 3
Element: 4, Frequency: 4*/

Solution:-

public class FrequencyCounter {
    public static void Main(string[] args) {
        int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
        
        // Create a dictionary to store the frequency of each element
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        // Iterate through the array and update the frequency map
        foreach (int num in numbers) {
            if (frequencyMap.ContainsKey(num)) {
                frequencyMap[num]++;
            } else {
                frequencyMap[num] = 1;
            }
        }

        // Print the elements and their frequencies
        foreach (var entry in frequencyMap) {
            Console.WriteLine($"Element: {entry.Key}, Frequency: {entry.Value}");
        }
    }
}
