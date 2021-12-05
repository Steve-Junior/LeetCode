using System;
using System.Linq;

public class Solution
{
    public int Rob(int[] nums)
    {
        //Since House[1] and House[n] are adjacent, they cannot be robbed together. Therefore, the problem becomes to rob either House[1]-House[n-1] or House[2]-House[n]

        var result = 0;

        if (nums.Length == 1)
            result = nums[0];

        else if (nums.Length == 2)
            result = new int[] { nums[0], nums[1] }.Max();

        else if(nums.Length > 2)
        {
            //House[1] - House[n - 1]
            var model1 = GetMaxAmount(nums.Take(nums.Length - 1).ToArray());

            //House[2] - House[n]
            var model2 = GetMaxAmount(nums.Skip(1).ToArray());

            result = new int[] { model1, model2 }.Max();
        }

        return result;
    }

    static int GetMaxAmount(int[] nums)
    {
        var temp = new int[nums.Length];

        temp[0] = nums[0];
        temp[1] = new int[] { nums[0], nums[1] }.Max();

        for (int i = 2; i < nums.Length; i++)
        {
            var array = new int[] {
                    nums[i] + temp[i - 2],
                    temp[i - 1]
                };

            temp[i] = array.Max();
        }

        return temp[nums.Length - 1];
    }
}