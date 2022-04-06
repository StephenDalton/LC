public class Solution {
    public int Search(int[] nums, int target) {
        
        if (nums.Length == 0 || nums == null)
            return -1;
        
        int low = 0;
        int high = nums.Length - 1;
        
        while (low <= high)
        {
            int mid = low + (high-low) / 2;
            
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }
}
