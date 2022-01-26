//Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите число:");
string stringNumber1 = Console.ReadLine() ?? "";
int Number1;
if (!int.TryParse(stringNumber1, out Number1))
{
    Console.WriteLine("Неправильный ввод первого числа!!!");
    Environment.Exit(1);
}

Console.WriteLine("Введите число для проверки кратности:");
string stringNumber2 = Console.ReadLine() ?? string.Empty;
if (!int.TryParse(stringNumber2, out int Number2))
{
    Console.WriteLine("Неправильный ввод вторго числа!!!");
    Environment.Exit(1);
}

int ostatok = Number1 % Number2;
if (ostatok == 0)
{
    Console.WriteLine("Перове число картно второму");
}
else
{
    Console.WriteLine($"Остаток равен: {ostatok}");
}
