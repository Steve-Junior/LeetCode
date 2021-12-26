public class Solution {
    public int CharacterReplacement(string s, int k) {
        var l = 0;
        var result = 0;
        var count = new Dictionary<char, int>();

        foreach (var r in Enumerable.Range(0, s.Length))
        {
            if (!count.TryGetValue(s[r], out int value))
            {
                // the key isn't in the dictionary.
                value = 0; // or whatever you want to do
            }

            count[s[r]] = 1 + value;

            while((r - l + 1) - count.Values.Max() > k)
            {
                count[s[l]] -= 1;
                l += 1;
            }

            result = Math.Max(result, r - l + 1);
        }
        return result;  
    }
}