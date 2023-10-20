public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        int maxLength = 0;
        int startIndex = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
        
        for (int endIndex = 0; endIndex < s.Length; endIndex++) {
            char currentChar = s[endIndex];
            
            if (charIndexMap.ContainsKey(currentChar)) {
                // 중복 문자를 발견한 경우, 시작 인덱스를 조절
                startIndex = Math.Max(startIndex, charIndexMap[currentChar] + 1);
            }
            
            charIndexMap[currentChar] = endIndex; // 문자의 인덱스를 갱신
            maxLength = Math.Max(maxLength, endIndex - startIndex + 1);
        }
        
        return maxLength;
    }
}