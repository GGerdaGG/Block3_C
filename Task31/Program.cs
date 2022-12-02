// Задача 31: 
// 1. Задайте массив из 12 элементов, 
// 2. заполненный случайными числами из промежутка [-9, 9]. 
// 3. Вывести массив в консоль
// 4. Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SumNegativeElemsArray(int[] arr)
{
    int sumNegative1 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNegative1 += arr[i];
    }
    return sumNegative1;
}

int SumPositiveElemsArray(int[] arr)
{
    int sumPositive1 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPositive1 += arr[i];
    }
    return sumPositive1;
}

int[] array = CreateArrayRndInt(12, -9, 9);

PrintArray(array);

int sumNegative = SumNegativeElemsArray(array);
int sumPositive = SumPositiveElemsArray(array);
Console.WriteLine($"Сумма положительных чисел = {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел = {sumNegative}");


// // Задача 31: 
// 1.Задайте массив из 12 элементов, 
// 2.заполненный  случайными числами из промежутка [-9, 9]. 
// 3.айдите сумму  отрицательных и положительных элементов массива.
// 4. Выввести массив в консоль
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// // положительных чисел равна 29, сумма отрицательных равна
// // -20.

//создание м ассива, заполняем массив числами из диапозона
int[] CreateArrayRandomInt (int size, int min, int max) //в скобках размер массива, диапозон числел мин и макс
{
    int [] array = new int [size]; //это мы создали сам массив с размером сайз, нью означает что мы выделяем память для этого массива
    Random rndm = new Random(); //это рандомные числа в массиве
    
    for(int index = 0; index < array.Length; index = index + 1) //счетчик хорошо подходит для передока индексов в массиве
    {
        array[index] = rndm.Next( min, max+1 );// массив с индексом = с учетом последнего индекса поэтому + 1
    }
    return array;
}

//метод который будет выводить в консоль, в нужной нам форме [ , , , ]
// тип войд означает что метод не возвращает никакое значение
void PrintArray (int [] arr) // тут пишем аргумент получения массива из предедущего метода
{
    Console.Write("[");//открывающая скобка для вывода
    for(int index = 0; index < arr.Length; index = index + 1)
    {
        if (index < arr.Length - 1) Console.Write($"{arr[index]}, ");//выводим все числа кроме последнего с запятой
        else Console.Write($"{arr[index]}");
    }
    Console.WriteLine("]");//закрывающая скобка для вывода
}

// Сумма отрицательных элементов

// int SumNegativeElemsArray(int[] arr)
// {
//     int sumNegative1 = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0) sumNegative1 += arr[i]; // или if (arr[i] < 0 ) sumNegative1 = sumNegative1 + arr[i];
//     }
//     return sumNegative1;
// }

// Сумма отрицательных элементов второй вариант
int GetSumNegativElem (int [] arr)
{
    int sum = default;
    for ( int index = 0; index < arr.Length; index = index + 1 )
    {
        if (arr[index] < 0 ) sum = sum + arr[index] ;// sumNegative += arr[index] можно так написать
    
    }
    return sum;
}

//Сумма положительных элементов 
// int SumPositiveElemsArray(int[] arr)
// {
//     int sumPositive1 = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sumPositive1 += arr[i];
//     }
//     return sumPositive1;
// }

//Сумма положительных элементов второй вариант
int GetSumPositiveElem (int [] arr)
{
    int sum = default;
    for ( int index = 0; index < arr.Length; index = index + 1 )
    {
        if (arr[index] > 0 ) sum = sum + arr[index] ;// sumNegative += arr[index] можно так написать
    
    }
    return sum;
}

int [] arrayFull = CreateArrayRandomInt(12, -9, 9);
PrintArray(arrayFull);

int sumNegative = GetSumNegativElem(arrayFull);
int sumPositive = GetSumPositiveElem(arrayFull);
Console.WriteLine ($"Сумма положительных чисел = {sumPositive}");
Console.WriteLine ($"Сумма отрицательных чисел = {sumNegative}");

// void PrintArray(int[] arr, string symb1, string symb2)
// {
//     Console.Write(symb1);
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1)
//             Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write(symb2);
// }


// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr, string symb1, string symb2)
// 9);
// PrintArray(array, "[", "]");

// int[] MultArray(int[] arr)
// {
//     int[] arr1 = arr.Length % 2 == 0 ? new int[arr.Length / 2] 
//                                     : new int[arr.Length / 2 + 1];
//     for (int i = 0; i < arr1.Length; i++)
//     {
//         arr1[i] = arr[i] * arr[arr.Length-i-1];
//     }
//     if (arr.Length % 2 == 1) arr1[arr1.Length-1] = arr[arr.Length/2];
//     return arr1;
// }

// int[] array2 = MultArray(array);
// PrintArray(array2, " -> ", "");

// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] arr = new double[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.NextDouble() * (max - min) + min;
//     }
//     return arr;
// }