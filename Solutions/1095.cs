//https://leetcode.com/problems/find-in-mountain-array/discuss/317607/JavaC%2B%2BPython-Triple-Binary-Search
/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */
class Solution {
    public int FindInMountainArray(int target, MountainArray mountainArr) {
        
        int left = 0;
        int right = mountainArr.Length() - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (mountainArr.Get(mid) < mountainArr.Get(mid + 1))
                left = mid + 1;
            else
                right = mid - 1;
        }

        int peak = left;
        left = 0;
        right = peak;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (mountainArr.Get(mid) == target)
                return mid;
            else if (mountainArr.Get(mid) < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        
        left = peak;
        right = mountainArr.Length() - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (mountainArr.Get(mid) == target)
                return mid;
            else if (mountainArr.Get(mid) > target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        
        return -1;
    }
}
