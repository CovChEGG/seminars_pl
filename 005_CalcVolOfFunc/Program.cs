// Написать программу вычисления значения функции y = f(a)

int Function(int x)
{
    int y = x * x + 3;
    return y;
};

Console.Clear();
Console.WriteLine("Вычисления значения функции y = f(a)");
Console.Write("Введите аргумент функции: ");
string argumentString = Console.ReadLine() ?? "";
int argumentInt = int.Parse(argumentString);
Console.WriteLine(Function(argumentInt));
