using System;

public class Solution 
{
    public int solution(int a, int b) 
    {
        int answer = 0;
        string ab = a.ToString() + b.ToString();
        string ba = b.ToString() + a.ToString();
        int ab_int = int.Parse(ab);
        int ba_int = int.Parse(ba);
        
        if(ab_int >= ba_int)
            answer = ab_int;
        else
            answer = ba_int;
        
        return answer;
    }
}