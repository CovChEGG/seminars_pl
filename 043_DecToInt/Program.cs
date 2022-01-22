//043 Написать программу преобразования десятичного числа в двоичное
int[] ToBinary(int arg)
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


Console.WriteLine("Input positive number");
string answer = Console.ReadLine() ?? string.Empty;
int value = int.Parse(answer);
PrintBin(ToBinary(value));


// Console.WriteLine("Введите число: "); 
// int number = Convert.ToInt32(Console.ReadLine()); 
 
// string binary = Convert.ToString(number, 2); // конвертируется в двоичное исчисление
// Console.WriteLine($"Перевод десятичного числа {number} в двоичное {binary}");