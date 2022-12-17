// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// Array.Sort(массив одномерный) - сортирует одномерный массив по порядку

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
// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }


void CountValue(int[]arr)
{
        int count = 1;
        int num = arr[0];
    for (int i = 1; i <arr.Length; i++)
    {
        if (arr[i] == num )count++;
        else
        {
            PrintMessage(num,count);
            count = 1;
            num = arr[i];       
        }
    }
 PrintMessage(num,count);
}

void PrintMessage(int num, int count)
{
    Console.WriteLine($"Число {num} встречается {count} раз.");
}

int [,] array2D = CreateMatrixRandomInt(5,5,1,9);
PrintMatrix(array2D);
Console.WriteLine();
int [] array = MatrixToArray(array2D);
Array.Sort(array);
// PrintArray(array);
// Console.WriteLine();
CountValue(array);

// Второе решение (Алексей)

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//             // TODO: вывести индексы массива.
//             // matrix[i, j] = i * 10 + j;
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix, string beginRow, string separatorElems, string endRow)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write(beginRow);
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1)
//                 Console.Write($"{matrix[i, j],4}{separatorElems}");
//             else Console.Write($"{matrix[i, j],4}");
//         }
//         Console.WriteLine(endRow);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//        Console.Write($"{array[i]} ");
//     }
// }


// int[] MatrixToArray(int[,] matrix)
// { 
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(0);
//     int[] array = new int[matrix.Length];
//     int index = 0;
//     for (int i = 0; i < rows; i++)
//     { 
//         for (int j = 0; j < columns; j++)
//         {
//             array[index] = matrix[i,j];
//             index++;
//         }
//     }
//     return array;
// }

// int[,] RequencyElemsArray(int[] array)
// {
//     int size = 0;
//     int temp = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] != temp)
//         {
//             size++;
//             temp = array[i];
//         }
//     }
//     int[,] matrix = new int[size,2];
//     int index=-1;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] != temp)
//         {
//             index++;
//             temp = array[i];
//             matrix[index,0] = array[i];
//         }
//         if (array[i] == temp)
//         matrix[index,1]++;
//     }
//     return matrix;
// }

// void PrintMatrixSpecial(int[,] matrix, string beginRow, string firstRow, string secondRow, string endRow)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write(beginRow);
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j==0)
//             Console.Write($"{matrix[i, j],4}{firstRow}");
//             else if (j==1)
//             Console.Write($"{matrix[i, j],4}{secondRow}");
//             else Console.Write($"{matrix[i, j],4}");
//         }
//         Console.WriteLine(endRow);
//     }
// }

// int[,] matrix1 = CreateMatrixRndInt(4,4,1,9);
// PrintMatrix(matrix1, "","","");
// Console.WriteLine();
// int[] array1 = MatrixToArray(matrix1);
// Array.Sort(array1);
// PrintArray(array1);
// Console.WriteLine();
// int[,] requencyElemsArray = RequencyElemsArray(array1);
// PrintMatrixSpecial(requencyElemsArray,"Число "," повторяется", " раз", "");
