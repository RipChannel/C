// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

Console.WriteLine("Введите длину массива");
int size1 = Convert.ToInt32(Console.ReadLine());

double[] result = CreateArray(size1);
PrintArray(result);
Result(result);
double[] CreateArray(int size)  //Создаем массив с выводом в консоль
{
    double[] array = new double[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*100;
    }
    return array;
}
void Result(double[] array) //Ищем минимальный и максимальный элемент массива и выводим ответ в консоль
{
    double max = array[0];
    double min = array[1];
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
    Console.WriteLine($"Максимальное число:= {Math.Round(max, 3)}");
    Console.WriteLine($"Минимальное число:= {Math.Round(min, 3)}");
    sum = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным значением:= {Math.Round(sum, 3)}");
}
void PrintArray(double[] numbers) // Выводим массив в консоль
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}