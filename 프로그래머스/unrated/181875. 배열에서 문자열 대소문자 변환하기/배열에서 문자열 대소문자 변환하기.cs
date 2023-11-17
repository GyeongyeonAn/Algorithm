using System;

public class Solution 
{
    public string[] solution(string[] strArr) 
    {
        int length = strArr.Length;
        string[] answer = new string[length];
        for(int i=0; i<length; i++)
        {
            if(i%2 == 0)
                answer[i] = strArr[i].ToLower();
            else
                answer[i] = strArr[i].ToUpper();
        }
        
        return answer;
    }
}