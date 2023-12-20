public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int difference = target;
        int[] test = nums;
        int[] sumNums = new int[2];
        bool foundAnswer = false;

        for (int i = 0; i < nums.Length; i++)
        {
            difference -= nums[i];
            test = nums.Skip(i+1).ToArray();
            if (test.Contains(difference) && foundAnswer != true)
            {
                sumNums[0] = i;
                sumNums[1] = Array.FindLastIndex(nums, x => x == difference);
                foundAnswer = true;
            }
            else difference = target;
        }
        return sumNums;
    }
}