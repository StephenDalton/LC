//https://leetcode.com/problems/kth-largest-element-in-an-array/discuss/60546/JAVA-concise-QuickSelect
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        return QuickSelect(nums, 0, nums.Length - 1, k);
    }
    
    private int QuickSelect(int[] nums, int start, int end, int k)
    {
        int pivot = end;
        int left = start;
        int right = end - 1;
        
        while (left <= right)
        {
            if (nums[left] > nums[pivot])
            {
                Swap(nums, left, right);
                right--;
            }
            else
                left++;
        }
        
        Swap(nums, left, pivot);
        
        int rank = nums.Length - left;
        
        if (rank == k)
            return nums[left];
        else if (rank > k)
            return QuickSelect(nums, left + 1, end, k);
        
        return QuickSelect(nums, start, left - 1, k); 
    }
    
    private void Swap(int[] nums, int a, int b)
    {
        int temp = nums[a];
        nums[a] = nums[b];
        nums[b] = temp;
    }

}
