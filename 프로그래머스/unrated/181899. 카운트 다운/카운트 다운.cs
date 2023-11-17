using System;

public class Solution 
{
    public int[] solution(int start, int end_num) 
    {
        int[] answer = new int[start - end_num + 1];
        int count = start;
        for(int i=0; i<answer.Length; i++)
        {
            if(count >= end_num)
            {
                answer[i] = count;
                count--;
            }
        }
        
        return answer;
    }
}