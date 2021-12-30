// 21. Программа проверяет пятизначное число на палиндромом.

Console.Clear();
int ReadInt(string msg) // Выводит сообщение переданное на входе, осуществляет ввод корректного числа (с проверкой),
{                       // на выходе выдаёт значение в целых числах.
    int valueInt;
    while (true)
    {
        Console.Write(msg);
        string? valueString = Console.ReadLine();
        if (int.TryParse(valueString, out valueInt) && (valueInt > 9999) && (valueInt < 100000)) break;
        else Console.WriteLine("Incorrect input, try again...");
    }
    // try
    // {
    //     valueInt = Convert.ToInt32(valueString);
    //     if ((valueInt < 9999) || (valueInt > 100000)) throw new Exception();
    // }
    // catch (System.Exception)
    // {
    //     Console.WriteLine("Incorrect input");
    //     Environment.Exit(1);
    // }
    return valueInt;
}

bool IsPoly(int valueInt) // Функция проверки на палиндром.
{
    string valueString = valueInt.ToString();
    for (int i = 0; i < 2; i++)
    {
        if (valueString[i] == valueString[4 - i]) continue;
        return false;
    }
    return true;
}

int valueInt = ReadInt("Input 5 digit number: ");
if (IsPoly(valueInt))
{
    Console.WriteLine("This Is a palindrome");
}
else
{
    Console.WriteLine("Is'nt a palindrome");
}
// Модифицировать до выявления полиндрома из любого числа.