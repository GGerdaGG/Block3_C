// ДЗ
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Metod(int num)
{
return ((num / 10000 == num % 10) && (num/10%10 == num/1000%10));
}

Console.WriteLine( Metod(number) ? "Да, палиндром" : "Нет, не палиндром");


// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int r=num/10%10; //получаем 4ое число
// Console.WriteLine(r);

// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int r=num/1000%10; //получаем 2ое число
// Console.WriteLine(r);

// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int r=num/10000; //получаем 1ое число
// Console.WriteLine(r);

// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int r=num%10; //получаем 5ое число
// Console.WriteLine(r);

