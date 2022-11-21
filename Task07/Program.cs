// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 
// 456 -> 6 782 -> 2 918 -> 8


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int last = number % 10;
Console.WriteLine($"Последняя цифра {last}");

// int num = 456; // 456/10 = 45 / 10 = 4
// int last = num % 10; // 6
// int first = num / 100; // 4
