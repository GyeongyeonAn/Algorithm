using System;

public class Solution 
{
    public int solution(int[] common) 
    {
        int answer = 0;
        int pivot = 0;
        
        // 등차수열의 경우
        if((common[1] - common[0]) == (common[2] - common[1]))
        {
           pivot = common[1] - common[0];
            answer = common[common.Length-1] + pivot;
        }
        else if((common[1] / common[0]) == (common[2] / common[1]))
        {
            pivot = common[1] / common[0];
            answer = common[common.Length-1] * pivot;
        }
        
        return answer;
    }
}