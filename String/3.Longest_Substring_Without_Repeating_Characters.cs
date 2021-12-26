public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<int> hashSet = new();
        int l = 0;
        int result = 0;            

        foreach(var r in Enumerable.Range(0, s.Length))
        {
            while (hashSet.Contains(s[r]))
            {
                hashSet.Remove(s[l]);
                l += 1;
            }

            hashSet.Add(s[r]);
            result = Math.Max(result, r - l + 1);
        }

        return result;
    }
}