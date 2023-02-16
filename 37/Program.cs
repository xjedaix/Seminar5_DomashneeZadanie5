// Доп
// Задача 37:Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6]-> 36 21


class Program
{
    static int[] PairwiseProduct(int[] arr)
    {
        int n = arr.Length;
        int[] result = new int[n / 2];
        for (int i = 0; i < n / 2; i++)
        {
            int product = arr[i] * arr[n - i - 1];
            result[i] = product;
        }
        return result;
    }

    static void Main()
    {
        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] result1 = PairwiseProduct(arr1);
        Console.WriteLine(string.Join(" ", result1));  // 5 8 3

        int[] arr2 = { 6, 7, 3, 6 };
        int[] result2 = PairwiseProduct(arr2);
        Console.WriteLine(string.Join(" ", result2));  // 36 21
    }
}