using System;

class Program
{
    static void Main()
    {
        // Вводим размер массива с консоли
        Console.Write("Введите размер массива (не более 8): ");
        int N = Convert.ToInt32(Console.ReadLine());

        // Проверяю на допустимость размер массива
        if (N <= 0 || N > 8)
        {
            Console.WriteLine("Неверно задан размер массива. Размер должен быть от 1 до 8.");
            return;
        }

        // Создаю массив и заполняю случайными числами от 0 до 9
        int[] array = new int[N];
        Random randomDigit = new Random();
        for (int i = 0; i < N; i++)
        {
            array[i] = randomDigit.Next(10);
        }

        // Вывожу массив на экран
        Console.Write("Массив: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Формируем целое число из цифр массива с нужным порядком
        int result = 0;
        for (int i = 0; i < N; i++)
        {
            result = result * 10 + array[i];
        }

        // Выводим сформированное число на экран
        Console.WriteLine("Сформированное число: " + result);
    }
}
