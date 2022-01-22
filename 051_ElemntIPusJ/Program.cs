// Найти четные элементы и меняем на противоположные

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


int[,] CreateArray(int qntRows, int qntColumns)
{
    int[,] array= new int[qntRows, qntColumns];
    for(int i = 0 ; i< qntRows; i++)
    {
        for(int j = 0; j < qntColumns; j++)
        {
            array[i,j]=i+j;
        }
    }
    return array;
}

Console.Clear();
var array=CreateArray(10,10);
PrintArrayInt(array);