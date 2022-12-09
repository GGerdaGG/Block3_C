// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
//    0_ 1_ 2_ 3
// 0 |1  4  8  19
// 1 |5  -2 33 -2
// 2 |77 3  8  1

int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max) // метод создания двумерного массива
{
    int[,] matrix = new int[rows, columns];// rows -строки(вертикаль) columns -столбцы(горизонталь)
    Random rndm = new Random();

    for (int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //единица в скобках если матрица не квадратная? Или это двумерный массив когда?
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

int[,] array2D = CreateMatrixRandomInt(10, 4, -50, 50); // тут указываем строки и столбцы ( и числа от кокого до какого будет рандом брать )
PrintMatrix(array2D);
