//https://leetcode.com/problems/fibonacci-number/discuss/215992/Java-Solutions
public class Solution {
    public int Fib(int n) {
        if (n <= 1)
            return n;
        
        int[] fibCache = new int[n + 1];
        fibCache[1] = 1;
        
        for(int i=2; i<=n; i++)
        {
            fibCache[i] = fibCache[i-1] + fibCache[i-2];
        }
        
        return fibCache[n];
    }
}

/*
public class Solution {
    public int Fib(int n) {
        if (n <= 1)
            return n;
        
        int a = 0;
        int b = 1;
        
        for (int i=1; i<n; i++)
        {
            int sum = a + b;

            a = b;
            b = sum;
        }
        
        return b;
    }
}
*/
