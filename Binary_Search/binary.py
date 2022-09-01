from random import randint

x = randint(0, 100)
count_perebor = 0
# метод последовательного перебора.
for i in range(0, 101):
    count_perebor += 1
    if x == i:
        print("Число найдено!")
        break

# print ("Загаданное число было ",x,"" "и для его поиска перебором потребовалость ",count_perebor," операций ,методом поиска 1. ")


count_random = 1
# метод случайного отгадывания.

y = randint(0, 100)
while x != y:
    y = randint(0, 100)
    count_random += 1
# print ("Загаданное число было ",x,"" "и для его поиска угадаванием потребовалость ",count_random," операций ,методом поиска 2. ")
right = 100
left = 0
x = randint(left, right)
count_binary = 1
# бинарный поиск
print("Давай начнем игру - угадай число от 0 до 100000")

mid = (right + left) // 2


while x != mid:
    print(mid)
    if x < mid:
        print("Меньше")
        right = mid - 1
    else:
        print("Больше")
        left = mid + 1

    mid = (right + left) // 2

    count_binary += 1

print("Загаданное число было ",x,"" "и для его поиска бинарным алгоритмом потребовалость ",count_binary," операци ,методом поиска 3. ",)
