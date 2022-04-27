//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/discuss/1735493/JavaC%2B%2B-best-ever-EXPLANATION-could-possible
public class Solution {
    public int MaxProfit(int[] prices) {
        
        int maxProfit = 0;
        int minValue = Int32.MaxValue;
        
        for (int i=0; i<prices.Length; i++)
        {
            minValue = Math.Min(minValue, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - minValue);
        }
        
        return maxProfit;
    }
}
