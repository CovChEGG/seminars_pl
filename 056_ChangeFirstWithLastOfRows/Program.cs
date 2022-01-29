// замена первой и последней сторки массива

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
}

void ChangeFirstLastRows(int[,] array)
{
    int lastIndexOfRows = array.GetLength(0) - 1;
    int tmp=0;
    for (int j; j < array.GetLength(1); j++ )
    {
        temp = array [0,j];
        array[0,j] = array[lastIndexOfRows, j];
        array[lastIndexOfRows,j] = tmp
    }
}

int[,] workingArray = new int[4,4];
FillTwoDimentionsalArray

// foreach (double i in resultArray)
// {
//     Console.Write($" {i:N2})   
// }