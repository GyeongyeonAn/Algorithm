public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        for(int i=0; i<nums2.Length; i++)
        {
            for(int j=0; j<nums1.Length; j++)
            {
                if(nums1[j] == 0)
                {
                    nums1[j] = nums2[i];
                    break;
                }
            }
        }

        int tmp;
        for(int i=nums1.Length-1; i>0; i--)
        {
            for(int j=0; j<i; j++)
            {
                if(nums1[j] > nums1[j+1])
                {
                    tmp = nums1[j];
                    nums1[j] = nums1[j+1];
                    nums1[j+1] = tmp;
                }
            } 
        }    
    }
}