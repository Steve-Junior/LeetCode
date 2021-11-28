public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        var result = new int[nums.Length];

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            result[i] = nums[nums[i]];
        }

        return result;
    }
}