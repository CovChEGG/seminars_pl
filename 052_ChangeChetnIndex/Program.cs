void PrintArrayInt(int[,] array)
{
    Console.Write($"\t");
    for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{j}\t");
    Console.WriteLine();
    for(int i = 0 ; i< array.GetLength(0); i++)
    {
        Console.Write($"{i}\t");
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

int[,] ChangeElmentWithEvenIndex(int[,] array)
{
    for(int i = 0 ; i< array.GetLength(0); i += 2)
    {
        for(int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i,j] *= array[i,j];
        }
    }
    return array;
}
 

Console.Clear();
var array=CreateArray(5,10,-1,10);
PrintArrayInt(array);
PrintArrayInt(ChangeElmentWithEvenIndex(array));