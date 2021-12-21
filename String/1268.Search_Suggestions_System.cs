public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        var result = new List<IList<string>>();

        Array.Sort(products);

        for (int i = 0; i < searchWord.Length; i++)
        {
            var word = searchWord.Substring(0, i + 1);

            var innerList = new List<string>();

            for (int j = 0; j < products.Length; j++)
            {
                if (innerList.Count() < 3 && products[j].Length > i)
                {
                    string s = products[j].Substring(0, i + 1);
                    if (s.Equals(word) && s.Length == word.Length)
                        innerList.Add(products[j]);
                }
            }

            result.Add(innerList);
        }

        return result;
    }
}