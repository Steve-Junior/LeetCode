using System;
using System.Linq;

public class Solution
{
    public int Rob(int[] nums)
    {
        //Since House[1] and House[n] are adjacent, they cannot be robbed together. Therefore, the problem becomes to rob either House[1]-House[n-1] or House[2]-House[n]

        if (nums.Length == 0) return 0;

        else if (nums.Length == 1) return nums[0];

        else
        {
            int len = nums.Length;
            //House[1] - House[n - 1]
            int first = StartFromHouse1orHouse2(nums, 0, len - 2);

            //House[2] - House[n]
            int second = StartFromHouse1orHouse2(nums, 1, len - 1);

            return Math.Max(first, second);
        }
    }

    int Rob(int[] nums)
    {
        //Since House[1] and House[n] are adjacent, they cannot be robbed together. Therefore, the problem becomes to rob either House[1]-House[n-1] or House[2]-House[n]

        if (nums.Length == 0) return 0;

        else if (nums.Length == 1) return nums[0];

        else
        {
            int len = nums.Length;
            //House[1] - House[n - 1]
            int first = StartFromHouse1orHouse2(nums, 0, len - 2);

            //House[2] - House[n]
            int second = StartFromHouse1orHouse2(nums, 1, len - 1);

            return Math.Max(first, second);
        }
    }
}