﻿// ДЗ
// **Задача 15:** Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да  
// 7 -> да  
// 1 -> нет

// Решила таким способом, а вот в решении с методом я не понимаю как синтаксически оформить если число с минусом (как записывается if внутри if в методе..?),
// поэтому без минуса.

Console.WriteLine("Введите число дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Да, выходной");
    }
    else
    {
        Console.WriteLine("Нет, рабочий день");
    }
}
else
{
    Console.WriteLine("Не верное число");
}

// Console.WriteLine("Введите число дня недели от 1 до 7: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool Result(int num)
// {
//     return num == 6 || num == 7;
// }
// Console.WriteLine(Result(number) ? "Да, выходной" : "Нет, рабочий день");





