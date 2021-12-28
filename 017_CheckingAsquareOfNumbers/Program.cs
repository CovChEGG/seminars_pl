// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();
int ReadInt(string msg)
{
    Console.Write(msg);
    string? valueString = Console.ReadLine();
    int valueInt = Convert.ToInt32(valueString);
    return valueInt;
}

int valueInt1 = ReadInt("Input number 1: ");
int valueInt2 = ReadInt("Input number 2: ");

if (valueInt2 * valueInt2 == valueInt1)
{
    Console.Write("Первое число является квадратом второго числа");
}
else
{
    if (valueInt1 * valueInt1 == valueInt2)
    {
        Console.Write("Второе число является квадратом первого числа");
    }
    else
    {
        Console.Write("Числа не являются квадратами друг друга");
    }
}