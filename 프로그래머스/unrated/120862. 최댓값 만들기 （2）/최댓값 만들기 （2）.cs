using System;

public class Solution 
{
    public int solution(int[] numbers) 
    {
        int answer = 0;
        int max = int.MinValue;
        for(int i=0; i<numbers.Length-1; i++)
        {
            for(int j=i+1; j<numbers.Length; j++)
            {
                int multi = numbers[i] * numbers[j];
                max = max > multi ? max : multi; 
            }
        }
        answer = max;
        return answer;
    }
}