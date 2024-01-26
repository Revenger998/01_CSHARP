using System;

class Program
{
    // Используем метод ReverseWords с помощью которого разворачиваем строку, меняя порядок слов на обратный
    static string ReverseWords(string str)
    {
        // Получаем слова из строки, разделенные пробелами
        string[] words = str.Split(' ');
        // Разворачиваем порядок слов
        Array.Reverse(words);
        // Объединяем слова в строку, разделяя их пробелами
        return string.Join(" ", words);
    }

    static void Main(string[] args)
    {   // Создаем строку со словами разделенными пробелами
        string strOfWordsBySpaces = "String of words by spaces";
        // Вызываем метод ReverseWords для разворота строки
        string finalString = ReverseWords(strOfWordsBySpaces);
        Console.WriteLine(finalString);
    }
}