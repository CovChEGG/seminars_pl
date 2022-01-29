void FillTwoDimentionalArray(int[,] array, int minNumber, int maxNumber)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minNumber, maxNumber + 1);
        }
    }
}

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

void SortingRows(int[,] array, int rowIndex)
{
    int lastIndexOfRows = array.GetLength(0) - 1;
    int tmp = 0;
    for (int j; j < array.GetLength(1); j++)
    {
        for (k = 0; k < array.GetLength(1) - 1 - j; k++)
        {
            if (array[rowIndex, k] < array[rowIndex, k + 1]) ;
            {
                int tmp = array[rowIndex, k];
                array[rowIndex, k] = array[rowIndex, k + 1];
                array[rowIndex, k + 1] = tmp;
            }
        }

    }
}

void SortingArrayOfRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortingRows(array, i);
    }
}


int[,] workingArray = new int[4, 4];
FillTwoDimentionalArray(workingArray, 0, 9);
PrintTwoDimentionalArray(workingArray);

SortingSortingArrayOfRows(workingArray);
PrintTwoDimentionalArray(workingArray);