using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        double squareRoot = Math.Sqrt(n);
        
        if(squareRoot == (int)squareRoot)
            answer = 1;
        else
            answer = 2;
        return answer;
    }
}