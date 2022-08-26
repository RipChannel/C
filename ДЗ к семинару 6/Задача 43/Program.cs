// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
double x = FindX(k1, b1, k2, b2);
double y = FindY(k1, b1, x);
Console.WriteLine($"Точка пересечения двух прямых:= {x}, {y}");

double FindX(int k1, int b1, int k2, int b2)
{
int k = k2 * (-1) + k1;
int b = b2 + b1 * (-1);
return b/k;
}
double FindY(int k1, int b1, double x)
{
    return k1 * x + b1;
}