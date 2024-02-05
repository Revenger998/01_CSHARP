using System;

class Program
{
    static void Main()
    {
        int m = 2;
        int n = 3;
        // Вызываем функцию Аккермана с заданными значениями m и n
        int result = AckerFunction(m, n);

        Console.WriteLine($"AckerFunction({m}, {n}) = {result}");
    }
    // Используем рекурсию для вычисления функции Аккермана
    static int AckerFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckerFunction(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return AckerFunction(m - 1, AckerFunction(m, n - 1));
        }

        return 0; // Возвращаемое значение, если условия не выполнены
    }
}