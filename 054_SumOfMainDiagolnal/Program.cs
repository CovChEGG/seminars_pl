// 054. В матрице чисел найти сумму элементов главной диагонали
  
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
    Console.WriteLine(); for (int i = 0; i < array.GetLength(0); i++) { Console.Write($"{i}\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
    }
}