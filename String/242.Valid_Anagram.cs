public class Solution {
    public bool IsAnagram(string s_input, string t_input) {
         if (s_input.Length != t_input.Length) return false;

        var s_dictionary = new Dictionary<char, int>();
        var t_dictionary = new Dictionary<char, int>();

        foreach (var i in Enumerable.Range(0, s_input.Length))
        {
            if (!s_dictionary.TryGetValue(s_input[i], out int svalue))
            {
                // the key isn't in the dictionary.
                svalue = 0; // or whatever you want to do
            }

            s_dictionary[s_input[i]] = 1 + svalue;

            if (!t_dictionary.TryGetValue(t_input[i], out int tvalue))
            {
                // the key isn't in the dictionary.
                tvalue = 0; // or whatever you want to do
            }

            t_dictionary[t_input[i]] = 1 + tvalue;

        }

        return AreDictionariesEqual(t_dictionary, s_dictionary);
    }
    
    private static bool AreDictionariesEqual(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
    {
            return dict1.Keys.Count == dict2.Keys.Count &&
                   dict1.Keys.All(k => dict2.ContainsKey(k) && object.Equals(dict2[k], dict1[k]));
    }
}