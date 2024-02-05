using System;

class Program
{
    static void Main()
    {
        // Создаем произвольный массив
    int[] array = { 3, 5, 2, 15, 4 };

    Console.WriteLine ("Элементы массива, начиная с конца: ");
    // Вызываем рекурсивну функцию для вывода элементов массива
    PrintArrayReversed (array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            // Выводим текущий элемент
            Console.WriteLine(array[index]);
            // Вызываем рекурсию для следующего элемента
            PrintArrayReversed(array, index - 1);
        }
    }
}