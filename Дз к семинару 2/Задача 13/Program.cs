// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.

int GetThirdDiggital (int num)
{
    while(num > 999)
    {
       num = num / 10;
    }
    int third = num % 10;
    return third;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
int res = GetThirdDiggital (num);
Console.WriteLine($"Третья цифра {res}");
}