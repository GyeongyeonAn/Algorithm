using System;

public class Solution 
{
    public string solution(string my_string, int n) 
    {
        string answer = "";
        string tmp = "";
        int index_count = my_string.Length - 1;
        for(int i=0; i<n; i++)
        {
            tmp += my_string[index_count];
            index_count--;
        }
        
        for(int i=tmp.Length-1; i>=0; i--)
        {
            answer += tmp[i];
        }
        
        return answer;
    }
}