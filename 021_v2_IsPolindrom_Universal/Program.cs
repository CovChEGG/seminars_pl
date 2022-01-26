// 21. Программа проверяет введёное число на палиндромом.
DateTime dt;
Console.Clear();
int ReadInt(string msg) // Выводит сообщение переданное на входе, осуществляет ввод корректного числа (с проверкой),
{                       // на выходе возвращает значение в целых числах.
    int valueInt;
    while (true)
    {
        Console.Write(msg);                                      //Вывод полученного текста на экран
        string? valueString = Console.ReadLine();
        dt = DateTime.Now;
        if (valueString != "-0")
            if (int.TryParse(valueString, out valueInt)) break;  //Проверка на число и отправка значения в valueInt
        Console.WriteLine("Incorrect input, try again...");
    }
    return valueInt;
}

bool IsPoly(int valueInt) // Функция проверки на палиндром - принимает число, возвращает true или false,.
{
    string valueString = valueInt.ToString();                   //преобразуем число в строку
    int valueLength = valueString.Length;                       //вычисляем длину строки
    for (int i = 0; i < (valueLength / 2); i++)
    {
        if (valueString[i] == valueString[valueLength - 1 - i]) continue;  //сравниваем элементы начала и конца
        return false;                                           //возвращаем false при первом же не совпадении
    }
    return true;                                                //если все хорошо возвращаем true
}

int valueInt = ReadInt("Palindrome check. Enter the number: ");
if (IsPoly(valueInt))
{
    Console.WriteLine("This is a palindrome");
}
else
{
    Console.WriteLine("Is'nt a palindrome");
}
Console.WriteLine(dt-DateTime.Now);