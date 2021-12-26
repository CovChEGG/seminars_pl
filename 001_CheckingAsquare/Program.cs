// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите квадрат числа =>");
string valueString1 = Console.ReadLine() ?? "";
int valueInt1 = int.Parse(valueString1);
Console.WriteLine("Введите само число =>");
string valueString2 = Console.ReadLine() ?? "";
int valueInt2 = int.Parse(valueString2);
if (valueInt2 * valueInt2 == valueInt1)
{
    Console.Write("Квадрат числа соответствует самому числу");
}
else
{
    Console.Write("Первое введеное число не является квадратом второго");
}