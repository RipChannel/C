// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите строку");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец");
int n = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;
int[,] Array = CreateArrayRndInt(min, max);
PrintArray(Array);
Num(Array, m, n);
int[,] CreateArrayRndInt(int min, int max)
{
    int[,] array = new int [3, 4];
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
void Num(int[,] Arr, int m, int n)
{
    int row = 0;
    int col = 0;
    if(m < 4 && n < 5)
    {
    row = m - 1;
    col = n - 1;
    Console.WriteLine($"\nЧисло: {Arr[row,col]}");
    }
    else Console.WriteLine("\nНекорректное число");
}