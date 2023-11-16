using System;

public class Solution 
{
    public int solution(string str1, string str2) 
    {
        int answer = 0;
        bool check = str1.Contains(str2);
        
        if(check)
            answer = 1;
        else
            answer = 2;
        
        return answer;
    }
}