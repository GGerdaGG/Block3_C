// ДЗ
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

//1. Пользователь вводит числа - метод, через цикл, сначала он вводит число м (общее количество чисел),
//потом создаем массив из м элементов и вводим каждое число
//2. Считаем количество чисел больше нуля - метод

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

// 1. Создаем массив со своими переменными
int[] CreateArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите число {i}: ");
        arr [i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

// 2. Считаем количество чисел больше нуля
int PositiveNumbers (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)  sum=sum+1;
    }    
    return sum;
}

//Правильно ли я разместила все эти строчки внизу? Их нельзя размещать посередине, я правильно поняла?
int[] array = CreateArray(numberM);
PrintArray(array);
int positiveNumbers = PositiveNumbers(array);
Console.WriteLine($"Количество чисел больше нуля: {positiveNumbers}");


















// int[] array = new int[8];

// void RandomArray (int[] arrayA) // создание массива
// {
//     Random rnd = new Random(); // переменная генерирует рандомные числа
//     for (int i =0; i < arrayA.Length; i++) // счетчик наполнения массива 
//     {
//         arrayA[i] = rnd.Next(0, 2); // генерация чисел, 2 потому что оно не включается в диапозон, поэтому до единицы
//     }
// }

// void PrintArray (int[] arrayB) // этот метод выводит на печать 
// {
//     for (int i =0; i < arrayB.Length; i++) // счетчик вывода
//     {
//         Console.Write($" {arrayB[i]} "); // вывод
//     }
// }

// RandomArray(array);
// PrintArray(array);


// int n = 8; // длинна массива
// int [] array = new int [8];
// int[] arr = new int[n];
// Random rnd = new Random();

// int [] array = new int [8]; // так создаем массив с количеством 8 элементов. Вместо 8 size
// int [] arrayA = {3, 5, 7, 8, 6, 4}; // создание массива с цифрами
// int [] arrayB = new int [8] {4,5,6,7,8,9,6,4}; // создаем массив с известными эллементами

// array[0] = 34;
// array[1] = 36;
// array[2] = 74;
 

// Random rnd = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next();
// }

