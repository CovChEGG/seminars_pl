// 35. Определить, присутствует ли в заданном массиве, некоторое число 
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
int ReadIntCH(string msg)
{
    int valueInt;
    while (true)
    {
        Console.Write(msg);
        string? valueString = Console.ReadLine();
        if (int.TryParse(valueString, out valueInt)) break;
        else Console.WriteLine("Incorrect input for int, try again...");
    }
    return valueInt;
}
bool NumberExist(int[] arrayOfNumbers, int numberForSearch)
{
    foreach (int item in arrayOfNumbers)
        if (numberForSearch == item) return true;
    return false;

}

int[] arrayOfNumbers = new int[10];
FillAndPrintArray(arrayOfNumbers, 0, 10);
int numberForSearch = ReadIntCH("Input number for search in array: ");
string msg = NumberExist(arrayOfNumbers, numberForSearch) ? "Элемент в массиве" : "Элемент отсутсвтует";
Console.WriteLine(msg);