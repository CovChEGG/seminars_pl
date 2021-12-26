// Показать числа от -N до N

Console.Write("Input number N: ");
string valueString = Console.ReadLine() ?? "";
Console.WriteLine();
int valueInt = int.Parse(valueString);
int i = -valueInt;
while (i <= valueInt )
{
    Console.Write(i);
    Console.Write(" ");
    i++;
}
Console.WriteLine();