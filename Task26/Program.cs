// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

//for используют когда нам известно количество нужных циклов и while когда не известно


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Digits(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count == 0 ? 1 : count;
}
if (number < 0) number = -number;
int result = Digits(number);
Console.WriteLine($"Колличество цифр в числе {number} = {result}");

// Math.Abs(-123)     или можно использовать эту команду
// System.Console.WriteLine(Math.Abs(-123));

