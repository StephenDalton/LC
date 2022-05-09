//
public class Codec {
    // Encodes a list of strings to a single string.
    public string encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        
        foreach (string s in strs) 
        {
            sb.Append(s.Length).Append('/').Append(s);
        }
        
        return sb.ToString();
    }

    // Decodes a single string to a list of strings.
    public List<string> decode(string s) {
        var result = new List<string>();        
        var start = 0;
        
        while(start < s.Length) //gotcha
        {
            var i = s.IndexOf("/", start);
            var len = Convert.ToInt32(s.Substring(start, i - start));
            result.Add(s.Substring(i + 1, len));
            start = i + len + 1;
        }        
        
        return result;
    }
}
// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(strs));
