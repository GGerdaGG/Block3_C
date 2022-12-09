// ДЗ
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] CreateMatrixRandomInt(int rows, int columns, double min, double max) // метод создания двумерного массива
{
    double[,] matrix = new double[rows, columns];
    Random rndm = new Random();

    for (int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //единица в скобках если матрица не квадратная? Или это двумерный массив когда?
        {
            matrix[i, j] = Math.Round(rndm.NextDouble() * (max-min) + min,1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],6}, ");
            else Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine("|");
    }
}

double[,] array2D = CreateMatrixRandomInt(3, 4, -10.4, 10.4);
PrintMatrix(array2D);

