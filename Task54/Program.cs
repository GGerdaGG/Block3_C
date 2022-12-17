// ДЗ
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max) // метод создания двумерного массива
{
    int[,] matrix = new int[rows, columns];// rows -строки(вертикаль) columns -столбцы(горизонталь)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} "); //4 после запятой это для красивого форматирования
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] RowOrder(int[,] matrix)
{
    for (int a = 0; a < matrix.GetLength(0); a++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int temp = matrix[i, j + 1]; //меняем местами
                    matrix[i, j + 1] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }
    }
    return matrix;
}

int[,] array2D = CreateMatrixRandomInt(4, 4, 1, 99);
PrintMatrix(array2D);

RowOrder(array2D);
Console.WriteLine();
int[,] rowOrder = RowOrder(array2D);
PrintMatrix(array2D);