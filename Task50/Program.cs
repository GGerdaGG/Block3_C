// ДЗ
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


//через if

// m = 3, n = 4.
//    0_ 1_ 2_ 3
// 0 |1  4  8  19
// 1 |5  -2 33 -2
// 2 |77 3  8  1

Console.Write("Задайте число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число m: ");
int m = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max) // метод создания двумерного массива
{
    int[,] matrix = new int[rows, columns];// rows -строки, columns -столбцы
    Random rndm = new Random();

    for (int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = rndm.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix) // Вывод в консоль двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, "); //4 после запятой это для красивого форматирования
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}


bool FindElement(int[,] matrix)
{
   if (n >= matrix.GetLength(0) || m >= matrix.GetLength(1) || n < 0 || m < 0)
   return false;
   return true;
}

int[,] array2D = CreateMatrixRandomInt(3, 4, -10, 10);
PrintMatrix(array2D);
bool findElement = FindElement(array2D);
Console.WriteLine(FindElement(array2D) ? $"Значение этого элемента: {array2D[n,m]} " : "Такого элемента в массиве нет");

