public class Solution 
{
    public string LongestPalindrome(string s) 
    {
        int start = 0;    // 가장 긴 팰린드롬의 시작 인덱스
        int end = 0;      // 가장 긴 팰린드롬의 끝 인덱스
        
        for (int i = 0; i < s.Length; i++) 
        {
            // 홀수 길이 팰린드롬 확장
            int len1 = ExpandAroundCenter(s, i, i);
            
            // 짝수 길이 팰린드롬 확장
            int len2 = ExpandAroundCenter(s, i, i + 1);
            
            // 현재 팰린드롬의 길이 계산
            int len = Math.Max(len1, len2);
            
            // 현재 팰린드롬이 이전에 찾은 팰린드롬보다 길면 갱신
            if (len > end - start) 
            {
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }
        
        // 가장 긴 팰린드롬을 문자열로 반환
        return s.Substring(start, end - start + 1);
    }
    
    // 주어진 문자열 s에서 left와 right를 중심으로 팰린드롬을 확장하며 팰린드롬의 길이를 찾는 함수
    private int ExpandAroundCenter(string s, int left, int right) 
    {
        while (left >= 0 && right < s.Length && s[left] == s[right]) 
        {
            left--;
            right++;
        }
        return right - left - 1;
    }
}