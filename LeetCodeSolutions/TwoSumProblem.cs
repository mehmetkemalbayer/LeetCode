using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class TwoSumProblem
    {

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { i, map[complement] };
                }
                if (map.ContainsKey(nums[i])) continue;
                map.Add(nums[i], i);
            }
            return null;
        }
    }
}
