// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


int[,] CreateMatrixRandomInt (int rows, int columns, int min, int max)
{
    int [,] matrix = new int [rows, columns];
    Random rndm = new Random();
    
    for(int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix[i,j] = rndm.Next( min, max+1 );
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) -1) 
            Console.Write($"{matrix[i,j], 4}| ");
            else Console.Write($"{matrix[i,j], 4}");
        }
    Console.WriteLine("|");
    }
}

void ChangeFirstLastRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = default;
        int first = default;
        int last = matrix.GetLength(0) - 1;
        temp = matrix[first, i];
        matrix[first, i] = matrix[last, i];
        matrix[last, i] = temp;
    }
}

int [,] array2D = CreateMatrixRandomInt(5,5,1,9);
PrintMatrix(array2D);
Console.WriteLine();
ChangeFirstLastRows(array2D);
PrintMatrix(array2D);


