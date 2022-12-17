// ДЗ
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max) // метод создания двумерного массива
{
    int[,] matrix = new int[rows, columns];
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrMultiplication = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int rows1 = matrix1.GetLength(0);
    int rows2 = matrix2.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int columns2 = matrix2.GetLength(1);
    if (columns1 == rows2)
    {
        for (int a = 0; a < rows1; a++)
        {
            for (int i = 0; i < columns2; i++)
            {
                for (int j = 0; j < rows2; j++)
                {
                    matrMultiplication[a, i] = matrMultiplication[a, i] + matrix1[a, j] * matrix2[j, i];
                }
            }
        }
    }
    else Console.WriteLine("невозможно");
    return matrMultiplication;
}

int[,] randonArray = CreateMatrixRandomInt(3, 2, 1, 9);
int[,] randonArray2 = CreateMatrixRandomInt(2, 3, 1, 9);
Console.WriteLine("Первая матрица:");
PrintMatrix(randonArray);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintMatrix(randonArray2);
Console.WriteLine();
Console.WriteLine("Умножение матриц");
int[,] matrixMultiplication = MatrixMultiplication(randonArray, randonArray2);
PrintMatrix(matrixMultiplication);


// matrMultiplication[i, j + 1] = matrix1[i, j] * matrix2[i, j + 1] + matrix1[i, j + 1] * matrix2[i + 1, j + 1];
// matrMultiplication[0, 1] = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1];
// c 12 ​= a 11 ​⋅ b 12 ​+ a 12​⋅b 22 