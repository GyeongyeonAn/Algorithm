public class Solution 
{
    public int Reverse(int x) 
    {
        int reversed = 0;

        while (x != 0)
        {
            int lastDigit = x % 10;
            x /= 10;

            // 오버플로우 확인
            if (reversed > int.MaxValue / 10 || (reversed == int.MaxValue / 10 && lastDigit > 7) ||
                reversed < int.MinValue / 10 || (reversed == int.MinValue / 10 && lastDigit < -8))
            {
                return 0;
            }

            reversed = reversed * 10 + lastDigit;
        }

        return reversed;
    }
}
