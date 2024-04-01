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

# Начинаем с 1 и переходим к следующему нечетному числу до 99
number = 1
while number <= 99:
    # Если число нечетное, добавляем его к общей сумме
    total_sum += number
    # Переходим к следующему нечетному числу
    number += 2

# Выводим общую сумму
print("Сумма всех нечетных чисел от 1 до 99:", total_sum)