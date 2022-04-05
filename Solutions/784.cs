//https://leetcode.com/problems/letter-case-permutation/discuss/255071/Java-detailed-explanation-of-DFSBacktracking-solution
public class Solution {
    public IList<string> LetterCasePermutation(string s) {
        List<string> result = new List<string>();
        
        Backtrack(result, 0, s.ToCharArray());
        return result;
    }
    
    private void Backtrack(List<string> result, int index, char[] s){
        if (index == s.Length)
        {    
            result.Add(new string(s));
            return;
        }
      
        if (char.IsLetter(s[index]))
        {
            s[index] = char.ToLower(s[index]);
            Backtrack(result, index + 1, s);
            
            s[index] = char.ToUpper(s[index]);
            Backtrack(result, index + 1, s);
        }
        else
            Backtrack(result, index + 1, s);
    }
}
