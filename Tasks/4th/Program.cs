// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс,
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение , возможно придется кое-что для этого дополнительно выполнить.

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

double[] Elements(int[] array)
{
    double[] elements = new double[5];
    double max = array[0];
    double min = array[0];
    double maxInd = 0;
    double minInd = 0;
    double sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        sum += array[i];
        if(max < array[i])
        {
            max = array[i];
            maxInd = i;
        }
        if(min > array[i])
        {
            min = array[i];
            minInd = i;
        }
        
    }
    double average = sum / array.Length;
    elements[0] = maxInd;
    elements[1] = max;
    elements[2] = minInd;
    elements[3] = min;
    elements[4] = average;

    return elements;
}

int[] SortArray(int[] array)
{
    int tmp = 0;
    for(int i = 0; i < array.Length - 1; i++)
    {
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[i] > array[j])
            {
                tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
            }
        }
    }
    return array;
}

double Mediana(int[] array)                //число, которое находится в середине этого набора, если его упорядочить по возрастанию, 
{                                       //то есть такое число, что половина из элементов набора не меньше него, а другая половина не больше. 
    double med = 0;
    int medInd = 0;
    int max = array[0];
    if(array.Length % 2 == 0)           //Если в выборке чётное число элементов, медиана может быть не определена однозначно: 
    {                                   //тогда для числовых данных чаще всего используют полусумму двух соседних значений 
        medInd = array.Length / 2 - 1;
        med = 1.0 * (array[medInd] + array[medInd + 1]) / 2;
    } 
    else
    {
        medInd = array.Length / 2;
        med = array[medInd];   
    }
    
    return med;
}

try
{
    Console.WriteLine("Enter size of array!");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = FillArray(size);
    PrintArray(array);
    double[] elements = Elements(array);
    Console.WriteLine($"Индекс максимального элемента массива равен {elements[0]}, его значение равно {elements[1]}");
    Console.WriteLine($"Индекс минимального элемента равен {elements[2]}, его значение равно {elements[3]}");
    Console.WriteLine($"Среднее арифметическое всех элементов массива равно {elements[4]}");
    int[] sortArray = SortArray(array);
    Console.Write("Отсортированный массив: ");
    PrintArray(sortArray);
    double mediana = Mediana(sortArray);
    Console.WriteLine("Медиана массива равна " + mediana);
} catch
{
    Console.WriteLine("It`s not a int number!!!");
}

