// ДЗ
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max) // метод создания двумерного массива
{
    int[,] matrix = new int[rows, columns];// rows -строки(вертикаль) columns -столбцы(горизонталь)
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

double[] ArithmeticColumns(int[,] matrix) 
{
    double[] arr = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j = j + 1)
    {
        for (int i = 0; i < matrix.GetLength(0); i = i + 1)
        {
            arr[j] = arr[j] + matrix[i,j];
        }
        arr[j] = Math.Round (arr[j]/matrix.GetLength(0),1);
    }
    return arr;
}

void PrintArithmeticColumns(double[] matrix) 
{
        Console.Write("|");
        for (int i = 0; i < matrix.GetLength(0); i = i + 1)
        {
            Console.Write($"{matrix[i],5} ");
        }
        Console.Write("|");
}

int[,] arrayRandom = CreateMatrixRandomInt(3, 4, -9, 9);
PrintMatrix(arrayRandom);
Console.WriteLine();
double [] arithmeticColumns = ArithmeticColumns(arrayRandom);
PrintArithmeticColumns(arithmeticColumns);
Console.Write("= среднее арифметическое столбцов");

