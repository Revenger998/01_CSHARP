using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 10 случайных трехзначных чисел
        int[] array = GenerateRandomArray(10, 100, 999);

        // Выводим массив
        Console.WriteLine("Массив:");
        PrintArray(array);

        // Подсчитываем количество четных чисел
        int evenCount = CountEvenNumbers(array);

        // Выводим результат
        Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");

        // Ждем нажатия клавиши перед закрытием консоли
        Console.ReadKey();
    }

    // Метод для генерации массива случайных трехзначных чисел
    static int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }

        return array;
    }

    // Метод для вывода массива на консоль
    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    // Метод для подсчета количества четных чисел в массиве
    static int CountEvenNumbers(int[] array)
    {
        int evenCount = 0;

        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        return evenCount;
    }
}