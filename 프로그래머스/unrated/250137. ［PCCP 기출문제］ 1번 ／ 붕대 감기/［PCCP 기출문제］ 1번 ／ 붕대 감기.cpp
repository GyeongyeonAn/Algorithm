#include <string>
#include <vector>

using namespace std;

// 힐을 계산하는 함수
int heal(int hp, int max_hp, int amount)
{
    hp += amount;
    if(hp > max_hp)
        return max_hp; 
    return hp;
}

// 피격을 계산하는 함수
int hit(int hp, int amount)
{
    hp -= amount;
    if(hp <= 0)
        return -1;
    return hp;
}


int solution(vector<int> bandage, int health, vector<vector<int>> attacks) 
{
    // 남은 체력
    int answer = health;
    // 시간 초 
    int t=0;
    int heal_count = 0;
    int attack_index = 0;
    
    while(true)
    {
        // 몬스터의 마지막 공격일때, 종료
        if(attack_index == attacks.size())
            break;
        
        t++;
        // 힐이 가능한 경우 : 몬스터에게 피격받은 시간이 아니임
        if(t != attacks[attack_index][0])
        {
            heal_count++;
            // 힐을 할건데, 힐 카운터 값에 따라 추가량을 배정해줌
            if(heal_count == bandage[0])
            {
                // 추가 힐 적용
                answer = heal(answer, health, bandage[1] + bandage[2]);
                // 힐 카운터 초기화
                heal_count = 0;
            }
            else
                answer = heal(answer, health, bandage[1]);
        }
        // 공격 받았음
        else
        {
            // 힐 카운터 초기화
            heal_count = 0;
            // 어택 데미지 적용
            answer = hit(answer, attacks[attack_index][1]);
                
            // 만약 죽었다면 -1 리턴 종료
            if(answer < 0)
                return answer;
            
            attack_index++;
        }
    }
    return answer;
}