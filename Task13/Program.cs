﻿// ДЗ
// **Задача 13:** Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Я решила эту задачу так, очень долго решала, потом попыталась записать то же самое с int ThirdDigit(int num) например,
// но не смогла так как не достаточно информации о синтаксисе. Я просто не знаю как записывается while в этих штуках, потому что на семинаре 
// было только if и вообще не ясно как можно записывать, а как нельзя.


//Без отрицательных чисел:
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     while (number > 1000)
//     {
//         number = number / 10;
//     }
//     number = number % 10;
//     Console.WriteLine($"Третья цифра {number}");
// }

//C отрицательными:
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * -1;
}
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 1000)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра {number}");
}

