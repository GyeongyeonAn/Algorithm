using System;

public class Solution 
{
    public int[] solution(int[] array) 
    {
        int[] answer = new int[2];
        int max = int.MinValue;
        int maxIndex = -1;
        for(int i=0; i<array.Length; i++)
        {
            if(max < array[i])
            {
                max = array[i];
                maxIndex = i;
            }
        }
        answer[0] = max;
        answer[1] = maxIndex;
        return answer;
    }
}