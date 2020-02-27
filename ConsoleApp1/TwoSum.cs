using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            var temp_list = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var currentValue = nums[i];

                var otherHalf = target - currentValue;

                if (temp_list.ContainsKey(otherHalf))
                {
                    return new int[] { temp_list[otherHalf], i };
                }

                if (!temp_list.ContainsKey(currentValue))
                {
                    temp_list.Add(currentValue, i);
                }


            }

            return new int[] { };
        }
    }
}
