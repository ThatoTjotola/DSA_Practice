namespace DSA_PRACTICE.ArraysAndStringManipulation
{
    /// <summary>
    /// Efficent follows O(N)
    /// </summary>
    //Find the maximum sum of a contiguous subarray in a given array of integers(which may contain negative numbers).

    //Input: An array nums of integers(both positive and negative).
    //Output: The maximum possible sum of a contiguous subarray.
    //Example 1:
    //Input: nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
    //Output: 6
    //Explanation: The subarray [4, -1, 2, 1] has the largest sum = 6.
    //Example 2:
    //Input: nums = [1]
    //Output: 1
    //Explanation: The array only has one element, so the maximum subarray is the single element itself.
    //Example 3:
    //Input: nums = [5, 4, -1, 7, 8]
    //Output: 23
    //Explanation: The subarray [5, 4, -1, 7, 8] has the largest sum = 23.
    public class KadanesAlgorithm
    {
        public static int[] Numbers = [-2, 1, -3, 4, -1, 2, 1, -5, 4];

        public static int maxSubArray(int[] nums)
        {
            int current_sum = nums[0];
            int max_sum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                current_sum = Math.Max(nums[i],current_sum + nums[i]);
                max_sum = Math.Max(max_sum, current_sum);
            }
            return max_sum;
        }
    }
}
