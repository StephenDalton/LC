//https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/discuss/158940/Beat-100%3A-Very-Simple-(Python)-Very-Detailed-Explanation
public class Solution {
    public int FindMin(int[] nums) {
        
        int left = 0;
        int right = nums.Length - 1;
        
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            
            if (nums[mid] > nums[right])
                left = mid + 1;
            else if (nums[mid] < nums[right])
                right = mid;
        }
        
        return nums[left];
    }
}
