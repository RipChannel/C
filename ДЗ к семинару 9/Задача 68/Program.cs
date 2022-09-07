// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if(m == 4 && n > 0 || m > 4) Console.WriteLine("Некорректные данные");
else Console.WriteLine($"{Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return Akkerman(m - 1, 1);
    if(m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return n + 1;
}