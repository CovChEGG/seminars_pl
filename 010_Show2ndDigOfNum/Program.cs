// 10. Показать вторую цифру трёхзначного числа
Console.Clear();
int ReadInt(string msg) // Выводит сообщение переданное на входе, 
{                       // проверяет ввод числа на корректность (с проверкой),
    int valueInt;       // на выходе выдаёт значение в целых числах.
    while (true)
    {
        Console.Write(msg);
        string? valueString = Console.ReadLine();
        if (int.TryParse(valueString, out valueInt) 
            && (valueInt > 99)
            && (valueInt < 1000))
            break;
        else Console.WriteLine("Incorrect input, try again...");
    }
    return valueInt;
}

void ShowSecondDigital(int intNumber)
{
    string stringNumber = Convert.ToString(intNumber);
    Console.WriteLine($"Second digit is: {stringNumber[1]}");
}

int number = ReadInt("Input 3 digit number: ");
ShowSecondDigital(number);
