public class Solution 
{
    public string Convert(string s, int numRows) 
    {
        // numRows가 1이거나 s의 길이가 numRows 이하일 때는 변환할 필요가 없습니다.
        if (numRows == 1 || s.Length <= numRows)
            return s;

        // 행의 리스트를 만들고, 각 행에 해당하는 string형의 메모리를 할당받습니다. 
        List<StringBuilder> rows = new List<StringBuilder>();
        for (int i = 0; i < Math.Min(numRows, s.Length); i++)
            rows.Add(new StringBuilder());

        // 현재 행 번호, 초기 행 0번째
        int currentRow = 0;

        // 아래 방향 이동, 초기에는 이동하지 않습니다.
        bool goingDown = false;

        foreach (char c in s) 
        {
            // 현재 문자를 현재 행의 StringBuilder에 추가합니다.
            rows[currentRow].Append(c);
            // 행 이동 방향을 관리합니다. 맨 위 또는 맨 아래 행에 도달하면 방향을 반대로 변경합니다.
            if (currentRow == 0 || currentRow == numRows - 1)
                goingDown = !goingDown;
            currentRow += goingDown ? 1 : -1;
        }

        // 각 행의 StringBuilder를 이어붙여 최종 결과를 얻습니다.
        StringBuilder result = new StringBuilder();
        foreach (StringBuilder row in rows)
            result.Append(row);

        // 최종 결과를 문자열로 변환하여 반환합니다.
        return result.ToString();
    }
}