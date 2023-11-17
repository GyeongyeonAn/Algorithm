using System;

public class Solution 
{
    public int solution(int[] num_list, int n) 
    {
        int answer = 0;
        if(Array.IndexOf(num_list, n) == -1)
            answer = 0;
        else
            answer = 1;
        
        return answer;
    }
}