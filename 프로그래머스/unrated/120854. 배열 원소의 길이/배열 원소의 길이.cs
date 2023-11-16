using System;

public class Solution 
{
    public int[] solution(string[] strlist) 
    {
        int length = strlist.Length; 
        int[] answer = new int[length];
        
        for(int i=0; i<length; i++)
        {
            answer[i] = strlist[i].Length;
        }
        
        return answer;
    }
}