# 두 문자가 동일한지 여부를 판단하는 함수
def is_match(user, ban):
    # 두 문자열의 길이가 다르면 False를 반환
    if len(user) != len(ban):
        return False
    for u, b in zip(user, ban):
        # 밴 아이디의 문자가 '*'이 아니면서 유저 아이디의 문자와 다르다면 False를 반환
        if b != '*' and b != u:
            return False
    # 모든 조건을 통과하면 True를 반환
    return True

# 유저 아이디와 밴 아이디를 사용하여 가능한 조합을 찾는 재귀 함수
def find_combinations(user_id, banned_id, visited, index):
    # 모든 밴 아이디에 대한 검사를 완료했을 경우 현재까지의 조합을 반환
    if index == len(banned_id):
        return [tuple(visited)]

    result = []
    # 모든 유저 아이디에 대해 검사
    for i in range(len(user_id)):
        # 아직 사용되지 않았고, 현재 유저 아이디와 현재 밴 아이디가 매치되면
        if not visited[i] and is_match(user_id[i], banned_id[index]):
            visited[i] = True
            # 다음 밴 아이디에 대한 조합을 찾기 위해 재귀 호출
            result.extend(find_combinations(user_id, banned_id, visited, index + 1))
            visited[i] = False

    return result

# 최종적인 솔루션 함수
def solution(user_id, banned_id):
    visited = [False] * len(user_id)
    combinations = find_combinations(user_id, banned_id, visited, 0)
    # 중복된 조합을 제외하기 위해 set을 사용하고, 최종적으로 set의 길이를 반환
    answer = len(set(combinations))
    return answer
