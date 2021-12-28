public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var result = new List<IList<string>>();
        
        //check for empty input
        if(strs.Length == 0 || strs == null)
        {        
            return result;
        }            

        var dictionary = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            //all words which are anagrams should look exactly the same when ordered alphabetically
            
            string value = string.Concat(str.OrderBy(c => c));                                    
            if (!dictionary.ContainsKey(value))
            {
                //ordered word is used as key
                dictionary.Add(value, new List<string>());
            }

            //then all corresponding strings are stored under it in a list
            dictionary[value].Add(str);
        }

        foreach (List<string> item in dictionary.Values)
        {
            result.Add(item);
        }

        return result;

    }
}