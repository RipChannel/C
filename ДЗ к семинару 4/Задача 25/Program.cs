/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. */
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int pow = 1;
for(int i = 1;i <= num2;i++)
{
 pow = num1 * pow;
}
Console.WriteLine($"Степень числа {num1}:= {pow}");