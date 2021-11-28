public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var hashtable = new Hashtable();

        for (int i = 0; i < nums.Length; i++)
        {
            var difference = target - nums[i];

            if (hashtable.ContainsKey(difference))
                return new int[] { i, (int)hashtable[difference] };

            if (!hashtable.ContainsKey(nums[i]))
            {
                hashtable.Add(nums[i], i);
            }
        }

        return new int[] { -1, -1 };
    }
}