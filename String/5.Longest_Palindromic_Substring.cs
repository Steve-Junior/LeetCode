public class Solution {
    public string LongestPalindrome(string s)
    {
        if (s.Length == 0 || s.Length == 1)
        {
            return s;
        }

        int a = s.Length - 1;
        int r, l;
        int spos = 0, slen = 0;


        for (int i = 1; i < 3; i++)
        {
            for (int ii = 0; ii <= a - i; ii++)
            {
                l = ii;
                r = ii + i;

                while (l >= 0 && r <= a && s[l] == s[r])
                {
                    if (r - l > slen)
                    {
                        spos = l;
                        slen = r - l;
                    }

                    r++;
                    l--;
                }
            }
        }

        return s.Substring(spos, slen + 1);
    }
}