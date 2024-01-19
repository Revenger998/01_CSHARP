voit PrintTable (int [,] table)
{
    Console.WriteLine ();
}
Console.WriteLine ();

int[,] matrix =
{
    {1,2,3,9},
    {4,5,6,10},
    {7,8,9,8}
};

ReplaceElemBySquares(matrix)

void ReplaceElemsSquares(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(0); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                table[i, j] *= table[i, j];
            }
        }
    }
}