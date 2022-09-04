// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,,] array = BuildArray(x,y,z);
PrintArr(array);

int[,,] BuildArray(int x, int y, int z)
{
    int[,,] arr = new int[x,y,z];
    int rndMin = 0;
    int rndMax = 90;
    int[] rndNums = new int[rndMax];
    Random rnd = new Random();

    for(int i = 0; i < rndNums.Length; i++)
    {
        rndNums[i] = i + 10;
    }
    for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            for(int k = 0; k < z; k++)
            {
                int rndIndex = rnd.Next(rndMin, rndMax);
                if(rndNums[rndIndex] >= 10 && rndNums[rndIndex] < 100)
                {
                    arr[i,j,k] = rndNums[rndIndex];
                    rndNums[rndIndex] = 0;
                }
                else
                {
                    k--;
                }
            }
        }
    }
    return arr;
}

void PrintArr(int[,,] Array)
{
    for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            for(int k = 0; k < z; k++)
            {
                Console.WriteLine($"{Array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}