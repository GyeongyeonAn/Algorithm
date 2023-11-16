using System;

public class Solution 
{
    public int[] solution(int n) 
    {
        int count = 0;
        
        for(int i=1; i<=n; i++)
        {
            if(i%2 == 1)
                count++;
        }
        
        int[] answer = new int[count];
        
        for(int i=0; i<count; i++)
        {
            answer[i] = 1 + i*2;
        }
        return answer;
    }
}