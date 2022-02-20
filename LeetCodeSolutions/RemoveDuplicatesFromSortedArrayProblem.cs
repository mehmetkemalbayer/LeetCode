using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class RemoveDuplicatesFromSortedArrayProblem
    {
        public RemoveDuplicatesFromSortedArrayProblem()
        {
        }
        public int RemoveDuplicates(int[] nums)
        {
            int index = 0;
            int last = nums[0];
            for (int i=1;i<nums.Length;i++)
            {
                if (last == nums[i]) continue;
                nums[++index] = nums[i];                
                last = nums[i];
            }
            return ++index;
        }
    }
}
