//https://leetcode.com/problems/search-in-a-sorted-array-of-unknown-size/discuss/1801001/single-pass-binary-search
/**
 * // This is ArrayReader's API interface.
 * // You should not implement it, or speculate about its implementation
 * class ArrayReader {
 *     public int Get(int index) {}
 * }
 */
class Solution {
    public int Search(ArrayReader reader, int target) {
        int low = 0;
        int high = Int32.MaxValue;
        
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            
            if (reader.Get(mid) == target)
                return mid;
            else if (reader.Get(mid) < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        
        return -1;
    }
}
