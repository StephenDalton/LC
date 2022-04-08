//https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/discuss/14734/Easy-java-O(logn)-solution
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        return new int[] { FindFirst(nums, target), FindLast(nums, target) };
    }
    
    private int FindFirst(int[] nums, int target) {
        int idx = -1;
        int low = 0;
        int high = nums.Length - 1;
        
        while(low <= high)
        {
            int mid = low + (high - low) / 2;
            if(nums[mid] >= target)
                high = mid - 1;
            else
                low = mid + 1;
            
            if(nums[mid] == target) 
                idx = mid;
        }
        
        return idx;
    }
    
    private int FindLast(int[] nums, int target) {
        int idx = -1;
        int low = 0;
        int high = nums.Length - 1;
        
        while(low <= high)
        {
            int mid = low + (high - low) / 2;
            if(nums[mid] <= target)
                low = mid + 1;
            else
                high = mid - 1;
            
            if(nums[mid] == target) 
                idx = mid;
        }
        
        return idx;
    }
}
