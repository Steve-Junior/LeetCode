public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        //Do not return anything, modify nums1 in-place instead.
        var last = m + n - 1;

        while (m > 0 && n > 0)
        {
            if (nums1[m - 1] > nums2[n - 1])
            {
                nums1[last] = nums1[m - 1];
                m -= 1;
            }
            else
            {
                nums1[last] = nums2[n - 1];
                n -= 1;
            }

            last -= 1;
        }

        while (n > 0)
        {
            nums1[last] = nums2[n - 1];
            n = n - 1;
            last = last - 1;
        }
    }
}