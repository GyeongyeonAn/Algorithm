public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        // 입력 배열 중 nums1이 더 작은 배열인 경우, 코드를 간단히 하기 위해 두 배열을 교환합니다.
        if (nums1.Length > nums2.Length) {
            return FindMedianSortedArrays(nums2, nums1);
        }
        
        int x = nums1.Length;  // 배열 nums1의 길이
        int y = nums2.Length;  // 배열 nums2의 길이
        
        int low = 0;  // 이진 검색의 시작 위치
        int high = x;  // 이진 검색의 끝 위치
        
        while (low <= high) 
        {
            int partitionX = (low + high) / 2;  // 배열 1을 나눌 위치
            int partitionY = (x + y + 1) / 2 - partitionX;  // 배열 2를 나눌 위치
            
            int maxX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
            int maxY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
            int minX = (partitionX == x) ? int.MaxValue : nums1[partitionX];
            int minY = (partitionY == y) ? int.MaxValue : nums2[partitionY];
            
            if (maxX <= minY && maxY <= minX) {
                if ((x + y) % 2 == 0) 
                {
                    return (Math.Max(maxX, maxY) + Math.Min(minX, minY)) / 2.0;
                } 
                else 
                {
                    return Math.Max(maxX, maxY);
                }
            } 
            else if (maxX > minY) 
            {
                high = partitionX - 1;
            } 
            else 
            {
                low = partitionX + 1;
            }
        }
        
        // 오류 발생 시 기본값 반환.
        return 0.0;
    }
}
