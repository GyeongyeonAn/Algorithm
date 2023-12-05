using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] arr) 
    {
        List<int> x = new List<int>();
        
        for(int i=0; i<arr.Length; i++)
        {
            int pivot = arr[i];
            for(int j=0; j<pivot; j++)
                x.Add(pivot);
        }
        
        int length = x.Count;
        int[] answer = new int[length];
        
        for(int i=0; i<length; i++)
            answer[i] = x[i];
        
        return answer;
    }
}