// 31. Задать массив из 8 элементов и вывести их на экран 

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
}

int[] array = new int[8];
FillArrayRnd(array,0,1234);
PrintArray(array);
Console.WriteLine();