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

# Инициализируем переменные
count = 0  # счетчик найденных чисел
number = 100  # начинаем проверку с числа 100

# Пока не найдено 15 чисел
while count < 15:
    # Проверяем, делится ли число нацело на 19
    if number % 19 == 0:
        # Выводим число и увеличиваем счетчик
        print(number)
        count += 1
    # Переходим к следующему числу
    number += 1