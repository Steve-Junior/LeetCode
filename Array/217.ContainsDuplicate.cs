public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        var dictionary = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dictionary.ContainsKey(num))
            {
                return true;
            }
            dictionary.Add(num, 1);
        }

        return false;
    }
}