using System;

public class Solution 
{
    public int[] solution(int[] numbers, string direction) 
    {
        int length = numbers.Length;
        int[] answer = new int[length];
        
        if(direction == "left")
        {
            for(int i=0; i<length; i++)
            {
                int nextIndex = (i+1)%length;
                answer[i] = numbers[nextIndex];
            }
        }
        else
        {
            for(int i=0; i<length; i++)
            {
                int prevIndex = i-1 < 0 ? length-1 : i-1;
                answer[i] = numbers[prevIndex];
            }
        }
        return answer;
    }
}