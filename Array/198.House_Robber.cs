public class Solution
{
    public int Rob(int[] nums)
    {
        var result = 0;

        if (nums.Length > 2)
        {
            var temp = new int[nums.Length];
            temp[0] = nums[0];
            temp[1] = new int[] { nums[0], nums[1] }.Max();

            for (int i = 2; i < nums.Length; i++)
            {
                var array = new int[] { nums[i] + temp[i - 2], temp[i - 1] };
                temp[i] = array.Max();
            }

            result = temp[nums.Length - 1];
        }

        else if (nums.Length < 3)
            result = nums.Max();

        return result;
    }
}