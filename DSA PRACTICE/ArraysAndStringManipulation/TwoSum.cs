namespace DSA_PRACTICE.ArraysAndStringManipulation
{

    //Two Sum

    //Prompt: Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //Example:
    //Input: nums = [2, 7, 11, 15], target = 9
    //Output: [0, 1]
    public class TwoSum
    {
        public static void calculate(int target)
        {
            // very inefficient approach rather use a hashmap
            //not dymanic at all  restricted too one value instant fail
            int[] nums = [2, 7, 11, 15];
            target = nums[0] + nums[1];
            Console.WriteLine(target);
        }
    }
}
