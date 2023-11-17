using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int answer = 0;
        int length = num_list.Length;
        int sum = 0;
        int multi = 1;
        
        for(int i=0; i<length; i++)
        {
            sum += num_list[i];
            multi *= num_list[i];
        }
        
        // 리스트 길이가 11 이상이면
        if(length >= 11)
        {
            // 모든 원소의 합 리턴
            answer = sum;
        }
        // 모든 원소의 합이 10 이하라면
        
        if(length <= 10)
        {
            // 모든 원소의 곱을 리턴
            answer = multi;
        }
        
        return answer;
    }
}