//
public class Solution {
    public int MaxProduct(int[] nums) {
        int max = Int32.MinValue;
        
        int currentMax = 1;
        int currentMin = 1;
        
        foreach (var num in nums)
        {
            int productA = currentMax * num;
            int productB = currentMin * num;
            
            currentMax = Math.Max(num, Math.Max(productA, productB));
            currentMin = Math.Min(num, Math.Min(productA, productB));
            
            max = Math.Max(max, currentMax);
        }
        
        return max;
    }
}
