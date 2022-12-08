using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace kata1;
// recursive fib sequence

public class Solution {
    static int fib(int n)
    {
        if (n <= 1)
            return n;
        return fib(n - 1) + fib(n - 2);
    }
 
    static int countCombinations(int s)
    {
        return fib(s + 1);
    }
 
    // Driver Code
    static public void Main()
    {
        int steps = 4;
        Console.WriteLine("Number of ways = " + countCombinations(steps));
    }
}

// Input: steps = 4

//                   fib(5)
//            '3'  /        \   '2'
//                /          \
//            fib(4)         fib(3)
//      '2'  /      \ '1'   /      \  
//          /        \     /        \ 
//      fib(3)     fib(2)fib(2)      fib(1) 
//      /    \ '1' /   \ '0'
// '1' /   '1'\   /     \ 
//    /        \ fib(1) fib(0) 
// fib(2)     fib(1)
 
