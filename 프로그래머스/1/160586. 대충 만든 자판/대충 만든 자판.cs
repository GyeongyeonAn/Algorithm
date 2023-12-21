using System;

public class Solution 
{
    
    int find_key(string keys, char target)
    {
        return keys.IndexOf(target);
    }
    
    public int[] solution(string[] keymap, string[] targets) 
    {
        int length = targets.Length;
        int[] answer = new int[length];
        int min_index = Int32.MaxValue;
        int sum = 0;
        for(int i=0; i<length; i++)
        {
            sum = 0;
            for(int k=0; k<targets[i].Length; k++)
            {
                min_index = Int32.MaxValue;
                for(int j=0; j<keymap.Length; j++)
                {
                    int index = find_key(keymap[j], targets[i][k]);
                    // 인덱스의 최소 값을 구해줘
                    if(index != -1)
                        min_index = min_index < index ? min_index : index;
                }
                // 인덱스의 최소 값을 더해줘
                if(min_index != Int32.MaxValue)
                {
                    sum += min_index + 1;
                }
                else
                {
                    sum = -1;
                    break;
                }
            }
            answer[i] = sum;
        }
        
        return answer;
    }
}