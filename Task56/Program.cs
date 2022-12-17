// ДЗ
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max) // метод создания двумерного массива
{
    int[,] matrix = new int[rows, columns];
    Random rndm = new Random();

    for (int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //GetLength(0) возвращает количество строк в вашем массиве. Имя массива.GetLength(1) - количество столбцов. 
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, "); //4 после запятой это для красивого форматирования Эта строчка о запятой
            else Console.Write($"{matrix[i, j],4} "); //Последняя строчка без запятой
        }
        Console.WriteLine("|");
    }
}

double[] ArithmeticRows(int[,] matrix) // находит сумму строк отдельно, чтобы вывести их
{
    double[] arr = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < matrix.GetLength(1); j = j + 1)
        {
            arr[i] = arr[i] + matrix[i, j];
        }
    }
    return arr;
}

double ArithmeticRowsMin(int[,] matrix) //находит сумму строк и минимальную из них
{
    double[] arr = new double[matrix.GetLength(1)];
    double rowMin = 0;
    double sumMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumMin = sumMin + matrix[i, j];
        }
    }
    for (int m = 0; m < matrix.GetLength(0); m = m + 1)
    {
        for (int n = 0; n < matrix.GetLength(1); n = n + 1)
        {
            arr[m] = arr[m] + matrix[m, n];
        }
        if (arr[m] < sumMin)
        {
            sumMin = arr[m];
            rowMin = m;
        }
    }
    return rowMin;
}

void PrintArithmeticRows(double[] matrix) //выводит сумму строк
{
    for (int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        Console.Write($"{matrix[i],3}({i}) ");
    }
}

int[,] arrayRandom = CreateMatrixRandomInt(3, 3, 1, 9);
PrintMatrix(arrayRandom);
Console.WriteLine();
Console.Write("Cумма элементов по строкам =");
double[] arithmeticRows = ArithmeticRows(arrayRandom);
PrintArithmeticRows(arithmeticRows);
Console.WriteLine();
double arithmeticRowsMin = ArithmeticRowsMin(arrayRandom);
Console.WriteLine();
Console.WriteLine($"Номер строки с меньшей суммой = {arithmeticRowsMin}");






// еще пыталась так решить, но у меня не вышло, удалять жалко

// ДЗ
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max) // метод создания двумерного массива
// {
//     int[,] matrix = new int[rows, columns];// rows -строки columns -столбцы
//     Random rndm = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i = i + 1)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) //GetLength(0) возвращает количество строк в вашем массиве. Имя массива.GetLength(1) - количество столбцов. 
//         {
//             matrix[i, j] = rndm.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix) // Вывод в консоль двумерного массива
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, "); //4 после запятой это для красивого форматирования Эта строчка о запятой
//             else Console.Write($"{matrix[i, j],4} "); //Последняя строчка без запятой
//         }
//         Console.WriteLine("|");
//     }
// }

// double[] ArithmeticColumns(int[,] matrix)
// {
//     double[] arr = new double[matrix.GetLength(1)];

//     for (int i = 0; i < matrix.GetLength(0); i = i + 1)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j = j + 1)
//         {
//             arr[i] = arr[i] + matrix[i, j];
//         }
//     }
//     return arr;
// }

// void PrintArithmeticColumns(double[] matrix)
// {
//     Console.Write("|");
//     for (int i = 0; i < matrix.GetLength(0); i = i + 1)
//     {
//         Console.Write($"{matrix[i],5} ");
//     }
//     Console.Write("|");
// }

// void PrintArithmeticColumns2(double[] matrix)
// {
//     Console.Write("|");
//     for (int i = 0; i < matrix.GetLength(0) - 1; i = i + 1)
//     {
//         int sum = 0;
//         if (matrix[i] < matrix[i + 1] + sum)
//         Console.Write($"{i} ");
//     }
//     Console.Write("|");
// }

// int[,] arrayRandom = CreateMatrixRandomInt(4, 4, 1, 9);
// PrintMatrix(arrayRandom);
// Console.WriteLine();
// double[] arithmeticColumns = ArithmeticColumns(arrayRandom);
// PrintArithmeticColumns(arithmeticColumns);
// Console.Write("= сумма элементов по строкам");
// Console.WriteLine();
// double[] arithmeticColumns2 = ArithmeticColumns(arrayRandom);
// PrintArithmeticColumns2(arithmeticColumns);
// Console.Write("= номер строки с меньшей суммой");


