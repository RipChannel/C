// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите минимальное число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число");
int n = Convert.ToInt32(Console.ReadLine());
if(m <= n)
{
   int sum = NaturalNumber(m, n);
   Console.WriteLine($"Сумма от {m} до {n}:= {sum}");

   int NaturalNumber(int m, int n)
   {
       if(m == n) return m;
       return m + NaturalNumber(m + 1, n);
   }
}
   else Console.WriteLine("Некорректные данные");