//
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int idx1 = m - 1;
        int idx2 = n - 1;
        int insertIndex = m + n - 1;
        
        while (idx1 >= 0 && idx2 >= 0)
        {
            if (nums1[idx1] >= nums2[idx2])
            {
                nums1[insertIndex] = nums1[idx1];
                idx1--;
            }
            else
            {
                nums1[insertIndex] = nums2[idx2];
                idx2--;
            }
            
            insertIndex--;
        }
        
        while (idx2 >= 0)
        {
            nums1[insertIndex] = nums2[idx2];
            idx2--;
            insertIndex--;
        }
    }
}
