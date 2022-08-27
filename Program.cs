//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] NewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 5 + 5;
    }

    return array;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

Console.WriteLine("Введите число, определяющее длинну массива");
int length = Convert.ToInt32(Console.ReadLine());

double[] array = new double[length];
array = NewArray(array);
double min = Min(array);
double max = Max(array);

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("max - min = " + (max - min));
