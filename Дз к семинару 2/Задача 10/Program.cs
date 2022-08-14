// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int GetMiddleDiggit (int num)
{
    int middle = num % 100;
    middle = middle / 10;
    return middle;
}
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int res = GetMiddleDiggit (num);
Console.WriteLine($"Второе число {res}");