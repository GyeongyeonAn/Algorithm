public class Solution 
{
    public string IntToRoman(int num) 
    {
        // 로마 숫자와 대응되는 딕셔너리
        // 큰 숫자부터 작은 숫자 순서로 초기화되어 있어야 한다. 
        Dictionary<int, string> roman = new Dictionary<int, string>()
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"},
        };
        
        // 스트링 결과 변수
        StringBuilder result = new StringBuilder();

        // 모든 로마 문자를 순회한다. 
        foreach (var pair in roman)
        {
            // 만약 num의 값이 현재 로마 숫자 벨류 값보다 크거나 같다면
            while (num >= pair.Key)
            {
                // 문자를 삽입해준다.
                result.Append(pair.Value);
                // 숫자에 로마 숫자 벨류 값을 빼준다.
                // 3000일 경우 M을 3번 빼기 때문에 MMM이 된다. 
                num -= pair.Key;
            }
        }
        
        return result.ToString();
    }
}
