//https://leetcode.com/problems/find-pivot-index/discuss/109249/Java-6-liner
public class Solution {
    public int PivotIndex(int[] nums) {
        int leftSum = 0, rightSum = 0;
        
        for (int i = 0; i < nums.Length; i++) 
        {
           rightSum += nums[i]; 
        }
            
        for (int i = 0; i < nums.Length; i++) {
            rightSum -= nums[i];
            
            if (leftSum == rightSum)
                return i;
            
            leftSum += nums[i];
        }
        
        return -1;
    }
}

/*  Extra space

public class Solution {
    public int PivotIndex(int[] nums) {

        int[] leftSum = new int[nums.Length];
        int[] rightSum = new int[nums.Length];
        
        leftSum[0] = 0;
        rightSum[nums.Length - 1] = 0;
        
        for (int i=1; i<nums.Length; i++)
        {
            leftSum[i] = nums[i - 1] + leftSum[i - 1];
            rightSum[nums.Length - i - 1] = nums[nums.Length - i] + rightSum[nums.Length - i];
        }
        
        for (int i=0; i<nums.Length; i++)
        {
            if (leftSum[i] == rightSum[i])
                return i;
        }
        
        return -1;
    }
}
*/
