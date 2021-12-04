using System.Linq;

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        var l = 0;
        var output = 0;

        // output = R - (L + 1) 
        // R
        // L
        // [1,1,0,1,1,1]

        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
                l = i + 1
            output = new int[] { output, i - l + 1 }.Max(); //+1 gets the count instead of array index
        }

        return output;        
    }
}