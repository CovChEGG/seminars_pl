// 26. Возведите число А в натуральную степень B используя цикл
int ReadInt(string msg) // Выводит сообщение переданное на входе, осуществляет
{                         // ввод корректного числа (можно и ограничить ввод высотой консоли),
    int valueInt;         // на выходе выдаёт значение в целых числах.
    while (true)
    {
        Console.Write(msg + $": ");
        string? valueString = Console.ReadLine();
        if (int.TryParse(valueString, out valueInt)) break;
        else Console.WriteLine("Incorrect input for int, try again...");
    }
    return valueInt;
}

double a = ReadInt("Input number A");
int b;
while (true) //ввод и проверка на натуральность числа B
{
    b = ReadInt("Input natural number B");
    if (b > 0) break;
    Console.WriteLine("This isn't natural number! Try again");
}
double result = a;
for (int i = 1; i < b; i++) result *= a;
Console.WriteLine($"Result is: {result}");