// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillAndPrintArray(double[] array, int min, int max)
{
    Random rnd = new Random(DateTime.Now.Millisecond);
    Random rndSign = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 10 *rnd.Next(-1,1);
        Console.Write($"{array[i]:N2} ");
    }
    Console.WriteLine();
}

(double, double) MinMaxArray(double[] array)
{
    double minNumber = array[0];
    double maxNumber = array[0];
    foreach (double number in array)
    {
        if (number < minNumber) minNumber = number;
        if (number > maxNumber) maxNumber = number;
    }
    return (minNumber, maxNumber);
}
Console.Clear();
Console.WriteLine();

double[] Array = new double[12];
FillAndPrintArray(Array, -9, 9);
(double min, double max) = MinMaxArray(Array);
Console.WriteLine($"{max:N2} - {min:N2} = {max - min:N2}");
Console.WriteLine();