using System;

public class Solution 
{
    public int[,] solution(int n) 
    {
        int length = (int)Math.Pow(2, n) - 1;
        int[,] answer = new int[length, 2];
        int index = 0; // index 초기값을 0으로 설정

        // 하노이 탑 알고리즘 호출
        Hanoi(n, 1, 3, 2, answer, ref index);

        // 결과 배열을 실제 이동 경로 개수만큼 잘라서 반환
        int[,] result = new int[index, 2];
        Array.Copy(answer, result, index * 2); // 결과 배열 잘라내기

        return result;
    }

    // 하노이 탑 알고리즘 구현
    private void Hanoi(int n, int from, int to, int aux, int[,] answer, ref int index)
    {
        if (n == 1)
        {
            // 이동 경로를 answer 배열에 기록
            answer[index, 0] = from;
            answer[index, 1] = to;
            index++;
        }
        else
        {
            // n-1개의 원반을 보조 기둥으로 옮기고
            Hanoi(n - 1, from, aux, to, answer, ref index);

            // 남은 1개의 원반을 목표 기둥으로 옮기고
            answer[index, 0] = from;
            answer[index, 1] = to;
            index++;

            // 보조 기둥에 있는 n-1개의 원반을 목표 기둥으로 옮긴다.
            Hanoi(n - 1, aux, to, from, answer, ref index);
        }
    }
}