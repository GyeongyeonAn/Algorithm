using System;

public class Solution 
{
    public int[] solution(string s) 
    {
        int[] answer = new int[s.Length];
        
        for(int i=0; i<s.Length; i++)
        {
            int index = i;
            int count = 0;
            while(index >= 0)
            {
                index--;
                if(index != -1)
                {
                    count++;
                    if(s[index] == s[i])
                        break;
                }
            }
            if(index == -1)
                answer[i] = -1;
            else
                answer[i] = count;
        }
        
        return answer;
    }
}