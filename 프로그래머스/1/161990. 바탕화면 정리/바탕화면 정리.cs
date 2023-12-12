using System;

public class Solution 
{
    public int[] solution(string[] wallpaper) 
    {
        int[] answer = new int[4];
        int h = wallpaper.Length;
        int w = wallpaper[0].Length;

        // 가로 방향으로 순회하며 최소, 최대 인덱스 구하기
        int w_min_index = w;
        int w_max_index = 0;

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                if (wallpaper[i][j] == '#')
                {
                    w_min_index = Math.Min(w_min_index, j);
                    w_max_index = Math.Max(w_max_index, j);
                }
            }
        }

        // 세로 방향으로 순회하며 최소, 최대 인덱스 구하기
        int h_min_index = h;
        int h_max_index = 0;

        for (int i = 0; i < w; i++)
        {
            for (int j = 0; j < h; j++)
            {
                if (wallpaper[j][i] == '#')
                {
                    h_min_index = Math.Min(h_min_index, j);
                    h_max_index = Math.Max(h_max_index, j);
                }
            }
        }

        answer[0] = h_min_index;
        answer[1] = w_min_index;
        answer[2] = h_max_index+1;
        answer[3] = w_max_index+1;

        return answer;
    }
}