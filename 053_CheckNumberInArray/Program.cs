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

(int, int) FindElement(int[,] array, int searchNum)
{
    for(int i = 0 ; i< array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]== searchNum) return (i,j);
        }
    }
    return (-1,-1);
}
 

Console.Clear();
var array=CreateArray(5,10,1,10);
PrintArrayInt(array);
(int i, int j) = FindElement(array, 5);
if(i<0) Console.WriteLine("Not found!");
else Console.WriteLine($"Row index: {i}, Column index: {j}");
