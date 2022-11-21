// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 
// 78 -> 8 
// 12-> 2 
// 85 -> 8



int number = new Random().Next(10, 100); //функция для получения случайного числа, 10 минимальное значение, 100 максимальное. Если пусто, то в рамках int
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}"); //показываем пользователю какое случайное число вышло
int firstDigit = number / 10; // 78 / 10 = 7 
int secondDigit = number % 10; // 78 % 10 = 8
if (firstDigit == secondDigit) Console.WriteLine($"Цифры одинаковые");
else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");

// Другой вариант: 
// int res = Math.Max(firstDigit, secondDigit); // функция для выяснения наибольшего числа
// Console.WriteLine($"Наибольшая цифра числа = {res}");


// int MaxDigit(int num) // в скобках исходные данные
// {
//     int firstDigit = num / 10; // 78 / 10 = 7
//     int secondDigit = num % 10; // 78 % 10 = 8

//     // int result = default;

//     //  if (firstDigit > secondDigit) result = firstDigit;
//     //  else result = secondDigit;

//     return firstDigit > secondDigit ? firstDigit : secondDigit;
// }

// void PrintLine (string word)
// {
//     Console.WriteLine(word);
// }

// int maxDigit = MaxDigit(number);
// Console.WriteLine($"Наибольшая цифра числа = {maxDigit}");

// PrintLine("Привет!");







----
// int maxDigit1 = MaxDigit(56);
// Console.WriteLine($"Наибольшая цифра числа {56} равна {maxDigit1}");
// int maxDigit2 = MaxDigit(67);
// Console.WriteLine($"Наибольшая цифра числа {67} равна {maxDigit2}");
// int maxDigit3 = MaxDigit(99);
// Console.WriteLine($"Наибольшая цифра числа {99} равна {maxDigit3}");
// int maxDigit4 = MaxDigit(33);
// Console.WriteLine($"Наибольшая цифра числа {33} равна {maxDigit4}");

// int firstDigit = number / 10; // 78 / 10 = 7
// int secondDigit = number % 10; // 78 % 10 = 8

// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа равна {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа равна {secondDigit}");

// Условный оператор
// int result = default;
// if (firstDigit > secondDigit) result = firstDigit;
// else result = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа равна {result}");
// // Тернарный оператор 1
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");
// // Тернарный оператор 2
// Console.Write($"Наибольшая цифра числа {number} равна ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);


// int MaxDigit(int num)
// {
//     int firstDigit = num / 10; // 78 / 10 = 7
//     int secondDigit = num % 10; // 78 % 10 = 8
//     return firstDigit > secondDigit ? firstDigit : secondDigit;
// }

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int maxDigit = MaxDigit(number);
// Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");



// ТАК НЕЛЬЗЯ!!!
// string str = "32679644";
// System.Console.WriteLine(str[2]);