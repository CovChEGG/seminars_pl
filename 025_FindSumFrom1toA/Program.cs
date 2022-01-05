// 25. Найти сумму чисел от 1 до А
// n * (n + 1) / 2 - сумма ряда чисел от 1 до N
int ReadInt(string msg) // Выводит сообщение переданное на входе, осуществляет
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
//-------------------------------------------------------------------------------
Console.Clear();
double sum = ReadInt("For Summary of numbers from 1 to A, input A: ");
sum = sum * (sum + 1) / 2;
Console.WriteLine($"Summary is {sum}");