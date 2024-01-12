//int n = 10;
int [] array = { 1, 2, 3, 5, 6, 7, 8, 9, 6, 3 };
int i = 0;
while (i < array.Length)
{
    if (array [i] % 2 == 0)
    {
        Console.Write(array [i]);
    }
    i = i + 1;
}