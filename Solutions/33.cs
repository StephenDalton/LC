//https://leetcode.com/problems/search-in-rotated-sorted-array/discuss/14435/Clever-idea-making-it-simple/14793
public class Solution {
    public int Search(int[] nums, int target) {
        
        int left = 0;
        int right = nums.Length - 1;
        
        while (left < right)
        {
            int mid = left + (right - left) / 2;
                     
            if ((nums[mid] < nums[0]) == (target < nums[0]))
            {
                if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid;
            }
            else if (target < nums[0])
                left = mid + 1;
            else 
                right = mid;
        }
        
        return nums[left] == target ? left : -1;
    }
}
