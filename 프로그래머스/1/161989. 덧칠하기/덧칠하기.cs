using System;
using System.Text;

public class Solution 
{
    public int solution(int n, int m, int[] section) 
    {
        int answer = 0;

        // 초기 막대 생성
        StringBuilder bar_build = new StringBuilder(new string('o', n));

        // 지정된 섹션을 'x'로 표시
        for (int i = 0; i < section.Length; i++)
        {
            int sectionIndex = section[i] - 1;

            // 섹션 인덱스가 유효한 범위 내에 있는지 확인
            if (sectionIndex >= 0 && sectionIndex < n)
            {
                bar_build[sectionIndex] = 'x';
            }
            else
            {
                // 유효하지 않은 섹션 인덱스 처리 (원하는 대로 예외를 throw하거나 적절히 처리할 수 있음)
                Console.WriteLine($"잘못된 섹션 인덱스: {sectionIndex + 1}");
            }
        }

        // 'x'로 표시된 연속된 섹션의 길이가 'm'인 개수 세기
        for (int i = 0; i < bar_build.Length; i++)
        {
            if (bar_build[i] == 'x')
            {
                for (int j = i; j < i + m && j < bar_build.Length; j++)
                {
                    bar_build[j] = 'o';
                }
                answer++;
            }
        }

        return answer;
    }
}
