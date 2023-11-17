using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int n, int[] numlist) 
    {
        int count = 0;
        List<int> tmp = new List<int>();
        for(int i=0; i<numlist.Length; i++)
        {
            if(numlist[i] % n == 0)
            {
                count++;
                tmp.Add(numlist[i]);
            }
        }
        
        int[] answer = new int[count];
        int index = 0; 
        
        foreach(int item in tmp)
        {
            answer[index] = item;
            index++;
        }
        
        return answer;
    }
}