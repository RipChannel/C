//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите длину массива");
int size1 = Convert.ToInt32(Console.ReadLine());

int[] result = CreateArray(size1, 100, 1000);
PrintArray(result);
Result(result);
int[] CreateArray(int size, int min, int max) // Создаем массив
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}
void Result(int[] array) // Считаем колличество четных чисел в массиве
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            sum = sum + 1;
        }
    }
    Console.WriteLine($"Колличество четных чисел в массиве:= {sum}");
}
void PrintArray(int[] numbers) // Выводим массив на экран
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}