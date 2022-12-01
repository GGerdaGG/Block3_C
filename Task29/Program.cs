// ДЗ
// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = new int[8];

void RandomArray(int[] array1)
{
    Random rnd = new Random();
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = rnd.Next(0, 100); 
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

RandomArray(array);

// Console.WriteLine(string.Join(" ", array));
PrintArray(array);
