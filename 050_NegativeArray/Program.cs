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

int[,] ChangeEvenNumbersToOpposite(int[,] array)
{
    for(int i = 0 ; i< array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]%2==0) array[i,j] *=-1;
        }
    }
    return array;
}
 

Console.Clear();
var array=CreateArray(5,10,-100,100);
PrintArrayInt(array);
PrintArrayInt(ChangeEvenNumbersToOpposite(array));