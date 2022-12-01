// ДЗ
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Б не отрицательное, проверку числа Б
// А первое число может быть любым с минусом



Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0) Console.WriteLine("Не верное число");
else
{
    int result = Exponent(numberA, numberB);
    Console.WriteLine(result);
}

int Exponent(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}
