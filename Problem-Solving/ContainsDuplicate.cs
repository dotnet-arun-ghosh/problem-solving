using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public class ContainsDuplicate
    {

        public bool ContainsDuplicateM(int[] nums)
        {
            HashSet<int> keys = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(keys.Contains(nums[i]))
                {
                    return true;
                }
                keys.Add(nums[i]);
            }
            return false;
        }
    }
}
