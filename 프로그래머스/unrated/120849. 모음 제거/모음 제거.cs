using System;
using System.Collections.Generic;

public class Solution 
{
    public string solution(string my_string) 
    {
        string answer = "";
        
        // 딕셔너리 초기화
        Dictionary<char, bool> myDictionary = new Dictionary<char, bool>()
        {
            {'a', true},
            {'e', true},
            {'i', true},
            {'o', true},
            {'u', true}
        };
        
        for(int i=0; i<my_string.Length; i++)
        {
            if(!myDictionary.ContainsKey(my_string[i]))
            {
                answer += my_string[i];
            }
        }
        
        return answer;
    }
}