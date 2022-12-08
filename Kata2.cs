using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace kata2;


public class Solution {
    public static string PrefixChecker(string[] words) {
        var commonPrefix = "";
        // sorts alphabetically, 
        Array.Sort(words);
        // makes it able to check for last word[i] instantly, to see if it's common throughout
        // if First = "hal" Last = "hzl" 
        // we would know that the last wouldn't equal so we therefore don't have to check all elements
        // otherway around, if First = "hba" & Last = "hbb" we would know that hb is common throughout 
        char[] firstWord = words[0].ToCharArray();
        char[] lastWord = words[words.Length -1].ToCharArray();
        for(int i = 0; i < firstWord.Length; i++)
        {
            if(firstWord[i] != lastWord[i])
            {
                break;
            }
            commonPrefix += firstWord[i];
        }
        return commonPrefix;
    }
 
    // Driver Code
    static public void Main()
    {
        string[] words = new string[]{"hello", "hellb", "helloa", "helloo"};
        Console.WriteLine("Common prefix is = " + PrefixChecker(words));
    }
}
 
