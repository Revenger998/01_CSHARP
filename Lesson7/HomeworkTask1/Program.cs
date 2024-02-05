using System;

class Program
{
    static void Main()
    {
        // Вводим значения M и N
        int M = 5;
        int N = 10;

        // Вызываем функцию для вывода чисел от M до N
        PrintNumbersBetween(M, N);
    }

    static void PrintNumbersBetween(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbersBetween(m + 1, n);
        }
    }
}