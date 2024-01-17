using System;

class Program
{
    static void Main()
    {
        // Пример исходного массива
        int[] array = { 5, 2, 3, 1, 7 };

        // Переворачиваем массив
        ReverseArray(array);

        // Выводим результат
        Console.WriteLine("Перевернутый массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }

        Console.ReadLine();
    }

    static void ReverseArray(int[] arr)
    {
        int length = arr.Length;
        for (int i = 0; i < length / 2; i++)
        {
            // Меняем местами элементы от начала и конца массива
            int temp = arr[i];
            arr[i] = arr[length - i - 1];
            arr[length - i - 1] = temp;
        }
    }
}