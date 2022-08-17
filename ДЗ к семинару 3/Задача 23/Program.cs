// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1)
{
    Console.WriteLine("Некорректное число");
}
else
{
    for (int i = 1; i <= n; i++)
    {
        int res = i * i * i;
        Console.WriteLine($"{i} | {res}");
    }
}