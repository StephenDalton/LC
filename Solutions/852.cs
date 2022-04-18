//https://leetcode.com/problems/peak-index-in-a-mountain-array/discuss/143892/Java-Basic-Binary-Search-Solution
public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        
        int left = 0;
        int right = arr.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (arr[mid] < arr[mid + 1])
                left = mid + 1;
            else
                right = mid - 1;
        }
        
        return left;
    }
}
