using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int start_num, int end_num) 
    {
        List<int> result = new List<int>();
        
        for(int i=start_num; i<=end_num; i++)
        {
            result.Add(i);
        }
        
        int length = result.Count;
        int[] answer = new int[length];
        for(int i=0; i<length; i++)
        {
            answer[i] = result[i];
        }
        
        return answer;
    }
}