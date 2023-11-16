using System;

public class Solution 
{
    public double solution(int[] numbers) 
    {
        double answer = 0;
        int count = numbers.Length;
        for(int i=0; i<count; i++)
        {
            answer += numbers[i];
        }
        answer /= count;
        return answer;
    }
}