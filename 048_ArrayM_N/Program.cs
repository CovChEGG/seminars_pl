// 48. Показать двумерный массив размером m×n заполненный целыми числами

void PrintArrayInt(int[,] array)
{
    for(int i = 0 ; i< array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
} 


int[,] CreateArray(int qntRows, int qntColumns, int min, int max)
{
    int[,] array= new int[qntRows, qntColumns];
    Random rnd=new Random();
    for(int i = 0 ; i< qntRows; i++)
    {
        for(int j = 0; j < qntColumns; j++)
        {
            array[i,j]=rnd.Next(min, max);
        }
    }
    return array;
}

Console.Clear();
PrintArrayInt(CreateArray(5,10,-100,100));