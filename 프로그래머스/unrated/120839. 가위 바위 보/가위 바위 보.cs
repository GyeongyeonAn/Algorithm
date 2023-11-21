using System;

public class Solution 
{
    public string solution(string rsp) 
    {
        string answer = "";
        for(int i=0; i<rsp.Length; i++)
        {
            switch(rsp[i])
            {
                case '0':
                    answer += "5";
                    break;
                case '2':
                    answer += "0";
                    break;
                case '5':
                    answer += "2";
                    break;
                default:
                    break;
            }
        }
        return answer;
    }
}