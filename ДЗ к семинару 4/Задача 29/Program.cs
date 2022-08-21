// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] result = CreateArray(8, 0, 100);
PrintArr(result);
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}
void PrintArr(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i]);
      if(i < array.Length - 1)
      {
        Console.Write(", ");
      }
    }
    Console.Write("]");
}