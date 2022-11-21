// ДЗ
// **Задача 10:** Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **вторую** цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5  
// 782 -> 8  
// 918 -> 1


// Решила тремя способами, до сих пор не понимаю в чем разница нижних двух, только в синтаксисе?


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int first = number % 100;
int second = first / 10;
Console.WriteLine($"Вторая цифра {second}");

// Если ввели не трехзначное:

// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100 || number > 999)
// {
//     Console.WriteLine("Не верное число");
// }
// else
// {
//     int first = number % 100;
//     int second = first / 10;
//     Console.WriteLine($"Вторая цифра {second}");
// }

// С методом
// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100 || number > 999)
// {
//     Console.WriteLine("Не верное число");
// }
// else
// {
//     int SecondNumber(int num)
//     {
//         int first = num % 100;
//         int second = first / 10;
//         return second;
//     }
//     Console.WriteLine($"Вторая цифра {SecondNumber(number)}");
// }

