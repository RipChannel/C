// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите положительное число");
int n = Convert.ToInt32(Console.ReadLine());
NaturalNumber(n);

void NaturalNumber(int num)
{
    if(num == 0) return;
    Console.Write($"{num} ");
    NaturalNumber(num - 1);
}