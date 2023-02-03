// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecDigitOfNum(int number)
{
    return (number % 100) / 10;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Вторая цифра числа: " + SecDigitOfNum(num));
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
/*
int ThirdDigitOfNum(int number)
{
    int result = 0;
    if((number < 100) && (-100 < number)) result = -1;
    else
    {
        while(number > 999) number = number / 10;
        result = number %10;
    }
    return result;
}

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Третья цифра числа: " + ThirdDigitOfNum(num));
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool HolidayDetect(int dayNum)
{
    if((dayNum == 6) | (dayNum == 6)) return true;
    else return false;
}

string TranslateToRus(bool vacation)
{
    if(vacation == true) return "выходной";
    else return "не выходной";
}

Console.Write("Введите номер дня недели (1-7): ");
int numOfDay = Convert.ToInt32(Console.ReadLine());

Console.Write("Безусловно, это " + TranslateToRus(HolidayDetect(numOfDay)));
*/