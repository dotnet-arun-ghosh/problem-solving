using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{

    /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    You can return the answer in any order.



    Example 1:

    Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Output: Because nums[0] + nums[1] == 9, we return [0, 1].
    Example 2:

    Input: nums = [3,2,4], target = 6
    Output: [1,2]
    Example 3:

    Input: nums = [3,3], target = 6
    Output: [0,1]


    Constraints:

    2 <= nums.length <= 103
    -109 <= nums[i] <= 109
    -109 <= target <= 109
    Only one valid answer exists.*/

    public static class TwoSum
    {
        // Brute force
        public static int[] TwoSumValue(int[] nums, int target)
        {
            var length = nums.Length;
            var numArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                numArray[i] = target - nums[i];

                if (numArray[i] >= 0)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (nums[j] == numArray[i] && i != j)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
            }
            return new int[0];
        }

        // Brute force
        public static int[] TwoSumValueOn(int[] nums, int target)
        {
            var length = nums.Length;
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < length; i++)
            {
                if (dictionary.TryGetValue(nums[i], out int prevIndex))
                {
                    return new int[] { prevIndex, i };
                }
                else
                {
                    dictionary.Add(target - nums[i], i);
                }
            }
          
            return new int[] { };
        }
    }
}
