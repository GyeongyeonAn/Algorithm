using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int answer = 0;
        int sum = 0;
        int multi = 1;
        
        for(int i=0; i<num_list.Length; i++)
        {
            sum += num_list[i];
            multi *= num_list[i];
        }
        
        int multi_sum = sum * sum;
        
        if(multi > multi_sum)
            answer = 0;
        else
            answer = 1;
        
        return answer;
    }
}