using System;

class Program
{
    static void Main()
    {
        // Ввод размера массива с консоли
        Console.Write("Введите размер массива (не более 8): ");
        int N = Convert.ToInt32(Console.ReadLine());

        // Проверка на допустимость размера массива
        if (N <= 0 || N > 8)
        {
            Console.WriteLine("Недопустимый размер массива. Размер должен быть от 1 до 8.");
            return;
        }

        // Создание массива и заполнение случайными числами от 0 до 9
        int[] array = new int[N];
        Random random = new Random();
        for (int i = 0; i < N; i++)
        {
            array[i] = random.Next(10);
        }

        // Вывод массива
        Console.Write("Массив: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Сортировка массива в порядке убывания
        Array.Sort(array);
        Array.Reverse(array);

        // Сформировать целое число из отсортированных цифр массива
        int result = 0;
        for (int i = 0; i < N; i++)
        {
            result = result * 10 + array[i];
        }

        // Вывести сформированное число
        Console.WriteLine("Сформированное число: " + result);
    }
}