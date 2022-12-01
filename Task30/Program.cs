// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] array = new int[8];

void RandomArray (int[] arrayA) // создание массива
{
    Random rnd = new Random(); // переменная генерирует рандомные числа
    for (int i =0; i < arrayA.Length; i++) // счетчик наполнения массива 
    {
        arrayA[i] = rnd.Next(0, 2); // генерация чисел, 2 потому что оно не включается в диапозон, поэтому до единицы
    }
}

void PrintArray (int[] arrayB) // этот метод выводит на печать 
{
    for (int i =0; i < arrayB.Length; i++) // счетчик вывода
    {
        Console.Write($" {arrayB[i]} "); // вывод
    }
}

RandomArray(array);
PrintArray(array);


// int n = 8; // длинна массива
// int [] array = new int [8];
// int[] arr = new int[n];
// Random rnd = new Random();

// int [] array = new int [8]; // так создаем массив с количеством 8 элементов. Вместо 8 size
// int [] arrayA = {3, 5, 7, 8, 6, 4}; // создание массива с цифрами
// int [] arrayB = new int [8] {4,5,6,7,8,9,6,4}; // создаем массив с известными эллементами

// array[0] = 34;
// array[1] = 36;
// array[2] = 74;
 

// Random rnd = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next();
// }