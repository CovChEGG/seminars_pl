//043 Написать программу преобразования десятичного числа в двоичное
int ReadStringWithCheck4Int(string msg)
{                   
    int valueInt;   
    while (true)
    {
        Console.Write(msg + $": ");
        string? valueString = Console.ReadLine();
        if (int.TryParse(valueString, out valueInt))
        {
            if(valueInt >= 0) break;
        }
        Console.WriteLine("Incorrect input for Dec(int), try again...");
    }
    return valueInt;
}

int[] ToBin(int arg)
{
    int[] result = new int[16];
    for(int i=0; i< result.Length; i++)
    {
        if (arg > 0)
        {
            result[i] += arg%2;
            arg /=2;
        }
        else result[i]=2;
    }
    return result;
}
void PrintBin(int[] array)
{
    for (int i = array.Length-1; i >= 0; i--)
    {
        if(array[i] == 2) continue;
        Console.Write(array[i]);    
    }
    Console.WriteLine();
}

int value = ReadStringWithCheck4Int("Input positive Dec(int) number");
PrintBin(ToBin(value));