//https://leetcode.com/problems/maximum-subarray/discuss/1595097/JAVA-or-Kadane's-Algorithm-or-Explanation-Using-Image
public class Solution {
    public int MaxSubArray(int[] nums) {
        
        int max = nums[0];
        int currentSum  = 0;
        
        for (int i=0; i<nums.Length; i++)
        {
            if (currentSum < 0)
                currentSum = 0;
            
            currentSum += nums[i];
            max = Math.Max(max, currentSum);
        }
        
        return max;
    }
}
