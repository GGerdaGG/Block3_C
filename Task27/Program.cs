// ДЗ
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Digits(int num)
{
    int sum = 0;
    int b = 0;
    while (num > 0)
    {
        b = num % 10; 
        sum = sum + b; 
        num = num / 10; 
    }
    return sum;
}
if (number < 0) number = -number;
int result = Digits(number);
Console.WriteLine($"Сумма цифр в числе {number} = {result}");



