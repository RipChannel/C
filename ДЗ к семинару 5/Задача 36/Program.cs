// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).

Console.WriteLine("Введите длину массива");
int size1 = Convert.ToInt32(Console.ReadLine());

int[] result = CreateArray(size1, -100, 100);
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
void Result(int[] array) // Считаем сумму нечетных индексов
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 > 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine($"Сумма элементов массива на нечетных позициях:= {sum}");
}
void PrintArray(int[] numbers) // Выводим массив в консоль
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}