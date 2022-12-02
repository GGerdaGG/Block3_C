// ДЗ
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max-min) + min,1);
    }
    return arr;
}
// Math.Round
void PrintArray(double[] arr)
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

double[] array = CreateArrayRndInt(4, -100, 100);
PrintArray(array);

// 1. Найти минимум
// 2. Найти максимум
// 3. Разница

double MinDigit(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)  min = arr[i];
    }    
    return min;
}

double MaxDigit(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)  max = arr[i];
    }    
    return max;
}

double minDigit = MinDigit(array);
double maxDigit = MaxDigit(array);
Console.WriteLine($"Минимальное и максимальное число: {minDigit}, {maxDigit}");
Console.WriteLine($"Разница между ними  = {maxDigit - minDigit}");


//С целыми числами

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max+1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1)
//             Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }

// int[] array = CreateArrayRndInt(4, 1, 9);
// PrintArray(array);

// int MinDigit(int[] arr)
// {
//     int min = arr[0];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < min)  min = arr[i];
//     }    
//     return min;
// }

// int MaxDigit(int[] arr)
// {
//     int max = arr[0];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > max)  max = arr[i];
//     }    
//     return max;
// }

// int minDigit = MinDigit(array);
// int maxDigit = MaxDigit(array);
// Console.WriteLine($"Минимальное и максимальное число: {minDigit}, {maxDigit}");
// Console.WriteLine($"Разница между ними  = {maxDigit - minDigit}");

