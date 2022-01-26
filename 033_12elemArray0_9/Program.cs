// 33. Задать массив из 12 элементов, заполненных числами из [-9,9].
// Найти сумму положительных/отрицательных элементов массива

void FillArrayRnd(int[] arrand, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arrand.Length; i++)
    {
        arrand[i] = rnd.Next(min, max);
    }
}
void PrintArray(int[] arprint)
{
    for (int i = 0; i < arprint.Length; i++)
    {
        Console.Write($"{arprint[i]} ");
    }
    Console.WriteLine();
}
(int, int) SumOfPositiveAndNegativeElements(int[] array)
{
    int SumOfNegative = 0, SumOfPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) SumOfNegative += array[i];
        else SumOfPositive += array[i];
    }
    return (SumOfPositive, SumOfNegative);
}
//------^^^^ functions ^^^^------

int[] array = new int[12];
FillArrayRnd(array, -9, 9);
PrintArray(array);
(int sop, int son) = SumOfPositiveAndNegativeElements (array);
Console.WriteLine($"Sum Of Positive Numbers is {1}, Sum Of Negative Numbers is {2}", sop, son);
