//
public class Solution {
    public int MaxArea(int[] height) {
        
        int max = 0;
        
        int left = 0;
        int right = height.Length - 1;
        
        while (left < right)
        {
            int shortest = Math.Min(height[left], height[right]);
            max = Math.Max(max, shortest * (right - left) );
            
            if (height[left] < height[right])
                left++;
            else
                right--;
        }
        
        return max;
    }
}
