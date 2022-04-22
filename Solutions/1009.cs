//https://leetcode.com/problems/complement-of-base-10-integer/discuss/258500/Java-0ms-32mb...-beats-100
public class Solution {
    public int BitwiseComplement(int n) {
        
        if (n == 0) return 1;
        if (n == 1) return 0;
        
        int x = 1;
        
        while (x <= n)
        {
             x = x << 1;
        }
        
        return n ^ (x-1);
    }
}
