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

            // 현재 영역 계산식 = 두 높이중 작은 것 * 두 정점 사이의 거리
            int currentArea = Math.Min(h1, h2) * (right - left);
            
            // 최대 물의 양 갱신
            maxWater = Math.Max(maxWater, currentArea);

            // 두 높이중 작은 높이를 안쪽으로 이동
            if (h1 < h2)
                left++;
            else
                right--;
        }

        return maxWater;
    }
}