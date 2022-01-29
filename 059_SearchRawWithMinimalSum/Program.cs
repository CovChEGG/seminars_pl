
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
void PrintArrayInt(int[] arrayStr)
{
    foreach (var item in arrayStr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
} 

int FindRowSum(int[,] array, int rowIndex)
{

}

int FindMinRowSum(int[,] array)
{
    int minRowIndex = 0;
    int minSum = FindRowSum(array,0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int currentSum = FindRowSum(array, i);
        if (currentSum < minSum)
        {
            minSum=currentSum;
            minRowIndex = i;
        } 
    }
    return minRowIndex
}

int[,] workArray = new int[4,6];
FillTwoDimentionalArray(workArray, -2, 2);
int minRowIndex = FindMinRowSum(workArray);
PrintArrayInt(workArray);
Console.Wr 