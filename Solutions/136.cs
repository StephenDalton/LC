//https://leetcode.com/problems/single-number/discuss/43171/1ms-JAVA-solution
public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;
        
        foreach (int num in nums)
        {
            result = result ^ num;
        }
        
        return result;
    }
}
