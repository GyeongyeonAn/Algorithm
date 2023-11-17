using System;
using System.Collections.Generic;

public class Solution 
{
    public string[] solution(string my_string) 
    {
        int start_index = 0;
        int count = 0;
        List<string> string_list = new List<string>();
        for(int i=0; i<my_string.Length; i++)
        {
            // 공백을 만난 경우 
            if(my_string[i] == ' ')
            {
                string_list.Add(my_string.Substring(start_index, i - start_index));
                start_index = i+1;
                count++;
            }
            // 마지막인 경우
            if(i == my_string.Length-1)
            {
                string_list.Add(my_string.Substring(start_index, i - start_index + 1));
                count++;
            }
        }
        
        string[] answer = new string[count];
        
        for(int i=0; i<count; i++)
        {
            answer[i] = string_list[i];
        }
        
        return answer;
    }
}