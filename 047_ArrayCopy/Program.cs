// 

void PrintArrayInt(int[] arrayStr)
{
    foreach (var item in arrayStr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
} 


int[] CreateArray(int number, int min, int max)
{
    int[] array= new int[number];
    Random rnd=new Random();
    for(int i = 0 ; i< number; i++)
    {
        array[i]=rnd.Next(min, max);
    }
    return array;
}

int[] CopyArray (int[] array)
{
    int[] resultArray= new int[array.Length];
    for(int i=0 ; i< array.Length; i++ )
    {
        resultArray[i]=array[i];
    }
    return resultArray;
}

Console.Clear();
int[] array1=CreateArray(10, 1, 100);
PrintArrayInt(array1);
PrintArrayInt(CopyArray(array1));


