using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public string solution(string my_string) 
    {
        string answer = "";
        
        Dictionary<int, char> myDic = new Dictionary<int, char>();
        
        for(int i=0; i<my_string.Length; i++)
        {
            if(char.IsLower(my_string[i]))
                myDic[i] = char.ToUpper(my_string[i]);
            else if(char.IsUpper(my_string[i]))
                myDic[i] = char.ToLower(my_string[i]);
        }
        
        for(int i=0; i<my_string.Length; i++)
        {
            answer += myDic[i];
        }
        
        return answer;
    }
}