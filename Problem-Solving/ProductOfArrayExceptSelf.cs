using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public class ProductOfArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            var total = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                total *= nums[i];
            }

            int[] output = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = total / nums[i];
            }
            return output;
        }

        public static int[] ProductExceptSelf1(int[] nums)
        {
            var len = nums.Length;
            var left = new int[len];
            var right = new int[len];
            var output = new int[len];
            int j = len - 2;
            int i = 1;
            left[0] = right[len - 1] = 1;

            while (j >= 0 && i <= len)
            {
                var leftVal = left[i]= left[i - 1] * nums[i - 1];
                var rightVal = right[j] = right[j + 1] * nums[j + 1];

                if (right[i] != 0)
                {
                    output[i] = right[i] * leftVal;
                }

                if (left[j] != 0)
                {
                    output[j] = left[j] * rightVal;
                }

                i++;
                j--;
            }
            return output;
        }
    }
}
