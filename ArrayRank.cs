
/* Q1: Replace each array element by its corresponding rank
  Given an array of distinct integers, replace each array element by its corresponding rank in the array.

The minimum array element has the rank 1; the second minimum element has a rank of 2, and so on… For example,*/

using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayRank {
    public static int[] ReplaceWithRank(int[] arr) {
        // Create a copy of the array to preserve the original order
        int[] sortedArr = (int[])arr.Clone();

        // Sort the copy of the array
        Array.Sort(sortedArr);

        // Create a dictionary to store the rank of each element
        Dictionary<int, int> rankMap = new Dictionary<int, int>();
        int rank = 1;
        foreach (int num in sortedArr) {
            // Store rank of each element in the dictionary
            if (!rankMap.ContainsKey(num)) {
                rankMap[num] = rank++;
            }
        }

        // Replace each element in the original array with its rank
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = rankMap[arr[i]];
        }

        return arr;
    }

    public static void Main(string[] args) {
        int[] arr = { 10, 8, 15, 12, 6, 20, 1 };
        int[] rankedArray = ReplaceWithRank(arr);
        Console.Write("Output: {");
        for (int i = 0; i < rankedArray.Length; i++) {
            Console.Write(rankedArray[i]);
            if (i < rankedArray.Length - 1) {
                Console.Write(", ");
            }
        }
        Console.WriteLine("}");
    }
}
