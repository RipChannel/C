// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int min = -100;
int max = 100;
int[,] Array = CreateArrayRndInt(min, max);
PrintArray(Array);
Console.WriteLine();
Sort(Array);
PrintArray(Array);
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
void Sort(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = 0;
            int indexofmax = j;
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i,indexofmax] < array[i,k])
                {
                    indexofmax = k;
                }
            }
            temp = array[i,indexofmax];
            array[i,indexofmax] = array[i,j];
            array[i,j] = temp;
        }
    }
}