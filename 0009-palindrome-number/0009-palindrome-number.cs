public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) {
            return false;
        }

        // 정수를 문자열로 변환합니다.
        string strX = x.ToString();

        // 문자열의 시작과 끝부분에서 시작할 두 개의 포인터를 초기화합니다.
        int left = 0;
        int right = strX.Length - 1;

        // 문자열의 양 끝에서 해당 위치에 있는 문자를 비교합니다.
        while (left < right) {
            if (strX[left] != strX[right]) {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
