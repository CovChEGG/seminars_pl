// 48. Показать двумерный массив размером m×n заполненный целыми числами

void PrintArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:N2}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


double[,] CreateArray(int qntRows, int qntColumns, double min, double max)
{
    var array = new double[qntRows, qntColumns];
    Random rnd = new Random();
    for (int i = 0; i < qntRows; i++)
    {
        for (int j = 0; j < qntColumns; j++)
        {
            array[i, j] = min + rnd.NextDouble() * (max - min);
        }
    }
    return array;
}

Console.Clear();
PrintArrayDouble(CreateArray(5, 10, -100, 100));