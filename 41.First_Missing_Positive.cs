using System;

public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        //var minVe = 1;
        //first sort the array and ignore all values less than 1
        //for each +ve value in nums
        //value - minVe = 0 ? increment smallest by 1
        //value - minVe > 0 ? return smallest as first missing +ve value            

        Array.Sort(nums);

        var minVe = 1;

        foreach (var num in nums)
        {
            if (num <= 0) continue;

            if (num - minVe > 0) break;           

            if (num - minVe == 0) minVe++;
        }

        return minVe;
    }
}