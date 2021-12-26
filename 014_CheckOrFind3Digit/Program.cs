// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите любое целое число: ");
string StringNumber = Console.ReadLine() ?? "";
int Length = 0;
try
{
    Convert.ToInt32(StringNumber);
    string Temp = StringNumber ?? "";
    Length = StringNumber.Length;
    if (Length > 2)
    {
        Console.WriteLine("Третья цифра: " + Temp[Length - 3]);
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
