// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecDigitOfNum(int number)
{
    return (number % 100) / 10;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Вторая цифра числа: " + SecDigitOfNum(num));