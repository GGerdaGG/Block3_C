﻿// ДЗ
// **Задача 6:** Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да  
// -3 -> нет  
// 7 -> нет

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0) //деление на два без остатка
{
    Console.WriteLine("Да, является четным");
}
else
{
    Console.WriteLine("Нет, не является четным");
}

//