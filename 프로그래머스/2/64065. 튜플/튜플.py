def solution(s):
    # 중괄호와 쉼표를 제거하고 숫자들을 리스트에 저장
    numbers = [int(num) for num in s.replace('{', '').replace('}', '').split(',') if num.isdigit()]

    # 각 숫자의 등장 횟수를 세기 위한 딕셔너리 생성
    count_dict = {}
    for num in numbers:
        if num in count_dict:
            count_dict[num] += 1
        else:
            count_dict[num] = 1

    # 중복 횟수를 기준으로 내림차순 정렬
    sorted_numbers = sorted(count_dict.keys(), key=lambda x: count_dict[x], reverse=True)

    return sorted_numbers