// 34. Написать программу замены элементов массива на противоположные

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
        if (arprint[i] >= 0) Console.Write($" {arprint[i]}\t");
        else Console.Write($"{arprint[i]}\t");
    }
    Console.WriteLine();
}

void ReverseElements(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = -Array[i];
    }
}

Console.Clear();
int[] array = new int[8];
FillArrayRnd(array, -5, 5);
PrintArray(array);
Console.WriteLine();
ReverseElements(array);
PrintArray(array);
Console.WriteLine();