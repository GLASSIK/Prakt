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
#Даны два числа A и B (A<B). Найти сумму квадратов всех целых чисел от А до В включительно.
A=int(input("Введите чило A:"))
B = int(input("Введите число B (больше A): "))

# Проверяем, что A < B
if A>B:
    print("Ошибка: A должно быть меньше B")
else:
    # Инициализируем переменную для хранения суммы квадратов
    sum_of_squares = 0

    # Используем цикл для прохода от A до B (включительно) и нахождения суммы квадратов
    for i in range(A, B + 1):
        sum_of_squares += i ** 2

    # Выводим результат
    print(f"Сумма квадратов всех целых чисел от {A} до {B} включительно: {sum_of_squares}")