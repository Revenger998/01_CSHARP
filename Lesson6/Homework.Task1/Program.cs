using System;

class Program
{
    static void Main(string[] args)
{   // Создаем рандомную строку
    string rndText = "goagaog";
    char[] reverseText = rndText.ToCharArray();
    // Используем функцию для разворота текста
    Array.Reverse(reverseText);
    string finalText = new string(reverseText);
    // Сравниваем начальную строку и реверсированную с помощью условной конструкции if/else и выводим на экран ответ
    if (rndText == finalText)
    {
        Console.WriteLine("Данная запись является палиндромом");
    }
    else
    {
        Console.WriteLine("Данная запись не является палиндромом");
    }
}
}