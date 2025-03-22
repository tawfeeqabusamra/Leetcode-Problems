public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        Reverse(nums, 0 , nums.Length - 1);
        Reverse(nums, 0 , k - 1);
        Reverse(nums, k , nums.Length - 1);
    }
    private void Reverse(int[] nums, int start, int end){
        for(int i = start, j = end; i < j; i++, j--){
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}