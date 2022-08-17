// Задача 19.  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int rev = 0;
int rem = 0;
int initNum = num;
if (num < 10000 || num > 99999)
{
    System.Console.WriteLine("Некорректное число");
}
else
{
    while (num > 0)
    {
        rem = num % 10;
        num = num / 10;
        rev = rev * 10 + rem;
    }
    if (initNum == rev)
    {
        Console.Write("Является палиндромом");
    }
    else
    {
        Console.WriteLine("Не является палиндромом");
    }
}