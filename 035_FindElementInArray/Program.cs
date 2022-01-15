// 35. Определить, присутствует ли в заданном массиве, некоторое число 
void FillAndPrintArray(int[] array, int Min, int Max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(Min, Max + 1);
        Console.Write($"{array[i]} ");
    }
}
int ReadIntCH(string msg) // Выводит сообщение переданное на входе, осуществляет
{                         // ввод корректного числа (можно и ограничить ввод высотой консоли),
    int valueInt;         // на выходе выдаёт значение в целых числах.
    while (true)
    {
        Console.Write(msg);
        string? valueString = Console.ReadLine();
        if (int.TryParse(valueString, out valueInt)) break;
        else Console.WriteLine("Incorrect input for int, try again...");
    }
    return valueInt;
}
bool NumberExist(int[] array, int N)
{
    foreach (int item in array)
        if (N == item) return true;
    return false;

}

int[] array = new int[10];

FillAndPrintArray(array, 0, 10);
int answer = ReadIntCH("Input numer for search in array: ");
string msg=NumberExist(array, answer) ? "Элемент в массиве": "Элемент отсутсвтует";
if (NumberExist(array, answer)) Console.WriteLine(msg);