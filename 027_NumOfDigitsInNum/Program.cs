// 27. Определить количество цифр в числе
int CountDigits(string msg) // Выводит сообщение переданное на входе, осуществляет
{                           // проверку корректности числа,
    string valueString=string.Empty;  // на выходе выдаёт количество элементов
    double value;         
    while (true)
    {
        Console.Write(msg + $": ");
        valueString = Console.ReadLine() ?? "";
        if (double.TryParse(valueString, out value)) break;
        else Console.WriteLine("Incorrect input for int, try again...");
    }

    if(value == 0) return 1;
    if(value < 0) return (valueString.Length-1);
    return valueString.Length;
}
Console.Clear();
Console.WriteLine($"Number of digits is: {CountDigits("Input Number")}");