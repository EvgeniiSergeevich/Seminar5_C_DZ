// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size) 
{
    int[] array = new int[size]; 
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int isEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

try
{
    Console.WriteLine("Enter the array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = FillArray(size);
    PrintArray(array);
    int count = isEven(array);
    Console.WriteLine($"Even numbers {count}.");
}
catch
{
    Console.WriteLine("It`s not an int number!");
}
