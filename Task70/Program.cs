//черновик 70

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

int[] MatrixToArray(int[,] matrix)
{
    int [] arr = new int [matrix.Length];
    int k = 0;
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k++] = matrix[i,j];
        }
    }
    return arr;
}

int[,] array2D = CreateMatrixRandomInt(3, 4, 1, 9);
PrintMatrix(array2D);
int [] array = MatrixToArray(array2D);
Array.Sort(array);
PrintMatrix(array2D);

string[,] matrix = new string[2, 2];

matrix[0, 0] = "Паша";
matrix[0, 1] = "Коля";
matrix[1, 0] = "Дима";
matrix[1, 1] = "Миша";


// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]}, ");
//     }
//     Console.WriteLine();
// }

// for (int i = 0; i <2; i++)
// {
//     for (int j = 0; j < 2; j++)
//     {
//         Console.Write($"{matrix[i,j]}, ");
//     }
//     Console.WriteLine();
// }

void Print(string[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine();
    }
}
Print(matrix);