//
public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> results = new List<string>();
        
        for (int i=1; i<=n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                results.Add("FizzBuzz");
            else if (i % 3 == 0)
                results.Add("Fizz");
            else if (i % 5 == 0)
                results.Add("Buzz");
            else
                results.Add(i.ToString());
        }
        
        return results;
    }
}
