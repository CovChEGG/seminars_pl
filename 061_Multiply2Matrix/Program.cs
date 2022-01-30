
void PrintArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:N0}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


double[,] CreateArray(int qntRows, int qntColumns, int min, int max)
{
    var array = new double[qntRows, qntColumns];
    Random rnd = new Random();
    for (int i = 0; i < qntRows; i++)
    {
        for (int j = 0; j < qntColumns; j++)
        {
            array[i, j] = rnd.Next(min, max);
        }
    }
    return array;
}

double[,] Multiply2Matrix(double[,] matrix1, double[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Size of matrix incorrect");
        Environment.Exit(1);
    }
    double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {

        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}


var matrix1 = CreateArray(3, 2, 1, 5);
var matrix2 = CreateArray(2, 3, 1, 5);
PrintArrayDouble(matrix1);
PrintArrayDouble(matrix2);


PrintArrayDouble(Multiply2Matrix(matrix1, matrix2));

