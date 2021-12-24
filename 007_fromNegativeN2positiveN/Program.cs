Console.Write("Input number N: ");
string valueString = Console.ReadLine();
Console.WriteLine();
int valueInt = int.Parse(valueString);
int i = -1 * valueInt;
while (i <= valueInt )
{
    Console.Write(i);
    Console.Write(" ");
    i++;
}
Console.WriteLine();