﻿// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[123];
Random random = new Random();
int count = 0;


for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
}


foreach (int num in array)
{
    if (num % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine(count);