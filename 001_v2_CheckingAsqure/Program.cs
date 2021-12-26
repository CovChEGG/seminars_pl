Console.WriteLine("Введите первое число =>");
string valueString1 = Console.ReadLine() ?? "";
int valueInt1 = int.Parse(valueString1);
Console.WriteLine("Введите второе число =>");
string valueString2 = Console.ReadLine() ?? "";
int valueInt2 = int.Parse(valueString2);
if (valueInt2 * valueInt2 == valueInt1)
{
    Console.Write("Первое число является квадратом второго числа");
}
else
{
        if (valueInt1*valueInt1==valueInt2)
        {
            Console.Write("Второе число является квадратом первого числа");
        }
        else
        {
            Console.Write("Числа не являются квадратами друг друга");
        }
}