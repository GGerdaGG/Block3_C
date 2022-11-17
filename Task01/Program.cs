// Итерация №1
// Решение в группах задач:
// 1. Напишите программу, которая 
// 1. на вход принимает два
// числа и 
// 2. проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.WriteLine("Введите число1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}