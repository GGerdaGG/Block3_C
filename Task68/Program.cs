﻿// ДЗ
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int Akkerman(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    else
    if ((numM != 0) && (numN == 0))
        return Akkerman(numM - 1, 1);
    else
        return Akkerman(numM - 1, Akkerman(numM, numN - 1));
}

Console.WriteLine($"A({numberM},{numberN})={Akkerman(numberM,numberN)}");
