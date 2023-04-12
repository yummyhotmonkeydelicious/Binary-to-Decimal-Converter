import math

def binary_to_decimal(binary):
    answer = 0
    num = 0
    for x in range(7, -1, -1):
        if binary[x] == "1":
            answer += math.pow(2, num) 
        num += 1
    return answer

print(binary_to_decimal("11111111"))