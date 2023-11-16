using System;

public class Solution {
    public int solution(int n, int k) 
    {
        int answer = 0;
        int nPrice = n * 12000;
        int kPrice = (k - (n/10)) * 2000;
        answer = nPrice + kPrice;
        return answer;
    }
}