// 28. Подсчитать сумму цифр в числе
int SumOfDigits(string msg)             // Выводит сообщение переданное на входе, осуществляет
{                                       // проверку корректности ввод числа,
    string valueString = string.Empty;  // на выходе выдаёт сумму элементов
    double value;
    int index, sum = 0;
    while (true)
    {
        Console.Write(msg + $": ");
        valueString = Console.ReadLine() ?? "";
        if (double.TryParse(valueString, out value)) break;
        else Console.WriteLine("Incorrect input, try again...");
    }
    if (value == 0) return 0;
    if (value < 0) index = 1; //пропускаем знак минуса в строке
    else index = 0;
    for (; index < valueString.Length; index++) sum += valueString[index]-'0';
    return sum;
}
Console.Clear();
Console.WriteLine($"Sum of digits is: {SumOfDigits("Input Number")}");