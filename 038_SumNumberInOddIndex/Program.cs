// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int SumOfNumberWithOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) sum += array[i];
    return sum;
}

int[] FillArrayRandom(int[] arrayForFilling, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arrayForFilling.Length; i++)
    {
        arrayForFilling[i] = rnd.Next(min, max);
    }
    return arrayForFilling;
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        int numOfElemForPrintInOneRaw = 12;
        if (i % numOfElemForPrintInOneRaw == 0) Console.WriteLine();
        Console.Write($"{arrayForPrint[i]}\t");
    }
    Console.WriteLine();
    Console.WriteLine();
}
Console.Clear();

int lengthOfArray = 10;

int[] array = new int[lengthOfArray];
array = FillArrayRandom(array, min: 0, max: 100);
PrintArray(array);
int sum = SumOfNumberWithOddIndex(array);
Console.WriteLine($"Sum of elements in array with odd index is {sum}");
