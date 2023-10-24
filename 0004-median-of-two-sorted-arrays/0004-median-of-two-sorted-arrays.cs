public class Solution 
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        int m = nums1.Length;
        int n = nums2.Length;
        
        // 두 배열을 합칩니다.
        int[] merged = new int[m + n];
        
        int i = 0, j = 0, k = 0;

        while (i < m && j < n) {
            if (nums1[i] < nums2[j]) {
                merged[k] = nums1[i];
                i++;
            } 
            else 
            {
                merged[k] = nums2[j];
                j++;
            }
            k++;
        }
        
        // 남은 요소들을 복사
        while (i < m) {
            merged[k] = nums1[i];
            i++;
            k++;
        }

        while (j < n) {
            merged[k] = nums2[j];
            j++;
            k++;
        }
        
        // 합친 배열을 정렬합니다.
        Array.Sort(merged);
        
        // 중앙값 계산
        if ((m + n) % 2 == 0) 
        {
            int mid1 = merged[(m + n) / 2 - 1];
            int mid2 = merged[(m + n) / 2];
            return (double)(mid1 + mid2) / 2.0;
        } 
        else 
        {
            return (double)merged[(m + n) / 2];
        }
    }
}

