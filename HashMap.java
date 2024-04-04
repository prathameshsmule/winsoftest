/* Q3:Write a Java Program to count the number of words in a string using HashMap. */

import java.io.*;
import java.util.HashMap;
import java.util.Map;
 
class GFG {
    public static void main(String[] args)
    {
 
        String str = "Alice is girl and Bob is boy";
 
        Map<String, Integer> hashMap = new HashMap<>();
 
        String[] words = str.split(" ");
 
        for (String word : words) {
            // containsKey(key) will return a boolean value
            // i.e. true if it contains the key and false if
            // it doesn't.
            if (hashMap.containsKey(word))
                hashMap.put(word, hashMap.get(word) + 1);
 
            else
                hashMap.put(word, 1);
        }
 
        System.out.println(hashMap);
    }
}