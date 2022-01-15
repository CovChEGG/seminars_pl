// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void FillAndPrintArray(int[] array, int Min, int Max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(Min, Max + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

(int, int) Quantity(int[] array)
{
    int even = 0, odd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) even++;
        else odd++;
    }
    return (even, odd);
}
int[] array = new int[10];
FillAndPrintArray(array, 100, 999);
(int even, int odd) = Quantity(array);
Console.WriteLine($"Even numbers {even}, Odd numbers {odd}");