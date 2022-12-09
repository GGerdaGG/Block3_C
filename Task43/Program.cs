// ДЗ
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) (x;y)

Console.Write("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double DotX (double ab1, double ak1, double ab2, double ak2)
{
    double x = 0;
    x = (ab2-ab1)/(ak1-ak2);
    return x;
}

double DotY (double ab1, double ak1, double ab2, double ak2)
{
    double y = 0;
    y = ak1 * ((ab2-ab1)/(ak1-ak2)) + ab1;
    return y;
}

double dotX = DotX (b1, k1, b2, k2);
double dotY = DotY (b1, k1, b2, k2);
Console.Write($"Точка пересечения: ({Math.Round(dotX,2)},{Math.Round(dotY,2)})");