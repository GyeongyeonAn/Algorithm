using System;
using System.Collections.Generic;

public class Solution 
{
    int h;
    int w;
    char direction;
    Dictionary<char, (int x, int y)> directionDictionary;

    int[] CalculateMove(string route)
    {
        int[] result = new int[2];
        int route_number = int.Parse(route.Substring(2));
        switch(route[0])
        {
            case 'N':
                result[0] = route_number * -1;
                result[1] = 0;
                direction = 'N';
                break;
            case 'S':
                result[0] = route_number;
                result[1] = 0;
                direction = 'S';
                break;
            case 'W':
                result[0] = 0;
                result[1] = route_number * -1;
                direction = 'W';
                break;
            case 'E':
                result[0] = 0;
                result[1] = route_number;
                direction = 'E';
                break;
        }

        return result;
    }
    
    bool IsMovementPossible(int[] start, int[] end, string[] park)
    {
        // 목표지점이 공원을 벗어나 있으면 실패
        if (end[0] < 0 || end[0] >= h || end[1] < 0 || end[1] >= w)
            return false;

        // 이동 방향과 값은 이미 가지고 있음
        (int y, int x) movement = directionDictionary[direction];

        // 현재 위치를 복사하여 사용
        int currentY = start[0];
        int currentX = start[1];

        // while 루프에서는 end 지점까지의 이동을 확인
        while (currentY != end[0] || currentX != end[1])
        {
            // 현재 위치를 이동
            currentY += movement.y;
            currentX += movement.x;
            
            // 현재 위치가 범위를 벗어나 있으면 실패
            if (currentY < 0 || currentY >= h || currentX < 0 || currentX >= w)
                return false;
            
            // 현재 위치에 장애물이 있다면 이동이 불가능
            if (park[currentY][currentX] == 'X')
                return false;
        }
        return true;
    }

    public int[] solution(string[] park, string[] routes) 
    {
        h = park.Length;
        w = park[0].Length;
        directionDictionary = new Dictionary<char, (int x, int y)>();

        // 동서남북에 따라 이동할 x, y값 추가
        directionDictionary.Add('N', (-1, 0)); // 북쪽
        directionDictionary.Add('E', (0, 1)); // 동쪽
        directionDictionary.Add('S', (1, 0)); // 남쪽
        directionDictionary.Add('W', (0, -1)); // 서쪽
        
        int[] startPos = new int[2];
        int[] endPos = new int[2];
            
        // 스타트 지점을 찾습니다. 
        for(int i = 0; i < h; i++)
        {
            int j = park[i].IndexOf('S');
            if(j != -1)
            {
                startPos[0] = i;
                startPos[1] = j;
                break;
            }
        }
        
        for(int i = 0; i < routes.Length; i++)
        {
            int[] moveVector = CalculateMove(routes[i]);
            endPos[0] = startPos[0] + moveVector[0];
            endPos[1] = startPos[1] + moveVector[1];
            
            // 이동이 가능하면 현재 위치를 업데이트
            if (IsMovementPossible(startPos, endPos, park))
            {
                startPos[0] = endPos[0];
                startPos[1] = endPos[1];
            }
        }
    
        return startPos;
    }
}
