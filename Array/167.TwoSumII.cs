public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];

            if(sum == target)
                return new int[] { left + 1, right + 1 }; //1-indexed array
            
            else if (sum > target)
                right -= 1;

            else 
                left += 1;
        }

        return new int[] { 0, 0 };
    }
}