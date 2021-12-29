public class Solution {
    public int CountSubstrings(string s) {
        int result = 0;

        foreach (int i in Enumerable.Range(0, s.Length))
        {
            //odd length palindrome
            int l = i; int r = i;

            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                result += 1;
                l -= 1;
                r += 1;
            }


            //even length palindrome
            l = i; r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {                    
                result += 1;
                l -= 1;
                r += 1;
            }
        }

        return result;
    }
}