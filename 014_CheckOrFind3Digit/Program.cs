// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите любое целое число: ");
string StringNumber = Console.ReadLine() ?? string.Empty;
// int Length = 0;
try
{
    Convert.ToInt32(StringNumber); // для того чтобы сработал try-catch вызвав остановку
                                   // при наборе текста
    string Temp = StringNumber ?? "";
    if (Temp.Length > 2)
    {
        Console.WriteLine("Третья цифра: " + Temp[Temp.Length - 3]);
    }
    else
    {
        Console.WriteLine("Третьей цифры в числе нет!");
    }
}
catch (System.Exception)
{
    Console.WriteLine("Неверный ввод!");
}
