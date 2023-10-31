public class Solution 
{
    public int MyAtoi(string s) 
    {
        // 1단계: 입력 문자열에서 숫자로 시작하도록 조정
        int startIndex = 0;
        while (startIndex < s.Length && s[startIndex] == ' ')
        {
            startIndex++;
        }

        // 문자열이 모두 공백인 경우
        if (startIndex == s.Length)
            return 0;

        // 2단계: 부호 확인
        bool isNegative = false;
        if (s[startIndex] == '-')
        {
            isNegative = true;
            startIndex++;
        }
        else if (s[startIndex] == '+')
        {
            startIndex++;
        }

        // 3단계: 문자열을 숫자로 변환 (범위 검사 포함)
        long result = 0; // long을 사용하여 int 범위를 벗어나는 경우를 처리
        while (startIndex < s.Length)
        {
            char c = s[startIndex];
            if (char.IsDigit(c))
            {
                result = result * 10 + (c - '0');
                if (isNegative)
                {
                    if (-result < int.MinValue)
                    {
                        return int.MinValue;
                    }
                }
                else
                {
                    if (result > int.MaxValue)
                    {
                        return int.MaxValue;
                    }
                }
                startIndex++;
            }
            else
            {
                break; // 숫자 이외의 문자가 나오면 루프 종료
            }
        }

        if (isNegative)
        {
            result = -result;
        }

        return (int)result;
    }
}