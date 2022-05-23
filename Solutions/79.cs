//https://leetcode.com/problems/word-search/discuss/279279/Java-Simple-with-Explanation!
public class Solution {
    public bool Exist(char[][] board, string word) {
        
        for (int i=0; i<board.Length; i++)
        {
            for (int j=0; j<board[0].Length; j++)
            {
                if (board[i][j] == word[0] && ExistHelper(board, i, j, word, 0))
                    return true;
            }
        }
        return false;
    }
    
    private bool ExistHelper(char[][] board, int x, int y, string word, int wordIndex) {
        
        if (wordIndex == word.Length)
            return true;
        
        if (x < 0 || x >= board.Length || y < 0 || y >= board[0].Length)
            return false;
        
        if (board[x][y] != word[wordIndex])
            return false;
        
        char temp = board[x][y];
        board[x][y] = '0';
        
        wordIndex++;
        
        bool up = ExistHelper(board, x, y + 1, word, wordIndex);
        bool down = ExistHelper(board, x, y - 1, word, wordIndex);
        bool left = ExistHelper(board, x - 1, y, word, wordIndex);
        bool right = ExistHelper(board, x + 1, y, word, wordIndex);
        
        board[x][y] = temp;
        
        return up || down || left || right;
    }
}
