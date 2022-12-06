// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int [] CopyArray ( int[] arr)
{
    int [] copyArray = new int [arr.Length]; 
    for (int i = 0; i <arr.Length; i++)
    {  
        copyArray[i] = arr[i];
    }
    return copyArray;
}

int[] CreateArrayRandomInt (int size, int min, int max)
{
    int [] array = new int [size];
    Random rndm = new Random();
    
    for(int index = 0; index < array.Length; index = index + 1)
    {
        array[index] = rndm.Next( min, max+1 );
    }
    return array;
}

void PrintArray(int[] arr, string symb1, string symb2)
{
    Console.Write(symb1);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(symb2);
}

int [] arrayCreate = CreateArrayRandomInt(10, 0, 50);
PrintArray(arrayCreate, "Оригинальный массив[", "]");
int [] copyArray = CopyArray(arrayCreate);
PrintArray(copyArray, "\nКопия массива[", "]");
