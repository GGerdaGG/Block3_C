// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// 456 -> 46 
// 782 -> 72 
// 918 -> 98


int number = new Random().Next(99, 1000); //функция для получения случайного числа, 100 минимальное значение, 1000 максимальное. Если пусто, то в рамках int
Console.WriteLine($"Случайное число из диапазона 100 - 999 => {number}"); //показываем пользователю какое случайное число вышло
int firstDigit = number / 100; // 78 / 10 = 7 
int secondDigit = number % 10; // 78 % 10 = 8
if (firstDigit == secondDigit) Console.WriteLine($"Цифры одинаковые");
else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");




int number = new Random().Next(99, 1000);
Console.WriteLine($"Случайное число из отрезка 99 - 1000 --> {number}");


//    int firstDigit = number / 100;  
//    int secondDigit = number % 10;
//   Console.WriteLine($"Число:  {firstDigit}{secondDigit} ");

// int res = firstDigit * 10 + secondDigit;
// Console.WriteLine(res);

int RemoveSecondDigit(int num) // int num = number
{
    int firstDigit = num / 100;  
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}



// int maxDigit = MaxDigit(number);
Console.WriteLine("Удаляем вторую цифру");
Console.WriteLine($"Результат = {RemoveSecondDigit(number)}");