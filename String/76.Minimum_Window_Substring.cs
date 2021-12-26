public class Solution {
    public string MinWindow(string s, string t) {
        var result = new int[] {-1, -1 };
        var resultLen = int.MaxValue;

        if (string.IsNullOrEmpty(t)) return string.Empty;

        var countT = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();

        foreach (var c in t)
        {
            if (!countT.TryGetValue(c, out int value))
            {
                // the key isn't in the dictionary.
                value = 0; // or whatever you want to do
            }

            countT[c] = 1 + value;
        }

        int l = 0;
        int have = 0;
        int need = countT.Count();

        foreach (var r in Enumerable.Range(0, s.Length))
        {
            char c = s[r];

            if (!window.TryGetValue(c, out int value))
            {
                // the key isn't in the dictionary.
                value = 0; // or whatever you want to do
            }

            window[c] = 1 + value;

            if(countT.ContainsKey(c) && window[c] == countT[c])
            {
                have += 1;
            }

            while(have == need)
            {
                //keep our result updated
                int windowSize = r - l + 1;

                if(windowSize < resultLen)
                {
                    result = new int[] { l, r };
                    resultLen = windowSize;
                }

                //pop from the left of our window
                window[s[l]] -= 1;                    
                if(countT.ContainsKey(s[l]) && window[s[l]] < countT[s[l]])
                {
                    have -= 1;
                }

                l += 1;
            }
        }

        int startIndex  = result[0];            

        if (resultLen != int.MaxValue)
             return s.Substring(startIndex, resultLen);

        return string.Empty;  
    }
}