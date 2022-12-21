// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.


Console.Write("Введите число M: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(firstNum, secondNum);

void NaturalNumbers(int num1, int num2) 
{
    if (num1 > num2) 
    {
        Console.Write(num2);
        NaturalNumbers(num1, num2 + 1);
    }
    if(num1 < num2) 
    {
        Console.Write(num1);
        NaturalNumbers(num1 + 1, num2);
    
    }
    if(num1 == num2)
        Console.Write(num1);
}
