int value = ReadIntFromConsole ("Введите целое число: ");
Console.WriteLine($"Модуль числа = {Absolute(value)}");

int ReadIntFromConsole(string prompt)
{
    Console.WriteLine(prompt);
    string answer = Console.ReadLine() ?? "";
    return Convert.ToInt32(answer);
}


int Absolute(int argument)
{
    if (argument >= 0)
    {
        return argument;
    }
    else
    {
        return -argument;
    }
}