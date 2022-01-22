// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить,
// что это невозможно (в случае, если матрица не квадратная).

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

// int[,] ChangeRowsToColumns(int[,] array)
// {
//     int[,] resultArray = new int[array.GetLength(1), array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             resultArray[j, i] = array[i, j];
//         }
//     }
//     return resultArray;
// }
void ChangeRowsToColumns(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Поменять строки со столбцами в этой матрице не возможно");
        Environment.Exit(1);
    }
    int tmp = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            tmp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = tmp;
        }
    }
}

int[,] workingArray = new int[10, 10];
FillTwoDimentionalArray(workingArray, 0, 9);
PrintTwoDimentionalArray(workingArray);

// var result = ChangeRowsToColumns(workingArray);
// PrintTwoDimentionalArray(result);
ChangeRowsToColumns(workingArray);
PrintTwoDimentionalArray(workingArray);