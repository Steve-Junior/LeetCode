public class Solution {
    public bool IsAnagram(string s, string t) {
      return string.Concat(s.OrderBy(c => c)) == string.Concat(t.OrderBy(c => c)); 
    }
}