//По заданному номеру дня недели вывести его название

Console.WriteLine("Input the number of the day of the week =>");
string valueString = Console.ReadLine() ?? "";
int valueInt = int.Parse(valueString);
if ((0 < valueInt) & (valueInt < 8))
{
    if (valueInt == 1)
        Console.WriteLine("Monday");
    if (valueInt == 2)
        Console.WriteLine("Tuesday");
    if (valueInt == 3)
        Console.WriteLine("Wednesday");
    if (valueInt == 4)
        Console.WriteLine("Thursday");
    if (valueInt == 5)
        Console.WriteLine("Friday");
    if (valueInt == 6)
        Console.WriteLine("Saturday");
    if (valueInt == 7)
        Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Incorrect input!!!");
}