using System;

public class Solution 
{
    public string solution(string s, string skip, int index) 
    {
        string answer = "";
        
        for(int i=0; i<s.Length; i++)
        {
            char target = s[i];
            for(int j=0; j<index;)
            {
                target = target + 1 > 'z' ? 'a' : (char)(target + 1);
                // 스킵에 포함되어 있으면 스킵하기
                while(skip.Contains(target))
                {
                    target = target + 1 > 'z' ? 'a' : (char)(target + 1);
                }
                j++;
            }
            answer += target;
        }
        
        return answer;
    }
}