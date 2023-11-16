using System;

public class Solution {
    public string solution(string my_string) 
    {
        string answer = "";
        int length = my_string.Length;
        
        for(int i=length; i>0; i--)
        {
            answer += my_string[i-1];
        }
        
        return answer;
    }
}