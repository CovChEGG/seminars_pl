// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillAndPrintArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i =0; i < array.Length; i++)
    {
        array[i]=rnd.Next(min, max);
        Console.Write($"{array[i]} ");
    }

}

(int, int) MinMaxArray(int[] array)
{
    int minNumber = array[0];
    int maxNumber = array[0];
    foreach (int number in array)
    {
        if (number > minNumber) minNumber = number;
        if (number < maxNumber) maxNumber = number;
    }
    return (minNumber, maxNumber);
}

int[] Array = new int [12];
FillAndPrintArray(Array, -9, 9);
(int Min, int Max) = MinMaxArray(Array);
Console.WriteLine($"{min}")