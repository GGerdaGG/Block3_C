// ДЗ
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


int NumbersSum(int numM, int numN) 
{
    if (numM > numN)
    {
        return numM + NumbersSum(numM - 1, numN);
    }
    else if (numM < numN)
    {
       return  numM + NumbersSum(numM + 1, numN);
    }
    else
    {
        return numN;
    }
}

int sum = NumbersSum(numberM, numberN);
Console.WriteLine($"Сумма чисел = {sum}");

