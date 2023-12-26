using System;

public class Solution 
{
    public string solution(string[] cards1, string[] cards2, string[] goal) 
    {
        string answer = "Yes";
        
        int card1_count = 0;
        int card2_count = 0; 
        
        for(int i=0; i<goal.Length; i++)
        {
            if(card1_count < cards1.Length && goal[i] == cards1[card1_count])
            {
                card1_count++;
            }
            else if(card2_count < cards2.Length && goal[i] == cards2[card2_count])
            {
                card2_count++;
            }
            else
            {
                answer = "No";
            }
        }
        
        return answer;
    }
}