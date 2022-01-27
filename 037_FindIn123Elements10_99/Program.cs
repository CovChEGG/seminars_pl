// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
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
        if (i % 12 == 0) Console.WriteLine();
        Console.Write($"{arrayForPrint[i]}\t");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int CalcQuantityOfElements(int[] arrayForSearchingElements, int fromMinimum, int toMaximum)
{
    int quantity = 0;
    for (int i = 0; i < arrayForSearchingElements.Length; i++)
    {
        if (arrayForSearchingElements[i] >= fromMinimum && arrayForSearchingElements[i] <= toMaximum)
        {
            quantity++;
        }
    }
    return quantity;
}
//------------------------------------------------------------------------------------
Console.Clear();

int lengthOfArray = 123;
int fromMin = 10;
int toMax = 99;

int[] array = new int[lengthOfArray];
array = FillArrayRandom(
                        array,
                        min: 0,
                        max: 100
                       );
PrintArray(array);
int quantity = CalcQuantityOfElements(array, fromMin, toMax);
Console.WriteLine($"Quantity of elements in array from {fromMin} to {toMax} is {quantity}");
