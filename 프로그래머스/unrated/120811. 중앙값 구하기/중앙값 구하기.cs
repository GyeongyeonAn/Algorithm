using System;

public class Solution 
{
    public int solution(int[] array) 
    {
        int answer = 0;
        int length = array.Length;
        Array.Sort(array);
        answer = array[length/2];
        
        return answer;
    }
}