// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int min = 0;
int max = 100;
int[,] Array = CreateArrayRndInt(min, max);
Console.WriteLine();
PrintArray(Array);
Console.WriteLine();
Minsum(Array);
int[,] CreateArrayRndInt(int min, int max)
{
    int[,] array = new int [5, 3];
    Random rnd = new Random();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int[,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if(j < Array.GetLength(1) - 1) Console.Write($"{Array[i,j]},");
            else Console.Write(Array[i,j]);
        }
        Console.WriteLine("]");
    }
}
void Minsum(int[,] array)
{
    int k = 1;
    int minsum = int.MaxValue;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if(i == 0)
        {
            minsum = sum;
        }
        if(sum < minsum)
        {
            minsum = sum;
            k = i + 1;
        }
    }
    System.Console.WriteLine($"Строка с наиманьшей суммой элементов:= {k}");
}