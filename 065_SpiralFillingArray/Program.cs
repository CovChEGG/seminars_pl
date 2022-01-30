// 65. Спирально заполнить двумерный массив:
int[,] array = new int[4, 4];
int currentElement = 1;

SpiralFillArray(array);
PrintTwoDimentionalArray(array);

void PrintTwoDimentionalArray(int[,] array)
{
    Console.Write("\t"); for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{j}\t");
    Console.WriteLine(); for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{i}\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillToRight(int[,] array, int index, int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        array[index, i] = currentElement++;
    }
}

void FillToDown(int[,] array, int index, int start, int end)
{

    for (int i = start; i <= end; i++)
    {
        array[i, index] = currentElement++;
    }
}

void FillToLeft(int[,] array, int index, int start, int end)
{
    for (int i = start; i >= end; i--)
    {
        array[index, i] = currentElement++;
    }
}

void FillToUp(int[,] array, int index, int start, int end)
{

    for (int i = start; i >= end; i--)
    {
        array[i, index] = currentElement++;
    }
}

void SpiralFillArray(int[,] array)
{
    int startRowIndex = 0;
    int endRowIndex = array.GetLength(1) - 1;
    int startColumnIndex = 0;
    int endColumnIndex = array.GetLength(0) - 1;
    int curColumnIndex = endColumnIndex;
    while(currentElement<array.GetLength(0)*array.GetLength(1))
    {
        FillToRight(array, startRowIndex, startColumnIndex, endColumnIndex);
        startRowIndex++;
        FillToDown(array, endColumnIndex, startRowIndex, endRowIndex);
        endColumnIndex--;
        FillToLeft(array, endRowIndex, endColumnIndex, startColumnIndex);
        endRowIndex--;
        FillToUp(array, startColumnIndex, endRowIndex, startRowIndex);
        startColumnIndex++;
    }
}