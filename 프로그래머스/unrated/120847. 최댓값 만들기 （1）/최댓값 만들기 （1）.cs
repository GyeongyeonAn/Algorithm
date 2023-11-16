using System;

public class Solution {
    public int solution(int[] numbers) 
    {
        int answer = 0;
        
        // 최대값을 2번 추출한다.
        // 2개의 최대값을 리턴한다.
        int max_num1 = 0;
        int max_num2 = 0;
        int ban_index = 0;
        
        for(int i=0; i<numbers.Length; i++)
        {
            if(numbers[i] > max_num1)
            {
                ban_index = i;
                max_num1 = numbers[i];
            }
        }
        
        for(int i=0; i<numbers.Length; i++)
        {
            if(i != ban_index && numbers[i] > max_num2)
            {
                max_num2 = numbers[i];
            }
        }
        
        answer = max_num2 * max_num1;
        
        return answer;
    }
}