using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        
        // 짝수인 경우 
        if(n % 2 == 0)
        {
            // n 이하의 모든 양의 짝수 제곱 합 return
            for(int i=2; i<=n; i=i+2)
            {
                answer += i * i;
            }
        }
        // 홀수인 경우
        else
        {
            // n 이하의 모든 양의 홀수 합 return
            for(int i=1; i<=n; i=i+2)
            {
                answer += i;
            }
        }
        
        return answer;
    }
}