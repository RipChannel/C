//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите колличество строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов");
int col = Convert.ToInt32(Console.ReadLine());
int min = -9;
int max = 9;
double[,] Array = CreateArrayRndDbl(row, col, min, max);
PrintArray(Array);
double[,] CreateArrayRndDbl(int row, int col, int min, int max)
{
    double[,] array = new double[row, col];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        int RndNum = rnd.Next(min, max + 1);
        if(RndNum < 0)
            {
            array[i, j] = RndNum - rnd.NextDouble();
            }
            else
            {
            array[i, j] = rnd.NextDouble() + RndNum;
            }
       }
    }
    return array;
}

void PrintArray(double[,] Arr)
{
     for(int i = 0; i < Arr.GetLength(0); i++)
     {
        Console.Write("[");
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            if(j < Arr.GetLength(1) - 1) Console.Write($"{Math.Round(Arr[i,j], 1)}, ");
            else Console.Write(Math.Round(Arr[i,j], 1));
        }
        Console.WriteLine("]");
     }
}