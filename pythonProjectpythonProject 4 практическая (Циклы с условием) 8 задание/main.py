# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.


def print_hi(name):
    # Use a breakpoint in the code line below to debug your script.
    print(f'Hi, {name}')  # Press Ctrl+F8 to toggle the breakpoint.


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    print_hi('PyCharm')

# See PyCharm help at https://www.jetbrains.com/help/pycharm/

# Вводим натуральное число
number = int(input("Введите натуральное число: "))

# Получаем первую цифру числа
first_digit = int(str(number)[0])

# Инициализируем счетчик
count = 0

# Проходим по каждой цифре в числе
while number > 0:
    # Получаем последнюю цифру числа
    last_digit = number % 10

    # Если последняя цифра равна первой цифре числа, увеличиваем счетчик
    if last_digit == first_digit:
        count += 1

    # Убираем последнюю цифру числа
    number //= 10

# Выводим результат
print(f"Первая цифра {first_digit} встречается в числе {count} раз(а).")