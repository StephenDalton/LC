//https://leetcode.com/problems/kth-missing-positive-number/discuss/1687149/Java-Simple-Solution
public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        
        int left = 0;
        int right = arr.Length - 1;
        
        while (left <= right) 
        {
            int mid = left (right - left) / 2;
            
            if (arr[mid] - mid - 1 >= k) 
                right = mid - 1;
            else 
                left = mid + 1;
        }
        
        return k + left;
    }
}
