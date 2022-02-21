using System;
namespace LeetCodeSolutions
{
    public class MaxSubArrayProblem
    {
        public MaxSubArrayProblem()
        {
            
        }
        public int MaxSubArray(int[] nums)
        {
            int maxSum = int.MinValue;
            int curSum = 0;
            for(int i=0;i<nums.Length;i++)
            {
                curSum += nums[i];
                if (curSum> maxSum)
                {
                    maxSum = curSum;
                }
                if (curSum <0)
                {
                    curSum = 0;
                }
            }
            return maxSum;
        }
        // [-2,-1,-4,0,-1,1,2,-3,1]
        // [-2,-3]
        // [-2,-1]
        // [5,9,8,15,23]
        // [-1,-3]
        //5, 4, -1, 7, 8
    }
}
