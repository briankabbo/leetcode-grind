public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int current = 0;
        int best = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
                current++;
            else
            {
                best = Math.Max(current, best);
                current = 0;
            }

        }
        best = Math.Max(current, best);
        return best;
    }
}