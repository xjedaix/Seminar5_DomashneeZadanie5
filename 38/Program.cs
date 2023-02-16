// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = { 3.0, 7.0, 22.0, 2.0, 78.0 };
double min = array[0];
double max = array[0];

foreach (double num in array)
{
    if (num < min)
    {
        min = num;
    }
    if (num > max)
    {
        max = num;
    }
}

double diff = max - min;
Console.WriteLine(diff);