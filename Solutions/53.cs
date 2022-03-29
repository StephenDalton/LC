public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = nums[0];
        int currentSum = 0;
        
        for(int i=0; i<nums.Length; i++)
        {
            if (currentSum < 0)
                currentSum = 0;
            
            currentSum += nums[i];
            max = Math.Max(max, currentSum);
            
        }
        return max;
    }
}
