//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int num1 = num;
 while (num > 0)
{
        sum = num % 10 + sum;
        num = num / 10;
}
Console.WriteLine($"Сумма цифр числа {num1}:= {sum}");