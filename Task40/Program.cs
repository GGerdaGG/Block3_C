// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
// 2 -> 10

bool Triagnle( int a, int b, int c) //бул если можно ответить только да или нет
{
    return a < b + c && b < a + c && c < a + b;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Triagnle(numberA,numberB,numberC)?"Треугольник может существовать" : "Треугольник не может существовать");



