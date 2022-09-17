// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] FillArray(int size) 
{
    double[] array = new double[size]; 
    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round( new Random().NextDouble(), 4);
    }
    return array;
}

void PrintArray(double[] array) 
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i != array.Length - 1) 
        {
            Console.Write($"{array[i]}, ");
        } else
        {
            Console.WriteLine(array[i]);
        }
    }
}

double Difference(double[] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(max < array[i]) 
        {
            max = array[i];
        }
        if(min > array[i]) 
        {
            min = array[i];
        }
    }
    return diff = max - min;
}

try
{
    Console.WriteLine("Enter array size ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = FillArray(size);
    PrintArray(array);
    double difference = Math.Round(Difference(array), 4);
    Console.WriteLine($"Difference between maximum and minimum array elements is {difference}");
} catch
{
    Console.WriteLine("It`s not a number!");
}