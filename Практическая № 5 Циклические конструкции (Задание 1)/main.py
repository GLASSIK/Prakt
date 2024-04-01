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

# Инициализируем переменную для хранения суммы
total_sum = 0

# Перебираем все четырехзначные числа
for number in range(1000, 10000):
    # Инициализируем переменную для хранения суммы цифр числа
    digit_sum = 0

    # Разбиваем число на цифры и суммируем их
    for digit in str(number):
        digit_sum += int(digit)

    # Если сумма цифр равна 20, добавляем число к общей сумме
    if digit_sum == 20:
        total_sum += number

# Выводим общую сумму
print("Сумма всех четырехзначных чисел, сумма цифр каждого из которых равна 20:", total_sum)