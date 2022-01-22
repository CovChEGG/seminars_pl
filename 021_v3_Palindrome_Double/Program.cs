// 21. Программа проверяет введёное число на палиндромом.
Console.Clear();
string Input(string msg) // Выводит сообщение переданное на входе, осуществляет ввод корректного числа (с проверкой),
{                        // на выходе возвращает значение в целых числах.
    double valueDouble;
    string valueStr = string.Empty;
    while (true)
    {
        Console.Write(msg);                                      //Вывод полученного текста на экран
        string? valueString = Console.ReadLine();
        if (double.TryParse(valueString, out valueDouble))
        {
            valueStr = valueDouble.ToString();
            break;      //Проверка на число и отправка значения в valueInt
        }
        Console.WriteLine(valueStr);
        Console.WriteLine("Incorrect input, try again...");
    }
    return valueStr;
}
bool IsPoly(string valueString) // Функция проверки на палиндром - принимает число, возвращает true или false,.
{
    int valueStringLength = valueString.Length;                       //вычисляем длину строки
    for (int i = 0; i < (valueStringLength / 2); i++)
    {
        if (valueString[i] == valueString[valueStringLength - 1 - i]) continue;  //сравниваем элементы начала и конца
        return false;                                           //возвращаем false при первом же не совпадении
    }
    return true;                                                //если все совпдает возвращаем true
}

string numberStr = Input("Palindrome check. Enter the number: ");
if (IsPoly(numberStr)) Console.WriteLine("This is a palindrome");
else Console.WriteLine("Is'nt a palindrome");