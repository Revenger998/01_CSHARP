using System;

class Program
{
    static bool IsEvenSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum % 2 == 0;
    }

    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для завершения: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (int.TryParse(userInput, out int num))
            {
                if (IsEvenSum(num))
                {
                    Console.WriteLine($"Сумма цифр числа {num} чётная. Программа завершена.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Сумма цифр числа {num} нечётная.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введите целое число или 'q' для завершения.");
            }
        }
    }
}