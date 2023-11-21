using System;
using System.Collections.Generic;

public class Solution 
{
    public string solution(int age) 
    {
        string answer = "";
        Dictionary<int, char> myDic = new Dictionary<int, char>()
        {
            {0, 'a'},
            {1, 'b'},
            {2, 'c'},
            {3, 'd'},
            {4, 'e'},
            {5, 'f'},
            {6, 'g'},
            {7, 'h'},
            {8, 'i'},
            {9, 'j'}
        };
        
        string revers = "";
        
        while(age > 0)
        {
            int num = age % 10;
            age /= 10;
            revers += myDic[num];
        }
        
        for(int i=revers.Length-1; i>=0; i--)
        {
            answer += revers[i];
        }
        
        return answer;
    }
}