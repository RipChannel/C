// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int min = -100;
int max = 100;
int[,] Array = CreateArrayRndInt(min, max);
PrintArray(Array);
ComArray(Array);
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
void ComArray(int[,] Arr)
{
    Console.WriteLine();
    for(int j = 0; j < Arr.GetLength(1); j++)
    {
        double com = 0;
        for(int i = 0; i < Arr.GetLength(0); i++)
        {
            com = Arr[i,j] + com;
        }
        com = com / 3;
        Console.WriteLine($"Среднее арифметическое столбца {j}:= {Math.Round(com, 1)}");
    }
}