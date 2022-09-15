// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size) 
{
    int[] array = new int[size]; 
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

void PrintArray(int[] array) 
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

int Sum(int[] array) 
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];        
    }
    return sum;
}

try
{
    Console.WriteLine("Enter the array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = FillArray(size);
    PrintArray(array);
    int sum = Sum(array);
    Console.WriteLine($"Sum of odd array elements = {sum}");
} catch
{
    Console.WriteLine("It`s not an int number!");
}

