int[] Array = new int[3];
for (int i = 0; i < Array.Length; i++)
{
    Console.Write("Input number ");
    Console.Write(i + 1);
    Console.Write(": ");
    string valueString = Console.ReadLine();
    int valueInt = int.Parse(valueString);
    Array[i] = valueInt;
}
int max = Array[0];
for (int i = 1; i < Array.Length; i++)
{
    if (Array[i] > max)
    {
        max = Array[i];
    }
}
Console.Write("Maximum namber is: ");
Console.WriteLine(max);