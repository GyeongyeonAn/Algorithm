using System;

public class Solution {
    public int[] solution(int[] arr, int n) 
    {
        int length = arr.Length;
        bool isEven = length % 2 == 0 ? true : false;
        
        if(isEven)
            for(int i=1; i<length; i+=2)
                arr[i] += n;
        else
            for(int i=0; i<length; i+=2)
                arr[i] += n;
        
        return arr;
    }
}