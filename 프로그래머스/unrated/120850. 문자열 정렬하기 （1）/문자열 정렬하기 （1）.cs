using System;
using System.Collections.Generic;
public class Solution 
{
    public int[] solution(string my_string) 
    {
        List<int> numList = new List<int>();
        
        for(int i=0; i<my_string.Length; i++)
        {
            if(char.IsDigit(my_string[i]))
            {
                numList.Add((int)my_string[i] - '0');
            }
        }
        
        numList.Sort();
        
        int[] answer = new int[numList.Count];
        
        for(int i=0; i<answer.Length; i++)
        {
            answer[i] = numList[i];
        }
        
        return answer;
    }
}