
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int Majority = 0;
        int Count = 0;
        List<
        for (int i = 0; i < nums.Length; i++)
        {
            Majority = nums[i];
            if (nums[i] == Majority)
                Count++;
        }


        return Majority;
    }

}
