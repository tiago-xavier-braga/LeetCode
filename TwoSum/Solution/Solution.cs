namespace LeetCode.TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int compared = 0; compared < nums.Count(); compared++)
            {
                for (int comparator = 0; comparator < nums.Count(); comparator++)
                {
                    bool isIndexDifferent = compared != comparator;
                    bool isSumEqualTarget = (nums[compared] + nums[comparator]) == target;

                    if (isIndexDifferent && isSumEqualTarget)
                    {
                        result[0] = compared;
                        result[1] = comparator;
                        break;
                    }
                }
            }

            return result;
        }
    }
}