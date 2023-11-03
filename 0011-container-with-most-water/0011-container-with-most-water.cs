using System.Linq;

public class Solution 
{
    public int MaxArea(int[] height) 
    {
        int maxWater = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int h1 = height[left];
            int h2 = height[right];

            // 현재 영역 계산
            int currentArea = Math.Min(h1, h2) * (right - left);
            maxWater = Math.Max(maxWater, currentArea);

            // 더 낮은 라인의 포인터를 내부로 이동
            if (h1 < h2)
                left++;
            else
                right--;
        }

        return maxWater;
    }
}