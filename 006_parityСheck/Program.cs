Console.Clear();
Console.Write("Введите проверяемое на чётность число: ");
string valuetString = Console.ReadLine() ?? "";
int valueInt = int.Parse(valuetString);
if ((valueInt % 2) != 0)
{
    Console.WriteLine("Введеное число является НЕЧЁТНЫМ");
}
else
{
    Console.WriteLine("Введеное число является ЧЁТНЫМ");
}
