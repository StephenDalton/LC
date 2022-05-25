//https://leetcode.com/problems/pacific-atlantic-water-flow/discuss/90733/Java-BFS-and-DFS-from-Ocean
public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        List<IList<int>> res = new List<IList<int>>();
        
        int n = heights.Length;
        int m = heights[0].Length;
        
        bool[,] pacificCanReach = new bool[n,m];
        bool[,] atlanticCanReach = new bool[n,m];
        
        for(int i=0; i<m; i++)
        {
            DFS(heights, pacificCanReach, Int32.MinValue, i, 0);
            DFS(heights, atlanticCanReach, Int32.MinValue, i, n-1);
        }
        
        for(int i=0; i<n; i++)
        {
            DFS(heights, pacificCanReach, Int32.MinValue, 0, i);
            DFS(heights, atlanticCanReach, Int32.MinValue, m-1, i);
        }
        
        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j < m; j++) 
            {
                if (pacificCanReach[i,j] && atlanticCanReach[i,j]) 
                    res.Add(new List<int> {i, j});
            }
        }
            
        return res;
    }
    
    
    private void DFS(int[][] matrix, bool[,] canReach, int height, int x, int y) {
        if (x<0 || x>=matrix[0].Length || y<0 || y>=matrix.Length || canReach[y,x] || matrix[y][x] < height)
            return;
        
        canReach[y,x] = true;
        
        DFS(matrix, canReach, matrix[y][x], x+1, y);
        DFS(matrix, canReach, matrix[y][x], x-1, y);
        DFS(matrix, canReach, matrix[y][x], x, y+1);
        DFS(matrix, canReach, matrix[y][x], x, y-1);
    }
}
