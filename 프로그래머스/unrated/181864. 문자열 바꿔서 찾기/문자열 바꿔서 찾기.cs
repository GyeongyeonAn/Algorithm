using System;
using System.Text;

public class Solution 
{
    public int solution(string myString, string pat) 
    {
        int answer = 0;
        int length = myString.Length;
        
        StringBuilder stringBuilder = new StringBuilder(myString);
        
        for(int i=0; i<length; i++)
        {
            if(stringBuilder[i] == 'A')
                stringBuilder[i] = 'B';
            else
                stringBuilder[i] = 'A';
        }
        
        string reform_string = stringBuilder.ToString();
            
        if(reform_string.Contains(pat))
            answer = 1;
        else
            answer = 0;
        
        return answer;
    }
}