// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

//Чтобы найти нужно разделить 45 на 2 и записать остаток, потом снова на два и так пока 45 не превратиться в 0. 
//Простой способ это через строку, потом рекурсия или сложнее через цифры

// string Binary (int number)
// {
//     string bin = string.Empty;
//     while (number > 0)
// {
//     bin = number % 2 +bin;
//     number /= 2;
// }
// return bin;
// }

// Console.Write("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Число {numberA} в двоичном представлении = {Binary(numberA)}");



// int [] Binary (int number)
// {
//     int num1 = number ;
//     int digits = 0;
//     while(num1 > 0)
//     {
//         num1 /= 2 ;
//     digits +=1;
//     }
//     int [] bin = new int[digits];
//    for (int i = 0; i < bin.Length; i++)
//    {
//      bin[i] = number % 2;
//     number /=2;
//    }
//    Array.Reverse(bin);
// return bin;
// }

// void PrintArray(int[] arr, string symb1, string symb2)
// {
//     Console.Write(symb1);
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1)
//             Console.Write($"{arr[i]}");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write(symb2);
// }


// Console.Write("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// int[] binary = Binary(numberA);
// Console.Write($"Число {numberA} в двоичном представлении = ");
// PrintArray( binary,"","");

