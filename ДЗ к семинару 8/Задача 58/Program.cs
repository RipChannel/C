// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int min = 0;
int max = 10;
int[,] array1 = CreateArrayRndInt(min, max);
int[,] array2 = CreateArrayRndInt(min, max);
PrintArray(array1);
Console.WriteLine();

PrintArray(array2);
Console.WriteLine();

int[,] multArr = Multiplication(array1, array2);
PrintArray(multArr);

int[,] CreateArrayRndInt(int min, int max)
{
    int[,] array = new int [3, 3];
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
int[,] Multiplication(int[,] arr1, int[,] arr2)
{
    int[,] arr = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for(int i = 0; i < arr1.GetLength(0); i++)
    {
        for(int j = 0; j < arr2.GetLength(1); j++)
        {
            int sum = 0;
            for(int k = 0; k < arr1.GetLength(1); k++)
            {
              sum = sum + (arr1[i,k] * arr2[k,j]);
            }
            arr[i,j] = sum;
        }
    }
    return arr;
}