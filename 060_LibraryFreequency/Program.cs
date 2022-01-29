// 060. Составить частотный словарь элементов двумерного массива
// Число 1 встречаетсся 38 раз. Частота 11.38%

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

bool FindEqualElement(int[] array, findElement)
{
    foreach (int currentElement in array)
    {
        if(currentElement == FindDifferentElement; i++);        
    }
}

int[] FindDifferentElement(int[] array)
{
    int[] workArray = new int{array.Length};
    workArray[0] = array[0];
    int countElements = 1;
    for (int i=1; i < array.Length; i++)
    {
        if(!FindEqualElement(workArray, array[i]))
        {
            workArray[countElements] = array[i];
            countElements++;
        }

    }
    return CopyArray(workArray, countElements);
}

int[] CopyArray (int[] array, int countElements)
{
    int[] resultArray = new int[countElements];
    for (int i = 0; i < countElements; i++)
    {
        resultArray=array[i];
    }
    return resultArray;
}

int[] CreateOnedementionArray(int[,] array)
{
    int[] resultArray = new int[array.GetLength(0)*array.GetLength(1)];
    int i = 0;
    foreach (int element in array)
    {
        resultArray[i] = element;
        i++;
    }
}

int array = {0,1,2,3,4,1};
int[] newArray = FindDifferentElement(array);
foreach (int element in newArray)
{
    Console.WriteLine($"{element}\t");
}
Console.WriteLine();
Console.WriteLine();


// int[,] workArray = new int[3,3];
// FillTwoDimentionalArray(workArray, -2, 2);
