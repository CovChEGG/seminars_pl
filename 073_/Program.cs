// 73. Написать программу показывающие первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

int EnterInt(string msg) 
{
    int valueInt;
    while (true)
    {
        Console.Write(msg + $": ");
        string? valueString = Console.ReadLine();
        if (int.TryParse(valueString, out valueInt)) break;
        else Console.WriteLine("Incorrect input for int, try again...");
    }
    return valueInt;
}

string StringNumber(int startFirst, int startSecond, int count)
{
    if(count ==0) return string.Empty;
    count--;
    return $"{startFirst} {StringNumber(startSecond)}";
}

int startFirst = EnterInt("Input 1st number: ");
int startSecond = EnterInt("Input 2nd number: ");
string sum = StringNumber(startFirst, startSecond, 5);
Console.WriteLine(sum);
