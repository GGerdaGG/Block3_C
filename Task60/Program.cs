// ДЗ
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRandomInt(int rows, int columns, int depth, int min, int max) // метод создания трехмерного массива
{
    int[,,] matrix = new int[rows, columns, depth]; // rows -строки(вертикаль) columns -столбцы(горизонталь) -глубина
    Random rndm = new Random();

    for (int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++) //добавляем третий счетчик
            {
                matrix[i, j, k] = rndm.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix) // Вывод в консоль двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) "); 
            }
        }
        Console.WriteLine();
    }
}

int[,,] array2D = CreateMatrixRandomInt(2, 2, 2, 10, 99);
PrintMatrix(array2D);

