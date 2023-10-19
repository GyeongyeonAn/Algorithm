public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        List<int> removeIndex = new List<int>();
        int n = nums.Length;

        for (int i = n-1; i >= 0; i--) {
            if (nums[i] == val) {
                removeIndex.Add(i);
            }
        }

        foreach (int index in removeIndex) {
            for (int j = index; j < n - 1; j++) 
            {
                nums[j] = nums[j + 1];
            }
            n--;
        }

        return n;
    }
}