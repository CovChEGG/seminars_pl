// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива
void FillArrayRnd(int[] arrand, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arrand.Length; i++)
    {
        arrand[i] = rnd.Next(0, 999);
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
(int, int) SumOfPosNeg(int[] arsum)
{
    int SumOfNegative = 0, SumOfPositive = 0;
    for (int i = 0; i < arsum.Length; i++)
    {
        if (arsum[i] < 0) SumOfNegative += arsum[i];
        else SumOfPositive += arsum[i];
    }
    return (SumOfPositive, SumOfNegative);
}
//------^^^ functions ^^^^------

int[] array = new int[12];
FillArrayRnd(array, -100, 9);
PrintArray(array);
(int sop, int son) = SumOfPosNeg (array);
Console.WriteLine($"Sum Of Positive Numbers is {1}, Sum Of Negative Numbers is {2}", sop, son);
