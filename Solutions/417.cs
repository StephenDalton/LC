//https://leetcode.com/problems/pacific-atlantic-water-flow/discuss/90733/Java-BFS-and-DFS-from-Ocean
public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        List<IList<int>> results = new List<IList<int>>();
        
        int n = heights.Length;
        int m = heights[0].Length;
        
        bool[,] pacific = new bool[n,m];
        bool[,] atlantic = new bool[n,m];
        
        for(int i=0; i<n; i++)
        {
            DFS(heights, pacific, Int32.MinValue, i, 0);
            DFS(heights, atlantic, Int32.MinValue, i, m-1);
        }
        
        for(int i=0; i<m; i++)
        {
            DFS(heights, pacific, Int32.MinValue, 0, i);
            DFS(heights, atlantic, Int32.MinValue, n-1, i);
        }
        
        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j < m; j++) 
            {
                if (pacific[i,j] && atlantic[i,j]) 
                    results.Add(new List<int> {i, j});
            }
        }
            
        return results;
    }
    
    
    private void DFS(int[][] heights, bool[,] canReach, int height, int i, int j) {
        if (i < 0 || i >= heights.Length || j < 0 || j >= heights[0].Length || canReach[i,j] || heights[i][j] < height)
            return;
        
        canReach[i,j] = true;
        
        DFS(heights, canReach, heights[i][j], i+1, j);
        DFS(heights, canReach, heights[i][j], i-1, j);
        DFS(heights, canReach, heights[i][j], i, j+1);
        DFS(heights, canReach, heights[i][j], i, j-1);
    }
}
