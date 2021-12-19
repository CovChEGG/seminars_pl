Console.WriteLine("Введите первое число =>");
string valueString1 = Console.ReadLine();
int valueInt1 = int.Parse(valueString1);
Console.WriteLine("Введите второе число =>");
string valueString2 = Console.ReadLine();
int valueInt2 = int.Parse(valueString2);
if (valueInt1 > valueInt2)
{
    Console.Write("Большее число ");
    Console.WriteLine(valueInt1);
    Console.Write("Меншее число ");
    Console.WriteLine(valueInt2);
}
else
{
    if (valueInt1 < valueInt2)
    {
        Console.Write("Большее число ");
        Console.WriteLine(valueInt2);
        Console.Write("Меншее число ");
        Console.WriteLine(valueInt1);

    }
    else
    {
        Console.Write("Числа равны");
    }
}