using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем двумерный массив символов 4х3  
        char[,] rndArray = new char[4, 3]{
        {'$','6','1'},
        { '5','#','!'},
        { 'k','%','&'},
        { '8','*','@'}};
        // Создаем пустую строку
        string newString = " ";
        // Заполняем строку символами из массива
        for (int i = 0; i < rndArray.GetLength(0); i++)
        {
            for (int j = 0; j < rndArray.GetLength(1); j++)
            {
                newString += rndArray[i, j].ToString();
            }
        }
        Console.WriteLine(newString);
    }
}