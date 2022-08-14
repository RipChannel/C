// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday > 5 && weekday < 8)
{
 Console.WriteLine("Да");
}
if (weekday > 0 && weekday < 6)
{
 Console.WriteLine("Нет");
}
if (weekday > 7 || weekday < 1)
{
    Console.WriteLine("Неверное число");
}