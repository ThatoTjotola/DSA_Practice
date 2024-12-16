using System.Reflection.Metadata.Ecma335;

namespace DSA_PRACTICE.ArraysAndStringManipulation
{

    //Two Sum

    //Prompt: Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //Example:
    //Input: nums = [2, 7, 11, 15], target = 9
    //Output: [0, 1]
    public class TwoSum
    {
        public static int[] nums = new int[] { 2, 7, 11, 15 };

        public static void calculate(int target)
        {
            // very inefficient approach rather use a hashmap
            //not dymanic at all  restricted too one value instant fail
            //static int[] nums = [2, 7, 11, 15];
            target = nums[0] + nums[1];
            Console.WriteLine(target);
        }

       /// <summary>
       ///  MORE EFFICIENT N(1)
       /// </summary>
       /// <param name="nums"></param>
       /// <param name="target"></param>
       /// <returns></returns>
        public static int[] TwoSums(int[] nums, int target)
        {
            Dictionary<int, int> testHash = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int testvalue = (target - nums[i]);

                if (testHash.ContainsKey(testvalue)){

                    return new int[] { testHash[testvalue], i };
                }

                testHash[nums[i]] = i;
            }
            return new int[0];
        }
    }
}

